using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using System.IO.Ports;
using System.Data.SqlClient;

namespace media_player_with_remote_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        string[] fileWays; //müziklerin soya yollarını tutacak olan dizi
        string [] fileNames; //müziklerin isimlerini tutacak olan dizi
        string[] fileNumbers; //rastgele müzik çalınmasını sağlamak için olan dizi
        string[] portList; //portların listeleneceği dizi
        bool play_media = false; // herhangi bir şarkının çalıp çalmadığını kontrol edecek bit
        double lastMinute; // şarkı durdurulduğunda şarkının kesildiği dakikayı tutan değişken
        int muteCount = 0; // sessize alma tuşunun 2 işlevini de yerine getirebilmesi için olan değişken
        int remoteCount = 0; // kumanndanın bir tuşunun 2 işlevini de yerine getirebilmesi için olan değişken
        int mixedCount = 0;
        int hour = 0, minute=0, second = 0;
        bool timer = false;
        string readedData; // port tarafından okunan verinin tutlduğu değişken

        void listPorts()
        {
            comboBox1.Items.Clear();
            portList = SerialPort.GetPortNames();
            foreach (string portName in portList) { comboBox1.Items.Add(portName.ToString()); } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // hangi klasörün içine bakacağını belirtiyoruz
            DirectoryInfo folder = new DirectoryInfo(@"C:\Users\iosca\Projelerim\C#-ARDUINO\media player with remote control\Songs"); 
            if (folder.Exists) // eğer klasöre ulaşabiliyorsak
            {
                FileInfo[] files = folder.GetFiles("*.mp3", SearchOption.AllDirectories); // mp3 uzantılı bütün dosyaları 'files' dizisine atıyoruz
                fileWays = new string[files.Length]; // yukarıda belirlediğimiz dizilerin boyutlarını dosya sayısına göre belirliyoruz
                fileNames = new string[files.Length]; 

                for (int i = 0; i < files.Length; i++) // listbox1 e bütün şarkıların isimlerini listbox 2 ye ise bütün şarkıların dosya yollarını ekliyoruz
                {
                    listBox1.Items.Add(i + 1 + " : " + files[i].Name);
                    fileNames[i] = files[i].Name.ToString();
                    listBox2.Items.Add(i + 1 + " : " + files[i].FullName);
                    fileWays[i] = files[i].FullName.ToString();
                }
            }
            else { MessageBox.Show("Müziklerin olduğu klasöre erişilemiyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            btnCancenTimer.Enabled = false;
            trackBar1.Minimum = 5;
            trackBar1.Maximum = 150;
            listPorts();
            play("normal");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (fileNames.Length > 0) // eğer kolasörde müzik varsa
            {
                play_media = true;
                axWindowsMediaPlayer1.Ctlcontrols.play(); // mdeia player başlat
                btnPlay.Enabled = false;
                btnStop.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            play_media = false;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            lastMinute = axWindowsMediaPlayer1.Ctlcontrols.currentPosition; // minute değişkenine müzikte kalınan en son süreyi ata
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = lastMinute; // ve orda kal
            btnPlay.Enabled = true;
            btnStop.Enabled = false;
        }

        private void play(string playMode)
        {
            listBox1.Items.Clear(); // iki listeyi de temizliyoruz
            listBox2.Items.Clear();
            play_media = true; // medya oynatması true değeri alır

            if (playMode == "normal") // eğer normal modda oşarkı oynatılmak isteniyorsa
            {
                var normalList = axWindowsMediaPlayer1.playlistCollection.newPlaylist("Sıralı liste"); // sıralı liste adında yeni bir playlist oluşturuyoruz

                for (int i=0;i<fileNames.Length;i++)
                {
                    var mediaItem = axWindowsMediaPlayer1.newMedia(fileWays[i].ToString()); // sırasıyla şarkıların tutulduğu dosya yolu alınıyor
                    normalList.appendItem(mediaItem); // şarkı listesine ekleniyor
                    listBox1.Items.Add(fileNames[i].ToString()); // şarkı adı listbox1 e keleniyor
                    listBox2.Items.Add(fileWays[i].ToString()); // dosya yolları listbox2 ye ekleniyor
                }

                axWindowsMediaPlayer1.currentPlaylist = normalList; //çalınacak olan şarkı listesi değiştiriliyor
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }  
            else if (playMode == "mixed")
            {
                if(fileNames.Length > 5) // eğer 5 den fazla müzik varsa
                {
                    fileNumbers = new string[fileNames.Length]; // müzik sayıları listesine dizi boyutu atadık
                    Random rnd = new Random();

                    for (int i = 0; i < fileNames.Length; i++)
                    {
                        int number;

                        do
                        {
                            number = rnd.Next(0, fileNames.Length); // 0 ile şarkı sayısı arasında rastgele bir sayı ürettik

                            if (!fileNumbers.Contains(number.ToString())) { fileNumbers[i] = number.ToString(); } //contains içermek demek
                            // bu sayıyı müzik numaraları dizisine ekledik ve eğer bu gelen rastgele sayı daha önce müzik numaraları sayısına eklenmemişse  yani kendini tekrarlamamışsa playliste ekleniyor
                            // ve böylece aynı şarkıların birden fazla karışık listesine eklenmesi önleniyor
                        }
                        while (fileNumbers[i] != number.ToString()); // bütün şarkılar eklenip artık eklenen numaralardan biri denk gelene kadar kadar bu işlemi yapacak
                    }

                    var mixedList = axWindowsMediaPlayer1.playlistCollection.newPlaylist("Karışık liste"); // playlist adı verdik

                    for (int i = 0; i < fileNames.Length; i++)
                    {
                        var mediaItem = axWindowsMediaPlayer1.newMedia(fileWays[int.Parse(fileNumbers[i])].ToString()); // önceden belirlenen karışık numaralara göre o şarkılanır dosya yolları alınıyor
                        mixedList.appendItem(mediaItem); // listeye ekleniyor
                        listBox1.Items.Add(i + 1 + " : " + fileNames[int.Parse(fileNumbers[i])]);  // şarkının adı listbox1 e ekleniyor
                        listBox2.Items.Add(fileWays[int.Parse(fileNumbers[i])].ToString()); // şarkıların dosya yolları listbox2 ye ekleniyor
                    }

                    axWindowsMediaPlayer1.currentPlaylist = mixedList; // ve karışık liste çalınmaya başlıyor
                }
                else { MessageBox.Show("Karışık liste oluşturulması için 5 den fazla şarkınız olmalı !","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning); }   
            }
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            mixedCount++;
            if (fileNames.Length > 5 && mixedCount ==1) { play("mixed"); } 
            else if (fileNames.Length > 5 && mixedCount==2) { mixedCount = 0; play("normal"); btnPlay.Enabled = true; btnStop.Enabled = false; }// eğer 5 den fazla şarkı varsa karışık çalmayı başlat yoksa uyarı ver
            else { MessageBox.Show("Karışık liste oluşturulması için 5 den fazla şarkınız olmalı !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnRollBack_Click(object sender, EventArgs e)
        {
            if (play_media == true) // başa sar butonuna basıldığında eğer şarkı oynatılıyorsa
            {
                play_media = false; // şarkı oynatma durumunu false yap
                axWindowsMediaPlayer1.Ctlcontrols.stop(); // media player etkinliğini tamamen durdur
                btnPlay.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofl = new OpenFileDialog() { Multiselect = true /*çoklu seçim açık */, Filter = "MP3|*.mp3|MP4|*.mp4"};
            ofl.ShowDialog();
            int selectedFileNumber = ofl.SafeFileNames.Length;

            if (selectedFileNumber > 0)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                fileNames = new string[selectedFileNumber]; // şarkı adlarının depolandığı dizinin boyutunu güncelliyoruz
                fileWays = new string[selectedFileNumber]; // şarkı yollarının depolandığı dizinin boyutunu güncelliyoruz

                for (int i=0; i< selectedFileNumber; i++)
                {
                    fileNames[i] = ofl.SafeFileNames[i]; // seçilen dosyaları diziye ekliyoruz
                    fileWays[i] = ofl.FileNames[i].ToString();
                }
                play("normal");
            }
            else { MessageBox.Show("Dosya seçimi yapılmadı !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (play_media == true) { if (listBox1.Items.Count > 0) { axWindowsMediaPlayer1.Ctlcontrols.previous(); } }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (play_media == true) { if (listBox1.Items.Count > 0) { axWindowsMediaPlayer1.Ctlcontrols.next(); } }
        }

        private void btnRevind_Click(object sender, EventArgs e)
        {
            if (play_media == true) { axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 10; }
        }

        private void btnForvard_Click(object sender, EventArgs e)
        {
            if (play_media == true) { axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 10; }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -= 5;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 5;
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            muteCount += 1;
            if (muteCount == 1)
            {
                axWindowsMediaPlayer1.settings.mute = true;
                btnMute.ImageIndex = 9;
            }
            else if (muteCount == 2)
            {
                muteCount = 0;
                axWindowsMediaPlayer1.settings.mute = false;
                btnMute.ImageIndex = 8;
            } 
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value < 60) { hour = 0; textBox3.Text = hour.ToString(); }
            else if (trackBar1.Value<120) { hour = 1; textBox3.Text = hour.ToString(); }
            else { hour = 2; textBox1.Text = hour.ToString(); }

            textBox1.Text = Convert.ToString(trackBar1.Value % 60);
            textBox2.Text = "0";
        }

        private void btnSetTimer_Click(object sender, EventArgs e)
        {
            timer = true;
            second = 60;
            minute = trackBar1.Value % 60 - 1;
            textBox3.Text = hour.ToString();
            textBox1.Text = minute.ToString();
            textBox2.Text = second.ToString();

            timer1.Interval = 1000;
            timer1.Start();
            btnSetTimer.Enabled = false;
            btnCancenTimer.Enabled = true;
            trackBar1.Enabled = false;
        }

        private void btnCancenTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnSetTimer.Enabled = true;
            btnCancenTimer.Enabled = false;
            trackBar1.Enabled = true;
            trackBar1.Value = 5;
            second = 60;
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            timer = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;
            if (second == 0 && minute !=0) { minute--; second = 60; }
            if (minute == 0 && hour !=0) { hour--; minute = 60; }

            textBox3.Text = hour.ToString();
            textBox1.Text = minute.ToString();
            textBox2.Text = second.ToString();

            if (hour == 0 && minute==0 && second == 0) { System.Diagnostics.Process.Start("shutdown", "/s /t 0"); }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && serialPort1.IsOpen == false)
            {
                serialPort1.PortName = comboBox1.SelectedItem.ToString();
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                comboBox1.Enabled = false;
                timer2.Start();
                timer2.Interval = 20;
                panel4.Visible = true;
            }          
        }

        private void btnRefreshPorts_Click(object sender, EventArgs e) { listPorts(); }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                comboBox1.Enabled = true;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                timer2.Stop();
                panel4.Visible = false;
            } 
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
          
            if (serialPort1.IsOpen==true)
            {
                readedData = serialPort1.ReadExisting().ToString();

                switch (readedData)
                {
                    case "P": btnPrevious.PerformClick(); break; // perform click tıklanması demek
                    case "N": btnNext.PerformClick(); break;
                    case "+": btnUp.PerformClick(); break;
                    case "-": btnDown.PerformClick(); break;
                    case "S": remoteCount++; if (remoteCount == 1) { btnPlay.PerformClick(); } else { remoteCount = 0; btnStop.PerformClick(); } break;
                }

                serialPort1.DiscardInBuffer(); // portumuzu yeni bir veri girişine hazır hale getiriyor                       
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) { if (serialPort1.IsOpen == true) { serialPort1.Close(); } }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                play_media = true;
                btnPlay.Enabled = false;
                btnStop.Enabled = true;
                listBox2.SelectedIndex = listBox1.SelectedIndex;
                axWindowsMediaPlayer1.URL = fileWays[listBox2.SelectedIndex];
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            try { if (play_media == true) { axWindowsMediaPlayer1.fullScreen = true; } } catch { }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Gerçekten bilgisayarı kapatmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) { System.Diagnostics.Process.Start("shutdown", "/s /t 0"); }            
        }
    }
}

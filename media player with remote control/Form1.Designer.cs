namespace media_player_with_remote_control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRollBack = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRevind = new System.Windows.Forms.Button();
            this.btnForvard = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSetTimer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancenTimer = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMix = new System.Windows.Forms.Button();
            this.btnFullscreen = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.btnRollBack);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnRevind);
            this.groupBox1.Controls.Add(this.btnForvard);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dosya oynatma";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.Gray;
            this.btnStop.ImageIndex = 19;
            this.btnStop.ImageList = this.ımageList1;
            this.btnStop.Location = new System.Drawing.Point(6, 21);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 40);
            this.btnStop.TabIndex = 11;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Simge1_Play.png");
            this.ımageList1.Images.SetKeyName(1, "Simge2_Stop.png");
            this.ımageList1.Images.SetKeyName(2, "Simge3_Previous.png");
            this.ımageList1.Images.SetKeyName(3, "Simge4_ Next.png");
            this.ımageList1.Images.SetKeyName(4, "Simge5_Rewind.png");
            this.ımageList1.Images.SetKeyName(5, "Simge6_Forward.png");
            this.ımageList1.Images.SetKeyName(6, "Simge7_Volume-.png");
            this.ımageList1.Images.SetKeyName(7, "Simge8_Volume+.png");
            this.ımageList1.Images.SetKeyName(8, "Simge9_Mute.png");
            this.ımageList1.Images.SetKeyName(9, "Simge10_NoMute.png");
            this.ımageList1.Images.SetKeyName(10, "Simge11_TimerOn.png");
            this.ımageList1.Images.SetKeyName(11, "Simge12_TimerOff.png");
            this.ımageList1.Images.SetKeyName(12, "Simge13_Files.png");
            this.ımageList1.Images.SetKeyName(13, "Simge14_RamdomList.png");
            this.ımageList1.Images.SetKeyName(14, "Simge15_FullScreen.png");
            this.ımageList1.Images.SetKeyName(15, "Simge16_ShutDown.png");
            this.ımageList1.Images.SetKeyName(16, "Simge17_Connect.png");
            this.ımageList1.Images.SetKeyName(17, "Simge18_DontConnect.png");
            this.ımageList1.Images.SetKeyName(18, "Simge19_Yenile.png");
            this.ımageList1.Images.SetKeyName(19, "Simge20_Pause.png");
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.Gray;
            this.btnPlay.ImageIndex = 0;
            this.btnPlay.ImageList = this.ımageList1;
            this.btnPlay.Location = new System.Drawing.Point(50, 21);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRollBack
            // 
            this.btnRollBack.FlatAppearance.BorderSize = 0;
            this.btnRollBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollBack.ForeColor = System.Drawing.Color.Gray;
            this.btnRollBack.ImageIndex = 1;
            this.btnRollBack.ImageList = this.ımageList1;
            this.btnRollBack.Location = new System.Drawing.Point(96, 21);
            this.btnRollBack.Name = "btnRollBack";
            this.btnRollBack.Size = new System.Drawing.Size(40, 40);
            this.btnRollBack.TabIndex = 6;
            this.btnRollBack.UseVisualStyleBackColor = true;
            this.btnRollBack.Click += new System.EventHandler(this.btnRollBack_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.Gray;
            this.btnPrevious.ImageIndex = 2;
            this.btnPrevious.ImageList = this.ımageList1;
            this.btnPrevious.Location = new System.Drawing.Point(142, 21);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(40, 40);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Gray;
            this.btnNext.ImageIndex = 3;
            this.btnNext.ImageList = this.ımageList1;
            this.btnNext.Location = new System.Drawing.Point(188, 21);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 8;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRevind
            // 
            this.btnRevind.FlatAppearance.BorderSize = 0;
            this.btnRevind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevind.ForeColor = System.Drawing.Color.Gray;
            this.btnRevind.ImageIndex = 4;
            this.btnRevind.ImageList = this.ımageList1;
            this.btnRevind.Location = new System.Drawing.Point(234, 21);
            this.btnRevind.Name = "btnRevind";
            this.btnRevind.Size = new System.Drawing.Size(40, 40);
            this.btnRevind.TabIndex = 9;
            this.btnRevind.UseVisualStyleBackColor = true;
            this.btnRevind.Click += new System.EventHandler(this.btnRevind_Click);
            // 
            // btnForvard
            // 
            this.btnForvard.FlatAppearance.BorderSize = 0;
            this.btnForvard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForvard.ForeColor = System.Drawing.Color.Gray;
            this.btnForvard.ImageIndex = 5;
            this.btnForvard.ImageList = this.ımageList1;
            this.btnForvard.Location = new System.Drawing.Point(280, 21);
            this.btnForvard.Name = "btnForvard";
            this.btnForvard.Size = new System.Drawing.Size(40, 40);
            this.btnForvard.TabIndex = 10;
            this.btnForvard.UseVisualStyleBackColor = true;
            this.btnForvard.Click += new System.EventHandler(this.btnForvard_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnDown);
            this.groupBox2.Controls.Add(this.btnUp);
            this.groupBox2.Controls.Add(this.btnMute);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(344, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ses";
            // 
            // btnDown
            // 
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.ForeColor = System.Drawing.Color.Gray;
            this.btnDown.ImageIndex = 6;
            this.btnDown.ImageList = this.ımageList1;
            this.btnDown.Location = new System.Drawing.Point(6, 21);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 40);
            this.btnDown.TabIndex = 11;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ForeColor = System.Drawing.Color.Gray;
            this.btnUp.ImageIndex = 7;
            this.btnUp.ImageList = this.ımageList1;
            this.btnUp.Location = new System.Drawing.Point(53, 21);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 40);
            this.btnUp.TabIndex = 12;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnMute
            // 
            this.btnMute.FlatAppearance.BorderSize = 0;
            this.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMute.ForeColor = System.Drawing.Color.Gray;
            this.btnMute.ImageIndex = 8;
            this.btnMute.ImageList = this.ımageList1;
            this.btnMute.Location = new System.Drawing.Point(99, 21);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(40, 40);
            this.btnMute.TabIndex = 13;
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.btnSetTimer);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btnCancenTimer);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zamanlayıcı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "saniye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "dakika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(104, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "saat";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(102, 20);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 40);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(214, 20);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 40);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetTimer
            // 
            this.btnSetTimer.FlatAppearance.BorderSize = 0;
            this.btnSetTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTimer.ForeColor = System.Drawing.Color.Gray;
            this.btnSetTimer.ImageIndex = 11;
            this.btnSetTimer.ImageList = this.ımageList1;
            this.btnSetTimer.Location = new System.Drawing.Point(7, 40);
            this.btnSetTimer.Name = "btnSetTimer";
            this.btnSetTimer.Size = new System.Drawing.Size(40, 40);
            this.btnSetTimer.TabIndex = 16;
            this.btnSetTimer.UseVisualStyleBackColor = true;
            this.btnSetTimer.Click += new System.EventHandler(this.btnSetTimer_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(158, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancenTimer
            // 
            this.btnCancenTimer.FlatAppearance.BorderSize = 0;
            this.btnCancenTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancenTimer.ForeColor = System.Drawing.Color.Gray;
            this.btnCancenTimer.ImageIndex = 10;
            this.btnCancenTimer.ImageList = this.ımageList1;
            this.btnCancenTimer.Location = new System.Drawing.Point(312, 40);
            this.btnCancenTimer.Name = "btnCancenTimer";
            this.btnCancenTimer.Size = new System.Drawing.Size(40, 40);
            this.btnCancenTimer.TabIndex = 15;
            this.btnCancenTimer.UseVisualStyleBackColor = true;
            this.btnCancenTimer.Click += new System.EventHandler(this.btnCancenTimer_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackBar1.Location = new System.Drawing.Point(6, 86);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(346, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnMix);
            this.groupBox4.Controls.Add(this.btnFullscreen);
            this.groupBox4.Controls.Add(this.btnManage);
            this.groupBox4.Controls.Add(this.btnShutdown);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(376, 370);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(116, 148);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yönetim";
            // 
            // btnMix
            // 
            this.btnMix.FlatAppearance.BorderSize = 0;
            this.btnMix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMix.ForeColor = System.Drawing.Color.Gray;
            this.btnMix.ImageIndex = 13;
            this.btnMix.ImageList = this.ımageList1;
            this.btnMix.Location = new System.Drawing.Point(70, 30);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(40, 40);
            this.btnMix.TabIndex = 18;
            this.btnMix.UseVisualStyleBackColor = true;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.FlatAppearance.BorderSize = 0;
            this.btnFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullscreen.ForeColor = System.Drawing.Color.Gray;
            this.btnFullscreen.ImageIndex = 14;
            this.btnFullscreen.ImageList = this.ımageList1;
            this.btnFullscreen.Location = new System.Drawing.Point(8, 86);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(40, 40);
            this.btnFullscreen.TabIndex = 19;
            this.btnFullscreen.UseVisualStyleBackColor = true;
            this.btnFullscreen.Click += new System.EventHandler(this.btnFullscreen_Click);
            // 
            // btnManage
            // 
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.ForeColor = System.Drawing.Color.Gray;
            this.btnManage.ImageIndex = 12;
            this.btnManage.ImageList = this.ımageList1;
            this.btnManage.Location = new System.Drawing.Point(8, 30);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(40, 40);
            this.btnManage.TabIndex = 17;
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.FlatAppearance.BorderSize = 0;
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.ForeColor = System.Drawing.Color.Gray;
            this.btnShutdown.ImageIndex = 15;
            this.btnShutdown.ImageList = this.ımageList1;
            this.btnShutdown.Location = new System.Drawing.Point(70, 86);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(40, 40);
            this.btnShutdown.TabIndex = 20;
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 120);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(277, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 6;
            this.panel4.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(3, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 100);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnDisconnect);
            this.panel3.Controls.Add(this.btnRefreshPorts);
            this.panel3.Controls.Add(this.btnConnect);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(130, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 100);
            this.panel3.TabIndex = 5;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.ForeColor = System.Drawing.Color.Gray;
            this.btnDisconnect.ImageIndex = 16;
            this.btnDisconnect.ImageList = this.ımageList1;
            this.btnDisconnect.Location = new System.Drawing.Point(98, 57);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(40, 40);
            this.btnDisconnect.TabIndex = 23;
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.FlatAppearance.BorderSize = 0;
            this.btnRefreshPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPorts.ForeColor = System.Drawing.Color.Gray;
            this.btnRefreshPorts.ImageIndex = 18;
            this.btnRefreshPorts.ImageList = this.ımageList1;
            this.btnRefreshPorts.Location = new System.Drawing.Point(52, 57);
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.Size = new System.Drawing.Size(40, 40);
            this.btnRefreshPorts.TabIndex = 22;
            this.btnRefreshPorts.UseVisualStyleBackColor = true;
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ForeColor = System.Drawing.Color.Gray;
            this.btnConnect.ImageIndex = 17;
            this.btnConnect.ImageList = this.ımageList1;
            this.btnConnect.Location = new System.Drawing.Point(3, 57);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(44, 40);
            this.btnConnect.TabIndex = 21;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port seçimi";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(498, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 624);
            this.listBox1.TabIndex = 4;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.Gray;
            this.button10.ImageIndex = 9;
            this.button10.ImageList = this.ımageList1;
            this.button10.Location = new System.Drawing.Point(663, 370);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 40);
            this.button10.TabIndex = 14;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(498, 447);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(272, 196);
            this.listBox2.TabIndex = 15;
            this.listBox2.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(480, 270);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnRollBack;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRevind;
        private System.Windows.Forms.Button btnForvard;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnSetTimer;
        private System.Windows.Forms.Button btnCancenTimer;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnFullscreen;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnRefreshPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnDisconnect;
    }
}


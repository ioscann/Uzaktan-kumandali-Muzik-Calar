#include <IRremote.h>

int pin=2;
IRrecv IR0(pin);
decode_results results;

#define volumeUp 0xFF18E7
#define volumeDown 0xFF4AB5
#define nextSong 0xFF5AA5
#define previousSong 0xFF10EF
#define playStop 0xFF38C7

void setup() 
{
 Serial.begin(9600);
 IR0.enableIRIn(); //alıcı aktif ediliyor
}

void loop() 
{
  Serial.available();
  
  if (IR0.decode(&results)) //alıcıya herhangi bir sinyal gelmişse
  {
    IR0.resume(); // yeni bir kod alımı için alıcı hazır haline getiriliyor

    switch(results.value)
    {
      case previousSong:  Serial.print("P"); break;
      case nextSong:  Serial.print("N"); break;
      case volumeUp:  Serial.print("+"); break;
      case volumeDown:  Serial.print("-"); break;
      case playStop:  Serial.print("S"); break;     
    }
  }
  delay(20); 
}
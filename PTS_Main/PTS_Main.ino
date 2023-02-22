
///Daniel Barba Linear Prototypes 20191220 Version 2.0-updated communicated transfer and serial ID for verification


#include <SPI.h>
#include "RF24.h"
#include "nRF24L01.h"

RF24 radio (7, 8); 


const byte address[][10] = {"00001", "00002"};

String TIME = "",incoming="", incomingString="", VAL="";
String BoardSerial="12345abcde";

double VERSION= 0.1;

struct package
{
  char ID[10];
  unsigned long TIME = 0;
  char FUNC[10];
  unsigned long VAL = 0;
};

typedef struct package Package;
Package data;

void setup() {
  //pinMode(A6, INPUT);

  Serial.begin(115200);
  Serial.setTimeout(3);
  radio.begin();


  radio.openWritingPipe(address[1]);
  radio.openReadingPipe(1, address[0]);

  radio.setDataRate(RF24_250KBPS);
  radio.setPALevel(RF24_PA_LOW);
   radio.startListening();
}

void loop() {
  if (Serial.available())
  {
    //**********uncomment Serial.xxxx() for debugging comms**********
    
    //Serial.println("Done 1");
    incoming = Serial.readString();
   //Serial.println(incoming);
    //Serial.println(BoardSerial);
    if(incoming == "BoardSerial")Serial.println(BoardSerial);
    else{
       //Serial.println("Done 2");
    incomingString = incoming.substring(0, 1);
    incomingString.toCharArray(data.ID, 2);
    incomingString  = incoming.substring(1, 2);
    incomingString.toCharArray(data.FUNC, 2);
    VAL= incoming.substring(2, 10);
    data.VAL = VAL.toInt();
    
    //Serial.println("Done 3");
    radio.stopListening();
    
    //Serial.println("Done 4");
    radio.write(&data, sizeof(data));
    
    //Serial.println("Done 5");
     radio.startListening();
    }
   
  }




 
  if ( radio.available())
  {
    radio.read( &data, sizeof(data) );
    Serial.println(data.ID + String(data.TIME)+data.FUNC+String(data.VAL));
  }





}

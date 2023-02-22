
///Daniel Barba Linear Prototypes 20191220 Version 2.0
///Daniel Barba Linear Prototypes 20191225 Version 2.1- innocent bystander dynamic with updated feedback and timeout


#include <SPI.h>
#include "RF24.h"
#include "nRF24L01.h"
#include <EEPROM.h>
RF24 radio (7, 8);


const byte address[][10] = {"00001", "00002"};

String command = "", num = "", letter = "", ID = "";
String readsingle = "";

int TargetLife = 0;


struct package
{
  char ID[10];
  unsigned long TIME = 0;
  char FUNC[10];
  unsigned long VAL = 0;

};

typedef struct package Package;
Package data;


unsigned long timeKeep = 0;

char TargetID = ' ';
char TargetType = 'E';
int TriggerVal = 0;
int BufferTime = 75;//in ms
int moniter = 0;

double innocentLife = 0;

const int LRed = 4, LGreen = 5, LBlue = 6, Piezo = A6;

float f = 150.000f; //set for default sensiticity (0-1024 value) value in milliseconds
double VERSION = 0.1;

void setup() {
  pinMode(Piezo, INPUT);

  pinMode(LRed, OUTPUT);
  pinMode(LGreen, OUTPUT);
  pinMode(LBlue, OUTPUT);

  Serial.begin(115200);


  //**********Uncomment for LED check at beginning of start up*************
  digitalWrite(LRed, HIGH);
  delay(500);
  digitalWrite(LRed, LOW);
  delay(10);
  digitalWrite(LGreen, HIGH);
  delay(500);
  digitalWrite(LGreen, LOW);
  delay(10);
  digitalWrite(LBlue, HIGH);
  delay(500);
  digitalWrite(LBlue, LOW);

  //*********uncomment once for NEW board to load default data into EEPROM************
  //EEPROM.put(1,'@'); //current default ID is A
  //EEPROM.put(2,f);//set default for sensitivity, see above Setup() for setting value in milliseconds
  //**************removed from older version***************//EEPROM.put(3,'E');//default target type status (E-enemy, G-friendly, N-nuetral)


  //*****Retrieves EEPROM data*****
  //**************removed from older version***************//EEPROM.get(3, TargetType);
  EEPROM.get(1, TargetID);
  EEPROM.get(2, f);
  TriggerVal = int(f);

  Serial.print("ID: ");
  Serial.println(TargetID);
  Serial.print("Trigger: ");
  Serial.println(TriggerVal);



  radio.begin();
  radio.openWritingPipe(address[0]);
  radio.openReadingPipe(1, address[1]);
  radio.setDataRate(RF24_250KBPS);
  radio.setPALevel(RF24_PA_LOW);
  radio.startListening();


}


void loop() {
  if ( radio.available())
  {
    //********Uncomment to debug misc********
    //Serial.println("Radio....");

    radio.read( &data, sizeof(data) );

    //********Uncomment to debug misc********
    //Serial.println("Radio read finished!!");

    //****Global Target Commands all set to Z as authenticated command*******
    if (data.ID[0] == '!')//do not change Z, if so change for ALL units
    {
      //********Uncomment to debug universal ID misc********
      //Serial.println("Z accepted");

      if (data.FUNC[0] == 'S') innocentLife = 0, TargetLife = 0, digitalWrite(LRed, LOW), digitalWrite(LGreen, LOW), digitalWrite(LBlue, LOW); // Serial.println("STOPPED"); //***Uncomment Serial Print for debug***
      else if (data.FUNC[0] == 'C')
      {
        delay((int(TargetID) - 64)*BufferTime); // delay to keep from multiple units talking at the same time on the same pipe address

      }

      radio.stopListening();
      data.ID[0] = TargetID;
      data.TIME = millis();
      data.FUNC[0] == 'R';
      radio.write(&data, sizeof(data));
      radio.startListening();

      if (data.FUNC[0] == 'C')Flash(2, 30, 3);
    }

    //*********Specific ID target command********
    else if (data.ID[0] == TargetID)
    {
      //********Uncomment to debug misc********
      //Serial.println("ID ok");
      //while(1==1);


      if (data.FUNC[0]  == 'E')
      {
        timeKeep = millis();
        TargetLife = data.VAL;
        TargetType = data.FUNC[0];
        digitalWrite(LGreen, LOW);
        digitalWrite(LBlue, LOW);
        digitalWrite(LRed, HIGH);//Serial.println("Target is SET to ENEMY");//***Uncomment Serial Print for debug LED****
      }
      else if (data.FUNC[0]  == 'G')
      {
        timeKeep = millis();
        TargetLife = data.VAL;
        innocentLife = TargetLife;
        TargetType = data.FUNC[0];
        digitalWrite(LRed, LOW);
        digitalWrite(LBlue, LOW);
        digitalWrite(LGreen, HIGH);
      }
      else if (data.FUNC[0] == 'N')
      {
        timeKeep = millis();
        TargetLife = data.VAL;
        TargetType = data.FUNC[0];
        digitalWrite(LRed, LOW);
        digitalWrite(LGreen, LOW);
        digitalWrite(LBlue, HIGH);
      }


      else if (data.FUNC[0] == 'S') TargetLife = 0, digitalWrite(LRed, LOW), digitalWrite(LGreen, LOW), digitalWrite(LBlue, LOW); //Serial.println("STOPPED");//***Uncomment Serial Print for debug***
      else if (data.FUNC[0] == 'T')f = data.VAL, EEPROM.put(2, f);
      else if (data.FUNC[0] == 'I')EEPROM.put(1, char(int(data.VAL))), TargetID = char(int(data.VAL));

      //*******************older V1.xx function**********************
      /*else if (data.FUNC[0] == 'M')
        {
        if(data.VAL==0)TargetType = 'G';
        else if(data.VAL==1)TargetType = 'E';
        else if(data.VAL==2)TargetType = 'F';
          digitalWrite(LRed, LOW);
          digitalWrite(LGreen, LOW);
          digitalWrite(LBlue, LOW);
          if(TargetType=='G')digitalWrite(LGreen, HIGH);
          else if(TargetType=='E')digitalWrite(LRed, HIGH);
          else if(TargetType=='F')digitalWrite(LBlue, HIGH);
        }*/

      else if (data.FUNC[0] == 'F')Flash(2, 150, int(data.VAL));
      else if (data.FUNC[0] == 'O')Lights(1, int(data.VAL));
      else if (data.FUNC[0] == 'N')Lights(0, 0);
      else if (data.FUNC[0] == 'C')
      {
        if ( data.VAL == 2) data.VAL = TriggerVal;
        else if ( data.VAL == 3) data.VAL = TargetLife;
      }


      delay(5);
      radio.stopListening();
      data.ID[0] = TargetID;
      data.TIME = millis();
      data.FUNC[0] = 'R';
      radio.write(&data, sizeof(data));
      radio.startListening();


    }


  }

  //*********uncomment to debug input from piezo/misc**********
  //Serial.println(analogRead(A6));
  //Serial.println(TriggerVal);

  if (!radio.available() && analogRead(Piezo) > TriggerVal && (millis() - timeKeep) > 50)
  {
    //*********uncomment to debug OUTPUT**********
    //Serial.println("HIT!!");
    //Serial.println(TargetLife);

    radio.stopListening();
    data.ID[0] = TargetID;
    data.TIME = millis() - timeKeep;
    timeKeep = millis();

    if (TargetLife > 0)
    {

      if (TargetType == 'E')
      {
        TargetLife -= 1;
        data.VAL = TargetLife;
      }
      if (TargetType == 'G' || TargetType == 'N')
      {
        innocentLife -= 1;
        if (innocentLife > 0)TargetLife = innocentLife;
        else innocentLife = 0, TargetLife = 0;
        data.VAL = innocentLife;
      }
      data.FUNC[0] = TargetType;

      if (TargetLife > 0)
      {
        radio.write(&data, sizeof(data));
        radio.startListening();
      }
      else if (TargetLife == 0)
      {
        digitalWrite(LRed, LOW);
        digitalWrite(LGreen, LOW);
        digitalWrite(LBlue, LOW);
        radio.write(&data, sizeof(data));
        radio.startListening();
      }
      
    }
    else 
      {
        //*********uncomment to debug OUTPUT**********
        //Serial.println("INSIDE # FUNC");
        data.VAL = TargetLife;
        if (TargetType == 'E')data.FUNC[0] = 'I';
        else if (TargetType == 'G')data.FUNC[0] = 'O';
        else if (TargetType == 'N')data.FUNC[0] = 'P';

        radio.write(&data, sizeof(data));
        radio.startListening();

        if (TargetType == 'E')Flash(5, 50, 1);
        else if (TargetType == 'G')Flash(5, 50, 2);
        else if (TargetType == 'N')Flash(5, 50, 3);
      }

  }


  if (TargetType == 'G' && innocentLife > 0)
  {
    delay(1);
    innocentLife -= 0.001;
    if (innocentLife <= 0)
    {
      digitalWrite(LRed, LOW);
      digitalWrite(LGreen, LOW);
      digitalWrite(LBlue, LOW);
      radio.stopListening();
      data.ID[0] = TargetID;
      data.TIME = millis() - timeKeep;
      timeKeep = millis();
      data.FUNC[0] = 'R';
      data.VAL = 0;
      radio.write(&data, sizeof(data));
      radio.startListening();
    }
  }





}

void Lights( int ON, int color)
{
  digitalWrite(LRed, LOW), digitalWrite(LGreen, LOW), digitalWrite(LBlue, LOW);
  if (ON == 0);
  else {
    if (color == 1)digitalWrite(LRed, HIGH);
    else if (color == 2)digitalWrite(LGreen, HIGH);
    else if (color == 3)digitalWrite(LBlue, HIGH);
    else if (color == 4)digitalWrite(LRed, HIGH), digitalWrite(LGreen, HIGH);
    else if (color == 5)digitalWrite(LBlue, HIGH), digitalWrite(LGreen, HIGH);
    else if (color == 6)digitalWrite(LBlue, HIGH), digitalWrite(LRed, HIGH);
    else if (color == 7)digitalWrite(LRed, HIGH), digitalWrite(LGreen, HIGH), digitalWrite(LBlue, HIGH);
  }
}


void Flash( int cycles, int t,  int color)
{

  if (color > 0 && color < 4)
  {
    for (int a = 0; a < cycles; a++)
    {
      if (color == 1)digitalWrite(LRed, HIGH);
      else if (color == 2)digitalWrite(LGreen, HIGH);
      else if (color == 3)digitalWrite(LBlue, HIGH);
      delay(t);

      if (color == 1) digitalWrite(LRed, LOW);
      else if (color == 2)digitalWrite(LGreen, LOW);
      else if (color == 3)digitalWrite(LBlue, LOW);
      delay(t);
    }
  }
  else {
    for (int a = 0; a < cycles; a++)
    {
      if (color == 4)digitalWrite(LRed, HIGH), digitalWrite(LGreen, HIGH);
      else if (color == 5)digitalWrite(LBlue, HIGH), digitalWrite(LGreen, HIGH);
      else if (color == 6)digitalWrite(LBlue, HIGH), digitalWrite(LRed, HIGH);
      else if (color == 7)digitalWrite(LBlue, HIGH), digitalWrite(LRed, HIGH), digitalWrite(LGreen, HIGH);
      delay(t);

      if (color == 4)digitalWrite(LRed, LOW), digitalWrite(LGreen, LOW);
      else if (color == 5)digitalWrite(LBlue, LOW), digitalWrite(LGreen, LOW);
      else if (color == 6)digitalWrite(LBlue, LOW), digitalWrite(LRed, LOW);
      else if (color == 7)digitalWrite(LBlue, LOW), digitalWrite(LRed, LOW), digitalWrite(LGreen, LOW);
      delay(t);
    }
  }

}

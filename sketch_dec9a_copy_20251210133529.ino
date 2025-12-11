#include <DHT.h>
const int pinRojo = 9;
const int pinVerde = 10;
const int pinAzul = 11;

const int pinDHT = 2;
#define DHTTYPE DHT11

DHT dht(pinDHT, DHTTYPE);

String comandoSerial;
float temperatura = 0;
float humedad = 0;

void setup() {
  pinMode(pinRojo, OUTPUT);
  pinMode(pinVerde, OUTPUT);
  pinMode(pinAzul, OUTPUT);

  Serial.begin(9600);

  dht.begin();
  
  apagarLED();
}

void loop() {
  if (Serial.available() > 0) {
    comandoSerial=Serial.readString();
    comandoSerial.trim();

    if (comandoSerial.length()>0) {
      char comando = comandoSerial.charAt(0);
      
      switch (comando){
        case 'R':
        setearColor(255,0,0);
        break;
        case 'G':
        setearColor(0,255,0);
        break;
        case 'B':
        setearColor(0,0,255);
        break;
        case '0':
        apagarLED();
        break;
      }
    }
  }
  static unsigned long tiempoAnterior=0;
  unsigned long intervalo = 2000;
  if(millis()-tiempoAnterior>=intervalo){
    humedad=dht.readHumidity();
    temperatura=dht.readTemperature();

    if(!isnan(humedad)&&!isnan(temperatura)){
      Serial.println(String(temperatura,2)+","+String(humedad,2));
    }

    tiempoAnterior=millis();
  }
}
void apagarLED(){
  digitalWrite(pinRojo, LOW);
  digitalWrite(pinVerde, LOW);
  digitalWrite(pinAzul, LOW);
}
void setearColor(int r,int g, int b){
  analogWrite(pinRojo, r);
  analogWrite(pinVerde, g);
  analogWrite(pinAzul, b);
}

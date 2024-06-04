#include "BluetoothSerial.h";

//variables manejo de string
String inputString = "";
bool stringComplete = false;

//pin led y baudios
int pin_led = 2;
int baudios = 9600;

//vars Bluetooth
int inputBlue;
String deviceName = "ESP32 Bluetooth";
BluetoothSerial bluetooth;

void setup() {

  //configuracion
  Serial.begin(baudios);
  pinMode(pin_led, OUTPUT);
  digitalWrite(pin_led, false);
  bluetooth.begin(deviceName);

  Serial.println();
  Serial.println("-------------------------------------");
  Serial.println(deviceName + " listo para emparejar...");
}

void loop() {

  leerPuertoSerie();
  leerPuertoBluetooth();

  delay(20);
}
void leerPuertoSerie() {
  while (Serial.available()) {

    char inChar = (char)Serial.read();
    if (inChar == '\n') {
      stringComplete = true;

    } else {
      inputString += inChar;
    }
  }
  if (stringComplete) {
    inputString.trim();
    Serial.println(inputString);

    if (inputString.equals("1")) {
      digitalWrite(pin_led, true);
    } else if (inputString.equals("0")) {
      digitalWrite(pin_led, false);
    }

    inputString = "";
    stringComplete = false;
  }
}
void leerPuertoBluetooth(){
if (bluetooth.available()) {
    inputBlue = bluetooth.read();
    Serial.write(inputBlue);


    if (inputBlue == '1') {
      digitalWrite(pin_led, true);
    } else if (inputBlue == '0') {
      digitalWrite(pin_led, false);
    }
  }
}

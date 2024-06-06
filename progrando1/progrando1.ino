#include "BluetoothSerial.h"; // Incluye la librería para manejar la comunicación Bluetooth

// Variables para manejo de string
String inputString = ""; // Variable para almacenar la cadena de caracteres recibida por el puerto serie
bool stringComplete = false; // Bandera para indicar si la cadena de caracteres está completa

// Pin del LED y baudios de la comunicación serie
int pin_led = 2; // Pin del LED
int baudios = 9600; // Velocidad de la comunicación serie en baudios

// Variables para Bluetooth
int inputBlue; // Variable para almacenar el dato recibido por Bluetooth
String deviceName = "ESP32 Bluetooth"; // Nombre del dispositivo Bluetooth
BluetoothSerial bluetooth; // Instancia de la clase BluetoothSerial

void setup() {

  // Configuración inicial
  Serial.begin(baudios); // Inicializa la comunicación serie con la velocidad especificada
  pinMode(pin_led, OUTPUT); // Configura el pin del LED como salida
  digitalWrite(pin_led, false); // Apaga el LED inicialmente
  bluetooth.begin(deviceName); // Inicializa el módulo Bluetooth con el nombre del dispositivo

  // Mensajes de inicio en el monitor serie
  Serial.println();
  Serial.println("-------------------------------------");
  Serial.println(deviceName + " listo para emparejar..."); // Informa que el dispositivo está listo para emparejar
}

void loop() {

  leerPuertoSerie(); // Llama a la función para leer el puerto serie
  leerPuertoBluetooth(); // Llama a la función para leer el puerto Bluetooth

  delay(20); // Pequeña pausa para evitar problemas de sincronización
}

void leerPuertoSerie() {
  while (Serial.available()) { // Mientras haya datos disponibles en el puerto serie

    char inChar = (char)Serial.read(); // Lee un carácter del puerto serie
    if (inChar == '\n') { // Si el carácter es un salto de línea, la cadena está completa
      stringComplete = true;

    } else {
      inputString += inChar; // Si no, añade el carácter a la cadena de entrada
    }
  }
  if (stringComplete) { // Si la cadena está completa
    inputString.trim(); // Elimina espacios en blanco al principio y al final de la cadena
    Serial.println(inputString); // Imprime la cadena completa en el monitor serie

    if (inputString.equals("1")) { // Si la cadena es "1", enciende el LED
      digitalWrite(pin_led, true);
    } else if (inputString.equals("0")) { // Si la cadena es "0", apaga el LED
      digitalWrite(pin_led, false);
    }

    inputString = ""; // Reinicia la cadena de entrada
    stringComplete = false; // Reinicia la bandera de cadena completa
  }
}

void leerPuertoBluetooth(){
  if (bluetooth.available()) { // Si hay datos disponibles en el puerto Bluetooth
    inputBlue = bluetooth.read(); // Lee un dato del Bluetooth
    Serial.write(inputBlue); // Escribe el dato en el monitor serie

    if (inputBlue == '1') { // Si el dato es '1', enciende el LED
      digitalWrite(pin_led, true);
    } else if (inputBlue == '0') { // Si el dato es '0', apaga el LED
      digitalWrite(pin_led, false);
    }
  }
}

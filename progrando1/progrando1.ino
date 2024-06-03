String inputString="";
bool stringComplete=false;

int pin_led=13;

void setup() 
{
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(pin_led, OUTPUT);
  digitalWrite(pin_led, false);
}

void loop() 
{
  serialEvent();
  // put your main code here, to run repeatedly:
  if(stringComplete)
  {
    inputString.trim();
    Serial.println(inputString);

    if(inputString.equals("$On")){
      digitalWrite(pin_led, true);
    }else if(inputString.equals("$Off")){
      digitalWrite(pin_led, false);
    }

    inputString ="";
    stringComplete= false;

  }

}
void serialEvent()
{

  while(Serial.available())
  {

    char inChar = (char)Serial.read();
    if(inChar == '\n'){
      stringComplete=true;

    }else{
      inputString += inChar;
    }




  }

}
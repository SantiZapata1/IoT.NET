String inputString="";
bool stringComplete=false;

void setup() 
{
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(2, OUTPUT);
  digitalWrite(2, false);
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
      digitalWrite(2, true);
    }else if(inputString.equals("$Off")){
      digitalWrite(2, false);
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
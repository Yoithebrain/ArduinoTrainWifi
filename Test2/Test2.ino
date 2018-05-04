
String inputs[] = {"", "", "", ""};
int index = 0;
boolean reqDone = false;

void setup() {
  Serial.begin(9600);
  Serial.println("begin");

}

void loop() {

  if (reqDone) {
    Serial.println("Request: " + inputs[0]);
    Serial.println("Param 1: " + inputs[1]);
    Serial.println("Param 2: " + inputs[2]);
    Serial.println("Param 3: " + inputs[3]);

    inputs[0] = "";
    inputs[1] = "";
    inputs[2] = "";
    inputs[3] = "";
    
    reqDone = false;
    index = 0;
  }
}

void serialEvent() {

  while(Serial.available()) {

    char c = (char)Serial.read();

    if (c == ';') {
      reqDone = true;
      break;
    } else if (c == ' ') {
      if (index < 3) {
        index++;
      } else {
        reqDone = true;
      }
    } else {
      inputs[index] += c;
    }
  }
}















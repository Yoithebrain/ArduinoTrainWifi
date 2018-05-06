
String inputs[] = {"", "", "", ""};
byte index = 0;
boolean reqDone = false;

void setup() {
  Serial.begin(9600);
  Serial.println("begin");

}

void loop() {

  if (reqDone) {
    Serial.print("{R: <" + inputs[0]);
    Serial.print("> P1: <" + inputs[1]);
    Serial.print("> P2: <" + inputs[2]);
    Serial.println("> P3: <" + inputs[3] + ">}");

    clearInputs();
    
    reqDone = false;
    index = 0;
  }
}

void clearInputs() {
  inputs[0] = "";
  inputs[1] = "";
  inputs[2] = "";
  inputs[3] = "";
}

void serialEvent() {

  while(Serial.available()) {

    char c = (char)Serial.read();

    if (c == '{') {
      clearInputs();
    } else if (c == '}') {
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















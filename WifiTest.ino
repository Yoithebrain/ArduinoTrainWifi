#include <ESP8266WiFi.h>
const char* ssid = "JamalTheMelonKing";
const char* password = "melonking";

WiFiServer server(80);
int ledPin = D5;

void setup() {
  // put your setup code here, to run once:
   Serial.begin(115200);
  delay(10);
 
  pinMode(ledPin, OUTPUT);
  digitalWrite(ledPin, LOW);
 
  // Connect to WiFi network
  Serial.println();
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(ssid);
 
  WiFi.begin(ssid, password);
 
  while (WiFi.status() != WL_CONNECTED) 
  {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.println("WiFi connected");
 
  // Start the server
  server.begin();
  Serial.println("Server started");
 
  // Print the IP address
  Serial.print("Use this URL : ");
  Serial.print("http://");
  Serial.print(WiFi.localIP());
  Serial.println("/");
 
  // fra L298_org
  //pinMode(A, OUTPUT);      // Define the Outputs from the Arduino
   
  //digitalWrite(A, LOW);   // Set Pins Low to start
  delay(500);
}

void loop() {
  // put your main code here, to run repeatedly:
  WiFiClient client = server.available();
  if(!client){
    return;
  }
Serial.println("New client!");
String msg = "";
byte myBytes [1024];
int i = 0;
while(msg = client.read()) {
    if(msg = client.read() != ' '){
    myBytes[i] = ((byte)client.read());
    i++;
    delay(10); 
    }
  }

msg = String((char *)myBytes);
Serial.println(msg);

}

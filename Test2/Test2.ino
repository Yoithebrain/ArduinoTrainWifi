#define DCC_PIN 4
#define PREAMBLELENGTH 16
#define TIMER_SHORT 0x8D
#define TIMER_LONG  0x1B

#define PREAMPLE 0
#define SEPERATOR 1
#define SENDBYTE 2

unsigned char type_addr; //Hvilken type af ting vi prøver at få fat på, accessory eller tog
unsigned char addr; //Adresse for tog eller accessory
unsigned char idle_addr = 255;
unsigned char data; // dataen til toget
unsigned char idle_data;
unsigned char checksum;
unsigned char speedy = 0; //Defualt værdi for speed
unsigned char locoDir; //Retning af tog

bool test = true;

int const maxdata = 2;
unsigned char data_arr[2][maxdata];
int set_index = 0;
int get_index = 0;
int msgindex = 0;
int byteindex = 0;



bool pulseUp = true;                        // high -> low -> repeat
bool short_pulse = true;                    // short = 1, long = 0
unsigned char pulse_width = TIMER_SHORT;    // pulse width
unsigned char msgIndex = 0;                 // 0 = message, 1 = idle
unsigned char byte_index = 0;               // index of byte in message
unsigned char state_index = PREAMBLELENGTH; // index step in current state

unsigned char state = PREAMPLE;

bool testing = true;
String testTxt = "";

struct Message
{
  unsigned char data[8];
  unsigned char len;
};

struct Message msg[2]
{
  { { 0b00001001, 0b01001111, 0b01000110, 0, 0, 0, 0, 0}, 3},  // msg
  { { 0xFF, 0, 0xFF, 0, 0, 0, 0, 0}, 3}                                 // idle 
};

void SetupTimer2()
{
  TCCR2A = 0; //page 203 - 206 ATmega328/P // normal operation mode
  TCCR2B = 2; //Page 206 // prescaler på 8
  TIMSK2 = 1<<TOIE2;   //Timer2 Overflow Interrupt Enable - page 211 ATmega328/P   
  TCNT2 = TIMER_SHORT;   //load the timer for its first cycle
}

ISR(TIMER2_OVF_vect) //Timer2 overflow interrupt vector handler
{
  unsigned char latency;
  if (pulseUp)
  {
    digitalWrite(DCC_PIN, HIGH);
    pulseUp = false;
    latency=TCNT2;
    TCNT2=latency+pulse_width;
    
  } else
  {
    pulseUp = true;
    digitalWrite(DCC_PIN, LOW);
    
    switch(state)
    {
    case PREAMPLE:
      if (state_index > 0)
      {
        state_index -= 1;
        short_pulse = true;
      }
      else
      {
        if (msg[0].len == 0)
        {
          msgIndex = 1;
          if (testing)
          {
            Serial.println(testTxt);
            testTxt = "";
            testing = false;
          }
        }
        else
        {
          msgIndex = 0;
          //testing = true;
        }
        state = SEPERATOR;
        byte_index = 0;
        short_pulse = true;
      }
      if(testing)
        Serial.println("pre");
      break;

      
    case SEPERATOR:
      if (byte_index == 3 || byte_index == 4)
      {
        short_pulse = true;
      } else
      {
        short_pulse = false;
      }
      state_index = 0;
      state = SENDBYTE;
      if(testing)
        Serial.println("-------------sep");
      break;

      
    case SENDBYTE:
      if(testing)
        Serial.println("bit");
      // loop through bits
      // state_index is the current bit
      // byte_index is the current byte

      unsigned char selector = 128 >> state_index;

      if ((msg[msgIndex].data[byte_index] & selector) == 0)
      {
        short_pulse = false;
      }
      else
      {
        short_pulse = true;
      }

      // code for checking if current bit is 0 or 1
      if (state_index < 7) // jump to next bit in byte
      {
        state_index += 1;
      }
      else
      {
        if (byte_index >= msg[msgIndex].len -1) // jump to preample
        {
          if (msgIndex == 0) {
            msg[msgIndex].len = 0;
          }
          state = PREAMPLE;
          state_index = PREAMBLELENGTH;
          if (testing)
          {
            Serial.println("Stop");
          }
        }
        else
        {
          byte_index += 1; // jump to seperator and then next byte
          state = SEPERATOR;
        }
      }
      break;
    }

    if (short_pulse)  
    {  // data = 1 short pulse
      latency=TCNT2;
      TCNT2=latency+TIMER_SHORT;
      pulse_width=TIMER_SHORT;
      
      if(testing)
      {
        Serial.println("1");
        testTxt += "1";
      }
    }  
    else  
    {   // data = 0 long pulse
      latency=TCNT2;
      TCNT2=latency+TIMER_LONG; 
      pulse_width=TIMER_LONG;
      
      if(testing)
      {
        Serial.println("0");
        testTxt += "0";
      }
    }
    if(testing && state == 1)
    {
      testTxt += " ";
    }
  }
}


String inputs[] = {"", "", "", ""};
byte serial_index = 0;
bool reqDone = false;

void setup() {
  Serial.begin(115200);
  pinMode(DCC_PIN,OUTPUT);
  SetupTimer2();
}

void loop() {

  if (reqDone) {
    
    decode_Userinput();
    delay(50);
    decode_Userinput();
    delay(50);
    decode_Userinput();

    clearInputs();
    reqDone = false;
    serial_index = 0;
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
      if (serial_index < 3) {
        serial_index++;
      } else {
        reqDone = true;
      }
    } else {
      inputs[serial_index] += c;
    }
  }
}

void putdata(unsigned char a, unsigned char b)
{    
  noInterrupts();
  if(true) 
  {
    Serial.print("putdata");
    msg[0].data[0] = a;
    msg[0].data[1] = b;
    msg[0].data[2] = a^b;
    Serial.println("");
    Serial.print(a, BIN);
    Serial.print(" ");
    Serial.print(b, BIN);
    Serial.print(" ");
    Serial.print(msg[0].data[2], BIN);
    Serial.println("");
    msg[0].len = 3;
  }
  interrupts();
}

void putAccData(unsigned char byte1, unsigned char byte2)
{
  unsigned char * pByte1 = NULL;
  pByte1 = &byte1;
  
  noInterrupts();
  Serial.print("putAccData");
    msg[0].data[0] = *pByte1;
    msg[0].data[1] = byte2;
    msg[0].data[2] = *pByte1^byte2;
    Serial.println("");
    Serial.print(*pByte1, BIN);
    Serial.print(" ");
    Serial.print(*pByte1, BIN);
    Serial.print(" ");
    Serial.print(msg[0].data[2], BIN);
    Serial.println("");
    msg[0].data[3] = 255;
    msg[0].data[4] = 255;

    
    byte2 = byte2 - 8; // switch register off
    Serial.println("");
    Serial.print(*pByte1, BIN);
    Serial.print(" ");
    Serial.print(*pByte1, BIN);
    Serial.print(" ");
    Serial.print(msg[0].data[2], BIN);
    Serial.println("");
    msg[0].data[5] = *pByte1;
    msg[0].data[6] = byte2;
    msg[0].data[7] = *pByte1^byte2;
    msg[0].len = 8;
  interrupts();
}

void decode_Userinput()
{
  if(inputs[0] == "2") // Set speed
  {
    addr = stringToInt(127, 1);
    speedy = stringToInt(31, 2);
    locoDir = stringToInt(1, 3);
    speedy += 64;
    if (locoDir == 1)
    {
        speedy += 32;
    }
    putdata(addr, speedy);
    //clearInputs();
  } 
  else if (inputs[0] == "4") // Set train effect
  {
    addr = stringToInt(127, 1);
    unsigned char effects = stringToInt(31, 2);
    effects += 128;
    putdata(addr, effects);
  }
  else if(inputs[0] == "6") // Set accessory
  {
    addr = stringToInt(512, 1);
    data = stringToInt(31, 2);
    calculateaddr(addr, data);
    //clearInputs();
  }
}

// Funktion til at parse vores string inputs over til
// unsigned ints så vi kan bruge dem til bedskeden.
unsigned int stringToInt(unsigned int maxVal,  unsigned int index)
{

  unsigned int stringInput = 0xFFFF;
  //Serial.println(string);
  while (stringInput > maxVal) 
  {
    if (inputs[index] != "")
    {
      stringInput = (inputs[index].toInt());
    }
  }
  Serial.println("input: \"" + inputs[index] + "\"");
  Serial.print("converted int: \"");
  Serial.print(stringInput);
  Serial.println("\"");
  return stringInput;
  
}

void calculateaddr(unsigned int a, unsigned char b)
{
  unsigned int address, x, y;
  unsigned char reg, byte1, byte2;
  
  if((a%4)==0)
  {
    address=a/4;
    reg=3;   
  }
  else
  {
    address = (a/4)+1;
    reg = (a%4)-1; // -1 jkp 2311
  }
  byte1   = address & 63;
  byte1   = byte1 + 128;
  Serial.print("addr : ");
  Serial.println(byte1);

  byte2   = 128;
  x       = 0;
  y       = address & 64;
  if(y==0) x += 64;
  y       = address & 128;
  if(y==0) x += 128;
  y       = address & 256;
  if(y==0) x += 256;
  x = x >> 2;
  byte2 += x;
  byte2 = byte2 + (reg << 1);
  if(b==1)
  {
    if(test)
    {
      Serial.print(" b=1 byte 2 : ");
      Serial.println(byte2);
    }
    byte2 += 9;
    putAccData(byte1, byte2);
  }
  else
  {
    if(test)
    {
      Serial.print(" b=0 byte 2 : ");
      Serial.println(byte2);
    }
//        byte2 += 1;
    byte2 += 8;
    putAccData(byte1, byte2);
  }
}










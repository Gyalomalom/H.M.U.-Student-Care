const int TEMPSENSOR = A1;
const int LIGHTSENSOR = A2;

const int NTC_R25 = 10000; // the resistance of the NTC at 25'C is 10k ohm
const int NTC_MATERIAL_CONSTANT = 3950; // value provided by manufacturer

unsigned long int Temp_Time=0;
const int TEMP_DELAY = 5000;

unsigned long int Light_Time = 0;
const int LIGHT_DELAY = 10000;

int LightThreshold = 250;

String GetLightStatus(){
  int CurrentLightValue = analogRead(LIGHTSENSOR);
  bool TemporaryLightDetectionState = (CurrentLightValue>=LightThreshold);

if (TemporaryLightDetectionState){
    return "LIGHT_DETECTED";
  }
return "NO_LIGHT_DETECTED";  
}

/*bottom code provided by prof. Sabina Pencheva, used to convert temp sensor value to celsius*/
float get_temperature()

{

    float temperature, resistance;
    int value;
    value = analogRead(TEMPSENSOR);
    resistance   = (float)value * NTC_R25/(1024 - value); // Calculate resistance
    /* Calculate the temperature according to the following formula. */
    temperature  = 1/(log(resistance/NTC_R25)/NTC_MATERIAL_CONSTANT+1/298.15)-273.15;
    return temperature;
}


void setup() {
pinMode(LIGHTSENSOR, INPUT);
pinMode(TEMPSENSOR, INPUT);
Serial.begin(9600);
}

void loop() {
   float TempReport;
   String LightStatus;

/*send temperature information every 5 seconds*/
 if(millis()-Temp_Time>TEMP_DELAY)
 {
    TempReport = get_temperature();
    Serial.println(TempReport);
    Temp_Time = millis();
 }
/*Check on light status every 10 seconds*/
if(millis()- Light_Time>LIGHT_DELAY)
{
   LightStatus = GetLightStatus();
   Serial.println(LightStatus);
   Light_Time = millis();
}

}

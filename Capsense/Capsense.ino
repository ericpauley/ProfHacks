#include <CapacitiveSensor.h>

CapacitiveSensor   back = CapacitiveSensor(12,6);
CapacitiveSensor   right = CapacitiveSensor(12,2);
CapacitiveSensor   left = CapacitiveSensor(12,3);
CapacitiveSensor   top = CapacitiveSensor(12,5);
CapacitiveSensor   bottom = CapacitiveSensor(12,4);

CapacitiveSensor sensors[] = {back, right, left, top, bottom};
int cycleNum = 0;
long measurements[5];
long avMeasurements[3][5]; // 0 is back, 1 is right, 2 is top
long offsetBack = 0;
long offsetRight = 0;
long offsetTop = 0;
bool clicked = false;

void setup() {
  Serial.begin(9600);
  for(int i = 0;i<5;i++){
    //sensors[i].set_CS_AutocaL_Millis(0xFFFFFFFF);
  }
}

void loop() {
  
  //long measurements[5];
  measurements[0] = sensors[0].capacitiveSensor(100);
  for(int i = 1;i<5;i++){
    measurements[i] = sensors[i].capacitiveSensor(25);
  }
  avMeasurements[0][cycleNum] = measurements[0] + offsetBack;
  avMeasurements[1][cycleNum] = measurements[1]-measurements[2] + offsetRight;
  avMeasurements[2][cycleNum] = measurements[3]-measurements[4] + offsetTop;

    float runAvBack = 0;
    float runAvRight = 0;
    float runAvTop = 0;
    
    for(int i = 0; i < 5; i++) {
      runAvBack += avMeasurements[0][i];
      runAvRight += avMeasurements[1][i];
      runAvTop += avMeasurements[2][i];
    }
    runAvBack = runAvBack / 5;
    runAvRight = runAvRight / 5;
    runAvTop = runAvTop / 5;
   /* 
  Serial.print(max(min(back,200),0));
  Serial.print(" ");
  Serial.print(max(min(right,100),-100));
  Serial.print(" ");
  Serial.print(max(min(top,100),-100));
  Serial.println();
  */

  Serial.print(max(min(runAvBack,200),0));
  Serial.print(" ");
  Serial.print(max(min(runAvRight,100),-100));
  Serial.print(" ");
  Serial.print(max(min(runAvTop,100),-100));
  Serial.println();
  
  cycleNum++;
  if(cycleNum == 5) cycleNum = 0;
}

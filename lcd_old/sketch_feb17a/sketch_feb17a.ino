#include <Wire.h>
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd (0x27, 2, 1, 0, 4, 5, 6, 7);
const int speed = 300;

void setup() {
  lcd.setBacklightPin(3, POSITIVE);
  lcd.setBacklight(HIGH);
  lcd.begin(16,2);
  lcd.clear();
  lcd.print("Connected");
  Serial.begin(9600);
}

void loop() {
  lcd.setCursor(0, 1);
  lcd.print(millis()/1000);
  lcd.print(" Segundos");
  delay(100);
}

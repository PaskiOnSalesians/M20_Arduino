/*========================================
    Keypad + LCD a modo de "cerradura".

    Autor: DevPaski
  ========================================*/

// Librerias para usar
#include<Wire.h>
#include <Keypad.h>
#include <LiquidCrystal_I2C.h>

/*========================================
  LCD
  ========================================*/

LiquidCrystal_I2C lcd (0x27, 2, 1, 0, 4, 5, 6, 7);
//const int speed = 300;

/*========================================
  KEYPAD
  ========================================*/

const byte FILAS = 4;
const byte COLUMNAS = 4;

char keys[FILAS][COLUMNAS] = { // distribucion keypad
  {'1', '2', '3', 'A'},
  {'4', '5', '6', 'B'},
  {'7', '8', '9', 'C'},
  {'*', '0', '#', 'D'}
};

byte pinesFilas[FILAS] = {5, 6, 7, 8}; // pines de las filas
byte pinesColumnas[COLUMNAS] = {9, 10, 11, 12}; // pines de las columnas

Keypad teclado = Keypad(makeKeymap(keys), pinesFilas, pinesColumnas, FILAS, COLUMNAS);

char TECLA; // tecla presionada
char CLAVE[5]; // almacena un array de 4 digitos ingresados
char CLAVE_MAESTRA[5] = "1234"; // array con contraseña maestra
byte INDICE = 0; // indice del array

int x = 10;

void setup() {
  Serial.begin(9600);
  lcd.setBacklightPin(3, POSITIVE);
  lcd.setBacklight(HIGH);
  lcd.begin(16, 2);
  lcd.clear();
}

void loop() {
  lcd.setCursor(0, 0);
  lcd.print("Logout in ");
  lcd.print(x - millis() / 1000);
  lcd.print(":");

  if (x == 0) {
    x = 10;
  }
}

/*========================================
    Keypad + LCD a modo de "cerradura".

    Autor: DevPaski
  ========================================*/

// Librerias para usar
#include<Wire.h>
#include <Keypad.h>
#include <LCD.h>
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
String CLAVE; // almacena un array de 4 digitos ingresados
String CLAVE_MAESTRA = "1234"; // array con contraseña maestra
byte INDICE = 0; // indice del array

void setup() {
  Serial.begin(9600);
  lcd.setBacklightPin(3, POSITIVE);
  lcd.setBacklight(HIGH);
  lcd.begin(16, 2);
  lcd.clear();
}

void loop() {
  int currentSeconds;

  String claveFinal = "";
  char teclaKeypad;

  currentSeconds = 30;

  TECLA = teclado.getKey();

  lcd.setCursor(0, 0);
  lcd.print("Logout in ");
  currentSeconds -= millis() / 1000;

  if (currentSeconds < 10) {
    lcd.print("0" + String(currentSeconds));
  } else {
    lcd.print(currentSeconds);
  }
  lcd.print(":");

  if (TECLA) {
    Serial.print(TECLA);
    lcd.setCursor(0, 1);

    teclaKeypad = TECLA;

    switch (teclaKeypad) {
      case 'A':
        BorrarAnterior(claveFinal);
        break;
      case 'B':
        BorrarTodo();
        break;
      case '#':
        lcd.setCursor(0, 0);
        lcd.print("Logout in ");
        if (currentSeconds < 10) {
          lcd.print("0" + String(currentSeconds));
        } else {
          lcd.print(currentSeconds);
        }
        lcd.print(":");
        if (CLAVE.equals(CLAVE_MAESTRA)) {
          lcd.setCursor(0, 1);
          lcd.print("OK                                    ");
          delay(2000);
          lcd.clear();
          exit(0);
        } else {
          lcd.setCursor(0, 1);
          lcd.print("NOK                                 ");
          BorrarTodo();
        }
        break;
      default:
        if ((TECLA != '*' || TECLA != 'C' || TECLA != 'D') && CLAVE.length() <= 3) {
          CLAVE += TECLA;

          for (int i = 0; i < CLAVE.length(); i++) {
            claveFinal += '*';
          }

          lcd.print(claveFinal);
        }
        break;
    }
  }

  if (currentSeconds <= 0) {
    lcd.setCursor(0, 0);
    lcd.print("Unlucky.                            ");
    lcd.setCursor(0, 1);
    lcd.print("                                         ");
    delay(1000);
    lcd.clear();
    exit(0);
  }
}

void BorrarAnterior(String claveRetroceso) {
  CLAVE = CLAVE.substring(0, CLAVE.length() - 1);
  lcd.setCursor(0, 1);
  lcd.clear();

  for (int i = 0; i < CLAVE.length(); i++) {
    claveRetroceso += '*';
  }

  lcd.setCursor(0, 1);
  lcd.print(claveRetroceso);
}

void BorrarTodo() {
  lcd.clear();
  CLAVE = "";
}

/*========================================
    Keypad + LCD a modo de "cerradura".
    
    Autor: DevPaski
========================================*/

// Librerias para usar
#include<Wire.h>
#include <Keypad.h>
#include <LiquidCrystal_I2C.h>


/*=----=----= Constantes y otras variables =----=----=*/
int limiteSegundos;


/*========================================
  LCD
========================================*/

LiquidCrystal_I2C lcd (0x27, 2, 1, 0, 4, 5, 6, 7);
const int speed = 300;

/*========================================
  KEYPAD
========================================*/

const byte FILAS = 4;
const byte COLUMNAS = 4;

char keys[FILAS][COLUMNAS] ={ // distribucion keypad
  {'1','2','3','A'},
  {'4','5','6','B'},
  {'7','8','9','C'},
  {'*','0','#','D'}  
};

byte pinesFilas[FILAS] = {5,6,7,8}; // pines de las filas
byte pinesColumnas[COLUMNAS] = {9,10,11,12}; // pines de las columnas

Keypad teclado = Keypad(makeKeymap(keys), pinesFilas, pinesColumnas, FILAS, COLUMNAS);

char TECLA; // tecla presionada
char CLAVE[5]; // almacena un array de 4 digitos ingresados
char CLAVE_MAESTRA[5] = "1234"; // array con contraseña maestra
byte INDICE = 0; // indice del array

void setup() {
  lcd.setBacklightPin(3, POSITIVE);
  lcd.setBacklight(HIGH);
  lcd.begin(16,2);
  lcd.clear();

  Serial.begin(9600);
}

void loop() {
  limiteSegundos = 30;
  String limite, teclaKeypad;

  TECLA = teclado.getKey();
  
  while(limiteSegundos >= 0){
    lcd.setCursor(0,0);
    limite = String(limiteSegundos);
    lcd.print("Logout in " );
    if(limiteSegundos < 10){
      lcd.print("0" + limite);
    } else{
      lcd.print(limite);  
    }
    lcd.print(":");  
     
    if(TECLA){
      Serial.print(TECLA);
      lcd.setCursor(0,1);
      teclaKeypad = String(TECLA);
      lcd.print(teclaKeypad);
      CLAVE[INDICE] = TECLA;
      INDICE++;
    }

//    if(INDICE == 4){
//      if(!strcmp(CLAVE, CLAVE_MAESTRA)){
//        lcd.print("Correct Login");
//    }
//      INDICE = 0;
//    }
     
    lcd.cursor();
    
    //lcd.noCursor();
    limiteSegundos -= 1;
    delay(1000); // Tiempo enlazado con contador limite de 30seg
  }
  
}

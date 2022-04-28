#define Pares 9
#define Impares 8
#define Multiplos 7
const char* a = "abcd";

void setup() {
  Serial.begin(9600);
  Serial.write("Power On");
  pinMode(Pares, OUTPUT);
  pinMode(Impares, OUTPUT);
  pinMode(Multiplos, OUTPUT);
}

void loop() {
  int pulsoDelay = 100;
  //bool connected_port = false;
  
  if(Serial.available()){
    String opcio = Serial.readString();
    //String opcio = "10,8";
    String ciclos, _multiplos;
    bool comilla = false;
    int numero, _multiplo;

    opcio.trim();
    
    if(opcio == a){ // !opcio.equals("start")
      digitalWrite(Pares,HIGH);
      digitalWrite(Impares,HIGH);
      digitalWrite(Multiplos, HIGH);
      delay(pulsoDelay * 50);
      digitalWrite(Pares,LOW);
      digitalWrite(Impares,LOW);
      digitalWrite(Multiplos, LOW);
    }
  
    for(int i = 0; i < opcio.length(); i++){
      if(opcio[i] == ','){
        comilla = true;
      } else if(!comilla){
        ciclos += opcio[i];
      } else if(comilla){
        _multiplos += opcio[i];
      }
    }

    numero = ciclos.toInt();
    _multiplo = _multiplos.toInt();

    int limiteInf = 5, limiteSup = 20;

    if(numero >= limiteInf && numero <= limiteSup){
      for(int i = 0; i < numero +1; i++){
          bool par = (i % 2 == 0);
          bool multiplo = (i % _multiplo == 0);
        
         if(par && !multiplo){
          digitalWrite(Pares,HIGH);
          delay(pulsoDelay * 3);
          digitalWrite(Pares,LOW);
          delay(pulsoDelay * 10);
         } else if(par && multiplo){
          digitalWrite(Pares,HIGH);
          digitalWrite(Multiplos, HIGH);
          delay(pulsoDelay * 3);
          digitalWrite(Pares,LOW);
          digitalWrite(Multiplos, LOW);
          delay(pulsoDelay * 10);
         } else if(!par && multiplo){
          digitalWrite(Impares,HIGH);
          digitalWrite(Multiplos, HIGH);
          delay(pulsoDelay * 3);
          digitalWrite(Impares,LOW);
          digitalWrite(Multiplos, LOW);
          delay(pulsoDelay * 10);
         } else{
          digitalWrite(Impares,HIGH);
          delay(pulsoDelay * 3);
          digitalWrite(Impares,LOW); 
          delay(pulsoDelay * 10);
         }
      }
    } else{
      digitalWrite(Pares, LOW);
      digitalWrite(Impares, LOW);
      digitalWrite(Multiplos, LOW);
    }
  }
}

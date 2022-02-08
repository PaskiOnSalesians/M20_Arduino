
int Pin = 9;
int pulsoCorto = 200;
int pulsoLargo = 600;
 

void setup() {
  pinMode(Pin, OUTPUT);
}
 
void loop() {
  // Letra S
  SecuenciaLetra(pulsoCorto);
  delay(pulsoCorto*3);
  // Letra O
  SecuenciaLetra(pulsoLargo);
  delay(pulsoLargo);
  // Letra S
  SecuenciaLetra(pulsoCorto);
  delay(pulsoCorto*10);
}
 
void SecuenciaLetra(int pulso)
{
  for (int j=0;j<3;j++)
  {
    digitalWrite(Pin, HIGH);
    delay(pulso);           
    digitalWrite(Pin, LOW);    
    delay(pulso);
  }
}

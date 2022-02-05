
int Pin = 13;
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
  delay(pulsoCorto*3);
  // Letra S
  SecuenciaLetra(pulsoCorto);
  delay(pulsoLargo*3);
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

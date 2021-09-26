using System;

namespace Command
{
    class ComandoEnceder: IComando //esta clase esta implementando la interface comando
    {
        Automovil auto; //variable de referencia hacia la clase automovil

        public ComandoEnceder(Automovil pAuto)  //constructo con la referencia de a que comando se va dirigir.
        {
            auto = pAuto;
        }

        public void ejecutar()  //Implementacion de ejecutar
        {
            auto.Encender(); //Invocamos el metodo enceder ya que este es el comando encender.
        }
    }
}

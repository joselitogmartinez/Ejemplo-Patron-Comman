using System;

namespace Command
{
    class ComandoApagar: IComando
    {
        Automovil auto; 

        public ComandoApagar(Automovil pAuto)
        {
            auto = pAuto;
        }

        public void ejecutar()
        {
            //invocamos la accion correspondiente en el auto
            auto.Apagar();
        }
    }
}

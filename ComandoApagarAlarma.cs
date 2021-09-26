using System;

namespace Command
{
    class ComandoApagarAlarma: IComando
    {
        Automovil auto;

        public ComandoApagarAlarma(Automovil pAuto)
        {
            auto = pAuto;
        }

        public void ejecutar()
        {
            //invocamos la accion correspondiente en el auto
            auto.QuitarAlarma();
        }
    }
}
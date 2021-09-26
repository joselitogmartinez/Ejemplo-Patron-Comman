using System;

namespace Command
{
    class ComandoPrenderAlarma: IComando
    {
        Automovil auto;

        public ComandoPrenderAlarma(Automovil pAuto)
        {
            auto = pAuto;
        }

        public void ejecutar()
        {
            //invocamos la accion correspondiente en el auto
            auto.ColocarAlarma();
        }
    }
}

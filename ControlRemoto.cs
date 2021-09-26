using System;

namespace Command
{
    class ControlRemoto  //representa al invoker
    {
        private IComando[] comandos=new IComando[4]; //Arreglo para invocar varios comandos

        public ControlRemoto(Automovil pAuto) //constructor con el auto con el que va estar trabajando el control remoto(pAuto)
        {
            comandos[0] = new ComandoEnceder(pAuto);  //cada elemento se le asigna un comando
            comandos[1] = new ComandoApagar(pAuto);
            comandos[2] = new ComandoPrenderAlarma(pAuto);
            comandos[3] = new ComandoApagarAlarma(pAuto);
        }

        public void Boton(int pIndice) //metodo boton que recibe un indice del comando a ejecutar
        {
            comandos[pIndice].ejecutar();
        }
    }
}
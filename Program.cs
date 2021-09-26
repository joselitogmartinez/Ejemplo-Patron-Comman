using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil miAuto = new Automovil(); //instanciamos automovil
            ControlRemoto control = new ControlRemoto(miAuto); //instanciamos control Remoto 
            string opcion;

            do //ciclo do While con menu.
            {
                Console.WriteLine("1-encender, 2-apagar. 3-prender alarma, 4-quitar alarma, 5-salir");

                opcion = Console.ReadLine();

                if (opcion == "1"){
                    control.Boton(0); // invocamos el metodo en el control remoto indicando el indice que corresponde
                }
                if (opcion == "2"){
                    control.Boton(1);
                }
                if (opcion == "3"){
                    control.Boton(2);
                }
                if (opcion == "4"){
                    control.Boton(3);
                }
            } while (opcion != "5"); // salir
        }
    }
}

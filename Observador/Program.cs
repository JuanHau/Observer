using Observador.Observador;
using Observador.Suscriptores;
using System;

namespace Observador
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Instancia de 
            AzureDevOps azureDevOps = new AzureDevOps();
            Compilador compilador = new Compilador();
            EjecutorPruebasUnitarias ejecutorPruebasUnitarias = new EjecutorPruebasUnitarias();
            Instalador instalador = new Instalador();
            Notificador notificador = new Notificador();
            bool salir = true;

            while (salir)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("******** Suscriptores disponibles *********");
                Console.WriteLine("*   1) Compilador                         *");
                Console.WriteLine("*   2) Pruebas unitarias                  *");
                Console.WriteLine("*   3) Instalador                         *");
                Console.WriteLine("*   4) Notificador                        *");
                Console.WriteLine("******** Suscriptores disponibles *********");
                Console.WriteLine("0) Ejecutar acción principal");
                Console.WriteLine("5) Salir del programa");
                Console.WriteLine("");
                int resultado = int.Parse(Console.ReadLine());

                switch (resultado)
                {
                    case 0:
                        azureDevOps.SubirCodigo();
                        break;
                    case 1:
                        azureDevOps.AgregarSuscriptor(compilador);
                        break;
                    case 2:
                        azureDevOps.AgregarSuscriptor(ejecutorPruebasUnitarias);
                        break;
                    case 3:
                        azureDevOps.AgregarSuscriptor(instalador);
                        break;
                    case 4:
                        azureDevOps.AgregarSuscriptor(notificador);
                        break;
                    case 5:
                        salir = false;
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}

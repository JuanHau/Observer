using Observador.Suscriptores.Interfaces;
using System;

namespace Observador.Suscriptores
{
    public class Instalador : ISuscriptor
    {
        public void EjecutarAccion()
        {
            Console.WriteLine("Se ha instalado la versión 1.1");
        }
    }
}

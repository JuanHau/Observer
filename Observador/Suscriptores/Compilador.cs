using Observador.Suscriptores.Interfaces;
using System;

namespace Observador.Suscriptores
{
    public class Compilador : ISuscriptor
    {
        public void EjecutarAccion()
        {
            Console.WriteLine("Compilación de código correcta");
        }
    }
}

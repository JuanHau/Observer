using Observador.Suscriptores.Interfaces;
using System;

namespace Observador.Suscriptores
{
    public class Notificador : ISuscriptor
    {
        public void EjecutarAccion()
        {
            Console.WriteLine("Existe una actualización de código: Versión 1.1");
        }
    }
}

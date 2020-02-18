using Observador.Suscriptores.Interfaces;
using System;

namespace Observador.Suscriptores
{
    public class EjecutorPruebasUnitarias : ISuscriptor
    {
        public void EjecutarAccion()
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas");
        }
    }
}

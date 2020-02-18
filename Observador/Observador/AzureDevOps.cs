using Observador.Observador.Interfaces;
using Observador.Suscriptores.Interfaces;
using System;
using System.Collections.Generic;

namespace Observador.Observador
{
    public class AzureDevOps : IAzureDevOps
    {
        private readonly List<ISuscriptor> _suscriptores = new List<ISuscriptor>();

        public void AgregarSuscriptor(ISuscriptor suscriptor)
        {
            _suscriptores.Add(suscriptor);
        }

        public void RemoverSuscriptor(ISuscriptor suscriptor)
        {
            _suscriptores.Remove(suscriptor);
        }

        public void NotificarSuscriptores()
        {
            foreach (ISuscriptor suscriptor in _suscriptores)
            {
                suscriptor.EjecutarAccion();
            }
        }

        public void SubirCodigo()
        {
            Console.WriteLine("Commit de código de la versión 1.1");

            NotificarSuscriptores();
        }
    }
}

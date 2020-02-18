using Observador.Suscriptores.Interfaces;

namespace Observador.Observador.Interfaces
{
    public interface IAzureDevOps
    {
        void AgregarSuscriptor(ISuscriptor suscriptor);
        void RemoverSuscriptor(ISuscriptor suscriptor);
        void NotificarSuscriptores();
        void SubirCodigo();
    }
}

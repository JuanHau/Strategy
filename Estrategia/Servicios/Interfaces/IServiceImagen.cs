using Estrategia.Tipos.Interfaces;

namespace Estrategia.Servicios.Interfaces
{
    public interface IServiceImagen
    {
        void GuardarImagen(IImagen imagen);
        int EstablecerPropiedadImagen();
    }
}

using Estrategia.Tipos.Interfaces;

namespace Estrategia.Tipos
{
    public class ImagenPng : IImagen
    {
        public string Nombre { get; set; }
        private readonly string _extension = "PNG";

        public string GuardarImagen()
        {
            return string.Format("{0}.{1}", Nombre, _extension);
        }
    }
}

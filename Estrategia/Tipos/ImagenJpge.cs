using Estrategia.Tipos.Interfaces;

namespace Estrategia.Tipos
{
    public class ImagenJpge : IImagen
    {
        public string Nombre { get; set; }
        private readonly string _extension = "JPGE";

        public string GuardarImagen()
        {
            return string.Format("{0}.{1}", Nombre, _extension);
        }
    }
}

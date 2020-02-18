using Estrategia.Tipos.Interfaces;

namespace Estrategia.Tipos
{
    public class ImagenBpm : IImagen
    {
        private readonly string _extension = "BPM";

        public string Nombre { get; set; }

        public string GuardarImagen()
        {
            return string.Format("{0}.{1}", Nombre, _extension);
        }
    }
}

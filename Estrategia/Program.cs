using Estrategia.Servicios;
using Estrategia.Tipos;

namespace Estrategia
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ServiceImagen serviceImagen = new ServiceImagen();
            int tipo = serviceImagen.EstablecerPropiedadImagen();
            switch (tipo)
            {
                case 1:
                    ImagenBpm imagenBmp = new ImagenBpm();
                    serviceImagen.GuardarImagen(imagenBmp);
                    break;
                case 2:
                    ImagenJpge imagenJpge = new ImagenJpge();
                    serviceImagen.GuardarImagen(imagenJpge);
                    break;
                case 3:
                    ImagenPng imagenPng = new ImagenPng();
                    serviceImagen.GuardarImagen(imagenPng);
                    break;
            }
        }
    }
}

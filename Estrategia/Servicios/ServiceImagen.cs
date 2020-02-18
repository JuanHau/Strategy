using Estrategia.Servicios.Interfaces;
using Estrategia.Tipos.Interfaces;
using System;

namespace Estrategia.Servicios
{
    public class ServiceImagen : IServiceImagen
    {
        private string _nombre;

        public int EstablecerPropiedadImagen()
        {
            Console.WriteLine("Ingrese el tipo (bpm, png, jpge)");
            string tipoString = Console.ReadLine();
            int tipo = tipoString switch
            {
                "bpm" => 1,
                "png" => 3,
                "jpge" => 2,
                _ => 1,
            };

            Console.WriteLine("Ingrese el nombre de la imagen");
            _nombre = Console.ReadLine();
            return tipo;
        }

        public void GuardarImagen(IImagen imagen)
        {
            imagen.Nombre = _nombre;

            Console.WriteLine(imagen.GuardarImagen());
        }
    }
}

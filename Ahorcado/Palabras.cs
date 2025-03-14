using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Palabras
    {
        private string[] bancodePalabras = { "Argentina", "Brasil", "Colegio", "Dentista", "Futbol", "Universidad" };
        private string[] descripciones = {
            "País en Sudamérica conocido por su tango y fútbol.",
            "País en Sudamérica famoso por su Carnaval y la Amazonía.",
            "Institución educativa donde se enseña desde primaria hasta secundaria.",
            "Profesional de la salud que cuida los dientes y la boca.",
            "Deporte que se juega entre dos equipos de 11 jugadores con una pelota.",
            "Institución educativa de nivel superior, donde se obtienen grados académicos."
         };

        public int generarNumeroRandom()
        {
            Random numero = new Random();
            int numeroRandom = numero.Next(bancodePalabras.Length);
            return numeroRandom;

        }
        public string escogerPalabra()
        {
            string palabraElegida = bancodePalabras[generarNumeroRandom()].ToLower();
            
            return palabraElegida;
        }
        public string descripcion()
        {
            string descripcionPalabra = descripciones[generarNumeroRandom()];
            return descripcionPalabra;
        }

        public string[] palabraElegidaOculta()
        {
            string[] palabraAdivinada = new string[escogerPalabra().Length];
            for (int i = 0; i < escogerPalabra().Length; i++)
            {

                palabraAdivinada[i] = "_";

            }
            palabraAdivinada[generarNumeroRandom()] = escogerPalabra()[generarNumeroRandom()].ToString();
            return palabraAdivinada;
        
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Juego
    {
        private Palabras palabra = new Palabras();
        private int intentos;
        private string palabraAadivinar;
        private string descripcionPalabra;
        
        public Juego()
        {

            palabraAadivinar = palabra.escogerPalabra();
            descripcionPalabra = palabra.descripcion();
            intentos = 3;
        }

        
        public void restarIntentos()
        {
            intentos = intentos - 1;
        }
        
        public void jugar()
        {

            string[] palabraAdivinada = palabra.palabraElegidaOculta();

            Console.WriteLine(descripcionPalabra);
            
            while (true)
            {
                Console.WriteLine("Intentos: " + intentos + "\n");
                
                Console.WriteLine(string.Join(" ", palabraAdivinada)+ "\n");
                Console.WriteLine("Letra: ");
                string entrada = Console.ReadLine().ToLower();
                Console.WriteLine();
                
                char letra = entrada[0];
                bool letraEncontrada = false;

                for (int i = 0; i < palabraAadivinar.Length; i++)
                {

                    if (palabraAadivinar[i] == letra && palabraAdivinada[i] =="_" )
                    {
                        palabraAdivinada[i] = entrada[0].ToString();
                        letraEncontrada = true;
                        
                    }
                    
                }
                if (!letraEncontrada)
                {
                    restarIntentos();
                }

                if(string.Join("",palabraAdivinada) == palabraAadivinar)
                {
                    Console.WriteLine(string.Join(" ", palabraAdivinada));
                    Console.WriteLine("Ganaste el juego");
                    break;
                }

                if(intentos == 0)
                {
                    Console.WriteLine("Se te acabo el juego");
                    Console.WriteLine("La palabra era: " + palabraAadivinar);
                    break;

                }

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Juego
    {
        private Palabras palabra;
        private int intentos;

        public Juego()
        {
            palabra = new Palabras();
            intentos = 3;
        }

        
        public void setIntentos()
        {
            intentos = intentos - 1;
        }
        
        

        public void jugar()
        {
            string palabraAadivinar = palabra.escogerPalabra().ToLower();
            string descripcion = palabra.descripcion();
            string[] palabraAdivinada = new string[palabraAadivinar.Length];
            
            Console.WriteLine(descripcion);
            for (int i = 0; i < palabraAadivinar.Length; i++)
            {
                palabraAdivinada[i] = "_";

            }


            
            
            while (true)
            {
                Console.WriteLine("Intentos: " + intentos);
                Console.WriteLine("Letra: ");
                Console.WriteLine(string.Join(" ", palabraAdivinada));
                string entrada = Console.ReadLine().ToLower();
                char letra = entrada[0];
                bool letraEncontrada = false;
                for (int i = 0; i < palabraAadivinar.Length; i++)
                {

                    if (palabraAadivinar[i] == letra)
                    {
                        palabraAdivinada[i] = entrada;
                        letraEncontrada = true;
                    }
                    
                }
                if (!letraEncontrada)
                {
                    setIntentos();
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

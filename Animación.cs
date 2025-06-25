using System;
using System.Threading;

namespace Test___Estilo_de_Aprendizaje___VAK
{
    class Animación
    {
        public static void parpadeo(string texto, int vecesQueSeRepite = 5)
        {
            Console.CursorVisible = false;
            for (int i = 0; i < vecesQueSeRepite; i++)
            {
                Console.WriteLine(texto);
                Thread.Sleep(500);
                Console.Clear();
                Thread.Sleep(200);
            }
            Console.WriteLine(texto);
            Console.CursorVisible = true;
        }

        public static void Typing(string text, int retraso = 25)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(retraso);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo Keyinfo = Console.ReadKey(true);
                    Console.Write(text.Substring(i++)); break;
                }
            }
        }

        public static void PresioneColor(string mensaje = "Presione una tecla para continuar", bool Readkey = true)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t    " + mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;

            if (Readkey)
                Console.ReadKey(true);
        }

        public static void PresioneEnter(string tecla = " tecla ", string salto = " para saltarse la animación")
        {
            Console.Write("           presione una "); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(tecla); Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(salto + "\n\n");
        }
    }
}


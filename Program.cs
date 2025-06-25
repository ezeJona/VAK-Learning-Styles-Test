using System;
using System.Threading;

namespace Test___Estilo_de_Aprendizaje___VAK
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] item = 
            {{"¿Qué actividades disfruto más en mi tiempo libre?","En mi tiempo libre disfruto mas __________________"},
            {"Cuándo tratas de recordar algo ¿De qué manera lo haces?", "__________________________ suelo recordar las cosas"},
            {"¿A qué eventos te gusta asistir más?","Me gusta asistir ____________________________"},
            {"En tu tiempo libre, ¿Qué te gusta hacer?","__________________ lo hago en mi tiempo libre"},
            {"¿Qué prefieres?","Prefiero ______________________________ en mis vacaciones de fin de año"}};

            /*Console.WriteLine(item.Length);
            Console.WriteLine();
            Console.ReadKey(true);*/

            string[,] opciones = new string[15, 2] 

           {{"\n  Ver películas     ".PadRight(32,'-') + " A" , "ver películas"}, 
               {" Escuchar la radio ".PadRight(30,'-') + " B" , "escuchar la radio"},
               {" Bailar mucho      ".PadRight(30,'-') + " C" , "bailar mucho"},

            {"\n  A través de imágenes    ".PadRight(32,'-') + " A" , "a través de imágenes"},
               {" A través de sonidos     ".PadRight(30,'-') + " B" , "a través de sonidos"},
               {" A través de emociones   ".PadRight(30,'-') + " C" , "a través de emociones"},
           
            {"\n  A una exposición de arte ".PadRight(32,'-') + " A" , "a una exposición de arte"}, 
               {" A una coferencia         ".PadRight(30,'-') + " B" , "a una coferencia"},
               {" A un baile               ".PadRight(30,'-') + " C" , "a un baile"},
           
            {"\n  Ver series       ".PadRight(32,'-') + " A" , "ver series"}, 
               {" Escuchar música  ".PadRight(30,'-') + " B" , "escuchar música"},
               {" Leer algún libro ".PadRight(30,'-') + " C" , "leer algún libro"},
           
            {"\n  Ir a un museo            ".PadRight(32,'-') + " A" , "ir a un museo"}, 
               {" Ir a un concierto        ".PadRight(30,'-') + " B" , "ir a un concierto"},
               {" Participar en un maratón ".PadRight(30,'-') + " C" , "participar en un maratón"}};

            string[] respuestaS = new string[item.Length];
            int[,] respuestaC = new int[15, 1];

            //[0] = Visual, [1] = Auditivo, [2] Kinéstésico;
            int[] Suma = new int[3] { 0, 0, 0 };

            string unanManagua = @"

           ██╗   ██╗    ███╗   ██╗     █████╗     ███╗   ██╗    
           ██║   ██║    ████╗  ██║    ██╔══██╗    ████╗  ██║    
           ██║   ██║    ██╔██╗ ██║    ███████║    ██╔██╗ ██║    
           ██║   ██║    ██║╚██╗██║    ██╔══██║    ██║╚██╗██║    
           ╚██████╔╝    ██║ ╚████║    ██║  ██║    ██║ ╚████║    
            ╚═════╝     ╚═╝  ╚═══╝    ╚═╝  ╚═╝    ╚═╝  ╚═══╝  
              __  __                                     
             |  \/  | __ _  _ _   __ _  __ _  _  _  __ _ 
             | |\/| |/ _` || ' \ / _` |/ _` || || |/ _` |
             |_|  |_|\__,_||_||_|\__,_|\__, | \_,_|\__,_|
                                        |___/              
";
            Animación.parpadeo(unanManagua, 3);
            Animación.PresioneEnter();

            Animación.Typing(@"          Este test esta diseñado para identificar tus estilos
          de aprendizaje según el modelo VAK


          Lea detenidamente las siguientes intrucciones:" + "\n"
, 50);

            Animación.PresioneColor();

            Console.Clear();
            Console.WriteLine(unanManagua);
            Animación.PresioneEnter();

            Animación.Typing(@"          El test esta enfocado en el modelo de Blander y Grinder
          que se centra en 3 canales de aprendizaje: Visual,
          Auditivo y Kinestésico, basado en la programación
          Neurolingüística que nos facilita la comprensión 
          de las vias preferentes de entrada, procesamiento y 
          salida de la información.

", 50);

            Animación.PresioneColor();

            Console.Clear();
            Console.WriteLine(unanManagua);
            Animación.PresioneEnter();

            Animación.Typing(@"          Tenga en cuenta lo siguiente a la hora de realizar su test:
    
        1. no existen respuestas correctas ni incorrectas.
           Por favor, responda usted verdaderamente cada
           cada pregunta. Seleccionar cada respuesta, según
           lo que piense que sea la respuesta correcta en 
           cada uno de los enunciados e valoraciones del
           cuestionario.

        2. El inventario cuenta con diferentes formas para
           su elaboración y estas son: Selección única,
           Selección Múltiple y Complete, usted deberá 
           elegir la forma de elaboración que desee. 
", 50);

            Animación.PresioneColor();

            int t = 0, r = 0, p = 0, U = 20, i = 0, opc = 0;
            string prueba = "";

            try
            {

                do
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(unanManagua);
                        Console.WriteLine("\n\t\t  Menú \n");
                        Console.WriteLine("\n\t 1. Selección Unica");
                        Console.WriteLine("\n\t 2. Selección Múltiple");
                        Console.WriteLine("\n\t 3. Complete");
                        Console.WriteLine("\n\t 4. Salir");

                        Console.SetCursorPosition(40, 19);
                        Console.Write("(        )");

                        Console.SetCursorPosition(44, 19);
                        prueba = Console.ReadLine();

                        opc = 0;

                        if (prueba != "1" && prueba != "2" && prueba != "3" && prueba != "4")
                        {
                            Console.SetCursorPosition(40, 25);
                            Console.WriteLine("\n\tEl dato que ingreso no es valido");
                            Animación.PresioneColor();
                            continue;
                        }

                        opc = Convert.ToInt32(prueba);
                        if (opc == 4)
                            break;

                        t = 0; r = 0; p = 0; U = 17; i = 0;
                        Suma[0] = 0; Suma[1] = 0; Suma[2] = 0;

                    } while (opc != 1 && opc != 2 && opc != 3);

                    switch (opc)
                    {
                        case 1:

                            r = 1;
                            for (i = 0; i < 5; i++)
                            {
                                do
                                {

                                    //Item selección única

                                    Console.Clear();
                                    Console.WriteLine(unanManagua);

                                    Animación.PresioneColor("Responda \"A\", \"B\" o \"C\" según considere correcto \n",false);
                                    Console.WriteLine("\n " + (i + 1) + " " + item[i, 0]);

                                    do
                                    {
                                        Console.Write(" " + opciones[t, 0]);
                                        Console.WriteLine();
                                        t += 1;
                                        p++;
                                    } while (p <= 2);

                                    Console.SetCursorPosition(40, 21);
                                    Console.Write("(        )");

                                    Console.SetCursorPosition(44, 21);
                                    respuestaS[i] = Console.ReadLine().ToUpper();


                                    if (respuestaS[i] != "A" && respuestaS[i] != "B" && respuestaS[i] != "C" && respuestaS[i] != null)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("\n\n\tEl dato que usted ingreso no es valido");
                                        Animación.PresioneColor();

                                        t -= 3; p = 0; r = 1;
                                        continue;
                                    }

                                    Console.WriteLine("\n\n\n\tUsted ingreso " + respuestaS[i]);
                                    Animación.PresioneColor();

                                    if (respuestaS[i] == "A")
                                        Suma[0] += 10;
                                    else if (respuestaS[i] == "B")
                                        Suma[1] += 10;
                                    else if (respuestaS[i] == "C")
                                        Suma[2] += 10;

                                    p = 0;
                                } while (respuestaS[i] != "A" && respuestaS[i] != "B" && respuestaS[i] != "C" && respuestaS[i] != null);
                            }
                            Console.Clear();
                            Console.WriteLine(unanManagua);

                            //Aqui inicia el modulo de los resultados del test

                            Console.WriteLine("\n\t  El test ha terminado, vea sus resultados:");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t  ____________________________________________");
                            Console.WriteLine("\t | Pregunta | Auditivo | Visual | Kinéstesico |");
                            Console.WriteLine("\t |──────────┼──────────┼────────┼─────────────|");

                            for (int j = 0; j < 5; j++)
                            {
                                if (respuestaS[j] == "A")
                                {
                                    Console.WriteLine("\t |     " + (j + 1) + "    |    10    |        |             |", j);
                                    Console.WriteLine("\t |──────────┼──────────┼────────┼─────────────|");
                                }
                                else if (respuestaS[j] == "B")
                                {
                                    Console.WriteLine("\t |     " + (j + 1) + "    |          |   10   |             |", j);
                                    Console.WriteLine("\t |──────────┼──────────┼────────┼─────────────|");
                                }
                                else
                                {
                                    Console.WriteLine("\t |     " + (j + 1) + "    |          |        |      10     |", j);
                                    Console.WriteLine("\t |──────────┼──────────┼────────┼─────────────|");
                                }
                            }

                            Console.WriteLine("\t |   TOTAL  |    {0}    |   {1}   |     {2}      |", Suma[0], Suma[1], Suma[2]);
                            Console.WriteLine("\t  ---------------------------------------------");

                            break;
                        case 2:

                            //Intrucción
                            Console.Clear();
                            Console.WriteLine(unanManagua);
                            Animación.PresioneEnter();

                            Animación.Typing(@"          Puedes escoger entre los puntajes ""1"", ""2"" o ""3"".
          En el espacio destinado para que ingrese su respuesta,
          Responda el número que mejor describa cómo se aplica
          cada declaración en usted. Responde honestamente, no 
          hay respuestas correctas o incorrectas"

, 50);
                            Console.WriteLine("\t\n                      _______________________________ ");
                            Console.WriteLine("\t             | Calificación de equivalencias |");
                            Console.WriteLine("\t             |                               |");
                            Console.WriteLine("\t             |   Puntaje      | Preferencias |");
                            Console.WriteLine("\t             |────────────────┼──────────────|");
                            Console.WriteLine("\t             |       1        |   Muy bajo   |");
                            Console.WriteLine("\t             |────────────────┼──────────────|");
                            Console.WriteLine("\t             |       2        |     Bajo     |");
                            Console.WriteLine("\t             |────────────────┼──────────────|");
                            Console.WriteLine("\t             |       3        |   Muy alto   |");
                            Console.WriteLine("\t              -------------------------------");

                            Animación.PresioneColor();
                            do
                            {
                                //Item selección múltiple
                                Console.Clear();
                                Console.WriteLine(unanManagua);

                                Animación.PresioneColor("Puedes escoger entre los puntajes \"1.\", \"2\" o \"3\" \n", false);
                                Console.WriteLine("\n" + (i + 1) + " " + item[i, 0]);
                                p = 0;
                                do
                                {
                                    Console.Write(" " + opciones[t, 0]);
                                    Console.Write(" (     ) \n");
                                    t += 1; p++;
                                } while (p <= 2);

                                p = 0; U = 20;
                                do
                                {
                                    Console.SetCursorPosition(37, U);
                                    respuestaS[p] = Console.ReadLine();
                                    if (respuestaS[p] != "1" && respuestaS[p] != "2" && respuestaS[p] != "3")
                                    {
                                        Console.SetCursorPosition(35, U);
                                        Console.Write("     ");
                                        continue;
                                    }

                                    if (p != 0)
                                    {
                                        if (respuestaS[p] == respuestaS[0])
                                        {
                                            Console.SetCursorPosition(35, U);
                                            Console.Write("     ");
                                            continue;
                                        }

                                        if (p == 2)
                                        {
                                            if (respuestaS[p] == respuestaS[0])
                                            {
                                                Console.SetCursorPosition(35, U);
                                                Console.Write("     ");
                                                continue;
                                            }
                                            else if (respuestaS[p] == respuestaS[1])
                                            {
                                                Console.SetCursorPosition(35, U);
                                                Console.Write("     ");
                                                continue;
                                            }
                                        }

                                    }
                                    respuestaC[r, 0] = Convert.ToInt32(respuestaS[p]);
                                    Suma[p] += respuestaC[r, 0];
                                    p++; U++; r++;
                                } while (p <= 2);

                                i++;

                                Animación.PresioneColor();

                            } while (i < 5);

                            //Aqui inicia el modulo de los resultados del test

                            Console.Clear();
                            Console.WriteLine(unanManagua);
                            Console.WriteLine("\n\tEl test ha terminado, vea sus resultados:");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t  ____________________________________________");
                            Console.WriteLine("\t | Pregunta | Auditivo | Visual | Kinéstesico |");
                            Console.WriteLine("\t |──────────┼──────────┼────────┼─────────────|");
                            Console.WriteLine("\t |    1     |    " + (respuestaC[0, 0]) + "     |    " + (respuestaC[1, 0]) + "   |      " + (respuestaC[2, 0]) + "      |");
                            Console.WriteLine("\t |──────────┼──────────┼────────┼─────────────|");

                            i = 1;

                            for (int j = 2; j <= 11; j++)
                            {
                                Console.WriteLine("\t |    " + (i += 1) + "     |    " + (respuestaC[j += 1, 0]) + "     |    " + (respuestaC[j += 1, 0]) + "   |      " + (respuestaC[j + 1, 0]) + "      |");
                                Console.WriteLine("\t |──────────┼──────────┼────────┼─────────────|");
                            }

                            if (Convert.ToString(Suma[0]).Length == 1)
                                Console.Write("\t |  TOTAL   |    {0}     ", Suma[0]);

                            else
                                Console.Write("\t |  TOTAL   |   {0}     ", Suma[0]);

                            if (Convert.ToString(Suma[1]).Length == 1)
                                Console.Write("|    {0}   ", Suma[1]);

                            else
                                Console.Write("|   {0}   ", Suma[1]);

                            if (Convert.ToString(Suma[2]).Length == 1)
                                Console.Write("|      {0}      |", Suma[2]);

                            else
                                Console.Write("|     {0}      |", Suma[2]);

                            Console.WriteLine("\n\t  --------------------------------------------");



                            break;

                        case 3:

                            // item complete
                            for (i = 0; i <= 4; i++)
                            {
                                Console.Clear();
                                Console.WriteLine(unanManagua);

                                Animación.PresioneColor("Completar el enunciado segun lo indique y considere correcto \n", false);
                                Console.WriteLine("\n" + (i + 1) + " " + item[i, 1]);

                                for (p = 0; p <= 2; p++)
                                {
                                    Console.WriteLine(" " + opciones[t, 0]);
                                    t += 1;
                                }

                                if (i == 0)
                                    Console.SetCursorPosition(34, 18);
                                else if (i == 1)
                                    Console.SetCursorPosition(2, 18);
                                else if (i == 2)
                                    Console.SetCursorPosition(19, 18);
                                else if (i == 3)
                                    Console.SetCursorPosition(2, 18);
                                else
                                    Console.SetCursorPosition(11, 18);

                                respuestaS[i] = Console.ReadLine().ToLower();

                                if (respuestaS[i] == opciones[t - 3, 1])
                                    Suma[0] += 10;
                                else if (respuestaS[i] == opciones[t - 2, 1])
                                    Suma[1] += 10;
                                else if (respuestaS[i] == opciones[t - 1, 1])
                                    Suma[2] += 10;
                                else
                                {
                                    Console.SetCursorPosition(15, 24);
                                    Console.WriteLine("El dato que ingreso no es valido");
                                    Console.SetCursorPosition(15, 25);
                                    Animación.PresioneColor();
                                    t -= 3; i -= 1;

                                }

                            }

                            Console.Clear();
                            Console.WriteLine(unanManagua);

                            //Aqui inicia el modulo de los resultados del test

                            Console.WriteLine("\n\t  El test ha terminado, vea sus resultados:");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t  __________________________________________________");
                            Console.WriteLine("\t | Pregunta  |  Auditivo  |  Visual  |  Kinéstesico |");
                            Console.WriteLine("\t |───────────┼────────────┼──────────┼──────────────|");

                            if (respuestaS[0] == opciones[0, 1])
                            {
                                Console.WriteLine("\t |     1     |     10     |          |              |", i);
                                Console.WriteLine("\t |───────────┼────────────┼──────────┼──────────────|");
                            }
                            else if (respuestaS[0] == opciones[1, 1])
                            {
                                Console.WriteLine("\t |     1     |            |    10    |              |", i);
                                Console.WriteLine("\t |───────────┼────────────┼──────────┼──────────────|");
                            }
                            else if (respuestaS[0] == opciones[2, 1])
                            {
                                Console.WriteLine("\t |     1     |            |          |       10      |", i);
                                Console.WriteLine("\t |───────────┼────────────┼──────────┼───────────────|");
                            }

                            p = 2;

                            for (i = 1; i < 5; i++)
                            {
                                if (respuestaS[i] == opciones[p + 1, 1])
                                {
                                    Console.WriteLine("\t |     " + (i + 1) + "     |     10     |          |              |", i);
                                    Console.WriteLine("\t |───────────┼────────────┼──────────┼──────────────|");
                                }
                                else if (respuestaS[i] == opciones[p + 2, 1])
                                {
                                    Console.WriteLine("\t |     " + (i + 1) + "     |            |    10    |              |");
                                    Console.WriteLine("\t |───────────┼────────────┼──────────┼──────────────|");
                                }

                                else if (respuestaS[i] == opciones[p + 3, 1])
                                {
                                    Console.WriteLine("\t |     " + (i + 1) + "     |            |          |      10      |");
                                    Console.WriteLine("\t |───────────┼────────────┼──────────┼──────────────|");
                                }

                                p = p + 3;
                            }

                            Console.WriteLine("\t |   TOTAL   |     {0}     |    {1}    |      {2}      |", Suma[0], Suma[1], Suma[2]);
                            Console.WriteLine("\t  --------------------------------------------------");

                            break;

                        case 4:

                            // Salir

                            Console.Clear();
                            Console.WriteLine(unanManagua);
                            Animación.PresioneEnter();

                            Animación.Typing(@"          ¡Muchas gracias por tomarte el tiempo para completar el test!

          Esta investigación es importante porque ayuda a 
          mejorar nuestra compresión de los estilos de 
          aprendizaje y queremos incentivar a investigar y 
          desarrollar sus estilos, combinándolos o perfeccionandolo.
          Si algún día no entienden algo en la forma en que les
          enseñaron sus docentes, busquen ustedes mismos su
          estilo para mejorar en aquellas areas donde se les
          dificulta su aprendizaje.

", 50);
                            Animación.PresioneColor("Presione una tecla para salir");
                            break;
                    }

                    if (opc == 4)
                        break;

                    // Aqui inicia el proceso para encontrar el resultado del usuario.

                    Console.WriteLine();
                    Console.WriteLine("\t      Visual      ".PadRight(35, '-') + (Suma[1] * 100 / 50) + "%");
                    Console.WriteLine("\t      Auditivo    ".PadRight(35, '-') + (Suma[0] * 100 / 50) + "%");
                    Console.WriteLine("\t      Kinestésico ".PadRight(35, '-') + (Suma[2] * 100 / 50) + "%");
                    Console.WriteLine();

                    if (Suma[0] > Suma[1])
                        if (Suma[0] > Suma[2])
                            Console.WriteLine("\t  Su estilo es auditivo");
                        else
                            if (Suma[0] == Suma[2])
                                Console.WriteLine("\t  Tiene dos estilos: auditivo y kinestésico");
                            else
                                Console.WriteLine("\t  Su estilo es Kinestésico");
                    else
                        if (Suma[0] == Suma[1])
                            if (Suma[0] > Suma[2])
                                Console.WriteLine("\t  Tiene dos estilos: Auditivo y visual");
                            else
                                if (Suma[0] == Suma[2])
                                    Console.WriteLine("\t  Tiene los estilos visual, auditivo y kinéstesico desarrollados");
                                else
                                    Console.WriteLine("\t  Su estilo es Kinestésico");
                        else
                            if (Suma[1] > Suma[2])
                                Console.WriteLine("\t  su estilo es Visual");
                            else
                                if (Suma[1] == Suma[2])
                                    Console.WriteLine("\t  Tiene dos estilos: visual y kinestésico");
                                else
                                    Console.WriteLine("\t  Su estilo es kinestesico");

                    Animación.PresioneColor();

                } while (opc != 4);

            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine(unanManagua);

                Animación.PresioneColor("Algo ha ocurrido mal, por favor intentelo de nuevo", false);
                Animación.PresioneColor();
            }
        }
    }
}
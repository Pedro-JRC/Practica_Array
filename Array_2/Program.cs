using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES

            // ARRAY 1
            int[] array1 = { };
            string digitaLongA1;
            int longitudA1;
            string digitaDatosA1;
            int datosA1;
            int indice1 = 0;

            // ARRAY 2
            int[] array2 = { };
            string digitaLongA2;
            int longitudA2;
            string digitaDatosA2;
            int datosA2;
            int indice2 = 0;

            // MENSAJE ERROR
            string mensajeError = "ERROR: Favor ingrese datos validos";

            //-----------------------------------------------------------------//
            // INICIO

            try
            {
                // SOLICITA LA LONGITUD DEL ARREGLO [1]
                Console.WriteLine("Favor ingrese la longitud del arreglo [1]");
                digitaLongA1 = Console.ReadLine();

                // ESPACIO
                Console.WriteLine();

                // VALIDACIONES
                if (int.TryParse(digitaLongA1, out longitudA1) && longitudA1 > 0)
                {
                    // INDICA EL INDICE DEL ARREGLO
                    array1 = new int[longitudA1];

                    // BUCLE PARA SOLICITAR DATOS DEL ARREGLO
                    for (int iA1 = 0; iA1 < longitudA1; iA1++)
                    {
                        // SOLICITA LOS DATOS DEL ARREGLO
                        Console.Write($"Favor ingrese el numero [{iA1 + 1}] del arreglo [1]: ");
                        digitaDatosA1 = Console.ReadLine();

                        // VALIDACIONES
                        if (int.TryParse(digitaDatosA1, out datosA1) && datosA1 > 0)
                        {
                            array1[iA1] = datosA1;
                        }
                        else
                        {
                            // MUESTRA MENSAJE DE ERROR
                            Console.WriteLine($"{mensajeError}");
                        }

                    }
                }
                else
                {
                    // MUESTRA MENSAJE DE ERROR
                    Console.WriteLine($"{mensajeError}");
                }

                // ESPACIO
                Console.WriteLine();

                // CARGA DATOS DEL ARREGLO 2

                // SOLICITA LA LONGITUD DEL ARREGLO [1]
                Console.WriteLine("Favor ingrese la longitud del arreglo [2]");
                digitaLongA2 = Console.ReadLine();

                // ESPACIO
                Console.WriteLine();

                // VALIDACIONES
                if (int.TryParse(digitaLongA2, out longitudA2) && longitudA2 > 0)
                {
                    // INDICA EL INDICE DEL ARREGLO
                    array2 = new int[longitudA2];

                    // BUCLE PARA SOLICITAR DATOS DEL ARREGLO
                    for (int iA2 = 0; iA2 < longitudA2; iA2++)
                    {
                        // SOLICITA LOS DATOS DEL ARREGLO
                        Console.Write($"Favor ingrese el numero [{iA2 + 1}] del arreglo [2]: ");
                        digitaDatosA2 = Console.ReadLine();

                        // VALIDACIONES
                        if (int.TryParse(digitaDatosA2, out datosA2) && datosA2 > 0)
                        {
                            // ASIGNA EL VALOR DEL ARREGLO
                            array2[iA2] = datosA2;
                        }
                        else
                        {
                            // MUESTRA MENSAJE DE ERROR
                            Console.WriteLine($"{mensajeError}");
                        }

                    }
                }
                else
                {
                    // MUESTRA MENSAJE DE ERROR
                    Console.WriteLine($"{mensajeError}");
                }

                // MENSAJE RESULTADO DE ARREGLOS
                Console.WriteLine("\nResultado de los arreglos:");

                //MENSAJE PARA MOSTRAR DATOS DEL AREREGLO 1
                Console.WriteLine("\nArreglo 1");
                Console.WriteLine("____________________");

                // MUESTRA LOS DATOS DEL ARREGLO 1
                foreach (int iA1 in array1)
                {
                    Console.WriteLine($"Indice: {indice1++} | Valor: {iA1}");
                }

                //MENSAJE PARA MOSTRAR DATOS DEL AREREGLO 2
                Console.WriteLine("\nArreglo 2");
                Console.WriteLine("____________________");

                // MUESTRA LOS DATOS DEL ARREGLO 2
                foreach (int iA2 in array2)
                {
                    Console.WriteLine($"Indice: {indice2++} | Valor: {iA2}");
                }

                // MENSAJE RESULTADO
                Console.WriteLine("\nResultado:");

                // CONDICION PARA VERIRIFCAR SI LA LONGITUD ES LA MISMA
                if (array1.Length != array2.Length)
                {
                    // MENSAJE EN CASO DE DESIGUALDAD
                    Console.WriteLine("Los arreglos son desiguales");
                }
                else
                {  
                    // BUCLE PARA RECORRER LOS DATOS DEL INDICE
                    for (int i = 0; i < array1.Length; i++)
                    {
                        if (array1[i] != array2[i])
                        {
                            // MENSAJE EN CASO DE DESIGUALDAD
                            Console.WriteLine("Los arreglos son desiguales");
                            return;
                        }

                    }

                    // MENSAJE EN CASO DE IGUALDAD
                    Console.WriteLine("Los arreglos son iguales");
                }
            }
            catch
            {
                // MUESTRA MENSAJE DE ERROR
                Console.WriteLine($"{mensajeError}");
            }
        }
    }
}

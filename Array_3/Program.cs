using System.Timers;

namespace Array_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES

            int[] numeros = { };
            string digitaCantNum;
            int cantNum;
            string datosDigita;
            int datosnum;
            int numeroMenor;
            

            string mensajeError = "Favor ingrese valores validos.";

            //---------------------------------------------------------------//
            // INICIO

            try
            {
                // SOLICITA LA CANTIDAD DE NUMEROS A DIGITAR
                Console.WriteLine("Favor ingrese la cantidad de numeros a digitar:");
                digitaCantNum = Console.ReadLine();

                // ESPACIO
                Console.WriteLine();

                // VALIDACIONES
                if (int.TryParse(digitaCantNum, out cantNum) && cantNum > 0)
                {
                    // INDICA EL INDICE DEL ARREGLO
                    numeros = new int[cantNum];

                    // BUCLE PARA SOLICITAR NUMEROS
                    for (int indice = 0; indice < cantNum; indice++)
                    {
                        // SOLICITA LOS NUMEROS
                        Console.Write($"Favor ingrese el numero [{indice + 1}]: ");
                        datosDigita = Console.ReadLine();

                        // VALIDACIONES
                        if (int.TryParse(datosDigita, out datosnum) && datosnum > 0)
                        {
                            // CARGA LOS NUMEROS DIGITADOS AL ARREGLO
                            numeros[indice] = datosnum;
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

                // LE DA UN VALOR A LA VARIABLE PARA COMPARARLO CON LOS DEMAS VALORES
                numeroMenor = numeros[0];

                // BUCLE PARA IDENTIFICAR EL NUMERO MENOR
                for (int indice = 0; indice < numeros.Length; indice++)
                {
                    // CONDICION PARA VERIFICAR EL NUMERO MENOR
                    if (numeros[indice] < numeroMenor)
                    {                 
                        numeroMenor = numeros[indice];
                    }                 
                }

                // MUESTRA EL NUMERO MENOR
                Console.WriteLine($"\nEl numero menor es el: [{numeroMenor}]");

                // MENSAJE DE NUMEROS REPETIDOS
                Console.Write("\nLos numeros repetidos son el: ");

                // BUCLE PARA IDENTIFICAR NUMEROS REPETIDOS
                for (int indice = 0; indice < numeros.Length; indice++)
                {
                    // BUCLE PARA IDENTIFICAR NUMEROS REPETIDOS
                    for (int duplicado = indice + 1; duplicado < numeros.Length; duplicado++)
                    {
                        if (numeros[indice] == numeros[duplicado])
                        {
                            Console.Write($"[{numeros[indice]}] ");
                        }
                    }
                }

                // ESPACIO
                Console.WriteLine();
            }
            catch
            {
                // MUESTRA MENSAJE DE ERROR
                Console.WriteLine($"{mensajeError}");
            }




        }
    }
}

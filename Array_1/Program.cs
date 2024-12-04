namespace Array_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // VARIABLES
                string cantNumerosDigita;
                int cantNumeros = 0;
                string numerosDigita;
                int numero = 0;
                int multiplo = 5;
                int[] numeros;

                //---------------------------------------------------------------//
                // INICIO
               

                
                // BUCLE EN CASO SE DIGITEN DATOS NO VALIDOS
                while (true)
                {
                    // SOLICITA LA CANTIDAD DE NUMEROS
                    Console.Write("Favor ingrese la cantidad de numeros a digitar: ");
                    cantNumerosDigita = Console.ReadLine();

                    //ESPACIO
                    Console.WriteLine();

                    // VALIDACIONES
                    if (int.TryParse(cantNumerosDigita, out cantNumeros) && cantNumeros > 0)
                    {
                        // INDICA EL INDICE DEL ARREGLO
                        numeros = new int[cantNumeros];

                        // BUCLE PARA SOLICITAR LOS NUMEROS
                        for (int i = 0; i < cantNumeros; i++)
                        {
                            // BUCLE EN CASO SE DIGITEN DATOS NO VALIDOS
                            while (true)
                            {
                                // SOLICITA LOS NUMEROS
                                Console.Write($"Favor introduce el numero ({i + 1}): ");
                                numerosDigita = Console.ReadLine();

                                // VALIDACIONES
                                if (int.TryParse(numerosDigita, out numero) && numero > 0)
                                {
                                    // CARGA EL NUMERO DIGITADO AL ARREGLO                           
                                    numeros[i] = numero * multiplo;
                                    break;
                                }
                                else
                                {
                                    // MENSAJE DE ERROR SI SE INTRODUCEN DATOS INVALIDOS
                                    Console.WriteLine("ERROR: Favor ingrese datos validos");
                                }
                            }


                        }
                        break;
                    }
                    else
                    {   // MENSAJE DE ERROR SI SE INTRODUCEN DATOS INVALIDOS
                        Console.WriteLine("ERROR: Favor ingrese datos validos");
                        
                    }

                    

                }

                //ESPACIO
                Console.WriteLine();

                // MENSAJE DE "RESULTADO"
                Console.WriteLine("Resultado del arreglo:");

                //ESPACIO
                Console.WriteLine();

                // BUCLE PARA IMPRIMIR EL ARREGLO E INDICAR EL INDICE DE CADA DATO
                for (int indice = 0; indice < numeros.Length; indice++)
                {
                    // MUESTRA EL INDICE Y EL VALOR DEL MISMO
                    Console.WriteLine($"Indice: ({indice}) | Valor: {numeros[indice]}.");
                }

            }
            catch 
            {   // MENSAJE DE ERROR SI SE INTRODUCEN DATOS INVALIDOS
                Console.WriteLine("ERROR: Favor ingrese datos validos");
            }
            
        }
    }
}

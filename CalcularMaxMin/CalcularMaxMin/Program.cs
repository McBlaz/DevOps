using Libreria_calcularmaxmin;
class Program
{
    static void Main(string[] args)
    {
        bool finalizaPrograma = false;

        Console.WriteLine("Calculadora de maximos y minimos\r");
        Console.WriteLine("--------------------------------\n");

        while (!finalizaPrograma)
        {
            float primerNumero;
            float segundoNumero;
            float tercerNumero;
            float resultadoMax = 0;
            float resultadoMin = 0;

            Console.Write("Introduzca el primer número y presione Enter: ");
            primerNumero = float.Parse(Console.ReadLine());
            float limpiarPrimero = 0;
            //este bucle indica que, si se ha introducido un valor no numerico, da error y pide otro
            //se repetira en cada caso
            while (!float.TryParse(primerNumero, out limpiarPrimero))
            {
                Console.Write("Error. Porfavor, introduzca otro número: ");
                primerNumero = float.Parse(Console.ReadLine());
            }

            Console.Write("Introduzca el segundo número y presione Enter: ");
            segundoNumero = float.Parse(Console.ReadLine());
            float limpiarSegundo = 0;
            while (!float.TryParse(segundoNumero, out limpiarSegundo))
            {
                Console.Write("Error. Porfavor, introduzca otro número: ");
                segundoNumero = float.Parse(Console.ReadLine());
            }

            Console.Write("Introduzca el tercer número y presione Enter: ");
            tercerNumero = float.Parse(Console.ReadLine());
            float limpiarTercero = 0;

            while (!float.TryParse(tercerNumero, out limpiarTercero))
            {
                Console.Write("Error. Porfavor, introduzca otro número: ");
                tercerNumero = float.Parse(Console.ReadLine());
            }

            //la interfaz de usuario
            Console.WriteLine("¿Qué desea saber?");
            Console.WriteLine("\ta - Máximo");
            Console.WriteLine("\tb - Mínimo");
            Console.WriteLine("\tc - Ambos");
            Console.WriteLine("\ts - Salir");

            string op = Console.ReadLine();
            switch (op)
            {
                case "a":
                    resultadoMax = maxmin.numeromax(primerNumero,segundoNumero, tercerNumero);
                    Console.WriteLine("El maximo es: " + resultadoMax);
                    break;

                case "b":
                    resultadoMin = maxmin.numeromin(primerNumero, segundoNumero, tercerNumero);
                    Console.WriteLine("El mínimo es: " + resultadoMin);
                    break;

                case "c":
                    resultadoMax = maxmin.numeromax(primerNumero, segundoNumero, tercerNumero);
                    resultadoMin = maxmin.numeromin(primerNumero, segundoNumero, tercerNumero);
                    Console.WriteLine("El maximo es: " + resultadoMax + " y el mínimo es: " + resultadoMin);
                    break;
                case "s":
                    Console.WriteLine("Saliendo");
                    finalizaPrograma = true;
                    break;
                default:
                    Console.WriteLine("Prueba de nuevo \n");
                    break;
            }
            try
            {
                //si el resultado no es un número ni la opción de salir dará error 
                if (float.IsNaN(resultadoMax) && float.IsNaN(resultadoMin))
                {
                    if (op != "s")
                        Console.WriteLine("Error.\n");
                }
                
            }
            //saldrá un mensaje automático
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido una excepción.\n" + e.Message);
            }
            Console.WriteLine("------------------------\n");

            

            Console.WriteLine("\n");
        }
        return;
    }
}
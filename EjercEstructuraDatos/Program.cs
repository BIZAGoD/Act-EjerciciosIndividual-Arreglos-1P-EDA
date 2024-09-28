namespace EjercEstructuraDatos;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("== Elija una de las opciones ==");
            Console.WriteLine("== 1. Invertir ==");
            Console.WriteLine("== 2. Buscar ==");
            Console.WriteLine("== 3. Pesos ==");
            Console.WriteLine("== 4. Promedio ==");
            Console.WriteLine("== 5. Sueldo ==");
            Console.WriteLine("== 6. Salir ==");
            
            
            bool siNumero = int.TryParse(Console.ReadLine(), out opcion);

            if (!siNumero || opcion < 1 || opcion > 6)
            {
                Console.WriteLine(" == Opción inválida Por favor, seleccione una opción valida == ");
                Console.WriteLine(" == Presione cualquier tecla para intentar de nuevo... ==");
                Console.ReadKey();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Invertir inv = new Invertir();
                    inv.MostrarResultado();
                    break;
                case 2:
                    Buscar busc = new Buscar();
                    busc.PedirNumero();                   
                    break;
                case 3:
                    Pesos pes = new Pesos();
                    pes.PreguntarPesos();
                    break;
                case 4:
                    Promedio prome = new Promedio();
                    prome.Notas();
                    break;
                case 5:
                    Sueldo suel = new Sueldo();
                    suel.SolicitarSueldo();
                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa...");
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine("\n== Presione cualquier tecla para volver al menú... ==");
            Console.ReadKey();
        }
        while (opcion != 6);
    }
}
namespace EjercEstructuraDatos;

public class Sueldo()
{
    public void SolicitarSueldo()
    {
        const int empleadosCount = 5;
        const int quincenasPorMes = 2; 
        const int meses = 5;
        const int quincenasTotales = quincenasPorMes * meses;

      
        string[] empleados = new string[empleadosCount];
        double[,] sueldos = new double[empleadosCount, quincenasTotales]; 
        double[] acumuladoSueldos = new double[empleadosCount];

        
        for (int i = 0; i < empleadosCount; i++)
        {
            Console.Clear();
            Console.WriteLine("== Sueldo de empleados ==");
            Console.Write($"Ingrese el nombre del empleado {i + 1}: ");
            empleados[i] = Console.ReadLine();

            double sumaSueldoEmpleado = 0;

            for (int j = 0; j < quincenasTotales; j++)
            {
                double sueldo;
                bool esValido = false;

                do
                {
                    Console.Write($"Ingrese el sueldo de la quincena {j + 1} para {empleados[i]}: ");
                    if (double.TryParse(Console.ReadLine(), out sueldo) && sueldo >= 0)
                    {
                        sueldos[i, j] = sueldo;
                        esValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un sueldo válido (número positivo o cero).");
                    }
                } while (!esValido);

                sumaSueldoEmpleado += sueldo;
            }

            acumuladoSueldos[i] = sumaSueldoEmpleado;
        }

        double totalPagado = 0;
        for (int i = 0; i < empleadosCount; i++)
        {
            totalPagado += acumuladoSueldos[i];
        }
        Console.WriteLine($"\nEl total pagado en sueldos a todos los empleados en los últimos 5 meses es: {totalPagado:C2}");

  
        double mayorIngreso = acumuladoSueldos[0];
        string empleadoMayorIngreso = empleados[0];

        for (int i = 1; i < empleadosCount; i++)
        {
            if (acumuladoSueldos[i] > mayorIngreso)
            {
                mayorIngreso = acumuladoSueldos[i];
                empleadoMayorIngreso = empleados[i];
            }
        }

        Console.WriteLine($"\nEl empleado con el mayor ingreso acumulado es {empleadoMayorIngreso} con un total de {mayorIngreso:C2}.");
    }
    
}
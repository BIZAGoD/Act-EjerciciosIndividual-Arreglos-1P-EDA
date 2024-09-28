namespace EjercEstructuraDatos;

public class Pesos()
{
    public void PreguntarPesos()
    {
        double[] pesos = new double[10];
        double sumaPesos = 0;
        double promedio = 0;

       
        for (int i = 0; i < pesos.Length; i++)
        {
            double peso;
            bool esValido = false;

        
            do
            {
                Console.Clear();
                Console.WriteLine("== Pesos de 10 Personas ==");
                Console.Write($"Ingrese el peso de la persona {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out peso) && peso > 0)
                {
                    pesos[i] = peso;
                    esValido = true;
                }
                else
                {
                    Console.WriteLine("Por favor ingrese un valor válido y mayor que 0.");
                }
            } while (!esValido);

            sumaPesos += pesos[i]; 
        }

        promedio = sumaPesos / pesos.Length;

        int mayoresQuePromedio = 0;
        int menoresQuePromedio = 0;

        for (int i = 0; i < pesos.Length; i++)
        {
            if (pesos[i] > promedio)
            {
                mayoresQuePromedio++;
            }
            else if (pesos[i] < promedio)
            {
                menoresQuePromedio++;
            }
        }
   
        Console.WriteLine($"\nEl promedio de los pesos es: {promedio:F2} kg.");
        Console.WriteLine($"Personas con peso mayor que el promedio: {mayoresQuePromedio}");
        Console.WriteLine($"Personas con peso menor que el promedio: {menoresQuePromedio}");
    }
    
}
namespace EjercEstructuraDatos;

public class Buscar()
{
    public void PedirNumero()
    {

        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int numero = 0;
        bool entradaValida = false;

        do
        {
            Console.Clear();
            Console.WriteLine("== Buscar dentro un Arreglo ==");
            Console.Write("Ingrese un número no negativo que desea buscar: ");
            string entrada = Console.ReadLine();

  
            if (int.TryParse(entrada, out numero) && numero >= 0)
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número entero no negativo.");
            }

        } while (!entradaValida);

      
        bool encontrado = BuscarNumero(matriz, numero);

        if (encontrado)
        {
            Console.WriteLine($"El número {numero} se encuentra en la matriz.");
        }
        else
        {
            Console.WriteLine($"El número {numero} NO se encuentra en la matriz.");
        }
    
    }


    public bool BuscarNumero(int[,] matriz, int numero)
    {
    
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (matriz[i, j] == numero)
                {
                    return true;
                }
            }
        }
        return false;
    }
    
}
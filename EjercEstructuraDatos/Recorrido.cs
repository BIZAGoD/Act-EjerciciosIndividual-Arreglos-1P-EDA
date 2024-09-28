namespace EjercEstructuraDatos;

public class Recorrido
{
    public  void Edades()
    {
        Console.Clear();
        int [] arrayEdades = new int[10];

        arrayEdades[0] = 24;
        arrayEdades[1] = 27;
        arrayEdades[2] = 35;
        arrayEdades[3] = 19;
        arrayEdades[4] = 8;
        arrayEdades[5] = 72;
        arrayEdades[6] = 37;
        arrayEdades[7] = 23;
        arrayEdades[8] = 4;
        arrayEdades[9] = 56;
    

        for (int i = 0; i < arrayEdades.Length; i++)
        {
            Console.WriteLine($"La edad es {arrayEdades[i]}");
        }

        Console.WriteLine($"La media es {MediaEdades(arrayEdades)} anios");
    }

    public static decimal MediaEdades(int[] arrayEdades)
    {
        int sum = Suma(arrayEdades);
        decimal resultado = (decimal)sum / arrayEdades.Length;
        return resultado;
    }

    public static int Suma(int[] arrayEdades)
    {
        int result = 0;
        for (int i = 0; i < arrayEdades.Length; i++)
        {
            result += arrayEdades[1];
        }
        return result;
    }
}
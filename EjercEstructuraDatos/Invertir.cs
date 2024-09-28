namespace EjercEstructuraDatos;

public class Invertir()
{
    public void MostrarResultado()
    {
        int [] Arreglo = {1,2,3,4,5,6,7,8,9,10};
        Console.Clear();
        Console.WriteLine("== Mostrar Arreglo unidimensional con valores ==\n");
        Console.WriteLine("== Arreglo Normal ==");
        MostrarArreglo(Arreglo);

        InvertirArreglo(Arreglo);

        Console.WriteLine("== Arreglo Invertido ==");
        MostrarArreglo(Arreglo);
        
    }

    public void MostrarArreglo(int [] Arreglo)
    {
        foreach (int valor in Arreglo)
        {
            Console.Write(valor + "");
        }

        Console.WriteLine();
    }

    public void InvertirArreglo(int [] Arreglo)
    {
        int longitud = Arreglo.Length;
        for (int i = 0; i < longitud /2; i++)
        {
            int temp = Arreglo[i];
            Arreglo[i] = Arreglo[longitud - 1 - i];
            Arreglo[longitud -1 -i] = temp;
        }
    }
}
namespace EjercEstructuraDatos;

public class Promedio()
{
    public void Notas()
    {
        string [] cursos = { "Estructura de datos","Desarollo de Aplicaciones","Ingenieria de Software","Administracion de Base de Datos","Inges IV"};


        double[,] notas = new double[5, 5];
        double[] promedios = new double[5];
        double mayorPromedio = 0;

   
        for (int curso = 0; curso < cursos.Length; curso++)
        {
            Console.Clear();
            Console.WriteLine("== Promedio de Notas ==");
            Console.WriteLine($"\n== Ingresar notas para el curso de {cursos[curso]} ==");

            double sumaNotas = 0;

            for (int alumno = 0; alumno < 5; alumno++)
            {
                double nota;
                bool esValido = false;

                do
                {
                    Console.Write($"Ingrese la nota final del alumno {alumno + 1}: ");
                    if (double.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 100)
                    {
                        notas[curso, alumno] = nota;
                        esValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un valor válido entre 0 y 100.");
                    }
                } while (!esValido);

                sumaNotas += notas[curso, alumno];
            }

  
            promedios[curso] = sumaNotas / 5;

   
            if (promedios[curso] > mayorPromedio)
            {
                mayorPromedio = promedios[curso];
            }
        }

  
        Console.WriteLine($"\nEl mayor promedio general es: {mayorPromedio:F2}");

        Console.WriteLine("Los cursos que obtuvieron el mayor promedio son:");
        for (int i = 0; i < cursos.Length; i++)
        {
            if (promedios[i] == mayorPromedio)
            {
                Console.WriteLine($"- {cursos[i]}");
            }
        }
    }

    
}
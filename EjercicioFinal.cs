using System;
using System.Diagnostics;

namespace Lab03_Search;
class EjercicioFinal
{
    static void Main(string[] args)
    {
       int buenos = 0, malos = 0;

        // valores aleatorios

        Random random = new Random();
        int[] A = new int[100];
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = random.Next(1, 201);
        }
        

        Console.WriteLine();

        int[] C = new int[50];
        for (int i = 0; i < C.Length; i++)
        {
            C[i] = random.Next(1, 201);
            if (BusquedaSecuencial(A, C[i]) == true)
            {
                buenos = buenos + 1;
            }
            else
            {
                malos++;
            }
        }

        for (int j = 0; j < C.Length; j++)
        {
            Console.Write(C[j] + " ");
        }

        // Busquedas exitosas y fallidas
        Console.WriteLine("\n\nBusquedas Exitosas: {0}", buenos);
        Console.WriteLine("Busquedas Fallidas: {0}", malos);

        // Porcentaje de exitos y fallos
        Console.WriteLine("\n\nEl porcentaje de exitos es: {0}%", (buenos * 100) / 50);
        Console.WriteLine("El porcentaje de fallos es: {0}%", (malos * 100) / 50);

        // Máxima concurrencia 
        MaximasOcurrencias(C);


        // Imprimir el arreglo ordenado creciente
        OrdenamientoQuicksort(A, 0, A.Length - 1);
        Console.WriteLine("\n\nArreglo ordenado creciente");
        for (int j = 0; j < A.Length; j++)
        {
            Console.Write(A[j] + " ");
        }
        Console.WriteLine();

    }

        static Boolean BusquedaSecuencial(int[] A, int x)
    {
        int i = 0;
        while (i < A.Length && A[i] != x)
        {
            i++;
        }
        if (i < A.Length)
        {
            // Console.WriteLine("El elemento {0} se encuentra en la posición {1}", x, i);
            return true;
        }
        else
        {
            // Console.WriteLine("El elemento {0} no se encuentra en el arreglo", x);
            return false;
        }
    }

    static void MaximasOcurrencias(int[] numbers)
    {
        var groups = numbers.GroupBy(x => x);
        var largest = groups.OrderByDescending(x => x.Count()).First();
        Console.WriteLine("El numero que más se repite es {0} y aparece {1} veces", largest.Key, largest.Count());
    }

    static void OrdenamientoQuicksort(int[] A, int primero, int ultimo)
    {
        int i, j, central, pivote;
        central = (primero + ultimo) / 2;
        pivote = A[central];
        i = primero;
        j = ultimo;
        do
        {
            while (A[i] < pivote)
            {
                i++;
            }
            while (A[j] > pivote)
            {
                j--;
            }
            if (i <= j)
            {
                int tmp = A[i];
                A[i] = A[j];
                A[j] = tmp;
                i++;
                j--;
            }
        } while (i <= j);
        if (primero < j)
        {
            OrdenamientoQuicksort(A, primero, j);
        }
        if (i < ultimo)
        {
            OrdenamientoQuicksort(A, i, ultimo);
        }
    }

   

}

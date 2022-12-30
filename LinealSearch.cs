using System;
using System.Diagnostics;

namespace Lab03_Search;
class LinealSearch
{
    static void Main1(string[] args)
    {
        Stopwatch time_linealSearch = new Stopwatch();

        String horaInicio = DateTime.Now.ToLongTimeString();
        String horaFin = "";

        Console.WriteLine("\nAlgoritmo de búsqueda lineal");

        Console.WriteLine("La hora de inicio del programa es: " + horaInicio);

        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 14, 27, 11, 9, 4, 64, 55, 32 };

        Console.WriteLine("\nArreglo desordenado: ");
        time_linealSearch.Start();
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}]= {A[i]}" + "   ");

        }
        Console.WriteLine("");
        Console.WriteLine("\nIngrese un número a buscar: ");
        int valorIngresado = Convert.ToInt32(Console.ReadLine());
        int posicionEncontrada = BusquedaLinealID(A, A.Length, valorIngresado);

        if (posicionEncontrada != -1)
        { 
            // 65 es el elemento a buscar cout << "Elemento encontrado en posicion: " << posicionEncontrada << endl;
            Console.WriteLine($"\nElemento encontrado en la posición:  A[{posicionEncontrada}]= {A[posicionEncontrada]}"); 
           
        }
        else
        { 
            Console.WriteLine("El numero ingresado no se encuentra en el arreglo");
        }


        horaFin = DateTime.Now.ToLongTimeString();
        Console.WriteLine("\nLa hora de fin de ejecución del programa es: " + horaFin);

        Console.WriteLine("\n" + "*** Time spent in the recursive method: " + time_linealSearch.Elapsed.ToString() + " ***");
        time_linealSearch.Stop();

    }

    //Metodo de Busqueda Lineal
    static int BusquedaLinealID(int[] A, int n, int clave)
    {
        int i;
        for (i = 0; i < n; i++)
        {
            if (A[i] == clave)
            {
                return i;
            }
        }
        return -1;
    }

}

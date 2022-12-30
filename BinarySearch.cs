using System;
using System.Diagnostics;

namespace Lab03_Search;
class BinarySearch
{
    static void Main2(string[] args)
    {
        Stopwatch time_BinarySearch = new Stopwatch();

        DateTime inicioEjecucion = DateTime.Now;
        Console.WriteLine("\nLa hora de inicio del programa es: "+ DateTime.Now.ToLongTimeString());

        Console.WriteLine("\nAlgoritmo de búsqueda binaria");

        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 14, 27, 11, 9, 4, 64, 55, 32 };

        Console.WriteLine("\nArreglo desordenado: ");
        time_BinarySearch.Start();
        
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}]= {A[i]}" + "   ");

        }
        Array.Sort(A);

        Console.WriteLine("\nArreglo ordenado: ");
         for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}]= {A[i]}" + "   ");

        }

        Console.WriteLine("");
        Console.WriteLine("\nIngrese un número a buscar: ");
        int valorIngresado = Convert.ToInt32(Console.ReadLine());


        int posicionEncontrada = busquedaBinaria(A, A.Length, valorIngresado);

        if (posicionEncontrada != -1)
        { 
            // 65 es el elemento a buscar cout << "Elemento encontrado en posicion: " << posicionEncontrada << endl;
            Console.WriteLine($"\nElemento encontrado en la posición:  A[{posicionEncontrada}]= {A[posicionEncontrada]}"); 
           
        }
        else
        { 
            Console.WriteLine("El numero ingresado no se encuentra en el arreglo");
        }


        DateTime finEjecucion = DateTime.Now;
        Console.WriteLine("\nLa hora de fin del programa es:"+ DateTime.Now.ToLongTimeString());

        Console.WriteLine("\n" + "*** Time spent in the recursive method: " + time_BinarySearch.Elapsed.ToString() + " ***");
        time_BinarySearch.Stop();

    }

    //Metodo Busqueda Binaria 

 static  int busquedaBinaria(int []lista, int n, int clave)
    {
        int central, bajo = 0, alto = n - 1;
        int valorCentral;
        while (bajo <= alto)
        {
            central = (bajo + alto) / 2;
            /* indice de elemento central */
            valorCentral = lista[central];
            /* valor del indice central */
            if (lista[central] == clave)
                return central; /* encontrado, devuelve posicion */
            else if (clave < lista[central])
                alto = central - 1; /* ir a sublista inferior */
            else
                bajo = central + 1; /* ir a sublista superior */
        }
        return -1;
        /* elemento no encontrado */
    }

/*
    //Metodo de Busqueda Lineal
    static int BusquedaLineal(int[] A, int n, int clave)
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
*/

static int BusquedaBinaria(int []lista, int n, int clave)
{
  int bajo = 0, alto = n - 1, central=-1;
  bool encontrado = false;
  while ((bajo <= alto) && (!encontrado))
  {
    central = (bajo + alto) / 2;
    if (lista[central] == clave)
      encontrado = true;             // éxito en la búsqueda
    else if (clave < lista[central]) // a lo bajo del central
      alto = central - 1;
    else                            // a la alto del central
      bajo = central + 1;
  }
  return encontrado ? central : -1; // central si encontrado -1 otro caso
}

}

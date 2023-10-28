using System.Runtime.InteropServices;

class Arrays
{
    static void Main (string [] args)
    {
        int cont = 0;

        System.Console.WriteLine("Defina el tamaño del arreglo");

        int a = int.Parse(System.Console.ReadLine());

        int[] arreglo = new int[a];

        for (int i = 0; i < a; i++)
        {
            System.Console.WriteLine("Ingrese el valor " + (i + 1));

            arreglo [i] = int.Parse(System.Console.ReadLine());

            cont = cont + arreglo[i];

            System.Console.WriteLine($"La posicion {i + 1} equivale a {cont}\n");

        }     

        System.Console.WriteLine("La suma de los arreglos es {0}", cont );

        Console.ReadKey();


    }
}
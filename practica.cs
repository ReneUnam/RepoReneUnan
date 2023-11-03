using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

class Practica
{

    /*public static void array()
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
    }
    */

    //-----------------------------------------------------------------------------------------------------------

    public static void arregloEstatico()
    {
        int[] arregloEstatico = new int[3];

        for (int i = 0; i < 3; i++)
        {
            System.Console.WriteLine("Ingrese un valor para la posicion " + i);

            arregloEstatico[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < 3; i++)
        {

            System.Console.WriteLine("El arreglo con posicion {0} es {1}", i, arregloEstatico[i]);
            
        }
    }

    //----------------------------------------------------------------------------------------------------

    public static void arregloDinamico()
    {
        System.Console.WriteLine("Ingrese el tamaño del arreglo");

        int n = int.Parse(Console.ReadLine());

        int[] arregloDinamico = new int[n];

        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"Ingrese el valor {i}");

            arregloDinamico[i] = int.Parse(Console.ReadLine());
        }      

        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine("El arreglo {0} tiene como valor {1}\n", i, arregloDinamico[i]);
        } 

        System.Console.WriteLine("Ingrese el valor que desea buscar del arreglo anterior");

        int valor = int.Parse(Console.ReadLine());
        
        int cont = 0;

        for (int i = 0; i < n; i++)
        {

            if (valor == arregloDinamico[i])
            {
                System.Console.WriteLine("El valor buscado se encuentra en la posicion " + i);

                cont ++;
            }
        
        }

        if (cont == 0) System.Console.WriteLine("El valor que usted busca no se encuentra en el arreglo");

    }

    //------------------------------------------------------------------------------------------------------

    public static void arregloSinDuplicados()
    {

        int cont = 0;

        System.Console.WriteLine("Ingrese el tamaño del arreglo (NO se permiten duplicados)");

        int n = int.Parse(Console.ReadLine());

        int[] arreglo = new int[n];

        bool encontrado = false;

        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"Ingrese el valor {i}");

            int valor = int.Parse(Console.ReadLine());

            for (int x = 0; x < i; x++)
            {
                if (valor == arreglo[x])
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                System.Console.WriteLine("El valor ingresado ya existe en el arreglo.");
                break;
            }
            else
            {
                arreglo[i] = valor;
            }

            encontrado = false;
        }

    }

    //----------------------------------------------------------------------------------------------------------

    public static void arreglosUnidimensionales()
    {
        int [] arreglo1 = new int[5];

        int [] arreglo2 = new int[5];

        int [] arreglo3 = new int[5];

        System.Console.WriteLine("Ingrese los valores del primer arreglo (Son 5)");
    
        for (int i = 0; i < 5; i++)
        {
            arreglo1[i] = int.Parse(Console.ReadLine());
        }     

        System.Console.WriteLine("");

        System.Console.WriteLine("Ingrese los valores del segundo arreglo");

        for (int i = 0; i < 5; i++)
        {
            arreglo2[i] = int.Parse(Console.ReadLine());
        }       

        System.Console.WriteLine("Procederemos a  multiplicarlos");

        for (int i = 0; i < 5; i++)
        {
            arreglo3[i] = arreglo1[i] * arreglo2[i];

            System.Console.WriteLine("{0} x {1} = {2}\n", arreglo1[i], arreglo2[i], arreglo3[i]);
        }

    }

    //----------------------------------------------------------------------------------------------------

    public static void arregloPalabra()
    {
        string [] array = new string [3] {"Hola ", "¿cómo ", "esta?"};
        
        for (int i = 0; i < 3; i++)
        {
            System.Console.Write(array[i]);
        
        }
        
        System.Console.WriteLine("");

        System.Console.WriteLine("¿Cuántas palabras desea ingresar?");

        int n = int.Parse(Console.ReadLine());

        string [] array1 = new string [n];

        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine("Ingrese la palabra del array " + i);

            array1[i] = Console.ReadLine();
        }


        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine("La palabra en el array {0} es {1}", i, array1[i]);
        }

        //-----------------------------------------------------------------------------------------------------------

        for (int y = 0; y < n; y++)
    {

            char[] letras = new char [array1[y].Length];   

            for (int i = 0; i < letras.Length; i++)
            {
            letras[i] = array1[y][i];
            }

            for (int i = 0; i < letras.Length - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (letras[j] > letras[j + 1])
                    {
                        char aux = letras[j];
                        letras[j] = letras[j + 1];
                        letras[j + 1] = aux;
                    }
                }
            }

            System.Console.WriteLine("La palabra del array {0} ordenada alfabeticamente es: ", y);
            

            for (int i = 0; i < letras.Length; i++)
            {

                Console.Write(letras[i]);

            }

            System.Console.WriteLine("\n");
        }
    }
}
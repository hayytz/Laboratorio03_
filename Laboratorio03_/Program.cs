using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a. Sumatoria");
            Console.WriteLine("b. Tablas de multiplicar");
            Console.WriteLine("c. Número perfecto");
            Console.WriteLine("d. Tarea Ejercicio 1");
            Console.WriteLine("e. Tarea Ejercicio 2");


            char opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case 'a':
                    Console.Clear();
                    Console.WriteLine("Ingrese un número");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int resultado = 0;

                    do
                    {
                        n--;
                        resultado = resultado + n;
                    }
                    while (n > 0);
                    Console.WriteLine("Sumatoria = " + resultado);

                    break;
                case 'b':
                    Console.Clear();

                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write(i + ": ");
                        for (int j = 1; j < 11; j++)
                        {
                            Console.Write((i * j) + "\t");
                        }
                        Console.Write("\n");
                    }
                    break;
                case 'c':
                    Console.Clear();

                    Console.WriteLine("Ingrese un número para determinar si es perfecto:");
                    int num = int.Parse(Console.ReadLine());
                    int sum = 0;

                    for (int i = 1; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            sum += i;
                        }
                    }

                    if (sum == num)
                    {
                        Console.WriteLine("El número ingresado es perfecto.");
                    }
                    else
                    {
                        Console.WriteLine("El número ingresado no es perfecto.");
                    }
                    break;

                case 'd':
                    Console.Clear();

                    Console.Write("Ingrese un número en base 10: ");
                    int num_2 = int.Parse(Console.ReadLine());

                    string binario = "";
                    while (num_2 > 0)
                    {
                        binario = (num_2 % 2) + binario;
                        num_2 /= 2;
                    }

                    Console.WriteLine($"El número en binario es: {binario}");

                    break;

                case 'e':
                    Console.Clear();

                    Console.Write("Ingrese un número en base 10: ");
                    int num_3 = int.Parse(Console.ReadLine());
                    string hex = num_3.ToString("X");
                    Console.WriteLine("El número en hexadecimal es: " + hex);
                    Console.WriteLine("El número ingresado es: " + num_3);

                    break;
            }

            Console.ReadLine();
              

        }
    }
}
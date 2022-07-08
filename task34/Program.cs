using System;

namespace WORKING
{

    class Program
    {

        static void Main()
        {
            // Шапка
            // Задача 34: Задайте массив заполненный случайными 
            // положительными трёхзначными числами. Напишите программу,
            //  которая покажет количество чётных чисел в массиве.
            // [345, 897, 568, 234] -> 2


            int[] array = new int[4];
            for (int i = 0; i < 4; i++)
            {
                array[i] = new Random().Next(101, 999);
            }
            Console.Write("[" + string.Join(", ", array) + "]");
            void WriteArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {

                }
                Console.WriteLine();
            }

            int QuantityPositive(int[] array)
            {
                int quantity = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1)
                    {
                        quantity++;
                    }
                }
                return quantity;
            }
            WriteArray(array);
            Console.WriteLine();

            int quantity = QuantityPositive(array);
            Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
















        }
    }
}

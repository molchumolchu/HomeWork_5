using System;
// using MyMethods;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] arg)
        {
            void FillArray(int[]numbers, int minValue, int maxValue)
            {
                maxValue ++;
                Random rnd = new Random();
                for (int i=0; i<numbers.Length; i++)
                {
                    numbers[i]=rnd.Next(minValue, maxValue);
                }
            }

            void Print(int [] numbers)

            {
                for (int i=0; i<numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();
            }

            void Task34()
            {
                // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
                // Напишите программу, которая покажет количество чётных чисел в массиве.
                // [345, 897, 568, 234] -> 2
                int size = 4;
                int[]numbers = new int[size];
                FillArray(numbers, 100, 1000);
                Print(numbers);
                int count = 0;
                int dif = 0;
                for (int i=0; i < numbers.Length; i ++)
                {
                    if(numbers[i]%2==dif) count++;
                }
                Console.WriteLine($"Количество четных числе в массиве {count}");

            }


            void Task36()
            {
                // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
                // [3, 7, 23, 12] -> 19
                // [-4, -6, 89, 6] -> 0
                int size = 5;
                int[]numbers = new int[size];
                FillArray(numbers, -100,  100);
                Print(numbers);
                int sum = 0;
                int dif = 1;
                for (int i=0; i < numbers.Length; i ++)
                {
                    if (i%2==dif && i!=0) // 0 не положительное не отрицательное число
                    {
                        sum +=numbers[i];
                    }
                }
                Console.WriteLine($"Количество четных числе в массиве {sum}");                

            }


            void Task38()
            // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
            // [3,21 7,04 22,93 -2,71 78,24] -> 80,95
            {
                int size = 6;
                int [] numbers = new int[size];
                FillArray(numbers, -5, 5);
                Print(numbers);
                int min = 0;
                int max = 0;
               
                for (int i=0; i < numbers.Length; i ++)
                {
                    if (numbers[i]>max) max = numbers[i];
                    if (numbers[i]<min) min = numbers[i];
                }
                
                Console.WriteLine($"Разница между минимальным числом {min} и максимальным числом {max} равна {max-min}");
            }           
            Task38();
        }
    }
}


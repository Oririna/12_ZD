using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ZD
{
    class Program
    {
        public static Random rnd = new Random();
        public static int count1 = 0, count2 = 0, count11 = 0, count12 = 0;

        static void SortWithInsert(int[] arr) // сортировка вставками
        {
            count1 = 0;
            count11 = 0;
            for (int j = 1; j < arr.Length; j++)
            {
                int k = arr[j];
                int i = j - 1;
                while (i >= 0 && arr[i] > k)
                {
                    arr[i + 1] = arr[i];
                    i--;
                    count1++;
                    count11++;
                }
                arr[i + 1] = k;
            }
        }

        static void BubbleSort(int[] arr) // сортировка пузырьком
        {
            count2 = 0;
            count12 = 0;
            int maxValue = arr.Max<int>();
            int[] c = new int[maxValue + 1];

            // Основной цикл (количество повторений равно количеству элементов массива)
            for (int i = 0; i < arr.Length; i++)
            {
                // Вложенный цикл (количество повторений, равно количеству элементов массива минус 1 
                // и минус количество выполненных повторений основного цикла) 
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    // Если элемент массива с индексом j больше следующего за ним элемента
                    if (arr[j] > arr[j + 1]) 
                    {
                        //Меняем местами элемент массива с индексом j и следующий за ним
                        Swap(ref arr[j], ref arr[j + 1]);
                        count12++;
                    }
                    count2++;
                }
            }
        }
        public static void Swap(ref int aFirstArg, ref int aSecondArg)
        {
            //Временная (вспомогательная) переменная, хранит значение первого элемента
            int tmpParam = aFirstArg;

            //Первый аргумент получил значение второго
            aFirstArg = aSecondArg;

            //Второй аргумент, получил сохраненное ранее значение первого
            aSecondArg = tmpParam;
        }

        static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void print(string str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(str);
            Console.ResetColor();
        }
        static void makeRand(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10);
            }
        }
        static void print1(string str)
        {
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {

            print("Сортирвока методом вставки");
            int[] arr1 = { 10, 30, 50, 70, 90 };
            int[] arr2 = { -9, 8, 7, 6, -5, 6, -2, 3, 1, 0 };
            int[] arr3 = new int[10];
            makeRand(arr3);

            print1("Массив 1: Упорядоченный по возрастанию");
            print(arr1);
            print1("Массив 1: После сортировки вставкой");
            SortWithInsert(arr1);
            print(arr1);
            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {count1}");
            Console.WriteLine($"Количество пересылок в 1-ой сортировке = {count11}");



            print1("\nМассив 2: Не упорядоченный");
            print(arr2);
            print1("Массив 2: После сортировки вставкой");
            SortWithInsert(arr2);
            print(arr2);
            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {count1}");
            Console.WriteLine($"Количество пересылок в 1-ой сортировке = {count11}");



            print1("\nМассив 3: Не упорядоченный");
            print(arr3);
            print1("Массив 3: После сортировки вставкой");
            SortWithInsert(arr3);
            print(arr3);
            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {count1}");
            Console.WriteLine($"Количество пересылок в 1-ой сортировке = {count11}");


            print("\nСортирвока пузырьком");
            int[] arr4 = { 10, 30, 50, 70, 90 };
            int[] arr5 = { 8, 7, 1, 0 };
            int[] arr6 = new int[10];
            makeRand(arr6);

            print1("Массив 1: Упорядоченный по возрастанию");
            print(arr4);
            print1("Массив 1: После сортировки пузырьком: ");
            BubbleSort(arr4);
            print(arr4);
            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {count2}");
            Console.WriteLine($"Количество пересылок в 1-ой сортировке = {count12}");

            print1("\nМассив 2: Упорядоченный по убыванию");
            print(arr5);
            print1("Массив 2: После сортировки пузырьком: ");
            BubbleSort(arr5);
            print(arr5);
            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {count2}");
            Console.WriteLine($"Количество пересылок в 1-ой сортировке = {count12}");

            print1("\nМассив 3: Не упорядоченный");
            print(arr6);
            print1("Массив 3: После сортировки пузырьком: ");
            BubbleSort(arr6);
            print(arr6);
            Console.WriteLine($"\nКоличество перестановок в 1-ой сортировке = {count2}");
            Console.WriteLine($"Количество пересылок в 1-ой сортировке = {count12}");
            Console.ReadKey();
        }
    }
}
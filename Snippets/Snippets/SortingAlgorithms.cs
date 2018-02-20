using System;
using System.Diagnostics;

namespace Snippets
{
    class SortingAlgorithms
    {
        public static void SwapArray(int[] data, int a, int b)
        {
            int temp;
            temp = data[a];
            data[a] = data[b];
            data[b] = temp;
        }

        public static void printArray(int[] data)
        {
            Console.WriteLine("Sorted Array:");
            foreach (int i in data)
            {
                Console.Write(i + " ");
            }
        }

        public static void BubbleSort(int[] data)
        {
            for (int i = data.Length; i > 1; i--)
            {
                for (int j = 0; j < i-1 ; j++)
                {
                    if (data[j] > data[j+1])
                    {
                        SwapArray(data, j, j + 1);
                    }
                }
            }
            // printArray(data);
        }
        
        public static void SelectionSort(int[] data)
        {
            int min;
            for (int i = 0; i < data.Length-1; i++)
            {
                min = i;
                for (int j = i+1; j < data.Length; j++)
                {
                    if (data[j] < data[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    SwapArray(data, i, min);
                }
            }
            // printArray(data);
        }

        // for smaller fields

        public static void InsertionSort(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                for (int j = i; j > 0 && data[j] < data[j-1]; j--)
                {
                    SwapArray(data, j, j - 1);
                }
            }
        }

        public static void ShellSort(int[] data)
        {
            Console.WriteLine("Not yet implemented");
        }

        public static void QuickSort(int[] data)
        {
            IntArrayQuickSort(data, 0, data.Length - 1);
        }

        // TODO: Implement Quicksort by myself

        public static void IntArrayQuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    SwapArray(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }

        // TODO: Mergesort

        public static void GenerateArray(int[] data, int seed)
        {
            Random r = new Random(seed);
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = r.Next(0, 100);
            }
        }


        public static void Main(String[] args)
        {
            double elapsedTime;
            Stopwatch watch = new Stopwatch();
            int[] data = new int[100000];

            Console.WriteLine("-- Bubble Sort --");
            GenerateArray(data, 1);
            watch.Reset();
            watch.Start();
            BubbleSort(data);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Elapsed time: {0:F3}", elapsedTime);

            Console.WriteLine("-- Selection Sort --");
            GenerateArray(data, 2);
            watch.Reset();
            watch.Start();
            SelectionSort(data);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Elapsed time: {0:F3}", elapsedTime);

            Console.WriteLine("-- Insertion Sort --");
            GenerateArray(data, 3);
            watch.Reset();
            watch.Start();
            InsertionSort(data);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Elapsed time: {0:F3}", elapsedTime);

            Console.WriteLine("-- Shell Sort --");
            GenerateArray(data, 4);
            watch.Reset();
            watch.Start();
            ShellSort(data);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Elapsed time: {0:F3}", elapsedTime);

            Console.WriteLine("-- Quick Sort --");
            GenerateArray(data, 5);
            watch.Reset();
            watch.Start();
            QuickSort(data);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Elapsed time: {0:F3}", elapsedTime);

            Console.ReadLine();
        }
    }
}

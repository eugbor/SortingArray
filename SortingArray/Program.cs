using System;

namespace sortingArray
{
    internal class Program
    {
        /// <summary>
        /// Алгоритм сортировки (пузырьком).
        /// </summary>
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var a = new int[n];

            SetArray(a);
            Print(a);
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int b = a[i];
                        a[i] = a[j];
                        a[j] = b;
                    }
                }
            }

            Print(a);

            Console.ReadLine();
        }

        private static void SetArray(int[] a)
        {
            var r = new Random();

            for (int i = 0; i < a.Length; i++)
                a[i] = r.Next(10);

        }

        private static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);

        }
    }
}


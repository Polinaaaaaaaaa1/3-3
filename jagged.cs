using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    internal class jagged : BaseArray, IBaseArray, IPRINTER
    {
        private int[] array_of_lengths;
        private int[][] array;
        private int heigth;
        public jagged(int heigth,int[] array_of_lengths)
        {
            this.heigth = heigth;
            array = new int[heigth][];
            this.array_of_lengths = array_of_lengths;
        }
        protected override void user_fill()
        {
            for (int i = 1; i <= array.GetLength(0); i++)
            {

                int[] mas = new int[array_of_lengths[i-1]];
                Console.WriteLine("Введите " + i + " строку зубчатого массива");
                mas = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToArray();

                array[(i - 1)] = mas;

            }
        }
        protected override void random_fill()
        {
            Random rand = new Random();
            for (int i = 1; i <= array.GetLength(0); i++)
            {
                int[] mas = new int[rand.Next()];
                mas = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToArray();
                array[(i - 1)] = mas;

            }
        }
        public void Print()
        {
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < array_of_lengths[i]; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }
        public void average()
        {
            float sum = 0;
            float count = 0;
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < array_of_lengths[i]; j++)
                {
                    sum += array[i][j];
                    count++;
                }
            }
            Console.WriteLine($"среднее во всем массиве {sum / count}");

        }
        public void replace_even()
        {
            int k = 1;
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < array_of_lengths[i]; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        k = j * k;
                    }

                }

            }
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < array_of_lengths[i]; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = k;
                    }

                }
            }
        }
        public void ReCreate()
        {
            int heigth = int.Parse(Console.ReadLine());
            array = new int[heigth][];
        }
    }
}

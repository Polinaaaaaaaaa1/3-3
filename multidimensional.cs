using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3_3.Program;

namespace _3_3
{
    internal class multidimensional : BaseArray, IBaseArray, IPRINTER
    {
        private int[,] array;
        private int length, heigth;
        public multidimensional(int length2, int heigth2)
        {
            length = length2;
            heigth = heigth2;
            array = new int[length,heigth];
           
        }
        protected override void user_fill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)

                {

                    Console.Write($"Элемент [{i},{j}]в многомерном массиве: ");

                    array[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
        }
        protected override void random_fill()
        {
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    array[i, j] = rand.Next();
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void average()
        {
            float sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];

                }
            }
            Console.Write("среднее занчение ");
            Console.WriteLine(sum / (length * heigth));
        }
        public void print_snake()
        { Console.WriteLine("массив змейкой");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }


                else
                {
                    for (int j = array.GetLength(1); j > 0; j--)
                    {
                        Console.Write(array[i, j-1] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
         public void ReCreate()
        {
            int length = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            array = new int[length,heigth];
        }
    }
}

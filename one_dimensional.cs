using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3_3.Program;

namespace _3_3
{
    internal class one_dimensional : BaseArray, IBaseArray, IPRINTER
    {
        private int[] array;
        private bool id;
        public one_dimensional(int length,bool id)
        {
            array = new int[length];
            this.id = id;
            if(id == true)
            {
                this.user_fill();
            }
            else
            {
                this.random_fill(); 
            }

        }
        protected override void user_fill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        protected override void random_fill()
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
            }
        }
        public void Print()
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public void average()
        {
            float sum = 0;
            int count = 0;
            for(int i = 0; i<array.Length; i++)
            {
                sum += array[i];
                count++;
            }
            Console.WriteLine($"среднее в одномерном массиве {sum / count}");

        }
        public void delete()
        {
            int r = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int a = array[i];

                int c = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == a)
                    {
                        c++;
                    }
                }
                if (c < 2)
                {
                    r++;
                }
            }
            int[] array3 = new int[r];
            int d = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int a = array[i];


                int c = 0;
                for (int j = 0; j < array.Length; j++)
                {

                    if (array[j] == a)
                    {
                        c++;
                    }
                }
                if (c < 2)
                {
                    array3[d] = a;
                    d++;
                }
            }
            Console.Write("одномерный массив без повторяющихся эл-тов  ");
            Console.WriteLine("[{0}]", string.Join(", ", array3));
        }

        public void ReCreate(int length)
        {
            array = new int[length];
        }
    }
}

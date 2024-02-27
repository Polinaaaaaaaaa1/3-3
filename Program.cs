using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("длина одномерного массива");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите true, если заполните массив  с клавиатуры, иначе false");
            bool id = bool.Parse(Console.ReadLine());
            one_dimensional Array = new one_dimensional(length);
            Array.fill_select(id);
            

            Console.Write("введите длину многомерного массива");
            int length2 = int.Parse(Console.ReadLine());
            Console.Write("введите ширину многомерного массива");
            int heigth2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите true, если заполните массив  с клавиатуры, иначе false");
            bool id2 = bool.Parse(Console.ReadLine());
            multidimensional Array2 = new multidimensional(length2, heigth2);
            Array2.fill_select(id2);




            Console.WriteLine("введите количествео строк зубчатого массива");
            int heigth3 = int.Parse(Console.ReadLine());
            
            int[] array_of_lengths = new int[heigth3];
            for (int i = 0; i < heigth3; i++)
            {
                Console.WriteLine($"введите количество эл-тов в {i + 1} строке зубч массива");
                array_of_lengths[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите true, если заполните массив  с клавиатуры, иначе false");
            bool id3 = bool.Parse(Console.ReadLine());
            jagged Array3 = new jagged(heigth3, array_of_lengths);
            Array3.fill_select(id3);


            IPRINTER[] arrays = { Array, Array2, Array3 };
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine("обычный вывод массива");
                arrays[i].Print();
                
            }

            IBaseArray[] arrays2 = { Array, Array2, Array3 };
            for (int i = 0; i < arrays2.Length; i++)
            {
                arrays2[i].average();

            }
            Array.delete();
            Array2.print_snake();
            Array3.replace_even();

            days str = new days();
            str.Print();
        }
    }
}

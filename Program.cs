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
            one_dimensional Array = new one_dimensional(length);
            

            Console.Write("введите длину многомерного массива");
            int length2 = int.Parse(Console.ReadLine());
            Console.Write("введите ширину многомерного массива");
            int heigth2 = int.Parse(Console.ReadLine());
 
            multidimensional Array2 = new multidimensional(length2, heigth2);
            

           


            Console.WriteLine("введите количествео строк зубчатого массива");
            int heigth3 = int.Parse(Console.ReadLine());
        
            int[] array_of_lengths = new int[heigth3];
            for (int i = 0; i < heigth3; i++)
            {
                Console.WriteLine($"введите количество эл-тов в {i + 1} строке зубч массива");
                array_of_lengths[i] = int.Parse(Console.ReadLine());
            }
            jagged Array3 = new jagged(heigth3, array_of_lengths);


            base_array[] arrays = { Array, Array2, Array3 };
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine($"Введите true, если заполните массив {i+1} с клавиатуры, иначе false");
                bool id = bool.Parse(Console.ReadLine());
                if(id==true)
                {

                    arrays[i].user_fill();
                }
                else
                {
                        arrays[i].random_fill();
                }
                arrays[i].average();
                Console.WriteLine("обычный вывод массива");
                arrays[i].print();
                
            }
            Array.delete();
            Array2.print_snake();
            Array3.replace_even();

            string days = "понедельник,вторник,среда,четверг,пятница,суббота,воскресенье";
            days str = new days(days);
            str.Print();
        }
    }
}

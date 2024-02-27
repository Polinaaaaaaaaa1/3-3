using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    public class days : IPRINTER
    {
        string str = "понедельник,вторник,среда,четверг,пятница,суббота,воскресенье";
        public void Print()
        {
            Console.WriteLine(str);
        }
    }
}

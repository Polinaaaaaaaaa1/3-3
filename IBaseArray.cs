using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    public interface IBaseArray
    {
        void average();
        void ReCreate(int x, int y=0);
    }
}

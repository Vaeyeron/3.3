using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
     public interface IMulti_Dim : IPrinter
    {
        void Initialize(int[,] _array);
        double Calculate_Average(int[,] _array);
        void Reverse_Even_Rows(int[,] _array);
    }
}

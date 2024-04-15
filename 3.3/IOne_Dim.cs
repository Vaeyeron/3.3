using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    public interface IOne_Dim : IPrinter
    {
        void Initialize(int[] _array);
        double Calculate_Average(int[] _array);
        void Remove_Elements_More_Than_Abs_100(int[] _array);
        void Remove_Duplicate_Elements(int[] _array);
    }
}

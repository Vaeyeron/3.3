using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    public interface IJagged_Dim : IPrinter
    {
        void Initialize(int[][] _array);
        double Calculate_Average(int[][] _array);
        void Calculate_Nested_Averages(int[][] _array);
        void Modify_Even_Elements(int[][] _array);
    }
}

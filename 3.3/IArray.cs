using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    interface IArray : IPrinter
    {
        void Initialize();
        void Fill_Array_With_User_Values();
        void Fill_Array_With_Random_Values();
        double Calculate_Average();
    }
}

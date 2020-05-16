using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Sum
    {
        private int[] numbers;
        private int res = 0;
        private int i = 0;
        public Sum(int [] ctor)
        {
            numbers = ctor;
        }

        public  int Calculate ( ref int num)
        {
            if (num == numbers.Length) return 0;
            return res + Calculate(ref numbers[num++]);
        }
    }
}

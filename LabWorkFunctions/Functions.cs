using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkFunctions
{
    public static class Functions
    {
    
        public static int GetFactorial(int x)
        {
            if (x== 0) return 1;
            if (x<0) return 0;
            else 
                return x * GetFactorial(x);
            throw new NotImplementedException();
        }

        public static double GetPower(double x, int n)
        {
            throw new NotImplementedException();
        }
    }
}

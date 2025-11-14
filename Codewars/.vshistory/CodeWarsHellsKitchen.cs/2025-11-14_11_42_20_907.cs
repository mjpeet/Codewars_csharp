using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class Kata
    {
        public static string Gordon(string a)
        {
            a.ToUpper();
            a.Replace('A', '@');
            a.Replace(" ", "!!!! ");
            a.Trim();
            return a;
        }
    }
}

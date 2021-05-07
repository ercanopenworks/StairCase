using System;
using System.Linq;

namespace Staircase
{
    class Program
    {
        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                //shortest way
                Console.WriteLine(new String('#', i).PadLeft(n, ' '));

                //long way
                //string str = new String(' ', n - i);
                //string star = new string('#', i);

                //Console.WriteLine(str + star);
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            staircase(n);
        }
    }
}

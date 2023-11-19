using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentC_.HomeWork4
{

    internal class HomeWork4
    {

        public int number = 15;
        public List<int> ints = new List<int> { 77, 66, 3, 4, 1, 10, 7, 8, 9, 6, 11, 88, 13, 14, 15 };

        public void HomeWork4Metod()
        {
            foreach (int i in ints)
            {
                int x = 0;
                if (i < number)
                {
                    x = number - i;

                }
                else
                {
                    continue;
                }


                var list = ints.FirstOrDefault(m => ints.Contains(x - m) && m != i);

                if (list != null)
                {
                    Console.WriteLine($"{i}+{list}+{x - list} = {number}");
                    break;
                }



            }



        }



    }
}

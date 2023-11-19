using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentC_.HomeWork3
{
    public class HomeWork3
    {

        public static int HasExit(int startI, int startJ, int[,] l)
        {
            int сountOutputs = 0;
            int flag = 0;

            if (l[startI, startJ] == 1)
            {
                Console.WriteLine("Начальная точка находится в стене!");
                return 0;
            }

            /* else if(l[startI, startJ] == 2)
            {
                Console.WriteLine("Выход находится на входе!");
                return 0;
            } */

            var stack = new Stack<Tuple<int, int>>();

            stack.Push(new(startI, startJ));

            while (stack.Count > 0)
            {
                var temp = stack.Pop();

                if ((temp.Item1 == 0 || temp.Item1 == l.GetLength(0) - 1 || temp.Item2 == 0 || temp.Item2 == l.GetLength(1) - 1) && flag != 0)
                {

                    сountOutputs++;
                }

                l[temp.Item1, temp.Item2] = 1;

                if (temp.Item2 > 0 && l[temp.Item1, temp.Item2 - 1] != 1)
                {
                    stack.Push(new(temp.Item1, temp.Item2 - 1)); //влево
                }

                if (temp.Item2 + 1 < l.GetLength(1) && l[temp.Item1, temp.Item2 + 1] != 1)
                {
                    stack.Push(new(temp.Item1, temp.Item2 + 1)); //вправо
                }

                if (temp.Item1 > 0 && l[temp.Item1 - 1, temp.Item2] != 1)
                {
                    stack.Push(new(temp.Item1 - 1, temp.Item2)); //вверх
                }

                if (temp.Item1 + 1 < l.GetLength(0) && l[temp.Item1 + 1, temp.Item2] != 1)
                {
                    stack.Push(new(temp.Item1 + 1, temp.Item2)); //вправо
                }
                flag++;
            }
            return сountOutputs;
        }

    }
}

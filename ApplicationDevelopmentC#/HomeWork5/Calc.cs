using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentC_.HomeWork5
{
    internal class Calc: ICalc
    {
        public double Result { get; set; } = 0D;
        

        private Stack<double> LastResult { get; set; } = new Stack<double>();

        public event EventHandler<EventArgs> MyEventHandler;

        private void PrintResult()
        {
            MyEventHandler?.Invoke(this, new EventArgs());
        }

        private bool flag = true;
        public double Number = 0;

        public void Start()
        {
            while (flag)
            {
                Console.WriteLine("Введите команду:" +
                    " \n Делить" +
                    " \n Умножить" +
                    " \n Вычесть" +
                    " \n Сложить" +
                    " \n Отменить" +
                    " \n Для выхода введите отмена или пустую строку");
                string command = Console.ReadLine();
                command.ToLower(); 
               
                

                switch(command)
                {
                     case "делить":
                        if (GetNumber(ref Number) == 1)
                        {
                            if (Number == 0)
                            {
                                Console.WriteLine("На ноль делить нельзя!");
                                break;
                            }
                                Divide(Number);
                            break;

                        }
                        
                        else
                        {
                            break;
                        }
                        
                    case "умножить":
                        if (GetNumber(ref Number) == 1)
                        {
                            Multiply(Number);
                            break;

                        }
                        else
                        {
                            break;
                        }
                    case "вычесть":
                        if (GetNumber(ref Number) == 1)
                        {
                            Subtract(Number);
                            break;

                        }
                        else
                        {
                            break;
                        }
                    case "сложить":
                        if (GetNumber(ref Number) == 1)
                        {
                            Sum(Number);
                            break;

                        }
                        else
                        {
                            break;
                        }
                    case "отменить":
                        
                            CancelLast();
                            break;
                    case "":
                        flag = false;
                        Console.WriteLine("До свидания!");
                        break;
                    case "отмена":
                        flag = false;
                        Console.WriteLine("До свидания!");
                        break;

                    default:
                        Console.WriteLine("Команда не распознана!");
                        break;

 
                        

                }

            }
        }

        public int GetNumber(ref double x)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Введите число, для отмены введите отмена");
                string temp = Console.ReadLine();
                if (temp.Equals("отмена"))
                {
                    flag = false;
                    return -1;
                   

                }
                else
                {
                    bool flag2 = double.TryParse(temp, out double number);
                    if (flag2)
                    {
                        x = number;
                        flag = false;
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine("Введено некорректное число, повторите попытку!");
                    }

                }

                

            }
            return -1;

        }


        public void Divide(double x)
        {
            LastResult.Push(Result);
            Result /= x;
            PrintResult();
        }

        public void Multiply(double x)
        {
            LastResult.Push(Result);
            Result *= x;
            PrintResult();
        }

        public void Subtract(double x)
        {
            LastResult.Push(Result);
            Result -= x;
            PrintResult();
        }

        public void Sum(double x)
        {
            LastResult.Push(Result);
            Result += x;
            PrintResult();
        }

        public void CancelLast()
        {
            if(LastResult.TryPeek(out double result))
            {
                Result = LastResult.Pop();
                PrintResult();

            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentC_.HomeWork6
{
    internal class Calc_HW6: ICalc_HW6
    {
        public double Result { get; set; } = 0D;


        private Stack<double> LastResult { get; set; } = new Stack<double>();

        public event EventHandler<EventArgs> MyEventHandler;

        private void PrintResult()
        {
            MyEventHandler?.Invoke(this, new EventArgs());
        }

        private bool flag = true;
        public double Number = 0D;
        public double NumberDouble = 0D;
        public int NumberInteger = 0;

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
                int getNumberFlag = GetNumber();





                switch (command)
                {
                     case "делить":
                        if (getNumberFlag == 1)
                        {
                            
                            DivideDouble(NumberDouble);
                            break;

                        }
                        else if(getNumberFlag == 2)
                        {
                            DivideInteger(NumberInteger);
                            break;
                        }
                        
                        else
                        {
                            break;
                        }
                        
                    case "умножить":
                        if (getNumberFlag == 1)
                        {
                            MultiplyDouble(NumberDouble);
                            break;

                        }

                        else if(getNumberFlag == 2)
                        {
                            MultiplyInteger(NumberInteger);
                            break;
                        }

                        else
                        {
                            break;
                        }
                    case "вычесть":
                        try
                        {
                            if (getNumberFlag == 1)
                            {
                                SubtractDouble(NumberDouble);
                                break;

                            }
                            else if (getNumberFlag == 2)
                            {
                                SubtractInteger(NumberInteger);
                                break;

                            }
                            else
                            {
                                break;
                            }

                        }
                        catch(NegativeNumberException ex)
                        {
                            Console.WriteLine(ex.Message);
                            
                        }
                        
                        break;
                        
                    case "сложить":
                        
                        if (getNumberFlag == 1)
                        {
                            SumDouble(NumberDouble);
                            break;

                        }
                        else if(getNumberFlag == 2)
                        {
                            SumInteger(NumberInteger);
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

        public int GetNumber()
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Введите число(для дробей используйте запятую), для отмены введите отмена");
                string temp = Console.ReadLine();
                if (temp.Equals("отмена"))
                {
                    flag = false;
                    return -1;
                   

                }
                try
                {
                    if (temp.Contains(","))
                    {
                        
                        DoubleTryPars(temp);
                        flag = false;
                        return 1;

                    }

                    else
                    {
                        IntegerTryPars(temp);
                        flag = false;
                        return 2;

                    }

                }
                catch(ParseException ex)
                {
                    
                    Console.WriteLine(ex.Message);
                }
                catch(NegativeNumberException ex)
                {
                    Console.WriteLine(ex.Message);

                }


                
                   
                    
                   

                

            }
            return -1;

        }

        public void DoubleTryPars(string str)
        {
            bool x = double.TryParse(str, out double number);

            if (x)
            {
                if(number < 0) 
                {
                    throw new NegativeNumberException("Отрицательное число не допустимо");
                }
                NumberDouble = number;
            }
            else
            {
                throw new ParseException("Введено некорректное число!!!");
            }

        }

        public void IntegerTryPars(string str)
        {
            bool x = int.TryParse(str, out int number);
            if (x)
            {
                if (number < 0)
                {
                    throw new NegativeNumberException("Отрицательное число не допустимо");
                }
                NumberInteger = number;
            }
            else
            {
                throw new ParseException("Введено некорректное число!!!");
            }

        }




        public void DivideDouble(double x)
        {
            LastResult.Push(Result);
            Result /= x;
            PrintResult();
        }
        public void DivideInteger(int x)
        {
            LastResult.Push(Result);
            Result /= x;
            PrintResult();
        }

        public void MultiplyDouble(double x)
        {
            LastResult.Push(Result);
            Result *= x;
            PrintResult();
        }

        public void MultiplyInteger(int x)
        {
            LastResult.Push(Result);
            Result *= x;
            PrintResult();
        }

        public void SubtractDouble(double x)
        {
            LastResult.Push(Result);
            Result -= x;
            if (Result < 0)
            {
                
                throw new NegativeNumberException("Результат не должен быть отрицательным!!!");
                
            }
            PrintResult();
        }

        public void SubtractInteger(int x)
        {
            LastResult.Push(Result);
            
            if (Result < x)
            {
                
                throw new NegativeNumberException("Результат не должен быть отрицательным!!!");
            }
            Result -= x;
            PrintResult();
        }

        public void SumDouble(double x)
        {
            LastResult.Push(Result);
            Result += x;
            PrintResult();
        }

        public void SumInteger(int x)
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

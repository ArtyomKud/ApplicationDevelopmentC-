using ApplicationDevelopmentC_;
using ApplicationDevelopmentC_.HomeWork5;

internal class Program
{
    private static void Main(string[] args)
    {


        //HomeWork3

        /* int[,] labirynth1 = new int[,]
            {
                {1, 1, 1, 1, 1, 1, 1 },
                {1, 0, 0, 0, 0, 0, 1 },
                {1, 0, 1, 1, 1, 0, 1 },
                {0, 0, 0, 0, 1, 0, 0 },
                {1, 1, 0, 0, 1, 1, 1 },
                {1, 1, 1, 0, 1, 1, 1 },
                {1, 1, 1, 0, 1, 1, 1 }
            };
        ;
       
        
      
        Console.WriteLine(HomeWork3.HasExit(1, 1, labirynth1)); 
        */



        //HomeWork4

        // HomeWork4 homeWork4 = new HomeWork4();
        // homeWork4.HomeWork4Metod();


        // HomeWork5

        Calc calc = new Calc();
        calc.MyEventHandler += Calc_MyEventHandler1;

        calc.Start();
       

    }

    private static void Calc_MyEventHandler1(object? sender, EventArgs e)
    {
        Console.WriteLine($"Результат:{((Calc)sender).Result}");
    }

          

       

}
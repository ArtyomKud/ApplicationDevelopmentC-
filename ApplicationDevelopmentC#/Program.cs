﻿using ApplicationDevelopmentC_;
using ApplicationDevelopmentC_.HomeWork5;
using ApplicationDevelopmentC_.HomeWork6;
using ApplicationDevelopmentC_.HomeWork8;
using ApplicationDevelopmentC_.HomeWork9;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    public static void Main(string[] args)
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

        /* HomeWork4 homeWork4 = new HomeWork4();
         homeWork4.HomeWork4Metod();
        */


        // HomeWork5

        /*  Calc calc = new Calc();
         calc.MyEventHandler += Calc_MyEventHandler1;

         calc.Start();


     }

     private static void Calc_MyEventHandler1(object? sender, EventArgs e)
     {
         Console.WriteLine($"Результат:{((Calc)sender).Result}");
     }
        */


        // HomeWork6

        /*Calc_HW6 calc = new Calc_HW6();
        calc.MyEventHandler += Calc_MyEventHandler1;

        calc.Start(); */



        // HomeWork8


        /* HomeWork8 homeWork8 = new HomeWork8();
          homeWork8.searchForFileByTypeAndText(args[0], args[1]);

          */

        //HomeWork9




        HomeWork9 homeWork9 = new HomeWork9();

        

        string jsonString = "{\"name\": \"Федор\",\r\n\"age\": 22,\r\n\"brother\":[{\"name\":\"Петр\",\"age\": 23},\r\n{\"name\":\"Денис\",\"age\": 30}]\r\n  \r\n}";

        using (JsonDocument document = JsonDocument.Parse(jsonString))

        {

            JsonElement jsonElement = document.RootElement;

          

            XElement rootElement = homeWork9.CreateXmlElement(jsonElement, jsonElement.ValueKind.ToString());



            

            XDocument xmlDocument = new XDocument();

            xmlDocument.Add(rootElement);
            



           

            xmlDocument.Save("output.xml");

            

        }

    }



    

     /* private static void Calc_MyEventHandler1(object? sender, EventArgs e)
      {
          Console.WriteLine($"Результат:{((Calc_HW6)sender).Result}");
      } */

           


          

       

}
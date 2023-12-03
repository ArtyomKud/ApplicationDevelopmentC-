using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentC_.HomeWork8
{
    public class HomeWork8
    {

        public void searchForFileByTypeAndText(string type, string text)
        {
            string InitialPath = @"C:\";

            List<string> requiredHalyards = new List<string>();

            type = "*." + type;

            var res = Directory.EnumerateFiles(InitialPath, type, SearchOption.AllDirectories);



            foreach (var file in res)
            {
                using (var sr = new StreamReader(file))
                {
                    while (sr.Peek() >= 0)
                    {
                        if (sr.ReadLine().Contains(text))
                        {
                            requiredHalyards.Add(file);
                        }

                    }
                }



            }

            foreach (var file in requiredHalyards)
            {
                Console.WriteLine(file);
            }




            
        }

    }
}

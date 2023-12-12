using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ApplicationDevelopmentC_.HomeWork9
{
    public class HomeWork9
    {

        public XElement CreateXmlElement(JsonElement jsonElement, String str)

        {

            

            XElement element = new XElement(str); 



            switch (jsonElement.ValueKind)

            {

                case JsonValueKind.Object:

                   

                    foreach (JsonProperty property in jsonElement.EnumerateObject())

                    {
                        
                        XElement propertyElement = CreateXmlElement(property.Value, property.Name);
                       
                        element.Add(propertyElement);
                      


                    }

                    break;



                case JsonValueKind.Array:

                    

                    foreach (JsonElement arrayElement in jsonElement.EnumerateArray())

                    {
                        
                        XElement arrayItemElement = CreateXmlElement(arrayElement, arrayElement.ValueKind.ToString());
                       
                        element.Add(arrayItemElement);
                        






                       


                    }

                    break;



                case JsonValueKind.String:
                    element = new XElement(str, jsonElement.GetString());
                    

                   


                    break;



                case JsonValueKind.Number:

                case JsonValueKind.True:

                case JsonValueKind.False:

                    element = new XElement(str, jsonElement.GetRawText());
                    

                    

                    break;



                case JsonValueKind.Null:

                    element = new XElement("null", "true");

                    break;

                default:
                    element = new XElement("null", "true");

                    break;

            }



            return element;

        }



    }
}

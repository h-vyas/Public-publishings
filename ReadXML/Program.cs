using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ReadXML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lt = new List<string>();
            XDocument doc = XDocument.Load("xxe.xml"); // Or whatever
            var allElements = doc.Descendants();
            var matchingElements = doc.Descendants()
                          .Where(x => x.Attribute("contentId") != null);
            foreach(var x in matchingElements)
            {
                
                lt.Add(x.FirstAttribute.Value);
            }
            
            foreach(string s in lt)
            {
                Console.WriteLine(s);                
            }
            Console.ReadKey();

        }
    }
}

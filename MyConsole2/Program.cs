using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = System.Environment.CurrentDirectory + "/../../XMLFile1.xml";
            XDocument xdocument =  XDocument.Load(fileName);
            var doc = xdocument.FirstNode.Document;
            var docu = (from x in doc.Descendants()
                        where x.Name == "itemID"
                        select x);
            var first = docu.First();
            first.Add(new XAttribute("HH", "10"));
            first.Add(new XElement("tt", "20"));
            xdocument.Save(fileName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConfigTemplate
{
    class CSV_Test
    {
        public static void Main()
        {
            var Lines = File.ReadAllLines("C:\\Temp\\phones.csv").Skip(1);
            var CSV = from line in Lines
                      select (line.Split(',')).ToArray();

            foreach(var line in CSV)
            {
                Console.WriteLine($"Mac: {line[0], 11} Name: {line[1], 15} Port: {line[2],4} Ext: {line[3], 3} Password: {line[4], 6}");
            }

            Console.ReadKey();
        }
        
    }
}

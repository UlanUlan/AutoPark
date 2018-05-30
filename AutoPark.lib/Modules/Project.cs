using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.lib.Modules
{
    public class Project
    {
        public string NameProgect { get; set; }

        public List<Car> Cars = new List<Car>();

        public void PrintInfo()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Project : " + NameProgect);
            
            foreach (Car item in Cars)
            {
               
                Console.WriteLine("---------------");
                item.PrintInfo();
            }
        }
    }
}

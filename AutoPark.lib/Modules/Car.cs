using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.lib.Modules
{
    public enum TypeCar { Ecscovatop = 1, Grader, Traktor }
    public class Car
    {
        public string Model { get; set; }
        public DateTime GodVipuska { get; set; }
        public TypeCar TypeCar { get; set; }
        public int GosNomer { get; set; }

        public List<Component> Components = new List<Component>();

        public void PrintInfo()
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-> {0} \t {1} g.v. \t Number - {2}", Model, GodVipuska.Year, GosNomer);
            Console.ForegroundColor = ConsoleColor.White;
            
            foreach (Component item in Components)
            {             
                Console.WriteLine("-->" + item.NameComponent);
            }
        }


        public void PrintInfoGreen()
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-> {0} \t {1} g.v. \t Number - {2}", Model, GodVipuska.Year, GosNomer);
            Console.ForegroundColor = ConsoleColor.White;

            foreach (Component item in Components)
            {
                Console.WriteLine("-->" + item.NameComponent);
            }
        }

    }
}

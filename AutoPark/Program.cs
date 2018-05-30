using AutoPark.lib;
using AutoPark.lib.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator gen = new Generator();
            List<Project> projects = null;

            string massage;
            if (!gen.GeneratorProgect(ref projects, out massage))
            {
                Console.WriteLine(massage);
                return;
            }

            foreach (Project item in projects)
            {
                item.PrintInfo();
            }
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Выберите проэкт ");
            foreach (var item in projects)
            {
                Console.WriteLine(" - " + item.NameProgect);
            }

            Project temp = null;

            do
            {
                Console.WriteLine("-> ");
                string name = Console.ReadLine();

                temp = projects.FirstOrDefault(o => o.NameProgect.ToLower() == name.ToLower());
                if (temp != null)
                    break;
                Console.WriteLine("Проэкт не найден");
            }
            while (temp == null);

            Console.WriteLine("Выберите критерий поиска: 1 по номеру, 2 по модели");
            int choice;
            do
            {
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out choice);

            } while (choice != 1 && choice != 2);

            int GosNom = 0;
            string Model = " ";
            Service serv = new Service();
            Car findCar = null;

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Введите номер машины -> ");
                        Int32.TryParse(Console.ReadLine(), out GosNom);
                        findCar = findCar = serv.Search(temp, GosNom);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Введите модель машины -> ");
                        findCar = serv.Search(temp, Console.ReadLine());
                    }
                    break;
            }

            if (findCar == null)
            {
                Console.WriteLine("Модель не найдена");
            }
            else
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                findCar.PrintInfoGreen();
        }
    }

}

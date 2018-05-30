using AutoPark.lib.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.lib
{
    public class Generator
    {
        private Random rand = new Random();
        public bool GeneratorProgect(ref List<Project> Projects, out string massage)
        {
            try
            {
                if (Projects == null)
                {
                    Projects = new List<Project>();
                }
                Projects.Add(new Project() { NameProgect = "Varvarinskiy GOK" });
                Projects[0].Cars = GeneratorCar(out massage);
                Projects.Add(new Project() { NameProgect = "Karagandinskaya shakhta" });
                Projects[1].Cars = GeneratorCar(out massage);
                Projects.Add(new Project() { NameProgect = "CC GOK" });
                Projects[2].Cars = GeneratorCar(out massage);
                massage = "Проэкт добавлен успешно";
                return true;
            }
            catch (Exception ex)
            {
                massage = ex.Message;
                return false;
            }
        }

        private List<Car> GeneratorCar( out string massage)
        {
            List<Car> Cars = new List<Car>();
            for (int i = 0; i < 5; i++)
            {
                Car car = new Car();
                car.GodVipuska = DateTime.Now.AddMonths(rand.Next(1, 200) * -1);
                car.GosNomer = rand.Next(1000, 9999);
                car.Model = "Model" + rand.Next(1, 10);
                car.TypeCar = (TypeCar)rand.Next(1, 3);
                car.Components = GeneratorComponents(out massage);
                Cars.Add(car);
            }

            massage = "Создана машина";
            return Cars;
        }

        private List<Component> GeneratorComponents(out string massege)
        {
            List<Component> components = new List<Component>();
            for (int i = 0; i < 3; i++)
            {
                Component comp = new Component();
                comp.IdComponent = rand.Next();
                comp.NameComponent = (Parts)rand.Next(1, 4);
               
                components.Add(comp);
            }
            massege = "Создан компонент";
            return components;
        }


    }
}

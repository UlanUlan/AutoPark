using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.lib.Modules
{
    public class Service
    {
        public Car Search(Project project, int GosNomer)
        {
            foreach (Car item in project.Cars)
            {
                if (item.GosNomer == GosNomer) return item;
            }
            return null;
        }

        public Car Search(Project project, string Model)
        {
            foreach (Car item in project.Cars)
            {
                if (item.Model == Model) return item;
            }
            return null;
        }
    }
}

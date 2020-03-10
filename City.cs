using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Stima_2
{
    public class City
    {
        private readonly int population;
        public int startDay;
        private readonly string name;

        public City(string name, int population)
        {
            this.population = population;
            this.name = name;
        }

        public City(City city) : this(city.name, city.population) { }

        public string GetName()
        {
            return this.name;
        }

        public void Reset()
        {
            startDay = -1;
        }

        public int P()
        {
            return this.population;
        }

        //Hari Terkena Virus
        public int T()
        {
            return this.startDay;
        }

        //Lama hari setelah terkena virus
        public int t(int targetDay)
        {
            return targetDay - startDay;
        }

        public double I(int targetDay)
        {
            double p = (double)P();
            return p / (1 + (p - 1) * Math.Exp(-0.25 * t(targetDay)));
        }

    }
}

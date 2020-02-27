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
        private int startDay;
        public int StartDay {
            get
            {
                return startDay;
            }
            set
            {
                if (startDay == -1 || value == -1)
                {
                    startDay = value;
                }
            }
        }
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
            StartDay = -1;
        }

        public int P()
        {
            return this.population;
        }

        //Hari Terkena Virus
        public int T()
        {
            return this.StartDay;
        }

        //Lama hari setelah terkena virus
        public int t(int targetDay)
        {
            return targetDay - StartDay;
        }

        public double I(int targetDay)
        {
            //double Population = this.population;
            //double DurationInfected = t(targetDay);
            //double Infected;
            //Infected = Population / (1 + (Population - 1) * Math.Exp(-0.25 * DurationInfected));
            //return Infected;
            return t(targetDay) * P() / 20d;
        }

    }
}

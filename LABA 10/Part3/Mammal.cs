using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_10
{
    class Mammal : IAnimal
    {
        public int Weight
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int IncubationPeriod
        {
            get;
            set;
        }
        public int LifeExpectancy
        {
            get;
            set;
        }
        public Mammal(int weight, string name, int incubationPeriod, int lifeExpectancy)
        {
            Weight = weight;
            Name = name;
            IncubationPeriod = incubationPeriod;
            LifeExpectancy = lifeExpectancy;
        }
        public int CompareTo(object obj)
        {
            IAnimal newAnimal = (IAnimal)obj;

            if (this.Weight > newAnimal.Weight) return -1;
            if (this.Weight < newAnimal.Weight) return 1;
            return 0;
        }
        public object Clone()
        {
            return new Mammal(Weight, Name, IncubationPeriod, LifeExpectancy);
        }
    }
}

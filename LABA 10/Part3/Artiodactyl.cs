using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_10
{
    class Artiodactyl : IAnimal
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
        public bool HasHorns
        {
            get;
            set;
        }
        public string Habitat
        {
            get;
            set;
        }
        public Artiodactyl(int weight, string name, int incubationPeriod, int lifeExpectancy, bool hasHorns, string habitat)
        {
            Weight = weight;
            Name = name;
            IncubationPeriod = incubationPeriod;
            LifeExpectancy = lifeExpectancy;
            HasHorns = hasHorns;
            Habitat = habitat;
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
            return new Artiodactyl(Weight, Name, IncubationPeriod, LifeExpectancy, HasHorns, Habitat);
        }
    }
}

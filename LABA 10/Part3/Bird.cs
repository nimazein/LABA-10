using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_10
{
    class Bird : IAnimal
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
        public bool Flying
        {
            get;
            set;
        }
        public bool Domestic
        {
            get;
            set;
        }
        public Bird(int weight, string name, bool flying, bool domestic)
        {
            Weight = weight;
            Name = name;
            Flying = flying;
            Domestic = domestic;
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
            return new Bird(Weight, Name, Flying, Domestic);        
        }
    }
}

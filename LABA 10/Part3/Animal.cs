using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_10
{
    class Animal : IAnimal
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
        public Animal(int weight, string name)
        {
            Weight = weight;
            Name = name;
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
            return new Animal(Weight, Name);
        }
    }
}

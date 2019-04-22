using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_10
{
    class KingdomAnimal : Naming
    {
        int weight;

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }         
        }
        public KingdomAnimal(int weight, string name)
            :base(name)
        {
            Weight = weight;
        }
        virtual public Dictionary<string, string> ReturnValue()
        {
            Dictionary<string, string> animalParameters = new Dictionary<string, string>();

            animalParameters.Add("weight", Weight.ToString());
            animalParameters.Add("name",Name);

            return animalParameters;
        }
    }
}

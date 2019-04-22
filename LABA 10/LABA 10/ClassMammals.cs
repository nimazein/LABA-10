using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_10
{
    [Serializable]
    class ClassMammals : KingdomAnimal
    {
        int incubationPeriod;
        int lifeExpectancy;

        public int IncubationPeriod
        {
            get
            {
                return incubationPeriod;
            }
            set
            {
                incubationPeriod = value;
            }
        }
        public int LifeExpectancy
        {
            get
            {
                return lifeExpectancy;
            }
            set
            {
                lifeExpectancy = value;
            }
        }
        
        public ClassMammals(int incubationPeriod, int lifeExpectancy, int weight, string name)
            : base(weight, name)
        {
            IncubationPeriod = incubationPeriod;
            LifeExpectancy = lifeExpectancy;
        }
        public override Dictionary<string, string> ReturnValue()
        {
            Dictionary<string, string> mammalParameters = base.ReturnValue();

            mammalParameters.Add("incubationPeriod", IncubationPeriod.ToString());
            mammalParameters.Add("lifeExpectancy", LifeExpectancy.ToString());

            return mammalParameters;
        }
    }
    
}

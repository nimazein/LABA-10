using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_10
{
    [Serializable]
    class ClassBirds : KingdomAnimal
    {
        bool flying;
        bool domestic;

        public bool Flying
        {
            get
            {
                return flying;
            }
            set
            {
                flying = value;
            }
        }
        public bool Domestic
        {
            get
            {
                return domestic;
            }
            set
            {
                domestic = value;
            }
        }

        public ClassBirds(bool flying, bool domestic, int weight, string name) 
            : base(weight, name)
        {
            Flying = flying;
            Domestic = domestic;
        }
        public override Dictionary<string, string> ReturnValue()
        {
            Dictionary<string, string> birdParameters = base.ReturnValue();

            birdParameters.Add("flying", Flying.ToString());
            birdParameters.Add("domestic", Domestic.ToString());

            return birdParameters;
        }
    }
}

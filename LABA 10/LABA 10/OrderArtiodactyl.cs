using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_10
{
    [Serializable]
    class OrderArtiodactyl : ClassMammals
    {
        bool hasHorns;
        string habitat;

        public bool HasHorns
        {
            get
            {
                return hasHorns;
            }
            set
            {
                hasHorns = value;
            }
        }
        public string Habitat
        {
            get
            {
                return habitat;
            }
            set
            {
                habitat = value;
            }
        }
        public OrderArtiodactyl(bool hasHorns, string habitat, int incubationPeriod, int lifeExpectancy, int weight, string name)
            : base(incubationPeriod, lifeExpectancy, weight, name)
        {
            HasHorns = hasHorns;
            Habitat = habitat;
        }

        public override Dictionary<string, string> ReturnValue()
        {
            Dictionary<string, string> artiodactylParameters = base.ReturnValue();

            artiodactylParameters.Add("hasHorns", HasHorns.ToString());
            artiodactylParameters.Add("habitat", Habitat);

            return artiodactylParameters;
        }

    }
}

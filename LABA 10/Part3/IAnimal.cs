using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_10
{
    public interface IAnimal : IComparable, ICloneable
    {
        int Weight
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }
    }
}

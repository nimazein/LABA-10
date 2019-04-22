using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LABA_10
{
    class Inputs
    {
        public static string InputName(string text)
        {
            string name = null;
            if (SupportingMethods.IsStringEmpty(text))
            {
                SupportingMethods.ShowMistake();
            }
            else
            {
                name = text;                
            }
            return name;
        }
        public static int InputWeight(string text)
        {
            int weight = -1;
            if (SupportingMethods.IsStringEmpty(text))
            {
                SupportingMethods.ShowMistake();
            }
            else
            {
                int input = Convert.ToInt32(text);
                if (SupportingMethods.IsRightWeight(input))
                {
                    weight = input;
                }   
            }
            return weight;
        }
        public static int InputIncubationPeriod(string text)
        {
            int incubationPeriod = -1;
            if (SupportingMethods.IsStringEmpty(text))
            {
                SupportingMethods.ShowMistake();
            }
            else
            {
                int input = Convert.ToInt32(text);
                if (input != 0 && input < 50)
                {
                    incubationPeriod = input;
                }
            }
            return incubationPeriod;
        }
        public static int InputLifeExpectancy(string text)
        {
            int lifeExpectancy = -1;
            if (SupportingMethods.IsStringEmpty(text))
            {
                SupportingMethods.ShowMistake();
            }
            else
            {
                int input = Convert.ToInt32(text);
                if (input != 0 && input < 200)
                {
                    lifeExpectancy = input;
                }
            }
            return lifeExpectancy;
        }
        

    }
}

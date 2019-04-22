using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA_10
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }
        private void BTOutput_Click(object sender, EventArgs e)
        {
            foreach (IAnimal animal in Part3.animals)
            {
                Identify(animal);
            }
        }
        private void Identify(IAnimal animal)
        {
            int weight = animal.Weight;
            string name = animal.Name;

            if (animal is Mammal)
            {
                Mammal mammal = animal as Mammal;
                int incubationPeriod = mammal.IncubationPeriod;
                int lifeExpectancy = mammal.LifeExpectancy;

                if (animal is Artiodactyl)
                {
                    Artiodactyl artiodactyl = animal as Artiodactyl;

                    bool hasHorns = artiodactyl.HasHorns;
                    string habitat = artiodactyl.Habitat;

                    ShowInfo(weight, name, incubationPeriod, lifeExpectancy, hasHorns, habitat);
                    return;

                }      
                
                ShowInfo(weight, name, incubationPeriod, lifeExpectancy);
                return;
            }
            if (animal is Bird)
            {
                Bird bird = animal as Bird;

                bool flying = bird.Flying;
                bool domestic = bird.Domestic;

                ShowInfo(weight, name, flying, domestic);
            }

            ShowInfo(weight, name);
        }
        private void ShowInfo(int weight, string name)
        {

        }
        private void ShowInfo(int weight, string name, int incubationPeriod, int maxAge)
        {

        }
        private void ShowInfo(int weight, string name, int incubationPeriod, int maxAge, bool hasHorns, string habitat)
        {

        }
        private void ShowInfo(int weight, string name, bool flying, bool domestic)
        {

        }
    }
}

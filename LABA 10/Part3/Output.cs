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
            TBOutput.Clear();
            foreach (IAnimal animal in Part3.animals)
            {
                Identify(animal);
            }
        }
        private void Identify(IAnimal animal)
        {
            int weight = animal.Weight;
            string name = animal.Name;

            if (animal is Animal)
            {                
                ShowInfo(weight, name);
                return;
            }          
            if (animal is Mammal)
            {
                Mammal mammal = animal as Mammal;
                int incubationPeriod = mammal.IncubationPeriod;
                int lifeExpectancy = mammal.LifeExpectancy;

                ShowInfo(weight, name, incubationPeriod, lifeExpectancy);
                return;
            }
            if (animal is Artiodactyl)
            {
                Artiodactyl artiodactyl = animal as Artiodactyl;

                int incubationPeriod = artiodactyl.IncubationPeriod;
                int lifeExpectancy = artiodactyl.LifeExpectancy;
                bool hasHorns = artiodactyl.HasHorns;
                string habitat = artiodactyl.Habitat;

                ShowInfo(weight, name, incubationPeriod, lifeExpectancy, hasHorns, habitat);
                return;
            }
            if (animal is Bird)
            {
                Bird bird = animal as Bird;

                bool flying = bird.Flying;
                bool domestic = bird.Domestic;

                ShowInfo(weight, name, flying, domestic);
                return;
            }
        }
        private void ShowInfo(int weight, string name)
        {
            string output = name + " "+ weight + " кг" + "\r\n";
            TBOutput.Text += output;
        }
        private void ShowInfo(int weight, string name, int incubationPeriod, int maxAge)
        {
            string output = name + " " + weight + " кг "+incubationPeriod +" месяцев "+ maxAge + " лет"+"\r\n";
            TBOutput.Text += output;
        }
        private void ShowInfo(int weight, string name, int incubationPeriod, int maxAge, bool hasHorns, string habitat)
        {
            string output = name + " " + weight + " кг " + incubationPeriod + " месяцев " + maxAge + " лет "+"есть рога: "+hasHorns+" cреда обитания: "+habitat + "\r\n";
            TBOutput.Text += output;
        }
        private void ShowInfo(int weight, string name, bool flying, bool domestic)
        {
            string output = $"{name}, {weight} кг, умеет летать: {flying}, домашняя: {domestic}" + "\r\n";
            TBOutput.Text += output;
        }

        private void BTSort_Click(object sender, EventArgs e)
        {
            TBOutput.Clear();
            string content = "Животные отсортированы по весу";
            string header = "info";
            MessageBox.Show(content, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Array.Sort(Part3.animals);
        }

        private void ПоискЭлементаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search form = new Search();
            form.ShowDialog();
        }
        private void BTClone_Click(object sender, EventArgs e)
        {
            int weight;
            string name;
            TBOutput.Clear();
            foreach (IAnimal animal in Part3.animals)
            {
                TBOutput.Text += "Клон ";
                object newAnimal = animal.Clone();

                if (newAnimal is Animal)
                {
                    Animal animal_ = animal as Animal;
                    weight = animal_.Weight;
                    name = animal_.Name;

                    ShowInfo(weight, name);
                }
                if (newAnimal is Bird)
                {
                    Bird bird = newAnimal as Bird;

                    weight = bird.Weight;
                    name = bird.Name;
                    bool flying = bird.Flying;
                    bool domestic = bird.Domestic;

                    ShowInfo(weight, name, flying, domestic);
                    continue;
                }
                if (newAnimal is Mammal)
                {                                                        
                    Mammal mammal = newAnimal as Mammal;

                    weight = mammal.Weight;
                    name = mammal.Name;
                    int incubationPeriod = mammal.IncubationPeriod;
                    int lifeExpectancy = mammal.LifeExpectancy;

                    ShowInfo(weight, name, incubationPeriod, lifeExpectancy);
                    continue;
                }
                if (newAnimal is Artiodactyl)
                {
                    Artiodactyl artiodactyl = newAnimal as Artiodactyl;

                    weight = artiodactyl.Weight;
                    name = artiodactyl.Name;
                    int incubationPeriod = artiodactyl.IncubationPeriod;
                    int lifeExpectancy = artiodactyl.LifeExpectancy;
                    bool hasHorns = artiodactyl.HasHorns;
                    string habitat = artiodactyl.Habitat;

                    ShowInfo(weight, name, incubationPeriod, lifeExpectancy, hasHorns, habitat);
                    continue;
                }             
            }
            
        }
    }
}

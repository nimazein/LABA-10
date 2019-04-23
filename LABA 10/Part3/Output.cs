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
            string output = name + " " + weight + " кг " + incubationPeriod + " месяцев " + maxAge + " лет "+"есть рога: "+" cреда обитания: "+habitat + "\r\n";
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
            string content = "Массив отсортирован";
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
            foreach (IAnimal animal in Part3.animals)
            {
                TBOutput.Text += "Клон ";
                object newAnimal = animal.Clone();

                if (newAnimal is Bird)
                {
                    Bird bird = newAnimal as Bird;

                    int weight = bird.Weight;
                    string name = bird.Name;
                    bool flying = bird.Flying;
                    bool domestic = bird.Domestic;


                    ShowInfo(weight, name, flying, domestic);
                    continue;
                }
                if (animal is Mammal)
                {
                    int weight;
                    string name;
                    int incubationPeriod;
                    int lifeExpectancy;
                    if (animal is Artiodactyl)
                    {
                        Artiodactyl artiodactyl = newAnimal as Artiodactyl;

                        weight = artiodactyl.Weight;
                        name = artiodactyl.Name;
                        incubationPeriod = artiodactyl.IncubationPeriod;
                        lifeExpectancy = artiodactyl.LifeExpectancy;
                        bool hasHorns = artiodactyl.HasHorns;
                        string habitat = artiodactyl.Habitat;

                        ShowInfo(weight, name, incubationPeriod, lifeExpectancy, hasHorns, habitat);
                        continue;
                    }

                    Mammal mammal = newAnimal as Mammal;

                    weight = mammal.Weight;
                    name = mammal.Name;
                    incubationPeriod = mammal.IncubationPeriod;
                    lifeExpectancy = mammal.LifeExpectancy;

                    ShowInfo(weight, name, incubationPeriod, lifeExpectancy);

                }


            }
        }



    }
}

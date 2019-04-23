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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void BTTriggerSearch_Click(object sender, EventArgs e)
        {
            if (!SupportingMethods.IsStringEmpty(TBName.Text)
                && !SupportingMethods.IsStringEmpty(TBWeight.Text))
            {
                FindThisElement();
            }
            else
            {
                SupportingMethods.ShowMistake();
            }
        }
        private void FindThisElement()
        {
            string name = TBName.Text;
            int weight = Convert.ToInt32(TBWeight.Text);

            string content;
            string header;

            foreach (IAnimal animal in Part3.animals)
            {
                if (String.Equals(animal.Name, name))
                {
                    if (animal.Weight == weight)
                    {
                        content = "Объект найден";
                        header = "info";
                        MessageBox.Show(content, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OutputFoundObject(animal);
                        return;
                    }
                }
               
            }
            content = "Элемента с такими данными нет";
            header = "info";
            MessageBox.Show(content, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void OutputFoundObject(IAnimal animal)
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

                return;
            }

            ShowInfo(weight, name);
        }
        private void ShowInfo(int weight, string name)
        {
            string output = name + " " + weight + " кг" + "\r\n";
            TBOutput.Text += output;
        }
        private void ShowInfo(int weight, string name, int incubationPeriod, int maxAge)
        {
            string output = name + " " + weight + " кг " + incubationPeriod + " месяцев " + maxAge + " лет" + "\r\n";
            TBOutput.Text += output;
        }
        private void ShowInfo(int weight, string name, int incubationPeriod, int maxAge, bool hasHorns, string habitat)
        {
            string output = name + " " + weight + " кг " + incubationPeriod + " месяцев " + maxAge + " лет " + "есть рога: " + " cреда обитания: " + habitat + "\r\n";
            TBOutput.Text += output;
        }
        private void ShowInfo(int weight, string name, bool flying, bool domestic)
        {
            string output = $"{name}, {weight} кг, умеет летать: {flying}, домашняя: {domestic}" + "\r\n";
            TBOutput.Text += output;
        }

    }
}

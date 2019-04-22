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
    public partial class Part3 : Form
    {
        public Part3()
        {
            InitializeComponent();
        }
        public static IAnimal[] animals;
        public static int size;
        int i;
        private void BTInputSize_Click(object sender, EventArgs e)
        {
            if (SupportingMethods.IsStringEmpty(TBInputSize.Text))
            {
                SupportingMethods.ShowMistake();
            }
            else
            {                             
                CreateArray();
                BTInputSize.Enabled = false;
                EnableButtons();
            }         
        }
        private void CreateArray()
        {
            if (IsRightSize())
            {
                i = 0;
                animals = new IAnimal[size];
            }

        }
        private bool IsRightSize()
        {
            bool isRightSize = false;
            int input = Convert.ToInt32(TBInputSize.Text);

            if (input < 1 | input > 20)
            {
                SupportingMethods.ShowMistake(content: "Введен недопустимый размер");
                
            }
            else
            {
                isRightSize = true;
                size = input;
            }
            return isRightSize;
        }

        private void Part3_Load(object sender, EventArgs e)
        {
            DisableButtons();   
        }
        
        private void EnableButtons()
        {
            BTAnimalCreate.Enabled = true;
            BTArtiodactylCreate.Enabled = true;
            BTBirdCreate.Enabled = true;
            BTMammalCreate.Enabled = true;
        }
        private void DisableButtons()
        {
            BTAnimalCreate.Enabled = false;
            BTArtiodactylCreate.Enabled = false;
            BTBirdCreate.Enabled = false;
            BTMammalCreate.Enabled = false;
        }

        private void BTMammalCreate_Click(object sender, EventArgs e)
        {
            if (!SupportingMethods.IsStringEmpty(TBMammalName.Text)
                && !SupportingMethods.IsStringEmpty(TBMammalWeight.Text)
                && !SupportingMethods.IsStringEmpty(TBMammalMaxAge.Text)
                && !SupportingMethods.IsStringEmpty(TBMammalIncubationPeriod.Text))
            {
                string name = TBMammalName.Text;
                int weight = Convert.ToInt32(TBMammalWeight.Text);
                int incubationPeriod = Convert.ToInt32(TBMammalIncubationPeriod.Text);
                int lifeExpectancy = Convert.ToInt32(TBMammalMaxAge.Text);

                InsertMammalToArray(name, weight, incubationPeriod, lifeExpectancy);
            }
            else
            {
                SupportingMethods.ShowMistake();
            }
        }
        private void InsertMammalToArray(string name, int weight, int incubationPeriod, int lifeExpectancy)
        {
            if (i == size)
            {
                string content = "Массив заполнен";
                string header = "info";
                MessageBox.Show(content, header, MessageBoxButtons.OK,MessageBoxIcon.Information);
                DisableButtons();
            }
            else
            {
                Mammal mammal = new Mammal(weight, name, incubationPeriod, lifeExpectancy);
                animals[i] = mammal;
                i++;
            }
            
        }

        private void BTAnimalCreate_Click(object sender, EventArgs e)
        {
            if (!SupportingMethods.IsStringEmpty(TBAnimalName.Text)
                && !SupportingMethods.IsStringEmpty(TBAnimalWeight.Text))
            {
                string name = TBAnimalName.Text;
                int weight = Convert.ToInt32(TBAnimalWeight.Text);

                InsertAnimalToArray(name, weight);
            }
            else
            {
                SupportingMethods.ShowMistake();
            }
        }
        private void InsertAnimalToArray(string name, int weight)
        {
            if (i == size)
            {
                string content = "Массив заполнен";
                string header = "info";
                MessageBox.Show(content, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableButtons();
            }
            else
            {
                Animal animal = new Animal(weight, name);
                animals[i] = animal;
                i++;
            }

        }

        private void BTBirdCreate_Click(object sender, EventArgs e)
        {
            if (!SupportingMethods.IsStringEmpty(TBBirdName.Text)
                && !SupportingMethods.IsStringEmpty(TBBirdWeight.Text))
            {
                string name = TBBirdName.Text;
                int weight = Convert.ToInt32(TBBirdWeight.Text);
                bool flying = CBFlying.Checked;
                bool domestic = CBDomestic.Checked;

                InsertBirdToArray(name, weight, flying, domestic);
            }
            else
            {
                SupportingMethods.ShowMistake();
            }
        }
        private void InsertBirdToArray(string name, int weight, bool flying, bool domestic)
        {
            if (i == size)
            {
                string content = "Массив заполнен";
                string header = "info";
                MessageBox.Show(content, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableButtons();
            }
            else
            {
                Bird bird = new Bird(weight, name, flying, domestic);
                animals[i] = bird;
                i++;
            }
        }

        private void BTArtiodactylCreate_Click(object sender, EventArgs e)
        {
            if (!SupportingMethods.IsStringEmpty(TBArtiodactylName.Text)
                && !SupportingMethods.IsStringEmpty(TBArtiodactylWeight.Text)
                && !SupportingMethods.IsStringEmpty(TBArtiodactylMaxAge.Text)
                && !SupportingMethods.IsStringEmpty(TBArtiodactylIncubationPeriod.Text)
                && !SupportingMethods.IsStringEmpty(TBArtiodactylHabitat.Text))
            {
                string name = TBArtiodactylName.Text;
                int weight = Convert.ToInt32(TBArtiodactylWeight.Text);
                int incubationPeriod = Convert.ToInt32(TBArtiodactylIncubationPeriod.Text);
                int lifeExpectancy = Convert.ToInt32(TBArtiodactylMaxAge.Text);
                bool hasHorns = CBHorns.Checked;
                string habitat = TBArtiodactylHabitat.Text;

                InsertArtiodactylToArray(name, weight, incubationPeriod, lifeExpectancy, hasHorns, habitat);
            }
            else
            {
                SupportingMethods.ShowMistake();
            }
        }
        private void InsertArtiodactylToArray(string name, int weight, int incubationPeriod, int lifeExpectancy, bool hasHorns, string habitat)
        {
            if (i == size)
            {
                string content = "Массив заполнен";
                string header = "info";
                MessageBox.Show(content, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableButtons();
            }
            else
            {
                Artiodactyl artiodactyl = new Artiodactyl(weight, name, incubationPeriod, lifeExpectancy, hasHorns, habitat);
                animals[i] = artiodactyl;
                i++;
            }
        }

        private void ВывестиМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Output form = new Output();
            form.ShowDialog();
        }
    }
}

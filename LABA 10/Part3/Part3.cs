using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        public static int i;
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

            TBMammalWeight.Clear();
            TBMammalName.Clear();
            TBMammalMaxAge.Clear();
            TBMammalIncubationPeriod.Clear();
        }
        private void InsertMammalToArray(string name, int weight, int incubationPeriod, int lifeExpectancy)
        {
            Mammal mammal = new Mammal(weight, name, incubationPeriod, lifeExpectancy);
            animals[i] = mammal;
            

            if (i+1 == size)
            {
                string content = "Массив заполнен";
                string header = "info";
                MessageBox.Show(content, header, MessageBoxButtons.OK,MessageBoxIcon.Information);
                DisableButtons();
            }
            i++;


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

            TBAnimalName.Clear();
            TBAnimalWeight.Clear();
        }
        private void InsertAnimalToArray(string name, int weight)
        {
            Animal animal = new Animal(weight, name);
            animals[i] = animal;
            

            if (i + 1 == size)
            {
                string content = "Массив заполнен";
                string header = "info";
                MessageBox.Show(content, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableButtons();
            }
            i++;


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

            TBBirdWeight.Clear();
            TBBirdName.Clear();

        }
        private void InsertBirdToArray(string name, int weight, bool flying, bool domestic)
        {
            Bird bird = new Bird(weight, name, flying, domestic);
            animals[i] = bird;
            

            if (i +1 == size)
            {
                string content = "Массив заполнен";
                string header = "info";
                MessageBox.Show(content, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableButtons();
            }
            i++;
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

            TBArtiodactylHabitat.Clear();
            TBArtiodactylIncubationPeriod.Clear();
            TBArtiodactylMaxAge.Clear();
            TBArtiodactylName.Clear();
            TBArtiodactylWeight.Clear();
        }
        private void InsertArtiodactylToArray(string name, int weight, int incubationPeriod, int lifeExpectancy, bool hasHorns, string habitat)
        {
            Artiodactyl artiodactyl = new Artiodactyl(weight, name, incubationPeriod, lifeExpectancy, hasHorns, habitat);
            animals[i] = artiodactyl;           

            if (i + 1 == size)
            {
                string content = "Массив заполнен";
                string header = "info";
                MessageBox.Show(content, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableButtons();
            }
            i++;
        }

        private void ВывестиМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Output form = new Output();
            form.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("input.txt");

            string line;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();

                string[] delimiterChars = { " ", "\r\n" };
                string[] parameters = line.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

                string name = parameters[0];
                int weight = Convert.ToInt32(parameters[1]);

                if (parameters.Length == 2)
                {
                    InsertAnimalToArray(name, weight);
                    continue;
                }

                if (parameters.Length == 5)
                {//birds

                }

                int incubationPeriod = Convert.ToInt32(parameters[2]);
                int lifeExpectancy = Convert.ToInt32(parameters[3]);

                if (parameters.Length == 4)
                {
                    InsertMammalToArray(name, weight, incubationPeriod, lifeExpectancy);
                    continue;
                }
                if (parameters.Length == 6)
                {
                    bool hasHorns = Convert.ToBoolean(parameters[4]);
                    string habitat = parameters[5];

                    InsertArtiodactylToArray(name, weight, incubationPeriod, lifeExpectancy, hasHorns, habitat);
                    continue;
                }
            }
        }

        private void TBMammalName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if ((s > 'я' || s < 'А') && s != 8 && s != 32)
            {
                e.Handled = true;
            }
        }

        private void TBAnimalName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if ((s > 'я' || s < 'А') && s != 8 && s != 32)
            {
                e.Handled = true;
            }
        }

        private void TBArtiodactylHabitat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if ((s > 'я' || s < 'А') && s != 8 && s != 32)
            {
                e.Handled = true;
            }
        }

        private void TBBirdName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if ((s > 'я' || s < 'А') && s != 8 && s != 32)
            {
                e.Handled = true;
            }
        }

        private void TBMammalWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8)
            {
                e.Handled = true;
            }
        }

        private void TBMammalIncubationPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8)
            {
                e.Handled = true;
            }
        }

        private void TBMammalMaxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8)
            {
                e.Handled = true;
            }
        }

        private void TBBirdWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8)
            {
                e.Handled = true;
            }
        }

        private void TBAnimalWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8)
            {
                e.Handled = true;
            }
        }

        private void TBArtiodactylWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8)
            {
                e.Handled = true;
            }
        }

        private void TBArtiodactylIncubationPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8)
            {
                e.Handled = true;
            }
        }

        private void TBArtiodactylMaxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8)
            {
                e.Handled = true;
            }
        }

        private void TBArtiodactylName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if ((s > 'я' || s < 'А') && s != 8 && s != 32)
            {
                e.Handled = true;
            }
        }

        private void TBInputSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8)
            {
                e.Handled = true;
            }
        }
    }
}

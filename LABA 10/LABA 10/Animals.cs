using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LABA_10
{
    public partial class Animals : Form
    {



        public Animals()
        {
            InitializeComponent();
        }

        List<KingdomAnimal> animals = new List<KingdomAnimal>();

        private void Animals_Load(object sender, EventArgs e)
        {
            BTAnimalCreate.Enabled = false;
        }
        private void КМлекопитающимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            animals = null;
            Mammals form = new Mammals();
            form.ShowDialog();
            Close();
        }

        private void BTAnimalCreate_Click(object sender, EventArgs e)
        {
            string name = Inputs.InputName(TBAnimalName.Text);
            if (name != null)
            {
                int weight = Inputs.InputWeight(TBAnimalWeight.Text);
                if (weight > 0)
                {
                    KingdomAnimal animal = new KingdomAnimal(weight, name);
                    SupportingMethods.zoo.Add(animal);
                    animals.Add(animal);
                }
            }
        }
        private void TBAnimalWeight_TextChanged(object sender, EventArgs e)
        {
            BTAnimalCreate.Enabled = true;
        }

        private void TBAnimalName_TextChanged(object sender, EventArgs e)
        {
            BTAnimalCreate.Enabled = true;
        }

        private void кПтицамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            animals = null;
            Birds form = new Birds();
            form.ShowDialog();
            Close();
        }

        private void кПарнокопытнымToolStripMenuItem_Click(object sender, EventArgs e)
        {
            animals = null;
            Artiodactyl form = new Artiodactyl();
            form.ShowDialog();
            Close();
        }

        private void TBAnimalName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if ((s > 'я' || s < 'А') && s != 8 && s != 32)
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

        private void выводМассиваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            if (animals.Count == 0)
            {
                SupportingMethods.ShowMistake(content: "Массив пуст");
            }
            else
            {
                foreach (KingdomAnimal animal in animals)
                {
                    int weight = animal.Weight;
                    string name = animal.Name;

                    string output = name + ", " + weight +"кг " +"\r\n";
                    richTextBox1.Text += output;
                }
            }
        }

        private void КЧасти2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Part2 form = new Part2();
            form.ShowDialog();
            Close();
        }
    }
}

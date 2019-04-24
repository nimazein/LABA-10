using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LABA_10
{
    public partial class Birds : Form
    {
        public Birds()
        {
            InitializeComponent();
        }

        private void Birds_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        List<ClassBirds> birds = new List<ClassBirds>();
        private void BTBirdCreate_Click(object sender, EventArgs e)
        {
            string name = Inputs.InputName(TBBirdName.Text);
            if (name != null)
            {
                int weight = Inputs.InputWeight(TBBirdWeight.Text);
                if (weight > 0)
                {
                    bool flying = false;
                    if (CBFlying.Checked)
                    {
                        flying = true;
                    }
                    bool domestic = false;
                    if (CBDomestic.Checked)
                    {
                        domestic = true;
                    }

                    ClassBirds bird = new ClassBirds(flying, domestic, weight, name);
                    SupportingMethods.zoo.Add(bird);
                    birds.Add(bird);
                }
                else
                {
                    SupportingMethods.ShowMistake(content: "Вес введен неверно");
                }
            }

            TBBirdName.Clear();
            TBBirdWeight.Clear();
        }

        private void кЖивотнымToolStripMenuItem_Click(object sender, EventArgs e)
        {
            birds = null;
            Animals form = new Animals();
            form.ShowDialog();
            Close();
        }

        private void кМлекопитающимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            birds = null;
            Mammals form = new Mammals();
            form.ShowDialog();
            Close();
        }

        private void кПарнокопытнымToolStripMenuItem_Click(object sender, EventArgs e)
        {
            birds = null;
            Artiodactyl form = new Artiodactyl();
            form.ShowDialog();
            Close();
        }

        private void TBBirdWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8)
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

        private void выводМассиваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            if (birds.Count == 0)
            {
                SupportingMethods.ShowMistake(content: "Массив пуст");
            }
            else
            {
                foreach (ClassBirds bird in birds)
                {
                    int weight = bird.Weight;
                    string name = bird.Name;
                    bool flying = bird.Flying;
                    bool domestic = bird.Domestic;

                    string output = name + ", " + weight + "кг, " + "летает: " + flying + ", домашняя: " + domestic + "\r\n";
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

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace LABA_10
{
    public partial class Artiodactyl : Form
    {
        public Artiodactyl()
        {
            InitializeComponent();
        }

        private void Artiodactyl_Load(object sender, EventArgs e)
        {

        }
        List<OrderArtiodactyl> artiodactyls = new List<OrderArtiodactyl>();

        private void BTArtiodactylCreate_Click(object sender, EventArgs e)
        {
            string name = Inputs.InputName(TBArtiodactylName.Text);
            if (name != null)
            {
                int weight = Inputs.InputWeight(TBArtiodactylWeight.Text);
                if (weight > 0)
                {
                    int incubationPeriod = Inputs.InputIncubationPeriod(TBArtiodactylIncubationPeriod.Text);

                    if (incubationPeriod > 0)
                    {
                        int lifeExpectancy = Inputs.InputLifeExpectancy(TBArtiodactylMaxAge.Text);
                        if (lifeExpectancy > 0)
                        {
                            bool horns = false;
                            if (checkBox1.Checked)
                            {
                                horns = true;
                            }

                            if (SupportingMethods.IsStringEmpty(TBArtiodactylHabitat.Text))
                            {
                                SupportingMethods.ShowMistake();
                            }
                            else
                            {
                                string habitat = TBArtiodactylHabitat.Text;
                                OrderArtiodactyl artiodactyl = new OrderArtiodactyl(horns, habitat, incubationPeriod, lifeExpectancy, weight, name);
                                SupportingMethods.zoo.Add(artiodactyl);
                                artiodactyls.Add(artiodactyl);
                            }
                        }
                        else
                        {
                            SupportingMethods.ShowMistake("Продолжительность жизни введена неверно");
                        }
                    }
                    else
                    {
                        SupportingMethods.ShowMistake("Период вынашивания введен неверно");
                    }
                }
                else
                {
                    SupportingMethods.ShowMistake(content: "Вес введен неверно");
                }
            }
            TBArtiodactylHabitat.Clear();
            TBArtiodactylIncubationPeriod.Clear();
            TBArtiodactylMaxAge.Clear();
            TBArtiodactylName.Clear();
            TBArtiodactylWeight.Clear();
            

        }

        private void КМлекопитающимToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void кПтицамToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void кПарнокопытнымToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void кЖивотнымToolStripMenuItem_Click(object sender, EventArgs e)
        {
            artiodactyls = null;
            Animals form = new Animals();
            form.ShowDialog();
            Close();
        }

        private void кМлекопитающимToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            artiodactyls = null;
            Mammals form = new Mammals();
            form.ShowDialog();
            Close();
        }

        private void кПтицамToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            artiodactyls = null;
            Birds form = new Birds();
            form.ShowDialog();
            Close();
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

        private void TBArtiodactylHabitat_KeyPress(object sender, KeyPressEventArgs e)
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
            if (artiodactyls.Count == 0)
            {
                SupportingMethods.ShowMistake(content: "Массив пуст");
            }
            else
            {
                foreach (OrderArtiodactyl artiodactyl in artiodactyls)
                {
                    int weight = artiodactyl.Weight;
                    string name = artiodactyl.Name;
                    int incubationPeriod = artiodactyl.IncubationPeriod;
                    int maxAge = artiodactyl.LifeExpectancy;
                    bool horns = artiodactyl.HasHorns;
                    string habitat = artiodactyl.Habitat;

                    string output = name + ", " + weight + "кг, " + incubationPeriod + " месяцев, " + maxAge + " лет, " + "есть рога: " + horns + ", " + habitat + "\r\n";
                    richTextBox1.Text += output;
                }
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

        private void КЧасти2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Part2 form = new Part2();
            form.ShowDialog();
            Close();
        }
    }
}

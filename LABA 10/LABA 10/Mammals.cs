using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace LABA_10
{
    public partial class Mammals : Form
    {
        public Mammals()
        {
            InitializeComponent();
        }
        List<ClassMammals> mammals = new List<ClassMammals>();

        private void BTAnimalCreate_Click(object sender, EventArgs e)
        {
            string name = Inputs.InputName(TBMammalName.Text);
            if (name != null)
            {
                int weight = Inputs.InputWeight(TBMammalWeight.Text);
                if (weight > 0)
                {
                    int incubationPeriod = Inputs.InputIncubationPeriod(TBIncubationPeriod.Text);

                    if (incubationPeriod > 0)
                    {
                        int lifeExtrancy = Inputs.InputLifeExpectancy(TBMaxAge.Text);
                        if (lifeExtrancy > 0)
                        {
                            ClassMammals mammal = new ClassMammals(incubationPeriod, lifeExtrancy, weight, name);
                            SupportingMethods.zoo.Add(mammal);
                            mammals.Add(mammal);
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
                }else
                {
                    SupportingMethods.ShowMistake(content: "Вес введен неверно");
                }
            }

            TBIncubationPeriod.Clear();
            TBMammalName.Clear();
            TBMammalWeight.Clear();
            TBMaxAge.Clear();
        }

        private void кЖивотнымToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mammals = null;
            Animals form = new Animals();
            form.ShowDialog();
            Close();
        }

        private void кПтицамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mammals = null;
            Birds form = new Birds();
            form.ShowDialog();
            Close();
        }

        private void кПарнокопытнымToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mammals = null;
            Artiodactyl form = new Artiodactyl();
            form.ShowDialog();
            Close();
        }

        private void TBMammalWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8)
            {
                e.Handled = true;
            }
        }

        private void TBIncubationPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8)
            {
                e.Handled = true;
            }
        }

        private void TBMaxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && s != 8)
            {
                e.Handled = true;
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

        private void выводМассиваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            if (mammals.Count == 0)
            {
                SupportingMethods.ShowMistake(content: "Массив пуст");
            }
            else
            {
                foreach (ClassMammals mammal in mammals)
                {
                    int weight = mammal.Weight;
                    string name = mammal.Name;
                    int incubationPeriod = mammal.IncubationPeriod;
                    int maxAge = mammal.LifeExpectancy;

                    string output = name + ", " + weight + "кг, " +incubationPeriod+" месяцев, "+maxAge+" лет"+"\r\n";
                    richTextBox1.Text += output;
                }
            }
        }

        private void КЧасти2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Part2 form = new Part2();
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                res = MessageBox.Show("Закрыть приложение?", "", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                    Close();
            }
            _Forms(this, null);
        }
        public static void _Forms(Form _from, Form _to)
        {

        }
    }
}

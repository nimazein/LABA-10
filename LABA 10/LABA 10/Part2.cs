using System;
using System.Windows.Forms;

namespace LABA_10
{
    public partial class Part2 : Form
    {
        public Part2()
        {
            InitializeComponent();
        }

        int selectedItem;
        int sumWeight;
        int numberOfObjectsWithThisType;
        private void BTCountWeight_Click(object sender, EventArgs e)
        {
            if (SupportingMethods.zoo.Count == 0)
            {
                SupportingMethods.ShowMistake(content: "Массив пуст");
                return;
            }
            sumWeight = 0;
            numberOfObjectsWithThisType = 0;
            TBOutputWeight.Clear();
            selectedItem = comboBox1.SelectedIndex;

            CountSumWeight();
            if (numberOfObjectsWithThisType == 0)
            {
                SupportingMethods.ShowMistake(content: "Объектов такого типа в массиве нет");
                return;
            }

            CountAndOutputAverageWeight();

        }
        private void CountSumWeight()
        {
            
            foreach (object animal in SupportingMethods.zoo)
            {
                if (animal is KingdomAnimal)
                {
                    if (animal is ClassBirds)
                    {
                        if (selectedItem == 2)
                        {
                            ClassBirds bird = animal as ClassBirds;
                            numberOfObjectsWithThisType++;

                            sumWeight += bird.Weight;
                        }
                        continue;
                    }
                    if (animal is ClassMammals)
                    {
                        if (animal is OrderArtiodactyl)
                        {
                            if (selectedItem == 3)
                            {
                                OrderArtiodactyl artiodactyl = animal as OrderArtiodactyl;
                                numberOfObjectsWithThisType++;

                                sumWeight += artiodactyl.Weight;
                            }
                            continue;
                        }
                        if (selectedItem == 1)
                        {
                            ClassMammals mammal = animal as ClassMammals;
                            numberOfObjectsWithThisType++;

                            sumWeight += mammal.Weight;
                        }
                        continue;
                    }
                    if (selectedItem == 0)
                    {
                        KingdomAnimal being = animal as KingdomAnimal;
                        numberOfObjectsWithThisType++;

                        sumWeight += being.Weight;
                    }
                }
            }

        }

        private void CountAndOutputAverageWeight()
        {
            int averageWeight = sumWeight / numberOfObjectsWithThisType;

            TBOutputWeight.Text = averageWeight.ToString();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!BTCountWeight.Enabled)
                BTCountWeight.Enabled = true;

            numberOfObjectsWithThisType = 0;
        }

        private void Part2_Load(object sender, EventArgs e)
        {
            BTCountWeight.Enabled = false;
        }

        private void BTShowBirds_Click(object sender, EventArgs e)
        {
            int numberOfBirds = 0;

            foreach (object animal in SupportingMethods.zoo)
            {
                FindAndOutputBirds(animal);
            }
            if (numberOfBirds == 0)
            {
                string content = "Не было создано ни одной птицы";
                string header = "info";
                MessageBox.Show(content, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            void FindAndOutputBirds(object animal)
            {
                if (animal is ClassBirds)
                {
                    numberOfBirds++;
                    ClassBirds bird = animal as ClassBirds;

                    string output = bird.Name + "\r\n";
                    TBOutputBirds.Text += output;
                }
            }
        }
        

        int sumMaxAge;
        int averageMaxAge;
        private void BTCountMaxAge_Click(object sender, EventArgs e)
        {

            sumMaxAge = 0;
            averageMaxAge = 0;
            numberOfObjectsWithThisType = 0;

            CountSumMaxAge();

            if (numberOfObjectsWithThisType == 0)
            {
                SupportingMethods.ShowMistake(content: "Не было создано ни одного животного");
                return;
            }
            CountAndOutputAverageMaxAge();
        }
        private void CountSumMaxAge()
        {
            foreach (object animal in SupportingMethods.zoo)
            {
                if (animal is ClassMammals)
                {
                    if (animal is OrderArtiodactyl)
                    {
                        continue;
                    }
                    else
                    {
                        ClassMammals mammal = animal as ClassMammals;
                        numberOfObjectsWithThisType++;

                        sumMaxAge += mammal.LifeExpectancy;
                    }                  
                }
            }
        }

        private void CountAndOutputAverageMaxAge()
        {
            averageMaxAge = sumMaxAge / numberOfObjectsWithThisType;
            TBMaxAge.Text = averageMaxAge.ToString();
        }
    }
}

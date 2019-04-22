using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA_10
{
    class SupportingMethods
    {
        public static bool IsStringEmpty(string line)
        {
            return String.IsNullOrEmpty(line) | String.IsNullOrWhiteSpace(line);
        }
        public static void ShowMistake(string content = "Поля должны быть заполнены", string header = "Ошибка")
        {
            MessageBox.Show(content, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool IsRightWeight(int weight)
        {
            bool isRightWeight = false;
            if (weight == 0)
            {
                isRightWeight = false;
            }
            else if (weight > 152000)
            {
                isRightWeight = false;
            }
            else
            {
                isRightWeight = true;
            }
            return isRightWeight;
        }
        public static List<object> zoo = new List<object>();
    }
}

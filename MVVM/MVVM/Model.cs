using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CalculatorMVVM
{
    class Model
    {
        public static List<string> dataList = new List<string> { "Сложение", "Вычитание", "Умножение", "Деление" };

        public static double result;
    }
}

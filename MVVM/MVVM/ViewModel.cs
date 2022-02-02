using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace CalculatorMVVM
{
    class ViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        double x1, x2;
        string s ;
        double result;
        public string Result
        {
            get
            {
                return Model.result.ToString();
            }
        }
        public double ChangeX1
        {
            set
            {
                x1 = value;
            }
        }

        public double ChangeX2
        {
            set
            {
                x2 = value;
            }
        }
        public List<string> ComboChange
        {
            get
            {
                return Model.dataList;
            }
        }

        int cbIndex = -1;
        public int IndexSelected
        {
            set
            {
                cbIndex = value;
                s = Model.dataList[cbIndex];
                PropertyChanged(this, new PropertyChangedEventArgs("CBIndex"));
            }
        }




        public RoutedCommand Command { get; set; } = new RoutedCommand();
        public void Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (s == "Сложение")
            {
                result = x1 + x2;
            }
            if (s == "Вычитание")
            {
                result = x1 - x2;
            }
            if (s == "Умножение")
            {
                result = x1 * x2;
            }
            if (s == "Деление")
            {
                result = x1 / x2;
            }

            Model.result = result;
            PropertyChanged(this, new PropertyChangedEventArgs("Result"));
        }
        public CommandBinding bind;
        public ViewModel()
        {
            bind = new CommandBinding(Command);
            bind.Executed += Command_Executed;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calcolatrice
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string exp;
        bool negativeExp = false;
        private void Number_Click(object sender, RoutedEventArgs e)
        {
            if (exp == "0")
                exp = "";
            Button button = (Button)sender;
            exp += button.Content;
            PrintToLabel();
        }
        private void AC_Click(object sender, RoutedEventArgs e) //Cancella tutto
        {
            exp = "0";
            PrintToLabel();
        }
        private void Delete_Click(object sender, RoutedEventArgs e) //Cancella l'ultimo
        {
            exp = exp.Remove(exp.Length - 1, 1);
            PrintToLabel();
        }
        private void PrintToLabel()
        {
            if(exp == "")
                exp = "0";
            if (negativeExp)
                Result.Content = "-(" + exp + ")";
            else
                Result.Content = exp;
        }
        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            bool operation;
            Button button = (Button)sender;
            if (exp == "" || exp[exp.Length - 1] == '+' || exp[exp.Length - 1] == '/' || exp[exp.Length - 1] == '-' || exp[exp.Length - 1] == '*')
                return;
            exp += button.Content;
            PrintToLabel();
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            DataTable calc = new DataTable();
            exp = exp.Replace(',', '.');
            try
            { var result = calc.Compute(exp, null);
                exp = result.ToString();
                PrintToLabel();
            }
            catch
            {
                exp = "Syntax Error";
                PrintToLabel();
                exp = "";
            }
        }
        private void Negative_Click(object sender, RoutedEventArgs e)
        {
            negativeExp = !negativeExp;
            PrintToLabel();
		}

		private void Point_Click(object sender, RoutedEventArgs e)
		{
			exp += ".";
			PrintToLabel();
		}

		private void Percentage_Click(object sender, RoutedEventArgs e)
		{
            Equals_Click(null, null);
		}
	}
}

using System;
using System.Collections.Generic;
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
        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            exp += button.Content;
            PrintToLabel();
        }
        private void AC_Click(object sender, RoutedEventArgs e)
        {
            exp = "0";
            PrintToLabel();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            exp = exp.Remove(exp.Length - 1, 1);
            PrintToLabel();
        }
        private void PrintToLabel()
        {
            if(exp == "")
                exp = "0";
            Result.Content = exp;
        }
    }
}

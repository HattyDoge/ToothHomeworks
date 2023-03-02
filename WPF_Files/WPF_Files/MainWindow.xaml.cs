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

namespace WPF_Files
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WriteFile_Click(object sender, RoutedEventArgs e)
        {
            string[] Cognome = new string[12];
            string[] Nome = new string[12];
            int[] Peso = new int[12];
            int[] Altezza = new int[12];
            int[] Età = new int[12];
            Cognome[0] = "Pippo01"; Nome[0] = "Pippo02"; Peso[0] = 80; Altezza[0] = 190; Età[0] = 46;
            Cognome[1] = "Pippo11"; Nome[1] = "Pippo12"; Peso[1] = 50; Altezza[1] = 160; Età[1] = 35;
            Cognome[2] = "Pippo21"; Nome[2] = "Pippo22"; Peso[2] = 100; Altezza[2] = 190; Età[2] = 60;
            Cognome[3] = "Pippo31"; Nome[3] = "Pippo32"; Peso[3] = 76; Altezza[3] = 187; Età[3] = 25;
            Cognome[4] = "Pippo41"; Nome[4] = "Pippo42"; Peso[4] = 50; Altezza[4] = 160; Età[4] = 32;
            Cognome[5] = "Pippo51"; Nome[5] = "Pippo52"; Peso[5] = 78; Altezza[5] = 175; Età[5] = 25;
            Cognome[6] = "Pippo61"; Nome[6] = "Pippo62"; Peso[6] = 95; Altezza[6] = 190; Età[6] = 38;
            Cognome[7] = "Pippo71"; Nome[7] = "Pippo72"; Peso[7] = 90; Altezza[7] = 180; Età[7] = 47;
            Cognome[8] = "Pippo81"; Nome[8] = "Pippo82"; Peso[8] = 100; Altezza[8] = 190; Età[8] = 25;
            Cognome[9] = "Pippo91"; Nome[9] = "Pippo92"; Peso[9] = 97; Altezza[9] = 190; Età[9] = 42;
            Cognome[10] = "Pippo101"; Nome[10] = "Pippo102"; Peso[10] = 84; Altezza[10] = 168; Età[10] = 25;
            Cognome[11] = "Pippo111"; Nome[11] = "Pippo112"; Peso[11] = 90; Altezza[11] = 175; Età[11] = 58;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
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

namespace ProduzioneAgricola
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] anni = new string [5];
        public string[] prodotti = new string[7];
        public int[,] produzione;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        public void LeggiDaFile(string fileDir, ref string[] vect)
        {
            using (StreamReader sr = new StreamReader(fileDir))
            {
                int i = 0;
                while (!sr.EndOfStream)
                {
                    vect[i++] = sr.ReadLine();
                }
            }
        }

        private void Btn_CaricaFile_Click(object sender, RoutedEventArgs e)
        {
            produzione = new int[prodotti.Length, anni.Length];
            string fileDir = @"../../../Anno.txt";
            LeggiDaFile(fileDir, ref anni);
            fileDir = @"../../../Prodotti.txt";
            LeggiDaFile(fileDir, ref prodotti);
            using (StreamReader sr = new StreamReader(fileDir))
            {
                int i = 0;
                while (!sr.EndOfStream)
                {
                    string[] linea = sr.ReadLine().Split("_");
                    for (int j = 0; j < linea.Length; j++)
                        produzione[i,j] = int.Parse(linea[j]);
                }
            }
        }

        private void Btn_Tutto_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < anni.Length; i++)
                for(int j = 0; j < prodotti.Length; j++)
                    Dg_Out.Items.Add(new
                    {
                        Year = anni[i],
                        Product = prodotti[j] ,
                        Production = produzione[j, i]
                    });
        }

        private void Btn_Prodotto_Click(object sender, RoutedEventArgs e)
        {
            string prodottoInserito = Txt_Prodotto.Text;
            for (int i = 0; i < prodotti.Length; i++ )
            {
                if (prodottoInserito == prodotti[i])
                {
                    for (int j = 0; j < anni.Length; j++)
                    {
                        Lbx_ProduzioneOut.Items.Add($"{anni[j]} {produzione[i,j]}");
                    }
                    break;
                }
            }
            Txt_Prodotto.Clear();
        }

        private void Btn_Anno_Click(object sender, RoutedEventArgs e)
        {
            string annoInserito = Txt_Anni.Text;
            for (int i = 0; i < anni.Length; i++)
            {
                if (annoInserito == anni[i])
                {
                    for (int j = 0; j < prodotti.Length; j++)
                    {
                        Lbx_ProduzioneOut.Items.Add($"{prodotti[j]} {produzione[j, i]}");
                    }
                    break;
                }
            }
            Txt_Anni.Clear();
        }

        private void Btn_Media_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

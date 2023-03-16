using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPF_APPLICATION
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    struct People
    {
        public string name;
        public string surname;
        public int age;
        public int height;
        public int weight;
        public int activity;
    }
    public enum attività
    {
        Commerciante = 0,
        Dipendente,
        LiberoProfessionista,
        Artigiano,
        Imprenditore
    }
    public partial class MainWindow : Window
    {
        public int attivitàScelta;
        public MainWindow()
        {
            InitializeComponent();
        }
        public int peopleIndex;
        private void Btn_InitializeFile_Click(object sender, RoutedEventArgs e)
        {
            peopleIndex = 0;
            People[] people = new People[50];
            people[peopleIndex].surname = "Pippo01"; people[peopleIndex].name = "Pippo02"; people[peopleIndex].weight = 80; people[peopleIndex].height = 190; people[peopleIndex].age = 46; people[peopleIndex].activity = 0;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo11"; people[peopleIndex].name = "Pippo12"; people[peopleIndex].weight = 50; people[peopleIndex].height = 160; people[peopleIndex].age = 35; people[peopleIndex].activity = 0;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo21"; people[peopleIndex].name = "Pippo22"; people[peopleIndex].weight = 100; people[peopleIndex].height = 190; people[peopleIndex].age = 60; people[peopleIndex].activity = 0;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo31"; people[peopleIndex].name = "Pippo32"; people[peopleIndex].weight = 76; people[peopleIndex].height = 187; people[peopleIndex].age = 25; people[peopleIndex].activity = 0;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo41"; people[peopleIndex].name = "Pippo42"; people[peopleIndex].weight = 50; people[peopleIndex].height = 160; people[peopleIndex].age = 32; people[peopleIndex].activity = 0;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo51"; people[peopleIndex].name = "Pippo52"; people[peopleIndex].weight = 78; people[peopleIndex].height = 175; people[peopleIndex].age = 25; people[peopleIndex].activity = 0;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo61"; people[peopleIndex].name = "Pippo62"; people[peopleIndex].weight = 95; people[peopleIndex].height = 190; people[peopleIndex].age = 38; people[peopleIndex].activity = 0;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo71"; people[peopleIndex].name = "Pippo72"; people[peopleIndex].weight = 90; people[peopleIndex].height = 180; people[peopleIndex].age = 47; people[peopleIndex].activity = 0;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo81"; people[peopleIndex].name = "Pippo82"; people[peopleIndex].weight = 100; people[peopleIndex].height = 190; people[peopleIndex].age = 25; people[peopleIndex].activity = 0;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo91"; people[peopleIndex].name = "Pippo92"; people[peopleIndex].weight = 97; people[peopleIndex].height = 190; people[peopleIndex].age = 42; people[peopleIndex].activity = 0;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo101"; people[peopleIndex].name = "Pippo102"; people[peopleIndex].weight = 84; people[peopleIndex].height = 168; people[peopleIndex].age = 25; people[peopleIndex].activity = 0;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo111"; people[peopleIndex].name = "Pippo112"; people[peopleIndex].weight = 90; people[peopleIndex].height = 175; people[peopleIndex].age = 58; people[peopleIndex].activity = 0;
            string fileName = "C:\\Users\\leonardo.frassineti\\Desktop\\MolareToothHomeworks\\WPF_APPLICATION\\DataFile.txt";

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                for (int i = 0; i < 12; i++)
                {
                    sw.WriteLine($"{people[i].surname}|{people[i].name}|{people[i].weight}|{people[i].height}|{people[i].age}");
                }
                sw.Close();
            }
            Btn_InsertNewData.Visibility = Visibility.Visible;
            Btn_File_Output.Visibility = Visibility.Visible;
            Btn_Order.Visibility = Visibility.Visible;
            Btn_InitializeFile.Visibility = Visibility.Visible;
        }
        public void UncheckAll()
        {
            RBCommerciante_0.IsChecked = false;
            RBDipendente_1.IsChecked = false;
            RBLiberoProfessionista_2.IsChecked = false;
            RBArtigiano_3.IsChecked = false;
            RBImprenditore_4.IsChecked = false;
        }
        private void Attività_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = (RadioButton)sender;

            switch (radioButton.Name)
            {
                case "RBCommerciante_0":
                    attivitàScelta = (int)attività.Commerciante;
                    break;
                case "RBDipendente_1":
                    attivitàScelta = (int)attività.Dipendente;
                    break;
                case "RBLiberoProfessionista_2":
                    attivitàScelta = (int)attività.LiberoProfessionista;
                    break;
                case "RBArtigiano_3":
                    attivitàScelta = (int)attività.Artigiano;
                    break;
                case "RBImprenditore_4":
                    attivitàScelta = (int)attività.Imprenditore;
                    break;
            }
        }
        private void Btn_InsertNewData_Click(object sender, RoutedEventArgs e)
        {
            Vbx_InputData.Visibility = Visibility.Visible;
            GpBx_Attività.Visibility = Visibility.Visible;
            
        }
        private void Btn_Order_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Btn_File_Output_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                for (int i = 0; i < 12; i++)
                {
                    sr
                }
                sr.Close();
            }
        }
    }
}

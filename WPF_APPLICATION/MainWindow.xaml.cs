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
    }
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int peopleIndex;
        private void Btn_InitializeFile_Click(object sender, RoutedEventArgs e)
        {
            peopleIndex = 0;
            People[] people = new People[50];
            people[peopleIndex].surname = "Pippo01"; people[peopleIndex].name = "Pippo02"; people[peopleIndex].weight = 80; people[peopleIndex].height = 190; people[peopleIndex].age = 46;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo11"; people[peopleIndex].name = "Pippo12"; people[peopleIndex].weight = 50; people[peopleIndex].height = 160; people[peopleIndex].age = 35;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo21"; people[peopleIndex].name = "Pippo22"; people[peopleIndex].weight = 100; people[peopleIndex].height = 190; people[peopleIndex].age = 60;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo31"; people[peopleIndex].name = "Pippo32"; people[peopleIndex].weight = 76; people[peopleIndex].height = 187; people[peopleIndex].age = 25;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo41"; people[peopleIndex].name = "Pippo42"; people[peopleIndex].weight = 50; people[peopleIndex].height = 160; people[peopleIndex].age = 32;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo51"; people[peopleIndex].name = "Pippo52"; people[peopleIndex].weight = 78; people[peopleIndex].height = 175; people[peopleIndex].age = 25;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo61"; people[peopleIndex].name = "Pippo62"; people[peopleIndex].weight = 95; people[peopleIndex].height = 190; people[peopleIndex].age = 38;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo71"; people[peopleIndex].name = "Pippo72"; people[peopleIndex].weight = 90; people[peopleIndex].height = 180; people[peopleIndex].age = 47;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo81"; people[peopleIndex].name = "Pippo82"; people[peopleIndex].weight = 100; people[peopleIndex].height = 190; people[peopleIndex].age = 25;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo91"; people[peopleIndex].name = "Pippo92"; people[peopleIndex].weight = 97; people[peopleIndex].height = 190; people[peopleIndex].age = 42;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo101"; people[peopleIndex].name = "Pippo102"; people[peopleIndex].weight = 84; people[peopleIndex].height = 168; people[peopleIndex].age = 25;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo111"; people[peopleIndex].name = "Pippo112"; people[peopleIndex].weight = 90; people[peopleIndex].height = 175; people[peopleIndex].age = 58;
            string fileName = "C:\\Users\\leonardo.frassineti\\Desktop\\MolareToothHomeworks\\WPF_APPLICATION\\DataFile.txt";
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                for (int i = 0; i < 12; i++)
                {
                    sw.WriteLine($"{people[i].surname}|{people[i].name}|{people[i].weight}|{people[i].height}|{people[i].age}");
                }
                sw.Close();
            }
            Vbx_InputData.Visibility = Visibility.Visible;
            Btn_InsertNewData.Visibility = Visibility.Visible;
        }

        private void Btn_InsertNewData_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

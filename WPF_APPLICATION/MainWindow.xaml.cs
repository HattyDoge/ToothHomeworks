using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public struct People
    {
        public string name;
        public string surname;
        public int age;
        public int height;
        public int weight;
        public int activity;
    }


    public partial class MainWindow : Window
    {

        public string fileName = "..\\..\\..\\DataFile.txt";
        public int attivitàScelta;
        string[] activity = { "Commerciante", "Artigiano", "Dipendente", "LiberoProfessionista","Imprenditore"};
        public MainWindow()
        {
            InitializeComponent();

            Cb_ActivityCode.Items.Add("Commerciante");
            Cb_ActivityCode.Items.Add("Artigiano");
            Cb_ActivityCode.Items.Add("Dipendente");
            Cb_ActivityCode.Items.Add("LiberoProfessionista");
            Cb_ActivityCode.Items.Add("Imprenditore");
        }
        public int peopleIndex;
        public People[] people;

        private void Btn_InitializeFile_Click(object sender, RoutedEventArgs e)
        {

            people = new People[50];
            peopleIndex = 0;

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
            people[peopleIndex].surname = "Pippo51"; people[peopleIndex].name = "Pippo52"; people[peopleIndex].weight = 78; people[peopleIndex].height = 175; people[peopleIndex].age = 25; people[peopleIndex].activity = 4;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo61"; people[peopleIndex].name = "Pippo62"; people[peopleIndex].weight = 95; people[peopleIndex].height = 190; people[peopleIndex].age = 38; people[peopleIndex].activity = 2;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo71"; people[peopleIndex].name = "Pippo72"; people[peopleIndex].weight = 90; people[peopleIndex].height = 180; people[peopleIndex].age = 47; people[peopleIndex].activity = 1;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo81"; people[peopleIndex].name = "Pippo82"; people[peopleIndex].weight = 100; people[peopleIndex].height = 190; people[peopleIndex].age = 25; people[peopleIndex].activity = 3;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo91"; people[peopleIndex].name = "Pippo92"; people[peopleIndex].weight = 97; people[peopleIndex].height = 190; people[peopleIndex].age = 42; people[peopleIndex].activity = 2;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo101"; people[peopleIndex].name = "Pippo102"; people[peopleIndex].weight = 84; people[peopleIndex].height = 168; people[peopleIndex].age = 25; people[peopleIndex].activity = 3;
            peopleIndex++;
            people[peopleIndex].surname = "Pippo111"; people[peopleIndex].name = "Pippo112"; people[peopleIndex].weight = 90; people[peopleIndex].height = 175; people[peopleIndex].age = 58; people[peopleIndex].activity = 4;

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                for (int i = 0; i < peopleIndex; i++)
                {
                    sw.WriteLine($"{people[i].surname}|{people[i].name}|{people[i].weight}|{people[i].height}|{people[i].age}|{people[i].activity}");
                }
                sw.Close();
            }
            Btn_InsertNewData.Visibility = Visibility.Visible;
            Btn_File_Output.Visibility = Visibility.Visible;
            Btn_Order.Visibility = Visibility.Visible;
            Btn_InitializeFile.Visibility = Visibility.Visible;
            Btn_TransferToFile.Visibility = Visibility.Visible;
        }
        private void Cb_Input()
        {
            for (int i = 0; i < activity.Length; i++)
            {
                if (Cb_ActivityCode.Text == activity[i])
                {
                    attivitàScelta = i;
                }
            }
        }
        private void Btn_InsertNewData_Click(object sender, RoutedEventArgs e)
        {
            peopleIndex++;

            Vbx_Output.Visibility = Visibility.Hidden;
            Vbx_InputData.Visibility = Visibility.Visible;

            bool retry = true;
            people[peopleIndex].surname = Tbx_Surname.Text;
            people[peopleIndex].name = Tbx_Name.Text;
            retry = int.TryParse(Tbx_Age.Text, out people[peopleIndex].age);
            retry = int.TryParse(Tbx_Weight.Text, out people[peopleIndex].weight);
            retry = int.TryParse(Tbx_Height.Text, out people[peopleIndex].height);
            Cb_Input();
            people[peopleIndex].activity = attivitàScelta;
            if (!retry)
            {
                peopleIndex--;
            }
            Tbx_Age.Clear();
            Tbx_Surname.Clear();
            Tbx_Name.Clear();
            Tbx_Weight.Clear();
            Tbx_Height.Clear();
            Cb_ActivityCode.SelectedItem = null;
        }
        private void Btn_Order_Click(object sender, RoutedEventArgs e)
        {
            Vbx_InputData.Visibility = Visibility.Hidden;
            Vbx_Output.Visibility = Visibility.Hidden;

            SelectionSort();
        }

        private void Swap(int index, int index2)
        {
            int temp = people[index2].weight;
            people[index2].weight = people[index].weight;
            people[index].weight = temp;

            temp = people[index2].height;
            people[index2].height = people[index].height;
            people[index].height = temp;

            temp = people[index2].age;
            people[index2].age = people[index].age;
            people[index].age = temp;

            temp = people[index2].activity;
            people[index2].activity = people[index].activity;
            people[index].activity = temp;

            string temp1 = people[index2].name;
            people[index2].name = people[index].name;
            people[index].name = temp1;

            temp1 = people[index2].surname;
            people[index2].surname = people[index].surname;
            people[index].surname = temp1;

        }
        private bool CompareString(string str1, string str2)
        {
            int length = str1.Length;
            if (str1.Length > str2.Length)
            {
                length = str2.Length;
            }    
            for(int i = 0; i < length; i++)
            {
				if (str1[i] < str2[i])
					return false;
				if (str1[i] > str2[i])
                    return true;

            }
            return false;
        }
        private void SelectionSort()
        {
			for (int i = 0; i < peopleIndex; i++)
            {
                int jMin = i;
                for (int j = i + 1; j <= peopleIndex; j++)
                {
                    if (people[jMin].name.CompareTo(people[j].name) == 1)
                        jMin = j;
                }
                Swap(i, jMin);
            }
		}
        private void Btn_File_Output_Click(object sender, RoutedEventArgs e)
        {
            Dg_Out.Items.Clear();
            Lbx_Activity_Output.Items.Clear();
            Lbx_Weight_Output.Items.Clear();
            Lbx_Age_Output.Items.Clear();
            Lbx_Surname_Output.Items.Clear();
            Lbx_Name_Output.Items.Clear();
            Lbx_Height_Output.Items.Clear();

            Vbx_Output.Visibility = Visibility.Visible;
            Dg_Out.Visibility = Visibility.Visible;
            Vbx_InputData.Visibility = Visibility.Hidden;

            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] splittedLine = linea.Split("|");
                    Dg_Out.Items.Add(new
                    {
                        Name = splittedLine[1],
                        Surname = splittedLine[0],
                        Weight = splittedLine[2],
                        Height = splittedLine[3],
                        Age = splittedLine[4],
                        Activity = splittedLine[5],
                        Des_Activity = activity[int.Parse(splittedLine[5])]
                    });
                }
                sr.Close();
            }
        }

        private void Btn_TransferToFile_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                for (int i = 0; i <= peopleIndex; i++)
                {
                    sw.WriteLine($"{people[i].surname}|{people[i].name}|{people[i].weight}|{people[i].height}|{people[i].age}|{people[i].activity}");
                }
                sw.Close();
            }
        }
    }
}

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

namespace Squadre_Calcio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Team> Campionato;
        class Footballer
        {
            string name;
            int age;
            public string Name { get { return name;} set { name = value; } }
            public int Age { get { return age; } set { age = value; } }
            public Footballer(string name, int age) { this.age = age; this.name = name; }
        }
        class Team
        {
            string name;
            List<Footballer> footballers;
            public string TeamName { get { return name; } set { name = value; } }
            public int FootballersNumber { get { return footballers.Count; } }
            public Team(string teamName)
            {
                name = teamName;
                footballers = new List<Footballer>();
            }
            public void AddFootBaller(Footballer footballer)
            {
                footballers.Add(footballer);
            }
            public void AddFootBaller(string footballerName, int footballerAge)
            {
                Footballer footballer = new Footballer(footballerName, footballerAge);
                footballers.Add(footballer);
            }
            public Footballer GetFootballer(int index) { return footballers[index]; }
        }
        public MainWindow()
        {
            InitializeComponent();
            Campionato = new List<Team> { new Team("Juventus"), new Team("Cesena") };
            Campionato[0].AddFootBaller("Uomo1", 10);
            Campionato[0].AddFootBaller("Uomo2", 20);
            Campionato[0].AddFootBaller("Uomo3", 30);
            Campionato[0].AddFootBaller("Uomo4", 40);

            Campionato[1].AddFootBaller("Donna1", 10);
            Campionato[1].AddFootBaller("Donna2", 20);
            Campionato[1].AddFootBaller("Donna3", 30);
            Campionato[1].AddFootBaller("Donna4", 40);

            for (int i = 0; i < Campionato.Count; i++)
                PrintTeams(Campionato[i]);
        }
        private void PrintTeams(Team team)
        {
            Team_List.Items.Add(team.TeamName);
        }
        private void PrintFootballers(Footballer footballer)
        {
            Footballers_List.Items.Add($"{footballer.Name} {footballer.Age}");
        }
        private void Team_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            Footballers_List.Items.Clear();
            for (int i = 0; i < Campionato.Count; i++)
                if (Team_List.SelectedItem.ToString() == Campionato[i].TeamName)
                {
                    Team team = Campionato[i];
                    for (int j = 0; j < team.FootballersNumber; j++)
                    {
                        PrintFootballers(team.GetFootballer(j));
                    }
                }
        }
    }
}

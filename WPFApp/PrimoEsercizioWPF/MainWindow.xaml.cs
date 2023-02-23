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

namespace PrimoEsercizioWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        enum TypeOfActivity
        {
            Commerciante,
            Dipendente,
            LiberoProfessionista,
            Artigiano,
            Imprenditore
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        public enum attività
        {
            Commerciante = 0,
            Dipendente,
            LiberoProfessionista,
            Artigiano,
            Imprenditore
        }
        public struct Persona
        {
            public int altezza;
            public double peso;
            public int età;
            public string nome;
            public string cognome;
            public int attività;
            public double rapporto;

        }
        public Persona[] persone;
        public int indiceVettore = 0;
        public int attivitàScelta;

        public void LbxClearAll()
        {
            Lbx_AltezzaOut.Items.Clear();
            Lbx_NomeOut.Items.Clear();
            Lbx_CognomeOut.Items.Clear();
            Lbx_EtàOut.Items.Clear();
            Lbx_PesoOut.Items.Clear();
            Lbx_AttivitàOut.Items.Clear();
            Lbx_BestRapportoOut.Items.Clear();
            Lbx_WorstRapportoOut.Items.Clear();
        }
        public void InputHidden()
        {
            Txt_Altezza.Visibility = Visibility.Hidden;
            Txt_Cognome.Visibility = Visibility.Hidden;
            Txt_Nome.Visibility = Visibility.Hidden;
            Txt_Età.Visibility = Visibility.Hidden;
            Txt_Peso.Visibility = Visibility.Hidden;

            Lbl_Altezza.Visibility = Visibility.Hidden;
            Lbl_Cognome.Visibility = Visibility.Hidden;
            Lbl_Nome.Visibility = Visibility.Hidden;
            Lbl_Età.Visibility = Visibility.Hidden;
            Lbl_Peso.Visibility = Visibility.Hidden;

            GpBx_Attività.Visibility = Visibility.Hidden;
        }
        public void OutPutVisibile()
        {
            Lbx_AltezzaOut.Visibility = Visibility.Visible;
            Lbx_EtàOut.Visibility = Visibility.Visible;
            Lbx_NomeOut.Visibility = Visibility.Visible;
            Lbx_PesoOut.Visibility = Visibility.Visible;
            Lbx_CognomeOut.Visibility = Visibility.Visible;
            Lbx_AttivitàOut.Visibility = Visibility.Visible;
            Lbx_BestRapportoOut.Visibility = Visibility.Visible;
            Lbx_WorstRapportoOut.Visibility = Visibility.Visible;

            Lbl_AltezzaOut.Visibility = Visibility.Visible;
            Lbl_EtàOut.Visibility = Visibility.Visible;
            Lbl_NomeOut.Visibility = Visibility.Visible;
            Lbl_PesoOut.Visibility = Visibility.Visible;
            Lbl_CognomeOut.Visibility = Visibility.Visible;
            Lbl_AttivitàOut.Visibility = Visibility.Visible;
            Lbl_BestRapportoOut.Visibility= Visibility.Visible;
            Lbl_WorstRapportoOut.Visibility = Visibility.Visible;
        }
        private void Btn_Inserimento_Click(object sender, RoutedEventArgs e)
        {
            persone = new Persona[int.Parse(Txt_NumeroPersone.Text)];
            Btn_ConfermaInserimento.Visibility = Visibility.Visible;

            Btn_Inserimento.Visibility = Visibility.Hidden;
            Lbl_NumeroPersone.Visibility = Visibility.Hidden;
            Txt_NumeroPersone.Visibility = Visibility.Hidden;

            Txt_Altezza.Visibility = Visibility.Visible;
            Txt_Cognome.Visibility = Visibility.Visible;
            Txt_Nome.Visibility = Visibility.Visible;
            Txt_Età.Visibility = Visibility.Visible;
            Txt_Peso.Visibility = Visibility.Visible;

            Lbl_Peso.Visibility = Visibility.Visible;
            Lbl_Altezza.Visibility = Visibility.Visible;
            Lbl_Cognome.Visibility = Visibility.Visible;
            Lbl_Nome.Visibility = Visibility.Visible;
            Lbl_Età.Visibility = Visibility.Visible;
            Lbl_DataIndividual.Visibility = Visibility.Visible;

            GpBx_Attività.Visibility = Visibility.Visible;
        }
        private void Btn_ConfermInsertion_Click(object sender, RoutedEventArgs e)
        {
            persone[indiceVettore].peso = int.Parse(Txt_Peso.Text);
            persone[indiceVettore].altezza = int.Parse(Txt_Altezza.Text);
            persone[indiceVettore].età = int.Parse(Txt_Età.Text);
            persone[indiceVettore].nome = Txt_Nome.Text;
            persone[indiceVettore].cognome = Txt_Cognome.Text;
            persone[indiceVettore].attività = attivitàScelta;
            GpBx_Attività.Visibility = Visibility.Visible;
            if (indiceVettore == persone.Length - 1)
            {
                InputHidden();
                Lbl_DataIndividual.Visibility = Visibility.Hidden;

                Btn_Activity.Visibility = Visibility.Visible;
                Btn_AllOtherData.Visibility = Visibility.Visible;
                Btn_Tallest.Visibility = Visibility.Visible;
                Btn_TuttiDati.Visibility = Visibility.Visible;
                Btn_Youngest.Visibility = Visibility.Visible;
                Btn_Rapporto.Visibility = Visibility.Visible;

                Btn_ConfermaInserimento.Visibility = Visibility.Hidden;
                Lbl_DataIndividual.Visibility = Visibility.Hidden;
                for(indiceVettore = 0; indiceVettore < persone.Length; indiceVettore++)
                    persone[indiceVettore].rapporto = persone[indiceVettore].peso / persone[indiceVettore].altezza;
            }
            Txt_Altezza.Clear();
            Txt_Età.Clear();
            Txt_Peso.Clear();
            Txt_Nome.Clear();
            Txt_Cognome.Clear();
            indiceVettore++;
        }


        private void Btn_AllData_Click(object sender, EventArgs e)
        {
            InputHidden();
            LbxClearAll();
            OutPutVisibile();
            for (indiceVettore = 0; indiceVettore < persone.Length; indiceVettore++)
            {
                Lbx_AltezzaOut.Items.Add(persone[indiceVettore].altezza);
                Lbx_NomeOut.Items.Add(persone[indiceVettore].nome);
                Lbx_CognomeOut.Items.Add(persone[indiceVettore].cognome);
                Lbx_PesoOut.Items.Add(persone[indiceVettore].peso);
                Lbx_EtàOut.Items.Add(persone[indiceVettore].età);
                Lbx_AttivitàOut.Items.Add(persone[indiceVettore].attività);
            }

        }
        private void Btn_Youngest_Click(object sender, RoutedEventArgs e)
        {
            OutPutVisibile();
            InputHidden();
            LbxClearAll();
            int etàMin = persone[0].età; ;
            for (indiceVettore = 1; indiceVettore < persone.Length; ++indiceVettore)
                if (persone[indiceVettore].età < etàMin)
                    etàMin = persone[indiceVettore].età;

            for (indiceVettore = 0; indiceVettore < persone.Length; ++indiceVettore)
            {
                if (persone[indiceVettore].età == etàMin)
                {
                    Lbx_AltezzaOut.Items.Add(persone[indiceVettore].altezza);
                    Lbx_NomeOut.Items.Add(persone[indiceVettore].nome);
                    Lbx_CognomeOut.Items.Add(persone[indiceVettore].cognome);
                    Lbx_PesoOut.Items.Add(persone[indiceVettore].peso);
                    Lbx_EtàOut.Items.Add(persone[indiceVettore].età);
                    Lbx_AttivitàOut.Items.Add(persone[indiceVettore].attività);
                }
            }
        }
        private void Btn_Activity_Click(object sender, RoutedEventArgs e)
        {
            InputHidden();
            OutPutVisibile();
            LbxClearAll();

            GpBx_Attività.Visibility = Visibility.Visible;

            for (indiceVettore = 0; indiceVettore < persone.Length; indiceVettore++)
                if (persone[indiceVettore].attività == attivitàScelta)
                {
                    Lbx_AltezzaOut.Items.Add(persone[indiceVettore].altezza);
                    Lbx_NomeOut.Items.Add(persone[indiceVettore].nome);
                    Lbx_CognomeOut.Items.Add(persone[indiceVettore].cognome);
                    Lbx_PesoOut.Items.Add(persone[indiceVettore].peso);
                    Lbx_EtàOut.Items.Add(persone[indiceVettore].età);
                    Lbx_AttivitàOut.Items.Add(persone[indiceVettore].attività);
                }
            attivitàScelta = 0;
        }
        private void Btn_AllOtherData_Click(object sender, RoutedEventArgs e)
        {
            InputHidden();
            OutPutVisibile();
            LbxClearAll();

            Txt_Cognome.Visibility = Visibility.Visible;
            Txt_Nome.Visibility = Visibility.Visible;

            Lbl_Cognome.Visibility = Visibility.Visible;
            Lbl_Nome.Visibility = Visibility.Visible;

            string cognomeInserito = Txt_Cognome.Text;
            string nomeInserito = Txt_Nome.Text;


            indiceVettore = 0;
            while (indiceVettore < persone.Length)
            {
                if (cognomeInserito == persone[indiceVettore].cognome && nomeInserito == persone[indiceVettore].nome)
                {
                    Lbx_CognomeOut.Items.Add(persone[indiceVettore].cognome);
                    Lbx_NomeOut.Items.Add(persone[indiceVettore].nome);
                    Lbx_AltezzaOut.Items.Add(persone[indiceVettore].altezza);
                    Lbx_PesoOut.Items.Add(persone[indiceVettore].peso);
                    Lbx_EtàOut.Items.Add(persone[indiceVettore].età);
                    Lbx_AttivitàOut.Items.Add(persone[indiceVettore].attività);
                    break;
                }
                indiceVettore++;
            }
            Txt_Nome.Clear();
            Txt_Cognome.Clear();

        }
        private void Btn_Tallest_Click(object sender, RoutedEventArgs e)
        {
            OutPutVisibile();
            InputHidden();
            LbxClearAll();
            int maxAltezza = persone[0].altezza;
            for (indiceVettore = 1; indiceVettore < persone.Length; ++indiceVettore)
                if (persone[indiceVettore].altezza > maxAltezza)
                    maxAltezza = persone[indiceVettore].altezza;

            for (indiceVettore = 0; indiceVettore < persone.Length; ++indiceVettore)
            {
                if (persone[indiceVettore].altezza == maxAltezza)
                {
                    Lbx_AltezzaOut.Items.Add(persone[indiceVettore].altezza);
                    Lbx_NomeOut.Items.Add(persone[indiceVettore].nome);
                    Lbx_CognomeOut.Items.Add(persone[indiceVettore].cognome);
                    Lbx_PesoOut.Items.Add(persone[indiceVettore].peso);
                    Lbx_EtàOut.Items.Add(persone[indiceVettore].età);
                    Lbx_AttivitàOut.Items.Add(persone[indiceVettore].attività);
                }
            }
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
                    UncheckAll();
                    break;
                case "RBDipendente_1":
                    attivitàScelta = (int)attività.Dipendente;
                    UncheckAll();
                    break;
                case "RBLiberoProfessionista_2":
                    attivitàScelta = (int)attività.LiberoProfessionista;
                    UncheckAll();
                    break;
                case "RBArtigiano_3":
                    attivitàScelta = (int)attività.Artigiano;
                    UncheckAll();
                    break;
                case "RBImprenditore_4":
                    attivitàScelta = (int)attività.Imprenditore;
                    UncheckAll();
                    break;
            }
        }

        private void Btn_Rapporto_Click(object sender, RoutedEventArgs e)
        {
            OutPutVisibile();
            InputHidden();
            LbxClearAll();
            double migliorRapporto = persone[0].rapporto;
            double peggiorRapporto = persone[0].rapporto;
            for (indiceVettore = 1; indiceVettore < persone.Length; ++indiceVettore)
            {
                if (persone[indiceVettore].rapporto < migliorRapporto)
                    migliorRapporto = persone[indiceVettore].rapporto;
                if (persone[indiceVettore].rapporto > peggiorRapporto)
                    peggiorRapporto = persone[indiceVettore].rapporto;
            }

            for (indiceVettore = 0; indiceVettore < persone.Length; ++indiceVettore)
            {
                if (persone[indiceVettore].rapporto == migliorRapporto)
                {
                    Lbx_AltezzaOut.Items.Add(persone[indiceVettore].altezza);
                    Lbx_NomeOut.Items.Add(persone[indiceVettore].nome);
                    Lbx_CognomeOut.Items.Add(persone[indiceVettore].cognome);
                    Lbx_PesoOut.Items.Add(persone[indiceVettore].peso);
                    Lbx_EtàOut.Items.Add(persone[indiceVettore].età);
                    Lbx_AttivitàOut.Items.Add(persone[indiceVettore].attività);
                    Lbx_BestRapportoOut.Items.Add(persone[indiceVettore].rapporto);
                }
                if (persone[indiceVettore].rapporto == peggiorRapporto)
                {
                    Lbx_AltezzaOut.Items.Add(persone[indiceVettore].altezza);
                    Lbx_NomeOut.Items.Add(persone[indiceVettore].nome);
                    Lbx_CognomeOut.Items.Add(persone[indiceVettore].cognome);
                    Lbx_PesoOut.Items.Add(persone[indiceVettore].peso);
                    Lbx_EtàOut.Items.Add(persone[indiceVettore].età);
                    Lbx_AttivitàOut.Items.Add(persone[indiceVettore].attività);
                    Lbx_WorstRapportoOut.Items.Add(persone[indiceVettore].rapporto);
                }
            }
        }
    }
}

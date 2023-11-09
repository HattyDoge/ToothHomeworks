using System.Xml.Linq;

namespace BankLoans
{
    internal class Program
    {
        class SimpleLoan
        {
            protected double capital;
            protected double interests;
            protected DateTime dateStart;
            protected DateTime dateEnd;
            double fee;
            double uppercut;
            double lifespan;
            public virtual double Uppercut { get { uppercut = capital * (interests * lifespan + 1); return uppercut; } set { } }
            public double Capital { get { return capital; } set { capital = value; } }
            public double Interests { get { return interests; } set { interests = value; } }
            public DateTime DateStart { get { return dateStart; } set { dateStart = value; } }
            public DateTime DateEnd { get { return dateEnd; } set { dateEnd = value; } }
            public SimpleLoan(double capital, double interests, DateTime dateStart, DateTime dateEnd)
            {
                this.capital = capital;
                this.interests = interests;
                this.dateStart = dateStart;
                this.dateEnd = dateEnd;
                uppercut = capital * (interests * lifespan + 1);
            }
            public override string ToString()
            {
                return $"Capitale = {capital}\nInterests = {interests}\nData di inizio prestito = {dateStart}\nData di fine prestito = {dateEnd}\n";
            }
        }
        class ComplexLoan : SimpleLoan
        {
            double uppercut;
            public ComplexLoan(double uppercut, double capital, double interests, DateTime dateStart, DateTime dateEnd) : base(capital, interests, dateStart, dateEnd)
            {
                this.uppercut = uppercut;
            }
            public override string ToString()
            {
                return $"Capitale = {capital}\nInterests = {interests}\nData di inizio prestito = {dateStart}\nData di fine prestito = {dateEnd}";
            }
        }
        class Client
        {
            string taxIDCode;
            string name;
            string surname;
            double salary;
            List<SimpleLoan> loans;
            public string TaxIDCode { get { return taxIDCode; } set { taxIDCode = value; } }
            public string Name { get { return name; } set { name = value; } }
            public string Surname { get { return surname; } set { surname = value; } }
            public double Salary { get { return salary; } set { salary = value; } }
            public Client(string taxIDCode, string name, string surname, double salary)
            {
                this.name = name;
                this.salary = salary;
                this.surname = surname;
                this.taxIDCode = taxIDCode;
                loans = new List<SimpleLoan>();
            }
            public Client(string taxIDCode, string name, string surname, double salary, SimpleLoan loan)
            {
                this.name = name;
                this.salary = salary;
                this.surname = surname;
                this.taxIDCode = taxIDCode;
                loans = new List<SimpleLoan> { loan };
            }
            public void AddLoan(SimpleLoan loan)
            {
                loans.Add(loan);
            }
            public double SumUppercuts()
            {

            }
            public override string ToString() 
            { 
                return $"Codice fiscale = {taxIDCode}\nNome = {name}\nCognome = {surname}\nSalario = {salary}";
            }
            //a una certa data qunato paga di rate
        }
        class Bank
        {
            string bankName;
            List<Client> clients;
            public Bank(Client client, string bankName)
            {
                clients = new List<Client> { client };
                this.bankName = bankName;
            }
            public Bank(List<Client> client, string bankName)
            {
                clients = client;
                this.bankName = bankName;
            }
            public void AddClient(Client client) 
            {
                clients.Add(client);
            }
            public void RemoveClient(Client client)
            {
                clients.Remove(client);
            }
            public void RemoveClient(string taxIDCode)
            {
                for(int i = 0; i < clients.Count; i++)
                    if (clients[i].TaxIDCode == taxIDCode)
                        clients.RemoveAt(i);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
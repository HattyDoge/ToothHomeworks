namespace BankLoans
{
    internal class Program
    {
        class PrestitoSemplice
        {
            double capital;
            double interests;
            DateTime dateStart;
            DateTime dateEnd;
            public PrestitoSemplice(double capital, double interests, DateTime dateStart, DateTime dateEnd)
            {
                this.capital = capital;
                this.interests = interests;
                this.dateStart = dateStart;
                this.dateEnd = dateEnd;
            }
        }
        class PrestitoComposto : PrestitoSemplice
        {
            public PrestitoComposto(double Montante, double capital, double interests, DateTime dateStart, DateTime dateEnd) : base(capital, interests, dateStart, dateEnd)
            {

            }
        }
        class Client
        {
            string taxIDCode;
            string name;
            string surname;
            double salary;
            public Client(string taxIDCode, string name, string surname, double salary)
            {
                this.name = name;
                this.salary = salary;
                this.surname = surname;
                this.taxIDCode = taxIDCode;
            }
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
            public void AddCliente(Client client) 
            {
                clients.Add(client);
            }
            public void RemoveCliente(Client client)
            {
                clients.Add(client);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
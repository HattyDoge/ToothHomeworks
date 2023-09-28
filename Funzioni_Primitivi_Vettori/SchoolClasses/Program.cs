namespace SchoolClasses
{
    class Student
    {
        string surname, name;
        int serialNumber;
        double averageGrade;
        public Student(string surname, string name, int serialNumber, double averageGrade) // Costruttore
        {
            this.surname = surname;
            this.name = name;
            this.serialNumber = serialNumber;
            this.averageGrade = averageGrade;
        }
        public Student(string surname, string name, int serialNumber) // Costruttore senza un parametro
        {
            this.surname = surname;
            this.name = name;
            this.serialNumber = serialNumber;
            this.averageGrade = 0.0;
        }
        // Metodi "Setter / Getter" per i campi dati
        
        public string GetName()                          { return name; }
        public string GetSurname()                       { return surname; }
        public int GetSerialNumber()                     {  return serialNumber; }
        public double GetAverageGrade()                  {  return averageGrade; }
        public void SetAverageGrade(double averageGrade) { if (averageGrade < 1.0 || averageGrade > 10.0) { throw new Exception("AverageGrade not valid"); } this.averageGrade = averageGrade; }
        
        // Proprietà per l'accesso ai campi dati pag. 139

        public string Surname { get { return surname; } }
        public string Name { get { return name; } }
        public int SerialNumber { get { return serialNumber; } }
        public double AverageGrade { get { return averageGrade; } set { if (value < 1.0 || value > 10.0) { throw new Exception("AverageGrade not valid"); } averageGrade = value; } }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Student sA = new Student("Verdi", "Luca", 1234, 6.6);
            Student sB = new Student("Verdi", "Luca", 1234);
            // Imposta la media di sA utilizzando metodo e proprietà
            sA.SetAverageGrade(6.6);
            sA.AverageGrade = 6.6;
        }
    }
}
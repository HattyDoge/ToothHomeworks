namespace ExerciseClassesProprieties
{
    enum Subjects
    {
        Matematica,
        SistemiReti,
        Informatica,
        Inglese,
        Letteratura,
        TPSIT,
        Telecomunicazioni,
        Count
    }
    class Scholar
    {

        int registerNumber;
        DateOnly birthDate;
#if true
        double[] averageGrade;
#else
        Dictionary<Subjects, double> averageGrades;
#endif
        string name;
        string surname;
        public Scholar(int registerNumber, string name, string surname, DateOnly birthDate)
        {
            int subjectsNum = (int)Subjects.Count;
            this.registerNumber = registerNumber;
            this.birthDate = birthDate;
            this.name = name;
            this.surname = surname;
            this.averageGrade = new double[subjectsNum];
        }
        public string Name { get { return name; } }
        public string Surname { get { return surname; } }
        public DateOnly BirthDate { get { return birthDate; } }
        public int RegisterNumber { get { return registerNumber; } }
        public double this [Subjects s] { get { return averageGrade[(int)s]; } set { if (value < 0 || value > 10) { averageGrade[(int)s] = value ; } } }
    }
    
    class SchoolClass
    {
        int year;
        string section;
        List<Scholar> scholars;
            
        SchoolClass(int year, string section, int classSize)
        {
            this.year = year;
            this.section = section;
            scholars = new List<Scholar>(classSize);
        }
    }
    
    internal class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
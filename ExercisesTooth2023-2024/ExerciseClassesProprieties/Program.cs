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
        Telecomunicazioni
    }
    class SchoolClass
    {
        int subjectsNum = 7;
        struct Scholar
        {
            public int registerNumber;
            public DateOnly birthDate;
            public double[] averageGrade;
            public string name;
            public string surname;
        }

        SchoolClass(int classSize)
        {
            Scholar[] scholar = new Scholar[classSize];
            for(int i = 0; i< scholar.Length; i++)
                scholar[i].averageGrade = new double[subjectsNum];
        }
        public Scholar GetStudentAt()
        {
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            
        }
    }
}
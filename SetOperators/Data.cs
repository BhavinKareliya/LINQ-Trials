using SetOperators.Models;
namespace SetOperators
{
    internal static class Data
    {
        public readonly static List<int> NumbersList = new();
        public readonly static List<Student> StudentList;
        public readonly static List<Student> StudentList2;
        public readonly static List<Employee> EmpList;
        public readonly static List<object> MixedData;
        static Data()
        {
            for (int i = 1; i <= 10000; i++) NumbersList.Add(i);
            for (int i = 1; i <= 10000; i++) NumbersList.Add(i);

            StudentList = new List<Student>()
            {
                new Student(){ID = 1, Name = "Vipul", Gender = "Male" , DOB=DateOnly.Parse("09-02-1999")},
                new Student(){ID = 2, Name = "Bhavin", Gender = "Male",DOB=DateOnly.Parse("09-02-2002")},
                new Student(){ID = 3, Name = "Jil", Gender = "Male",DOB=DateOnly.Parse("09-09-2000")},
                new Student(){ID = 4, Name = "Abhi", Gender = "Male",DOB=DateOnly.Parse("02-02-2001")},
                new Student(){ID = 11, Name = "Tessa", Gender = "Female",DOB=DateOnly.Parse("16-01-2002")},
                new Student(){ID = 12, Name = "Salena Gomez", Gender = "Female",DOB=DateOnly.Parse("29-08-1965")},
                new Student(){ID = 12, Name = "Salena Gomez", Gender = "Female",DOB=DateOnly.Parse("29-08-1965")},
                new Student(){ID = 13, Name = "Enrich", Gender = "Female",DOB=DateOnly.Parse("31-03-1988")},
                new Student(){ID = 14, Name = "Ema Watson", Gender = "Female",DOB=DateOnly.Parse("15-04-2006")}
            };


            StudentList2 = new List<Student>()
            {
                new Student(){ID = 1, Name = "Vipul", Gender = "Male" , DOB=DateOnly.Parse("09-02-1999")},
                new Student(){ID = 2, Name = "Bhavin", Gender = "Male",DOB=DateOnly.Parse("09-02-2002")},
                new Student(){ID = 3, Name = "Jil", Gender = "Male",DOB=DateOnly.Parse("09-09-2000")},
                new Student(){ID = 13, Name = "Enrich", Gender = "Female",DOB=DateOnly.Parse("31-03-1988")},
                new Student(){ID = 14, Name = "Emmiy Gross", Gender = "Female",DOB=DateOnly.Parse("15-04-2006")}
            };

            EmpList = new List<Employee>()
            {
                new Employee(){ID = 1, Name = "Vipul", Gender = "Male" , DOB=DateOnly.Parse("09-02-1999")},
                new Employee(){ID = 2, Name = "Bhavin", Gender = "Male",DOB=DateOnly.Parse("09-02-2002")},
                new Employee(){ID = 3, Name = "Jil", Gender = "Male",DOB=DateOnly.Parse("09-09-2000")},
                new Employee(){ID = 4, Name = "Abhi", Gender = "Male",DOB=DateOnly.Parse("02-02-2001")},
                new Employee(){ID = 11, Name = "Tessa", Gender = "Female",DOB=DateOnly.Parse("16-01-2002")},
                new Employee(){ID = 12, Name = "Salena Gomez", Gender = "Female",DOB=DateOnly.Parse("29-08-1965")},
                new Employee(){ID = 13, Name = "Enrich", Gender = "Female",DOB=DateOnly.Parse("31-03-1988")},
                new Employee(){ID = 14, Name = "Ema Watson", Gender = "Female",DOB=DateOnly.Parse("15-04-2006")}
            };

            MixedData = new List<object>() { 1, 2, "Hello", "World", new Student() { ID = 1, Name = "Vipul", Gender = "Male" } };
        }
    }
}

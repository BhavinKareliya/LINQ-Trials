using SetOperators.Models;

namespace SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var demoNDistinct = Data.NumbersList.Distinct().ToList();

            var demoExcept = Data.StudentList.Except(Data.StudentList2).ToList();

            var demoDistinct = Data.StudentList.Distinct().ToList();

            var demoIntersect = Data.StudentList2.Intersect(Data.StudentList).ToList();

            //Give common also
            var demoUnion = Data.StudentList2.Union(Data.StudentList).ToList();

            Console.ReadLine();
        }
    }

    internal class EmployeeComparable : IEqualityComparer<Employee>
    {
        bool IEqualityComparer<Employee>.Equals(Employee? x, Employee? y)
        {
            if (x == null && y == null) return false;
            if (x == null || y == null) return false;

            if(object.ReferenceEquals(x, y)) return true;

            return x.ID.Equals(y.ID)
                && x.Name.Equals(y.Name)
                && x.DOB.Equals(y.DOB)
                && x.Company.Equals(y.Company)
                && x.Location.Equals(y.Location);
        }

        int IEqualityComparer<Employee>.GetHashCode(Employee obj)
        {
            int id = obj.ID.GetHashCode();
            int name = obj.Name.GetHashCode();
            int gender = obj.Gender.GetHashCode();
            int dob = obj.DOB.GetHashCode();
            int company = obj.Company.GetHashCode();
            int location = obj.Location.GetHashCode();

            return id ^ name ^ gender ^ dob ^ company ^ location;
        }
    }
}
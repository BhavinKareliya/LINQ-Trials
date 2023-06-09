namespace SetOperators.Models
{
    internal class Student : IEquatable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateOnly DOB { get; set; }

        public bool Equals(Student? other)
        {
            if (Object.ReferenceEquals(other, null)) return false;

            if (Object.ReferenceEquals(this, other)) return true;

            return other.ID == this.ID
                && other.Name == this.Name
                && other.Gender == this.Gender
                && other.DOB == this.DOB;
        }

        public override int GetHashCode()
        {
            int id = ID.GetHashCode();
            int name = Name.GetHashCode();
            int gender = Gender.GetHashCode();  
            int dob = DOB.GetHashCode();

            return id ^ name ^ gender ^ dob;
        }
    }
}

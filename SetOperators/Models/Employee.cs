namespace SetOperators.Models
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateOnly DOB { get; set; }
        public string Company { get; set; } = "SIMFORM";
        public string Location { get; set; } = "IND";
    }
}
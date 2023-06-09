namespace LINQ.Models
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public DateOnly DOB { get; set; }
        public int DeptId { get; set; }  
        public string Location { get; set; } = "IND";
    }
}
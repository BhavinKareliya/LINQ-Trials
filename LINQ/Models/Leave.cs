namespace LINQ.Models
{
    internal class Leave
    {
        public int ID { get; set; }
        public int EmpId { get; set; }
        public string Title { get; set; }
        public string Reason { get; set; }

        public DateOnly Date { get; set; }
    }
}

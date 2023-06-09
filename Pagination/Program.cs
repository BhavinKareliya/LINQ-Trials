namespace Pagination
{
    internal class Program
    {
        public readonly static List<int> NumbersList = new();
        static Program()
        {
            for (int i = 1; i < 10000; i++) NumbersList.Add(i);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter page number: ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter page size: ");
            int pageSize = Convert.ToInt32(Console.ReadLine());

            foreach (var data in NumbersList.Skip((pageNumber - 1) * pageSize).Take(pageSize).Select(a => a))
            {
                Console.WriteLine(data);
            }

            Console.ReadKey();
        }
    }
}
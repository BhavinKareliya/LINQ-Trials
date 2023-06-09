using LINQ.Models;

namespace LINQ
{
    sealed class MethodSyntax
    {
        public static void Main(string[] args)
        {
            #region Filtering
            //List Odd
            IEnumerable<int> evenNumbers = Data.NumbersList.Where(e => e % 2 == 0).ToList();
            List<Student> demoOfType = Data.MixedData.OfType<Student>().ToList();
            #endregion Filtering

            #region Projection
            //convert with index
            var data = Data.StudentList.Select(
                (stu, index) => new Employee()
                {
                    ID = index + 1,
                    Company = "Simform",
                    Gender = stu.Gender,
                    Name = stu.Name,
                }).ToList();

            //return list of char sequence  

            //If pass var which contains List of string it convert in single string list  
            var dataSelectMany = Data.StudentList.SelectMany((stu) => stu.Name).ToList();
            #endregion Projection

            #region Sorting
            var demoOrderBy = Data.NumbersList.OrderBy(a => a).ToList();
            var demoOrderByDescending = Data.NumbersList.OrderByDescending(a => a).ToList();
            var demoThenBy = Data.StudentList.OrderBy(a => a.Name).ThenBy(g => g.Gender).ToList();
            var demoThenByDecending = Data.StudentList.OrderBy(a => a.Name).ThenByDescending(g => g.Gender).ToList();
            var dataReverse = Data.StudentList.AsEnumerable().Reverse();
            #endregion Sorting

            #region Quantifiers (need to use MixedMode Only, returns booleans)
            var demoAll = Data.NumbersList.All(e => e % 2 == 0);
            var demoAny = Data.StudentList.Any(e => e.Gender == "Female");
            var demoContains = Data.StudentList.Contains(new Student());
            #endregion Quantifiers

            #region Join
            var demoJoin = Data.EmpList.Join(Data.DeptList,
                emp => emp.DeptId,
                dept => dept.ID,
                (empData, deptData) => new
                {
                    empData.ID,
                    empData.Name,
                    DepartmentName = deptData.Name,
                    empData.Gender
                });

            var demoMultipleJoin = Data.EmpList
                .Join(Data.DeptList,
                    emp => emp.DeptId,
                    dept => dept.ID,
                    (empData, deptData) => new
                    {
                        empData,
                        deptData
                    })
                .Join(Data.LeaveList,
                    empData => empData.empData.ID,
                    leave => leave.EmpId,
                    (empData, leave) => new
                    {
                        empData,
                        leave
                    })
                .Select(data => new {
                    data.empData.empData.ID,
                    data.empData.empData.Name,
                    DepartmentName = data.empData.deptData.Name,
                    data.leave.Title
                }).ToList();

            var demoGroupJoin = Data.DeptList.GroupJoin(Data.EmpList,
                              dept => dept.ID,
                              emp => emp.DeptId,
                              (dept, emp) => new
                              {
                                  dept,
                                  emp
                              });

            foreach(var content in demoGroupJoin)
            {
                Console.WriteLine(content.dept.Name + " " + content.emp.Count());
            }
            #endregion Join

            Console.ReadLine();

        }
    }
}

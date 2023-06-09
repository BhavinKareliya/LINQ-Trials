using LINQ.Models;

namespace LINQ
{
    internal class QuerySyntax
    {
        public static void Main(string[] args)
        {
            #region Filtering
            //List Even
            IEnumerable<int> demoWhere = (from obj in Data.NumbersList
                                          where obj % 2 == 0
                                          select obj
                                             ).ToList();

            var demoOfType = (from obj in Data.MixedData
                              where obj is Student
                              select obj
                              ).ToList();
            #endregion Filtering

            #region Projection
            var selectDemo = (from obj in Data.StudentList
                              select new Employee()
                              {
                                  ID = obj.ID,
                                  Name = obj.Name,
                              });

            var TdemoSelectMany = (from stu in Data.StudentList
                                   from stuChar in stu.Name
                                   select stuChar).ToList();
            #endregion Projection

            #region Sorting
            var demoOrderBy = (from obj in Data.NumbersList
                               orderby obj
                               select obj);
            var demoOrderByDescending = (from obj in Data.NumbersList
                                         orderby obj descending
                                         select obj);
            var demoThenBy = (from obj in Data.StudentList
                              orderby obj.Name, obj.Gender
                              select obj);
            var demoThenByDecending = (from obj in Data.StudentList
                                       orderby obj.Name, obj.Gender descending
                                       select obj);
            var dataReverse = (from obj in Data.StudentList
                               select obj).Reverse();
            #endregion Sorting

            #region Quantifiers (need to use MixedMode Only, returns booleans)
            var demoAll = (from obj in Data.NumbersList
                           select obj).All(e => e % 2 == 0);
            var demoAny = (from obj in Data.StudentList
                           select obj).Any(e => e.Gender == "Female");
            var demoContains = (from obj in Data.StudentList
                                select obj).Contains(new Student());
            #endregion Quantifiers

            #region Join
            var demoJoin = (from emp in Data.EmpList
                            join dept in Data.DeptList
                            on emp.ID equals dept.ID
                            select new
                            {
                                ID = emp.ID,
                                Name = emp.Name,
                                Department = dept.Name,
                                Gender = emp.Gender
                            }).ToList();

            var demoMultipleJoin = (from emp in Data.EmpList
                                    join dept in Data.DeptList
                                    on emp.ID equals dept.ID
                                    join leave in Data.LeaveList
                                    on emp.ID equals leave.EmpId
                                    select new
                                    {
                                        emp.ID,
                                        emp.Name,
                                        Department = dept.Name,
                                        emp.Gender,
                                        Leave = leave.ID,
                                        leave.Title
                                    }).ToList();

            var demoGroupJoin = (from dept in Data.DeptList
                                 join emp in Data.EmpList
                                 on dept.ID equals emp.DeptId into groupedData
                                 select new
                                 {
                                     dept,
                                     groupedData
                                 }).ToList();

            var demoLeftJoin = (from emp in Data.EmpList
                                join dept in Data.DeptList
                                on emp.DeptId equals dept.ID into empDepartment
                                from ed in empDepartment.DefaultIfEmpty()
                                select new
                                {
                                    EmployeeName = emp.Name,
                                    Department = ed != null ? ed.Name : "NA",
                                }).ToList();

            foreach (var content in demoGroupJoin)
            {
                Console.WriteLine(content.dept.Name + " " + content.groupedData.Count());
            }
            #endregion Join

            Console.ReadLine();
        }
    }
}
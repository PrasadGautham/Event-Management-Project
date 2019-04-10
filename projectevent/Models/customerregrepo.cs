using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectevent.Models
{
    public class customerregrepo
    {
        private static eventDBEntities context = new eventDBEntities();
        //public static List<Employee> GetAllEmployees()
        //{
        //    var res = from emp in dcontext.Employees
        //              select emp;
        //    return res.ToList();

        //}
        //public static Employee GetEmployee(int employeeId)
        //{
        //    var res1 = from emp in dcontext.Employees
        //               where emp.EmployeeID == employeeId
        //               select emp;
        //    return res1.SingleOrDefault();

        //}

        //public static List<Employee> GetAllEmployeeByname(string name)
        //{
        //    var res = from emp in dcontext.Employees
        //              where emp.EmployeeName.Contains(name)
        //              select emp;
        //    return res.ToList();

        //}
        public static bool Insertcustomer(customer Newcustomer)
        {

            context.customers.Add(Newcustomer);
            context.SaveChanges();
          
            return true;


        }

        //public static bool updateemployee(Employee emp)
        //{
        //    var query = from empl in dcontext.Employees
        //                where empl.EmployeeID == emp.EmployeeID
        //                select empl;
        //    if (query.Any())
        //    {
        //        var exemp = query.First();
        //        exemp.EmployeeName = emp.EmployeeName;
        //        exemp.Designation = emp.Designation;
        //        exemp.ContactNo = emp.ContactNo;
        //        exemp.EMailID = emp.EMailID;

        //        dcontext.SaveChanges();

        //        return true;
        //    }
        //    return false;
        //}
        //public static List<Employee> DeleteEmployee(int EmployeeId)
        //{
        //    var employee = GetEmployee(EmployeeId);
        //    if (employee != null)
        //    {
        //        dcontext.Employees.Remove(employee);
        //        dcontext.SaveChanges();

        //    }
        //    return GetAllEmployees();
        //}
    }
}
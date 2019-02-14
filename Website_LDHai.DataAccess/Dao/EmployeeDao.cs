using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using Website_LDHai.DataAccess.DataContext;

namespace Website_LDHai.DataAccess.Dao
{

    public class EmployeeDao : IActionDao<Employee>
    {
        /// <summary>
        /// Inserts the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public int Insert(Employee employee)
        {
            using (EmployeeManagementEntities db = new EmployeeManagementEntities())
            {
                try
                {
                    var employees = db.Employees;
                    employees.Add(employee);
                    return db.SaveChanges();
                }
                catch(Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return 0;
                }
            }
        }

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public int Update(Employee employee)
        {
            try
            {
                using (EmployeeManagementEntities db = new EmployeeManagementEntities())
                {
                    db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                    return db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return 0;
            }
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public int Delete(int id)
        {
            try
            {
                using (EmployeeManagementEntities db = new EmployeeManagementEntities())
                {
                    Employee employee = new Employee();
                    employee = db.Employees.SingleOrDefault(s => s.ID == id);
                    if (employee != null)
                    {
                        db.Employees.Remove(employee);
                    }
                    
                    return db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return 0;
            }
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Employee GetById(int id)
        {
            try
            {
                using (EmployeeManagementEntities db = new EmployeeManagementEntities())
                {
                    return db.Employees.FirstOrDefault(s => s.ID == id); ;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetList()
        {
            try
            {
                using (EmployeeManagementEntities db = new EmployeeManagementEntities())
                {
                    return db.Employees.ToList(); ;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        /// <summary>
        /// Filters the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public IEnumerable<Employee> Filter(Employee employee)
        {
            try
            {
                using (EmployeeManagementEntities db = new EmployeeManagementEntities())
                {
                    List<Employee> employees = new List<Employee>();
                    employees = db.Employees.Where(e => e.FullName.Contains(employee.FullName.Trim()))
                        .Where(e => e.Group.Contains(employee.Group.Trim())).Where(e => e.Account.Contains(employee.Account.Trim()))
                        .Where(e => e.StartDate >= employee.BirthDay && e.StartDate <= employee.StartDate).ToList();
                    return employees;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }
    }
}

using System.Collections.Generic;
using Website_LDHai.DataAccess.Dao;
using Website_LDHai.DataAccess.DataContext;

namespace Website_LDHai.BusinessFacade
{
    public class EmployeeFacade
    {
        private readonly EmployeeDao employeeDao = new EmployeeDao();

        /// <summary>
        /// Inserts the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public int Insert(Employee employee)
        {
            return employeeDao.Insert(employee);
        }

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public int Update(Employee employee)
        {
            return employeeDao.Update(employee);
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public int Delete(int id)
        {
            return employeeDao.Delete(id);
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Employee GetById(int id)
        {
            return employeeDao.GetById(id);
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetList()
        {
            return employeeDao.GetList();
        }

        /// <summary>
        /// Filters the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public IEnumerable<Employee> Filter(Employee employee)
        {
            if (employee.FullName == null)
            {
                employee.FullName = "";
            }
            if (employee.Account == null)
            {
                employee.Account = "";
            }
            if (employee.Group == null)
            {
                employee.Group = "";
            }
            return employeeDao.Filter(employee);
        }


    }
}

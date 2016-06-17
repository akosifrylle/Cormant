using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cormant.NHibernate.Dao;

namespace Cormant.Services
{
    public class EmployeeService
    {
        private readonly EmployeeDao _employeeDao;

        public EmployeeService()
        {
            _employeeDao = new EmployeeDao();
        }
        public Employee GetEmployee(int id)
        {
            return _employeeDao.GetById(id);
        }

        public IList<Employee> GetEmployees()
        {
            return _employeeDao.GetList();
        }

        public void AddEmployee(Employee employee)
        {
            _employeeDao.Save(employee);
        }
    }
}

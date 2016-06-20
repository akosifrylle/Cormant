using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cormant.NHibernate.Dao;
using Microsoft.SqlServer.Server;

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

        public Employee Login(string email, string password)
        {
            return _employeeDao.GetByEmailAndPassword(email, password);
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

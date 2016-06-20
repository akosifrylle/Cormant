using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cormant.NHibernate.Repo;

namespace Cormant.NHibernate.Dao
{
    public class EmployeeDao
    {
        public IList<Employee> GetList()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var employees = session.QueryOver<EmployeeRepo>().List();

                return Mapper.Map<IList<Employee>>(employees);
            }
        }

        public Employee GetById(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return Mapper.Map<Employee>(session.Get<EmployeeRepo>(id));
            }
        }

        public Employee GetByEmailAndPassword(string email, string password)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return Mapper.Map<Employee>(session.QueryOver<EmployeeRepo>()
                    .Where(e => e.Email == email && e.Password == password).SingleOrDefault());
            }
        }

        public void Save(Employee employee)
        {
            if (employee != null)
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    session.BeginTransaction();
                    session.Save(employee);
                    session.Transaction.Commit();
                }
            }
        }
    }
}

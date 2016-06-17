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

        public void Save(Employee employee)
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

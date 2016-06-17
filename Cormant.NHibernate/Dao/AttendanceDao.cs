using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cormant.NHibernate.Repo;

namespace Cormant.NHibernate.Dao
{
    public class AttendanceDao
    {
        public Attendance GetByEmployeeIdAndDate(int id, DateTime date)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return Mapper.Map<Attendance>(
                    session.QueryOver<AttendanceRepo>()
                    .Where(a => a.Employee.Id == id
                                && a.Date == date.Date).List().SingleOrDefault());
            }
        }

        public IList<Attendance> GetByDate(DateTime date)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return Mapper.Map<IList<Attendance>>(session.QueryOver<AttendanceRepo>()
                    .Where(a => a.Date == date).List());
            }
        } 

    }
}

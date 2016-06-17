using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cormant.NHibernate.Dao;

namespace Cormant.Services
{
    public class AttendanceService
    {
        private readonly AttendanceDao _attendanceDao;

        public AttendanceService()
        {
            _attendanceDao = new AttendanceDao();
        }

        public void AddAttendance(Employee employee, DateTime date)
        {
            
        }

        public Attendance GetAttendance(int employeeId, DateTime date)
        {
            return _attendanceDao.GetByEmployeeIdAndDate(employeeId, date);
        }

        public IList<Attendance> GetAttendanceByDate(DateTime date)
        {
            return _attendanceDao.GetByDate(date);
        }
    }
}

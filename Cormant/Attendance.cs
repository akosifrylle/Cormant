using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cormant
{
    public class Attendance
    {
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public AttendanceStatus Status { get; set; }
         
    }

    public enum AttendanceStatus
    {
        Nil = 0,
        OnDuty = 1,
        OnSickLeave = 2,
        OnEmergencyLeave = 3
    }
}

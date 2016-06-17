using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cormant.NHibernate.Repo
{
    public class AttendanceRepo
    {
        public virtual Employee Employee { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual AttendanceStatus Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cormant.NHibernate.Repo
{
    public class EmployeeRepo
    {
        public virtual int id { get; set; }
        public virtual string Email { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Password { get; set; }
        public virtual string Department { get; set; }
    }
}

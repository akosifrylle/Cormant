using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cormant.NHibernate.Repo;
using FluentNHibernate.Mapping;

namespace Cormant.NHibernate.Mappings
{
    public class EmployeeMap : ClassMap<EmployeeRepo>
    {
        public EmployeeMap()
        {
            Table("Employee");
            Id(x => x.id)
                .GeneratedBy.Identity();
            Map(x => x.Firstname)
                .Length(20).Not.Nullable();
            Map(x => x.Lastname)
                .Length(20).Not.Nullable();
            Map(x => x.Department)
                .Length(30).Not.Nullable();
            Map(x => x.Email)
                .Length(50).Not.Nullable();
            Map(x => x.Password)
                .Length(20).Not.Nullable();
        }
    }
}

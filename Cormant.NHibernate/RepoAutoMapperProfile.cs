using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cormant.NHibernate.Repo;

namespace Cormant.NHibernate
{
    public class RepoAutoMapperProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Employee, EmployeeRepo>();
            Mapper.CreateMap<EmployeeRepo, Employee>();
            Mapper.CreateMap<Attendance, AttendanceRepo>();
        }
    }
}

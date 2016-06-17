using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Cormant.NHibernate
{
    public static class AutoMapperConfig
    {
        public static void Initilize()
        {
            Mapper.Initialize(config =>
            {
                config.AddProfile<RepoAutoMapperProfile>();
            });
        }
    }
}

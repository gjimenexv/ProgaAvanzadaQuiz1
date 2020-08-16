using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data = Solution.DAL.EF;
using ent = Solution.DO.Objects;

namespace Solution.Maps
{
    public class Maps
    {
        public static void CreateMaps()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ent.GroupGoals, data.GroupGoals>();
                cfg.CreateMap<data.GroupGoals, ent.GroupGoals>();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data = Solution.DAL.EF;
using ent = Solution.DO.Objects;
using Solution.DO.Interfaces;
using Solution.DAL;
using Solution.Maps;
using System.Linq.Expressions;
using AutoMapper;

namespace Solution.BS
{
    public class GroupGoals : ICRUD<ent.GroupGoals>
    {
        private DAL.GroupGoals _dal = new DAL.GroupGoals();
        public void Delete(ent.GroupGoals t)
        {
            var _ent = Mapper.Map<ent.GroupGoals, data.GroupGoals>(t);
            _dal.Delete(_ent);
        }

        public IEnumerable<ent.GroupGoals> GetAll()
        {
            var t = _dal.GetAll();
            var _ent = Mapper.Map<IEnumerable<data.GroupGoals>, IEnumerable<ent.GroupGoals>>(t);
            return _ent;
        }

        public ent.GroupGoals GetOneById(int id)
        {
            var t = _dal.GetOneById(id);
            var _ent = Mapper.Map<data.GroupGoals, ent.GroupGoals>(t);
            return _ent;
        }

        public void Insert(ent.GroupGoals t)
        {
            var _ent = Mapper.Map<ent.GroupGoals, data.GroupGoals>(t);
            _dal.Insert(_ent);
        }

        public IEnumerable<ent.GroupGoals> SearchByName(string Name)
        {
            var t = _dal.SearchByName(Name);
            var _ent = Mapper.Map<IEnumerable<data.GroupGoals>, IEnumerable<ent.GroupGoals>>(t);
            return _ent;
        }

        public IEnumerable<ent.GroupGoals> Search(Expression<Func<ent.GroupGoals, bool>> predicado)
        {
            return null;
        }

        public void Updated(ent.GroupGoals t)
        {
            var _ent = Mapper.Map<ent.GroupGoals, data.GroupGoals>(t);
            _dal.Updated(_ent);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data = Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DAL.EF;
using System.Linq.Expressions;
using Solution.DO.Interfaces;

namespace Solution.DAL
{
    public class GroupGoals : ICRUD<data.GroupGoals>
    {
        private Repository<data.GroupGoals> _repository = new Repository<data.GroupGoals>(new SocialGoalEntities());
        public void Delete(data.GroupGoals t)
        {
            try
            {
                //t.PhotoPath = true.ToString();
                //_repository.Updated(t);

                _repository.Delete(t.GroupGoalId);
                _repository.Commit();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public IEnumerable<data.GroupGoals> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public data.GroupGoals GetOneById(int id)
        {
            try
            {
                return _repository.GetOneByID(id);
            }
            catch (Exception ee)
            {
                throw;
            };
        }

        public void Insert(data.GroupGoals t)
        {
            try
            {
                _repository.Insert(t);
                _repository.Commit();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public IEnumerable<data.GroupGoals> SearchByName(string Name)
        {
            try
            {
                return _repository.Search(p => p.GoalName.Contains(Name));
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public IEnumerable<data.GroupGoals> Search(Expression<Func<data.GroupGoals, bool>> predicado)
        {
            try
            {
                return _repository.Search(predicado);
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void Updated(data.GroupGoals t)
        {
            try
            {
                _repository.Updated(t);
                _repository.Commit();
            }
            catch (Exception ee)
            {
                throw;
            }
        }
    }
}

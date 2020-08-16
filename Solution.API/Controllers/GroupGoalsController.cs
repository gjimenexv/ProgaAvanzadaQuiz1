using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Solution.DO.Objects;

namespace Solution.API.Controllers
{
    [Route("api/GroupGoals")]
    public class GroupGoalsController : ApiController
    {
        private BS.GroupGoals bs = new BS.GroupGoals();
        // GET: api/GroupGoals
        [Route("api/GroupGoals/GetGroupGoals/")]
        [HttpGet]
        public IQueryable<GroupGoals> GetGroupGoals()
        {
            //return db.GroupGoals;
            return bs.GetAll().AsQueryable();
        }

        [Route("api/GroupGoals/GetGroupGoals/5")]
        [HttpGet]
        // GET: api/GroupGoals/5
        [ResponseType(typeof(GroupGoals))]
        public async Task<IHttpActionResult> GetGroupGoals(int id)
        {
            GroupGoals groupGoals = bs.GetOneById(id);
            if (groupGoals == null)
            {
                return NotFound();
            }

            return Ok(groupGoals);
        }

        // PUT: api/GroupGoals/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGroupGoals(int id, GroupGoals groupGoals)
        {


            if (id != groupGoals.GroupGoalId)
            {
                return BadRequest();
            }
   
            // Llamar Update de BS 
            try
            {
                bs.Updated(groupGoals);

            }
            catch (Exception ee)
            {
                if (!GroupGoalsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/GroupGoals
        [ResponseType(typeof(GroupGoals))]
        public async Task<IHttpActionResult> PostGroupGoals(GroupGoals groupGoals)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // LLamar BS hacer insert 
            bs.Insert(groupGoals);
            GroupGoals newGoal = bs.SearchByName(groupGoals.GoalName).LastOrDefault();
            return CreatedAtRoute("DefaultApi", new { id = newGoal.GroupGoalId }, newGoal);
        }

        // DELETE: api/GroupGoals/5
        [ResponseType(typeof(GroupGoals))]
        public async Task<IHttpActionResult> DeleteGroupGoals(int id)
        {
            GroupGoals groupGoals = bs.GetOneById(id);
            if (groupGoals == null)
            {
                return NotFound();
            }
            bs.Delete(groupGoals);

            return Ok(groupGoals);
        }

        private bool GroupGoalsExists(int id)
        {
            return bs.GetOneById(id) != null ? true : false;
        }
    }
}

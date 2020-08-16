using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DO.Objects
{
    public partial class GroupGoals
    {
        public int GroupGoalId { get; set; }
        public string GoalName { get; set; }
        public string Description { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<double> Target { get; set; }
        public Nullable<int> MetricId { get; set; }
        public Nullable<int> FocusId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int GoalStatusId { get; set; }
        public int GroupUserId { get; set; }
        public Nullable<int> AssignedGroupUserId { get; set; }
        public string AssignedTo { get; set; }
        public int GroupId { get; set; }

    }
}

using System;
using System.Collections.Generic;

namespace ActivityPlanningTool.Models
{
    public class Session
    {
        public int Id { get; set; }
        public TimeSpan FromTime { get; set; }
        public TimeSpan ToTime { get; set; }
        public List<User> Users { get; set; }
    }
}
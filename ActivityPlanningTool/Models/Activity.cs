using System;
using System.Collections.Generic;

namespace ActivityPlanningTool.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public List<Session> Sessions { get; set; }
    }
}
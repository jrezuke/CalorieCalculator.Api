using System;
using System.Collections.Generic;

namespace CalorieCalculator.Api.Models
{
    public partial class Subject
    {
        public Subject()
        {
            CalEntry = new HashSet<CalEntry>();
        }

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public int SiteId { get; set; }
        public string SubjectId { get; set; }

        public virtual ICollection<CalEntry> CalEntry { get; set; }
        public virtual Site Site { get; set; }
    }
}

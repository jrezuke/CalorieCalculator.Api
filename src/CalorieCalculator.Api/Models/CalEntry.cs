using System;
using System.Collections.Generic;

namespace CalorieCalculator.Api.Models
{
    public partial class CalEntry
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public decimal Weight { get; set; }
        public decimal Hours { get; set; }
        public DateTime EntryDate { get; set; }

        public virtual Subject Subject { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CalorieCalculator.Api.Models
{
    public partial class Site
    {
        public Site()
        {
            Subject = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string LongName { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<Subject> Subject { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CalorieCalculator.Api.Models
{
    public partial class FluidInfusion
    {
        public int Id { get; set; }
        public int DextroseConcentrationId { get; set; }
        public int Volume { get; set; }

        public virtual DextroseConcentration DextroseConcentration { get; set; }
    }
}

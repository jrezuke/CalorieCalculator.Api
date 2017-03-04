using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalorieCalculator.Api.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CalorieCalculator.Api.Controllers
{
    [Route("api/[controller]")]
    public class DextroseConcentrationsController : Controller
    {
        private CalCalcContext _dbContext;

        public DextroseConcentrationsController(CalCalcContext context)
        {
            _dbContext = context;
        }
        // GET: /<controller>/
        public IEnumerable<DextroseConcentration> Get()
        {
            return _dbContext.DextroseConcentrations.ToList();
        }
    }
}

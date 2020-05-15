using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pogoda.DomainObjects;

namespace Pogoda.Controllers
{
    [ApiController]
    [Pogoda("[controller]")]
    public class PogodaController : ControllerBase
    {
        private readonly ILogger<PogodaController> _logger;

        public PogodaController(ILogger<PogodaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Pogoda> GetPogoda()
        {
            return new List<Pogoda>() 
            { 
                new Pogoda() 
                { 
                    Id = 1,
                    Min = "0",
                    Max = "2",
                    PogodaType = PogodaType.Hour3,
                    Prognoz = new Prognoz()
                    {
                        Id = 1,
                        Nachalo = "01.01.2018 09:00:00",
                        Konec = "01.01.2018 12:00:00",
                        Vipusk = "01.01.2018 06:29:00"
                    }
                } 
            };
        }
    }
}

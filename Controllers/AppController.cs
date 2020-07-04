using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using app.Services;
using app.Models;
using app.DTO;

namespace app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppController : ControllerBase
    {
        private readonly ILogger<AppController> _logger;
        private readonly IConfiguration _configuration;

        private readonly IDbService _dbService;

        public AppController(ILogger<AppController> logger, IConfiguration configuration, IDbService dbService)
        {
            _logger = logger;
            _configuration = configuration;
            _dbService = dbService;
        }

        [HttpGet]
        public IEnumerable<Item> Get()
        {
            _logger.LogInformation("Get");

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Item
            {
                Timestamp = DateTime.Now.AddDays(index)
            })
            .ToArray();
        }

        [HttpPost]
        public async Task<IActionResult> Post() 
        {
             //Request request
            //_logger.LogInformation("Post with request: {0}", request.Timestamp);

            _logger.LogInformation("Post");

            var item = new Item() {
                Id = Guid.NewGuid().ToString(),
                Timestamp = DateTime.UtcNow
            };

            await _dbService.AddItemAsync(item);

            return Ok(item);
        }
    }
}

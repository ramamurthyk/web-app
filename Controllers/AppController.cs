using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using app.Services;
using app.Models;

namespace app.Controllers
{
    /// <summary>
    /// API Controller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class AppController : ControllerBase
    {
        // Logger injected by the DI service.
        private readonly ILogger<AppController> _logger;

        // DB service instance injectedby the DI service.
        private readonly IDbService _dbService;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="logger">Instane of logger.</param>
        /// <param name="dbService">Instance of the DB service.</param>
        public AppController(ILogger<AppController> logger, IDbService dbService)
        {
            _logger = logger;
            _dbService = dbService;
        }

        /// <summary>
        /// REST API endpoint to Post timestamp to a database. When called, it generates a new timestamp and inserts into the Database.
        /// </summary>
        /// <returns>HTTP Response.</returns>
        [HttpPost]
        public async Task<IActionResult> Post() 
        {
            _logger.LogInformation("Post method called.");

            // Create a new item.
            var item = new Item() {
                Id = Guid.NewGuid().ToString(),
                Timestamp = DateTime.UtcNow
            };

            // Add item to the database.
            await _dbService.AddItemAsync(item);

            // Return OK response.
            return Ok(item);
        }
    }
}

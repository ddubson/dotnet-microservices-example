using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quark.Common.Commands;
using RawRabbit;

namespace Quark.API.Controllers
{
    [Route("[controller]")]
    public class ActivitiesController: Controller
    {
        private readonly IBusClient _busClient;

        public ActivitiesController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateActivity command)
        {
            command.Id = Guid.NewGuid();
            command.CreatedAt = DateTime.UtcNow;
            await _busClient.PublishAsync(command);

            return Accepted($"activities/{command.Id}");
        }
    }
}
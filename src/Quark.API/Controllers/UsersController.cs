using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quark.Common.Commands;
using RawRabbit;

namespace Quark.API.Controllers
{
    [Route("[controller]")]
    public class UsersController: Controller
    {
        private readonly IBusClient _busClient;

        public UsersController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Post([FromBody] CreateUser createUser)
        {
            await _busClient.PublishAsync(createUser);

            return Accepted();
        }
    }
}
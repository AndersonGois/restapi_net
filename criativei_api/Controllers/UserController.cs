using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using criativei_server.Model;
using AutoMapper;
using criativei_server.Mappings;

namespace criativei_server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        private UserService service;


        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] UserRequest userRequest)
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile <UserProfile>());
            var mapper = config.CreateMapper();
            UserEntity user = mapper.Map<UserEntity>(userRequest);

            await service.CreateUserAsync(user);

            return Ok(user);
        }

        // Este é um método GET de exemplo para recuperar um usuário pelo ID.
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(string id)
        {
            // Aqui você pode adicionar a lógica para recuperar o usuário do banco de dados.
            // Por exemplo:
             //var user = _database.GetUser(id);

            // Se o usuário não for encontrado, retorne um status 404 (Not Found).
            // if (user == null)
            // {
            //     return NotFound();
            // }

            // Se o usuário for encontrado, retorne o usuário.
             return Ok();
        }
    }
}

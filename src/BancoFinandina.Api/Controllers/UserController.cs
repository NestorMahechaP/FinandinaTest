using BancoFinandina.Service.Queries.DTOs;
using BancoFinandina.Service.Queries.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BancoFinandina.Api.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class UserController : ControllerBase
    {
        private readonly IBancoFinandinaQueryService _bancoFinandinaService;

        public UserController(IBancoFinandinaQueryService bancoFinandinaService)
        {
            _bancoFinandinaService = bancoFinandinaService;
        }

        [HttpGet]
        public async Task<List<UserDto>> GetAll()
        {
            var products = await _bancoFinandinaService.GetUsersAsync();
            return products.ToList();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserDto user)
        {
            _bancoFinandinaService.AddUser(user);
            if (!await _bancoFinandinaService.SaveAll())
            {
                return BadRequest("Could not create the new user.");
            }
            return Created(string.Empty, user);
        }
    }
}
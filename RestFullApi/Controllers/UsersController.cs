using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.DomainEntities.Models;
using OA.Services.ServiceInterface;

namespace RestFullApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IService<Users> _service;
        public UsersController
            (
            IUserService userService,
            IService<Users> service
            )
        {
            _userService = userService;
            _service = service;
        }
        [Route("getUserById")]
        [HttpGet]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _service.GetById(id.ToString());
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return BadRequest(user);
            }
        }

        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> Create(Users user)
        {
            var result = await _service.Create(user);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [Route("update")]
        [HttpPut]
        public IActionResult Update(Users user)
        {
            var result =  _service.Update(user);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        //[Route("delete")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForever(string id)
        {
            var result = await _service.Delete(id);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}

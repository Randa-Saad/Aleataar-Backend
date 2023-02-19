using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesOrderAPI.Models;
using System;

namespace SalesOrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly Sales_DBContext _authContext;
        public UserController(Sales_DBContext appDbContext)
        {
            _authContext = appDbContext;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] TblUser userObj)
        {
            if (userObj == null)
            {
                return BadRequest();
            }
            var user = await _authContext.TblUsers.FirstOrDefaultAsync(x => x.Name == userObj.Name && x.Password == userObj.Password);
            if (user == null)
            {
                return NotFound(new { Message = "User Not Found!" });
            }

            return Ok(new { Message = "Login Success!" });
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] TblUser userObj)
        {
            if (userObj == null)
            {
                return BadRequest();
            }
            await _authContext.TblUsers.AddAsync(userObj);
            await _authContext.SaveChangesAsync();
            return Ok(new { Message = "Register Success!" });
        }
    }
}

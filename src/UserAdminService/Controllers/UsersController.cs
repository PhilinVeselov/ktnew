using Microsoft.AspNetCore.Mvc;

namespace UserAdminService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// </summary>
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(new { Message = "Список пользователей" });
        }

        /// <summary>
        /// </summary>
        [HttpPost]
        public IActionResult CreateUser([FromBody] UserDto user)
        {
            return Ok(new { Message = "Пользователь создан" });
        }

        /// <summary>
        /// </summary>
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] UserDto user)
        {
            return Ok(new { Message = "Пользователь обновлен" });
        }

        /// <summary>
        /// </summary>
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            return Ok(new { Message = "Пользователь удален" });
        }
    }

    public class UserDto
    {
public string Name { get; set; } = string.Empty;
public string Email { get; set; } = string.Empty;

    }
}

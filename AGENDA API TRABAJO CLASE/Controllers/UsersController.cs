using AgendaApi.Models.DTOs.Requests;
using AgendaApi.Models.DTOs.Responses;
using Microsoft.AspNetCore.Mvc;

namespace AGENDA_API_TRABAJO_CLASE.Controllers
{
    public class UsersController : ControllerBase
    {

        [HttpGet]
        public ActionResult<UserDto> GetAll()

        [HttpGet("{id}")]
        public IActionResult GetOneById(int id)

        [HttpPut("{userId}")]
        public IActionResult UpdateUser(CreateAndUpdateUserDto dto, int userId)
        
        [HttpDelete]
        public IActionResult DeleteUser(int id)

    }
}

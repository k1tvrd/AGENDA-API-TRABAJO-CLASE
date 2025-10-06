using AgendaApi.Models.DTOs.Requests;
using AgendaApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AGENDA_API_TRABAJO_CLASE.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;

    [HttpGet]
    public IActionResult GetAll()
    {
        var contacts = _userService.GetAll();

        return Ok(contacts);
    }

    [HttpGet("{id}")]
    public IActionResult GetOneById(int id)
    {
        var user = _userService.GetById(id);
        if (user == null)
        {
            return NotFound($"Usuario con ID {id} no fue encontrado.");
        } return Ok(user);
    }

    [HttpPut("{userId}")]
    public IActionResult UpdateUser(CreateAndUpdateUserDto dto, int userId)
    {
        _userService.Update(dto, userId);
        return Ok();

    }

    [HttpDelete]
    public IActionResult DeleteUser(int id)
    {
        _userService.RemoveUser(id);    
        return Ok();
    }

}

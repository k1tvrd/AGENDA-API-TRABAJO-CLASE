
using AgendaApi.Models.DTOs.Requests;
using AgendaApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AGENDA_API_TRABAJO_CLASE.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService; //inyeccion interfaz
        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult GetAll(int userId)
        {
            var contacts = _contactService.GetAllByUser(userId);
            if (contacts == null || !contacts.Any())
            {
                return NotFound($"No fueron encontrados contactos para el usuario con ID {userId}.");
            } 
            return Ok(contacts);
        }

         [HttpGet("{contactId}")]
        public IActionResult GetOne(int userId, int contactId)
        {
            var contact = _contactService.GetOneByUserId(userId, contactId); //cambiar 1 por userId logueado
            if (contact == null)
            {
                return NotFound($"Contacto con ID {contactId} no fue encontrado.");
            }
            return Ok(contact);
        }

         [HttpPost]
        public IActionResult CreateContact(CreateAndUpdateContactDto createContactDto, int UserId)
        {
            var newContact = _contactService.Create(createContactDto, UserId);
            if (newContact == null)
            {
                return BadRequest("No se pudo crear el contacto.");
            } return Ok(newContact);
        }

        [HttpPut]
        [Route("{contactId}")]
        public IActionResult UpdateContact(CreateAndUpdateContactDto dto, int contactId)
        {
            _contactService.Update(dto, contactId);
            return Ok();
        }

        [HttpDelete] 
        [Route("{contactId}")]
        public IActionResult DeleteContact(int contactId)
        {
            _contactService.Delete(contactId);
            return NoContent();
        }


    }
}

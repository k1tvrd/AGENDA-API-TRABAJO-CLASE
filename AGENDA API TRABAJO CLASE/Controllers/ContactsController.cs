
using AgendaApi.Models.DTOs.Requests;
using Microsoft.AspNetCore.Mvc;

namespace AGENDA_API_TRABAJO_CLASE.Controllers
{
    public class ContactsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()

         [HttpGet("{contactId}")]
        public IActionResult GetOne(int contactId)

         [HttpPost]
        public IActionResult CreateContact(CreateAndUpdateContactDto createContactDto)

        [HttpPut]
        [Route("{contactId}")]
        public IActionResult UpdateContact(CreateAndUpdateContactDto dto, int contactId)

        [HttpDelete] 
        [Route("{contactId}")]


    }
}

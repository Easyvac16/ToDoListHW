using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestApi.Abstract;
using TestApi.Core.Abstract;
using TestApi.Core.DTOs;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoListController : ControllerBase
    {
        private readonly IMyService _service;

        public ToDoListController(IMyService service)
        {
            _service = service;
        }

        [HttpPost(Name = "PostToDoList")]
        public IActionResult Post(ToDoListDTO toDoListDTO)
        { 
            _service.AddToDo(toDoListDTO);

            return Ok("ss");
        }

        [HttpGet(Name = "GetToDoList")]
        public IActionResult Get()
        {

            var result = _service.GetAllList();  

            return Ok(result);

        }

    }
}

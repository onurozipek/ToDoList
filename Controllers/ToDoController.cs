
using Microsoft.AspNetCore.Mvc;
using ToDoList.Data;
using ToDoList.Model;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ToDoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllToDo()
        {
            var toDo = _context.ToDoList.ToList();
            return Ok(toDo);
        }
        
        [HttpPost]
        public IActionResult AddToDo(ToDo toDo)
        {
            _context.ToDoList.Add(toDo);
            _context.SaveChanges();
            return Ok();
        }
        
        [HttpPut]
        public IActionResult UpdateToDo(ToDo toDo)
        {
            _context.ToDoList.Update(toDo);
            _context.SaveChanges();
            return Ok();
        }
        
        [HttpDelete]
        public IActionResult DeleteToDo(int id)
        {
            var deleteToDo = _context.ToDoList.Find(id);
            _context.ToDoList.Remove(deleteToDo);
            _context.SaveChanges();
            return Ok();
        }
    }
}

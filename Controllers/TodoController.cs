using Microsoft.AspNetCore.Mvc;
using TodoApplication.Models;
using TodoApplication.Repositories;

namespace TodoApplication.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository TodoRepository;
        public TodoController(ITodoRepository TodoRepository)
        {
            this.TodoRepository = TodoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTodos()
        {
            return Ok(await this.TodoRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllTodos(int id)
        {
            return Ok(await this.TodoRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddTodo([FromBody] Todos todo)
        {
            var entity = await this.TodoRepository.Add(todo);
            return Created(nameof(todo), entity);
        }
         
        [HttpPut]
        public async Task<IActionResult> UpdateTodo([FromBody] Todos todo)
        {
            await this.TodoRepository.Update(todo);
            return NoContent();
        }
        
        [HttpDelete]
        public async Task<IActionResult> RemoveTodo([FromBody] Todos todo)
        {
            await this.TodoRepository.Remove(todo);
            return NoContent();
        }
    }
}

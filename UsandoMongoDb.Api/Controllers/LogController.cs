using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsandoMongoDb.Api.Model;
using UsandoMongoDb.Api.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UsandoMongoDb.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogController : ControllerBase
    {

        private readonly BookService _bookService;

        public LogController(BookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/<LogController>
        [HttpPost("gravar")]
        public IActionResult Gravar(Book book)
        {
            _bookService.Create(book);

            //return CreatedAtRoute("GetBook", new { id = book.Id.ToString() }, book);
            return Ok();
        }

        // GET api/<LogController>/5
        [HttpGet("obter-log/{id:length(24)}")]
        public ActionResult<Book> ObterLogPorId(string id)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        
        [HttpGet("obter-todos-log")]
        public IActionResult ObterTodosLog()
        {
            return Ok();
        }

        [HttpDelete("remover/{id:length(24)}")]
        public IActionResult RemoverLog(string id)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _bookService.Remove(book.Id);

            return NoContent();
        }

    }
}

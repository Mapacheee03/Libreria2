using Libreria2.Data.Service;
using Libreria2.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Libreria2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class AuthorsController : Controller
    {
        private AuthorsService _authorsServices;
        public AuthorsController(AuthorsService authorsServices)
        {
            _authorsServices = authorsServices;
        }
        [HttpPost("Add-author")]
        public IActionResult AddBook([FromBody] AuthorVM author)
        {
            _authorsServices.AddAuthor(author);
            return Ok();
        }

        [HttpGet("get-author-with-books-by-id/{id}")]
        public IActionResult GetAuthorWithBooks(int id)
        {
            var response = _authorsServices.GetAuthorWithBooksVM(id);
            return Ok(response);
        }


    }
}
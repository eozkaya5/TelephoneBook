using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//ATTRIBUTE
    public class BookController : Controller
    {

        IBookService _bookService;
        public BookController(IBookService bookService)
      {
            _bookService = bookService;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            // Dependency chain
            //Eğer istek başarılı ise veriyi listelettir değilse hata mesajı göster
            var result = _bookService.Get();
            if (result.Success)
            {
                return Ok(result);//Data
            }
            return BadRequest(result);// Messages
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            //Eğer istek başarılı ise veriyi listelettir değilse hata mesajı göster
            var result = _bookService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Book book)
        {
            //Eğer istek başarılı ise veriyi kaydet değilse hata mesajı göster

            var result = _bookService.Add(book);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

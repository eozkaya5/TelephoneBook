using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
   
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
            var result = _bookService.Get();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _bookService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}
       
        //public IActionResult GetAll(int id)
        //{
        //    var result = _bookService.GetAll(id);
          
        //    return View(result);

        //}
    
    }
}

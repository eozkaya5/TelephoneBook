
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Models.Authentication;
using WebAPI.Models.Context;

namespace WebAPI.Controllers
{
	[Authorize]
	public class TelephoneBook : Controller
	{

		private readonly BookDbContext _context;
		private readonly UserManager<AppUser> _userManager;

		public TelephoneBook(BookDbContext context, UserManager<AppUser> userManager)
		{
			_context = context;
			_userManager = userManager;

		}
		public IActionResult Index(int id)
		{
			ViewBag.UserName = User.Identity.Name;
			var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
			var book = _context.Books.Where(x => x.UserId == user.Id);
			return View(book);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Book book)
		{
			try
			{
				var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
				book.UserId = user.Id;
				_context.Books.Add(book);
				_context.SaveChanges();
				return RedirectToAction("Index", "TelephoneBook");
			}
			catch (Exception)
			{
				return View(book);
			}
		}

		public IActionResult Delete(int? id)
		{
			try
			{
				var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
				var delete = _context.Books.FirstOrDefault(x => x.Id == id);
				delete.UserId = user.Id;
				_context.Books.Remove(delete);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				TempData["Message"] = "Ödenmesi gereken borç bulunmaktadır. Ödeme işlemi yapıldıktan sonra tekrar deneyiniz.";
			}
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			var model = _context.Books.FirstOrDefault(x => x.Id == id);
			return View(model);
		}
		[HttpPost]
		public IActionResult Edit(Book book, int id)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var model = _context.Books.FirstOrDefault(x => x.Id == id);
					model.Name = book.Name;
					model.SurName = book.SurName;
					model.TelephoneNumber = book.TelephoneNumber;

					_context.SaveChanges();
					return RedirectToAction("Index", new { id = model.UserId });
				}
			}
			catch (Exception)
			{

				throw;
			}
			return View(book);
		}
	}
}



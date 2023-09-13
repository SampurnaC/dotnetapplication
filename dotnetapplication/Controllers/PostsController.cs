using dotnetapplication.Models;
using dotnetapplication.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using System;

namespace dotnetapplication.Controllers
{
    public class PostsController : Controller
    {
        private readonly DatabaseContext _ctx;
        public PostsController(DatabaseContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPost(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                _ctx.Post.Add(post);
                _ctx.SaveChanges();
                TempData["msg"] = "Added successfully";
                return RedirectToAction("AddPost");  

            }
            catch (Exception ex)
            {
                TempData["msg"] = "Could not added!!!";
                return View();
            }

        }
    }
}

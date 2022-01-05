using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    //[Route("blog")]
    public class BlogController : Controller
    {
        private readonly BlogDataContext _db;
        private readonly UserManager<IdentityUser> userManager;

        public BlogController(BlogDataContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            this.userManager = userManager;
        }
        //[Route("")]
        public IActionResult Index(int page = 0)
        {
            var pageSize = 2;
            var totalPosts = _db.Posts.Count();
            var totalPages = totalPosts / pageSize;
            var previousPage = page - 1;
            var nextPage = page + 1;

            ViewBag.PreviousPage = previousPage;
            ViewBag.HasPreviousPage = previousPage >= 0;
            ViewBag.NextPage = nextPage;
            ViewBag.HasNextPage = nextPage < totalPages;

            var posts =
                _db.Posts
                    .OrderByDescending(x => x.Posted)
                    .Skip(pageSize * page)
                    .Take(pageSize)
                    .ToArray();

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView(posts);
            
            return View(posts);
        }
        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = _db.Posts.FirstOrDefault(x => x.Key == key);
            //var post = new Post
            //{
            //    Title = "My blog post",
            //    Author = "T Willenbring",
            //    Posted = DateTime.Now,
            //    Body = "Great blog post right?"
            //};
            
            return View(post);
        }

        //[HttpGet, Route("create")]
        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
        //[HttpPost, Route("create")]
        [HttpPost]
        [Authorize]
        public IActionResult Create(Post post)
        {
            if (!ModelState.IsValid)
                return View();
            
            //post.Author = User.Identity.Name;
            //post.Author = user.Email;
            post.Posted = DateTime.Now;

            _db.Add(post);
            _db.SaveChanges();
            return RedirectToAction("Post", "Blog", new
            {
                year = post.Posted.Year,
                month = post.Posted.Month,
                key = post.Key
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lab6_v2.Data;
using lab6_v2.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace lab6_v2.Controllers
{
    

    public class ImagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ImagesController(ApplicationDbContext context)
        {
            _context = context;
        }



        // GET: Images/Create
        public IActionResult Create([FromRoute] int topicId)
        {
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("PostId,Img")] Image image, IFormFile ttt,int id)
        {
            image.PostId = id;
            using (var ms = new MemoryStream())
            {
                ttt.CopyTo(ms);
                image.Img = ms.ToArray();
            };

            _context.Add(image);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Posts", new { id = _context.Post.Where(b=> b.Id == id).FirstOrDefault().TopicId });

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.Image
                .Include(i => i.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var image = await _context.Image.FindAsync(id);
            _context.Image.Remove(image);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Posts", new { id = _context.Post.Where(b => b.Id == image.PostId).FirstOrDefault().TopicId });
        }

        private bool ImageExists(int id)
        {
            return _context.Image.Any(e => e.Id == id);
        }
    }
}

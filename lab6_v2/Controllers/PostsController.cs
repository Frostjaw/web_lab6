using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lab6_v2.Data;
using lab6_v2.Models;
using System.Security.Claims;

namespace lab6_v2.Controllers
{
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Posts
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.id = id;

            var applicationDbContext = _context.Post.Include(p => p.Topic).Include(p => p.Images).Include(p => p.Topic);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Attach(int? id, string title)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post
                .Include(p => p.Topic)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return RedirectToAction("Create", "Images", new { id = post.Id, topicId = post.TopicId });
        }

        public async Task<IActionResult> DeleteImage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.Image
                .FirstOrDefaultAsync(m => m.Id == id);
            if (image == null)
            {
                return NotFound();
            }

            return RedirectToAction("Delete", "Images", new { id = id });
        }
        

        // GET: Posts/Create
        public IActionResult Create()
        {
            ViewData["TopicId"] = new SelectList(_context.Topic, "Id", "Id");
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //BISUAL STUDIO, TEBE PLOHO?????
        public async Task<IActionResult> Create([Bind("Text,UserName,TopicId")] Post post,int id)
        {
            post.TopicId = id;

            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            if (claimsIdentity.Name != null)
            {
                post.UserName = claimsIdentity.Name;
            }
            else
            {
                post.UserName = "Anonymous";
            }

            if (ModelState.IsValid)
            {
                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Posts", new { id = id });
            }
            ViewData["TopicId"] = new SelectList(_context.Topic, "Id", "Id", post.TopicId);
            return View(post);
        }

        // GET: Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Text")] Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                int dirId = _context.Post.Where(b => b.Id == id).FirstOrDefault().TopicId;

                try
                {
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Posts", new { id = dirId });
            }
            ViewData["TopicId"] = new SelectList(_context.Topic, "Id", "Id", post.TopicId);
            return View(post);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post
                .Include(p => p.Topic)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Post.FindAsync(id);

            int dirId = _context.Post.Where(b => b.Id == id).FirstOrDefault().TopicId;

            _context.Post.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Posts", new { id = dirId });
        }

        private bool PostExists(int id)
        {
            return _context.Post.Any(e => e.Id == id);
        }
    }
}

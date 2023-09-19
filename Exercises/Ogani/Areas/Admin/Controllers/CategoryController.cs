using Microsoft.AspNetCore.Mvc;
using Ogani.Data;
using Ogani.Data.Entities;

namespace Ogani.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;

        }
        [HttpGet]

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return RedirectToAction("Categories", "Console");
            }
            else
            {
                Category? category = _context.Categories.FirstOrDefault(c => c.CategoryID == id);
                if (category == null)
                {
                    return RedirectToAction("Categories", "Console");
                }
                else
                {
                    return View(category);
                }

            }

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category? category) 
        { 
            if(category == null)
            {
                return RedirectToAction("Categories", "Console");
            }
            else
            {
                try
                {
                    Category newCategory = new Category(category.CategoryName, category.CategoryDescription);
                    _context.Categories.Add(newCategory);
                    _context.SaveChanges();

                    return RedirectToAction("Categories", "Console");
                }
                catch (Exception ex)
                {

                    return RedirectToAction("Error", "Console", ex);
                }
               
            }
        }

        //GET: Admin/Category/Delete 
        public IActionResult Delete(Guid id)
        {
         
            Category? category = _context.Categories.FirstOrDefault(c => c.CategoryID == id);
            if (id == null)
            {
                return RedirectToAction("Categories", "Console");
            }
            else
            {
                return View(category);
            }
        }

        //Post: Admin/Category/Delete/0000-0000-00000-0000
        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmDelete(Guid? id)
        {
            Category? category = _context.Categories.FirstOrDefault(c => c.CategoryID == id);
            if (id == null)
            {
                return RedirectToAction("Categories", "Console");
            }
            else
            {
                try
                {
                    _context.Categories.Remove(category);
                    _context.SaveChanges();
                    return RedirectToAction("Categories", "Console");
                }
                catch (Exception ex)
                {

                    throw new HttpRequestException("Category not found", ex.InnerException);
                }
            }
        }

        //GET: Admin/Category/Update

        public IActionResult Update(Guid? id)
        {
            Category? category = _context.Categories.FirstOrDefault(c => c.CategoryID == id);

            if (id == null)
            {
                return RedirectToAction("Categories", "Console");
            }
            else
            {
                return View(category);
            }
        }

        //Post: Admin/Category/Update
        [HttpPost]
        public IActionResult Update([Bind("CategoryID, CategoryName, CategoryDescription")] Category updatedCategory)
        {
            Category? category = _context.Categories.FirstOrDefault(c => c.CategoryID == updatedCategory.CategoryID);
            if (category == null)
            {
                return RedirectToAction("Categories", "Console");
            }
            else
            {
                try
                {
                    category.CategoryName = updatedCategory.CategoryName;
                    category.CategoryDescription = updatedCategory.CategoryDescription;
                    _context.Categories.Update(category);
                    _context.SaveChanges();
                    return RedirectToAction("Categories", "Console");
                }
                catch (Exception ex)
                {

                    throw new HttpRequestException("Category not found", ex.InnerException);
                }
            }
        }

    }
}

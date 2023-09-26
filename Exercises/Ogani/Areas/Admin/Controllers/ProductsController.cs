using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ogani.Data;
using Ogani.Data.Entities;

namespace Ogani.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        //// GET: Admin/Products
        //public async Task<IActionResult> Index()
        //{
        //      return _context.Products != null ? 
        //                  View(await _context.Products.ToListAsync()) :
        //                  Problem("Entity set 'ApplicationDbContext.Products'  is null.");
        //}

        // GET: Admin/Products/Details/{C5CBFEDE-13F8-4C6F-B081-F4C0F3273680}
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            Product product = await _context.Products.FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] IFormFile image, Product product)
        {
            if (image != null && image.Length > 0)
            {
                try
                {
                    // Get the original file name
                    var fileName = Path.GetFileName(image.FileName);

                    // Define the directory where the image will be saved (usually in wwwroot/img/product)
                    var directoryPath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "product");

                    // Ensure the directory exists, create it if it doesn't
                    Directory.CreateDirectory(directoryPath);

                    // Combine the directory path with the original file name to get the full path
                    var imagePath = Path.Combine(directoryPath, fileName);

                    // Copy the uploaded image to the specified directory
                    using (Stream stream = new FileStream(imagePath, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }

                    // Store the file name in your product object or database.
                    product.ProductImageName = fileName;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during file upload
                    ModelState.AddModelError("ImageUploadError", "An error occurred while uploading the image: " + ex.Message);
                }
            }

            // Retrieve categories for dropdown
            ViewBag.Categories = _context.Categories;

            if (ModelState.IsValid && product.ProductCategoryCategoryID != Guid.Empty)
            {
                try
                {
                    // Create a new product
                    product.ProductID = Guid.NewGuid();
                    product.DateOfCreation = DateTime.Now;
                    _context.Add(product);
                    await _context.SaveChangesAsync();

                    // Redirect to the "Products" action of the "Console" controller upon successful creation
                    return RedirectToAction("Products", "Console");
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during product creation
                    ModelState.AddModelError("ProductCreateError", "An error occurred while creating the product: " + ex.Message);
                }
            }
            else
            {
                ModelState.AddModelError("ProductCategoryCategoryID", "You must select a product category!");
            }

            // Return to the view with any validation errors and the product model
            return View(product);
        }

        //public async Task<IActionResult> Create([FromForm] IFormFile image, Product product)
        //{
        //    if (image != null && image.Length > 0)
        //    {
        //        // Save the image to a directory or perform required processing.
        //        // For example:
        //        var uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
        //        var filePath = Path.Combine("~/wwwroot/img/product/", uniqueFileName);

        //        using (Stream stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await image.CopyToAsync(stream);
        //        }

        //        // Store the file path or uniqueFileName in your product object or database.
        //        product.ProductImageName = uniqueFileName;
        //    }
        //    ViewBag.Categories = _context.Categories;
        //    if (ModelState.IsValid && product.ProductCategoryCategoryID != Guid.Empty)
        //    {
        //        product.ProductID = Guid.NewGuid();
        //        product.DateOfCreation = DateTime.Now;
        //        _context.Add(product);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction("Products", "Console");
        //    }
        //    ModelState.AddModelError("ProductCategoryCategoryID", "You must select a product category!");
        //    return View(product);
        //}

        // GET: Admin/Products/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ProductID,ProductName,ProductPrice,ProductShortDescription,ProductDescription,ProductInformation,Weight,ProductImageName")] Product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    product.DateOfUpdate = DateTime.Now;
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Products","Console");
            }
            return View(product);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Products", "Console");
        }

        private bool ProductExists(Guid id)
        {
          return (_context.Products?.Any(e => e.ProductID == id)).GetValueOrDefault();
        }
    }
}

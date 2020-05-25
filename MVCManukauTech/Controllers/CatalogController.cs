//20180312 JPC migration notes from MVC5 to Core 2.0
//Straightforward - only a small challenge with returning statuscodes.
//eg in MVC5 - return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//Search gives this: https://stackoverflow.com/questions/37690114/how-to-return-a-specific-status-code-and-no-contents-from-controller
//Much nicer code as - return BadRequest(); // Http status code 400

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCManukauTech.Models.DB;
using Microsoft.AspNetCore.Http;
using MVCManukauTech.ViewModels;
using X.PagedList;
using X.PagedList.Mvc.Core;

namespace MVCManukauTech.Controllers
{
    public class CatalogController : Controller
    {
        private readonly RareShoesContext _context;

        public CatalogController(RareShoesContext context)
        {
            _context = context;
        }

        // GET: /Catalog
        public object Index(int? pageNumber)
        {
            // 20190412 BQC Set pageNumber to 1 if null. This is to ensure a page is always visible.
            int page;
            if (pageNumber == null || pageNumber == 0)
            {
                page = 1;
            }
            else
            {
                page = (int) pageNumber;
            }

            // 20190412 BQC Get all the shoes
            var catalog = _context.Shoes.Include(a => a.Category).Select(b => new 
            {
                ShoesId = b.ShoesId,
                CategoryId = b.Category.CategoryId,
                Name = b.Name,
                ImageFileName = b.ImageFileName,
                UnitCost = b.UnitCost,
                Description = b.Description.Substring(0, 100) + "...",
                CategoryName = b.Category.CategoryName,

            }).ToPagedList(page, 6);


            ViewBag.Model = catalog;
            return View();
        }

        // GET: Catalog/Details?ShoesId=1MORE4ME
        // 20190413 BQC PageNumber is used to navigate back to the previous page.
        public IActionResult Details(string ShoesId, int pageNumber)
        {
            if (ShoesId == null)
            {
                return BadRequest(); // Http status code 400
            }
            //140903 JPC security check - if ProductId is dodgy then return bad request and log the fact 
            //  of a possible hacker attack.  Excessive length or containing possible control characters
            //  are cause for concern!  TODO move this into a separate reusable code method with more sophistication.
            if (ShoesId.Length > 20 || ShoesId.IndexOf("'") > -1 || ShoesId.IndexOf("#") > -1)
            {
                //TODO Code to log this event and send alert email to admin
                return BadRequest(); // Http status code 400
            }

          
            // 20190413 BQC Query to find the shoes matching the supplied ShoeId
            var shoes = _context.Shoes.Include(a => a.Category).Select(b => new CatalogViewModel
            {
                ShoesId = b.ShoesId,
                CategoryId = b.Category.CategoryId,
                Name = b.Name,
                ImageFileName = b.ImageFileName,
                UnitCost = b.UnitCost,
                Description = b.Description,
                CategoryName = b.Category.CategoryName,
            }).Where(s => s.ShoesId == ShoesId).FirstOrDefault();

            if (shoes == null)
            {
                return NotFound(); //Http status code 404
            }

            ViewBag.PageNumber = pageNumber;
            return View(shoes);
        }

    }
}

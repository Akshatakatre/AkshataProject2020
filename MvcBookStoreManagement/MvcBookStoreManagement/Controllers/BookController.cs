using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBookStoreManagement.Models;

namespace MvcBookStoreManagement.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            ViewBag.ItemList = "Book Store book List Page";
            BookListDBHandler IHandler = new BookListDBHandler();
            ModelState.Clear();
            return View(IHandler.GetItemList());

        }

        public ActionResult Index(booklist model)
        {
            var selectedValue = model.Author;
            ViewBag.Author = selectedValue.ToString();
            return View();
        }


        //---add new book---

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(booklist iList)
        {
           
            if (ModelState.IsValid)
            {
                BookListDBHandler ItemHandler = new BookListDBHandler();
                if (ItemHandler.InsertItem(iList))
                {
                    ViewBag.Message = "Book Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();
            
        }

        //---update book details---

        [HttpGet]
        public ActionResult Edit(int id)
        {
            BookListDBHandler ItemHandler = new BookListDBHandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.ID == id));
        }
        [HttpPost]
        public ActionResult Edit(int id, booklist iList)
        {
            try
            {
                BookListDBHandler ItemHandler = new BookListDBHandler();
                ItemHandler.UpdateItem(iList);
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }

        //---delete book details---

        public ActionResult Delete(int id)
        {
            try
            {
                BookListDBHandler ItemHandler = new BookListDBHandler();
                if (ItemHandler.DeleteItem(id))
                {
                    ViewBag.AlertMsg = "Book Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }

        public ActionResult Details(int id)
        {
            BookListDBHandler ItemHandler = new BookListDBHandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.ID == id));
        }
    }
}



    

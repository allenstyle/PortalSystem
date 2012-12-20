using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BillDomain.Entity;
using BillDomain.Repository.Class;

namespace LazyAccount.Controllers
{
    public class ItemController : Controller
    {
        //
        // GET: /Item/

        public ActionResult Index()
        {
            ItemRepository _itemRepository = new ItemRepository();
            IList<Item> result = _itemRepository.GetAll();
            return View(result);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Item model)
        {
            ItemRepository _itemRepository = new ItemRepository();
            _itemRepository.Add(model);
            return RedirectToAction("Index");
        }
    }
}

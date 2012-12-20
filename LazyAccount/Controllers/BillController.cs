using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BillDomain.Entity;
using BillDomain.Repository.Class;
using LazyAccount.Models;

namespace LazyAccount.Controllers
{
    public class BillController : Controller
    {
        //
        // GET: /Bill/

        public ActionResult Index()
        {
            BillModel _billModel = new BillModel();
            return View(_billModel);
        }

        [HttpGet]
        public ActionResult Add()
        {
            BillModel _billModel = new BillModel();

            return View(_billModel);
        }

        public ActionResult Add(BillModel model)
        {
            BillModel _billModel = new BillModel();
            _billModel.AddBill(model);
            return RedirectToAction("Index");
        }
    }
}

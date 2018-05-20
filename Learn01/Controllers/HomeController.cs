using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Learn01.Models;

namespace Learn01.Controllers
{
    public class HomeController : Controller
    {
        //create a learn01Context object
        Learn01Context db = new Learn01Context();

        public ActionResult Index(string option, string search)
        {
            if (option == "BankName")
            {
                return View(db.Bids.Where(x => x.BankName.StartsWith(search) || search == null).ToList());
            }
            else if (option == "FwdDate")
            {
                DateTime searchdate = Convert.ToDateTime(search);
                return View(db.Bids.Where(x => x.FwdDate == searchdate || search == null).ToList());
            }
            else
            {
                List<Bid> BidList = db.Bids.ToList();
                return View(BidList);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ExcelUpload ()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VantageGA.Models;

namespace VantageGA.Controllers
{
    public class TransactionsController : Controller
    {
        // GET: Transaction/TransactionDetails
        public ActionResult TransactionDetails()
        {

            var TransactionDetails = new Transaction();
            return View(TransactionDetails);
        }

        // GET: Transaction/Details

        public ActionResult TransactionInfo()
        {

            var TransactionInfo = new Transaction();
            return View(TransactionInfo);
        }
    }
}
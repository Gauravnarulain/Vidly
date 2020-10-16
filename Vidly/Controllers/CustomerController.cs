using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context= new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MemeShip).ToList();
            return View(customers);
        }

        public ActionResult New()
        {
            var viewModel = new CustomerViewModel
            {
                MemberShips = _context.Member.ToList()
            };
            return View(viewModel);
        }

        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
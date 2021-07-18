using Microsoft.AspNetCore.Mvc;
using Invoice.Data;
using Invoice.ViewModels;

namespace Invoice.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class HomeController : Controller
    {
        private readonly InvoiceDbContext _dbContext;

        public HomeController(InvoiceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<IActionResult> CreateAsync(Invoice.Models.Invoice viewModel)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(viewModel);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
        public ActionResult GetInvoices()
        {
            return View(_dbContext.InvoiceItems);
        }

        [Route("api/Home/InsertCustomer")]
        [HttpPost]
        public InvoiceItem InsertCustomer(InvoiceItem _invoice)
        {
            _dbContext.Add(_invoice);
            _dbContext.SaveChanges();
            return _invoice;
        }

        //[Route("api/AjaxAPI/DeleteCustomer")]
        //[HttpPost]
        //public void DeleteCustomer(Customer _customer)
        //{
        //    using (_dbContext)
        //    {
        //        Invoice.Models.InvoiceItem customer = (from c in _dbContext.InvoiceItems
        //                             where c.Id == _customer.id
        //                             select c).FirstOrDefault();
        //        entities.Customers.Remove(customer);
        //        entities.SaveChanges();
        //    }
        //}
    }
}
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaxComputation.Domain.Entities;
using TaxComputation.Domain.Interfaces;
using TaxComputation.Ui.Models;

namespace TaxComputation.Ui.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork, ILogger<HomeController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var company = new Company(); // Create a new Company instance
            company.Products = new List<Product>(); // Initialize the Products collection
            return View(company);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Company? company)
        {
            if (company != null)
            {
                await _unitOfWork.Company!.CreateAsync(company!);
                await _unitOfWork.SaveChangesAsync();
            }
            else
            {
                return NotFound("An Error Occurred!");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GraduateApp.Models;
using MinorApp.Models;
using UndergraduateApp.Models;
using FacultyApp.Models;
using CoopApp.Models;
using EmploymentApp.Models;
using AboutApp.Models;

/*
<summary>
Represents the controller that handles requests related to the Home page and its sub-pages.
</summary>
*/
namespace NewsApp.Controllers
{
    /**
     * <summary>
     * Initializes a new instance of the <see cref="HomeController"/> class.
     * </summary>
     * 
     * @param logger The logger used to log messages from this controller.
     */
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /**
         * <summary>
         *     Retrieves the view model for the Home page.
         * </summary>
         * 
         * @returns The view for the Home page.
         */
        public async Task<IActionResult> Index()
        {
            return View(await AboutModel.GetViewModelAsync());
        }

        /**
         * <summary>
         *     Retrieves the view model for the Minor page.
         * </summary>
         * 
         * @returns The view for the Minor page.
         */
        public async Task<IActionResult> Minor()
        {
            return View(await MinorModel.GetViewModelAsync());
        }

        /**
         * <summary>
         *     Retrieves the view model for the Undergraduate page.
         * </summary>
         * 
         * @returns The view for the Undergraduate page.
         */
        public async Task<IActionResult> Undergraduate()
        {
            return View(await UndergraduateModel.GetViewModelAsync());
        }

        /**
         * <summary>
         *     Retrieves the view model for the Graduate page.
         * </summary>
         * 
         * @returns The view for the Graduate page.
         */
        public async Task<IActionResult> Graduate()
        {
            return View(await GraduateModel.GetViewModelAsync());
        }

        /**
         * <summary>
         *     Retrieves the view model for the Faculty page.
         * </summary>
         * 
         * @returns The view for the Faculty page.
         */
        public async Task<IActionResult> Faculty()
        {
            return View(await FacultyModel.GetViewModelAsync());
        }

        /**
         * <summary>
         *     Retrieves the view model for the Coop page.
         * </summary>
         * 
         * @returns The view for the Coop page.
         */
        public async Task<IActionResult> Coop()
        {
            return View(await CoopModel.GetViewModelAsync());
        }

        /**
         * <summary>
         *     Retrieves the view model for the Employment page.
         * </summary>
         * 
         * @returns The view for the Employment page.
         */
        public async Task<IActionResult> Employment()
        {
            return View(await EmploymentModel.GetViewModelAsync());
        }

        /**
        * <summary>
        *     Handles errors that occur while processing a request.
        * </summary>
        * 
        * @returns The view for the error page.
        */
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ChartController : Controller
    {
        private readonly GoogleSheetService _sheetService;

        public ChartController(GoogleSheetService sheetService)
        {
            _sheetService = sheetService;
        }

        public async Task<IActionResult> Index()
        {
            string sheetUrl = "https://docs.google.com/spreadsheets/d/1vT9wZzQufKXh2rqWVPAMiW3BCEvAVimu5nii-BS5CAM/export?format=csv&gid=0";

            var csvData = await _sheetService.FetchCsvAsync(sheetUrl);

            ViewBag.CsvData = csvData;

            return View();
        }
    }
}

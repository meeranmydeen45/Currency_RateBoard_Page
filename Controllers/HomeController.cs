using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebCore_MVC_RateBoard.Models;
using WebCore_MVC_RateBoard.Services;


namespace WebCore_MVC_RateBoard.Controllers
{
    public class HomeController : Controller
    {   
        private readonly ILogger<HomeController> _logger;

        //private JsonRateService _jsonRateService;
        private SqlService sqlService;

        public HomeController(ILogger<HomeController> logger, SqlService _sqlService)
        {
           _logger = logger;
            sqlService = _sqlService;
           // _jsonRateService = jsonRateService;
            
        }

        
        [HttpGet]
        public IActionResult Index()
        {
            CombineData combineData = new CombineData();
            combineData.rateModels = sqlService.GetRateBoardData();
            combineData.BackScreenRate = sqlService.GetBackScreenData();
            return View(combineData);
        }
        [HttpPost]
        public JsonResult Index(IEnumerable<RateModelSql> rateModelsView, IEnumerable<BackScreenRateSql> backScreenRate)
        {
            // _jsonRateService.AddBackScreenData(backScreenRate);
            // _jsonRateService.AddData(rateModelsView);
            //CombineData combineData = new CombineData();
            //combineData.rateModels = sqlService.GetRateBoardData();
            //combineData.BackScreenRate = sqlService.GetBackScreenData();

            sqlService.AddRateBoardData(rateModelsView);
            sqlService.AddBackScreenData(backScreenRate);

            sqlService.SetRefreshData();

            return Json('N');

        }

        
        public JsonResult TableRefresh()
        {
            CombineData combineData = new CombineData();
            combineData.rateModels = sqlService.GetRateBoardData();
            combineData.BackScreenRate = sqlService.GetBackScreenData();

            return Json(combineData);


        }

        public JsonResult StausCheck() {
            RefreshStatusModel refreshStatus = new RefreshStatusModel();
            refreshStatus  = sqlService.GetRefreshData();
            return Json(refreshStatus);
        
        
        }

        public void SetStatuFalse()
        {
            sqlService.setRefreshDataFalse();

        }

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

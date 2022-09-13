using ElectricityCalculationProject.Contexts;
using ElectricityCalculationProject.Interfaces;
using ElectricityCalculationProject.Models;
using ElectricityCalculationProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElectricityCalculationProject.Controllers
{
    [Route("api/[controller]/")]
    public class ElectricityController : Controller
    {

        private readonly IElectricityDataRetrievalService _dataRetriever;
        private readonly IElectricityDataHandlerService _dataHandler;
        private readonly IElectricityDataFilteringService _dataFilter;
        private readonly IElectricityDataRepository _dataRepository;
        private readonly ILogger<ElectricityController> _logger;

        public ElectricityController(IElectricityDataRetrievalService dataRetriever, 
            IElectricityDataHandlerService dataHandler, 
            IElectricityDataFilteringService dataFilter,
            IElectricityDataRepository dataRepository,
            ILogger<ElectricityController> logger)
        {
            _dataRetriever = dataRetriever;
            _dataHandler = dataHandler;
            _dataFilter = dataFilter;
            _dataRepository = dataRepository;
            _logger = logger;
        }

        // GET: Electricity/
        [HttpGet]
        public async Task<IActionResult> GetDataByInterval(int startIndex, int length)
        {
            return Ok((await _dataRetriever.GetElectricityData(_dataHandler))
                .Skip(startIndex)
                    .Take(length));
        }

        // GET: ElectricityController/Namas/
        [HttpGet]
        [Route("{buildingType}")]
        public async Task<IActionResult> FilterByBuildingType(string buildingType, int startIndex, int length)
        {
            _logger.LogInformation($"Filtering by building type {buildingType} started...");
            _logger.LogInformation($"Getting data from api...");

            List<ElectricityData> list = (await _dataFilter.FilterByBuildingType(await _dataRetriever.GetElectricityData(_dataHandler), buildingType));

            _logger.LogInformation($"Getting data from api successful...");

            return Ok(list.Skip(startIndex).Take(length));
        }

        // GET: Electricity/Consumption/
        [HttpGet]
        [Route("Consumption/")]
        public async Task<IActionResult> FilterByElectricityConsumption(decimal consumptionKw, int startIndex, int length)
        {
            _logger.LogInformation($"Filtering by electricity consumption with less than {consumptionKw} kw started...");
            _logger.LogInformation($"Getting data from api...");

            List<ElectricityData> list = (await _dataFilter.FilterByElectricityConsumptionLess(await _dataRetriever.GetElectricityData(_dataHandler), consumptionKw));

            _logger.LogInformation($"Getting data from api successful...");
            _logger.LogInformation($"Filtering data...");

            _dataRepository.WriteMultipleToDatabase(list);

            _logger.LogInformation($"Filtering data successful...");

            return Ok(list.Skip(startIndex).Take(length));
        }
    }
}

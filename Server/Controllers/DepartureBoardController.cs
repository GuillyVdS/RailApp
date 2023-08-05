using Microsoft.AspNetCore.Mvc;
using Server.Entities;
using Newtonsoft.Json;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DepartureBoardController : ControllerBase
{
    private readonly ILogger<DepartureBoardController> _logger;

    private readonly IRailClient _railclient;

    public DepartureBoardController(ILogger<DepartureBoardController> logger, IRailClient railClient)
    {
        _logger = logger;
        _railclient = railClient;
    }

    [HttpGet("{location}")]
    public async Task<ActionResult<SimpleDepartureBoard>> GetWeatherDataForLocation(string location)
        {

            try
            {
                string returnData = await _railclient.GetSimpleDepartureBoard(location);
                return ParseData(returnData, location);
            }
            catch(ArgumentException ex)
            {
                return BadRequest();
            } 
            
        }
    
    private SimpleDepartureBoard ParseData(string jsonString, string location)
        {
            Root ApiData = JsonConvert.DeserializeObject<Root>(jsonString);
            List<DepartureDetails> Departures = new List<DepartureDetails>();
            
            SimpleDepartureBoard StationDepartures = new SimpleDepartureBoard(location, Departures);

            StationDepartures.Location = ApiData.Location.Name;

            foreach (var Service in ApiData.Services) {
                DepartureDetails Departure = new DepartureDetails(
                    Service.LocationDetail.GbttBookedDeparture,
                    Service.LocationDetail.Destination[0].Description,
                    Service.LocationDetail.Platform,
                    Service.LocationDetail.GbttBookedArrival);
                StationDepartures.Departures.Add(Departure);
            }

            return StationDepartures;
        }
}
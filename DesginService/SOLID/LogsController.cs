//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignService.SOLID;

//internal class LogsController : ControllerBase
//{
//    private readonly ICloudLogger _logger;

//    public LogsController(ICloudLogger logger)
//    {
//        _logger = logger;
//    }

//    [HttpPost]
//    public IActionResult LogMessage([FromBody] string message)
//    {
//        _logger.Log(message);
//        return Ok("Log recorded successfully.");
//    }
//}



/*
 
 // Use ConsoleLogger for local development
   builder.Services.AddSingleton<ICloudLogger, ConsoleLogger>();

// Or switch to FileLogger
   builder.Services.AddSingleton<ICloudLogger, FileLogger>();

// Or use Azure Application Insights in production
   builder.Services.AddSingleton<ICloudLogger, AppInsightsLogger>();
 
 */



/*
 
    Violate OCP
    // Every new log type requires modifying the controller

    [ApiController]
    [Route("api/logs")]
    public class LogsController : ControllerBase
    {
        [HttpPost]
        public IActionResult LogMessage([FromBody] string message, string logType)
        {
            if (logType == "Console")
                Console.WriteLine($"[Console] {message}");
            else if (logType == "File")
                File.AppendAllText("logs.txt", message + "\n");
            else if (logType == "AppInsights")
            {
                var telemetry = new TelemetryClient();
                telemetry.TrackTrace(message);
            }

            return Ok("Log recorded.");
        }
    }

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;

namespace DesignService.SOLID;

public interface ICloudLogger
{
    void Log(string message);
}


public class ConsoleLogger : ICloudLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Console] {DateTime.UtcNow}: {message}");
    }
}

public class FileLogger : ICloudLogger
{
    private readonly string _filePath = "logs.txt";

    public void Log(string message)
    {
        File.AppendAllText(_filePath, $"[File] {DateTime.UtcNow}: {message}\n");
    }
}


public class AppInsightsLogger : ICloudLogger
{
    private readonly TelemetryClient _telemetryClient;

    public AppInsightsLogger(TelemetryClient telemetryClient)
    {
        _telemetryClient = telemetryClient;
    }

    public void Log(string message)
    {
        _telemetryClient.TrackTrace(new TraceTelemetry(message, SeverityLevel.Information));
    }
}


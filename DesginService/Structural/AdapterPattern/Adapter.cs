using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignService.Structural.AdapterPattern
{
    using DesignService.Creational.FactoryPattern;
    using System;
    using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    // Old System (legacy code)
    public class OldSystem
    {
        public string GetData()
        {
            return "Data from the Old System";
        }
    }

    // New System (expects data in a different format)
    public class NewSystem
    {
        public void DisplayData(string data)
        {
            Console.WriteLine("Displaying data: " + data);
        }
    }

    // Adapter class to adapt the old system's data for the new system
    public class Adapter
    {
        private OldSystem _oldSystem;

        public Adapter(OldSystem oldSystem)
        {
            _oldSystem = oldSystem;
        }

        public string GetDataForNewSystem()
        {
            // Convert data from the old system to the format the new system expects
            string oldData = _oldSystem.GetData();
            return $"Adapted: {oldData}";
        }
    }


    // OldSystem: This is the legacy system that provides data in one format.

    // NewSystem: This system expects data in a different format(here, a simple string).

    // Adapter: This class adapts the data from the OldSystem to the format expected by the NewSystem.It converts the data into a format the NewSystem understands.

    // Main Program: In the Main method, we create instances of the OldSystem, Adapter, and NewSystem. The Adapter converts the data from the OldSystem into the format that can be used by the NewSystem.


}

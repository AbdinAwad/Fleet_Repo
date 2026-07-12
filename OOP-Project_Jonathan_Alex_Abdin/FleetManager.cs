using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    // Creating FleetManager class
    // Features: [F-08] (Static Members)
    public class FleetManager
    {
        // Properties and lists
        private List<Vehicle> Vehicles = new List<Vehicle>();

        // [F-08] Static list for central data management
        public static List<string> AvailableDrivers = new List<string>();
        private static string filePath = "drivers.txt";

        // Methods

        // [F-07] Data Storage & Persistence (Reading from text file)
        public static void InitializeDriverPool()
        {
            string fullPath = Path.Combine(AppContext.BaseDirectory, filePath);

            if (File.Exists(fullPath))
            {
                // Reading driver data and utilizing a static helper for validation
                AvailableDrivers = File.ReadAllLines(fullPath)
                                       .Where(name => ValidationHelper.IsValidString(name))
                                       .Select(name => name.Trim())
                                       .ToList();
            }
        }

        public void AddVehicle(Vehicle vec) => Vehicles.Add(vec);

        // Recycling the driver back to the pool when a vehicle is removed
        public void RemoveVehicle(Vehicle vec)
        {
            if (vec.DriverName != "Unassigned")
            {
                AvailableDrivers.Add(vec.DriverName);
            }
            Vehicles.Remove(vec);
        }
    }
}
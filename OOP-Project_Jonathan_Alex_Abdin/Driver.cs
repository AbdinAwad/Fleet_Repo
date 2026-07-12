using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    // Creating Driver class
    // Features: [F-05], [F-06]
    public class Driver
    {
        // Properties and lists

        // Internal collection for managing driver instances [F-06]
        private List<Driver> drivers = new List<Driver>();

        // Initializing with empty strings to prevent nullability warnings [F-05]
        public string DriverID { get; set; } = string.Empty;
        public string DriverName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int DriverYearsOfExperience { get; set; }
        public double DriverWage { get; set; }

        // Methods

        // Basic list management for driver entities [F-06]
        public void AddDriver(Driver driver)
        {
            drivers.Add(driver);
        }

        public void RemoveDriver(Driver driver)
        {
            drivers.Remove(driver);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    // Creating Package class
    // Features: [F-05] (Encapsulation and Data Validation)
    public class Package
    {
        // Properties and lists
        // [F-05] Private backing fields
        private double weight;
        private double packageSize;

        public string PackageID { get; set; }
        public string Description { get; set; }

        // [F-05] Public Properties with validation logic
        public double Weight
        {
            get => weight;
            set => weight = (value < 0) ? 0 : value;
        }

        public double PackageSize
        {
            get => packageSize;
            set => packageSize = (value < 0) ? 0 : value;
        }

        // Methods

        public Package(string id, string desc, double weight, double size)
        {
            PackageID = id;
            Description = desc;
            Weight = weight;
            PackageSize = size;
        }

        public double GetWeight() => Weight;
        public double GetSize() => PackageSize;
    }
}
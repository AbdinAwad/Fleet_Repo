using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    // Creating Main Vehicle Class (Abstract)
    // Features: [F-01] (Abstract Base), [F-02] (Built-in Interface)
    public abstract class Vehicle : IComparable<Vehicle>
    {
        // Properties and lists
        public string DriverName { get; set; } = "Unassigned";
        public string VehicleID { get; set; } = string.Empty;
        public double VehicleSize { get; set; }
        public double MaxCapacity { get; set; }
        public double CurrentWeightLoad { get; set; }
        public double CurrentSizeLoad { get; set; }

        // [F-06] List to track loaded packages so they persist when reopening forms
        public List<Package> LoadedPackages { get; set; } = new List<Package>();

        public double EnergyLevel { get; set; }

        protected static Random rand = new Random();

        public Vehicle()
        {
            // Starting with a random energy level for realism
            EnergyLevel = rand.Next(5, 101);
        }

        // Methods

        // [F-01] Abstract method that derived classes must implement
        public abstract void Refuel(double amount);

        // [F-03] Method Overloading (Overload 1: Parameterless top-off)
        public void Refuel()
        {
            this.EnergyLevel = 100;
        }

        // [F-04] Operator Overloading (+) to combine Vehicle and Package
        // [F-08] Exception Handling for capacity violations
        //Overloads the '+' operator to allow for syntax 'Vehicle + Package'.
        //Before adding the package it validates if the vehicle has enough capacity.
        public static Vehicle operator +(Vehicle v, Package p)
        {
            //logical check: Current load + New Package weight vs. Max Allowed.
            if (v.CurrentWeightLoad + p.Weight > v.MaxCapacity)
            {
                //Throws an exception to catch in the UI and prevent overloading the vehicle.
                //This prevents the application from processing invalid data.
                throw new InvalidOperationException("This vehicle can't handle that much weight.");
            }

            if (v.CurrentSizeLoad + p.PackageSize > v.VehicleSize)
                throw new InvalidOperationException("Size limit exceeded");

            //if weight is within limits, proceed to add the package.
            v.CurrentWeightLoad += p.Weight;
            v.CurrentSizeLoad += p.PackageSize;
            v.LoadedPackages.Add(p);
            return v;
        }

        // [F-02] IComparable implementation for sorting collections
        //Sorting Logic
        //Compares the Current Vehicle's maxCapacity with another vehicle's MaxCapacity
        //Returns -1 if this is smaller, 1 if larger, and 0 if they are equal
        public int CompareTo(Vehicle? other)
        {
            if (other == null) return 1;
            return this.MaxCapacity.CompareTo(other.MaxCapacity);
        }

        public double getRemainingCapacity() => MaxCapacity - CurrentWeightLoad;
        public double getRemainingSize() => VehicleSize - CurrentSizeLoad;
    }

    // Creating ElectricVehicle class which inherits from Vehicle
    // Features: [F-01] (Inheritance), [F-02] (Custom Interface Implementation)
    public class ElectricVehicle : Vehicle, IEnergyConsumer
    {
        // [F-03] Method Overriding
        public override void Refuel(double amount)
        {
            EnergyLevel += amount;
            if (EnergyLevel > 100) EnergyLevel = 100;
        }

        public string GetFuelWarning() => EnergyLevel < 20 ? "Low Battery! Find a charging station." : "Battery Level Nominal.";
        public void ConsumeEnergy(double amount) => EnergyLevel = Math.Max(0, EnergyLevel - amount);
    }

    // Creating HydrogenVehicle class which inherits from Vehicle
    public class HydrogenVehicle : Vehicle, IEnergyConsumer
    {
        public override void Refuel(double amount)
        {
            EnergyLevel += amount;
            if (EnergyLevel > 100) EnergyLevel = 100;
        }

        public string GetFuelWarning() => EnergyLevel < 20 ? "Low Hydrogen! Refuel immediately." : "Hydrogen Pressure Nominal.";
        public void ConsumeEnergy(double amount) => EnergyLevel = Math.Max(0, EnergyLevel - amount);
    }

    // [F-08] Sealed Classes to prevent further inheritance
    public sealed class Drone : ElectricVehicle { public Drone() : base() { MaxCapacity = 5; VehicleSize = 25; } }
    public sealed class ElectricCar : ElectricVehicle { public ElectricCar() : base() { MaxCapacity = 500; VehicleSize = 500; } }
    public sealed class ElectricVan : ElectricVehicle { public ElectricVan() : base() { MaxCapacity = 1500; VehicleSize = 1000; } }
    public sealed class ElectricBike : ElectricVehicle { public ElectricBike() : base() { MaxCapacity = 50; VehicleSize = 150; } }
    public sealed class HeavydutyHydrogenTruck : HydrogenVehicle { public HeavydutyHydrogenTruck() : base() { MaxCapacity = 5000; VehicleSize = 3000; } }
}
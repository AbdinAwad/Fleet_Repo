using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Project_Jonathan_Alex_Abdin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Tests
{
    // Features: [F-01] Hierarchy, [F-02] Interfaces, [F-03] Polymorphism, 
    // [F-04] Operator Overloading, [F-05] Encapsulation, [F-08] Exceptions/Statics
    [TestClass]
    public class VehicleTests
    {
        // 1. Test: Operator Overload (+) [F-04]
        [TestMethod]
        public void Test_OperatorOverload_AddsWeight()
        {
            // Arrange
            Vehicle car = new ElectricCar();
            Package pkg = new Package("P1", "Test", 50, 2);

            // Act
            car = car + pkg;

            // Assert
            Assert.AreEqual(50, car.CurrentWeightLoad);
        }

        // 2. Test: Capacity Exception Handling [F-04], [F-08]
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_OperatorOverload_ThrowsOnWeightLimit()
        {
            // Arrange
            Vehicle drone = new Drone();
            Package heavyPkg = new Package("P2", "Too Heavy", 10, 1);

            // Act
            drone = drone + heavyPkg;
        }

        // 3. Test: Method Overriding logic [F-03]
        [TestMethod]
        public void Test_Refuel_CapsAtOneHundred()
        {
            // Arrange
            Vehicle bike = new ElectricBike();
            bike.EnergyLevel = 90;

            // Act
            bike.Refuel(50);

            // Assert
            Assert.AreEqual(100, bike.EnergyLevel);
        }

        // 4. Test: Method Overloading (Parameterless) [F-03]
        [TestMethod]
        public void Test_RefuelOverload_TopsOff()
        {
            // Arrange
            Vehicle truck = new HeavydutyHydrogenTruck();
            truck.EnergyLevel = 10;

            // Act
            truck.Refuel();

            // Assert
            Assert.AreEqual(100, truck.EnergyLevel);
        }

        // 5. Test: Built-in Interface (IComparable) [F-02]
        [TestMethod]
        public void Test_IComparable_SortingOrder()
        {
            // Arrange
            Vehicle drone = new Drone();
            Vehicle truck = new HeavydutyHydrogenTruck();

            // Act & Assert
            Assert.IsTrue(drone.CompareTo(truck) < 0);
        }

        // 6. Test: Encapsulation & Data Validation [F-05]
        [TestMethod]
        public void Test_Package_NoNegativeWeight()
        {
            // Arrange & Act
            Package pkg = new Package("P3", "Broken", -50, -5);

            // Assert
            Assert.AreEqual(0, pkg.Weight);
            Assert.AreEqual(0, pkg.PackageSize);
        }

        // 7. Test: Custom Interface Implementation [F-02]
        [TestMethod]
        public void Test_Interface_FuelWarning()
        {
            // Arrange
            ElectricVehicle car = new ElectricCar();
            car.EnergyLevel = 10;

            // Act
            string warning = car.GetFuelWarning();

            // Assert
            Assert.IsTrue(warning.Contains("Low Battery"));
        }

        // 8. Test: Static Helper Utility [F-08]
        [TestMethod]
        public void Test_StaticHelper_Validation()
        {
            // Arrange, Act & Assert
            Assert.IsFalse(ValidationHelper.IsValidString("   "));
        }
    }
}
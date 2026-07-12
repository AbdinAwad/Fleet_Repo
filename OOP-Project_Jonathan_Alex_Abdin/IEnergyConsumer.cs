using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    // Creating Custom Interface for Energy Management
    // Feature: [F-02] (Defining a unique interface implemented by multiple classes)
    public interface IEnergyConsumer
    {
        // Method to return a type-specific warning string (e.g., "Low Battery" vs "Low Hydrogen")
        string GetFuelWarning();

        // Method to handle the reduction of energy levels during vehicle operation
        void ConsumeEnergy(double amount);
    }
}
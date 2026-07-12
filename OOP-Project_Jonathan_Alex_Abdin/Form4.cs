using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    // Creating Energy Management Form
    // Features: [F-03], [F-08]
    public partial class frmManageFuel : Form
    {
        // Properties and lists
        private Vehicle? selectedVehicle;

        // Methods

        public frmManageFuel(Vehicle vehicle)
        {
            InitializeComponent();
            selectedVehicle = vehicle;

            // Ensuring the UI is ready regardless of how the form is opened
            if (selectedVehicle != null) InitializeFormDisplay();
        }

        private void frmManageFuel_Load(object sender, EventArgs e) => InitializeFormDisplay();

        private void InitializeFormDisplay()
        {
            lblVehicleID.Text = selectedVehicle?.VehicleID ?? "Unknown";

            // Visual switching based on fuel type (Electric vs Hydrogen)
            if (selectedVehicle is ElectricVehicle)
            {
                label2.Text = "Charging Hub";
                picEnergyIcon.Visible = true;
                picHydrogenIcon.Visible = false;
            }
            else
            {
                label2.Text = "Hydrogen Station";
                picEnergyIcon.Visible = false;
                picHydrogenIcon.Visible = true;
            }
            UpdateFuelUI();
        }

        private void UpdateFuelUI()
        {
            prgEnergryLevel.Value = (int)selectedVehicle!.EnergyLevel;
            lblPercent.Text = $"{(int)selectedVehicle.EnergyLevel}%";
        }

        // Executing the polymorphic refuel implementation [F-03]
        private void btnRefill_Click(object sender, EventArgs e)
        {
            double amount = (double)nudAmount.Value;

            // Check if the new total exceeds 100%
            if ((selectedVehicle?.EnergyLevel ?? 0) + amount > 100)
            {
                // [F-03] Using type-checking to customize the "Cap" message
                string tankName = (selectedVehicle is ElectricVehicle) ? "battery" : "hydrogen tank";

                MessageBox.Show($"Maximum capacity reached. Capping {tankName} at 100%.", "System Notice");
            }

            // Using override to run the specific logic for this vehicle type [F-03]
            selectedVehicle?.Refuel(amount);
            UpdateFuelUI();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
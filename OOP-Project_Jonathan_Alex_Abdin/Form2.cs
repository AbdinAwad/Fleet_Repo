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
    // Creating Driver Assignment Form
    // Features: [F-05], [F-07], [F-08]
    public partial class frmAssignDriver : Form
    {
        // Properties and lists
        List<String> drivers = FleetManager.AvailableDrivers;
        private Vehicle selectedVehicle;

        // Methods

        // Passing the vehicle reference for cross-form editing [F-05]
        public frmAssignDriver(Vehicle vehicleToEdit)
        {
            InitializeComponent();
            selectedVehicle = vehicleToEdit;
        }

        private void frmAssignDriver_Load(object sender, EventArgs e)
        {
            // Displaying current vehicle details passed from Form 1 (frmFleetDashboard)
            lblVehicleDetails.Text = selectedVehicle.VehicleID;
            lblDriverSelection.Text = selectedVehicle.DriverName;

            // Loading the combo box with drivers from our static pool [F-08]
            cboDrivers.Items.Clear();
            foreach (string? driver in drivers)
            {
                if (driver != null)
                {
                    cboDrivers.Items.Add(driver);
                }
            }
        }

        // Logic for assigning the driver and managing the shared pool
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cboDrivers.SelectedIndex != -1)
            {
                string newDriver = cboDrivers.SelectedItem?.ToString() ?? "Unassigned";

                // If we are replacing an existing driver, they go back to the top of the pool
                if (selectedVehicle.DriverName != "Unassigned")
                {
                    drivers.Insert(0, selectedVehicle.DriverName);
                }

                // Updating the vehicle object and removing the new driver from availability
                selectedVehicle.DriverName = newDriver;
                drivers.Remove(newDriver);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            string driverName = txtDriverName.Text;
            if (!ValidationHelper.IsValidString(driverName))
            {
                MessageBox.Show("Please enter driver name.");
            }
            else if (driverName.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length < 2)
            {
                MessageBox.Show("Please enter full name (first and last).");
            }
            else if (cboDrivers.Items.Contains(driverName))
            {
                MessageBox.Show("This driver already exists.");
            }
            else
            {
                drivers.Add(driverName);
                cboDrivers.Items.Add($"{driverName}");
                SaveDriversToFile();
                MessageBox.Show("Driver added successfully");
            }

        }

        private void btnRemoveDriver_Click(object sender, EventArgs e)
        {
            string driverName = txtDriverName.Text;
            if (!ValidationHelper.IsValidString(driverName))
            {
                MessageBox.Show("Please enter driver name.");
            }
            else if (driverName.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length < 2)
            {
                MessageBox.Show("Please enter full name (first and last).");
            }
            else if (!cboDrivers.Items.Contains(driverName))
            {
                MessageBox.Show("This driver doesn't exist. \nNote: if the driver is assigned to a vehicle you need to unassign the driver to be able to remove them");
            }
            else
            {
                drivers.Remove(driverName);
                cboDrivers.Items.Remove($"{driverName}");
                SaveDriversToFile();
                MessageBox.Show("Driver removed successfully");
            }
        }
        private void SaveDriversToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("drivers.txt", false))
                {
                    foreach (var d in drivers)
                    {
                        writer.WriteLine(d);
                    }
                }
            }
            catch (IOException ex)
            {
                // Notifies the user if the file cannot be accessed (for example, file is open in another program)
                MessageBox.Show($"Data Error: Could not save drivers. {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Catch for any other unexpected system errors
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
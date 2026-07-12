using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    // Creating Main Fleet Dashboard Form
    // Features: [F-06], [F-07], [F-08]
    public partial class frmFleetDashboard : Form
    {
        // Properties and lists

        // Main collection for tracking all registered vehicles in the current session [F-06]
        private List<Vehicle> fleet = new List<Vehicle>();

        // Shared warehouse inventory accessible by the cargo management screen [F-06]
        public static List<Package> Warehouse = new List<Package>();

        // Methods

        public frmFleetDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Initializing our driver pool from the external text file at startup [F-07]
            FleetManager.InitializeDriverPool();

            // Stocking the warehouse with a random set of packages if it's currently empty
            if (Warehouse.Count == 0)
            {
                PopulateSmartWarehouse();
            }

            // Setting initial UI states for a clean startup
            SetActionButtonsState(false);
            grpVehicleDetails.Visible = false;

            radBike.Checked = false;
            radDrone.Checked = false;
            radCar.Checked = false;
            radVan.Checked = false;
            radTruck.Checked = false;


            // Checking if the vehicle.txt file exists or no 
            if (File.Exists("vehicles.txt"))
            {
                //Reading the file data
                var lines = File.ReadAllLines("vehicles.txt");

                foreach (var line in lines)
                {
                    var data = line.Split(" ");

                    Vehicle v;

                    //Switch case to determine the vehicle type
                    switch (data[1])
                    {
                        case "ElectricCar": v = new ElectricCar(); break;
                        case "Drone": v = new Drone(); break;
                        case "ElectricVan": v = new ElectricVan(); break;
                        case "ElectricBike": v = new ElectricBike(); break;
                        case "HeavydutyHydrogenTruck": v = new HeavydutyHydrogenTruck(); break;
                        default: continue;
                    }

                    v.VehicleID = data[0];
                    v.MaxCapacity = double.Parse(data[2]);
                    v.EnergyLevel = double.Parse(data[3]);

                    if (data[4] == "Unassigned")
                    {
                        v.DriverName = $"{data[4]}";
                    }
                    else
                    {

                        v.DriverName = $"{data[4]} {data[5]}";
                        FleetManager.AvailableDrivers.Remove(v.DriverName);
                    }
                    fleet.Add(v);
                    lstFleet.Items.Add(v.VehicleID);

                }

                lblTotalCount.Text = $"Total Vehicles: {fleet.Count}";
            }
        }

        // Setting up a variety of packages to demonstrate different vehicle load limits [F-06]
        private void PopulateSmartWarehouse()
        {
            Random r = new Random();

            // Generating categorized packages: Small (Drones), Medium (Cars), and Heavy (Trucks)
            for (int i = 1; i <= 5; i++)
            {
                Warehouse.Add(new Package($"S-{100 + i}", "Small Parcel", r.Next(1, 5), r.Next(1, 25)));
            }
            for (int i = 1; i <= 5; i++)
            {
                Warehouse.Add(new Package($"M-{200 + i}", "Standard Box", r.Next(20, 101), r.Next(25, 250)));
            }
            for (int i = 1; i <= 5; i++)
            {
                Warehouse.Add(new Package($"H-{300 + i}", "Industrial Pallet", r.Next(500, 2001), r.Next(250, 1000)));
            }
        }

        // Handling the logic for creating and registering new vehicles [F-01]
        private void btnRegister_Click(object sender, EventArgs e)
        {

            Vehicle? newVehicle = null;
            string prefix = "";

            // Instantiating the specific type based on user selection [F-01]
            if (radBike.Checked) { newVehicle = new ElectricBike(); prefix = "B-"; }
            else if (radDrone.Checked) { newVehicle = new Drone(); prefix = "D-"; }
            else if (radCar.Checked) { newVehicle = new ElectricCar(); prefix = "C-"; }
            else if (radVan.Checked) { newVehicle = new ElectricVan(); prefix = "V-"; }
            else if (radTruck.Checked) { newVehicle = new HeavydutyHydrogenTruck(); prefix = "T-"; }

            if (newVehicle != null)
            {
                string finalID;
                bool isDuplicate;
                Random idGen = new Random();

                // Generating a unique 5-digit ID and checking for duplicates in the list [F-06]
                do
                {
                    isDuplicate = false;
                    int randomNumber = idGen.Next(10000, 99999);
                    finalID = prefix + randomNumber.ToString();

                    foreach (Vehicle v in fleet)
                    {
                        if (v.VehicleID == finalID) { isDuplicate = true; break; }
                    }

                } while (isDuplicate);

                newVehicle.VehicleID = finalID;
                fleet.Add(newVehicle);

                // Refreshing the UI with the new registration data
                lstFleet.Items.Add(newVehicle.VehicleID);
                lblTotalCount.Text = $"Total Vehicles: {fleet.Count}";

                SaveFleetToFile();

                MessageBox.Show($"{newVehicle.VehicleID} registered!", "Success");
            }
            else
            {
                MessageBox.Show("Please select a vehicle type.", "Registration Error");
            }
        }

        // Refreshing the dashboard display whenever a vehicle is selected from the list [F-05]
        private void lstFleet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFleet.SelectedIndex == -1)
            {
                SetActionButtonsState(false);
                grpVehicleDetails.Visible = false;
                return;
            }

            SetActionButtonsState(true);
            grpVehicleDetails.Visible = true;

            // Accessing the object properties through encapsulation [F-05]
            Vehicle selected = fleet[lstFleet.SelectedIndex];

            lblDisplayID.Text = selected.VehicleID;
            lblDisplayDriver.Text = selected.DriverName;
            lblDisplayMaxPayload.Text = $"{selected.MaxCapacity} kg";
            lblDisplayPayload.Text = $"{selected.CurrentWeightLoad} kg";
            lblDisplaySize.Text = $"{selected.CurrentSizeLoad} cm³";
            lblFuelPercent.Text = $"{selected.EnergyLevel}%";
            lblDisplayFuelType.Text = (selected is ElectricVehicle) ? "Battery" : "Hydrogen";

            // Determining the friendly name for display based on the specific class type
            switch (selected)
            {
                case Drone _: lblDisplayType.Text = "Drone"; break;
                case ElectricCar _: lblDisplayType.Text = "Electric Car"; break;
                case ElectricVan _: lblDisplayType.Text = "Electric Van"; break;
                case ElectricBike _: lblDisplayType.Text = "Electric Bike"; break;
                case HeavydutyHydrogenTruck _: lblDisplayType.Text = "Hydrogen Truck"; break;
                default: lblDisplayType.Text = "Unknown Vehicle"; break;
            }

            // Updating visual status indicators
            UpdateFuelStatus(selected.EnergyLevel);
            UpdateVehicleImage(selected);
        }

        // Logic for managing action button colors and availability
        private void SetActionButtonsState(bool enabled)
        {
            Color disabledGrey = Color.FromArgb(213, 216, 220);

            btnAssignDriver.Enabled = enabled;
            btnAssignDriver.BackColor = enabled ? Color.FromArgb(52, 152, 219) : disabledGrey;

            btnManageCargo.Enabled = enabled;
            btnManageCargo.BackColor = enabled ? Color.FromArgb(155, 89, 182) : disabledGrey;

            btnRemoveVehicle.Enabled = enabled;
            btnRemoveVehicle.BackColor = enabled ? Color.FromArgb(192, 57, 43) : disabledGrey;

            btnManageFuel.Enabled = enabled;
            btnManageFuel.BackColor = enabled ? Color.FromArgb(243, 156, 18) : disabledGrey;
        }

        // Logic for color-coding the fuel status label based on current levels
        private void UpdateFuelStatus(double level)
        {
            // [F-02] Grabs the selected vehicle reference
            Vehicle? selected = (lstFleet.SelectedIndex != -1) ? fleet[lstFleet.SelectedIndex] : null;

            if (selected != null)
            {
                UpdateVehicleImage(selected);
            }

            // Handles all the visual UI updates so the labels match the vehicle
            if (level >= 80)
            {
                lblFuelStatus.Text = "System Ready";
                lblFuelStatusBack.BackColor = Color.FromArgb(46, 204, 113);
                label9.BackColor = Color.FromArgb(46, 204, 113);
                lblFuelStatus.BackColor = Color.FromArgb(46, 204, 113);
                lblFuelPercent.BackColor = Color.FromArgb(46, 204, 113);
            }
            else if (level >= 20)
            {
                lblFuelStatus.Text = "Refill Recommended";
                lblFuelStatusBack.BackColor = Color.FromArgb(241, 196, 15);
                label9.BackColor = Color.FromArgb(241, 196, 15);
                lblFuelStatus.BackColor = Color.FromArgb(241, 196, 15);
                lblFuelPercent.BackColor = Color.FromArgb(241, 196, 15);
            }
            else
            {
                lblFuelStatus.Text = "URGENT: Low Energy";
                lblFuelStatusBack.BackColor = Color.FromArgb(230, 126, 34);
                label9.BackColor = Color.FromArgb(230, 126, 34);
                lblFuelStatus.BackColor = Color.FromArgb(230, 126, 34);
                lblFuelPercent.BackColor = Color.FromArgb(230, 126, 34);
            }

            // Forces the UI to refresh its visuals before the MessageBox pauses the thread

            this.Refresh();

            // Triggers the custom interface popup [F-02]
            if (level < 20 && selected is IEnergyConsumer consumer)
            {
                string warning = consumer.GetFuelWarning();
                MessageBox.Show(warning, "Critical Energy Level", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateVehicleImage(Vehicle v)
        {
            picBike.Visible = v is ElectricBike;
            picDrone.Visible = v is Drone;
            picCar.Visible = v is ElectricCar;
            picVan.Visible = v is ElectricVan;
            picTruck.Visible = v is HeavydutyHydrogenTruck;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAssignDriver_Click(object sender, EventArgs e)
        {
            if (lstFleet.SelectedIndex != -1)
            {
                Vehicle selected = fleet[lstFleet.SelectedIndex];

                // Opening the driver assignment form as a modal dialog [F-08]
                using (frmAssignDriver assignForm = new frmAssignDriver(selected))
                {
                    if (assignForm.ShowDialog() == DialogResult.OK)
                    {
                        lblDisplayDriver.Text = selected.DriverName;

                        SaveFleetToFile();
                    }
                }
            }
        }

        private void btnManageCargo_Click(object sender, EventArgs e)
        {
            if (lstFleet.SelectedIndex != -1)
            {
                Vehicle selected = fleet[lstFleet.SelectedIndex];

                // Launching the cargo management screen for the selected vehicle [F-08]
                using (frmManageCargo cargoForm = new frmManageCargo(selected))
                {
                    if (cargoForm.ShowDialog() == DialogResult.OK)
                    {
                        lblDisplayPayload.Text = $"{selected.CurrentWeightLoad} kg";
                        lblDisplaySize.Text = $"{selected.CurrentSizeLoad} cm³";
                    }
                }
            }
        }

        // Logic for decommissioning a vehicle and recycling its assigned resources back to pools
        private void btnRemoveVehicle_Click(object sender, EventArgs e)
        {
            if (lstFleet.SelectedIndex != -1)
            {
                Vehicle toRemove = fleet[lstFleet.SelectedIndex];

                // Returning the driver and all loaded cargo to the top of their respective pools [F-06]
                if (toRemove.DriverName != "Unassigned")
                {
                    FleetManager.AvailableDrivers.Insert(0, toRemove.DriverName);
                }

                foreach (Package pkg in toRemove.LoadedPackages)
                {
                    Warehouse.Insert(0, pkg);
                }

                fleet.RemoveAt(lstFleet.SelectedIndex);
                lstFleet.Items.RemoveAt(lstFleet.SelectedIndex);

                SaveFleetToFile();

                lblTotalCount.Text = $"Total Vehicles: {fleet.Count}";
                grpVehicleDetails.Visible = false;
                SetActionButtonsState(false);
            }
        }

        private void btnManageFuel_Click(object sender, EventArgs e)
        {
            if (lstFleet.SelectedIndex != -1)
            {
                Vehicle selected = fleet[lstFleet.SelectedIndex];

                // Accessing the energy management form [F-08]
                using (frmManageFuel fuelForm = new frmManageFuel(selected))
                {
                    fuelForm.ShowDialog();
                    lblFuelPercent.Text = $"{selected.EnergyLevel}%";
                    UpdateFuelStatus(selected.EnergyLevel);

                    SaveFleetToFile();
                }
            }
        }

        // [F-08] Saving vehicles data with error handling to prevent application crashes
        private void SaveFleetToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("vehicles.txt", false))
                {
                    foreach (var v in fleet)
                    {
                        writer.WriteLine($"{v.VehicleID} {v.GetType().Name} {v.MaxCapacity} {v.EnergyLevel} {v.DriverName}");
                    }
                }
            }
            catch (IOException ex)
            {
                // Notifies the user if the file cannot be accessed (for example, file is open in another program)
                MessageBox.Show($"Data Error: Could not save fleet. {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Catch for any other unexpected system errors
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFleetDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
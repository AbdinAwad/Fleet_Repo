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
    // Creating Cargo Management Form
    // Features: [F-04], [F-06], [F-08]
    public partial class frmManageCargo : Form
    {
        // Properties and lists
        private Vehicle selectedVehicle;
        private List<Package> sessionPackages = new List<Package>();

        // Methods

        public frmManageCargo(Vehicle vehicle)
        {
            InitializeComponent();
            selectedVehicle = vehicle;
        }

        private void frmManageCargo_Load(object sender, EventArgs e)
        {
            lblVehicleDetails.Text = selectedVehicle.VehicleID;
            UpdateCargoDisplay();
            UpdateVehicleImage(selectedVehicle);
            RefreshVehicleCargoList();
            RefreshWarehouseList();
        }

        // Standardizing the list display for a clean UI
        private string GetPackageDisplayName(Package pkg) => $"{pkg.PackageID} | {pkg.Weight}kg - {pkg.Description} - Size: {pkg.PackageSize} cm³";

        private void RefreshWarehouseList()
        {
            lstWarehouse.Items.Clear();
            foreach (var pkg in frmFleetDashboard.Warehouse) lstWarehouse.Items.Add(GetPackageDisplayName(pkg));
        }

        private void RefreshVehicleCargoList()
        {
            lstVehicleCargo.Items.Clear();
            foreach (var pkg in selectedVehicle.LoadedPackages) lstVehicleCargo.Items.Add(GetPackageDisplayName(pkg));
        }

        private void UpdateCargoDisplay()
        {
            lblCurrentWeight.Text = $"{selectedVehicle.CurrentWeightLoad}kg";
            lblMaxWeight.Text = $"{selectedVehicle.MaxCapacity}kg";

            lblCurrentSize.Text = $"{selectedVehicle.CurrentSizeLoad} cm³";
            lblMaxSize.Text = $"{selectedVehicle.VehicleSize}cm³";
            double weightPercent = (selectedVehicle.CurrentWeightLoad / selectedVehicle.MaxCapacity) * 100;
            double SizePercent = (selectedVehicle.CurrentSizeLoad / selectedVehicle.VehicleSize) * 100;

            label6.Text = $"({(int)weightPercent}%)";
            prgCapacity.Value = (int)Math.Min(weightPercent, 100);

            label5.Text = $"({(int)SizePercent}%)";
            prgSize.Value = (int)Math.Min(SizePercent, 100);
        }

        // Attempting to add cargo via overloaded operator [F-04]
        private void btnAddCargo_Click(object sender, EventArgs e)
        {
            if (lstWarehouse.SelectedIndex == -1) return;
            int index = lstWarehouse.SelectedIndex;
            Package selectedPkg = frmFleetDashboard.Warehouse[index];

            try
            {
                // Using the overloaded + operator [F-04]
                selectedVehicle = selectedVehicle + selectedPkg; 

                // Tracking the move for the cancel rollback logic
                sessionPackages.Add(selectedPkg);
                frmFleetDashboard.Warehouse.RemoveAt(index);

                RefreshVehicleCargoList();
                RefreshWarehouseList();
                UpdateCargoDisplay();
            }
            catch (InvalidOperationException ex)
            {
                // Catching weight violations [F-08]
                MessageBox.Show(ex.Message, "Weight Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveCargo_Click(object sender, EventArgs e)
        {
            if (lstVehicleCargo.SelectedIndex == -1) return;
            int index = lstVehicleCargo.SelectedIndex;
            Package pkgToRemove = selectedVehicle.LoadedPackages[index];

            // Reversing the loads manually and returning cargo to the top of the warehouse pool
            selectedVehicle.CurrentWeightLoad -= pkgToRemove.Weight;
            selectedVehicle.CurrentSizeLoad -= pkgToRemove.PackageSize;

            frmFleetDashboard.Warehouse.Insert(0, pkgToRemove);
            selectedVehicle.LoadedPackages.RemoveAt(index);

            RefreshVehicleCargoList();
            RefreshWarehouseList();
            UpdateCargoDisplay();
        }

        private void btnConfimCargo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Logic for cancelling changes and rolling back the session [F-08]
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Reverse loop to safely unload items added in this window
            for (int i = sessionPackages.Count - 1; i >= 0; i--)
            {
                Package pkg = sessionPackages[i];
                selectedVehicle.CurrentWeightLoad -= pkg.Weight;
                selectedVehicle.CurrentSizeLoad -= pkg.PackageSize;
                selectedVehicle.LoadedPackages.Remove(pkg);
                frmFleetDashboard.Warehouse.Add(pkg);
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void UpdateVehicleImage(Vehicle v)
        {
            picBike.Visible = v is ElectricBike;
            picDrone.Visible = v is Drone;
            picCar.Visible = v is ElectricCar;
            picVan.Visible = v is ElectricVan;
            picTruck.Visible = v is HeavydutyHydrogenTruck;
        }
    }
}
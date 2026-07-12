namespace OOP_Project_Jonathan_Alex_Abdin
{
    partial class frmManageCargo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageCargo));
            label1 = new Label();
            picBike = new PictureBox();
            picDrone = new PictureBox();
            picCar = new PictureBox();
            picVan = new PictureBox();
            picTruck = new PictureBox();
            lblVehicleDetails = new Label();
            label2 = new Label();
            lblCurrentWeight = new Label();
            label4 = new Label();
            lblMaxWeight = new Label();
            label6 = new Label();
            prgCapacity = new ProgressBar();
            groupBox1 = new GroupBox();
            lstWarehouse = new ListBox();
            groupBox2 = new GroupBox();
            lstVehicleCargo = new ListBox();
            btnAddCargo = new Button();
            btnRemoveCargo = new Button();
            btnConfimCargo = new Button();
            btnCancel = new Button();
            label3 = new Label();
            lblCurrentSize = new Label();
            label7 = new Label();
            lblMaxSize = new Label();
            label5 = new Label();
            prgSize = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)picBike).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDrone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTruck).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(298, 46);
            label1.TabIndex = 1;
            label1.Text = "Loading Cargo for:";
            // 
            // picBike
            // 
            picBike.BackColor = Color.White;
            picBike.BorderStyle = BorderStyle.Fixed3D;
            picBike.Image = (Image)resources.GetObject("picBike.Image");
            picBike.Location = new Point(34, 20);
            picBike.Margin = new Padding(2);
            picBike.Name = "picBike";
            picBike.Size = new Size(121, 121);
            picBike.SizeMode = PictureBoxSizeMode.Zoom;
            picBike.TabIndex = 2;
            picBike.TabStop = false;
            // 
            // picDrone
            // 
            picDrone.BackColor = Color.White;
            picDrone.BorderStyle = BorderStyle.Fixed3D;
            picDrone.Image = (Image)resources.GetObject("picDrone.Image");
            picDrone.Location = new Point(34, 20);
            picDrone.Margin = new Padding(2);
            picDrone.Name = "picDrone";
            picDrone.Size = new Size(121, 121);
            picDrone.SizeMode = PictureBoxSizeMode.Zoom;
            picDrone.TabIndex = 23;
            picDrone.TabStop = false;
            // 
            // picCar
            // 
            picCar.BackColor = Color.White;
            picCar.BorderStyle = BorderStyle.Fixed3D;
            picCar.Image = (Image)resources.GetObject("picCar.Image");
            picCar.Location = new Point(34, 20);
            picCar.Margin = new Padding(2);
            picCar.Name = "picCar";
            picCar.Size = new Size(121, 121);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
            picCar.TabIndex = 24;
            picCar.TabStop = false;
            // 
            // picVan
            // 
            picVan.BackColor = Color.White;
            picVan.BorderStyle = BorderStyle.Fixed3D;
            picVan.Image = (Image)resources.GetObject("picVan.Image");
            picVan.Location = new Point(34, 20);
            picVan.Margin = new Padding(2);
            picVan.Name = "picVan";
            picVan.Size = new Size(121, 121);
            picVan.SizeMode = PictureBoxSizeMode.Zoom;
            picVan.TabIndex = 25;
            picVan.TabStop = false;
            // 
            // picTruck
            // 
            picTruck.BackColor = Color.White;
            picTruck.BorderStyle = BorderStyle.Fixed3D;
            picTruck.Image = (Image)resources.GetObject("picTruck.Image");
            picTruck.Location = new Point(34, 20);
            picTruck.Margin = new Padding(2);
            picTruck.Name = "picTruck";
            picTruck.Size = new Size(121, 121);
            picTruck.SizeMode = PictureBoxSizeMode.Zoom;
            picTruck.TabIndex = 26;
            picTruck.TabStop = false;
            // 
            // lblVehicleDetails
            // 
            lblVehicleDetails.AutoSize = true;
            lblVehicleDetails.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleDetails.Location = new Point(487, 9);
            lblVehicleDetails.Margin = new Padding(2, 0, 2, 0);
            lblVehicleDetails.Name = "lblVehicleDetails";
            lblVehicleDetails.Size = new Size(177, 46);
            lblVehicleDetails.TabIndex = 27;
            lblVehicleDetails.Text = "[ Vehicle ]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(159, 55);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(210, 37);
            label2.TabIndex = 28;
            label2.Text = "Current Weight: ";
            // 
            // lblCurrentWeight
            // 
            lblCurrentWeight.AutoSize = true;
            lblCurrentWeight.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentWeight.Location = new Point(356, 55);
            lblCurrentWeight.Margin = new Padding(2, 0, 2, 0);
            lblCurrentWeight.Name = "lblCurrentWeight";
            lblCurrentWeight.Size = new Size(65, 37);
            lblCurrentWeight.TabIndex = 29;
            lblCurrentWeight.Text = "0kg";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(487, 55);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 37);
            label4.TabIndex = 30;
            label4.Text = " / Max: ";
            // 
            // lblMaxWeight
            // 
            lblMaxWeight.AutoSize = true;
            lblMaxWeight.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaxWeight.Location = new Point(582, 55);
            lblMaxWeight.Margin = new Padding(2, 0, 2, 0);
            lblMaxWeight.Name = "lblMaxWeight";
            lblMaxWeight.Size = new Size(65, 37);
            lblMaxWeight.TabIndex = 31;
            lblMaxWeight.Text = "0kg";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(724, 55);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 37);
            label6.TabIndex = 32;
            label6.Text = "(0%)";
            // 
            // prgCapacity
            // 
            prgCapacity.Location = new Point(827, 65);
            prgCapacity.Margin = new Padding(2);
            prgCapacity.Name = "prgCapacity";
            prgCapacity.Size = new Size(387, 27);
            prgCapacity.TabIndex = 33;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(210, 180, 222);
            groupBox1.Controls.Add(lstWarehouse);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(62, 167);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(471, 299);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Available Packages (Bulk Warehouse)";
            // 
            // lstWarehouse
            // 
            lstWarehouse.FormattingEnabled = true;
            lstWarehouse.Location = new Point(18, 38);
            lstWarehouse.Margin = new Padding(2);
            lstWarehouse.Name = "lstWarehouse";
            lstWarehouse.Size = new Size(434, 228);
            lstWarehouse.TabIndex = 35;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(210, 180, 222);
            groupBox2.Controls.Add(lstVehicleCargo);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(775, 167);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(439, 299);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Currently Loaded (Vehicle Inventory)";
            // 
            // lstVehicleCargo
            // 
            lstVehicleCargo.FormattingEnabled = true;
            lstVehicleCargo.Location = new Point(16, 38);
            lstVehicleCargo.Margin = new Padding(2);
            lstVehicleCargo.Name = "lstVehicleCargo";
            lstVehicleCargo.Size = new Size(404, 228);
            lstVehicleCargo.TabIndex = 35;
            // 
            // btnAddCargo
            // 
            btnAddCargo.BackColor = Color.FromArgb(155, 89, 182);
            btnAddCargo.FlatStyle = FlatStyle.Popup;
            btnAddCargo.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btnAddCargo.Location = new Point(554, 219);
            btnAddCargo.Margin = new Padding(2);
            btnAddCargo.Name = "btnAddCargo";
            btnAddCargo.Size = new Size(201, 86);
            btnAddCargo.TabIndex = 37;
            btnAddCargo.Text = ">";
            btnAddCargo.UseVisualStyleBackColor = false;
            btnAddCargo.Click += btnAddCargo_Click;
            // 
            // btnRemoveCargo
            // 
            btnRemoveCargo.BackColor = Color.FromArgb(155, 89, 182);
            btnRemoveCargo.FlatStyle = FlatStyle.Popup;
            btnRemoveCargo.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btnRemoveCargo.Location = new Point(554, 330);
            btnRemoveCargo.Margin = new Padding(2);
            btnRemoveCargo.Name = "btnRemoveCargo";
            btnRemoveCargo.Size = new Size(201, 86);
            btnRemoveCargo.TabIndex = 38;
            btnRemoveCargo.Text = "<";
            btnRemoveCargo.UseVisualStyleBackColor = false;
            btnRemoveCargo.Click += btnRemoveCargo_Click;
            // 
            // btnConfimCargo
            // 
            btnConfimCargo.BackColor = Color.FromArgb(155, 89, 182);
            btnConfimCargo.FlatStyle = FlatStyle.Popup;
            btnConfimCargo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfimCargo.Location = new Point(80, 486);
            btnConfimCargo.Margin = new Padding(2);
            btnConfimCargo.Name = "btnConfimCargo";
            btnConfimCargo.Size = new Size(661, 71);
            btnConfimCargo.TabIndex = 39;
            btnConfimCargo.Text = "[Confirm && Update Fleet]";
            btnConfimCargo.UseVisualStyleBackColor = false;
            btnConfimCargo.Click += btnConfimCargo_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(213, 216, 220);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(894, 486);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(301, 71);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "[Cancel && Close]";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(159, 104);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 37);
            label3.TabIndex = 41;
            label3.Text = "Current Size: ";
            // 
            // lblCurrentSize
            // 
            lblCurrentSize.AutoSize = true;
            lblCurrentSize.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentSize.Location = new Point(356, 114);
            lblCurrentSize.Margin = new Padding(2, 0, 2, 0);
            lblCurrentSize.Name = "lblCurrentSize";
            lblCurrentSize.Size = new Size(82, 37);
            lblCurrentSize.TabIndex = 42;
            lblCurrentSize.Text = "0cm³";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(487, 114);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 37);
            label7.TabIndex = 43;
            label7.Text = " / Max: ";
            // 
            // lblMaxSize
            // 
            lblMaxSize.AutoSize = true;
            lblMaxSize.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaxSize.Location = new Point(582, 114);
            lblMaxSize.Margin = new Padding(2, 0, 2, 0);
            lblMaxSize.Name = "lblMaxSize";
            lblMaxSize.Size = new Size(82, 37);
            lblMaxSize.TabIndex = 44;
            lblMaxSize.Text = "0cm³";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(724, 114);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 37);
            label5.TabIndex = 45;
            label5.Text = "(0%)";
            // 
            // prgSize
            // 
            prgSize.Location = new Point(827, 124);
            prgSize.Margin = new Padding(2);
            prgSize.Name = "prgSize";
            prgSize.Size = new Size(387, 27);
            prgSize.TabIndex = 46;
            // 
            // frmManageCargo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 180, 222);
            ClientSize = new Size(1275, 582);
            Controls.Add(prgSize);
            Controls.Add(label5);
            Controls.Add(lblMaxSize);
            Controls.Add(label7);
            Controls.Add(lblCurrentSize);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnConfimCargo);
            Controls.Add(btnRemoveCargo);
            Controls.Add(btnAddCargo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(prgCapacity);
            Controls.Add(label6);
            Controls.Add(lblMaxWeight);
            Controls.Add(label4);
            Controls.Add(lblCurrentWeight);
            Controls.Add(label2);
            Controls.Add(lblVehicleDetails);
            Controls.Add(label1);
            Controls.Add(picBike);
            Controls.Add(picDrone);
            Controls.Add(picCar);
            Controls.Add(picVan);
            Controls.Add(picTruck);
            Margin = new Padding(2);
            Name = "frmManageCargo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargo Loading Management - EcoLink Hub";
            Load += frmManageCargo_Load;
            ((System.ComponentModel.ISupportInitialize)picBike).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDrone).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVan).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTruck).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox picBike;
        private PictureBox picDrone;
        private PictureBox picCar;
        private PictureBox picVan;
        private PictureBox picTruck;
        private Label lblVehicleDetails;
        private Label label2;
        private Label lblCurrentWeight;
        private Label label4;
        private Label lblMaxWeight;
        private Label label6;
        private ProgressBar prgCapacity;
        private GroupBox groupBox1;
        private ListBox lstWarehouse;
        private GroupBox groupBox2;
        private ListBox lstVehicleCargo;
        private Button btnAddCargo;
        private Button btnRemoveCargo;
        private Button btnConfimCargo;
        private Button btnCancel;
        private Label label3;
        private Label lblCurrentSize;
        private Label label7;
        private Label lblMaxSize;
        private Label label5;
        private ProgressBar prgSize;
    }
}
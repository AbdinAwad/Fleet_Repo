namespace OOP_Project_Jonathan_Alex_Abdin
{
    partial class frmFleetDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFleetDashboard));
            grpRegistration = new GroupBox();
            radTruck = new RadioButton();
            radVan = new RadioButton();
            radCar = new RadioButton();
            radDrone = new RadioButton();
            radBike = new RadioButton();
            lblgrpBack = new Label();
            btnRegister = new Button();
            btnAssignDriver = new Button();
            btnManageCargo = new Button();
            btnRemoveVehicle = new Button();
            btnExit = new Button();
            lstFleet = new ListBox();
            label1 = new Label();
            lblTotalCount = new Label();
            grpVehicleDetails = new GroupBox();
            lblDisplaySize = new Label();
            label10 = new Label();
            lblFuelStatus = new Label();
            lblFuelPercent = new Label();
            lblDisplayMaxPayload = new Label();
            label2 = new Label();
            label9 = new Label();
            lblFuelStatusBack = new Label();
            lblDisplayFuelType = new Label();
            lblDisplayPayload = new Label();
            lblDisplayDriver = new Label();
            lblDisplayType = new Label();
            lblDisplayID = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            picBike = new PictureBox();
            picDrone = new PictureBox();
            picCar = new PictureBox();
            picVan = new PictureBox();
            picTruck = new PictureBox();
            btnManageFuel = new Button();
            grpRegistration.SuspendLayout();
            grpVehicleDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBike).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDrone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTruck).BeginInit();
            SuspendLayout();
            // 
            // grpRegistration
            // 
            grpRegistration.Controls.Add(radTruck);
            grpRegistration.Controls.Add(radVan);
            grpRegistration.Controls.Add(radCar);
            grpRegistration.Controls.Add(radDrone);
            grpRegistration.Controls.Add(radBike);
            grpRegistration.ForeColor = Color.Black;
            grpRegistration.Location = new Point(47, 61);
            grpRegistration.Margin = new Padding(2);
            grpRegistration.Name = "grpRegistration";
            grpRegistration.Padding = new Padding(2);
            grpRegistration.Size = new Size(336, 300);
            grpRegistration.TabIndex = 1;
            grpRegistration.TabStop = false;
            grpRegistration.Text = "Register New Vehicle";
            // 
            // radTruck
            // 
            radTruck.AutoSize = true;
            radTruck.Location = new Point(37, 234);
            radTruck.Margin = new Padding(2);
            radTruck.Name = "radTruck";
            radTruck.Size = new Size(288, 24);
            radTruck.TabIndex = 0;
            radTruck.Text = "Heavy-Duty Hydrogen Truck (Prefix: T-)";
            radTruck.UseVisualStyleBackColor = true;
            // 
            // radVan
            // 
            radVan.AutoSize = true;
            radVan.Location = new Point(37, 190);
            radVan.Margin = new Padding(2);
            radVan.Name = "radVan";
            radVan.Size = new Size(179, 24);
            radVan.TabIndex = 0;
            radVan.Text = "Electric Van (Prefix: V-)";
            radVan.UseVisualStyleBackColor = true;
            // 
            // radCar
            // 
            radCar.AutoSize = true;
            radCar.Location = new Point(37, 146);
            radCar.Margin = new Padding(2);
            radCar.Name = "radCar";
            radCar.Size = new Size(177, 24);
            radCar.TabIndex = 0;
            radCar.Text = "Electric Car (Prefix: C-)";
            radCar.UseVisualStyleBackColor = true;
            // 
            // radDrone
            // 
            radDrone.AutoSize = true;
            radDrone.Location = new Point(37, 102);
            radDrone.Margin = new Padding(2);
            radDrone.Name = "radDrone";
            radDrone.Size = new Size(143, 24);
            radDrone.TabIndex = 0;
            radDrone.Text = "Drone (Prefix D-)";
            radDrone.UseVisualStyleBackColor = true;
            // 
            // radBike
            // 
            radBike.AutoSize = true;
            radBike.Checked = true;
            radBike.Location = new Point(37, 58);
            radBike.Margin = new Padding(2);
            radBike.Name = "radBike";
            radBike.Size = new Size(183, 24);
            radBike.TabIndex = 0;
            radBike.TabStop = true;
            radBike.Text = "Electric Bike (Prefix: B-)";
            radBike.UseVisualStyleBackColor = true;
            // 
            // lblgrpBack
            // 
            lblgrpBack.BorderStyle = BorderStyle.Fixed3D;
            lblgrpBack.Enabled = false;
            lblgrpBack.ForeColor = Color.FromArgb(45, 62, 80);
            lblgrpBack.Location = new Point(27, 29);
            lblgrpBack.Margin = new Padding(2, 0, 2, 0);
            lblgrpBack.Name = "lblgrpBack";
            lblgrpBack.Size = new Size(380, 445);
            lblgrpBack.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(39, 174, 96);
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(115, 397);
            btnRegister.Margin = new Padding(2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(189, 52);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "[&Register && Generate ID]";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnAssignDriver
            // 
            btnAssignDriver.BackColor = Color.FromArgb(52, 152, 219);
            btnAssignDriver.FlatStyle = FlatStyle.Popup;
            btnAssignDriver.ForeColor = Color.Black;
            btnAssignDriver.Location = new Point(61, 489);
            btnAssignDriver.Margin = new Padding(2);
            btnAssignDriver.Name = "btnAssignDriver";
            btnAssignDriver.Size = new Size(168, 52);
            btnAssignDriver.TabIndex = 3;
            btnAssignDriver.Text = "[Assign/Change &Driver]";
            btnAssignDriver.UseVisualStyleBackColor = false;
            btnAssignDriver.Click += btnAssignDriver_Click;
            // 
            // btnManageCargo
            // 
            btnManageCargo.BackColor = Color.FromArgb(155, 89, 182);
            btnManageCargo.FlatStyle = FlatStyle.Popup;
            btnManageCargo.ForeColor = Color.Black;
            btnManageCargo.Location = new Point(260, 489);
            btnManageCargo.Margin = new Padding(2);
            btnManageCargo.Name = "btnManageCargo";
            btnManageCargo.Size = new Size(168, 52);
            btnManageCargo.TabIndex = 4;
            btnManageCargo.Text = "[Manage &Cargo]";
            btnManageCargo.UseVisualStyleBackColor = false;
            btnManageCargo.Click += btnManageCargo_Click;
            // 
            // btnRemoveVehicle
            // 
            btnRemoveVehicle.BackColor = Color.FromArgb(192, 57, 43);
            btnRemoveVehicle.FlatStyle = FlatStyle.Popup;
            btnRemoveVehicle.ForeColor = Color.Black;
            btnRemoveVehicle.Location = new Point(463, 489);
            btnRemoveVehicle.Margin = new Padding(2);
            btnRemoveVehicle.Name = "btnRemoveVehicle";
            btnRemoveVehicle.Size = new Size(168, 52);
            btnRemoveVehicle.TabIndex = 5;
            btnRemoveVehicle.Text = "[Remove &Vehicle]";
            btnRemoveVehicle.UseVisualStyleBackColor = false;
            btnRemoveVehicle.Click += btnRemoveVehicle_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(127, 140, 141);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(875, 489);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(168, 52);
            btnExit.TabIndex = 7;
            btnExit.Text = "[&Exit Program]";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lstFleet
            // 
            lstFleet.ForeColor = Color.Black;
            lstFleet.FormattingEnabled = true;
            lstFleet.Location = new Point(463, 61);
            lstFleet.Margin = new Padding(2);
            lstFleet.Name = "lstFleet";
            lstFleet.Size = new Size(154, 324);
            lstFleet.TabIndex = 8;
            lstFleet.SelectedIndexChanged += lstFleet_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(435, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 0;
            label1.Text = "Registered Fleet (Vehicle ID's)";
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCount.ForeColor = Color.Black;
            lblTotalCount.Location = new Point(487, 394);
            lblTotalCount.Margin = new Padding(2, 0, 2, 0);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(121, 20);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "Total Vehicles: 0";
            // 
            // grpVehicleDetails
            // 
            grpVehicleDetails.Controls.Add(lblDisplaySize);
            grpVehicleDetails.Controls.Add(label10);
            grpVehicleDetails.Controls.Add(lblFuelStatus);
            grpVehicleDetails.Controls.Add(lblFuelPercent);
            grpVehicleDetails.Controls.Add(lblDisplayMaxPayload);
            grpVehicleDetails.Controls.Add(label2);
            grpVehicleDetails.Controls.Add(label9);
            grpVehicleDetails.Controls.Add(lblFuelStatusBack);
            grpVehicleDetails.Controls.Add(lblDisplayFuelType);
            grpVehicleDetails.Controls.Add(lblDisplayPayload);
            grpVehicleDetails.Controls.Add(lblDisplayDriver);
            grpVehicleDetails.Controls.Add(lblDisplayType);
            grpVehicleDetails.Controls.Add(lblDisplayID);
            grpVehicleDetails.Controls.Add(label8);
            grpVehicleDetails.Controls.Add(label7);
            grpVehicleDetails.Controls.Add(label6);
            grpVehicleDetails.Controls.Add(label5);
            grpVehicleDetails.Controls.Add(label4);
            grpVehicleDetails.Controls.Add(label3);
            grpVehicleDetails.Controls.Add(picBike);
            grpVehicleDetails.Controls.Add(picDrone);
            grpVehicleDetails.Controls.Add(picCar);
            grpVehicleDetails.Controls.Add(picVan);
            grpVehicleDetails.Controls.Add(picTruck);
            grpVehicleDetails.ForeColor = Color.Black;
            grpVehicleDetails.Location = new Point(677, 46);
            grpVehicleDetails.Margin = new Padding(2);
            grpVehicleDetails.Name = "grpVehicleDetails";
            grpVehicleDetails.Padding = new Padding(2);
            grpVehicleDetails.Size = new Size(375, 428);
            grpVehicleDetails.TabIndex = 0;
            grpVehicleDetails.TabStop = false;
            grpVehicleDetails.Text = "Selected Vehicle Details";
            // 
            // lblDisplaySize
            // 
            lblDisplaySize.AutoSize = true;
            lblDisplaySize.Location = new Point(150, 308);
            lblDisplaySize.Margin = new Padding(2, 0, 2, 0);
            lblDisplaySize.Name = "lblDisplaySize";
            lblDisplaySize.Size = new Size(55, 20);
            lblDisplaySize.TabIndex = 26;
            lblDisplaySize.Text = "[HERE]";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 308);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 0;
            label10.Text = "Size:";
            // 
            // lblFuelStatus
            // 
            lblFuelStatus.AutoSize = true;
            lblFuelStatus.BackColor = Color.White;
            lblFuelStatus.Location = new Point(174, 383);
            lblFuelStatus.Margin = new Padding(2, 0, 2, 0);
            lblFuelStatus.Name = "lblFuelStatus";
            lblFuelStatus.Size = new Size(55, 20);
            lblFuelStatus.TabIndex = 0;
            lblFuelStatus.Text = "[HERE]";
            // 
            // lblFuelPercent
            // 
            lblFuelPercent.AutoSize = true;
            lblFuelPercent.BackColor = Color.White;
            lblFuelPercent.Location = new Point(115, 383);
            lblFuelPercent.Margin = new Padding(2, 0, 2, 0);
            lblFuelPercent.Name = "lblFuelPercent";
            lblFuelPercent.Size = new Size(55, 20);
            lblFuelPercent.TabIndex = 0;
            lblFuelPercent.Text = "[HERE]";
            // 
            // lblDisplayMaxPayload
            // 
            lblDisplayMaxPayload.AutoSize = true;
            lblDisplayMaxPayload.Location = new Point(211, 70);
            lblDisplayMaxPayload.Margin = new Padding(2, 0, 2, 0);
            lblDisplayMaxPayload.Name = "lblDisplayMaxPayload";
            lblDisplayMaxPayload.Size = new Size(55, 20);
            lblDisplayMaxPayload.TabIndex = 0;
            lblDisplayMaxPayload.Text = "[HERE]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 0;
            label2.Text = "Max Payload:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(18, 383);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 0;
            label9.Text = "FUEL STATUS: ";
            // 
            // lblFuelStatusBack
            // 
            lblFuelStatusBack.BackColor = Color.White;
            lblFuelStatusBack.BorderStyle = BorderStyle.Fixed3D;
            lblFuelStatusBack.Enabled = false;
            lblFuelStatusBack.Location = new Point(7, 378);
            lblFuelStatusBack.Margin = new Padding(2, 0, 2, 0);
            lblFuelStatusBack.Name = "lblFuelStatusBack";
            lblFuelStatusBack.Size = new Size(359, 45);
            lblFuelStatusBack.TabIndex = 9;
            // 
            // lblDisplayFuelType
            // 
            lblDisplayFuelType.AutoSize = true;
            lblDisplayFuelType.Location = new Point(150, 344);
            lblDisplayFuelType.Margin = new Padding(2, 0, 2, 0);
            lblDisplayFuelType.Name = "lblDisplayFuelType";
            lblDisplayFuelType.Size = new Size(55, 20);
            lblDisplayFuelType.TabIndex = 0;
            lblDisplayFuelType.Text = "[HERE]";
            // 
            // lblDisplayPayload
            // 
            lblDisplayPayload.AutoSize = true;
            lblDisplayPayload.Location = new Point(150, 277);
            lblDisplayPayload.Margin = new Padding(2, 0, 2, 0);
            lblDisplayPayload.Name = "lblDisplayPayload";
            lblDisplayPayload.Size = new Size(55, 20);
            lblDisplayPayload.TabIndex = 0;
            lblDisplayPayload.Text = "[HERE]";
            // 
            // lblDisplayDriver
            // 
            lblDisplayDriver.AutoSize = true;
            lblDisplayDriver.Location = new Point(150, 245);
            lblDisplayDriver.Margin = new Padding(2, 0, 2, 0);
            lblDisplayDriver.Name = "lblDisplayDriver";
            lblDisplayDriver.Size = new Size(55, 20);
            lblDisplayDriver.TabIndex = 0;
            lblDisplayDriver.Text = "[HERE]";
            // 
            // lblDisplayType
            // 
            lblDisplayType.AutoSize = true;
            lblDisplayType.Location = new Point(150, 213);
            lblDisplayType.Margin = new Padding(2, 0, 2, 0);
            lblDisplayType.Name = "lblDisplayType";
            lblDisplayType.Size = new Size(55, 20);
            lblDisplayType.TabIndex = 0;
            lblDisplayType.Text = "[HERE]";
            // 
            // lblDisplayID
            // 
            lblDisplayID.AutoSize = true;
            lblDisplayID.Location = new Point(150, 181);
            lblDisplayID.Margin = new Padding(2, 0, 2, 0);
            lblDisplayID.Name = "lblDisplayID";
            lblDisplayID.Size = new Size(55, 20);
            lblDisplayID.TabIndex = 0;
            lblDisplayID.Text = "[HERE]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 344);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 0;
            label8.Text = "Fuel Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 277);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 0;
            label7.Text = "Payload:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 245);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 0;
            label6.Text = "Assigned Driver:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 213);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 0;
            label5.Text = "Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 181);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 0;
            label4.Text = "ID:";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Enabled = false;
            label3.Location = new Point(0, 158);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(375, 10);
            label3.TabIndex = 0;
            // 
            // picBike
            // 
            picBike.BackColor = Color.White;
            picBike.BorderStyle = BorderStyle.Fixed3D;
            picBike.Image = (Image)resources.GetObject("picBike.Image");
            picBike.Location = new Point(18, 32);
            picBike.Margin = new Padding(2);
            picBike.Name = "picBike";
            picBike.Size = new Size(121, 121);
            picBike.SizeMode = PictureBoxSizeMode.Zoom;
            picBike.TabIndex = 0;
            picBike.TabStop = false;
            // 
            // picDrone
            // 
            picDrone.BackColor = Color.White;
            picDrone.BorderStyle = BorderStyle.Fixed3D;
            picDrone.Image = (Image)resources.GetObject("picDrone.Image");
            picDrone.Location = new Point(18, 32);
            picDrone.Margin = new Padding(2);
            picDrone.Name = "picDrone";
            picDrone.Size = new Size(121, 121);
            picDrone.SizeMode = PictureBoxSizeMode.Zoom;
            picDrone.TabIndex = 22;
            picDrone.TabStop = false;
            // 
            // picCar
            // 
            picCar.BackColor = Color.White;
            picCar.BorderStyle = BorderStyle.Fixed3D;
            picCar.Image = (Image)resources.GetObject("picCar.Image");
            picCar.Location = new Point(18, 32);
            picCar.Margin = new Padding(2);
            picCar.Name = "picCar";
            picCar.Size = new Size(121, 121);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
            picCar.TabIndex = 23;
            picCar.TabStop = false;
            // 
            // picVan
            // 
            picVan.BackColor = Color.White;
            picVan.BorderStyle = BorderStyle.Fixed3D;
            picVan.Image = (Image)resources.GetObject("picVan.Image");
            picVan.Location = new Point(18, 32);
            picVan.Margin = new Padding(2);
            picVan.Name = "picVan";
            picVan.Size = new Size(121, 121);
            picVan.SizeMode = PictureBoxSizeMode.Zoom;
            picVan.TabIndex = 24;
            picVan.TabStop = false;
            // 
            // picTruck
            // 
            picTruck.BackColor = Color.White;
            picTruck.BorderStyle = BorderStyle.Fixed3D;
            picTruck.Image = (Image)resources.GetObject("picTruck.Image");
            picTruck.Location = new Point(18, 32);
            picTruck.Margin = new Padding(2);
            picTruck.Name = "picTruck";
            picTruck.Size = new Size(121, 121);
            picTruck.SizeMode = PictureBoxSizeMode.Zoom;
            picTruck.TabIndex = 25;
            picTruck.TabStop = false;
            // 
            // btnManageFuel
            // 
            btnManageFuel.BackColor = Color.FromArgb(243, 156, 18);
            btnManageFuel.FlatStyle = FlatStyle.Popup;
            btnManageFuel.ForeColor = Color.Black;
            btnManageFuel.Location = new Point(666, 489);
            btnManageFuel.Margin = new Padding(2);
            btnManageFuel.Name = "btnManageFuel";
            btnManageFuel.Size = new Size(168, 52);
            btnManageFuel.TabIndex = 6;
            btnManageFuel.Text = "[Manage &Fuel/Battery]";
            btnManageFuel.UseVisualStyleBackColor = false;
            btnManageFuel.Click += btnManageFuel_Click;
            // 
            // frmFleetDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 245, 233);
            ClientSize = new Size(1068, 552);
            Controls.Add(btnManageFuel);
            Controls.Add(grpVehicleDetails);
            Controls.Add(lblTotalCount);
            Controls.Add(label1);
            Controls.Add(lstFleet);
            Controls.Add(btnExit);
            Controls.Add(btnRemoveVehicle);
            Controls.Add(btnManageCargo);
            Controls.Add(btnAssignDriver);
            Controls.Add(btnRegister);
            Controls.Add(grpRegistration);
            Controls.Add(lblgrpBack);
            ForeColor = Color.Black;
            Margin = new Padding(2);
            Name = "frmFleetDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EcoLink: Operations Command";
            FormClosing += frmFleetDashboard_FormClosing;
            Load += Form1_Load;
            grpRegistration.ResumeLayout(false);
            grpRegistration.PerformLayout();
            grpVehicleDetails.ResumeLayout(false);
            grpVehicleDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBike).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDrone).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVan).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTruck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpRegistration;
        private RadioButton radTruck;
        private RadioButton radVan;
        private RadioButton radCar;
        private RadioButton radDrone;
        private RadioButton radBike;
        private Label lblgrpBack;
        private Button btnRegister;
        private Button btnAssignDriver;
        private Button btnManageCargo;
        private Button btnRemoveVehicle;
        private Button btnExit;
        private ListBox lstFleet;
        private Label label1;
        private Label lblTotalCount;
        private GroupBox grpVehicleDetails;
        private PictureBox picBike;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label lblDisplayFuelType;
        private Label lblDisplayPayload;
        private Label lblDisplayDriver;
        private Label lblDisplayType;
        private Label lblDisplayID;
        private Button btnManageFuel;
        private Label lblFuelStatusBack;
        private Label label9;
        private Label label2;
        private PictureBox picDrone;
        private PictureBox picCar;
        private PictureBox picVan;
        private PictureBox picTruck;
        private Label lblDisplayMaxPayload;
        private Label lblFuelStatus;
        private Label lblFuelPercent;
        private Label lblDisplaySize;
        private Label label10;
    }
}

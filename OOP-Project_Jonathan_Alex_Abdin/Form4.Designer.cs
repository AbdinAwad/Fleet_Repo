namespace OOP_Project_Jonathan_Alex_Abdin
{
    partial class frmManageFuel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageFuel));
            label1 = new Label();
            lblVehicleID = new Label();
            label2 = new Label();
            picEnergyIcon = new PictureBox();
            picHydrogenIcon = new PictureBox();
            lblStatus = new Label();
            prgEnergryLevel = new ProgressBar();
            lblPercent = new Label();
            grpRefill = new GroupBox();
            nudAmount = new NumericUpDown();
            label3 = new Label();
            btnRefill = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)picEnergyIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHydrogenIcon).BeginInit();
            grpRefill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 42);
            label1.Name = "label1";
            label1.Size = new Size(203, 54);
            label1.TabIndex = 2;
            label1.Text = "Servicing: ";
            // 
            // lblVehicleID
            // 
            lblVehicleID.AutoSize = true;
            lblVehicleID.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleID.Location = new Point(243, 42);
            lblVehicleID.Name = "lblVehicleID";
            lblVehicleID.Size = new Size(262, 54);
            lblVehicleID.TabIndex = 3;
            lblVehicleID.Text = "[ Vehicle ID ]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(529, 42);
            label2.Name = "label2";
            label2.Size = new Size(405, 54);
            label2.TabIndex = 4;
            label2.Text = "Electric Charging Port";
            // 
            // picEnergyIcon
            // 
            picEnergyIcon.BackColor = Color.FromArgb(252, 236, 197);
            picEnergyIcon.Image = (Image)resources.GetObject("picEnergyIcon.Image");
            picEnergyIcon.Location = new Point(1082, 12);
            picEnergyIcon.Name = "picEnergyIcon";
            picEnergyIcon.Size = new Size(150, 150);
            picEnergyIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picEnergyIcon.TabIndex = 5;
            picEnergyIcon.TabStop = false;
            // 
            // picHydrogenIcon
            // 
            picHydrogenIcon.BackColor = Color.FromArgb(252, 236, 197);
            picHydrogenIcon.Image = (Image)resources.GetObject("picHydrogenIcon.Image");
            picHydrogenIcon.Location = new Point(1082, 12);
            picHydrogenIcon.Name = "picHydrogenIcon";
            picHydrogenIcon.Size = new Size(150, 150);
            picHydrogenIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picHydrogenIcon.TabIndex = 6;
            picHydrogenIcon.TabStop = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(146, 185);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(489, 54);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Current Fuel/Energy Level:";
            // 
            // prgEnergryLevel
            // 
            prgEnergryLevel.Location = new Point(146, 247);
            prgEnergryLevel.Name = "prgEnergryLevel";
            prgEnergryLevel.Size = new Size(588, 34);
            prgEnergryLevel.TabIndex = 8;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercent.Location = new Point(774, 185);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(160, 96);
            lblPercent.TabIndex = 9;
            lblPercent.Text = "--%";
            // 
            // grpRefill
            // 
            grpRefill.Controls.Add(nudAmount);
            grpRefill.Controls.Add(label3);
            grpRefill.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpRefill.Location = new Point(146, 347);
            grpRefill.Name = "grpRefill";
            grpRefill.Size = new Size(788, 210);
            grpRefill.TabIndex = 10;
            grpRefill.TabStop = false;
            grpRefill.Text = "Transfer Fuel/Energy";
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(391, 99);
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(357, 55);
            nudAmount.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 104);
            label3.Name = "label3";
            label3.Size = new Size(304, 45);
            label3.TabIndex = 11;
            label3.Text = "Amount to Add (%):";
            // 
            // btnRefill
            // 
            btnRefill.BackColor = Color.FromArgb(243, 156, 18);
            btnRefill.FlatStyle = FlatStyle.Popup;
            btnRefill.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefill.Location = new Point(146, 577);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(375, 90);
            btnRefill.TabIndex = 11;
            btnRefill.Text = "Initiate Transfer";
            btnRefill.UseVisualStyleBackColor = false;
            btnRefill.Click += btnRefill_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(213, 216, 220);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCancel.Location = new Point(559, 577);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(375, 90);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Disconnect && Close";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmManageFuel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 236, 197);
            ClientSize = new Size(1251, 742);
            Controls.Add(btnCancel);
            Controls.Add(btnRefill);
            Controls.Add(grpRefill);
            Controls.Add(lblPercent);
            Controls.Add(prgEnergryLevel);
            Controls.Add(lblStatus);
            Controls.Add(label2);
            Controls.Add(lblVehicleID);
            Controls.Add(label1);
            Controls.Add(picEnergyIcon);
            Controls.Add(picHydrogenIcon);
            Name = "frmManageFuel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Energy & Refueling Command - EcoLink Hub";
            Load += frmManageFuel_Load;
            ((System.ComponentModel.ISupportInitialize)picEnergyIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHydrogenIcon).EndInit();
            grpRefill.ResumeLayout(false);
            grpRefill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblVehicleID;
        private Label label2;
        private PictureBox picEnergyIcon;
        private PictureBox picHydrogenIcon;
        private Label lblStatus;
        private ProgressBar prgEnergryLevel;
        private Label lblPercent;
        private GroupBox grpRefill;
        private NumericUpDown nudAmount;
        private Label label3;
        private Button btnRefill;
        private Button btnCancel;
    }
}
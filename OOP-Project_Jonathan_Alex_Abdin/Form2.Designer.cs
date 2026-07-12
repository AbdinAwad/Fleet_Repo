namespace OOP_Project_Jonathan_Alex_Abdin
{
    partial class frmAssignDriver
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
            label1 = new Label();
            lblVehicleDetails = new Label();
            label2 = new Label();
            lblDriverSelection = new Label();
            grpDriverSelection = new GroupBox();
            txtDriverName = new TextBox();
            label4 = new Label();
            btnRemoveDriver = new Button();
            btnAddDriver = new Button();
            cboDrivers = new ComboBox();
            label3 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            grpDriverSelection.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(320, 46);
            label1.TabIndex = 0;
            label1.Text = "Assigning Driver to: ";
            // 
            // lblVehicleDetails
            // 
            lblVehicleDetails.AutoSize = true;
            lblVehicleDetails.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleDetails.Location = new Point(349, 38);
            lblVehicleDetails.Margin = new Padding(2, 0, 2, 0);
            lblVehicleDetails.Name = "lblVehicleDetails";
            lblVehicleDetails.Size = new Size(177, 46);
            lblVehicleDetails.TabIndex = 0;
            lblVehicleDetails.Text = "[ Vehicle ]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(148, 92);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(196, 37);
            label2.TabIndex = 0;
            label2.Text = "Current Driver: ";
            // 
            // lblDriverSelection
            // 
            lblDriverSelection.AutoSize = true;
            lblDriverSelection.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDriverSelection.Location = new Point(341, 92);
            lblDriverSelection.Margin = new Padding(2, 0, 2, 0);
            lblDriverSelection.Name = "lblDriverSelection";
            lblDriverSelection.Size = new Size(82, 37);
            lblDriverSelection.TabIndex = 0;
            lblDriverSelection.Text = "None";
            // 
            // grpDriverSelection
            // 
            grpDriverSelection.Controls.Add(txtDriverName);
            grpDriverSelection.Controls.Add(label4);
            grpDriverSelection.Controls.Add(btnRemoveDriver);
            grpDriverSelection.Controls.Add(btnAddDriver);
            grpDriverSelection.Controls.Add(cboDrivers);
            grpDriverSelection.Controls.Add(label3);
            grpDriverSelection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDriverSelection.ForeColor = SystemColors.ControlText;
            grpDriverSelection.Location = new Point(11, 142);
            grpDriverSelection.Margin = new Padding(2);
            grpDriverSelection.Name = "grpDriverSelection";
            grpDriverSelection.Padding = new Padding(2);
            grpDriverSelection.Size = new Size(515, 219);
            grpDriverSelection.TabIndex = 3;
            grpDriverSelection.TabStop = false;
            grpDriverSelection.Text = "Driver Selection";
            // 
            // txtDriverName
            // 
            txtDriverName.Location = new Point(172, 108);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(332, 34);
            txtDriverName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 111);
            label4.Name = "label4";
            label4.Size = new Size(126, 28);
            label4.TabIndex = 3;
            label4.Text = "Driver Name:";
            // 
            // btnRemoveDriver
            // 
            btnRemoveDriver.BackColor = Color.FromArgb(192, 0, 0);
            btnRemoveDriver.FlatAppearance.BorderColor = Color.Black;
            btnRemoveDriver.FlatStyle = FlatStyle.Flat;
            btnRemoveDriver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRemoveDriver.ForeColor = SystemColors.ButtonHighlight;
            btnRemoveDriver.Location = new Point(280, 151);
            btnRemoveDriver.Name = "btnRemoveDriver";
            btnRemoveDriver.Size = new Size(224, 63);
            btnRemoveDriver.TabIndex = 2;
            btnRemoveDriver.Text = "[Remove Driver]";
            btnRemoveDriver.UseVisualStyleBackColor = false;
            btnRemoveDriver.Click += btnRemoveDriver_Click;
            // 
            // btnAddDriver
            // 
            btnAddDriver.BackColor = Color.FromArgb(0, 192, 0);
            btnAddDriver.FlatAppearance.BorderColor = Color.Black;
            btnAddDriver.FlatStyle = FlatStyle.Flat;
            btnAddDriver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddDriver.ForeColor = SystemColors.ButtonHighlight;
            btnAddDriver.Location = new Point(14, 151);
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.Size = new Size(224, 63);
            btnAddDriver.TabIndex = 1;
            btnAddDriver.Text = "[Add Driver]";
            btnAddDriver.UseVisualStyleBackColor = false;
            btnAddDriver.Click += btnAddDriver_Click;
            // 
            // cboDrivers
            // 
            cboDrivers.BackColor = Color.White;
            cboDrivers.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDrivers.FormattingEnabled = true;
            cboDrivers.Location = new Point(5, 66);
            cboDrivers.Margin = new Padding(2);
            cboDrivers.Name = "cboDrivers";
            cboDrivers.Size = new Size(499, 28);
            cboDrivers.TabIndex = 0;
            cboDrivers.Text = "Select and Available Driver from this list.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 33);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(214, 32);
            label3.TabIndex = 0;
            label3.Text = "Available Drivers:";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(52, 152, 219);
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(25, 365);
            btnConfirm.Margin = new Padding(2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(224, 63);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "[Confirm Assignment]";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(213, 216, 220);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.Location = new Point(291, 365);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(224, 63);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "[Cancel && Close]";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAssignDriver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(174, 214, 241);
            ClientSize = new Size(566, 439);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(grpDriverSelection);
            Controls.Add(lblDriverSelection);
            Controls.Add(label2);
            Controls.Add(lblVehicleDetails);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmAssignDriver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Driver Assignment Command - EcoLink Hub";
            Load += frmAssignDriver_Load;
            grpDriverSelection.ResumeLayout(false);
            grpDriverSelection.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblVehicleDetails;
        private Label label2;
        private Label lblDriverSelection;
        private GroupBox grpDriverSelection;
        private ComboBox cboDrivers;
        private Button btnConfirm;
        private Button btnCancel;
        private Label label3;
        private TextBox txtDriverName;
        private Label label4;
        private Button btnRemoveDriver;
        private Button btnAddDriver;
    }
}
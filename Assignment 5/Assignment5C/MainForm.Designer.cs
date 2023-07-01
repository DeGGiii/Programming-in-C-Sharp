namespace Assignment5C
{
    partial class MainForm
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
            grpNewEvent = new GroupBox();
            btnCreateEvent = new Button();
            txtFeePerParticipant = new TextBox();
            txtCostPerParticipant = new TextBox();
            txtEventTitle = new TextBox();
            lblFeePerParticipant = new Label();
            lblCostPerParticipant = new Label();
            lblEventTitle = new Label();
            grpParticipants = new GroupBox();
            btnAdd = new Button();
            cmbCountry = new ComboBox();
            txtZipCode = new TextBox();
            txtCity = new TextBox();
            txtStreet = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblCountry = new Label();
            lblZipCode = new Label();
            lblCity = new Label();
            lblStreet = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lstParticipants = new ListBox();
            lblParticipants = new Label();
            lblAddress = new Label();
            btnChange = new Button();
            btnDelete = new Button();
            grpEventEconomy = new GroupBox();
            txtTotalFees = new TextBox();
            txtSurplusDeficit = new TextBox();
            txtTotalCost = new TextBox();
            txtNbrOfParticipants = new TextBox();
            lblSurplusDeficit = new Label();
            lblTotalFees = new Label();
            lblTotalCost = new Label();
            lblNbrOfParticipants = new Label();
            grpNewEvent.SuspendLayout();
            grpParticipants.SuspendLayout();
            grpEventEconomy.SuspendLayout();
            SuspendLayout();
            // 
            // grpNewEvent
            // 
            grpNewEvent.Controls.Add(btnCreateEvent);
            grpNewEvent.Controls.Add(txtFeePerParticipant);
            grpNewEvent.Controls.Add(txtCostPerParticipant);
            grpNewEvent.Controls.Add(txtEventTitle);
            grpNewEvent.Controls.Add(lblFeePerParticipant);
            grpNewEvent.Controls.Add(lblCostPerParticipant);
            grpNewEvent.Controls.Add(lblEventTitle);
            grpNewEvent.Location = new Point(23, 26);
            grpNewEvent.Name = "grpNewEvent";
            grpNewEvent.Size = new Size(242, 162);
            grpNewEvent.TabIndex = 0;
            grpNewEvent.TabStop = false;
            grpNewEvent.Text = "New Event";
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.ForeColor = Color.FromArgb(0, 192, 0);
            btnCreateEvent.Location = new Point(74, 128);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(90, 28);
            btnCreateEvent.TabIndex = 4;
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.UseVisualStyleBackColor = true;
            btnCreateEvent.Click += btnCreateEvent_Click;
            // 
            // txtFeePerParticipant
            // 
            txtFeePerParticipant.Location = new Point(194, 87);
            txtFeePerParticipant.Name = "txtFeePerParticipant";
            txtFeePerParticipant.Size = new Size(38, 23);
            txtFeePerParticipant.TabIndex = 3;
            txtFeePerParticipant.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCostPerParticipant
            // 
            txtCostPerParticipant.Location = new Point(194, 58);
            txtCostPerParticipant.Name = "txtCostPerParticipant";
            txtCostPerParticipant.Size = new Size(38, 23);
            txtCostPerParticipant.TabIndex = 3;
            txtCostPerParticipant.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEventTitle
            // 
            txtEventTitle.Location = new Point(84, 26);
            txtEventTitle.Name = "txtEventTitle";
            txtEventTitle.Size = new Size(148, 23);
            txtEventTitle.TabIndex = 3;
            // 
            // lblFeePerParticipant
            // 
            lblFeePerParticipant.AutoSize = true;
            lblFeePerParticipant.Location = new Point(16, 95);
            lblFeePerParticipant.Name = "lblFeePerParticipant";
            lblFeePerParticipant.Size = new Size(105, 15);
            lblFeePerParticipant.TabIndex = 2;
            lblFeePerParticipant.Text = "Fee per participant";
            // 
            // lblCostPerParticipant
            // 
            lblCostPerParticipant.AutoSize = true;
            lblCostPerParticipant.Location = new Point(16, 66);
            lblCostPerParticipant.Name = "lblCostPerParticipant";
            lblCostPerParticipant.Size = new Size(111, 15);
            lblCostPerParticipant.TabIndex = 1;
            lblCostPerParticipant.Text = "Cost per participant";
            lblCostPerParticipant.Click += label2_Click;
            // 
            // lblEventTitle
            // 
            lblEventTitle.AutoSize = true;
            lblEventTitle.Location = new Point(16, 34);
            lblEventTitle.Name = "lblEventTitle";
            lblEventTitle.Size = new Size(61, 15);
            lblEventTitle.TabIndex = 0;
            lblEventTitle.Text = "Event Title";
            // 
            // grpParticipants
            // 
            grpParticipants.Controls.Add(btnAdd);
            grpParticipants.Controls.Add(cmbCountry);
            grpParticipants.Controls.Add(txtZipCode);
            grpParticipants.Controls.Add(txtCity);
            grpParticipants.Controls.Add(txtStreet);
            grpParticipants.Controls.Add(txtLastName);
            grpParticipants.Controls.Add(txtFirstName);
            grpParticipants.Controls.Add(lblCountry);
            grpParticipants.Controls.Add(lblZipCode);
            grpParticipants.Controls.Add(lblCity);
            grpParticipants.Controls.Add(lblStreet);
            grpParticipants.Controls.Add(lblLastName);
            grpParticipants.Controls.Add(lblFirstName);
            grpParticipants.Location = new Point(23, 215);
            grpParticipants.Name = "grpParticipants";
            grpParticipants.Size = new Size(242, 233);
            grpParticipants.TabIndex = 1;
            grpParticipants.TabStop = false;
            grpParticipants.Text = "Add participants";
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.FromArgb(0, 192, 0);
            btnAdd.Location = new Point(74, 192);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 31);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(84, 159);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(148, 23);
            cmbCountry.TabIndex = 2;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(84, 134);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(148, 23);
            txtZipCode.TabIndex = 1;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(84, 109);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(148, 23);
            txtCity.TabIndex = 1;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(84, 85);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(148, 23);
            txtStreet.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(84, 51);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(148, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(84, 26);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(148, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(15, 167);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 15);
            lblCountry.TabIndex = 0;
            lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(15, 142);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(55, 15);
            lblZipCode.TabIndex = 0;
            lblZipCode.Text = "Zip Code";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(15, 117);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 0;
            lblCity.Text = "City";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(15, 93);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(37, 15);
            lblStreet.TabIndex = 0;
            lblStreet.Text = "Street";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(15, 59);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(15, 34);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lstParticipants
            // 
            lstParticipants.FormattingEnabled = true;
            lstParticipants.ItemHeight = 15;
            lstParticipants.Location = new Point(295, 42);
            lstParticipants.Name = "lstParticipants";
            lstParticipants.Size = new Size(481, 184);
            lstParticipants.TabIndex = 2;
            lstParticipants.SelectedIndexChanged += lstParticipants_SelectedIndexChanged;
            // 
            // lblParticipants
            // 
            lblParticipants.AutoSize = true;
            lblParticipants.Location = new Point(295, 24);
            lblParticipants.Name = "lblParticipants";
            lblParticipants.Size = new Size(64, 15);
            lblParticipants.TabIndex = 3;
            lblParticipants.Text = "Participant";
            lblParticipants.Click += lblParticipants_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(401, 24);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address";
            // 
            // btnChange
            // 
            btnChange.ForeColor = Color.Black;
            btnChange.Location = new Point(381, 255);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(88, 34);
            btnChange.TabIndex = 4;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(600, 255);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // grpEventEconomy
            // 
            grpEventEconomy.Controls.Add(txtTotalFees);
            grpEventEconomy.Controls.Add(txtSurplusDeficit);
            grpEventEconomy.Controls.Add(txtTotalCost);
            grpEventEconomy.Controls.Add(txtNbrOfParticipants);
            grpEventEconomy.Controls.Add(lblSurplusDeficit);
            grpEventEconomy.Controls.Add(lblTotalFees);
            grpEventEconomy.Controls.Add(lblTotalCost);
            grpEventEconomy.Controls.Add(lblNbrOfParticipants);
            grpEventEconomy.Location = new Point(371, 300);
            grpEventEconomy.Name = "grpEventEconomy";
            grpEventEconomy.Size = new Size(293, 138);
            grpEventEconomy.TabIndex = 5;
            grpEventEconomy.TabStop = false;
            grpEventEconomy.Text = "Event economy";
            // 
            // txtTotalFees
            // 
            txtTotalFees.Location = new Point(176, 78);
            txtTotalFees.Name = "txtTotalFees";
            txtTotalFees.ReadOnly = true;
            txtTotalFees.Size = new Size(100, 23);
            txtTotalFees.TabIndex = 1;
            txtTotalFees.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSurplusDeficit
            // 
            txtSurplusDeficit.Location = new Point(176, 102);
            txtSurplusDeficit.Name = "txtSurplusDeficit";
            txtSurplusDeficit.ReadOnly = true;
            txtSurplusDeficit.Size = new Size(100, 23);
            txtSurplusDeficit.TabIndex = 1;
            txtSurplusDeficit.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(176, 54);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(100, 23);
            txtTotalCost.TabIndex = 1;
            txtTotalCost.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNbrOfParticipants
            // 
            txtNbrOfParticipants.Location = new Point(176, 29);
            txtNbrOfParticipants.Name = "txtNbrOfParticipants";
            txtNbrOfParticipants.ReadOnly = true;
            txtNbrOfParticipants.Size = new Size(100, 23);
            txtNbrOfParticipants.TabIndex = 1;
            txtNbrOfParticipants.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSurplusDeficit
            // 
            lblSurplusDeficit.AutoSize = true;
            lblSurplusDeficit.ForeColor = Color.Green;
            lblSurplusDeficit.Location = new Point(20, 110);
            lblSurplusDeficit.Name = "lblSurplusDeficit";
            lblSurplusDeficit.Size = new Size(84, 15);
            lblSurplusDeficit.TabIndex = 0;
            lblSurplusDeficit.Text = "Surplus/deficit";
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.ForeColor = Color.Green;
            lblTotalFees.Location = new Point(20, 86);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(56, 15);
            lblTotalFees.TabIndex = 0;
            lblTotalFees.Text = "Total fees";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.ForeColor = Color.Green;
            lblTotalCost.Location = new Point(20, 62);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(59, 15);
            lblTotalCost.TabIndex = 0;
            lblTotalCost.Text = "Total Cost";
            // 
            // lblNbrOfParticipants
            // 
            lblNbrOfParticipants.AutoSize = true;
            lblNbrOfParticipants.ForeColor = Color.Green;
            lblNbrOfParticipants.Location = new Point(20, 37);
            lblNbrOfParticipants.Name = "lblNbrOfParticipants";
            lblNbrOfParticipants.Size = new Size(130, 15);
            lblNbrOfParticipants.TabIndex = 0;
            lblNbrOfParticipants.Text = "Number of participants";
            lblNbrOfParticipants.Click += lblNbrOfParticipants_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 456);
            Controls.Add(grpEventEconomy);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(lblAddress);
            Controls.Add(lblParticipants);
            Controls.Add(lstParticipants);
            Controls.Add(grpParticipants);
            Controls.Add(grpNewEvent);
            Name = "MainForm";
            Text = "Marges Birthday By Jagtej Sidhu";
            grpNewEvent.ResumeLayout(false);
            grpNewEvent.PerformLayout();
            grpParticipants.ResumeLayout(false);
            grpParticipants.PerformLayout();
            grpEventEconomy.ResumeLayout(false);
            grpEventEconomy.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpNewEvent;
        private TextBox txtFeePerParticipant;
        private TextBox txtCostPerParticipant;
        private TextBox txtEventTitle;
        private Label lblFeePerParticipant;
        private Label lblCostPerParticipant;
        private Label lblEventTitle;
        private Button btnCreateEvent;
        private GroupBox grpParticipants;
        private TextBox txtZipCode;
        private TextBox txtCity;
        private TextBox txtStreet;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblCountry;
        private Label lblZipCode;
        private Label lblCity;
        private Label lblStreet;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnAdd;
        private ComboBox cmbCountry;
        private ListBox lstParticipants;
        private Label lblParticipants;
        private Label lblAddress;
        private Button btnChange;
        private Button btnDelete;
        private GroupBox grpEventEconomy;
        private Label lblSurplusDeficit;
        private Label lblTotalFees;
        private Label lblTotalCost;
        private Label lblNbrOfParticipants;
        private TextBox txtTotalFees;
        private TextBox txtSurplusDeficit;
        private TextBox txtTotalCost;
        private TextBox txtNbrOfParticipants;
    }
}
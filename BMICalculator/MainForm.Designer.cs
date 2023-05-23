namespace BMICalculator
{
    partial class MainForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.grpBoxResults = new System.Windows.Forms.GroupBox();
            this.lblWeightCat = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.txtWeightCat = new System.Windows.Forms.TextBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.grpBoxUnits = new System.Windows.Forms.GroupBox();
            this.radioBtnImperial = new System.Windows.Forms.RadioButton();
            this.radioBtnMetric = new System.Windows.Forms.RadioButton();
            this.grpBoxSavingPlan = new System.Windows.Forms.GroupBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtMonthlyDeposit = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblMonthlyDeposit = new System.Windows.Forms.Label();
            this.btnCalcSavings = new System.Windows.Forms.Button();
            this.grpBoxFutureValue = new System.Windows.Forms.GroupBox();
            this.txtFinalBalance = new System.Windows.Forms.TextBox();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblFinalBal = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.grpBoxResults.SuspendLayout();
            this.grpBoxUnits.SuspendLayout();
            this.grpBoxSavingPlan.SuspendLayout();
            this.grpBoxFutureValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(99, 63);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(65, 20);
            this.txtHeight.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(99, 102);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(65, 20);
            this.txtWeight.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Your Name: ";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(25, 69);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            this.lblHeight.Click += new System.EventHandler(this.lblHeight_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(25, 108);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(45, 175);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(236, 34);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // grpBoxResults
            // 
            this.grpBoxResults.Controls.Add(this.lblWeightCat);
            this.grpBoxResults.Controls.Add(this.lblBMI);
            this.grpBoxResults.Controls.Add(this.txtWeightCat);
            this.grpBoxResults.Controls.Add(this.txtBMI);
            this.grpBoxResults.Location = new System.Drawing.Point(28, 246);
            this.grpBoxResults.Name = "grpBoxResults";
            this.grpBoxResults.Size = new System.Drawing.Size(273, 149);
            this.grpBoxResults.TabIndex = 8;
            this.grpBoxResults.TabStop = false;
            this.grpBoxResults.Text = "Results for";
            // 
            // lblWeightCat
            // 
            this.lblWeightCat.AutoSize = true;
            this.lblWeightCat.Location = new System.Drawing.Point(30, 76);
            this.lblWeightCat.Name = "lblWeightCat";
            this.lblWeightCat.Size = new System.Drawing.Size(86, 13);
            this.lblWeightCat.TabIndex = 3;
            this.lblWeightCat.Text = "Weight Category";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(30, 41);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(51, 13);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.Text = "Your BMI";
            // 
            // txtWeightCat
            // 
            this.txtWeightCat.Location = new System.Drawing.Point(130, 73);
            this.txtWeightCat.Name = "txtWeightCat";
            this.txtWeightCat.ReadOnly = true;
            this.txtWeightCat.Size = new System.Drawing.Size(137, 20);
            this.txtWeightCat.TabIndex = 1;
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(130, 38);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(100, 20);
            this.txtBMI.TabIndex = 0;
            // 
            // grpBoxUnits
            // 
            this.grpBoxUnits.Controls.Add(this.radioBtnImperial);
            this.grpBoxUnits.Controls.Add(this.radioBtnMetric);
            this.grpBoxUnits.Location = new System.Drawing.Point(245, 22);
            this.grpBoxUnits.Name = "grpBoxUnits";
            this.grpBoxUnits.Size = new System.Drawing.Size(200, 100);
            this.grpBoxUnits.TabIndex = 9;
            this.grpBoxUnits.TabStop = false;
            this.grpBoxUnits.Text = "Units";
            // 
            // radioBtnImperial
            // 
            this.radioBtnImperial.AutoSize = true;
            this.radioBtnImperial.Location = new System.Drawing.Point(38, 63);
            this.radioBtnImperial.Name = "radioBtnImperial";
            this.radioBtnImperial.Size = new System.Drawing.Size(107, 17);
            this.radioBtnImperial.TabIndex = 1;
            this.radioBtnImperial.TabStop = true;
            this.radioBtnImperial.Text = "Imperial (lbs, feet)";
            this.radioBtnImperial.UseVisualStyleBackColor = true;
            this.radioBtnImperial.CheckedChanged += new System.EventHandler(this.radioBtnImperial_CheckedChanged);
            // 
            // radioBtnMetric
            // 
            this.radioBtnMetric.AutoSize = true;
            this.radioBtnMetric.Location = new System.Drawing.Point(38, 31);
            this.radioBtnMetric.Name = "radioBtnMetric";
            this.radioBtnMetric.Size = new System.Drawing.Size(95, 17);
            this.radioBtnMetric.TabIndex = 0;
            this.radioBtnMetric.TabStop = true;
            this.radioBtnMetric.Text = "Metric (kg, cm)";
            this.radioBtnMetric.UseVisualStyleBackColor = true;
            this.radioBtnMetric.CheckedChanged += new System.EventHandler(this.radioBtnMetric_CheckedChanged);
            // 
            // grpBoxSavingPlan
            // 
            this.grpBoxSavingPlan.Controls.Add(this.txtPeriod);
            this.grpBoxSavingPlan.Controls.Add(this.txtMonthlyDeposit);
            this.grpBoxSavingPlan.Controls.Add(this.lblPeriod);
            this.grpBoxSavingPlan.Controls.Add(this.lblMonthlyDeposit);
            this.grpBoxSavingPlan.Location = new System.Drawing.Point(473, 21);
            this.grpBoxSavingPlan.Name = "grpBoxSavingPlan";
            this.grpBoxSavingPlan.Size = new System.Drawing.Size(233, 119);
            this.grpBoxSavingPlan.TabIndex = 10;
            this.grpBoxSavingPlan.TabStop = false;
            this.grpBoxSavingPlan.Text = "Saving plan";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(118, 75);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtPeriod.TabIndex = 3;
            // 
            // txtMonthlyDeposit
            // 
            this.txtMonthlyDeposit.Location = new System.Drawing.Point(118, 43);
            this.txtMonthlyDeposit.Name = "txtMonthlyDeposit";
            this.txtMonthlyDeposit.Size = new System.Drawing.Size(100, 20);
            this.txtMonthlyDeposit.TabIndex = 2;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(23, 78);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(71, 13);
            this.lblPeriod.TabIndex = 1;
            this.lblPeriod.Text = "Period (years)";
            // 
            // lblMonthlyDeposit
            // 
            this.lblMonthlyDeposit.AutoSize = true;
            this.lblMonthlyDeposit.Location = new System.Drawing.Point(23, 46);
            this.lblMonthlyDeposit.Name = "lblMonthlyDeposit";
            this.lblMonthlyDeposit.Size = new System.Drawing.Size(81, 13);
            this.lblMonthlyDeposit.TabIndex = 0;
            this.lblMonthlyDeposit.Text = "Monthly deposit";
            // 
            // btnCalcSavings
            // 
            this.btnCalcSavings.Location = new System.Drawing.Point(479, 175);
            this.btnCalcSavings.Name = "btnCalcSavings";
            this.btnCalcSavings.Size = new System.Drawing.Size(227, 29);
            this.btnCalcSavings.TabIndex = 11;
            this.btnCalcSavings.Text = "Calculate savings";
            this.btnCalcSavings.UseVisualStyleBackColor = true;
            this.btnCalcSavings.Click += new System.EventHandler(this.btnCalcSavings_Click);
            // 
            // grpBoxFutureValue
            // 
            this.grpBoxFutureValue.Controls.Add(this.txtFinalBalance);
            this.grpBoxFutureValue.Controls.Add(this.txtAmountPaid);
            this.grpBoxFutureValue.Controls.Add(this.lblFinalBal);
            this.grpBoxFutureValue.Controls.Add(this.lblAmountPaid);
            this.grpBoxFutureValue.Location = new System.Drawing.Point(473, 235);
            this.grpBoxFutureValue.Name = "grpBoxFutureValue";
            this.grpBoxFutureValue.Size = new System.Drawing.Size(233, 160);
            this.grpBoxFutureValue.TabIndex = 12;
            this.grpBoxFutureValue.TabStop = false;
            this.grpBoxFutureValue.Text = "Future Value";
            // 
            // txtFinalBalance
            // 
            this.txtFinalBalance.Location = new System.Drawing.Point(118, 87);
            this.txtFinalBalance.Name = "txtFinalBalance";
            this.txtFinalBalance.ReadOnly = true;
            this.txtFinalBalance.Size = new System.Drawing.Size(100, 20);
            this.txtFinalBalance.TabIndex = 3;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(118, 49);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.ReadOnly = true;
            this.txtAmountPaid.Size = new System.Drawing.Size(100, 20);
            this.txtAmountPaid.TabIndex = 2;
            // 
            // lblFinalBal
            // 
            this.lblFinalBal.AutoSize = true;
            this.lblFinalBal.Location = new System.Drawing.Point(26, 87);
            this.lblFinalBal.Name = "lblFinalBal";
            this.lblFinalBal.Size = new System.Drawing.Size(70, 13);
            this.lblFinalBal.TabIndex = 1;
            this.lblFinalBal.Text = "Final balance";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(26, 51);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(66, 13);
            this.lblAmountPaid.TabIndex = 0;
            this.lblAmountPaid.Text = "Amount paid";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 407);
            this.Controls.Add(this.grpBoxFutureValue);
            this.Controls.Add(this.btnCalcSavings);
            this.Controls.Add(this.grpBoxSavingPlan);
            this.Controls.Add(this.grpBoxUnits);
            this.Controls.Add(this.grpBoxResults);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtName);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpBoxResults.ResumeLayout(false);
            this.grpBoxResults.PerformLayout();
            this.grpBoxUnits.ResumeLayout(false);
            this.grpBoxUnits.PerformLayout();
            this.grpBoxSavingPlan.ResumeLayout(false);
            this.grpBoxSavingPlan.PerformLayout();
            this.grpBoxFutureValue.ResumeLayout(false);
            this.grpBoxFutureValue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox grpBoxResults;
        private System.Windows.Forms.Label lblWeightCat;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtWeightCat;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.GroupBox grpBoxUnits;
        private System.Windows.Forms.RadioButton radioBtnImperial;
        private System.Windows.Forms.RadioButton radioBtnMetric;
        private System.Windows.Forms.GroupBox grpBoxSavingPlan;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtMonthlyDeposit;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblMonthlyDeposit;
        private System.Windows.Forms.Button btnCalcSavings;
        private System.Windows.Forms.GroupBox grpBoxFutureValue;
        private System.Windows.Forms.TextBox txtFinalBalance;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblFinalBal;
        private System.Windows.Forms.Label lblAmountPaid;
    }
}



namespace Assignment3
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
            lblName = new Label();
            txtBoxName = new TextBox();
            lblHeight = new Label();
            lblWeight = new Label();
            txtBoxHeight = new TextBox();
            txtBoxWeight = new TextBox();
            groupBoxUnit = new GroupBox();
            radioBtnUsUnit = new RadioButton();
            radioBtnMetric = new RadioButton();
            btnCalculateBMI = new Button();
            groupBoxResults = new GroupBox();
            txtBoxWeightCategory = new TextBox();
            txtBoxResults = new TextBox();
            lblWeightCategory = new Label();
            lblResults = new Label();
            groupBoxSavingPlan = new GroupBox();
            btnCalculateSaving = new Button();
            txtBoxFees = new TextBox();
            txtBoxGrowth = new TextBox();
            txtBoxPeriod = new TextBox();
            txtBoxMonthlyDeposit = new TextBox();
            txtBoxInitalDeposit = new TextBox();
            lblGrowth = new Label();
            lblFees = new Label();
            lblPeriod = new Label();
            lblMonthlyDeposit = new Label();
            lblInitialDeposit = new Label();
            groupBoxFutureValue = new GroupBox();
            textBoxAmountPaid = new TextBox();
            textBoxTotalFees = new TextBox();
            textBoxFinalBalance = new TextBox();
            textBoxAmountEarned = new TextBox();
            lblTotalFees = new Label();
            lblFinalBalance = new Label();
            lblAmountEarned = new Label();
            lblAmountPaid = new Label();
            groupBoxBMICalc = new GroupBox();
            lblIn = new Label();
            lblft = new Label();
            txtBoxHeightInches = new TextBox();
            groupBoxBMRCalculator = new GroupBox();
            textBoxWeightBMR = new TextBox();
            lblWeightBMR = new Label();
            textBoxHeightBMR = new TextBox();
            lblHeightBMR = new Label();
            btnCalculateBMR = new Button();
            groupBoxWeeklyActivityLevel = new GroupBox();
            radioBtnExtraActive = new RadioButton();
            radioBtnVeryActive = new RadioButton();
            radioBtnModeratelyActive = new RadioButton();
            radioBtnLighlyActive = new RadioButton();
            radioBtnSedentery = new RadioButton();
            txtBoxAge = new TextBox();
            lblAge = new Label();
            groupBox1 = new GroupBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            groupBoxBMRResults = new GroupBox();
            textBoxBMR = new TextBox();
            textBoxGainWholeKg = new TextBox();
            textBoxGainHalfKg = new TextBox();
            textBoxLoseWholeKg = new TextBox();
            textBoxLoseHalfKg = new TextBox();
            textBoxMaintainWeight = new TextBox();
            lblGainWholeKg = new Label();
            lblGainHalfKg = new Label();
            lblLoseWholeKg = new Label();
            lblLoseHalfKg = new Label();
            lblCaloriesMaintainWeight = new Label();
            lblYourBMR = new Label();
            lblNormalWeightMetric = new Label();
            lblNormalWeightImperial = new Label();
            groupBoxUnit.SuspendLayout();
            groupBoxResults.SuspendLayout();
            groupBoxSavingPlan.SuspendLayout();
            groupBoxFutureValue.SuspendLayout();
            groupBoxBMICalc.SuspendLayout();
            groupBoxBMRCalculator.SuspendLayout();
            groupBoxWeeklyActivityLevel.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxBMRResults.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(7, 35);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Your Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(134, 29);
            txtBoxName.Margin = new Padding(4);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(604, 31);
            txtBoxName.TabIndex = 1;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(7, 77);
            lblHeight.Margin = new Padding(4, 0, 4, 0);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(104, 25);
            lblHeight.TabIndex = 2;
            lblHeight.Text = "Height (cm)";
            lblHeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(8, 123);
            lblWeight.Margin = new Padding(4, 0, 4, 0);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(103, 25);
            lblWeight.TabIndex = 3;
            lblWeight.Text = "Weight (kg)";
            // 
            // txtBoxHeight
            // 
            txtBoxHeight.Location = new Point(134, 75);
            txtBoxHeight.Margin = new Padding(4);
            txtBoxHeight.Name = "txtBoxHeight";
            txtBoxHeight.Size = new Size(79, 31);
            txtBoxHeight.TabIndex = 4;
            txtBoxHeight.TextChanged += txtBHeight_TextChanged;
            // 
            // txtBoxWeight
            // 
            txtBoxWeight.Location = new Point(134, 120);
            txtBoxWeight.Margin = new Padding(4);
            txtBoxWeight.Name = "txtBoxWeight";
            txtBoxWeight.Size = new Size(79, 31);
            txtBoxWeight.TabIndex = 5;
            txtBoxWeight.TextChanged += txtBWeight_TextChanged;
            // 
            // groupBoxUnit
            // 
            groupBoxUnit.Controls.Add(radioBtnUsUnit);
            groupBoxUnit.Controls.Add(radioBtnMetric);
            groupBoxUnit.Location = new Point(429, 68);
            groupBoxUnit.Margin = new Padding(4);
            groupBoxUnit.Name = "groupBoxUnit";
            groupBoxUnit.Padding = new Padding(4);
            groupBoxUnit.Size = new Size(312, 132);
            groupBoxUnit.TabIndex = 6;
            groupBoxUnit.TabStop = false;
            groupBoxUnit.Text = "Unit";
            groupBoxUnit.Enter += groupBoxUnit_Enter;
            // 
            // radioBtnUsUnit
            // 
            radioBtnUsUnit.AutoSize = true;
            radioBtnUsUnit.Location = new Point(44, 76);
            radioBtnUsUnit.Margin = new Padding(4);
            radioBtnUsUnit.Name = "radioBtnUsUnit";
            radioBtnUsUnit.Size = new Size(177, 29);
            radioBtnUsUnit.TabIndex = 1;
            radioBtnUsUnit.TabStop = true;
            radioBtnUsUnit.Text = "US Unit (foot, lbs)";
            radioBtnUsUnit.UseVisualStyleBackColor = true;
            radioBtnUsUnit.CheckedChanged += radioBtnUsUnit_CheckedChanged_1;
            // 
            // radioBtnMetric
            // 
            radioBtnMetric.AutoSize = true;
            radioBtnMetric.Location = new Point(44, 39);
            radioBtnMetric.Margin = new Padding(4);
            radioBtnMetric.Name = "radioBtnMetric";
            radioBtnMetric.Size = new Size(189, 29);
            radioBtnMetric.TabIndex = 0;
            radioBtnMetric.TabStop = true;
            radioBtnMetric.Text = "Metric unit (kg, cm)";
            radioBtnMetric.UseVisualStyleBackColor = true;
            radioBtnMetric.CheckedChanged += radioBtnMetric_CheckedChanged_1;
            // 
            // btnCalculateBMI
            // 
            btnCalculateBMI.Location = new Point(158, 178);
            btnCalculateBMI.Margin = new Padding(4);
            btnCalculateBMI.Name = "btnCalculateBMI";
            btnCalculateBMI.Size = new Size(151, 38);
            btnCalculateBMI.TabIndex = 7;
            btnCalculateBMI.Text = "Calculate BMI";
            btnCalculateBMI.UseVisualStyleBackColor = true;
            btnCalculateBMI.Click += btnCalculateBMI_Click_1;
            // 
            // groupBoxResults
            // 
            groupBoxResults.Controls.Add(lblNormalWeightImperial);
            groupBoxResults.Controls.Add(lblNormalWeightMetric);
            groupBoxResults.Controls.Add(txtBoxWeightCategory);
            groupBoxResults.Controls.Add(txtBoxResults);
            groupBoxResults.Controls.Add(lblWeightCategory);
            groupBoxResults.Controls.Add(lblResults);
            groupBoxResults.Location = new Point(833, 7);
            groupBoxResults.Margin = new Padding(4);
            groupBoxResults.Name = "groupBoxResults";
            groupBoxResults.Padding = new Padding(4);
            groupBoxResults.Size = new Size(485, 230);
            groupBoxResults.TabIndex = 8;
            groupBoxResults.TabStop = false;
            groupBoxResults.Text = "Results for";
            // 
            // txtBoxWeightCategory
            // 
            txtBoxWeightCategory.BackColor = SystemColors.Control;
            txtBoxWeightCategory.Location = new Point(244, 66);
            txtBoxWeightCategory.Margin = new Padding(4);
            txtBoxWeightCategory.Name = "txtBoxWeightCategory";
            txtBoxWeightCategory.Size = new Size(155, 31);
            txtBoxWeightCategory.TabIndex = 3;
            txtBoxWeightCategory.TextChanged += txtBoxWeightCategory_TextChanged;
            // 
            // txtBoxResults
            // 
            txtBoxResults.BackColor = SystemColors.Control;
            txtBoxResults.Location = new Point(244, 24);
            txtBoxResults.Margin = new Padding(4);
            txtBoxResults.Name = "txtBoxResults";
            txtBoxResults.Size = new Size(155, 31);
            txtBoxResults.TabIndex = 2;
            // 
            // lblWeightCategory
            // 
            lblWeightCategory.AutoSize = true;
            lblWeightCategory.Location = new Point(21, 72);
            lblWeightCategory.Margin = new Padding(4, 0, 4, 0);
            lblWeightCategory.Name = "lblWeightCategory";
            lblWeightCategory.Size = new Size(142, 25);
            lblWeightCategory.TabIndex = 1;
            lblWeightCategory.Text = "Weight category";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(31, 30);
            lblResults.Margin = new Padding(4, 0, 4, 0);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(83, 25);
            lblResults.TabIndex = 0;
            lblResults.Text = "Your BMI";
            // 
            // groupBoxSavingPlan
            // 
            groupBoxSavingPlan.Controls.Add(btnCalculateSaving);
            groupBoxSavingPlan.Controls.Add(txtBoxFees);
            groupBoxSavingPlan.Controls.Add(txtBoxGrowth);
            groupBoxSavingPlan.Controls.Add(txtBoxPeriod);
            groupBoxSavingPlan.Controls.Add(txtBoxMonthlyDeposit);
            groupBoxSavingPlan.Controls.Add(txtBoxInitalDeposit);
            groupBoxSavingPlan.Controls.Add(lblGrowth);
            groupBoxSavingPlan.Controls.Add(lblFees);
            groupBoxSavingPlan.Controls.Add(lblPeriod);
            groupBoxSavingPlan.Controls.Add(lblMonthlyDeposit);
            groupBoxSavingPlan.Controls.Add(lblInitialDeposit);
            groupBoxSavingPlan.Location = new Point(12, 627);
            groupBoxSavingPlan.Name = "groupBoxSavingPlan";
            groupBoxSavingPlan.Size = new Size(402, 283);
            groupBoxSavingPlan.TabIndex = 9;
            groupBoxSavingPlan.TabStop = false;
            groupBoxSavingPlan.Text = "Saving plan";
            groupBoxSavingPlan.Enter += groupBoxSavingPlan_Enter;
            // 
            // btnCalculateSaving
            // 
            btnCalculateSaving.AutoSize = true;
            btnCalculateSaving.Location = new Point(158, 240);
            btnCalculateSaving.Name = "btnCalculateSaving";
            btnCalculateSaving.Size = new Size(148, 48);
            btnCalculateSaving.TabIndex = 10;
            btnCalculateSaving.Text = "Calculate saving";
            btnCalculateSaving.UseVisualStyleBackColor = true;
            btnCalculateSaving.Click += btnCalculateSaving_Click;
            // 
            // txtBoxFees
            // 
            txtBoxFees.Location = new Point(233, 173);
            txtBoxFees.Name = "txtBoxFees";
            txtBoxFees.Size = new Size(150, 31);
            txtBoxFees.TabIndex = 9;
            txtBoxFees.TextChanged += txtBoxFees_TextChanged;
            // 
            // txtBoxGrowth
            // 
            txtBoxGrowth.Location = new Point(233, 133);
            txtBoxGrowth.Name = "txtBoxGrowth";
            txtBoxGrowth.Size = new Size(150, 31);
            txtBoxGrowth.TabIndex = 8;
            txtBoxGrowth.TextChanged += txtBoxGrowth_TextChanged;
            // 
            // txtBoxPeriod
            // 
            txtBoxPeriod.Location = new Point(233, 97);
            txtBoxPeriod.Name = "txtBoxPeriod";
            txtBoxPeriod.Size = new Size(150, 31);
            txtBoxPeriod.TabIndex = 7;
            txtBoxPeriod.TextChanged += txtBoxPeriod_TextChanged;
            // 
            // txtBoxMonthlyDeposit
            // 
            txtBoxMonthlyDeposit.Location = new Point(233, 61);
            txtBoxMonthlyDeposit.Name = "txtBoxMonthlyDeposit";
            txtBoxMonthlyDeposit.Size = new Size(150, 31);
            txtBoxMonthlyDeposit.TabIndex = 6;
            txtBoxMonthlyDeposit.TextChanged += txtBoxMonthlyDeposit_TextChanged;
            // 
            // txtBoxInitalDeposit
            // 
            txtBoxInitalDeposit.Location = new Point(233, 24);
            txtBoxInitalDeposit.Name = "txtBoxInitalDeposit";
            txtBoxInitalDeposit.Size = new Size(150, 31);
            txtBoxInitalDeposit.TabIndex = 5;
            txtBoxInitalDeposit.TextChanged += txtBoxInitalDeposit_TextChanged;
            // 
            // lblGrowth
            // 
            lblGrowth.AutoSize = true;
            lblGrowth.Location = new Point(6, 139);
            lblGrowth.Name = "lblGrowth";
            lblGrowth.Size = new Size(204, 25);
            lblGrowth.TabIndex = 4;
            lblGrowth.Text = "Growth (or interest) in %";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Location = new Point(6, 182);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(86, 25);
            lblFees.TabIndex = 3;
            lblFees.Text = "Fees in %";
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.Location = new Point(6, 103);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(118, 25);
            lblPeriod.TabIndex = 2;
            lblPeriod.Text = "Period (years)";
            // 
            // lblMonthlyDeposit
            // 
            lblMonthlyDeposit.AutoSize = true;
            lblMonthlyDeposit.Location = new Point(6, 68);
            lblMonthlyDeposit.Name = "lblMonthlyDeposit";
            lblMonthlyDeposit.Size = new Size(143, 25);
            lblMonthlyDeposit.TabIndex = 1;
            lblMonthlyDeposit.Text = "Monthly deposit";
            // 
            // lblInitialDeposit
            // 
            lblInitialDeposit.AutoSize = true;
            lblInitialDeposit.Location = new Point(6, 33);
            lblInitialDeposit.Name = "lblInitialDeposit";
            lblInitialDeposit.Size = new Size(121, 25);
            lblInitialDeposit.TabIndex = 0;
            lblInitialDeposit.Text = "Initial Deposit";
            // 
            // groupBoxFutureValue
            // 
            groupBoxFutureValue.Controls.Add(textBoxAmountPaid);
            groupBoxFutureValue.Controls.Add(textBoxTotalFees);
            groupBoxFutureValue.Controls.Add(textBoxFinalBalance);
            groupBoxFutureValue.Controls.Add(textBoxAmountEarned);
            groupBoxFutureValue.Controls.Add(lblTotalFees);
            groupBoxFutureValue.Controls.Add(lblFinalBalance);
            groupBoxFutureValue.Controls.Add(lblAmountEarned);
            groupBoxFutureValue.Controls.Add(lblAmountPaid);
            groupBoxFutureValue.Location = new Point(430, 627);
            groupBoxFutureValue.Name = "groupBoxFutureValue";
            groupBoxFutureValue.Size = new Size(396, 193);
            groupBoxFutureValue.TabIndex = 10;
            groupBoxFutureValue.TabStop = false;
            groupBoxFutureValue.Text = "Future value";
            // 
            // textBoxAmountPaid
            // 
            textBoxAmountPaid.BackColor = SystemColors.Control;
            textBoxAmountPaid.Location = new Point(233, 24);
            textBoxAmountPaid.Name = "textBoxAmountPaid";
            textBoxAmountPaid.Size = new Size(150, 31);
            textBoxAmountPaid.TabIndex = 9;
            textBoxAmountPaid.TextChanged += textBoxAmountPaid_TextChanged;
            // 
            // textBoxTotalFees
            // 
            textBoxTotalFees.BackColor = SystemColors.Control;
            textBoxTotalFees.Location = new Point(233, 133);
            textBoxTotalFees.Name = "textBoxTotalFees";
            textBoxTotalFees.Size = new Size(150, 31);
            textBoxTotalFees.TabIndex = 8;
            // 
            // textBoxFinalBalance
            // 
            textBoxFinalBalance.BackColor = SystemColors.Control;
            textBoxFinalBalance.Location = new Point(233, 97);
            textBoxFinalBalance.Name = "textBoxFinalBalance";
            textBoxFinalBalance.Size = new Size(150, 31);
            textBoxFinalBalance.TabIndex = 7;
            // 
            // textBoxAmountEarned
            // 
            textBoxAmountEarned.BackColor = SystemColors.Control;
            textBoxAmountEarned.Location = new Point(233, 61);
            textBoxAmountEarned.Name = "textBoxAmountEarned";
            textBoxAmountEarned.Size = new Size(150, 31);
            textBoxAmountEarned.TabIndex = 6;
            textBoxAmountEarned.TextChanged += textBoxAmountEarned_TextChanged;
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Location = new Point(6, 139);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(86, 25);
            lblTotalFees.TabIndex = 4;
            lblTotalFees.Text = "Total fees";
            // 
            // lblFinalBalance
            // 
            lblFinalBalance.AutoSize = true;
            lblFinalBalance.Location = new Point(6, 103);
            lblFinalBalance.Name = "lblFinalBalance";
            lblFinalBalance.Size = new Size(113, 25);
            lblFinalBalance.TabIndex = 2;
            lblFinalBalance.Text = "Final balance";
            // 
            // lblAmountEarned
            // 
            lblAmountEarned.AutoSize = true;
            lblAmountEarned.Location = new Point(6, 68);
            lblAmountEarned.Name = "lblAmountEarned";
            lblAmountEarned.Size = new Size(136, 25);
            lblAmountEarned.TabIndex = 1;
            lblAmountEarned.Text = "Amount earned";
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Location = new Point(6, 33);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(117, 25);
            lblAmountPaid.TabIndex = 0;
            lblAmountPaid.Text = "Amount paid";
            // 
            // groupBoxBMICalc
            // 
            groupBoxBMICalc.Controls.Add(lblIn);
            groupBoxBMICalc.Controls.Add(lblft);
            groupBoxBMICalc.Controls.Add(txtBoxHeightInches);
            groupBoxBMICalc.Controls.Add(groupBoxBMRCalculator);
            groupBoxBMICalc.Controls.Add(lblName);
            groupBoxBMICalc.Controls.Add(txtBoxName);
            groupBoxBMICalc.Controls.Add(lblHeight);
            groupBoxBMICalc.Controls.Add(txtBoxHeight);
            groupBoxBMICalc.Controls.Add(btnCalculateBMI);
            groupBoxBMICalc.Controls.Add(txtBoxWeight);
            groupBoxBMICalc.Controls.Add(groupBoxUnit);
            groupBoxBMICalc.Controls.Add(lblWeight);
            groupBoxBMICalc.Location = new Point(12, 2);
            groupBoxBMICalc.Name = "groupBoxBMICalc";
            groupBoxBMICalc.Size = new Size(781, 597);
            groupBoxBMICalc.TabIndex = 11;
            groupBoxBMICalc.TabStop = false;
            groupBoxBMICalc.Text = "BMICalculator";
            // 
            // lblIn
            // 
            lblIn.AutoSize = true;
            lblIn.Location = new Point(351, 83);
            lblIn.Name = "lblIn";
            lblIn.Size = new Size(26, 25);
            lblIn.TabIndex = 15;
            lblIn.Text = "in";
            // 
            // lblft
            // 
            lblft.AutoSize = true;
            lblft.Location = new Point(220, 81);
            lblft.Name = "lblft";
            lblft.Size = new Size(24, 25);
            lblft.TabIndex = 14;
            lblft.Text = "ft";
            // 
            // txtBoxHeightInches
            // 
            txtBoxHeightInches.Location = new Point(265, 76);
            txtBoxHeightInches.Margin = new Padding(4);
            txtBoxHeightInches.Name = "txtBoxHeightInches";
            txtBoxHeightInches.Size = new Size(79, 31);
            txtBoxHeightInches.TabIndex = 13;
            // 
            // groupBoxBMRCalculator
            // 
            groupBoxBMRCalculator.Controls.Add(textBoxWeightBMR);
            groupBoxBMRCalculator.Controls.Add(lblWeightBMR);
            groupBoxBMRCalculator.Controls.Add(textBoxHeightBMR);
            groupBoxBMRCalculator.Controls.Add(lblHeightBMR);
            groupBoxBMRCalculator.Controls.Add(btnCalculateBMR);
            groupBoxBMRCalculator.Controls.Add(groupBoxWeeklyActivityLevel);
            groupBoxBMRCalculator.Controls.Add(txtBoxAge);
            groupBoxBMRCalculator.Controls.Add(lblAge);
            groupBoxBMRCalculator.Controls.Add(groupBox1);
            groupBoxBMRCalculator.Location = new Point(8, 232);
            groupBoxBMRCalculator.Name = "groupBoxBMRCalculator";
            groupBoxBMRCalculator.Size = new Size(748, 338);
            groupBoxBMRCalculator.TabIndex = 12;
            groupBoxBMRCalculator.TabStop = false;
            groupBoxBMRCalculator.Text = "BMRCalculator";
            // 
            // textBoxWeightBMR
            // 
            textBoxWeightBMR.Location = new Point(283, 150);
            textBoxWeightBMR.Margin = new Padding(4);
            textBoxWeightBMR.Name = "textBoxWeightBMR";
            textBoxWeightBMR.Size = new Size(79, 31);
            textBoxWeightBMR.TabIndex = 19;
            textBoxWeightBMR.TextChanged += textBoxWeightBMR_TextChanged_1;
            // 
            // lblWeightBMR
            // 
            lblWeightBMR.AutoSize = true;
            lblWeightBMR.Location = new Point(174, 156);
            lblWeightBMR.Margin = new Padding(4, 0, 4, 0);
            lblWeightBMR.Name = "lblWeightBMR";
            lblWeightBMR.Size = new Size(103, 25);
            lblWeightBMR.TabIndex = 18;
            lblWeightBMR.Text = "Weight (kg)";
            lblWeightBMR.Click += lblWeightBMR_Click_1;
            // 
            // textBoxHeightBMR
            // 
            textBoxHeightBMR.Location = new Point(283, 114);
            textBoxHeightBMR.Margin = new Padding(4);
            textBoxHeightBMR.Name = "textBoxHeightBMR";
            textBoxHeightBMR.Size = new Size(79, 31);
            textBoxHeightBMR.TabIndex = 13;
            textBoxHeightBMR.TextChanged += textBoxHeightBMR_TextChanged_1;
            // 
            // lblHeightBMR
            // 
            lblHeightBMR.AutoSize = true;
            lblHeightBMR.Location = new Point(173, 117);
            lblHeightBMR.Margin = new Padding(4, 0, 4, 0);
            lblHeightBMR.Name = "lblHeightBMR";
            lblHeightBMR.Size = new Size(104, 25);
            lblHeightBMR.TabIndex = 17;
            lblHeightBMR.Text = "Height (cm)";
            lblHeightBMR.TextAlign = ContentAlignment.MiddleCenter;
            lblHeightBMR.Click += lblHeightBMR_Click_1;
            // 
            // btnCalculateBMR
            // 
            btnCalculateBMR.AutoSize = true;
            btnCalculateBMR.Location = new Point(230, 259);
            btnCalculateBMR.Name = "btnCalculateBMR";
            btnCalculateBMR.Size = new Size(134, 35);
            btnCalculateBMR.TabIndex = 16;
            btnCalculateBMR.Text = "Calculate BMR";
            btnCalculateBMR.UseVisualStyleBackColor = true;
            btnCalculateBMR.Click += btnCalculateBMR_Click;
            // 
            // groupBoxWeeklyActivityLevel
            // 
            groupBoxWeeklyActivityLevel.Controls.Add(radioBtnExtraActive);
            groupBoxWeeklyActivityLevel.Controls.Add(radioBtnVeryActive);
            groupBoxWeeklyActivityLevel.Controls.Add(radioBtnModeratelyActive);
            groupBoxWeeklyActivityLevel.Controls.Add(radioBtnLighlyActive);
            groupBoxWeeklyActivityLevel.Controls.Add(radioBtnSedentery);
            groupBoxWeeklyActivityLevel.Location = new Point(421, 54);
            groupBoxWeeklyActivityLevel.Name = "groupBoxWeeklyActivityLevel";
            groupBoxWeeklyActivityLevel.Size = new Size(294, 202);
            groupBoxWeeklyActivityLevel.TabIndex = 15;
            groupBoxWeeklyActivityLevel.TabStop = false;
            groupBoxWeeklyActivityLevel.Text = "Weekly Activity Level";
            // 
            // radioBtnExtraActive
            // 
            radioBtnExtraActive.AutoSize = true;
            radioBtnExtraActive.Location = new Point(9, 167);
            radioBtnExtraActive.Name = "radioBtnExtraActive";
            radioBtnExtraActive.Size = new Size(125, 29);
            radioBtnExtraActive.TabIndex = 4;
            radioBtnExtraActive.TabStop = true;
            radioBtnExtraActive.Text = "Extra active";
            radioBtnExtraActive.UseVisualStyleBackColor = true;
            radioBtnExtraActive.CheckedChanged += radioBtnExtraActive_CheckedChanged;
            // 
            // radioBtnVeryActive
            // 
            radioBtnVeryActive.AutoSize = true;
            radioBtnVeryActive.Location = new Point(12, 133);
            radioBtnVeryActive.Name = "radioBtnVeryActive";
            radioBtnVeryActive.Size = new Size(226, 29);
            radioBtnVeryActive.TabIndex = 3;
            radioBtnVeryActive.TabStop = true;
            radioBtnVeryActive.Text = "Very Active (6 to 7 time)";
            radioBtnVeryActive.UseVisualStyleBackColor = true;
            radioBtnVeryActive.CheckedChanged += radioBtnVeryActive_CheckedChanged;
            // 
            // radioBtnModeratelyActive
            // 
            radioBtnModeratelyActive.AutoSize = true;
            radioBtnModeratelyActive.Location = new Point(12, 98);
            radioBtnModeratelyActive.Name = "radioBtnModeratelyActive";
            radioBtnModeratelyActive.Size = new Size(242, 29);
            radioBtnModeratelyActive.TabIndex = 2;
            radioBtnModeratelyActive.TabStop = true;
            radioBtnModeratelyActive.Text = "Moderately Active (3 to 5)";
            radioBtnModeratelyActive.UseVisualStyleBackColor = true;
            radioBtnModeratelyActive.CheckedChanged += radioBtnModeratelyActive_CheckedChanged;
            // 
            // radioBtnLighlyActive
            // 
            radioBtnLighlyActive.AutoSize = true;
            radioBtnLighlyActive.Location = new Point(12, 63);
            radioBtnLighlyActive.Name = "radioBtnLighlyActive";
            radioBtnLighlyActive.Size = new Size(204, 29);
            radioBtnLighlyActive.TabIndex = 1;
            radioBtnLighlyActive.TabStop = true;
            radioBtnLighlyActive.Text = "Lightly Active (1 to 3)";
            radioBtnLighlyActive.UseVisualStyleBackColor = true;
            radioBtnLighlyActive.CheckedChanged += radioBtnLighlyActive_CheckedChanged;
            // 
            // radioBtnSedentery
            // 
            radioBtnSedentery.AutoSize = true;
            radioBtnSedentery.Location = new Point(12, 30);
            radioBtnSedentery.Name = "radioBtnSedentery";
            radioBtnSedentery.Size = new Size(282, 29);
            radioBtnSedentery.TabIndex = 0;
            radioBtnSedentery.TabStop = true;
            radioBtnSedentery.Text = "Sedentery (Little or no exercise)";
            radioBtnSedentery.UseVisualStyleBackColor = true;
            radioBtnSedentery.CheckedChanged += radioBtnSedentery_CheckedChanged;
            // 
            // txtBoxAge
            // 
            txtBoxAge.Location = new Point(283, 77);
            txtBoxAge.Name = "txtBoxAge";
            txtBoxAge.Size = new Size(81, 31);
            txtBoxAge.TabIndex = 14;
            txtBoxAge.TextChanged += txtBoxAge_TextChanged;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(174, 80);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(44, 25);
            lblAge.TabIndex = 13;
            lblAge.Text = "Age";
            lblAge.Click += lblAge_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Location = new Point(6, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(145, 103);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(6, 68);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(75, 29);
            rbMale.TabIndex = 1;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(6, 28);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(93, 29);
            rbFemale.TabIndex = 0;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // groupBoxBMRResults
            // 
            groupBoxBMRResults.Controls.Add(textBoxBMR);
            groupBoxBMRResults.Controls.Add(textBoxGainWholeKg);
            groupBoxBMRResults.Controls.Add(textBoxGainHalfKg);
            groupBoxBMRResults.Controls.Add(textBoxLoseWholeKg);
            groupBoxBMRResults.Controls.Add(textBoxLoseHalfKg);
            groupBoxBMRResults.Controls.Add(textBoxMaintainWeight);
            groupBoxBMRResults.Controls.Add(lblGainWholeKg);
            groupBoxBMRResults.Controls.Add(lblGainHalfKg);
            groupBoxBMRResults.Controls.Add(lblLoseWholeKg);
            groupBoxBMRResults.Controls.Add(lblLoseHalfKg);
            groupBoxBMRResults.Controls.Add(lblCaloriesMaintainWeight);
            groupBoxBMRResults.Controls.Add(lblYourBMR);
            groupBoxBMRResults.Location = new Point(833, 244);
            groupBoxBMRResults.Name = "groupBoxBMRResults";
            groupBoxBMRResults.Size = new Size(485, 328);
            groupBoxBMRResults.TabIndex = 13;
            groupBoxBMRResults.TabStop = false;
            groupBoxBMRResults.Text = " BMR Results";
            // 
            // textBoxBMR
            // 
            textBoxBMR.BackColor = SystemColors.Control;
            textBoxBMR.Location = new Point(290, 30);
            textBoxBMR.Name = "textBoxBMR";
            textBoxBMR.Size = new Size(150, 31);
            textBoxBMR.TabIndex = 11;
            textBoxBMR.TextChanged += textBoxBMR_TextChanged;
            // 
            // textBoxGainWholeKg
            // 
            textBoxGainWholeKg.BackColor = SystemColors.Control;
            textBoxGainWholeKg.Location = new Point(290, 277);
            textBoxGainWholeKg.Name = "textBoxGainWholeKg";
            textBoxGainWholeKg.Size = new Size(150, 31);
            textBoxGainWholeKg.TabIndex = 10;
            textBoxGainWholeKg.TextChanged += textBoxGainWholeKg_TextChanged;
            // 
            // textBoxGainHalfKg
            // 
            textBoxGainHalfKg.BackColor = SystemColors.Control;
            textBoxGainHalfKg.Location = new Point(290, 230);
            textBoxGainHalfKg.Name = "textBoxGainHalfKg";
            textBoxGainHalfKg.Size = new Size(150, 31);
            textBoxGainHalfKg.TabIndex = 9;
            textBoxGainHalfKg.TextChanged += textBoxGainHalfKg_TextChanged;
            // 
            // textBoxLoseWholeKg
            // 
            textBoxLoseWholeKg.BackColor = SystemColors.Control;
            textBoxLoseWholeKg.Location = new Point(290, 179);
            textBoxLoseWholeKg.Name = "textBoxLoseWholeKg";
            textBoxLoseWholeKg.Size = new Size(150, 31);
            textBoxLoseWholeKg.TabIndex = 8;
            textBoxLoseWholeKg.TextChanged += textBoxLoseWholeKg_TextChanged;
            // 
            // textBoxLoseHalfKg
            // 
            textBoxLoseHalfKg.BackColor = SystemColors.Control;
            textBoxLoseHalfKg.Location = new Point(290, 132);
            textBoxLoseHalfKg.Name = "textBoxLoseHalfKg";
            textBoxLoseHalfKg.Size = new Size(150, 31);
            textBoxLoseHalfKg.TabIndex = 7;
            textBoxLoseHalfKg.TextChanged += textBoxLoseHalfKg_TextChanged;
            // 
            // textBoxMaintainWeight
            // 
            textBoxMaintainWeight.BackColor = SystemColors.Control;
            textBoxMaintainWeight.Location = new Point(290, 81);
            textBoxMaintainWeight.Name = "textBoxMaintainWeight";
            textBoxMaintainWeight.Size = new Size(150, 31);
            textBoxMaintainWeight.TabIndex = 6;
            textBoxMaintainWeight.TextChanged += textBoxMaintainWeight_TextChanged;
            // 
            // lblGainWholeKg
            // 
            lblGainWholeKg.AutoSize = true;
            lblGainWholeKg.Location = new Point(7, 277);
            lblGainWholeKg.Name = "lblGainWholeKg";
            lblGainWholeKg.Size = new Size(246, 25);
            lblGainWholeKg.TabIndex = 5;
            lblGainWholeKg.Text = "Calories to gain 1kg per week";
            lblGainWholeKg.Click += lblGainWholeKg_Click;
            // 
            // lblGainHalfKg
            // 
            lblGainHalfKg.AutoSize = true;
            lblGainHalfKg.Location = new Point(7, 230);
            lblGainHalfKg.Name = "lblGainHalfKg";
            lblGainHalfKg.Size = new Size(260, 25);
            lblGainHalfKg.TabIndex = 4;
            lblGainHalfKg.Text = "Calories to gain 0.5kg per week";
            lblGainHalfKg.Click += lblGainHalfKg_Click;
            // 
            // lblLoseWholeKg
            // 
            lblLoseWholeKg.AutoSize = true;
            lblLoseWholeKg.Location = new Point(7, 179);
            lblLoseWholeKg.Name = "lblLoseWholeKg";
            lblLoseWholeKg.Size = new Size(244, 25);
            lblLoseWholeKg.TabIndex = 3;
            lblLoseWholeKg.Text = "Calories to lose 1kg per week";
            lblLoseWholeKg.Click += lblLoseWholeKg_Click;
            // 
            // lblLoseHalfKg
            // 
            lblLoseHalfKg.AutoSize = true;
            lblLoseHalfKg.Location = new Point(7, 132);
            lblLoseHalfKg.Name = "lblLoseHalfKg";
            lblLoseHalfKg.Size = new Size(258, 25);
            lblLoseHalfKg.TabIndex = 2;
            lblLoseHalfKg.Text = "Calories to lose 0.5kg per week";
            lblLoseHalfKg.Click += lblLoseHalfKg_Click;
            // 
            // lblCaloriesMaintainWeight
            // 
            lblCaloriesMaintainWeight.AutoSize = true;
            lblCaloriesMaintainWeight.Location = new Point(7, 81);
            lblCaloriesMaintainWeight.Name = "lblCaloriesMaintainWeight";
            lblCaloriesMaintainWeight.Size = new Size(268, 25);
            lblCaloriesMaintainWeight.TabIndex = 1;
            lblCaloriesMaintainWeight.Text = "Calories to maintain your weight";
            lblCaloriesMaintainWeight.Click += lblCaloriesMaintainWeight_Click;
            // 
            // lblYourBMR
            // 
            lblYourBMR.AutoSize = true;
            lblYourBMR.Location = new Point(21, 30);
            lblYourBMR.Name = "lblYourBMR";
            lblYourBMR.Size = new Size(199, 25);
            lblYourBMR.TabIndex = 0;
            lblYourBMR.Text = "Your BMR (calories/day)";
            lblYourBMR.Click += lblYourBMR_Click;
            // 
            // lblNormalWeightMetric
            // 
            lblNormalWeightMetric.Location = new Point(191, 115);
            lblNormalWeightMetric.Margin = new Padding(4, 0, 4, 0);
            lblNormalWeightMetric.Name = "lblNormalWeightMetric";
            lblNormalWeightMetric.Size = new Size(103, 25);
            lblNormalWeightMetric.TabIndex = 4;
            // 
            // lblNormalWeightImperial
            // 
            lblNormalWeightImperial.Location = new Point(191, 173);
            lblNormalWeightImperial.Margin = new Padding(4, 0, 4, 0);
            lblNormalWeightImperial.Name = "lblNormalWeightImperial";
            lblNormalWeightImperial.Size = new Size(103, 25);
            lblNormalWeightImperial.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 893);
            Controls.Add(groupBoxBMRResults);
            Controls.Add(groupBoxBMICalc);
            Controls.Add(groupBoxFutureValue);
            Controls.Add(groupBoxSavingPlan);
            Controls.Add(groupBoxResults);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Super calculator";
            Load += MainForm_Load;
            groupBoxUnit.ResumeLayout(false);
            groupBoxUnit.PerformLayout();
            groupBoxResults.ResumeLayout(false);
            groupBoxResults.PerformLayout();
            groupBoxSavingPlan.ResumeLayout(false);
            groupBoxSavingPlan.PerformLayout();
            groupBoxFutureValue.ResumeLayout(false);
            groupBoxFutureValue.PerformLayout();
            groupBoxBMICalc.ResumeLayout(false);
            groupBoxBMICalc.PerformLayout();
            groupBoxBMRCalculator.ResumeLayout(false);
            groupBoxBMRCalculator.PerformLayout();
            groupBoxWeeklyActivityLevel.ResumeLayout(false);
            groupBoxWeeklyActivityLevel.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxBMRResults.ResumeLayout(false);
            groupBoxBMRResults.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Label lblName;
        private TextBox txtBoxName;
        private Label lblHeight;
        private Label lblWeight;
        private TextBox txtBoxHeight;
        private TextBox txtBoxHeightInches;
        private TextBox txtBoxWeight;
        private GroupBox groupBoxUnit;
        private RadioButton radioBtnUsUnit;
        private RadioButton radioBtnMetric;
        private Button btnCalculateBMI;
        private GroupBox groupBoxResults;
        private Label lblResults;
        private Label lblWeightCategory;
        private TextBox txtBoxWeightCategory;
        private TextBox txtBoxResults;
        private GroupBox groupBoxSavingPlan;
        private Label lblInitialDeposit;
        private Label lblGrowth;
        private Label lblFees;
        private Label lblPeriod;
        private Label lblMonthlyDeposit;
        private TextBox txtBoxFees;
        private TextBox txtBoxGrowth;
        private TextBox txtBoxPeriod;
        private TextBox txtBoxMonthlyDeposit;
        private TextBox txtBoxInitalDeposit;
        private Button btnCalculateSaving;
        private GroupBox groupBoxFutureValue;
        private TextBox textBoxTotalFees;
        private TextBox textBoxFinalBalance;
        private TextBox textBoxAmountEarned;
       
        private Label lblTotalFees;
        private Label lblFinalBalance;
        private Label lblAmountEarned;
        private Label lblAmountPaid;
        private TextBox textBoxAmountPaid;
        private GroupBox groupBoxBMICalc;
        private GroupBox groupBoxBMRCalculator;
        private GroupBox groupBox1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label lblAge;
        private TextBox txtBoxAge;
        private GroupBox groupBoxWeeklyActivityLevel;
        private RadioButton radioBtnVeryActive;
        private RadioButton radioBtnModeratelyActive;
        private RadioButton radioBtnLighlyActive;
        private RadioButton radioBtnSedentery;
        private RadioButton radioBtnExtraActive;
        private Button btnCalculateBMR;
        private GroupBox groupBoxBMRResults;
        private Label lblGainWholeKg;
        private Label lblGainHalfKg;
        private Label lblLoseWholeKg;
        private Label lblLoseHalfKg;
        private Label lblCaloriesMaintainWeight;
        private Label lblYourBMR;
        private TextBox textBoxMaintainWeight;
        private TextBox textBoxBMR;
        private TextBox textBoxGainWholeKg;
        private TextBox textBoxGainHalfKg;
        private TextBox textBoxLoseWholeKg;
        private TextBox textBoxLoseHalfKg;
        private Label lblHeightBMR;
        private TextBox textBoxHeightBMR;
        private TextBox textBoxWeightBMR;
        private Label lblWeightBMR;
        private Label lblft;
        private Label lblIn;
        private Label lblNormalWeightMetric;
        private Label lblNormalWeightImperial;
    }
}

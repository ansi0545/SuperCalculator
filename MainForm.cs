using Assignment3;
using Assignment3.CalculatorClasses;
using System;
using System.Windows.Forms;

namespace Assignment3
{
    internal partial class MainForm : Form
    {
        private BmiCalculator bmiCalc;
        private SavingsCalculator savingsCalc;
        private BmrCalculator bmrCalc;
        




        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeCalculators();
            InitializeGUI();
        }


        /// <summary>
        /// Initializes the calculators used in the application.
        /// </summary>
        private void InitializeCalculators()
        {
            bmiCalc = new BmiCalculator();
            savingsCalc = new SavingsCalculator();
            bmrCalc = new BmrCalculator();
        }

        /// <summary>
        /// Initializes the graphical user interface.
        /// </summary>
        private void InitializeGUI()
        {
            // lblNormalWeightMetric = new Label();
            // lblNormalWeightMetric.Visible = false;
             //this.Controls.Add(lblNormalWeightMetric);

            // lblNormalWeightImperial = new Label();
            // lblNormalWeightImperial.Visible = false;
            // this.Controls.Add(lblNormalWeightImperial);
            ClearTextBoxes();
            radioBtnMetric.Checked = true;
        }

        /// <summary>
        /// Clears the text boxes in the form.
        /// </summary>
        private void ClearTextBoxes()
        {
            txtBoxName.Clear();
            txtBoxHeight.Clear();
            txtBoxWeight.Clear();
            txtBoxResults.Clear();
            txtBoxWeightCategory.Clear();
            textBoxAmountEarned.Clear();
            textBoxAmountPaid.Clear();
            textBoxBMR.Clear();
            textBoxMaintainWeight.Clear();
            textBoxLoseHalfKg.Clear();
            textBoxFinalBalance.Clear();
            textBoxGainHalfKg.Clear();
            textBoxGainWholeKg.Clear();
            textBoxLoseWholeKg.Clear();
            txtBoxInitalDeposit.Clear();
            txtBoxMonthlyDeposit.Clear();
            txtBoxPeriod.Clear();
            txtBoxGrowth.Clear();
            txtBoxFees.Clear();
            textBoxTotalFees.Clear();
            textBoxHeightBMR.Clear();
            textBoxWeightBMR.Clear();
            txtBoxAge.Clear();
        }


        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            ReadInputBmi();
            double bmi = bmiCalc.GetBmi();
            txtBoxResults.Text = bmi.ToString("0.00");
            txtBoxWeightCategory.Text = bmiCalc.GetBmiCategory();
            if (bmiCalc.GetUnit() == UnitTypes.Metric)
            {
                lblNormalWeightMetric.Text = bmiCalc.GetNormalWeightLimits();
                lblNormalWeightMetric.Visible = true;
                lblNormalWeightImperial.Visible = false;
            }
            else
            {
                lblNormalWeightImperial.Text = bmiCalc.GetNormalWeightLimits();
                lblNormalWeightImperial.Visible = true;
                lblNormalWeightMetric.Visible = false;
            }

        }


        private void ReadInputBmi()
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text))
            {
                MessageBox.Show("Name input cannot be empty for BMI");
                return;
            }
            else
            {
                bmiCalc.SetName(txtBoxName.Text);
            }
            if (double.TryParse(txtBoxWeight.Text, out double weight))
            {
                bmiCalc.SetWeight(weight);
            }
            else
            {
                MessageBox.Show("Invalid weight input for BMI");
                return;
            }

            if (radioBtnMetric.Checked)
            {
                if (double.TryParse(txtBoxHeight.Text, out double height))
                {
                    bmiCalc.SetHeight(height / 100); // Convert cm to m
                }
                else
                {
                    MessageBox.Show("Invalid height input for BMI");
                    return;
                }
                bmiCalc.SetUnit(UnitTypes.Metric);
            }
            else
            {
                if (double.TryParse(txtBoxHeight.Text, out double heightFeet) &&
                    double.TryParse(txtBoxHeightInches.Text, out double heightInches))
                {
                    bmiCalc.SetHeight(heightFeet * 12 + heightInches); // Convert feet to inches and add inches
                }
                else
                {
                    MessageBox.Show("Invalid height input for BMI");
                    return;
                }
                bmiCalc.SetUnit(UnitTypes.Imperial);
            }
        }

        private void ReadInputBmr()
        {
            double height;
            if (double.TryParse(textBoxHeightBMR.Text, out height))
            {
                bmrCalc.SetHeight(height); // Set height for BmrCalculator
            }
            else
            {
                MessageBox.Show("Invalid height input for BMR");
                return;
            }

            double weight;
            if (double.TryParse(textBoxWeightBMR.Text, out weight))
            {
                bmrCalc.SetWeight(weight); // Set weight for BmrCalculator
            }
            else
            {
                MessageBox.Show("Invalid weight input for BMR");
                return;
            }

            if (int.TryParse(txtBoxAge.Text, out int age))
            {
                bmrCalc.SetAge(age); // Set age for BmrCalculator
            }
            else
            {
                MessageBox.Show("Invalid age input for BMR");
                return;
            }
        }

        private void btnCalculateSaving_Click(object sender, EventArgs e)
        {
            double initialDeposit;
            if (!double.TryParse(txtBoxInitalDeposit.Text, out initialDeposit))
            {
                MessageBox.Show("Invalid initial deposit input");
                return;
            }

            double monthlyDeposit;
            if (!double.TryParse(txtBoxMonthlyDeposit.Text, out monthlyDeposit) || monthlyDeposit < 0.00)
            {
                MessageBox.Show("Invalid monthly deposit input");
                return;
            }

            int period;
            if (!int.TryParse(txtBoxPeriod.Text, out period) || period <= 0.00)
            {
                MessageBox.Show("Invalid period input");
                return;
            }

            double growthRate;
            if (!double.TryParse(txtBoxGrowth.Text, out growthRate) || growthRate <= 0.00)
            {
                MessageBox.Show("Invalid growth rate input");
                return;
            }

            double fees;
            if (!double.TryParse(txtBoxFees.Text, out fees))
            {
                MessageBox.Show("Invalid fees input");
                return;
            }

            savingsCalc.SetInitialDeposit(initialDeposit);
            savingsCalc.SetMonthlyDeposit(monthlyDeposit);
            savingsCalc.SetPeriod(period);
            savingsCalc.SetGrowthRate(growthRate);
            savingsCalc.SetFees(fees);

            double futureValue = savingsCalc.PerformCalculation();
            textBoxAmountEarned.Text = (futureValue - savingsCalc.GetTotalAmountPaid()).ToString("0.00");
            textBoxAmountPaid.Text = savingsCalc.GetTotalAmountPaid().ToString("0.00");

            textBoxTotalFees.Text = savingsCalc.GetTotalFees().ToString("0.00");
            textBoxFinalBalance.Text = (futureValue - savingsCalc.GetTotalFees()).ToString("0.00");
        }

        private void radioBtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            lblHeight.Text = "Height (cm)";
            lblWeight.Text = "Weight (kg)";
            txtBoxHeightInches.Visible = false;
            lblft.Visible = false;
            lblIn.Visible = false;
        }


        private void radioBtnUsUnit_CheckedChanged(object sender, EventArgs e)
        {
            lblHeight.Text = "Height (feet)";
            lblWeight.Text = "Weight (lbs)";
            txtBoxHeightInches.Visible = true;
            lblft.Visible = true;
            lblIn.Visible = true;
        }


        private void btnCalculateBMI_Click_1(object sender, EventArgs e)
        {
            btnCalculateBMI_Click(sender, e);
        }


        private void radioBtnMetric_CheckedChanged_1(object sender, EventArgs e)
        {
            radioBtnMetric_CheckedChanged(sender, e);
        }


        private void radioBtnUsUnit_CheckedChanged_1(object sender, EventArgs e)
        {
            radioBtnUsUnit_CheckedChanged(sender, e);
        }


        private void txtBHeight_TextChanged(object sender, EventArgs e)
        {
            double height;
            if (!double.TryParse(txtBoxHeight.Text, out height) || height <= 0)
            {
                MessageBox.Show("Invalid height input");
            }
        }


        private void txtBWeight_TextChanged(object sender, EventArgs e)
        {
            double weight;
            if (!double.TryParse(txtBoxWeight.Text, out weight) || weight <= 0)
            {
                MessageBox.Show("Invalid weight input");
            }
        }




        private void txtBoxWeightCategory_TextChanged(object sender, EventArgs e)
        {

        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void groupBoxSavingPlan_Enter(object sender, EventArgs e)
        {

        }


        private void txtBoxInitalDeposit_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtBoxMonthlyDeposit_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtBoxPeriod_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtBoxGrowth_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtBoxFees_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxAmountEarned_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxAmountPaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxUnit_Enter(object sender, EventArgs e)
        {

        }


        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetIsMale(false); // Set gender for BmrCalculator
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetIsMale(true); // Set gender for BmrCalculator
        }

        private void txtBoxAge_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxAge.Text, out int age))
            {
                bmrCalc.SetAge(age);
            }
        }

        private void btnCalculateBMR_Click(object sender, EventArgs e)
        {
            ReadInputBmr();
            double bmr = bmrCalc.GetBmr();
            textBoxBMR.Text = bmr.ToString("0.00");


            textBoxMaintainWeight.Text = bmrCalc.CalculateMaintainWeightBmr().ToString("0.00");
            textBoxLoseHalfKg.Text = bmrCalc.CalculateWeightChangeBmr(-0.5).ToString("0.00");
            textBoxLoseWholeKg.Text = bmrCalc.CalculateWeightChangeBmr(-1).ToString("0.00");
            textBoxGainHalfKg.Text = bmrCalc.CalculateWeightChangeBmr(0.5).ToString("0.00");
            textBoxGainWholeKg.Text = bmrCalc.CalculateWeightChangeBmr(1).ToString("0.00");
        }

        private void radioBtnSedentery_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetActivityLevel(1.2);
        }

        private void radioBtnLighlyActive_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetActivityLevel(1.375);
        }

        private void radioBtnModeratelyActive_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetActivityLevel(1.55);
        }

        private void radioBtnVeryActive_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetActivityLevel(1.725);
        }

        private void radioBtnExtraActive_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetActivityLevel(1.9);
        }

        private void textBoxGainWholeKg_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHeightBMR_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHeightBMR_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWeightBMR_Click(object sender, EventArgs e)
        {

        }

        private void textBoxWeightBMR_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void lblYourBMR_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBMR_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCaloriesMaintainWeight_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMaintainWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLoseHalfKg_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLoseHalfKg_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLoseWholeKg_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLoseWholeKg_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGainHalfKg_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGainHalfKg_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGainWholeKg_Click(object sender, EventArgs e)
        {

        }

        private void lblHeightBMR_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxHeightBMR_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblWeightBMR_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxWeightBMR_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblNameBMR_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNameBMR_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNormalWeightImperial_Click(object sender, EventArgs e)
        {

        }

        private void lblNormalWeightMetric_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Windows.Forms;

namespace Standard_Scientific_Mortgage_Calculator_And_Simple_Convervions
{
    public partial class Form1 : Form
    {
        double results = 0;
        string operation = "";
        bool enter_value = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 286;
            calculatorEntryBox.Width = 257;
            calculatorEntryBox.Visible = true;
            groupBoxStandardCalculatorKeys.Visible = true;
            groupBoxScientificCalculatorKeys.Visible = false;
            groupBoxTemperatureCoverter.Visible = false;
            groupBoxTemperatureSelection.Visible = false;
            groupBoxStandardToStandardLengthConverter.Visible = false;
            groupBoxSelect_S_To_S.Visible = false;
            groupBoxMetricToStandardLengthConverter.Visible = false;
            groupBoxSelect_M_To_S.Visible = false;
            groupBoxMetricToMetricLengthConvertion.Visible = false;
            groupBoxSelect_M_To_M.Visible = false;
            groupBoxStandardToMetricLengthConverter.Visible = false;
            groupBoxSelect_S_To_M.Visible = false;
            groupBoxWeightConverter.Visible = false;
            groupBoxSelectWeight.Visible = false;
            groupBoxVolumeConverter.Visible = false;
            groupBoxSelectVolume.Visible = false;
            groupBoxMortgageCalculator.Visible = false;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 286;
            calculatorEntryBox.Width = 257;
            calculatorEntryBox.Visible = true;
            groupBoxStandardCalculatorKeys.Visible = true;
            groupBoxScientificCalculatorKeys.Visible = false;
            groupBoxTemperatureCoverter.Visible = false;
            groupBoxTemperatureSelection.Visible = false;
            groupBoxStandardToStandardLengthConverter.Visible = false;
            groupBoxSelect_S_To_S.Visible = false;
            groupBoxMetricToStandardLengthConverter.Visible = false;
            groupBoxSelect_M_To_S.Visible = false;
            groupBoxMetricToMetricLengthConvertion.Visible = false;
            groupBoxSelect_M_To_M.Visible = false;
            groupBoxStandardToMetricLengthConverter.Visible = false;
            groupBoxSelect_S_To_M.Visible = false;
            groupBoxVolumeConverter.Visible = false;
            groupBoxSelectVolume.Visible = false;
            groupBoxMortgageCalculator.Visible = false;
        }

        //Standard Calculator Code

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (calculatorEntryBox.Text.Length > 0)
            {
                calculatorEntryBox.Text = calculatorEntryBox.Text.Remove(calculatorEntryBox.Text.Length - 1, 1);
            }

            if (calculatorEntryBox.Text == "")
            {
                calculatorEntryBox.Text = "0";
            }
        }
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            calculatorEntryBox.Text = "0";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            calculatorEntryBox.Text = "0";
        }
        private void numericalNumbersAndDecimalButton_Click(object sender, EventArgs e)
        {
            if ((calculatorEntryBox.Text == "0") || enter_value)
                calculatorEntryBox.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!calculatorEntryBox.Text.Contains("."))
                    calculatorEntryBox.Text += num.Text;
            }
            else
                calculatorEntryBox.Text += num.Text;
        }

        private void standardArithmaticOperatorsPlusExpAndMod(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(calculatorEntryBox.Text);
            calculatorEntryBox.Text = "";

        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "/":
                    calculatorEntryBox.Text = (results / Double.Parse(calculatorEntryBox.Text)).ToString();
                    break;

                case "*":
                    calculatorEntryBox.Text = (results * Double.Parse(calculatorEntryBox.Text)).ToString();
                    break;

                case "-":
                    calculatorEntryBox.Text = (results - Double.Parse(calculatorEntryBox.Text)).ToString();
                    break;
                case "+":
                    calculatorEntryBox.Text = (results + Double.Parse(calculatorEntryBox.Text)).ToString();
                    break;

                case "Mod":
                    calculatorEntryBox.Text = (results % Double.Parse(calculatorEntryBox.Text)).ToString();
                    break;

                case "Exp":
                    double iExp = Double.Parse(calculatorEntryBox.Text);
                    calculatorEntryBox.Text = Math.Exp(iExp).ToString();
                    break;


            }
        }

        //Scientific Calculator Code
        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 548;
            calculatorEntryBox.Width = 517;
            calculatorEntryBox.Visible = true;
            groupBoxStandardCalculatorKeys.Visible = true;
            groupBoxScientificCalculatorKeys.Visible = true;
            groupBoxTemperatureCoverter.Visible = false;
            groupBoxTemperatureSelection.Visible = false;
            groupBoxStandardToStandardLengthConverter.Visible = false;
            groupBoxSelect_S_To_S.Visible = false;
            groupBoxMetricToStandardLengthConverter.Visible = false;
            groupBoxSelect_M_To_S.Visible = false;
            groupBoxMetricToMetricLengthConvertion.Visible = false;
            groupBoxSelect_M_To_M.Visible = false;
            groupBoxStandardToMetricLengthConverter.Visible = false;
            groupBoxSelect_S_To_M.Visible = false;
            groupBoxWeightConverter.Visible = false;
            groupBoxSelectWeight.Visible = false;
            groupBoxVolumeConverter.Visible = false;
            groupBoxSelectVolume.Visible = false;
            groupBoxMortgageCalculator.Visible = false;
        }
        private void btnPi_Click(object sender, EventArgs e)
        {
            calculatorEntryBox.Text = "3.1415926553589976323";
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            double iLog = Double.Parse(calculatorEntryBox.Text);
            iLog = Math.Log10(iLog);
            calculatorEntryBox.Text = Convert.ToString(iLog);
        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double iSqrt = Double.Parse(calculatorEntryBox.Text);
            iSqrt = Math.Sqrt(iSqrt);
            calculatorEntryBox.Text = Convert.ToString(iSqrt);
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            Double i = Convert.ToDouble(calculatorEntryBox.Text) * Convert.ToDouble(calculatorEntryBox.Text);
            calculatorEntryBox.Text = Convert.ToString(i);
        }
        private void btnSinh_Click(object sender, EventArgs e)
        {
            double iSinh = Double.Parse(calculatorEntryBox.Text);
            iSinh = Math.Sinh(iSinh);
            calculatorEntryBox.Text = Convert.ToString(iSinh);
        }
        private void btnSin_Click(object sender, EventArgs e)
        {
            double iSin = Double.Parse(calculatorEntryBox.Text);
            iSin = Math.Sin(iSin);
            calculatorEntryBox.Text = Convert.ToString(iSin);
        }
        private void btnDec_Click(object sender, EventArgs e)
        {
            int i = int.Parse(calculatorEntryBox.Text);
            calculatorEntryBox.Text = Convert.ToString(i);
        }
        private void btnCube_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(calculatorEntryBox.Text) * Convert.ToDouble(calculatorEntryBox.Text) * Convert.ToDouble(calculatorEntryBox.Text);
            calculatorEntryBox.Text = Convert.ToString(i);
        }
        private void btnCosh_Click(object sender, EventArgs e)
        {
            double iCosh = Double.Parse(calculatorEntryBox.Text);
            iCosh = Math.Cosh(iCosh);
            calculatorEntryBox.Text = Convert.ToString(iCosh);
        }
        private void btnCos_Click(object sender, EventArgs e)
        {
            double iCos = Double.Parse(calculatorEntryBox.Text);
            iCos = Math.Cos(iCos);
            calculatorEntryBox.Text = Convert.ToString(iCos);
        }
        private void btnBin_Click(object sender, EventArgs e)
        {
            int i = int.Parse(calculatorEntryBox.Text);
            calculatorEntryBox.Text = Convert.ToString(i, 2);
        }
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(1.0 / Convert.ToDouble(calculatorEntryBox.Text));
            calculatorEntryBox.Text = Convert.ToString(i);
        }
        private void btnTanh_Click(object sender, EventArgs e)
        {
            double iTanh = Double.Parse(calculatorEntryBox.Text);
            iTanh = Math.Tanh(iTanh);
            calculatorEntryBox.Text = Convert.ToString(iTanh);
        }
        private void btnTan_Click(object sender, EventArgs e)
        {
            double iTan = Double.Parse(calculatorEntryBox.Text);
            iTan = Math.Sqrt(iTan);
            calculatorEntryBox.Text = Convert.ToString(iTan);
        }
        private void btnHex_Click(object sender, EventArgs e)
        {
            int i = int.Parse(calculatorEntryBox.Text);
            calculatorEntryBox.Text = Convert.ToString(i, 16);
        }
        private void btnNaturalLogarithm_Click(object sender, EventArgs e)
        {
            double iLog = Double.Parse(calculatorEntryBox.Text);
            iLog = Math.Log(iLog);
            calculatorEntryBox.Text = Convert.ToString(iLog);
        }
        private void btnOct_Click(object sender, EventArgs e)
        {
            int i = int.Parse(calculatorEntryBox.Text);
            calculatorEntryBox.Text = Convert.ToString(i, 8);
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(calculatorEntryBox.Text) / Convert.ToDouble(100);
            calculatorEntryBox.Text = Convert.ToString(i);
        }


        // Temperture Converter Code

        private void tempertureConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 900;
            calculatorEntryBox.Width = 517;
            calculatorEntryBox.Visible = true;
            groupBoxStandardCalculatorKeys.Visible = true;
            groupBoxScientificCalculatorKeys.Visible = true;
            groupBoxTemperatureCoverter.Visible = true;
            groupBoxTemperatureSelection.Visible = true;
            groupBoxStandardToStandardLengthConverter.Visible = false;
            groupBoxSelect_S_To_S.Visible = false;
            groupBoxMetricToStandardLengthConverter.Visible = false;
            groupBoxSelect_M_To_S.Visible = false;
            groupBoxMetricToMetricLengthConvertion.Visible = false;
            groupBoxSelect_M_To_M.Visible = false;
            groupBoxStandardToMetricLengthConverter.Visible = false;
            groupBoxSelect_S_To_M.Visible = false;
            groupBoxWeightConverter.Visible = false;
            groupBoxSelectWeight.Visible = false;
            groupBoxVolumeConverter.Visible = false;
            groupBoxSelectVolume.Visible = false;
            groupBoxMortgageCalculator.Visible = false;
        }

        float iCelsius;
        float iFahrenheit;
        float iKelvin;
        char iOperation;

        private void rbCelciusToFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }
        private void rbFahrenheitToCelsius_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }
        private void rbFahrenheitToKelvin_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }
        private void rbCelsiusToKelvin_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'I';
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                //Celsius to Fehrenheit
                case 'C':
                    iCelsius = float.Parse(temperatureEntryBox.Text);
                    conversionTextBox.Text = ((((9 * iCelsius) / 5) + 32).ToString());
                    break;

                //Fehrenheit to Celsius
                case 'F':
                    iFahrenheit = float.Parse(temperatureEntryBox.Text);
                    conversionTextBox.Text = ((((iFahrenheit - 32) * 5) / 9).ToString());
                    break;

                //Fahrenheit to Kelvin
                case 'K':
                    iKelvin = float.Parse(temperatureEntryBox.Text);
                    conversionTextBox.Text = (((((iKelvin - 32) * 5) / 9) + 273.15).ToString());
                    break;

                //Celsius to Kelvin
                case 'I':
                    iKelvin = float.Parse(temperatureEntryBox.Text);
                    conversionTextBox.Text = (iKelvin + 273.15).ToString();
                    break;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            temperatureEntryBox.Clear();
            conversionTextBox.Text = "";
            rbCelciusToFahrenheit.Checked = false;
            rbFahrenheitToCelsius.Checked = false;
            rbFahrenheitToKelvin.Checked = false;
            rbFahrenheitToKelvin.Checked = false;
            rbCelsiusToKelvin.Checked = false;
        }
        // Start of Length Converter Tab.
        private void lengthConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1310;
            calculatorEntryBox.Visible = false;
            groupBoxStandardCalculatorKeys.Visible = false;
            groupBoxScientificCalculatorKeys.Visible = false;
            groupBoxTemperatureCoverter.Visible = false;
            groupBoxTemperatureSelection.Visible = false;
            groupBoxStandardToStandardLengthConverter.Visible = true;
            groupBoxSelect_S_To_S.Visible = true;
            groupBoxMetricToStandardLengthConverter.Visible = true;
            groupBoxSelect_M_To_S.Visible = true;
            groupBoxMetricToMetricLengthConvertion.Visible = true;
            groupBoxSelect_M_To_M.Visible = true;
            groupBoxStandardToMetricLengthConverter.Visible = true;
            groupBoxSelect_S_To_M.Visible = true;
            groupBoxWeightConverter.Visible = false;
            groupBoxSelectWeight.Visible = false;
            groupBoxVolumeConverter.Visible = false;
            groupBoxSelectVolume.Visible = false;
            groupBoxMortgageCalculator.Visible = false;
        }


        // Metric To Standard Length Converter Box 
        double iMillimeter;
        double iCentimeter;
        double iMeter;
        double iKilometer;
        string jOperation;

        private void rbMilimeterToInch_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "MMtoIN";
        }
        private void rbMillimeterToFoot_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "MMtoFT";
        }
        private void rbMillimeterToYard_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "MMtoYD";
        }
        private void rbMillimeterToMile_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "MMtoMI";
        }
        private void rbCentimeterToInch_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "CMtoIN";
        }
        private void rbCentimeterToFoot_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "CMtoFT";
        }
        private void rbCentimeterToYard_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "CMtoYD";
        }
        private void rbCentimeterToMile_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "CMtoMI";
        }
        private void rbMeterToIn_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "MtoIN";
        }
        private void rbMeterToFoot_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "MtoFT";
        }
        private void rbMeterToYard_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "MtoYD";
        }
        private void rbMeterToMile_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "MtoMI";
        }
        private void rbKilometerToInch_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "KMtoIN";
        }
        private void rbKilometerToFoot_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "KMtoFT";
        }
        private void rbKilometerToYard_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "KMtoYD";
        }
        private void rbKilometerToMile_CheckedChanged(object sender, EventArgs e)
        {
            jOperation = "KMtoMI";
        }
        private void btnMetrictoStandardConvert_Click(object sender, EventArgs e)
        {
            switch (jOperation)
            {
                //Millimeters conversion code
                case "MMtoIN":
                    iMillimeter = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iMillimeter / 25.4).ToString();
                    break;
                case "MMtoFT":
                    iMillimeter = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iMillimeter / 304.8).ToString();
                    break;
                case "MMtoYD":
                    iMillimeter = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iMillimeter / 914.4).ToString();
                    break;
                case "MMtoMI":
                    iMillimeter = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iMillimeter / 1609344).ToString();
                    break;

                //Centimeters conversion code
                case "CMtoIN":
                    iCentimeter = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iCentimeter / 2.54).ToString();
                    break;
                case "CMtoFT":
                    iCentimeter = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iCentimeter / 30.48).ToString();
                    break;
                case "CMtoYD":
                    iCentimeter = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iCentimeter / 91.44).ToString();
                    break;
                case "CMtoMI":
                    iCentimeter = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iCentimeter / 160934).ToString();
                    break;

                //Meters Conversion Code
                case "MtoIN":
                    iMeter = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iMeter / 0.0254).ToString();
                    break;
                case "MtoFT":
                    iMeter = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iMeter / 0.3048).ToString();
                    break;
                case "MtoYD":
                    iMeter = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iMeter / 0.9144).ToString();
                    break;
                case "MtoMI":
                    iMeter = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iMeter / 1609.34).ToString();
                    break;

                // Kilometer convertion code
                case "KMtoIN":
                    iKilometer = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iKilometer / 0.0000254).ToString();
                    break;
                case "KMtoFT":
                    iKilometer = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iKilometer / 0.0003048).ToString();
                    break;
                case "KMtoYD":
                    iKilometer = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iKilometer / 0.0009144).ToString();
                    break;
                case "KMtoMI":
                    iKilometer = double.Parse(metricToStandardLenthEntryBox.Text);
                    metricToStandardConvsionBox.Text = (iKilometer / 1.60934).ToString();
                    break;
            }
        }
        private void btnLengthMetricReset_Click(object sender, EventArgs e)
        {
            metricToStandardLenthEntryBox.Clear();
            metricToStandardConvsionBox.Text = "";
            rbMilimeterToInch.Checked = false;
            rbMillimeterToFoot.Checked = false;
            rbMillimeterToYard.Checked = false;
            rbMillimeterToMile.Checked = false;
            rbCentimeterToInch.Checked = false;
            rbCentimeterToFoot.Checked = false;
            rbCentimeterToYard.Checked = false;
            rbCentimeterToMile.Checked = false;
            rbMeterToIn.Checked = false;
            rbMeterToFoot.Checked = false;
            rbMeterToYard.Checked = false;
            rbMeterToMile.Checked = false;
            rbKilometerToInch.Checked = false;
            rbKilometerToFoot.Checked = false;
            rbKilometerToYard.Checked = false;
            rbKilometerToMile.Checked = false;
        }

        // Metric to Metric Length Converter Box
        string kOperation;

        private void rbMillimeterToCentimeter_CheckedChanged(object sender, EventArgs e)
        {
            kOperation = "MMtoCM";
        }
        private void rbMillimeterToMeter_CheckedChanged(object sender, EventArgs e)
        {
            kOperation = "MMtoM";
        }
        private void rbMillimeterToKilometer_CheckedChanged(object sender, EventArgs e)
        {
            kOperation = "MMtoKM";
        }
        private void rbCentimeterToMillimeter_CheckedChanged(object sender, EventArgs e)
        {
            kOperation = "CMtoMM";
        }
        private void rbCentimeterToMeter_CheckedChanged(object sender, EventArgs e)
        {
            kOperation = "CMtoM";
        }
        private void rbCentimeterToKilometer_CheckedChanged(object sender, EventArgs e)
        {
            kOperation = "CMtoKM";
        }
        private void rbMeterToMillimeter_CheckedChanged(object sender, EventArgs e)
        {
            kOperation = "MtoMM";
        }
        private void rbMeterToCentimeter_CheckedChanged(object sender, EventArgs e)
        {
            kOperation = "MtoCM";
        }
        private void rbMeterToKilometer_CheckedChanged(object sender, EventArgs e)
        {
            kOperation = "MtoKM";
        }
        private void rbKilometerToMillimeter_CheckedChanged(object sender, EventArgs e)
        {
            kOperation = "KMtoMM";
        }
        private void rbKilometerToCentimeter_CheckedChanged(object sender, EventArgs e)
        {
            kOperation = "KMtoCM";
        }
        private void rbKilometerToMeter_CheckedChanged(object sender, EventArgs e)
        {
            kOperation = "KMtoM";
        }
        private void btnMetricToMetricConvert_Click(object sender, EventArgs e)
        {
            switch(kOperation)
            {
                //Metric to Metric Millimeter Conversion Code
                case "MMtoCM":
                    iMillimeter = double.Parse(textBoxMetricToMetricEntry.Text);
                    textBoxMetricToMetricConversion.Text = (iMillimeter / 10).ToString();
                    break;
                case "MMtoM":
                    iMillimeter = double.Parse(textBoxMetricToMetricEntry.Text);
                    textBoxMetricToMetricConversion.Text = (iMillimeter / 1000).ToString();
                    break;
                case "MMtoKM":
                    iMillimeter = double.Parse(textBoxMetricToMetricEntry.Text);
                    textBoxMetricToMetricConversion.Text = (iMillimeter / 1000000).ToString();
                    break;

                //Metric to Metric Centimeter conversion code
                case "CMtoMM":
                    iCentimeter = double.Parse(textBoxMetricToMetricEntry.Text);
                    textBoxMetricToMetricConversion.Text = (iCentimeter * 10).ToString();
                    break;
                case "CMtoM":
                    iCentimeter = double.Parse(textBoxMetricToMetricEntry.Text);
                    textBoxMetricToMetricConversion.Text = (iCentimeter / 100).ToString();
                    break;
                case "CMtoKM":
                    iCentimeter = double.Parse(textBoxMetricToMetricEntry.Text);
                    textBoxMetricToMetricConversion.Text = (iCentimeter / 100000).ToString();
                    break;

                //Metric to Metric Meters Conversion Code
                case "MtoMM":
                    iMeter = double.Parse(textBoxMetricToMetricEntry.Text);
                    textBoxMetricToMetricConversion.Text = (iMeter * 1000).ToString();
                    break;
                case "MtoCM":
                    iMeter = double.Parse(textBoxMetricToMetricEntry.Text);
                    textBoxMetricToMetricConversion.Text = (iMeter * 100).ToString();
                    break;
                case "MtoKM":
                    iMeter = double.Parse(textBoxMetricToMetricEntry.Text);
                    textBoxMetricToMetricConversion.Text = (iMeter / 1000).ToString();
                    break;

                // Metric to Metric Kilometer convertion code
                case "KMtoMM":
                    iKilometer = double.Parse(textBoxMetricToMetricEntry.Text);
                    textBoxMetricToMetricConversion.Text = (iKilometer * 1000000).ToString();
                    break;
                case "KMtoCM":
                    iKilometer = double.Parse(textBoxMetricToMetricEntry.Text);
                    textBoxMetricToMetricConversion.Text = (iKilometer * 100000).ToString();
                    break;
                case "KMtoM":
                    iKilometer = double.Parse(textBoxMetricToMetricEntry.Text);
                    textBoxMetricToMetricConversion.Text = (iKilometer * 1000).ToString();
                    break;
            }
        }
        private void btnResetMetricToMetric_Click(object sender, EventArgs e)
        {
            textBoxMetricToMetricEntry.Clear();
            textBoxMetricToMetricConversion.Text = "";
            rbMillimeterToCentimeter.Checked = false;
            rbMillimeterToMeter.Checked = false;
            rbMillimeterToKilometer.Checked = false;
            rbCentimeterToMillimeter.Checked = false;
            rbCentimeterToMeter.Checked = false;
            rbCentimeterToKilometer.Checked = false;
            rbMeterToMillimeter.Checked = false;
            rbMeterToCentimeter.Checked = false;
            rbMeterToKilometer.Checked = false;
            rbKilometerToMillimeter.Checked = false;
            rbKilometerToCentimeter.Checked = false;
            rbKilometerToMeter.Checked = false;
        }

        //Standard to Standard Length Converter Box
        double iInch;
        double iFoot;
        double iYard;
        double iMile;
        string lOperation;
        private void rbInchToFoot_CheckedChanged(object sender, EventArgs e)
        {
            lOperation = "INtoFT";
        }
        private void rbInchToYard_CheckedChanged(object sender, EventArgs e)
        {
            lOperation = "INtoYD";
        }
        private void rbInchToMile_CheckedChanged(object sender, EventArgs e)
        {
            lOperation = "IntoMI";
        }
        private void rbFootToInch_CheckedChanged(object sender, EventArgs e)
        {
            lOperation = "FTtoIN";
        }
        private void rbFootToYard_CheckedChanged(object sender, EventArgs e)
        {
            lOperation = "FTtoYD";
        }
        private void rbFootToMile_CheckedChanged(object sender, EventArgs e)
        {
            lOperation = "FTtoMI";
        }

        private void rbYardToInch_CheckedChanged(object sender, EventArgs e)
        {
            lOperation = "YDtoIn";
        }
        private void rbYardToFoot_CheckedChanged(object sender, EventArgs e)
        {
            lOperation = "YDtoFT";
        }
        private void rbYardToMile_CheckedChanged(object sender, EventArgs e)
        {
            lOperation = "YDtoMI";
        }
        private void rbMileToInch_CheckedChanged(object sender, EventArgs e)
        {
            lOperation = "MItoIn";
        }
        private void rbMileToFoot_CheckedChanged(object sender, EventArgs e)
        {
            lOperation = "MItoFT";
        }
        private void rbMileToYard_CheckedChanged(object sender, EventArgs e)
        {
            lOperation = "MItoYD";
        }

        private void btnStandardToStandardConvert_Click(object sender, EventArgs e)
        {
            switch(lOperation)
            {
                //Standard Inch Conversion Code
                case "INtoFT":
                    iInch = double.Parse(textBoxStandardToStandardEntry.Text);
                    textBoxStandardToStandardConversion.Text = (iInch / 12).ToString();
                    break;
                case "INtoYD":
                    iInch = double.Parse(textBoxStandardToStandardEntry.Text);
                    textBoxStandardToStandardConversion.Text = (iInch / 36).ToString();
                    break;
                case "INtoMI":
                    iInch = double.Parse(textBoxStandardToStandardEntry.Text);
                    textBoxStandardToStandardConversion.Text = (iInch / 63360).ToString();
                    break;

                //Standard to Standard Foot conversion code
                case "FTtoIN":
                    iFoot = double.Parse(textBoxStandardToStandardEntry.Text);
                    textBoxStandardToStandardConversion.Text = (iFoot * 12).ToString();
                    break;
                case "FTtoYD":
                    iFoot = double.Parse(textBoxStandardToStandardEntry.Text);
                    textBoxStandardToStandardConversion.Text = (iFoot / 3).ToString();
                    break;
                case "FTtoMI":
                    iFoot = double.Parse(textBoxStandardToStandardEntry.Text);
                    textBoxStandardToStandardConversion.Text = (iFoot / 5280).ToString();
                    break;

                //Standard to Standard Yard conversion code
                case "YDtoIN":
                    iYard = double.Parse(textBoxStandardToStandardEntry.Text);
                    textBoxStandardToStandardConversion.Text = (iYard * 36).ToString();
                    break;
                case "YDtoFT":
                    iYard = double.Parse(textBoxStandardToStandardEntry.Text);
                    textBoxStandardToStandardConversion.Text = (iYard * 3).ToString();
                    break;
                case "YDtoMI":
                    iYard = double.Parse(textBoxStandardToStandardEntry.Text);
                    textBoxStandardToStandardConversion.Text = (iYard / 1760).ToString();
                    break;

                //Standard to Standard Mile conversion code
                case "MItoIN":
                    iMile = double.Parse(textBoxStandardToStandardEntry.Text);
                    textBoxStandardToStandardConversion.Text = (iMile * 63360).ToString();
                    break;
                case "MItoFT":
                    iMile = double.Parse(textBoxStandardToStandardEntry.Text);
                    textBoxStandardToStandardConversion.Text = (iMile * 5280).ToString();
                    break;
                case "MItoYD":
                    iMile = double.Parse(textBoxStandardToStandardEntry.Text);
                    textBoxStandardToStandardConversion.Text = (iMile * 1760).ToString();
                    break;

            }
        }
        private void btnResetStandardToStandard_Click(object sender, EventArgs e)
        {
            textBoxStandardToStandardEntry.Clear();
            textBoxStandardToStandardConversion.Text = "";
            rbInchToFoot.Checked = false;
            rbInchToYard.Checked = false;
            rbInchToMile.Checked = false;
            rbFootToInch.Checked = false;
            rbFootToYard.Checked = false;
            rbFootToMile.Checked = false;
            rbYardToInch.Checked = false;
            rbYardToFoot.Checked = false;
            rbYardToMile.Checked = false;
            rbMileToInch.Checked = false;
            rbMileToFoot.Checked = false;
            rbMileToYard.Checked = false;
        }


        // Standard to Metric Length Converter Box

        string mOperation;
        private void rbInchToMillimeter_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "INtoMM";
        }
        private void rbInchToCentimeter_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "INtoCM";
        }
        private void rbInchToMeter_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "INtoM";
        }
        private void rbInchToKilometer_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "INtoKM";
        }
        private void rbFootToMillimeter_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "FTtoMM";
        }
        private void rbFootToCentimeter_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "FTtoCM";
        }
        private void rbFootToMeter_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "FTtoM";
        }
        private void rbFootToKilometer_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "FTtoKM";
        }
        private void rbYardToMillimeter_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "YDtoMM";
        }
        private void rbYardToCentimeter_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "YDtoCM";
        }
        private void rbYardToMeter_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "YDtoM";
        }

        private void rbYardsToKilometer_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "YDtoKM";
        }
        private void rbMileToMillimeter_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "MItoMM";
        }
        private void rbMileToCentimeter_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "MItoCM";
        }
        private void rbMileToMeter_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "MItoM";
        }
        private void rbMileToKilometer_CheckedChanged(object sender, EventArgs e)
        {
            mOperation = "MItoKM";
        }

        private void btnStandardToMetricConvert_Click(object sender, EventArgs e)
        {
            switch(mOperation)
            {
                case "INtoMM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iInch * 25.4).ToString();
                    break;
                case "IntoCM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iInch * 2.54).ToString();
                    break;
                case "IntoM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iInch * 0.0254).ToString();
                    break;
                case "INtoKM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iInch * 0.0000254).ToString();
                    break;
                case "FTtoMM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iFoot * 304.8).ToString();
                    break;
                case "FTtoCM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iFoot * 30.48).ToString();
                    break;
                case "FTtoM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iFoot * 0.3048).ToString();
                    break;
                case "FTtoKM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iFoot * 0.0003048).ToString();
                    break;
                case "YDtoMM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iYard * 914.4).ToString();
                    break;
                case "YDtoCM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iYard * 91.44).ToString();
                    break;
                case "YDtoM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iYard * 0.9144).ToString();
                    break;
                case "YDtoKM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iYard * 0.0009144).ToString();
                    break;
                case "MItoMM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iMile * 1609344).ToString();
                    break;
                case "MItoCM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iMile * 160934).ToString();
                    break;
                case "MItoM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iMile * 1609.34).ToString();
                    break;
                case "MItoKM":
                    iMile = double.Parse(textBoxStandardToMetricEntry.Text);
                    textBoxStandardToMetricConversion.Text = (iMile * 1.60934).ToString();
                    break;

            }
        }

        private void btnResetStandardToMetric_Click(object sender, EventArgs e)
        {
            textBoxStandardToMetricEntry.Clear();
            textBoxStandardToMetricConversion.Text = "";
            rbInchToMillimeter.Checked = false;
            rbInchToCentimeter.Checked = false;
            rbInchToMeter.Checked = false;
            rbInchToKilometer.Checked = false;
            rbFootToMillimeter.Checked = false;
            rbFootToCentimeter.Checked = false;
            rbFootToMeter.Checked = false;
            rbFootToKilometer.Checked = false;
            rbYardToMillimeter.Checked = false;
            rbYardToCentimeter.Checked = false;
            rbYardToMeter.Checked = false;
            rbYardsToKilometer.Checked = false;
            rbMileToMillimeter.Checked = false;
            rbMileToCentimeter.Checked = false;
            rbMileToMeter.Checked = false;
            rbMileToKilometer.Checked = false;
        }

        //Weight Converter Box
        private void weightConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 878;
            calculatorEntryBox.Width = 517;
            calculatorEntryBox.Visible = true;
            groupBoxStandardCalculatorKeys.Visible = true;
            groupBoxScientificCalculatorKeys.Visible = true;
            groupBoxWeightConverter.Visible = true;
            groupBoxSelectWeight.Visible = true;
            groupBoxTemperatureCoverter.Visible = false;
            groupBoxTemperatureSelection.Visible = false;
            groupBoxStandardToStandardLengthConverter.Visible = false;
            groupBoxSelect_S_To_S.Visible = false;
            groupBoxMetricToStandardLengthConverter.Visible = false;
            groupBoxSelect_M_To_S.Visible = false;
            groupBoxMetricToMetricLengthConvertion.Visible = false;
            groupBoxSelect_M_To_M.Visible = false;
            groupBoxStandardToMetricLengthConverter.Visible = false;
            groupBoxSelect_S_To_M.Visible = false;
            groupBoxVolumeConverter.Visible = false;
            groupBoxSelectVolume.Visible = false;
        }
        double iOunce;
        double iPound;
        double iGram;
        double iKilogram;
        string nOperation;

        private void rbGramToKilogram_CheckedChanged(object sender, EventArgs e)
        {
            nOperation = "g-kg";
        }
        private void rbGramToOunce_CheckedChanged(object sender, EventArgs e)
        {
            nOperation = "g-oz";
        }
        private void rbGramToPound_CheckedChanged(object sender, EventArgs e)
        {
            nOperation = "g-lb";
        }
        private void rbKilogramToGram_CheckedChanged(object sender, EventArgs e)
        {
            nOperation = "kg-g";
        }
        private void rbKilogramToOunce_CheckedChanged(object sender, EventArgs e)
        {
            nOperation = "kg-oz";
        }
        private void rbKilogramToPound_CheckedChanged(object sender, EventArgs e)
        {
            nOperation = "kg-lb";
        }
        private void rbOunceToPound_CheckedChanged(object sender, EventArgs e)
        {
            nOperation = "oz-lb";
        }
        private void rbOunceToGram_CheckedChanged(object sender, EventArgs e)
        {
            nOperation = "oz-g";
        }
        private void rbOunceToKilogram_CheckedChanged(object sender, EventArgs e)
        {
            nOperation = "oz-lb";
        }
        private void rbPoundToOunce_CheckedChanged(object sender, EventArgs e)
        {
            nOperation = "lb-g";
        }
        private void rbPoundToGram_CheckedChanged(object sender, EventArgs e)
        {
            nOperation = "lb-g";
        }
        private void rbPoundToKilogram_CheckedChanged(object sender, EventArgs e)
        {
            nOperation = "lb-kg";
        }

        private void btnWeightConvert_Click(object sender, EventArgs e)
        {
            switch(nOperation)
            {
                case "g-kg":
                    iGram = double.Parse(textBoxWeightEntryBox.Text);
                    textBoxWeightConversion.Text = (iGram / 1000).ToString();
                    break;
                case "g-oz":
                    iGram = double.Parse(textBoxWeightEntryBox.Text);
                    textBoxWeightConversion.Text = (iGram * 0.035274).ToString();
                    break;
                case "g-lb":
                    iGram = double.Parse(textBoxWeightEntryBox.Text);
                    textBoxWeightConversion.Text = (iGram * 0.00220462).ToString();
                    break;
                case "kg-g":
                    iKilogram = double.Parse(textBoxWeightEntryBox.Text);
                    textBoxWeightConversion.Text = (iKilogram * 1000).ToString();
                    break;
                case "kg-oz":
                    iKilogram = double.Parse(textBoxWeightEntryBox.Text);
                    textBoxWeightConversion.Text = (iKilogram * 35.274).ToString();
                    break;
                case "kg-lb":
                    iKilogram = double.Parse(textBoxWeightEntryBox.Text);
                    textBoxWeightConversion.Text = (iKilogram * 2.20462).ToString();
                    break;
                case "oz-lb":
                    iOunce = double.Parse(textBoxWeightEntryBox.Text);
                    textBoxWeightConversion.Text = (iOunce * 0.0625).ToString();
                    break;
                case "oz-g":
                    iMile = double.Parse(textBoxWeightEntryBox.Text);
                    textBoxWeightConversion.Text = (iOunce * 28.3495).ToString();
                    break;
                case "oz-kg":
                    iOunce = double.Parse(textBoxWeightEntryBox.Text);
                    textBoxWeightConversion.Text = (iOunce * 0.0283495).ToString();
                    break;
                case "lb-oz":
                    iPound = double.Parse(textBoxWeightEntryBox.Text);
                    textBoxWeightConversion.Text = (iPound * 16).ToString();
                    break;
                case "lb-g":
                    iPound = double.Parse(textBoxWeightEntryBox.Text);
                    textBoxWeightConversion.Text = (iPound * 453.592).ToString();
                    break;
                case "lb-kg":
                    iPound = double.Parse(textBoxWeightEntryBox.Text);
                    textBoxWeightConversion.Text = (iPound * 0.453592).ToString();
                    break;

            }
        }
        private void btnWeightReset_Click(object sender, EventArgs e)
        {
            textBoxWeightEntryBox.Clear();
            textBoxWeightConversion.Text = "";
            rbGramToKilogram.Checked = false;
            rbGramToOunce.Checked = false;
            rbGramToPound.Checked = false;
            rbKilogramToGram.Checked = false;
            rbKilogramToOunce.Checked = false;
            rbKilogramToPound.Checked = false;
            rbOunceToGram.Checked = false;
            rbOunceToKilogram.Checked = false;
            rbOunceToPound.Checked = false;
            rbPoundToOunce.Checked = false;
            rbPoundToKilogram.Checked = false;
            rbPoundToGram.Checked = false;
        }

        //Volume Converter Box

        private void volumeConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 927;
            calculatorEntryBox.Width = 517;
            calculatorEntryBox.Visible = true;
            groupBoxVolumeConverter.Visible = true;
            groupBoxSelectVolume.Visible = true;
            groupBoxStandardCalculatorKeys.Visible = true;
            groupBoxScientificCalculatorKeys.Visible = true;
            groupBoxWeightConverter.Visible = false; ;
            groupBoxSelectWeight.Visible = false;
            groupBoxTemperatureCoverter.Visible = false;
            groupBoxTemperatureSelection.Visible = false;
            groupBoxStandardToStandardLengthConverter.Visible = false;
            groupBoxSelect_S_To_S.Visible = false;
            groupBoxMetricToStandardLengthConverter.Visible = false;
            groupBoxSelect_M_To_S.Visible = false;
            groupBoxMetricToMetricLengthConvertion.Visible = false;
            groupBoxSelect_M_To_M.Visible = false;
            groupBoxStandardToMetricLengthConverter.Visible = false;
            groupBoxSelect_S_To_M.Visible = false;
            groupBoxMortgageCalculator.Visible = false;
        }
        double jOunce;
        double jCup;
        double jPint;
        double jQuart;
        double jGallon;
        string oOperation;

        private void rbOunceToCup_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "oz-c";
        }
        private void rbOunceToPint_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "oz-pt";
        }
        private void rbOunceToQuart_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "oz-qt";
        }
        private void rbOunceToGallon_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "oz-g";
        }
        private void rbCupToOunce_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "c-oz";
        }
        private void rbCupToPint_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "c-pt";
        }
        private void rbCupToQuart_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "c-qt";
        }
        private void rbCupToGallon_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "c-g";
        }
        private void rbPintToOunce_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "pt-oz";
        }
        private void rbPintToCup_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "pt-c";
        }
        private void rbPintToQuart_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "pt-qt";
        }
        private void rbPintToGallon_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "pt-g";
        }
        private void rbQuartToOunce_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "qt-oz";
        }
        private void rbQuartToCup_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "qt-c";
        }
        private void rbQuartToPint_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "qt-pt";
        }
        private void rbQuartToGallon_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "qt-g";
        }
        private void rbGallonToOunce_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "g-oz";
        }
        private void rbGallonToCup_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "g-c";
        }
        private void rbGallonToPint_CheckedChanged(object sender, EventArgs e)
        {
            oOperation = "g-pt";
        }
        private void rbGallonToQuart_CheckedChanged_1(object sender, EventArgs e)
        {
            oOperation = "g-qt";
        }

        private void btnVolumeConvert_Click(object sender, EventArgs e)
        {
            switch (oOperation)
            {
                case "oz-c":
                    jOunce = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jOunce * 0.125).ToString();
                    break;
                case "oz-pt":
                    jOunce = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jOunce * 0.0625).ToString();
                    break;
                case "oz-qt":
                    jOunce = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jOunce * 0.03125).ToString();
                    break;
                case "oz-g":
                    jOunce = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jOunce * 0.0078125).ToString();
                    break;
                case "c-oz":
                    jCup = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jCup * 8.0).ToString();
                    break;
                case "c-pt":
                    jCup = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jCup * 0.5).ToString();
                    break;
                case "c-qt":
                    jCup = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jCup * 0.25).ToString();
                    break;
                case "c-g":
                    jCup = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jCup * 0.0625).ToString();
                    break;
                case "pt-oz":
                    jPint = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jPint * 16.0).ToString();
                    break;
                case "pt-c":
                    jPint = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jPint * 2.0).ToString();
                    break;
                case "pt-qt":
                    jPint = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jPint * 0.453592).ToString();
                    break;
                case "pt-g":
                    jPint = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jPint * 0.5).ToString();
                    break;
                case "qt-oz":
                    jQuart = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jQuart * 32.0).ToString();
                    break;
                case "qt-c":
                    jQuart = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jQuart * 4.0).ToString();
                    break;
                case "qt-pt":
                    jQuart = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jQuart * 2.0).ToString();
                    break;
                case "qt-g":
                    jQuart = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jQuart * 0.25).ToString();
                    break;
                case "g-oz":
                    jGallon = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jGallon * 128.0).ToString();
                    break;
                case "g-c":
                    jGallon = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jGallon * 16.0).ToString();
                    break;
                case "g-pt":
                    jGallon = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jGallon * 8.0).ToString();
                    break;
                case "g-qt":
                    jGallon = double.Parse(textBoxVolumeEntry.Text);
                    textBoxVolumeConversion.Text = (jGallon * 4.0).ToString();
                    break;

            }
        }
        private void btnVolumeReset_Click(object sender, EventArgs e)
        {
            textBoxVolumeEntry.Clear();
            textBoxVolumeConversion.Text = "";
            rbOunceToCup.Checked = false;
            rbOunceToPint.Checked = false;
            rbOunceToQuart.Checked = false;
            rbOunceToGallon.Checked = false;
            rbCupToOunce.Checked = false;
            rbCupToPint.Checked = false;
            rbCupToQuart.Checked = false;
            rbCupToGallon.Checked = false;
            rbPintToOunce.Checked = false;
            rbPintToCup.Checked = false;
            rbPintToQuart.Checked = false;
            rbPintToGallon.Checked = false;
            rbQuartToOunce.Checked = false;
            rbQuartToCup.Checked = false;
            rbQuartToPint.Checked = false;
            rbQuartToGallon.Checked = false;
            rbGallonToOunce.Checked = false;
            rbGallonToCup.Checked = false;
            rbGallonToPint.Checked = false;
            rbGallonToQuart.Checked = false;

        }

        // Mortgage Calculator Box.

        private void mortgageCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 927;
            calculatorEntryBox.Width = 517;
            calculatorEntryBox.Visible = true;
            groupBoxStandardCalculatorKeys.Visible = true;
            groupBoxScientificCalculatorKeys.Visible = true;
            groupBoxMortgageCalculator.Visible = true;
            groupBoxVolumeConverter.Visible = true;
            groupBoxSelectVolume.Visible = true;
            groupBoxWeightConverter.Visible = false; ;
            groupBoxSelectWeight.Visible = false;
            groupBoxTemperatureCoverter.Visible = false;
            groupBoxTemperatureSelection.Visible = false;
            groupBoxStandardToStandardLengthConverter.Visible = false;
            groupBoxSelect_S_To_S.Visible = false;
            groupBoxMetricToStandardLengthConverter.Visible = false;
            groupBoxSelect_M_To_S.Visible = false;
            groupBoxMetricToMetricLengthConvertion.Visible = false;
            groupBoxSelect_M_To_M.Visible = false;
            groupBoxStandardToMetricLengthConverter.Visible = false;
            groupBoxSelect_S_To_M.Visible = false;
        }
        private void btnCalculateMortgagePayment_Click(object sender, EventArgs e)
        {
            double rate = 0.0;
            decimal loan = 0;
            decimal monthPmt = 0.0M;
            int numPmt = 0;
            double R = 0.0;
            double F = 0.0;
            loan = int.Parse(textBoxTotalMortgageAmount.Text.Trim());
            rate = double.Parse(textBoxAnnualInterestRate.Text.Trim());
            numPmt = 12 * int.Parse(textBoxTermOfLoan.Text.Trim());
            R = rate / 1200;
            F = Math.Pow(1 + R, numPmt);
            monthPmt = loan * (decimal)((R * F / (-1 + F)));
            string output = "";
            output += String.Format("The Loan Amount: {0:c}{1}", loan, Environment.NewLine);
            output += String.Format("The Annual Interest Rate: {0:0.00%}{1}", rate / 100, Environment.NewLine);
            output += String.Format("The Number of Payments Required: {0:0}{1}", numPmt, Environment.NewLine);
            output += String.Format("Number of Years the Loan is Taken for: {0:0}{1}", numPmt / 12, Environment.NewLine);
            output += String.Format("Monthly Payment = {0:c}{1}", monthPmt, Environment.NewLine);
            output += String.Format("Total Amount Owed = {0:c}{1}", monthPmt * numPmt, Environment.NewLine);
            textBoxMortgagePaymentDisplay.AppendText(output);
        }
        private void btnMortgageCalculatorReset_Click(object sender, EventArgs e)
        {
            textBoxTotalMortgageAmount.Text = "";
            textBoxAnnualInterestRate.Text = "";
            textBoxTermOfLoan.Text = "";
            textBoxMortgagePaymentDisplay.Text = "";
        }

        
    }
}

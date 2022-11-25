using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SpinnerPlugin.Model;


namespace SpinnerPlugin.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Spinner parameters.
        /// </summary>
        private readonly SpinnerParameters Parameters;

        /// <summary>
        /// Stores a text field and its error.
        /// </summary>
        private readonly Dictionary<TextBox, string> TextBoxAndError;

        /// <summary>
        /// Stores a text field and its corresponding parameter type.
        /// </summary>
        private readonly Dictionary<TextBox, SpinnerParametersType> TextBoxToParameterType;
        public MainForm()
        {
            InitializeComponent();
            Parameters = new SpinnerParameters();
            TextBoxToParameterType = new Dictionary<TextBox, SpinnerParametersType>
            {
                { textBoxDiameter, SpinnerParametersType.Diameter },
                { textBoxThickness, SpinnerParametersType.Thickness },
                { textBoxRadius, SpinnerParametersType.Radius },
                { textBoxLength, SpinnerParametersType.Length },
                { textBoxWidth, SpinnerParametersType.Width }
            };
            TextBoxAndError = new Dictionary<TextBox, string>
            {
                { textBoxDiameter, "" },
                { textBoxThickness, "" },
                { textBoxRadius, "" },
                { textBoxLength, "" },
                { textBoxWidth, "" }
            };
        }

        /// <summary>
        /// Sets default values ​​on form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetDefaultValues(30, 50, 30, 75, 86.25);
        }

        /// <summary>
        /// Sets default values.
        /// </summary>
        /// <param name="diameterValue">Spinner diameter.</param>
        /// <param name="thicknessValue">Spinner thickness.</param>
        /// <param name="radiusValue">Spinner radius.</param>
        /// <param name="lengthValue">Spinner length.</param>
        /// <param name="widthValue">Spinner width.</param>
        private void SetDefaultValues(double diameterValue,
            double thicknessValue, double radiusValue, double lengthValue, double widthValue)
        {
            Parameters.SetParameterValue(SpinnerParametersType.Diameter, diameterValue);
            Parameters.SetParameterValue(SpinnerParametersType.Thickness, thicknessValue);
            Parameters.SetParameterValue(SpinnerParametersType.Radius, radiusValue);
            Parameters.SetParameterValue(SpinnerParametersType.Length, lengthValue);
            Parameters.SetParameterValue(SpinnerParametersType.Width, widthValue);

            textBoxDiameter.Text = diameterValue.ToString();
            textBoxThickness.Text = thicknessValue.ToString();
            textBoxRadius.Text = radiusValue.ToString();
            textBoxLength.Text = lengthValue.ToString();
            textBoxWidth.Text = widthValue.ToString();
        }

        /// <summary>
        /// Sets the minimum parameters of the mug.
        /// </summary>
        private void SetMinimumParameters(object sender, MouseEventArgs e)
        {
            SetDefaultValues(30, 10, 20, 75, 86.25);
        }

        /// <summary>
        /// Sets the average parameters of the mug.
        /// </summary>
        private void SetAvgareParameters(object sender, EventArgs e)
        {
            SetDefaultValues(65, 30, 40, 162.5, 186.875);
        }

        /// <summary>
        ///  Sets the maximum parameters for the mug.
        /// </summary>
        private void SetMaximumParameters(object sender, EventArgs e)
        {
            SetDefaultValues(100, 50, 60, 250, 287.5);
        }

        /// <summary>
        /// Clears a text field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearTextBox(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).Text = "";
        }


        /// <summary>
        /// Checks if all text fields are filled correctly.
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxes()
        {
            var isError = true;
            foreach (var item in
                     TextBoxAndError.Where(item => item.Value != ""))
            {
                isError = false;
                errorProvider.SetError(item.Key, item.Value);
            }

            return isError;
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                // Call build method
            }
            else
            {
                MessageBox.Show(@"Fill all required parameters correctly");
            }
        }

        private void textBoxDiameter_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDiameter.Text))
            {
                errorProvider.SetError(textBoxDiameter, "Не указано число!");
            }
            else if (textBoxDiameter.Text.Length < 30 || textBoxDiameter.Text.Length > 100)
            {
                errorProvider.SetError(textBoxDiameter, "Некоректное число");

            }
            else
            {
                errorProvider.Clear();
            }
        }
    }
}

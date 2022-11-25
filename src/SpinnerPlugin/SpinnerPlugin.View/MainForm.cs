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
            SetDefaultValues(10, 10, 30, 75, 86.25);
        }

        /// <summary>
        /// Sets default values.
        /// </summary>
        /// <param name="diameterValue">Spinner diameter.</param>
        /// <param name="thicknessValue">Spinner thickness.</param>
        /// <param name="radiusValue">Spinner radius.</param>
        /// <param name="lengthValue">Spinner length.</param>
        /// <param name="widthValue">Spinner width.</param>
        private void SetDefaultValues(double diameterValue, double radiusValue,
            double thicknessValue, double lengthValue, double widthValue)
        {
            Parameters.SetParameterValue(SpinnerParametersType.Diameter, diameterValue);
            Parameters.SetParameterValue(SpinnerParametersType.Thickness, thicknessValue);
            Parameters.SetParameterValue(SpinnerParametersType.Radius, radiusValue);
            Parameters.SetParameterValue(SpinnerParametersType.Length, lengthValue);
            Parameters.SetParameterValue(SpinnerParametersType.Width, widthValue);

            textBoxDiameter.Text = diameterValue.ToString();
            textBoxRadius.Text = radiusValue.ToString();
            textBoxThickness.Text = thicknessValue.ToString();
            textBoxLength.Text = lengthValue.ToString();
            textBoxWidth.Text = widthValue.ToString();
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


        private void buttonBuild_Click(object sender, EventArgs e)
        {

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

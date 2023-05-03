using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SpinnerPlugin.Model;
using SpinnerPlugin.Wrapper;


namespace SpinnerPlugin.View
{
    /// <summary>
    /// Class for interacting with the form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Spinner parameters.
        /// </summary>
        private readonly SpinnerParameters _parameters;

        /// <summary>
        /// Stores a text field and its error.
        /// </summary>
        private readonly Dictionary<TextBox, string> _textBoxAndError;

        /// <summary>
        /// Stores a text field and its corresponding parameter type.
        /// </summary>
        private readonly Dictionary<TextBox, SpinnerParametersType> _textBoxToParameterType;

        /// <summary>
        /// Main form constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _parameters = new SpinnerParameters();
            _textBoxToParameterType = new Dictionary<TextBox, SpinnerParametersType>
            {
                { textBoxInnerRings, SpinnerParametersType.DiameterInnerRings },
                { textBoxDiameter, SpinnerParametersType.Diameter },
                { textBoxLength, SpinnerParametersType.Length },
                { textBoxOuterRings, SpinnerParametersType.RadiusOuterRings },
                { textBoxThickness, SpinnerParametersType.Thickness },
                { textBoxRounding, SpinnerParametersType.Rounding },
            };
            _textBoxAndError = new Dictionary<TextBox, string>
            {
                { textBoxInnerRings, "" },
                { textBoxDiameter, "" },
                { textBoxLength, "" },
                { textBoxOuterRings, "" },
                { textBoxThickness, "" },
                { textBoxRounding, "" }
            };
        }

        /// <summary>
        /// Sets parameter value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetParameter(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            var isType = _textBoxToParameterType.TryGetValue(textBox, out var type);
            var textValue = textBox.Text.Replace('.', ',');
            double.TryParse(textValue, out var value);
            value = Math.Round(value, 1);

            if (!isType) return;

            try
            {
                _parameters.SetParameterValue(type, value);
                _textBoxAndError[textBox] = "";
                errorProvider.Clear();
            }
            catch (ArgumentOutOfRangeException error)
            {
                _textBoxAndError[textBox] = error.ParamName;
                errorProvider.SetError(textBox, error.ParamName);
            }
        }


        /// <summary>
        /// Sets default values.
        /// </summary>
        /// <param name="diameterValue">Spinner diameter.</param>
        /// <param name="thicknessValue">Spinner thickness.</param>
        /// <param name="radiusInnerRingsValue">Spinner radius.</param>
        /// <param name="lengthValue">Spinner length.</param>
        /// <param name="radiusOuterRingsValue">Spinner radius outer rings.</param>
        /// <param name="roundingValue">Spinner rounding.</param>
        private void SetParameters(double radiusInnerRingsValue, double diameterValue, 
            double lengthValue, double radiusOuterRingsValue, double thicknessValue, double roundingValue)
        {
            _parameters.SetParameterValue(SpinnerParametersType.DiameterInnerRings, radiusInnerRingsValue);
            _parameters.SetParameterValue(SpinnerParametersType.Diameter, diameterValue);
            _parameters.SetParameterValue(SpinnerParametersType.Length, lengthValue);
            _parameters.SetParameterValue(SpinnerParametersType.RadiusOuterRings, radiusOuterRingsValue);
            _parameters.SetParameterValue(SpinnerParametersType.Thickness, thicknessValue);
            _parameters.SetParameterValue(SpinnerParametersType.Rounding, roundingValue);

            textBoxInnerRings.Text = radiusInnerRingsValue.ToString();
            textBoxDiameter.Text = diameterValue.ToString();
            textBoxLength.Text = lengthValue.ToString();
            textBoxOuterRings.Text = radiusOuterRingsValue.ToString();
            textBoxThickness.Text = thicknessValue.ToString();
            textBoxRounding.Text = roundingValue.ToString();
        }

        /// <summary>
        /// Checks if all text fields are filled correctly.
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxes()
        {
            var isError = true;
            foreach (var item in
                     _textBoxAndError.Where(item => item.Value != ""))
            {
                isError = false;
                errorProvider.SetError(item.Key, item.Value);
            }

            return isError;
        }

        /// <summary>
        /// Build spinner in Kompas 3D.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Build(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                var builder = new SpinnerBuilder();
                builder.BuildSpinner(_parameters);
            }
            else
            {
                MessageBox.Show(@"Fill all required parameters correctly",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set default spinner parameters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetDefaultParameters(object sender, EventArgs e)
        {
            var buttonName = (sender as Button)?.Name;

            switch (buttonName)
            {
                case "buttonMimimum":
                    {
                        var dependentValues = _parameters.GetDependentValues(30);
                        SetParameters(30, dependentValues[0], dependentValues[1], dependentValues[2], 10, 0.5);
                        break;
                    }
                case "buttonAverage":
                    {
                        var dependentValues = _parameters.GetDependentValues(45);
                        SetParameters(45, dependentValues[0], dependentValues[1], dependentValues[2], 20, 1.25);
                        break;
                    }
                case "buttonMaximum":
                    {
                        var dependentValues = _parameters.GetDependentValues(60);
                        SetParameters(60, dependentValues[0], dependentValues[1], dependentValues[2], 30, 2);
                        break;
                    }
                default:
                    {
                        var dependentValues = _parameters.GetDependentValues(45);
                        SetParameters(45, dependentValues[0], dependentValues[1], dependentValues[2], 20, 1.25);
                        break;
                    }
            }
        }

        /// <summary>
        /// Clear text field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearField(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.Text = "";
        }
    }
}

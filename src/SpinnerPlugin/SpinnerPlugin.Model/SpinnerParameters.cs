using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinnerPlugin.Model
{
    public class SpinnerParameters
    {
        /// <summary>
        /// Stores the parameter type and its values.
        /// </summary>
        private readonly Dictionary<SpinnerParametersType, SpinnerParameter> _parameters;

        /// <summary>
        /// SpinnerParameters constructor.
        /// </summary>
        public SpinnerParameters()
        {
            _parameters = new Dictionary<SpinnerParametersType, SpinnerParameter>()
            {
                { SpinnerParametersType.Diameter, new SpinnerParameter(65, 30, 100) },
                { SpinnerParametersType.Thickness, new SpinnerParameter(30, 10, 50) },
                { SpinnerParametersType.Radius, new SpinnerParameter(40, 20, 60) },
                { SpinnerParametersType.Length, new SpinnerParameter(162.5, 75, 250) },
                { SpinnerParametersType.Width, new SpinnerParameter(186.875, 86.25, 287.5) },
            };
        }

        /// <summary>
        /// Sets parameter value.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public void SetParameterValue(SpinnerParametersType type, double value)
        {
            if (!_parameters.TryGetValue(type, out var parameter)) return;

            CheckDependencies(type, value);
            parameter.Value = value;
        }

        /// <summary>
        /// Gets parameter value.
        /// </summary>
        /// <param name="type">Spinner parameter type.</param>
        /// <returns>Parameter value.</returns>
        /// <exception cref="Exception">If parameter value does not exist.</exception>
        public double GetParameterValue(SpinnerParametersType type)
        {
            if (_parameters.TryGetValue(type, out var parameter))
            {
                return parameter.Value;
            }
            throw new Exception("Parameter does not exist");
        }

        /// <summary>
        /// Checks dependent parameters.
        /// </summary>
        /// <param name="type">Spinner parameter type.</param>
        /// <param name="value">Parameter value.</param>
        /// <exception cref="Exception">If the parameter values ​​are set incorrectly.</exception>
        private void CheckDependencies(SpinnerParametersType type, double value)
        {
            switch (type)
            {
                case SpinnerParametersType.Length:
                    {
                        _parameters.TryGetValue(SpinnerParametersType.Diameter, out var parameter);
                        if (value * 2.5 == parameter.Value)
                        {
                            throw new Exception(
                                "Length depends on the diameter in the ratio (diameter * 2.5)");
                        }

                        break;
                    }
                case SpinnerParametersType.Width:
                    {
                        _parameters.TryGetValue(SpinnerParametersType.Length, out var parameter);
                        if (value * 1.15 == parameter.Value)
                        {
                            throw new Exception(
                                "Width depends on the length in the ratio (length * 1.15)");

                        }
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
        }
    }
}

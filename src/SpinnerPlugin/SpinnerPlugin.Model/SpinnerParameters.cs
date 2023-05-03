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
            var avgDependentValues = GetDependentValues(45);
            var maxDependentValues = GetDependentValues(60);
            var minDependentValues = GetDependentValues(30);

            _parameters = new Dictionary<SpinnerParametersType, SpinnerParameter>()
            {
                { SpinnerParametersType.DiameterInnerRings, new SpinnerParameter(45, 30, 60) },
                {
                    SpinnerParametersType.Diameter,
                    new SpinnerParameter(avgDependentValues[0], minDependentValues[0], maxDependentValues[0])
                },
                {
                    SpinnerParametersType.Length,
                    new SpinnerParameter(avgDependentValues[1], minDependentValues[1], maxDependentValues[1])
                },
                {
                    SpinnerParametersType.RadiusOuterRings,
                    new SpinnerParameter(avgDependentValues[2], minDependentValues[2], maxDependentValues[2])
                },
                { SpinnerParametersType.Thickness, new SpinnerParameter(20, 10, 30) },
                { SpinnerParametersType.Rounding, new SpinnerParameter(1.25, 0.5, 2) },
            };
        }

        /// <summary>
        /// Sets parameter value.
        /// </summary>
        /// <param name="type">Spinner parameter type.</param>
        /// <param name="value">Parameter value.</param>
        public void SetParameterValue(SpinnerParametersType type, double value)
        {
            var parameter = _parameters[type];
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
            return _parameters[type].Value;
        }


        /// <summary>
        /// Get Dependent Parameters.
        /// </summary>
        /// <param name="diameterInnerRings">Spinner RadiusInnerRings.</param>
        /// <returns></returns>
        public double[] GetDependentValues(double diameterInnerRings)
        {
            var dependentValues = new double[]
            {
                Math.Round(diameterInnerRings * 0.7, 1),
                Math.Round(diameterInnerRings * 1.5, 1),
                Math.Round((diameterInnerRings + 10) / 2, 1),
            };
            return dependentValues;
        }

        /// <summary>
        /// Checks dependent parameters.
        /// </summary>
        /// <param name="type">Spinner parameter type.</param>
        /// <param name="value">Parameter value.</param>
        /// <exception cref="Exception">If the parameter values ​​are set incorrectly.</exception>
        private void CheckDependencies(SpinnerParametersType type, double value)
        {
            _parameters.TryGetValue(SpinnerParametersType.DiameterInnerRings, out var parameter);
            var dependentValues = GetDependentValues(parameter.Value);

            if (type == SpinnerParametersType.Diameter)
            {
                if (value != dependentValues[0])
                {
                    throw new ArgumentOutOfRangeException(
                        "Diameter depends on the Diameter Inner Rings in the ratio (DiameterInnerRings * 0.7)");
                }
            }

            if (type == SpinnerParametersType.Length)
            {
                if (value != dependentValues[1])
                {
                    throw new ArgumentOutOfRangeException(
                        "Length depends on the Diameter Inner Rings in the ratio (DiameterInnerRings * 1.5)");

                }
            }

            if (type == SpinnerParametersType.RadiusOuterRings)
            {
                if (value != dependentValues[2])
                {
                    throw new ArgumentOutOfRangeException(
                        "Radius outer rings depends on the Diameter Inner Rings in the ratio ( (DiameterInnerRings + 10) / 2)");
                }
            }
        }
    }
}

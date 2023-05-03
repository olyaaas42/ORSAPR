using NUnit.Framework;
using SpinnerPlugin.Model;

namespace SpinnerPlugin.UnitTests
{

    [TestFixture]
    public class SpinnerParametersTest
    {
        /// <summary>
        /// Spinner parameters.
        /// </summary>
        private readonly SpinnerParameters _parameters = new SpinnerParameters();

        [Test(Description = "Positive test set dependent parameter values.")]
        public void TestDependentParameterSet_CorrectValues()
        {
            var expectedDiameter = _parameters.GetParameterValue(SpinnerParametersType.Diameter);
            var expectedLength = _parameters.GetParameterValue(SpinnerParametersType.Length);
            var expectedRadiusInnerRings = _parameters.GetParameterValue(SpinnerParametersType.RadiusInnerRings);

            _parameters.SetParameterValue(SpinnerParametersType.Diameter, expectedDiameter);
            _parameters.SetParameterValue(SpinnerParametersType.Length, expectedLength);
            _parameters.SetParameterValue(SpinnerParametersType.RadiusInnerRings, expectedRadiusInnerRings);

            Assert.Multiple(() =>
            {
                Assert.That(_parameters.GetParameterValue(SpinnerParametersType.Diameter),
                    Is.EqualTo(expectedDiameter));
                Assert.That(_parameters.GetParameterValue(SpinnerParametersType.Length),
                    Is.EqualTo(expectedLength));
                Assert.That(_parameters.GetParameterValue(SpinnerParametersType.RadiusInnerRings),
                    Is.EqualTo(expectedRadiusInnerRings));
            });
        }

        [Test(Description = "Negative test set dependent parameter values.")]
        public void TestDependentParameterSet_IncorrectValues()
        {
            var actualDiameterException = Assert.Throws<System.ArgumentOutOfRangeException>(() =>
                _parameters.SetParameterValue(SpinnerParametersType.Diameter, 20));
            var actualLengthException = Assert.Throws<System.ArgumentOutOfRangeException>(() =>
                _parameters.SetParameterValue(SpinnerParametersType.Length, 20));
            var actualRadiusInnerRingsException = Assert.Throws<System.ArgumentOutOfRangeException>(() =>
                _parameters.SetParameterValue(SpinnerParametersType.RadiusInnerRings, 20));


            Assert.Multiple(() =>
            {
                Assert.That(actualDiameterException?.GetType(), Is.EqualTo(typeof(System.ArgumentOutOfRangeException)));
                Assert.That(actualLengthException?.GetType(), Is.EqualTo(typeof(System.ArgumentOutOfRangeException)));
                Assert.That(actualRadiusInnerRingsException?.GetType(), Is.EqualTo(typeof(System.ArgumentOutOfRangeException)));
            });
        }
    }
}
using SpinnerPlugin.Model;
using Kompas6API5;
using KompasAPI7;

namespace SpinnerPlugin.Wrapper
{

    /// <summary>
    /// Class for constructing a spinner.
    /// </summary>
    public class SpinnerBuilder
    {

        /// <summary>
        /// Kompas wrapper.
        /// </summary>
        private readonly KompasWrapper _wrapper = new KompasWrapper();

        /// <summary>
        /// Build a spinner by parameters.
        /// </summary>
        /// <param name="spinnerParameters">Spinner parameters.</param>
        public void BuildSpinner(SpinnerParameters spinnerParameters)
        {
            _wrapper.StartKompas();
            _wrapper.CreateDocument();
            _wrapper.SetProperties();

            var spinnerInnerRings = spinnerParameters.GetParameterValue(SpinnerParametersType.RadiusInnerRings) / 2;
            var spinnerDiameter = spinnerParameters.GetParameterValue(SpinnerParametersType.Diameter) / 2;
            var spinnerLenght = spinnerParameters.GetParameterValue(SpinnerParametersType.Length);
            var spinnerOuterRings = spinnerParameters.GetParameterValue(SpinnerParametersType.RadiusOuterRings);
            var spinnerThickness = spinnerParameters.GetParameterValue(SpinnerParametersType.Thickness);
            var spinnerRounding = spinnerParameters.GetParameterValue(SpinnerParametersType.Rounding);
            BuildSpinnerBody(spinnerInnerRings, spinnerDiameter, spinnerLenght, spinnerOuterRings, spinnerThickness);
            
            _wrapper.Fillet(spinnerRounding);
        }

        /// <summary>
        /// Build spinner body.
        /// </summary>
        /// <param name="innerRings">Spinner radius inner rings.</param>
        /// <param name="diameter">Spinner diameter.</param>
        /// <param name="length">Spinner lenght between rings.</param>
        /// <param name="outerRings">Spinner radius outer rings.</param>
        /// <param name="thickness">Spinner thickness.</param>
        private void BuildSpinnerBody(double innerRings, double diameter, double length, double outerRings, double thickness)
        {
            // Create spinner body.
            var sketch = _wrapper.CreateSketch(3);
            var start = new Point2D(0, 0);
            var end = new Point2D(0, length);
            var end1 = new Point2D(0, -length);
            var arc1 = new Point2D(-diameter -3, 0);
            var st1 = new Point2D(-outerRings, -length);
            var st2 = new Point2D(-outerRings, length);
            var arc2 = new Point2D(diameter + 3, 0);
            var st3 = new Point2D(outerRings, -length);
            var st4 = new Point2D(outerRings, length);
            short dir = -1;

            sketch.CreateCircle(start, diameter, 1);

            sketch.CreateLineSeg(start, end, 3);
            sketch.CreateCircle(end, innerRings, 1);

            sketch.CreateLineSeg(start, end1, 3);
            sketch.CreateCircle(end1, innerRings, 1);

            sketch.CreateArcBy3Points(st1, arc1, st2);
            sketch.CreateArcBy3Points(st3, arc2, st4);

            sketch.CreateArcByPoint(end1, outerRings, st3, st1, dir);
            sketch.CreateArcByPoint(end, outerRings, st2, st4, dir);

            sketch.EndEdit();
            _wrapper.Extrude(sketch, thickness, true);

        }
    }
}

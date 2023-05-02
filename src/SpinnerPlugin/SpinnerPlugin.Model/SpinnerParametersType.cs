using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinnerPlugin.Model
{
    /// <summary>
    /// Enumeration of spinner parameters.
    /// </summary>
    public enum SpinnerParametersType
    {
        /// <summary>
        /// Spinner radius.
        /// </summary>
        RadiusInnerRings,

        /// <summary>
        /// Spinner ring diameter.
        /// </summary>
        Diameter,

        /// <summary>
        /// Spinner length.
        /// </summary>
        Length,

        /// <summary>
        /// Spinner width.
        /// </summary>
        RadiusOuterRings,

        /// <summary>
        /// Spinner thickness.
        /// </summary>
        Thickness,

        /// <summary>
        /// Spinner rounding.
        /// </summary>
        Rounding
    }
}

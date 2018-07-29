/*************************************************************************
 *  Copyright © 2018 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Maths.cs
 *  Description  :  Define math interpolation.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  7/29/2018
 *  Description  :  Initial development version.
 *************************************************************************/

namespace Mogoson.Mathematics
{
    /// <summary>
    /// Mathematical concepts and methods.
    /// </summary>
    public static partial class Maths
    {
        #region Static Method
        /// <summary>
        /// Interpolates between a and b by t.
        /// </summary>
        /// <param name="from">Start value of interpolate value.</param>
        /// <param name="to">End value of interpolate value.</param>
        /// <param name="t">t is clamped between 0 and 1.</param>
        /// <returns></returns>
        public static double Lerp(double from, double to, double t)
        {
            return from + (to - from) * t;
        }
        #endregion
    }
}
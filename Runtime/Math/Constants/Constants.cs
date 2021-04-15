using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace CGTK.Utilities.Extensions
{
    public static class Constants
    {
        /// <summary>
        /// Circle constant relating the circumference of a circle to its linear dimension.
        /// (circumference / radius)
        /// </summary>
        [PublicAPI]
        public const float TAU = 6.28318530717959f;

        [PublicAPI]
        public const float PI = Mathf.PI;
        
        [PublicAPI]
        public const float PI_HALF = (PI * 0.5f);
        
        /// <summary>
        /// Use this to convert from Degrees to Radians.
        /// (TAU / 360) or (PI / 180)
        /// </summary>
        [PublicAPI]
        public const float DEG_TO_RAD = (TAU / 360f);
        
        /// <summary>
        /// Use this to convert from Radians to Degrees.
        /// (360 / TAU) or (180 / PI)
        /// </summary>
        [PublicAPI]
        public const float RAD_TO_DEG = (360f / TAU);
        
        public const float INFINITY = Mathf.Infinity;
        
        public const float NEGATIVE_INFINITY = Mathf.NegativeInfinity;
        
        public static float EPSILON = Mathf.Epsilon;


        /*!
         *  Circle constant relating the circumference of a circle to its linear dimension.
         *  (circumference / radius)
         */
        //constexpr float TAU = 6.28318530717959f;

        /*!
         *  Use this to convert from Degrees to Radians.
         *  (TAU / 360) or (PI / 180)
         */
        //constexpr float DEG_TO_RAD = (TAU / 360);

        /*!
         *  Use this to convert from Radians to Degrees.
         *  (360 / TAU) or (180 / PI)
         */
        //constexpr float RAD_TO_DEG = (360 / TAU);

        /*!
         * A small value, most often used to compare floats.
         */
        //constexpr float EPSILON = 0.0001f;

        //constexpr float INFINITY	    = std::numeric_limits<float>::infinity();

        //constexpr float NEGATIVE_INFINITY = -std::numeric_limits<float>::infinity();
    }
}

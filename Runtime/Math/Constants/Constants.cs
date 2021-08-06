using System;
using JetBrains.Annotations;
using UnityEngine;

namespace CGTK.Utilities.Extensions
{
 using F32 = Single;
 using F64 = Double;

 using I8  = SByte;
 using I16 = Int16;
 using I32 = Int32;
 using I64 = Int64;

 using U8  = Byte;
 using U16 = UInt16;
 using U32 = UInt32;
 using U64 = UInt64;

    public static class Constants
    {
        /// <summary>
        /// Circle constant relating the circumference of a circle to its linear dimension.
        /// (circumference / radius)
        /// </summary>
        [PublicAPI]
        public const F32 TAU = 6.28318530717959f;

        [PublicAPI]
        public const F32 PI = Mathf.PI;
        
        [PublicAPI]
        public const F32 PI_HALF = (PI * 0.5f);
        
        /// <summary>
        /// Use this to convert from Degrees to Radians.
        /// (TAU / 360) or (PI / 180)
        /// </summary>
        [PublicAPI]
        public const F32 DEG_TO_RAD = (TAU / 360f);
        
        /// <summary>
        /// Use this to convert from Radians to Degrees.
        /// (360 / TAU) or (180 / PI)
        /// </summary>
        [PublicAPI]
        public const F32 RAD_TO_DEG = (360f / TAU);
        
        public const F32 INFINITY = Mathf.Infinity;
        
        public const F32 NEGATIVE_INFINITY = Mathf.NegativeInfinity;
        
        public static F32 EPSILON = Mathf.Epsilon;


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

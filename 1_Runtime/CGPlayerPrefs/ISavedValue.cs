using System;
using JetBrains.Annotations;

namespace CGTK.Utils.Extensions.CGPlayerPrefs
{
    using static PackageConstants;
    
    /// <summary>
    /// Abstract class describing a PlayerPrefs values
    /// </summary>
    /// 
    /// <typeparam name="T">Type of the stored object</typeparam>
    [PublicAPI]
    public interface ISavedValue<T>
    {
        /// <summary> Gets or Sets the object from PlayerPrefs. </summary>
        public abstract T Value { get; set; }

        /// <summary> Delete the object from PlayerPrefs. </summary>
        public abstract void Delete();

        /// <summary> Whether the PlayerPref value is set. </summary>
        public abstract Boolean IsSet { get; }
        
        

        /// <summary> Reads the object from PlayerPrefs </summary>
        /// 
        /// <returns> The high-level object </returns>
        public abstract T Read();
    
        /// <summary> Writes the object to PlayerPrefs </summary>
        /// 
        /// <param name="value"> The high-level object </param>
        public abstract void Write(in T value);
    }
}

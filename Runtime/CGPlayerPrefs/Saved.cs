using System;
using JetBrains.Annotations;

namespace CGTK.Utilities.Extensions.CGPlayerPrefs
{
    /// <summary>
    /// An abstract, simple implementation of <see cref="ISavedValue{T}"/>
    /// </summary>
    /// 
    /// <typeparam name="T"> Type of the saved value. </typeparam>
    [PublicAPI]
    public abstract class Saved<T> : ISavedValue<T>
    {
        #region Fields & Properties

        protected String Key { get; }
        protected T DefaultValue { get; }

        private Boolean _isCached;
        
        private T _valueInternal;
        public T Value
        {
            get
            {
                if (Key.IsNullOrEmpty()) throw new Exception(message: "Not initialized");

                if (_isCached) return _valueInternal;
                
                _valueInternal = IsSet ? Read() : DefaultValue;
                _isCached = true;

                return _valueInternal;
            }
            set
            {
                if (Key.IsNullOrEmpty()) throw new Exception(message: "Not initialized");

                Write(value);
                
                _valueInternal = value;
                _isCached = true;
            }
        }
        
        #endregion

        #region Structors
        
        public Saved(in String key, in T defaultValue = default)
        {
            this.Key = key;
            this.DefaultValue = defaultValue;
        }
        
        #endregion

        #region Methods

        public void Delete()
        {
            UnityEngine.PlayerPrefs.DeleteKey(Key);
            _valueInternal = DefaultValue;
        }

        public Boolean IsSet
        {
            get
            {
                if (Key.IsNullOrEmpty()) throw new Exception(message: "Not initialized");

                return UnityEngine.PlayerPrefs.HasKey(Key);
            }
        }

        public abstract T Read();
        public abstract void Write(in T value);

        #endregion
        
    }
}
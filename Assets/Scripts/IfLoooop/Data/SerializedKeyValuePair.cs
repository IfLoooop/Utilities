using System;
using UnityEditor;
using UnityEngine;

namespace IfLoooop.Data
{
#if ODIN_INSPECTOR
    using Sirenix.OdinInspector;
    
    /// <summary>
    /// SerializedKeyValuePair is a serializable struct that represents a key/value pair, specifically designed to be used with Unity's serialization system.
    /// It uses Odin Inspector attributes for better editor integration and customization.
    /// </summary>
    /// <typeparam name="K">The type of the key.</typeparam>
    /// <typeparam name="V">The type of the value.</typeparam>
    [Serializable]
    public struct SerializedKeyValuePair<K,V>
    {
        #region Inspector Fields
        [Tooltip("Represents the key in a serialized key/value pair.")]
        [HorizontalGroup, HideLabel]
        [SerializeField] private K key;
        [Tooltip("Represents the value in a serialized key/value pair.")]
        [HorizontalGroup, HideLabel]
        [SerializeField] private V value;
        #endregion
        
        #region Constants
        /// <summary>
        /// Refactor resistant name for <see cref="key"/>. <br/>
        /// <i>For custom <see cref="PropertyDrawer"/>.</i>
        /// </summary>
        public const string KEY = nameof(key);
        /// <summary>
        /// Refactor resistant name for <see cref="value"/>. <br/>
        /// <i>For custom <see cref="PropertyDrawer"/>.</i>
        /// </summary>
        public const string VALUE = nameof(value);
        #endregion
        
        #region Properties
        /// <summary>
        /// <see cref="key"/>.
        /// </summary>
        public K Key { get => this.key; set => this.key = value; }
        /// <summary>
        /// <see cref="value"/>.
        /// </summary>
        public V Value { get => this.value; set => this.value = value; }
        #endregion
        
        #region Constructors
        /// <summary>
        /// <see cref="SerializedKeyValuePair{K,V}"/>.
        /// </summary>
        /// <param name="_Key"><see cref="key"/>.</param>
        /// <param name="_Value"><see cref="value"/>.</param>
        public SerializedKeyValuePair(K _Key, V _Value)
        {
            this.key = _Key;
            this.value = _Value;
        }
        #endregion
    }
#endif
}
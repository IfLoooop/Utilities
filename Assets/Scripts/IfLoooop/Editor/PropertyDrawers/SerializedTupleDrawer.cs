using IfLoooop.Attributes;
using IfLoooop.Data;
using UnityEngine;

namespace IfLoooop.Editor.PropertyDrawers
{
#if ODIN_INSPECTOR
    using Sirenix.OdinInspector.Editor;
    
    /// <summary>
    /// A custom drawer for <see cref="SerializedTuple{T}"/> to render it in the Unity Inspector.
    /// This drawer makes use of Odin Inspector to draw the properties and can also utilize the
    /// <see cref="TupleLabelsAttribute"/> for custom labels on the tuple's items.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the <see cref="SerializedTuple{T}"/>.</typeparam>
    public sealed class SerializedTupleDrawer<T> : OdinValueDrawer<SerializedTuple<T>>
    {
        #region Methods
        protected override void DrawPropertyLayout(GUIContent _Label)
        {
            var _tupleLabelsAttribute = this.Property.GetAttribute<TupleLabelsAttribute>();
            var _tuple = this.ValueEntry.SmartValue;

            if (_tupleLabelsAttribute != null)
            {
                _tuple.Item1Label = _tupleLabelsAttribute.Item1Label;
                _tuple.Item2Label = _tupleLabelsAttribute.Item2Label;
            }

            base.CallNextDrawer(_Label);
        }
        #endregion
    } 
#endif
}
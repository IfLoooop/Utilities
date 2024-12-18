using System;
using IfLoooop.Utilities;
using UnityEngine;

namespace IfLoooop.Extensions
{
    /// <summary>
    /// Contains extension methods for <see cref="Vector3"/>.
    /// </summary>
    public static class Vector3Extensions
    {
        #region Methods
        /// <summary>
        /// Divides the components of a <see cref="Vector3"/> by a specified value along the given axis.
        /// </summary>
        /// <param name="_Vector3">The <see cref="Vector3"/> to be divided.</param>
        /// <param name="_Axis">The axis along which to divide the component(s).</param>
        /// <param name="_Value">The value by which to divide the component(s).</param>
        /// <returns>A new <see cref="Vector3"/> with the divided values.</returns>
        public static Vector3 Divide(this Vector3 _Vector3, Axis _Axis, float _Value) => _Axis switch
        {
            Axis.X => new Vector3(_Vector3.x / _Value, _Vector3.y, _Vector3.z),
            Axis.Y => new Vector3(_Vector3.x, _Vector3.y / _Value, _Vector3.z),
            Axis.Z => new Vector3(_Vector3.x, _Vector3.y, _Vector3.z / _Value),
            Axis.XY => new Vector3(_Vector3.x / _Value, _Vector3.y / _Value, _Vector3.z),
            Axis.XZ => new Vector3(_Vector3.x / _Value, _Vector3.y, _Vector3.z / _Value),
            Axis.YZ => new Vector3(_Vector3.x, _Vector3.y / _Value, _Vector3.z / _Value),
            Axis.XYZ => new Vector3(_Vector3.x / _Value, _Vector3.y / _Value, _Vector3.z / _Value),
            _ => throw ArgumentOutOfRangeException(nameof(_Axis), _Axis)
        };

        /// <summary>
        /// Returns the maximum value among the x, y, and z components of the given <see cref="Vector3"/>.
        /// </summary>
        /// <param name="_Vector3">The <see cref="Vector3"/> to evaluate.</param>
        /// <returns>The maximum value among the x, y, and z components.</returns>
        public static float Max(this Vector3 _Vector3)
        {
            var _value = _Vector3.x;
            
            if (_Vector3.y > _value)
            {
                _value = _Vector3.x;
            }
            if (_Vector3.z > _value)
            {
                _value = _Vector3.x;
            }

            return _value;
        }

        /// <summary>
        /// Subtracts the specified value from the components of a <see cref="Vector3"/> along the given axis.
        /// </summary>
        /// <param name="_Vector3">The <see cref="Vector3"/> to be subtracted from.</param>
        /// <param name="_Axis">The axis along which to subtract the component(s).</param>
        /// <param name="_Value">The value to subtract from the component(s).</param>
        /// <returns>A new <see cref="Vector3"/> with the subtracted values.</returns>
        public static Vector3 Minus(this Vector3 _Vector3, Axis _Axis, float _Value) => _Axis switch
        {
            Axis.X => new Vector3(_Vector3.x - _Value, _Vector3.y, _Vector3.z),
            Axis.Y => new Vector3(_Vector3.x, _Vector3.y - _Value, _Vector3.z),
            Axis.Z => new Vector3(_Vector3.x, _Vector3.y, _Vector3.z - _Value),
            Axis.XY => new Vector3(_Vector3.x - _Value, _Vector3.y - _Value, _Vector3.z),
            Axis.XZ => new Vector3(_Vector3.x - _Value, _Vector3.y, _Vector3.z - _Value),
            Axis.YZ => new Vector3(_Vector3.x, _Vector3.y - _Value, _Vector3.z - _Value),
            Axis.XYZ => new Vector3(_Vector3.x - _Value, _Vector3.y - _Value, _Vector3.z - _Value),
            _ => throw ArgumentOutOfRangeException(nameof(_Axis), _Axis)
        };

        /// <summary>
        /// Multiplies the components of a Vector3 by a specified value along the given axis.
        /// </summary>
        /// <param name="_Vector3">The Vector3 to be multiplied.</param>
        /// <param name="_Axis">The axis along which to multiply the component(s).</param>
        /// <param name="_Value">The value by which to multiply the component(s).</param>
        /// <returns>A new Vector3 with the multiplied values.</returns>
        public static Vector3 Multiply(this Vector3 _Vector3, Axis _Axis, float _Value) => _Axis switch
        {
            Axis.X => new Vector3(_Vector3.x * _Value, _Vector3.y, _Vector3.z),
            Axis.Y => new Vector3(_Vector3.x, _Vector3.y * _Value, _Vector3.z),
            Axis.Z => new Vector3(_Vector3.x, _Vector3.y, _Vector3.z * _Value),
            Axis.XY => new Vector3(_Vector3.x * _Value, _Vector3.y * _Value, _Vector3.z),
            Axis.XZ => new Vector3(_Vector3.x * _Value, _Vector3.y, _Vector3.z * _Value),
            Axis.YZ => new Vector3(_Vector3.x, _Vector3.y * _Value, _Vector3.z * _Value),
            Axis.XYZ => new Vector3(_Vector3.x * _Value, _Vector3.y * _Value, _Vector3.z * _Value),
            _ => throw ArgumentOutOfRangeException(nameof(_Axis), _Axis)
        };

        /// <summary>
        /// Adds a specified value to the components of a <see cref="Vector3"/> along the given axis.
        /// </summary>
        /// <param name="_Vector3">The <see cref="Vector3"/> to which the value will be added.</param>
        /// <param name="_Axis">The axis along which to add the value to the component(s).</param>
        /// <param name="_Value">The value to add to the component(s).</param>
        /// <returns>A new <see cref="Vector3"/> with the added values.</returns>
        public static Vector3 Plus(this Vector3 _Vector3, Axis _Axis, float _Value) => _Axis switch
        {
            Axis.X => new Vector3(_Vector3.x + _Value, _Vector3.y, _Vector3.z),
            Axis.Y => new Vector3(_Vector3.x, _Vector3.y + _Value, _Vector3.z),
            Axis.Z => new Vector3(_Vector3.x, _Vector3.y, _Vector3.z + _Value),
            Axis.XY => new Vector3(_Vector3.x + _Value, _Vector3.y + _Value, _Vector3.z),
            Axis.XZ => new Vector3(_Vector3.x + _Value, _Vector3.y, _Vector3.z + _Value),
            Axis.YZ => new Vector3(_Vector3.x, _Vector3.y + _Value, _Vector3.z + _Value),
            Axis.XYZ => new Vector3(_Vector3.x + _Value, _Vector3.y + _Value, _Vector3.z + _Value),
            _ => throw ArgumentOutOfRangeException(nameof(_Axis), _Axis)
        };

        /// <summary>
        /// Sets the component(s) of a <see cref="Vector3"/> to a specified value along the given axis.
        /// </summary>
        /// <param name="_Vector3">The <see cref="Vector3"/> to be modified.</param>
        /// <param name="_Axis">The axis along which to set the component(s).</param>
        /// <param name="_Value">The value to set the component(s) to.</param>
        /// <returns>A new <see cref="Vector3"/> with the set values.</returns>
        public static Vector3 Set(this Vector3 _Vector3, Axis _Axis, float _Value) => _Axis switch
        {
            Axis.X => new Vector3(_Value, _Vector3.y, _Vector3.z),
            Axis.Y => new Vector3(_Vector3.x, _Value, _Vector3.z),
            Axis.Z => new Vector3(_Vector3.x, _Vector3.y, _Value),
            Axis.XY => new Vector3(_Value, _Value, _Vector3.z),
            Axis.XZ => new Vector3(_Value, _Vector3.y, _Value),
            Axis.YZ => new Vector3(_Vector3.x, _Value, _Value),
            Axis.XYZ => new Vector3(_Value, _Value, _Value),
            _ => throw ArgumentOutOfRangeException(nameof(_Axis), _Axis)
        };

        /// <summary>
        /// Creates a new <see cref="ArgumentOutOfRangeException"/> for the specified parameter and axis.
        /// </summary>
        /// <param name="_ParameterName">The name of the parameter that caused the exception.</param>
        /// <param name="_Axis">The axis enumeration value that is not allowed.</param>
        /// <returns>An instance of <see cref="ArgumentOutOfRangeException"/>.</returns>
        private static ArgumentOutOfRangeException ArgumentOutOfRangeException(string _ParameterName, Axis _Axis)
        {
            return new ArgumentOutOfRangeException(_ParameterName, _Axis, $"The value of [{nameof(_Axis)}]:{_Axis}, is not allowed.");
        }

        /// <summary>
        /// Sets the x component of a <see cref="Vector3"/> to a specified value.
        /// </summary>
        /// <param name="_Vector">The <see cref="Vector3"/> to modify.</param>
        /// <param name="_X">The new value for the x component.</param>
        /// <param name="_Add">If true, adds the value to the existing x component; otherwise, sets the x component to the specified value.</param>
        /// <returns>A new <see cref="Vector3"/> with the modified x component.</returns>
        public static Vector3 WithX(this Vector3 _Vector, float _X, bool _Add = false)
        {
            _Vector.x = _Add == false ? _X : _Vector.x + _X;
            return _Vector;
        }

        /// <summary>
        /// Sets or adds a specified value to the Y component of a given <see cref="Vector3"/>.
        /// </summary>
        /// <param name="_Vector">The <see cref="Vector3"/> whose Y component is to be modified.</param>
        /// <param name="_Y">The value to set or add to the Y component.</param>
        /// <param name="_Add">If true, adds the value to the current Y component; otherwise, sets the Y component to the specified value.</param>
        /// <returns>A new <see cref="Vector3"/> with the modified Y component.</returns>
        public static Vector3 WithY(this Vector3 _Vector, float _Y, bool _Add = false)
        {
            _Vector.y = _Add == false ? _Y : _Vector.y + _Y;
            return _Vector;
        }

        /// <summary>
        /// Returns a new <see cref="Vector3"/> with the Z component set to a specified value, or optionally added to the current Z component.
        /// </summary>
        /// <param name="_Vector">The <see cref="Vector3"/> to modify.</param>
        /// <param name="_Z">The value to set or add to the Z component.</param>
        /// <param name="_Add">If true, adds _Z to the current Z component rather than setting it. Default is false.</param>
        /// <returns>A new <see cref="Vector3"/> with the modified Z component.</returns>
        public static Vector3 WithZ(this Vector3 _Vector, float _Z, bool _Add = false)
        {
            _Vector.z = _Add == false ? _Z : _Vector.z + _Z;
            return _Vector;
        }

        /// <summary>
        /// Updates the x and y components of the <see cref="Vector3"/> with the specified values, with an option to add to the existing components.
        /// </summary>
        /// <param name="_Vector">The original <see cref="Vector3"/> to be updated.</param>
        /// <param name="_X">The new value for the x component.</param>
        /// <param name="_Y">The new value for the y component.</param>
        /// <param name="_Add">If true, the specified values will be added to the existing components; otherwise, they will replace the existing components.</param>
        /// <returns>A new <see cref="Vector3"/> with the updated x and y values.</returns>
        public static Vector3 WithXY(this Vector3 _Vector, float _X, float _Y, bool _Add = false)
        {
            _Vector.x = _Add == false ? _X : _Vector.x + _X;
            _Vector.y = _Add == false ? _Y : _Vector.y + _Y;

            return _Vector;
        }

        /// <summary>
        /// Adjusts the x and z components of a Vector3 with optional addition.
        /// </summary>
        /// <param name="_Vector">The Vector3 to be adjusted.</param>
        /// <param name="_X">The value to set or add to the x component.</param>
        /// <param name="_Z">The value to set or add to the z component.</param>
        /// <param name="_Add">Determines whether to add to the current components (true) or set them (false).</param>
        /// <returns>A new Vector3 with the adjusted x and z components.</returns>
        public static Vector3 WithXZ(this Vector3 _Vector, float _X, float _Z, bool _Add = false)
        {
            _Vector.x = _Add == false ? _X : _Vector.x + _X;
            _Vector.z = _Add == false ? _Z : _Vector.z + _Z;

            return _Vector;
        }

        /// <summary>
        /// Sets the Y and Z components of a <see cref="Vector3"/> to the specified values, optionally adding the specified values to the existing components.
        /// </summary>
        /// <param name="_Vector">The <see cref="Vector3"/> to be modified.</param>
        /// <param name="_Y">The value to set (or add to) the Y component.</param>
        /// <param name="_Z">The value to set (or add to) the Z component.</param>
        /// <param name="_Add">If true, the specified values will be added to the existing components; otherwise, the components will be set to the specified values.</param>
        /// <returns>The modified <see cref="Vector3"/>.</returns>
        public static Vector3 WithYZ(this Vector3 _Vector, float _Y, float _Z, bool _Add = false)
        {
            _Vector.y = _Add == false ? _Y : _Vector.y + _Y;
            _Vector.z = _Add == false ? _Z : _Vector.z + _Z;

            return _Vector;
        }

        /// <summary>
        /// Sets or adds the specified x, y, and z values to the components of the given <see cref="Vector3"/>.
        /// </summary>
        /// <param name="_Vector">The <see cref="Vector3"/> instance to modify.</param>
        /// <param name="_X">The new x value or the value to add to the current x component.</param>
        /// <param name="_Y">The new y value or the value to add to the current y component.</param>
        /// <param name="_Z">The new z value or the value to add to the current z component.</param>
        /// <param name="_Add">If true, the specified values are added to the current components; otherwise, they replace the current components.</param>
        /// <returns>The modified <see cref="Vector3"/>.</returns>
        public static Vector3 WithXYZ(this Vector3 _Vector, float _X, float _Y, float _Z, bool _Add = false)
        {
            _Vector.x = _Add == false ? _X : _Vector.x + _X;
            _Vector.y = _Add == false ? _Y : _Vector.y + _Y;
            _Vector.z = _Add == false ? _Z : _Vector.z + _Z;

            return _Vector;
        }
        #endregion
    }
}
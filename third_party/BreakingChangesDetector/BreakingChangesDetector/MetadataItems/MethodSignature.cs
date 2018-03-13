/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.MetadataItems
{
#if DEBUG
	/// <summary>
	/// Represent the signature of a method which can be distinguished from other methods in the same assembly.
	/// </summary> 
#endif
	internal class MethodSignature
	{
		private readonly string _declaringTypeName;
		private readonly int _genericParameterCount;
		private readonly string _methodName;
		private readonly TypeKey[] _parameterTypes;

		public MethodSignature(MethodDefinition method)
		{
			_declaringTypeName = method.DeclaringType.FullName;
			_genericParameterCount = method.GenericParameters.Count;
			_methodName = method.Name;
			_parameterTypes = new TypeKey[method.Parameters.Count];
			for (int i = 0; i < _parameterTypes.Length; i++)
				_parameterTypes[i] = TypeKey.Create(method.Parameters[i]);
		}

		public override bool Equals(object obj)
		{
			var other = obj as MethodSignature;
			if (other == null)
				return false;

			if (_declaringTypeName != other._declaringTypeName)
				return false;

			if (_genericParameterCount != other._genericParameterCount)
				return false;

			if (_methodName != other._methodName)
				return false;

			if (_parameterTypes.Length != other._parameterTypes.Length)
				return false;

			for (int i = 0; i < _parameterTypes.Length; i++)
			{
				if (_parameterTypes[i].Equals(other._parameterTypes[i]) == false)
					return false;
			}

			return true;
		}

		public override int GetHashCode()
		{
			var hashCode =
				_declaringTypeName.GetHashCode() ^
				(_genericParameterCount << 5) ^
				_methodName.GetHashCode() << 7 ^
				_parameterTypes.Length << 10;

			for (int i = 0; i < _parameterTypes.Length; i++)
				hashCode ^= _parameterTypes[i].GetHashCode() << (i % 16);

			return hashCode;
		}

		public override string ToString()
		{
			var genericSignature = _genericParameterCount == 0 ? "" : "<" + new string(',', _genericParameterCount - 1) + ">";
			var parameterSignature = string.Join(", ", from t in _parameterTypes select t);
			return _declaringTypeName + "." + _methodName + genericSignature + "(" + parameterSignature + ")";
		}

		private abstract class TypeKey
		{
			public static TypeKey Create(ParameterDefinition parameter)
			{
				var genericParameter = parameter.ParameterType as GenericParameter;
				if (genericParameter == null)
					return new TypeNameTypeKey(parameter.ParameterType);

				if (genericParameter.DeclaringMethod != null)
					return new MethodGenericParameterTypeKey(genericParameter.Position);

				return new TypeGenericParameterTypeKey(genericParameter.Position);
			}
		}

		private sealed class MethodGenericParameterTypeKey : TypeKey
		{
			private readonly int _position;

			public MethodGenericParameterTypeKey(int position)
			{
				_position = position;
			}

			public override bool Equals(object obj)
			{
				var other = obj as MethodGenericParameterTypeKey;
				return other != null && _position == other._position;
			}

			public override int GetHashCode()
			{
				return _position << 3;
			}

			public override string ToString()
			{
				return "<M_" + _position + ">";
			}
		}

		private sealed class TypeGenericParameterTypeKey : TypeKey
		{
			private readonly int _position;

			public TypeGenericParameterTypeKey(int position)
			{
				_position = position;
			}

			public override bool Equals(object obj)
			{
				var other = obj as TypeGenericParameterTypeKey;
				return other != null && _position == other._position;
			}

			public override int GetHashCode()
			{
				return _position << 7;
			}

			public override string ToString()
			{
				return "<T_" + _position + ">";
			}
		}

		private sealed class TypeNameTypeKey : TypeKey
		{
			private readonly string _assemblyName;
			private readonly string _fullName;

			public TypeNameTypeKey(TypeReference type)
			{
				if (type.GetType() == typeof(TypeReference))
					type = type.Resolve();

				_fullName = type.FullName;
				_assemblyName = type.GetDeclaringAssembly().FullName;
			}

			public override bool Equals(object obj)
			{
				var other = obj as TypeNameTypeKey;
				return
					other != null &&
					_assemblyName == other._assemblyName &&
					_fullName == other._fullName;
			}

			public override int GetHashCode()
			{
				return
					_assemblyName.GetHashCode() ^
					(_fullName.GetHashCode() << 5);
			}

			public override string ToString()
			{
				return _fullName;
			}
		}
	}
}

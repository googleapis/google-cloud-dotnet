/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.
    Copyright 2018 Google LLC

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

using Microsoft.CodeAnalysis;
using System.Linq;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Represent the signature of a method which can be distinguished from other methods in the same assembly.
    /// </summary> 
    internal sealed class MethodSignature
    {
        private readonly string _declaringTypeName;
        private readonly int _typeParameterCount;
        private readonly string _methodName;
        private readonly ParameterKey[] _parameters;

        public MethodSignature(MetadataResolutionContext context, IMethodSymbol methodSymbol)
        {
            _declaringTypeName = methodSymbol.ContainingType.GetFullName();
            _typeParameterCount = methodSymbol.TypeParameters.Length;
            _methodName = methodSymbol.Name;
            _parameters = methodSymbol.Parameters
                .Select(p => new ParameterKey(TypeKey.Create(context, p), p.RefKind))
                .ToArray();
        }

        public override bool Equals(object obj)
        {
            var other = obj as MethodSignature;
            if (other == null)
            {
                return false;
            }

            if (_declaringTypeName != other._declaringTypeName)
            {
                return false;
            }

            if (_typeParameterCount != other._typeParameterCount)
            {
                return false;
            }

            if (_methodName != other._methodName)
            {
                return false;
            }

            if (_parameters.Length != other._parameters.Length)
            {
                return false;
            }

            for (int i = 0; i < _parameters.Length; i++)
            {
                if (_parameters[i].Equals(other._parameters[i]) == false)
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var hashCode =
                _declaringTypeName.GetHashCode() ^
                (_typeParameterCount << 5) ^
                _methodName.GetHashCode() << 7 ^
                _parameters.Length << 10;

            for (int i = 0; i < _parameters.Length; i++)
            {
                hashCode ^= _parameters[i].GetHashCode() << (i % 16);
            }

            return hashCode;
        }

        public override string ToString()
        {
            var genericSignature = _typeParameterCount == 0 ? "" : "<" + new string(',', _typeParameterCount - 1) + ">";
            var parameterSignature = string.Join(", ", from t in _parameters select t);
            return _declaringTypeName + "." + _methodName + genericSignature + "(" + parameterSignature + ")";
        }

        private sealed class ParameterKey
        {
            private readonly RefKind _refKind;
            private readonly TypeKey _type;

            public ParameterKey(TypeKey type, RefKind refKind)
            {
                _type = type;
                _refKind = refKind;
            }

            public override bool Equals(object obj) =>
                obj is ParameterKey other && _refKind == other._refKind && _type.Equals(other._type);

            public override int GetHashCode() =>
                _refKind.GetHashCode() ^ _type.GetHashCode() << 3;

            public override string ToString() =>
                GetModifier(_refKind) + _type.ToString();

            private static string GetModifier(RefKind refKind)
            {
                switch (refKind)
                {
                    default:
                    case RefKind.None: return "";
                    case RefKind.In: return "in ";
                    case RefKind.Out: return "out ";
                    case RefKind.Ref: return "ref ";
                }
            }
        }

        private abstract class TypeKey
        {
            public static TypeKey Create(MetadataResolutionContext context, IParameterSymbol parameterSymbol)
            {
                var typeParameterSymbol = parameterSymbol.Type as ITypeParameterSymbol;
                if (typeParameterSymbol == null)
                {
                    return new TypeNameTypeKey(context, parameterSymbol.Type);
                }

                if (typeParameterSymbol.DeclaringMethod != null)
                {
                    return new MethodGenericParameterTypeKey(typeParameterSymbol.Ordinal);
                }

                return new TypeGenericParameterTypeKey(typeParameterSymbol.Ordinal);
            }
        }

        private sealed class MethodGenericParameterTypeKey : TypeKey
        {
            private readonly int _position;

            public MethodGenericParameterTypeKey(int position) => _position = position;

            public override bool Equals(object obj) =>
                obj is MethodGenericParameterTypeKey other && _position == other._position;

            public override int GetHashCode() => _position << 3;

            public override string ToString() => "<M_" + _position + ">";
        }

        private sealed class TypeGenericParameterTypeKey : TypeKey
        {
            private readonly int _position;

            public TypeGenericParameterTypeKey(int position) => _position = position;

            public override bool Equals(object obj) =>
                obj is TypeGenericParameterTypeKey other && _position == other._position;

            public override int GetHashCode() => _position << 7;

            public override string ToString() => "<T_" + _position + ">";
        }

        private sealed class TypeNameTypeKey : TypeKey
        {
            private readonly string _assemblyName;
            private readonly string _fullName;

            public TypeNameTypeKey(MetadataResolutionContext context, ITypeSymbol typeSymbol)
            {
                _fullName = typeSymbol.GetFullName();
                _assemblyName = context.GetDeclaringAssemblySymbol(typeSymbol).ToDisplayString();
            }

            public override bool Equals(object obj) =>
                obj is TypeNameTypeKey other &&
                _assemblyName == other._assemblyName &&
                _fullName == other._fullName;

            public override int GetHashCode() =>
                _assemblyName.GetHashCode() ^
                (_fullName.GetHashCode() << 5);

            public override string ToString() => _fullName;
        }
    }
}

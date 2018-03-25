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

using BreakingChangesDetector.MetadataItems;
using Infragistics;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace BreakingChangesDetector
{
    internal static class Utilities
	{
		public const string DynamicTypeName = "dynamic";

		public static readonly string ArrayTypeName = typeof(Array).FullName;
		public static readonly string CommonObjectRuntimeAssemblyName = typeof(int).Assembly.GetName().Name;
		public static readonly string EnumTypeName = typeof(Enum).FullName;
		public static readonly string ObjectTypeName = typeof(Object).FullName;
        public static readonly string VoidTypeName = typeof(void).FullName;

		public static readonly string ICloneableTypeName = typeof(ICloneable).FullName;
		public static readonly string IListTypeName = typeof(System.Collections.IList).FullName;
		public static readonly string ICollectionTypeName = typeof(System.Collections.ICollection).FullName;
		public static readonly string IEnumerableTypeName = typeof(System.Collections.IEnumerable).FullName;
		public static readonly string IStructuralComparableTypeName = typeof(System.Collections.IStructuralComparable).FullName;
		public static readonly string IStructuralEquatableTypeName = typeof(System.Collections.IStructuralEquatable).FullName;
		public static readonly string IListGenericTypeName = typeof(IList<>).FullName;
		public static readonly string ICollectionGenericTypeName = typeof(ICollection<>).FullName;
		public static readonly string IEnumerableGenericTypeName = typeof(IEnumerable<>).FullName;
		public static readonly string IReadOnlyListGenericTypeName = typeof(IReadOnlyList<>).FullName;
		public static readonly string IReadOnlyCollectionGenericTypeName = typeof(IReadOnlyCollection<>).FullName;

		public static bool CanRead(this MemberDataBase propertyFieldOrConstant)
		{
			switch (propertyFieldOrConstant.MetadataItemKind)
			{
				case MetadataItemKinds.Constant: return true;
				case MetadataItemKinds.Field: return true;
				case MetadataItemKinds.Property: return ((PropertyData)propertyFieldOrConstant).GetMethodAccessibility != null;

				default:
					Debug.Fail("Unknown MetadataItemKinds: " + propertyFieldOrConstant.MetadataItemKind);
					return false;
			}
		}

		public static bool CanWrite(this MemberDataBase propertyFieldOrConstant)
		{
			switch (propertyFieldOrConstant.MetadataItemKind)
			{
				case MetadataItemKinds.Constant: return false;
				case MetadataItemKinds.Field: return ((FieldData)propertyFieldOrConstant).IsReadOnly == false;
				case MetadataItemKinds.Property: return ((PropertyData)propertyFieldOrConstant).SetMethodAccessibility != null;

				default:
					Debug.Fail("Unknown MetadataItemKinds: " + propertyFieldOrConstant.MetadataItemKind);
					return false;
			}
		}

        public static string GetFullName(this ITypeSymbol typeSymbol)
        {
            if (!typeSymbol.CanBeReferencedByName || typeSymbol.TypeKind == Microsoft.CodeAnalysis.TypeKind.TypeParameter)
            {
                return typeSymbol.ToDisplayString();
            }

            string suffix = null;
            if (typeSymbol is INamedTypeSymbol namedType && namedType.IsConstructed())
            {
                // TODO_Refactor: The assembly full name is included in the arguments here
                suffix = $"[{string.Join(",", namedType.TypeArguments.Select(a => $"[{a.GetFullName()}]"))}]";
            }

            if (typeSymbol.ContainingType != null)
            {
                return typeSymbol.ContainingType.GetFullName() + "/" + typeSymbol.MetadataName + suffix;
            }
            else if (typeSymbol.ContainingNamespace.IsGlobalNamespace)
            {
                return typeSymbol.MetadataName + suffix;
            }
            else
            {
                return typeSymbol.ContainingNamespace.ToDisplayString() + "." + typeSymbol.MetadataName + suffix;
            }
        }

		public static bool EqualsType(this ITypeSymbol typeSymbol, Type type)
		{
			if (typeSymbol == null)
				return type == null;
			else if (type == null)
				return false;

			return
                typeSymbol.GetFullName() == type.FullName.Replace('+', '/') &&
				typeSymbol.ContainingAssembly.ToDisplayString() == type.Assembly.FullName;
		}

		public static string FormatEnumValue(TypeDefinitionData enumType, object value)
		{
			var unqualifiedName = enumType.GetDisplayName(fullyQualify: false);

			foreach (ConstantData constant in enumType.GetMembers())
			{
				if (Object.Equals(constant.Value, value))
					return unqualifiedName + "." + constant.Name;
			}

			if (enumType.IsFlagsEnum)
			{
				var sb = new StringBuilder();
				var longValue = Convert.ToUInt64(value);
				foreach (ConstantData constant in enumType.GetMembers())
				{
					var longFlag = Convert.ToUInt64(constant.Value);
					if ((longValue & longFlag) == longFlag)
					{
						longValue &= ~longFlag;

						if (sb.Length != 0)
							sb.Append(" | ");

						sb.AppendFormat("{0}.{1}", unqualifiedName, constant.Name);

						if (longValue == 0)
							return sb.ToString();
					}
				}
			}

			var rawValue = (ulong)value;
			return string.Format("({0}){1}", unqualifiedName, rawValue);
		}

        public static MemberAccessibility? GetAccessibility(this ISymbol symbol)
        {
            if (symbol == null)
            {
                return null;
            }
            switch (symbol.DeclaredAccessibility)
            {
                case Accessibility.NotApplicable:
                case Accessibility.Public:
                    return MemberAccessibility.Public;
                case Accessibility.ProtectedAndInternal:
                case Accessibility.ProtectedOrInternal:
                case Accessibility.Protected:
                    return MemberAccessibility.Protected;
            }
            return null;
        }

        public static GenericTypeParameterCollection GetGenericParameters(INamedTypeSymbol namedTypeSymbol, MemberDataBase declaringMember)
        {
            // TODO_Refactor: Since Roslyn requires this but Mono.Cecil did not, perhaps we can redesign things so we don't have to do this.
            IEnumerable<ITypeParameterSymbol> allGenericParameters = namedTypeSymbol.TypeParameters;
            while (true)
            {
                namedTypeSymbol = namedTypeSymbol.ContainingType;
                if (namedTypeSymbol == null)
                {
                    break;
                }
                if (!namedTypeSymbol.TypeParameters.IsEmpty)
                {
                    allGenericParameters = namedTypeSymbol.TypeParameters.Concat(allGenericParameters);
                }
            }
            return GetGenericParameters(allGenericParameters, declaringMember);
        }

        public static GenericTypeParameterCollection GetGenericParameters(IEnumerable<ITypeParameterSymbol> typeParameterSymbols, MemberDataBase declaringMember)
        {
            return new GenericTypeParameterCollection(typeParameterSymbols.Select(typeParameterSymbol =>
            {
                var genericParameter = declaringMember.Context.GetGenericTypeParameterData(typeParameterSymbol);

                if (declaringMember != null) // TODO: Is this needed?
                {
                    // TODO_Refactor: If non-null, assert it is a containing type
                    //Debug.Assert(genericParameter.GenericDeclaringMember == null, "The GenericDeclaringMember should not be set twice.");
                    if (genericParameter.GenericDeclaringMember == null)
                    {
                        genericParameter.GenericDeclaringMember = declaringMember;
                    }
                }

                return genericParameter;
            }));
        }

		public static MemberAccessibility GetLeastRestrictiveAccessibility(MemberAccessibility? a, MemberAccessibility? b)
		{
			if (a == MemberAccessibility.Public || b == MemberAccessibility.Public)
				return MemberAccessibility.Public;

			if (a == MemberAccessibility.Protected || b == MemberAccessibility.Protected)
				return MemberAccessibility.Protected;

			Debug.Fail("Unknown MemberAccessibility: " + (a ?? b));
			return MemberAccessibility.Protected;
		}

		public static MemberFlags GetMemberFlags(IMethodSymbol methodSymbol)
		{
			if (methodSymbol == null)
				return 0;

			var flags = MemberFlags.None;

            if (methodSymbol.IsStatic)
            {
                flags |= MemberFlags.Static;
            }

            if (methodSymbol.IsOverride)
            {
                flags |= MemberFlags.Override;
            }

            if (methodSymbol.IsAbstract)
			{
				flags |= MemberFlags.Abstract;
			}

            if (methodSymbol.IsVirtual)
			{
                flags |= MemberFlags.Virtual;
			}

            if (methodSymbol.IsSealed)
            {
                flags |= MemberFlags.Sealed;
            }

			// Non-virtual interface implicit implementations are marked virtual sealed. They should have neither flag for our purposes.
			// It is safe to strip out these flags when both are present because it is impossible in code to declare something as virtual sealed.
			if (flags.HasFlag(MemberFlags.Virtual) && flags.HasFlag(MemberFlags.Sealed))
				flags &= ~(MemberFlags.Virtual | MemberFlags.Sealed);

			return flags;
		}

		public static MemberFlags GetMemberFlags(ITypeSymbol typeSymbol)
		{
			var namedTypeSymbol = typeSymbol as INamedTypeSymbol;
			if (namedTypeSymbol == null)
				return 0;

			var flags = (MemberFlags)0;

            if (namedTypeSymbol.IsStatic)
            {
                flags |= MemberFlags.Static;
            }

			if (namedTypeSymbol.IsAbstract)
			{
                flags |= MemberFlags.Abstract;
			}

            if (namedTypeSymbol.IsSealed)
			{
				flags |= MemberFlags.Sealed;
			}

			return flags;
		}

        // TODO: Rename these
		public static IEnumerable<ISymbol> Members(this INamedTypeSymbol namedTypeSymbol)
		{
            foreach (var member in namedTypeSymbol.GetMembers())
            {
                switch (namedTypeSymbol.Kind)
                {
                    case SymbolKind.Event:
                    case SymbolKind.Property:
                    case SymbolKind.Field:
                    case SymbolKind.NamedType:
                        yield return member;
                        break;

                    case SymbolKind.Method:
                        {
                            var method = (IMethodSymbol)member;
                            if (method.AssociatedSymbol == null)
                            {
                                yield return member;
                            }
                            break;
                        }
                }
            }
		}

        public static IEnumerable<IMethodSymbol> Methods(this INamedTypeSymbol namedTypeSymbol) => namedTypeSymbol.Members().OfType<IMethodSymbol>();
        public static IEnumerable<IPropertySymbol> Properties(this INamedTypeSymbol namedTypeSymbol) => namedTypeSymbol.Members().OfType<IPropertySymbol>();
        public static IEnumerable<IEventSymbol> Events(this INamedTypeSymbol namedTypeSymbol) => namedTypeSymbol.Members().OfType<IEventSymbol>();

        #region GetNamespaceRenames

        public static IEnumerable<KeyValuePair<string, string>> GetNamespaceRenames(IAssemblySymbol assemblySymbol)
		{
			var namespaceRenamedAttributeDatas = assemblySymbol.GetAttributes().Where(
				a => a.AttributeClass.GetFullName() == typeof(NamespaceRenamedAttribute).FullName
				);

			foreach (var attributeData in namespaceRenamedAttributeDatas)
			{
				var oldNamespaceName = attributeData.ConstructorArguments[0].Value as string;
				var newNamespaceName = attributeData.ConstructorArguments[1].Value as string;
				if (oldNamespaceName != null && newNamespaceName != null)
					yield return new KeyValuePair<string, string>(oldNamespaceName, newNamespaceName);
			}
		}

		#endregion // GetNamespaceRenames

		public static TypeKind GetTypeKind(ITypeSymbol typeSymbol)
		{
			var typeParameterSymbol = typeSymbol as ITypeParameterSymbol;
			if (typeParameterSymbol != null)
			{
				if (typeParameterSymbol.HasValueTypeConstraint)
					return TypeKind.Struct;

				return TypeKind.Class;
			}

            if (typeSymbol.BaseType.EqualsType(typeof(MulticastDelegate)))
				return TypeKind.Delegate;

			if (typeSymbol.TypeKind == Microsoft.CodeAnalysis.TypeKind.Enum)
				return TypeKind.Enum;

			if (typeSymbol.IsValueType)
				return TypeKind.Struct;

			if (typeSymbol.TypeKind == Microsoft.CodeAnalysis.TypeKind.Interface)
				return TypeKind.Interface;

			if (typeSymbol.IsReferenceType)
				return TypeKind.Class;

			Debug.Fail("Unknown kind of type: " + typeSymbol.GetFullName());
			return TypeKind.Class;
		}

		#region GetVersionComparisonName

#if DEBUG
		/// <summary>
		/// Gets the version comparison name for the specified <see cref="Assembly"/>, which is the name by which assemblies across versions can be 
		/// matched up to be treated as logically equivalent.
		/// </summary>
		/// <param name="assemblySymbol">The Assembly of which to get the version comparison name.</param>
		/// <returns></returns> 
#endif
		public static string GetVersionComparisonName(IAssemblySymbol assemblySymbol)
		{
			var versionComparisonNameAttributeData = assemblySymbol.GetAttributes().FirstOrDefault(
				a => a.AttributeClass.GetFullName() == typeof(VersionComparisonNameAttribute).FullName
				);

			if (versionComparisonNameAttributeData != null)
			{
				var value = versionComparisonNameAttributeData.ConstructorArguments[0].Value as string;
				if (value != null)
					return value;
			}

			return assemblySymbol.Name;
		}

        #endregion // GetVersionComparisonName

        public static bool IsConstructed(this INamedTypeSymbol namedTypeSymbol) =>
            !namedTypeSymbol.ConstructedFrom.Equals(namedTypeSymbol);

		public static bool IsDynamicType(this IFieldSymbol fieldSymbol)
		{
			return fieldSymbol.GetAttributes().Any(a => a.AttributeClass.EqualsType(typeof(DynamicAttribute)));
		}

		public static bool IsDynamicType(this IParameterSymbol parameterSymbol)
		{
			return parameterSymbol.GetAttributes().Any(a => a.AttributeClass.EqualsType(typeof(DynamicAttribute)));
		}

		public static bool IsNullable(this Type t)
		{
			return t.IsConstructedGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		public static bool IsNullable(this ITypeSymbol typeSymbol)
		{
			var namedTypeSymbol = typeSymbol as INamedTypeSymbol;
			return namedTypeSymbol != null && namedTypeSymbol.ConstructedFrom.EqualsType(typeof(Nullable<>));
		}

        public static bool TryGetNullableUnderlyingType(this ITypeSymbol type, out ITypeSymbol underlyingType)
        {
            if (type.IsNullable())
            {
                underlyingType = ((INamedTypeSymbol)type).TypeArguments[0];
                return true;
            }
            else
            {
                underlyingType = null;
                return false;
            }
        }

        public static bool IsPropertyTypeDynamic(this IPropertySymbol propertySymbol)
		{
			if (propertySymbol.GetMethod != null)
				return propertySymbol.GetMethod.IsReturnTypeDynamic();

			var parameters = propertySymbol.SetMethod.Parameters;
			return parameters[parameters.Length - 1].IsDynamicType();
		}

		public static bool IsReturnTypeDynamic(this IMethodSymbol methodSymbol)
		{
			return methodSymbol.GetReturnTypeAttributes().Any(a => a.AttributeClass.EqualsType(typeof(DynamicAttribute)));
		}

        public static object PreprocessConstantValue(ITypeSymbol typeSymbol, object value)
        {
            if (value != null)
            {
                if (typeSymbol.TryGetNullableUnderlyingType(out var underlyingType))
                {
                    typeSymbol = underlyingType;
                }

                if (typeSymbol.TypeKind == Microsoft.CodeAnalysis.TypeKind.Enum)
                {
                    try
                    {
                        value = Convert.ToUInt64(value);
                    }
                    catch (OverflowException)
                    {
                        value = unchecked((ulong)Convert.ToInt64(value));
                    }
                }
            }

            return value;
        }
	}
}

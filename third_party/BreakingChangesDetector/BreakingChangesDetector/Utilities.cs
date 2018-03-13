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

using BreakingChangesDetector.MetadataItems;
using Infragistics;
using Mono.Cecil;
using Mono.Cecil.Rocks;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

		public static bool EqualsType(this TypeReference typeReference, Type type)
		{
			if (typeReference == null)
				return type == null;
			else if (type == null)
				return false;

			if (typeReference.GetType() == typeof(TypeReference))
				typeReference = typeReference.Resolve();

			return
				typeReference.FullName == type.FullName.Replace('+', '/') &&
				typeReference.GetDeclaringAssembly().FullName == type.Assembly.FullName;
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

		public static MemberAccessibility? GetAccessibility(this FieldDefinition field)
		{
			if (field.IsPublic)
				return MemberAccessibility.Public;
			else if (field.IsFamily || field.IsFamilyAndAssembly || field.IsFamilyOrAssembly)
				return MemberAccessibility.Protected;

			return null;
		}

		public static MemberAccessibility? GetAccessibility(this MethodDefinition member)
		{
			if (member != null)
			{
				if (member.IsPublic)
					return MemberAccessibility.Public;
				else if (member.IsFamily || member.IsFamilyAndAssembly || member.IsFamilyOrAssembly)
					return MemberAccessibility.Protected;
			}

			return null;
		}

		public static MemberAccessibility? GetAccessibility(this TypeReference type)
		{
			TypeSpecification typeSpecification;
			while ((typeSpecification = type as TypeSpecification) != null)
				type = typeSpecification.ElementType;

			if (type is GenericParameter)
				return MemberAccessibility.Public;

			var typeDefinition = type.Resolve();
			if (typeDefinition.IsPublic)
				return MemberAccessibility.Public;

			if (typeDefinition.IsNested && GetAccessibility(typeDefinition.DeclaringType) != null)
			{
				if (typeDefinition.IsNestedPublic)
					return MemberAccessibility.Public;
				else if (typeDefinition.IsNestedFamily || typeDefinition.IsNestedFamilyAndAssembly || typeDefinition.IsNestedFamilyOrAssembly)
					return MemberAccessibility.Protected;
			}

			return null;
		}

		public static AssemblyDefinition GetDeclaringAssembly(this TypeReference type)
		{
			var elementType = type.GetElementType();

			var genericParameter = elementType as GenericParameter;
			if (genericParameter != null)
			{
				if (genericParameter.DeclaringMethod != null)
					return genericParameter.DeclaringMethod.DeclaringType.GetDeclaringAssembly();

				return genericParameter.DeclaringType.GetDeclaringAssembly();
			}

			return elementType.Resolve().Module.AssemblyResolved;
		}

		public static object GetDefualtValue(this ParameterDefinition parameter)
		{
			if (parameter.HasCustomAttributes)
			{
				var decimalConstant = parameter.CustomAttributes.FirstOrDefault(a => a.AttributeType.EqualsType(typeof(DecimalConstantAttribute)));
				if (decimalConstant != null)
				{
					if (decimalConstant.ConstructorArguments.Count == 5)
					{
						var scale = Convert.ToByte(decimalConstant.ConstructorArguments[0].Value);
						var sign = Convert.ToByte(decimalConstant.ConstructorArguments[1].Value);
						var hi = Convert.ToInt32(decimalConstant.ConstructorArguments[2].Value);
						var mid = Convert.ToInt32(decimalConstant.ConstructorArguments[3].Value);
						var low = Convert.ToInt32(decimalConstant.ConstructorArguments[4].Value);
						return new decimal(low, mid, hi, sign != 0, scale);
					}
					else
					{
						Debug.Fail("There should be 5 arguments in the DecimalConstantAttribute");

					}
				}
			}

			return parameter.Constant;
		}

		public static GenericTypeParameterCollection GetGenericParameters(IEnumerable<GenericParameter> genericArguments, MemberDataBase declaringMember)
		{
			return new GenericTypeParameterCollection(genericArguments.Select(a =>
			{
				var genericParameter = GenericTypeParameterData.FromType(a);

				if (declaringMember != null)
				{
					Debug.Assert(genericParameter.GenericDeclaringMember == null, "The GenericDeclaringMember should not be set twice.");
					genericParameter.GenericDeclaringMember = declaringMember;
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

		public static MemberFlags GetMemberFlags(MethodDefinition method)
		{
			if (method == null)
				return 0;

			var flags = MemberFlags.None;

			if (method.IsStatic)
				flags |= MemberFlags.Static;

			if (method.IsAbstract)
			{
				flags |= MemberFlags.Abstract;

				if (method.GetBaseMethod() != method)
					flags |= MemberFlags.Override;
			}
			else if (method.IsVirtual)
			{
				if (method.GetBaseMethod() != method)
					flags |= MemberFlags.Override;
				else
					flags |= MemberFlags.Virtual;
			}

			if (method.IsFinal)
				flags |= MemberFlags.Sealed;

			// Non-virtual interface implicit implementations are marked virtual sealed. They should have neither flag for our purposes.
			// It is safe to strip out these flags when both are present because it is impossible in code to declare something as virtual sealed.
			if (flags.HasFlag(MemberFlags.Virtual) && flags.HasFlag(MemberFlags.Sealed))
				flags &= ~(MemberFlags.Virtual | MemberFlags.Sealed);

			return flags;
		}

		public static MemberFlags GetMemberFlags(TypeReference type)
		{
			var typeDefinition = type as TypeDefinition;
			if (typeDefinition == null)
				return 0;

			var flags = (MemberFlags)0;

			if (typeDefinition.IsAbstract)
			{
				if (typeDefinition.IsSealed)
					flags |= MemberFlags.Static;
				else
					flags |= MemberFlags.Abstract;
			}
			else if (typeDefinition.IsSealed)
			{
				flags |= MemberFlags.Sealed;
			}

			return flags;
		}

		public static IEnumerable<MemberReference> GetMembers(this TypeDefinition type)
		{
			foreach (var member in type.Events)
				yield return member;

			foreach (var member in type.Fields)
				yield return member;

			foreach (var member in type.Methods)
				yield return member;

			foreach (var member in type.NestedTypes)
				yield return member;

			foreach (var member in type.Properties)
				yield return member;
		}

		#region GetNamespaceRenames

		public static IEnumerable<KeyValuePair<string, string>> GetNamespaceRenames(AssemblyDefinition assembly)
		{
			var namespaceRenamedAttributeDatas = assembly.CustomAttributes.Where(
				a => a.AttributeType.FullName == typeof(NamespaceRenamedAttribute).FullName
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

		public static TypeKind GetTypeKind(TypeReference type)
		{
			var genericParameter = type as GenericParameter;
			if (genericParameter != null)
			{
				if (genericParameter.HasNotNullableValueTypeConstraint)
					return TypeKind.Struct;

				return TypeKind.Class;
			}

			var typeDefinition = type.Resolve();

			if (typeDefinition.BaseType.EqualsType(typeof(MulticastDelegate)))
				return TypeKind.Delegate;

			if (typeDefinition.IsEnum)
				return TypeKind.Enum;

			if (typeDefinition.IsValueType)
				return TypeKind.Struct;

			if (typeDefinition.IsInterface)
				return TypeKind.Interface;

			if (typeDefinition.IsClass)
				return TypeKind.Class;

			Debug.Fail("Unknown kind of type: " + type.FullName);
			return TypeKind.Class;
		}

		#region GetVersionComparisonName

#if DEBUG
		/// <summary>
		/// Gets the version comparison name for the specified <see cref="Assembly"/>, which is the name by which assemblies across versions can be 
		/// matched up to be treated as logically equivalent.
		/// </summary>
		/// <param name="assembly">The Assembly of which to get the version comparison name.</param>
		/// <returns></returns> 
#endif
		public static string GetVersionComparisonName(AssemblyDefinition assembly)
		{
			var versionComparisonNameAttributeData = assembly.CustomAttributes.Where(
				a => a.AttributeType.FullName == typeof(VersionComparisonNameAttribute).FullName
				).FirstOrDefault();

			if (versionComparisonNameAttributeData != null)
			{
				var value = versionComparisonNameAttributeData.ConstructorArguments[0].Value as string;
				if (value != null)
					return value;
			}

			return assembly.FullName;
		}

		#endregion // GetVersionComparisonName

		public static bool IsDynamicType(this FieldDefinition field)
		{
			return field.CustomAttributes.Any(a => a.AttributeType.EqualsType(typeof(DynamicAttribute)));
		}

		public static bool IsDynamicType(this ParameterDefinition parameter)
		{
			return parameter.CustomAttributes.Any(a => a.AttributeType.EqualsType(typeof(DynamicAttribute)));
		}

		public static bool IsEnum(this TypeReference type)
		{
			if (type.GetType() == typeof(TypeReference))
				type = type.Resolve();

			var typeDefinition = type as TypeDefinition;
			return typeDefinition != null && typeDefinition.IsEnum;
		}

		#region IsNullable

		public static bool IsNullable(this Type t)
		{
			return t.IsConstructedGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		public static bool IsNullable(this TypeReference type)
		{
			var genericInstance = type as GenericInstanceType;
			return genericInstance != null && genericInstance.ElementType.EqualsType(typeof(Nullable<>));
		}

		#endregion // IsNullable

		public static bool IsPropertyTypeDynamic(this PropertyDefinition property)
		{
			if (property.GetMethod != null)
				return property.GetMethod.IsReturnTypeDynamic();

			var parameters = property.SetMethod.Parameters;
			return parameters[parameters.Count - 1].IsDynamicType();
		}

		public static bool IsReturnTypeDynamic(this MethodDefinition method)
		{
			return method.MethodReturnType.CustomAttributes.Any(a => a.AttributeType.EqualsType(typeof(DynamicAttribute)));
		}

		public static object PreprocessConstantValue(TypeReference type, object value)
		{
			if (value != null)
			{
				if (type.IsEnum() ||
					(value != null && type.IsNullable() && ((GenericInstanceType)type).GenericArguments[0].IsEnum()))
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

		#region ToAssemblyDefinition

		private static ConcurrentDictionary<Assembly, AssemblyDefinition> _cache =
			new ConcurrentDictionary<Assembly, AssemblyDefinition>();

		public static AssemblyDefinition ToAssemblyDefinition(this Assembly assembly)
		{
			return _cache.GetOrAdd(assembly, a => AssemblyDefinition.ReadAssembly(a.Location));
		}

		#endregion // ToAssemblyDefinition
	}
}

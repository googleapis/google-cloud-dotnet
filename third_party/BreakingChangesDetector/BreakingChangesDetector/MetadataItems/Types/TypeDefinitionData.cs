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

using Infragistics;
using Mono.Cecil;
using Mono.Cecil.Rocks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.MetadataItems
{
	/// <summary>
	/// Represents the metadata for an externally visible type definition.
	/// </summary>
	public sealed class TypeDefinitionData : DeclaringTypeData,
		IGenericItem,
		IParameterizedItem,
		ITypedItem
	{
		#region Static Variables

		private static Dictionary<string, HashSet<string>> _implicitNumericConversions = new Dictionary<string, HashSet<string>>() {
			{ typeof(sbyte).FullName, new HashSet<string> { typeof(short).FullName, typeof(int).FullName, typeof(long).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
			{ typeof(byte).FullName, new HashSet<string> { typeof(short).FullName, typeof(ushort).FullName, typeof(int).FullName, typeof(uint).FullName, typeof(long).FullName, typeof(ulong).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
			{ typeof(short).FullName, new HashSet<string> { typeof(int).FullName, typeof(long).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
			{ typeof(ushort).FullName, new HashSet<string> { typeof(int).FullName, typeof(uint).FullName, typeof(long).FullName, typeof(ulong).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
			{ typeof(int).FullName, new HashSet<string> { typeof(long).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
			{ typeof(uint).FullName, new HashSet<string> { typeof(long).FullName, typeof(ulong).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
			{ typeof(long).FullName, new HashSet<string> { typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
			{ typeof(ulong).FullName, new HashSet<string> { typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
			{ typeof(char).FullName, new HashSet<string> { typeof(ushort).FullName, typeof(int).FullName, typeof(uint).FullName, typeof(long).FullName, typeof(ulong).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
			{ typeof(float).FullName, new HashSet<string> { typeof(double).FullName } }
		};

		private static Dictionary<string, string> _primitiveTypeNames = new Dictionary<string, string>() {
			{ typeof(object).FullName, "object" },
			{ typeof(sbyte).FullName, "sbyte" },
			{ typeof(byte).FullName, "byte" },
			{ typeof(short).FullName,"short" },
			{ typeof(ushort).FullName,"ushort" },
			{ typeof(int).FullName,"int" },
			{ typeof(uint).FullName,"uint" },
			{ typeof(long).FullName, "long" },
			{ typeof(ulong).FullName,"ulong" },
			{ typeof(char).FullName, "char" },
			{ typeof(float).FullName, "float" },
			{ typeof(double).FullName, "double" },
			{ typeof(decimal).FullName, "decimal" },
			{ typeof(void).FullName, "void" },
		};

		#endregion // Static Variables

		#region Member Variables

		private readonly AssemblyData _assembly;
		private Dictionary<TypeDataSequence, ConstructedGenericTypeData> _constructedGenericTypes;

		#endregion // Member Variables

		#region Constructor

		internal TypeDefinitionData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeKind typeKind, AssemblyData assembly, string fullName, TypeDefinitionFlags typeDefinitionFlags, bool delegateReturnTypeIsDynamic)
			: base(name, accessibility, memberFlags, typeKind)
		{
			_assembly = assembly;
			this.DelegateReturnTypeIsDynamic = delegateReturnTypeIsDynamic;
			this.FullName = fullName;
			this.TypeDefinitionFlags = typeDefinitionFlags;
		}

		internal TypeDefinitionData(TypeDefinition type, MemberAccessibility accessibility, DeclaringTypeData declaringType, AssemblyData assembly)
			: base(type, accessibility, declaringType)
		{
			_assembly = assembly;

			var typeFlags = TypeDefinitionFlags.None;

			if (this.TypeKind == TypeKind.Class && type.CustomAttributes.Any(a => a.AttributeType.EqualsType(typeof(ExtensionAttribute))))
				typeFlags |= TypeDefinitionFlags.ExtensionsClass;

			if (this.IsSealed == false)
			{
				// A type can only be inherited if it has at least one externally visible constructor and any abstract members are also externally visible.
				var canBeIherited = type.Methods.Where(c => c.IsConstructor && c.GetAccessibility() != null).Any();
				if (this.CanBeInherited)
				{
					if (type.Methods.Where(m => m.IsSpecialName == false && m.IsConstructor == false && m.GetAccessibility() == null && m.IsAbstract).Any() ||
						type.Events.Where(e => e.AddMethod.GetAccessibility() == null && e.AddMethod.IsAbstract).Any() ||
						type.Properties.Where(p => p.GetMethod != null ? p.GetMethod.GetAccessibility() == null && p.GetMethod.IsAbstract : p.SetMethod.GetAccessibility() == null && p.SetMethod.IsAbstract).Any())
						canBeIherited = false;
				}

				if (canBeIherited)
					typeFlags |= TypeDefinitionFlags.CanBeInherited;
			}

			if (this.TypeKind == TypeKind.Enum)
			{
				var flagsAttributeData = type.CustomAttributes.Where(a => a.AttributeType.EqualsType(typeof(FlagsAttribute))).SingleOrDefault();
				if (flagsAttributeData != null)
					typeFlags |= TypeDefinitionFlags.FlagsEnum;
			}

			this.TypeDefinitionFlags = typeFlags;
			this.FullName = type.FullName;

			var renamedAttributeData = type.CustomAttributes.Where(a => a.AttributeType.EqualsType(typeof(TypeRenamedAttribute))).SingleOrDefault();
			if (renamedAttributeData != null)
				this.OldName = renamedAttributeData.ConstructorArguments[0].Value as string;

			var typeForwardedFromAttribute = type.CustomAttributes.Where(a => a.AttributeType.EqualsType(typeof(TypeForwardedFromAttribute))).SingleOrDefault();
			if (typeForwardedFromAttribute != null)
				this.AssemblyData.AddForwardedTypeFromTarget(this, typeForwardedFromAttribute.ConstructorArguments[0].Value.ToString());
		}

		#endregion // Constructor

		#region Interfaces

		bool IParameterizedItem.IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily, bool ignoreNewOptionalParameters)
		{
			return this.IsEquivalentToNewTypeHelper((TypeDefinitionData)newMember, newAssemblyFamily, ignoreNewOptionalParameters);
		}

		ParameterCollection IParameterizedItem.Parameters
		{
			get { return this.DelegateParameters; }
		}

		bool ITypedItem.IsTypeDynamic
		{
			get { return this.DelegateReturnTypeIsDynamic; }
		}

		TypeData ITypedItem.Type
		{
			get { return this.DelegateReturnType; }
		}

		#endregion // Interfaces

		#region Base Class Overrides

		#region Accept

		/// <summary>
		/// Performs the specified visitor's functionality on this instance.
		/// </summary>
		/// <param name="visitor">The visitor whose functionality should be performed on the instance.</param>
		public override void Accept(MetadataItemVisitor visitor)
		{
			visitor.VisitTypeDefinitionData(this);
		}

		#endregion // Accept

		#region AssemblyData

		/// <summary>
		/// Gets the <see cref="T:AssemblyData"/> representing the assembly in which the type is defined.
		/// </summary>
		public override AssemblyData AssemblyData
		{
			get { return _assembly; }
		}

		#endregion // AssemblyData

		#region CanOverrideMember

#if DEBUG
		/// <summary>
		/// Indicates whether the current member can override the specified member from a base type.
		/// </summary>
		/// <param name="baseMember">The member from the base type.</param>
		/// <returns>True if the current member can override the base member; False otherwise.</returns> 
#endif
		internal override bool CanOverrideMember(MemberDataBase baseMember)
		{
			Debug.Fail("Types cannot be overridden.");
			return false;
		}

		#endregion // CanOverrideMember

		#region DoesMatch

		internal override bool DoesMatch(MetadataItemBase other)
		{
			if (base.DoesMatch(other) == false)
				return false;

			var otherTyped = other as TypeDefinitionData;
			if (otherTyped == null)
				return false;

			if (this.FullName != otherTyped.FullName)
				return false;

			if (this.GenericParameters.DoesMatch(otherTyped.GenericParameters) == false)
				return false;

			if (this.NameForComparison != otherTyped.NameForComparison)
				return false;

			if (this.OldName != otherTyped.OldName)
				return false;

			if (this.TypeDefinitionFlags != otherTyped.TypeDefinitionFlags)
				return false;

			return true;
		}

		#endregion // DoesMatch

		#region GenericArity

#if DEBUG
		/// <summary>
		/// Gets the number of generic parameters/arguments for the type.
		/// </summary> 
#endif
		internal override int GenericArity
		{
			get { return this.GenericParameters.Count; }
		}

		#endregion // GenericArity

		#region GetDirectImplicitConversions

#if DEBUG
		/// <summary>
		/// Gets the types to which this type can implicitly convert. For type hierarchy conversions, only the direct base type will be enumerated.
		/// Ancestor base types will can be enumerated recursively by calling this method on the base type.
		/// </summary>
		/// <param name="onlyReferenceAndIdentityConversions">
		/// True if reference and identify conversions are they only allowed conversions; False if all implicit conversions are allowed.
		/// </param>
		/// <returns>
		/// A collection of all types to which this type can convert explicitly, except for ancestor base types which are not the direct base type.
		/// </returns> 
#endif
		internal override IEnumerable<TypeData> GetDirectImplicitConversions(bool onlyReferenceAndIdentityConversions)
		{
			if (onlyReferenceAndIdentityConversions == false)
			{
				var mscorlibData = this.AssemblyData.GetReferencedAssembly(Utilities.CommonObjectRuntimeAssemblyName);
				if (mscorlibData != null)
				{
					if (this.TypeKind == TypeKind.Enum)
					{
						yield return mscorlibData.GetTypeDefinitionData(Utilities.EnumTypeName);
					}
					else
					{
						// See if there is an implicit numeric conversion for the types.
						HashSet<string> destTypeNames;
						if (mscorlibData != null &&
							_implicitNumericConversions.TryGetValue(this.FullName, out destTypeNames))
						{
							foreach (var numericTypeName in destTypeNames)
								yield return mscorlibData.GetTypeDefinitionData(numericTypeName);
						}
					}
				}
			}

			foreach (var item in base.GetDirectImplicitConversions(onlyReferenceAndIdentityConversions))
				yield return item;
		}

		#endregion // GetDirectImplicitConversions

		#region GetDisplayName

#if DEBUG
		/// <summary>
		/// Gets the display name for the type, which can be used for generating user-readable messages about the type.
		/// </summary>
		/// <param name="fullyQualify">Indicates whether the type name should be fully qualified with declaring type and namespace names.</param>
		/// <param name="includeGenericInfo">Indicates whether generic parameters and arguments should be included in type names.</param>
		/// <param name="genericArguments">
		/// The generic arguments used to parameterize a type. For nested types, this will include the arguments for the declaring type before the arguments 
		/// for the nested type.
		/// </param>
		/// <returns>The display name of the type.</returns> 
#endif
		internal override string GetDisplayName(bool fullyQualify, bool includeGenericInfo, GenericTypeArgumentCollection genericArguments)
		{
			string primitiveTypeName;
			if (_primitiveTypeNames.TryGetValue(this.FullName, out primitiveTypeName))
				return primitiveTypeName;

			var rootName = this.Name;
			var tickIndex = rootName.LastIndexOf('`');
			if (0 <= tickIndex)
				rootName = rootName.Substring(0, tickIndex);

			if (includeGenericInfo)
			{
				var declaringTypeGenericArity = this.DeclaringType == null ? 0 : this.DeclaringType.GenericArity;

				if (genericArguments != null)
					rootName += genericArguments.GetGenericArgumentListDisplayText(includeGenericInfo, declaringTypeGenericArity, this.GenericParameters.Count - declaringTypeGenericArity);
				else if (this.GenericParameters != null) // While initializing, this.GenericParameters could be null and we don't want this throwing an exception
					rootName += this.GenericParameters.GetParameterListText(skipCount: declaringTypeGenericArity);
			}

			return this.PostProcessUnqualifiedName(rootName, fullyQualify, includeGenericInfo, genericArguments);
		}

		#endregion // GetDisplayName

		#region GetEquivalentNewType

#if DEBUG
		/// <summary>
		/// Gets the type equivalent to this one which is from a newer assembly.
		/// </summary>
		/// <param name="newAssemblyFamily">The assembly family in which new assemblies reside.</param>
#endif
		internal override TypeData GetEquivalentNewType(AssemblyFamily newAssemblyFamily)
		{
			var newAssembly = newAssemblyFamily.GetEquivalentAssembly(this.AssemblyData);
			if (newAssembly == null)
				return null;

			var newType = newAssembly.GetTypeDefinitionData(this.FullName);
			if (newType != null)
				return newType;

			var oldNamespaceName = this.GetNamespaceName();
			var newNamespaceName = newAssembly.GetNewNamespaceName(oldNamespaceName);
			if (newNamespaceName != null)
			{
				var newFullName = newNamespaceName + this.FullName.Substring(oldNamespaceName.Length);
				newType = newAssembly.GetTypeDefinitionData(newFullName);
				if (newType != null)
					return newType;
			}

			foreach (var otherAssembly in newAssemblyFamily)
			{
				if (otherAssembly == newAssembly)
					continue;

				newType = otherAssembly.GetTypeDefinitionData(this.FullName);
				if (newType != null && otherAssembly.GetForwardedTypeSources(newType).Any(s => s == newAssembly.FullName))
					return newType;
			}

			return null;
		}

		#endregion // GetEquivalentNewType

		#region GetNamespaceName

#if DEBUG
		/// <summary>
		/// Gets the name of the namespace in which the type is defined, or null if it is not defined in a namespace.
		/// </summary> 
#endif
		internal override string GetNamespaceName()
		{
			if (_primitiveTypeNames.ContainsKey(this.FullName))
				return null;

			if (this.DeclaringType != null)
				return this.DeclaringType.GetNamespaceName();

			var lastDot = this.FullName.LastIndexOf(".");
			if (0 <= lastDot)
				return this.FullName.Substring(0, lastDot);

			return string.Empty;
		}

		#endregion // GetNamespaceName

		#region IsEquivalentToNewMember

#if DEBUG
		/// <summary>
		/// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build.
		/// </summary> 
#endif
		internal override bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
		{
			var newType = newMember as TypeDefinitionData;
			if (newType == null)
				return false;

			return this.IsEquivalentToNewTypeHelper(newType, newAssemblyFamily, ignoreNewOptionalParameters: false);
		}

		#endregion // IsEquivalentToNewMember

		#region IsExtensionsClass

#if DEBUG
		/// <summary>
		/// Gets the value indicating whether the type is an extension class (a class containing extension methods).
		/// </summary> 
#endif
		internal override bool IsExtensionsClass
		{
			get { return this.TypeDefinitionFlags.HasFlag(TypeDefinitionFlags.ExtensionsClass); }
		}

		#endregion // IsExtensionsClass

		#region MetadataItemKind

		/// <summary>
		/// Gets the type of item the instance represents.
		/// </summary>
		public override MetadataItemKinds MetadataItemKind
		{
			get { return MetadataItemKinds.TypeDefinition; }
		}

		#endregion // MetadataItemKind

		#region ReplaceGenericTypeParameters

#if DEBUG
		/// <summary>
		/// Replaces all type parameters used by the member with their associated generic arguments specified in a constructed generic type.
		/// </summary>
		/// <param name="genericParameters">The generic parameters being replaced.</param>
		/// <param name="genericArguments">The generic arguments replacing the parameters.</param>
		/// <returns>A new member with the replaced type parameters or the current instance if the member does not use any of the generic parameters.</returns> 
#endif
		internal override MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
		{
			if (this.GenericParameters == genericParameters)
				return this.GetConstructedGenericTypeData(genericArguments);

			return this;
		}

		#endregion // ReplaceGenericTypeParameters

		#endregion // Base Class Overrides

		#region Methods

		#region Public Methods

		#region FromType

		/// <summary>
		/// Gets the <see cref="TypeDefinitionData"/> instance representing the specified type.
		/// </summary>
		/// <typeparam name="T">The type for which to get the <see cref="TypeDefinitionData"/>.</typeparam>
		/// <returns>The <see cref="TypeDefinitionData"/> instance.</returns>
		public new static TypeDefinitionData FromType<T>()
		{
			return TypeDefinitionData.FromType(typeof(T));
		}

		/// <summary>
		/// Gets the <see cref="TypeDefinitionData"/> instance representing the specified type.
		/// </summary>
		/// <returns>The <see cref="TypeDefinitionData"/> instance.</returns>
		public new static TypeDefinitionData FromType(Type t)
		{
			var typeDefinition = TypeData.FromType(t) as TypeDefinitionData;
			if (typeDefinition == null)
				throw new ArgumentException("The specified type is not an externally visible type definition.", "t");

			return typeDefinition;
		}

		/// <summary>
		/// Gets the <see cref="TypeDefinitionData"/> instance representing the specified type.
		/// </summary>
		/// <returns>The <see cref="TypeDefinitionData"/> instance.</returns>
		public new static TypeDefinitionData FromType(TypeReference t)
		{
			return (TypeDefinitionData)TypeData.FromType(t);
		}

		#endregion // FromType

		#region GetNestedType

		/// <summary>
		/// Gets the single nested type with the specified name or null if no such nested type exists. If multiple nested types exist with the specified name, 
		/// an exception will be thrown.
		/// </summary>
		/// <param name="name">The name of the nested type to get.</param>
		/// <returns>The single nested type with the specified name, or null if no such nested type exists.</returns>
		public TypeDefinitionData GetNestedType(string name)
		{
			return this.GetMembers(name).OfType<TypeDefinitionData>().SingleOrDefault();
		}

		#endregion // GetNestedType

		#endregion // Public Methods

		#region Internal Methods

		#region FinalizeDefinition

#if DEBUG
		/// <summary>
		/// Populates the type with additional information which can't be loaded when the type is created (due to potential circularities in item dependencies).
		/// </summary>
		/// <param name="underlyingType">The underlying type this instance represents.</param>
#endif
		internal void FinalizeDefinition(TypeDefinition underlyingType)
		{
			if (underlyingType.IsEnum)
				this.BaseType = (DeclaringTypeData)TypeData.FromType(underlyingType.GetEnumUnderlyingType());
			else if (underlyingType.BaseType != null)
				this.BaseType = (DeclaringTypeData)TypeData.FromType(underlyingType.BaseType);

			this.ImplementedInterfaces = new ImplementedInterfacesCollection(
				underlyingType.Interfaces.Select(i => (DeclaringTypeData)TypeData.FromType(i)).Where(i => i != null)
				);

			if (this.TypeKind == TypeKind.Delegate)
			{
				var invokeMethod = underlyingType.Methods.Single(m => m.Name == "Invoke");
				this.DelegateParameters = new ParameterCollection(invokeMethod.Parameters, this);
				this.DelegateReturnType = TypeData.FromType(invokeMethod.ReturnType);
				this.DelegateReturnTypeIsDynamic = invokeMethod.IsReturnTypeDynamic();
			}

			if (underlyingType.HasGenericParameters)
			{
				this.GenericParameters = Utilities.GetGenericParameters(underlyingType.GenericParameters, this);
				Debug.Assert(
					_constructedGenericTypes == null || _constructedGenericTypes.Values.All(c => c.GenericArguments.Count == this.GenericParameters.Count),
					"The type arity does not match.");
			}
			else
			{
				this.GenericParameters = GenericTypeParameterData.EmptyList;
				Debug.Assert(_constructedGenericTypes == null, "There should be no constructed generic types.");
			}

			this.NameForComparison = this.GetDisplayName(fullyQualify: true, includeGenericInfo: false);

			Debug.Assert(_constructedGenericTypes == null || _constructedGenericTypes.Keys.All(t => t.Count == this.GenericParameters.Count), "A constructed generic has the wrong type arity.");
		}

		#endregion // FinalizeDefinition

		#region GetConstructedGenericTypeData

#if DEBUG
		/// <summary>
		/// Gets a <see cref="ConstructedGenericTypeData"/> instance with the current type as its generic type definition and the specified sequence of type as its 
		/// generic type arguments.
		/// </summary>
#endif
		internal ConstructedGenericTypeData GetConstructedGenericTypeData(IEnumerable<TypeData> typeArguments)
		{
			return this.GetConstructedGenericTypeData(new TypeDataSequence(typeArguments));
		}

#if DEBUG
		/// <summary>
		/// Gets a <see cref="ConstructedGenericTypeData"/> instance with the current type as its generic type definition and the specified sequence of type as its 
		/// generic type arguments.
		/// </summary>
#endif
		internal ConstructedGenericTypeData GetConstructedGenericTypeData(TypeDataSequence typeArguments)
		{
			Debug.Assert(this.GenericParameters == null || this.GenericParameters.Count == typeArguments.Count, "The type arity does not match.");

			if (_constructedGenericTypes == null)
				_constructedGenericTypes = new Dictionary<TypeDataSequence, ConstructedGenericTypeData>();

			ConstructedGenericTypeData constructedGenericType;
			if (_constructedGenericTypes.TryGetValue(typeArguments, out constructedGenericType) == false)
			{
				constructedGenericType = new ConstructedGenericTypeData(this, typeArguments);
				Debug.Assert(_constructedGenericTypes.ContainsKey(typeArguments), "The constructed generic type did not register itself.");
			}

			return constructedGenericType;
		}

		#endregion // GetConstructedGenericTypeData

		#region IsType

#if DEBUG
		/// <summary>
		/// Indicates whether the specified type is represented by the current <see cref="TypeDefinitionData"/> instance.
		/// </summary> 
#endif
		internal bool IsType(Type type)
		{
			return
				this.FullName == type.FullName &&
				this.AssemblyData.Name == type.Assembly.GetName().Name;
		}

		#endregion // IsType

		#region PopulateMembers

		internal void PopulateMembers(TypeDefinition underlyingType)
		{
			foreach (var member in underlyingType.GetMembers())
				this.AddMember(MemberDataBase.MemberDataFromReflection(member, this));
		}

		#endregion // PopulateMembers

		#region RegisterConstructedGenericTypeData

#if DEBUG
		/// <summary>
		/// Registers a <see cref="ConstructedGenericTypeData"/> instance with the current type as its generic type definition so it can be cached and re-used when trying 
		/// to get a constructed generic type with the same type arguments.
		/// </summary>
#endif
		internal void RegisterConstructedGenericTypeData(ConstructedGenericTypeData constructedGenericType)
		{
			Debug.Assert(this.GenericParameters == null || this.GenericParameters.Count == constructedGenericType.GenericArguments.Count, "The type arity does not match.");

			if (_constructedGenericTypes == null)
				_constructedGenericTypes = new Dictionary<TypeDataSequence, ConstructedGenericTypeData>();

			var key = new TypeDataSequence(constructedGenericType.GenericArguments);
			Debug.Assert(_constructedGenericTypes.ContainsKey(key) == false, "We should not register the same constructed generic twice.");
			_constructedGenericTypes[key] = constructedGenericType;
		}

		#endregion // RegisterConstructedGenericTypeData

		#endregion // Internal Methods

		#region Private Methods

		#region IsEquivalentToNewTypeHelper

#if DEBUG
		/// <summary>
		/// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build.
		/// </summary>
		/// <param name="newType">The new member to compare.</param>
		/// <param name="newAssemblyFamily">The assembly family in which new assemblies reside.</param>
		/// <param name="ignoreNewOptionalParameters">
		/// Indicates whether to ignore any new parameters at the end of the collection which are optional when comparing.
		/// </param>
#endif
		private bool IsEquivalentToNewTypeHelper(TypeDefinitionData newType, AssemblyFamily newAssemblyFamily, bool ignoreNewOptionalParameters)
		{
			if (base.IsEquivalentToNewMember(newType, newAssemblyFamily) == false)
				return false;

			var isEquivalent = this.AssemblyData.IsEquivalentToNewAssembly(newType.AssemblyData);
			if (isEquivalent == false)
			{
				foreach (var source in newType.AssemblyData.GetForwardedTypeSources(newType))
				{
					if (this.AssemblyData.IsEquivalentToNewAssembly(newAssemblyFamily.GetAssembly(source)))
					{
						isEquivalent = true;
						break;
					}
				}

				if (isEquivalent == false)
					return false;
			}

			return
				this.GenericParameters.Count == newType.GenericParameters.Count &&
				this.TypeKind == newType.TypeKind &&
				this.NameForComparison == newType.OldNameResolved;
		}

		#endregion // IsEquivalentToNewTypeHelper

		#endregion // Private Methods

		#endregion // Methods

		#region Properties

		#region Public Properties

		/// <summary>
		/// Gets the value indicating whether the class can be inherited by a type external to its assembly.
		/// </summary>
		public bool CanBeInherited { get { return this.TypeDefinitionFlags.HasFlag(TypeDefinitionFlags.CanBeInherited); } }

		/// <summary>
		/// Gets the fully qualified name of the type.
		/// </summary>
		public string FullName { get; private set; }

		/// <summary>
		/// Gets the collection of generic parameters for the type.
		/// </summary>
		public GenericTypeParameterCollection GenericParameters { get; internal set; }

		/// <summary>
		/// Gets the value indicating whether the type is an enum definition with the Flags attribute applied.
		/// </summary>
		public bool IsFlagsEnum { get { return this.TypeDefinitionFlags.HasFlag(TypeDefinitionFlags.FlagsEnum); } }

		#endregion // Public Properties

		#region Internal Properties

		internal bool HasPublicConstructors { get { return this.GetMembers(".ctor").Any(c => c.Accessibility == MemberAccessibility.Public); } }

		internal string NameForComparison { get; private set; }

		internal string OldName { get; set; } // TODO_Serialize: Test and round-trip

		internal string OldNameResolved { get { return this.OldName ?? this.NameForComparison; } }

		internal TypeDefinitionFlags TypeDefinitionFlags { get; private set; }

		#endregion // Internal Properties

		#endregion // Properties
	}
}

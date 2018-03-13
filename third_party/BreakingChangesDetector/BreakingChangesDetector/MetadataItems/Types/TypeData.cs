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
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.MetadataItems
{
	/// <summary>
	/// Abstract base class representing metadata for an externally visible type.
	/// </summary>
	public abstract class TypeData : MemberDataBase
	{
		#region Member Variables

		private Dictionary<byte, ArrayTypeData> _arrayTypes;
		private PointerTypeData _pointerType;

		#endregion // Member Variables

		#region Constructors

		internal TypeData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeKind typeKind)
			: base(name, accessibility, memberFlags)
		{
			this.TypeKind = typeKind;
		}

		internal TypeData(TypeReference type, MemberAccessibility accessibility, DeclaringTypeData declaringType)
			: base(type, accessibility, Utilities.GetMemberFlags(type), declaringType)
		{
			this.TypeKind = Utilities.GetTypeKind(type);
		}

		#endregion // Constructors

		#region Base Class Overrides

		#region DisplayName

		/// <summary>
		/// Gets the name to use for this item in messages.
		/// </summary>
		public sealed override string DisplayName
		{
			get { return this.GetDisplayName(); }
		}

		#endregion // DisplayName

		#region DoesMatch

		internal override bool DoesMatch(MetadataItemBase other)
		{
			if (base.DoesMatch(other) == false)
				return false;

			var otherTyped = other as TypeData;
			if (otherTyped == null)
				return false;

			if (this.TypeKind != otherTyped.TypeKind)
				return false;

			return true;
		}

		#endregion // DoesMatch

		#region IsNameUsedToVerifyEquivalence

		/// <summary>
		/// Gets the value indicating whether the <see cref="MemberDataBase.Name"/> of the member is primarily used to determine whether it is equivalent to another member.
		/// </summary>
		public sealed override bool IsNameUsedToVerifyEquivalence
		{
			get
			{
				// For generic parameters, the position is used to verify equivalence (the name doesn't matter as long as it is used consistently 
				// within the class). For other types, the full name is used to verify equivalence, not the name
				return false;
			}
		}

		#endregion // IsNameUsedToVerifyEquivalence

		#endregion // Base Class Overrides

		#region Methods

		#region Public Methods

		#region FromType

		/// <summary>
		/// Gets the derived <see cref="TypeData"/> instance representing the specified type.
		/// </summary>
		/// <typeparam name="T">The type for which to get the <see cref="TypeData"/>.</typeparam>
		/// <returns>The derived <see cref="TypeData"/> instance.</returns>
		public static TypeData FromType<T>()
		{
			return TypeData.FromType(typeof(T));
		}

		/// <summary>
		/// Gets the derived <see cref="TypeData"/> instance representing the specified type.
		/// </summary>
		/// <param name="t">The type for which to get the <see cref="TypeData"/>.</param>
		/// <returns>The derived <see cref="TypeData"/> instance.</returns>
		public static TypeData FromType(Type t)
		{
			return TypeData.FromType(
				t.Assembly.ToAssemblyDefinition().MainModule.GetType(t.FullName, runtimeName: true));
		}

		/// <summary>
		/// Gets the derived <see cref="TypeData"/> instance representing the specified type.
		/// </summary>
		/// <param name="t">The type for which to get the <see cref="TypeData"/>.</param>
		/// <returns>The derived <see cref="TypeData"/> instance.</returns>
		public static TypeData FromType(TypeReference t)
		{
			if (t.GetType() == typeof(TypeReference))
				t = t.Resolve();

			// TODO_Public: throw an exception if the type is not externally visible
			return AssemblyData.FromAssembly(t.GetDeclaringAssembly()).GetTypeData(t);
		}

		#endregion // FromType

		#region GetDisplayName

		/// <summary>
		/// Gets the display name for the type, which can be used for generating user-readable messages about the type.
		/// </summary>
		/// <param name="fullyQualify">Indicates whether the type name should be fully qualified with declaring type and namespace names.</param>
		/// <param name="includeGenericInfo">Indicates whether generic parameters and arguments should be included in type names.</param>
		/// <returns>The display name of the type.</returns>
		public abstract string GetDisplayName(bool fullyQualify = true, bool includeGenericInfo = true);

		#endregion // GetDisplayName

		#region IsEquivalentToNew

#if DEBUG
		/// <summary>
		/// Indicates whether a new type is logically the same as the current type, just from a newer build.
		/// </summary> 
#endif
		public bool IsEquivalentToNew(TypeData newType, AssemblyFamily newAssemblyFamily)
		{
			return this.IsEquivalentToNewMember(newType, newAssemblyFamily);
		}

		#endregion // IsEquivalentToNew

		#region IsEquivalentToOld

#if DEBUG
		/// <summary>
		/// Indicates whether an old type is logically the same as the current type, just from an older build.
		/// </summary> 
#endif
		public bool IsEquivalentToOld(TypeData oldType, AssemblyFamily newAssemblyFamily)
		{
			return oldType.IsEquivalentToNewMember(this, newAssemblyFamily);
		}

		#endregion // IsEquivalentToOld

		#endregion // Public Methods

		#region Internal Methods

		#region GetArrayType

		internal ArrayTypeData GetArrayType(byte rank)
		{
			if (_arrayTypes == null)
				_arrayTypes = new Dictionary<byte, ArrayTypeData>();

			ArrayTypeData arrayTypeData;
			if (_arrayTypes.TryGetValue(rank, out arrayTypeData) == false)
			{
				Debug.Assert(_arrayTypes.ContainsKey(rank) == false, "The array type was cached twice");
				_arrayTypes[rank] = arrayTypeData = new ArrayTypeData(
					string.Format("{0}[{1}]", this.Name, new string(',', rank - 1)),
					MemberAccessibility.Public,
					MemberFlags.None,
					TypeKind.Class,
					this,
					rank);
			}

			return arrayTypeData;
		}

		#endregion // GetArrayType

		#region GetDefiningAssemblyFamily

#if DEBUG
		/// <summary>
		/// Gets the <see cref="AssemblyFamily"/> containing the type. If the type is nullable and type with element, 
		/// such as T?, T[], or T*, this returns the family containing the type T.
		/// </summary> 
#endif
		internal virtual AssemblyFamily GetDefiningAssemblyFamily()
		{
			return new AssemblyFamily { this.AssemblyData };
		}

		#endregion // GetDefiningAssemblyFamily

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
		internal abstract IEnumerable<TypeData> GetDirectImplicitConversions(bool onlyReferenceAndIdentityConversions);

		#endregion // GetDirectImplicitConversions

		#region GetEquivalentNewType

#if DEBUG
		/// <summary>
		/// Gets the type equivalent to this one which is from a newer assembly.
		/// </summary>
		/// <param name="newAssemblyFamily">The assembly family in which new assemblies reside.</param>
#endif
		internal abstract TypeData GetEquivalentNewType(AssemblyFamily newAssemblyFamily);

		#endregion // GetEquivalentNewType

		#region GetNamespaceName

#if DEBUG
		/// <summary>
		/// Gets the name of the namespace in which the type is defined, or null if it is not defined in a namespace.
		/// </summary> 
#endif
		internal virtual string GetNamespaceName()
		{
			return null;
		}

		#endregion // GetNamespaceName

		#region GetPointerType

		internal PointerTypeData GetPointerType()
		{
			if (_pointerType == null)
				_pointerType = new PointerTypeData(this.Name + "*", this.Accessibility, MemberFlags.None, TypeKind.Class, this);

			return _pointerType;
		}

		#endregion // GetPointerType

		#region IsArray

		internal virtual bool IsArray(out int rank, out TypeData elementType)
		{
			rank = 0;
			elementType = null;
			return false;
		}

		#endregion // IsArray

		#region IsAssignableFrom

#if DEBUG
		/// <summary>
		/// Indicates whether a variable of the current type is assignable from the specified source type.
		/// </summary>
		/// <param name="sourceType">The source type from which to test assignability to this type.</param>
		/// <param name="context">Information about the context of the IsAssignableFrom invocation.</param>
		/// <returns>True if a value of the source type is assignable to a variable of the current type.</returns> 
#endif
		internal virtual bool IsAssignableFrom(TypeData sourceType, IsAssignableFromContext context)
		{
			if (this.IsEquivalentTo(sourceType, context.NewAssemblyFamily, context.IsSourceTypeOld))
				return true;

			foreach (var implicitConversionType in sourceType.GetDirectImplicitConversions(context.OnlyReferenceAndIdentityConversions))
			{
				if (this.IsAssignableFrom(implicitConversionType, context))
					return true;
			}

			return false;
		}

		#endregion // IsAssignableFrom

		#region IsAssignableFromNew

#if DEBUG
		/// <summary>
		/// Indicates whether a variable of the current type is assignable from the specified source type, which is from a newer build, if they
		/// had been from the same assembly version.
		/// </summary>
		/// <param name="newSourceType">The newer source type from which to test assignability to this type.</param>
		/// <param name="newAssemblyFamily">
		/// The newer family of assemblies from which to obtain equivalents of older types, or null to use a default family containing only the new type's assembly.
		/// </param>
#endif
		internal bool IsAssignableFromNew(TypeData newSourceType, AssemblyFamily newAssemblyFamily = null)
		{
			newAssemblyFamily = newAssemblyFamily ?? newSourceType.GetDefiningAssemblyFamily();
			return this.IsAssignableFrom(newSourceType, new IsAssignableFromContext(newAssemblyFamily, isSourceTypeOld: false, onlyReferenceAndIdentityConversions: false));
		}

		#endregion // IsAssignableFromNew

		#region IsAssignableFromOld

#if DEBUG
		/// <summary>
		/// Indicates whether a variable of the current type is assignable from the specified source type, which is from an older build, if they
		/// had been from the same assembly version.
		/// </summary>
		/// <param name="oldSourceType">The older source type from which to test assignability to this type.</param>
		/// <param name="newAssemblyFamily">
		/// The newer family of assemblies from which to obtain equivalents of older types, or null to use a default family containing only the new type's assembly.
		/// </param>
#endif
		internal bool IsAssignableFromOld(TypeData oldSourceType, AssemblyFamily newAssemblyFamily = null)
		{
			newAssemblyFamily = newAssemblyFamily ?? this.GetDefiningAssemblyFamily();
			return this.IsAssignableFrom(oldSourceType, new IsAssignableFromContext(newAssemblyFamily, isSourceTypeOld: true, onlyReferenceAndIdentityConversions: false));
		}

		#endregion // IsAssignableFromOld

		#region IsEquivalentTo

#if DEBUG
		/// <summary>
		/// Indicates whether the specified type is equivalent to the current type (but from another version).
		/// </summary>
		/// <param name="otherType">The type to compare to the current type.</param>
		/// <param name="newAssemblyFamily">The assembly family in which new assemblies reside.</param>
		/// <param name="isOtherTypeOld">Indicates whether the type on which this method is called is from the older version of assemblies.</param>
		/// <returns>True if the types are equivalent but from different assembly versions; False otherwise.</returns> 
#endif
		internal bool IsEquivalentTo(TypeData otherType, AssemblyFamily newAssemblyFamily, bool isOtherTypeOld)
		{
			if (isOtherTypeOld)
				return otherType.IsEquivalentToNewMember(this, newAssemblyFamily);
			else
				return this.IsEquivalentToNewMember(otherType, newAssemblyFamily);
		}

		#endregion // IsEquivalentTo

		#region IsNullable

#if DEBUG
		/// <summary>
		/// Indicates whether the type is a nullable value type.
		/// </summary>
		/// <param name="underlyingType">[Out] Will be set to the underlying value type if the tpye is nullable; will be null otherwise.</param>
		/// <returns>True if the type is nullable; False otherwise.</returns> 
#endif
		internal virtual bool IsNullable(out TypeData underlyingType)
		{
			underlyingType = null;
			return false;
		}

		#endregion // IsNullable

		#region IsVarianceConvertibleTo

#if DEBUG
		/// <summary>
		/// Indicates whether the type can convert to the specified target type using type parameter variance.
		/// </summary>
		/// <param name="target">The target type to which this type might convert.</param>
		/// <param name="context">Information about the context of the IsAssignableFrom invocation.</param>
		/// <returns>True is the type is variance convertible to the target; False otherwise.</returns> 
#endif
		internal virtual bool IsVarianceConvertibleTo(ConstructedGenericTypeData target, IsAssignableFromContext context)
		{
			return false;
		}

		#endregion // IsVarianceConvertibleTo

		#endregion // Internal Methods

		#endregion // Methods

		#region Properties

		#region Public Properties

		/// <summary>
		/// Gets the kind of type this instance represents.
		/// </summary>
		public TypeKind TypeKind { get; private set; }

		#endregion // Public Properties

		#region Internal Properties

		/// <summary>
		/// Gets the value indicating whether the type represents a value type.
		/// </summary>
		internal bool IsValueType { get { return this.TypeKind == TypeKind.Enum || this.TypeKind == TypeKind.Struct; } }

		#endregion // Internal Properties

		#endregion // Properties
	}
}

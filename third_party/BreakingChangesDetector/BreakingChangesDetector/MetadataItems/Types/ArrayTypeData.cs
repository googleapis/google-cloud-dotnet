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
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.MetadataItems
{
	/// <summary>
	/// Represents the metadata for an externally visible array type.
	/// </summary>
	public sealed class ArrayTypeData : TypeWithElementData
	{
		#region Constructor

		internal ArrayTypeData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeKind typeKind, TypeData elementType, byte arrayRank)
			: base(name, accessibility, memberFlags, typeKind, elementType)
		{
			this.ArrayRank = arrayRank;
		}

		#endregion // Constructor

		#region Base Class Overrides

		#region DoesMatch

		internal override bool DoesMatch(MetadataItemBase other)
		{
			if (base.DoesMatch(other) == false)
				return false;

			var otherTyped = other as ArrayTypeData;
			if (otherTyped == null)
				return false;

			if (this.ArrayRank != otherTyped.ArrayRank)
				return false;

			return true;
		}

		#endregion // DoesMatch

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
			var mscorlibData = this.AssemblyData.GetReferencedAssembly(Utilities.CommonObjectRuntimeAssemblyName);
			if (mscorlibData == null)
				yield break;

			yield return mscorlibData.GetTypeDefinitionData(Utilities.ArrayTypeName);
			yield return mscorlibData.GetTypeDefinitionData(Utilities.ICloneableTypeName);
			yield return mscorlibData.GetTypeDefinitionData(Utilities.IListTypeName);
			yield return mscorlibData.GetTypeDefinitionData(Utilities.ICollectionTypeName);
			yield return mscorlibData.GetTypeDefinitionData(Utilities.IEnumerableTypeName);
			yield return mscorlibData.GetTypeDefinitionData(Utilities.IStructuralComparableTypeName);
			yield return mscorlibData.GetTypeDefinitionData(Utilities.IStructuralEquatableTypeName);

			if (this.ArrayRank == 1)
			{
				var genericArguments = new TypeDataSequence(this.ElementType);
				yield return mscorlibData.GetTypeDefinitionData(Utilities.IListGenericTypeName).GetConstructedGenericTypeData(genericArguments);
				yield return mscorlibData.GetTypeDefinitionData(Utilities.ICollectionGenericTypeName).GetConstructedGenericTypeData(genericArguments);
				yield return mscorlibData.GetTypeDefinitionData(Utilities.IEnumerableGenericTypeName).GetConstructedGenericTypeData(genericArguments);
				yield return mscorlibData.GetTypeDefinitionData(Utilities.IReadOnlyCollectionGenericTypeName).GetConstructedGenericTypeData(genericArguments);
				yield return mscorlibData.GetTypeDefinitionData(Utilities.IReadOnlyListGenericTypeName).GetConstructedGenericTypeData(genericArguments);
			}
		}

		#endregion // GetDirectImplicitConversions

		#region GetDisplayName

		/// <summary>
		/// Gets the display name for the type, which can be used for generating user-readable messages about the type.
		/// </summary>
		/// <param name="fullyQualify">Indicates whether the type name should be fully qualified with declaring type and namespace names.</param>
		/// <param name="includeGenericInfo">Indicates whether generic parameters and arguments should be included in type names.</param>
		/// <returns>The display name of the type.</returns>
		public override string GetDisplayName(bool fullyQualify = true, bool includeGenericInfo = true)
		{
			return this.ElementType.GetDisplayName(fullyQualify, includeGenericInfo) + '[' + new string(',', this.ArrayRank - 1) + ']';
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
			var newElementType = this.ElementType.GetEquivalentNewType(newAssemblyFamily);
			if (newElementType == null)
				return null;

			return
				newElementType.GetArrayType(this.ArrayRank) ??
				new ArrayTypeData(this.Name, this.Accessibility, this.MemberFlags, this.TypeKind, newElementType, this.ArrayRank);
		}

		#endregion // GetEquivalentNewType

		#region IsArrayHelper

		internal override bool IsArray(out int rank, out TypeData elementType)
		{
			rank = this.ArrayRank;
			elementType = this.ElementType;
			return true;
		}

		#endregion // IsArrayHelper

		#region IsAssignableFrom

#if DEBUG
		/// <summary>
		/// Gets the value indicating whether a variable of the current type is assignable from the specified source type.
		/// </summary>
		/// <param name="sourceType">The source type from which to test assignability to this type.</param>
		/// <param name="context">Information about the context of the IsAssignableFrom invocation.</param>
		/// <returns>True if a value of the source type is assignable to a variable of the current type.</returns> 
#endif
		internal override bool IsAssignableFrom(TypeData sourceType, IsAssignableFromContext context)
		{
			if (base.IsAssignableFrom(sourceType, context))
				return true;

			// From C# specification: (The implicit reference conversions are) 
			// - From an array-type S with an element type Se to an array-type T with an element type Te, provided all of the following are true:
			//   - S and T differ only in element type. In other words, S and T have the same number of dimensions.
			//   - Both Se and Te are reference-types.
			//   - An implicit reference conversion exists from Se to Te.
			if (this.ElementType.IsValueType == false)
			{
				int sourceRank;
				TypeData sourceElementType;
				if (sourceType.IsArray(out sourceRank, out sourceElementType) &&
					sourceElementType.IsValueType == false &&
					this.ArrayRank == sourceRank)
				{
					return this.ElementType.IsAssignableFrom(sourceElementType, new IsAssignableFromContext(context.NewAssemblyFamily, context.IsSourceTypeOld, onlyReferenceAndIdentityConversions: true));
				}
			}

			return false;
		}

		#endregion // IsAssignableFrom

		#region IsEquivalentToNewMember

#if DEBUG
		/// <summary>
		/// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build.
		/// </summary> 
#endif
		internal override bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
		{
			if (base.IsEquivalentToNewMember(newMember, newAssemblyFamily) == false)
				return false;

			var other = newMember as ArrayTypeData;
			if (other == null)
				return false;

			return this.ArrayRank == other.ArrayRank;
		}

		#endregion // IsEquivalentToNewMember

		#region MetadataItemKind

		/// <summary>
		/// Gets the type of item the instance represents.
		/// </summary>
		public override MetadataItemKinds MetadataItemKind
		{
			get { return MetadataItemKinds.ArrayType; }
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
			var replacedElementType = (TypeData)this.ElementType.ReplaceGenericTypeParameters(genericParameters, genericArguments);
			if (replacedElementType == this.ElementType)
				return this;

			return
				replacedElementType.GetArrayType(this.ArrayRank) ??
				new ArrayTypeData(
					this.Name,
					this.Accessibility,
					this.MemberFlags,
					this.TypeKind,
					replacedElementType,
					this.ArrayRank);
		}

		#endregion // ReplaceGenericTypeParameters

		#endregion // Base Class Overrides

		#region Properties

		/// <summary>
		/// Gets the number of dimensions for array types if <see cref="IsArray"/> is true; 0 otherwise.
		/// </summary>
		public byte ArrayRank { get; private set; } // TODO_Serialize: Round trip and unit test

		#endregion // Properties
	}
}

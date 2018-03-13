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
	/// Represents the metadata for an externally visible pointer type.
	/// </summary>
	public sealed class PointerTypeData : TypeWithElementData
	{
		internal PointerTypeData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeKind typeKind, TypeData elementType)
			: base(name, accessibility, memberFlags, typeKind, elementType) { }

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
			yield break;
		}

		/// <summary>
		/// Gets the display name for the type, which can be used for generating user-readable messages about the type.
		/// </summary>
		/// <param name="fullyQualify">Indicates whether the type name should be fully qualified with declaring type and namespace names.</param>
		/// <param name="includeGenericInfo">Indicates whether generic parameters and arguments should be included in type names.</param>
		/// <returns>The display name of the type.</returns>
		public override string GetDisplayName(bool fullyQualify = true, bool includeGenericInfo = true)
		{
			return this.ElementType.GetDisplayName(fullyQualify, includeGenericInfo) + '*';
		}

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

			return newElementType.GetPointerType();
		}

		#region MetadataItemKind

		/// <summary>
		/// Gets the type of item the instance represents.
		/// </summary>
		public override MetadataItemKinds MetadataItemKind
		{
			get { return MetadataItemKinds.PointerType; }
		}

		#endregion // MetadataItemKind

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

			return replacedElementType.GetPointerType();
		}
	}
}

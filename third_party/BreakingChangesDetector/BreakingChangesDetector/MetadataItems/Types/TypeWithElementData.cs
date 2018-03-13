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
	/// Abstract base class representing the metadata for an externally visible type with an element type, which is either an array or pointer type.
	/// </summary>
	public abstract class TypeWithElementData : TypeData
	{
		internal TypeWithElementData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeKind typeKind, TypeData elementType)
			: base(name, accessibility, memberFlags, typeKind)
		{
			this.ElementType = elementType;
		}

		/// <summary>
		/// Performs the specified visitor's functionality on this instance.
		/// </summary>
		/// <param name="visitor">The visitor whose functionality should be performed on the instance.</param>
		public override void Accept(MetadataItemVisitor visitor)
		{
			visitor.VisitTypeWithElementData(this);
		}

		/// <summary>
		/// Gets the <see cref="T:AssemblyData"/> representing the assembly in which the type is defined.
		/// </summary>
		public override AssemblyData AssemblyData
		{
			get { return this.ElementType.AssemblyData; }
		}

		internal override bool DoesMatch(MetadataItemBase other)
		{
			if (base.DoesMatch(other) == false)
				return false;

			var otherTyped = other as TypeWithElementData;
			if (otherTyped == null)
				return false;

			if (this.ElementType.DisplayName != otherTyped.ElementType.DisplayName)
				return false;

			return true;
		}

#if DEBUG
		/// <summary>
		/// Gets the <see cref="AssemblyFamily"/> containing the type. If the type is nullable and type with element, 
		/// such as T?, T[], or T*, this returns the family containing the type T.
		/// </summary> 
#endif
		internal override AssemblyFamily GetDefiningAssemblyFamily()
		{
			return this.ElementType.GetDefiningAssemblyFamily();
		}

#if DEBUG
		/// <summary>
		/// Gets the name of the namespace in which the type is defined, or null if it is not defined in a namespace.
		/// </summary> 
#endif
		internal override string GetNamespaceName()
		{
			return this.ElementType.GetNamespaceName();
		}

#if DEBUG
		/// <summary>
		/// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build.
		/// </summary> 
#endif
		internal override bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
		{
			if (base.IsEquivalentToNewMember(newMember, newAssemblyFamily) == false)
				return false;

			var other = newMember as TypeWithElementData;
			return
				other != null &&
				this.ElementType.IsEquivalentToNew(other.ElementType, newAssemblyFamily);
		}

		/// <summary>
		/// Gets the underlying element type.
		/// </summary>
		public TypeData ElementType { get; private set; } // TODO_Serialize: Round trip and unit test
	}
}

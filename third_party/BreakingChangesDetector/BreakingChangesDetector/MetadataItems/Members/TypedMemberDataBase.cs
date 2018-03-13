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
	/// Abstract base class representing metadata for externally visible members with an type or return type.
	/// </summary>
	public abstract class TypedMemberDataBase : MemberDataBase,
		ITypedItem
	{
		#region Constructor

		internal TypedMemberDataBase(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeData type, bool isTypeDynamic)
			: base(name, accessibility, memberFlags)
		{
			this.Type = type;
			this.IsTypeDynamic = isTypeDynamic;
		}

		internal TypedMemberDataBase(MemberReference member, MemberAccessibility accessibility, TypeReference type, bool isTypeDynamic, MemberFlags flags, DeclaringTypeData declaringType)
			: base(member, accessibility, flags, declaringType)
		{
			this.Type = TypeData.FromType(type);
			this.IsTypeDynamic = isTypeDynamic;
			Debug.Assert(this.Type != null, "Unable to get the TypeData.");
		}

		#endregion // Constructor

		#region Base Class Overrides

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
			if (base.CanOverrideMember(baseMember) == false)
				return false;

			return this.Type == ((TypedMemberDataBase)baseMember).Type;
		}

		#endregion // CanOverrideMember

		#region DoesMatch

		internal override bool DoesMatch(MetadataItemBase other)
		{
			if (base.DoesMatch(other) == false)
				return false;

			var otherTyped = other as TypedMemberDataBase;
			if (otherTyped == null)
				return false;

			if (this.IsTypeDynamic != otherTyped.IsTypeDynamic)
				return false;

			if (this.Type.DisplayName != otherTyped.Type.DisplayName)
				return false;

			return true;
		}

		#endregion // DoesMatch

		#endregion // Base Class Overrides

		#region Properties

		/// <summary>
		/// Gets the value indicating whether the type is dynamic.
		/// </summary>
		public bool IsTypeDynamic { get; private set; } // TODO_Serialize: round trip and test

		/// <summary>
		/// Gets the type (or return type) of the member.
		/// </summary>
		public TypeData Type { get; private set; }

		#endregion // Properties
	}
}

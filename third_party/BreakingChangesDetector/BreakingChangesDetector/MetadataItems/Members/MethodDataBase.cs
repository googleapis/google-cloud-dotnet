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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.MetadataItems
{
	/// <summary>
	/// Abstract base class representing metadata for externally visible methods.
	/// </summary>
	public abstract class MethodDataBase : TypedMemberDataBase, 
		IParameterizedItem
	{
		#region Constructor

		internal MethodDataBase(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeData type, bool isTypeDynamic, ParameterCollection parameters)
			: base(name, accessibility, memberFlags, type, isTypeDynamic)
		{
			this.Parameters = parameters;
		}

		internal MethodDataBase(MethodDefinition methodDefinition, MemberAccessibility accessibility, DeclaringTypeData declaringType)
			: base(methodDefinition, accessibility, methodDefinition.ReturnType, methodDefinition.IsReturnTypeDynamic(), Utilities.GetMemberFlags(methodDefinition), declaringType)
		{
			this.Parameters = new ParameterCollection(methodDefinition.Parameters, this);
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

			var otherMethodBase = (MethodDataBase)baseMember;
			return this.Parameters.IsEquivalentTo(otherMethodBase.Parameters);
		}

		#endregion // CanOverrideMember

		#region DisplayName

		/// <summary>
		/// Gets the name to use for this item in messages.
		/// </summary>
		public override string DisplayName
		{
			get { return this.Name + this.Parameters.GetParameterListDisplayText(); }
		}

		#endregion // DisplayName

		#region DoesMatch

		internal override bool DoesMatch(MetadataItemBase other)
		{
			if (base.DoesMatch(other) == false)
				return false;

			var otherTyped = other as MethodDataBase;
			if (otherTyped == null)
				return false;

			if (this.Parameters.DoesMatch(otherTyped.Parameters) == false)
				return false;

			return true;
		}

		#endregion // DoesMatch

		#region IsEquivalentToNewMember

#if DEBUG
		/// <summary>
		/// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build.
		/// </summary> 
#endif
		internal override bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
		{
			return this.IsEquivalentToNewMember((MethodDataBase)newMember, newAssemblyFamily, ignoreNewOptionalParameters: false);
		}

		#endregion // IsEquivalentToNewMember

		#endregion // Base Class Overrides

		#region Interfaces

		bool IParameterizedItem.IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily, bool ignoreNewOptionalParameters)
		{
			return this.IsEquivalentToNewMember((MethodDataBase)newMember, newAssemblyFamily, ignoreNewOptionalParameters);
		}

		#endregion // Interfaces

		#region Methods

		#region IsEquivalentToNewMember

#if DEBUG
		/// <summary>
		/// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build.
		/// </summary>
		/// <param name="newMember">The new member to compare.</param>
		/// <param name="newAssemblyFamily">The assembly family in which new assemblies reside.</param>
		/// <param name="ignoreNewOptionalParameters">
		/// Indicates whether to ignore any new parameters at the end of the collection which are optional when comparing.
		/// </param>
#endif
		private bool IsEquivalentToNewMember(MethodDataBase newMember, AssemblyFamily newAssemblyFamily, bool ignoreNewOptionalParameters)
		{
			if (base.IsEquivalentToNewMember(newMember, newAssemblyFamily) == false)
				return false;

			return this.Parameters.IsEquivalentToNewParameters(newMember.Parameters, newAssemblyFamily, ignoreNewOptionalParameters);
		}

		#endregion // IsEquivalentToNewMember

		#endregion // Methods

		#region Properties

		/// <summary>
		/// Gets the collection of parameters for the method.
		/// </summary>
		public ParameterCollection Parameters { get; private set; }

		#endregion // Properties
	}
}

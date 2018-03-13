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
	/// Represents the metadata for an externally visible event.
	/// </summary>
	public sealed class EventData : TypedMemberDataBase
	{
		#region Constructors

		internal EventData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeData type)
			: base(name, accessibility, memberFlags, type, isTypeDynamic: false)
		{
		}

		private EventData(EventDefinition eventDefinition, MemberAccessibility accessibility, DeclaringTypeData declaringType)
			: base(eventDefinition, accessibility, eventDefinition.EventType, false, Utilities.GetMemberFlags(eventDefinition.AddMethod), declaringType) { }

		#endregion // Constructors

		#region Base Class Overrides

		#region Accept

		/// <summary>
		/// Performs the specified visitor's functionality on this instance.
		/// </summary>
		/// <param name="visitor">The visitor whose functionality should be performed on the instance.</param>
		public override void Accept(MetadataItemVisitor visitor)
		{
			visitor.VisitEventData(this);
		}

		#endregion // Accept

		#region MetadataItemKind

		/// <summary>
		/// Gets the type of item the instance represents.
		/// </summary>
		public override MetadataItemKinds MetadataItemKind
		{
			get { return MetadataItemKinds.Event; }
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
			var replacedType = (TypeData)this.Type.ReplaceGenericTypeParameters(genericParameters, genericArguments);
			if (replacedType == this.Type)
				return this;

			return new EventData(this.Name, this.Accessibility, this.MemberFlags, replacedType);
		}

		#endregion // ReplaceGenericTypeParameters

		#endregion // Base Class Overrides

		#region Methods

		#region EventDataFromReflection

		internal static EventData EventDataFromReflection(EventDefinition eventDefinition, DeclaringTypeData declaringType)
		{
			var accessibility = eventDefinition.AddMethod.GetAccessibility();
			if (accessibility == null)
				return null;

			return new EventData(eventDefinition, accessibility.Value, declaringType);
		}

		#endregion // EventDataFromReflection

		#endregion // Methods
	}
}

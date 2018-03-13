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
	/// Represents the metadata for an externally visible method or indexer parameter.
	/// </summary>
	public sealed class ParameterData : MetadataItemBase,
		ITypedItem
	{
		#region Member Variables

		private readonly InternalFlags _flags; // TODO_Serialize: round trip and test

		#endregion // Member Variables

		#region Constructor

		internal ParameterData(MetadataItemKinds declaringMemberKind, string name, TypeData type, ParameterModifier modifer, InternalFlags flags, object defaultValue)
		{
			_flags = flags;

			this.DeclaringMemberKind = declaringMemberKind;
			this.DefaultValue = defaultValue;
			this.Modifer = modifer;
			this.Name = name;
			this.Type = type;
		}

		internal ParameterData(ParameterDefinition underlyingParameter, MemberDataBase declaringMember)
		{
			var modifer = ParameterModifier.None;
			var parameterType = underlyingParameter.ParameterType;
			var byReferenceType = parameterType as ByReferenceType;
			if (byReferenceType != null)
			{
				modifer = underlyingParameter.IsOut ? ParameterModifier.Out : ParameterModifier.Ref;
				parameterType = byReferenceType.ElementType;
			}

			this.DeclaringMemberKind = declaringMember.MetadataItemKind;
			this.Modifer = modifer;
			this.Name = underlyingParameter.Name;
			this.Type = TypeData.FromType(parameterType);

			if (underlyingParameter.IsOptional)
			{
				_flags |= InternalFlags.IsOptional;
				this.DefaultValue = Utilities.PreprocessConstantValue(parameterType, underlyingParameter.GetDefualtValue());
			}

			if (underlyingParameter.CustomAttributes.Any(c => c.AttributeType.EqualsType(typeof(ParamArrayAttribute))))
				_flags |= InternalFlags.IsParamsArray;

			if (underlyingParameter.IsDynamicType())
				_flags |= InternalFlags.IsTypeDynamic;
		}

		#endregion // Constructor

		#region Base Class Overrides

		#region Accept

		/// <summary>
		/// Performs the specified visitor's functionality on this instance.
		/// </summary>
		/// <param name="visitor">The visitor whose functionality should be performed on the instance.</param>
		public override void Accept(MetadataItemVisitor visitor)
		{
			visitor.VisitParameterData(this);
		}

		#endregion // Accept

		#region DisplayName

		/// <summary>
		/// Gets the name to use for this item in messages.
		/// </summary>
		public override string DisplayName
		{
			get { return this.Name; }
		}

		#endregion // DisplayName

		#region DoesMatch

		internal override bool DoesMatch(MetadataItemBase other)
		{
			if (base.DoesMatch(other) == false)
				return false;

			var otherTyped = other as ParameterData;
			if (otherTyped == null)
				return false;

			if (_flags != otherTyped._flags)
				return false;

			if (this.DeclaringMemberKind != otherTyped.DeclaringMemberKind)
				return false;

			if (Object.Equals(this.DefaultValue, otherTyped.DefaultValue) == false)
				return false;

			if (this.Modifer != otherTyped.Modifer)
				return false;

			if (this.Name != otherTyped.Name)
				return false;

			if (this.Type.DisplayName != otherTyped.DisplayName)
				return false;

			return true;
		}

		#endregion // DoesMatch

		#endregion // Base Class Overrides

		#region Methods

		#region Internal Methods

		#region GetDefaultValueDisplayText

		internal string GetDefaultValueDisplayText()
		{
			if (this.IsOptional == false)
				return null;

			var value = this.DefaultValue;
			if (value == null)
				return "null";

			if (value is bool)
				return value.ToString().ToLower();

			if (this.Type.TypeKind == TypeKind.Enum)
				return Utilities.FormatEnumValue((TypeDefinitionData)this.Type, value);

			return value.ToString();
		}

		#endregion // GetDefaultValueDisplayText

		#region GetParameterListDisplayText

		internal string GetParameterListDisplayText()
		{
			var typeName = this.IsTypeDynamic
				? Utilities.DynamicTypeName
				: this.Type.GetDisplayName(fullyQualify: false);

			if (this.IsParamsArray)
			{
				typeName = "params " + typeName;
			}
			else
			{
				switch (this.Modifer)
				{
					case ParameterModifier.None:
						break;

					case ParameterModifier.Ref:
						typeName = "ref " + typeName;
						break;

					case ParameterModifier.Out:
						typeName = "out " + typeName;
						break;

					default:
						Debug.Fail("Unknown ParameterModifier: " + this.Modifer);
						break;
				}
			}

			var defaultValueText = this.GetDefaultValueDisplayText();
			if (defaultValueText != null)
				return typeName + " = " + defaultValueText;

			return typeName;
		}

		#endregion // GetParameterListDisplayText

		#region IsEquivalentTo

#if DEBUG
		/// <summary>
		/// Indicates whether the two parameter is equivalent to the specified parameter, meaning it has the same type and modifiers (name and default value are ignored).
		/// </summary> 
#endif
		internal bool IsEquivalentTo(ParameterData other)
		{
			return
				this.IsTypeDynamic == other.IsTypeDynamic &&
				this.IsParamsArray == other.IsParamsArray &&
				this.Modifer == other.Modifer &&
				this.Type == other.Type;
		}

		#endregion // IsEquivalentTo

		#region IsEquivalentToNewParameter

#if DEBUG
		/// <summary>
		/// Indicates whether a new parameter of the same type and name is logically the same member as the current parameter, just from a newer build.
		/// </summary> 
#endif
		internal bool IsEquivalentToNewParameter(ParameterData newParameter, AssemblyFamily newAssemblyFamily)
		{
			return
				this.IsTypeDynamic == newParameter.IsTypeDynamic &&
				this.IsParamsArray == newParameter.IsParamsArray &&
				this.Modifer == newParameter.Modifer &&
				this.Type.IsEquivalentToNew(newParameter.Type, newAssemblyFamily);
		}

		#endregion // IsEquivalentToNewParameter

		#region ReplaceGenericTypeParameters

#if DEBUG
		/// <summary>
		/// Replaces all type parameters used by the member with their associated generic arguments specified in a constructed generic type.
		/// </summary>
		/// <param name="declaringMemberKind">The type of member owning the parameter collection.</param>
		/// <param name="genericParameters">The generic parameters being replaced.</param>
		/// <param name="genericArguments">The generic arguments replacing the parameters.</param>
		/// <returns>A new member with the replaced type parameters or the current instance if the member does not use any of the generic parameters.</returns> 
#endif
		internal ParameterData ReplaceGenericTypeParameters(MetadataItemKinds declaringMemberKind, GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
		{
			var replacedType = (TypeData)this.Type.ReplaceGenericTypeParameters(genericParameters, genericArguments);
			if (replacedType == this.Type)
				return this;

			return new ParameterData(declaringMemberKind, this.Name, replacedType, this.Modifer, _flags, this.DefaultValue);
		}

		#endregion // ReplaceGenericTypeParameters

		#endregion // Internal Methods

		#region Private Methods

		#region GetFlag

		private bool GetFlag(InternalFlags flag)
		{
			return (_flags & flag) == flag;
		}

		#endregion // GetFlag

		#endregion // Private Methods

		#endregion // Methods

		#region Properties

		/// <summary>
		/// Gets the type of member owning the parameter collection.
		/// </summary>
		public MetadataItemKinds DeclaringMemberKind { get; private set; }

		/// <summary>
		/// Gets the default value of an optional parameter (only valid if <see cref="IsOptional"/> is true).
		/// </summary>
		/// <seealso cref="IsOptional"/>
		public object DefaultValue { get; private set; }

		/// <summary>
		/// Gets the value indicating whether the parameter has a default value and is therefore optional.
		/// </summary>
		/// <seealso cref="DefaultValue"/>
		public bool IsOptional { get { return this.GetFlag(InternalFlags.IsOptional); } }

		/// <summary>
		/// Gets the value indicating whether the parameter is a paras array.
		/// </summary>
		public bool IsParamsArray { get { return this.GetFlag(InternalFlags.IsParamsArray); } }

		/// <summary>
		/// Gets the value indicating whether the parameter type is 'dynamic', in which case <see cref="Type"/> will be System.Object.
		/// </summary>
		public bool IsTypeDynamic { get { return this.GetFlag(InternalFlags.IsTypeDynamic); } }

		/// <summary>
		/// Gets the type of item the instance represents.
		/// </summary>
		public override MetadataItemKinds MetadataItemKind
		{
			get { return MetadataItemKinds.Parameter; }
		}

		/// <summary>
		/// Gets the value indicating whether a ref or out modifier is specified on the parameter.
		/// </summary>
		public ParameterModifier Modifer { get; private set; }

		/// <summary>
		/// Gets the name of the parameter.
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// Gets the type of the parameter.
		/// </summary>
		public TypeData Type { get; private set; }

		#endregion // Properties


		#region InternalFlags enum

		[Flags]
		internal enum InternalFlags : byte
		{
			IsOptional = 1 << 0,
			IsParamsArray = 1 << 1,
			IsTypeDynamic = 1 << 2,
		}

		#endregion // InternalFlags enum
	}
}

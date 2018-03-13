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

using BreakingChangesDetector.BreakingChanges.Formatting;
using BreakingChangesDetector.MetadataItems;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.BreakingChanges
{
	#region BreakingChangeBase

	/// <summary>
	/// Abstract base class for an object representing a breaking change.
	/// </summary>
	public abstract class BreakingChangeBase
	{
		#region Member Variables

		private string _message;

		#endregion // Member Variables

		#region Constructor

		internal BreakingChangeBase(MetadataItemBase oldItem, MetadataItemBase newItem, MetadataItemBase associatedData, BreakingChangeKind breakingChangeKind)
		{
			this.AssociatedData = associatedData;
			this.BreakingChangeKind = breakingChangeKind;
			this.NewItem = newItem;
			this.OldItem = oldItem;
		}

		#endregion // Constructor

		#region Base Class Overrides

		/// <summary>
		/// Gets a string representation of the breaking change.
		/// </summary>
		public override string ToString()
		{
			return this.Message;
		}

		#endregion // Base Class Overrides

		#region Methods

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public abstract void FormatMessage(IBreakingChangeFormatter formatter);

		#endregion // Methods

		#region Properties

		#region Public Properties

		/// <summary>
		/// Gets the type of breaking change this instance represents.
		/// </summary>
		public BreakingChangeKind BreakingChangeKind { get; private set; }

		/// <summary>
		/// Gets the message describing the breaking change.
		/// </summary>
		public string Message
		{
			get
			{
				if (_message == null)
				{
					var stringFormatter = new BreakingChangeStringFormatter();
					this.FormatMessage(stringFormatter);
					_message = stringFormatter.Builder.ToString();
				}

				return _message;
			}
		}

		#endregion // Public Properties

		#region Internal Properties

		internal MetadataItemBase AssociatedData { get; private set; }
		internal MetadataItemBase NewItem { get; private set; }
		internal MetadataItemBase OldItem { get; private set; }

		#endregion // Internal Properties

		#endregion // Properties
	}

	#endregion // BreakingChangeBase


	#region AddedAbstractMember

	/// <summary>
	/// Represents an abstract member which has been added to an abstract type, which may cause externally derived types to not compile.
	/// </summary>
	public sealed class AddedAbstractMember : BreakingChangeBase
	{
		internal AddedAbstractMember(MemberDataBase newMember)
			: base(null, newMember, null, BreakingChangeKind.AddedAbstractMember)
		{
			this.NewMember = newMember;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Added a new abstract {0} {1} which will cause derived classes to not compile.",
				FormatItem.MemberKind(this.NewMember),
				FormatItem.MemberName(this.NewMember, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the abstract member which has been added.
		/// </summary>
		public MemberDataBase NewMember { get; private set; }
	}

	#endregion // AddedAbstractMember

	#region AddedBaseInterface

	/// <summary>
	/// Represents an interface (with at least one member) which has been added to the base type list of an existing interface,
	/// which may cause implementors of the existing interface to not compile.
	/// </summary>
	public sealed class AddedBaseInterface : BreakingChangeBase
	{
		internal AddedBaseInterface(TypeDefinitionData oldType, TypeDefinitionData newType, DeclaringTypeData newInterfaceType)
			: base(oldType, newType, newInterfaceType, BreakingChangeKind.AddedBaseInterface)
		{
			this.OldType = oldType;
			this.NewType = newType;
			this.NewInterfaceType = newInterfaceType;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Added a new base interface {1} to {0} which will cause implementing types to not compile.",
				FormatItem.MemberName(this.NewType, StyleFlags.Bold),
				FormatItem.MemberName(this.NewInterfaceType, StyleFlags.Italics));
		}

		/// <summary>
		/// Gets the older version of the existing interface.
		/// </summary>
		public TypeDefinitionData OldType { get; private set; }

		/// <summary>
		/// Gets the newer version of the existing interface.
		/// </summary>
		public TypeDefinitionData NewType { get; private set; }

		/// <summary>
		/// Gets the interface which has been added to the base type list of the existing interface.
		/// </summary>
		public DeclaringTypeData NewInterfaceType { get; private set; }
	}

	#endregion // AddedBaseInterface

	#region AddedInterfaceMember

	/// <summary>
	/// Represents an member which has been added to an interface type, which may cause externally implementing types to not compile.
	/// </summary>
	public sealed class AddedInterfaceMember : BreakingChangeBase
	{
		internal AddedInterfaceMember(MemberDataBase newMember)
			: base(null, newMember, null, BreakingChangeKind.AddedInterfaceMember)
		{
			this.NewMember = newMember;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Added a new interface {0} {1} which will cause implementing types to not compile.",
				FormatItem.MemberKind(this.NewMember),
				FormatItem.MemberName(this.NewMember, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the member which has been added.
		/// </summary>
		public MemberDataBase NewMember { get; private set; }
	}

	#endregion // AddedInterfaceMember

	#region ChangedAccessibilityFromPublicToProtected

	/// <summary>
	/// Represents the change of a member or type's accessibility from public to protected, which will cause usages of it outside
	/// derived types to not compile.
	/// </summary>
	public sealed class ChangedAccessibilityFromPublicToProtected : BreakingChangeBase
	{
		internal ChangedAccessibilityFromPublicToProtected(MemberDataBase oldMember, MemberDataBase newMember)
			: base(oldMember, newMember, null, BreakingChangeKind.ChangedAccessibilityFromPublicToProtected)
		{
			this.OldMember = oldMember;
			this.NewMember = newMember;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed accessibility of {0} from public to protected which may cause code to not compile.",
				FormatItem.MemberName(this.NewMember, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the member or type.
		/// </summary>
		public MemberDataBase OldMember { get; private set; }

		/// <summary>
		/// Gets the newer version of the member or type.
		/// </summary>
		public MemberDataBase NewMember { get; private set; }
	}

	#endregion // ChangedAccessibilityFromPublicToProtected

	#region ChangedClassToAbstract

	/// <summary>
	/// Represents the change of the non-abstract class to abstract, which will cause instantiations of the type to not compile.
	/// </summary>
	public sealed class ChangedClassToAbstract : BreakingChangeBase
	{
		internal ChangedClassToAbstract(TypeDefinitionData oldType, TypeDefinitionData newType)
			: base(oldType, newType, null, BreakingChangeKind.ChangedClassToAbstract)
		{
			this.OldType = oldType;
			this.NewType = newType;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed non-abstract class {0} to abstract which will cause instantiations of the class to not compile.",
				FormatItem.MemberName(this.NewType, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the class.
		/// </summary>
		public TypeDefinitionData OldType { get; private set; }

		/// <summary>
		/// Gets the newer version of the class.
		/// </summary>
		public TypeDefinitionData NewType { get; private set; }
	}

	#endregion // ChangedClassToAbstract

	#region ChangedFieldToReadOnly

	/// <summary>
	/// Represents the change of a read-write field to read-only, which will cause assignments to the field to not compile.
	/// </summary>
	public sealed class ChangedFieldToReadOnly : BreakingChangeBase
	{
		internal ChangedFieldToReadOnly(FieldData oldField, FieldData newField)
			: base(oldField, newField, null, BreakingChangeKind.ChangedFieldToReadOnly)
		{
			this.OldField = oldField;
			this.NewField = newField;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed read-write field {0} to read-only which will cause writes to the field to not compile.",
				FormatItem.MemberName(this.NewField, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the field.
		/// </summary>
		public FieldData OldField { get; private set; }

		/// <summary>
		/// Gets the newer version of the field.
		/// </summary>
		public FieldData NewField { get; private set; }
	}

	#endregion // ChangedFieldToReadOnly

	#region ChangedClassToStatic

	/// <summary>
	/// Represents the change of the class to static, which will cause instantiations of the type to not compile.
	/// </summary>
	public sealed class ChangedClassToStatic : BreakingChangeBase
	{
		internal ChangedClassToStatic(TypeDefinitionData oldType, TypeDefinitionData newType)
			: base(oldType, newType, null, BreakingChangeKind.ChangedClassToStatic)
		{
			this.OldType = oldType;
			this.NewType = newType;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed non-static class {0} to static which will cause instantiations of the class to not compile.",
				FormatItem.MemberName(this.NewType, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the class.
		/// </summary>
		public TypeDefinitionData OldType { get; private set; }

		/// <summary>
		/// Gets the newer version of the class.
		/// </summary>
		public TypeDefinitionData NewType { get; private set; }
	}

	#endregion // ChangedClassToStatic

	#region ChangedGenericTypeParameterConstraints

	/// <summary>
	/// Represents the change of the constraints on a generic type parameter, which may cause constructions of the generic entity
	/// to not compile.
	/// </summary>
	public sealed class ChangedGenericTypeParameterConstraints : BreakingChangeBase
	{
		internal ChangedGenericTypeParameterConstraints(GenericTypeParameterData oldGenericParameter, GenericTypeParameterData newGenericParameter)
			: base(oldGenericParameter, newGenericParameter, null, BreakingChangeKind.ChangedGenericTypeParameterConstraints)
		{
			this.OldGenericParameter = oldGenericParameter;
			this.NewGenericParameter = newGenericParameter;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed constraints for the generic type parameter {0} in {1} {2} which may cause constructions of the entity to not compile.",
				FormatItem.MemberName(this.NewGenericParameter, StyleFlags.Italics),
				FormatItem.MemberKind(this.NewGenericParameter.GenericDeclaringMember),
				FormatItem.MemberName(this.NewGenericParameter.GenericDeclaringMember, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the generic type parameter.
		/// </summary>
		public GenericTypeParameterData OldGenericParameter { get; private set; }

		/// <summary>
		/// Gets the newer version of the generic type parameter.
		/// </summary>
		public GenericTypeParameterData NewGenericParameter { get; private set; }
	}

	#endregion // ChangedGenericTypeParameterConstraints

	#region ChangedGenericTypeParameterVariance

	/// <summary>
	/// Represents the removal or change of the 'in' or 'out' variance modifier on a generic type parameter's definition, which may 
	/// cause contra- or co-variant conversions of the declaring generic type to not compile.
	/// </summary>
	public sealed class ChangedGenericTypeParameterVariance : BreakingChangeBase
	{
		internal ChangedGenericTypeParameterVariance(GenericTypeParameterData oldGenericParameter, GenericTypeParameterData newGenericParameter)
			: base(oldGenericParameter, newGenericParameter, null, BreakingChangeKind.ChangedGenericTypeParameterVariance)
		{
			this.OldGenericParameter = oldGenericParameter;
			this.NewGenericParameter = newGenericParameter;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed variance (in or out modifier) for the generic type parameter {0} in {1} {2} which may cause implicit conversions of the {1} to not compile.",
				FormatItem.MemberName(this.NewGenericParameter, StyleFlags.Italics),
				FormatItem.MemberKind(this.NewGenericParameter.GenericDeclaringMember),
				FormatItem.MemberName(this.NewGenericParameter.GenericDeclaringMember, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the generic type parameter.
		/// </summary>
		public GenericTypeParameterData OldGenericParameter { get; private set; }

		/// <summary>
		/// Gets the newer version of the generic type parameter.
		/// </summary>
		public GenericTypeParameterData NewGenericParameter { get; private set; }
	}

	#endregion // ChangedGenericTypeParameterVariance

	#region ChangedMemberToAbstract

	/// <summary>
	/// Represents the change of a non-abstract member to abstract, which may cause externally derived types to not compile.
	/// </summary>
	public sealed class ChangedMemberToAbstract : BreakingChangeBase
	{
		internal ChangedMemberToAbstract(MemberDataBase oldMember, MemberDataBase newMember)
			: base(oldMember, newMember, null, BreakingChangeKind.ChangedMemberToAbstract)
		{
			this.OldMember = oldMember;
			this.NewMember = newMember;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed non-abstract {0} {1} to abstract which will cause derived classes not overriding the {0} to not compile.",
				FormatItem.MemberKind(this.NewMember),
				FormatItem.MemberName(this.NewMember, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older definition of the member, which is not abstract.
		/// </summary>
		public MemberDataBase OldMember { get; private set; }

		/// <summary>
		/// Gets the newer definition of the member, which is abstract.
		/// </summary>
		public MemberDataBase NewMember { get; private set; }
	}

	#endregion // ChangedMemberToAbstract

	#region ChangedMemberToNonVirtual

	/// <summary>
	/// Represents the change of a virtual member to non-virtual, which will cause overrides of the member in externally derived types 
	/// to not compile.
	/// </summary>
	public sealed class ChangedMemberToNonVirtual : BreakingChangeBase
	{
		internal ChangedMemberToNonVirtual(MemberDataBase oldMember, MemberDataBase newMember)
			: base(oldMember, newMember, null, BreakingChangeKind.ChangedMemberToNonVirtual)
		{
			this.OldMember = oldMember;
			this.NewMember = newMember;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed virtual {0} {1} to non-virtual which will cause derived classes overriding the {0} to not compile.",
				FormatItem.MemberKind(this.NewMember),
				FormatItem.MemberName(this.NewMember, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older definition of the member, which is not virtual, abstract, or override (without a sealed modifier).
		/// </summary>
		public MemberDataBase OldMember { get; private set; }

		/// <summary>
		/// Gets the newer definition of the member, which is non-virtual.
		/// </summary>
		public MemberDataBase NewMember { get; private set; }
	}

	#endregion // ChangedMemberToNonVirtual

	#region ChangedMemberType

	/// <summary>
	/// Represents the change of a member type to something which will cause usages of it in external code to not compile. For out-only
	/// types, including return types from methods and delegates as well as the types of constants and read-only fields, properties, and
	/// indexers, this is a type not implicitly assignable to the original type. For in-only types, including the types or write-only
	/// properties and indexers, this is a type not implicitly assignable from the original type. For in and out types, such as the types
	/// of read/write fields, properties, and indexers, this is any type other than the original type.
	/// </summary>
	public sealed class ChangedMemberType : BreakingChangeBase
	{
		internal ChangedMemberType(ITypedItem oldTypedItem, ITypedItem newTypedItem)
			: base((MetadataItemBase)oldTypedItem, (MetadataItemBase)newTypedItem, null, BreakingChangeKind.ChangedMemberType)
		{
			this.OldTypedItem = oldTypedItem;
			this.NewTypedItem = newTypedItem;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed the type of {0} {1} in a way which may cause code using the {0} to not compile. Type was changed from {2} to {3}.",
				FormatItem.TypedItemKind(this.NewTypedItem),
				FormatItem.TypedItemName(this.NewTypedItem, StyleFlags.Bold),
				FormatItem.TypedItemTypeName(this.OldTypedItem, StyleFlags.Italics),
				FormatItem.TypedItemTypeName(this.NewTypedItem, StyleFlags.Italics));
		}

		/// <summary>
		/// Gets the older definition of the member.
		/// </summary>
		public ITypedItem OldTypedItem { get; private set; }

		/// <summary>
		/// Gets the newer definition of the member.
		/// </summary>
		public ITypedItem NewTypedItem { get; private set; }
	}

	#endregion // ChangedMemberType

	#region ChangedParameterCount

	/// <summary>
	/// Represents the change of the required or total parameter count of a method, indexer, or delegate in a way which could cause 
	/// external invocations to not compile. This can represent an increase in the required parameter count, perhaps by removing the a 
	/// parameter's default value, which will cause invocations not passing in all parameters to not compile. It can also represent a
	/// decrease in the total parameter count, which will cause invocations passing in all parameters to not compile.
	/// </summary>
	public sealed class ChangedParameterCount : BreakingChangeBase
	{
		internal ChangedParameterCount(IParameterizedItem oldParameterizedItem, IParameterizedItem newParameterizedItem)
			: base((MetadataItemBase)oldParameterizedItem, (MetadataItemBase)newParameterizedItem, null, BreakingChangeKind.ChangedParameterCount)
		{
			this.OldParameterizedItem = oldParameterizedItem;
			this.NewParameterizedItem = newParameterizedItem;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed the parameter count of {0} in a way which may cause invocations to not compile. Previous declaration was {1}.",
				FormatItem.ParameterizedItemName(this.NewParameterizedItem, StyleFlags.Bold),
				FormatItem.ParameterizedItemName(this.OldParameterizedItem, StyleFlags.Italics));
		}

		/// <summary>
		/// Gets the older version of the method, indexer, or delegate owning the parameters.
		/// </summary>
		public IParameterizedItem OldParameterizedItem { get; private set; }

		/// <summary>
		/// Gets the newer version of the method, indexer, or delegate owning the parameters.
		/// </summary>
		public IParameterizedItem NewParameterizedItem { get; private set; }
	}

	#endregion // ChangedParameterCount

	#region ChangedParameterDefaultValue

	/// <summary>
	/// Represents the change of a parameter's default value, which may cause a behavioral change in an external invocation.
	/// </summary>
	public sealed class ChangedParameterDefaultValue : BreakingChangeBase
	{
		internal ChangedParameterDefaultValue(ParameterData oldParameter, ParameterData newParameter, IParameterizedItem newParameterizedItem)
			: base(oldParameter, newParameter, (MetadataItemBase)newParameterizedItem, BreakingChangeKind.ChangedParameterDefaultValue)
		{
			this.OldParameter = oldParameter;
			this.NewParameter = newParameter;
			this.NewParameterizedItem = newParameterizedItem;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed default value of parameter '{0}' in {1} which may cause an unintentional behavioral change in code. The value was changed from '{2}' to '{3}'.",
				FormatItem.ParameterName(this.NewParameter, StyleFlags.Italics),
				FormatItem.ParameterizedItemName(this.NewParameterizedItem, StyleFlags.Bold),
				FormatItem.DefaultParameterValue(this.OldParameter, StyleFlags.Italics),
				FormatItem.DefaultParameterValue(this.NewParameter, StyleFlags.Italics));
		}

		/// <summary>
		/// Gets the older version of the parameter.
		/// </summary>
		public ParameterData OldParameter { get; private set; }

		/// <summary>
		/// Gets the older version of the parameter.
		/// </summary>
		public ParameterData NewParameter { get; private set; }

		/// <summary>
		/// Gets the newer version of the method, indexer, or delegate which defines the parameter.
		/// </summary>
		public IParameterizedItem NewParameterizedItem { get; private set; }
	}

	#endregion // ChangedParameterDefaultValue

	#region ChangedParameterModifier

	/// <summary>
	/// Represents the addition, removal, or change of a parameter's 'ref' or 'out' modifier, which will cause external invocations to 
	/// not compile.
	/// </summary>
	public sealed class ChangedParameterModifier : BreakingChangeBase
	{
		internal ChangedParameterModifier(ParameterData oldParameter, ParameterData newParameter, IParameterizedItem newParameterizedItem)
			: base(oldParameter, newParameter, (MetadataItemBase)newParameterizedItem, BreakingChangeKind.ChangedParameterModifier)
		{
			this.OldParameter = oldParameter;
			this.NewParameter = newParameter;
			this.NewParameterizedItem = newParameterizedItem;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed the ref or out modifier of parameter '{0}' in {1} which will cause invocations to not compile.",
				FormatItem.ParameterName(this.NewParameter, StyleFlags.Italics),
				FormatItem.ParameterizedItemName(this.NewParameterizedItem, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the parameter.
		/// </summary>
		public ParameterData OldParameter { get; private set; }

		/// <summary>
		/// Gets the older version of the parameter.
		/// </summary>
		public ParameterData NewParameter { get; private set; }

		/// <summary>
		/// Gets the newer version of the method, indexer, or delegate which defines the parameter.
		/// </summary>
		public IParameterizedItem NewParameterizedItem { get; private set; }
	}

	#endregion // ChangedParameterModifier

	#region ChangedParameterName

	/// <summary>
	/// Represents the change of a parameter's name, which will cause a named argument in an external invocation to not compile.
	/// </summary>
	public sealed class ChangedParameterName : BreakingChangeBase
	{
		internal ChangedParameterName(ParameterData oldParameter, ParameterData newParameter, IParameterizedItem newParameterizedItem)
			: base(oldParameter, newParameter, (MetadataItemBase)newParameterizedItem, BreakingChangeKind.ChangedParameterName)
		{
			this.OldParameter = oldParameter;
			this.NewParameter = newParameter;
			this.NewParameterizedItem = newParameterizedItem;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed the name of a parameter from '{0}' to '{1}' in {2} which will cause named arguments in invocations to not compile.",
				FormatItem.ParameterName(this.OldParameter, StyleFlags.Italics),
				FormatItem.ParameterName(this.NewParameter, StyleFlags.Italics),
				FormatItem.ParameterizedItemName(this.NewParameterizedItem, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the parameter.
		/// </summary>
		public ParameterData OldParameter { get; private set; }

		/// <summary>
		/// Gets the older version of the parameter.
		/// </summary>
		public ParameterData NewParameter { get; private set; }

		/// <summary>
		/// Gets the newer version of the method, indexer, or delegate which defines the parameter.
		/// </summary>
		public IParameterizedItem NewParameterizedItem { get; private set; }
	}

	#endregion // ChangedParameterName

	#region ChangedParameterType

	/// <summary>
	/// Represents the change of a parameter's type to something which will cause external invocations to not compile. For normal parameters, 
	/// this is a type not implicitly assignable from the original type. For 'ref' and 'out' parameters, this is any type other than the 
	/// original type.
	/// </summary>
	public sealed class ChangedParameterType : BreakingChangeBase
	{
		internal ChangedParameterType(ParameterData oldParameter, ParameterData newParameter, IParameterizedItem newParameterizedItem)
			: base(oldParameter, newParameter, (MetadataItemBase)newParameterizedItem, BreakingChangeKind.ChangedParameterType)
		{
			this.OldParameter = oldParameter;
			this.NewParameter = newParameter;
			this.NewParameterizedItem = newParameterizedItem;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed the type of parameter '{0}' in {1} in a way which may cause invocations to not compile. Type was changed from {2} to {3}.",
				FormatItem.ParameterName(this.NewParameter, StyleFlags.Italics),
				FormatItem.ParameterizedItemName(this.NewParameterizedItem, StyleFlags.Bold),
				FormatItem.TypedItemTypeName(this.OldParameter, StyleFlags.Italics),
				FormatItem.TypedItemTypeName(this.NewParameter, StyleFlags.Italics));
		}

		/// <summary>
		/// Gets the older version of the parameter.
		/// </summary>
		public ParameterData OldParameter { get; private set; }

		/// <summary>
		/// Gets the older version of the parameter.
		/// </summary>
		public ParameterData NewParameter { get; private set; }

		/// <summary>
		/// Gets the newer version of the method, indexer, or delegate which defines the parameter.
		/// </summary>
		public IParameterizedItem NewParameterizedItem { get; private set; }
	}

	#endregion // ChangedParameterType

	#region ChangedStaticOrInstanceStatus

	/// <summary>
	/// Represents the removal or addition of the static modifier on an event, field, property, or method, which may cause external usages of
	/// the member to not compile.
	/// </summary>
	public sealed class ChangedStaticOrInstanceStatus : BreakingChangeBase
	{
		internal ChangedStaticOrInstanceStatus(MemberDataBase oldMember, MemberDataBase newMember)
			: base(oldMember, newMember, null, BreakingChangeKind.ChangedStaticOrInstanceStatus)
		{
			this.OldMember = oldMember;
			this.NewMember = newMember;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Added or removed the static modifier of {0} {1} which may cause code using the {0} to not compile.",
				FormatItem.MemberKind(this.NewMember),
				FormatItem.MemberName(this.NewMember, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the member.
		/// </summary>
		public MemberDataBase OldMember { get; private set; }

		/// <summary>
		/// Gets the newer version of the member.
		/// </summary>
		public MemberDataBase NewMember { get; private set; }
	}

	#endregion // ChangedStaticOrInstanceStatus

	#region IncompatibleClassHierarchy

	/// <summary>
	/// Represents the change of a class's base type to something not derived from the original base type, which may cause external usages of
	/// the class to not compile.
	/// </summary>
	public sealed class IncompatibleClassHierarchy : BreakingChangeBase
	{
		internal IncompatibleClassHierarchy(TypeDefinitionData oldType, TypeDefinitionData newType)
			: base(oldType, newType, null, BreakingChangeKind.IncompatibleClassHierarchy)
		{
			this.OldType = oldType;
			this.NewType = newType;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed the base class of {0} to something not derived from the previous base class which may cause code using the class to not compile. The base class was changed from {1} to {2}.",
				FormatItem.MemberName(this.NewType, StyleFlags.Bold),
				FormatItem.MemberName(this.OldType.BaseType, StyleFlags.Italics),
				FormatItem.MemberName(this.NewType.BaseType, StyleFlags.Italics));
		}

		/// <summary>
		/// Gets the older version of the class.
		/// </summary>
		public TypeDefinitionData OldType { get; private set; }

		/// <summary>
		/// Gets the newer version of the class.
		/// </summary>
		public TypeDefinitionData NewType { get; private set; }
	}

	#endregion // IncompatibleClassHierarchy

	#region RemovedAssembly

	/// <summary>
	/// Represents the removal of an assembly, which will cause external usages of types from the assembly to not compile.
	/// </summary>
	public sealed class RemovedAssembly : BreakingChangeBase
	{
		internal RemovedAssembly(AssemblyData oldAssembly)
			: base(oldAssembly, null, null, BreakingChangeKind.RemovedAssembly)
		{
			this.OldAssembly = oldAssembly;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Removed the equivalent to assembly {0} in the new version, which will cause projects referencing the assembly to not compile.",
				FormatItem.AssemblyName(this.OldAssembly, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the assembly.
		/// </summary>
		public AssemblyData OldAssembly { get; private set; }
	}

	#endregion // RemovedAssembly

	#region RemovedExtensionMethodModifier

	/// <summary>
	/// Represents the removal of the 'this' parameter modifier on the first parameter of an extension method, which may cause external 
	/// invocations of the method to not compile.
	/// </summary>
	public sealed class RemovedExtensionMethodModifier : BreakingChangeBase
	{
		internal RemovedExtensionMethodModifier(MethodData oldMethod, MethodData newMethod)
			: base(oldMethod, newMethod, null, BreakingChangeKind.RemovedExtensionMethodModifier)
		{
			this.OldMethod = oldMethod;
			this.NewMethod = newMethod;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Removed the 'this' modifier from the first parameter of {0} which will cause code using the method as an extension method to not compile.",
				FormatItem.MemberName(this.NewMethod, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the method.
		/// </summary>
		public MethodData OldMethod { get; private set; }

		/// <summary>
		/// Gets the newer version of the method.
		/// </summary>
		public MethodData NewMethod { get; private set; }
	}

	#endregion // RemovedExtensionMethodModifier

	#region RemovedImplementedInterface

	/// <summary>
	/// Represents the removal of an interface from a types implemented interfaces list, which may cause external usages of the type to
	/// not compile.
	/// </summary>
	public sealed class RemovedImplementedInterface : BreakingChangeBase
	{
		internal RemovedImplementedInterface(TypeDefinitionData oldType, TypeDefinitionData newType, DeclaringTypeData oldInterfaceType)
			: base(oldType, newType, oldInterfaceType, BreakingChangeKind.RemovedImplementedInterface)
		{
			this.OldType = oldType;
			this.NewType = newType;
			this.OldInterfaceType = oldInterfaceType;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Removed implementation of interface {0} from {1} which may cause code using the {2} to not compile.",
				FormatItem.MemberName(this.OldInterfaceType, StyleFlags.Italics),
				FormatItem.MemberName(this.NewType, StyleFlags.Bold),
				FormatItem.MemberKind(this.NewType));
		}

		/// <summary>
		/// Gets the older version of the type.
		/// </summary>
		public TypeDefinitionData OldType { get; private set; }

		/// <summary>
		/// Gets the newer version of the type.
		/// </summary>
		public TypeDefinitionData NewType { get; private set; }

		/// <summary>
		/// Gets the older version of the interface which was implemented on the type.
		/// </summary>
		public DeclaringTypeData OldInterfaceType { get; private set; }
	}

	#endregion // RemovedImplementedInterface

	#region RemovedMember

	/// <summary>
	/// Represents the removal or rename of a member from a type, which will cause external usages of the member to not compile.
	/// </summary>
	public sealed class RemovedMember : BreakingChangeBase
	{
		internal RemovedMember(MemberDataBase oldMember, TypeDefinitionData newType)
			: base(oldMember, null, newType, BreakingChangeKind.RemovedMember)
		{
			this.NewType = newType;
			this.OldMember = oldMember;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Removed {0} {1} which will cause code using the {0} to not compile.",
				FormatItem.MemberKind(this.OldMember),
				FormatItem.MemberName(this.OldMember, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the newer version of the type, which no longer defines the member.
		/// </summary>
		public TypeDefinitionData NewType { get; private set; }

		/// <summary>
		/// Gets the older version of the member.
		/// </summary>
		public MemberDataBase OldMember { get; private set; }
	}

	#endregion // RemovedMember

	#region RemovedOverrideOfAbstractMember

	/// <summary>
	/// Represents the removal of an override of an abstract member, which may cause externally derived types not also overriding the 
	/// member to not compile.
	/// </summary>
	public sealed class RemovedOverrideOfAbstractMember : BreakingChangeBase
	{
		internal RemovedOverrideOfAbstractMember(MemberDataBase oldMemberOverride, TypeDefinitionData newType)
			: base(oldMemberOverride, null, newType, BreakingChangeKind.RemovedOverrideOfAbstractMember)
		{
			this.NewType = newType;
			this.OldMemberOverride = oldMemberOverride;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Removed override of abstract {0} {1} in {2} which may derived classes to not compile.",
				FormatItem.MemberKind(this.OldMemberOverride),
				FormatItem.MemberName(this.OldMemberOverride, StyleFlags.Italics),
				FormatItem.MemberName(this.NewType, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the newer version of the type, which no longer defines the override.
		/// </summary>
		public TypeDefinitionData NewType { get; private set; }

		/// <summary>
		/// Gets the older version of the member override.
		/// </summary>
		public MemberDataBase OldMemberOverride { get; private set; }
	}

	#endregion // RemovedOverrideOfAbstractMember

	#region RemovedPropertyAccessors

	/// <summary>
	/// Represents the removal (or hiding) of the get and/or set accessor from a property or indexer, which may cause external usages 
	/// of the member to not compile.
	/// </summary>
	public sealed class RemovedPropertyAccessors : BreakingChangeBase
	{
		internal RemovedPropertyAccessors(PropertyData oldProperty, PropertyData newProperty)
			: base(oldProperty, newProperty, null, BreakingChangeKind.RemovedPropertyAccessors)
		{
			this.OldProperty = oldProperty;
			this.NewProperty = newProperty;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Removed or changed the visibility of the get or set accessor of {0} {1} which may code using the {0} to not compile.",
				FormatItem.MemberKind(this.NewProperty),
				FormatItem.MemberName(this.NewProperty, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the property or indexer.
		/// </summary>
		public PropertyData OldProperty { get; private set; }

		/// <summary>
		/// Gets the newer version of the property or indexer.
		/// </summary>
		public PropertyData NewProperty { get; private set; }
	}

	#endregion // RemovedPropertyAccessors

	#region RemovedRootType

	/// <summary>
	/// Removed or renamed a non-nested type declaration, which will cause external usages of the type to not compile.
	/// </summary>
	public sealed class RemovedRootType : BreakingChangeBase
	{
		internal RemovedRootType(TypeDefinitionData oldType)
			: base(oldType, null, null, BreakingChangeKind.RemovedRootType)
		{
			this.OldType = oldType;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Removed {0} {1} which will cause code using the {0} to not compile.",
				FormatItem.MemberKind(this.OldType),
				FormatItem.MemberName(this.OldType, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the type.
		/// </summary>
		public TypeDefinitionData OldType { get; private set; }
	}

	#endregion // RemovedRootType

	#region SealedClass

	/// <summary>
	/// Represents the addition of the 'sealed' keyword to a class declaration, which will cause externally derived classes to not compile.
	/// </summary>
	public sealed class SealedClass : BreakingChangeBase
	{
		internal SealedClass(TypeDefinitionData oldType, TypeDefinitionData newType)
			: base(oldType, newType, null, BreakingChangeKind.SealedClass)
		{
			this.OldType = oldType;
			this.NewType = newType;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed class {0} from unsealed to sealed which will cause derived classes to not compile.",
				FormatItem.MemberName(this.NewType, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the class declaration.
		/// </summary>
		public TypeDefinitionData OldType { get; private set; }

		/// <summary>
		/// Gets the newer version of the class declaration.
		/// </summary>
		public TypeDefinitionData NewType { get; private set; }
	}

	#endregion // SealedClass

	#region SealedMember

	/// <summary>
	/// Represents the addition of the 'sealed' keyword to a member override, which will cause externally derived classes also overriding 
	/// the member to not compile.
	/// </summary>
	public sealed class SealedMember : BreakingChangeBase
	{
		internal SealedMember(MemberDataBase oldMember, MemberDataBase newMember)
			: base(oldMember, newMember, null, BreakingChangeKind.SealedMember)
		{
			this.OldMember = oldMember;
			this.NewMember = newMember;
		}

		/// <summary>
		/// Formats a message explaining the breaking change using the specified formatter.
		/// </summary>
		public override void FormatMessage(IBreakingChangeFormatter formatter)
		{
			formatter.AppendFormat("Changed {0} {1} from unsealed to sealed which will cause derived classes overriding the {0} to not compile.",
				FormatItem.MemberKind(this.NewMember),
				FormatItem.MemberName(this.NewMember, StyleFlags.Bold));
		}

		/// <summary>
		/// Gets the older version of the member.
		/// </summary>
		public MemberDataBase OldMember { get; private set; }

		/// <summary>
		/// Gets the newer version of the member.
		/// </summary>
		public MemberDataBase NewMember { get; private set; }
	}

	#endregion // SealedMember
}

/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.
    Copyright 2018 Google LLC

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

namespace BreakingChangesDetector.BreakingChanges
{
    /// <summary>
    /// Abstract base sealed class for an object representing a breaking change.
    /// </summary>
    public abstract class BreakingChangeBase
    {
        private string _message;

        internal BreakingChangeBase(MetadataItemBase oldItem, MetadataItemBase newItem, MetadataItemBase associatedData, BreakingChangeKind breakingChangeKind)
        {
            AssociatedData = associatedData;
            BreakingChangeKind = breakingChangeKind;
            NewItem = newItem;
            OldItem = oldItem;
        }

        /// <inheritdoc/>
        public override string ToString() => Message;

        /// <summary>
        /// Formats a message explaining the breaking change using the specified formatter.
        /// </summary>
        public abstract void FormatMessage(IBreakingChangeFormatter formatter);

        /// <summary>
        /// Gets the type of breaking change this instance represents.
        /// </summary>
        public BreakingChangeKind BreakingChangeKind { get; }

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
                    FormatMessage(stringFormatter);
                    _message = stringFormatter.Builder.ToString();
                }

                return _message;
            }
        }

        internal MetadataItemBase AssociatedData { get; }
        internal MetadataItemBase NewItem { get; }
        internal MetadataItemBase OldItem { get; }
    }

    /// <summary>
    /// Represents an abstract member which has been added to an abstract type, which may cause externally derived types to not compile.
    /// </summary>
    public sealed class AddedAbstractMember : BreakingChangeBase
    {
        internal AddedAbstractMember(MemberDataBase newMember)
            : base(null, newMember, null, BreakingChangeKind.AddedAbstractMember)
        {
            NewMember = newMember;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Added a new abstract {0} {1} which will cause derived classes to not compile.",
                FormatItem.MemberKind(NewMember),
                FormatItem.MemberName(NewMember, StyleFlags.Bold));

        /// <summary>
        /// Gets the abstract member which has been added.
        /// </summary>
        public MemberDataBase NewMember { get; }
    }

    /// <summary>
    /// Represents an interface (with at least one member) which has been added to the base type list of an existing interface,
    /// which may cause implementors of the existing interface to not compile.
    /// </summary>
    public sealed class AddedBaseInterface : BreakingChangeBase
    {
        internal AddedBaseInterface(TypeDefinitionData oldType, TypeDefinitionData newType, DeclaringTypeData newInterfaceType)
            : base(oldType, newType, newInterfaceType, BreakingChangeKind.AddedBaseInterface)
        {
            OldType = oldType;
            NewType = newType;
            NewInterfaceType = newInterfaceType;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Added a new base interface {1} to {0} which will cause implementing types to not compile.",
                FormatItem.MemberName(NewType, StyleFlags.Bold),
                FormatItem.MemberName(NewInterfaceType, StyleFlags.Italics));

        /// <summary>
        /// Gets the older version of the existing interface.
        /// </summary>
        public TypeDefinitionData OldType { get; }

        /// <summary>
        /// Gets the newer version of the existing interface.
        /// </summary>
        public TypeDefinitionData NewType { get; }

        /// <summary>
        /// Gets the interface which has been added to the base type list of the existing interface.
        /// </summary>
        public DeclaringTypeData NewInterfaceType { get; }
    }

    /// <summary>
    /// Represents an member which has been added to an interface type, which may cause externally implementing types to not compile.
    /// </summary>
    public sealed class AddedInterfaceMember : BreakingChangeBase
    {
        internal AddedInterfaceMember(MemberDataBase newMember)
            : base(null, newMember, null, BreakingChangeKind.AddedInterfaceMember)
        {
            NewMember = newMember;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Added a new interface {0} {1} which will cause implementing types to not compile.",
                FormatItem.MemberKind(NewMember),
                FormatItem.MemberName(NewMember, StyleFlags.Bold));

        /// <summary>
        /// Gets the member which has been added.
        /// </summary>
        public MemberDataBase NewMember { get; }
    }

    /// <summary>
    /// Represents the change of a member or type's accessibility from public to protected, which will cause usages of it outside
    /// derived types to not compile.
    /// </summary>
    public sealed class ChangedAccessibilityFromPublicToProtected : BreakingChangeBase
    {
        internal ChangedAccessibilityFromPublicToProtected(MemberDataBase oldMember, MemberDataBase newMember)
            : base(oldMember, newMember, null, BreakingChangeKind.ChangedAccessibilityFromPublicToProtected)
        {
            OldMember = oldMember;
            NewMember = newMember;

        }

        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed accessibility of {0} from public to protected which may cause code to not compile.",
                FormatItem.MemberName(NewMember, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the member or type.
        /// </summary>
        public MemberDataBase OldMember { get; }

        /// <summary>
        /// Gets the newer version of the member or type.
        /// </summary>
        public MemberDataBase NewMember { get; }
    }

    /// <summary>
    /// Represents the change of the non-abstract sealed class to abstract, which will cause instantiations of the type to not compile.
    /// </summary>
    public sealed class ChangedClassToAbstract : BreakingChangeBase
    {
        internal ChangedClassToAbstract(TypeDefinitionData oldType, TypeDefinitionData newType)
            : base(oldType, newType, null, BreakingChangeKind.ChangedClassToAbstract)
        {
            OldType = oldType;
            NewType = newType;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed non-abstract sealed class {0} to abstract which will cause instantiations of the sealed class to not compile.",
                FormatItem.MemberName(NewType, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the class.
        /// </summary>
        public TypeDefinitionData OldType { get; }

        /// <summary>
        /// Gets the newer version of the class.
        /// </summary>
        public TypeDefinitionData NewType { get; }
    }

    /// <summary>
    /// Represents the change of a read-write field to read-only, which will cause assignments to the field to not compile.
    /// </summary>
    public sealed class ChangedFieldToReadOnly : BreakingChangeBase
    {
        internal ChangedFieldToReadOnly(FieldData oldField, FieldData newField)
            : base(oldField, newField, null, BreakingChangeKind.ChangedFieldToReadOnly)
        {
            OldField = oldField;
            NewField = newField;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed read-write field {0} to read-only which will cause writes to the field to not compile.",
                FormatItem.MemberName(NewField, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the field.
        /// </summary>
        public FieldData OldField { get; }

        /// <summary>
        /// Gets the newer version of the field.
        /// </summary>
        public FieldData NewField { get; }
    }

    /// <summary>
    /// Represents the change of the sealed class to static, which will cause instantiations of the type to not compile.
    /// </summary>
    public sealed class ChangedClassToStatic : BreakingChangeBase
    {
        internal ChangedClassToStatic(TypeDefinitionData oldType, TypeDefinitionData newType)
            : base(oldType, newType, null, BreakingChangeKind.ChangedClassToStatic)
        {
            OldType = oldType;
            NewType = newType;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed non-static sealed class {0} to static which will cause instantiations of the sealed class to not compile.",
                FormatItem.MemberName(NewType, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the class.
        /// </summary>
        public TypeDefinitionData OldType { get; }

        /// <summary>
        /// Gets the newer version of the class.
        /// </summary>
        public TypeDefinitionData NewType { get; }
    }

    /// <summary>
    /// Represents the change of the constraints on a generic type parameter, which may cause constructions of the generic entity
    /// to not compile.
    /// </summary>
    public sealed class ChangedGenericTypeParameterConstraints : BreakingChangeBase
    {
        internal ChangedGenericTypeParameterConstraints(GenericTypeParameterData oldGenericParameter, GenericTypeParameterData newGenericParameter)
            : base(oldGenericParameter, newGenericParameter, null, BreakingChangeKind.ChangedGenericTypeParameterConstraints)
        {
            OldGenericParameter = oldGenericParameter;
            NewGenericParameter = newGenericParameter;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed constraints for the generic type parameter {0} in {1} {2} which may cause constructions of the entity to not compile.",
                FormatItem.MemberName(NewGenericParameter, StyleFlags.Italics),
                FormatItem.MemberKind(NewGenericParameter.GenericDeclaringMember),
                FormatItem.MemberName(NewGenericParameter.GenericDeclaringMember, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the generic type parameter.
        /// </summary>
        public GenericTypeParameterData OldGenericParameter { get; }

        /// <summary>
        /// Gets the newer version of the generic type parameter.
        /// </summary>
        public GenericTypeParameterData NewGenericParameter { get; }
    }

    /// <summary>
    /// Represents the removal or change of the 'in' or 'out' variance modifier on a generic type parameter's definition, which may 
    /// cause contra- or co-variant conversions of the declaring generic type to not compile.
    /// </summary>
    public sealed class ChangedGenericTypeParameterVariance : BreakingChangeBase
    {
        internal ChangedGenericTypeParameterVariance(GenericTypeParameterData oldGenericParameter, GenericTypeParameterData newGenericParameter)
            : base(oldGenericParameter, newGenericParameter, null, BreakingChangeKind.ChangedGenericTypeParameterVariance)
        {
            OldGenericParameter = oldGenericParameter;
            NewGenericParameter = newGenericParameter;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed variance (in or out modifier) for the generic type parameter {0} in {1} {2} which may cause implicit conversions of the {1} to not compile.",
                FormatItem.MemberName(NewGenericParameter, StyleFlags.Italics),
                FormatItem.MemberKind(NewGenericParameter.GenericDeclaringMember),
                FormatItem.MemberName(NewGenericParameter.GenericDeclaringMember, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the generic type parameter.
        /// </summary>
        public GenericTypeParameterData OldGenericParameter { get; }

        /// <summary>
        /// Gets the newer version of the generic type parameter.
        /// </summary>
        public GenericTypeParameterData NewGenericParameter { get; }
    }

    /// <summary>
    /// Represents the change of a non-abstract member to abstract, which may cause externally derived types to not compile.
    /// </summary>
    public sealed class ChangedMemberToAbstract : BreakingChangeBase
    {
        internal ChangedMemberToAbstract(MemberDataBase oldMember, MemberDataBase newMember)
            : base(oldMember, newMember, null, BreakingChangeKind.ChangedMemberToAbstract)
        {
            OldMember = oldMember;
            NewMember = newMember;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed non-abstract {0} {1} to abstract which will cause derived classes not overriding the {0} to not compile.",
                FormatItem.MemberKind(NewMember),
                FormatItem.MemberName(NewMember, StyleFlags.Bold));

        /// <summary>
        /// Gets the older definition of the member, which is not abstract.
        /// </summary>
        public MemberDataBase OldMember { get; }

        /// <summary>
        /// Gets the newer definition of the member, which is abstract.
        /// </summary>
        public MemberDataBase NewMember { get; }
    }

    /// <summary>
    /// Represents the change of a virtual member to non-virtual, which will cause overrides of the member in externally derived types 
    /// to not compile.
    /// </summary>
    public sealed class ChangedMemberToNonVirtual : BreakingChangeBase
    {
        internal ChangedMemberToNonVirtual(MemberDataBase oldMember, MemberDataBase newMember)
            : base(oldMember, newMember, null, BreakingChangeKind.ChangedMemberToNonVirtual)
        {
            OldMember = oldMember;
            NewMember = newMember;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed virtual {0} {1} to non-virtual which will cause derived classes overriding the {0} to not compile.",
                FormatItem.MemberKind(NewMember),
                FormatItem.MemberName(NewMember, StyleFlags.Bold));

        /// <summary>
        /// Gets the older definition of the member, which is not virtual, abstract, or override (without a sealed modifier).
        /// </summary>
        public MemberDataBase OldMember { get; }

        /// <summary>
        /// Gets the newer definition of the member, which is non-virtual.
        /// </summary>
        public MemberDataBase NewMember { get; }
    }

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
            OldTypedItem = oldTypedItem;
            NewTypedItem = newTypedItem;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed the type of {0} {1} in a way which may cause code using the {0} to not compile. Type was changed from {2} to {3}.",
                FormatItem.TypedItemKind(NewTypedItem),
                FormatItem.TypedItemName(NewTypedItem, StyleFlags.Bold),
                FormatItem.TypedItemTypeName(OldTypedItem, StyleFlags.Italics),
                FormatItem.TypedItemTypeName(NewTypedItem, StyleFlags.Italics));

        /// <summary>
        /// Gets the older definition of the member.
        /// </summary>
        public ITypedItem OldTypedItem { get; }

        /// <summary>
        /// Gets the newer definition of the member.
        /// </summary>
        public ITypedItem NewTypedItem { get; }
    }

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
            OldParameterizedItem = oldParameterizedItem;
            NewParameterizedItem = newParameterizedItem;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed the parameter count of {0} in a way which may cause invocations to not compile. Previous declaration was {1}.",
                FormatItem.ParameterizedItemName(NewParameterizedItem, StyleFlags.Bold),
                FormatItem.ParameterizedItemName(OldParameterizedItem, StyleFlags.Italics));

        /// <summary>
        /// Gets the older version of the method, indexer, or delegate owning the parameters.
        /// </summary>
        public IParameterizedItem OldParameterizedItem { get; }

        /// <summary>
        /// Gets the newer version of the method, indexer, or delegate owning the parameters.
        /// </summary>
        public IParameterizedItem NewParameterizedItem { get; }
    }

    /// <summary>
    /// Represents the change of a parameter's default value, which may cause a behavioral change in an external invocation.
    /// </summary>
    public sealed class ChangedParameterDefaultValue : BreakingChangeBase
    {
        internal ChangedParameterDefaultValue(ParameterData oldParameter, ParameterData newParameter, IParameterizedItem newParameterizedItem)
            : base(oldParameter, newParameter, (MetadataItemBase)newParameterizedItem, BreakingChangeKind.ChangedParameterDefaultValue)
        {
            OldParameter = oldParameter;
            NewParameter = newParameter;
            NewParameterizedItem = newParameterizedItem;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed default value of parameter '{0}' in {1} which may cause an unintentional behavioral change in code. The value was changed from '{2}' to '{3}'.",
                FormatItem.ParameterName(NewParameter, StyleFlags.Italics),
                FormatItem.ParameterizedItemName(NewParameterizedItem, StyleFlags.Bold),
                FormatItem.DefaultParameterValue(OldParameter, StyleFlags.Italics),
                FormatItem.DefaultParameterValue(NewParameter, StyleFlags.Italics));

        /// <summary>
        /// Gets the older version of the parameter.
        /// </summary>
        public ParameterData OldParameter { get; }

        /// <summary>
        /// Gets the older version of the parameter.
        /// </summary>
        public ParameterData NewParameter { get; }

        /// <summary>
        /// Gets the newer version of the method, indexer, or delegate which defines the parameter.
        /// </summary>
        public IParameterizedItem NewParameterizedItem { get; }
    }

    /// <summary>
    /// Represents the addition, removal, or change of a parameter's 'ref' or 'out' modifier, which will cause external invocations to 
    /// not compile.
    /// </summary>
    public sealed class ChangedParameterModifier : BreakingChangeBase
    {
        internal ChangedParameterModifier(ParameterData oldParameter, ParameterData newParameter, IParameterizedItem newParameterizedItem)
            : base(oldParameter, newParameter, (MetadataItemBase)newParameterizedItem, BreakingChangeKind.ChangedParameterModifier)
        {
            OldParameter = oldParameter;
            NewParameter = newParameter;
            NewParameterizedItem = newParameterizedItem;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed the ref or out modifier of parameter '{0}' in {1} which will cause invocations to not compile.",
                FormatItem.ParameterName(NewParameter, StyleFlags.Italics),
                FormatItem.ParameterizedItemName(NewParameterizedItem, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the parameter.
        /// </summary>
        public ParameterData OldParameter { get; }

        /// <summary>
        /// Gets the older version of the parameter.
        /// </summary>
        public ParameterData NewParameter { get; }

        /// <summary>
        /// Gets the newer version of the method, indexer, or delegate which defines the parameter.
        /// </summary>
        public IParameterizedItem NewParameterizedItem { get; }
    }

    /// <summary>
    /// Represents the change of a parameter's name, which will cause a named argument in an external invocation to not compile.
    /// </summary>
    public sealed class ChangedParameterName : BreakingChangeBase
    {
        internal ChangedParameterName(ParameterData oldParameter, ParameterData newParameter, IParameterizedItem newParameterizedItem)
            : base(oldParameter, newParameter, (MetadataItemBase)newParameterizedItem, BreakingChangeKind.ChangedParameterName)
        {
            OldParameter = oldParameter;
            NewParameter = newParameter;
            NewParameterizedItem = newParameterizedItem;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed the name of a parameter from '{0}' to '{1}' in {2} which will cause named arguments in invocations to not compile.",
                FormatItem.ParameterName(OldParameter, StyleFlags.Italics),
                FormatItem.ParameterName(NewParameter, StyleFlags.Italics),
                FormatItem.ParameterizedItemName(NewParameterizedItem, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the parameter.
        /// </summary>
        public ParameterData OldParameter { get; }

        /// <summary>
        /// Gets the older version of the parameter.
        /// </summary>
        public ParameterData NewParameter { get; }

        /// <summary>
        /// Gets the newer version of the method, indexer, or delegate which defines the parameter.
        /// </summary>
        public IParameterizedItem NewParameterizedItem { get; }
    }

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
            OldParameter = oldParameter;
            NewParameter = newParameter;
            NewParameterizedItem = newParameterizedItem;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed the type of parameter '{0}' in {1} in a way which may cause invocations to not compile. Type was changed from {2} to {3}.",
                FormatItem.ParameterName(NewParameter, StyleFlags.Italics),
                FormatItem.ParameterizedItemName(NewParameterizedItem, StyleFlags.Bold),
                FormatItem.TypedItemTypeName(OldParameter, StyleFlags.Italics),
                FormatItem.TypedItemTypeName(NewParameter, StyleFlags.Italics));

        /// <summary>
        /// Gets the older version of the parameter.
        /// </summary>
        public ParameterData OldParameter { get; }

        /// <summary>
        /// Gets the older version of the parameter.
        /// </summary>
        public ParameterData NewParameter { get; }

        /// <summary>
        /// Gets the newer version of the method, indexer, or delegate which defines the parameter.
        /// </summary>
        public IParameterizedItem NewParameterizedItem { get; }
    }

    /// <summary>
    /// Represents the removal or addition of the static modifier on an event, field, property, or method, which may cause external usages of
    /// the member to not compile.
    /// </summary>
    public sealed class ChangedStaticOrInstanceStatus : BreakingChangeBase
    {
        internal ChangedStaticOrInstanceStatus(MemberDataBase oldMember, MemberDataBase newMember)
            : base(oldMember, newMember, null, BreakingChangeKind.ChangedStaticOrInstanceStatus)
        {
            OldMember = oldMember;
            NewMember = newMember;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Added or removed the static modifier of {0} {1} which may cause code using the {0} to not compile.",
                FormatItem.MemberKind(NewMember),
                FormatItem.MemberName(NewMember, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the member.
        /// </summary>
        public MemberDataBase OldMember { get; }

        /// <summary>
        /// Gets the newer version of the member.
        /// </summary>
        public MemberDataBase NewMember { get; }
    }

    /// <summary>
    /// Represents the change of a class's base type to something not derived from the original base type, which may cause external usages of
    /// the sealed class to not compile.
    /// </summary>
    public sealed class IncompatibleClassHierarchy : BreakingChangeBase
    {
        internal IncompatibleClassHierarchy(TypeDefinitionData oldType, TypeDefinitionData newType)
            : base(oldType, newType, null, BreakingChangeKind.IncompatibleClassHierarchy)
        {
            OldType = oldType;
            NewType = newType;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed the base sealed class of {0} to something not derived from the previous base sealed class which may cause code using the sealed class to not compile. The base sealed class was changed from {1} to {2}.",
                FormatItem.MemberName(NewType, StyleFlags.Bold),
                FormatItem.MemberName(OldType.BaseType, StyleFlags.Italics),
                FormatItem.MemberName(NewType.BaseType, StyleFlags.Italics));

        /// <summary>
        /// Gets the older version of the class.
        /// </summary>
        public TypeDefinitionData OldType { get; }

        /// <summary>
        /// Gets the newer version of the class.
        /// </summary>
        public TypeDefinitionData NewType { get; }
    }

    /// <summary>
    /// Represents the removal of an assembly, which will cause external usages of types from the assembly to not compile.
    /// </summary>
    public sealed class RemovedAssembly : BreakingChangeBase
    {
        internal RemovedAssembly(AssemblyData oldAssembly)
            : base(oldAssembly, null, null, BreakingChangeKind.RemovedAssembly)
        {
            OldAssembly = oldAssembly;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Removed the equivalent to assembly {0} in the new version, which will cause projects referencing the assembly to not compile.",
                FormatItem.AssemblyName(OldAssembly, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the assembly.
        /// </summary>
        public AssemblyData OldAssembly { get; }
    }

    /// <summary>
    /// Represents the removal of the 'this' parameter modifier on the first parameter of an extension method, which may cause external 
    /// invocations of the method to not compile.
    /// </summary>
    public sealed class RemovedExtensionMethodModifier : BreakingChangeBase
    {
        internal RemovedExtensionMethodModifier(MethodData oldMethod, MethodData newMethod)
            : base(oldMethod, newMethod, null, BreakingChangeKind.RemovedExtensionMethodModifier)
        {
            OldMethod = oldMethod;
            NewMethod = newMethod;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Removed the 'this' modifier from the first parameter of {0} which will cause code using the method as an extension method to not compile.",
                FormatItem.MemberName(NewMethod, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the method.
        /// </summary>
        public MethodData OldMethod { get; }

        /// <summary>
        /// Gets the newer version of the method.
        /// </summary>
        public MethodData NewMethod { get; }
    }

    /// <summary>
    /// Represents the removal of an interface from a types implemented interfaces list, which may cause external usages of the type to
    /// not compile.
    /// </summary>
    public sealed class RemovedImplementedInterface : BreakingChangeBase
    {
        internal RemovedImplementedInterface(TypeDefinitionData oldType, TypeDefinitionData newType, DeclaringTypeData oldInterfaceType)
            : base(oldType, newType, oldInterfaceType, BreakingChangeKind.RemovedImplementedInterface)
        {
            OldType = oldType;
            NewType = newType;
            OldInterfaceType = oldInterfaceType;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Removed implementation of interface {0} from {1} which may cause code using the {2} to not compile.",
                FormatItem.MemberName(OldInterfaceType, StyleFlags.Italics),
                FormatItem.MemberName(NewType, StyleFlags.Bold),
                FormatItem.MemberKind(NewType));

        /// <summary>
        /// Gets the older version of the type.
        /// </summary>
        public TypeDefinitionData OldType { get; }

        /// <summary>
        /// Gets the newer version of the type.
        /// </summary>
        public TypeDefinitionData NewType { get; }

        /// <summary>
        /// Gets the older version of the interface which was implemented on the type.
        /// </summary>
        public DeclaringTypeData OldInterfaceType { get; }
    }

    /// <summary>
    /// Represents the removal or rename of a member from a type, which will cause external usages of the member to not compile.
    /// </summary>
    public sealed class RemovedMember : BreakingChangeBase
    {
        internal RemovedMember(MemberDataBase oldMember, TypeDefinitionData newType)
            : base(oldMember, null, newType, BreakingChangeKind.RemovedMember)
        {
            NewType = newType;
            OldMember = oldMember;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Removed {0} {1} which will cause code using the {0} to not compile.",
                FormatItem.MemberKind(OldMember),
                FormatItem.MemberName(OldMember, StyleFlags.Bold));

        /// <summary>
        /// Gets the newer version of the type, which no longer defines the member.
        /// </summary>
        public TypeDefinitionData NewType { get; }

        /// <summary>
        /// Gets the older version of the member.
        /// </summary>
        public MemberDataBase OldMember { get; }
    }

    /// <summary>
    /// Represents the removal of an override of an abstract member, which may cause externally derived types not also overriding the 
    /// member to not compile.
    /// </summary>
    public sealed class RemovedOverrideOfAbstractMember : BreakingChangeBase
    {
        internal RemovedOverrideOfAbstractMember(MemberDataBase oldMemberOverride, TypeDefinitionData newType)
            : base(oldMemberOverride, null, newType, BreakingChangeKind.RemovedOverrideOfAbstractMember)
        {
            NewType = newType;
            OldMemberOverride = oldMemberOverride;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Removed override of abstract {0} {1} in {2} which may derived classes to not compile.",
                FormatItem.MemberKind(OldMemberOverride),
                FormatItem.MemberName(OldMemberOverride, StyleFlags.Italics),
                FormatItem.MemberName(NewType, StyleFlags.Bold));

        /// <summary>
        /// Gets the newer version of the type, which no longer defines the override.
        /// </summary>
        public TypeDefinitionData NewType { get; }

        /// <summary>
        /// Gets the older version of the member override.
        /// </summary>
        public MemberDataBase OldMemberOverride { get; }
    }

    /// <summary>
    /// Represents the removal (or hiding) of the get and/or set accessor from a property or indexer, which may cause external usages 
    /// of the member to not compile.
    /// </summary>
    public sealed class RemovedPropertyAccessors : BreakingChangeBase
    {
        internal RemovedPropertyAccessors(PropertyData oldProperty, PropertyData newProperty)
            : base(oldProperty, newProperty, null, BreakingChangeKind.RemovedPropertyAccessors)
        {
            OldProperty = oldProperty;
            NewProperty = newProperty;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Removed or changed the visibility of the get or set accessor of {0} {1} which may code using the {0} to not compile.",
                FormatItem.MemberKind(NewProperty),
                FormatItem.MemberName(NewProperty, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the property or indexer.
        /// </summary>
        public PropertyData OldProperty { get; }

        /// <summary>
        /// Gets the newer version of the property or indexer.
        /// </summary>
        public PropertyData NewProperty { get; }
    }

    /// <summary>
    /// Removed or renamed a non-nested type declaration, which will cause external usages of the type to not compile.
    /// </summary>
    public sealed class RemovedRootType : BreakingChangeBase
    {
        internal RemovedRootType(TypeDefinitionData oldType)
            : base(oldType, null, null, BreakingChangeKind.RemovedRootType) =>
            OldType = oldType;

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Removed {0} {1} which will cause code using the {0} to not compile.",
                FormatItem.MemberKind(OldType),
                FormatItem.MemberName(OldType, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the type.
        /// </summary>
        public TypeDefinitionData OldType { get; }
    }

    /// <summary>
    /// Represents the addition of the 'sealed' keyword to a sealed class declaration, which will cause externally derived classes to not compile.
    /// </summary>
    public sealed class SealedClass : BreakingChangeBase
    {
        internal SealedClass(TypeDefinitionData oldType, TypeDefinitionData newType)
            : base(oldType, newType, null, BreakingChangeKind.SealedClass)
        {
            OldType = oldType;
            NewType = newType;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed sealed class {0} from unsealed to sealed which will cause derived classes to not compile.",
                FormatItem.MemberName(NewType, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the sealed class declaration.
        /// </summary>
        public TypeDefinitionData OldType { get; }

        /// <summary>
        /// Gets the newer version of the sealed class declaration.
        /// </summary>
        public TypeDefinitionData NewType { get; }
    }

    /// <summary>
    /// Represents the addition of the 'sealed' keyword to a member override, which will cause externally derived classes also overriding 
    /// the member to not compile.
    /// </summary>
    public sealed class SealedMember : BreakingChangeBase
    {
        internal SealedMember(MemberDataBase oldMember, MemberDataBase newMember)
            : base(oldMember, newMember, null, BreakingChangeKind.SealedMember)
        {
            OldMember = oldMember;
            NewMember = newMember;
        }

        /// <inheritdoc/>
        public override void FormatMessage(IBreakingChangeFormatter formatter) =>
            formatter.AppendFormat("Changed {0} {1} from unsealed to sealed which will cause derived classes overriding the {0} to not compile.",
                FormatItem.MemberKind(NewMember),
                FormatItem.MemberName(NewMember, StyleFlags.Bold));

        /// <summary>
        /// Gets the older version of the member.
        /// </summary>
        public MemberDataBase OldMember { get; }

        /// <summary>
        /// Gets the newer version of the member.
        /// </summary>
        public MemberDataBase NewMember { get; }
    }
}

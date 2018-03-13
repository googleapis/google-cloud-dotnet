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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.BreakingChanges
{
	/// <summary>
	/// Represents the various kinds of breaking changes that can be detected.
	/// </summary>
	public enum BreakingChangeKind
	{
		/// <summary>
		/// Represents an abstract member which has been added to an abstract type, which may cause externally derived types to not compile.
		/// </summary>
		AddedAbstractMember,

		/// <summary>
		/// Represents an interface (with at least one member) which has been added to the base type list of an existing interface,
		/// which may cause implementors of the existing interface to not compile.
		/// </summary>
		AddedBaseInterface,

		/// <summary>
		/// Represents an member which has been added to an interface type, which may cause externally implementing types to not compile.
		/// </summary>
		AddedInterfaceMember,

		/// <summary>
		/// Represents the changes of a member or type's accessibility from public to protected, which will cause usages of it outside
		/// derived types to not compile.
		/// </summary>
		ChangedAccessibilityFromPublicToProtected,

		/// <summary>
		/// Represents the change of the non-abstract class to abstract, which will cause instantiations of the type to not compile.
		/// </summary>
		ChangedClassToAbstract,

		/// <summary>
		/// Represents the change of a read-write field to read-only, which will cause assignments to the field to not compile.
		/// </summary>
		ChangedFieldToReadOnly,

		/// <summary>
		/// Represents the change of the class to static, which will cause instantiations of the type to not compile.
		/// </summary>
		ChangedClassToStatic,

		/// <summary>
		/// Represents the change of the constraints on a generic type parameter, which may cause constructions of the generic entity
		/// to not compile.
		/// </summary>
		ChangedGenericTypeParameterConstraints,

		/// <summary>
		/// Represents the removal or change of the 'in' or 'out' variance modifier on a generic type parameter's definition, which may 
		/// cause contra- or co-variant conversions of the declaring generic type to not compile.
		/// </summary>
		ChangedGenericTypeParameterVariance,

		/// <summary>
		/// Represents the change of a non-abstract member to abstract, which may cause externally derived types to not compile.
		/// </summary>
		ChangedMemberToAbstract,

		/// <summary>
		/// Represents the change of a virtual member to non-virtual, which will cause overrides of the member in externally derived types 
		/// to not compile.
		/// </summary>
		ChangedMemberToNonVirtual,

		/// <summary>
		/// Represents the change of a member type to something which will cause usages of it in external code to not compile. For out-only
		/// types, including return types from methods and delegates as well as the types of constants and read-only fields, properties, and
		/// indexers, this is a type not implicitly assignable to the original type. For in-only types, including the types or write-only
		/// properties and indexers, this is a type not implicitly assignable from the original type. For in and out types, such as the types
		/// of read/write fields, properties, and indexers, this is any type other than the original type.
		/// </summary>
		ChangedMemberType,

		/// <summary>
		/// Represents the change of the required or total parameter count of a method, indexer, or delegate in a way which could cause 
		/// external invocations to not compile. This can represent an increase in the required parameter count, perhaps by removing the a 
		/// parameter's default value, which will cause invocations not passing in all parameters to not compile. It can also represent a
		/// decrease in the total parameter count, which will cause invocations passing in all parameters to not compile.
		/// </summary>
		ChangedParameterCount,
		
		/// <summary>
		/// Represents the change of a parameter's default value, which may cause a behavioral change in an external invocation.
		/// </summary>
		ChangedParameterDefaultValue,

		/// <summary>
		/// Represents the addition, removal, or change of a parameter's 'ref' or 'out' modifier, which will cause external invocations to 
		/// not compile.
		/// </summary>
		ChangedParameterModifier,

		/// <summary>
		/// Represents the change of a parameter's name, which will cause a named argument in an external invocation to not compile.
		/// </summary>
		ChangedParameterName,

		/// <summary>
		/// Represents the change of a parameter's type to something which will cause external invocations to not compile. For normal parameters, 
		/// this is a type not implicitly assignable from the original type. For 'ref' and 'out' parameters, this is any type other than the 
		/// original type.
		/// </summary>
		ChangedParameterType,

		/// <summary>
		/// Represents the removal or addition of the static modifier on an event, field, property, or method, which may cause external usages of
		/// the member to not compile.
		/// </summary>
		ChangedStaticOrInstanceStatus,

		/// <summary>
		/// Represents the change of a class's base type to something not derived from the original base type, which may cause external usages of
		/// the class to not compile.
		/// </summary>
		IncompatibleClassHierarchy,

		/// <summary>
		/// Represents the removal of an assembly, which will cause external usages of types from the assembly to not compile.
		/// </summary>
		RemovedAssembly,

		/// <summary>
		/// Represents the removal of the 'this' parameter modifier on the first parameter of an extension method, which may cause external 
		/// invocations of the method to not compile.
		/// </summary>
		RemovedExtensionMethodModifier,

		/// <summary>
		/// Represents the removal of an interface from a types implemented interfaces list, which may cause external usages of the type to
		/// not compile.
		/// </summary>
		RemovedImplementedInterface,

		/// <summary>
		/// Represents the removal or rename of a member from a type, which will cause external usages of the member to not compile.
		/// </summary>
		RemovedMember,

		/// <summary>
		/// Represents the removal of an override of an abstract member, which may cause externally derived types not also overriding the 
		/// member to not compile.
		/// </summary>
		RemovedOverrideOfAbstractMember,

		/// <summary>
		/// Represents the removal (or hiding) of the get and/or set accessor from a property or indexer, which may cause external usages 
		/// of the member to not compile.
		/// </summary>
		RemovedPropertyAccessors,

		/// <summary>
		/// Represents the removal or rename of a non-nested type declaration, which will cause external usages of the type to not compile.
		/// </summary>
		RemovedRootType,

		/// <summary>
		/// Represents the addition of the 'sealed' keyword to a class declaration, which will cause externally derived classes to not compile.
		/// </summary>
		SealedClass,

		/// <summary>
		/// Represents the addition of the 'sealed' keyword to a member override, which will cause externally derived classes also overriding 
		/// the member to not compile.
		/// </summary>
		SealedMember,
	}

	/// <summary>
	/// Represents the various styling flags that can be present in a rich text formatting of breaking change messages.
	/// </summary>
	[Flags]
	public enum StyleFlags
	{
		/// <summary>
		/// The text has no rich formatting.
		/// </summary>
		Normal = 0,

		/// <summary>
		/// The text should be bold.
		/// </summary>
		Bold = 1 << 0,

		/// <summary>
		/// The text should be italic.
		/// </summary>
		Italics = 1 << 1,
	}
}

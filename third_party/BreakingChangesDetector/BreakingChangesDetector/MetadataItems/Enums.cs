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

namespace BreakingChangesDetector.MetadataItems
{
	/// <summary>
	/// Represents the various externally visible accessibilities available for members.
	/// </summary>
	public enum MemberAccessibility : byte
	{
		// Note: these are ordered so we can compare them: Protected < Public

		/// <summary>
		/// A member is publicly visible to derived types in external assemblies.
		/// </summary>
		Protected = 0,

		/// <summary>
		/// A member is publicly visible to external assemblies.
		/// </summary>
		Public = 1,
	}

	/// <summary>
	/// Represents the various boolean options available on members.
	/// </summary>
	[Flags]
	public enum MemberFlags : byte
	{
		/// <summary>
		/// No options are specified.
		/// </summary>
		None = 0,

		/// <summary>
		/// The member is defined with the 'static' keyword.
		/// </summary>
		Static = 1 << 0,

		/// <summary>
		/// The member is defined with the 'abstract' keyword.
		/// </summary>
		Abstract = 1 << 1,

		/// <summary>
		/// The member is defined with the 'virtual' keyword.
		/// </summary>
		Virtual = 1 << 2,

		/// <summary>
		/// The member is defined with the 'override' keyword.
		/// </summary>
		Override = 1 << 3,

		/// <summary>
		/// The member is defined with the 'sealed' keyword.
		/// </summary>
		Sealed = 1 << 4,
	}

	/// <summary>
	/// Represents the various kinds of metadata items represents by individual classes.
	/// </summary>
	[Flags]
	public enum MetadataItemKinds : ushort
	{
		/// <summary>
		/// An assembly, represented by the <see cref="AssemblyData"/> class.
		/// </summary>
		Assembly = 1 << 0,

		/// <summary>
		/// A constant, represented by the <see cref="ConstantData"/> class.
		/// </summary>
		Constant = 1 << 1,

		/// <summary>
		/// A constructor, represented by the <see cref="ConstructorData"/> class.
		/// </summary>
		Constructor = 1 << 2,

		/// <summary>
		/// An event, represented by the <see cref="EventData"/> class.
		/// </summary>
		Event = 1 << 3,

		/// <summary>
		/// A field, represented by the <see cref="FieldData"/> class.
		/// </summary>
		Field = 1 << 4,

		/// <summary>
		/// A generic type parameter, represented by the <see cref="GenericTypeParameterData"/> class.
		/// </summary>
		GenericTypeParameter = 1 << 5,

		/// <summary>
		/// An indexer, represented by the <see cref="IndexerData"/> class.
		/// </summary>
		Indexer = 1 << 6,

		/// <summary>
		/// A method, represented by the <see cref="MethodData"/> class.
		/// </summary>
		Method = 1 << 7,

		/// <summary>
		/// An operator, represented by the <see cref="OperatorData"/> class.
		/// </summary>
		Operator = 1 << 8,

		/// <summary>
		/// A parameter, represented by the <see cref="ParameterData"/> class.
		/// </summary>
		Parameter = 1 << 9,

		/// <summary>
		/// A property, represented by the <see cref="PropertyData"/> class.
		/// </summary>
		Property = 1 << 10,

		/// <summary>
		/// A type definition, represented by the <see cref="TypeDefinitionData"/> class.
		/// </summary>
		TypeDefinition = 1 << 11,

		/// <summary>
		/// A constructed generic type, represented by the <see cref="ConstructedGenericTypeData"/> class.
		/// </summary>
		ConstructedGenericType = 1 << 12,

		/// <summary>
		/// A pointer type, represented by the <see cref="PointerTypeData"/> class.
		/// </summary>
		PointerType = 1 << 13,

		/// <summary>
		/// A array type, represented by the <see cref="ArrayTypeData"/> class.
		/// </summary>
		ArrayType = 1 << 14,
	}

	/// <summary>
	/// Represents the various modifiers which can be placed on parameters.
	/// </summary>
	public enum ParameterModifier : byte
	{
		/// <summary>
		/// No modifier is specified.
		/// </summary>
		None,

		/// <summary>
		/// The 'ref' modifier is specified.
		/// </summary>
		Ref,

		/// <summary>
		/// The 'out' modifier is specified.
		/// </summary>
		Out,
	}

	/// <summary>
	/// Represents the various boolean options available on types.
	/// </summary>
	[Flags]
	internal enum TypeDefinitionFlags : byte
	{
		/// <summary>
		/// No options are specified.
		/// </summary>
		None = 0,

		/// <summary>
		/// The type is an extension class: a static non-nested class with at least one extension method.
		/// </summary>
		ExtensionsClass = 1 << 1,

		/// <summary>
		/// The type can be used as a base type for other types.
		/// </summary>
		CanBeInherited = 1 << 2,

		/// <summary>
		/// The type is an enum definition with the Flags attribute applied.
		/// </summary>
		FlagsEnum = 1 << 3,
	}

	/// <summary>
	/// Represents the various kinds of types which can be defined.
	/// </summary>
	public enum TypeKind : byte
	{
		/// <summary>
		/// A class type
		/// </summary>
		Class,

		/// <summary>
		/// A struct type
		/// </summary>
		Struct,

		/// <summary>
		/// An interface type
		/// </summary>
		Interface,

		/// <summary>
		/// A enum type
		/// </summary>
		Enum,

		/// <summary>
		/// A delegate type
		/// </summary>
		Delegate
	}
}

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

using BreakingChangesDetector.MetadataItems;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.BreakingChanges.Formatting
{
	/// <summary>
	/// Represents an entity that can be represented as text with specific formatting.
	/// </summary>
	public class FormatItem
	{
		#region Constructor

		private FormatItem(string text, StyleFlags style)
		{
			this.Style = style;
			this.Text = text;
		}

		#endregion // Constructor

		#region Base Class Overrides

		/// <summary>
		/// Gets the string representation of the <see cref="FormatItem"/>.
		/// </summary>
		public override string ToString()
		{
			return this.Text;
		}

		#endregion // Base Class Overrides

		#region Methods

		#region Public Methods

		/// <summary>
		/// Creates a <see cref="FormatItem"/> to represent the display name of an <see cref="AssemblyData"/> with the specified formatting.
		/// </summary>
		public static FormatItem AssemblyName(AssemblyData assembly, StyleFlags style = StyleFlags.Normal)
		{
			return new FormatItem(assembly.DisplayName, style);
		}

		/// <summary>
		/// Creates a <see cref="FormatItem"/> to represent the default value of a <see cref="ParameterData"/> with the specified formatting.
		/// </summary>
		public static FormatItem DefaultParameterValue(ParameterData parameter, StyleFlags style = StyleFlags.Normal)
		{
			return new FormatItem(parameter.GetDefaultValueDisplayText(), style);
		}

		/// <summary>
		/// Creates a <see cref="FormatItem"/> to represent the C# name of a <see cref="MemberDataBase"/> with the specified formatting.
		/// </summary>
		public static FormatItem MemberKind(MemberDataBase member, StyleFlags style = StyleFlags.Normal)
		{
			return new FormatItem(GetItemDescription(member), style);
		}

		/// <summary>
		/// Creates a <see cref="FormatItem"/> to represent the full name of a <see cref="MemberDataBase"/> with the specified formatting.
		/// </summary>
		public static FormatItem MemberName(MemberDataBase member, StyleFlags style = StyleFlags.Normal)
		{
			return new FormatItem(GetFullMemberName(member), style);
		}

		/// <summary>
		/// Creates a <see cref="FormatItem"/> to represent the full name of an entity with parameters with the specified formatting.
		/// </summary>
		public static FormatItem ParameterizedItemName(IParameterizedItem item, StyleFlags style = StyleFlags.Normal)
		{
			return new FormatItem(GetFullMemberName((MemberDataBase)item), style);
		}

		/// <summary>
		/// Creates a <see cref="FormatItem"/> to represent the name of a <see cref="ParameterData"/> with the specified formatting.
		/// </summary>
		public static FormatItem ParameterName(ParameterData parameter, StyleFlags style = StyleFlags.Normal)
		{
			return new FormatItem(parameter.DisplayName, style);
		}

		/// <summary>
		/// Creates a <see cref="FormatItem"/> to represent the C# name of a typed item with the specified formatting.
		/// </summary>
		public static FormatItem TypedItemKind(ITypedItem item, StyleFlags style = StyleFlags.Normal)
		{
			return new FormatItem(GetItemDescription((MetadataItemBase)item), style);
		}

		/// <summary>
		/// Creates a <see cref="FormatItem"/> to represent the full name of a typed item with the specified formatting.
		/// </summary>
		public static FormatItem TypedItemName(ITypedItem item, StyleFlags style = StyleFlags.Normal)
		{
			return new FormatItem(GetFullMemberName((MemberDataBase)item), style);
		}

		/// <summary>
		/// Creates a <see cref="FormatItem"/> to represent the type name of a typed item with the specified formatting.
		/// </summary>
		public static FormatItem TypedItemTypeName(ITypedItem item, StyleFlags style = StyleFlags.Normal)
		{
			return new FormatItem(GetTypeDisplayName(item), style);
		}

		#endregion // Public Methods

		#region Private Methods

		private static string GetFullMemberName(MemberDataBase member)
		{
			if (member.MetadataItemKind == MetadataItemKinds.TypeDefinition)
				return member.DisplayName;

			return member.DeclaringType.DisplayName + "." + member.DisplayName;
		}

		private static string GetItemDescription(MetadataItemBase item)
		{
			switch (item.MetadataItemKind)
			{
				case MetadataItemKinds.Assembly: return "assembly";
				case MetadataItemKinds.Constant: return "constant";
				case MetadataItemKinds.Constructor: return "constructor";
				case MetadataItemKinds.Event: return "event";
				case MetadataItemKinds.Field: return "field";
				case MetadataItemKinds.GenericTypeParameter: return "generic type parameter";
				case MetadataItemKinds.Indexer: return "indexer";
				case MetadataItemKinds.Method: return "method";
				case MetadataItemKinds.Operator: return "operator";
				case MetadataItemKinds.Parameter: return "parameter";
				case MetadataItemKinds.Property: return "property";
				case MetadataItemKinds.TypeDefinition:
					{
						var type = (TypeDefinitionData)item;
						switch (type.TypeKind)
						{
							case TypeKind.Class: return "class";
							case TypeKind.Struct: return "struct";
							case TypeKind.Interface: return "interface";
							case TypeKind.Enum: return "enum";
							case TypeKind.Delegate: return "delegate";
							default:
								Debug.Fail("Unknown TypeKind: " + item.MetadataItemKind);
								return "item";
						}
					}

				default:
					Debug.Fail("Unknown MetadataItemKinds: " + item.MetadataItemKind);
					return "item";
			}
		}

		private static string GetTypeDisplayName(ITypedItem item)
		{
			if (item.IsTypeDynamic)
				return Utilities.DynamicTypeName;

			return item.Type.DisplayName;
		}

		#endregion // Private Methods

		#endregion // Methods

		#region Properties

		/// <summary>
		/// Gets the formatting to use with the item.
		/// </summary>
		public StyleFlags Style { get; private set; }

		/// <summary>
		/// Gets the text to format with the item.
		/// </summary>
		public string Text { get; private set; }

		#endregion // Properties
	}
}

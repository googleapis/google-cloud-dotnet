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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.BreakingChanges.Definitions
{
	internal class ChangedMemberTypeDefinition : BreakingChangeDefinitionBase
	{
		public static readonly ChangedMemberTypeDefinition Instance = new ChangedMemberTypeDefinition();

		private ChangedMemberTypeDefinition() { }

		public override void CompareItems(CompareItemsContext context)
		{
			var oldTypedItem = (ITypedItem)context.OldItem;
			var newTypedItem = (ITypedItem)context.NewItem;
			if (oldTypedItem.Type == null || newTypedItem.Type == null)
				return;

			// Changing from void to non-void is allowed.
			var typeDefinition = oldTypedItem.Type as TypeDefinitionData;
			if (typeDefinition != null &&
				typeDefinition.FullName == Utilities.VoidTypeName &&
				typeDefinition.AssemblyData.Name == Utilities.CommonObjectRuntimeAssemblyName)
				return;

			// If we are comparing two enum members, we know they came from the same type, which is also their return type, so we don't need to check below.
			if (context.OldItem.MetadataItemKind == MetadataItemKinds.Constant &&
				((MemberDataBase)context.OldItem).DeclaringType.TypeKind == TypeKind.Enum)
			{
				return;
			}

			switch (context.OldItem.MetadataItemKind)
			{
				// Read/write fields cannot change type at all because they can be used in out or ref parameters
				case MetadataItemKinds.Field:
					if (((FieldData)context.OldItem).IsReadOnly)
						goto default;

					if (oldTypedItem.IsTypeDynamic != newTypedItem.IsTypeDynamic ||
						oldTypedItem.Type.IsEquivalentToNew(newTypedItem.Type, context.NewAssemblyFamily) == false)
					{
						context.BreakingChanges.Add(new ChangedMemberType(oldTypedItem, newTypedItem));
					}
					break;

				default:
					if (newTypedItem.IsTypeDynamic == false)
					{
						if (oldTypedItem.IsTypeDynamic || oldTypedItem.Type.IsAssignableFromNew(newTypedItem.Type, context.NewAssemblyFamily) == false)
							context.BreakingChanges.Add(new ChangedMemberType(oldTypedItem, newTypedItem));
					}
					break;
			}
		}

		public override BreakingChangeKind BreakingChangeKind
		{
			get { return BreakingChangeKind.ChangedMemberType; }
		}

		public override MetadataItemKinds MembersKindsHandled
		{
			get
			{
				return
					MetadataItemKinds.Constant |
					MetadataItemKinds.Event |
					MetadataItemKinds.Field |
					MetadataItemKinds.Indexer |
					MetadataItemKinds.Method |
					MetadataItemKinds.Operator |
					MetadataItemKinds.Property |
					MetadataItemKinds.TypeDefinition;
			}
		}
	}
}

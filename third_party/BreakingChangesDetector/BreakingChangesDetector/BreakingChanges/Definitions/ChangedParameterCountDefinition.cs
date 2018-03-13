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
	internal class ChangedParameterCountDefinition : BreakingChangeDefinitionBase
	{
		public static readonly ChangedParameterCountDefinition Instance = new ChangedParameterCountDefinition();

		private ChangedParameterCountDefinition() { }

		public override void CompareItems(CompareItemsContext context)
		{
			var oldParameterizedItem = (IParameterizedItem)context.OldItem;
			var newParameterizedItem = (IParameterizedItem)context.NewItem;

			if (oldParameterizedItem.Parameters == null || newParameterizedItem.Parameters == null)
				return;

			// If there are now fewer parameters than before, it could be breaking, because someone could have specified all parameters
			if (newParameterizedItem.Parameters.Count < oldParameterizedItem.Parameters.Count)
			{
				context.BreakingChanges.Add(new ChangedParameterCount(oldParameterizedItem, newParameterizedItem));
				return;
			}

			// If there are now more required parameters than before, it could be breaking, because someone could have specified the minimum 
			// required parameters before, which is no longer valid.
			if (oldParameterizedItem.Parameters.RequiredArgumentCount < newParameterizedItem.Parameters.RequiredArgumentCount)
			{
				context.BreakingChanges.Add(new ChangedParameterCount(oldParameterizedItem, newParameterizedItem));
				return;
			}
		}

		public override BreakingChangeKind BreakingChangeKind
		{
			get { return BreakingChangeKind.ChangedParameterCount; }
		}

		public override MetadataItemKinds MembersKindsHandled
		{
			get
			{
				return
					MetadataItemKinds.TypeDefinition |
					MetadataItemKinds.Method |
					MetadataItemKinds.Indexer |
					MetadataItemKinds.Constructor;
			}
		}
	}
}

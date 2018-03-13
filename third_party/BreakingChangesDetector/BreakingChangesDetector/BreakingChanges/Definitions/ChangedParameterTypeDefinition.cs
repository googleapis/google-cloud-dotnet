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
	internal class ChangedParameterTypeDefinition : BreakingChangeDefinitionBase
	{
		public static readonly ChangedParameterTypeDefinition Instance = new ChangedParameterTypeDefinition();

		private ChangedParameterTypeDefinition() { }

		public override void CompareItems(CompareItemsContext context)
		{
			var oldParameter = (ParameterData)context.OldItem;
			var newParameter = (ParameterData)context.NewItem;

			if (oldParameter.IsTypeDynamic == newParameter.IsTypeDynamic && oldParameter.Type.IsEquivalentToNew(newParameter.Type, context.NewAssemblyFamily))
				return;

			var isBreakingChange = false;

			if (oldParameter.Modifer != ParameterModifier.None)
			{
				isBreakingChange = true;
			}
			else if (newParameter.IsTypeDynamic == false)
			{
				isBreakingChange = (oldParameter.IsTypeDynamic || newParameter.Type.IsAssignableFromOld(oldParameter.Type, context.NewAssemblyFamily) == false);
			}

			if (isBreakingChange)
				context.BreakingChanges.Add(new ChangedParameterType(oldParameter, newParameter, (IParameterizedItem)context.AdditionalInfo));
		}

		public override BreakingChangeKind BreakingChangeKind
		{
			get { return BreakingChangeKind.ChangedParameterType; }
		}

		public override MetadataItemKinds MembersKindsHandled
		{
			get { return MetadataItemKinds.Parameter; }
		}
	}
}

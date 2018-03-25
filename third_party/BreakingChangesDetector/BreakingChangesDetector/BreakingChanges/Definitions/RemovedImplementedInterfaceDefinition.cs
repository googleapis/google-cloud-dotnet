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

using BreakingChangesDetector.MetadataItems;

namespace BreakingChangesDetector.BreakingChanges.Definitions
{
    internal class RemovedImplementedInterfaceDefinition : BreakingChangeDefinitionBase
    {
        public static readonly RemovedImplementedInterfaceDefinition Instance =
            new RemovedImplementedInterfaceDefinition();

        private RemovedImplementedInterfaceDefinition() { }

        public override void CompareItems(CompareItemsContext context)
        {
            var oldType = (TypeDefinitionData)context.OldItem;
            var newType = (TypeDefinitionData)context.NewItem;

            foreach (var oldInterfaceType in oldType.ImplementedInterfaces)
            {
                var hasOldInterfaceEquivalent = false;
                foreach (var newInterfaceType in newType.ImplementedInterfaces)
                {
                    if (oldInterfaceType.IsAssignableFromNew(newInterfaceType, context.NewAssemblyFamily))
                    {
                        hasOldInterfaceEquivalent = true;
                        break;
                    }
                }

                if (hasOldInterfaceEquivalent == false)
                {
                    context.BreakingChanges.Add(new RemovedImplementedInterface(oldType, newType, oldInterfaceType));
                }
            }
        }

        public override BreakingChangeKind BreakingChangeKind =>
            BreakingChangeKind.RemovedImplementedInterface;

        public override MetadataItemKinds MembersKindsHandled =>
            MetadataItemKinds.TypeDefinition;
    }
}

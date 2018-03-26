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
using Microsoft.CodeAnalysis;

namespace BreakingChangesDetector.BreakingChanges.Definitions
{
    internal sealed class RemovedPropertyAccessorsDefinition : BreakingChangeDefinitionBase
    {
        public static readonly RemovedPropertyAccessorsDefinition Instance =
            new RemovedPropertyAccessorsDefinition();

        private RemovedPropertyAccessorsDefinition() { }

        public override void CompareItems(CompareItemsContext context)
        {
            var oldProperty = (PropertyData)context.OldItem;
            var newProperty = (PropertyData)context.NewItem;

            // TODO: What about protected accessors that are made internal/private. This doesn't seem to check for it. Do we handle it somewhere else?
            if ((oldProperty.GetMethodAccessibility != null && newProperty.GetMethodAccessibility == null) ||
                (oldProperty.Accessibility == newProperty.Accessibility && oldProperty.GetMethodAccessibility == Accessibility.Public && newProperty.GetMethodAccessibility != Accessibility.Public))
            {
                context.BreakingChanges.Add(new RemovedPropertyAccessors(oldProperty, newProperty));
                return;
            }

            if ((oldProperty.SetMethodAccessibility != null && newProperty.SetMethodAccessibility == null) ||
                (oldProperty.Accessibility == newProperty.Accessibility && oldProperty.SetMethodAccessibility == Accessibility.Public && newProperty.SetMethodAccessibility != Accessibility.Public))
            {
                context.BreakingChanges.Add(new RemovedPropertyAccessors(oldProperty, newProperty));
            }
        }

        public override BreakingChangeKind BreakingChangeKind =>
            BreakingChangeKind.RemovedPropertyAccessors;

        public override MetadataItemKinds MembersKindsHandled =>
            MetadataItemKinds.Property |
            MetadataItemKinds.Indexer;
    }
}

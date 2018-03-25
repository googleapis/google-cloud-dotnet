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
    internal sealed class ChangedMemberToAbstractDefinition : BreakingChangeDefinitionBase
    {
        public static readonly ChangedMemberToAbstractDefinition Instance =
            new ChangedMemberToAbstractDefinition();

        private ChangedMemberToAbstractDefinition() { }

        public override void CompareItems(CompareItemsContext context)
        {
            var oldMember = (MemberDataBase)context.OldItem;
            var newMember = (MemberDataBase)context.NewItem;
            if (oldMember.IsAbstract == false && newMember.IsAbstract)
            {
                context.BreakingChanges.Add(new ChangedMemberToAbstract(oldMember, newMember));
            }
        }

        public override BreakingChangeKind BreakingChangeKind => BreakingChangeKind.ChangedMemberToAbstract;

        public override MetadataItemKinds MembersKindsHandled =>
            MetadataItemKinds.Event |
            MetadataItemKinds.Indexer |
            MetadataItemKinds.Method |
            MetadataItemKinds.Property;
    }
}

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

using BreakingChangesDetector.BreakingChanges;
using Xunit;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class RemovedPropertyAccessorsTests
    {
        #region PropertyTests

        [Fact]
        public void PropertyTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var PropertyReadOnly = context.GetTypeDefinitionData(typeof(PropertyReadOnly));
            var PropertyReadOnlyPublic = context.GetTypeDefinitionData(typeof(PropertyReadOnlyPublic));
            var PropertyReadWrite = context.GetTypeDefinitionData(typeof(PropertyReadWrite));
            var PropertyWriteOnly = context.GetTypeDefinitionData(typeof(PropertyWriteOnly));
            var PropertyWriteOnlyPublic = context.GetTypeDefinitionData(typeof(PropertyWriteOnlyPublic));

            var breakingChanges = MetadataComparer.CompareTypes(PropertyReadWrite, PropertyReadOnly);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when changing a read/write Property to read-only.");
            AssertX.Equal(BreakingChangeKind.RemovedPropertyAccessors, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(PropertyReadWrite.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(PropertyReadOnly.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyReadWrite, PropertyReadOnlyPublic);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when changing a read/write Property to read-only.");
            AssertX.Equal(BreakingChangeKind.RemovedPropertyAccessors, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(PropertyReadWrite.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(PropertyReadOnlyPublic.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyReadWrite, PropertyWriteOnly);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when changing a read/write Property to write-only.");
            AssertX.Equal(BreakingChangeKind.RemovedPropertyAccessors, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(PropertyReadWrite.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(PropertyWriteOnly.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyReadWrite, PropertyWriteOnlyPublic);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when changing a read/write Property to write-only.");
            AssertX.Equal(BreakingChangeKind.RemovedPropertyAccessors, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(PropertyReadWrite.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(PropertyWriteOnlyPublic.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // PropertyTests

        public class PropertyReadOnly { public int Property { get { return 0; } } }
        public class PropertyReadOnlyPublic { public int Property { get { return 0; } protected set { } } }
        public class PropertyReadWrite { public int Property { get { return 0; } set { } } }
        public class PropertyWriteOnly { public int Property { set { } } }
        public class PropertyWriteOnlyPublic { public int Property { protected get { return 0; } set { } } }
    }
}

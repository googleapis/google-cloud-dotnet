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

using Xunit;
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class AddedInterfaceMemberTests
    {
        #region NestedTypeTests

        [Fact]
        public void NestedTypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var nestedInterfaceWithNoMembers = context.GetTypeDefinitionData(typeof(NestedInterfaceWithNoMembers));
            var nestedInterfaceWithEvent = context.GetTypeDefinitionData(typeof(NestedInterfaceWithEvent));
            var nestedInterfaceWithIndexer = context.GetTypeDefinitionData(typeof(NestedInterfaceWithIndexer));
            var nestedInterfaceWithMethod = context.GetTypeDefinitionData(typeof(NestedInterfaceWithMethod));
            var nestedInterfaceWithProperty = context.GetTypeDefinitionData(typeof(NestedInterfaceWithProperty));

            var breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithNoMembers, nestedInterfaceWithEvent);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
            AssertX.Equal(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Null(breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedInterfaceWithEvent.GetNestedType("Interface").GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithNoMembers, nestedInterfaceWithIndexer);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
            AssertX.Equal(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Null(breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedInterfaceWithIndexer.GetNestedType("Interface").GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithNoMembers, nestedInterfaceWithMethod);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
            AssertX.Equal(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Null(breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedInterfaceWithMethod.GetNestedType("Interface").GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithNoMembers, nestedInterfaceWithProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
            AssertX.Equal(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Null(breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedInterfaceWithProperty.GetNestedType("Interface").GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // NestedTypeTests

        #region TypeTests

        [Fact]
        public void TypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var interfaceWithNoMembers = context.GetTypeDefinitionData(typeof(InterfaceWithNoMembers));
            var interfaceWithEvent = context.GetTypeDefinitionData(typeof(InterfaceWithEvent));
            var interfaceWithIndexer = context.GetTypeDefinitionData(typeof(InterfaceWithIndexer));
            var interfaceWithMethod = context.GetTypeDefinitionData(typeof(InterfaceWithMethod));
            var interfaceWithProperty = context.GetTypeDefinitionData(typeof(InterfaceWithProperty));

            var breakingChanges = MetadataComparer.CompareTypes(interfaceWithNoMembers, interfaceWithEvent);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
            AssertX.Equal(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Null(breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(interfaceWithEvent.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(interfaceWithNoMembers, interfaceWithIndexer);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
            AssertX.Equal(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Null(breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(interfaceWithIndexer.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(interfaceWithNoMembers, interfaceWithMethod);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
            AssertX.Equal(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Null(breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(interfaceWithMethod.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(interfaceWithNoMembers, interfaceWithProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
            AssertX.Equal(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Null(breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(interfaceWithProperty.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // TypeTests
    }
}

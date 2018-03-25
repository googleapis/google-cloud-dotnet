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
    public class RemovedImplementedInterfaceTests
    {
        [Fact]
        public void NestedTypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var nestedClassImplementingBase = context.GetTypeDefinitionData(typeof(NestedClassImplementingBase));
            var nestedClassImplementingDerived = context.GetTypeDefinitionData(typeof(NestedClassImplementingDerived));
            var nestedClassImplementingNothing = context.GetTypeDefinitionData(typeof(NestedClassImplementingNothing));

            var breakingChanges = MetadataComparer.CompareTypes(nestedClassImplementingBase, nestedClassImplementingDerived);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the new type implements a more specialized interface.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassImplementingBase, nestedClassImplementingNothing);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the new type does not implement the same interface.");
            AssertX.Equal(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassImplementingBase.GetMember("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassImplementingNothing.GetMember("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NestedBaseInterface.Interface)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassImplementingDerived, nestedClassImplementingBase);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the new type implements a less specialized interface.");
            AssertX.Equal(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassImplementingDerived.GetMember("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassImplementingBase.GetMember("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NestedDerivedInterface.Interface)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassImplementingDerived, nestedClassImplementingNothing);
            AssertX.Equal(2, breakingChanges.Count, "There should be one breaking change when the new type does not implement the same interface.");
            AssertX.Equal(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassImplementingDerived.GetMember("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassImplementingNothing.GetMember("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NestedDerivedInterface.Interface)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
            AssertX.Equal(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[1].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassImplementingDerived.GetMember("Class"), breakingChanges[1].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassImplementingNothing.GetMember("Class"), breakingChanges[1].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NestedBaseInterface.Interface)), breakingChanges[1].AssociatedData, "The AssociatedData is incorrect.");
        }

        [Fact]
        public void TypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var classImplementingBase = context.GetTypeDefinitionData(typeof(ClassImplementingBase));
            var classImplementingDerived = context.GetTypeDefinitionData(typeof(ClassImplementingDerived));
            var classImplementingNothing = context.GetTypeDefinitionData(typeof(ClassImplementingNothing));

            var breakingChanges = MetadataComparer.CompareTypes(classImplementingBase, classImplementingDerived);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the new type implements a more specialized interface.");

            breakingChanges = MetadataComparer.CompareTypes(classImplementingBase, classImplementingNothing);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the new type does not implement the same interface.");
            AssertX.Equal(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classImplementingBase, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classImplementingNothing, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(BaseInterface)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classImplementingDerived, classImplementingBase);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the new type implements a less specialized interface.");
            AssertX.Equal(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classImplementingDerived, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classImplementingBase, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(DerivedInterface)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classImplementingDerived, classImplementingNothing);
            AssertX.Equal(2, breakingChanges.Count, "There should be one breaking change when the new type does not implement the same interface.");
            AssertX.Equal(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classImplementingDerived, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classImplementingNothing, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(DerivedInterface)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
            AssertX.Equal(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[1].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classImplementingDerived, breakingChanges[1].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classImplementingNothing, breakingChanges[1].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(BaseInterface)), breakingChanges[1].AssociatedData, "The AssociatedData is incorrect.");
        }

        public class NestedBaseInterface { public interface Interface { } }
        public class NestedDerivedInterface { public interface Interface : NestedBaseInterface.Interface { } }

        public class NestedClassImplementingBase { public class Class : NestedBaseInterface.Interface { } }
        public class NestedClassImplementingDerived { public class Class : NestedDerivedInterface.Interface { } }
        public class NestedClassImplementingNothing { public class Class { } }

        public class ClassImplementingBase : BaseInterface { }
        public class ClassImplementingDerived : DerivedInterface { }
        public class ClassImplementingNothing { }
    }
}

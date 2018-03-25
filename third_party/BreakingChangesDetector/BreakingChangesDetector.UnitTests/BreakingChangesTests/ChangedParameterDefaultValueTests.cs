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

using System;
using Xunit;
using BreakingChangesDetector.MetadataItems;
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class ChangedParameterDefaultValueTests
    {
        [Fact]
        public void ConstructorTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterDefaultValueTests));
            var ConstructorWithDefault0 = context.GetTypeDefinitionData(typeof(ConstructorWithDefault0));
            var ConstructorWithDefault1 = context.GetTypeDefinitionData(typeof(ConstructorWithDefault1));

            var breakingChanges = MetadataComparer.CompareTypes(ConstructorWithDefault0, ConstructorWithDefault1);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)ConstructorWithDefault0.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)ConstructorWithDefault1.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ConstructorWithDefault1.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ConstructorWithDefault1, ConstructorWithDefault0);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)ConstructorWithDefault1.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)ConstructorWithDefault0.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ConstructorWithDefault0.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        [Fact]
        public void IndexerTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterDefaultValueTests));
            var IndexerWithDefault0 = context.GetTypeDefinitionData(typeof(IndexerWithDefault0));
            var IndexerWithDefault1 = context.GetTypeDefinitionData(typeof(IndexerWithDefault1));

            var breakingChanges = MetadataComparer.CompareTypes(IndexerWithDefault0, IndexerWithDefault1);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)IndexerWithDefault0.GetMember("Item")).Parameters[1], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)IndexerWithDefault1.GetMember("Item")).Parameters[1], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(IndexerWithDefault1.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithDefault1, IndexerWithDefault0);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)IndexerWithDefault1.GetMember("Item")).Parameters[1], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)IndexerWithDefault0.GetMember("Item")).Parameters[1], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(IndexerWithDefault0.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        [Fact]
        public void MethodTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterDefaultValueTests));
            var MethodWithDefault0 = context.GetTypeDefinitionData(typeof(MethodWithDefault0));
            var MethodWithDefault1 = context.GetTypeDefinitionData(typeof(MethodWithDefault1));

            var breakingChanges = MetadataComparer.CompareTypes(MethodWithDefault0, MethodWithDefault1);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(MethodWithDefault0.GetMethod("Method").Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(MethodWithDefault1.GetMethod("Method").Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(MethodWithDefault1.GetMethod("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithDefault1, MethodWithDefault0);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(MethodWithDefault1.GetMethod("Method").Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(MethodWithDefault0.GetMethod("Method").Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(MethodWithDefault0.GetMethod("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        [Fact]
        public void NestedTypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterDefaultValueTests));
            var nestedDelegateWithDefault0 = context.GetTypeDefinitionData(typeof(NestedDelegateWithDefault0));
            var nestedDelegateWithDefault1 = context.GetTypeDefinitionData(typeof(NestedDelegateWithDefault1));

            var breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithDefault0, nestedDelegateWithDefault1);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedDelegateWithDefault0.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedDelegateWithDefault1.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(nestedDelegateWithDefault1.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithDefault1, nestedDelegateWithDefault0);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedDelegateWithDefault1.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedDelegateWithDefault0.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(nestedDelegateWithDefault0.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        [Fact]
        public void TypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterDefaultValueTests));
            var DelegateWithDefault0 = context.GetTypeDefinitionData(typeof(DelegateWithDefault0));
            var DelegateWithDefault1 = context.GetTypeDefinitionData(typeof(DelegateWithDefault1));

            var breakingChanges = MetadataComparer.CompareTypes(DelegateWithDefault0, DelegateWithDefault1);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithDefault0.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithDefault1.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(DelegateWithDefault1, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithDefault1, DelegateWithDefault0);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithDefault1.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithDefault0.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(DelegateWithDefault0, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        public class NestedDelegateWithDefault0 { public delegate void Delegate(int x = 0); }
        public class NestedDelegateWithDefault1 { public delegate void Delegate(int x = 1); }

        public delegate void DelegateWithDefault0(int x = 0);
        public delegate void DelegateWithDefault1(int x = 1);

        public class ConstructorWithDefault0 { public ConstructorWithDefault0(int x = 0) { } }
        public class ConstructorWithDefault1 { public ConstructorWithDefault1(int x = 1) { } }

        public class IndexerWithDefault0 { public int this[int x, int y = 0] { get { return 0; } } }
        public class IndexerWithDefault1 { public int this[int x, int y = 1] { get { return 0; } } }

        public class MethodWithDefault0 { public void Method(DateTimeKind x = DateTimeKind.Local) { } }
        public class MethodWithDefault1 { public void Method(DateTimeKind x = DateTimeKind.Unspecified) { } }
    }
}

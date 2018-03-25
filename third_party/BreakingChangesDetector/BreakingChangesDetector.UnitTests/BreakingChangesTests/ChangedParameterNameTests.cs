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
using Infragistics;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class ChangedParameterNameTests
    {
        #region ConstructorTests

        [Fact]
        public void ConstructorTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterNameTests));
            var constructorWithOldParameterName = context.GetTypeDefinitionData(typeof(ConstructorWithOldParameterName));
            var constructorWithNewParameterName = context.GetTypeDefinitionData(typeof(ConstructorWithNewParameterName));

            var breakingChanges = MetadataComparer.CompareTypes(constructorWithOldParameterName, constructorWithNewParameterName);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)constructorWithOldParameterName.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)constructorWithNewParameterName.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(constructorWithNewParameterName.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(constructorWithNewParameterName, constructorWithOldParameterName);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)constructorWithNewParameterName.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)constructorWithOldParameterName.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(constructorWithOldParameterName.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // ConstructorTests

        #region IndexerTests

        [Fact]
        public void IndexerTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterNameTests));
            var indexerWithOldParameterName = context.GetTypeDefinitionData(typeof(IndexerWithOldParameterName));
            var indexerWithNewParameterName = context.GetTypeDefinitionData(typeof(IndexerWithNewParameterName));

            var breakingChanges = MetadataComparer.CompareTypes(indexerWithOldParameterName, indexerWithNewParameterName);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)indexerWithOldParameterName.GetMember("Item")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)indexerWithNewParameterName.GetMember("Item")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(indexerWithNewParameterName.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(indexerWithNewParameterName, indexerWithOldParameterName);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)indexerWithNewParameterName.GetMember("Item")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)indexerWithOldParameterName.GetMember("Item")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(indexerWithOldParameterName.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // IndexerTests

        #region MethodTests

        [Fact]
        public void MethodTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterNameTests));
            var methodWithOldParameterName = context.GetTypeDefinitionData(typeof(MethodWithOldParameterName));
            var methodWithNewParameterName = context.GetTypeDefinitionData(typeof(MethodWithNewParameterName));

            var breakingChanges = MetadataComparer.CompareTypes(methodWithOldParameterName, methodWithNewParameterName);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithOldParameterName.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithNewParameterName.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(methodWithNewParameterName.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithNewParameterName, methodWithOldParameterName);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithNewParameterName.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithOldParameterName.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(methodWithOldParameterName.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // MethodTests

        #region NestedTypeTests

        [Fact]
        public void NestedTypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterNameTests));
            var nestedDelegateWithOldParameterName = context.GetTypeDefinitionData(typeof(NestedDelegateWithOldParameterName));
            var nestedDelegateWithNewParameterName = context.GetTypeDefinitionData(typeof(NestedDelegateWithNewParameterName));

            var breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithOldParameterName, nestedDelegateWithNewParameterName);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedDelegateWithOldParameterName.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedDelegateWithNewParameterName.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(nestedDelegateWithNewParameterName.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithNewParameterName, nestedDelegateWithOldParameterName);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedDelegateWithNewParameterName.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedDelegateWithOldParameterName.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(nestedDelegateWithOldParameterName.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // NestedTypeTests

        #region OperatorTests

        [Fact]
        public void OperatorTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterNameTests));
            var OperatorWithOldParameterName = context.GetTypeDefinitionData(typeof(OperatorWithOldParameterName));
            var OperatorWithNewParameterName = context.GetTypeDefinitionData(typeof(OperatorWithNewParameterName));

            var breakingChanges = MetadataComparer.CompareTypes(OperatorWithOldParameterName, OperatorWithNewParameterName);
            AssertX.Equal(0, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
        }

        #endregion // OperatorTests

        #region TypeTests

        [Fact]
        public void TypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterNameTests));
            var delegateWithOldParameterName = context.GetTypeDefinitionData(typeof(DelegateWithOldParameterName));
            var delegateWithNewParameterName = context.GetTypeDefinitionData(typeof(DelegateWithNewParameterName));

            var breakingChanges = MetadataComparer.CompareTypes(delegateWithOldParameterName, delegateWithNewParameterName);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(delegateWithOldParameterName.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(delegateWithNewParameterName.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(delegateWithNewParameterName, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(delegateWithNewParameterName, delegateWithOldParameterName);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(delegateWithNewParameterName.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(delegateWithOldParameterName.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(delegateWithOldParameterName, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // TypeTests

        public class NestedDelegateWithOldParameterName { public delegate void Delegate(int x); }
        public class NestedDelegateWithNewParameterName { public delegate void Delegate(int y); }

        public delegate void DelegateWithOldParameterName(int x);
        public delegate void DelegateWithNewParameterName(int y);

        public class ConstructorWithOldParameterName { public ConstructorWithOldParameterName(int x) { } }
        public class ConstructorWithNewParameterName { public ConstructorWithNewParameterName(int y) { } }

        public class IndexerWithOldParameterName { public int this[int x] { get { return 0; } } }
        public class IndexerWithNewParameterName { public int this[int y] { get { return 0; } } }

        public class MethodWithOldParameterName { public void Method(int x) { } }
        public class MethodWithNewParameterName { public void Method(int y) { } }

        public class OperatorWithOldParameterName { public static implicit operator OperatorWithOldParameterName(int x) { return null; } }
        [TypeRenamed("BreakingChangesDetector.UnitTests.BreakingChangesTests.ChangedParameterNameTests.OperatorWithOldParameterName")]
        public class OperatorWithNewParameterName { public static implicit operator OperatorWithNewParameterName(int y) { return null; } }
    }
}

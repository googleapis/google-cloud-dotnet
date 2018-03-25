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
using System.Linq;
using Xunit;
using BreakingChangesDetector.MetadataItems;
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{

    public class ChangedParameterTypeTests
    {
        #region ConstructorTests

        [Fact]
        public void ConstructorTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterTypeTests));
            var ConstructorWithIntParameter = context.GetTypeDefinitionData(typeof(ConstructorWithIntParameter));
            var ConstructorWithStringParameter = context.GetTypeDefinitionData(typeof(ConstructorWithStringParameter));
            var ConstructorWithDynamicParameter = context.GetTypeDefinitionData(typeof(ConstructorWithDynamicParameter));

            var breakingChanges = MetadataComparer.CompareTypes(ConstructorWithIntParameter, ConstructorWithStringParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)ConstructorWithIntParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)ConstructorWithStringParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ConstructorWithStringParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ConstructorWithStringParameter, ConstructorWithIntParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)ConstructorWithStringParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)ConstructorWithIntParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ConstructorWithIntParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ConstructorWithIntParameter, ConstructorWithDynamicParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(ConstructorWithDynamicParameter, ConstructorWithIntParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)ConstructorWithDynamicParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)ConstructorWithIntParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ConstructorWithIntParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ConstructorWithStringParameter, ConstructorWithDynamicParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(ConstructorWithDynamicParameter, ConstructorWithStringParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)ConstructorWithDynamicParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)ConstructorWithStringParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ConstructorWithStringParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // ConstructorTests

        #region IndexerTests

        [Fact]
        public void IndexerTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterTypeTests));
            var IndexerWithIntParameter = context.GetTypeDefinitionData(typeof(IndexerWithIntParameter));
            var IndexerWithStringParameter = context.GetTypeDefinitionData(typeof(IndexerWithStringParameter));
            var IndexerWithDynamicParameter = context.GetTypeDefinitionData(typeof(IndexerWithDynamicParameter));

            var breakingChanges = MetadataComparer.CompareTypes(IndexerWithIntParameter, IndexerWithStringParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)IndexerWithIntParameter.GetMember("Item")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)IndexerWithStringParameter.GetMember("Item")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(IndexerWithStringParameter.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithStringParameter, IndexerWithIntParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)IndexerWithStringParameter.GetMember("Item")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)IndexerWithIntParameter.GetMember("Item")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(IndexerWithIntParameter.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithIntParameter, IndexerWithDynamicParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithDynamicParameter, IndexerWithIntParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)IndexerWithDynamicParameter.GetMember("Item")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)IndexerWithIntParameter.GetMember("Item")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(IndexerWithIntParameter.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithStringParameter, IndexerWithDynamicParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithDynamicParameter, IndexerWithStringParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)IndexerWithDynamicParameter.GetMember("Item")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)IndexerWithStringParameter.GetMember("Item")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(IndexerWithStringParameter.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // IndexerTests

        #region ModiferRestrictionsTests

        [Fact]
        public void ModiferRestrictionsTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterTypeTests));
            var methodWithRefParameterBase = context.GetTypeDefinitionData(typeof(MethodWithRefParameterBase));
            var methodWithRefParameterDerived = context.GetTypeDefinitionData(typeof(MethodWithRefParameterDerived));
            var methodWithOutParameterBase = context.GetTypeDefinitionData(typeof(MethodWithOutParameterBase));
            var methodWithOutParameterDerived = context.GetTypeDefinitionData(typeof(MethodWithOutParameterDerived));

            var breakingChanges = MetadataComparer.CompareTypes(methodWithRefParameterBase, methodWithRefParameterDerived);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes at all on a ref parameter.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithRefParameterBase.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithRefParameterDerived.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(methodWithRefParameterDerived.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithRefParameterDerived, methodWithRefParameterBase);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes at all on a ref parameter.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithRefParameterDerived.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithRefParameterBase.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(methodWithRefParameterBase.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithOutParameterBase, methodWithOutParameterDerived);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes at all on an out parameter.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithOutParameterBase.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithOutParameterDerived.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(methodWithOutParameterDerived.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithOutParameterDerived, methodWithOutParameterBase);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes at all on an out parameter.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithOutParameterDerived.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithOutParameterBase.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(methodWithOutParameterBase.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // ModiferRestrictionsTests

        #region MethodTests

        [Fact]
        public void MethodTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterTypeTests));
            var MethodWithIntParameter = context.GetTypeDefinitionData(typeof(MethodWithIntParameter));
            var MethodWithStringParameter = context.GetTypeDefinitionData(typeof(MethodWithStringParameter));
            var MethodWithDynamicParameter = context.GetTypeDefinitionData(typeof(MethodWithDynamicParameter));

            var breakingChanges = MetadataComparer.CompareTypes(MethodWithIntParameter, MethodWithStringParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)MethodWithIntParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)MethodWithStringParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(MethodWithStringParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithStringParameter, MethodWithIntParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)MethodWithStringParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)MethodWithIntParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(MethodWithIntParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithIntParameter, MethodWithDynamicParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithDynamicParameter, MethodWithIntParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)MethodWithDynamicParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)MethodWithIntParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(MethodWithIntParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithStringParameter, MethodWithDynamicParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithDynamicParameter, MethodWithStringParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)MethodWithDynamicParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)MethodWithStringParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(MethodWithStringParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // MethodTests

        #region NestedTypeTests

        [Fact]
        public void NestedTypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterTypeTests));
            var NestedDelegateWithIntParameter = context.GetTypeDefinitionData(typeof(NestedDelegateWithIntParameter));
            var NestedDelegateWithStringParameter = context.GetTypeDefinitionData(typeof(NestedDelegateWithStringParameter));
            var NestedDelegateWithDynamicParameter = context.GetTypeDefinitionData(typeof(NestedDelegateWithDynamicParameter));

            var breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithIntParameter, NestedDelegateWithStringParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(NestedDelegateWithIntParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(NestedDelegateWithStringParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(NestedDelegateWithStringParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithStringParameter, NestedDelegateWithIntParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(NestedDelegateWithStringParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(NestedDelegateWithIntParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(NestedDelegateWithIntParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithIntParameter, NestedDelegateWithDynamicParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithDynamicParameter, NestedDelegateWithIntParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)NestedDelegateWithDynamicParameter.GetMember("Delegate")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)NestedDelegateWithIntParameter.GetMember("Delegate")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(NestedDelegateWithIntParameter.GetMember("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithStringParameter, NestedDelegateWithDynamicParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithDynamicParameter, NestedDelegateWithStringParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)NestedDelegateWithDynamicParameter.GetMember("Delegate")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)NestedDelegateWithStringParameter.GetMember("Delegate")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(NestedDelegateWithStringParameter.GetMember("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // NestedTypeTests

        #region ParameterTypeContravarianceTests

        [Fact]
        public void ParameterTypeContravarianceTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterTypeTests));
            var methodWithParameterBase = context.GetTypeDefinitionData(typeof(MethodWithParameterBase));
            var methodWithParameterDerived = context.GetTypeDefinitionData(typeof(MethodWithParameterDerived));

            var breakingChanges = MetadataComparer.CompareTypes(methodWithParameterBase, methodWithParameterDerived);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithParameterBase.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)methodWithParameterDerived.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(methodWithParameterDerived.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithParameterDerived, methodWithParameterBase);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the parameter type changes to a base type.");
        }

        #endregion // ParameterTypeContravarianceTests

        #region OperatorTests

        [Fact]
        public void OperatorTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterTypeTests));
            var OperatorWithIntParameter = context.GetTypeDefinitionData(typeof(OperatorWithIntParameter));
            var OperatorWithStringParameter = context.GetTypeDefinitionData(typeof(OperatorWithStringParameter));
            var OperatorWithDynamicParameter = context.GetTypeDefinitionData(typeof(OperatorWithDynamicParameter));

            var breakingChanges = MetadataComparer.CompareTypes(OperatorWithIntParameter, OperatorWithStringParameter);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedParameterType).ToList();
            AssertX.Equal(2, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)OperatorWithIntParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)OperatorWithStringParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(OperatorWithStringParameter.GetMember("op_Addition"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(OperatorWithStringParameter, OperatorWithIntParameter);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedParameterType).ToList();
            AssertX.Equal(2, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)OperatorWithStringParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)OperatorWithIntParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(OperatorWithIntParameter.GetMember("op_Addition"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(OperatorWithIntParameter, OperatorWithDynamicParameter);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedParameterType).ToList();
            AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(OperatorWithDynamicParameter, OperatorWithIntParameter);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedParameterType).ToList();
            AssertX.Equal(2, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)OperatorWithDynamicParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)OperatorWithIntParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(OperatorWithIntParameter.GetMember("op_Addition"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(OperatorWithStringParameter, OperatorWithDynamicParameter);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedParameterType).ToList();
            AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(OperatorWithDynamicParameter, OperatorWithStringParameter);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedParameterType).ToList();
            AssertX.Equal(2, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((IParameterizedItem)OperatorWithDynamicParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((IParameterizedItem)OperatorWithStringParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(OperatorWithStringParameter.GetMember("op_Addition"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // OperatorTests

        #region TypeTests

        [Fact]
        public void TypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterTypeTests));
            var DelegateWithIntParameter = context.GetTypeDefinitionData(typeof(DelegateWithIntParameter));
            var DelegateWithStringParameter = context.GetTypeDefinitionData(typeof(DelegateWithStringParameter));
            var DelegateWithDynamicParameter = context.GetTypeDefinitionData(typeof(DelegateWithDynamicParameter));

            var breakingChanges = MetadataComparer.CompareTypes(DelegateWithIntParameter, DelegateWithStringParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithIntParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithStringParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(DelegateWithStringParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithStringParameter, DelegateWithIntParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithStringParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithIntParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(DelegateWithIntParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithIntParameter, DelegateWithDynamicParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithDynamicParameter, DelegateWithIntParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithDynamicParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithIntParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(DelegateWithIntParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithStringParameter, DelegateWithDynamicParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithDynamicParameter, DelegateWithStringParameter);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithDynamicParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithStringParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(DelegateWithStringParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // TypeTests

        public class NestedDelegateWithIntParameter { public delegate void Delegate(int x); }
        public class NestedDelegateWithStringParameter { public delegate void Delegate(string x); }
        public class NestedDelegateWithDynamicParameter { public delegate void Delegate(dynamic x); }

        public class MethodWithParameterBase { public void Method(ParameterBase x) { } }
        public class MethodWithParameterDerived { public void Method(ParameterDerived x) { } }
        public class MethodWithRefParameterBase { public void Method(ref ParameterBase x) { } }
        public class MethodWithRefParameterDerived { public void Method(ref ParameterDerived x) { } }
        public class MethodWithOutParameterBase { public void Method(out ParameterBase x) { x = null; } }
        public class MethodWithOutParameterDerived { public void Method(out ParameterDerived x) { x = null; } }

        public class ParameterBase { }
        public class ParameterDerived : ParameterBase { }

        public delegate void DelegateWithIntParameter(int x);
        public delegate void DelegateWithStringParameter(string x);
        public delegate void DelegateWithDynamicParameter(dynamic x);

        public class ConstructorWithIntParameter { public ConstructorWithIntParameter(int x) { } }
        public class ConstructorWithStringParameter { public ConstructorWithStringParameter(string x) { } }
        public class ConstructorWithDynamicParameter { public ConstructorWithDynamicParameter(dynamic x) { } }

        public class IndexerWithIntParameter { public int this[int x] { get { return 0; } } }
        public class IndexerWithStringParameter { public int this[string x] { get { return 0; } } }
        public class IndexerWithDynamicParameter { public int this[dynamic x] { get { return 0; } } }

        public class MethodWithIntParameter { public void Method(int x) { } }
        public class MethodWithStringParameter { public void Method(string x) { } }
        public class MethodWithDynamicParameter { public void Method(dynamic x) { } }

        public class OperatorWithIntParameter { public static int operator +(int a, OperatorWithIntParameter b) { return 0; } }
        public class OperatorWithStringParameter { public static int operator +(string a, OperatorWithStringParameter b) { return 0; } }
        public class OperatorWithDynamicParameter { public static int operator +(dynamic a, OperatorWithDynamicParameter b) { return 0; } }
    }
}

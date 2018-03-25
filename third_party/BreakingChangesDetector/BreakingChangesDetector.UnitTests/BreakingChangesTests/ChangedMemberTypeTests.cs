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
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class ChangedMemberTypeTests
    {
        #region ChangeVoidToNonVoidAllowedTest

        [Fact]
        public void ChangeVoidToNonVoidAllowedTest()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var MethodWithIntReturn = context.GetTypeDefinitionData(typeof(MethodWithIntReturn));
            var MethodWithStringReturn = context.GetTypeDefinitionData(typeof(MethodWithStringReturn));
            var MethodWithDynamicReturn = context.GetTypeDefinitionData(typeof(MethodWithDynamicReturn));
            var MethodWithVoidReturn = context.GetTypeDefinitionData(typeof(MethodWithVoidReturn));

            var breakingChanges = MetadataComparer.CompareTypes(MethodWithVoidReturn, MethodWithIntReturn);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes from void to non-void.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithVoidReturn, MethodWithStringReturn);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes from void to non-void.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithVoidReturn, MethodWithDynamicReturn);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes from void to non-void.");
        }

        public class MethodWithVoidReturn { public void Method() { } }

        #endregion // ChangeVoidToNonVoidAllowedTest

        #region ConstantTests

        [Fact]
        public void ConstantTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var ConstantWithIntReturn = context.GetTypeDefinitionData(typeof(ConstantWithIntReturn));
            var ConstantWithStringReturn = context.GetTypeDefinitionData(typeof(ConstantWithStringReturn));

            var breakingChanges = MetadataComparer.CompareTypes(ConstantWithIntReturn, ConstantWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ConstantWithIntReturn.GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(ConstantWithStringReturn.GetMember("Constant"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ConstantWithStringReturn, ConstantWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ConstantWithStringReturn.GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(ConstantWithIntReturn.GetMember("Constant"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // ConstantTests

        #region EventTests

        [Fact]
        public void EventTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var EventWithIntReturn = context.GetTypeDefinitionData(typeof(EventWithIntReturn));
            var EventWithStringReturn = context.GetTypeDefinitionData(typeof(EventWithStringReturn));

            var breakingChanges = MetadataComparer.CompareTypes(EventWithIntReturn, EventWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(EventWithIntReturn.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(EventWithStringReturn.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(EventWithStringReturn, EventWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(EventWithStringReturn.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(EventWithIntReturn.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // EventTests

        #region FieldTests

        [Fact]
        public void FieldTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var FieldWithIntReturn = context.GetTypeDefinitionData(typeof(FieldWithIntReturn));
            var FieldWithStringReturn = context.GetTypeDefinitionData(typeof(FieldWithStringReturn));
            var FieldWithDynamicReturn = context.GetTypeDefinitionData(typeof(FieldWithDynamicReturn));

            var breakingChanges = MetadataComparer.CompareTypes(FieldWithIntReturn, FieldWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(FieldWithIntReturn.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(FieldWithStringReturn.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(FieldWithStringReturn, FieldWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(FieldWithStringReturn.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(FieldWithIntReturn.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(FieldWithIntReturn, FieldWithDynamicReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(FieldWithIntReturn.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(FieldWithDynamicReturn.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(FieldWithDynamicReturn, FieldWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(FieldWithDynamicReturn.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(FieldWithIntReturn.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(FieldWithStringReturn, FieldWithDynamicReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(FieldWithStringReturn.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(FieldWithDynamicReturn.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(FieldWithDynamicReturn, FieldWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(FieldWithDynamicReturn.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(FieldWithStringReturn.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // FieldTests

        #region IndexerTests

        [Fact]
        public void IndexerTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var IndexerWithIntReturn = context.GetTypeDefinitionData(typeof(IndexerWithIntReturn));
            var IndexerWithStringReturn = context.GetTypeDefinitionData(typeof(IndexerWithStringReturn));
            var IndexerWithDynamicReturn = context.GetTypeDefinitionData(typeof(IndexerWithDynamicReturn));

            var breakingChanges = MetadataComparer.CompareTypes(IndexerWithIntReturn, IndexerWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(IndexerWithIntReturn.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(IndexerWithStringReturn.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithStringReturn, IndexerWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(IndexerWithStringReturn.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(IndexerWithIntReturn.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithIntReturn, IndexerWithDynamicReturn);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithDynamicReturn, IndexerWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(IndexerWithDynamicReturn.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(IndexerWithIntReturn.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithStringReturn, IndexerWithDynamicReturn);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithDynamicReturn, IndexerWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(IndexerWithDynamicReturn.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(IndexerWithStringReturn.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // IndexerTests

        #region MethodTests

        [Fact]
        public void MethodTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var MethodWithIntReturn = context.GetTypeDefinitionData(typeof(MethodWithIntReturn));
            var MethodWithStringReturn = context.GetTypeDefinitionData(typeof(MethodWithStringReturn));
            var MethodWithDynamicReturn = context.GetTypeDefinitionData(typeof(MethodWithDynamicReturn));

            var breakingChanges = MetadataComparer.CompareTypes(MethodWithIntReturn, MethodWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(MethodWithIntReturn.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(MethodWithStringReturn.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithStringReturn, MethodWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(MethodWithStringReturn.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(MethodWithIntReturn.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithIntReturn, MethodWithDynamicReturn);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithDynamicReturn, MethodWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(MethodWithDynamicReturn.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(MethodWithIntReturn.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithStringReturn, MethodWithDynamicReturn);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithDynamicReturn, MethodWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(MethodWithDynamicReturn.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(MethodWithStringReturn.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // MethodTests

        #region NestedTypeTests

        [Fact]
        public void NestedTypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var nestedDelegateWithIntReturn = context.GetTypeDefinitionData(typeof(NestedDelegateWithIntReturn));
            var nestedDelegateWithStringReturn = context.GetTypeDefinitionData(typeof(NestedDelegateWithStringReturn));
            var nestedDelegateWithDynamicReturn = context.GetTypeDefinitionData(typeof(NestedDelegateWithDynamicReturn));

            var breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithIntReturn, nestedDelegateWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedDelegateWithIntReturn.GetNestedType("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedDelegateWithStringReturn.GetNestedType("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithStringReturn, nestedDelegateWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedDelegateWithStringReturn.GetNestedType("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedDelegateWithIntReturn.GetNestedType("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithIntReturn, nestedDelegateWithDynamicReturn);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithDynamicReturn, nestedDelegateWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedDelegateWithDynamicReturn.GetMember("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedDelegateWithIntReturn.GetMember("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithStringReturn, nestedDelegateWithDynamicReturn);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithDynamicReturn, nestedDelegateWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedDelegateWithDynamicReturn.GetMember("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedDelegateWithStringReturn.GetMember("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // NestedTypeTests

        #region OperatorTests

        [Fact]
        public void OperatorTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var OperatorWithIntReturn = context.GetTypeDefinitionData(typeof(OperatorWithIntReturn));
            var OperatorWithStringReturn = context.GetTypeDefinitionData(typeof(OperatorWithStringReturn));
            var OperatorWithDynamicReturn = context.GetTypeDefinitionData(typeof(OperatorWithDynamicReturn));

            var breakingChanges = MetadataComparer.CompareTypes(OperatorWithIntReturn, OperatorWithStringReturn);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedMemberType).ToList();
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(OperatorWithIntReturn.GetMember("op_Addition"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(OperatorWithStringReturn.GetMember("op_Addition"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(OperatorWithStringReturn, OperatorWithIntReturn);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedMemberType).ToList();
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(OperatorWithStringReturn.GetMember("op_Addition"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(OperatorWithIntReturn.GetMember("op_Addition"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(OperatorWithIntReturn, OperatorWithDynamicReturn);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedMemberType).ToList();
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(OperatorWithDynamicReturn, OperatorWithIntReturn);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedMemberType).ToList();
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(OperatorWithDynamicReturn.GetMember("op_Addition"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(OperatorWithIntReturn.GetMember("op_Addition"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(OperatorWithStringReturn, OperatorWithDynamicReturn);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedMemberType).ToList();
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(OperatorWithDynamicReturn, OperatorWithStringReturn);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedMemberType).ToList();
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(OperatorWithDynamicReturn.GetMember("op_Addition"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(OperatorWithStringReturn.GetMember("op_Addition"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // OperatorTests

        #region PropertyTests

        [Fact]
        public void PropertyTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var PropertyWithIntReturn = context.GetTypeDefinitionData(typeof(PropertyWithIntReturn));
            var PropertyWithStringReturn = context.GetTypeDefinitionData(typeof(PropertyWithStringReturn));
            var PropertyWithDynamicReturn = context.GetTypeDefinitionData(typeof(PropertyWithDynamicReturn));

            var breakingChanges = MetadataComparer.CompareTypes(PropertyWithIntReturn, PropertyWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(PropertyWithIntReturn.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(PropertyWithStringReturn.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyWithStringReturn, PropertyWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(PropertyWithStringReturn.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(PropertyWithIntReturn.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyWithIntReturn, PropertyWithDynamicReturn);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyWithDynamicReturn, PropertyWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(PropertyWithDynamicReturn.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(PropertyWithIntReturn.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyWithStringReturn, PropertyWithDynamicReturn);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyWithDynamicReturn, PropertyWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(PropertyWithDynamicReturn.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(PropertyWithStringReturn.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // PropertyTests

        #region ReturnTypeCovarianceTests

        [Fact]
        public void ReturnTypeCovarianceTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var methodWithReturnBase = context.GetTypeDefinitionData(typeof(MethodWithReturnBase));
            var methodWithReturnDerived = context.GetTypeDefinitionData(typeof(MethodWithReturnDerived));

            var breakingChanges = MetadataComparer.CompareTypes(methodWithReturnDerived, methodWithReturnBase);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(methodWithReturnDerived.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(methodWithReturnBase.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithReturnBase, methodWithReturnDerived);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to a base type.");

            // Read/write fields cannot change type at all because they can be used in out or ref parameters
            var FieldWithReturnBase = context.GetTypeDefinitionData(typeof(FieldWithReturnBase));
            var FieldWithReturnDerived = context.GetTypeDefinitionData(typeof(FieldWithReturnDerived));
            var FieldWithReadonlyReturnBase = context.GetTypeDefinitionData(typeof(FieldWithReadonlyReturnBase));
            breakingChanges = MetadataComparer.CompareTypes(FieldWithReturnDerived, FieldWithReturnBase);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(FieldWithReturnDerived.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(FieldWithReturnBase.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
            breakingChanges = MetadataComparer.CompareTypes(FieldWithReturnBase, FieldWithReturnDerived);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(FieldWithReturnBase.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(FieldWithReturnDerived.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
            breakingChanges = MetadataComparer.CompareTypes(FieldWithReadonlyReturnBase, FieldWithReturnDerived);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the read-only field type changes to a base type.");

            var EventWithReturnBase = context.GetTypeDefinitionData(typeof(EventWithReturnBase));
            var EventWithReturnDerived = context.GetTypeDefinitionData(typeof(EventWithReturnDerived));
            breakingChanges = MetadataComparer.CompareTypes(EventWithReturnDerived, EventWithReturnBase);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(EventWithReturnDerived.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(EventWithReturnBase.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
            breakingChanges = MetadataComparer.CompareTypes(EventWithReturnBase, EventWithReturnDerived);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(EventWithReturnBase.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(EventWithReturnDerived.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // ReturnTypeCovarianceTests

        #region TypeTests

        [Fact]
        public void TypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var DelegateWithIntReturn = context.GetTypeDefinitionData(typeof(DelegateWithIntReturn));
            var DelegateWithStringReturn = context.GetTypeDefinitionData(typeof(DelegateWithStringReturn));
            var DelegateWithDynamicReturn = context.GetTypeDefinitionData(typeof(DelegateWithDynamicReturn));

            var breakingChanges = MetadataComparer.CompareTypes(DelegateWithIntReturn, DelegateWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithIntReturn, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithStringReturn, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithStringReturn, DelegateWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithStringReturn, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithIntReturn, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithIntReturn, DelegateWithDynamicReturn);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithDynamicReturn, DelegateWithIntReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithDynamicReturn, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithIntReturn, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithStringReturn, DelegateWithDynamicReturn);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithDynamicReturn, DelegateWithStringReturn);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithDynamicReturn, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithStringReturn, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // TypeTests

        public class NestedDelegateWithIntReturn { public delegate int Delegate(); }
        public class NestedDelegateWithStringReturn { public delegate string Delegate(); }
        public class NestedDelegateWithDynamicReturn { public delegate dynamic Delegate(); }

#pragma warning disable 0067
        public class EventWithReturnBase { public event EventHandler<ReturnBase> Event; }
        public class EventWithReturnDerived { public event EventHandler<ReturnDerived> Event; }
#pragma warning restore 0067

        public class FieldWithReturnBase { public ReturnBase Field; }
        public class FieldWithReturnDerived { public ReturnDerived Field; }
        public class FieldWithReadonlyReturnBase { public readonly ReturnBase Field; }

        public class MethodWithReturnBase { public ReturnBase Method() { return null; } }
        public class MethodWithReturnDerived { public ReturnDerived Method() { return null; } }

        public class ReturnBase { }
        public class ReturnDerived : ReturnBase { }


        public class ConstantWithIntReturn { public const int Constant = 0; }
        public class ConstantWithStringReturn { public const string Constant = "X"; }

        public delegate int DelegateWithIntReturn();
        public delegate string DelegateWithStringReturn();
        public delegate dynamic DelegateWithDynamicReturn();

#pragma warning disable 0067
        public class EventWithIntReturn { public event EventHandler<int> Event; }
        public class EventWithStringReturn { public event EventHandler<string> Event; }
#pragma warning restore 0067

        public class FieldWithIntReturn { public int Field; }
        public class FieldWithStringReturn { public string Field; }
        public class FieldWithDynamicReturn { public dynamic Field; }

        public class IndexerWithIntReturn { public int this[int x] { get { return 0; } } }
        public class IndexerWithStringReturn { public string this[int x] { get { return "X"; } } }
        public class IndexerWithDynamicReturn { public dynamic this[int x] { get { return "X"; } } }

        public class MethodWithIntReturn { public int Method() { return 0; } }
        public class MethodWithStringReturn { public string Method() { return "X"; } }
        public class MethodWithDynamicReturn { public dynamic Method() { return "X"; } }

        public class OperatorWithIntReturn { public static int operator +(OperatorWithIntReturn a, OperatorWithIntReturn b) { return 0; } }
        public class OperatorWithStringReturn { public static string operator +(OperatorWithStringReturn a, OperatorWithStringReturn b) { return "X"; } }
        public class OperatorWithDynamicReturn { public static dynamic operator +(OperatorWithDynamicReturn a, OperatorWithDynamicReturn b) { return "X"; } }

        public class PropertyWithIntReturn { public int Property { get { return 0; } } }
        public class PropertyWithStringReturn { public string Property { get { return "X"; } } }
        public class PropertyWithDynamicReturn { public dynamic Property { get { return "X"; } } }
    }
}

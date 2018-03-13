/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.

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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakingChangesDetector.MetadataItems;
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	[TestClass]
	public class ChangedMemberTypeTests
	{
		#region ChangeVoidToNonVoidAllowedTest

		[TestMethod]
		public void ChangeVoidToNonVoidAllowedTest()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var MethodWithIntReturn = TypeDefinitionData.FromType(typeof(MethodWithIntReturn));
			var MethodWithStringReturn = TypeDefinitionData.FromType(typeof(MethodWithStringReturn));
			var MethodWithDynamicReturn = TypeDefinitionData.FromType(typeof(MethodWithDynamicReturn));
			var MethodWithVoidReturn = TypeDefinitionData.FromType(typeof(MethodWithVoidReturn));
			
			var breakingChanges = MetadataComparer.CompareTypes(MethodWithVoidReturn, MethodWithIntReturn);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes from void to non-void.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithVoidReturn, MethodWithStringReturn);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes from void to non-void.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithVoidReturn, MethodWithDynamicReturn);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes from void to non-void.");
		}

		public class MethodWithVoidReturn { public void Method() { } }

		#endregion // ChangeVoidToNonVoidAllowedTest

		#region ConstantTests

		[TestMethod]
		public void ConstantTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var ConstantWithIntReturn = TypeDefinitionData.FromType(typeof(ConstantWithIntReturn));
			var ConstantWithStringReturn = TypeDefinitionData.FromType(typeof(ConstantWithStringReturn));
			
			var breakingChanges = MetadataComparer.CompareTypes(ConstantWithIntReturn, ConstantWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ConstantWithIntReturn.GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(ConstantWithStringReturn.GetMember("Constant"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstantWithStringReturn, ConstantWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ConstantWithStringReturn.GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(ConstantWithIntReturn.GetMember("Constant"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ConstantTests

		#region EventTests

		[TestMethod]
		public void EventTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var EventWithIntReturn = TypeDefinitionData.FromType(typeof(EventWithIntReturn));
			var EventWithStringReturn = TypeDefinitionData.FromType(typeof(EventWithStringReturn));
			
			var breakingChanges = MetadataComparer.CompareTypes(EventWithIntReturn, EventWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventWithIntReturn.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(EventWithStringReturn.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventWithStringReturn, EventWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventWithStringReturn.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(EventWithIntReturn.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // EventTests

		#region FieldTests

		[TestMethod]
		public void FieldTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var FieldWithIntReturn = TypeDefinitionData.FromType(typeof(FieldWithIntReturn));
			var FieldWithStringReturn = TypeDefinitionData.FromType(typeof(FieldWithStringReturn));
			var FieldWithDynamicReturn = TypeDefinitionData.FromType(typeof(FieldWithDynamicReturn));
			
			var breakingChanges = MetadataComparer.CompareTypes(FieldWithIntReturn, FieldWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(FieldWithIntReturn.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(FieldWithStringReturn.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(FieldWithStringReturn, FieldWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(FieldWithStringReturn.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(FieldWithIntReturn.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(FieldWithIntReturn, FieldWithDynamicReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(FieldWithIntReturn.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(FieldWithDynamicReturn.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(FieldWithDynamicReturn, FieldWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(FieldWithDynamicReturn.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(FieldWithIntReturn.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(FieldWithStringReturn, FieldWithDynamicReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(FieldWithStringReturn.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(FieldWithDynamicReturn.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(FieldWithDynamicReturn, FieldWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(FieldWithDynamicReturn.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(FieldWithStringReturn.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // FieldTests

		#region IndexerTests

		[TestMethod]
		public void IndexerTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var IndexerWithIntReturn = TypeDefinitionData.FromType(typeof(IndexerWithIntReturn));
			var IndexerWithStringReturn = TypeDefinitionData.FromType(typeof(IndexerWithStringReturn));
			var IndexerWithDynamicReturn = TypeDefinitionData.FromType(typeof(IndexerWithDynamicReturn));
			
			var breakingChanges = MetadataComparer.CompareTypes(IndexerWithIntReturn, IndexerWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerWithIntReturn.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerWithStringReturn.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithStringReturn, IndexerWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerWithStringReturn.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerWithIntReturn.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithIntReturn, IndexerWithDynamicReturn);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithDynamicReturn, IndexerWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerWithDynamicReturn.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerWithIntReturn.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithStringReturn, IndexerWithDynamicReturn);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithDynamicReturn, IndexerWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerWithDynamicReturn.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerWithStringReturn.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // IndexerTests

		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var MethodWithIntReturn = TypeDefinitionData.FromType(typeof(MethodWithIntReturn));
			var MethodWithStringReturn = TypeDefinitionData.FromType(typeof(MethodWithStringReturn));
			var MethodWithDynamicReturn = TypeDefinitionData.FromType(typeof(MethodWithDynamicReturn));
			
			var breakingChanges = MetadataComparer.CompareTypes(MethodWithIntReturn, MethodWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodWithIntReturn.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodWithStringReturn.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithStringReturn, MethodWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodWithStringReturn.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodWithIntReturn.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithIntReturn, MethodWithDynamicReturn);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithDynamicReturn, MethodWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodWithDynamicReturn.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodWithIntReturn.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithStringReturn, MethodWithDynamicReturn);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithDynamicReturn, MethodWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodWithDynamicReturn.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodWithStringReturn.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // MethodTests

		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var nestedDelegateWithIntReturn = TypeDefinitionData.FromType(typeof(NestedDelegateWithIntReturn));
			var nestedDelegateWithStringReturn = TypeDefinitionData.FromType(typeof(NestedDelegateWithStringReturn));
			var nestedDelegateWithDynamicReturn = TypeDefinitionData.FromType(typeof(NestedDelegateWithDynamicReturn));
			
			var breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithIntReturn, nestedDelegateWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithIntReturn.GetNestedType("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithStringReturn.GetNestedType("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithStringReturn, nestedDelegateWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithStringReturn.GetNestedType("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithIntReturn.GetNestedType("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithIntReturn, nestedDelegateWithDynamicReturn);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithDynamicReturn, nestedDelegateWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithDynamicReturn.GetMember("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithIntReturn.GetMember("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithStringReturn, nestedDelegateWithDynamicReturn);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithDynamicReturn, nestedDelegateWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithDynamicReturn.GetMember("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithStringReturn.GetMember("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region OperatorTests

		[TestMethod]
		public void OperatorTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var OperatorWithIntReturn = TypeDefinitionData.FromType(typeof(OperatorWithIntReturn));
			var OperatorWithStringReturn = TypeDefinitionData.FromType(typeof(OperatorWithStringReturn));
			var OperatorWithDynamicReturn = TypeDefinitionData.FromType(typeof(OperatorWithDynamicReturn));
			
			var breakingChanges = MetadataComparer.CompareTypes(OperatorWithIntReturn, OperatorWithStringReturn);
			breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedMemberType).ToList();
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(OperatorWithIntReturn.GetMember("op_Addition"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(OperatorWithStringReturn.GetMember("op_Addition"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(OperatorWithStringReturn, OperatorWithIntReturn);
			breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedMemberType).ToList();
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(OperatorWithStringReturn.GetMember("op_Addition"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(OperatorWithIntReturn.GetMember("op_Addition"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(OperatorWithIntReturn, OperatorWithDynamicReturn);
			breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedMemberType).ToList();
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(OperatorWithDynamicReturn, OperatorWithIntReturn);
			breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedMemberType).ToList();
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(OperatorWithDynamicReturn.GetMember("op_Addition"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(OperatorWithIntReturn.GetMember("op_Addition"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(OperatorWithStringReturn, OperatorWithDynamicReturn);
			breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedMemberType).ToList();
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(OperatorWithDynamicReturn, OperatorWithStringReturn);
			breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedMemberType).ToList();
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(OperatorWithDynamicReturn.GetMember("op_Addition"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(OperatorWithStringReturn.GetMember("op_Addition"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // OperatorTests

		#region PropertyTests

		[TestMethod]
		public void PropertyTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var PropertyWithIntReturn = TypeDefinitionData.FromType(typeof(PropertyWithIntReturn));
			var PropertyWithStringReturn = TypeDefinitionData.FromType(typeof(PropertyWithStringReturn));
			var PropertyWithDynamicReturn = TypeDefinitionData.FromType(typeof(PropertyWithDynamicReturn));
			
			var breakingChanges = MetadataComparer.CompareTypes(PropertyWithIntReturn, PropertyWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyWithIntReturn.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyWithStringReturn.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyWithStringReturn, PropertyWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyWithStringReturn.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyWithIntReturn.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyWithIntReturn, PropertyWithDynamicReturn);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyWithDynamicReturn, PropertyWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyWithDynamicReturn.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyWithIntReturn.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyWithStringReturn, PropertyWithDynamicReturn);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyWithDynamicReturn, PropertyWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyWithDynamicReturn.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyWithStringReturn.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // PropertyTests

		#region ReturnTypeCovarianceTests

		[TestMethod]
		public void ReturnTypeCovarianceTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var methodWithReturnBase = TypeDefinitionData.FromType(typeof(MethodWithReturnBase));
			var methodWithReturnDerived = TypeDefinitionData.FromType(typeof(MethodWithReturnDerived));
			
			var breakingChanges = MetadataComparer.CompareTypes(methodWithReturnDerived, methodWithReturnBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(methodWithReturnDerived.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(methodWithReturnBase.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithReturnBase, methodWithReturnDerived);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to a base type.");

			// Read/write fields cannot change type at all because they can be used in out or ref parameters
			var FieldWithReturnBase = TypeDefinitionData.FromType(typeof(FieldWithReturnBase));
			var FieldWithReturnDerived = TypeDefinitionData.FromType(typeof(FieldWithReturnDerived));
			var FieldWithReadonlyReturnBase = TypeDefinitionData.FromType(typeof(FieldWithReadonlyReturnBase));
			breakingChanges = MetadataComparer.CompareTypes(FieldWithReturnDerived, FieldWithReturnBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(FieldWithReturnDerived.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(FieldWithReturnBase.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
			breakingChanges = MetadataComparer.CompareTypes(FieldWithReturnBase, FieldWithReturnDerived);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(FieldWithReturnBase.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(FieldWithReturnDerived.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
			breakingChanges = MetadataComparer.CompareTypes(FieldWithReadonlyReturnBase, FieldWithReturnDerived);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the read-only field type changes to a base type.");

			var EventWithReturnBase = TypeDefinitionData.FromType(typeof(EventWithReturnBase));
			var EventWithReturnDerived = TypeDefinitionData.FromType(typeof(EventWithReturnDerived));
			breakingChanges = MetadataComparer.CompareTypes(EventWithReturnDerived, EventWithReturnBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventWithReturnDerived.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(EventWithReturnBase.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
			breakingChanges = MetadataComparer.CompareTypes(EventWithReturnBase, EventWithReturnDerived);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventWithReturnBase.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(EventWithReturnDerived.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ReturnTypeCovarianceTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var DelegateWithIntReturn = TypeDefinitionData.FromType(typeof(DelegateWithIntReturn));
			var DelegateWithStringReturn = TypeDefinitionData.FromType(typeof(DelegateWithStringReturn));
			var DelegateWithDynamicReturn = TypeDefinitionData.FromType(typeof(DelegateWithDynamicReturn));
			
			var breakingChanges = MetadataComparer.CompareTypes(DelegateWithIntReturn, DelegateWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithIntReturn, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithStringReturn, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithStringReturn, DelegateWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithStringReturn, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithIntReturn, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithIntReturn, DelegateWithDynamicReturn);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithDynamicReturn, DelegateWithIntReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithDynamicReturn, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithIntReturn, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithStringReturn, DelegateWithDynamicReturn);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Return type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithDynamicReturn, DelegateWithStringReturn);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Return type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithDynamicReturn, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithStringReturn, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // TypeTests

		public class NestedDelegateWithIntReturn { public delegate int Delegate(); }
		public class NestedDelegateWithStringReturn { public delegate string Delegate(); }
		public class NestedDelegateWithDynamicReturn { public delegate dynamic Delegate(); }

#pragma warning disable 0067
		public class EventWithReturnBase { public event EventHandler<ReturnBase> Event;  }
		public class EventWithReturnDerived { public event EventHandler<ReturnDerived> Event;  }
#pragma warning restore 0067

		public class FieldWithReturnBase { public ReturnBase Field; }
		public class FieldWithReturnDerived { public ReturnDerived Field; }
		public class FieldWithReadonlyReturnBase { public readonly ReturnBase Field; }

		public class MethodWithReturnBase { public ReturnBase Method() { return null; } }
		public class MethodWithReturnDerived { public ReturnDerived Method() { return null; } }

		public class ReturnBase { }
		public class ReturnDerived : ReturnBase { }


		public class ConstantWithIntReturn { public const int Constant = 0;  }
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

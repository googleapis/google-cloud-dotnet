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
	public class ChangedParameterTypeTests
	{
		#region ConstructorTests

		[TestMethod]
		public void ConstructorTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterTypeTests).Assembly);
			var ConstructorWithIntParameter = TypeDefinitionData.FromType(typeof(ConstructorWithIntParameter));
			var ConstructorWithStringParameter = TypeDefinitionData.FromType(typeof(ConstructorWithStringParameter));
			var ConstructorWithDynamicParameter = TypeDefinitionData.FromType(typeof(ConstructorWithDynamicParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(ConstructorWithIntParameter, ConstructorWithStringParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithIntParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithStringParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ConstructorWithStringParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithStringParameter, ConstructorWithIntParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithStringParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithIntParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ConstructorWithIntParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithIntParameter, ConstructorWithDynamicParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithDynamicParameter, ConstructorWithIntParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithDynamicParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithIntParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ConstructorWithIntParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithStringParameter, ConstructorWithDynamicParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithDynamicParameter, ConstructorWithStringParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithDynamicParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithStringParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ConstructorWithStringParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ConstructorTests

		#region IndexerTests

		[TestMethod]
		public void IndexerTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterTypeTests).Assembly);
			var IndexerWithIntParameter = TypeDefinitionData.FromType(typeof(IndexerWithIntParameter));
			var IndexerWithStringParameter = TypeDefinitionData.FromType(typeof(IndexerWithStringParameter));
			var IndexerWithDynamicParameter = TypeDefinitionData.FromType(typeof(IndexerWithDynamicParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(IndexerWithIntParameter, IndexerWithStringParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)IndexerWithIntParameter.GetMember("Item")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)IndexerWithStringParameter.GetMember("Item")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(IndexerWithStringParameter.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithStringParameter, IndexerWithIntParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)IndexerWithStringParameter.GetMember("Item")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)IndexerWithIntParameter.GetMember("Item")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(IndexerWithIntParameter.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithIntParameter, IndexerWithDynamicParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithDynamicParameter, IndexerWithIntParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)IndexerWithDynamicParameter.GetMember("Item")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)IndexerWithIntParameter.GetMember("Item")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(IndexerWithIntParameter.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithStringParameter, IndexerWithDynamicParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithDynamicParameter, IndexerWithStringParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)IndexerWithDynamicParameter.GetMember("Item")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)IndexerWithStringParameter.GetMember("Item")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(IndexerWithStringParameter.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // IndexerTests

		#region ModiferRestrictionsTests

		[TestMethod]
		public void ModiferRestrictionsTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterTypeTests).Assembly);
			var methodWithRefParameterBase = TypeDefinitionData.FromType(typeof(MethodWithRefParameterBase));
			var methodWithRefParameterDerived = TypeDefinitionData.FromType(typeof(MethodWithRefParameterDerived));
			var methodWithOutParameterBase = TypeDefinitionData.FromType(typeof(MethodWithOutParameterBase));
			var methodWithOutParameterDerived = TypeDefinitionData.FromType(typeof(MethodWithOutParameterDerived));
			
			var breakingChanges = MetadataComparer.CompareTypes(methodWithRefParameterBase, methodWithRefParameterDerived);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes at all on a ref parameter.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithRefParameterBase.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithRefParameterDerived.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(methodWithRefParameterDerived.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithRefParameterDerived, methodWithRefParameterBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes at all on a ref parameter.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithRefParameterDerived.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithRefParameterBase.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(methodWithRefParameterBase.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithOutParameterBase, methodWithOutParameterDerived);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes at all on an out parameter.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithOutParameterBase.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithOutParameterDerived.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(methodWithOutParameterDerived.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithOutParameterDerived, methodWithOutParameterBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes at all on an out parameter.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithOutParameterDerived.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithOutParameterBase.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(methodWithOutParameterBase.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ModiferRestrictionsTests

		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterTypeTests).Assembly);
			var MethodWithIntParameter = TypeDefinitionData.FromType(typeof(MethodWithIntParameter));
			var MethodWithStringParameter = TypeDefinitionData.FromType(typeof(MethodWithStringParameter));
			var MethodWithDynamicParameter = TypeDefinitionData.FromType(typeof(MethodWithDynamicParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(MethodWithIntParameter, MethodWithStringParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithIntParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithStringParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(MethodWithStringParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithStringParameter, MethodWithIntParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithStringParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithIntParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(MethodWithIntParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithIntParameter, MethodWithDynamicParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithDynamicParameter, MethodWithIntParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithDynamicParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithIntParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(MethodWithIntParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithStringParameter, MethodWithDynamicParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithDynamicParameter, MethodWithStringParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithDynamicParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithStringParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(MethodWithStringParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // MethodTests

		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterTypeTests).Assembly);
			var NestedDelegateWithIntParameter = TypeDefinitionData.FromType(typeof(NestedDelegateWithIntParameter));
			var NestedDelegateWithStringParameter = TypeDefinitionData.FromType(typeof(NestedDelegateWithStringParameter));
			var NestedDelegateWithDynamicParameter = TypeDefinitionData.FromType(typeof(NestedDelegateWithDynamicParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithIntParameter, NestedDelegateWithStringParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedDelegateWithIntParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedDelegateWithStringParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(NestedDelegateWithStringParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithStringParameter, NestedDelegateWithIntParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedDelegateWithStringParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedDelegateWithIntParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(NestedDelegateWithIntParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithIntParameter, NestedDelegateWithDynamicParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithDynamicParameter, NestedDelegateWithIntParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)NestedDelegateWithDynamicParameter.GetMember("Delegate")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)NestedDelegateWithIntParameter.GetMember("Delegate")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(NestedDelegateWithIntParameter.GetMember("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithStringParameter, NestedDelegateWithDynamicParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithDynamicParameter, NestedDelegateWithStringParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)NestedDelegateWithDynamicParameter.GetMember("Delegate")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)NestedDelegateWithStringParameter.GetMember("Delegate")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(NestedDelegateWithStringParameter.GetMember("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region ParameterTypeContravarianceTests

		[TestMethod]
		public void ParameterTypeContravarianceTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterTypeTests).Assembly);
			var methodWithParameterBase = TypeDefinitionData.FromType(typeof(MethodWithParameterBase));
			var methodWithParameterDerived = TypeDefinitionData.FromType(typeof(MethodWithParameterDerived));
			
			var breakingChanges = MetadataComparer.CompareTypes(methodWithParameterBase, methodWithParameterDerived);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithParameterBase.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithParameterDerived.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(methodWithParameterDerived.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithParameterDerived, methodWithParameterBase);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the parameter type changes to a base type.");
		}

		#endregion // ParameterTypeContravarianceTests

		#region OperatorTests

		[TestMethod]
		public void OperatorTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterTypeTests).Assembly);
			var OperatorWithIntParameter = TypeDefinitionData.FromType(typeof(OperatorWithIntParameter));
			var OperatorWithStringParameter = TypeDefinitionData.FromType(typeof(OperatorWithStringParameter));
			var OperatorWithDynamicParameter = TypeDefinitionData.FromType(typeof(OperatorWithDynamicParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(OperatorWithIntParameter, OperatorWithStringParameter);
			breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedParameterType).ToList();
			Assert.AreEqual(2, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)OperatorWithIntParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)OperatorWithStringParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(OperatorWithStringParameter.GetMember("op_Addition"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(OperatorWithStringParameter, OperatorWithIntParameter);
			breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedParameterType).ToList();
			Assert.AreEqual(2, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)OperatorWithStringParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            Assert.AreEqual(((IParameterizedItem)OperatorWithIntParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(OperatorWithIntParameter.GetMember("op_Addition"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(OperatorWithIntParameter, OperatorWithDynamicParameter);
			breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedParameterType).ToList();
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(OperatorWithDynamicParameter, OperatorWithIntParameter);
			breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedParameterType).ToList();
			Assert.AreEqual(2, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)OperatorWithDynamicParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)OperatorWithIntParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(OperatorWithIntParameter.GetMember("op_Addition"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(OperatorWithStringParameter, OperatorWithDynamicParameter);
			breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedParameterType).ToList();
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(OperatorWithDynamicParameter, OperatorWithStringParameter);
			breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedParameterType).ToList();
			Assert.AreEqual(2, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)OperatorWithDynamicParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)OperatorWithStringParameter.GetMember("op_Addition")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(OperatorWithStringParameter.GetMember("op_Addition"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // OperatorTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterTypeTests).Assembly);
			var DelegateWithIntParameter = TypeDefinitionData.FromType(typeof(DelegateWithIntParameter));
			var DelegateWithStringParameter = TypeDefinitionData.FromType(typeof(DelegateWithStringParameter));
			var DelegateWithDynamicParameter = TypeDefinitionData.FromType(typeof(DelegateWithDynamicParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(DelegateWithIntParameter, DelegateWithStringParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithIntParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithStringParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(DelegateWithStringParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithStringParameter, DelegateWithIntParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithStringParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithIntParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(DelegateWithIntParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithIntParameter, DelegateWithDynamicParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithDynamicParameter, DelegateWithIntParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithDynamicParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithIntParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(DelegateWithIntParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithStringParameter, DelegateWithDynamicParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the Parameter type changes to dynamic.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithDynamicParameter, DelegateWithStringParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the Parameter type changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterType, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithDynamicParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithStringParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(DelegateWithStringParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // TypeTests

		public class NestedDelegateWithIntParameter { public delegate void Delegate(int x);}
		public class NestedDelegateWithStringParameter { public delegate void Delegate(string x);}
		public class NestedDelegateWithDynamicParameter { public delegate void Delegate(dynamic x);}


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

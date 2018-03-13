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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakingChangesDetector.MetadataItems;
using BreakingChangesDetector.BreakingChanges;
using Infragistics;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	[TestClass]
	public class ChangedParameterNameTests
	{
		#region ConstructorTests

		[TestMethod]
		public void ConstructorTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterNameTests).Assembly);
			var constructorWithOldParameterName = TypeDefinitionData.FromType(typeof(ConstructorWithOldParameterName));
			var constructorWithNewParameterName = TypeDefinitionData.FromType(typeof(ConstructorWithNewParameterName));
			
			var breakingChanges = MetadataComparer.CompareTypes(constructorWithOldParameterName, constructorWithNewParameterName);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)constructorWithOldParameterName.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)constructorWithNewParameterName.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(constructorWithNewParameterName.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(constructorWithNewParameterName, constructorWithOldParameterName);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)constructorWithNewParameterName.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)constructorWithOldParameterName.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(constructorWithOldParameterName.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ConstructorTests

		#region IndexerTests

		[TestMethod]
		public void IndexerTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterNameTests).Assembly);
			var indexerWithOldParameterName = TypeDefinitionData.FromType(typeof(IndexerWithOldParameterName));
			var indexerWithNewParameterName = TypeDefinitionData.FromType(typeof(IndexerWithNewParameterName));
			
			var breakingChanges = MetadataComparer.CompareTypes(indexerWithOldParameterName, indexerWithNewParameterName);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)indexerWithOldParameterName.GetMember("Item")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)indexerWithNewParameterName.GetMember("Item")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(indexerWithNewParameterName.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(indexerWithNewParameterName, indexerWithOldParameterName);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)indexerWithNewParameterName.GetMember("Item")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)indexerWithOldParameterName.GetMember("Item")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(indexerWithOldParameterName.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // IndexerTests

		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterNameTests).Assembly);
			var methodWithOldParameterName = TypeDefinitionData.FromType(typeof(MethodWithOldParameterName));
			var methodWithNewParameterName = TypeDefinitionData.FromType(typeof(MethodWithNewParameterName));
			
			var breakingChanges = MetadataComparer.CompareTypes(methodWithOldParameterName, methodWithNewParameterName);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithOldParameterName.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithNewParameterName.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(methodWithNewParameterName.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithNewParameterName, methodWithOldParameterName);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithNewParameterName.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)methodWithOldParameterName.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(methodWithOldParameterName.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // MethodTests

		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterNameTests).Assembly);
			var nestedDelegateWithOldParameterName = TypeDefinitionData.FromType(typeof(NestedDelegateWithOldParameterName));
			var nestedDelegateWithNewParameterName = TypeDefinitionData.FromType(typeof(NestedDelegateWithNewParameterName));
			
			var breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithOldParameterName, nestedDelegateWithNewParameterName);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithOldParameterName.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithNewParameterName.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithNewParameterName.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithNewParameterName, nestedDelegateWithOldParameterName);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithNewParameterName.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithOldParameterName.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithOldParameterName.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region OperatorTests

		[TestMethod]
		public void OperatorTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterNameTests).Assembly);
			var OperatorWithOldParameterName = TypeDefinitionData.FromType(typeof(OperatorWithOldParameterName));
			var OperatorWithNewParameterName = TypeDefinitionData.FromType(typeof(OperatorWithNewParameterName));
			
			var breakingChanges = MetadataComparer.CompareTypes(OperatorWithOldParameterName, OperatorWithNewParameterName);
			Assert.AreEqual(0, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
		}

		#endregion // OperatorTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterNameTests).Assembly);
			var delegateWithOldParameterName = TypeDefinitionData.FromType(typeof(DelegateWithOldParameterName));
			var delegateWithNewParameterName = TypeDefinitionData.FromType(typeof(DelegateWithNewParameterName));
			
			var breakingChanges = MetadataComparer.CompareTypes(delegateWithOldParameterName, delegateWithNewParameterName);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(delegateWithOldParameterName.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(delegateWithNewParameterName.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(delegateWithNewParameterName, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(delegateWithNewParameterName, delegateWithOldParameterName);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter name changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterName, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(delegateWithNewParameterName.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(delegateWithOldParameterName.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(delegateWithOldParameterName, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // TypeTests

		public class NestedDelegateWithOldParameterName { public delegate void Delegate(int x);}
		public class NestedDelegateWithNewParameterName { public delegate void Delegate(int y);}


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

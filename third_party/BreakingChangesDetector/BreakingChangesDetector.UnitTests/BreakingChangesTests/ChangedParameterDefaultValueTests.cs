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

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	[TestClass]
	public class ChangedParameterDefaultValueTests
	{
		#region ConstructorTests

		[TestMethod]
		public void ConstructorTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterDefaultValueTests).Assembly);
			var ConstructorWithDefault0 = TypeDefinitionData.FromType(typeof(ConstructorWithDefault0));
			var ConstructorWithDefault1 = TypeDefinitionData.FromType(typeof(ConstructorWithDefault1));
			
			var breakingChanges = MetadataComparer.CompareTypes(ConstructorWithDefault0, ConstructorWithDefault1);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithDefault0.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithDefault1.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ConstructorWithDefault1.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithDefault1, ConstructorWithDefault0);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithDefault1.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithDefault0.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ConstructorWithDefault0.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ConstructorTests

		#region IndexerTests

		[TestMethod]
		public void IndexerTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterDefaultValueTests).Assembly);
			var IndexerWithDefault0 = TypeDefinitionData.FromType(typeof(IndexerWithDefault0));
			var IndexerWithDefault1 = TypeDefinitionData.FromType(typeof(IndexerWithDefault1));
			
			var breakingChanges = MetadataComparer.CompareTypes(IndexerWithDefault0, IndexerWithDefault1);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)IndexerWithDefault0.GetMember("Item")).Parameters[1], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)IndexerWithDefault1.GetMember("Item")).Parameters[1], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(IndexerWithDefault1.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithDefault1, IndexerWithDefault0);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)IndexerWithDefault1.GetMember("Item")).Parameters[1], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)IndexerWithDefault0.GetMember("Item")).Parameters[1], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(IndexerWithDefault0.GetMember("Item"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // IndexerTests

		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterDefaultValueTests).Assembly);
			var MethodWithDefault0 = TypeDefinitionData.FromType(typeof(MethodWithDefault0));
			var MethodWithDefault1 = TypeDefinitionData.FromType(typeof(MethodWithDefault1));
			
			var breakingChanges = MetadataComparer.CompareTypes(MethodWithDefault0, MethodWithDefault1);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodWithDefault0.GetMethod("Method").Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodWithDefault1.GetMethod("Method").Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(MethodWithDefault1.GetMethod("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithDefault1, MethodWithDefault0);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodWithDefault1.GetMethod("Method").Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodWithDefault0.GetMethod("Method").Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(MethodWithDefault0.GetMethod("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // MethodTests

		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterDefaultValueTests).Assembly);
			var nestedDelegateWithDefault0 = TypeDefinitionData.FromType(typeof(NestedDelegateWithDefault0));
			var nestedDelegateWithDefault1 = TypeDefinitionData.FromType(typeof(NestedDelegateWithDefault1));
			
			var breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithDefault0, nestedDelegateWithDefault1);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithDefault0.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithDefault1.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithDefault1.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithDefault1, nestedDelegateWithDefault0);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithDefault1.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithDefault0.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithDefault0.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterDefaultValueTests).Assembly);
			var DelegateWithDefault0 = TypeDefinitionData.FromType(typeof(DelegateWithDefault0));
			var DelegateWithDefault1 = TypeDefinitionData.FromType(typeof(DelegateWithDefault1));
			
			var breakingChanges = MetadataComparer.CompareTypes(DelegateWithDefault0, DelegateWithDefault1);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithDefault0.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithDefault1.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(DelegateWithDefault1, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithDefault1, DelegateWithDefault0);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterDefaultValue, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithDefault1.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithDefault0.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(DelegateWithDefault0, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // TypeTests

		public class NestedDelegateWithDefault0 { public delegate void Delegate(int x = 0);}
		public class NestedDelegateWithDefault1 { public delegate void Delegate(int x = 1);}


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

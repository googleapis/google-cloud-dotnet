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
	public class ChangedParameterCountTests
	{
		#region ConstructorTests

		[TestMethod]
		public void ConstructorTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterCountTests).Assembly);
			var ConstructorWithFewerParameters = TypeDefinitionData.FromType(typeof(ConstructorWithFewerParameters));
			var ConstructorWithMoreParameters = TypeDefinitionData.FromType(typeof(ConstructorWithMoreParameters));
			var ConstructorWithOptionalParameter = TypeDefinitionData.FromType(typeof(ConstructorWithOptionalParameter));
			var ConstructorWithParamsParameter = TypeDefinitionData.FromType(typeof(ConstructorWithParamsParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(ConstructorWithFewerParameters, ConstructorWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ConstructorWithFewerParameters.GetMember(".ctor"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(ConstructorWithMoreParameters.GetMember(".ctor"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithMoreParameters, ConstructorWithFewerParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ConstructorWithMoreParameters.GetMember(".ctor"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(ConstructorWithFewerParameters.GetMember(".ctor"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithMoreParameters, ConstructorWithOptionalParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a required parameter is made optional.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithFewerParameters, ConstructorWithOptionalParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an optional parameter is added.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithOptionalParameter, ConstructorWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ConstructorWithOptionalParameter.GetMember(".ctor"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(ConstructorWithMoreParameters.GetMember(".ctor"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithFewerParameters, ConstructorWithParamsParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an params parameter is added.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithParamsParameter, ConstructorWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ConstructorWithParamsParameter.GetMember(".ctor"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(ConstructorWithMoreParameters.GetMember(".ctor"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ConstructorTests

		#region IndexerTests

		[TestMethod]
		public void IndexerTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterCountTests).Assembly);
			var IndexerWithFewerParameters = TypeDefinitionData.FromType(typeof(IndexerWithFewerParameters));
			var IndexerWithMoreParameters = TypeDefinitionData.FromType(typeof(IndexerWithMoreParameters));
			var IndexerWithOptionalParameter = TypeDefinitionData.FromType(typeof(IndexerWithOptionalParameter));
			var IndexerWithParamsParameter = TypeDefinitionData.FromType(typeof(IndexerWithParamsParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(IndexerWithFewerParameters, IndexerWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerWithFewerParameters.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerWithMoreParameters.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithMoreParameters, IndexerWithFewerParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerWithMoreParameters.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerWithFewerParameters.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithMoreParameters, IndexerWithOptionalParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a required parameter is made optional.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithFewerParameters, IndexerWithOptionalParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an optional parameter is added.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithOptionalParameter, IndexerWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerWithOptionalParameter.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerWithMoreParameters.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithFewerParameters, IndexerWithParamsParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an params parameter is added.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerWithParamsParameter, IndexerWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerWithParamsParameter.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerWithMoreParameters.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // IndexerTests

		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterCountTests).Assembly);
			var MethodWithFewerParameters = TypeDefinitionData.FromType(typeof(MethodWithFewerParameters));
			var MethodWithMoreParameters = TypeDefinitionData.FromType(typeof(MethodWithMoreParameters));
			var MethodWithOptionalParameter = TypeDefinitionData.FromType(typeof(MethodWithOptionalParameter));
			var MethodWithParamsParameter = TypeDefinitionData.FromType(typeof(MethodWithParamsParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(MethodWithFewerParameters, MethodWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodWithFewerParameters.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodWithMoreParameters.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithMoreParameters, MethodWithFewerParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodWithMoreParameters.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodWithFewerParameters.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithMoreParameters, MethodWithOptionalParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a required parameter is made optional.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithFewerParameters, MethodWithOptionalParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an optional parameter is added.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithOptionalParameter, MethodWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodWithOptionalParameter.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodWithMoreParameters.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithFewerParameters, MethodWithParamsParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an params parameter is added.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithParamsParameter, MethodWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodWithParamsParameter.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodWithMoreParameters.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // MethodTests

		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterCountTests).Assembly);
			var nestedDelegateWithFewerParameters = TypeDefinitionData.FromType(typeof(NestedDelegateWithFewerParameters));
			var nestedDelegateWithMoreParameters = TypeDefinitionData.FromType(typeof(NestedDelegateWithMoreParameters));
			var nestedDelegateWithOptionalParameter = TypeDefinitionData.FromType(typeof(NestedDelegateWithOptionalParameter));
			var nestedDelegateWithParamsParameter = TypeDefinitionData.FromType(typeof(NestedDelegateWithParamsParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithFewerParameters, nestedDelegateWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithFewerParameters.GetNestedType("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithMoreParameters.GetNestedType("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithMoreParameters, nestedDelegateWithFewerParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithMoreParameters.GetNestedType("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithFewerParameters.GetNestedType("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithMoreParameters, nestedDelegateWithOptionalParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a required parameter is made optional.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithFewerParameters, nestedDelegateWithOptionalParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an optional parameter is added.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithOptionalParameter, nestedDelegateWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithOptionalParameter.GetNestedType("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithMoreParameters.GetNestedType("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithFewerParameters, nestedDelegateWithParamsParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an params parameter is added.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithParamsParameter, nestedDelegateWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithParamsParameter.GetNestedType("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithMoreParameters.GetNestedType("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterCountTests).Assembly);
			var DelegateWithFewerParameters = TypeDefinitionData.FromType(typeof(DelegateWithFewerParameters));
			var DelegateWithMoreParameters = TypeDefinitionData.FromType(typeof(DelegateWithMoreParameters));
			var DelegateWithOptionalParameter = TypeDefinitionData.FromType(typeof(DelegateWithOptionalParameter));
			var DelegateWithParamsParameter = TypeDefinitionData.FromType(typeof(DelegateWithParamsParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(DelegateWithFewerParameters, DelegateWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithFewerParameters, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithMoreParameters, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithMoreParameters, DelegateWithFewerParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithMoreParameters, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithFewerParameters, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithMoreParameters, DelegateWithOptionalParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a required parameter is made optional.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithFewerParameters, DelegateWithOptionalParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an optional parameter is added.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithOptionalParameter, DelegateWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithOptionalParameter, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithMoreParameters, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithFewerParameters, DelegateWithParamsParameter);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an params parameter is added.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithParamsParameter, DelegateWithMoreParameters);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithParamsParameter, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithMoreParameters, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // TypeTests

		public class NestedDelegateWithFewerParameters { public delegate void Delegate(int x);}
		public class NestedDelegateWithMoreParameters { public delegate void Delegate(int x, int[] y);}
		public class NestedDelegateWithOptionalParameter { public delegate void Delegate(int x, int[] y = null);}
		public class NestedDelegateWithParamsParameter { public delegate void Delegate(int x, params int[] y);}


		public delegate void DelegateWithFewerParameters(int x);
		public delegate void DelegateWithMoreParameters(int x, int[] y);
		public delegate void DelegateWithOptionalParameter(int x, int[] y = null);
		public delegate void DelegateWithParamsParameter(int x, params int[] y);

		public class ConstructorWithFewerParameters { public ConstructorWithFewerParameters(int x) { } }
		public class ConstructorWithMoreParameters { public ConstructorWithMoreParameters(int x, int[] y) { } }
		public class ConstructorWithOptionalParameter { public ConstructorWithOptionalParameter(int x, int[] y = null) { } }
		public class ConstructorWithParamsParameter { public ConstructorWithParamsParameter(int x, params int[] y) { } }

		public class IndexerWithFewerParameters { public int this[int x] { get { return 0; } } }
		public class IndexerWithMoreParameters { public int this[int x, int[] y] { get { return 0; } } }
		public class IndexerWithOptionalParameter { public int this[int x, int[] y = null] { get { return 0; } } }
		public class IndexerWithParamsParameter { public int this[int x, params int[] y] { get { return 0; } } }

		public class MethodWithFewerParameters { public void Method(int x) { } }
		public class MethodWithMoreParameters { public void Method(int x, int[] y) { } }
		public class MethodWithOptionalParameter { public void Method(int x, int[] y = null) { } }
		public class MethodWithParamsParameter { public void Method(int x, params int[] y) { } }
	}
}

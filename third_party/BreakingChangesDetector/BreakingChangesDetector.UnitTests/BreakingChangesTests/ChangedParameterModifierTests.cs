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
	public class ChangedParameterModifierTests
	{
		#region ConstructorTests

		[TestMethod]
		public void ConstructorTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterModifierTests).Assembly);
			var ConstructorWithUnmodifiedParameter = TypeDefinitionData.FromType(typeof(ConstructorWithUnmodifiedParameter));
			var ConstructorWithRefParameter = TypeDefinitionData.FromType(typeof(ConstructorWithRefParameter));
			var ConstructorWithOutParameter = TypeDefinitionData.FromType(typeof(ConstructorWithOutParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(ConstructorWithUnmodifiedParameter, ConstructorWithRefParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithUnmodifiedParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithRefParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ConstructorWithRefParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithRefParameter, ConstructorWithUnmodifiedParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithRefParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithUnmodifiedParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ConstructorWithUnmodifiedParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithUnmodifiedParameter, ConstructorWithOutParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithUnmodifiedParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithOutParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ConstructorWithOutParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithOutParameter, ConstructorWithUnmodifiedParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithOutParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithUnmodifiedParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ConstructorWithUnmodifiedParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithRefParameter, ConstructorWithOutParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithRefParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithOutParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ConstructorWithOutParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithOutParameter, ConstructorWithRefParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithOutParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)ConstructorWithRefParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ConstructorWithRefParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ConstructorTests

		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterModifierTests).Assembly);
			var MethodWithUnmodifiedParameter = TypeDefinitionData.FromType(typeof(MethodWithUnmodifiedParameter));
			var MethodWithRefParameter = TypeDefinitionData.FromType(typeof(MethodWithRefParameter));
			var MethodWithOutParameter = TypeDefinitionData.FromType(typeof(MethodWithOutParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(MethodWithUnmodifiedParameter, MethodWithRefParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithUnmodifiedParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithRefParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(MethodWithRefParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithRefParameter, MethodWithUnmodifiedParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithRefParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithUnmodifiedParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(MethodWithUnmodifiedParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithUnmodifiedParameter, MethodWithOutParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithUnmodifiedParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithOutParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(MethodWithOutParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithOutParameter, MethodWithUnmodifiedParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithOutParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithUnmodifiedParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(MethodWithUnmodifiedParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithRefParameter, MethodWithOutParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithRefParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithOutParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(MethodWithOutParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithOutParameter, MethodWithRefParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithOutParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((IParameterizedItem)MethodWithRefParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(MethodWithRefParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // MethodTests

		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterModifierTests).Assembly);
			var NestedDelegateWithUnmodifiedParameter = TypeDefinitionData.FromType(typeof(NestedDelegateWithUnmodifiedParameter));
			var NestedDelegateWithRefParameter = TypeDefinitionData.FromType(typeof(NestedDelegateWithRefParameter));
			var NestedDelegateWithOutParameter = TypeDefinitionData.FromType(typeof(NestedDelegateWithOutParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithUnmodifiedParameter, NestedDelegateWithRefParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedDelegateWithUnmodifiedParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedDelegateWithRefParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            Assert.AreEqual(NestedDelegateWithRefParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithRefParameter, NestedDelegateWithUnmodifiedParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedDelegateWithRefParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedDelegateWithUnmodifiedParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            Assert.AreEqual(NestedDelegateWithUnmodifiedParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithUnmodifiedParameter, NestedDelegateWithOutParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedDelegateWithUnmodifiedParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedDelegateWithOutParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            Assert.AreEqual(NestedDelegateWithOutParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithOutParameter, NestedDelegateWithUnmodifiedParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedDelegateWithOutParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedDelegateWithUnmodifiedParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            Assert.AreEqual(NestedDelegateWithUnmodifiedParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithRefParameter, NestedDelegateWithOutParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedDelegateWithRefParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedDelegateWithOutParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            Assert.AreEqual(NestedDelegateWithOutParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithOutParameter, NestedDelegateWithRefParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedDelegateWithOutParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedDelegateWithRefParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            Assert.AreEqual(NestedDelegateWithRefParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedParameterModifierTests).Assembly);
			var DelegateWithUnmodifiedParameter = TypeDefinitionData.FromType(typeof(DelegateWithUnmodifiedParameter));
			var DelegateWithRefParameter = TypeDefinitionData.FromType(typeof(DelegateWithRefParameter));
			var DelegateWithOutParameter = TypeDefinitionData.FromType(typeof(DelegateWithOutParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(DelegateWithUnmodifiedParameter, DelegateWithRefParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithUnmodifiedParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithRefParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            Assert.AreEqual(DelegateWithRefParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithRefParameter, DelegateWithUnmodifiedParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithRefParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithUnmodifiedParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            Assert.AreEqual(DelegateWithUnmodifiedParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithUnmodifiedParameter, DelegateWithOutParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithUnmodifiedParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithOutParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            Assert.AreEqual(DelegateWithOutParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithOutParameter, DelegateWithUnmodifiedParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithOutParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithUnmodifiedParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            Assert.AreEqual(DelegateWithUnmodifiedParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithRefParameter, DelegateWithOutParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithRefParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithOutParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            Assert.AreEqual(DelegateWithOutParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithOutParameter, DelegateWithRefParameter);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(DelegateWithOutParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(DelegateWithRefParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            Assert.AreEqual(DelegateWithRefParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // TypeTests

		public class NestedDelegateWithUnmodifiedParameter { public delegate void Delegate(int x);}
		public class NestedDelegateWithRefParameter { public delegate void Delegate(ref int x);}
		public class NestedDelegateWithOutParameter { public delegate void Delegate(out int x);}

		public delegate void DelegateWithUnmodifiedParameter(int x);
		public delegate void DelegateWithRefParameter(ref int x);
		public delegate void DelegateWithOutParameter(out int x);

		public class ConstructorWithUnmodifiedParameter { public ConstructorWithUnmodifiedParameter(int x) { } }
		public class ConstructorWithRefParameter { public ConstructorWithRefParameter(ref int x) { } }
		public class ConstructorWithOutParameter { public ConstructorWithOutParameter(out int x) { x = 0; } }

		public class MethodWithUnmodifiedParameter { public void Method(int x) { } }
		public class MethodWithRefParameter { public void Method(ref int x) { } }
		public class MethodWithOutParameter { public void Method(out int x) { x = 0; } }
	}
}

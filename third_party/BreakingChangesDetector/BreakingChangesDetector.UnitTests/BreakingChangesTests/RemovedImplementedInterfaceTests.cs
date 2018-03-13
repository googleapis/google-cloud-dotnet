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

using BreakingChangesDetector.BreakingChanges;
using BreakingChangesDetector.MetadataItems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	[TestClass]
	public class RemovedImplementedInterfaceTests
	{
		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var nestedClassImplementingBase = TypeDefinitionData.FromType(typeof(NestedClassImplementingBase));
			var nestedClassImplementingDerived = TypeDefinitionData.FromType(typeof(NestedClassImplementingDerived));
			var nestedClassImplementingNothing = TypeDefinitionData.FromType(typeof(NestedClassImplementingNothing));
			
			var breakingChanges = MetadataComparer.CompareTypes(nestedClassImplementingBase, nestedClassImplementingDerived);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the new type implements a more specialized interface.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassImplementingBase, nestedClassImplementingNothing);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the new type does not implement the same interface.");
			Assert.AreEqual(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassImplementingBase.GetMember("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassImplementingNothing.GetMember("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NestedBaseInterface.Interface)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassImplementingDerived, nestedClassImplementingBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the new type implements a less specialized interface.");
			Assert.AreEqual(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassImplementingDerived.GetMember("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassImplementingBase.GetMember("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NestedDerivedInterface.Interface)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassImplementingDerived, nestedClassImplementingNothing);
			Assert.AreEqual(2, breakingChanges.Count, "There should be one breaking change when the new type does not implement the same interface.");
			Assert.AreEqual(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassImplementingDerived.GetMember("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassImplementingNothing.GetMember("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NestedDerivedInterface.Interface)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
			Assert.AreEqual(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[1].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassImplementingDerived.GetMember("Class"), breakingChanges[1].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassImplementingNothing.GetMember("Class"), breakingChanges[1].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NestedBaseInterface.Interface)), breakingChanges[1].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var classImplementingBase = TypeDefinitionData.FromType(typeof(ClassImplementingBase));
			var classImplementingDerived = TypeDefinitionData.FromType(typeof(ClassImplementingDerived));
			var classImplementingNothing = TypeDefinitionData.FromType(typeof(ClassImplementingNothing));
			
			var breakingChanges = MetadataComparer.CompareTypes(classImplementingBase, classImplementingDerived);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the new type implements a more specialized interface.");

			breakingChanges = MetadataComparer.CompareTypes(classImplementingBase, classImplementingNothing);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the new type does not implement the same interface.");
			Assert.AreEqual(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classImplementingBase, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classImplementingNothing, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(BaseInterface)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classImplementingDerived, classImplementingBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the new type implements a less specialized interface.");
			Assert.AreEqual(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classImplementingDerived, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classImplementingBase, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(DerivedInterface)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classImplementingDerived, classImplementingNothing);
			Assert.AreEqual(2, breakingChanges.Count, "There should be one breaking change when the new type does not implement the same interface.");
			Assert.AreEqual(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classImplementingDerived, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classImplementingNothing, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(DerivedInterface)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
			Assert.AreEqual(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[1].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classImplementingDerived, breakingChanges[1].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classImplementingNothing, breakingChanges[1].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(BaseInterface)), breakingChanges[1].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // TypeTests

		public class NestedBaseInterface { public interface Interface { } }
		public class NestedDerivedInterface { public interface Interface : NestedBaseInterface.Interface { } }

		public class NestedClassImplementingBase { public class Class : NestedBaseInterface.Interface { } }
		public class NestedClassImplementingDerived { public class Class : NestedDerivedInterface.Interface { } }
		public class NestedClassImplementingNothing { public class Class { } }

		public class ClassImplementingBase : BaseInterface { }
		public class ClassImplementingDerived : DerivedInterface { }
		public class ClassImplementingNothing { }
	}
}

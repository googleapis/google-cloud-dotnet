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
	public class AddedBaseInterfaceTests
	{
		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var NestedInterfaceImplementingNothing = TypeDefinitionData.FromType(typeof(NestedInterfaceImplementingNothing));
			var NestedInterfaceImplementingBase = TypeDefinitionData.FromType(typeof(NestedInterfaceImplementingBase));
			var NestedInterfaceImplementingDerived = TypeDefinitionData.FromType(typeof(NestedInterfaceImplementingDerived));
			var NestedInterfaceImplementingDerivedAndBase = TypeDefinitionData.FromType(typeof(NestedInterfaceImplementingDerivedAndBase));
			var NestedInterfaceImplementingInterfaceWithNoMembers = TypeDefinitionData.FromType(typeof(NestedInterfaceImplementingInterfaceWithNoMembers));
			
			var breakingChanges = MetadataComparer.CompareTypes(NestedInterfaceImplementingNothing, NestedInterfaceImplementingBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an interface is added.");
			Assert.AreEqual(BreakingChangeKind.AddedBaseInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedInterfaceImplementingNothing.GetMember("Interface"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedInterfaceImplementingBase.GetMember("Interface"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(BaseInterfaceWithMembers)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedInterfaceImplementingNothing, NestedInterfaceImplementingDerived);
			Assert.AreEqual(2, breakingChanges.Count, "There should be breaking changes when an interfaces are added.");
			// These might need to be reversed
			Assert.AreEqual(BreakingChangeKind.AddedBaseInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedInterfaceImplementingNothing.GetMember("Interface"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedInterfaceImplementingDerived.GetMember("Interface"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(DerivedInterfaceWithMembers)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
			Assert.AreEqual(BreakingChangeKind.AddedBaseInterface, breakingChanges[1].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedInterfaceImplementingNothing.GetMember("Interface"), breakingChanges[1].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedInterfaceImplementingDerived.GetMember("Interface"), breakingChanges[1].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(BaseInterfaceWithMembers)), breakingChanges[1].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedInterfaceImplementingBase, NestedInterfaceImplementingDerived);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an interface is added.");
			Assert.AreEqual(BreakingChangeKind.AddedBaseInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedInterfaceImplementingBase.GetMember("Interface"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedInterfaceImplementingDerived.GetMember("Interface"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(DerivedInterfaceWithMembers)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedInterfaceImplementingDerived, NestedInterfaceImplementingDerivedAndBase);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an interface already implemented is added.");

			breakingChanges = MetadataComparer.CompareTypes(NestedInterfaceImplementingNothing, NestedInterfaceImplementingInterfaceWithNoMembers);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an interface is added but contains no members.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var InterfaceImplementingNothing = TypeDefinitionData.FromType(typeof(InterfaceImplementingNothing));
			var InterfaceImplementingBase = TypeDefinitionData.FromType(typeof(InterfaceImplementingBase));
			var InterfaceImplementingDerived = TypeDefinitionData.FromType(typeof(InterfaceImplementingDerived));
			var InterfaceImplementingDerivedAndBase = TypeDefinitionData.FromType(typeof(InterfaceImplementingDerivedAndBase));
			var InterfaceImplementingInterfaceWithNoMembers = TypeDefinitionData.FromType(typeof(InterfaceImplementingInterfaceWithNoMembers));
			
			var breakingChanges = MetadataComparer.CompareTypes(InterfaceImplementingNothing, InterfaceImplementingBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an interface is added.");
			Assert.AreEqual(BreakingChangeKind.AddedBaseInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(InterfaceImplementingNothing, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(InterfaceImplementingBase, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(BaseInterfaceWithMembers)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(InterfaceImplementingNothing, InterfaceImplementingDerived);
			Assert.AreEqual(2, breakingChanges.Count, "There should be breaking changes when an interfaces are added.");
			// These might need to be reversed
			Assert.AreEqual(BreakingChangeKind.AddedBaseInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(InterfaceImplementingNothing, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(InterfaceImplementingDerived, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(DerivedInterfaceWithMembers)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
			Assert.AreEqual(BreakingChangeKind.AddedBaseInterface, breakingChanges[1].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(InterfaceImplementingNothing, breakingChanges[1].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(InterfaceImplementingDerived, breakingChanges[1].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(BaseInterfaceWithMembers)), breakingChanges[1].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(InterfaceImplementingBase, InterfaceImplementingDerived);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an interface is added.");
			Assert.AreEqual(BreakingChangeKind.AddedBaseInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(InterfaceImplementingBase, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(InterfaceImplementingDerived, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(DerivedInterfaceWithMembers)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(InterfaceImplementingDerived, InterfaceImplementingDerivedAndBase);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an interface already implemented is added.");

			breakingChanges = MetadataComparer.CompareTypes(InterfaceImplementingNothing, InterfaceImplementingInterfaceWithNoMembers);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an interface is added but contains no members.");
		}

		#endregion // TypeTests

		public interface BaseInterfaceWithMembers { void Method(); }
		public interface DerivedInterfaceWithMembers : BaseInterfaceWithMembers { void Method2(); }
		public interface InterfaceWithNoMembers { }

		public interface InterfaceImplementingNothing { }
		public interface InterfaceImplementingBase : BaseInterfaceWithMembers { }
		public interface InterfaceImplementingDerived : DerivedInterfaceWithMembers { }
		public interface InterfaceImplementingDerivedAndBase : DerivedInterfaceWithMembers, BaseInterfaceWithMembers { }
		public interface InterfaceImplementingInterfaceWithNoMembers : InterfaceWithNoMembers { }


		public class NestedInterfaceImplementingNothing { public interface Interface { } }
		public class NestedInterfaceImplementingBase { public interface Interface : BaseInterfaceWithMembers { } }
		public class NestedInterfaceImplementingDerived { public interface Interface : DerivedInterfaceWithMembers { } }
		public class NestedInterfaceImplementingDerivedAndBase { public interface Interface : DerivedInterfaceWithMembers, BaseInterfaceWithMembers { } }
		public class NestedInterfaceImplementingInterfaceWithNoMembers { public interface Interface : InterfaceWithNoMembers { } }
	}
}

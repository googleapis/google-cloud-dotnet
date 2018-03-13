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
	public class AddedInterfaceMemberTests
	{
		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var nestedInterfaceWithNoMembers = TypeDefinitionData.FromType(typeof(NestedInterfaceWithNoMembers));
			var nestedInterfaceWithEvent = TypeDefinitionData.FromType(typeof(NestedInterfaceWithEvent));
			var nestedInterfaceWithIndexer = TypeDefinitionData.FromType(typeof(NestedInterfaceWithIndexer));
			var nestedInterfaceWithMethod = TypeDefinitionData.FromType(typeof(NestedInterfaceWithMethod));
			var nestedInterfaceWithProperty = TypeDefinitionData.FromType(typeof(NestedInterfaceWithProperty));
			
			var breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithNoMembers, nestedInterfaceWithEvent);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
			Assert.AreEqual(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.IsNull(breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedInterfaceWithEvent.GetNestedType("Interface").GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithNoMembers, nestedInterfaceWithIndexer);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
			Assert.AreEqual(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.IsNull(breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedInterfaceWithIndexer.GetNestedType("Interface").GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithNoMembers, nestedInterfaceWithMethod);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
			Assert.AreEqual(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.IsNull(breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedInterfaceWithMethod.GetNestedType("Interface").GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithNoMembers, nestedInterfaceWithProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
			Assert.AreEqual(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.IsNull(breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedInterfaceWithProperty.GetNestedType("Interface").GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var interfaceWithNoMembers = TypeDefinitionData.FromType(typeof(InterfaceWithNoMembers));
			var interfaceWithEvent = TypeDefinitionData.FromType(typeof(InterfaceWithEvent));
			var interfaceWithIndexer = TypeDefinitionData.FromType(typeof(InterfaceWithIndexer));
			var interfaceWithMethod = TypeDefinitionData.FromType(typeof(InterfaceWithMethod));
			var interfaceWithProperty = TypeDefinitionData.FromType(typeof(InterfaceWithProperty));
			
			var breakingChanges = MetadataComparer.CompareTypes(interfaceWithNoMembers, interfaceWithEvent);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
			Assert.AreEqual(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.IsNull(breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(interfaceWithEvent.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(interfaceWithNoMembers, interfaceWithIndexer);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
			Assert.AreEqual(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.IsNull(breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(interfaceWithIndexer.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(interfaceWithNoMembers, interfaceWithMethod);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
			Assert.AreEqual(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.IsNull(breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(interfaceWithMethod.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(interfaceWithNoMembers, interfaceWithProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an interface member is added.");
			Assert.AreEqual(BreakingChangeKind.AddedInterfaceMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.IsNull(breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(interfaceWithProperty.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // TypeTests
	}
}

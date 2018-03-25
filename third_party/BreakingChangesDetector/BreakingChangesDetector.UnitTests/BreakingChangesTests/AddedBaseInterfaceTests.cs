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

using BreakingChangesDetector.BreakingChanges;
using BreakingChangesDetector.MetadataItems;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	public class AddedBaseInterfaceTests
	{
		#region NestedTypeTests

		[Fact]
		public void NestedTypeTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
			var NestedInterfaceImplementingNothing = context.GetTypeDefinitionData(typeof(NestedInterfaceImplementingNothing));
			var NestedInterfaceImplementingBase = context.GetTypeDefinitionData(typeof(NestedInterfaceImplementingBase));
			var NestedInterfaceImplementingDerived = context.GetTypeDefinitionData(typeof(NestedInterfaceImplementingDerived));
			var NestedInterfaceImplementingDerivedAndBase = context.GetTypeDefinitionData(typeof(NestedInterfaceImplementingDerivedAndBase));
			var NestedInterfaceImplementingInterfaceWithNoMembers = context.GetTypeDefinitionData(typeof(NestedInterfaceImplementingInterfaceWithNoMembers));
			
			var breakingChanges = MetadataComparer.CompareTypes(NestedInterfaceImplementingNothing, NestedInterfaceImplementingBase);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an interface is added.");
			AssertX.Equal(BreakingChangeKind.AddedBaseInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(NestedInterfaceImplementingNothing.GetMember("Interface"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(NestedInterfaceImplementingBase.GetMember("Interface"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(context.GetTypeDefinitionData(typeof(BaseInterfaceWithMembers)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedInterfaceImplementingNothing, NestedInterfaceImplementingDerived);
			AssertX.Equal(2, breakingChanges.Count, "There should be breaking changes when an interfaces are added.");
			// These might need to be reversed
			AssertX.Equal(BreakingChangeKind.AddedBaseInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(NestedInterfaceImplementingNothing.GetMember("Interface"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(NestedInterfaceImplementingDerived.GetMember("Interface"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(context.GetTypeDefinitionData(typeof(DerivedInterfaceWithMembers)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
			AssertX.Equal(BreakingChangeKind.AddedBaseInterface, breakingChanges[1].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(NestedInterfaceImplementingNothing.GetMember("Interface"), breakingChanges[1].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(NestedInterfaceImplementingDerived.GetMember("Interface"), breakingChanges[1].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(context.GetTypeDefinitionData(typeof(BaseInterfaceWithMembers)), breakingChanges[1].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedInterfaceImplementingBase, NestedInterfaceImplementingDerived);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an interface is added.");
			AssertX.Equal(BreakingChangeKind.AddedBaseInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(NestedInterfaceImplementingBase.GetMember("Interface"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(NestedInterfaceImplementingDerived.GetMember("Interface"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(context.GetTypeDefinitionData(typeof(DerivedInterfaceWithMembers)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedInterfaceImplementingDerived, NestedInterfaceImplementingDerivedAndBase);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an interface already implemented is added.");

			breakingChanges = MetadataComparer.CompareTypes(NestedInterfaceImplementingNothing, NestedInterfaceImplementingInterfaceWithNoMembers);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an interface is added but contains no members.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[Fact]
		public void TypeTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
			var InterfaceImplementingNothing = context.GetTypeDefinitionData(typeof(InterfaceImplementingNothing));
			var InterfaceImplementingBase = context.GetTypeDefinitionData(typeof(InterfaceImplementingBase));
			var InterfaceImplementingDerived = context.GetTypeDefinitionData(typeof(InterfaceImplementingDerived));
			var InterfaceImplementingDerivedAndBase = context.GetTypeDefinitionData(typeof(InterfaceImplementingDerivedAndBase));
			var InterfaceImplementingInterfaceWithNoMembers = context.GetTypeDefinitionData(typeof(InterfaceImplementingInterfaceWithNoMembers));
			
			var breakingChanges = MetadataComparer.CompareTypes(InterfaceImplementingNothing, InterfaceImplementingBase);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an interface is added.");
			AssertX.Equal(BreakingChangeKind.AddedBaseInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(InterfaceImplementingNothing, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(InterfaceImplementingBase, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(context.GetTypeDefinitionData(typeof(BaseInterfaceWithMembers)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(InterfaceImplementingNothing, InterfaceImplementingDerived);
			AssertX.Equal(2, breakingChanges.Count, "There should be breaking changes when an interfaces are added.");
			// These might need to be reversed
			AssertX.Equal(BreakingChangeKind.AddedBaseInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(InterfaceImplementingNothing, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(InterfaceImplementingDerived, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(context.GetTypeDefinitionData(typeof(DerivedInterfaceWithMembers)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
			AssertX.Equal(BreakingChangeKind.AddedBaseInterface, breakingChanges[1].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(InterfaceImplementingNothing, breakingChanges[1].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(InterfaceImplementingDerived, breakingChanges[1].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(context.GetTypeDefinitionData(typeof(BaseInterfaceWithMembers)), breakingChanges[1].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(InterfaceImplementingBase, InterfaceImplementingDerived);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an interface is added.");
			AssertX.Equal(BreakingChangeKind.AddedBaseInterface, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(InterfaceImplementingBase, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(InterfaceImplementingDerived, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(context.GetTypeDefinitionData(typeof(DerivedInterfaceWithMembers)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(InterfaceImplementingDerived, InterfaceImplementingDerivedAndBase);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an interface already implemented is added.");

			breakingChanges = MetadataComparer.CompareTypes(InterfaceImplementingNothing, InterfaceImplementingInterfaceWithNoMembers);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an interface is added but contains no members.");
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

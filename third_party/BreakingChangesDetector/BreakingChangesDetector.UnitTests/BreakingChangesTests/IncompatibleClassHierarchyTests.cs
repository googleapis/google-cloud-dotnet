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
	public class IncompatibleClassHierarchyTests
	{
		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var nestedDerivedFromBase = TypeDefinitionData.FromType(typeof(NestedDerivedFromBase));
			var nestedDerivedFromSpecializedBase = TypeDefinitionData.FromType(typeof(NestedDerivedFromSpecializedBase));
			var nestedDerivedFromOtherBase = TypeDefinitionData.FromType(typeof(NestedDerivedFromOtherBase));
			
			var breakingChanges = MetadataComparer.CompareTypes(nestedDerivedFromBase, nestedDerivedFromSpecializedBase);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the new type derives from a more specialized base class.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDerivedFromBase, nestedDerivedFromOtherBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the new type derives from a different base class.");
			Assert.AreEqual(BreakingChangeKind.IncompatibleClassHierarchy, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDerivedFromBase.GetNestedType("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDerivedFromOtherBase.GetNestedType("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDerivedFromSpecializedBase, nestedDerivedFromBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the new type derives from a less specialized base class.");
			Assert.AreEqual(BreakingChangeKind.IncompatibleClassHierarchy, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDerivedFromSpecializedBase.GetNestedType("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDerivedFromBase.GetNestedType("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDerivedFromSpecializedBase, nestedDerivedFromOtherBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the new type derives from a different base class.");
			Assert.AreEqual(BreakingChangeKind.IncompatibleClassHierarchy, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDerivedFromSpecializedBase.GetNestedType("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDerivedFromOtherBase.GetNestedType("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var derivedFromBase = TypeDefinitionData.FromType(typeof(DerivedFromBase));
			var derivedFromSpecializedBase = TypeDefinitionData.FromType(typeof(DerivedFromSpecializedBase));
			var derivedFromOtherBase = TypeDefinitionData.FromType(typeof(DerivedFromOtherBase));
			
			var breakingChanges = MetadataComparer.CompareTypes(derivedFromBase, derivedFromSpecializedBase);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the new type derives from a more specialized base class.");

			breakingChanges = MetadataComparer.CompareTypes(derivedFromBase, derivedFromOtherBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the new type derives from a different base class.");
			Assert.AreEqual(BreakingChangeKind.IncompatibleClassHierarchy, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(derivedFromBase, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(derivedFromOtherBase, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(derivedFromSpecializedBase, derivedFromBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the new type derives from a less specialized base class.");
			Assert.AreEqual(BreakingChangeKind.IncompatibleClassHierarchy, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(derivedFromSpecializedBase, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(derivedFromBase, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(derivedFromSpecializedBase, derivedFromOtherBase);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when the new type derives from a different base class.");
			Assert.AreEqual(BreakingChangeKind.IncompatibleClassHierarchy, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(derivedFromSpecializedBase, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(derivedFromOtherBase, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // TypeTests

		public class NestedBaseClass { public class Class { } }
		public class NestedSpecializedBaseClass { public class Class : BaseClass { } }
		public class NestedOtherBaseClass { public class Class { } }

		public class NestedDerivedFromBase { public class Class : BaseClass { } }
		public class NestedDerivedFromSpecializedBase { public class Class : SpecializedBaseClass { } }
		public class NestedDerivedFromOtherBase { public class Class : OtherBaseClass { } }

		public class BaseClass { }
		public class SpecializedBaseClass : BaseClass { }
		public class OtherBaseClass { }

		public class DerivedFromBase : BaseClass { }
		public class DerivedFromSpecializedBase : SpecializedBaseClass { }
		public class DerivedFromOtherBase : OtherBaseClass { }
	}
}

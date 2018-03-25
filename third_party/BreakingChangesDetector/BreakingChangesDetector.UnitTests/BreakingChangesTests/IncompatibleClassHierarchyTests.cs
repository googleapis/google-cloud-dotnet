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

using System;
using Xunit;
using BreakingChangesDetector.MetadataItems;
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	public class IncompatibleClassHierarchyTests
	{
		#region NestedTypeTests

		[Fact]
		public void NestedTypeTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
			var nestedDerivedFromBase = context.GetTypeDefinitionData(typeof(NestedDerivedFromBase));
			var nestedDerivedFromSpecializedBase = context.GetTypeDefinitionData(typeof(NestedDerivedFromSpecializedBase));
			var nestedDerivedFromOtherBase = context.GetTypeDefinitionData(typeof(NestedDerivedFromOtherBase));
			
			var breakingChanges = MetadataComparer.CompareTypes(nestedDerivedFromBase, nestedDerivedFromSpecializedBase);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the new type derives from a more specialized base class.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDerivedFromBase, nestedDerivedFromOtherBase);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the new type derives from a different base class.");
			AssertX.Equal(BreakingChangeKind.IncompatibleClassHierarchy, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(nestedDerivedFromBase.GetNestedType("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(nestedDerivedFromOtherBase.GetNestedType("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDerivedFromSpecializedBase, nestedDerivedFromBase);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the new type derives from a less specialized base class.");
			AssertX.Equal(BreakingChangeKind.IncompatibleClassHierarchy, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(nestedDerivedFromSpecializedBase.GetNestedType("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(nestedDerivedFromBase.GetNestedType("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDerivedFromSpecializedBase, nestedDerivedFromOtherBase);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the new type derives from a different base class.");
			AssertX.Equal(BreakingChangeKind.IncompatibleClassHierarchy, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(nestedDerivedFromSpecializedBase.GetNestedType("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(nestedDerivedFromOtherBase.GetNestedType("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[Fact]
		public void TypeTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
			var derivedFromBase = context.GetTypeDefinitionData(typeof(DerivedFromBase));
			var derivedFromSpecializedBase = context.GetTypeDefinitionData(typeof(DerivedFromSpecializedBase));
			var derivedFromOtherBase = context.GetTypeDefinitionData(typeof(DerivedFromOtherBase));
			
			var breakingChanges = MetadataComparer.CompareTypes(derivedFromBase, derivedFromSpecializedBase);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when the new type derives from a more specialized base class.");

			breakingChanges = MetadataComparer.CompareTypes(derivedFromBase, derivedFromOtherBase);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the new type derives from a different base class.");
			AssertX.Equal(BreakingChangeKind.IncompatibleClassHierarchy, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(derivedFromBase, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(derivedFromOtherBase, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(derivedFromSpecializedBase, derivedFromBase);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the new type derives from a less specialized base class.");
			AssertX.Equal(BreakingChangeKind.IncompatibleClassHierarchy, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(derivedFromSpecializedBase, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(derivedFromBase, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(derivedFromSpecializedBase, derivedFromOtherBase);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the new type derives from a different base class.");
			AssertX.Equal(BreakingChangeKind.IncompatibleClassHierarchy, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(derivedFromSpecializedBase, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(derivedFromOtherBase, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
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

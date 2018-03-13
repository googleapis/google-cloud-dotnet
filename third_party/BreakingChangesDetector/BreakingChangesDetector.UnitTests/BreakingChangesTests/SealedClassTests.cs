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
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakingChangesDetector.MetadataItems;
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	[TestClass]
	public class SealedClassTests
	{
		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var nestedUnsealedClass = TypeDefinitionData.FromType(typeof(NestedUnsealedClass));
			var nestedUnsealedClassWithInternalConstructor = TypeDefinitionData.FromType(typeof(NestedUnsealedClassWithInternalConstructor));
			var nestedSealedClass = TypeDefinitionData.FromType(typeof(NestedSealedClass));
			
			var breakingChanges = MetadataComparer.CompareTypes(nestedUnsealedClass, nestedSealedClass);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a type is sealed.");
			Assert.AreEqual(BreakingChangeKind.SealedClass, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedUnsealedClass.GetNestedType("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedSealedClass.GetNestedType("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedUnsealedClassWithInternalConstructor, nestedSealedClass);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a type is sealed which couldn't be derived externally.");

			breakingChanges = MetadataComparer.CompareTypes(nestedSealedClass, nestedUnsealedClass);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when unsealing a class.");

			breakingChanges = MetadataComparer.CompareTypes(nestedSealedClass, nestedUnsealedClassWithInternalConstructor);
			Assert.AreEqual(0, breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.SealedClass).Count(), "There should be no breaking changes when unsealing a class.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var unsealedClass = TypeDefinitionData.FromType(typeof(UnsealedClass));
			var unsealedClassWithInternalConstructor = TypeDefinitionData.FromType(typeof(UnsealedClassWithInternalConstructor));
			var sealedClass = TypeDefinitionData.FromType(typeof(SealedClass));
			
			var breakingChanges = MetadataComparer.CompareTypes(unsealedClass, sealedClass);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a type is sealed.");
			Assert.AreEqual(BreakingChangeKind.SealedClass, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(unsealedClass, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(sealedClass, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(unsealedClassWithInternalConstructor, sealedClass);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a type is sealed which couldn't be derived externally.");

			breakingChanges = MetadataComparer.CompareTypes(sealedClass, unsealedClass);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when unsealing a class.");

			breakingChanges = MetadataComparer.CompareTypes(sealedClass, unsealedClassWithInternalConstructor);
			Assert.AreEqual(0, breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.SealedClass).Count(), "There should be no breaking changes when unsealing a class.");
		}

		#endregion // TypeTests

		public class NestedUnsealedClass { public class Class { } }
		public class NestedUnsealedClassWithInternalConstructor { public class Class { internal Class() { }} }
		public class NestedSealedClass { public sealed class Class { } }

		public class UnsealedClass { }
		public class UnsealedClassWithInternalConstructor { internal UnsealedClassWithInternalConstructor() { } }
		public sealed class SealedClass { }
	}
}

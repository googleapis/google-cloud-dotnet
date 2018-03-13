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
	public class ChangedClassToAbstractTests
	{
		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var NestedClass = TypeDefinitionData.FromType(typeof(NestedClass));
			var NestedClassWithInternalConstructor = TypeDefinitionData.FromType(typeof(NestedClassWithInternalConstructor));
			var NestedAbstractClass = TypeDefinitionData.FromType(typeof(NestedAbstractClass));
			
			var breakingChanges = MetadataComparer.CompareTypes(NestedClass, NestedAbstractClass).Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedClassToAbstract).ToList();
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a class is made abstract.");
			Assert.AreEqual(BreakingChangeKind.ChangedClassToAbstract, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedClass.GetMember("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedAbstractClass.GetMember("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedClassWithInternalConstructor, NestedAbstractClass);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a class with no public constructors is made abstract.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var Class = TypeDefinitionData.FromType(typeof(Class));
			var ClassWithInternalConstructor = TypeDefinitionData.FromType(typeof(ClassWithInternalConstructor));
			var AbstractClass = TypeDefinitionData.FromType(typeof(AbstractClass));
			
			var breakingChanges = MetadataComparer.CompareTypes(Class, AbstractClass).Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedClassToAbstract).ToList();
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a class is made abstract.");
			Assert.AreEqual(BreakingChangeKind.ChangedClassToAbstract, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(Class, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(AbstractClass, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithInternalConstructor, AbstractClass);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a class with no public constructors is made abstract.");
		}

		#endregion // TypeTests

		public class NestedClass { public class Class { } }
		public class NestedClassWithInternalConstructor { public class Class { internal Class() { } } }
		public class NestedAbstractClass { public abstract class Class { } }

		public class Class { }
		public class ClassWithInternalConstructor { internal ClassWithInternalConstructor() { } }
		public abstract class AbstractClass { }
	}
}

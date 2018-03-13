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
	public class ChangedClassToStaticTests
	{
		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedClassToStaticTests).Assembly);
			var NestedClass = TypeDefinitionData.FromType(typeof(NestedClass));
			var NestedClassWithInternalConstructor = TypeDefinitionData.FromType(typeof(NestedClassWithInternalConstructor));
			var NestedClassWithProtectedConstructor = TypeDefinitionData.FromType(typeof(NestedClassWithProtectedConstructor));
			var NestedStaticClass = TypeDefinitionData.FromType(typeof(NestedStaticClass));
			
			var breakingChanges = MetadataComparer.CompareTypes(NestedClass, NestedStaticClass).Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedClassToStatic).ToList();
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a class is made static.");
			Assert.AreEqual(BreakingChangeKind.ChangedClassToStatic, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedClass.GetMember("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedStaticClass.GetMember("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedClassWithInternalConstructor, NestedStaticClass);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a class with no public constructors is made abstract.");

			breakingChanges = MetadataComparer.CompareTypes(NestedClassWithProtectedConstructor, NestedStaticClass).Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedClassToStatic).ToList();
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a class is made static.");
			Assert.AreEqual(BreakingChangeKind.ChangedClassToStatic, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(NestedClassWithProtectedConstructor.GetMember("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(NestedStaticClass.GetMember("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedClassToStaticTests).Assembly);
			var Class = TypeDefinitionData.FromType(typeof(Class));
			var ClassWithInternalConstructor = TypeDefinitionData.FromType(typeof(ClassWithInternalConstructor));
			var ClassWithProtectedConstructor = TypeDefinitionData.FromType(typeof(ClassWithProtectedConstructor));
			var StaticClass = TypeDefinitionData.FromType(typeof(StaticClass));
			
			var breakingChanges = MetadataComparer.CompareTypes(Class, StaticClass).Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedClassToStatic).ToList();
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a class is made static.");
			Assert.AreEqual(BreakingChangeKind.ChangedClassToStatic, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(Class, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(StaticClass, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithInternalConstructor, StaticClass);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a class with no public constructors is made abstract.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithProtectedConstructor, StaticClass).Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedClassToStatic).ToList();
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a class is made static.");
			Assert.AreEqual(BreakingChangeKind.ChangedClassToStatic, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithProtectedConstructor, breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(StaticClass, breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // TypeTests

		public class NestedClass { public class Class { } }
		public class NestedClassWithInternalConstructor { public class Class { internal Class() { } } }
		public class NestedClassWithProtectedConstructor { public class Class { protected Class() { } } }
		public class NestedStaticClass { public static class Class { } }

		public class Class { }
		public class ClassWithInternalConstructor { internal ClassWithInternalConstructor() { } }
		public class ClassWithProtectedConstructor { protected ClassWithProtectedConstructor() { } }
		public static class StaticClass { }
	}
}

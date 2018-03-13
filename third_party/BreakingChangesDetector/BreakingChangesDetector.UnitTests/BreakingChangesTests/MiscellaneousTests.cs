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

extern alias older;
extern alias newer;

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakingChangesDetector.MetadataItems;
using BreakingChangesDetector.BreakingChanges;
using Infragistics;
using System.Reflection;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	[TestClass]
	public class MiscellaneousTests
	{
		#region GenericParameterRenameTest

		[TestMethod]
		public void GenericParameterRenameTest()
		{
			var assembly = AssemblyData.FromAssembly(typeof(MiscellaneousTests).Assembly);
			var typeData1 = TypeDefinitionData.FromType(typeof(GenericParameter1<>));
			var typeData2 = TypeDefinitionData.FromType(typeof(GenericParameter2<>));
			var typeData3 = TypeDefinitionData.FromType(typeof(GenericParameter3<,>));
			var typeData4 = TypeDefinitionData.FromType(typeof(GenericParameter4<,>));
			
			var breakingChanges = MetadataComparer.CompareTypes(typeData1, typeData2);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes for renaming a class's generic type parameter.");

			breakingChanges = MetadataComparer.CompareTypes(typeData3, typeData4);
			Assert.AreEqual(1, breakingChanges.Count, "There should be a breaking changes for using a different generic type parameter position as a return type.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "There should be a breaking changes for using a different generic type parameter position as a return type.");

			typeData1 = TypeDefinitionData.FromType(typeof(GenericMethodParameter1));
			typeData2 = TypeDefinitionData.FromType(typeof(GenericMethodParameter2));
			typeData3 = TypeDefinitionData.FromType(typeof(GenericMethodParameter3));
			typeData4 = TypeDefinitionData.FromType(typeof(GenericMethodParameter4));

			breakingChanges = MetadataComparer.CompareTypes(typeData1, typeData2);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes for renaming a class's generic type parameter.");

			breakingChanges = MetadataComparer.CompareTypes(typeData3, typeData4);
			Assert.AreEqual(1, breakingChanges.Count, "There should be a breaking changes for using a different generic type parameter position as a return type.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberType, breakingChanges[0].BreakingChangeKind, "There should be a breaking changes for using a different generic type parameter position as a return type.");
		}

		public class GenericMethodParameter1 { public T Method<T>(T x) { return default(T); } }
		public class GenericMethodParameter2 { public U Method<U>(U x) { return default(U); } }
		public class GenericMethodParameter3 { public T Method<T, U>(T x) { return default(T); } }
		public class GenericMethodParameter4 { public W Method<V, W>(V x) { return default(W); } }
		public class GenericParameter1<T> { public T Method(T x) { return default(T); } }
		[TypeRenamed("BreakingChangesDetector.UnitTests.BreakingChangesTests.MiscellaneousTests.GenericParameter1")]
		public class GenericParameter2<U> { public U Method(U x) { return default(U); } }
		public class GenericParameter3<T, U> { public T Method(T x) { return default(T); } }
		[TypeRenamed("BreakingChangesDetector.UnitTests.BreakingChangesTests.MiscellaneousTests.GenericParameter3")]
		public class GenericParameter4<V, W> { public W Method(V x) { return default(W); } }

		#endregion // GenericParameterRenameTest

		#region NamespaceRenamedAttributeTest

		[TestMethod]
		public void NamespaceRenamedAttributeTest()
		{
			var oldFamily = new AssemblyFamily { AssemblyData.FromAssembly(typeof(NamespaceRenamedAttributeOld.Type).Assembly) };
			var newFamily = new AssemblyFamily { AssemblyData.FromAssembly(typeof(NamespaceRenamedAttributeNew.Type).Assembly) };
			var breakingChanges = MetadataComparer.CompareAssemblyFamilies(oldFamily, newFamily);

			// Verify that the two 'Type' classes match up and that the comparer correctly detects the breaking change between them.
			Assert.AreEqual(1, breakingChanges.Count, "There should be a breaking change for the removed IDisposable interface.");
			Assert.AreEqual(BreakingChangeKind.RemovedImplementedInterface, breakingChanges[0].BreakingChangeKind, "There should be a breaking change for the removed IDisposable interface.");

			// However, when reversing the order, we should detect a removed type since the old assembly doesn't have the rename attribute
			breakingChanges = MetadataComparer.CompareAssemblyFamilies(newFamily, oldFamily);
			Assert.AreEqual(1, breakingChanges.Count, "There should be a breaking change for removing a root type.");
			Assert.AreEqual(BreakingChangeKind.RemovedRootType, breakingChanges[0].BreakingChangeKind, "There should be a breaking change for removing a root type.");
		}

		#endregion // NamespaceRenamedAttributeTest

		#region TypeForwardingTest

		[TestMethod]
		public void TypeForwardingTest()
		{
			var foo = typeof(older::TypeForwardingOld.SourceType).Assembly.FullName;

			var oldFamily = new AssemblyFamily { AssemblyData.FromAssembly(typeof(older::TypeForwardingOld.SourceType).Assembly) };
			var newFamily = new AssemblyFamily 
			{ 
				AssemblyData.FromAssembly(typeof(newer::TypeForwardingOld.SourceType).Assembly),
				AssemblyData.FromAssembly(typeof(newer::TypeForwardingOld.TargetType1).Assembly) 
			};
			var breakingChanges = MetadataComparer.CompareAssemblyFamilies(oldFamily, newFamily);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when the removed type is forwarded.");
		}

		#endregion // TypeForwardingTest
	}
}

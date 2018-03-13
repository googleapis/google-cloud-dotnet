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
	public class ChangedMemberToAbstractTests
	{
		#region EventTests

		[TestMethod]
		public void EventTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(AddedAbstractMemberTests).Assembly);
			var EventVirtual = TypeDefinitionData.FromType(typeof(EventVirtual));
			var EventAbstract = TypeDefinitionData.FromType(typeof(EventAbstract));
			
			var breakingChanges = MetadataComparer.CompareTypes(EventVirtual, EventAbstract);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to abstract.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberToAbstract, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventVirtual.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(EventAbstract.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventAbstract, EventVirtual);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an abstract member changes to virtual.");
		}

		#endregion // EventTests

		#region IndexerTests

		[TestMethod]
		public void IndexerTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(AddedAbstractMemberTests).Assembly);
			var indexerVirtual = TypeDefinitionData.FromType(typeof(IndexerVirtual));
			var indexerAbstract = TypeDefinitionData.FromType(typeof(IndexerAbstract));
			
			var breakingChanges = MetadataComparer.CompareTypes(indexerVirtual, indexerAbstract);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to abstract.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberToAbstract, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(indexerVirtual.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(indexerAbstract.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(indexerAbstract, indexerVirtual);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an abstract member changes to virtual.");
		}

		#endregion // IndexerTests

		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(AddedAbstractMemberTests).Assembly);
			var methodVirtual = TypeDefinitionData.FromType(typeof(MethodVirtual));
			var methodAbstract = TypeDefinitionData.FromType(typeof(MethodAbstract));
			
			var breakingChanges = MetadataComparer.CompareTypes(methodVirtual, methodAbstract);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to abstract.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberToAbstract, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(methodVirtual.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(methodAbstract.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodAbstract, methodVirtual);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an abstract member changes to virtual.");
		}

		#endregion // MethodTests

		#region PropertyTests

		[TestMethod]
		public void PropertyTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(AddedAbstractMemberTests).Assembly);
			var PropertyVirtual = TypeDefinitionData.FromType(typeof(PropertyVirtual));
			var PropertyAbstract = TypeDefinitionData.FromType(typeof(PropertyAbstract));
			
			var breakingChanges = MetadataComparer.CompareTypes(PropertyVirtual, PropertyAbstract);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to abstract.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberToAbstract, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyVirtual.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyAbstract.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyAbstract, PropertyVirtual);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an abstract member changes to virtual.");
		}

		#endregion // PropertyTests


#pragma warning disable 0067
		public abstract class EventVirtual { public virtual event EventHandler Event; }
		public abstract class EventAbstract { public abstract event EventHandler Event; }
#pragma warning restore 0067

		public abstract class IndexerVirtual { public virtual int this[int x] { get { return 0; } } }
		public abstract class IndexerAbstract { public abstract int this[int x] { get; } }

		public abstract class MethodVirtual { public virtual int Method() { return 0; } }
		public abstract class MethodAbstract { public abstract int Method(); }

		public abstract class PropertyVirtual { public virtual int Property { get { return 0; } } }
		public abstract class PropertyAbstract { public abstract int Property { get; } }
	}
}

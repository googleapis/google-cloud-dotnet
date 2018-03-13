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
	public class ChangedMemberToNonVirtualTests
	{
		#region EventTests

		[TestMethod]
		public void EventTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(AddedAbstractMemberTests).Assembly);
			var EventNonVirtual = TypeDefinitionData.FromType(typeof(EventNonVirtual));
			var EventVirtual = TypeDefinitionData.FromType(typeof(EventVirtual));
			var EventAbstract = TypeDefinitionData.FromType(typeof(EventAbstract));
			
			var breakingChanges = MetadataComparer.CompareTypes(EventVirtual, EventNonVirtual);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to non-virtual.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventVirtual.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(EventNonVirtual.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventAbstract, EventNonVirtual);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an abstract member changes to non-virtual.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventAbstract.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(EventNonVirtual.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventNonVirtual, EventVirtual);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a non-virtual member changes to virtual.");
		}

		#endregion // EventTests

		#region IndexerTests

		[TestMethod]
		public void IndexerTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(AddedAbstractMemberTests).Assembly);
			var IndexerNonVirtual = TypeDefinitionData.FromType(typeof(IndexerNonVirtual));
			var IndexerVirtual = TypeDefinitionData.FromType(typeof(IndexerVirtual));
			var IndexerAbstract = TypeDefinitionData.FromType(typeof(IndexerAbstract));
			
			var breakingChanges = MetadataComparer.CompareTypes(IndexerVirtual, IndexerNonVirtual);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to non-virtual.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerVirtual.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerNonVirtual.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerAbstract, IndexerNonVirtual);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an abstract member changes to non-virtual.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerAbstract.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerNonVirtual.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerNonVirtual, IndexerVirtual);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a non-virtual member changes to virtual.");
		}

		#endregion // IndexerTests

		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(AddedAbstractMemberTests).Assembly);
			var MethodNonVirtual = TypeDefinitionData.FromType(typeof(MethodNonVirtual));
			var MethodVirtual = TypeDefinitionData.FromType(typeof(MethodVirtual));
			var MethodAbstract = TypeDefinitionData.FromType(typeof(MethodAbstract));
			
			var breakingChanges = MetadataComparer.CompareTypes(MethodVirtual, MethodNonVirtual);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to non-virtual.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodVirtual.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodNonVirtual.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodAbstract, MethodNonVirtual);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an abstract member changes to non-virtual.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodAbstract.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodNonVirtual.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodNonVirtual, MethodVirtual);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a non-virtual member changes to virtual.");
		}

		#endregion // MethodTests

		#region PropertyTests

		[TestMethod]
		public void PropertyTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(AddedAbstractMemberTests).Assembly);
			var PropertyNonVirtual = TypeDefinitionData.FromType(typeof(PropertyNonVirtual));
			var PropertyVirtual = TypeDefinitionData.FromType(typeof(PropertyVirtual));
			var PropertyAbstract = TypeDefinitionData.FromType(typeof(PropertyAbstract));
			
			var breakingChanges = MetadataComparer.CompareTypes(PropertyVirtual, PropertyNonVirtual);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to non-virtual.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyVirtual.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyNonVirtual.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyAbstract, PropertyNonVirtual);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an abstract member changes to non-virtual.");
			Assert.AreEqual(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyAbstract.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyNonVirtual.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyNonVirtual, PropertyVirtual);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a non-virtual member changes to virtual.");
		}

		#endregion // PropertyTests


#pragma warning disable 0067
		public abstract class EventNonVirtual { public event EventHandler Event; }
		public abstract class EventVirtual { public virtual event EventHandler Event; }
		public abstract class EventAbstract { public abstract event EventHandler Event; }
#pragma warning restore 0067

		public abstract class IndexerNonVirtual { public int this[int x] { get { return 0; } } }
		public abstract class IndexerVirtual { public virtual int this[int x] { get { return 0; } } }
		public abstract class IndexerAbstract { public abstract int this[int x] { get; } }

		public abstract class MethodNonVirtual { public int Method() { return 0; } }
		public abstract class MethodVirtual { public virtual int Method() { return 0; } }
		public abstract class MethodAbstract { public abstract int Method(); }

		public abstract class PropertyNonVirtual { public int Property { get { return 0; } } }
		public abstract class PropertyVirtual { public virtual int Property { get { return 0; } } }
		public abstract class PropertyAbstract { public abstract int Property { get; } }
	}
}

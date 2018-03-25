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
	public class ChangedMemberToNonVirtualTests
	{
		#region EventTests

		[Fact]
		public void EventTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(AddedAbstractMemberTests));
			var EventNonVirtual = context.GetTypeDefinitionData(typeof(EventNonVirtual));
			var EventVirtual = context.GetTypeDefinitionData(typeof(EventVirtual));
			var EventAbstract = context.GetTypeDefinitionData(typeof(EventAbstract));
			
			var breakingChanges = MetadataComparer.CompareTypes(EventVirtual, EventNonVirtual);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to non-virtual.");
			AssertX.Equal(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(EventVirtual.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(EventNonVirtual.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventAbstract, EventNonVirtual);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an abstract member changes to non-virtual.");
			AssertX.Equal(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(EventAbstract.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(EventNonVirtual.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventNonVirtual, EventVirtual);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a non-virtual member changes to virtual.");
		}

		#endregion // EventTests

		#region IndexerTests

		[Fact]
		public void IndexerTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(AddedAbstractMemberTests));
			var IndexerNonVirtual = context.GetTypeDefinitionData(typeof(IndexerNonVirtual));
			var IndexerVirtual = context.GetTypeDefinitionData(typeof(IndexerVirtual));
			var IndexerAbstract = context.GetTypeDefinitionData(typeof(IndexerAbstract));
			
			var breakingChanges = MetadataComparer.CompareTypes(IndexerVirtual, IndexerNonVirtual);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to non-virtual.");
			AssertX.Equal(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(IndexerVirtual.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(IndexerNonVirtual.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerAbstract, IndexerNonVirtual);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an abstract member changes to non-virtual.");
			AssertX.Equal(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(IndexerAbstract.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(IndexerNonVirtual.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerNonVirtual, IndexerVirtual);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a non-virtual member changes to virtual.");
		}

		#endregion // IndexerTests

		#region MethodTests

		[Fact]
		public void MethodTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(AddedAbstractMemberTests));
			var MethodNonVirtual = context.GetTypeDefinitionData(typeof(MethodNonVirtual));
			var MethodVirtual = context.GetTypeDefinitionData(typeof(MethodVirtual));
			var MethodAbstract = context.GetTypeDefinitionData(typeof(MethodAbstract));
			
			var breakingChanges = MetadataComparer.CompareTypes(MethodVirtual, MethodNonVirtual);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to non-virtual.");
			AssertX.Equal(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(MethodVirtual.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(MethodNonVirtual.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodAbstract, MethodNonVirtual);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an abstract member changes to non-virtual.");
			AssertX.Equal(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(MethodAbstract.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(MethodNonVirtual.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodNonVirtual, MethodVirtual);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a non-virtual member changes to virtual.");
		}

		#endregion // MethodTests

		#region PropertyTests

		[Fact]
		public void PropertyTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(AddedAbstractMemberTests));
			var PropertyNonVirtual = context.GetTypeDefinitionData(typeof(PropertyNonVirtual));
			var PropertyVirtual = context.GetTypeDefinitionData(typeof(PropertyVirtual));
			var PropertyAbstract = context.GetTypeDefinitionData(typeof(PropertyAbstract));
			
			var breakingChanges = MetadataComparer.CompareTypes(PropertyVirtual, PropertyNonVirtual);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to non-virtual.");
			AssertX.Equal(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(PropertyVirtual.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(PropertyNonVirtual.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyAbstract, PropertyNonVirtual);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an abstract member changes to non-virtual.");
			AssertX.Equal(BreakingChangeKind.ChangedMemberToNonVirtual, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(PropertyAbstract.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(PropertyNonVirtual.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyNonVirtual, PropertyVirtual);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a non-virtual member changes to virtual.");
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

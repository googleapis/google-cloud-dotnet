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
	public class RemovedOverrideOfAbstractMemberTests
	{
		#region EventTests

		[TestMethod]
		public void EventTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(RemovedOverrideOfAbstractMemberTests).Assembly);
			var EventVirtual = TypeDefinitionData.FromType(typeof(EventVirtual));
			var EventAbstract = TypeDefinitionData.FromType(typeof(EventAbstract));
			var EventVirtualOverride = TypeDefinitionData.FromType(typeof(EventVirtualOverride));
			var EventAbstractOverride = TypeDefinitionData.FromType(typeof(EventAbstractOverride));
			var EventVirtualOverrideInternalConstructor = TypeDefinitionData.FromType(typeof(EventVirtualOverrideInternalConstructor));
			var EventAbstractOverrideInternalConstructor = TypeDefinitionData.FromType(typeof(EventAbstractOverrideInternalConstructor));
			var EventVirtualNoOverride = TypeDefinitionData.FromType(typeof(EventVirtualNoOverride));
			var EventAbstractNoOverride = TypeDefinitionData.FromType(typeof(EventAbstractNoOverride));
			
			var breakingChanges = MetadataComparer.CompareTypes(EventVirtualOverride, EventVirtualNoOverride);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed.");

			breakingChanges = MetadataComparer.CompareTypes(EventVirtualOverrideInternalConstructor, EventVirtualNoOverride);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed and there are no externally visible constructors.");

			breakingChanges = MetadataComparer.CompareTypes(EventAbstractOverride, EventAbstractNoOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an override of an abstract member is removed.");
			Assert.AreEqual(BreakingChangeKind.RemovedOverrideOfAbstractMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventAbstractOverride.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(EventAbstractNoOverride, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventAbstractOverrideInternalConstructor, EventAbstractNoOverride);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an override of an abstract member is removed and there are no externally visible constructors.");
		}

		#endregion // EventTests

		#region IndexerTests

		[TestMethod]
		public void IndexerTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(RemovedOverrideOfAbstractMemberTests).Assembly);
			var IndexerVirtual = TypeDefinitionData.FromType(typeof(IndexerVirtual));
			var IndexerAbstract = TypeDefinitionData.FromType(typeof(IndexerAbstract));
			var IndexerVirtualOverride = TypeDefinitionData.FromType(typeof(IndexerVirtualOverride));
			var IndexerAbstractOverride = TypeDefinitionData.FromType(typeof(IndexerAbstractOverride));
			var IndexerVirtualOverrideInternalConstructor = TypeDefinitionData.FromType(typeof(IndexerVirtualOverrideInternalConstructor));
			var IndexerAbstractOverrideInternalConstructor = TypeDefinitionData.FromType(typeof(IndexerAbstractOverrideInternalConstructor));
			var IndexerVirtualNoOverride = TypeDefinitionData.FromType(typeof(IndexerVirtualNoOverride));
			var IndexerAbstractNoOverride = TypeDefinitionData.FromType(typeof(IndexerAbstractNoOverride));
			
			var breakingChanges = MetadataComparer.CompareTypes(IndexerVirtualOverride, IndexerVirtualNoOverride);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerVirtualOverrideInternalConstructor, IndexerVirtualNoOverride);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed and there are no externally visible constructors.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerAbstractOverride, IndexerAbstractNoOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an override of an abstract member is removed.");
			Assert.AreEqual(BreakingChangeKind.RemovedOverrideOfAbstractMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerAbstractOverride.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(IndexerAbstractNoOverride, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerAbstractOverrideInternalConstructor, IndexerAbstractNoOverride);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an override of an abstract member is removed and there are no externally visible constructors.");
		}

		#endregion // IndexerTests

		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(RemovedOverrideOfAbstractMemberTests).Assembly);
			var MethodVirtual = TypeDefinitionData.FromType(typeof(MethodVirtual));
			var MethodAbstract = TypeDefinitionData.FromType(typeof(MethodAbstract));
			var MethodVirtualOverride = TypeDefinitionData.FromType(typeof(MethodVirtualOverride));
			var MethodAbstractOverride = TypeDefinitionData.FromType(typeof(MethodAbstractOverride));
			var MethodVirtualOverrideInternalConstructor = TypeDefinitionData.FromType(typeof(MethodVirtualOverrideInternalConstructor));
			var MethodAbstractOverrideInternalConstructor = TypeDefinitionData.FromType(typeof(MethodAbstractOverrideInternalConstructor));
			var MethodVirtualNoOverride = TypeDefinitionData.FromType(typeof(MethodVirtualNoOverride));
			var MethodAbstractNoOverride = TypeDefinitionData.FromType(typeof(MethodAbstractNoOverride));
			
			var breakingChanges = MetadataComparer.CompareTypes(MethodVirtualOverride, MethodVirtualNoOverride);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed.");

			breakingChanges = MetadataComparer.CompareTypes(MethodVirtualOverrideInternalConstructor, MethodVirtualNoOverride);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed and there are no externally visible constructors.");

			breakingChanges = MetadataComparer.CompareTypes(MethodAbstractOverride, MethodAbstractNoOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an override of an abstract member is removed.");
			Assert.AreEqual(BreakingChangeKind.RemovedOverrideOfAbstractMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodAbstractOverride.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(MethodAbstractNoOverride, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodAbstractOverrideInternalConstructor, MethodAbstractNoOverride);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an override of an abstract member is removed and there are no externally visible constructors.");
		}

		#endregion // MethodTests

		#region PropertyTests

		[TestMethod]
		public void PropertyTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(RemovedOverrideOfAbstractMemberTests).Assembly);
			var PropertyVirtual = TypeDefinitionData.FromType(typeof(PropertyVirtual));
			var PropertyAbstract = TypeDefinitionData.FromType(typeof(PropertyAbstract));
			var PropertyVirtualOverride = TypeDefinitionData.FromType(typeof(PropertyVirtualOverride));
			var PropertyAbstractOverride = TypeDefinitionData.FromType(typeof(PropertyAbstractOverride));
			var PropertyVirtualOverrideInternalConstructor = TypeDefinitionData.FromType(typeof(PropertyVirtualOverrideInternalConstructor));
			var PropertyAbstractOverrideInternalConstructor = TypeDefinitionData.FromType(typeof(PropertyAbstractOverrideInternalConstructor));
			var PropertyVirtualNoOverride = TypeDefinitionData.FromType(typeof(PropertyVirtualNoOverride));
			var PropertyAbstractNoOverride = TypeDefinitionData.FromType(typeof(PropertyAbstractNoOverride));
			
			var breakingChanges = MetadataComparer.CompareTypes(PropertyVirtualOverride, PropertyVirtualNoOverride);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyVirtualOverrideInternalConstructor, PropertyVirtualNoOverride);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed and there are no externally visible constructors.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyAbstractOverride, PropertyAbstractNoOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an override of an abstract member is removed.");
			Assert.AreEqual(BreakingChangeKind.RemovedOverrideOfAbstractMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyAbstractOverride.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(PropertyAbstractNoOverride, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyAbstractOverrideInternalConstructor, PropertyAbstractNoOverride);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an override of an abstract member is removed and there are no externally visible constructors.");
		}

		#endregion // PropertyTests


#pragma warning disable 0067
		public abstract class EventVirtual { public virtual event EventHandler Event; }
		public abstract class EventAbstract { public abstract event EventHandler Event; }
		public abstract class EventVirtualOverride : EventVirtual { public override event EventHandler Event; }
		public abstract class EventAbstractOverride : EventAbstract { public override event EventHandler Event; }
		public abstract class EventVirtualOverrideInternalConstructor : EventVirtual { internal EventVirtualOverrideInternalConstructor() { } public override event EventHandler Event; }
		public abstract class EventAbstractOverrideInternalConstructor : EventAbstract { internal EventAbstractOverrideInternalConstructor() { } public override event EventHandler Event; }
		public abstract class EventVirtualNoOverride : EventVirtual { }
		public abstract class EventAbstractNoOverride : EventAbstract { }
#pragma warning restore 0067

		public abstract class IndexerVirtual { public virtual int this[int x] { get { return 0; } } }
		public abstract class IndexerAbstract { public abstract int this[int x] { get; } }
		public abstract class IndexerVirtualOverride : IndexerVirtual { public override int this[int x] { get { return 0; } } }
		public abstract class IndexerAbstractOverride : IndexerAbstract { public override int this[int x] { get { return 0; } } }
		public abstract class IndexerVirtualOverrideInternalConstructor : IndexerVirtual { internal IndexerVirtualOverrideInternalConstructor() { } public override int this[int x] { get { return 0; } } }
		public abstract class IndexerAbstractOverrideInternalConstructor : IndexerAbstract { internal IndexerAbstractOverrideInternalConstructor() { } public override int this[int x] { get { return 0; } } }
		public abstract class IndexerVirtualNoOverride : IndexerVirtual { }
		public abstract class IndexerAbstractNoOverride : IndexerAbstract { }

		public abstract class MethodVirtual { public virtual int Method() { return 0; } }
		public abstract class MethodAbstract { public abstract int Method(); }
		public abstract class MethodVirtualOverride : MethodVirtual { public override int Method() { return 0; } }
		public abstract class MethodAbstractOverride : MethodAbstract { public override int Method() { return 0; } }
		public abstract class MethodVirtualOverrideInternalConstructor : MethodVirtual { internal MethodVirtualOverrideInternalConstructor() { } public override int Method() { return 0; } }
		public abstract class MethodAbstractOverrideInternalConstructor : MethodAbstract { internal MethodAbstractOverrideInternalConstructor() { } public override int Method() { return 0; } }
		public abstract class MethodVirtualNoOverride : MethodVirtual { }
		public abstract class MethodAbstractNoOverride : MethodAbstract { }

		public abstract class PropertyVirtual { public virtual int Property { get { return 0; } } }
		public abstract class PropertyAbstract { public abstract int Property { get; } }
		public abstract class PropertyVirtualOverride : PropertyVirtual { public override int Property { get { return 0; } } }
		public abstract class PropertyAbstractOverride : PropertyAbstract { public override int Property { get { return 0; } } }
		public abstract class PropertyVirtualOverrideInternalConstructor : PropertyVirtual { internal PropertyVirtualOverrideInternalConstructor() { } public override int Property { get { return 0; } } }
		public abstract class PropertyAbstractOverrideInternalConstructor : PropertyAbstract { internal PropertyAbstractOverrideInternalConstructor() { } public override int Property { get { return 0; } } }
		public abstract class PropertyVirtualNoOverride : PropertyVirtual { }
		public abstract class PropertyAbstractNoOverride : PropertyAbstract { }
	}
}

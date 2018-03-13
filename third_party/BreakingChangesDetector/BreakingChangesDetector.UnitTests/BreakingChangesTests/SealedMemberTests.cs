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
	public class SealedMemberTests
	{
		#region EventTests

		[TestMethod]
		public void EventTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(SealedMemberTests).Assembly);
			var EventVirtual = TypeDefinitionData.FromType(typeof(EventVirtual));
			var EventAbstract = TypeDefinitionData.FromType(typeof(EventAbstract));
			var EventVirtualOverride = TypeDefinitionData.FromType(typeof(EventVirtualOverride));
			var EventAbstractOverride = TypeDefinitionData.FromType(typeof(EventAbstractOverride));
			var EventVirtualNoOverride = TypeDefinitionData.FromType(typeof(EventVirtualNoOverride));
			var EventAbstractNoOverride = TypeDefinitionData.FromType(typeof(EventAbstractNoOverride));
			var EventVirtualSealedOverride = TypeDefinitionData.FromType(typeof(EventVirtualSealedOverride));
			var EventAbstractSealedOverride = TypeDefinitionData.FromType(typeof(EventAbstractSealedOverride));
			var EventVirtualSealedOverrideSealed = TypeDefinitionData.FromType(typeof(EventVirtualSealedOverrideSealed));
			var EventAbstractSealedOverrideSealed = TypeDefinitionData.FromType(typeof(EventAbstractSealedOverrideSealed));
			
			var breakingChanges = MetadataComparer.CompareTypes(EventVirtualOverride, EventVirtualSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventVirtualOverride.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(EventVirtualSealedOverride.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventVirtualOverride, EventVirtualSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(EventAbstractOverride, EventAbstractSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventAbstractOverride.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(EventAbstractSealedOverride.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventAbstractOverride, EventAbstractSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(EventVirtualNoOverride, EventVirtualSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventVirtual.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(EventVirtualSealedOverride.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventVirtualNoOverride, EventVirtualSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(EventAbstractNoOverride, EventAbstractSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventAbstract.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(EventAbstractSealedOverride.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventAbstractNoOverride, EventAbstractSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");
		}

		#endregion // EventTests

		#region IndexerTests

		[TestMethod]
		public void IndexerTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(SealedMemberTests).Assembly);
			var IndexerVirtual = TypeDefinitionData.FromType(typeof(IndexerVirtual));
			var IndexerAbstract = TypeDefinitionData.FromType(typeof(IndexerAbstract));
			var IndexerVirtualOverride = TypeDefinitionData.FromType(typeof(IndexerVirtualOverride));
			var IndexerAbstractOverride = TypeDefinitionData.FromType(typeof(IndexerAbstractOverride));
			var IndexerVirtualNoOverride = TypeDefinitionData.FromType(typeof(IndexerVirtualNoOverride));
			var IndexerAbstractNoOverride = TypeDefinitionData.FromType(typeof(IndexerAbstractNoOverride));
			var IndexerVirtualSealedOverride = TypeDefinitionData.FromType(typeof(IndexerVirtualSealedOverride));
			var IndexerAbstractSealedOverride = TypeDefinitionData.FromType(typeof(IndexerAbstractSealedOverride));
			var IndexerVirtualSealedOverrideSealed = TypeDefinitionData.FromType(typeof(IndexerVirtualSealedOverrideSealed));
			var IndexerAbstractSealedOverrideSealed = TypeDefinitionData.FromType(typeof(IndexerAbstractSealedOverrideSealed));
			
			var breakingChanges = MetadataComparer.CompareTypes(IndexerVirtualOverride, IndexerVirtualSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerVirtualOverride.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerVirtualSealedOverride.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerVirtualOverride, IndexerVirtualSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerAbstractOverride, IndexerAbstractSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerAbstractOverride.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerAbstractSealedOverride.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerAbstractOverride, IndexerAbstractSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerVirtualNoOverride, IndexerVirtualSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerVirtual.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerVirtualSealedOverride.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerVirtualNoOverride, IndexerVirtualSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerAbstractNoOverride, IndexerAbstractSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(IndexerAbstract.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(IndexerAbstractSealedOverride.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerAbstractNoOverride, IndexerAbstractSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");
		}

		#endregion // IndexerTests

		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(SealedMemberTests).Assembly);
			var MethodVirtual = TypeDefinitionData.FromType(typeof(MethodVirtual));
			var MethodAbstract = TypeDefinitionData.FromType(typeof(MethodAbstract));
			var MethodVirtualOverride = TypeDefinitionData.FromType(typeof(MethodVirtualOverride));
			var MethodAbstractOverride = TypeDefinitionData.FromType(typeof(MethodAbstractOverride));
			var MethodVirtualNoOverride = TypeDefinitionData.FromType(typeof(MethodVirtualNoOverride));
			var MethodAbstractNoOverride = TypeDefinitionData.FromType(typeof(MethodAbstractNoOverride));
			var MethodVirtualSealedOverride = TypeDefinitionData.FromType(typeof(MethodVirtualSealedOverride));
			var MethodAbstractSealedOverride = TypeDefinitionData.FromType(typeof(MethodAbstractSealedOverride));
			var MethodVirtualSealedOverrideSealed = TypeDefinitionData.FromType(typeof(MethodVirtualSealedOverrideSealed));
			var MethodAbstractSealedOverrideSealed = TypeDefinitionData.FromType(typeof(MethodAbstractSealedOverrideSealed));
			
			var breakingChanges = MetadataComparer.CompareTypes(MethodVirtualOverride, MethodVirtualSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodVirtualOverride.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodVirtualSealedOverride.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodVirtualOverride, MethodVirtualSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(MethodAbstractOverride, MethodAbstractSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodAbstractOverride.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodAbstractSealedOverride.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodAbstractOverride, MethodAbstractSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(MethodVirtualNoOverride, MethodVirtualSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodVirtual.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodVirtualSealedOverride.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodVirtualNoOverride, MethodVirtualSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(MethodAbstractNoOverride, MethodAbstractSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodAbstract.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodAbstractSealedOverride.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodAbstractNoOverride, MethodAbstractSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");
		}

		#endregion // MethodTests

		#region PropertyTests

		[TestMethod]
		public void PropertyTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(SealedMemberTests).Assembly);
			var PropertyVirtual = TypeDefinitionData.FromType(typeof(PropertyVirtual));
			var PropertyAbstract = TypeDefinitionData.FromType(typeof(PropertyAbstract));
			var PropertyVirtualOverride = TypeDefinitionData.FromType(typeof(PropertyVirtualOverride));
			var PropertyAbstractOverride = TypeDefinitionData.FromType(typeof(PropertyAbstractOverride));
			var PropertyVirtualNoOverride = TypeDefinitionData.FromType(typeof(PropertyVirtualNoOverride));
			var PropertyAbstractNoOverride = TypeDefinitionData.FromType(typeof(PropertyAbstractNoOverride));
			var PropertyVirtualSealedOverride = TypeDefinitionData.FromType(typeof(PropertyVirtualSealedOverride));
			var PropertyAbstractSealedOverride = TypeDefinitionData.FromType(typeof(PropertyAbstractSealedOverride));
			var PropertyVirtualSealedOverrideSealed = TypeDefinitionData.FromType(typeof(PropertyVirtualSealedOverrideSealed));
			var PropertyAbstractSealedOverrideSealed = TypeDefinitionData.FromType(typeof(PropertyAbstractSealedOverrideSealed));
			
			var breakingChanges = MetadataComparer.CompareTypes(PropertyVirtualOverride, PropertyVirtualSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyVirtualOverride.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyVirtualSealedOverride.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyVirtualOverride, PropertyVirtualSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyAbstractOverride, PropertyAbstractSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyAbstractOverride.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyAbstractSealedOverride.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyAbstractOverride, PropertyAbstractSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyVirtualNoOverride, PropertyVirtualSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyVirtual.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyVirtualSealedOverride.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyVirtualNoOverride, PropertyVirtualSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyAbstractNoOverride, PropertyAbstractSealedOverride);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			Assert.AreEqual(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyAbstract.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyAbstractSealedOverride.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyAbstractNoOverride, PropertyAbstractSealedOverrideSealed);
			Assert.AreEqual(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");
		}

		#endregion // PropertyTests


#pragma warning disable 0067
		public abstract class EventVirtual { public virtual event EventHandler Event; }
		public abstract class EventAbstract { public abstract event EventHandler Event; }
		public class EventVirtualOverride : EventVirtual { public override event EventHandler Event; }
		public class EventAbstractOverride : EventAbstract { public override event EventHandler Event; }
		public abstract class EventVirtualNoOverride : EventVirtual { }
		public abstract class EventAbstractNoOverride : EventAbstract { }
		public class EventVirtualSealedOverride : EventVirtual { public sealed override event EventHandler Event; }
		public class EventAbstractSealedOverride : EventAbstract { public sealed override event EventHandler Event; }
		public sealed class EventVirtualSealedOverrideSealed : EventVirtual { public sealed override event EventHandler Event; }
		public sealed class EventAbstractSealedOverrideSealed : EventAbstract { public sealed override event EventHandler Event; }
#pragma warning restore 0067

		public abstract class IndexerVirtual { public virtual int this[int x] { get { return 0; } } }
		public abstract class IndexerAbstract { public abstract int this[int x] { get; } }
		public class IndexerVirtualOverride : IndexerVirtual { public override int this[int x] { get { return 0; } } }
		public class IndexerAbstractOverride : IndexerAbstract { public override int this[int x] { get { return 0; } } }
		public abstract class IndexerVirtualNoOverride : IndexerVirtual { }
		public abstract class IndexerAbstractNoOverride : IndexerAbstract { }
		public class IndexerVirtualSealedOverride : IndexerVirtual { public sealed override int this[int x] { get { return 0; } } }
		public class IndexerAbstractSealedOverride : IndexerAbstract { public sealed override int this[int x] { get { return 0; } } }
		public sealed class IndexerVirtualSealedOverrideSealed : IndexerVirtual { public sealed override int this[int x] { get { return 0; } } }
		public sealed class IndexerAbstractSealedOverrideSealed : IndexerAbstract { public sealed override int this[int x] { get { return 0; } } }

		public abstract class MethodVirtual { public virtual int Method() { return 0; } }
		public abstract class MethodAbstract { public abstract int Method(); }
		public class MethodVirtualOverride : MethodVirtual { public override int Method() { return 0; } }
		public class MethodAbstractOverride : MethodAbstract { public override int Method() { return 0; } }
		public abstract class MethodVirtualNoOverride : MethodVirtual { }
		public abstract class MethodAbstractNoOverride : MethodAbstract { }
		public class MethodVirtualSealedOverride : MethodVirtual { public sealed override int Method() { return 0; } }
		public class MethodAbstractSealedOverride : MethodAbstract { public sealed override int Method() { return 0; } }
		public sealed class MethodVirtualSealedOverrideSealed : MethodVirtual { public sealed override int Method() { return 0; } }
		public sealed class MethodAbstractSealedOverrideSealed : MethodAbstract { public sealed override int Method() { return 0; } }

		public abstract class PropertyVirtual { public virtual int Property { get { return 0; } } }
		public abstract class PropertyAbstract { public abstract int Property { get; } }
		public class PropertyVirtualOverride : PropertyVirtual { public override int Property { get { return 0; } } }
		public class PropertyAbstractOverride : PropertyAbstract { public override int Property { get { return 0; } } }
		public abstract class PropertyVirtualNoOverride : PropertyVirtual { }
		public abstract class PropertyAbstractNoOverride : PropertyAbstract { }
		public class PropertyVirtualSealedOverride : PropertyVirtual { public sealed override int Property { get { return 0; } } }
		public class PropertyAbstractSealedOverride : PropertyAbstract { public sealed override int Property { get { return 0; } } }
		public sealed class PropertyVirtualSealedOverrideSealed : PropertyVirtual { public sealed override int Property { get { return 0; } } }
		public sealed class PropertyAbstractSealedOverrideSealed : PropertyAbstract { public sealed override int Property { get { return 0; } } }
	}
}

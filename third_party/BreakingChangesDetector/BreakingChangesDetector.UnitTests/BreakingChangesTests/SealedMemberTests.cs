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
	public class SealedMemberTests
	{
		#region EventTests

		[Fact]
		public void EventTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(SealedMemberTests));
			var EventVirtual = context.GetTypeDefinitionData(typeof(EventVirtual));
			var EventAbstract = context.GetTypeDefinitionData(typeof(EventAbstract));
			var EventVirtualOverride = context.GetTypeDefinitionData(typeof(EventVirtualOverride));
			var EventAbstractOverride = context.GetTypeDefinitionData(typeof(EventAbstractOverride));
			var EventVirtualNoOverride = context.GetTypeDefinitionData(typeof(EventVirtualNoOverride));
			var EventAbstractNoOverride = context.GetTypeDefinitionData(typeof(EventAbstractNoOverride));
			var EventVirtualSealedOverride = context.GetTypeDefinitionData(typeof(EventVirtualSealedOverride));
			var EventAbstractSealedOverride = context.GetTypeDefinitionData(typeof(EventAbstractSealedOverride));
			var EventVirtualSealedOverrideSealed = context.GetTypeDefinitionData(typeof(EventVirtualSealedOverrideSealed));
			var EventAbstractSealedOverrideSealed = context.GetTypeDefinitionData(typeof(EventAbstractSealedOverrideSealed));
			
			var breakingChanges = MetadataComparer.CompareTypes(EventVirtualOverride, EventVirtualSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(EventVirtualOverride.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(EventVirtualSealedOverride.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventVirtualOverride, EventVirtualSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(EventAbstractOverride, EventAbstractSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(EventAbstractOverride.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(EventAbstractSealedOverride.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventAbstractOverride, EventAbstractSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(EventVirtualNoOverride, EventVirtualSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(EventVirtual.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(EventVirtualSealedOverride.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventVirtualNoOverride, EventVirtualSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(EventAbstractNoOverride, EventAbstractSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(EventAbstract.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(EventAbstractSealedOverride.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventAbstractNoOverride, EventAbstractSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");
		}

		#endregion // EventTests

		#region IndexerTests

		[Fact]
		public void IndexerTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(SealedMemberTests));
			var IndexerVirtual = context.GetTypeDefinitionData(typeof(IndexerVirtual));
			var IndexerAbstract = context.GetTypeDefinitionData(typeof(IndexerAbstract));
			var IndexerVirtualOverride = context.GetTypeDefinitionData(typeof(IndexerVirtualOverride));
			var IndexerAbstractOverride = context.GetTypeDefinitionData(typeof(IndexerAbstractOverride));
			var IndexerVirtualNoOverride = context.GetTypeDefinitionData(typeof(IndexerVirtualNoOverride));
			var IndexerAbstractNoOverride = context.GetTypeDefinitionData(typeof(IndexerAbstractNoOverride));
			var IndexerVirtualSealedOverride = context.GetTypeDefinitionData(typeof(IndexerVirtualSealedOverride));
			var IndexerAbstractSealedOverride = context.GetTypeDefinitionData(typeof(IndexerAbstractSealedOverride));
			var IndexerVirtualSealedOverrideSealed = context.GetTypeDefinitionData(typeof(IndexerVirtualSealedOverrideSealed));
			var IndexerAbstractSealedOverrideSealed = context.GetTypeDefinitionData(typeof(IndexerAbstractSealedOverrideSealed));
			
			var breakingChanges = MetadataComparer.CompareTypes(IndexerVirtualOverride, IndexerVirtualSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(IndexerVirtualOverride.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(IndexerVirtualSealedOverride.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerVirtualOverride, IndexerVirtualSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerAbstractOverride, IndexerAbstractSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(IndexerAbstractOverride.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(IndexerAbstractSealedOverride.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerAbstractOverride, IndexerAbstractSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerVirtualNoOverride, IndexerVirtualSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(IndexerVirtual.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(IndexerVirtualSealedOverride.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerVirtualNoOverride, IndexerVirtualSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerAbstractNoOverride, IndexerAbstractSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(IndexerAbstract.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(IndexerAbstractSealedOverride.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(IndexerAbstractNoOverride, IndexerAbstractSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");
		}

		#endregion // IndexerTests

		#region MethodTests

		[Fact]
		public void MethodTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(SealedMemberTests));
			var MethodVirtual = context.GetTypeDefinitionData(typeof(MethodVirtual));
			var MethodAbstract = context.GetTypeDefinitionData(typeof(MethodAbstract));
			var MethodVirtualOverride = context.GetTypeDefinitionData(typeof(MethodVirtualOverride));
			var MethodAbstractOverride = context.GetTypeDefinitionData(typeof(MethodAbstractOverride));
			var MethodVirtualNoOverride = context.GetTypeDefinitionData(typeof(MethodVirtualNoOverride));
			var MethodAbstractNoOverride = context.GetTypeDefinitionData(typeof(MethodAbstractNoOverride));
			var MethodVirtualSealedOverride = context.GetTypeDefinitionData(typeof(MethodVirtualSealedOverride));
			var MethodAbstractSealedOverride = context.GetTypeDefinitionData(typeof(MethodAbstractSealedOverride));
			var MethodVirtualSealedOverrideSealed = context.GetTypeDefinitionData(typeof(MethodVirtualSealedOverrideSealed));
			var MethodAbstractSealedOverrideSealed = context.GetTypeDefinitionData(typeof(MethodAbstractSealedOverrideSealed));
			
			var breakingChanges = MetadataComparer.CompareTypes(MethodVirtualOverride, MethodVirtualSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(MethodVirtualOverride.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(MethodVirtualSealedOverride.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodVirtualOverride, MethodVirtualSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(MethodAbstractOverride, MethodAbstractSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(MethodAbstractOverride.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(MethodAbstractSealedOverride.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodAbstractOverride, MethodAbstractSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(MethodVirtualNoOverride, MethodVirtualSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(MethodVirtual.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(MethodVirtualSealedOverride.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodVirtualNoOverride, MethodVirtualSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(MethodAbstractNoOverride, MethodAbstractSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(MethodAbstract.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(MethodAbstractSealedOverride.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodAbstractNoOverride, MethodAbstractSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");
		}

		#endregion // MethodTests

		#region PropertyTests

		[Fact]
		public void PropertyTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(SealedMemberTests));
			var PropertyVirtual = context.GetTypeDefinitionData(typeof(PropertyVirtual));
			var PropertyAbstract = context.GetTypeDefinitionData(typeof(PropertyAbstract));
			var PropertyVirtualOverride = context.GetTypeDefinitionData(typeof(PropertyVirtualOverride));
			var PropertyAbstractOverride = context.GetTypeDefinitionData(typeof(PropertyAbstractOverride));
			var PropertyVirtualNoOverride = context.GetTypeDefinitionData(typeof(PropertyVirtualNoOverride));
			var PropertyAbstractNoOverride = context.GetTypeDefinitionData(typeof(PropertyAbstractNoOverride));
			var PropertyVirtualSealedOverride = context.GetTypeDefinitionData(typeof(PropertyVirtualSealedOverride));
			var PropertyAbstractSealedOverride = context.GetTypeDefinitionData(typeof(PropertyAbstractSealedOverride));
			var PropertyVirtualSealedOverrideSealed = context.GetTypeDefinitionData(typeof(PropertyVirtualSealedOverrideSealed));
			var PropertyAbstractSealedOverrideSealed = context.GetTypeDefinitionData(typeof(PropertyAbstractSealedOverrideSealed));
			
			var breakingChanges = MetadataComparer.CompareTypes(PropertyVirtualOverride, PropertyVirtualSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(PropertyVirtualOverride.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(PropertyVirtualSealedOverride.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyVirtualOverride, PropertyVirtualSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyAbstractOverride, PropertyAbstractSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(PropertyAbstractOverride.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(PropertyAbstractSealedOverride.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyAbstractOverride, PropertyAbstractSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyVirtualNoOverride, PropertyVirtualSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(PropertyVirtual.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(PropertyVirtualSealedOverride.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyVirtualNoOverride, PropertyVirtualSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyAbstractNoOverride, PropertyAbstractSealedOverride);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a sealed override is added to an unsealed class.");
			AssertX.Equal(BreakingChangeKind.SealedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(PropertyAbstract.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(PropertyAbstractSealedOverride.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyAbstractNoOverride, PropertyAbstractSealedOverrideSealed);
			AssertX.Equal(1, breakingChanges.Count, "There should be no breaking changes when a sealed override is added to a sealed class.");
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

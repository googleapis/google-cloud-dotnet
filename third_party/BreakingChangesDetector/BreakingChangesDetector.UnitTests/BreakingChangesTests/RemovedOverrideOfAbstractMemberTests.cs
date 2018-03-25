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
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class RemovedOverrideOfAbstractMemberTests
    {
        [Fact]
        public void EventTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(RemovedOverrideOfAbstractMemberTests));
            var EventVirtual = context.GetTypeDefinitionData(typeof(EventVirtual));
            var EventAbstract = context.GetTypeDefinitionData(typeof(EventAbstract));
            var EventVirtualOverride = context.GetTypeDefinitionData(typeof(EventVirtualOverride));
            var EventAbstractOverride = context.GetTypeDefinitionData(typeof(EventAbstractOverride));
            var EventVirtualOverrideInternalConstructor = context.GetTypeDefinitionData(typeof(EventVirtualOverrideInternalConstructor));
            var EventAbstractOverrideInternalConstructor = context.GetTypeDefinitionData(typeof(EventAbstractOverrideInternalConstructor));
            var EventVirtualNoOverride = context.GetTypeDefinitionData(typeof(EventVirtualNoOverride));
            var EventAbstractNoOverride = context.GetTypeDefinitionData(typeof(EventAbstractNoOverride));

            var breakingChanges = MetadataComparer.CompareTypes(EventVirtualOverride, EventVirtualNoOverride);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed.");

            breakingChanges = MetadataComparer.CompareTypes(EventVirtualOverrideInternalConstructor, EventVirtualNoOverride);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed and there are no externally visible constructors.");

            breakingChanges = MetadataComparer.CompareTypes(EventAbstractOverride, EventAbstractNoOverride);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an override of an abstract member is removed.");
            AssertX.Equal(BreakingChangeKind.RemovedOverrideOfAbstractMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(EventAbstractOverride.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(EventAbstractNoOverride, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(EventAbstractOverrideInternalConstructor, EventAbstractNoOverride);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an override of an abstract member is removed and there are no externally visible constructors.");
        }

        [Fact]
        public void IndexerTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(RemovedOverrideOfAbstractMemberTests));
            var IndexerVirtual = context.GetTypeDefinitionData(typeof(IndexerVirtual));
            var IndexerAbstract = context.GetTypeDefinitionData(typeof(IndexerAbstract));
            var IndexerVirtualOverride = context.GetTypeDefinitionData(typeof(IndexerVirtualOverride));
            var IndexerAbstractOverride = context.GetTypeDefinitionData(typeof(IndexerAbstractOverride));
            var IndexerVirtualOverrideInternalConstructor = context.GetTypeDefinitionData(typeof(IndexerVirtualOverrideInternalConstructor));
            var IndexerAbstractOverrideInternalConstructor = context.GetTypeDefinitionData(typeof(IndexerAbstractOverrideInternalConstructor));
            var IndexerVirtualNoOverride = context.GetTypeDefinitionData(typeof(IndexerVirtualNoOverride));
            var IndexerAbstractNoOverride = context.GetTypeDefinitionData(typeof(IndexerAbstractNoOverride));

            var breakingChanges = MetadataComparer.CompareTypes(IndexerVirtualOverride, IndexerVirtualNoOverride);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerVirtualOverrideInternalConstructor, IndexerVirtualNoOverride);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed and there are no externally visible constructors.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerAbstractOverride, IndexerAbstractNoOverride);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an override of an abstract member is removed.");
            AssertX.Equal(BreakingChangeKind.RemovedOverrideOfAbstractMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(IndexerAbstractOverride.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(IndexerAbstractNoOverride, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerAbstractOverrideInternalConstructor, IndexerAbstractNoOverride);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an override of an abstract member is removed and there are no externally visible constructors.");
        }

        [Fact]
        public void MethodTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(RemovedOverrideOfAbstractMemberTests));
            var MethodVirtual = context.GetTypeDefinitionData(typeof(MethodVirtual));
            var MethodAbstract = context.GetTypeDefinitionData(typeof(MethodAbstract));
            var MethodVirtualOverride = context.GetTypeDefinitionData(typeof(MethodVirtualOverride));
            var MethodAbstractOverride = context.GetTypeDefinitionData(typeof(MethodAbstractOverride));
            var MethodVirtualOverrideInternalConstructor = context.GetTypeDefinitionData(typeof(MethodVirtualOverrideInternalConstructor));
            var MethodAbstractOverrideInternalConstructor = context.GetTypeDefinitionData(typeof(MethodAbstractOverrideInternalConstructor));
            var MethodVirtualNoOverride = context.GetTypeDefinitionData(typeof(MethodVirtualNoOverride));
            var MethodAbstractNoOverride = context.GetTypeDefinitionData(typeof(MethodAbstractNoOverride));

            var breakingChanges = MetadataComparer.CompareTypes(MethodVirtualOverride, MethodVirtualNoOverride);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed.");

            breakingChanges = MetadataComparer.CompareTypes(MethodVirtualOverrideInternalConstructor, MethodVirtualNoOverride);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed and there are no externally visible constructors.");

            breakingChanges = MetadataComparer.CompareTypes(MethodAbstractOverride, MethodAbstractNoOverride);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an override of an abstract member is removed.");
            AssertX.Equal(BreakingChangeKind.RemovedOverrideOfAbstractMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(MethodAbstractOverride.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(MethodAbstractNoOverride, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(MethodAbstractOverrideInternalConstructor, MethodAbstractNoOverride);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an override of an abstract member is removed and there are no externally visible constructors.");
        }

        [Fact]
        public void PropertyTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(RemovedOverrideOfAbstractMemberTests));
            var PropertyVirtual = context.GetTypeDefinitionData(typeof(PropertyVirtual));
            var PropertyAbstract = context.GetTypeDefinitionData(typeof(PropertyAbstract));
            var PropertyVirtualOverride = context.GetTypeDefinitionData(typeof(PropertyVirtualOverride));
            var PropertyAbstractOverride = context.GetTypeDefinitionData(typeof(PropertyAbstractOverride));
            var PropertyVirtualOverrideInternalConstructor = context.GetTypeDefinitionData(typeof(PropertyVirtualOverrideInternalConstructor));
            var PropertyAbstractOverrideInternalConstructor = context.GetTypeDefinitionData(typeof(PropertyAbstractOverrideInternalConstructor));
            var PropertyVirtualNoOverride = context.GetTypeDefinitionData(typeof(PropertyVirtualNoOverride));
            var PropertyAbstractNoOverride = context.GetTypeDefinitionData(typeof(PropertyAbstractNoOverride));

            var breakingChanges = MetadataComparer.CompareTypes(PropertyVirtualOverride, PropertyVirtualNoOverride);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyVirtualOverrideInternalConstructor, PropertyVirtualNoOverride);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an override of a virtual member is removed and there are no externally visible constructors.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyAbstractOverride, PropertyAbstractNoOverride);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an override of an abstract member is removed.");
            AssertX.Equal(BreakingChangeKind.RemovedOverrideOfAbstractMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(PropertyAbstractOverride.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(PropertyAbstractNoOverride, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyAbstractOverrideInternalConstructor, PropertyAbstractNoOverride);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an override of an abstract member is removed and there are no externally visible constructors.");
        }

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

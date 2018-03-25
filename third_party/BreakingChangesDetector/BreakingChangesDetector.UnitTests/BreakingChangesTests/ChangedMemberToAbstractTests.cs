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
using Xunit;
using System;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class ChangedMemberToAbstractTests
    {
        [Fact]
        public void EventTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(AddedAbstractMemberTests));
            var EventVirtual = context.GetTypeDefinitionData(typeof(EventVirtual));
            var EventAbstract = context.GetTypeDefinitionData(typeof(EventAbstract));

            var breakingChanges = MetadataComparer.CompareTypes(EventVirtual, EventAbstract);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to abstract.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberToAbstract, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(EventVirtual.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(EventAbstract.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(EventAbstract, EventVirtual);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an abstract member changes to virtual.");
        }

        [Fact]
        public void IndexerTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(AddedAbstractMemberTests));
            var indexerVirtual = context.GetTypeDefinitionData(typeof(IndexerVirtual));
            var indexerAbstract = context.GetTypeDefinitionData(typeof(IndexerAbstract));

            var breakingChanges = MetadataComparer.CompareTypes(indexerVirtual, indexerAbstract);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to abstract.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberToAbstract, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(indexerVirtual.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(indexerAbstract.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(indexerAbstract, indexerVirtual);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an abstract member changes to virtual.");
        }

        [Fact]
        public void MethodTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(AddedAbstractMemberTests));
            var methodVirtual = context.GetTypeDefinitionData(typeof(MethodVirtual));
            var methodAbstract = context.GetTypeDefinitionData(typeof(MethodAbstract));

            var breakingChanges = MetadataComparer.CompareTypes(methodVirtual, methodAbstract);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to abstract.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberToAbstract, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(methodVirtual.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(methodAbstract.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodAbstract, methodVirtual);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an abstract member changes to virtual.");
        }

        [Fact]
        public void PropertyTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(AddedAbstractMemberTests));
            var PropertyVirtual = context.GetTypeDefinitionData(typeof(PropertyVirtual));
            var PropertyAbstract = context.GetTypeDefinitionData(typeof(PropertyAbstract));

            var breakingChanges = MetadataComparer.CompareTypes(PropertyVirtual, PropertyAbstract);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a virtual member changes to abstract.");
            AssertX.Equal(BreakingChangeKind.ChangedMemberToAbstract, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(PropertyVirtual.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(PropertyAbstract.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyAbstract, PropertyVirtual);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an abstract member changes to virtual.");
        }

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

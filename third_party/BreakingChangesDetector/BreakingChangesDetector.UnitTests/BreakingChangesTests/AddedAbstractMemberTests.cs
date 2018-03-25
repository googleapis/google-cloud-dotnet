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
using System.Linq;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class AddedAbstractMemberTests
    {
        #region EventTests

        [Fact]
        public void EventTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(AddedAbstractMemberTests));
            var EventNotDeclared = context.GetTypeDefinitionData<EventNotDeclared>();
            var EventAbstract = context.GetTypeDefinitionData<EventAbstract>();

            var breakingChanges = MetadataComparer.CompareTypes(EventNotDeclared, EventAbstract);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an abstract member is added.");
            AssertX.Equal(BreakingChangeKind.AddedAbstractMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Null(breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(EventAbstract.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(EventAbstract, EventNotDeclared).Where(b => b.BreakingChangeKind == BreakingChangeKind.AddedAbstractMember).ToList();
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an abstract member changes to virtual.");
        }

        #endregion // EventTests

        #region IndexerTests

        [Fact]
        public void IndexerTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(AddedAbstractMemberTests));
            var IndexerNotDeclared = context.GetTypeDefinitionData<IndexerNotDeclared>();
            var IndexerAbstract = context.GetTypeDefinitionData<IndexerAbstract>();

            var breakingChanges = MetadataComparer.CompareTypes(IndexerNotDeclared, IndexerAbstract);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an abstract member is added.");
            AssertX.Equal(BreakingChangeKind.AddedAbstractMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Null(breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(IndexerAbstract.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerAbstract, IndexerNotDeclared).Where(b => b.BreakingChangeKind == BreakingChangeKind.AddedAbstractMember).ToList();
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an abstract member changes to virtual.");
        }

        #endregion // IndexerTests

        #region MethodTests

        [Fact]
        public void MethodTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(AddedAbstractMemberTests));
            var MethodNotDeclared = context.GetTypeDefinitionData<MethodNotDeclared>();
            var MethodAbstract = context.GetTypeDefinitionData<MethodAbstract>();

            var breakingChanges = MetadataComparer.CompareTypes(MethodNotDeclared, MethodAbstract);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an abstract member is added.");
            AssertX.Equal(BreakingChangeKind.AddedAbstractMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Null(breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(MethodAbstract.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(MethodAbstract, MethodNotDeclared).Where(b => b.BreakingChangeKind == BreakingChangeKind.AddedAbstractMember).ToList();
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an abstract member changes to virtual.");
        }

        #endregion // MethodTests

        #region PropertyTests

        [Fact]
        public void PropertyTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(AddedAbstractMemberTests));
            var PropertyNotDeclared = context.GetTypeDefinitionData<PropertyNotDeclared>();
            var PropertyAbstract = context.GetTypeDefinitionData<PropertyAbstract>();

            var breakingChanges = MetadataComparer.CompareTypes(PropertyNotDeclared, PropertyAbstract);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an abstract member is added.");
            AssertX.Equal(BreakingChangeKind.AddedAbstractMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Null(breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(PropertyAbstract.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyAbstract, PropertyNotDeclared).Where(b => b.BreakingChangeKind == BreakingChangeKind.AddedAbstractMember).ToList();
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an abstract member changes to virtual.");
        }

        #endregion // PropertyTests


#pragma warning disable 0067
        public abstract class EventNotDeclared { }
        public abstract class EventAbstract { public abstract event EventHandler Event; }
#pragma warning restore 0067

        public abstract class IndexerNotDeclared { }
        public abstract class IndexerAbstract { public abstract int this[int x] { get; } }

        public abstract class MethodNotDeclared { }
        public abstract class MethodAbstract { public abstract int Method(); }

        public abstract class PropertyNotDeclared { }
        public abstract class PropertyAbstract { public abstract int Property { get; } }
    }
}

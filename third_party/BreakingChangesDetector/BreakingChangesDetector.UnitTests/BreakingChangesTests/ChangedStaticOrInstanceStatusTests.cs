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
    public class ChangedStaticOrInstanceStatusTests
    {
        #region EventTests

        [Fact]
        public void EventTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var EventInstance = context.GetTypeDefinitionData(typeof(EventInstance));
            var EventStatic = context.GetTypeDefinitionData(typeof(EventStatic));

            var breakingChanges = MetadataComparer.CompareTypes(EventInstance, EventStatic);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an instance member changes to static.");
            AssertX.Equal(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(EventInstance.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(EventStatic.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(EventStatic, EventInstance);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a static member changes to instance.");
            AssertX.Equal(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(EventStatic.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(EventInstance.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // EventTests

        #region FieldTests

        [Fact]
        public void FieldTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var FieldInstance = context.GetTypeDefinitionData(typeof(FieldInstance));
            var FieldStatic = context.GetTypeDefinitionData(typeof(FieldStatic));

            var breakingChanges = MetadataComparer.CompareTypes(FieldInstance, FieldStatic);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an instance member changes to static.");
            AssertX.Equal(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(FieldInstance.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(FieldStatic.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(FieldStatic, FieldInstance);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a static member changes to instance.");
            AssertX.Equal(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(FieldStatic.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(FieldInstance.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // FieldTests

        #region MethodTests

        [Fact]
        public void MethodTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var MethodInstance = context.GetTypeDefinitionData(typeof(MethodInstance));
            var MethodStatic = context.GetTypeDefinitionData(typeof(MethodStatic));

            var breakingChanges = MetadataComparer.CompareTypes(MethodInstance, MethodStatic);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an instance member changes to static.");
            AssertX.Equal(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(MethodInstance.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(MethodStatic.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(MethodStatic, MethodInstance);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a static member changes to instance.");
            AssertX.Equal(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(MethodStatic.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(MethodInstance.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // MethodTests

        #region PropertyTests

        [Fact]
        public void PropertyTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var PropertyInstance = context.GetTypeDefinitionData(typeof(PropertyInstance));
            var PropertyStatic = context.GetTypeDefinitionData(typeof(PropertyStatic));

            var breakingChanges = MetadataComparer.CompareTypes(PropertyInstance, PropertyStatic);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an instance member changes to static.");
            AssertX.Equal(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(PropertyInstance.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(PropertyStatic.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(PropertyStatic, PropertyInstance);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a static member changes to instance.");
            AssertX.Equal(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(PropertyStatic.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(PropertyInstance.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // PropertyTests


#pragma warning disable 0067
        public class EventInstance { public event EventHandler<int> Event; }
        public class EventStatic { public static event EventHandler<int> Event; }
#pragma warning restore 0067

        public class FieldInstance { public int Field; }
        public class FieldStatic { public static int Field; }

        public class MethodInstance { public int Method() { return 0; } }
        public class MethodStatic { public static int Method() { return 0; } }

        public class PropertyInstance { public int Property { get { return 0; } } }
        public class PropertyStatic { public static int Property { get { return 0; } } }
    }
}

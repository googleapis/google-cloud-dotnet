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

using System.Linq;
using Xunit;
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class ChangedClassToStaticTests
    {
        [Fact]
        public void NestedTypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedClassToStaticTests));
            var NestedClass = context.GetTypeDefinitionData(typeof(NestedClass));
            var NestedClassWithInternalConstructor = context.GetTypeDefinitionData(typeof(NestedClassWithInternalConstructor));
            var NestedClassWithProtectedConstructor = context.GetTypeDefinitionData(typeof(NestedClassWithProtectedConstructor));
            var NestedStaticClass = context.GetTypeDefinitionData(typeof(NestedStaticClass));

            var breakingChanges = MetadataComparer.CompareTypes(NestedClass, NestedStaticClass).Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedClassToStatic).ToList();
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a class is made static.");
            AssertX.Equal(BreakingChangeKind.ChangedClassToStatic, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(NestedClass.GetMember("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(NestedStaticClass.GetMember("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(NestedClassWithInternalConstructor, NestedStaticClass);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a class with no public constructors is made abstract.");

            breakingChanges = MetadataComparer.CompareTypes(NestedClassWithProtectedConstructor, NestedStaticClass).Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedClassToStatic).ToList();
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a class is made static.");
            AssertX.Equal(BreakingChangeKind.ChangedClassToStatic, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(NestedClassWithProtectedConstructor.GetMember("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(NestedStaticClass.GetMember("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        [Fact]
        public void TypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedClassToStaticTests));
            var Class = context.GetTypeDefinitionData(typeof(Class));
            var ClassWithInternalConstructor = context.GetTypeDefinitionData(typeof(ClassWithInternalConstructor));
            var ClassWithProtectedConstructor = context.GetTypeDefinitionData(typeof(ClassWithProtectedConstructor));
            var StaticClass = context.GetTypeDefinitionData(typeof(StaticClass));

            var breakingChanges = MetadataComparer.CompareTypes(Class, StaticClass).Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedClassToStatic).ToList();
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a class is made static.");
            AssertX.Equal(BreakingChangeKind.ChangedClassToStatic, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(Class, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(StaticClass, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithInternalConstructor, StaticClass);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a class with no public constructors is made abstract.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithProtectedConstructor, StaticClass).Where(b => b.BreakingChangeKind == BreakingChangeKind.ChangedClassToStatic).ToList();
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a class is made static.");
            AssertX.Equal(BreakingChangeKind.ChangedClassToStatic, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithProtectedConstructor, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(StaticClass, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        public class NestedClass { public class Class { } }
        public class NestedClassWithInternalConstructor { public class Class { internal Class() { } } }
        public class NestedClassWithProtectedConstructor { public class Class { protected Class() { } } }
        public class NestedStaticClass { public static class Class { } }

        public class Class { }
        public class ClassWithInternalConstructor { internal ClassWithInternalConstructor() { } }
        public class ClassWithProtectedConstructor { protected ClassWithProtectedConstructor() { } }
        public static class StaticClass { }
    }
}

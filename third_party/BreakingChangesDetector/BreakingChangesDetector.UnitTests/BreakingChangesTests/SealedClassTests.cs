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
using System.Linq;
using Xunit;
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class SealedClassTests
    {
        #region NestedTypeTests

        [Fact]
        public void NestedTypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var nestedUnsealedClass = context.GetTypeDefinitionData(typeof(NestedUnsealedClass));
            var nestedUnsealedClassWithInternalConstructor = context.GetTypeDefinitionData(typeof(NestedUnsealedClassWithInternalConstructor));
            var nestedSealedClass = context.GetTypeDefinitionData(typeof(NestedSealedClass));

            var breakingChanges = MetadataComparer.CompareTypes(nestedUnsealedClass, nestedSealedClass);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a type is sealed.");
            AssertX.Equal(BreakingChangeKind.SealedClass, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedUnsealedClass.GetNestedType("Class"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedSealedClass.GetNestedType("Class"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedUnsealedClassWithInternalConstructor, nestedSealedClass);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a type is sealed which couldn't be derived externally.");

            breakingChanges = MetadataComparer.CompareTypes(nestedSealedClass, nestedUnsealedClass);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when unsealing a class.");

            breakingChanges = MetadataComparer.CompareTypes(nestedSealedClass, nestedUnsealedClassWithInternalConstructor);
            AssertX.Equal(0, breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.SealedClass).Count(), "There should be no breaking changes when unsealing a class.");
        }

        #endregion // NestedTypeTests

        #region TypeTests

        [Fact]
        public void TypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var unsealedClass = context.GetTypeDefinitionData(typeof(UnsealedClass));
            var unsealedClassWithInternalConstructor = context.GetTypeDefinitionData(typeof(UnsealedClassWithInternalConstructor));
            var sealedClass = context.GetTypeDefinitionData(typeof(SealedClass));

            var breakingChanges = MetadataComparer.CompareTypes(unsealedClass, sealedClass);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a type is sealed.");
            AssertX.Equal(BreakingChangeKind.SealedClass, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(unsealedClass, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(sealedClass, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(unsealedClassWithInternalConstructor, sealedClass);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a type is sealed which couldn't be derived externally.");

            breakingChanges = MetadataComparer.CompareTypes(sealedClass, unsealedClass);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when unsealing a class.");

            breakingChanges = MetadataComparer.CompareTypes(sealedClass, unsealedClassWithInternalConstructor);
            AssertX.Equal(0, breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.SealedClass).Count(), "There should be no breaking changes when unsealing a class.");
        }

        #endregion // TypeTests

        public class NestedUnsealedClass { public class Class { } }
        public class NestedUnsealedClassWithInternalConstructor { public class Class { internal Class() { } } }
        public class NestedSealedClass { public sealed class Class { } }

        public class UnsealedClass { }
        public class UnsealedClassWithInternalConstructor { internal UnsealedClassWithInternalConstructor() { } }
        public sealed class SealedClass { }
    }
}

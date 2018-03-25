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

using Xunit;
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class RemovedExtensionMethodModifierTests
    {
        [Fact]
        public void MethodTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(RemovedExtensionMethodModifierTests));
            var ClassWithExtensionMethod = context.GetTypeDefinitionData(typeof(ClassWithExtensionMethod));
            var ClassWithoutExtensionMethod = context.GetTypeDefinitionData(typeof(ClassWithoutExtensionMethod));

            var breakingChanges = MetadataComparer.CompareTypes(ClassWithExtensionMethod, ClassWithoutExtensionMethod);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an extension method is turned into a normal method.");
            AssertX.Equal(BreakingChangeKind.RemovedExtensionMethodModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithExtensionMethod.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(ClassWithoutExtensionMethod.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithoutExtensionMethod, ClassWithExtensionMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an normal method is turned into an extension method.");
        }
    }

    public static class ClassWithExtensionMethod { public static void Method(this RemovedExtensionMethodModifierTests x) { } }
    public static class ClassWithoutExtensionMethod { public static void Method(RemovedExtensionMethodModifierTests x) { } }
}

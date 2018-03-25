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
    public class ChangedFieldToReadOnlyTests
    {
        [Fact]
        public void FieldTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedMemberTypeTests));
            var FieldReadOnly = context.GetTypeDefinitionData(typeof(FieldReadOnly));
            var FieldReadWrite = context.GetTypeDefinitionData(typeof(FieldReadWrite));

            var breakingChanges = MetadataComparer.CompareTypes(FieldReadOnly, FieldReadWrite);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when changing a read-only field to read/write.");

            breakingChanges = MetadataComparer.CompareTypes(FieldReadWrite, FieldReadOnly);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when changing a read/write field to read-only.");
            AssertX.Equal(BreakingChangeKind.ChangedFieldToReadOnly, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(FieldReadWrite.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(FieldReadOnly.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        public class FieldReadOnly { public readonly int Field; }
        public class FieldReadWrite { public int Field; }
    }
}

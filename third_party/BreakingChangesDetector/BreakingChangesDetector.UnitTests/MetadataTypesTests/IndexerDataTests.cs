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

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
    public class IndexerDataTests
    {
        #region IndexerDataAccessibilityTest

        [Fact]
        public void IndexerDataAccessibilityTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);

            var members = typeData.GetMembers("Item");
            AssertX.Equal(3, members.Count, "Incorrect number of indexers returned.");
            AssertX.Equal(MemberAccessibility.Protected, ((IndexerData)members[0]).Accessibility, "Incorrect MemberAccessibility.");
            AssertX.Equal(MemberAccessibility.Public, ((IndexerData)members[1]).Accessibility, "Incorrect MemberAccessibility.");
            AssertX.Equal(MemberAccessibility.Public, ((IndexerData)members[2]).Accessibility, "Incorrect MemberAccessibility.");
        }

        #endregion // IndexerDataAccessibilityTest

        #region IndexerDataDeclaringTypeTest

        [Fact]
        public void IndexerDataDeclaringTypeTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var indexer = typeData.GetMembers("Item")[0];
            AssertX.Equal(typeData, indexer.ContainingType, "The DeclaringType of a member should be the type in which it is defined.");
        }

        #endregion // IndexerDataDeclaringTypeTest

        #region IndexerDataMemberFlagsTest

        [Fact]
        public void IndexerDataMemberFlagsTest()
        {
            var t = typeof(OverloadedMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);

            var members = typeData.GetMembers("Item");
            AssertX.Equal(9, members.Count, "Incorrect number of indexers");

            var indexerData = (IndexerData)members[0];
            AssertX.Equal(MemberFlags.None, indexerData.MemberFlags, "The Flags value of the member is wrong.");
            indexerData = (IndexerData)members[1];
            AssertX.Equal(MemberFlags.Abstract, indexerData.MemberFlags, "The Flags value of the member is wrong.");
            indexerData = (IndexerData)members[2];
            AssertX.Equal(MemberFlags.Virtual, indexerData.MemberFlags, "The Flags value of the member is wrong.");
            indexerData = (IndexerData)members[3];
            AssertX.Equal(MemberFlags.Override, indexerData.MemberFlags, "The Flags value of the member is wrong.");
            indexerData = (IndexerData)members[4];
            AssertX.Equal(MemberFlags.Override | MemberFlags.Sealed, indexerData.MemberFlags, "The Flags value of the member is wrong.");
            indexerData = (IndexerData)members[5];
            AssertX.Equal(MemberFlags.Override | MemberFlags.Abstract, indexerData.MemberFlags, "The Flags value of the member is wrong.");
            indexerData = (IndexerData)members[6];
            AssertX.Equal(MemberFlags.Override, indexerData.MemberFlags, "The Flags value of the member is wrong.");
            indexerData = (IndexerData)members[7];
            AssertX.Equal(MemberFlags.Override | MemberFlags.Sealed, indexerData.MemberFlags, "The Flags value of the member is wrong.");
            indexerData = (IndexerData)members[8];
            AssertX.Equal(MemberFlags.Override | MemberFlags.Abstract, indexerData.MemberFlags, "The Flags value of the member is wrong.");
        }

        #endregion // IndexerDataMemberFlagsTest

        #region IndexerDataGetMethodAccessibilityTest

        [Fact]
        public void IndexerDataGetMethodAccessibilityTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);

            var members = typeData.GetMembers("Item");

            var readOnlyIndexer = (IndexerData)members[0];
            AssertX.Equal(MemberAccessibility.Protected, readOnlyIndexer.GetMethodAccessibility, "The GetMethodAccessibility of the read only property is incorrect.");

            var writeOnlyIndexer = (IndexerData)members[1];
            AssertX.Equal(null, writeOnlyIndexer.GetMethodAccessibility, "The GetMethodAccessibility of the write only property is incorrect.");

            var readWriteIndexer = (IndexerData)members[2];
            AssertX.Equal(MemberAccessibility.Public, readWriteIndexer.GetMethodAccessibility, "The GetMethodAccessibility of the read write property is incorrect.");
        }

        #endregion // IndexerDataGetMethodAccessibilityTest

        #region IndexerDataNameTest

        [Fact]
        public void IndexerDataNameTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var indexer = typeData.GetMembers("Item")[0];
            AssertX.Equal("Item", indexer.Name, "The Name of the member is incorrect.");
        }

        #endregion // IndexerDataNameTest

        #region IndexerDataParametersTest

        [Fact]
        public void IndexerDataParametersTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var members = typeData.GetMembers("Item");
            AssertX.Equal(3, members.Count, "Incorrect number of constructors returned.");
            AssertX.Equal(1, ((IndexerData)members[0]).Parameters.Count, "The read only indexer has the wrong number of parameters.");
            AssertX.Equal(2, ((IndexerData)members[1]).Parameters.Count, "The write only indexer has the wrong number of parameters.");
            AssertX.Equal(3, ((IndexerData)members[2]).Parameters.Count, "The read write indexer has the wrong number of parameters.");
        }

        #endregion // IndexerDataParametersTest

        #region IndexerDataSetMethodAccessibilityTest

        [Fact]
        public void IndexerDataSetMethodAccessibilityTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);

            var members = typeData.GetMembers("Item");

            var readOnlyIndexer = (IndexerData)members[0];
            AssertX.Equal(null, readOnlyIndexer.SetMethodAccessibility, "The SetMethodAccessibility of the read only property is incorrect.");

            var writeOnlyIndexer = (IndexerData)members[1];
            AssertX.Equal(MemberAccessibility.Public, writeOnlyIndexer.SetMethodAccessibility, "The SetMethodAccessibility of the write only property is incorrect.");

            var readWriteIndexer = (IndexerData)members[2];
            AssertX.Equal(MemberAccessibility.Protected, readWriteIndexer.SetMethodAccessibility, "The SetMethodAccessibility of the read write property is incorrect.");
        }

        #endregion // IndexerDataSetMethodAccessibilityTest

        #region IndexerDataTypeTest

        [Fact]
        public void IndexerDataTypeTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var indexer = (IndexerData)typeData.GetMembers("Item")[0];
            var objectType = context.GetTypeDefinitionData<object>();
            AssertX.Equal(objectType, indexer.Type, "The Type of the member is incorrect.");
        }

        #endregion // IndexerDataTypeTest
    }
}

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
using BreakingChangesDetector.MetadataItems;

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
    public class FieldDataTests
    {
        #region FieldDataAccessibilityTest

        [Fact]
        public void FieldDataAccessibilityTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            TestUtilities.VerifyAccessibility(typeData, "FieldInstance");
        }

        #endregion // FieldDataAccessibilityTest

        #region FieldDataDeclaringTypeTest

        [Fact]
        public void FieldDataDeclaringTypeTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var field = typeData.GetMember("FieldInstance");
            AssertX.Equal(typeData, field.ContainingType, "The DeclaringType of a member should be the type in which it is defined.");
        }

        #endregion // FieldDataDeclaringTypeTest

        #region FieldDataIsReadOnlyTest

        [Fact]
        public void FieldDataIsReadOnlyTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var field = (FieldData)typeData.GetMember("FieldInstance");
            Assert.False(field.IsReadOnly, "The IsReadOnly of the member is incorrect.");
            field = (FieldData)typeData.GetMember("FieldReadOnlyInstance");
            Assert.True(field.IsReadOnly, "The IsReadOnly of the member is incorrect.");
            field = (FieldData)typeData.GetMember("FieldStatic");
            Assert.False(field.IsReadOnly, "The IsReadOnly of the member is incorrect.");
            field = (FieldData)typeData.GetMember("FieldReadOnlyStatic");
            Assert.True(field.IsReadOnly, "The IsReadOnly of the member is incorrect.");
        }

        #endregion // FieldDataIsReadOnlyTest

        #region FieldDataMemberFlagsTest

        [Fact]
        public void FieldDataMemberFlagsTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);

            var field = (FieldData)typeData.GetMember("FieldInstance");
            AssertX.Equal(MemberFlags.None, field.MemberFlags, "The Flags value of the member is wrong.");

            field = (FieldData)typeData.GetMember("FieldStatic");
            AssertX.Equal(MemberFlags.Static, field.MemberFlags, "The Flags value of the member is wrong.");
        }

        #endregion // FieldDataMemberFlagsTest

        #region FieldDataNameTest

        [Fact]
        public void FieldDataNameTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var field = typeData.GetMember("FieldInstance");
            AssertX.Equal("FieldInstance", field.Name, "The Name of the member is incorrect.");
        }

        #endregion // FieldDataNameTest

        #region FieldDataTypeTest

        [Fact]
        public void FieldDataTypeTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var field = (FieldData)typeData.GetMember("FieldInstance");
            var intType = context.GetTypeDefinitionData<int>();
            AssertX.Equal(intType, field.Type, "The Type of the member is incorrect.");
        }

        #endregion // FieldDataTypeTest
    }
}

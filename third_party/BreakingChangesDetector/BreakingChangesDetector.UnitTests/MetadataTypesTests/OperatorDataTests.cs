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
    public class OperatorDataTests
    {
        #region OperatorDataAccessibilityTest

        [Fact]
        public void OperatorDataAccessibilityTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var member = typeData.GetMember("op_Addition");
            AssertX.Equal(MemberAccessibility.Public, member.Accessibility, "Incorrect Accessibility");
        }

        #endregion // OperatorDataAccessibilityTest

        #region OperatorDataAllOperatorsTest

        [Fact]
        public void OperatorDataAllOperatorsTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);

            Assert.NotNull(typeData.GetMember("op_Implicit"));
            Assert.NotNull(typeData.GetMember("op_Explicit"));
            Assert.NotNull(typeData.GetMember("op_Addition"));
            Assert.NotNull(typeData.GetMember("op_Subtraction"));
            Assert.NotNull(typeData.GetMember("op_Multiply"));
            Assert.NotNull(typeData.GetMember("op_Division"));
            Assert.NotNull(typeData.GetMember("op_Modulus"));
            Assert.NotNull(typeData.GetMember("op_ExclusiveOr"));
            Assert.NotNull(typeData.GetMember("op_BitwiseAnd"));
            Assert.NotNull(typeData.GetMember("op_BitwiseOr"));
            Assert.NotNull(typeData.GetMember("op_LeftShift"));
            Assert.NotNull(typeData.GetMember("op_RightShift"));
            Assert.NotNull(typeData.GetMember("op_Equality"));
            Assert.NotNull(typeData.GetMember("op_GreaterThan"));
            Assert.NotNull(typeData.GetMember("op_LessThan"));
            Assert.NotNull(typeData.GetMember("op_Inequality"));
            Assert.NotNull(typeData.GetMember("op_GreaterThanOrEqual"));
            Assert.NotNull(typeData.GetMember("op_LessThanOrEqual"));
            Assert.NotNull(typeData.GetMember("op_Decrement"));
            Assert.NotNull(typeData.GetMember("op_Increment"));
            Assert.NotNull(typeData.GetMember("op_UnaryNegation"));
            Assert.NotNull(typeData.GetMember("op_UnaryPlus"));
            Assert.NotNull(typeData.GetMember("op_OnesComplement"));
            Assert.NotNull(typeData.GetMember("op_LogicalNot"));
            Assert.NotNull(typeData.GetMember("op_True"));
            Assert.NotNull(typeData.GetMember("op_False"));
        }

        #endregion // OperatorDataAllOperatorsTest

        #region OperatorDataDeclaringTypeTest

        [Fact]
        public void OperatorDataDeclaringTypeTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var method = typeData.GetMember("op_Addition");
            AssertX.Equal(typeData, method.ContainingType, "The DeclaringType of a member should be the type in which it is defined.");
        }

        #endregion // OperatorDataDeclaringTypeTest

        #region OperatorDataNameTest

        [Fact]
        public void OperatorDataNameTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var method = typeData.GetMember("op_Addition");
            AssertX.Equal("op_Addition", method.Name, "The Name of the member is incorrect.");
        }

        #endregion // OperatorDataNameTest

        #region OperatorDataParametersTest

        [Fact]
        public void OperatorDataParametersTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var method = (OperatorData)typeData.GetMember("op_Addition");
            AssertX.Equal(2, method.Parameters.Count, "The public method has the wrong number of parameters.");
        }

        #endregion // OperatorDataParametersTest

        #region OperatorDataTypeTest

        [Fact]
        public void OperatorDataTypeTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var voidType = context.GetTypeDefinitionData(typeof(void));

            var method = (OperatorData)typeData.GetMember("op_Addition");
            AssertX.Equal(typeData, method.Type, "The Type of the member is incorrect.");
        }

        #endregion // OperatorDataTypeTest
    }
}

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
using System.Reflection;
using Microsoft.CodeAnalysis;

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
    public class GenericTypeParameterDataTests
    {
        #region GenericTypeParameterDataContraintsTest

        [Fact]
        public void GenericTypeParameterDataContraintsTest()
        {
            var t = typeof(TestClassDefinition<,,,,>);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var testClassDefinitionData = context.GetTypeDefinitionData(t);
            var equatableInterfaceData = context.GetConstructedGenericTypeData<IEquatable<TestClassDefinition>>();
            var testInterfaceDefinitionData = context.GetTypeDefinitionData<TestInterfaceDefinition>();
            var valueTypeData = context.GetTypeDefinitionData<ValueType>();

            var p1 = testClassDefinitionData.GenericParameters[0];
            AssertX.Equal(0, p1.Constraints.Count, "The number of Constraints on the genertic type parameter is incorrect.");

            var p2 = testClassDefinitionData.GenericParameters[1];
            AssertX.Equal(2, p2.Constraints.Count, "The number of Constraints on the genertic type parameter is incorrect.");
            // Note: these may need to be reversed
            AssertX.Equal(equatableInterfaceData, p2.Constraints[0], "The reported type is not correct.");
            AssertX.Equal(testInterfaceDefinitionData, p2.Constraints[1], "The reported type is not correct.");

            var p3 = testClassDefinitionData.GenericParameters[2];
            AssertX.Equal(0, p3.Constraints.Count, "The number of Constraints on the genertic type parameter is incorrect.");

            var p4 = testClassDefinitionData.GenericParameters[3];
            AssertX.Equal(0, p4.Constraints.Count, "The number of Constraints on the genertic type parameter is incorrect.");

            var p5 = testClassDefinitionData.GenericParameters[4];
            AssertX.Equal(0, p5.Constraints.Count, "The number of Constraints on the genertic type parameter is incorrect.");
        }

        #endregion // GenericTypeParameterDataContraintsTest

        #region GenericTypeParameterDataGenericParameterAttributesTest

        [Fact]
        public void GenericTypeParameterDataGenericParameterAttributesTest()
        {
            var t = typeof(TestClassDefinition<,,,,>);
            var context = MetadataResolutionContext.CreateFromTypes(t);

            var typeData = context.GetTypeDefinitionData(t);

            var p1 = typeData.GenericParameters[0];
            AssertX.Equal(GenericParameterAttributes.None, p1.GenericParameterAttributes, "The number of generic parameters is incorrect.");

            var p2 = typeData.GenericParameters[1];
            AssertX.Equal(GenericParameterAttributes.None, p2.GenericParameterAttributes, "The number of generic parameters is incorrect.");

            var p3 = typeData.GenericParameters[2];
            AssertX.Equal(GenericParameterAttributes.ReferenceTypeConstraint, p3.GenericParameterAttributes, "The number of generic parameters is incorrect.");

            var p4 = typeData.GenericParameters[3];
            AssertX.Equal(GenericParameterAttributes.NotNullableValueTypeConstraint, p4.GenericParameterAttributes, "The number of generic parameters is incorrect.");

            var p5 = typeData.GenericParameters[4];
            AssertX.Equal(GenericParameterAttributes.DefaultConstructorConstraint, p5.GenericParameterAttributes, "The number of generic parameters is incorrect.");

            typeData = context.GetTypeDefinitionData(typeof(TestInterfaceDefinition<,,>));

            p1 = typeData.GenericParameters[0];
            AssertX.Equal(GenericParameterAttributes.None, p1.GenericParameterAttributes, "The number of generic parameters is incorrect.");

            p2 = typeData.GenericParameters[1];
            AssertX.Equal(GenericParameterAttributes.Contravariant, p2.GenericParameterAttributes, "The number of generic parameters is incorrect.");

            p3 = typeData.GenericParameters[2];
            AssertX.Equal(GenericParameterAttributes.Covariant, p3.GenericParameterAttributes, "The number of generic parameters is incorrect.");
        }

        #endregion // GenericTypeParameterDataGenericParameterAttributesTest

        #region GenericTypeParameterDataKindTest

        [Fact]
        public void GenericTypeParameterDataKindTest()
        {
            var t = typeof(TestClassDefinition<,,,,>);
            var context = MetadataResolutionContext.CreateFromTypes(typeof(TestClassDefinition<,,,,>));
            var typeData = context.GetTypeDefinitionData(t);

            Assert.Equal(TypeKind.Class, typeData.GenericParameters[0].TypeKind);
            Assert.Equal(TypeKind.Class, typeData.GenericParameters[1].TypeKind);
            Assert.Equal(TypeKind.Class, typeData.GenericParameters[2].TypeKind);
            Assert.Equal(TypeKind.Struct, typeData.GenericParameters[3].TypeKind);
            Assert.Equal(TypeKind.Class, typeData.GenericParameters[4].TypeKind);
        }

        #endregion // GenericTypeParameterDataKindTest

        #region GenericTypeParameterDataNameTest

        [Fact]
        public void GenericTypeParameterDataNameTest()
        {
            var t = typeof(TestClassDefinition<,,,,>);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);

            var p1 = typeData.GenericParameters[0];
            AssertX.Equal(t.GetGenericArguments()[0].Name, p1.Name, "The Name is not assigned correctly.");
        }

        #endregion // GenericTypeParameterDataNameTest
    }
}

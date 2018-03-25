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
using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
    public class TypeDefinitionDataTests
    {
        #region ProtectedMembersInSealedClassesNotStoredTest

        [Fact]
        public void ProtectedMembersInSealedClassesNotStoredTest()
        {
            var t = typeof(SealedClass);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var members = typeData.GetMembers("MethodVirtual");
            Assert.True(members == null || members.Count == 0, "Protected members of sealed classes should never be considered for breaking changes.");
        }

        #endregion // ProtectedMembersInSealedClassesNotStoredTest

        #region TypeDefinitionDataAccessibilityTest

        [Fact]
        public void TypeDefinitionDataAccessibilityTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            TestUtilities.VerifyAccessibility(typeData, "NestedStruct");
        }

        #endregion // TypeDefinitionDataAccessibilityTest

        #region TypeDefinitionDataAssemblyTest

        [Fact]
        public void TypeDefinitionDataAssemblyTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var assembly = context.GetAssemblyData(t.Assembly);
            var typeData = context.GetTypeDefinitionData(t);
            AssertX.Equal(assembly, typeData.AssemblyData, "The Assembly reference is not assigned correctly.");
        }

        #endregion // TypeDefinitionDataAssemblyTest

        #region TypeDefinitionDataBaseTypeTest

        [Fact]
        public void TypeDefinitionDataBaseTypeTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var testClassDefinitionData = context.GetTypeDefinitionData(t);
            var testClassDefinitionBaseData = context.GetTypeDefinitionData(typeof(TestClassDefinitionBase));
            var marshalByRefObjectData = context.GetTypeDefinitionData<MarshalByRefObject>();
            var objectData = context.GetTypeDefinitionData<Object>();

            DeclaringTypeData current = testClassDefinitionData;
            AssertX.Equal(testClassDefinitionBaseData, current.BaseType, "The base type of " + current.Name + "is incorrect.");
            current = current.BaseType;
            AssertX.Equal(marshalByRefObjectData, current.BaseType, "The base type of " + current.Name + "is incorrect.");
            current = current.BaseType;
            AssertX.Equal(objectData, current.BaseType, "The base type of " + current.Name + "is incorrect.");
            current = current.BaseType;
            AssertX.Null(current.BaseType, "The base type of " + current.Name + "is incorrect.");

            var testEnumDefinitionData = context.GetTypeDefinitionData(typeof(TestEnumDefinition));
            var intData = context.GetTypeDefinitionData<int>();
            var valueTypeData = context.GetTypeDefinitionData<ValueType>();
            current = testEnumDefinitionData;
            AssertX.Equal(intData, current.BaseType, "The base type of " + current.Name + "is incorrect.");
            current = current.BaseType;
            AssertX.Equal(valueTypeData, current.BaseType, "The base type of " + current.Name + "is incorrect.");
            current = current.BaseType;
            AssertX.Equal(objectData, current.BaseType, "The base type of " + current.Name + "is incorrect.");
            current = current.BaseType;
            AssertX.Null(current.BaseType, "The base type of " + current.Name + "is incorrect.");

            var testInterfaceDefinitionData = context.GetTypeDefinitionData(typeof(TestInterfaceDefinition));
            current = testInterfaceDefinitionData;
            AssertX.Equal(null, current.BaseType, "The base type of " + current.Name + "is incorrect.");
        }

        #endregion // TypeDefinitionDataBaseTypeTest

        #region TypeDefinitionDataDeclaringTypeTest

        [Fact]
        public void TypeDefinitionDataDeclaringTypeTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            AssertX.Null(typeData.ContainingType, "The DeclaringType of a root level type should be null.");
            var nestedType = typeData.GetMember("NestedStruct");
            AssertX.Equal(typeData, nestedType.ContainingType, "The DeclaringType of a nested type should be the root level type.");
        }

        #endregion // TypeDefinitionDataDeclaringTypeTest

        #region TypeDefinitionDataDelegateParametersTest

        [Fact]
        public void TypeDefinitionDataDelegateParametersTest()
        {
            var t = typeof(TestDelegateDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);

            var typeData = context.GetTypeDefinitionData(t);
            AssertX.Equal(0, typeData.DelegateParameters.Count, "The number of delegate parameters is incorrect.");

            typeData = context.GetTypeDefinitionData(typeof(TestDelegateDefinitionWithParams));
            AssertX.Equal(2, typeData.DelegateParameters.Count, "The number of delegate parameters is incorrect.");
        }

        #endregion // TypeDefinitionDataDelegateParametersTest

        #region TypeDefinitionDataFlagsTest

        [Fact]
        public void TypeDefinitionDataFlagsTest()
        {
            var t = typeof(UnsealedClass);
            var context = MetadataResolutionContext.CreateFromTypes(t);

            var typeData = context.GetTypeDefinitionData(t);
            AssertX.Equal(MemberFlags.None, typeData.MemberFlags, "The Flags of class incorrect.");

            typeData = context.GetTypeDefinitionData(typeof(SealedClass));
            AssertX.Equal(MemberFlags.Sealed, typeData.MemberFlags, "The Flags of class incorrect.");

            typeData = context.GetTypeDefinitionData(typeof(AbstractClass));
            AssertX.Equal(MemberFlags.Abstract, typeData.MemberFlags, "The Flags of class incorrect.");

            typeData = context.GetTypeDefinitionData(typeof(StaticClass));
            AssertX.Equal(MemberFlags.Static, typeData.MemberFlags, "The Flags of class incorrect.");
        }

        #endregion // TypeDefinitionDataFlagsTest

        #region TypeDefinitionDataFullNameTest

        [Fact]
        public void TypeDefinitionDataFullNameTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            AssertX.Equal(t.FullName, typeData.FullName, "The FullName is not assigned correctly.");
        }

        #endregion // TypeDefinitionDataFullNameTest

        #region TypeDefinitionDataGenericParametersTest

        [Fact]
        public void TypeDefinitionDataGenericParametersTest()
        {
            var t = typeof(TestClassDefinition<,,,,>);
            var context = MetadataResolutionContext.CreateFromTypes(t);

            var testClassDefinitionData = context.GetTypeDefinitionData(t);
            AssertX.Equal(5, testClassDefinitionData.GenericParameters.Count, "The number of generic parameters is incorrect.");

            var baseType = (ConstructedGenericTypeData)context.GetTypeDefinitionData(typeof(TestClassDefinitionPartiallyDerived<,,>)).BaseType;
            AssertX.Equal(5, baseType.GenericArguments.Count, "The number of generic arguments is incorrect.");
        }

        #endregion // TypeDefinitionDataGenericParametersTest

        #region TypeDefinitionDataImplementedInterfacesTest

        [Fact]
        public void TypeDefinitionDataImplementedInterfacesTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var testClassDefinitionData = context.GetTypeDefinitionData(t);
            var equatableInterfaceData = context.GetConstructedGenericTypeData<IEquatable<TestClassDefinition>>();
            var testInterfaceDefinitionData = context.GetTypeDefinitionData<TestInterfaceDefinition>();

            AssertX.Equal(2, testClassDefinitionData.ImplementedInterfaces.Count, "The TestClassDefinition should only have one externally visiiblt interface.");
            // Note: these may need to be reversed
            AssertX.Equal(testInterfaceDefinitionData, testClassDefinitionData.ImplementedInterfaces[0], "The reported interface is not correct.");
            AssertX.Equal(equatableInterfaceData, testClassDefinitionData.ImplementedInterfaces[1], "The reported interface is not correct.");

            AssertX.Equal(1, testInterfaceDefinitionData.ImplementedInterfaces.Count, "The TestClassDefinition should only have one externally visiiblt interface.");
            AssertX.Equal(equatableInterfaceData, testInterfaceDefinitionData.ImplementedInterfaces[0], "The reported interface is not correct.");
        }

        #endregion // TypeDefinitionDataImplementedInterfacesTest

        // TODO_Test: test IsConstructedGenericType, IsPointer, IsByRef

        #region TypeDefinitionDataKindTest

        [Fact]
        public void TypeDefinitionDataKindTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(typeof(TestClassDefinition));

            Assert.Equal(TypeKind.Class, context.GetTypeDefinitionData(typeof(TestClassDefinition)).TypeKind);
            Assert.Equal(TypeKind.Struct, context.GetTypeDefinitionData(typeof(TestStructDefinition)).TypeKind);
            Assert.Equal(TypeKind.Interface, context.GetTypeDefinitionData(typeof(TestInterfaceDefinition)).TypeKind);
            Assert.Equal(TypeKind.Enum, context.GetTypeDefinitionData(typeof(TestEnumDefinition)).TypeKind);
            Assert.Equal(TypeKind.Delegate, context.GetTypeDefinitionData(typeof(TestDelegateDefinition)).TypeKind);
        }

        #endregion // TypeDefinitionDataKindTest

        #region TypeDefinitionDataMembersInClassTest

        [Fact]
        public void TypeDefinitionDataMembersInClassTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            AssertX.NotNull(typeData, "Unable to create a TypeDefinitionData instance from the TestClassDefinition type.");

            TestUtilities.VerifyMember<ConstantData>(typeData, "Constant");
            TestUtilities.VerifyInstanceAndStaticMember<FieldData>(typeData, "Field");
            TestUtilities.VerifyInstanceAndStaticMember<FieldData>(typeData, "FieldReadOnly");

            var members = typeData.GetMembers(".ctor");
            AssertX.Equal(3, members.Count, "Incorrect number of constructors returned.");
            AssertX.Equal(0, ((ConstructorData)members[0]).Parameters.Count, "The public constructor should have been returned.");
            AssertX.Equal(2, ((ConstructorData)members[1]).Parameters.Count, "The protected constructor should have been returned.");
            AssertX.Equal(3, ((ConstructorData)members[2]).Parameters.Count, "The protected internal constructor should have been returned.");

            TestUtilities.VerifyInstanceAndStaticMember<EventData>(typeData, "Event");
            TestUtilities.VerifyInstanceAndStaticMember<EventData>(typeData, "EventCustom");

            members = typeData.GetMembers("Item");
            AssertX.Equal(3, members.Count, "Incorrect number of indexers returned.");
            AssertX.Equal(1, ((IndexerData)members[0]).Parameters.Count, "The public indexer should have been returned.");
            AssertX.Equal(3, ((IndexerData)members[1]).Parameters.Count, "The protected indexer should have been returned.");
            AssertX.Equal(4, ((IndexerData)members[2]).Parameters.Count, "The protected internal indexer should have been returned.");

            TestUtilities.VerifyInstanceAndStaticMember<MethodData>(typeData, "Method");

            var member = (OperatorData)typeData.GetMember("op_Addition");
            AssertX.NotNull(member, "OperatorData instances should be returned.");

            TestUtilities.VerifyInstanceAndStaticMember<PropertyData>(typeData, "Property");

            TestUtilities.VerifyMember<TypeDefinitionData>(typeData, "NestedStruct");
        }

        #endregion // TypeDefinitionDataMembersInClassTest

        #region TypeDefinitionDataMembersInEnumTest

        [Fact]
        public void TypeDefinitionDataMembersInEnumTest()
        {
            var t = typeof(TestEnumDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            AssertX.NotNull(typeData, "Unable to create a TypeDefinitionData instance from the TestClassDefinition type.");

            TestUtilities.VerifyMember<ConstantData>(typeData, "Constant");
        }

        #endregion // TypeDefinitionDataMembersInEnumTest

        #region TypeDefinitionDataMembersInInterfaceTest

        [Fact]
        public void TypeDefinitionDataMembersInInterfaceTest()
        {
            var t = typeof(TestInterfaceDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            AssertX.NotNull(typeData, "Unable to create a TypeDefinitionData instance from the TestClassDefinition type.");

            TestUtilities.VerifyInstanceAndStaticMember<EventData>(typeData, "Event");

            var members = typeData.GetMembers("Item");
            AssertX.Equal(1, members.Count, "Incorrect number of indexers returned.");
            AssertX.Equal(1, ((IndexerData)members[0]).Parameters.Count, "The public indexer should have been returned.");

            TestUtilities.VerifyInstanceAndStaticMember<MethodData>(typeData, "Method");
            TestUtilities.VerifyInstanceAndStaticMember<PropertyData>(typeData, "Property");
        }

        #endregion // TypeDefinitionDataMembersInInterfaceTest

        #region TypeDefinitionDataMembersInStructTest

        [Fact]
        public void TypeDefinitionDataMembersInStructTest()
        {
            var t = typeof(TestStructDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            AssertX.NotNull(typeData, "Unable to create a TypeDefinitionData instance from the TestClassDefinition type.");

            TestUtilities.VerifyMember<ConstantData>(typeData, "Constant");
            TestUtilities.VerifyInstanceAndStaticMember<FieldData>(typeData, "Field");
            TestUtilities.VerifyInstanceAndStaticMember<FieldData>(typeData, "FieldReadOnly");

            var members = typeData.GetMembers(".ctor");
            AssertX.Equal(2, members.Count, "Incorrect number of constructors returned.");
            AssertX.Equal(0, ((ConstructorData)members[0]).Parameters.Count, "The default constructor should have been returned.");
            AssertX.Equal(1, ((ConstructorData)members[1]).Parameters.Count, "The public constructor should have been returned.");

            TestUtilities.VerifyInstanceAndStaticMember<EventData>(typeData, "Event");
            TestUtilities.VerifyInstanceAndStaticMember<EventData>(typeData, "EventCustom");

            members = typeData.GetMembers("Item");
            AssertX.Equal(1, members.Count, "Incorrect number of indexers returned.");
            AssertX.Equal(1, ((IndexerData)members[0]).Parameters.Count, "The public indexer should have been returned.");

            TestUtilities.VerifyInstanceAndStaticMember<MethodData>(typeData, "Method");

            var member = (OperatorData)typeData.GetMember("op_Addition");
            AssertX.NotNull(member, "OperatorData instances should be returned.");

            TestUtilities.VerifyInstanceAndStaticMember<PropertyData>(typeData, "Property");

            TestUtilities.VerifyMember<TypeDefinitionData>(typeData, "NestedStruct");
        }

        #endregion // TypeDefinitionDataMembersInStructTest

        #region TypeDefinitionDataNameTest

        [Fact]
        public void TypeDefinitionDataNameTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            AssertX.Equal(t.Name, typeData.Name, "The Name is not assigned correctly.");
        }

        #endregion // TypeDefinitionDataNameTest
    }
}

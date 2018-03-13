/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.

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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakingChangesDetector.MetadataItems;
using System.Collections.Generic;

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
	[TestClass]
	public class TypeDefinitionDataTests
	{
		#region ProtectedMembersInSealedClassesNotStoredTest

		[TestMethod]
		public void ProtectedMembersInSealedClassesNotStoredTest()
		{
			var t = typeof(SealedClass);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var members = typeData.GetMembers("MethodVirtual");
			Assert.IsTrue(members == null || members.Count == 0, "Protected members of sealed classes should never be considered for breaking changes.");
		}

		#endregion // ProtectedMembersInSealedClassesNotStoredTest

		#region TypeDefinitionDataAccessibilityTest

		[TestMethod]
		public void TypeDefinitionDataAccessibilityTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			TestUtilities.VerifyAccessibility(typeData, "NestedStruct");
		}

		#endregion // TypeDefinitionDataAccessibilityTest

		#region TypeDefinitionDataAssemblyTest

		[TestMethod]
		public void TypeDefinitionDataAssemblyTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			Assert.AreEqual(assembly, typeData.AssemblyData, "The Assembly reference is not assigned correctly.");
		}

		#endregion // TypeDefinitionDataAssemblyTest

		#region TypeDefinitionDataBaseTypeTest

		[TestMethod]
		public void TypeDefinitionDataBaseTypeTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var testClassDefinitionData = TypeDefinitionData.FromType(t);
			var testClassDefinitionBaseData = TypeDefinitionData.FromType(typeof(TestClassDefinitionBase));
			var marshalByRefObjectData = TypeDefinitionData.FromType<MarshalByRefObject>();
			var objectData = TypeDefinitionData.FromType<Object>();

			DeclaringTypeData current = testClassDefinitionData;
			Assert.AreEqual(testClassDefinitionBaseData, current.BaseType, "The base type of " + current.Name + "is incorrect.");
			current = current.BaseType;
			Assert.AreEqual(marshalByRefObjectData, current.BaseType, "The base type of " + current.Name + "is incorrect.");
			current = current.BaseType;
			Assert.AreEqual(objectData, current.BaseType, "The base type of " + current.Name + "is incorrect.");
			current = current.BaseType;
			Assert.IsNull(current.BaseType, "The base type of " + current.Name + "is incorrect.");

			var testEnumDefinitionData = TypeDefinitionData.FromType(typeof(TestEnumDefinition));
			var intData = TypeDefinitionData.FromType<int>();
			var valueTypeData = TypeDefinitionData.FromType<ValueType>();
			current = testEnumDefinitionData;
			Assert.AreEqual(intData, current.BaseType, "The base type of " + current.Name + "is incorrect.");
			current = current.BaseType;
			Assert.AreEqual(valueTypeData, current.BaseType, "The base type of " + current.Name + "is incorrect.");
			current = current.BaseType;
			Assert.AreEqual(objectData, current.BaseType, "The base type of " + current.Name + "is incorrect.");
			current = current.BaseType;
			Assert.IsNull(current.BaseType, "The base type of " + current.Name + "is incorrect.");

			var testInterfaceDefinitionData = TypeDefinitionData.FromType(typeof(TestInterfaceDefinition));
			current = testInterfaceDefinitionData;
			Assert.AreEqual(null, current.BaseType, "The base type of " + current.Name + "is incorrect.");
		}

		#endregion // TypeDefinitionDataBaseTypeTest

		#region TypeDefinitionDataDeclaringTypeTest

		[TestMethod]
		public void TypeDefinitionDataDeclaringTypeTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			Assert.IsNull(typeData.DeclaringType, "The DeclaringType of a root level type should be null.");
			var nestedType = typeData.GetMember("NestedStruct");
			Assert.AreEqual(typeData, nestedType.DeclaringType, "The DeclaringType of a nested type should be the root level type.");
		}

		#endregion // TypeDefinitionDataDeclaringTypeTest

		#region TypeDefinitionDataDelegateParametersTest

		[TestMethod]
		public void TypeDefinitionDataDelegateParametersTest()
		{
			var t = typeof(TestDelegateDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);

			var typeData = TypeDefinitionData.FromType(t);
			Assert.AreEqual(0, typeData.DelegateParameters.Count, "The number of delegate parameters is incorrect.");

			typeData = TypeDefinitionData.FromType(typeof(TestDelegateDefinitionWithParams));
			Assert.AreEqual(2, typeData.DelegateParameters.Count, "The number of delegate parameters is incorrect.");
		}

		#endregion // TypeDefinitionDataDelegateParametersTest

		#region TypeDefinitionDataFlagsTest

		[TestMethod]
		public void TypeDefinitionDataFlagsTest()
		{
			var t = typeof(UnsealedClass);
			var assembly = AssemblyData.FromAssembly(t.Assembly);

			var typeData = TypeDefinitionData.FromType(t);
			Assert.AreEqual(MemberFlags.None, typeData.MemberFlags, "The Flags of class incorrect.");

			typeData = TypeDefinitionData.FromType(typeof(SealedClass));
			Assert.AreEqual(MemberFlags.Sealed, typeData.MemberFlags, "The Flags of class incorrect.");

			typeData = TypeDefinitionData.FromType(typeof(AbstractClass));
			Assert.AreEqual(MemberFlags.Abstract, typeData.MemberFlags, "The Flags of class incorrect.");

			typeData = TypeDefinitionData.FromType(typeof(StaticClass));
			Assert.AreEqual(MemberFlags.Static, typeData.MemberFlags, "The Flags of class incorrect.");
		}

		#endregion // TypeDefinitionDataFlagsTest

		#region TypeDefinitionDataFullNameTest

		[TestMethod]
		public void TypeDefinitionDataFullNameTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			Assert.AreEqual(t.FullName, typeData.FullName, "The FullName is not assigned correctly.");
		}

		#endregion // TypeDefinitionDataFullNameTest

		#region TypeDefinitionDataGenericParametersTest

		[TestMethod]
		public void TypeDefinitionDataGenericParametersTest()
		{
			var t = typeof(TestClassDefinition<,,,,>);
			var assembly = AssemblyData.FromAssembly(t.Assembly);

			var testClassDefinitionData = TypeDefinitionData.FromType(t);
			Assert.AreEqual(5, testClassDefinitionData.GenericParameters.Count, "The number of generic parameters is incorrect.");

			var baseType = (ConstructedGenericTypeData)TypeDefinitionData.FromType(typeof(TestClassDefinitionPartiallyDerived<,,>)).BaseType;
			Assert.AreEqual(5, baseType.GenericArguments.Count, "The number of generic arguments is incorrect.");
		}

		#endregion // TypeDefinitionDataGenericParametersTest

		#region TypeDefinitionDataImplementedInterfacesTest

		[TestMethod]
		public void TypeDefinitionDataImplementedInterfacesTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var testClassDefinitionData = TypeDefinitionData.FromType(t);
			var equatableInterfaceData = ConstructedGenericTypeData.FromType<IEquatable<TestClassDefinition>>();
			var testInterfaceDefinitionData = TypeDefinitionData.FromType<TestInterfaceDefinition>();

			Assert.AreEqual(2, testClassDefinitionData.ImplementedInterfaces.Count, "The TestClassDefinition should only have one externally visiiblt interface.");
			// Note: these may need to be reversed
			Assert.AreEqual(testInterfaceDefinitionData, testClassDefinitionData.ImplementedInterfaces[0], "The reported interface is not correct.");
			Assert.AreEqual(equatableInterfaceData, testClassDefinitionData.ImplementedInterfaces[1], "The reported interface is not correct.");

			Assert.AreEqual(1, testInterfaceDefinitionData.ImplementedInterfaces.Count, "The TestClassDefinition should only have one externally visiiblt interface.");
			Assert.AreEqual(equatableInterfaceData, testInterfaceDefinitionData.ImplementedInterfaces[0], "The reported interface is not correct.");
		}

		#endregion // TypeDefinitionDataImplementedInterfacesTest

		// TODO_Test: test IsConstructedGenericType, IsPointer, IsByRef

		#region TypeDefinitionDataIsExtensionsClassTest

		[TestMethod]
		public void TypeDefinitionDataIsExtensionsClassTest()
		{
			var assembly = AssemblyData.FromAssembly(typeof(TypeDefinitionDataTests).Assembly);
			Assert.IsFalse(TypeDefinitionData.FromType(typeof(StaticClass)).IsExtensionsClass, "The IsExtensionsClass value is incorrect.");
			Assert.IsTrue(TypeDefinitionData.FromType(typeof(ExtensionsClass)).IsExtensionsClass, "The IsExtensionsClass value is incorrect.");
		}

		#endregion // TypeDefinitionDataIsExtensionsClassTest

		#region TypeDefinitionDataKindTest

		[TestMethod]
		public void TypeDefinitionDataKindTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(typeof(TestClassDefinition).Assembly);

			Assert.AreEqual(TypeKind.Class, TypeDefinitionData.FromType(typeof(TestClassDefinition)).TypeKind);
			Assert.AreEqual(TypeKind.Struct, TypeDefinitionData.FromType(typeof(TestStructDefinition)).TypeKind);
			Assert.AreEqual(TypeKind.Interface, TypeDefinitionData.FromType(typeof(TestInterfaceDefinition)).TypeKind);
			Assert.AreEqual(TypeKind.Enum, TypeDefinitionData.FromType(typeof(TestEnumDefinition)).TypeKind);
			Assert.AreEqual(TypeKind.Delegate, TypeDefinitionData.FromType(typeof(TestDelegateDefinition)).TypeKind);
		}

		#endregion // TypeDefinitionDataKindTest

		#region TypeDefinitionDataMembersInClassTest

		[TestMethod]
		public void TypeDefinitionDataMembersInClassTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			Assert.IsNotNull(typeData, "Unable to create a TypeDefinitionData instance from the TestClassDefinition type.");

			TestUtilities.VerifyMember<ConstantData>(typeData, "Constant");
			TestUtilities.VerifyInstanceAndStaticMember<FieldData>(typeData, "Field");
			TestUtilities.VerifyInstanceAndStaticMember<FieldData>(typeData, "FieldReadOnly");

			var members = typeData.GetMembers(".ctor");
			Assert.AreEqual(3, members.Count, "Incorrect number of constructors returned.");
			Assert.AreEqual(0, ((ConstructorData)members[0]).Parameters.Count, "The public constructor should have been returned.");
			Assert.AreEqual(2, ((ConstructorData)members[1]).Parameters.Count, "The protected constructor should have been returned.");
			Assert.AreEqual(3, ((ConstructorData)members[2]).Parameters.Count, "The protected internal constructor should have been returned.");

			TestUtilities.VerifyInstanceAndStaticMember<EventData>(typeData, "Event");
			TestUtilities.VerifyInstanceAndStaticMember<EventData>(typeData, "EventCustom");

			members = typeData.GetMembers("Item");
			Assert.AreEqual(3, members.Count, "Incorrect number of indexers returned.");
			Assert.AreEqual(1, ((IndexerData)members[0]).Parameters.Count, "The public indexer should have been returned.");
			Assert.AreEqual(3, ((IndexerData)members[1]).Parameters.Count, "The protected indexer should have been returned.");
			Assert.AreEqual(4, ((IndexerData)members[2]).Parameters.Count, "The protected internal indexer should have been returned.");

			TestUtilities.VerifyInstanceAndStaticMember<MethodData>(typeData, "Method");

			var member = (OperatorData)typeData.GetMember("op_Addition");
			Assert.IsNotNull(member, "OperatorData instances should be returned.");

			TestUtilities.VerifyInstanceAndStaticMember<PropertyData>(typeData, "Property");

			TestUtilities.VerifyMember<TypeDefinitionData>(typeData, "NestedStruct");
		}

		#endregion // TypeDefinitionDataMembersInClassTest

		#region TypeDefinitionDataMembersInEnumTest

		[TestMethod]
		public void TypeDefinitionDataMembersInEnumTest()
		{
			var t = typeof(TestEnumDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			Assert.IsNotNull(typeData, "Unable to create a TypeDefinitionData instance from the TestClassDefinition type.");

			TestUtilities.VerifyMember<ConstantData>(typeData, "Constant");
		}

		#endregion // TypeDefinitionDataMembersInEnumTest

		#region TypeDefinitionDataMembersInInterfaceTest

		[TestMethod]
		public void TypeDefinitionDataMembersInInterfaceTest()
		{
			var t = typeof(TestInterfaceDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			Assert.IsNotNull(typeData, "Unable to create a TypeDefinitionData instance from the TestClassDefinition type.");

			TestUtilities.VerifyInstanceAndStaticMember<EventData>(typeData, "Event");

			var members = typeData.GetMembers("Item");
			Assert.AreEqual(1, members.Count, "Incorrect number of indexers returned.");
			Assert.AreEqual(1, ((IndexerData)members[0]).Parameters.Count, "The public indexer should have been returned.");

			TestUtilities.VerifyInstanceAndStaticMember<MethodData>(typeData, "Method");
			TestUtilities.VerifyInstanceAndStaticMember<PropertyData>(typeData, "Property");
		}

		#endregion // TypeDefinitionDataMembersInInterfaceTest

		#region TypeDefinitionDataMembersInStructTest

		[TestMethod]
		public void TypeDefinitionDataMembersInStructTest()
		{
			var t = typeof(TestStructDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			Assert.IsNotNull(typeData, "Unable to create a TypeDefinitionData instance from the TestClassDefinition type.");

			TestUtilities.VerifyMember<ConstantData>(typeData, "Constant");
			TestUtilities.VerifyInstanceAndStaticMember<FieldData>(typeData, "Field");
			TestUtilities.VerifyInstanceAndStaticMember<FieldData>(typeData, "FieldReadOnly");

			var members = typeData.GetMembers(".ctor");
			Assert.AreEqual(1, members.Count, "Incorrect number of constructors returned.");
			Assert.AreEqual(1, ((ConstructorData)members[0]).Parameters.Count, "The public constructor should have been returned.");

			TestUtilities.VerifyInstanceAndStaticMember<EventData>(typeData, "Event");
			TestUtilities.VerifyInstanceAndStaticMember<EventData>(typeData, "EventCustom");

			members = typeData.GetMembers("Item");
			Assert.AreEqual(1, members.Count, "Incorrect number of indexers returned.");
			Assert.AreEqual(1, ((IndexerData)members[0]).Parameters.Count, "The public indexer should have been returned.");

			TestUtilities.VerifyInstanceAndStaticMember<MethodData>(typeData, "Method");

			var member = (OperatorData)typeData.GetMember("op_Addition");
			Assert.IsNotNull(member, "OperatorData instances should be returned.");

			TestUtilities.VerifyInstanceAndStaticMember<PropertyData>(typeData, "Property");

			TestUtilities.VerifyMember<TypeDefinitionData>(typeData, "NestedStruct");
		}

		#endregion // TypeDefinitionDataMembersInStructTest

		#region TypeDefinitionDataNameTest

		[TestMethod]
		public void TypeDefinitionDataNameTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			Assert.AreEqual(t.Name, typeData.Name, "The Name is not assigned correctly.");
		}

		#endregion // TypeDefinitionDataNameTest
	}
}

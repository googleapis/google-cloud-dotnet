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
using System.Reflection;

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
	[TestClass]
	public class GenericTypeParameterDataTests
	{
		#region GenericTypeParameterDataContraintsTest

		[TestMethod]
		public void GenericTypeParameterDataContraintsTest()
		{
			var t = typeof(TestClassDefinition<,,,,>);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var testClassDefinitionData = TypeDefinitionData.FromType(t);
			var equatableInterfaceData = ConstructedGenericTypeData.FromType<IEquatable<TestClassDefinition>>();
			var testInterfaceDefinitionData = TypeDefinitionData.FromType<TestInterfaceDefinition>();
			var valueTypeData = TypeDefinitionData.FromType<ValueType>();

			var p1 = testClassDefinitionData.GenericParameters[0];
			Assert.AreEqual(0, p1.Constraints.Count, "The number of Constraints on the genertic type parameter is incorrect.");

			var p2 = testClassDefinitionData.GenericParameters[1];
			Assert.AreEqual(2, p2.Constraints.Count, "The number of Constraints on the genertic type parameter is incorrect.");
			// Note: these may need to be reversed
			Assert.AreEqual(equatableInterfaceData, p2.Constraints[0], "The reported type is not correct.");
			Assert.AreEqual(testInterfaceDefinitionData, p2.Constraints[1], "The reported type is not correct.");

			var p3 = testClassDefinitionData.GenericParameters[2];
			Assert.AreEqual(0, p3.Constraints.Count, "The number of Constraints on the genertic type parameter is incorrect.");

			var p4 = testClassDefinitionData.GenericParameters[3];
			Assert.AreEqual(1, p4.Constraints.Count, "The number of Constraints on the genertic type parameter is incorrect.");
			Assert.AreEqual(valueTypeData, p4.Constraints[0], "The reported type is not correct.");

			var p5 = testClassDefinitionData.GenericParameters[4];
			Assert.AreEqual(0, p5.Constraints.Count, "The number of Constraints on the genertic type parameter is incorrect.");
		}

		#endregion // GenericTypeParameterDataContraintsTest

		#region GenericTypeParameterDataGenericParameterAttributesTest

		[TestMethod]
		public void GenericTypeParameterDataGenericParameterAttributesTest()
		{
			var t = typeof(TestClassDefinition<,,,,>);
			var assembly = AssemblyData.FromAssembly(t.Assembly);

			var typeData = TypeDefinitionData.FromType(t);

			var p1 = typeData.GenericParameters[0];
			Assert.AreEqual(GenericParameterAttributes.None, p1.GenericParameterAttributes, "The number of generic parameters is incorrect.");

			var p2 = typeData.GenericParameters[1];
			Assert.AreEqual(GenericParameterAttributes.None, p2.GenericParameterAttributes, "The number of generic parameters is incorrect.");

			var p3 = typeData.GenericParameters[2];
			Assert.AreEqual(GenericParameterAttributes.ReferenceTypeConstraint, p3.GenericParameterAttributes, "The number of generic parameters is incorrect.");

			var p4 = typeData.GenericParameters[3];
			Assert.AreEqual(GenericParameterAttributes.NotNullableValueTypeConstraint | GenericParameterAttributes.DefaultConstructorConstraint, p4.GenericParameterAttributes, "The number of generic parameters is incorrect.");

			var p5 = typeData.GenericParameters[4];
			Assert.AreEqual(GenericParameterAttributes.DefaultConstructorConstraint, p5.GenericParameterAttributes, "The number of generic parameters is incorrect.");

			typeData = TypeDefinitionData.FromType(typeof(TestInterfaceDefinition<,,>));

			p1 = typeData.GenericParameters[0];
			Assert.AreEqual(GenericParameterAttributes.None, p1.GenericParameterAttributes, "The number of generic parameters is incorrect.");

			p2 = typeData.GenericParameters[1];
			Assert.AreEqual(GenericParameterAttributes.Contravariant, p2.GenericParameterAttributes, "The number of generic parameters is incorrect.");

			p3 = typeData.GenericParameters[2];
			Assert.AreEqual(GenericParameterAttributes.Covariant, p3.GenericParameterAttributes, "The number of generic parameters is incorrect.");
		}

		#endregion // GenericTypeParameterDataGenericParameterAttributesTest

		#region GenericTypeParameterDataKindTest

		[TestMethod]
		public void GenericTypeParameterDataKindTest()
		{
			var t = typeof(TestClassDefinition<,,,,>);
			var assembly = AssemblyData.FromAssembly(typeof(TestClassDefinition<,,,,>).Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			Assert.AreEqual(TypeKind.Class, typeData.GenericParameters[0].TypeKind);
			Assert.AreEqual(TypeKind.Class, typeData.GenericParameters[1].TypeKind);
			Assert.AreEqual(TypeKind.Class, typeData.GenericParameters[2].TypeKind);
			Assert.AreEqual(TypeKind.Struct, typeData.GenericParameters[3].TypeKind);
			Assert.AreEqual(TypeKind.Class, typeData.GenericParameters[4].TypeKind);
		}

		#endregion // GenericTypeParameterDataKindTest

		#region GenericTypeParameterDataNameTest

		[TestMethod]
		public void GenericTypeParameterDataNameTest()
		{
			var t = typeof(TestClassDefinition<,,,,>);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var p1 = typeData.GenericParameters[0];
			Assert.AreEqual(t.GetGenericArguments()[0].Name, p1.Name, "The Name is not assigned correctly.");
		}

		#endregion // GenericTypeParameterDataNameTest
	}
}

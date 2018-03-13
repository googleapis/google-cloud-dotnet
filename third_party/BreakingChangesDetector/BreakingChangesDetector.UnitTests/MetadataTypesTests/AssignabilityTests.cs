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
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakingChangesDetector.MetadataItems;
using System.Collections;
using System.Collections.Generic;

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
	[TestClass]
	public class AssignabilityTests
	{
		#region ImplicitBoxingConversionsTests

		[TestMethod]
		public void ImplicitBoxingConversionsTests()
		{
			TestAssignability(
				typeof(int),
				typeof(EnumValues),
				typeof(Struct),
				typeof(int?),
				typeof(EnumValues?),
				typeof(Struct?),
				typeof(Struct2),
				typeof(Struct2?),
				typeof(object),
				typeof(ValueType),
				typeof(Enum),
				typeof(IComparable),
				typeof(IFormattable),
				typeof(IConvertible),
				typeof(IComparable<int>),
				typeof(IEquatable<int>),
				typeof(DerivedInterface),
				typeof(BaseInterface),
				typeof(IEnumerable<DerivedClass>),
				typeof(IEnumerable<BaseClass>));
		}

		#endregion // ImplicitBoxingConversionsTests

		#region ImplicitConversionsInvolvingTypeParametersTests

		[TestMethod]
		public void ImplicitConversionsInvolvingTypeParametersTests()
		{
			TestAssignability(
				typeof(TypeParameterWithBaseClass<>).GetGenericArguments()[0],
				typeof(TypeParameterWithInterface<>).GetGenericArguments()[0],
				typeof(TypeParameterWithBaseGeneric<,>).GetGenericArguments()[0],
				typeof(TypeParameterWithBaseGeneric<,>).GetGenericArguments()[1],
				typeof(TypeParameterWithVariantInterfaces<,>).GetGenericArguments()[0],
				typeof(TypeParameterWithVariantInterfaces<,>).GetGenericArguments()[1],
				typeof(DerivedClass),
				typeof(BaseClass),
				typeof(object),
				typeof(DerivedInterface),
				typeof(BaseInterface),
				typeof(ContravariantInterface<BaseClass>),
				typeof(ContravariantInterface<DerivedClass>),
				typeof(CovariantInterface<BaseClass>),
				typeof(CovariantInterface<DerivedClass>));
		}

		#endregion // ImplicitConversionsInvolvingTypeParametersTests

		#region ImplicitIdentityConversionsTests

		[TestMethod]
		public void ImplicitIdentityConversionsTests()
		{
			TestAssignability<List<object>, List<dynamic>>();
		}

		#endregion // ImplicitIdentityConversionsTests

		#region ImplicitNullableConversionsTests

		[TestMethod]
		public void ImplicitNullableConversionsTests()
		{
			var result = TypeData.FromType<BStruct?>().IsAssignableFromNew(TypeData.FromType<CStruct?>());

			TestAssignability((a, b) => a.IsNullable() || b.IsNullable(),
				typeof(byte),
				typeof(sbyte),
				typeof(ushort),
				typeof(short),
				typeof(uint),
				typeof(int),
				typeof(ulong),
				typeof(long),
				typeof(float),
				typeof(double),
				typeof(decimal),
				typeof(char),
				typeof(CStruct),
				typeof(BStruct),
				typeof(AStruct),
				typeof(byte?),
				typeof(sbyte?),
				typeof(ushort?),
				typeof(short?),
				typeof(uint?),
				typeof(int?),
				typeof(ulong?),
				typeof(long?),
				typeof(float?),
				typeof(double?),
				typeof(decimal?),
				typeof(char?),
				typeof(CStruct?),
				typeof(BStruct?),
				typeof(AStruct?));
		}

		#endregion // ImplicitNullableConversionsTests

		#region ImplicitNumericConversionsTests

		[TestMethod]
		public void ImplicitNumericConversionsTests()
		{
			TestAssignability(
				typeof(byte),
				typeof(sbyte),
				typeof(ushort),
				typeof(short),
				typeof(uint),
				typeof(int),
				typeof(ulong),
				typeof(long),
				typeof(float),
				typeof(double),
				typeof(decimal),
				typeof(char));
		}

		#endregion // ImplicitNumericConversionsTests

		#region ImplicitReferenceConversionsTests

		[TestMethod]
		public void ImplicitReferenceConversionsTests()
		{
			var dynamicType = TypeDefinitionData.FromType<DynamicMethod>();

			TestAssignability(
				typeof(object),
				typeof(AssignabilityTests),
				typeof(BaseClass),
				typeof(DerivedClass),
				typeof(BaseInterface),
				typeof(DerivedInterface),
				typeof(object[]),
				typeof(AssignabilityTests[]),
				typeof(BaseClass[]),
				typeof(DerivedClass[]),
				typeof(BaseInterface[]),
				typeof(DerivedInterface[]),
				typeof(object[,]),
				typeof(AssignabilityTests[,]),
				typeof(BaseClass[,]),
				typeof(DerivedClass[,]),
				typeof(BaseInterface[,]),
				typeof(DerivedInterface[,]),
				typeof(Array),
				typeof(ICloneable),
				typeof(IList),
				typeof(ICollection),
				typeof(IEnumerable),
				typeof(IStructuralComparable),
				typeof(IStructuralEquatable),
				typeof(IList<AssignabilityTests>),
				typeof(IList<object>),
				typeof(Delegate),
				typeof(IEnumerable<BaseClass>),
				typeof(IEnumerable<DerivedClass>),
				typeof(Func<BaseClass>),
				typeof(Func<DerivedClass>),
				typeof(Action<BaseClass>),
				typeof(Func<BaseClass, BaseClass>),
				typeof(Func<DerivedClass, DerivedClass>),
				typeof(Func<BaseClass, DerivedClass>),
				typeof(Func<DerivedClass, BaseClass>));
		}

		#endregion // ImplicitReferenceConversionsTests

		#region NullableTests

		[TestMethod]
		public void NullableTests()
		{
			TestAssignability<object, Nullable<int>>();
			TestAssignability<int, Nullable<int>>();
		}

		#endregion // NullableTests

		#region OnlyReferenceAndIdentityConversionsInVariancesTest

		[TestMethod]
		public void OnlyReferenceAndIdentityConversionsInVariancesTest()
		{
			Assert.IsFalse(ConstructedGenericTypeData.FromType<IEnumerable<object>>().IsAssignableFromNew(ConstructedGenericTypeData.FromType<IEnumerable<int>>()));
			Assert.IsFalse(ConstructedGenericTypeData.FromType<IEnumerable<int>>().IsAssignableFromNew(ConstructedGenericTypeData.FromType<IEnumerable<byte>>()));
			Assert.IsFalse(ConstructedGenericTypeData.FromType<IEnumerable<int?>>().IsAssignableFromNew(ConstructedGenericTypeData.FromType<IEnumerable<int>>()));
		}

		#endregion // OnlyReferenceAndIdentityConversionsInVariancesTest

		#region UserDefinedImplicitConversionsTests

		[TestMethod]
		public void UserDefinedImplicitConversionsTests()
		{
			TestAssignability(
				typeof(A),
				typeof(B),
				typeof(C));
		}

		#endregion // UserDefinedImplicitConversionsTests

		#region ValueTypeTests

		[TestMethod]
		public void ValueTypeTests()
		{
			TestAssignability<object, ValueType>();
			TestAssignability<ValueType, int>();
			TestAssignability<object, int>();
		}

		#endregion // ValueTypeTests


		[TestMethod]
		public void IsImplicitlyAssignableFromTests()
		{
			#region Implicit Identity Conversions

			Assert.IsTrue(typeof(List<object>).IsImplicitlyAssignableFrom(typeof(List<dynamic>)));
			Assert.IsTrue(typeof(List<dynamic>).IsImplicitlyAssignableFrom(typeof(List<object>)));

			#endregion // Implicit Identity Conversions

			#region Implicit Numeric Conversions


			Assert.IsTrue(typeof(short).IsImplicitlyAssignableFrom(typeof(sbyte)));
			Assert.IsTrue(typeof(int).IsImplicitlyAssignableFrom(typeof(sbyte)));
			Assert.IsTrue(typeof(long).IsImplicitlyAssignableFrom(typeof(sbyte)));
			Assert.IsTrue(typeof(float).IsImplicitlyAssignableFrom(typeof(sbyte)));
			Assert.IsTrue(typeof(double).IsImplicitlyAssignableFrom(typeof(sbyte)));
			Assert.IsTrue(typeof(decimal).IsImplicitlyAssignableFrom(typeof(sbyte)));
			Assert.IsTrue(typeof(short).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(ushort).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(int).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(uint).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(long).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(ulong).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(float).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(double).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(decimal).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(int).IsImplicitlyAssignableFrom(typeof(short)));
			Assert.IsTrue(typeof(long).IsImplicitlyAssignableFrom(typeof(short)));
			Assert.IsTrue(typeof(float).IsImplicitlyAssignableFrom(typeof(short)));
			Assert.IsTrue(typeof(double).IsImplicitlyAssignableFrom(typeof(short)));
			Assert.IsTrue(typeof(decimal).IsImplicitlyAssignableFrom(typeof(short)));
			Assert.IsTrue(typeof(int).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(uint).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(long).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(ulong).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(float).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(double).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(decimal).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(long).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(float).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(double).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(decimal).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(long).IsImplicitlyAssignableFrom(typeof(uint)));
			Assert.IsTrue(typeof(ulong).IsImplicitlyAssignableFrom(typeof(uint)));
			Assert.IsTrue(typeof(float).IsImplicitlyAssignableFrom(typeof(uint)));
			Assert.IsTrue(typeof(double).IsImplicitlyAssignableFrom(typeof(uint)));
			Assert.IsTrue(typeof(decimal).IsImplicitlyAssignableFrom(typeof(uint)));
			Assert.IsTrue(typeof(float).IsImplicitlyAssignableFrom(typeof(long)));
			Assert.IsTrue(typeof(double).IsImplicitlyAssignableFrom(typeof(long)));
			Assert.IsTrue(typeof(decimal).IsImplicitlyAssignableFrom(typeof(long)));
			Assert.IsTrue(typeof(float).IsImplicitlyAssignableFrom(typeof(ulong)));
			Assert.IsTrue(typeof(double).IsImplicitlyAssignableFrom(typeof(ulong)));
			Assert.IsTrue(typeof(decimal).IsImplicitlyAssignableFrom(typeof(ulong)));
			Assert.IsTrue(typeof(ushort).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(int).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(uint).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(long).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(ulong).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(float).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(double).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(decimal).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(double).IsImplicitlyAssignableFrom(typeof(float)));

			#endregion // Implicit Numeric Conversions

			#region Implicit Nullable Conversions

			Assert.IsTrue(typeof(short?).IsImplicitlyAssignableFrom(typeof(sbyte?)));
			Assert.IsTrue(typeof(int?).IsImplicitlyAssignableFrom(typeof(sbyte?)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(sbyte?)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(sbyte?)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(sbyte?)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(sbyte?)));
			Assert.IsTrue(typeof(short?).IsImplicitlyAssignableFrom(typeof(byte?)));
			Assert.IsTrue(typeof(ushort?).IsImplicitlyAssignableFrom(typeof(byte?)));
			Assert.IsTrue(typeof(int?).IsImplicitlyAssignableFrom(typeof(byte?)));
			Assert.IsTrue(typeof(uint?).IsImplicitlyAssignableFrom(typeof(byte?)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(byte?)));
			Assert.IsTrue(typeof(ulong?).IsImplicitlyAssignableFrom(typeof(byte?)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(byte?)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(byte?)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(byte?)));
			Assert.IsTrue(typeof(int?).IsImplicitlyAssignableFrom(typeof(short?)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(short?)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(short?)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(short?)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(short?)));
			Assert.IsTrue(typeof(int?).IsImplicitlyAssignableFrom(typeof(ushort?)));
			Assert.IsTrue(typeof(uint?).IsImplicitlyAssignableFrom(typeof(ushort?)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(ushort?)));
			Assert.IsTrue(typeof(ulong?).IsImplicitlyAssignableFrom(typeof(ushort?)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(ushort?)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(ushort?)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(ushort?)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(int?)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(int?)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(int?)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(int?)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(uint?)));
			Assert.IsTrue(typeof(ulong?).IsImplicitlyAssignableFrom(typeof(uint?)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(uint?)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(uint?)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(uint?)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(long?)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(long?)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(long?)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(ulong?)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(ulong?)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(ulong?)));
			Assert.IsTrue(typeof(ushort?).IsImplicitlyAssignableFrom(typeof(char?)));
			Assert.IsTrue(typeof(int?).IsImplicitlyAssignableFrom(typeof(char?)));
			Assert.IsTrue(typeof(uint?).IsImplicitlyAssignableFrom(typeof(char?)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(char?)));
			Assert.IsTrue(typeof(ulong?).IsImplicitlyAssignableFrom(typeof(char?)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(char?)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(char?)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(char?)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(float?)));
			Assert.IsTrue(typeof(BStruct?).IsImplicitlyAssignableFrom(typeof(CStruct?)));
			Assert.IsTrue(typeof(AStruct?).IsImplicitlyAssignableFrom(typeof(BStruct?)));
			Assert.IsTrue(typeof(short?).IsImplicitlyAssignableFrom(typeof(sbyte)));
			Assert.IsTrue(typeof(int?).IsImplicitlyAssignableFrom(typeof(sbyte)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(sbyte)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(sbyte)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(sbyte)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(sbyte)));
			Assert.IsTrue(typeof(short?).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(ushort?).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(int?).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(uint?).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(ulong?).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(byte)));
			Assert.IsTrue(typeof(int?).IsImplicitlyAssignableFrom(typeof(short)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(short)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(short)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(short)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(short)));
			Assert.IsTrue(typeof(int?).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(uint?).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(ulong?).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(ushort)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(uint)));
			Assert.IsTrue(typeof(ulong?).IsImplicitlyAssignableFrom(typeof(uint)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(uint)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(uint)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(uint)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(long)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(long)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(long)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(ulong)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(ulong)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(ulong)));
			Assert.IsTrue(typeof(ushort?).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(int?).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(uint?).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(long?).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(ulong?).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(float?).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(decimal?).IsImplicitlyAssignableFrom(typeof(char)));
			Assert.IsTrue(typeof(double?).IsImplicitlyAssignableFrom(typeof(float)));
			Assert.IsTrue(typeof(BStruct?).IsImplicitlyAssignableFrom(typeof(CStruct)));
			Assert.IsTrue(typeof(AStruct?).IsImplicitlyAssignableFrom(typeof(BStruct)));

			#endregion // Implicit Nullable Conversions

			#region Implicit Reference Conversions

			Assert.IsTrue(typeof(object).IsImplicitlyAssignableFrom(typeof(AssignabilityTests)));
			Assert.IsTrue(typeof(BaseClass).IsImplicitlyAssignableFrom(typeof(DerivedClass)));
			Assert.IsTrue(typeof(BaseInterface).IsImplicitlyAssignableFrom(typeof(DerivedClass)));
			Assert.IsTrue(typeof(DerivedInterface).IsImplicitlyAssignableFrom(typeof(DerivedClass)));
			Assert.IsTrue(typeof(BaseInterface).IsImplicitlyAssignableFrom(typeof(DerivedInterface)));
			Assert.IsTrue(typeof(object[]).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[])));
			Assert.IsTrue(typeof(BaseClass[]).IsImplicitlyAssignableFrom(typeof(DerivedClass[])));
			Assert.IsTrue(typeof(BaseInterface[]).IsImplicitlyAssignableFrom(typeof(DerivedClass[])));
			Assert.IsTrue(typeof(DerivedInterface[]).IsImplicitlyAssignableFrom(typeof(DerivedClass[])));
			Assert.IsTrue(typeof(BaseInterface[]).IsImplicitlyAssignableFrom(typeof(DerivedInterface[])));
			Assert.IsTrue(typeof(object[,]).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[,])));
			Assert.IsTrue(typeof(BaseClass[,]).IsImplicitlyAssignableFrom(typeof(DerivedClass[,])));
			Assert.IsTrue(typeof(BaseInterface[,]).IsImplicitlyAssignableFrom(typeof(DerivedClass[,])));
			Assert.IsTrue(typeof(DerivedInterface[,]).IsImplicitlyAssignableFrom(typeof(DerivedClass[,])));
			Assert.IsTrue(typeof(BaseInterface[,]).IsImplicitlyAssignableFrom(typeof(DerivedInterface[,])));
			Assert.IsFalse(typeof(object[]).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[,])));
			Assert.IsFalse(typeof(object[,]).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[])));
			Assert.IsTrue(typeof(Array).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[])));
			Assert.IsTrue(typeof(Array).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[,])));
			Assert.IsTrue(typeof(ICloneable).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[])));
			Assert.IsTrue(typeof(ICloneable).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[,])));
			Assert.IsTrue(typeof(IList).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[])));
			Assert.IsTrue(typeof(IList).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[,])));
			Assert.IsTrue(typeof(ICollection).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[])));
			Assert.IsTrue(typeof(ICollection).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[,])));
			Assert.IsTrue(typeof(IEnumerable).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[])));
			Assert.IsTrue(typeof(IEnumerable).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[,])));
			Assert.IsTrue(typeof(IStructuralComparable).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[])));
			Assert.IsTrue(typeof(IStructuralComparable).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[,])));
			Assert.IsTrue(typeof(IStructuralEquatable).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[])));
			Assert.IsTrue(typeof(IStructuralEquatable).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[,])));
			Assert.IsTrue(typeof(IList<AssignabilityTests>).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[])));
			Assert.IsTrue(typeof(IList<object>).IsImplicitlyAssignableFrom(typeof(AssignabilityTests[])));
			Assert.IsTrue(typeof(Delegate).IsImplicitlyAssignableFrom(typeof(Action)));
			Assert.IsTrue(typeof(Delegate).IsImplicitlyAssignableFrom(typeof(Func<int>)));
			Assert.IsTrue(typeof(IEnumerable<BaseClass>).IsImplicitlyAssignableFrom(typeof(IEnumerable<DerivedClass>)));
			Assert.IsTrue(typeof(Func<BaseClass>).IsImplicitlyAssignableFrom(typeof(Func<DerivedClass>)));
			Assert.IsFalse(typeof(Func<DerivedClass>).IsImplicitlyAssignableFrom(typeof(Func<BaseClass>)));
			Assert.IsFalse(typeof(Action<BaseClass>).IsImplicitlyAssignableFrom(typeof(Action<DerivedClass>)));
			Assert.IsTrue(typeof(Action<DerivedClass>).IsImplicitlyAssignableFrom(typeof(Action<BaseClass>)));
			Assert.IsTrue(typeof(Func<DerivedClass, BaseClass>).IsImplicitlyAssignableFrom(typeof(Func<BaseClass, DerivedClass>)));
			Assert.IsFalse(typeof(Func<BaseClass, BaseClass>).IsImplicitlyAssignableFrom(typeof(Func<DerivedClass, DerivedClass>)));
			Assert.IsFalse(typeof(Func<DerivedClass, DerivedClass>).IsImplicitlyAssignableFrom(typeof(Func<BaseClass, BaseClass>)));

			#endregion // Implicit Reference Conversions

			#region Boxing Conversions

			Assert.IsTrue(typeof(object).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(object).IsImplicitlyAssignableFrom(typeof(EnumValues)));
			Assert.IsTrue(typeof(object).IsImplicitlyAssignableFrom(typeof(Struct)));
			Assert.IsTrue(typeof(ValueType).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(ValueType).IsImplicitlyAssignableFrom(typeof(Struct)));
			Assert.IsTrue(typeof(ValueType).IsImplicitlyAssignableFrom(typeof(EnumValues)));
			Assert.IsTrue(typeof(IComparable).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(IFormattable).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(IConvertible).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(IComparable<int>).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(IEquatable<int>).IsImplicitlyAssignableFrom(typeof(int)));
			Assert.IsTrue(typeof(DerivedInterface).IsImplicitlyAssignableFrom(typeof(Struct)));
			Assert.IsTrue(typeof(BaseInterface).IsImplicitlyAssignableFrom(typeof(Struct)));
			Assert.IsTrue(typeof(IComparable).IsImplicitlyAssignableFrom(typeof(EnumValues)));
			Assert.IsTrue(typeof(IFormattable).IsImplicitlyAssignableFrom(typeof(EnumValues)));
			Assert.IsTrue(typeof(IConvertible).IsImplicitlyAssignableFrom(typeof(EnumValues)));
			Assert.IsTrue(typeof(Enum).IsImplicitlyAssignableFrom(typeof(EnumValues)));
			Assert.IsTrue(typeof(object).IsImplicitlyAssignableFrom(typeof(int?)));
			Assert.IsTrue(typeof(object).IsImplicitlyAssignableFrom(typeof(EnumValues?)));
			Assert.IsTrue(typeof(object).IsImplicitlyAssignableFrom(typeof(Struct?)));
			Assert.IsTrue(typeof(ValueType).IsImplicitlyAssignableFrom(typeof(int?)));
			Assert.IsTrue(typeof(ValueType).IsImplicitlyAssignableFrom(typeof(Struct?)));
			Assert.IsTrue(typeof(ValueType).IsImplicitlyAssignableFrom(typeof(EnumValues?)));
			Assert.IsTrue(typeof(IComparable).IsImplicitlyAssignableFrom(typeof(int?)));
			Assert.IsTrue(typeof(IFormattable).IsImplicitlyAssignableFrom(typeof(int?)));
			Assert.IsTrue(typeof(IConvertible).IsImplicitlyAssignableFrom(typeof(int?)));
			Assert.IsTrue(typeof(IComparable<int>).IsImplicitlyAssignableFrom(typeof(int?)));
			Assert.IsTrue(typeof(IEquatable<int>).IsImplicitlyAssignableFrom(typeof(int?)));
			Assert.IsTrue(typeof(DerivedInterface).IsImplicitlyAssignableFrom(typeof(Struct?)));
			Assert.IsTrue(typeof(BaseInterface).IsImplicitlyAssignableFrom(typeof(Struct?)));
			Assert.IsTrue(typeof(IComparable).IsImplicitlyAssignableFrom(typeof(EnumValues?)));
			Assert.IsTrue(typeof(IFormattable).IsImplicitlyAssignableFrom(typeof(EnumValues?)));
			Assert.IsTrue(typeof(IConvertible).IsImplicitlyAssignableFrom(typeof(EnumValues?)));
			Assert.IsTrue(typeof(Enum).IsImplicitlyAssignableFrom(typeof(EnumValues?)));
			Assert.IsTrue(typeof(IEnumerable<DerivedClass>).IsImplicitlyAssignableFrom(typeof(Struct2)));
			Assert.IsTrue(typeof(IEnumerable<BaseClass>).IsImplicitlyAssignableFrom(typeof(Struct2)));
			Assert.IsTrue(typeof(IEnumerable<DerivedClass>).IsImplicitlyAssignableFrom(typeof(Struct2?)));
			Assert.IsTrue(typeof(IEnumerable<BaseClass>).IsImplicitlyAssignableFrom(typeof(Struct2?)));

			#endregion // Boxing Conversions

			#region Implicit conversions involving type parameters

			var typeParameter = typeof(TypeParameterWithBaseClass<>).GetGenericArguments()[0];
			Assert.IsTrue(typeof(DerivedClass).IsImplicitlyAssignableFrom(typeParameter));
			Assert.IsTrue(typeof(BaseClass).IsImplicitlyAssignableFrom(typeParameter));
			Assert.IsTrue(typeof(object).IsImplicitlyAssignableFrom(typeParameter));
			Assert.IsTrue(typeof(DerivedInterface).IsImplicitlyAssignableFrom(typeParameter));
			Assert.IsTrue(typeof(BaseInterface).IsImplicitlyAssignableFrom(typeParameter));
			typeParameter = typeof(TypeParameterWithInterface<>).GetGenericArguments()[0];
			Assert.IsTrue(typeof(DerivedInterface).IsImplicitlyAssignableFrom(typeParameter));
			Assert.IsTrue(typeof(BaseInterface).IsImplicitlyAssignableFrom(typeParameter));
			var typeParameter1 = typeof(TypeParameterWithBaseGeneric<,>).GetGenericArguments()[0];
			var typeParameter2 = typeof(TypeParameterWithBaseGeneric<,>).GetGenericArguments()[1];
			Assert.IsTrue(typeParameter2.IsImplicitlyAssignableFrom(typeParameter1));
			typeParameter1 = typeof(TypeParameterWithVariantInterfaces<,>).GetGenericArguments()[0];
			typeParameter2 = typeof(TypeParameterWithVariantInterfaces<,>).GetGenericArguments()[1];
			Assert.IsTrue(typeof(ContravariantInterface<DerivedClass>).IsImplicitlyAssignableFrom(typeParameter1));
			Assert.IsTrue(typeof(CovariantInterface<BaseClass>).IsImplicitlyAssignableFrom(typeParameter2));

			#endregion // Implicit conversions involving type parameters

			#region User-defined implicit conversions

			Assert.IsTrue(typeof(A).IsImplicitlyAssignableFrom(typeof(B)));
			Assert.IsTrue(typeof(B).IsImplicitlyAssignableFrom(typeof(C)));

			#endregion // User-defined implicit conversions
		}


		public class DynamicMethod { public dynamic Method() { return null; } }

		public enum EnumValues { X, Y, Z }

		public class TypeParameterWithBaseClass<T> where T : DerivedClass { }
		public class TypeParameterWithInterface<T> where T : DerivedInterface { }
		public class TypeParameterWithBaseGeneric<T, U> where T : U { }
		public class TypeParameterWithVariantInterfaces<T, U>
			where T : ContravariantInterface<BaseClass>
			where U : CovariantInterface<DerivedClass> { }

		public class A { }
		public class B
		{
			public static implicit operator A(B b) { return null; }
			public static implicit operator B(C c) { return null; }
		}
		public class C { }

		public struct AStruct { }
		public struct BStruct
		{
			public static implicit operator AStruct(BStruct b) { return default(AStruct); }
			public static implicit operator BStruct(CStruct c) { return default(BStruct); }
		}
		public struct CStruct { }

		public interface ContravariantInterface<in T> { }
		public interface CovariantInterface<out T> { }
		
		public interface  BaseInterface { }
		public interface DerivedInterface : BaseInterface { }
		public class BaseClass { }
		public class DerivedClass : BaseClass, DerivedInterface { }
		public struct Struct : DerivedInterface { }
		public struct Struct2 : IEnumerable<DerivedClass> 
		{
			public IEnumerator<DerivedClass> GetEnumerator()
			{
				throw new NotImplementedException();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new NotImplementedException();
			}
		}

		private static void TestAssignability(params Type[] types)
		{
			TestAssignability((a, b) => true, types);
		}

		private static void TestAssignability(Func<Type, Type, bool> filter, params Type[] types)
		{
			var pairs =
				from a in types
				from b in types
				where a != b && filter(a, b)
				select new { a, b };

			foreach (var pair in pairs)
				TestAssignability(pair.a, pair.b);
		}

		private static void TestAssignability<A, B>()
		{
			TestAssignability(typeof(A), typeof(B));
		}

		private static void TestAssignability(Type a, Type b)
		{
			var aData = a.IsGenericParameter ? GenericTypeParameterData.FromType(a) : TypeData.FromType(a);
			var bData = b.IsGenericParameter ? GenericTypeParameterData.FromType(b) : TypeData.FromType(b);

			if (aData == null || bData == null)
				Assert.Inconclusive("Unable to get one of the types");

			if (a.IsImplicitlyAssignableFrom(b))
				Assert.IsTrue(aData.IsAssignableFromNew(bData), string.Format("The type should be assignable: {0} <- {1}", aData.Name, bData.Name));
			else
				Assert.IsFalse(aData.IsAssignableFromNew(bData), string.Format("The type should not be assignable: {0} <- {1}", aData.Name, bData.Name));

			if (b.IsImplicitlyAssignableFrom(a))
				Assert.IsTrue(bData.IsAssignableFromNew(aData), string.Format("The type should be assignable: {0} <- {1}", bData.Name, aData.Name));
			else
				Assert.IsFalse(bData.IsAssignableFromNew(aData), string.Format("The type should not be assignable: {0} <- {1}", bData.Name, aData.Name));
		}
	}
}

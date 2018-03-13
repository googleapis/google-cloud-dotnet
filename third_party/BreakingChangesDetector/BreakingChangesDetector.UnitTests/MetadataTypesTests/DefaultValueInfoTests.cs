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

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
	[TestClass]
	public class DefaultValueInfoTests
	{
		#region NullableBoolDefaultValueTests

		[TestMethod]
		public void NullableBoolDefaultValueTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(DefaultValueInfoTests).Assembly);
			var typeData = TypeDefinitionData.FromType(typeof(MethodWithDefaultValues));
			var method = typeData.GetMethod("MethodWithBools");

			Assert.AreEqual(null, method.Parameters[0].DefaultValue);
			Assert.AreEqual(true, method.Parameters[1].DefaultValue);
		}

		#endregion // NullableBoolDefaultValueTests

		#region NullableDecimalDefaultValueTests

		[TestMethod]
		public void NullableDecimalDefaultValueTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(DefaultValueInfoTests).Assembly);
			var typeData = TypeDefinitionData.FromType(typeof(MethodWithDefaultValues));
			var method = typeData.GetMethod("MethodWithDecimals");

			Assert.AreEqual(null, method.Parameters[0].DefaultValue);
			Assert.AreEqual(0m, method.Parameters[1].DefaultValue);
		}

		#endregion // NullableDecimalDefaultValueTests

		#region NullableEnumDefaultValueTests

		[TestMethod]
		public void NullableEnumDefaultValueTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(DefaultValueInfoTests).Assembly);
			var typeData = TypeDefinitionData.FromType(typeof(MethodWithDefaultValues));
			var method = typeData.GetMethod("MethodWithEnums");

			Assert.AreEqual(null, method.Parameters[0].DefaultValue);
			Assert.AreEqual((ulong)DateTimeKind.Local, method.Parameters[1].DefaultValue);
		}

		#endregion // NullableEnumDefaultValueTests

		#region NullableIntDefaultValueTests

		[TestMethod]
		public void NullableIntDefaultValueTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(DefaultValueInfoTests).Assembly);
			var typeData = TypeDefinitionData.FromType(typeof(MethodWithDefaultValues));
			var method = typeData.GetMethod("MethodWithInts");

			Assert.AreEqual(null, method.Parameters[0].DefaultValue);
			Assert.AreEqual(0, method.Parameters[1].DefaultValue);
		}

		#endregion // NullableIntDefaultValueTests

		public class MethodWithDefaultValues
		{
			public void MethodWithBools(bool? x = null, bool? y = true) { }
			public void MethodWithDecimals(decimal? x = null, decimal? y = 0) { }
			public void MethodWithEnums(DateTimeKind? x = null, DateTimeKind? y = DateTimeKind.Local) { }
			public void MethodWithInts(int? x = null, int? y = 0) { }
		}
	}
}

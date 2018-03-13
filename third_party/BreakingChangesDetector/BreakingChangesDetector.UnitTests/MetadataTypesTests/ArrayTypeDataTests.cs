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
	public class ArrayTypeDataTests
	{
		#region GetDirectImplicitConversionsTests

		[TestMethod]
		public void GetDirectImplicitConversionsTests()
		{
			var rank1ArrayType = typeof(int[]);
			var rank1ArrayTypeData = ArrayTypeData.FromType(rank1ArrayType);

			var implicitConversions = new HashSet<TypeData>(rank1ArrayTypeData.GetDirectImplicitConversions(true));

			if (implicitConversions.Remove(TypeData.FromType(rank1ArrayType.BaseType)) == false)
				Assert.Fail(string.Format("Base type {0} was not returned from GetDirectImplicitConversions of a rank-1 array.", rank1ArrayType.BaseType));

			foreach (var implementedInterface in rank1ArrayType.GetInterfaces())
			{
				if (implicitConversions.Remove(TypeData.FromType(implementedInterface)) == false)
					Assert.Fail(string.Format("Implemented interface type {0} was not returned from GetDirectImplicitConversions of a rank-1 array.", implementedInterface.Name));
			}

			Assert.AreEqual(0, implicitConversions.Count, "Extra interfaces were returned from GetDirectImplicitConversions of a rank-1 array.");

			// ----------------------------------------------------------------

			var rank2ArrayType = typeof(int[,]);
			var rank2ArrayTypeData = ArrayTypeData.FromType(rank2ArrayType);

			implicitConversions = new HashSet<TypeData>(rank2ArrayTypeData.GetDirectImplicitConversions(true));

			if (implicitConversions.Remove(TypeData.FromType(rank2ArrayType.BaseType)) == false)
				Assert.Fail(string.Format("Base type {0} was not returned from GetDirectImplicitConversions of a rank-1 array.", rank2ArrayType.BaseType));

			foreach (var implementedInterface in rank2ArrayType.GetInterfaces())
			{
				if (implicitConversions.Remove(TypeData.FromType(implementedInterface)) == false)
					Assert.Fail(string.Format("Implemented interface type {0} was not returned from GetDirectImplicitConversions of a rank-2 array.", implementedInterface.Name));
			}

			Assert.AreEqual(0, implicitConversions.Count, "Extra interfaces were returned from GetDirectImplicitConversions of a rank-2 array.");
		}

		#endregion // GetDirectImplicitConversionsTests
	}
}

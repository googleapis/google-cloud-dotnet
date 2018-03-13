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
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	[TestClass]
	public class RemovedExtensionMethodModifierTests
	{
		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(RemovedExtensionMethodModifierTests).Assembly);
			var ClassWithExtensionMethod = TypeDefinitionData.FromType(typeof(ClassWithExtensionMethod));
			var ClassWithoutExtensionMethod = TypeDefinitionData.FromType(typeof(ClassWithoutExtensionMethod));
			
			var breakingChanges = MetadataComparer.CompareTypes(ClassWithExtensionMethod, ClassWithoutExtensionMethod);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an extension method is turned into a normal method.");
			Assert.AreEqual(BreakingChangeKind.RemovedExtensionMethodModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithExtensionMethod.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(ClassWithoutExtensionMethod.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithoutExtensionMethod, ClassWithExtensionMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an normal method is turned into an extension method.");
		}

		#endregion // MethodTests
	}

	public static class ClassWithExtensionMethod { public static void Method(this RemovedExtensionMethodModifierTests x) { } }
	public static class ClassWithoutExtensionMethod { public static void Method(RemovedExtensionMethodModifierTests x) { } }
}

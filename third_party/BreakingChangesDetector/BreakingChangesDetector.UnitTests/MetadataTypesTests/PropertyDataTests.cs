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
	public class PropertyDataTests
	{
		#region PropertyDataAccessibilityTest

		[TestMethod]
		public void PropertyDataAccessibilityTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var member = (PropertyData)typeData.GetMember("PropertyReadOnly");
			Assert.AreEqual(MemberAccessibility.Protected, member.Accessibility, "Incorrect MemberAccessibility.");

			member = (PropertyData)typeData.GetMember("PropertyWriteOnly");
			Assert.AreEqual(MemberAccessibility.Public, member.Accessibility, "Incorrect MemberAccessibility.");

			member = (PropertyData)typeData.GetMember("PropertyReadWrite");
			Assert.AreEqual(MemberAccessibility.Public, member.Accessibility, "Incorrect MemberAccessibility.");
		}

		#endregion // PropertyDataAccessibilityTest

		#region PropertyDataDeclaringTypeTest

		[TestMethod]
		public void PropertyDataDeclaringTypeTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var member = (PropertyData)typeData.GetMember("PropertyReadOnly");
			Assert.AreEqual(typeData, member.DeclaringType, "The DeclaringType of a member should be the type in which it is defined.");
		}

		#endregion // PropertyDataDeclaringTypeTest

		#region PropertyDataMemberFlagsTest

		[TestMethod]
		public void PropertyDataMemberFlagsTest()
		{
			var t = typeof(OverloadedMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var eventData = (PropertyData)typeData.GetMember("PropertyInstance");
			Assert.AreEqual(MemberFlags.None, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (PropertyData)typeData.GetMember("PropertyStatic");
			Assert.AreEqual(MemberFlags.Static, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (PropertyData)typeData.GetMember("PropertyInstanceAbstract");
			Assert.AreEqual(MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (PropertyData)typeData.GetMember("PropertyInstanceVirtual");
			Assert.AreEqual(MemberFlags.Virtual, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (PropertyData)typeData.GetMember("PropertyInstanceOverrideAbstract");
			Assert.AreEqual(MemberFlags.Override, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (PropertyData)typeData.GetMember("PropertyInstanceOverrideAbstractSealed");
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Sealed, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (PropertyData)typeData.GetMember("PropertyInstanceOverrideAbstractAbstract");
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (PropertyData)typeData.GetMember("PropertyInstanceOverrideVirtual");
			Assert.AreEqual(MemberFlags.Override, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (PropertyData)typeData.GetMember("PropertyInstanceOverrideVirtualSealed");
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Sealed, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (PropertyData)typeData.GetMember("PropertyInstanceOverrideVirtualAbstract");
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
		}

		#endregion // PropertyDataMemberFlagsTest

		#region PropertyDataGetMethodAccessibilityTest

		[TestMethod]
		public void PropertyDataGetMethodAccessibilityTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var member = (PropertyData)typeData.GetMember("PropertyReadOnly");
			Assert.AreEqual(MemberAccessibility.Protected, member.GetMethodAccessibility, "The GetMethodAccessibility of the read only property is incorrect.");

			member = (PropertyData)typeData.GetMember("PropertyWriteOnly");
			Assert.AreEqual(null, member.GetMethodAccessibility, "The GetMethodAccessibility of the write only property is incorrect.");

			member = (PropertyData)typeData.GetMember("PropertyReadWrite");
			Assert.AreEqual(MemberAccessibility.Public, member.GetMethodAccessibility, "The GetMethodAccessibility of the read write property is incorrect.");
		}

		#endregion // PropertyDataGetMethodAccessibilityTest

		#region PropertyDataNameTest

		[TestMethod]
		public void PropertyDataNameTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var member = (PropertyData)typeData.GetMember("PropertyReadOnly");
			Assert.AreEqual("PropertyReadOnly", member.Name, "The Name of the member is incorrect.");
		}

		#endregion // PropertyDataNameTest

		#region PropertyDataSetMethodAccessibilityTest

		[TestMethod]
		public void PropertyDataSetMethodAccessibilityTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var member = (PropertyData)typeData.GetMember("PropertyReadOnly");
			Assert.AreEqual(null, member.SetMethodAccessibility, "The SetMethodAccessibility of the read only property is incorrect.");

			member = (PropertyData)typeData.GetMember("PropertyWriteOnly");
			Assert.AreEqual(MemberAccessibility.Public, member.SetMethodAccessibility, "The SetMethodAccessibility of the write only property is incorrect.");

			member = (PropertyData)typeData.GetMember("PropertyReadWrite");
			Assert.AreEqual(MemberAccessibility.Protected, member.SetMethodAccessibility, "The SetMethodAccessibility of the read write property is incorrect.");
		}

		#endregion // PropertyDataSetMethodAccessibilityTest

		#region PropertyDataTypeTest

		[TestMethod]
		public void PropertyDataTypeTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var member = (PropertyData)typeData.GetMember("PropertyReadOnly");
			var objectType = TypeDefinitionData.FromType<object>();
			Assert.AreEqual(objectType, member.Type, "The Type of the member is incorrect.");
		}

		#endregion // PropertyDataTypeTest
	}
}

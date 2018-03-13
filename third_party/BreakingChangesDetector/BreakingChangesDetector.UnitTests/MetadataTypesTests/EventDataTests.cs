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
	public class EventDataTests
	{
		#region EventDataAccessibilityTest

		[TestMethod]
		public void EventDataAccessibilityTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			TestUtilities.VerifyAccessibility(typeData, "EventInstance");
		}

		#endregion // EventDataAccessibilityTest

		#region EventDataDeclaringTypeTest

		[TestMethod]
		public void EventDataDeclaringTypeTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var eventData = typeData.GetMember("EventInstance");
			Assert.AreEqual(typeData, eventData.DeclaringType, "The DeclaringType of a member should be the type in which it is defined.");
		}

		#endregion // EventDataDeclaringTypeTest

		#region EventDataMemberFlagsTest

		[TestMethod]
		public void EventDataMemberFlagsTest()
		{
			var t = typeof(OverloadedMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var eventData = (EventData)typeData.GetMember("EventInstance");
			Assert.AreEqual(MemberFlags.None, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventStatic");
			Assert.AreEqual(MemberFlags.Static, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceAbstract");
			Assert.AreEqual(MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceVirtual");
			Assert.AreEqual(MemberFlags.Virtual, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceOverrideAbstract");
			Assert.AreEqual(MemberFlags.Override, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceOverrideAbstractSealed");
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Sealed, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceOverrideAbstractAbstract");
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceOverrideVirtual");
			Assert.AreEqual(MemberFlags.Override, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceOverrideVirtualSealed");
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Sealed, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceOverrideVirtualAbstract");
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
		}

		#endregion // EventDataMemberFlagsTest

		#region EventDataNameTest

		[TestMethod]
		public void EventDataNameTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var eventData = typeData.GetMember("EventInstance");
			Assert.AreEqual("EventInstance", eventData.Name, "The Name of the member is incorrect.");
		}

		#endregion // EventDataNameTest

		#region EventDataTypeTest

		[TestMethod]
		public void EventDataTypeTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var eventData = (EventData)typeData.GetMember("EventInstance");
			var eventHandlerType = TypeDefinitionData.FromType<EventHandler>();
			Assert.AreEqual(eventHandlerType, eventData.Type, "The Type of the member is incorrect.");
		}

		#endregion // EventDataTypeTest
	}
}

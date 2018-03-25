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

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{	
	public class EventDataTests
	{
		#region EventDataAccessibilityTest

		[Fact]
		public void EventDataAccessibilityTest()
		{
			var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
			TestUtilities.VerifyAccessibility(typeData, "EventInstance");
		}

		#endregion // EventDataAccessibilityTest

		#region EventDataDeclaringTypeTest

		[Fact]
		public void EventDataDeclaringTypeTest()
		{
			var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
			var eventData = typeData.GetMember("EventInstance");
			AssertX.Equal(typeData, eventData.ContainingType, "The DeclaringType of a member should be the type in which it is defined.");
		}

		#endregion // EventDataDeclaringTypeTest

		#region EventDataMemberFlagsTest

		[Fact]
		public void EventDataMemberFlagsTest()
		{
			var t = typeof(OverloadedMemberFeatures);
			var context = MetadataResolutionContext.CreateFromTypes(t);
			var typeData = context.GetTypeDefinitionData(t);

			var eventData = (EventData)typeData.GetMember("EventInstance");
			AssertX.Equal(MemberFlags.None, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventStatic");
			AssertX.Equal(MemberFlags.Static, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceAbstract");
			AssertX.Equal(MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceVirtual");
			AssertX.Equal(MemberFlags.Virtual, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceOverrideAbstract");
			AssertX.Equal(MemberFlags.Override, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceOverrideAbstractSealed");
			AssertX.Equal(MemberFlags.Override | MemberFlags.Sealed, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceOverrideAbstractAbstract");
			AssertX.Equal(MemberFlags.Override | MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceOverrideVirtual");
			AssertX.Equal(MemberFlags.Override, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceOverrideVirtualSealed");
			AssertX.Equal(MemberFlags.Override | MemberFlags.Sealed, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (EventData)typeData.GetMember("EventInstanceOverrideVirtualAbstract");
			AssertX.Equal(MemberFlags.Override | MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
		}

		#endregion // EventDataMemberFlagsTest

		#region EventDataNameTest

		[Fact]
		public void EventDataNameTest()
		{
			var t = typeof(TestClassDefinition);
			var context = MetadataResolutionContext.CreateFromTypes(t);
			var typeData = context.GetTypeDefinitionData(t);
			var eventData = typeData.GetMember("EventInstance");
			AssertX.Equal("EventInstance", eventData.Name, "The Name of the member is incorrect.");
		}

		#endregion // EventDataNameTest

		#region EventDataTypeTest

		[Fact]
		public void EventDataTypeTest()
		{
			var t = typeof(TestClassDefinition);
			var context = MetadataResolutionContext.CreateFromTypes(t);
			var typeData = context.GetTypeDefinitionData(t);
			var eventData = (EventData)typeData.GetMember("EventInstance");
			var eventHandlerType = context.GetTypeDefinitionData<EventHandler>();
			AssertX.Equal(eventHandlerType, eventData.Type, "The Type of the member is incorrect.");
		}

		#endregion // EventDataTypeTest
	}
}

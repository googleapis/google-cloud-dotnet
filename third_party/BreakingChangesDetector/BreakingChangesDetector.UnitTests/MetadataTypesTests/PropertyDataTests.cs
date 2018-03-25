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

using Xunit;
using BreakingChangesDetector.MetadataItems;

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
    public class PropertyDataTests
    {
        #region PropertyDataAccessibilityTest

        [Fact]
        public void PropertyDataAccessibilityTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);

            var member = (PropertyData)typeData.GetMember("PropertyReadOnly");
            AssertX.Equal(MemberAccessibility.Protected, member.Accessibility, "Incorrect MemberAccessibility.");

            member = (PropertyData)typeData.GetMember("PropertyWriteOnly");
            AssertX.Equal(MemberAccessibility.Public, member.Accessibility, "Incorrect MemberAccessibility.");

            member = (PropertyData)typeData.GetMember("PropertyReadWrite");
            AssertX.Equal(MemberAccessibility.Public, member.Accessibility, "Incorrect MemberAccessibility.");
        }

        #endregion // PropertyDataAccessibilityTest

        #region PropertyDataDeclaringTypeTest

        [Fact]
        public void PropertyDataDeclaringTypeTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var member = (PropertyData)typeData.GetMember("PropertyReadOnly");
            AssertX.Equal(typeData, member.ContainingType, "The DeclaringType of a member should be the type in which it is defined.");
        }

        #endregion // PropertyDataDeclaringTypeTest

        #region PropertyDataMemberFlagsTest

        [Fact]
        public void PropertyDataMemberFlagsTest()
        {
            var t = typeof(OverloadedMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);

            var eventData = (PropertyData)typeData.GetMember("PropertyInstance");
            AssertX.Equal(MemberFlags.None, eventData.MemberFlags, "The Flags value of the member is wrong.");
            eventData = (PropertyData)typeData.GetMember("PropertyStatic");
            AssertX.Equal(MemberFlags.Static, eventData.MemberFlags, "The Flags value of the member is wrong.");
            eventData = (PropertyData)typeData.GetMember("PropertyInstanceAbstract");
            AssertX.Equal(MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
            eventData = (PropertyData)typeData.GetMember("PropertyInstanceVirtual");
            AssertX.Equal(MemberFlags.Virtual, eventData.MemberFlags, "The Flags value of the member is wrong.");
            eventData = (PropertyData)typeData.GetMember("PropertyInstanceOverrideAbstract");
            AssertX.Equal(MemberFlags.Override, eventData.MemberFlags, "The Flags value of the member is wrong.");
            eventData = (PropertyData)typeData.GetMember("PropertyInstanceOverrideAbstractSealed");
            AssertX.Equal(MemberFlags.Override | MemberFlags.Sealed, eventData.MemberFlags, "The Flags value of the member is wrong.");
            eventData = (PropertyData)typeData.GetMember("PropertyInstanceOverrideAbstractAbstract");
            AssertX.Equal(MemberFlags.Override | MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
            eventData = (PropertyData)typeData.GetMember("PropertyInstanceOverrideVirtual");
            AssertX.Equal(MemberFlags.Override, eventData.MemberFlags, "The Flags value of the member is wrong.");
            eventData = (PropertyData)typeData.GetMember("PropertyInstanceOverrideVirtualSealed");
            AssertX.Equal(MemberFlags.Override | MemberFlags.Sealed, eventData.MemberFlags, "The Flags value of the member is wrong.");
            eventData = (PropertyData)typeData.GetMember("PropertyInstanceOverrideVirtualAbstract");
            AssertX.Equal(MemberFlags.Override | MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
        }

        #endregion // PropertyDataMemberFlagsTest

        #region PropertyDataGetMethodAccessibilityTest

        [Fact]
        public void PropertyDataGetMethodAccessibilityTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);

            var member = (PropertyData)typeData.GetMember("PropertyReadOnly");
            AssertX.Equal(MemberAccessibility.Protected, member.GetMethodAccessibility, "The GetMethodAccessibility of the read only property is incorrect.");

            member = (PropertyData)typeData.GetMember("PropertyWriteOnly");
            AssertX.Equal(null, member.GetMethodAccessibility, "The GetMethodAccessibility of the write only property is incorrect.");

            member = (PropertyData)typeData.GetMember("PropertyReadWrite");
            AssertX.Equal(MemberAccessibility.Public, member.GetMethodAccessibility, "The GetMethodAccessibility of the read write property is incorrect.");
        }

        #endregion // PropertyDataGetMethodAccessibilityTest

        #region PropertyDataNameTest

        [Fact]
        public void PropertyDataNameTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);

            var member = (PropertyData)typeData.GetMember("PropertyReadOnly");
            AssertX.Equal("PropertyReadOnly", member.Name, "The Name of the member is incorrect.");
        }

        #endregion // PropertyDataNameTest

        #region PropertyDataSetMethodAccessibilityTest

        [Fact]
        public void PropertyDataSetMethodAccessibilityTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);

            var member = (PropertyData)typeData.GetMember("PropertyReadOnly");
            AssertX.Equal(null, member.SetMethodAccessibility, "The SetMethodAccessibility of the read only property is incorrect.");

            member = (PropertyData)typeData.GetMember("PropertyWriteOnly");
            AssertX.Equal(MemberAccessibility.Public, member.SetMethodAccessibility, "The SetMethodAccessibility of the write only property is incorrect.");

            member = (PropertyData)typeData.GetMember("PropertyReadWrite");
            AssertX.Equal(MemberAccessibility.Protected, member.SetMethodAccessibility, "The SetMethodAccessibility of the read write property is incorrect.");
        }

        #endregion // PropertyDataSetMethodAccessibilityTest

        #region PropertyDataTypeTest

        [Fact]
        public void PropertyDataTypeTest()
        {
            var t = typeof(VariousMemberFeatures);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var member = (PropertyData)typeData.GetMember("PropertyReadOnly");
            var objectType = context.GetTypeDefinitionData<object>();
            AssertX.Equal(objectType, member.Type, "The Type of the member is incorrect.");
        }

        #endregion // PropertyDataTypeTest
    }
}

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
using System.Linq;
using Xunit;
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class RemovedMemberTests
    {
        #region ChangeConstantToFieldTest

        [Fact]
        public void ChangeConstantToFieldTest()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(RemovedMemberTests));
            var ClassWithConstant = context.GetTypeDefinitionData(typeof(ClassWithConstant));
            var ClassWithStaticReadOnlyField = context.GetTypeDefinitionData(typeof(ClassWithStaticReadOnlyField));
            var ClassWithStaticReadWriteField = context.GetTypeDefinitionData(typeof(ClassWithStaticReadWriteField));
            var ClassWithReadOnlyField = context.GetTypeDefinitionData(typeof(ClassWithReadOnlyField));
            var ClassWithReadWriteField = context.GetTypeDefinitionData(typeof(ClassWithReadWriteField));

            var breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithStaticReadOnlyField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed to a read-only static field.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithStaticReadWriteField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed to a read-write static field.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithReadOnlyField);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constant is changed to a read-only instance field.");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithConstant.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithReadOnlyField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithReadWriteField);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constant is changed to a read-write instance field.");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithConstant.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithReadWriteField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // ChangeConstantToFieldTest

        #region ChangeConstantToPropertyTest

        [Fact]
        public void ChangeConstantToPropertyTest()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(RemovedMemberTests));
            var ClassWithConstant = context.GetTypeDefinitionData(typeof(ClassWithConstant));
            var ClassWithReadOnlyProperty = context.GetTypeDefinitionData(typeof(ClassWithReadOnlyProperty));
            var ClassWithStaticReadOnlyProperty = context.GetTypeDefinitionData(typeof(ClassWithStaticReadOnlyProperty));
            var ClassWithStaticReadOnlyProtectedProperty = context.GetTypeDefinitionData(typeof(ClassWithStaticReadOnlyProtectedProperty));
            var ClassWithStaticProtectedGetProperty = context.GetTypeDefinitionData(typeof(ClassWithStaticProtectedGetProperty));

            var breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithReadOnlyProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constant is changed to an instance property");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithConstant.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithReadOnlyProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithStaticReadOnlyProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed to a static property with compatible access.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithStaticReadOnlyProtectedProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constant is changed to a protected property.");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithConstant.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithStaticReadOnlyProtectedProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithStaticProtectedGetProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constant is changed to a public property with a protected get accessor.");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithConstant.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithStaticProtectedGetProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // ChangeConstantToPropertyTest

        #region ChangeExplicitToImplicitMemberTests

        [Fact]
        public void ChangeExplicitToImplicitMemberTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(RemovedMemberTests));
            var ExplicitInterfaceMember = context.GetTypeDefinitionData(typeof(ExplicitInterfaceMember));
            var ImplicitInterfaceMember = context.GetTypeDefinitionData(typeof(ImplicitInterfaceMember));

            var breakingChanges = MetadataComparer.CompareTypes(ImplicitInterfaceMember, ExplicitInterfaceMember);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an implicit interface member is changed to explicit");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ImplicitInterfaceMember.GetMember("Equals"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ExplicitInterfaceMember, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ExplicitInterfaceMember, ImplicitInterfaceMember);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an explicit interface member is changed to implicit");
        }

        #endregion // ChangeExplicitToImplicitMemberTests

        #region ChangeFieldToConstantTest

        [Fact]
        public void ChangeFieldToConstantTest()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(RemovedMemberTests));
            var ClassWithConstant = context.GetTypeDefinitionData(typeof(ClassWithConstant));
            var ClassWithStaticReadOnlyField = context.GetTypeDefinitionData(typeof(ClassWithStaticReadOnlyField));
            var ClassWithStaticReadWriteField = context.GetTypeDefinitionData(typeof(ClassWithStaticReadWriteField));
            var ClassWithReadOnlyField = context.GetTypeDefinitionData(typeof(ClassWithReadOnlyField));
            var ClassWithReadWriteField = context.GetTypeDefinitionData(typeof(ClassWithReadWriteField));

            var breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadOnlyField, ClassWithConstant);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a read-only static field is changed to a constant");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadWriteField, ClassWithConstant);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read-write static is changed to a constant");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithStaticReadWriteField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithConstant);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read-only instance is changed to a constant");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadOnlyField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteField, ClassWithConstant);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read-write instance is changed to a constant");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadWriteField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // ChangeFieldToConstantTest

        #region ChangeFieldToPropertyTest

        [Fact]
        public void ChangeFieldToPropertyTest()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(RemovedMemberTests));
            var ClassWithReadOnlyField = context.GetTypeDefinitionData(typeof(ClassWithReadOnlyField));
            var ClassWithReadWriteField = context.GetTypeDefinitionData(typeof(ClassWithReadWriteField));
            var ClassWithReadOnlyProperty = context.GetTypeDefinitionData(typeof(ClassWithReadOnlyProperty));
            var ClassWithReadWriteProperty = context.GetTypeDefinitionData(typeof(ClassWithReadWriteProperty));
            var ClassWithWriteOnlyProperty = context.GetTypeDefinitionData(typeof(ClassWithWriteOnlyProperty));
            var ClassWithVirtualProperty = context.GetTypeDefinitionData(typeof(ClassWithVirtualProperty));
            var ClassWithSealedOverrideProperty = context.GetTypeDefinitionData(typeof(ClassWithSealedOverrideProperty));
            var ClassWithStaticReadOnlyField = context.GetTypeDefinitionData(typeof(ClassWithStaticReadOnlyField));
            var ClassWithStaticReadOnlyProperty = context.GetTypeDefinitionData(typeof(ClassWithStaticReadOnlyProperty));
            var ClassWithReadOnlyProtectedField = context.GetTypeDefinitionData(typeof(ClassWithReadOnlyProtectedField));
            var ClassWithReadOnlyProtectedProperty = context.GetTypeDefinitionData(typeof(ClassWithReadOnlyProtectedProperty));
            var ClassWithProtectedGetProperty = context.GetTypeDefinitionData(typeof(ClassWithProtectedGetProperty));

            var breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithReadOnlyProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a property is changed to a field with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteField, ClassWithReadOnlyProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read/write field is changed to a property");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadWriteField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithReadOnlyProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithReadWriteProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a read-only field is changed to a property with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteField, ClassWithReadWriteProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read/write field is changed to a property");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadWriteField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithReadWriteProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithWriteOnlyProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read-only field is changed to a write-only property.");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadOnlyField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithWriteOnlyProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteField, ClassWithWriteOnlyProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read/write field is changed to a property");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadWriteField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithWriteOnlyProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithVirtualProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a read-only field is changed to a virtual property.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithSealedOverrideProperty);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.RemovedMember).ToList();
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a read-only field is changed to a sealed override property.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadOnlyField, ClassWithStaticReadOnlyProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a read-only field is changed to a property with compatible access.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadOnlyField, ClassWithReadOnlyProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read-only static field is changed to an instance property.");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithStaticReadOnlyField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithReadOnlyProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithStaticReadOnlyProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read-only instance field is changed to a static property.");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadOnlyField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithStaticReadOnlyProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithReadOnlyProtectedProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read-only public field is changed to a protected property.");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadOnlyField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithReadOnlyProtectedProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithProtectedGetProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read-only public field is changed to a public property with a protected get accessor.");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadOnlyField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithProtectedGetProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // ChangeFieldToPropertyTest

        #region ChangePropertyToConstantTest

        [Fact]
        public void ChangePropertyToConstantTest()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(RemovedMemberTests));
            var ClassWithConstant = context.GetTypeDefinitionData(typeof(ClassWithConstant));
            var ClassWithReadOnlyProperty = context.GetTypeDefinitionData(typeof(ClassWithReadOnlyProperty));
            var ClassWithReadWriteProperty = context.GetTypeDefinitionData(typeof(ClassWithReadWriteProperty));
            var ClassWithWriteOnlyProperty = context.GetTypeDefinitionData(typeof(ClassWithWriteOnlyProperty));
            var ClassWithStaticReadOnlyProperty = context.GetTypeDefinitionData(typeof(ClassWithStaticReadOnlyProperty));
            var ClassWithStaticReadWriteProperty = context.GetTypeDefinitionData(typeof(ClassWithStaticReadWriteProperty));
            var ClassWithStaticWriteOnlyProperty = context.GetTypeDefinitionData(typeof(ClassWithStaticWriteOnlyProperty));

            var breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyProperty, ClassWithConstant);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read-only instance property is changed to a constant");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteProperty, ClassWithConstant);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read-write instance property is changed to a constant");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadWriteProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithWriteOnlyProperty, ClassWithConstant);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a write-only instance property is changed to a constant");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithWriteOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadOnlyProperty, ClassWithConstant);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a read-only static property is changed to a constant");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadWriteProperty, ClassWithConstant);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a read-write static property is changed to a constant");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithStaticReadWriteProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticWriteOnlyProperty, ClassWithConstant);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a write-only static property is changed to a constant");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithStaticWriteOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // ChangePropertyToConstantTest

        #region ChangePropertyToFieldTest

        [Fact]
        public void ChangePropertyToFieldTest()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(RemovedMemberTests));
            var ClassWithReadOnlyField = context.GetTypeDefinitionData(typeof(ClassWithReadOnlyField));
            var ClassWithReadWriteField = context.GetTypeDefinitionData(typeof(ClassWithReadWriteField));
            var ClassWithReadOnlyProperty = context.GetTypeDefinitionData(typeof(ClassWithReadOnlyProperty));
            var ClassWithReadWriteProperty = context.GetTypeDefinitionData(typeof(ClassWithReadWriteProperty));
            var ClassWithWriteOnlyProperty = context.GetTypeDefinitionData(typeof(ClassWithWriteOnlyProperty));
            var ClassWithVirtualProperty = context.GetTypeDefinitionData(typeof(ClassWithVirtualProperty));
            var ClassWithSealedOverrideProperty = context.GetTypeDefinitionData(typeof(ClassWithSealedOverrideProperty));
            var ClassWithStaticReadOnlyField = context.GetTypeDefinitionData(typeof(ClassWithStaticReadOnlyField));
            var ClassWithStaticReadOnlyProperty = context.GetTypeDefinitionData(typeof(ClassWithStaticReadOnlyProperty));
            var ClassWithReadOnlyProtectedField = context.GetTypeDefinitionData(typeof(ClassWithReadOnlyProtectedField));

            var breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyProperty, ClassWithReadOnlyField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a property is changed to a field with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyProperty, ClassWithReadWriteField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a property is changed to a field with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteProperty, ClassWithReadOnlyField);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a property is changed to a field but the field has more restricted access");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadWriteProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithReadOnlyField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteProperty, ClassWithReadWriteField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a property is changed to a field with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithWriteOnlyProperty, ClassWithReadOnlyField);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a property is changed to a field but the field has more restricted access");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithWriteOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithReadOnlyField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithWriteOnlyProperty, ClassWithReadWriteField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a property is changed to a field with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithVirtualProperty, ClassWithReadOnlyField);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a virtual property is changed to a field");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithVirtualProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithReadOnlyField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithSealedOverrideProperty, ClassWithReadOnlyField);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.RemovedMember).ToList();
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a virtual property is changed to a field");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadOnlyProperty, ClassWithStaticReadOnlyField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a property is changed to a field with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyProperty, ClassWithStaticReadOnlyField);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when an instance property is changed to a static field");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithStaticReadOnlyField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadOnlyProperty, ClassWithReadOnlyField);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a static property is changed to an instance field");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithStaticReadOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithReadOnlyField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyProperty, ClassWithReadOnlyProtectedField);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a public property is changed to a protected field");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ClassWithReadOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(ClassWithReadOnlyProtectedField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // ChangePropertyToFieldTest

        #region ConstantTests

        [Fact]
        public void ConstantTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var publicConstant = context.GetTypeDefinitionData(typeof(PublicConstant));
            var protectedConstant = context.GetTypeDefinitionData(typeof(ProtectedConstant));
            var protectedInternalConstant = context.GetTypeDefinitionData(typeof(ProtectedInternalConstant));
            var internalConstant = context.GetTypeDefinitionData(typeof(InternalConstant));
            var privateConstant = context.GetTypeDefinitionData(typeof(PrivateConstant));
            var noConstant = context.GetTypeDefinitionData(typeof(NoConstant));

            var breakingChanges = MetadataComparer.CompareTypes(publicConstant, noConstant);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a public constant is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicConstant)).GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoConstant)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedConstant, noConstant);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected constant is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedConstant)).GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoConstant)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalConstant, noConstant);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected internal constant is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalConstant)).GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoConstant)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(internalConstant, noConstant);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an internal constant is removed");
            breakingChanges = MetadataComparer.CompareTypes(privateConstant, noConstant);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a private constant is removed");

            breakingChanges = MetadataComparer.CompareTypes(noConstant, publicConstant);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a public constant is added");
            breakingChanges = MetadataComparer.CompareTypes(noConstant, protectedConstant);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected constant is added");
            breakingChanges = MetadataComparer.CompareTypes(noConstant, protectedInternalConstant);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal constant is added");
            breakingChanges = MetadataComparer.CompareTypes(noConstant, internalConstant);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal constant is added");
            breakingChanges = MetadataComparer.CompareTypes(noConstant, privateConstant);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal constant is added");

            var EnumWithTwoMembers = context.GetTypeDefinitionData(typeof(EnumWithTwoMembers));
            var EnumWithOneMember = context.GetTypeDefinitionData(typeof(EnumWithOneMember));
            breakingChanges = MetadataComparer.CompareTypes(EnumWithTwoMembers, EnumWithOneMember);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a public constant is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(EnumWithTwoMembers.GetMember("Y"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(EnumWithOneMember, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(EnumWithOneMember, EnumWithTwoMembers);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a public constant is added");
        }

        #endregion // ConstantTests

        #region ConstructorTests

        [Fact]
        public void ConstructorTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var publicConstructor = context.GetTypeDefinitionData(typeof(PublicConstructor));
            var protectedConstructor = context.GetTypeDefinitionData(typeof(ProtectedConstructor));
            var protectedInternalConstructor = context.GetTypeDefinitionData(typeof(ProtectedInternalConstructor));
            var internalConstructor = context.GetTypeDefinitionData(typeof(InternalConstructor));
            var privateConstructor = context.GetTypeDefinitionData(typeof(PrivateConstructor));
            var noConstructor = context.GetTypeDefinitionData(typeof(NoConstructor));

            var breakingChanges = MetadataComparer.CompareTypes(publicConstructor, noConstructor);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a public constructor is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicConstructor)).GetMembers(".ctor")[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoConstructor)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedConstructor, noConstructor);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected constructor is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedConstructor)).GetMembers(".ctor")[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoConstructor)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalConstructor, noConstructor);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected internal constructor is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalConstructor)).GetMembers(".ctor")[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoConstructor)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(internalConstructor, noConstructor);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an internal constructor is removed");
            breakingChanges = MetadataComparer.CompareTypes(privateConstructor, noConstructor);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a private constructor is removed");

            breakingChanges = MetadataComparer.CompareTypes(noConstructor, publicConstructor);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a public constructor is added");
            breakingChanges = MetadataComparer.CompareTypes(noConstructor, protectedConstructor);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected constructor is added");
            breakingChanges = MetadataComparer.CompareTypes(noConstructor, protectedInternalConstructor);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal constructor is added");
            breakingChanges = MetadataComparer.CompareTypes(noConstructor, internalConstructor);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal constructor is added");
            breakingChanges = MetadataComparer.CompareTypes(noConstructor, privateConstructor);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal constructor is added");
        }

        #endregion // ConstructorTests

        #region EventTests

        [Fact]
        public void EventTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var publicEvent = context.GetTypeDefinitionData(typeof(PublicEvent));
            var protectedEvent = context.GetTypeDefinitionData(typeof(ProtectedEvent));
            var protectedInternalEvent = context.GetTypeDefinitionData(typeof(ProtectedInternalEvent));
            var internalEvent = context.GetTypeDefinitionData(typeof(InternalEvent));
            var privateEvent = context.GetTypeDefinitionData(typeof(PrivateEvent));
            var noEvent = context.GetTypeDefinitionData(typeof(NoEvent));

            var breakingChanges = MetadataComparer.CompareTypes(publicEvent, noEvent);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a public event is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicEvent)).GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoEvent)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedEvent, noEvent);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected event is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedEvent)).GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoEvent)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalEvent, noEvent);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected internal event is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalEvent)).GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoEvent)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(internalEvent, noEvent);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an internal event is removed");
            breakingChanges = MetadataComparer.CompareTypes(privateEvent, noEvent);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a private event is removed");

            breakingChanges = MetadataComparer.CompareTypes(noEvent, publicEvent);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a public event is added");
            breakingChanges = MetadataComparer.CompareTypes(noEvent, protectedEvent);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected event is added");
            breakingChanges = MetadataComparer.CompareTypes(noEvent, protectedInternalEvent);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal event is added");
            breakingChanges = MetadataComparer.CompareTypes(noEvent, internalEvent);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal event is added");
            breakingChanges = MetadataComparer.CompareTypes(noEvent, privateEvent);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal event is added");
        }

        #endregion // EventTests

        #region FieldTests

        [Fact]
        public void FieldTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var publicField = context.GetTypeDefinitionData(typeof(PublicField));
            var protectedField = context.GetTypeDefinitionData(typeof(ProtectedField));
            var protectedInternalField = context.GetTypeDefinitionData(typeof(ProtectedInternalField));
            var internalField = context.GetTypeDefinitionData(typeof(InternalField));
            var privateField = context.GetTypeDefinitionData(typeof(PrivateField));
            var noField = context.GetTypeDefinitionData(typeof(NoField));

            var breakingChanges = MetadataComparer.CompareTypes(publicField, noField);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a public field is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicField)).GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoField)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedField, noField);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected field is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedField)).GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoField)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalField, noField);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected internal field is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalField)).GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoField)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(internalField, noField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an internal field is removed");
            breakingChanges = MetadataComparer.CompareTypes(privateField, noField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a private field is removed");

            breakingChanges = MetadataComparer.CompareTypes(noField, publicField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a public field is added");
            breakingChanges = MetadataComparer.CompareTypes(noField, protectedField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected field is added");
            breakingChanges = MetadataComparer.CompareTypes(noField, protectedInternalField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal field is added");
            breakingChanges = MetadataComparer.CompareTypes(noField, internalField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal field is added");
            breakingChanges = MetadataComparer.CompareTypes(noField, privateField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal field is added");
        }

        #endregion // FieldTests

        #region IndexerTests

        [Fact]
        public void IndexerTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var publicIndexer = context.GetTypeDefinitionData(typeof(PublicIndexer));
            var protectedIndexer = context.GetTypeDefinitionData(typeof(ProtectedIndexer));
            var protectedInternalIndexer = context.GetTypeDefinitionData(typeof(ProtectedInternalIndexer));
            var internalIndexer = context.GetTypeDefinitionData(typeof(InternalIndexer));
            var privateIndexer = context.GetTypeDefinitionData(typeof(PrivateIndexer));
            var noIndexer = context.GetTypeDefinitionData(typeof(NoIndexer));

            var breakingChanges = MetadataComparer.CompareTypes(publicIndexer, noIndexer);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a public indexer is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicIndexer)).GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoIndexer)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedIndexer, noIndexer);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected indexer is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedIndexer)).GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoIndexer)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalIndexer, noIndexer);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected internal indexer is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalIndexer)).GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoIndexer)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(internalIndexer, noIndexer);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an internal indexer is removed");
            breakingChanges = MetadataComparer.CompareTypes(privateIndexer, noIndexer);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a private indexer is removed");

            breakingChanges = MetadataComparer.CompareTypes(noIndexer, publicIndexer);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a public indexer is added");
            breakingChanges = MetadataComparer.CompareTypes(noIndexer, protectedIndexer);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected indexer is added");
            breakingChanges = MetadataComparer.CompareTypes(noIndexer, protectedInternalIndexer);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal indexer is added");
            breakingChanges = MetadataComparer.CompareTypes(noIndexer, internalIndexer);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal indexer is added");
            breakingChanges = MetadataComparer.CompareTypes(noIndexer, privateIndexer);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal indexer is added");
        }

        #endregion // IndexerTests

        #region MethodTests

        [Fact]
        public void MethodTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var publicMethod = context.GetTypeDefinitionData(typeof(PublicMethod));
            var protectedMethod = context.GetTypeDefinitionData(typeof(ProtectedMethod));
            var protectedInternalMethod = context.GetTypeDefinitionData(typeof(ProtectedInternalMethod));
            var internalMethod = context.GetTypeDefinitionData(typeof(InternalMethod));
            var privateMethod = context.GetTypeDefinitionData(typeof(PrivateMethod));
            var noMethod = context.GetTypeDefinitionData(typeof(NoMethod));

            var breakingChanges = MetadataComparer.CompareTypes(publicMethod, noMethod);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a public method is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicMethod)).GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoMethod)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedMethod, noMethod);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected method is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedMethod)).GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoMethod)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalMethod, noMethod);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected internal method is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalMethod)).GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoMethod)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(internalMethod, noMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an internal method is removed");
            breakingChanges = MetadataComparer.CompareTypes(privateMethod, noMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a private method is removed");

            breakingChanges = MetadataComparer.CompareTypes(noMethod, publicMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a public method is added");
            breakingChanges = MetadataComparer.CompareTypes(noMethod, protectedMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected method is added");
            breakingChanges = MetadataComparer.CompareTypes(noMethod, protectedInternalMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal method is added");
            breakingChanges = MetadataComparer.CompareTypes(noMethod, internalMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal method is added");
            breakingChanges = MetadataComparer.CompareTypes(noMethod, privateMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal method is added");

            var InterfaceWithMethod = context.GetTypeDefinitionData(typeof(InterfaceWithMethod));
            var InterfaceWithoutMethod = context.GetTypeDefinitionData(typeof(InterfaceWithoutMethod));
            breakingChanges = MetadataComparer.CompareTypes(InterfaceWithMethod, InterfaceWithoutMethod);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a public method is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(InterfaceWithMethod.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(InterfaceWithoutMethod, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(InterfaceWithoutMethod, InterfaceWithMethod).Where(b => b.BreakingChangeKind == BreakingChangeKind.RemovedMember).ToList();
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a public method is added");

            var StructWithMethod = context.GetTypeDefinitionData(typeof(StructWithMethod));
            var StructWithoutMethod = context.GetTypeDefinitionData(typeof(StructWithoutMethod));
            breakingChanges = MetadataComparer.CompareTypes(StructWithMethod, StructWithoutMethod);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a public method is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(StructWithMethod.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(StructWithoutMethod, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(StructWithoutMethod, StructWithMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a public method is added");

            var DerivedClassWithMethod = context.GetTypeDefinitionData(typeof(DerivedClassWithMethod));
            breakingChanges = MetadataComparer.CompareTypes(publicMethod, DerivedClassWithMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a public method is added");
        }

        public class BaseClassWithMethod { public void Method() { } }
        public class DerivedClassWithMethod : BaseClassWithMethod { }

        #endregion // MethodTests

        #region OperatorTests

        [Fact]
        public void OperatorTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var publicOperator = context.GetTypeDefinitionData(typeof(PublicOperator));
            var noOperator = context.GetTypeDefinitionData(typeof(NoOperator));

            var breakingChanges = MetadataComparer.CompareTypes(publicOperator, noOperator);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a public operator is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicOperator)).GetMember("op_Addition"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoOperator)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(noOperator, publicOperator);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a public operator is added");
        }

        #endregion // OperatorTests

        #region RemovingOverrideInNonBreaking

        [Fact]
        public void RemovingOverrideInNonBreaking()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var ClassWithOverride = context.GetTypeDefinitionData(typeof(ClassWithOverride));
            var ClassWithoutOverride = context.GetTypeDefinitionData(typeof(ClassWithoutOverride));

            var breakingChanges = MetadataComparer.CompareTypes(ClassWithOverride, ClassWithoutOverride);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when removing an override of a virtual method");
        }

        #endregion // RemovingOverrideInNonBreaking

        #region PropertyTests

        [Fact]
        public void PropertyTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var publicProperty = context.GetTypeDefinitionData(typeof(PublicProperty));
            var protectedProperty = context.GetTypeDefinitionData(typeof(ProtectedProperty));
            var protectedInternalProperty = context.GetTypeDefinitionData(typeof(ProtectedInternalProperty));
            var internalProperty = context.GetTypeDefinitionData(typeof(InternalProperty));
            var privateProperty = context.GetTypeDefinitionData(typeof(PrivateProperty));
            var noProperty = context.GetTypeDefinitionData(typeof(NoProperty));

            var breakingChanges = MetadataComparer.CompareTypes(publicProperty, noProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a public property is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicProperty)).GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoProperty)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedProperty, noProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected property is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedProperty)).GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoProperty)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalProperty, noProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected internal property is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalProperty)).GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoProperty)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(internalProperty, noProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an internal property is removed");
            breakingChanges = MetadataComparer.CompareTypes(privateProperty, noProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a private property is removed");

            breakingChanges = MetadataComparer.CompareTypes(noProperty, publicProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a public property is added");
            breakingChanges = MetadataComparer.CompareTypes(noProperty, protectedProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected property is added");
            breakingChanges = MetadataComparer.CompareTypes(noProperty, protectedInternalProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal property is added");
            breakingChanges = MetadataComparer.CompareTypes(noProperty, internalProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal property is added");
            breakingChanges = MetadataComparer.CompareTypes(noProperty, privateProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal property is added");
        }

        #endregion // PropertyTests

        #region NestedTypeTests

        [Fact]
        public void NestedTypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var publicNestedType = context.GetTypeDefinitionData(typeof(PublicNestedType));
            var protectedNestedType = context.GetTypeDefinitionData(typeof(ProtectedNestedType));
            var protectedInternalNestedType = context.GetTypeDefinitionData(typeof(ProtectedInternalNestedType));
            var internalNestedType = context.GetTypeDefinitionData(typeof(InternalNestedType));
            var privateNestedType = context.GetTypeDefinitionData(typeof(PrivateNestedType));
            var noNestedType = context.GetTypeDefinitionData(typeof(NoNestedType));

            var breakingChanges = MetadataComparer.CompareTypes(publicNestedType, noNestedType);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a public nested type is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicNestedType)).GetMember("NestedType"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoNestedType)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedNestedType, noNestedType);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected nested type is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedNestedType)).GetMember("NestedType"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoNestedType)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalNestedType, noNestedType);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a protected internal nested type is removed");
            AssertX.Equal(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalNestedType)).GetMember("NestedType"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Null(breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(NoNestedType)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(internalNestedType, noNestedType);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an internal nested type is removed");
            breakingChanges = MetadataComparer.CompareTypes(privateNestedType, noNestedType);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a private nested type is removed");

            breakingChanges = MetadataComparer.CompareTypes(noNestedType, publicNestedType);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a public nested type is added");
            breakingChanges = MetadataComparer.CompareTypes(noNestedType, protectedNestedType);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected nested type is added");
            breakingChanges = MetadataComparer.CompareTypes(noNestedType, protectedInternalNestedType);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal nested type is added");
            breakingChanges = MetadataComparer.CompareTypes(noNestedType, internalNestedType);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal nested type is added");
            breakingChanges = MetadataComparer.CompareTypes(noNestedType, privateNestedType);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a protected internal nested type is added");
        }

        #endregion // NestedTypeTests


        public class ExplicitInterfaceMember : IEquatable<int> { bool IEquatable<int>.Equals(int other) { return false; } }
        public class ImplicitInterfaceMember : IEquatable<int> { public bool Equals(int other) { return false; } }

        public class ClassWithOverride { public override string ToString() { return "X"; } }
        public class ClassWithoutOverride { }

        public enum EnumWithTwoMembers { X, Y }
        public enum EnumWithOneMember { X }

        public interface InterfaceWithMethod { void Method(); }
        public interface InterfaceWithoutMethod { }

        public struct StructWithMethod { public void Method() { } }
        public struct StructWithoutMethod { }



        public class ClassWithConstant { public const int Data = 0; }

        public class ClassWithReadOnlyField { public readonly int Data; }
        public class ClassWithReadWriteField { public int Data; }
        public class ClassWithReadOnlyProperty { public int Data { get { return 0; } } }
        public class ClassWithReadWriteProperty { public int Data { get; set; } }
        public class ClassWithWriteOnlyProperty { public int Data { set { } } }
        public class ClassWithVirtualProperty { public virtual int Data { get { return 0; } } }
        public class ClassWithSealedOverrideProperty : ClassWithVirtualProperty { public sealed override int Data { get { return 0; } } }

        public class ClassWithStaticReadOnlyField { public static readonly int Data; }
        public class ClassWithStaticReadWriteField { public static int Data; }
        public class ClassWithStaticReadOnlyProperty { public static int Data { get { return 0; } } }
        public class ClassWithStaticReadWriteProperty { public static int Data { get; set; } }
        public class ClassWithStaticWriteOnlyProperty { public static int Data { set { } } }

        public class ClassWithReadOnlyProtectedField { protected readonly int Data; }
        public class ClassWithReadOnlyProtectedProperty { protected int Data { get { return 0; } } }
        public class ClassWithProtectedGetProperty { public int Data { protected get; set; } }

        public class ClassWithStaticReadOnlyProtectedProperty { protected static int Data { get { return 0; } } }
        public class ClassWithStaticProtectedGetProperty { public static int Data { protected get; set; } }
    }
}

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
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class ChangedGenericTypeParameterConstraintsTests
    {
        #region MethodTests

        [Fact]
        public void MethodTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var methodWithNoConstraints = context.GetTypeDefinitionData(typeof(MethodWithNoConstraints));
            var methodWithNewConstraint = context.GetTypeDefinitionData(typeof(MethodWithNewConstraint));
            var methodWithStructConstraint = context.GetTypeDefinitionData(typeof(MethodWithStructConstraint));
            var methodWithClassConstraint = context.GetTypeDefinitionData(typeof(MethodWithClassConstraint));
            var methodWithClassNewConstraints = context.GetTypeDefinitionData(typeof(MethodWithClassNewConstraints));
            var methodWithBaseInterfaceConstraint = context.GetTypeDefinitionData(typeof(MethodWithBaseInterfaceConstraint));
            var methodWithDerivedInterfaceConstraint = context.GetTypeDefinitionData(typeof(MethodWithDerivedInterfaceConstraint));
            var methodWithBaseTypeContraint = context.GetTypeDefinitionData(typeof(MethodWithBaseTypeContraint));

            var breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithNewConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithNewConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithStructConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithStructConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithClassConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithClassConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithClassNewConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithClassNewConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithBaseInterfaceConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithBaseInterfaceConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithDerivedInterfaceConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithDerivedInterfaceConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithBaseTypeContraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithBaseTypeContraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            // Do the same tests in reverse order
            breakingChanges = MetadataComparer.CompareTypes(methodWithNewConstraint, methodWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithNewConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithStructConstraint, methodWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithStructConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithClassConstraint, methodWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithClassConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithClassNewConstraints, methodWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithClassNewConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithBaseInterfaceConstraint, methodWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithBaseInterfaceConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithDerivedInterfaceConstraint, methodWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithDerivedInterfaceConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(methodWithBaseTypeContraint, methodWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(((MethodData)methodWithBaseTypeContraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // MethodTests

        #region NestedTypeTests

        [Fact]
        public void NestedTypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var nestedClassWithNoConstraints = context.GetTypeDefinitionData(typeof(NestedClassWithNoConstraints));
            var nestedClassWithNewConstraint = context.GetTypeDefinitionData(typeof(NestedClassWithNewConstraint));
            var nestedClassWithStructConstraint = context.GetTypeDefinitionData(typeof(NestedClassWithStructConstraint));
            var nestedClassWithClassConstraint = context.GetTypeDefinitionData(typeof(NestedClassWithClassConstraint));
            var nestedClassWithClassNewConstraints = context.GetTypeDefinitionData(typeof(NestedClassWithClassNewConstraints));
            var nestedClassWithBaseInterfaceConstraint = context.GetTypeDefinitionData(typeof(NestedClassWithBaseInterfaceConstraint));
            var nestedClassWithDerivedInterfaceConstraint = context.GetTypeDefinitionData(typeof(NestedClassWithDerivedInterfaceConstraint));
            var nestedClassWithBaseTypeContraint = context.GetTypeDefinitionData(typeof(NestedClassWithBaseTypeContraint));

            var breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithNewConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithNewConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithStructConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithStructConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithClassConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithClassConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithClassNewConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithClassNewConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithBaseInterfaceConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithBaseInterfaceConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithDerivedInterfaceConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithDerivedInterfaceConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithBaseTypeContraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithBaseTypeContraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            // Do the same tests in reverse order
            breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNewConstraint, nestedClassWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithNewConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassWithStructConstraint, nestedClassWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithStructConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassWithClassConstraint, nestedClassWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithClassConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassWithClassNewConstraints, nestedClassWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithClassNewConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassWithBaseInterfaceConstraint, nestedClassWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithBaseInterfaceConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassWithDerivedInterfaceConstraint, nestedClassWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithDerivedInterfaceConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedClassWithBaseTypeContraint, nestedClassWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedClassWithBaseTypeContraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // NestedTypeTests

        #region TypeTests

        [Fact]
        public void TypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var classWithNoConstraints = context.GetTypeDefinitionData(typeof(ClassWithNoConstraints<>));
            var classWithNewConstraint = context.GetTypeDefinitionData(typeof(ClassWithNewConstraint<>));
            var classWithStructConstraint = context.GetTypeDefinitionData(typeof(ClassWithStructConstraint<>));
            var classWithClassConstraint = context.GetTypeDefinitionData(typeof(ClassWithClassConstraint<>));
            var classWithClassNewConstraints = context.GetTypeDefinitionData(typeof(ClassWithClassNewConstraints<>));
            var classWithBaseInterfaceConstraint = context.GetTypeDefinitionData(typeof(ClassWithBaseInterfaceConstraint<>));
            var classWithDerivedInterfaceConstraint = context.GetTypeDefinitionData(typeof(ClassWithDerivedInterfaceConstraint<>));
            var classWithBaseTypeContraint = context.GetTypeDefinitionData(typeof(ClassWithBaseTypeContraint<>));

            var breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithNewConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithNewConstraint.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithStructConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithStructConstraint.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithClassConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithClassConstraint.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithClassNewConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithClassNewConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithBaseInterfaceConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithBaseInterfaceConstraint.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithDerivedInterfaceConstraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithDerivedInterfaceConstraint.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithBaseTypeContraint);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithBaseTypeContraint.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            // Do the same tests in reverse order
            breakingChanges = MetadataComparer.CompareTypes(classWithNewConstraint, classWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithNewConstraint.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classWithStructConstraint, classWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithStructConstraint.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classWithClassConstraint, classWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithClassConstraint.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classWithClassNewConstraints, classWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithClassNewConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classWithBaseInterfaceConstraint, classWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithBaseInterfaceConstraint.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classWithDerivedInterfaceConstraint, classWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithDerivedInterfaceConstraint.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(classWithBaseTypeContraint, classWithNoConstraints);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
            AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(classWithBaseTypeContraint.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // TypeTests

        public class NestedClassWithNoConstraints { public class Class<T> { } }
        public class NestedClassWithNewConstraint { public class Class<T> where T : new() { } }
        public class NestedClassWithStructConstraint { public class Class<T> where T : struct { } }
        public class NestedClassWithClassConstraint { public class Class<T> where T : class { } }
        public class NestedClassWithClassNewConstraints { public class Class<T> where T : class, new() { } }
        public class NestedClassWithBaseInterfaceConstraint { public class Class<T> where T : BaseInterface { } }
        public class NestedClassWithDerivedInterfaceConstraint { public class Class<T> where T : DerivedInterface { } }
        public class NestedClassWithBaseTypeContraint { public class Class<T> where T : Attribute { } }


        public class ClassWithNoConstraints<T> { }
        public class ClassWithNewConstraint<T> where T : new() { }
        public class ClassWithStructConstraint<T> where T : struct { }
        public class ClassWithClassConstraint<T> where T : class { }
        public class ClassWithClassNewConstraints<T> where T : class, new() { }
        public class ClassWithBaseInterfaceConstraint<T> where T : BaseInterface { }
        public class ClassWithDerivedInterfaceConstraint<T> where T : DerivedInterface { }
        public class ClassWithBaseTypeContraint<T> where T : Attribute { }

        public class MethodWithNoConstraints { public void Method<T>() { } }
        public class MethodWithNewConstraint { public void Method<T>() where T : new() { } }
        public class MethodWithStructConstraint { public void Method<T>() where T : struct { } }
        public class MethodWithClassConstraint { public void Method<T>() where T : class { } }
        public class MethodWithClassNewConstraints { public void Method<T>() where T : class, new() { } }
        public class MethodWithBaseInterfaceConstraint { public void Method<T>() where T : BaseInterface { } }
        public class MethodWithDerivedInterfaceConstraint { public void Method<T>() where T : DerivedInterface { } }
        public class MethodWithBaseTypeContraint { public void Method<T>() where T : Attribute { } }
    }
}

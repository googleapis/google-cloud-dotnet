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

using BreakingChangesDetector.BreakingChanges;
using BreakingChangesDetector.MetadataItems;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
    public class ChangedAccessibilityFromPublicToProtectedTests
    {
        #region ConstantTests

        [Fact]
        public void ConstantTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var publicConstant = context.GetTypeDefinitionData(typeof(PublicConstant));
            var protectedConstant = context.GetTypeDefinitionData(typeof(ProtectedConstant));
            var protectedInternalConstant = context.GetTypeDefinitionData(typeof(ProtectedInternalConstant));

            var breakingChanges = MetadataComparer.CompareTypes(publicConstant, protectedConstant);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicConstant)).GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedConstant)).GetMember("Constant"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(publicConstant, protectedInternalConstant);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected internal");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicConstant)).GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalConstant)).GetMember("Constant"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedConstant, publicConstant);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed from protected to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedConstant, protectedInternalConstant);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed from protected to protected internal");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalConstant, publicConstant);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed from protected internal to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalConstant, protectedConstant);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed from protected internal to protected");
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

            var breakingChanges = MetadataComparer.CompareTypes(publicConstructor, protectedConstructor);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicConstructor)).GetMembers(".ctor")[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedConstructor)).GetMembers(".ctor")[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(publicConstructor, protectedInternalConstructor);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constructor is changed from public to protected internal");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicConstructor)).GetMembers(".ctor")[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalConstructor)).GetMembers(".ctor")[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedConstructor, publicConstructor);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a constructor is changed from protected to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedConstructor, protectedInternalConstructor);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a constructor is changed from protected to protected internal");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalConstructor, publicConstructor);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a constructor is changed from protected internal to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalConstructor, protectedConstructor);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a constructor is changed from protected internal to protected");
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

            var breakingChanges = MetadataComparer.CompareTypes(publicEvent, protectedEvent);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicEvent)).GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedEvent)).GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(publicEvent, protectedInternalEvent);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a event is changed from public to protected internal");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicEvent)).GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalEvent)).GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedEvent, publicEvent);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a event is changed from protected to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedEvent, protectedInternalEvent);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a event is changed from protected to protected internal");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalEvent, publicEvent);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a event is changed from protected internal to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalEvent, protectedEvent);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a event is changed from protected internal to protected");
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

            var breakingChanges = MetadataComparer.CompareTypes(publicField, protectedField);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicField)).GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedField)).GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(publicField, protectedInternalField);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a field is changed from public to protected internal");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicField)).GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalField)).GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedField, publicField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a field is changed from protected to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedField, protectedInternalField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a field is changed from protected to protected internal");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalField, publicField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a field is changed from protected internal to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalField, protectedField);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a field is changed from protected internal to protected");
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

            var breakingChanges = MetadataComparer.CompareTypes(publicIndexer, protectedIndexer);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicIndexer)).GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedIndexer)).GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(publicIndexer, protectedInternalIndexer);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a indexer is changed from public to protected internal");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicIndexer)).GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalIndexer)).GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedIndexer, publicIndexer);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a indexer is changed from protected to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedIndexer, protectedInternalIndexer);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a indexer is changed from protected to protected internal");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalIndexer, publicIndexer);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a indexer is changed from protected internal to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalIndexer, protectedIndexer);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a indexer is changed from protected internal to protected");
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

            var breakingChanges = MetadataComparer.CompareTypes(publicMethod, protectedMethod);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicMethod)).GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedMethod)).GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(publicMethod, protectedInternalMethod);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a method is changed from public to protected internal");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicMethod)).GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalMethod)).GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedMethod, publicMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a method is changed from protected to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedMethod, protectedInternalMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a method is changed from protected to protected internal");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalMethod, publicMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a method is changed from protected internal to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalMethod, protectedMethod);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a method is changed from protected internal to protected");
        }

        #endregion // MethodTests

        #region PropertyTests

        [Fact]
        public void PropertyTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var publicProperty = context.GetTypeDefinitionData(typeof(PublicProperty));
            var protectedProperty = context.GetTypeDefinitionData(typeof(ProtectedProperty));
            var protectedInternalProperty = context.GetTypeDefinitionData(typeof(ProtectedInternalProperty));

            var breakingChanges = MetadataComparer.CompareTypes(publicProperty, protectedProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicProperty)).GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedProperty)).GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(publicProperty, protectedInternalProperty);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a property is changed from public to protected internal");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicProperty)).GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalProperty)).GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedProperty, publicProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a property is changed from protected to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedProperty, protectedInternalProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a property is changed from protected to protected internal");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalProperty, publicProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a property is changed from protected internal to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalProperty, protectedProperty);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a property is changed from protected internal to protected");
        }

        #endregion // PropertyTests

        #region TypeTests

        [Fact]
        public void TypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
            var publicNestedType = context.GetTypeDefinitionData(typeof(PublicNestedType));
            var protectedNestedType = context.GetTypeDefinitionData(typeof(ProtectedNestedType));
            var protectedInternalNestedType = context.GetTypeDefinitionData(typeof(ProtectedInternalNestedType));

            var breakingChanges = MetadataComparer.CompareTypes(publicNestedType, protectedNestedType);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a nested type is changed from public to protected");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicNestedType.NestedType)), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedNestedType)).GetMember("NestedType"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(publicNestedType, protectedInternalNestedType);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when a nested type is changed from public to protected internal");
            AssertX.Equal(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(PublicNestedType.NestedType)), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(context.GetTypeDefinitionData(typeof(ProtectedInternalNestedType.NestedType)), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(protectedNestedType, publicNestedType);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a nested type is changed from protected to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedNestedType, protectedInternalNestedType);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a nested type is changed from protected to protected internal");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalNestedType, publicNestedType);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a nested type is changed from protected internal to public");

            breakingChanges = MetadataComparer.CompareTypes(protectedInternalNestedType, protectedNestedType);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a nested type is changed from protected internal to protected");
        }

        #endregion // TypeTests
    }
}

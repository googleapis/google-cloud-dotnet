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
    public class ChangedParameterCountTests
    {
        #region ConstructorTests

        [Fact]
        public void ConstructorTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterCountTests));
            var ConstructorWithFewerParameters = context.GetTypeDefinitionData(typeof(ConstructorWithFewerParameters));
            var ConstructorWithMoreParameters = context.GetTypeDefinitionData(typeof(ConstructorWithMoreParameters));
            var ConstructorWithOptionalParameter = context.GetTypeDefinitionData(typeof(ConstructorWithOptionalParameter));
            var ConstructorWithParamsParameter = context.GetTypeDefinitionData(typeof(ConstructorWithParamsParameter));

            var breakingChanges = MetadataComparer.CompareTypes(ConstructorWithFewerParameters, ConstructorWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ConstructorWithFewerParameters.GetMember(".ctor"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(ConstructorWithMoreParameters.GetMember(".ctor"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ConstructorWithMoreParameters, ConstructorWithFewerParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ConstructorWithMoreParameters.GetMember(".ctor"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(ConstructorWithFewerParameters.GetMember(".ctor"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ConstructorWithMoreParameters, ConstructorWithOptionalParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a required parameter is made optional.");

            breakingChanges = MetadataComparer.CompareTypes(ConstructorWithFewerParameters, ConstructorWithOptionalParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an optional parameter is added.");

            breakingChanges = MetadataComparer.CompareTypes(ConstructorWithOptionalParameter, ConstructorWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ConstructorWithOptionalParameter.GetMember(".ctor"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(ConstructorWithMoreParameters.GetMember(".ctor"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ConstructorWithFewerParameters, ConstructorWithParamsParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an params parameter is added.");

            breakingChanges = MetadataComparer.CompareTypes(ConstructorWithParamsParameter, ConstructorWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(ConstructorWithParamsParameter.GetMember(".ctor"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(ConstructorWithMoreParameters.GetMember(".ctor"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // ConstructorTests

        #region IndexerTests

        [Fact]
        public void IndexerTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterCountTests));
            var IndexerWithFewerParameters = context.GetTypeDefinitionData(typeof(IndexerWithFewerParameters));
            var IndexerWithMoreParameters = context.GetTypeDefinitionData(typeof(IndexerWithMoreParameters));
            var IndexerWithOptionalParameter = context.GetTypeDefinitionData(typeof(IndexerWithOptionalParameter));
            var IndexerWithParamsParameter = context.GetTypeDefinitionData(typeof(IndexerWithParamsParameter));

            var breakingChanges = MetadataComparer.CompareTypes(IndexerWithFewerParameters, IndexerWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(IndexerWithFewerParameters.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(IndexerWithMoreParameters.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithMoreParameters, IndexerWithFewerParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(IndexerWithMoreParameters.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(IndexerWithFewerParameters.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithMoreParameters, IndexerWithOptionalParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a required parameter is made optional.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithFewerParameters, IndexerWithOptionalParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an optional parameter is added.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithOptionalParameter, IndexerWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(IndexerWithOptionalParameter.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(IndexerWithMoreParameters.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithFewerParameters, IndexerWithParamsParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an params parameter is added.");

            breakingChanges = MetadataComparer.CompareTypes(IndexerWithParamsParameter, IndexerWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(IndexerWithParamsParameter.GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(IndexerWithMoreParameters.GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // IndexerTests

        #region MethodTests

        [Fact]
        public void MethodTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterCountTests));
            var MethodWithFewerParameters = context.GetTypeDefinitionData(typeof(MethodWithFewerParameters));
            var MethodWithMoreParameters = context.GetTypeDefinitionData(typeof(MethodWithMoreParameters));
            var MethodWithOptionalParameter = context.GetTypeDefinitionData(typeof(MethodWithOptionalParameter));
            var MethodWithParamsParameter = context.GetTypeDefinitionData(typeof(MethodWithParamsParameter));

            var breakingChanges = MetadataComparer.CompareTypes(MethodWithFewerParameters, MethodWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(MethodWithFewerParameters.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(MethodWithMoreParameters.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithMoreParameters, MethodWithFewerParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(MethodWithMoreParameters.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(MethodWithFewerParameters.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithMoreParameters, MethodWithOptionalParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a required parameter is made optional.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithFewerParameters, MethodWithOptionalParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an optional parameter is added.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithOptionalParameter, MethodWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(MethodWithOptionalParameter.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(MethodWithMoreParameters.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithFewerParameters, MethodWithParamsParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an params parameter is added.");

            breakingChanges = MetadataComparer.CompareTypes(MethodWithParamsParameter, MethodWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(MethodWithParamsParameter.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(MethodWithMoreParameters.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // MethodTests

        #region NestedTypeTests

        [Fact]
        public void NestedTypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterCountTests));
            var nestedDelegateWithFewerParameters = context.GetTypeDefinitionData(typeof(NestedDelegateWithFewerParameters));
            var nestedDelegateWithMoreParameters = context.GetTypeDefinitionData(typeof(NestedDelegateWithMoreParameters));
            var nestedDelegateWithOptionalParameter = context.GetTypeDefinitionData(typeof(NestedDelegateWithOptionalParameter));
            var nestedDelegateWithParamsParameter = context.GetTypeDefinitionData(typeof(NestedDelegateWithParamsParameter));

            var breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithFewerParameters, nestedDelegateWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedDelegateWithFewerParameters.GetNestedType("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedDelegateWithMoreParameters.GetNestedType("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithMoreParameters, nestedDelegateWithFewerParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedDelegateWithMoreParameters.GetNestedType("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedDelegateWithFewerParameters.GetNestedType("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithMoreParameters, nestedDelegateWithOptionalParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a required parameter is made optional.");

            breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithFewerParameters, nestedDelegateWithOptionalParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an optional parameter is added.");

            breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithOptionalParameter, nestedDelegateWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedDelegateWithOptionalParameter.GetNestedType("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedDelegateWithMoreParameters.GetNestedType("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithFewerParameters, nestedDelegateWithParamsParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an params parameter is added.");

            breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithParamsParameter, nestedDelegateWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(nestedDelegateWithParamsParameter.GetNestedType("Delegate"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(nestedDelegateWithMoreParameters.GetNestedType("Delegate"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // NestedTypeTests

        #region TypeTests

        [Fact]
        public void TypeTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterCountTests));
            var DelegateWithFewerParameters = context.GetTypeDefinitionData(typeof(DelegateWithFewerParameters));
            var DelegateWithMoreParameters = context.GetTypeDefinitionData(typeof(DelegateWithMoreParameters));
            var DelegateWithOptionalParameter = context.GetTypeDefinitionData(typeof(DelegateWithOptionalParameter));
            var DelegateWithParamsParameter = context.GetTypeDefinitionData(typeof(DelegateWithParamsParameter));

            var breakingChanges = MetadataComparer.CompareTypes(DelegateWithFewerParameters, DelegateWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithFewerParameters, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithMoreParameters, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithMoreParameters, DelegateWithFewerParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithMoreParameters, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithFewerParameters, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithMoreParameters, DelegateWithOptionalParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a required parameter is made optional.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithFewerParameters, DelegateWithOptionalParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an optional parameter is added.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithOptionalParameter, DelegateWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithOptionalParameter, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithMoreParameters, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithFewerParameters, DelegateWithParamsParameter);
            AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when an params parameter is added.");

            breakingChanges = MetadataComparer.CompareTypes(DelegateWithParamsParameter, DelegateWithMoreParameters);
            AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the required parameter count changes.");
            AssertX.Equal(BreakingChangeKind.ChangedParameterCount, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
            AssertX.Equal(DelegateWithParamsParameter, breakingChanges[0].OldItem, "The OldItem is incorrect.");
            AssertX.Equal(DelegateWithMoreParameters, breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
        }

        #endregion // TypeTests

        public class NestedDelegateWithFewerParameters { public delegate void Delegate(int x); }
        public class NestedDelegateWithMoreParameters { public delegate void Delegate(int x, int[] y); }
        public class NestedDelegateWithOptionalParameter { public delegate void Delegate(int x, int[] y = null); }
        public class NestedDelegateWithParamsParameter { public delegate void Delegate(int x, params int[] y); }

        public delegate void DelegateWithFewerParameters(int x);
        public delegate void DelegateWithMoreParameters(int x, int[] y);
        public delegate void DelegateWithOptionalParameter(int x, int[] y = null);
        public delegate void DelegateWithParamsParameter(int x, params int[] y);

        public class ConstructorWithFewerParameters { public ConstructorWithFewerParameters(int x) { } }
        public class ConstructorWithMoreParameters { public ConstructorWithMoreParameters(int x, int[] y) { } }
        public class ConstructorWithOptionalParameter { public ConstructorWithOptionalParameter(int x, int[] y = null) { } }
        public class ConstructorWithParamsParameter { public ConstructorWithParamsParameter(int x, params int[] y) { } }

        public class IndexerWithFewerParameters { public int this[int x] { get { return 0; } } }
        public class IndexerWithMoreParameters { public int this[int x, int[] y] { get { return 0; } } }
        public class IndexerWithOptionalParameter { public int this[int x, int[] y = null] { get { return 0; } } }
        public class IndexerWithParamsParameter { public int this[int x, params int[] y] { get { return 0; } } }

        public class MethodWithFewerParameters { public void Method(int x) { } }
        public class MethodWithMoreParameters { public void Method(int x, int[] y) { } }
        public class MethodWithOptionalParameter { public void Method(int x, int[] y = null) { } }
        public class MethodWithParamsParameter { public void Method(int x, params int[] y) { } }
    }
}

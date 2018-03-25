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
	public class ChangedParameterModifierTests
	{
		#region ConstructorTests

		[Fact]
		public void ConstructorTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterModifierTests));
			var ConstructorWithUnmodifiedParameter = context.GetTypeDefinitionData(typeof(ConstructorWithUnmodifiedParameter));
			var ConstructorWithRefParameter = context.GetTypeDefinitionData(typeof(ConstructorWithRefParameter));
			var ConstructorWithOutParameter = context.GetTypeDefinitionData(typeof(ConstructorWithOutParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(ConstructorWithUnmodifiedParameter, ConstructorWithRefParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(((IParameterizedItem)ConstructorWithUnmodifiedParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(((IParameterizedItem)ConstructorWithRefParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(ConstructorWithRefParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithRefParameter, ConstructorWithUnmodifiedParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(((IParameterizedItem)ConstructorWithRefParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(((IParameterizedItem)ConstructorWithUnmodifiedParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(ConstructorWithUnmodifiedParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithUnmodifiedParameter, ConstructorWithOutParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(((IParameterizedItem)ConstructorWithUnmodifiedParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(((IParameterizedItem)ConstructorWithOutParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(ConstructorWithOutParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithOutParameter, ConstructorWithUnmodifiedParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(((IParameterizedItem)ConstructorWithOutParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(((IParameterizedItem)ConstructorWithUnmodifiedParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(ConstructorWithUnmodifiedParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithRefParameter, ConstructorWithOutParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(((IParameterizedItem)ConstructorWithRefParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(((IParameterizedItem)ConstructorWithOutParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(ConstructorWithOutParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ConstructorWithOutParameter, ConstructorWithRefParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(((IParameterizedItem)ConstructorWithOutParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(((IParameterizedItem)ConstructorWithRefParameter.GetMember(".ctor")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(ConstructorWithRefParameter.GetMember(".ctor"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ConstructorTests

		#region MethodTests

		[Fact]
		public void MethodTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterModifierTests));
			var MethodWithUnmodifiedParameter = context.GetTypeDefinitionData(typeof(MethodWithUnmodifiedParameter));
			var MethodWithRefParameter = context.GetTypeDefinitionData(typeof(MethodWithRefParameter));
			var MethodWithOutParameter = context.GetTypeDefinitionData(typeof(MethodWithOutParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(MethodWithUnmodifiedParameter, MethodWithRefParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(((IParameterizedItem)MethodWithUnmodifiedParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(((IParameterizedItem)MethodWithRefParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(MethodWithRefParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithRefParameter, MethodWithUnmodifiedParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(((IParameterizedItem)MethodWithRefParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(((IParameterizedItem)MethodWithUnmodifiedParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(MethodWithUnmodifiedParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithUnmodifiedParameter, MethodWithOutParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(((IParameterizedItem)MethodWithUnmodifiedParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(((IParameterizedItem)MethodWithOutParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(MethodWithOutParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithOutParameter, MethodWithUnmodifiedParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(((IParameterizedItem)MethodWithOutParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(((IParameterizedItem)MethodWithUnmodifiedParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(MethodWithUnmodifiedParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithRefParameter, MethodWithOutParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(((IParameterizedItem)MethodWithRefParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(((IParameterizedItem)MethodWithOutParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(MethodWithOutParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodWithOutParameter, MethodWithRefParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(((IParameterizedItem)MethodWithOutParameter.GetMember("Method")).Parameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(((IParameterizedItem)MethodWithRefParameter.GetMember("Method")).Parameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Equal(MethodWithRefParameter.GetMember("Method"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // MethodTests

		#region NestedTypeTests

		[Fact]
		public void NestedTypeTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterModifierTests));
			var NestedDelegateWithUnmodifiedParameter = context.GetTypeDefinitionData(typeof(NestedDelegateWithUnmodifiedParameter));
			var NestedDelegateWithRefParameter = context.GetTypeDefinitionData(typeof(NestedDelegateWithRefParameter));
			var NestedDelegateWithOutParameter = context.GetTypeDefinitionData(typeof(NestedDelegateWithOutParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithUnmodifiedParameter, NestedDelegateWithRefParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(NestedDelegateWithUnmodifiedParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(NestedDelegateWithRefParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(NestedDelegateWithRefParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithRefParameter, NestedDelegateWithUnmodifiedParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(NestedDelegateWithRefParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(NestedDelegateWithUnmodifiedParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(NestedDelegateWithUnmodifiedParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithUnmodifiedParameter, NestedDelegateWithOutParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(NestedDelegateWithUnmodifiedParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(NestedDelegateWithOutParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(NestedDelegateWithOutParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithOutParameter, NestedDelegateWithUnmodifiedParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(NestedDelegateWithOutParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(NestedDelegateWithUnmodifiedParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(NestedDelegateWithUnmodifiedParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithRefParameter, NestedDelegateWithOutParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(NestedDelegateWithRefParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(NestedDelegateWithOutParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(NestedDelegateWithOutParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(NestedDelegateWithOutParameter, NestedDelegateWithRefParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(NestedDelegateWithOutParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(NestedDelegateWithRefParameter.GetNestedType("Delegate").DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(NestedDelegateWithRefParameter.GetNestedType("Delegate"), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[Fact]
		public void TypeTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedParameterModifierTests));
			var DelegateWithUnmodifiedParameter = context.GetTypeDefinitionData(typeof(DelegateWithUnmodifiedParameter));
			var DelegateWithRefParameter = context.GetTypeDefinitionData(typeof(DelegateWithRefParameter));
			var DelegateWithOutParameter = context.GetTypeDefinitionData(typeof(DelegateWithOutParameter));
			
			var breakingChanges = MetadataComparer.CompareTypes(DelegateWithUnmodifiedParameter, DelegateWithRefParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(DelegateWithUnmodifiedParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(DelegateWithRefParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(DelegateWithRefParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithRefParameter, DelegateWithUnmodifiedParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(DelegateWithRefParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(DelegateWithUnmodifiedParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(DelegateWithUnmodifiedParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithUnmodifiedParameter, DelegateWithOutParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(DelegateWithUnmodifiedParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(DelegateWithOutParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(DelegateWithOutParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithOutParameter, DelegateWithUnmodifiedParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(DelegateWithOutParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(DelegateWithUnmodifiedParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(DelegateWithUnmodifiedParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithRefParameter, DelegateWithOutParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(DelegateWithRefParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(DelegateWithOutParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(DelegateWithOutParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(DelegateWithOutParameter, DelegateWithRefParameter);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when the parameter modifier changes.");
			AssertX.Equal(BreakingChangeKind.ChangedParameterModifier, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(DelegateWithOutParameter.DelegateParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(DelegateWithRefParameter.DelegateParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
            AssertX.Equal(DelegateWithRefParameter, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // TypeTests

		public class NestedDelegateWithUnmodifiedParameter { public delegate void Delegate(int x);}
		public class NestedDelegateWithRefParameter { public delegate void Delegate(ref int x);}
		public class NestedDelegateWithOutParameter { public delegate void Delegate(out int x);}

		public delegate void DelegateWithUnmodifiedParameter(int x);
		public delegate void DelegateWithRefParameter(ref int x);
		public delegate void DelegateWithOutParameter(out int x);

		public class ConstructorWithUnmodifiedParameter { public ConstructorWithUnmodifiedParameter(int x) { } }
		public class ConstructorWithRefParameter { public ConstructorWithRefParameter(ref int x) { } }
		public class ConstructorWithOutParameter { public ConstructorWithOutParameter(out int x) { x = 0; } }

		public class MethodWithUnmodifiedParameter { public void Method(int x) { } }
		public class MethodWithRefParameter { public void Method(ref int x) { } }
		public class MethodWithOutParameter { public void Method(out int x) { x = 0; } }
	}
}

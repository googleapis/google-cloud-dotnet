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
	public class ChangedStaticOrInstanceStatusTests
	{
		#region EventTests

		[TestMethod]
		public void EventTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var EventInstance = TypeDefinitionData.FromType(typeof(EventInstance));
			var EventStatic = TypeDefinitionData.FromType(typeof(EventStatic));
			
			var breakingChanges = MetadataComparer.CompareTypes(EventInstance, EventStatic);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an instance member changes to static.");
			Assert.AreEqual(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventInstance.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(EventStatic.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EventStatic, EventInstance);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a static member changes to instance.");
			Assert.AreEqual(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EventStatic.GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(EventInstance.GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // EventTests

		#region FieldTests

		[TestMethod]
		public void FieldTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var FieldInstance = TypeDefinitionData.FromType(typeof(FieldInstance));
			var FieldStatic = TypeDefinitionData.FromType(typeof(FieldStatic));
			
			var breakingChanges = MetadataComparer.CompareTypes(FieldInstance, FieldStatic);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an instance member changes to static.");
			Assert.AreEqual(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(FieldInstance.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(FieldStatic.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(FieldStatic, FieldInstance);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a static member changes to instance.");
			Assert.AreEqual(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(FieldStatic.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(FieldInstance.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // FieldTests

		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var MethodInstance = TypeDefinitionData.FromType(typeof(MethodInstance));
			var MethodStatic = TypeDefinitionData.FromType(typeof(MethodStatic));
			
			var breakingChanges = MetadataComparer.CompareTypes(MethodInstance, MethodStatic);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an instance member changes to static.");
			Assert.AreEqual(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodInstance.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodStatic.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(MethodStatic, MethodInstance);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a static member changes to instance.");
			Assert.AreEqual(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(MethodStatic.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(MethodInstance.GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // MethodTests

		#region PropertyTests

		[TestMethod]
		public void PropertyTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var PropertyInstance = TypeDefinitionData.FromType(typeof(PropertyInstance));
			var PropertyStatic = TypeDefinitionData.FromType(typeof(PropertyStatic));
			
			var breakingChanges = MetadataComparer.CompareTypes(PropertyInstance, PropertyStatic);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an instance member changes to static.");
			Assert.AreEqual(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyInstance.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyStatic.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyStatic, PropertyInstance);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a static member changes to instance.");
			Assert.AreEqual(BreakingChangeKind.ChangedStaticOrInstanceStatus, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyStatic.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyInstance.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // PropertyTests


#pragma warning disable 0067
		public class EventInstance { public event EventHandler<int> Event; }
		public class EventStatic { public static event EventHandler<int> Event; }
#pragma warning restore 0067

		public class FieldInstance { public int Field; }
		public class FieldStatic { public static int Field; }

		public class MethodInstance { public int Method() { return 0; } }
		public class MethodStatic { public static int Method() { return 0; } }

		public class PropertyInstance { public int Property { get { return 0; } } }
		public class PropertyStatic { public static int Property { get { return 0; } } }
	}
}

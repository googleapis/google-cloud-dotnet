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

#pragma warning disable 0067, 0169, 0414, 0649, 0660, 0661

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
	public class TestClassDefinitionBase : MarshalByRefObject
	{
	}

	internal interface InternalInterface { }

	public class TestClassDefinition : TestClassDefinitionBase,
		IEquatable<TestClassDefinition>,
		TestInterfaceDefinition,
		InternalInterface
	{
		public const int Constant = 1;
		internal const int ConstantInternal = 1;
		protected const int ConstantProtected = 1;
		protected internal const int ConstantProtectedInternal = 1;
		private const int ConstantPrivate = 1;

		public int FieldInstance = 1;
		internal int FieldInstanceInternal = 1;
		protected int FieldInstanceProtected = 1;
		protected internal int FieldInstanceProtectedInternal = 1;
		private int FieldInstancePrivate = 1;

		public static int FieldStatic = 1;
		internal static int FieldStaticInternal = 1;
		protected static int FieldStaticProtected = 1;
		protected internal static int FieldStaticProtectedInternal = 1;
		private static int FieldStaticPrivate = 1;

		public readonly int FieldReadOnlyInstance = 1;
		internal readonly int FieldReadOnlyInstanceInternal = 1;
		protected readonly int FieldReadOnlyInstanceProtected = 1;
		protected internal readonly int FieldReadOnlyInstanceProtectedInternal = 1;
		private readonly int FieldReadOnlyInstancePrivate = 1;

		public static readonly int FieldReadOnlyStatic = 1;
		internal static readonly int FieldReadOnlyStaticInternal = 1;
		protected static readonly int FieldReadOnlyStaticProtected = 1;
		protected internal static readonly int FieldReadOnlyStaticProtectedInternal = 1;
		private static readonly int FieldReadOnlyStaticPrivate = 1;

		public TestClassDefinition() { }
		internal TestClassDefinition(int p1) { }
		protected TestClassDefinition(int p1, int p2) { }
		protected internal TestClassDefinition(int p1, int p2, int p3) { }
		private TestClassDefinition(int p1, int p2, int p3, int p4) { }

		public event EventHandler EventInstance;
		internal event EventHandler EventInstanceInternal;
		protected event EventHandler EventInstanceProtected;
		protected internal event EventHandler EventInstanceProtectedInternal;
		private event EventHandler EventInstancePrivate;

		public static event EventHandler EventStatic;
		internal static event EventHandler EventStaticInternal;
		protected static event EventHandler EventStaticProtected;
		protected internal static event EventHandler EventStaticProtectedInternal;
		private static event EventHandler EventStaticPrivate;

		public event EventHandler EventCustomInstance { add { } remove { } }
		internal event EventHandler EventCustomInstanceInternal { add { } remove { } }
		protected event EventHandler EventCustomInstanceProtected { add { } remove { } }
		protected internal event EventHandler EventCustomInstanceProtectedInternal { add { } remove { } }
		private event EventHandler EventCustomInstancePrivate { add { } remove { } }

		public static event EventHandler EventCustomStatic { add { } remove { } }
		internal static event EventHandler EventCustomStaticInternal { add { } remove { } }
		protected static event EventHandler EventCustomStaticProtected { add { } remove { } }
		protected internal static event EventHandler EventCustomStaticProtectedInternal { add { } remove { } }
		private static event EventHandler EventCustomStaticPrivate { add { } remove { } }

		public object this[int x1] { get { return null; } }
		internal object this[int x1, int x2] { get { return null; } }
		protected object this[int x1, int x2, int x3] { get { return null; } }
		protected internal object this[int x1, int x2, int x3, int x4] { get { return null; } }
		private object this[int x1, int x2, int x3, int x4, int x5] { get { return null; } }

		public static List<int> MethodStatic() { return null; }
		internal static List<int> MethodStaticInternal() { return null; }
		protected static List<int> MethodStaticProtected() { return null; }
		protected internal static List<int> MethodStaticProtectedInternal() { return null; }
		private static List<int> MethodStaticPrivate() { return null; }

		public void MethodInstance() { }
		internal void MethodInstanceInternal(int x1) { }
		protected void MethodInstanceProtected(int x1, int x2) { }
		protected internal void MethodInstanceProtectedInternal(int x1, int x2, int x3) { }
		private void MethodInstancePrivate(int x1, int x2, int x3, int x4) { }

		public static TestClassDefinition operator +(TestClassDefinition a, int b) { return null; }

		public static int PropertyStatic { get { return 1; } }
		internal static int PropertyStaticInternal { get { return 1; } }
		protected static int PropertyStaticProtected { get { return 1; } }
		protected internal static int PropertyStaticProtectedInternal { get { return 1; } }
		private static int PropertyStaticPrivate { get { return 1; } }

		public string PropertyInstance { get { return "X"; } }
		internal string PropertyInstanceInternal { get { return "X"; } }
		protected string PropertyInstanceProtected { get { return "X"; } }
		protected internal string PropertyInstanceProtectedInternal { get { return "X"; } }
		private string PropertyInstancePrivate { get { return "X"; } }

		public struct NestedStruct
		{
			public TestClassDefinition RefToDeclaringType;
		}
		internal struct NestedStructInternal { }
		protected struct NestedStructProtected { }
		protected internal struct NestedStructProtectedInternal { }
		private struct NestedStructPrivate { }

		bool IEquatable<TestClassDefinition>.Equals(TestClassDefinition other) { return false; }
	}

	public class TestClassDefinition<T1, T2, T3, T4, T5>
		where T2 : IEquatable<TestClassDefinition>, TestInterfaceDefinition
		where T3 : class
		where T4 : struct
		where T5 : new()
	{
	}

	public class TestClassDefinitionPartiallyDerived<T1, T3, T5> : TestClassDefinition<T1, TestClassDefinition, T3, int, T5>
		where T3 : class
		where T5 : new()
	{
	}

	public interface TestInterfaceDefinition<T1, in T2, out T3> { }

	public struct TestStructDefinition
	{
		public const int Constant = 1;
		internal const int ConstantInternal = 1;
		private const int ConstantPrivate = 1;

		public int FieldInstance;
		internal int FieldInstanceInternal;
		private int FieldInstancePrivate;

		public static int FieldStatic;
		internal static int FieldStaticInternal;
		private static int FieldStaticPrivate;

		public int FieldReadOnlyInstance;
		internal int FieldReadOnlyInstanceInternal;
		private int FieldReadOnlyInstancePrivate;

		public static int FieldReadOnlyStatic;
		internal static int FieldReadOnlyStaticInternal;
		private static int FieldReadOnlyStaticPrivate;

		public TestStructDefinition(int p1)
		{
			this.FieldInstance = 1;
			this.FieldInstanceInternal = 1;
			this.FieldInstancePrivate = 1;
			this.FieldReadOnlyInstance = 1;
			this.FieldReadOnlyInstanceInternal = 1;
			this.FieldReadOnlyInstancePrivate = 1;
			this.EventInstance = null;
			this.EventInstanceInternal = null;
			this.EventInstancePrivate = null;
		}
		internal TestStructDefinition(int p1, int p2)
		{
			this.FieldInstance = 1;
			this.FieldInstanceInternal = 1;
			this.FieldInstancePrivate = 1;
			this.FieldReadOnlyInstance = 1;
			this.FieldReadOnlyInstanceInternal = 1;
			this.FieldReadOnlyInstancePrivate = 1;
			this.EventInstance = null;
			this.EventInstanceInternal = null;
			this.EventInstancePrivate = null;
		}
		private TestStructDefinition(int p1, int p2, int p3)
		{
			this.FieldInstance = 1;
			this.FieldInstanceInternal = 1;
			this.FieldInstancePrivate = 1;
			this.FieldReadOnlyInstance = 1;
			this.FieldReadOnlyInstanceInternal = 1;
			this.FieldReadOnlyInstancePrivate = 1;
			this.EventInstance = null;
			this.EventInstanceInternal = null;
			this.EventInstancePrivate = null;
		}

		public event EventHandler EventInstance;
		internal event EventHandler EventInstanceInternal;
		private event EventHandler EventInstancePrivate;

		public static event EventHandler EventStatic;
		internal static event EventHandler EventStaticInternal;
		private static event EventHandler EventStaticPrivate;

		public event EventHandler EventCustomInstance { add { } remove { } }
		internal event EventHandler EventCustomInstanceInternal { add { } remove { } }
		private event EventHandler EventCustomInstancePrivate { add { } remove { } }

		public static event EventHandler EventCustomStatic { add { } remove { } }
		internal static event EventHandler EventCustomStaticInternal { add { } remove { } }
		private static event EventHandler EventCustomStaticPrivate { add { } remove { } }

		public object this[int x1] { get { return null; } }
		internal object this[int x1, int x2] { get { return null; } }
		private object this[int x1, int x2, int x3, int x4, int x5] { get { return null; } }

		public static List<int> MethodStatic() { return null; }
		internal static List<int> MethodStaticInternal() { return null; }
		private static List<int> MethodStaticPrivate() { return null; }

		public void MethodInstance() { }
		internal void MethodInstanceInternal() { }
		private void MethodInstancePrivate() { }

		public static TestClassDefinition operator +(TestStructDefinition a, int b) { return null; }

		public static int PropertyStatic { get { return 1; } }
		internal static int PropertyStaticInternal { get { return 1; } }
		private static int PropertyStaticPrivate { get { return 1; } }

		public string PropertyInstance { get { return "X"; } }
		internal string PropertyInstanceInternal { get { return "X"; } }
		private string PropertyInstancePrivate { get { return "X"; } }

		public struct NestedStruct { }
		internal struct NestedStructInternal { }
		private struct NestedStructPrivate { }
	}

	public interface TestInterfaceDefinition :
		IEquatable<TestClassDefinition>
	{
		event EventHandler EventInstance;
		object this[int x1] { get; }
		void MethodInstance();
		string PropertyInstance { get; }
	}

	public enum TestEnumDefinition { Constant }

	public delegate void TestDelegateDefinition();
	public delegate void TestDelegateDefinitionWithParams(int x, ref int y);

	public abstract class VariousMemberFeatures
	{
		protected object this[int x1] { get { return null; } }
		public object this[int x1, int x2] { set { } }
		public object this[int x1, int x2, int x3] { get { return null; } protected set { } }

		public void GenericMethod<T1, T2, T3, T4, T5>()
			where T2 : IEquatable<TestClassDefinition>, TestInterfaceDefinition
			where T3 : class
			where T4 : struct
			where T5 : new() { }

		public void MethodWithDefaultParameter(int param1, int param2 = 1, System.DateTimeKind kind = DateTimeKind.Local, int[] array = null) { }
		public void MethodWithParameterModifiers(int param1, ref int param2, out int param3) { param3 = 1; }
		public void MethodWithParameterTypes(int param1, VariousMemberFeatures param2) { }
		public void MethodWithParamsArray(int param1, params int[] param2) { }

		protected object PropertyReadOnly { get { return null; } }
		public object PropertyWriteOnly { set { } }
		public object PropertyReadWrite { get { return null; } protected set { } }

		public static VariousMemberFeatures operator +(VariousMemberFeatures a) { return null; }
		public static VariousMemberFeatures operator -(VariousMemberFeatures a) { return null; }
		public static VariousMemberFeatures operator !(VariousMemberFeatures a) { return null; }
		public static VariousMemberFeatures operator ~(VariousMemberFeatures a) { return null; }
		public static VariousMemberFeatures operator ++(VariousMemberFeatures a) { return null; }
		public static VariousMemberFeatures operator --(VariousMemberFeatures a) { return null; }

		public static bool operator true(VariousMemberFeatures a) { return false; }
		public static bool operator false(VariousMemberFeatures a) { return false; }

		public static VariousMemberFeatures operator +(VariousMemberFeatures a, VariousMemberFeatures b) { return null; }
		public static VariousMemberFeatures operator -(VariousMemberFeatures a, VariousMemberFeatures b) { return null; }
		public static VariousMemberFeatures operator *(VariousMemberFeatures a, VariousMemberFeatures b) { return null; }
		public static VariousMemberFeatures operator /(VariousMemberFeatures a, VariousMemberFeatures b) { return null; }
		public static VariousMemberFeatures operator %(VariousMemberFeatures a, VariousMemberFeatures b) { return null; }
		public static VariousMemberFeatures operator &(VariousMemberFeatures a, VariousMemberFeatures b) { return null; }
		public static VariousMemberFeatures operator |(VariousMemberFeatures a, VariousMemberFeatures b) { return null; }
		public static VariousMemberFeatures operator ^(VariousMemberFeatures a, VariousMemberFeatures b) { return null; }
		public static VariousMemberFeatures operator <<(VariousMemberFeatures a, int b) { return null; }
		public static VariousMemberFeatures operator >>(VariousMemberFeatures a, int b) { return null; }

		public static bool operator ==(VariousMemberFeatures a, VariousMemberFeatures b) { return false; }
		public static bool operator !=(VariousMemberFeatures a, VariousMemberFeatures b) { return false; }
		public static bool operator <(VariousMemberFeatures a, VariousMemberFeatures b) { return false; }
		public static bool operator >(VariousMemberFeatures a, VariousMemberFeatures b) { return false; }
		public static bool operator <=(VariousMemberFeatures a, VariousMemberFeatures b) { return false; }
		public static bool operator >=(VariousMemberFeatures a, VariousMemberFeatures b) { return false; }

		public static implicit operator VariousMemberFeatures(int a) { return null; }
		public static explicit operator VariousMemberFeatures(double a) { return null; }
	}

	public abstract class OverloadedMemberFeaturesBase
	{
		public abstract event EventHandler EventInstanceOverrideAbstract;
		public abstract event EventHandler EventInstanceOverrideAbstractSealed;
		public abstract event EventHandler EventInstanceOverrideAbstractAbstract;
		public virtual event EventHandler EventInstanceOverrideVirtual;
		public virtual event EventHandler EventInstanceOverrideVirtualSealed;
		public virtual event EventHandler EventInstanceOverrideVirtualAbstract;

		public abstract int this[int x1] { get; }
		public abstract int this[int x1, int x2] { get; }
		public abstract int this[int x1, int x2, int x3] { get; }
		public virtual int this[int x1, int x2, int x3, int x4] { get { return 0; } }
		public virtual int this[int x1, int x2, int x3, int x4, int x5] { get { return 0; } }
		public virtual int this[int x1, int x2, int x3, int x4, int x5, int x6] { get { return 0; } }

		public abstract void MethodInstanceOverrideAbstract();
		public abstract void MethodInstanceOverrideAbstractSealed();
		public abstract void MethodInstanceOverrideAbstractAbstract();
		public virtual void MethodInstanceOverrideVirtual() { }
		public virtual void MethodInstanceOverrideVirtualSealed() { }
		public virtual void MethodInstanceOverrideVirtualAbstract() { }

		public abstract int PropertyInstanceOverrideAbstract { get; }
		public abstract int PropertyInstanceOverrideAbstractSealed { get; }
		public abstract int PropertyInstanceOverrideAbstractAbstract { get; }
		public virtual int PropertyInstanceOverrideVirtual { get { return 0; } }
		public virtual int PropertyInstanceOverrideVirtualSealed { get { return 0; } }
		public virtual int PropertyInstanceOverrideVirtualAbstract { get { return 0; } }
	}

	public abstract class OverloadedMemberFeatures : OverloadedMemberFeaturesBase
	{
		public event EventHandler EventInstance;
		public static event EventHandler EventStatic;
		public abstract event EventHandler EventInstanceAbstract;
		public virtual event EventHandler EventInstanceVirtual;
		public override event EventHandler EventInstanceOverrideAbstract;
		public sealed override event EventHandler EventInstanceOverrideAbstractSealed;
		public abstract override event EventHandler EventInstanceOverrideAbstractAbstract;
		public override event EventHandler EventInstanceOverrideVirtual;
		public sealed override event EventHandler EventInstanceOverrideVirtualSealed;
		public abstract override event EventHandler EventInstanceOverrideVirtualAbstract;

		public int this[string x1] { get { return 0; } }
		public abstract int this[string x1, string x2] { get; }
		public virtual int this[string x1, string x2, string x3] { get { return 0; } }
		public override int this[int x1] { get { return 0; } }
		public sealed override int this[int x1, int x2] { get { return 0; } }
		public abstract override int this[int x1, int x2, int x3] { get; }
		public override int this[int x1, int x2, int x3, int x4] { get { return 0; } }
		public sealed override int this[int x1, int x2, int x3, int x4, int x5] { get { return 0; } }
		public abstract override int this[int x1, int x2, int x3, int x4, int x5, int x6] { get; }

		public void MethodInstance() { }
		public static void MethodStatic() { }
		public abstract void MethodInstanceAbstract();
		public virtual void MethodInstanceVirtual() { }
		public override void MethodInstanceOverrideAbstract() { }
		public sealed override void MethodInstanceOverrideAbstractSealed() { }
		public abstract override void MethodInstanceOverrideAbstractAbstract();
		public override void MethodInstanceOverrideVirtual() { }
		public sealed override void MethodInstanceOverrideVirtualSealed() { }
		public abstract override void MethodInstanceOverrideVirtualAbstract();

		public int PropertyInstance { get { return 0; } }
		public static int PropertyStatic { get { return 0; } }
		public abstract int PropertyInstanceAbstract { get; }
		public virtual int PropertyInstanceVirtual { get { return 0; } }
		public override int PropertyInstanceOverrideAbstract { get { return 0; } }
		public sealed override int PropertyInstanceOverrideAbstractSealed { get { return 0; } }
		public abstract override int PropertyInstanceOverrideAbstractAbstract { get; }
		public override int PropertyInstanceOverrideVirtual { get { return 0; } }
		public sealed override int PropertyInstanceOverrideVirtualSealed { get { return 0; } }
		public abstract override int PropertyInstanceOverrideVirtualAbstract { get; }
	}

	public class UnsealedClass
	{
		protected virtual void MethodVirtual() { }
	}

	public sealed class SealedClass : UnsealedClass
	{
		protected override void MethodVirtual() { }
	}

	public abstract class AbstractClass
	{

	}

	public static class StaticClass
	{
		public static void Method(string s) { }
	}

	public static class ExtensionsClass
	{
		public static void Method(this string s) { }
	}
}

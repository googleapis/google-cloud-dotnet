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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	public interface BaseInterface { }
	public interface DerivedInterface : BaseInterface { }

	public class PublicConstant { public const int Constant = 0;	}
	public class ProtectedConstant { protected const int Constant = 0;	}
	public class ProtectedInternalConstant { protected internal const int Constant = 0;	}
	public class InternalConstant { internal const int Constant = 0;	}
	public class PrivateConstant { private const int Constant = 0;	}
	public class NoConstant { }

	public class PublicConstructor { public PublicConstructor(int x) { } }
	public class ProtectedConstructor { protected ProtectedConstructor(int x) { } }
	public class ProtectedInternalConstructor { protected internal ProtectedInternalConstructor(int x) { } }
	public class InternalConstructor { private InternalConstructor(int x) { } }
	public class PrivateConstructor { private PrivateConstructor(int x) { } }
	public class NoConstructor { private NoConstructor() { } }

#pragma warning disable 0067
	public class PublicEvent { public event EventHandler Event; }
	public class ProtectedEvent { protected event EventHandler Event; }
	public class ProtectedInternalEvent { protected internal event EventHandler Event; }
	public class InternalEvent { internal event EventHandler Event; }
	public class PrivateEvent { private event EventHandler Event; }
	public class NoEvent { }
#pragma warning restore 0067

#pragma warning disable 0169, 0649
	public class PublicField { public int Field; }
	public class ProtectedField { protected int Field; }
	public class ProtectedInternalField { protected internal int Field; }
	public class InternalField { internal int Field; }
	public class PrivateField { private int Field; }
	public class NoField { }
#pragma warning restore 0169, 0649

	public class PublicIndexer { public int this[int x] { get { return 0; } } }
	public class ProtectedIndexer { protected int this[int x] { get { return 0; } } }
	public class ProtectedInternalIndexer { protected internal int this[int x] { get { return 0; } } }
	public class InternalIndexer { internal int this[int x] { get { return 0; } } }
	public class PrivateIndexer { private int this[int x] { get { return 0; } } }
	public class NoIndexer { }

	public class PublicMethod { public void Method() { } }
	public class ProtectedMethod { protected void Method() { } }
	public class ProtectedInternalMethod { protected internal void Method() { } }
	public class InternalMethod { internal void Method() { } }
	public class PrivateMethod { private void Method() { } }
	public class NoMethod { }

	public class PublicOperator { public static int operator +(PublicOperator a, PublicOperator b) { return 0; } }
	public class NoOperator { }

	public class PublicProperty { public int Property { get { return 0; } } }
	public class ProtectedProperty { protected int Property { get { return 0; } } }
	public class ProtectedInternalProperty { protected internal int Property { get { return 0; } } }
	public class InternalProperty { internal int Property { get { return 0; } } }
	public class PrivateProperty { private int Property { get { return 0; } } }
	public class NoProperty { }

	public class PublicNestedType { public class NestedType { } }
	public class ProtectedNestedType { protected class NestedType { } }
	public class ProtectedInternalNestedType { protected internal class NestedType { } }
	public class InternalNestedType { internal class NestedType { } }
	public class PrivateNestedType { private class NestedType { } }
	public class NoNestedType { }

	public interface InterfaceWithNoMembers { }
	public interface InterfaceWithEvent { event EventHandler Event; }
	public interface InterfaceWithIndexer { object this[int x1] { get; } }
	public interface InterfaceWithMethod { void Method(); }
	public interface InterfaceWithProperty { string Property { get; } }

	// TODO_Test: Can we remove these?
	public class ClassWithNoMembers { }
	public class ClassWithConstant { public const int Constant = 0; }
	public class ClassWithConstructor { public ClassWithConstructor(int x) { } public ClassWithConstructor() { } }
#pragma warning disable 0067
	public class ClassWithEvent { public event EventHandler Event; }
#pragma warning restore 0067
	public class ClassWithField { public int Field; }
	public class ClassWithIndexer { public object this[int x1] { get { return null; } } }
	public class ClassWithMethod { public void Method() { } }
	public class ClassWithOperator { public static int operator +(ClassWithOperator a, ClassWithOperator b) { return 0; } }
	public class ClassWithProperty { public string Property { get { return null; } } }
	public class ClassWithNestedType { public class NestedType { } }

	public struct StructWithNoMembers { }
	public struct StructWithConstant { public const int Constant = 0; }
	public struct StructWithConstructor { public StructWithConstructor(int x) { } }
#pragma warning disable 0067
	public struct StructWithEvent { public event EventHandler Event; }
#pragma warning restore 0067
	public struct StructWithField { public int Field; }
	public struct StructWithIndexer { public object this[int x1] { get { return null; } } }
	public struct StructWithMethod { public void Method() { } }
	public struct StructWithOperator { public static int operator +(StructWithOperator a, PublicOperator b) { return 0; } }
	public struct StructWithProperty { public string Property { get { return null; } } }
	public struct StructWithNestedType { public struct NestedType { } }

	public class NestedInterfaceWithNoMembers { public interface Interface { } }
	public class NestedInterfaceWithEvent { public interface Interface { event EventHandler Event; } }
	public class NestedInterfaceWithIndexer { public interface Interface { object this[int x1] { get; } } }
	public class NestedInterfaceWithMethod { public interface Interface { void Method(); } }
	public class NestedInterfaceWithProperty { public interface Interface { string Property { get; } } }

	public class NestedClassWithNoMembers { public class Class { } }
	public class NestedClassWithConstant { public class Class { public const int Constant = 0; } }
	public class NestedClassWithConstructor { public class Class { public Class(int x) { } public Class() { } } }
#pragma warning disable 0067
	public class NestedClassWithEvent { public class Class { public event EventHandler Event; } }
#pragma warning restore 0067
	public class NestedClassWithField { public class Class { public int Field; } }
	public class NestedClassWithIndexer { public class Class { public object this[int x1] { get { return null; } } } }
	public class NestedClassWithMethod { public class Class { public void Method() { } } }
	public class NestedClassWithOperator { public class Class { public static int operator +(Class a, Class b) { return 0; } } }
	public class NestedClassWithProperty { public class Class { public string Property { get { return null; } } } }
	public class NestedClassWithNestedType { public class Class { public class NestedType { } } }

	public class NestedStructWithNoMembers { public struct Struct { } }
	public class NestedStructWithConstant { public struct Struct { public const int Constant = 0; } }
	public class NestedStructWithConstructor { public struct Struct { public Struct(int x) { } } }
#pragma warning disable 0067
	public class NestedStructWithEvent { public struct Struct { public event EventHandler Event; } }
#pragma warning restore 0067
	public class NestedStructWithField { public struct Struct { public int Field; } }
	public class NestedStructWithIndexer { public struct Struct { public object this[int x1] { get { return null; } } } }
	public class NestedStructWithMethod { public struct Struct { public void Method() { } } }
	public class NestedStructWithOperator { public struct Struct { public static int operator +(Struct a, Struct b) { return 0; } } }
	public class NestedStructWithProperty { public struct Struct { public string Property { get { return null; } } } }
	public class NestedStructWithNestedType { public struct Struct { public struct NestedType { } } }
}

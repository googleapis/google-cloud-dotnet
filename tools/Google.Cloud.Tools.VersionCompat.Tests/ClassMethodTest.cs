// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using Xunit;

namespace Google.Cloud.Tools.VersionCompat.Tests.ClassMethod
{
    namespace MethodAdded.A { public class C { } }
    namespace MethodAdded.B { public class C { public void A() { } } }

    namespace MethodRemoved.A { public class C { public void A() { } } }
    namespace MethodRemoved.B { public class C { } }

    namespace MethodMadeExported.A { public class C { private void A() { } } }
    namespace MethodMadeExported.B { public class C { protected internal void A() { } } }

    namespace MethodMadeNotExported.A { public class C { protected internal void A() { } } }
    namespace MethodMadeNotExported.B { public class C { private void A() { } } }

    namespace ReturnTypeChanged1.A { public class C { public void A() { } } }
    namespace ReturnTypeChanged1.B { public class C { public int A() => 0; } }

    namespace ReturnTypeChanged2.A { public class C { public IEnumerable<int> A() => null; } }
    namespace ReturnTypeChanged2.B { public class C { public IEnumerable<long> A() => null; } }

    namespace ParamNameChanged.A { public class C { public void A(int i) { } } }
    namespace ParamNameChanged.B { public class C { public void A(int j) { } } }

    namespace ParamInOutChanged1.A { public class C { public void A(in string s) { } } }
    namespace ParamInOutChanged1.B { public class C { public void A(ref string s) { } } }

    namespace ParamInOutChanged2.A { public class C { public void A(ref string s) { } } }
    namespace ParamInOutChanged2.B { public class C { public void A(out string s) => s = ""; } }

    namespace ToStatic.A { public class C { public void A() { } } }
    namespace ToStatic.B { public class C { public static void A() { } } }

    namespace FromStatic.A { public class C { public static void A() { } } }
    namespace FromStatic.B { public class C { public void A() { } } }

    namespace GenericConstraintAdded1.A { public class C { public void A<T>() { } } }
    namespace GenericConstraintAdded1.B { public class C { public void A<T>() where T : new() { } } }

    namespace GenericConstraintAdded2.A { public class C { public void A<T>() { } } }
    namespace GenericConstraintAdded2.B { public class C { public void A<T>() where T : class { } } }

    namespace GenericConstraintAdded3.A { public class C { public void A<T>() { } } }
    namespace GenericConstraintAdded3.B { public class C { public void A<T>() where T : struct { } } }

    namespace GenericConstraintAdded4.A { public class C { public void A<T>() { } } }
    namespace GenericConstraintAdded4.B { public class C { public void A<T>() where T : IList<T> { } } }

    namespace GenericConstraintRemoved1.A { public class C { public void A<T>() where T : new() { } } }
    namespace GenericConstraintRemoved1.B { public class C { public void A<T>() { } } }

    namespace GenericConstraintRemoved2.A { public class C { public void A<T>() where T : class { } } }
    namespace GenericConstraintRemoved2.B { public class C { public void A<T>() { } } }

    namespace GenericConstraintRemoved3.A { public class C { public void A<T>() where T : struct { } } }
    namespace GenericConstraintRemoved3.B { public class C { public void A<T>() { } } }

    namespace GenericConstraintRemoved4.A { public class C { public void A<T>() where T : IList<T> { } } }
    namespace GenericConstraintRemoved4.B { public class C { public void A<T>() { } } }

    namespace GenericConstraintChanged1.A { public class C { public void A<T>() where T : IList<T> { } } }
    namespace GenericConstraintChanged1.B { public class C { public void A<T>() where T : IEquatable<T> { } } }

    namespace GenericConstraintChanged2.A { public class C { public void A<T, U>() where T : IList<T> { } } }
    namespace GenericConstraintChanged2.B { public class C { public void A<T, U>() where T : IList<U> { } } }

    namespace GenericConstraintChanged3.A { public class C { public void A<T, U>() where T : IList<T> where U : IList<T> { } } }
    namespace GenericConstraintChanged3.B { public class C { public void A<T, U>() where T : IList<U> where U : IList<T> { } } }

#nullable enable
    namespace GenericConstraintChanged4.A { public class C { public void A<T>() where T : notnull, IList<T> { } } }
    namespace GenericConstraintChanged4.B { public class C { public void A<T>() where T : IList<T> { } } }
#nullable restore

    namespace MethodModiferChanged1.A { public abstract class C { public virtual int A() => 0; } }
    namespace MethodModiferChanged1.B { public abstract class C { public int A() => 0; } }

    namespace MethodModiferChanged2.A { public abstract class C { public virtual int A() => 0; } }
    namespace MethodModiferChanged2.B { public abstract class C { public abstract int A(); } }

    public abstract class Base { public abstract int A(); }

    namespace MethodModiferChanged3.A { public abstract class C : Base { public override int A() => 0; } }
    namespace MethodModiferChanged3.B { public abstract class C : Base { public sealed override int A() => 0; } }

    namespace MethodModiferChanged4.A { public abstract class C { public int A() => 0; } }
    namespace MethodModiferChanged4.B { public abstract class C { public virtual int A() => 0; } }

    namespace MethodModiferChanged5.A { public abstract class C { public abstract int A(); } }
    namespace MethodModiferChanged5.B { public abstract class C { public virtual int A() => 0; } }

    namespace MethodModiferChanged6.A { public abstract class C : Base { public sealed override int A() => 0; } }
    namespace MethodModiferChanged6.B { public abstract class C : Base { public override int A() => 0; } }

    namespace MethodAccessModifierChanged1.A { public class C { public void A() { } } }
    namespace MethodAccessModifierChanged1.B { public class C { protected void A() { } } }

    namespace MethodAccessModifierChanged2.A { public class C { protected void A() { } } }
    namespace MethodAccessModifierChanged2.B { public class C { public void A() { } } }

    public class ClassMethodTest : TestBase
    {
        [Fact] public void MethodAdded() => TestMinor(Cause.MethodAdded);
        [Fact] public void MethodRemoved() => TestMajor(Cause.MethodRemoved);
        [Fact] public void MethodMadeExported() => TestMinor(Cause.MethodMadeExported);
        [Fact] public void MethodMadeNotExported() => TestMajor(Cause.MethodMadeNotExported);
        [Fact] public void ReturnTypeChanged1() => TestMajor(Cause.MethodReturnTypeChanged);
        [Fact] public void ReturnTypeChanged2() => TestMajor(Cause.MethodReturnTypeChanged);
        [Fact] public void ParamNameChanged() => TestMajor(Cause.MethodParameterNameChanged);
        [Fact] public void ParamInOutChanged1() => TestMajor(Cause.MethodParameterInOutChanged);
        [Fact] public void ParamInOutChanged2() => TestMajor(Cause.MethodParameterInOutChanged);
        [Fact] public void ToStatic() => TestMajor(Cause.MethodMadeStatic);
        [Fact] public void FromStatic() => TestMajor(Cause.MethodMadeNonStatic);
        [Fact] public void GenericConstraintAdded1() => TestMajor(Cause.MethodGenericConstraintChanged);
        [Fact] public void GenericConstraintAdded2() => TestMajor(Cause.MethodGenericConstraintChanged);
        [Fact] public void GenericConstraintAdded3() => TestMajor(Cause.MethodGenericConstraintChanged);
        [Fact] public void GenericConstraintAdded4() => TestMajor(Cause.MethodGenericConstraintChanged);
        [Fact] public void GenericConstraintRemoved1() => TestMinor(Cause.MethodGenericConstraintChanged);
        [Fact] public void GenericConstraintRemoved2() => TestMinor(Cause.MethodGenericConstraintChanged);
        [Fact] public void GenericConstraintRemoved3() => TestMinor(Cause.MethodGenericConstraintChanged);
        [Fact] public void GenericConstraintRemoved4() => TestMinor(Cause.MethodGenericConstraintChanged);
        [Fact] public void GenericConstraintChanged1() => Test()
            ((Level.Major, Cause.MethodGenericConstraintChanged), (Level.Minor, Cause.MethodGenericConstraintChanged));
        [Fact] public void GenericConstraintChanged2() => Test()
            ((Level.Major, Cause.MethodGenericConstraintChanged), (Level.Minor, Cause.MethodGenericConstraintChanged));
        [Fact] public void GenericConstraintChanged3() => Test()
            ((Level.Major, Cause.MethodGenericConstraintChanged), (Level.Minor, Cause.MethodGenericConstraintChanged));
        [Fact]
        public void GenericConstraintChanged4() => Test()
            ((Level.Major, Cause.MethodGenericConstraintChanged), (Level.Minor, Cause.MethodGenericConstraintChanged));
        [Fact] public void MethodModiferChanged1() => TestMajor(Cause.MethodModifierChanged);
        [Fact] public void MethodModiferChanged2() => TestMajor(Cause.MethodModifierChanged);
        [Fact] public void MethodModiferChanged3() => TestMajor(Cause.MethodModifierChanged);
        [Fact] public void MethodModiferChanged4() => TestMinor(Cause.MethodModifierChanged);
        [Fact] public void MethodModiferChanged5() => TestMinor(Cause.MethodModifierChanged);
        [Fact] public void MethodModiferChanged6() => TestMinor(Cause.MethodModifierChanged);
        [Fact] public void MethodAccessModifierChanged1() => TestMajor(Cause.MethodAccessModifierChanged);
        [Fact] public void MethodAccessModifierChanged2() => TestMinor(Cause.MethodAccessModifierChanged);
    }
}

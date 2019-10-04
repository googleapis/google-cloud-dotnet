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

namespace Google.Cloud.Tools.VersionCompat.Tests.StructMethod
{
    namespace MethodAdded.A { public struct S { } }
    namespace MethodAdded.B { public struct S { public void A() { } } }

    namespace MethodRemoved.A { public struct S { public void A() { } } }
    namespace MethodRemoved.B { public struct S { } }

    namespace MethodMadeExported.A { public struct S { private void A() { } } }
    namespace MethodMadeExported.B { public struct S { public void A() { } } }

    namespace MethodMadeNotExported.A { public struct S { public void A() { } } }
    namespace MethodMadeNotExported.B { public struct S { private void A() { } } }

    namespace ReturnTypeChanged1.A { public struct S { public void A() { } } }
    namespace ReturnTypeChanged1.B { public struct S { public int A() => 0; } }

    namespace ReturnTypeChanged2.A { public struct S { public IEnumerable<int> A() => null; } }
    namespace ReturnTypeChanged2.B { public struct S { public IEnumerable<long> A() => null; } }

    namespace ParamNameChanged.A { public struct S { public void A(int i) { } } }
    namespace ParamNameChanged.B { public struct S { public void A(int j) { } } }

    namespace ParamInOutChanged1.A { public struct S { public void A(in string s) { } } }
    namespace ParamInOutChanged1.B { public struct S { public void A(ref string s) { } } }

    namespace ParamInOutChanged2.A { public struct S { public void A(ref string s) { } } }
    namespace ParamInOutChanged2.B { public struct S { public void A(out string s) => s = ""; } }

    namespace ToStatic.A { public struct S { public void A() { } } }
    namespace ToStatic.B { public struct S { public static void A() { } } }

    namespace FromStatic.A { public struct S { public static void A() { } } }
    namespace FromStatic.B { public struct S { public void A() { } } }

    namespace GenericConstraintAdded1.A { public struct S { public void A<T>() { } } }
    namespace GenericConstraintAdded1.B { public struct S { public void A<T>() where T : new() { } } }

    namespace GenericConstraintAdded2.A { public struct S { public void A<T>() { } } }
    namespace GenericConstraintAdded2.B { public struct S { public void A<T>() where T : class { } } }

    namespace GenericConstraintAdded3.A { public struct S { public void A<T>() { } } }
    namespace GenericConstraintAdded3.B { public struct S { public void A<T>() where T : struct { } } }

    namespace GenericConstraintAdded4.A { public struct S { public void A<T>() { } } }
    namespace GenericConstraintAdded4.B { public struct S { public void A<T>() where T : IList<T> { } } }

    namespace GenericConstraintRemoved1.A { public struct S { public void A<T>() where T : new() { } } }
    namespace GenericConstraintRemoved1.B { public struct S { public void A<T>() { } } }

    namespace GenericConstraintRemoved2.A { public struct S { public void A<T>() where T : class { } } }
    namespace GenericConstraintRemoved2.B { public struct S { public void A<T>() { } } }

    namespace GenericConstraintRemoved3.A { public struct S { public void A<T>() where T : struct { } } }
    namespace GenericConstraintRemoved3.B { public struct S { public void A<T>() { } } }

    namespace GenericConstraintRemoved4.A { public struct S { public void A<T>() where T : IList<T> { } } }
    namespace GenericConstraintRemoved4.B { public struct S { public void A<T>() { } } }

    namespace GenericConstraintChanged1.A { public struct S { public void A<T>() where T : IList<T> { } } }
    namespace GenericConstraintChanged1.B { public struct S { public void A<T>() where T : IEquatable<T> { } } }

    namespace GenericConstraintChanged2.A { public struct S { public void A<T, U>() where T : IList<T> { } } }
    namespace GenericConstraintChanged2.B { public struct S { public void A<T, U>() where T : IList<U> { } } }

    namespace GenericConstraintChanged3.A { public class S { public void A<T, U>() where T : IList<T> where U : IList<T> { } } }
    namespace GenericConstraintChanged3.B { public class S { public void A<T, U>() where T : IList<U> where U : IList<T> { } } }

    public class StructMethodTest : TestBase
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
        [Fact]
        public void GenericConstraintChanged1() => Test()
            ((Level.Major, Cause.MethodGenericConstraintChanged), (Level.Minor, Cause.MethodGenericConstraintChanged));
        [Fact]
        public void GenericConstraintChanged2() => Test()
            ((Level.Major, Cause.MethodGenericConstraintChanged), (Level.Minor, Cause.MethodGenericConstraintChanged));
        [Fact]
        public void GenericConstraintChanged3() => Test()
            ((Level.Major, Cause.MethodGenericConstraintChanged), (Level.Minor, Cause.MethodGenericConstraintChanged));
    }
}

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

namespace Google.Cloud.Tools.VersionCompat.Tests.Struct
{
    namespace NoChange.A { public struct S { } }
    namespace NoChange.B { public struct S { } }

    public interface I1 { }
    internal interface I2 { }

    namespace InterfaceAdded.A { public struct S { } }
    namespace InterfaceAdded.B { public struct S : I1 { } }

    namespace InterfaceRemoved.A { public struct S : I1 { } }
    namespace InterfaceRemoved.B { public struct S { } }

    namespace NonExportedInterfaceAdded.A { public struct S { } }
    namespace NonExportedInterfaceAdded.B { public struct S : I2 { } }

    namespace NonExportedInterfaceRemoved.A { public struct S : I2 { } }
    namespace NonExportedInterfaceRemoved.B { public struct S { } }

    namespace GenericConstraintAdded1.A { public struct S<A> { } }
    namespace GenericConstraintAdded1.B { public struct S<A> where A : new() { } }

    namespace GenericConstraintAdded2.A { public struct S<A> { } }
    namespace GenericConstraintAdded2.B { public struct S<A> where A : class { } }

    namespace GenericConstraintAdded3.A { public struct S<A> { } }
    namespace GenericConstraintAdded3.B { public struct S<A> where A : struct { } }

    namespace GenericConstraintAdded4.A { public struct S<A> { } }
    namespace GenericConstraintAdded4.B { public struct S<A> where A : IList<A> { } }

    namespace GenericConstraintRemoved1.A { public struct S<A> where A : new() { } }
    namespace GenericConstraintRemoved1.B { public struct S<A> { } }

    namespace GenericConstraintRemoved2.A { public struct S<A> where A : class { } }
    namespace GenericConstraintRemoved2.B { public struct S<A> { } }

    namespace GenericConstraintRemoved3.A { public struct S<A> where A : struct { } }
    namespace GenericConstraintRemoved3.B { public struct S<A> { } }

    namespace GenericConstraintRemoved4.A { public struct S<A> where A : IList<A> { } }
    namespace GenericConstraintRemoved4.B { public struct S<A> { } }

    namespace GenericConstraintChanged1.A { public struct S<A> where A : IList<A> { } }
    namespace GenericConstraintChanged1.B { public struct S<A> where A : IEquatable<A> { } }

    namespace GenericConstraintChanged2.A { public struct S<A, B> where A : IList<A> { } }
    namespace GenericConstraintChanged2.B { public struct S<A, B> where A : IList<B> { } }

    namespace GenericConstraintChanged3.A { public struct S<A, B> where A : IList<A> where B : IList<A> { } }
    namespace GenericConstraintChanged3.B { public struct S<A, B> where A : IList<B> where B : IList<A> { } }
}

namespace Google.Cloud.Tools.VersionCompat.Tests
{
    public class StructTest : TestBase
    {
        [Fact] public void NoChange() => TestNone();
        [Fact] public void InterfaceAdded() => TestMajor(Cause.TypeImplementedInterfaceAdded);
        [Fact] public void InterfaceRemoved() => TestMajor(Cause.TypeImplementedInterfaceRemoved);
        [Fact] public void NonExportedInterfaceAdded() => TestNone();
        [Fact] public void NonExportedInterfaceRemoved() => TestNone();
        [Fact] public void GenericConstraintAdded1() => TestMajor(Cause.TypeGenericConstraintChanged);
        [Fact] public void GenericConstraintAdded2() => TestMajor(Cause.TypeGenericConstraintChanged);
        [Fact] public void GenericConstraintAdded3() => TestMajor(Cause.TypeGenericConstraintChanged);
        [Fact] public void GenericConstraintAdded4() => TestMajor(Cause.TypeGenericConstraintChanged);
        [Fact] public void GenericConstraintRemoved1() => TestMinor(Cause.TypeGenericConstraintChanged);
        [Fact] public void GenericConstraintRemoved2() => TestMinor(Cause.TypeGenericConstraintChanged);
        [Fact] public void GenericConstraintRemoved3() => TestMinor(Cause.TypeGenericConstraintChanged);
        [Fact] public void GenericConstraintRemoved4() => TestMinor(Cause.TypeGenericConstraintChanged);
        [Fact]
        public void GenericConstraintChanged1() => Test()
            ((Level.Major, Cause.TypeGenericConstraintChanged), (Level.Minor, Cause.TypeGenericConstraintChanged));
        [Fact]
        public void GenericConstraintChanged2() => Test()
            ((Level.Major, Cause.TypeGenericConstraintChanged), (Level.Minor, Cause.TypeGenericConstraintChanged));
        [Fact]
        public void GenericConstraintChanged3() => Test()
            ((Level.Major, Cause.TypeGenericConstraintChanged), (Level.Minor, Cause.TypeGenericConstraintChanged));
    }
}

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

namespace Google.Cloud.Tools.VersionCompat.Tests.Class
{
    namespace NoChange.A { public class C { } }
    namespace NoChange.B { public class C { } }

    namespace ToStatic.A { public class C { private C() { } } }
    namespace ToStatic.B { public static class C { } }

    namespace ToStaticNoCtor.A { public class C { private C() { } } }
    namespace ToStaticNoCtor.B { public static class C { } }

    namespace ToAbstract.A { public class C { public C() { } } }
    namespace ToAbstract.B { public abstract class C { public C() { } } }

    namespace ToAbstractNoCtor.A { public class C { protected C() { } } }
    namespace ToAbstractNoCtor.B { public abstract class C { protected C() { } } }

    namespace ToSealed.A { public class C { } }
    namespace ToSealed.B { public sealed class C { } }

    namespace FromStatic.A { public static class C { } }
    namespace FromStatic.B { public class C { protected C() { } } }

    namespace FromStaticNoCtor.A { public static class C { } }
    namespace FromStaticNoCtor.B { public class C { private C() { } } }

    namespace FromAbstract.A { public abstract class C { public C() { } } }
    namespace FromAbstract.B { public class C { public C() { } } }

    namespace FromAbstractNoCtor.A { public abstract class C { private C() { } } }
    namespace FromAbstractNoCtor.B { public class C { private C() { } } }

    namespace FromSealed.A { public sealed class C { } }
    namespace FromSealed.B { public class C { } }

    namespace FromSealedNoCtor.A { public sealed class C { private C() { } } }
    namespace FromSealedNoCtor.B { public class C { private C() { } } }

    namespace BaseTypeFromObjectOk.A { public class C { } }
    namespace BaseTypeFromObjectOk.B { public class C : List<int> { } }

    namespace BaseTypeFromObjectAbstract.A { public abstract class C { } }
    namespace BaseTypeFromObjectAbstract.B { public abstract class C : List<int> { } }

    namespace BaseTypeChanged.A { public class C : List<string> { } }
    namespace BaseTypeChanged.B { public class C : List<int> { } }

    public interface I1 { }
    internal interface I2 { }

    namespace InterfaceAdded.A { public abstract class C { } }
    namespace InterfaceAdded.B { public abstract class C : I1 { } }

    namespace InterfaceRemoved.A { public abstract class C : I1 { } }
    namespace InterfaceRemoved.B { public abstract class C { } }

    namespace NonExportedInterfaceAdded.A { public abstract class C { } }
    namespace NonExportedInterfaceAdded.B { public abstract class C : I2 { } }

    namespace NonExportedInterfaceRemoved.A { public abstract class C : I2 { } }
    namespace NonExportedInterfaceRemoved.B { public abstract class C { } }

    namespace GenericConstraintAdded1.A { public class C<A> { } }
    namespace GenericConstraintAdded1.B { public class C<A> where A : new() { } }

    namespace GenericConstraintAdded2.A { public class C<A> { } }
    namespace GenericConstraintAdded2.B { public class C<A> where A : class { } }

    namespace GenericConstraintAdded3.A { public class C<A> { } }
    namespace GenericConstraintAdded3.B { public class C<A> where A : struct { } }

    namespace GenericConstraintAdded4.A { public class C<A> { } }
    namespace GenericConstraintAdded4.B { public class C<A> where A : IList<A> { } }

    namespace GenericConstraintRemoved1.A { public class C<A> where A : new() { } }
    namespace GenericConstraintRemoved1.B { public class C<A> { } }

    namespace GenericConstraintRemoved2.A { public class C<A> where A : class { } }
    namespace GenericConstraintRemoved2.B { public class C<A> { } }

    namespace GenericConstraintRemoved3.A { public class C<A> where A : struct { } }
    namespace GenericConstraintRemoved3.B { public class C<A> { } }

    namespace GenericConstraintRemoved4.A { public class C<A> where A : IList<A> { } }
    namespace GenericConstraintRemoved4.B { public class C<A> { } }

    namespace GenericConstraintChanged1.A { public class C<A> where A : IList<A> { } }
    namespace GenericConstraintChanged1.B { public class C<A> where A : IEquatable<A> { } }

    namespace GenericConstraintChanged2.A { public class C<A, B> where A : IList<A> { } }
    namespace GenericConstraintChanged2.B { public class C<A, B> where A : IList<B> { } }

    namespace GenericConstraintChanged3.A { public class C<A, B> where A : IList<A> where B : IList<A> { } }
    namespace GenericConstraintChanged3.B { public class C<A, B> where A : IList<B> where B : IList<A> { } }

    public class ClassTest : TestBase
    {
        [Fact] public void NoChange() => TestNone();
        [Fact] public void ToStatic() => TestMajor(Cause.ClassModifierChanged);
        [Fact] public void ToStaticNoCtor() => TestMajor(Cause.ClassModifierChanged);
        [Fact] public void ToAbstract() => TestMajor(Cause.ClassModifierChanged);
        [Fact] public void ToAbstractNoCtor() => TestNone();
        [Fact] public void ToSealed() => TestMajor(Cause.ClassModifierChanged);
        [Fact] public void FromStatic() => Test()
            ((Level.Minor, Cause.ClassModifierChanged), (Level.Minor, Cause.CtorAdded));
        [Fact] public void FromStaticNoCtor() => TestNone();
        [Fact] public void FromAbstract() => TestMinor(Cause.ClassModifierChanged);
        [Fact] public void FromAbstractNoCtor() => TestNone();
        [Fact] public void FromSealed() => TestMinor(Cause.ClassModifierChanged);
        [Fact] public void FromSealedNoCtor() => TestNone();
        [Fact] public void BaseTypeFromObjectOk() => TestMinor(Cause.ClassBaseClassChanged);
        [Fact] public void BaseTypeFromObjectAbstract() => TestMajor(Cause.ClassBaseClassChanged);
        [Fact] public void BaseTypeChanged() => TestMajor(Cause.ClassBaseClassChanged);
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
        [Fact] public void GenericConstraintChanged1() => Test()
            ((Level.Major, Cause.TypeGenericConstraintChanged), (Level.Minor, Cause.TypeGenericConstraintChanged));
        [Fact] public void GenericConstraintChanged2() => Test()
            ((Level.Major, Cause.TypeGenericConstraintChanged), (Level.Minor, Cause.TypeGenericConstraintChanged));
        [Fact] public void GenericConstraintChanged3() => Test()
            ((Level.Major, Cause.TypeGenericConstraintChanged), (Level.Minor, Cause.TypeGenericConstraintChanged));
    }
}

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
using Xunit;

namespace Google.Cloud.Tools.VersionCompat.Tests.Obsolete
{
    namespace UnchangedClassWarning.A {[Obsolete("", error: false)] public class C { } }
    namespace UnchangedClassWarning.B {[Obsolete] public class C { } }

    namespace UnchangedPropertyError.A { public class C {[Obsolete("", error: true)] private int P { get; } } }
    namespace UnchangedPropertyError.B { public class C {[Obsolete("", error: true)] private int P { get; } } }

    namespace ClassBecomeObsoleteWarning.A { public class C { } }
    namespace ClassBecomeObsoleteWarning.B {[Obsolete] public class C { } }

    namespace ClassBecomeObsoleteError.A { public class C { } }
    namespace ClassBecomeObsoleteError.B {[Obsolete("", error: true)] public class C { } }

    namespace ClassBecomeNonObsoleteWarning.A {[Obsolete] public class C { } }
    namespace ClassBecomeNonObsoleteWarning.B { public class C { } }

    namespace ClassBecomeNonObsoleteError.A {[Obsolete("", error: true)] public class C { } }
    namespace ClassBecomeNonObsoleteError.B { public class C { } }

    namespace ClassObsoleteWarningToError.A {[Obsolete("", error: false)] public class C { } }
    namespace ClassObsoleteWarningToError.B {[Obsolete("", error: true)] public class C { } }

    namespace ClassObsoleteErrorToWarning.A {[Obsolete("", error: true)] public class C { } }
    namespace ClassObsoleteErrorToWarning.B {[Obsolete("", error: false)] public class C { } }

    namespace StructObsolete.A { public struct S { } }
    namespace StructObsolete.B {[Obsolete] public struct S { } }

    namespace StructMemberObsolete.A { public struct S { public void M() { } } }
    namespace StructMemberObsolete.B { public struct S {[Obsolete] public void M() { } } }

    namespace InterfaceObsolete.A { public interface I { } }
    namespace InterfaceObsolete.B {[Obsolete] public interface I { } }

    namespace InterfaceMemberObsolete.A { public interface I { void M(); } }
    namespace InterfaceMemberObsolete.B { public interface I {[Obsolete] void M(); } }

    namespace CtorObsolete.A { public class C { public C() { } } }
    namespace CtorObsolete.B { public class C {[Obsolete] public C() { } } }

    namespace MethodObsolete.A { public class C { public void M() { } } }
    namespace MethodObsolete.B { public class C {[Obsolete] public void M() { } } }

    namespace PropertyObsolete.A { public class C { public int P { get; } } }
    namespace PropertyObsolete.B { public class C {[Obsolete] public int P { get; } } }

    public class ObsoleteTest : TestBase
    {
        [Fact] public void UnchangedClassWarning() => TestNone();
        [Fact] public void UnchangedPropertyError() => TestNone();
        [Fact] public void ClassBecomeObsoleteWarning() => TestMinor(Cause.ObsoleteChanged);
        [Fact] public void ClassBecomeObsoleteError() => TestMajor(Cause.ObsoleteChanged);
        [Fact] public void ClassBecomeNonObsoleteWarning() => TestMinor(Cause.ObsoleteChanged);
        [Fact] public void ClassBecomeNonObsoleteError() => TestMinor(Cause.ObsoleteChanged);
        [Fact] public void ClassObsoleteWarningToError() => TestMajor(Cause.ObsoleteChanged);
        [Fact] public void ClassObsoleteErrorToWarning() => TestMinor(Cause.ObsoleteChanged);
        [Fact] public void StructObsolete() => TestMinor(Cause.ObsoleteChanged);
        [Fact] public void StructMemberObsolete() => TestMinor(Cause.ObsoleteChanged);
        [Fact] public void InterfaceObsolete() => TestMinor(Cause.ObsoleteChanged);
        [Fact] public void InterfaceMemberObsolete() => TestMinor(Cause.ObsoleteChanged);
        [Fact] public void CtorObsolete() => TestMinor(Cause.ObsoleteChanged);
        [Fact] public void MethodObsolete() => TestMinor(Cause.ObsoleteChanged);
        [Fact] public void PropertyObsolete() => TestMinor(Cause.ObsoleteChanged);
    }
}

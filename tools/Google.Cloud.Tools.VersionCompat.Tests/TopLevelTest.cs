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

using Xunit;

namespace Google.Cloud.Tools.VersionCompat.Tests.TopLevel
{
    namespace ClassUnchanged.A { public class C { } }
    namespace ClassUnchanged.B { public class C { } }

    namespace ClassRemoved.A { public class C { } internal class D { } }
    namespace ClassRemoved.B { internal class D { } }

    namespace ClassAdded.A { internal class D { } }
    namespace ClassAdded.B { public class C { } internal class D { } }

    namespace ClassMadeNotExported.A { public class C { } }
    namespace ClassMadeNotExported.B { internal class C { } }

    namespace NestedClassMadeNotExported1.A { public class C { public class N { } } }
    namespace NestedClassMadeNotExported1.B { internal class C { public class N { } } }

    namespace NestedClassMadeNotExported2.A { public class C { public class N { } } }
    namespace NestedClassMadeNotExported2.B { public class C { private class N { } } }

    namespace ClassMadeExported.A { internal class C { } }
    namespace ClassMadeExported.B { public class C { } }

    namespace NestedClassMadeExported1.A { internal class C { public class N { } } }
    namespace NestedClassMadeExported1.B { public class C { public class N { } } }

    namespace NestedClassMadeExported2.A { public class C { private class N { } } }
    namespace NestedClassMadeExported2.B { public class C { public class N { } } }

    namespace TypeChange1.A { public class C { } }
    namespace TypeChange1.B { public interface C { } }

    namespace TypeChange2.A { public class C { } }
    namespace TypeChange2.B { public delegate void C(); }

    namespace TypeChange3.A { public class C { } }
    namespace TypeChange3.B { public struct C { } }

    namespace TypeChange4.A { public class C { } }
    namespace TypeChange4.B { public enum C { } }

    public class TopLevelTest : TestBase
    {
        [Fact] public void ClassUnchanged() => TestNone();
        [Fact] public void ClassRemoved() => TestMajor(Cause.TypeRemoved);
        [Fact] public void ClassAdded() => TestMinor(Cause.TypeAdded);
        [Fact] public void ClassMadeNotExported() => TestMajor(Cause.TypeMadeNotExported);
        [Fact] public void NestedClassMadeNotExported1() => TestMajor(Cause.TypeMadeNotExported, "C.N");
        [Fact] public void NestedClassMadeNotExported2() => TestMajor(Cause.TypeMadeNotExported, "C.N");
        [Fact] public void ClassMadeExported() => TestMinor(Cause.TypeMadeExported);
        [Fact] public void NestedClassMadeExported1() => TestMinor(Cause.TypeMadeExported, "C.N");
        [Fact] public void NestedClassMadeExported2() => TestMinor(Cause.TypeMadeExported, "C.N");
        [Fact] public void TypeChange1() => TestMajor(Cause.TypeTypeChanged);
        [Fact] public void TypeChange2() => TestMajor(Cause.TypeTypeChanged);
        [Fact] public void TypeChange3() => TestMajor(Cause.TypeTypeChanged);
        [Fact] public void TypeChange4() => TestMajor(Cause.TypeTypeChanged);
    }
}

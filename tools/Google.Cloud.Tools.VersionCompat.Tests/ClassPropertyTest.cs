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

namespace ClassProperty
{
    namespace PropertyAdded.A { public class C { } }
    namespace PropertyAdded.B { public class C { public int P { get; } } }

    namespace PropertyRemoved.A { public class C { public int P { get; } } }
    namespace PropertyRemoved.B { public class C { } }

    namespace PropertyMadeExported.A { public class C { private int P { get; } } }
    namespace PropertyMadeExported.B { public class C { public int P { get; } } }

    namespace PropertyMadeNotExported.A { public class C { public int P { get; } } }
    namespace PropertyMadeNotExported.B { public class C { private int P { get; } } }

    namespace PropertyTypeChanged.A { public class C { public int P { get; } } }
    namespace PropertyTypeChanged.B { public class C { public string P { get; } } }

    namespace PropertyToStatic.A { public class C { public int P { get; } } }
    namespace PropertyToStatic.B { public class C { public static int P { get; } } }

    namespace PropertyFromStatic.A { public class C { public static int P { get; } } }
    namespace PropertyFromStatic.B { public class C { public int P { get; } } }
}

namespace Google.Cloud.Tools.VersionCompat.Tests
{
    public class ClassPropertyTest : TestBase
    {
        [Fact] public void PropertyAdded() => TestMinor(Cause.PropertyAdded);
        [Fact] public void PropertyRemoved() => TestMajor(Cause.PropertyRemoved);
        [Fact] public void PropertyMadeExported() => TestMinor(Cause.PropertyMadeExported);
        [Fact] public void PropertyMadeNotExported() => TestMajor(Cause.PropertyMadeNotExported);
        [Fact] public void PropertyTypeChanged() => TestMajor(Cause.PropertyTypeChanged);
        [Fact] public void PropertyToStatic() => TestMajor(Cause.PropertyMadeStatic);
        [Fact] public void PropertyFromStatic() => TestMajor(Cause.PropertyMadeNonStatic);
    }
}

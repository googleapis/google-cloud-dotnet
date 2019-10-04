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

namespace Google.Cloud.Tools.VersionCompat.Tests.StructProperty
{
    namespace PropertyAdded.A { public struct S { } }
    namespace PropertyAdded.B { public struct S { public int P { get; } } }

    namespace PropertyRemoved.A { public struct S { public int P { get; } } }
    namespace PropertyRemoved.B { public struct S { } }

    namespace PropertyMadeExported.A { public struct S { private int P { get; } } }
    namespace PropertyMadeExported.B { public struct S { public int P { get; } } }

    namespace PropertyMadeNotExported.A { public struct S { public int P { get; } } }
    namespace PropertyMadeNotExported.B { public struct S { private int P { get; } } }

    namespace PropertyTypeChanged.A { public struct S { public int P { get; } } }
    namespace PropertyTypeChanged.B { public struct S { public string P { get; } } }

    namespace PropertyToStatic.A { public struct S { public int P { get; } } }
    namespace PropertyToStatic.B { public struct S { public static int P { get; } } }

    namespace PropertyFromStatic.A { public struct S { public static int P { get; } } }
    namespace PropertyFromStatic.B { public struct S { public int P { get; } } }

    namespace PropertyGetAccessModiferChange1.A { public struct S { public int P { get; set; } } }
    namespace PropertyGetAccessModiferChange1.B { public struct S { public int P { private get; set; } } }

    namespace PropertyGetAccessModiferChange2.A { public struct S { public int P { private get; set; } } }
    namespace PropertyGetAccessModiferChange2.B { public struct S { public int P { get; set; } } }

    namespace PropertySetAccessModiferChange1.A { public struct S { public int P { get; set; } } }
    namespace PropertySetAccessModiferChange1.B { public struct S { public int P { get; private set; } } }

    namespace PropertySetAccessModiferChange2.A { public struct S { public int P { get; private set; } } }
    namespace PropertySetAccessModiferChange2.B { public struct S { public int P { get; set; } } }

    namespace PropertyGetAdded.A { public struct S { public int P { set { } } } }
    namespace PropertyGetAdded.B { public struct S { public int P { get; set; } } }

    namespace PropertySetAdded.A { public struct S { public int P { get; } } }
    namespace PropertySetAdded.B { public struct S { public int P { get; set; } } }

    namespace PropertyGetRemoved.A { public struct S { public int P { get; set; } } }
    namespace PropertyGetRemoved.B { public struct S { public int P { set { } } } }

    namespace PropertySetRemoved.A { public struct S { public int P { get; set; } } }
    namespace PropertySetRemoved.B { public struct S { public int P { get; } } }

    public class StructPropertyTest : TestBase
    {
        [Fact] public void PropertyAdded() => TestMinor(Cause.PropertyAdded);
        [Fact] public void PropertyRemoved() => TestMajor(Cause.PropertyRemoved);
        [Fact] public void PropertyMadeExported() => TestMinor(Cause.PropertyMadeExported);
        [Fact] public void PropertyMadeNotExported() => TestMajor(Cause.PropertyMadeNotExported);
        [Fact] public void PropertyTypeChanged() => TestMajor(Cause.PropertyTypeChanged);
        [Fact] public void PropertyToStatic() => TestMajor(Cause.PropertyMadeStatic);
        [Fact] public void PropertyFromStatic() => TestMajor(Cause.PropertyMadeNonStatic);
        [Fact] public void PropertyGetAccessModiferChange1() => TestMajor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertyGetAccessModiferChange2() => TestMinor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertySetAccessModiferChange1() => TestMajor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertySetAccessModiferChange2() => TestMinor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertyGetAdded() => TestMinor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertySetAdded() => TestMinor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertyGetRemoved() => TestMajor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertySetRemoved() => TestMajor(Cause.PropertyAccessModifierChanged);
    }
}

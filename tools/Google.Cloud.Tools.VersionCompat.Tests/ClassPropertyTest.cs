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

namespace Google.Cloud.Tools.VersionCompat.Tests.ClassProperty
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

    namespace PropertyModiferChanged1.A { public abstract class C { public virtual int P { get; } } }
    namespace PropertyModiferChanged1.B { public abstract class C { public int P { get; } } }

    namespace PropertyModiferChanged2.A { public abstract class C { public virtual int P { get; } } }
    namespace PropertyModiferChanged2.B { public abstract class C { public abstract int P { get; } } }

    public abstract class Base { public abstract int P { get; } }

    namespace PropertyModiferChanged3.A { public abstract class C : Base { public override int P { get; } } }
    namespace PropertyModiferChanged3.B { public abstract class C : Base { public sealed override int P { get; } } }

    namespace PropertyModiferChanged4.A { public abstract class C { public int P { get; } } }
    namespace PropertyModiferChanged4.B { public abstract class C { public virtual int P { get; } } }

    namespace PropertyModiferChanged5.A { public abstract class C { public abstract int P { get; } } }
    namespace PropertyModiferChanged5.B { public abstract class C { public virtual int P { get; } } }

    namespace PropertyModiferChanged6.A { public abstract class C : Base { public sealed override int P { get; } } }
    namespace PropertyModiferChanged6.B { public abstract class C : Base { public override int P { get; } } }

    namespace PropertyGetAccessModiferChange1.A { public class C { public int P { get; set; } } }
    namespace PropertyGetAccessModiferChange1.B { public class C { public int P { protected get; set; } } }

    namespace PropertyGetAccessModiferChange2.A { public class C { public int P { get; set; } } }
    namespace PropertyGetAccessModiferChange2.B { public class C { public int P { private get; set; } } }

    namespace PropertyGetAccessModiferChange3.A { public class C { public int P { protected get; set; } } }
    namespace PropertyGetAccessModiferChange3.B { public class C { public int P { private get; set; } } }

    namespace PropertyGetAccessModiferChange4.A { public class C { public int P { protected get; set; } } }
    namespace PropertyGetAccessModiferChange4.B { public class C { public int P { get; set; } } }

    namespace PropertyGetAccessModiferChange5.A { public class C { public int P { private get; set; } } }
    namespace PropertyGetAccessModiferChange5.B { public class C { public int P { get; set; } } }

    namespace PropertyGetAccessModiferChange6.A { public class C { public int P { private get; set; } } }
    namespace PropertyGetAccessModiferChange6.B { public class C { public int P { protected get; set; } } }

    namespace PropertySetAccessModiferChange1.A { public class C { public int P { get; set; } } }
    namespace PropertySetAccessModiferChange1.B { public class C { public int P { get; protected set; } } }

    namespace PropertySetAccessModiferChange2.A { public class C { public int P { get; set; } } }
    namespace PropertySetAccessModiferChange2.B { public class C { public int P { get; private set; } } }

    namespace PropertySetAccessModiferChange3.A { public class C { public int P { get; protected set; } } }
    namespace PropertySetAccessModiferChange3.B { public class C { public int P { get; private set; } } }

    namespace PropertySetAccessModiferChange4.A { public class C { public int P { get; protected set; } } }
    namespace PropertySetAccessModiferChange4.B { public class C { public int P { get; set; } } }

    namespace PropertySetAccessModiferChange5.A { public class C { public int P { get; private set; } } }
    namespace PropertySetAccessModiferChange5.B { public class C { public int P { get; set; } } }

    namespace PropertySetAccessModiferChange6.A { public class C { public int P { get; private set; } } }
    namespace PropertySetAccessModiferChange6.B { public class C { public int P { get; protected set; } } }

    namespace PropertyGetAdded.A { public class C { public int P { set { } } } }
    namespace PropertyGetAdded.B { public class C { public int P { get; set; } } }

    namespace PropertySetAdded.A { public class C { public int P { get; } } }
    namespace PropertySetAdded.B { public class C { public int P { get; set; } } }

    namespace PropertyGetRemoved.A { public class C { public int P { get; set; } } }
    namespace PropertyGetRemoved.B { public class C { public int P { set { } } } }

    namespace PropertySetRemoved.A { public class C { public int P { get; set; } } }
    namespace PropertySetRemoved.B { public class C { public int P { get; } } }

    public class ClassPropertyTest : TestBase
    {
        [Fact] public void PropertyAdded() => TestMinor(Cause.PropertyAdded);
        [Fact] public void PropertyRemoved() => TestMajor(Cause.PropertyRemoved);
        [Fact] public void PropertyMadeExported() => TestMinor(Cause.PropertyMadeExported);
        [Fact] public void PropertyMadeNotExported() => TestMajor(Cause.PropertyMadeNotExported);
        [Fact] public void PropertyTypeChanged() => TestMajor(Cause.PropertyTypeChanged);
        [Fact] public void PropertyToStatic() => TestMajor(Cause.PropertyMadeStatic);
        [Fact] public void PropertyFromStatic() => TestMajor(Cause.PropertyMadeNonStatic);
        [Fact] public void PropertyModiferChanged1() => TestMajor(Cause.PropertyModifierChanged);
        [Fact] public void PropertyModiferChanged2() => TestMajor(Cause.PropertyModifierChanged);
        [Fact] public void PropertyModiferChanged3() => TestMajor(Cause.PropertyModifierChanged);
        [Fact] public void PropertyModiferChanged4() => TestMinor(Cause.PropertyModifierChanged);
        [Fact] public void PropertyModiferChanged5() => TestMinor(Cause.PropertyModifierChanged);
        [Fact] public void PropertyModiferChanged6() => TestMinor(Cause.PropertyModifierChanged);
        [Fact] public void PropertyGetAccessModiferChange1() => TestMajor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertyGetAccessModiferChange2() => TestMajor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertyGetAccessModiferChange3() => TestMajor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertyGetAccessModiferChange4() => TestMinor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertyGetAccessModiferChange5() => TestMinor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertyGetAccessModiferChange6() => TestMinor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertySetAccessModiferChange1() => TestMajor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertySetAccessModiferChange2() => TestMajor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertySetAccessModiferChange3() => TestMajor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertySetAccessModiferChange4() => TestMinor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertySetAccessModiferChange5() => TestMinor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertySetAccessModiferChange6() => TestMinor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertyGetAdded() => TestMinor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertySetAdded() => TestMinor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertyGetRemoved() => TestMajor(Cause.PropertyAccessModifierChanged);
        [Fact] public void PropertySetRemoved() => TestMajor(Cause.PropertyAccessModifierChanged);
    }
}

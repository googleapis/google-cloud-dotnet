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
    }
}

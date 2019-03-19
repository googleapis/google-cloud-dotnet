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

namespace Google.Cloud.Tools.VersionCompat.Tests.Interface
{
    namespace NoChange.A { public interface I { } }
    namespace NoChange.B { public interface I { } }

    public interface I1 { }

    namespace InterfaceAdded.A { public interface I { } }
    namespace InterfaceAdded.B { public interface I : I1 { } }

    namespace InterfaceRemoved.A { public interface I : I1 { } }
    namespace InterfaceRemoved.B { public interface I { } }

    namespace MethodAdded.A { public interface I { } }
    namespace MethodAdded.B { public interface I { void M(); } }

    namespace MethodRemoved.A { public interface I { void M(); } }
    namespace MethodRemoved.B { public interface I { } }

    namespace PropertyAdded.A { public interface I { } }
    namespace PropertyAdded.B { public interface I { int P { get; } } }

    namespace PropertyRemoved.A { public interface I { int P { get; } } }
    namespace PropertyRemoved.B { public interface I { } }

    namespace ReturnTypeChanged1.A { public interface I { void A(); } }
    namespace ReturnTypeChanged1.B { public interface I { int A(); } }

    namespace ReturnTypeChanged2.A { public interface I { IEnumerable<int> A(); } }
    namespace ReturnTypeChanged2.B { public interface I { IEnumerable<long> A(); } }

    namespace ParamNameChanged.A { public interface I { void A(int i); } }
    namespace ParamNameChanged.B { public interface I { void A(int j); } }

    namespace ParamInOutChanged1.A { public interface I { void A(in string s); } }
    namespace ParamInOutChanged1.B { public interface I { void A(ref string s); } }

    namespace ParamInOutChanged2.A { public interface I { void A(ref string s); } }
    namespace ParamInOutChanged2.B { public interface I { void A(out string s); } }

    public class InterfaceTest : TestBase
    {
        [Fact] public void NoChange() => TestNone();
        [Fact] public void InterfaceAdded() => TestMajor(Cause.TypeImplementedInterfaceAdded);
        [Fact] public void InterfaceRemoved() => TestMajor(Cause.TypeImplementedInterfaceRemoved);
        [Fact] public void MethodAdded() => TestMajor(Cause.MethodAdded);
        [Fact] public void MethodRemoved() => TestMajor(Cause.MethodRemoved);
        [Fact] public void PropertyAdded() => TestMajor(Cause.PropertyAdded);
        [Fact] public void PropertyRemoved() => TestMajor(Cause.PropertyRemoved);
        [Fact] public void ReturnTypeChanged1() => TestMajor(Cause.MethodReturnTypeChanged);
        [Fact] public void ReturnTypeChanged2() => TestMajor(Cause.MethodReturnTypeChanged);
        [Fact] public void ParamNameChanged() => TestMajor(Cause.MethodParameterNameChanged);
        [Fact] public void ParamInOutChanged1() => TestMajor(Cause.MethodParameterInOutChanged);
        [Fact] public void ParamInOutChanged2() => TestMajor(Cause.MethodParameterInOutChanged);
    }
}

// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Xunit;

namespace Google.Cloud.Tools.VersionCompat.Tests.ClassConstant
{
    namespace NoChange.A { public class S { public const string A = "Same"; } }
    namespace NoChange.B { public class S { public const string A = "Same"; } }

    namespace ConstantAdded.A { public class S { } }
    namespace ConstantAdded.B { public class S { public const string A = ""; } }

    namespace ConstantRemoved.A { public class S { public const string A = ""; } }
    namespace ConstantRemoved.B { public class S { } }

    namespace ConstantMadeExported.A { public class S { private const string A = ""; } }
    namespace ConstantMadeExported.B { public class S { public const string A = ""; } }

    namespace ConstantMadeNotExported.A { public class S { public const string A = ""; } }
    namespace ConstantMadeNotExported.B { public class S { private const string A = ""; } }

    namespace TypeChanged.A { public class S { public const string A = ""; } }
    namespace TypeChanged.B { public class S { public const int A = 0; } }

    namespace ValueChanged.A { public class S { public const string A = "X"; } }
    namespace ValueChanged.B { public class S { public const string A = "Y"; } }

    public class ClassConstantTest : TestBase
    {
        [Fact] public void NoChange() => TestNone();
        [Fact] public void ConstantAdded() => TestMinor(Cause.ConstantAdded);
        [Fact] public void ConstantRemoved() => TestMajor(Cause.ConstantRemoved);
        [Fact] public void ConstantMadeExported() => TestMinor(Cause.ConstantMadeExported);
        [Fact] public void ConstantMadeNotExported() => TestMajor(Cause.ConstantMadeNotExported);
        [Fact] public void TypeChanged() => TestMajor(Cause.ConstantTypeChanged);
        [Fact] public void ValueChanged() => TestMajor(Cause.ConstantValueChanged);
    }
}

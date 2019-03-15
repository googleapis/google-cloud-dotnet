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

namespace Google.Cloud.Tools.VersionCompat.Tests.Enum
{
    namespace Unchanged.A { public enum E { V } }
    namespace Unchanged.B { public enum E { V } }

    namespace UnderlyingTypeChange.A { public enum E : int { } }
    namespace UnderlyingTypeChange.B { public enum E : short { } }

    namespace ValueChange.A { public enum E { V = 1 } }
    namespace ValueChange.B { public enum E { V = 2 } }

    namespace ValueAdded.A { public enum E { } }
    namespace ValueAdded.B { public enum E { V = 2 } }

    namespace ValueRemoved.A { public enum E { V = 2 } }
    namespace ValueRemoved.B { public enum E { } }

    public class EnumTest : TestBase
    {
        [Fact] public void Unchanged() => TestNone();
        [Fact] public void UnderlyingTypeChange() => TestMajor(Cause.EnumUnderlyingTypeChanged);
        [Fact] public void ValueChange() => TestMajor(Cause.EnumValueChanged);
        [Fact] public void ValueAdded() => TestMinor(Cause.EnumValueAdded);
        [Fact] public void ValueRemoved() => TestMajor(Cause.EnumValueRemoved);
    }
}

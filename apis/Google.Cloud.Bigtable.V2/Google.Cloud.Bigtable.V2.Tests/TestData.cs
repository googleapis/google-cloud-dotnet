// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Bigtable.Common.V2;
using Google.Protobuf;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class TestData
    {
        public static TheoryData<string> ValidFamilyNames { get; } = new TheoryData<string>
        {
            "a",
            "A",
            "-_.aZ09"
        };

        public static TheoryData<string> InvalidFamilyNames { get; } = new TheoryData<string>
        {
            default,
            "",
            "abc*",
            "abc ",
            "a=b"
        };

        public static TheoryData<BigtableByteString> InvalidRowKeys { get; } = new TheoryData<BigtableByteString>
        {
            "",
            new byte[0],
            ByteString.Empty,
            default
        };
    }
}

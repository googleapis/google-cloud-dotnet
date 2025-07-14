// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

namespace Google.Cloud.Tools.Common.Tests;

public class StructuredVersionTest
{
    [Theory]
    [InlineData("0.1.0", 0, 1, 0, null, null, false)]
    [InlineData("1.2.3-beta01", 1, 2, 3, null, "beta01", false)]
    [InlineData("1.2.3", 1, 2, 3, null, null, true)]
    [InlineData("1.2.3.4", 1, 2, 3, 4, null, true)]
    public void FromString_Valid(string text, int major, int minor, int patch, int? build, string prerelease, bool stable)
    {
        var parsed = StructuredVersion.FromString(text);
        Assert.Equal(major, parsed.Major);
        Assert.Equal(minor, parsed.Minor);
        Assert.Equal(patch, parsed.Patch);
        Assert.Equal(build, parsed.Build);
        Assert.Equal(prerelease, parsed.Prerelease);
        Assert.Equal(stable, parsed.IsStable);
        Assert.Equal(text, parsed.ToString());
    }

    [Theory]
    [InlineData("1")]
    [InlineData("1.2")]
    [InlineData("1.2.3.4.5")]
    [InlineData("bad")]
    [InlineData("bad-1.0.0")]
    [InlineData("1.bad.0.1")]
    public void FromString_Invalid(string text)
    {
        Assert.Throws<ArgumentException>(() => StructuredVersion.FromString(text));
    }
}

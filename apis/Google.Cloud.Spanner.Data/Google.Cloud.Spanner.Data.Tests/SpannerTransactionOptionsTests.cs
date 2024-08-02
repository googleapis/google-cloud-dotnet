// Copyright 2024 Google LLC
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

namespace Google.Cloud.Spanner.Data.Tests;
public class SpannerTransactionOptionsTests
{
    [Fact]
    public void Default_Values()
    {
        var options = new SpannerTransactionOptions();
        Assert.Null(options.MaxCommitDelay);
    }

    public static TheoryData<TimeSpan?> ValidMaxCommitDelayValues => SpannerTransactionTests.ValidMaxCommitDelayValues;

    [Theory, MemberData(nameof(ValidMaxCommitDelayValues))]
    public void MaxCommitDelay_Valid(TimeSpan? maxCommitDelay)
    {
        var options = new SpannerTransactionOptions
        {
            MaxCommitDelay = maxCommitDelay
        };

        Assert.Equal(maxCommitDelay, options.MaxCommitDelay);
    }

    public static TheoryData<TimeSpan?> InvalidMaxCommitDelayValues => SpannerTransactionTests.InvalidMaxCommitDelayValues;

    [Theory, MemberData(nameof(InvalidMaxCommitDelayValues))]
    public void MaxCommitDelay_Invalid(TimeSpan? maxCommitDelay)
    {
        var options = new SpannerTransactionOptions();
        Assert.Throws<ArgumentOutOfRangeException>(() => options.MaxCommitDelay = maxCommitDelay);
    }

    [Fact]
    public void CopyConstructor()
    {
        var options = new SpannerTransactionOptions
        {
            MaxCommitDelay = TimeSpan.FromSeconds(10)
        };
        var optionsCopy = new SpannerTransactionOptions(options);

        Assert.Equal(options.MaxCommitDelay, optionsCopy.MaxCommitDelay);
    }
}

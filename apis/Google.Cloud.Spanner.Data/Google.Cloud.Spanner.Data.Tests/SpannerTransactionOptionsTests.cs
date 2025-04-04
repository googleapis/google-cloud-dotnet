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
        Assert.Null(options.CommitTimeout);
        Assert.Null(options.CommitPriority);
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

    [Theory]
    [InlineData(0)]
    [InlineData(100)]
    [InlineData(int.MaxValue)]
    public void CommitTimeout_Valid(int commitTimeout)
    {
        var options = new SpannerTransactionOptions
        {
            CommitTimeout = commitTimeout
        };

        Assert.Equal(commitTimeout, options.CommitTimeout);
    }    

    [Theory]
    [InlineData(-1)]
    [InlineData(-100)]
    [InlineData(int.MinValue)]
    public void CommitTimeout_Invalid(int commitTimeout)
    {
        var options = new SpannerTransactionOptions();
        Assert.Throws<ArgumentOutOfRangeException>(() => options.CommitTimeout = commitTimeout);
    }

    [Theory]
    [InlineData(null, 90, 90)]
    [InlineData(10, 90, 10)]
    public void CommitTimeout_Effective(int? optionsCommitTimeout, int connectionTimeout, int effectiveTimeout)
    {
        var options = new SpannerTransactionOptions
        {
            CommitTimeout = optionsCommitTimeout
        };

        SpannerConnectionStringBuilder builder = new SpannerConnectionStringBuilder
        {
            Timeout = connectionTimeout
        };

        Assert.Equal(effectiveTimeout, options.EffectiveCommitTimeout(new SpannerConnection(builder)));
    }

    [Theory]
    [InlineData(null, TransactionMode.ReadOnly, Priority.Unspecified)]
    [InlineData(Priority.High, TransactionMode.ReadOnly, Priority.Unspecified)]
    [InlineData(null, TransactionMode.ReadWrite, Priority.Unspecified)]
    [InlineData(Priority.High, TransactionMode.ReadWrite, Priority.High)]
    public void CommitPriority_Effective(Priority? priority, TransactionMode mode, Priority effectivePriority)
    {
        var options = new SpannerTransactionOptions
        {
            CommitPriority = priority
        };

        Assert.Equal(effectivePriority, options.EffectivePriority(mode));
    }

    [Fact]
    public void CopyConstructor()
    {
        var options = new SpannerTransactionOptions
        {
            MaxCommitDelay = TimeSpan.FromSeconds(10),
            CommitTimeout = 10,
            CommitPriority = Priority.High,
        };
        var optionsCopy = new SpannerTransactionOptions(options);

        Assert.Equal(options.MaxCommitDelay, optionsCopy.MaxCommitDelay);
        Assert.Equal(options.CommitTimeout, optionsCopy.CommitTimeout);
        Assert.Equal(options.CommitPriority, optionsCopy.CommitPriority);
    }
}

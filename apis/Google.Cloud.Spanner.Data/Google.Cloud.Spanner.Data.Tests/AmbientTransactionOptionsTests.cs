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
public class AmbientTransactionOptionsTests
{
    [Fact]
    public void Default_Singleton()
    {
        var one = AmbientTransactionOptions.Default;
        Assert.NotNull(one);
        var two = AmbientTransactionOptions.Default;
        Assert.Same(one, two);
    }

    [Fact]
    public void Default_Values()
    {
        Assert.Null(AmbientTransactionOptions.Default.CommitDelay);
        Assert.Null(AmbientTransactionOptions.Default.TimestampBound);
        Assert.Null(AmbientTransactionOptions.Default.TransactionId);
    }

    public static TheoryData<TimeSpan?> ValidCommitDelayValues => SpannerTransactionTests.ValidCommitDelayValues;

    [Theory, MemberData(nameof(ValidCommitDelayValues))]
    public void WithCommitDelay_Valid(TimeSpan? commitDelay)
    {
        var custom = AmbientTransactionOptions.Default.WithCommitDelay(commitDelay);
        Assert.NotSame(AmbientTransactionOptions.Default, custom);
        Assert.Equal(commitDelay, custom.CommitDelay);
    }

    public static TheoryData<TimeSpan?> InvalidCommitDelayValues => SpannerTransactionTests.InvalidCommitDelayValues;

    [Theory, MemberData(nameof(InvalidCommitDelayValues))]
    public void WithCommitDelay_Invalid(TimeSpan? commitDelay) =>
        Assert.Throws<ArgumentOutOfRangeException>(() => AmbientTransactionOptions.Default.WithCommitDelay(commitDelay));

    [Fact]
    public void ForTimestampBoundReadOnly_Default()
    {
        var options = AmbientTransactionOptions.ForTimestampBoundReadOnly();
        Assert.Equal(TimestampBound.Strong, options.TimestampBound);
    }

    [Fact]
    public void ForTimestampBoundReadOnly_Custom()
    {
        var timestampBound = TimestampBound.OfMinReadTimestamp(DateTimeOffset.MinValue.UtcDateTime);
        var options = AmbientTransactionOptions.ForTimestampBoundReadOnly(timestampBound);
        Assert.Equal(timestampBound, options.TimestampBound);
    }

    [Fact]
    public void FromReadOnlyTransactionId_Null() =>
        Assert.Throws<ArgumentNullException>(() => AmbientTransactionOptions.FromReadOnlyTransactionId(null));


    [Fact]
    public void FromReadOnlyTransactionId_NotNull()
    {
        var transactionId = new TransactionId("connection-string", "session", "id", TimestampBound.Strong);
        var options = AmbientTransactionOptions.FromReadOnlyTransactionId(transactionId);
        Assert.Equal(transactionId, options.TransactionId);
    }
}

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

using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Cloud.Spanner.V1.Tests;
using System;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests;
public class SpannerTransactionTests
{
    public static TheoryData<TimeSpan?> ValidMaxCommitDelayValues { get; } = new TheoryData<TimeSpan?>
    {
        null,
        TimeSpan.Zero,
        TimeSpan.FromMilliseconds(100),
        TimeSpan.MaxValue,
    };

    public static TheoryData<TimeSpan?> InvalidMaxCommitDelayValues { get; } = new TheoryData<TimeSpan?>
    {
        TimeSpan.MinValue,
        TimeSpan.FromMilliseconds(-100),
        TimeSpan.FromMilliseconds(-1),
    };

    [Fact]
    public void MaxCommitDelay_DefaultsToNull()
    {
        SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        spannerClientMock.SetupBatchCreateSessionsAsync();
        SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
        SpannerTransaction transaction = connection.BeginTransaction();

        Assert.Null(transaction.TransactionOptions.MaxCommitDelay);
    }

    [Theory, MemberData(nameof(ValidMaxCommitDelayValues))]
    public void MaxCommitDelay_Valid(TimeSpan? maxCommitDelay)
    {
        SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        spannerClientMock.SetupBatchCreateSessionsAsync();
        SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
        SpannerTransaction transaction = connection.BeginTransaction();

        transaction.TransactionOptions.MaxCommitDelay = maxCommitDelay;
        Assert.Equal(maxCommitDelay, transaction.TransactionOptions.MaxCommitDelay);
    }

    [Theory, MemberData(nameof(InvalidMaxCommitDelayValues))]
    public void MaxCommitDelay_Invalid(TimeSpan? maxCommitdelay)
    {
        SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        spannerClientMock.SetupBatchCreateSessionsAsync();
        SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
        SpannerTransaction transaction = connection.BeginTransaction();

        Assert.Throws<ArgumentOutOfRangeException>(() => transaction.TransactionOptions.MaxCommitDelay = maxCommitdelay);
    }

    [Fact]
    public void SpannerTransactionOptions_FromBeginTransaction()
    {
        TimeSpan commitDelay = TimeSpan.FromMilliseconds(100);
        int commitTimeout = 10;
        Priority commitPriority = Priority.High;
        string tag = "tag";
        DisposeBehavior disposeBehavior = DisposeBehavior.CloseResources;

        SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        spannerClientMock.SetupBatchCreateSessionsAsync();
        SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
        SpannerTransaction transaction = connection.BeginTransaction(SpannerTransactionCreationOptions.ReadWrite, new SpannerTransactionOptions
        {
            MaxCommitDelay = commitDelay,
            CommitTimeout = commitTimeout,
            CommitPriority = commitPriority,
            Tag = tag,
            DisposeBehavior = DisposeBehavior.CloseResources,
            LogCommitStats = true
        });

        Assert.Equal(commitDelay, transaction.TransactionOptions.MaxCommitDelay);
        Assert.Equal(commitTimeout, transaction.TransactionOptions.CommitTimeout);
        Assert.Equal(commitPriority, transaction.TransactionOptions.CommitPriority);
        Assert.Equal(tag, transaction.TransactionOptions.Tag);
        Assert.Equal(disposeBehavior, transaction.TransactionOptions.DisposeBehavior);
        Assert.True(transaction.TransactionOptions.LogCommitStats);
    }
}

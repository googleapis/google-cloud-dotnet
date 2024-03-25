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
    public static TheoryData<TimeSpan?> ValidCommitDelayValues { get; } = new TheoryData<TimeSpan?>
    {
        null,
        TimeSpan.Zero,
        TimeSpan.FromMilliseconds(100),
        TimeSpan.MaxValue,
    };

    public static TheoryData<TimeSpan?> InvalidCommitDelayValues { get; } = new TheoryData<TimeSpan?>
    {
        TimeSpan.MinValue,
        TimeSpan.FromMilliseconds(-100),
        TimeSpan.FromMilliseconds(-1),
    };

    [Fact]
    public void CommitDelay_DefaultsToNull()
    {
        SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        spannerClientMock.SetupBatchCreateSessionsAsync();
        SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
        SpannerTransaction transaction = connection.BeginTransaction();

        Assert.Null(transaction.CommitDelay);
    }

    [Theory, MemberData(nameof(ValidCommitDelayValues))]
    public void CommitDelay_Valid(TimeSpan? value)
    {
        SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        spannerClientMock.SetupBatchCreateSessionsAsync();
        SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
        SpannerTransaction transaction = connection.BeginTransaction();

        transaction.CommitDelay = value;
        Assert.Equal(value, transaction.CommitDelay);
    }

    [Theory, MemberData(nameof(InvalidCommitDelayValues))]
    public void CommitDelay_Invalid(TimeSpan? value)
    {
        SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
        spannerClientMock.SetupBatchCreateSessionsAsync();
        SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
        SpannerTransaction transaction = connection.BeginTransaction();

        Assert.Throws<ArgumentOutOfRangeException>(() => transaction.CommitDelay = value);
    }
}

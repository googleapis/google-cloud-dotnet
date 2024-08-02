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
public class SpannerTransactionCreationOptionsTests
{
    [Fact]
    public void Default_Singleton()
    {
        var one = SpannerTransactionCreationOptions.Default;
        Assert.NotNull(one);
        var two = SpannerTransactionCreationOptions.Default;
        Assert.Same(one, two);
    }

    [Fact]
    public void Default_Values()
    {
        Assert.Null(SpannerTransactionCreationOptions.Default.TimestampBound);
        Assert.Null(SpannerTransactionCreationOptions.Default.TransactionId);
    }

    [Fact]
    public void ForTimestampBoundReadOnly_Default()
    {
        var options = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly();
        Assert.Equal(TimestampBound.Strong, options.TimestampBound);
    }

    [Fact]
    public void ForTimestampBoundReadOnly_Custom()
    {
        var timestampBound = TimestampBound.OfMinReadTimestamp(DateTimeOffset.MinValue.UtcDateTime);
        var options = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(timestampBound);
        Assert.Equal(timestampBound, options.TimestampBound);
    }

    [Fact]
    public void FromReadOnlyTransactionId_Null() =>
        Assert.Throws<ArgumentNullException>(() => SpannerTransactionCreationOptions.FromReadOnlyTransactionId(null));


    [Fact]
    public void FromReadOnlyTransactionId_NotNull()
    {
        var transactionId = new TransactionId("connection-string", "session", "id", TimestampBound.Strong);
        var options = SpannerTransactionCreationOptions.FromReadOnlyTransactionId(transactionId);
        Assert.Equal(transactionId, options.TransactionId);
    }
}

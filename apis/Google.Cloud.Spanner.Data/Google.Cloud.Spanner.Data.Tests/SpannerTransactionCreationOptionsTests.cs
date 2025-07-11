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
using System;
using Xunit;
using static Google.Cloud.Spanner.V1.TransactionOptions.Types;
using IsolationLevel = System.Data.IsolationLevel;
using SpannerIsolationLevel = Google.Cloud.Spanner.V1.TransactionOptions.Types.IsolationLevel;

namespace Google.Cloud.Spanner.Data.Tests;
public class SpannerTransactionCreationOptionsTests
{
    [Fact]
    public void ReadWrite_Singleton()
    {
        var one = SpannerTransactionCreationOptions.ReadWrite;
        Assert.NotNull(one);
        var two = SpannerTransactionCreationOptions.ReadWrite;
        Assert.Same(one, two);
    }

    [Fact]
    public void PartitionedDml_Singleton()
    {
        var one = SpannerTransactionCreationOptions.PartitionedDml;
        Assert.NotNull(one);
        var two = SpannerTransactionCreationOptions.PartitionedDml;
        Assert.Same(one, two);
    }

    [Fact]
    public void ReadOnly_Singleton()
    {
        var one = SpannerTransactionCreationOptions.ReadOnly;
        Assert.NotNull(one);
        var two = SpannerTransactionCreationOptions.ReadOnly;
        Assert.Same(one, two);
    }

    [Fact]
    public void ReadWrite_Values()
    {
        var readWrite = SpannerTransactionCreationOptions.ReadWrite;

        Assert.Null(readWrite.TimestampBound);
        Assert.Null(readWrite.TransactionId);
        Assert.Equal(TransactionMode.ReadWrite, readWrite.TransactionMode);
        Assert.False(readWrite.IsDetached);
        Assert.False(readWrite.IsSingleUse);
        Assert.False(readWrite.IsPartitionedDml);
        Assert.False(readWrite.ExcludeFromChangeStreams);
        Assert.Equal(IsolationLevel.Unspecified, readWrite.IsolationLevel);
        Assert.Equal(new TransactionOptions { ReadWrite = new ReadWrite() }, readWrite.GetTransactionOptions());
    }

    [Fact]
    public void PartitionedDml_Values()
    {
        var partitionedDml = SpannerTransactionCreationOptions.PartitionedDml;

        Assert.Null(partitionedDml.TimestampBound);
        Assert.Null(partitionedDml.TransactionId);
        Assert.Equal(TransactionMode.ReadWrite, partitionedDml.TransactionMode);
        Assert.False(partitionedDml.IsDetached);
        Assert.False(partitionedDml.IsSingleUse);
        Assert.True(partitionedDml.IsPartitionedDml);
        Assert.False(partitionedDml.ExcludeFromChangeStreams);
        Assert.Equal(IsolationLevel.Unspecified, partitionedDml.IsolationLevel);
        Assert.Equal(new TransactionOptions { PartitionedDml = new PartitionedDml() }, partitionedDml.GetTransactionOptions());
    }

    [Fact]
    public void ReadOnly_Values()
    {
        var readOnly = SpannerTransactionCreationOptions.ReadOnly;

        Assert.Equal(TimestampBound.Strong, readOnly.TimestampBound);
        Assert.Null(readOnly.TransactionId);
        Assert.Equal(TransactionMode.ReadOnly, readOnly.TransactionMode);
        Assert.False(readOnly.IsDetached);
        Assert.False(readOnly.IsSingleUse);
        Assert.False (readOnly.IsPartitionedDml);
        Assert.False(readOnly.ExcludeFromChangeStreams);
        Assert.Equal(IsolationLevel.Unspecified, readOnly.IsolationLevel);
        Assert.Equal(TimestampBound.Strong.ToTransactionOptions(), readOnly.GetTransactionOptions());
    }

    [Fact]
    public void ForTimestampBoundReadOnly_Null()
    {
        var options = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(null);
        Assert.Equal(TimestampBound.Strong, options.TimestampBound);
        Assert.Null(options.TransactionId);
        Assert.Equal(TransactionMode.ReadOnly, options.TransactionMode);
        Assert.False(options.IsDetached);
        Assert.False(options.IsSingleUse);
        Assert.False(options.IsPartitionedDml);
        Assert.False(options.ExcludeFromChangeStreams);
        Assert.Equal(IsolationLevel.Unspecified, options.IsolationLevel);
        Assert.Equal(TimestampBound.Strong.ToTransactionOptions(), options.GetTransactionOptions());
    }

    [Fact]
    public void ForTimestampBoundReadOnly_Custom()
    {
        var timestampBound = TimestampBound.OfMinReadTimestamp(DateTimeOffset.MinValue.UtcDateTime);
        var options = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(timestampBound);
        Assert.Equal(timestampBound, options.TimestampBound);
        Assert.Null(options.TransactionId);
        Assert.Equal(TransactionMode.ReadOnly, options.TransactionMode);
        Assert.False(options.IsDetached);
        Assert.True(options.IsSingleUse);
        Assert.False(options.IsPartitionedDml);
        Assert.False(options.ExcludeFromChangeStreams);
        Assert.Equal(IsolationLevel.Unspecified, options.IsolationLevel);
        Assert.Equal(timestampBound.ToTransactionOptions(), options.GetTransactionOptions());
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
        Assert.Null(options.TimestampBound);
        Assert.Equal(TransactionMode.ReadOnly, options.TransactionMode);
        Assert.True(options.IsDetached);
        Assert.False(options.IsSingleUse);
        Assert.False(options.IsPartitionedDml);
        Assert.False(options.ExcludeFromChangeStreams);
        Assert.Equal(IsolationLevel.Unspecified, options.IsolationLevel);
        Assert.Null(options.GetTransactionOptions());
    }

    [Fact]
    public void WithIsDetached()
    {
        var options = SpannerTransactionCreationOptions.ReadWrite.WithIsDetached(true);
        Assert.True(options.IsDetached);
        options = options.WithIsDetached(false);
        Assert.False(options.IsDetached);
    }

    [Fact]
    public void WithIsDetachedFalse_TransactionId()
    {
        var transactionId = new TransactionId("connection-string", "session", "id", TimestampBound.Strong);
        var options = SpannerTransactionCreationOptions.FromReadOnlyTransactionId(transactionId);
        options = options.WithIsDetached(true);
        Assert.True(options.IsDetached);
        Assert.Throws<ArgumentException>(() => options.WithIsDetached(false));
    }

    [Fact]
    public void SingleUse_MinReadTimestamp()
    {
        var timestampBound = TimestampBound.OfMinReadTimestamp(DateTimeOffset.MinValue.UtcDateTime);
        var options = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(timestampBound);

        Assert.True(options.IsSingleUse);

        Assert.Throws<ArgumentException>(() => options.WithIsSingleUse(false));
    }

    [Fact]
    public void SingleUse_MaxStaleness()
    {
        var timestampBound = TimestampBound.OfMaxStaleness(TimeSpan.FromHours(1));
        var options = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(timestampBound);

        Assert.True(options.IsSingleUse);

        Assert.Throws<ArgumentException>(() => options.WithIsSingleUse(false));
    }

    [Fact]
    public void SingleUse_TimestampBound()
    {
        var options = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(TimestampBound.Strong);

        Assert.False(options.IsSingleUse);
        options = options.WithIsSingleUse(true);
        Assert.True(options.IsSingleUse);
    }

    [Fact]
    public void SingleUse_NonTimestampBound()
    {
        var transactionId = new TransactionId("connection-string", "session", "id", TimestampBound.Strong);
        var options = SpannerTransactionCreationOptions.FromReadOnlyTransactionId(transactionId);

        Assert.False(options.IsSingleUse);
        Assert.Throws<ArgumentException>(() => options.WithIsSingleUse(true));
    }

    [Fact]
    public void ExcludeFromChangeStream_ReadOnly() =>
        Assert.Throws<ArgumentException>(() => SpannerTransactionCreationOptions.ReadOnly.WithExcludeFromChangeStreams(true));

    [Fact]
    public void ExcludeFromChangeStream_ReadWrite()
    {
        var options = SpannerTransactionCreationOptions.ReadWrite.WithExcludeFromChangeStreams(true);
        Assert.True(options.ExcludeFromChangeStreams);
    }

    [Fact]
    public void ExcludeFromChangeStream_PartitionedDml()
    {
        var options = SpannerTransactionCreationOptions.PartitionedDml.WithExcludeFromChangeStreams(true);
        Assert.True(options.ExcludeFromChangeStreams);
    }

    [Fact]
    public void IsolationLevel_ReadOnly() =>
        Assert.Throws<ArgumentException>(() => SpannerTransactionCreationOptions.ReadOnly.WithIsolationLevel(IsolationLevel.RepeatableRead));

    [Fact]
    public void IsolationLevel_ReadWrite()
    {
        var options = SpannerTransactionCreationOptions.ReadWrite.WithIsolationLevel(IsolationLevel.RepeatableRead);
        Assert.Equal(IsolationLevel.RepeatableRead, options.IsolationLevel);
    }

    [Fact]
    public void IsolationLevel_PartitionedDml()
    {
        var options = SpannerTransactionCreationOptions.PartitionedDml.WithIsolationLevel(IsolationLevel.RepeatableRead);
        Assert.Equal(IsolationLevel.RepeatableRead, options.IsolationLevel);
    }

    [Theory]
    [InlineData(IsolationLevel.RepeatableRead, SpannerIsolationLevel.RepeatableRead)]
    [InlineData(IsolationLevel.Snapshot, SpannerIsolationLevel.RepeatableRead)]
    [InlineData(IsolationLevel.Unspecified, SpannerIsolationLevel.Unspecified)]
    [InlineData(IsolationLevel.Serializable, SpannerIsolationLevel.Serializable)]
    public void IsolationLevel_ConversionCorrectness(IsolationLevel clientIsolationLevel, SpannerIsolationLevel expectedConvertedIsolationLevel)
    {
        var spannerTxnOptions = SpannerTransactionCreationOptions.PartitionedDml.WithIsolationLevel(clientIsolationLevel);
        var transactionOptions = spannerTxnOptions.GetTransactionOptions();

        Assert.Equal(expectedConvertedIsolationLevel, transactionOptions.IsolationLevel);
    }

    [Theory]
    [InlineData(IsolationLevel.ReadCommitted)]
    [InlineData(IsolationLevel.ReadUncommitted)]
    [InlineData(IsolationLevel.Chaos)]
    public void IsolationLevel_ConversionFailure(IsolationLevel clientIsolationLevel)
    {
        var spannerTxnOptions = SpannerTransactionCreationOptions.PartitionedDml.WithIsolationLevel(clientIsolationLevel);

        Assert.Throws<NotSupportedException>(() => spannerTxnOptions.GetTransactionOptions());
    }
}

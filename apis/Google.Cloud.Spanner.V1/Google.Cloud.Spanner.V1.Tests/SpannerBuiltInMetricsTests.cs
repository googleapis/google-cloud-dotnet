// Copyright 2026 Google LLC
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

using Google.Cloud.Spanner.Common.V1;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests;

// Suppress xUnit1045: Protobuf IMessages aren't IXunitSerializable, so parameterized tests are grouped.
#pragma warning disable xUnit1045
public class SpannerBuiltInMetricsTests
{
    private const string ProjectId = "my-project";
    private const string InstanceId = "my-instance";
    private const string DatabaseId = "my-database";

    private static readonly DatabaseName s_dbName = DatabaseName.FromProjectInstanceDatabase(ProjectId, InstanceId, DatabaseId);
    private static readonly SessionName s_sessionName = SessionName.FromProjectInstanceDatabaseSession(ProjectId, InstanceId, DatabaseId, "my-session");

    public static TheoryData<object, string, string, string> ValidRequestData => new()
    {
        { new CreateSessionRequest { DatabaseAsDatabaseName = s_dbName }, ProjectId, InstanceId, DatabaseId },
        { new BatchCreateSessionsRequest { DatabaseAsDatabaseName = s_dbName }, ProjectId, InstanceId, DatabaseId },
        { new ListSessionsRequest { DatabaseAsDatabaseName = s_dbName }, ProjectId, InstanceId, DatabaseId },
        { new GetSessionRequest { SessionName = s_sessionName }, ProjectId, InstanceId, DatabaseId },
        { new DeleteSessionRequest { SessionName = s_sessionName }, ProjectId, InstanceId, DatabaseId },
        { new ExecuteSqlRequest { SessionAsSessionName = s_sessionName }, ProjectId, InstanceId, DatabaseId },
        { new ExecuteBatchDmlRequest { SessionAsSessionName = s_sessionName }, ProjectId, InstanceId, DatabaseId },
        { new ReadRequest { SessionAsSessionName = s_sessionName }, ProjectId, InstanceId, DatabaseId },
        { new BeginTransactionRequest { SessionAsSessionName = s_sessionName }, ProjectId, InstanceId, DatabaseId },
        { new CommitRequest { SessionAsSessionName = s_sessionName }, ProjectId, InstanceId, DatabaseId },
        { new RollbackRequest { SessionAsSessionName = s_sessionName }, ProjectId, InstanceId, DatabaseId },
        { new PartitionQueryRequest { SessionAsSessionName = s_sessionName }, ProjectId, InstanceId, DatabaseId },
        { new PartitionReadRequest { SessionAsSessionName = s_sessionName }, ProjectId, InstanceId, DatabaseId },
        { new BatchWriteRequest { SessionAsSessionName = s_sessionName }, ProjectId, InstanceId, DatabaseId }
    };

    [Theory]
    [MemberData(nameof(ValidRequestData))]
    public void GetLabels_ValidRequests_ExtractsResourceLabels(object request, string expectedProjectId, string expectedInstanceId, string expectedDatabaseId)
    {
        var identity = SpannerBuiltInMetrics.Labeler.GenerateIdentity();
        var labels = SpannerBuiltInMetrics.Labeler.GetLabels("MethodName", (IDatabaseNameProvider)request, "OK", identity);

        Assert.Contains(labels, l => l.Key == "project_id" && (string) l.Value == expectedProjectId);
        Assert.Contains(labels, l => l.Key == "instance_id" && (string) l.Value == expectedInstanceId);
        Assert.Contains(labels, l => l.Key == "database" && (string) l.Value == expectedDatabaseId);
    }

    public static TheoryData<object> InvalidRequestData => new()
    {
        new ReadRequest(), // Missing Session
        new CreateSessionRequest(), // Missing Database
        new GetSessionRequest(), // Missing Name
        new ExecuteSqlRequest { Session = "invalid-session-string" }, // Invalid format
        new object() // Request does not implement IDatabaseNameProvider
    };

    [Theory]
    [MemberData(nameof(InvalidRequestData))]
    public void GetLabels_InvalidRequests_DefaultsToUnknown(object request)
    {
        var identity = SpannerBuiltInMetrics.Labeler.GenerateIdentity();
        var labels = SpannerBuiltInMetrics.Labeler.GetLabels("MethodName", request as IDatabaseNameProvider, "OK", identity);

        Assert.Contains(labels, l => l.Key == "project_id" && (string) l.Value == "unknown");
        Assert.Contains(labels, l => l.Key == "instance_id" && (string) l.Value == "unknown");
        Assert.Contains(labels, l => l.Key == "database" && (string) l.Value == "unknown");
    }

    [Theory]
    [InlineData("SomeMethod1", "OK")]
    [InlineData("SomeMethod2", "CANCELLED")]
    [InlineData("SomeMethod3", "DEADLINE_EXCEEDED")]
    public void GetLabels_PopulatesAllNonResourceLabels(string method, string status)
    {
        var identity = SpannerBuiltInMetrics.Labeler.GenerateIdentity();
        var request = new ReadRequest(); // The request object doesn't matter for this test.
        var labels = SpannerBuiltInMetrics.Labeler.GetLabels(method, (IDatabaseNameProvider)request, status, identity);

        // Verify explicitly passed parameters
        Assert.Contains(labels, l => l.Key == "method" && (string) l.Value == method);
        Assert.Contains(labels, l => l.Key == "status" && (string) l.Value == status);
        Assert.Contains(labels, l => l.Key == "client_uid" && (string) l.Value == identity.Id);

        // Verify statically assigned defaults
        Assert.Contains(labels, l => l.Key == "instance_config" && (string) l.Value == "unknown");
        Assert.Contains(labels, l => l.Key == "directpath_enabled" && (string) l.Value == "false");
        Assert.Contains(labels, l => l.Key == "directpath_used" && (string) l.Value == "false");

        // Verify dynamically computed system labels
        Assert.Contains(labels, l => l.Key == "location" && !string.IsNullOrEmpty((string) l.Value));
        Assert.Contains(labels, l => l.Key == "client_name" && ((string) l.Value).StartsWith("spanner-dotnet/"));

        // Verify client hash formatting
        var clientHashLabel = labels.First(l => l.Key == "client_hash");
        var clientHash = (string) clientHashLabel.Value;
        Assert.Equal(6, clientHash.Length);
        Assert.True(int.TryParse(clientHash, System.Globalization.NumberStyles.HexNumber, null, out int _));
    }

    [Fact]
    public async Task InstrumentedAsyncStreamReader_CleanCompletion_InvokesCallbackWithOk()
    {
        double recordedDuration = -1;
        string recordedStatus = null;
        var reader = new SpannerBuiltInMetrics.InstrumentedAsyncStreamReader<int>(
            new FakeAsyncStreamReader<int>([1, 2, 3]),
            SpannerBuiltInMetrics.DefaultStopwatchProvider.Instance,
            (duration, status) =>
            {
                recordedDuration = duration;
                recordedStatus = status;
            });

        while (await reader.MoveNext(CancellationToken.None))
        {
        }

        Assert.Equal("OK", recordedStatus);
        Assert.True(recordedDuration >= 0);
    }

    [Fact]
    public async Task InstrumentedAsyncStreamReader_RpcException_InvokesCallbackWithStatusCode()
    {
        double recordedDuration = -1;
        string recordedStatus = null;
        var ex = new RpcException(new Status(StatusCode.NotFound, "Not found"));
        var reader = new SpannerBuiltInMetrics.InstrumentedAsyncStreamReader<int>(
            new FakeAsyncStreamReader<int>([], ex),
            SpannerBuiltInMetrics.DefaultStopwatchProvider.Instance,
            (duration, status) =>
            {
                recordedDuration = duration;
                recordedStatus = status;
            });

        await Assert.ThrowsAsync<RpcException>(() => reader.MoveNext(CancellationToken.None));

        Assert.Equal("NotFound", recordedStatus);
        Assert.True(recordedDuration >= 0);
    }

    [Fact]
    public async Task InstrumentedAsyncStreamReader_EarlyDispose_InvokesCallbackWithCancelled()
    {
        double recordedDuration = -1;
        string recordedStatus = null;
        var reader = new SpannerBuiltInMetrics.InstrumentedAsyncStreamReader<int>(
            new FakeAsyncStreamReader<int>([1, 2, 3]),
            SpannerBuiltInMetrics.DefaultStopwatchProvider.Instance,
            (duration, status) =>
            {
                recordedDuration = duration;
                recordedStatus = status;
            });

        await reader.MoveNext(CancellationToken.None);
        reader.Dispose();

        Assert.Equal("Cancelled", recordedStatus);
        Assert.True(recordedDuration >= 0);
    }

    [Fact]
    public async Task InstrumentedAsyncStreamReader_OperationCanceledException_InvokesCallbackWithUnknown()
    {
        double recordedDuration = -1;
        string recordedStatus = null;
        var reader = new SpannerBuiltInMetrics.InstrumentedAsyncStreamReader<int>(
            new FakeAsyncStreamReader<int>([], new OperationCanceledException()),
            SpannerBuiltInMetrics.DefaultStopwatchProvider.Instance,
            (duration, status) =>
            {
                recordedDuration = duration;
                recordedStatus = status;
            });

        await Assert.ThrowsAsync<OperationCanceledException>(() => reader.MoveNext(CancellationToken.None));

        Assert.Equal("Unknown", recordedStatus);
        Assert.True(recordedDuration >= 0);
    }

    private class FakeAsyncStreamReader<T>(IEnumerable<T> items, Exception exception = null) : IAsyncStreamReader<T>
    {
        private readonly IEnumerator<T> _enumerator = items.GetEnumerator();

        public T Current => _enumerator.Current;

        public Task<bool> MoveNext(CancellationToken cancellationToken)
        {
            if (exception != null)
            {
                throw exception;
            }
            return Task.FromResult(_enumerator.MoveNext());
        }
    }
}

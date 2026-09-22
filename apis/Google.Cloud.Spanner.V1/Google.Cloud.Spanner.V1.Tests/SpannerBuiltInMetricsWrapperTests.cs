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

using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Spanner.V1.SpannerBuiltInMetrics;
using static Google.Cloud.Spanner.V1.Tests.MetricsCapture;

namespace Google.Cloud.Spanner.V1.Tests;

public class SpannerBuiltInMetricsWrapperTests
{
    private static readonly Grpc.Core.Status s_timeoutStatus = new(Grpc.Core.StatusCode.DeadlineExceeded, "timeout");
    private static readonly Exception s_rpcException = new Grpc.Core.RpcException(s_timeoutStatus);
    private static readonly ClientIdentity s_clientIdentity = Labeler.GenerateIdentity();

    [Fact]
    public void BuiltInMetricsWrapper_WrapsAllSpannerClientMethods()
    {
        var clientMethods = new HashSet<string>(typeof(SpannerClientImpl)
            .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
            .Where(m => !m.IsSpecialName)
            .Select(m => m.ToString()));

        var wrapperMethods = new HashSet<string>(typeof(BuiltInMetricsWrapper)
            .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
            .Where(m => !m.IsSpecialName)
            .Select(m => m.ToString()));

        var missingMethods = clientMethods.Except(wrapperMethods).ToList();

        Assert.True(missingMethods.Count == 0,
            $"We will need to implement the following methods in the BuiltInMetricsWrapper: {string.Join(", ", missingMethods)}");
    }

    [Fact]
    public void Properties_DelegateToInner()
    {
        var properties = typeof(SpannerClient)
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.CanRead);


        foreach (var prop in properties)
        {
            // Just to be safe we create a fresh mock so each property access is isolated
            var innerClient = Substitute.For<SpannerClient>();
            var instrumentedClient = BuiltInMetricsWrapper.Wrap(innerClient, s_clientIdentity);

            // Access the property on the fully wrapped client
            prop.GetValue(instrumentedClient);

            // Assert that the corresponding property on the inner client was also called
            var call = Assert.Single(innerClient.ReceivedCalls());
            Assert.Equal(prop.GetMethod.Name, call.GetMethodInfo().Name);
        }
    }

    [Fact]
    public async Task Methods_DelegateToInner()
    {
        var methods = typeof(BuiltInMetricsWrapper)
            .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
            .Where(m => !m.IsSpecialName);

        foreach (var method in methods)
        {
            // Just to be safe we create a fresh mock so each method call is isolated
            var innerClient = Substitute.For<SpannerClient>();
            var instrumentedClient = BuiltInMetricsWrapper.Wrap(innerClient, s_clientIdentity);

            // Arrange the input and make the method call
            var dummyArgs = method.GetParameters()
                .Select(p => p.ParameterType.IsValueType ? Activator.CreateInstance(p.ParameterType) :
                             p.ParameterType.GetConstructor(System.Type.EmptyTypes) != null ? Activator.CreateInstance(p.ParameterType) : null)
                .ToArray();

            var result = method.Invoke(instrumentedClient, dummyArgs);
            if (result is Task task)
            {
                await task;
            }

            // Assert that a single call was made to the inner client for the corresponding method.
            var call = Assert.Single(innerClient.ReceivedCalls());
            Assert.Equal(method.Name, call.GetMethodInfo().Name);
            Assert.Equal(dummyArgs, call.GetArguments());
        }
    }

    [Fact]
    public void Wrap_Idempotent()
    {
        Assert.Null(BuiltInMetricsWrapper.Wrap(null, s_clientIdentity));

        var mockClient = Substitute.For<SpannerClient>();
        var wrapped = BuiltInMetricsWrapper.Wrap(mockClient, s_clientIdentity);
        Assert.IsType<BuiltInMetricsWrapper>(wrapped);

        var wrappedAgain = BuiltInMetricsWrapper.Wrap(wrapped, s_clientIdentity);
        Assert.Same(wrapped, wrappedAgain);
    }

    private enum BuildMode
    {
        SyncOnly,
        AsyncOnly,
        Mixed
    }

    [Theory]
    [InlineData(BuildMode.SyncOnly, 2)]
    [InlineData(BuildMode.AsyncOnly, 2)]
    [InlineData(BuildMode.Mixed, 2)]
    [InlineData(BuildMode.SyncOnly, 20)]
    [InlineData(BuildMode.AsyncOnly, 20)]
    [InlineData(BuildMode.Mixed, 20)]
    [InlineData(BuildMode.SyncOnly, 50)]
    [InlineData(BuildMode.AsyncOnly, 50)]
    [InlineData(BuildMode.Mixed, 50)]
    private async Task ConcurrentBuilds_ClientIdentity_MatchesBetweenInterceptorAndWrapper(BuildMode buildMode, int clientCount)
    {
        // Arrange a single builder instance to build all clients.
        var builder = new SpannerClientBuilder
        {
            CallInvoker = new FakeCallInvoker(new Grpc.Core.Metadata())
        };

        // Arrange the build tasks based on the specified build mode (sync, async, or mixed).
        var buildTasks = ArrangeBuildTasks();
        var clients = await Task.WhenAll(buildTasks);

        // Every client must receive a distinct client identity.
        var uniqueIds = new HashSet<string>();
        foreach (var client in clients)
        {
            uniqueIds.Add(client._clientIdentity.Id);
        }
        Assert.Equal(clientCount, uniqueIds.Count);

        // Concurrently execute requests and verify that for each client,
        // its wrapper and interceptor share the exact same identity.
        var request = new CreateSessionRequest { Database = "projects/p/instances/i/databases/d" };
        var measurements = await RunWithMeterListenerAsync(async () =>
        {
            var callTasks = new List<Task>();
            for (int i = 0; i < clients.Length; i++)
            {
                var client = clients[i];
                if (i % 2 == 0)
                {
                    callTasks.Add(client.CreateSessionAsync(request));
                }
                else
                {
                    callTasks.Add(Task.Run(() => client.CreateSession(request)));
                }
            }
            await Task.WhenAll(callTasks);
        });

        foreach (var client in clients)
        {
            var scoped = FilterMeasurements(measurements, client._clientIdentity.Id);
            Assert.Single(scoped, m => m.Name == "operation_count");
            Assert.Single(scoped, m => m.Name == "attempt_count");
            Assert.All(scoped, m =>
            {
                Assert.Equal(client._clientIdentity.Id, m.GetTag("client_uid"));
                Assert.Equal(client._clientIdentity.Hash, m.GetTag("client_hash"));
            });
        }

        List<Task<BuiltInMetricsWrapper>> ArrangeBuildTasks()
        {
            var tasks = new List<Task<BuiltInMetricsWrapper>>();
            for (int i = 0; i < clientCount; i++)
            {
                if (buildMode == BuildMode.AsyncOnly || (buildMode == BuildMode.Mixed && i % 2 == 0))
                {
                    tasks.Add(Task.Run(async () => (BuiltInMetricsWrapper) await builder.BuildAsync()));
                }
                else
                {
                    tasks.Add(Task.Run(() => (BuiltInMetricsWrapper) builder.Build()));
                }
            }
            return tasks;
        }
    }

    [Fact]
    public async Task ConsecutiveCalls_RecordsMultipleMetrics()
    {
        var mockClient = Substitute.For<SpannerClient>();
        mockClient.ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), null).Returns(Task.FromResult(new ResultSet()));

        var instrumentedClient = (BuiltInMetricsWrapper) BuiltInMetricsWrapper.Wrap(mockClient, s_clientIdentity);
        var request = new ExecuteSqlRequest();

        var measurements = await RunWithMeterListenerAsync(async () =>
        {
            // Execute exactly 3 repeated invocations.
            await instrumentedClient.ExecuteSqlAsync(request, null);
            await instrumentedClient.ExecuteSqlAsync(request, null);
            await instrumentedClient.ExecuteSqlAsync(request, null);
        });

        var scoped = FilterMeasurements(measurements, instrumentedClient._clientIdentity.Id);

        // 3 operation count and 3 operation latencies should ahve been emitted for this specific method
        Assert.Equal(3, scoped.Count(m => m.Name == "operation_count"));
        Assert.Equal(3, scoped.Count(m => m.Name == "operation_latencies"));
        Assert.All(scoped, m =>
        {
            Assert.Equal(nameof(SpannerClient.ExecuteSqlAsync), m.GetTag("method"));
            Assert.Equal(Grpc.Core.StatusCode.OK.ToString(), m.GetTag("status"));
        });
    }

    [Theory]
    [MemberData(nameof(SuccessfulResponses))]
    public async Task RecordsMetricsOnSuccess(
        Action<SpannerClient> setupClient,
        Func<SpannerClient, Task> invoke,
        string expectedMethod,
        string expectedStatus)
    {
        var innerClient = Substitute.For<SpannerClient>();
        setupClient(innerClient);
        var instrumentedClient = (BuiltInMetricsWrapper) BuiltInMetricsWrapper.Wrap(innerClient, s_clientIdentity);

        var measurements = await RunWithMeterListenerAsync(() => invoke(instrumentedClient));

        AssertRecordedData(measurements, instrumentedClient._clientIdentity.Id, expectedMethod, expectedStatus);
    }

    [Theory]
    [MemberData(nameof(UnsuccessfulResponses))]
    public async Task RecordsMetricsOnException(
        Action<SpannerClient> setupClient,
        Func<SpannerClient, Task> invoke,
        string expectedMethod,
        string expectedStatus,
        Exception expectedException)
    {
        var mockClient = Substitute.For<SpannerClient>();
        setupClient(mockClient);
        var instrumentedClient = (BuiltInMetricsWrapper) BuiltInMetricsWrapper.Wrap(mockClient, s_clientIdentity);

        var measurements = await RunWithMeterListenerAsync(async () =>
        {
            var thrownException = await Assert.ThrowsAnyAsync<Exception>(() => invoke(instrumentedClient));
            Assert.Equal(expectedException.GetType(), thrownException.GetType());
            Assert.Equal(expectedException.Message, thrownException.Message);
        });

        AssertRecordedData(measurements, instrumentedClient._clientIdentity.Id, expectedMethod, expectedStatus);
    }

    public static TheoryData<Action<SpannerClient>, Func<SpannerClient, Task>, string, string> SuccessfulResponses => new()
    {
        {
            c => c.CreateSession(Arg.Any<CreateSessionRequest>(), null).Returns(new Session()),
            w => { w.CreateSession(new CreateSessionRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.CreateSession),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.CreateSessionAsync(Arg.Any<CreateSessionRequest>(), null).Returns(Task.FromResult(new Session())),
            w => w.CreateSessionAsync(new CreateSessionRequest(), null),
            nameof(SpannerClient.CreateSessionAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.BatchCreateSessions(Arg.Any<BatchCreateSessionsRequest>(), null).Returns(new BatchCreateSessionsResponse()),
            w => { w.BatchCreateSessions(new BatchCreateSessionsRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.BatchCreateSessions),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.BatchCreateSessionsAsync(Arg.Any<BatchCreateSessionsRequest>(), null).Returns(Task.FromResult(new BatchCreateSessionsResponse())),
            w => w.BatchCreateSessionsAsync(new BatchCreateSessionsRequest(), null),
            nameof(SpannerClient.BatchCreateSessionsAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.GetSession(Arg.Any<GetSessionRequest>(), null).Returns(new Session()),
            w => { w.GetSession(new GetSessionRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.GetSession),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.GetSessionAsync(Arg.Any<GetSessionRequest>(), null).Returns(Task.FromResult(new Session())),
            w => w.GetSessionAsync(new GetSessionRequest(), null),
            nameof(SpannerClient.GetSessionAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.DeleteSession(Arg.Any<DeleteSessionRequest>(), null),
            w => { w.DeleteSession(new DeleteSessionRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.DeleteSession),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.DeleteSessionAsync(Arg.Any<DeleteSessionRequest>(), null).Returns(Task.CompletedTask),
            w => w.DeleteSessionAsync(new DeleteSessionRequest(), null),
            nameof(SpannerClient.DeleteSessionAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.ExecuteSql(Arg.Any<ExecuteSqlRequest>(), null).Returns(new ResultSet()),
            w => { w.ExecuteSql(new ExecuteSqlRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.ExecuteSql),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), null).Returns(Task.FromResult(new ResultSet())),
            w => w.ExecuteSqlAsync(new ExecuteSqlRequest(), null),
            nameof(SpannerClient.ExecuteSqlAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.ExecuteBatchDml(Arg.Any<ExecuteBatchDmlRequest>(), null).Returns(new ExecuteBatchDmlResponse()),
            w => { w.ExecuteBatchDml(new ExecuteBatchDmlRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.ExecuteBatchDml),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.ExecuteBatchDmlAsync(Arg.Any<ExecuteBatchDmlRequest>(), null).Returns(Task.FromResult(new ExecuteBatchDmlResponse())),
            w => w.ExecuteBatchDmlAsync(new ExecuteBatchDmlRequest(), null),
            nameof(SpannerClient.ExecuteBatchDmlAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.Read(Arg.Any<ReadRequest>(), null).Returns(new ResultSet()),
            w => { w.Read(new ReadRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.Read),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.ReadAsync(Arg.Any<ReadRequest>(), null).Returns(Task.FromResult(new ResultSet())),
            w => w.ReadAsync(new ReadRequest(), null),
            nameof(SpannerClient.ReadAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.BeginTransaction(Arg.Any<BeginTransactionRequest>(), null).Returns(new Transaction()),
            w => { w.BeginTransaction(new BeginTransactionRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.BeginTransaction),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.BeginTransactionAsync(Arg.Any<BeginTransactionRequest>(), null).Returns(Task.FromResult(new Transaction())),
            w => w.BeginTransactionAsync(new BeginTransactionRequest(), null),
            nameof(SpannerClient.BeginTransactionAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.Commit(Arg.Any<CommitRequest>(), null).Returns(new CommitResponse()),
            w => { w.Commit(new CommitRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.Commit),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.CommitAsync(Arg.Any<CommitRequest>(), null).Returns(Task.FromResult(new CommitResponse())),
            w => w.CommitAsync(new CommitRequest(), null),
            nameof(SpannerClient.CommitAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.Rollback(Arg.Any<RollbackRequest>(), null),
            w => { w.Rollback(new RollbackRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.Rollback),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.RollbackAsync(Arg.Any<RollbackRequest>(), null).Returns(Task.CompletedTask),
            w => w.RollbackAsync(new RollbackRequest(), null),
            nameof(SpannerClient.RollbackAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.PartitionQuery(Arg.Any<PartitionQueryRequest>(), null).Returns(new PartitionResponse()),
            w => { w.PartitionQuery(new PartitionQueryRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.PartitionQuery),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.PartitionQueryAsync(Arg.Any<PartitionQueryRequest>(), null).Returns(Task.FromResult(new PartitionResponse())),
            w => w.PartitionQueryAsync(new PartitionQueryRequest(), null),
            nameof(SpannerClient.PartitionQueryAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.PartitionRead(Arg.Any<PartitionReadRequest>(), null).Returns(new PartitionResponse()),
            w => { w.PartitionRead(new PartitionReadRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.PartitionRead),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.PartitionReadAsync(Arg.Any<PartitionReadRequest>(), null).Returns(Task.FromResult(new PartitionResponse())),
            w => w.PartitionReadAsync(new PartitionReadRequest(), null),
            nameof(SpannerClient.PartitionReadAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },
    };

    public static TheoryData<Action<SpannerClient>, Func<SpannerClient, Task>, string, string, Exception> UnsuccessfulResponses => new()
    {
        {
            c => c.ExecuteSql(Arg.Any<ExecuteSqlRequest>(), null).Returns(x => throw s_rpcException),
            w => { w.ExecuteSql(new ExecuteSqlRequest { Session = "projects/p/instances/i/databases/d/sessions/s" }, null); return Task.CompletedTask; },
            nameof(SpannerClient.ExecuteSql),
            Grpc.Core.StatusCode.DeadlineExceeded.ToString(),
            s_rpcException
        },
        {
            c => c.CommitAsync(Arg.Any<CommitRequest>(), null).Returns(Task.FromException<CommitResponse>(new InvalidOperationException("boom"))),
            w => w.CommitAsync(new CommitRequest { Session = "projects/p/instances/i/databases/d/sessions/s" }, null),
            nameof(SpannerClient.CommitAsync),
            Grpc.Core.StatusCode.Unknown.ToString(),
            new InvalidOperationException("boom")
        }
    };

    private static List<Measurement> FilterMeasurements(IEnumerable<Measurement> measurements, string clientUid) =>
        measurements.Where(m => m.GetTag("client_uid") == clientUid).ToList();

    private static void AssertRecordedData(IEnumerable<Measurement> measurements, string clientUid, string expectedMethod, string expectedStatus)
    {
        var scoped = FilterMeasurements(measurements, clientUid);
        Assert.Single(scoped, m => m.Name == "operation_count");
        Assert.Single(scoped, m => m.Name == "operation_latencies");
        Assert.All(scoped, m =>
        {
            Assert.Equal(expectedMethod, m.GetTag("method"));
            Assert.Equal(expectedStatus, m.GetTag("status"));
        });
    }
}

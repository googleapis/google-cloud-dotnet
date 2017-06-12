// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.Testing;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using GrpcStatus = Grpc.Core.Status;
using ProtoStatus = Google.Rpc.Status;
using StatusCode = Grpc.Core.StatusCode;

namespace Google.LongRunning.Tests
{
    public class OperationTest
    {
        [Fact]
        public async Task Properties_WithResult()
        {
            var client = new FakeOperationsClient();
            var operation = ForResult("name", "foo", client);
            Assert.Equal("name", operation.Name);
            Assert.True(operation.IsCompleted);
            Assert.Equal("foo", operation.Result.Value);
            Assert.False(operation.IsFaulted);
            Assert.Null(operation.Exception);
            Assert.Same(operation, operation.PollOnce());
            Assert.Same(operation, operation.PollUntilCompleted());
            Assert.Same(operation, await operation.PollOnceAsync());
            Assert.Same(operation, await operation.PollUntilCompletedAsync());
            Assert.Equal(0, client.RequestCount);
        }

        [Fact]
        public async Task Properties_WithError()
        {
            var client = new FakeOperationsClient();
            var operation = ForError("name", new ProtoStatus { Message = "Bang", Code = 123 }, client);
            Assert.Equal("name", operation.Name);
            Assert.True(operation.IsCompleted);
            var exception = Assert.Throws<OperationFailedException>(() => operation.Result.ToString());
            Assert.Contains("Bang", exception.Message);
            Assert.Equal(123, exception.Status.Code);
            Assert.Same(operation.RpcMessage, exception.Operation);
            Assert.True(operation.IsFaulted);
            Assert.Same(exception, operation.Exception);
            Assert.Same(operation, operation.PollOnce());
            Assert.Same(operation, operation.PollUntilCompleted());
            Assert.Same(operation, await operation.PollOnceAsync());
            Assert.Same(operation, await operation.PollUntilCompletedAsync());
            Assert.Equal(0, client.RequestCount);
        }

        [Fact]
        public void Properties_Incomplete()
        {
            // No Poll etc calls here, as they're tested separately.
            var client = new FakeOperationsClient();
            var operation = ForIncomplete("name", client);
            Assert.Equal("name", operation.Name);
            Assert.False(operation.IsCompleted);
            var exception = Assert.Throws<InvalidOperationException>(() => operation.Result.ToString());
            Assert.False(operation.IsFaulted);
            Assert.Equal(0, client.RequestCount);
        }

        [Fact]
        public void PollOnce()
        {
            var client = new FakeOperationsClient();
            client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc().AddSeconds(3), new StringValue { Value = "result" });
            var initial = Operation<StringValue, Timestamp>.PollOnceFromName("op", client);
            Assert.False(initial.IsCompleted);
            client.FakeClock.Advance(TimeSpan.FromSeconds(2));
            var polled = initial.PollOnce();
            Assert.False(polled.IsCompleted);
            client.FakeClock.Advance(TimeSpan.FromSeconds(2));
            polled = polled.PollOnce();
            Assert.True(polled.IsCompleted);
            Assert.Equal("result", polled.Result.Value);
            Assert.Equal(3, client.RequestCount);
        }

        [Fact]
        public async Task PollOnceAsync()
        {
            var client = new FakeOperationsClient();
            client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc().AddSeconds(3), new StringValue { Value = "result" });
            var initial = await Operation<StringValue, Timestamp>.PollOnceFromNameAsync("op", client);
            Assert.False(initial.IsCompleted);
            client.FakeClock.Advance(TimeSpan.FromSeconds(2));
            var polled = await initial.PollOnceAsync();
            Assert.False(polled.IsCompleted);
            client.FakeClock.Advance(TimeSpan.FromSeconds(2));
            polled = await polled.PollOnceAsync();
            Assert.True(polled.IsCompleted);
            Assert.Equal("result", polled.Result.Value);
            Assert.Equal(3, client.RequestCount);
        }

        [Fact]
        public void PollUntilCompleted_Success()
        {
            var client = new FakeOperationsClient();
            var expectedMetadata = GenerateExpectedMetadata(client.Clock, 0, 2, 3);
            List<Timestamp> actualMetadata = new List<Timestamp>();
            client.FakeScheduler.Run(() =>
            {
                client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc().AddSeconds(3), new StringValue { Value = "result" });
                var initial = Operation<StringValue, Timestamp>.PollOnceFromName("op", client);
                var settings = new PollSettings(Expiration.FromTimeout(TimeSpan.FromSeconds(5)), TimeSpan.FromSeconds(2));
                // Second request at t=2, then another at t=4
                var final = initial.PollUntilCompleted(settings, metadataCallback: actualMetadata.Add);
                Assert.Equal("result", final.Result.Value);
                Assert.Equal(4, client.RequestCount);
            });
            Assert.Equal(expectedMetadata, actualMetadata);
        }

        [Fact]
        public void PollUntilCompleted_NullMetadata()
        {
            var client = new FakeOperationsClient { GenerateMetadata = false };
            var expectedMetadata = new List<Timestamp> { null, null, null };
            List<Timestamp> actualMetadata = new List<Timestamp>();
            client.FakeScheduler.Run(() =>
            {
                client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc().AddSeconds(3), new StringValue { Value = "result" });
                var initial = Operation<StringValue, Timestamp>.PollOnceFromName("op", client);
                var settings = new PollSettings(Expiration.FromTimeout(TimeSpan.FromSeconds(5)), TimeSpan.FromSeconds(2));
                // Second request at t=2, then another at t=4
                var final = initial.PollUntilCompleted(settings, metadataCallback: actualMetadata.Add);
                Assert.Equal("result", final.Result.Value);
                Assert.Equal(4, client.RequestCount);
            });
            Assert.Equal(expectedMetadata, actualMetadata);
        }

        [Fact]
        public void PollUntilCompleted_AlreadyCompleted ()
        {
            var client = new FakeOperationsClient();
            client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc(), new StringValue { Value = "result" });
            var initial = Operation<StringValue, Timestamp>.PollOnceFromName("op", client);
            Assert.True(initial.IsCompleted);
            var expectedMetadata = GenerateExpectedMetadata(client.Clock, 0);
            List<Timestamp> actualMetadata = new List<Timestamp>();
            client.FakeScheduler.Run(() =>
            {
                Assert.Equal(1, client.RequestCount);
                var settings = new PollSettings(Expiration.FromTimeout(TimeSpan.FromSeconds(5)), TimeSpan.FromSeconds(2));
                var final = initial.PollUntilCompleted(settings, metadataCallback: actualMetadata.Add);
                Assert.Equal("result", final.Result.Value);
                // No more requests due to PollUntilCompleted call
                Assert.Equal(1, client.RequestCount);
            });
            // Metadata was still added despite no RPCs being made
            Assert.Equal(expectedMetadata, actualMetadata);
        }

        [Fact]
        public void PollUntilCompleted_Timeout()
        {
            var client = new FakeOperationsClient();
            var expectedMetadata = GenerateExpectedMetadata(client.Clock, 0, 2, 4);
            List<Timestamp> actualMetadata = new List<Timestamp>();
            client.FakeScheduler.Run(() =>
            {
                client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc().AddSeconds(10), new StringValue { Value = "result" });
                var initial = Operation<StringValue, Timestamp>.PollOnceFromName("op", client);
                // Second request at t=0, then at t=2, then at t=4, then we give up.
                var settings = new PollSettings(Expiration.FromTimeout(TimeSpan.FromSeconds(5)), TimeSpan.FromSeconds(2));
                Assert.Throws<TimeoutException>(() => initial.PollUntilCompleted(settings, metadataCallback: actualMetadata.Add));
                Assert.Equal(4, client.RequestCount);
            });
            Assert.Equal(expectedMetadata, actualMetadata);
        }

        [Fact]
        public async Task PollUntilCompletedAsync_Success()
        {
            var client = new FakeOperationsClient();
            var expectedMetadata = GenerateExpectedMetadata(client.Clock, 0, 2, 3);
            List<Timestamp> actualMetadata = new List<Timestamp>();
            await client.FakeScheduler.RunAsync(async () =>
            {
                client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc().AddSeconds(3), new StringValue { Value = "result" });
                var initial = Operation<StringValue, Timestamp>.PollOnceFromNameAsync("op", client).Result;
                var settings = new PollSettings(Expiration.FromTimeout(TimeSpan.FromSeconds(5)), TimeSpan.FromSeconds(2));
                // Second request at t=0, then at t=2, then another at t=4
                var completedOperation = await initial.PollUntilCompletedAsync(settings, metadataCallback: actualMetadata.Add);
                Assert.Equal("result", completedOperation.Result.Value);
            });
            Assert.Equal(4, client.RequestCount);
            Assert.Equal(expectedMetadata, actualMetadata);
        }

        [Fact]
        public async Task PollUntilCompletedAsync_NullMetadata()
        {
            var client = new FakeOperationsClient { GenerateMetadata = false };
            var expectedMetadata = new List<Timestamp> { null, null, null };
            List<Timestamp> actualMetadata = new List<Timestamp>();
            await client.FakeScheduler.RunAsync(async () =>
            {
                client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc().AddSeconds(3), new StringValue { Value = "result" });
                var initial = Operation<StringValue, Timestamp>.PollOnceFromNameAsync("op", client).Result;
                var settings = new PollSettings(Expiration.FromTimeout(TimeSpan.FromSeconds(5)), TimeSpan.FromSeconds(2));
                // Second request at t=0, then at t=2, then another at t=4
                var completedOperation = await initial.PollUntilCompletedAsync(settings, metadataCallback: actualMetadata.Add);
                Assert.Equal("result", completedOperation.Result.Value);
            });
            Assert.Equal(4, client.RequestCount);
            Assert.Equal(expectedMetadata, actualMetadata);
        }

        [Fact]
        public async Task PollUntilCompletedAsync_AlreadyCompleted()
        {
            var client = new FakeOperationsClient();
            client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc(), new StringValue { Value = "result" });
            var initial = Operation<StringValue, Timestamp>.PollOnceFromName("op", client);
            Assert.True(initial.IsCompleted);
            var expectedMetadata = GenerateExpectedMetadata(client.Clock, 0);
            List<Timestamp> actualMetadata = new List<Timestamp>();
            await client.FakeScheduler.RunAsync(async () =>
            {
                Assert.Equal(1, client.RequestCount);
                var settings = new PollSettings(Expiration.FromTimeout(TimeSpan.FromSeconds(5)), TimeSpan.FromSeconds(2));
                var final = await initial.PollUntilCompletedAsync(settings, metadataCallback: actualMetadata.Add);
                Assert.Equal("result", final.Result.Value);
                // No more requests due to PollUntilCompletedAsync call
                Assert.Equal(1, client.RequestCount);
            });
            // Metadata was still added despite no RPCs being made
            Assert.Equal(expectedMetadata, actualMetadata);
        }

        [Fact]
        public void PollUntilCompleted_BaseSettingsCancellationToken()
        {
            var cts = new CancellationTokenSource();
            cts.Cancel();
            var client = new FakeOperationsClient(new FakeScheduler(), CallSettings.FromCancellationToken(cts.Token));
            var operation = ForIncomplete("op", client);
            Assert.Throws<OperationCanceledException>(() => operation.PollUntilCompleted());
        }

        [Fact]
        public void PollUntilCompleted_PerCallSettingsCancellationToken()
        {
            var cts = new CancellationTokenSource();
            cts.Cancel();
            var client = new FakeOperationsClient();
            var operation = ForIncomplete("op", client);
            var callSettings = CallSettings.FromCancellationToken(cts.Token);
            Assert.Throws<OperationCanceledException>(() => operation.PollUntilCompleted(callSettings: callSettings));
        }

        [Fact]
        public async Task PollUntilCompletedAsync_Timeout()
        {
            var client = new FakeOperationsClient();
            var expectedMetadata = GenerateExpectedMetadata(client.Clock, 0, 2, 4);
            List<Timestamp> actualMetadata = new List<Timestamp>();
            await client.FakeScheduler.RunAsync(async () =>
            {
                client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc().AddSeconds(10), new StringValue { Value = "result" });
                var initial = Operation<StringValue, Timestamp>.PollOnceFromNameAsync("op", client).Result;
                // Second request at t=0, then at t=2, then at t=4, then we give up.
                var settings = new PollSettings(Expiration.FromTimeout(TimeSpan.FromSeconds(5)), TimeSpan.FromSeconds(2));
                await Assert.ThrowsAsync<TimeoutException>(() => initial.PollUntilCompletedAsync(settings, metadataCallback: actualMetadata.Add));
            });
            Assert.Equal(4, client.RequestCount);
            Assert.Equal(expectedMetadata, actualMetadata);
        }

        [Theory]
        [InlineData("metadata")]
        [InlineData(null)]
        public static void Metadata(string metadata)
        {
            var message = new Operation
            {
                Done = false,                
                Name = "name",
                Metadata = metadata == null ? null : Any.Pack(new StringValue { Value = metadata })
            };
            var operation = new Operation<Timestamp, StringValue>(message, new FakeOperationsClient());
            Assert.Equal(metadata, operation.Metadata?.Value);
        }

        private static Operation<StringValue, Timestamp> ForResult(string name, string value, OperationsClient client)
        {
            var operation = new Operation
            {
                Done = true,
                Name = name,
                Response = Any.Pack(new StringValue { Value = value })
            };
            return new Operation<StringValue, Timestamp>(operation, client);
        }

        private static Operation<StringValue, Timestamp> ForIncomplete(string name, OperationsClient client)
        {
            var operation = new Operation
            {
                Done = false,
                Name = name
            };
            return new Operation<StringValue, Timestamp>(operation, client);
        }

        private static Operation<StringValue, Timestamp> ForError(string name, ProtoStatus error, OperationsClient client)
        {
            var operation = new Operation
            {
                Done = true,
                Name = name,
                Error = error
            };
            return new Operation<StringValue, Timestamp>(operation, client);
        }

        private static List<Timestamp> GenerateExpectedMetadata(IClock clock, params int[] timesInSecondsFromNow) =>
            timesInSecondsFromNow
                .Select(t => clock.GetCurrentDateTimeUtc().AddSeconds(t))
                .Select(Timestamp.FromDateTime)
                .ToList();

        // We may want to make this public in a testing package at some point... and possibly the helper methods above.
        class FakeOperationsClient : OperationsClient
        {
            private readonly CallSettings _baseCallSettings;
            public override IClock Clock => FakeScheduler.Clock;
            public override IScheduler Scheduler => FakeScheduler;
            public override PollSettings DefaultPollSettings => null;
            public FakeClock FakeClock => FakeScheduler.Clock;
            public FakeScheduler FakeScheduler { get; }
            public bool GenerateMetadata { get; set; } = true;
            public int RequestCount { get; private set; }

            private readonly Dictionary<string, Tuple<DateTime, Operation>> operations;

            public FakeOperationsClient() : this(new FakeScheduler(), null)
            {
            }

            public FakeOperationsClient(FakeScheduler scheduler, CallSettings baseCallSettings)
            {
                FakeScheduler = scheduler;
                _baseCallSettings = baseCallSettings;
                operations = new Dictionary<string, Tuple<DateTime, Operation>>();
            }

            public void AddSuccessfulOperation<T>(string name, DateTime completionTime, T result) where T : IMessage<T>
            {
                var operation = new Operation
                {
                    Done = true,
                    Name = name,
                    Metadata = GetMetadata(completionTime),
                    Response = Any.Pack(result)
                };
                operations.Add(name, Tuple.Create(completionTime, operation));
            }

            public void AddFailedOperation<T>(string name, DateTime completionTime, ProtoStatus error) where T : IMessage<T>
            {
                var operation = new Operation
                {
                    Done = true,
                    Name = name,
                    Metadata = GetMetadata(completionTime),
                    Error = error
                };
                operations.Add(name, Tuple.Create(completionTime, operation));
            }

            public override Operation GetOperation(string name, CallSettings callSettings = null)
            {
                callSettings?.CancellationToken?.ThrowIfCancellationRequested();
                RequestCount++;
                Tuple<DateTime, Operation> tuple;
                if (!operations.TryGetValue(name, out tuple))
                {
                    throw new RpcException(new GrpcStatus(StatusCode.NotFound, "Operation not found"));
                }
                // Return the completed operation, or an incomplete version.
                return Clock.GetCurrentDateTimeUtc() >= tuple.Item1
                    ? tuple.Item2
                    : new Operation { Name = name, Metadata = GetMetadata(Clock.GetCurrentDateTimeUtc()) };
            }

            public override void CancelOperation(string name, CallSettings callSettings = null)
            {
                RequestCount++;
                throw new RpcException(new GrpcStatus(StatusCode.Unimplemented, "Cancellation not implemented yet"));
            }

            public override void DeleteOperation(string name, CallSettings callSettings = null)
            {
                RequestCount++;
                throw new RpcException(new GrpcStatus(StatusCode.Unimplemented, "Deletion not implemented yet"));
            }

            protected override CallSettings GetEffectiveCallSettingsForGetOperation(CallSettings callSettings)
                => _baseCallSettings.MergedWith(callSettings);

            // Async overrides that just delegate to the sync calls...
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
            public override async Task CancelOperationAsync(string name, CallSettings callSettings = null)
                => CancelOperation(name, callSettings);

            public override async Task DeleteOperationAsync(string name, CallSettings callSettings = null)
                => DeleteOperation(name, callSettings);

            public override async Task<Operation> GetOperationAsync(string name, CallSettings callSettings = null)
                => GetOperation(name, callSettings);
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously

            private Any GetMetadata(DateTime dateTime) => GenerateMetadata ? Any.Pack(Timestamp.FromDateTime(dateTime)) : null;
        }
    }
}

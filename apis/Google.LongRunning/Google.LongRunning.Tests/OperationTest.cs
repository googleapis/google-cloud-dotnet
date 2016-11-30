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
            var initial = Operation<StringValue>.PollOnceFromName("op", client);
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
            var initial = await Operation<StringValue>.PollOnceFromNameAsync("op", client);
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
            client.FakeScheduler.Run(() =>
            {
                client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc().AddSeconds(3), new StringValue { Value = "result" });
                var initial = Operation<StringValue>.PollOnceFromName("op", client);
                var settings = new PollSettings(Expiration.FromTimeout(TimeSpan.FromSeconds(5)), TimeSpan.FromSeconds(2));
                // Second request at t=2, then another at t=4
                var final = initial.PollUntilCompleted(settings);
                Assert.Equal("result", final.Result.Value);
                Assert.Equal(4, client.RequestCount);
                return 0; // TODO: Remove the need for this, by improving FakeScheduler.
            });
        }

        [Fact]
        public void PollUntilCompleted_Timeout()
        {
            var client = new FakeOperationsClient();
            client.FakeScheduler.Run(() =>
            {
                client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc().AddSeconds(10), new StringValue { Value = "result" });
                var initial = Operation<StringValue>.PollOnceFromName("op", client);
                // Second request at t=0, then at t=2, then at t=4, then we give up.
                var settings = new PollSettings(Expiration.FromTimeout(TimeSpan.FromSeconds(5)), TimeSpan.FromSeconds(2));
                Assert.Throws<TimeoutException>(() => initial.PollUntilCompleted(settings));
                Assert.Equal(4, client.RequestCount);
            });
        }

        [Fact]
        public async Task PollUntilCompletedAsync_Success()
        {
            var client = new FakeOperationsClient();
            await client.FakeScheduler.RunAsync(async () =>
            {
                client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc().AddSeconds(3), new StringValue { Value = "result" });
                var initial = Operation<StringValue>.PollOnceFromNameAsync("op", client).Result;
                var settings = new PollSettings(Expiration.FromTimeout(TimeSpan.FromSeconds(5)), TimeSpan.FromSeconds(2));
                // Second request at t=2, then another at t=4
                var completedOperation = await initial.PollUntilCompletedAsync(settings);
                Assert.Equal("result", completedOperation.Result.Value);
            });
            Assert.Equal(4, client.RequestCount);
        }

        [Fact]
        public async Task PollUntilCompletedAsync_Timeout()
        {
            var client = new FakeOperationsClient();
            await client.FakeScheduler.RunAsync(async () =>
            {
                client.AddSuccessfulOperation("op", client.Clock.GetCurrentDateTimeUtc().AddSeconds(10), new StringValue { Value = "result" });
                var initial = Operation<StringValue>.PollOnceFromNameAsync("op", client).Result;
                // Second request at t=0, then at t=2, then at t=4, then we give up.
                var settings = new PollSettings(Expiration.FromTimeout(TimeSpan.FromSeconds(5)), TimeSpan.FromSeconds(2));
                await Assert.ThrowsAsync<TimeoutException>(() => initial.PollUntilCompletedAsync(settings));
            });
            Assert.Equal(4, client.RequestCount);
        }

        private static Operation<StringValue> ForResult(string name, string value, OperationsClient client)
        {
            var operation = new Operation
            {
                Done = true,
                Name = name,
                Response = Any.Pack(new StringValue { Value = value })
            };
            return new Operation<StringValue>(operation, client);
        }

        private static Operation<StringValue> ForIncomplete(string name, OperationsClient client)
        {
            var operation = new Operation
            {
                Done = false,
                Name = name
            };
            return new Operation<StringValue>(operation, client);
        }

        private static Operation<StringValue> ForError(string name, ProtoStatus error, OperationsClient client)
        {
            var operation = new Operation
            {
                Done = true,
                Name = name,
                Error = error
            };
            return new Operation<StringValue>(operation, client);
        }

        // We may want to make this public in a testing package at some point... and possibly the helper methods above.
        class FakeOperationsClient : OperationsClient
        {
            public override IClock Clock => FakeScheduler.Clock;
            public override IScheduler Scheduler => FakeScheduler;
            public FakeClock FakeClock => FakeScheduler.Clock;
            public FakeScheduler FakeScheduler { get; }
            public int RequestCount { get; private set; }

            private readonly Dictionary<string, Tuple<DateTime, Operation>> operations;

            public FakeOperationsClient() : this(new FakeScheduler())
            {
            }

            public FakeOperationsClient(FakeScheduler scheduler)
            {
                FakeScheduler = scheduler;
                operations = new Dictionary<string, Tuple<DateTime, Operation>>();
            }

            public void AddSuccessfulOperation<T>(string name, DateTime completionTime, T result) where T : IMessage<T>
            {
                var operation = new Operation
                {
                    Done = true,
                    Name = name,
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
                    Error = error
                };
                operations.Add(name, Tuple.Create(completionTime, operation));
            }

            public override Operation GetOperation(string name, CallSettings callSettings = null)
            {
                RequestCount++;
                Tuple<DateTime, Operation> tuple;
                if (!operations.TryGetValue(name, out tuple))
                {
                    throw new RpcException(new GrpcStatus(StatusCode.NotFound, "Operation not found"));
                }
                // Return the completed operation, or an incomplete version.
                return Clock.GetCurrentDateTimeUtc() >= tuple.Item1 ? tuple.Item2 : new Operation { Name = name };
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

            // Async overrides that just delegate to the sync calls...
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
            public override async Task CancelOperationAsync(string name, CallSettings callSettings = null)
                => CancelOperation(name, callSettings);

            public override async Task DeleteOperationAsync(string name, CallSettings callSettings = null)
                => DeleteOperation(name, callSettings);

            public override async Task<Operation> GetOperationAsync(string name, CallSettings callSettings = null)
                => GetOperation(name, callSettings);
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        }
    }
}

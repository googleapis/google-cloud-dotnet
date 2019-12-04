// Copyright 2019 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.Testing;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Spanner.V1.SqlResultStream;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class RetryStateTests
    {
        // The retry settings used by various tests:
        private static readonly RetrySettings s_retrySettings = RetrySettings.FromExponentialBackoff(
            maxAttempts: int.MaxValue, // Ignored in SqlResultStream
            initialBackoff: TimeSpan.FromSeconds(1),
            maxBackoff: TimeSpan.FromSeconds(15),
            backoffMultiplier: 2.0,
            ignored => false, // Ignored in SqlResultStream
            RetrySettings.NoJitter);

        [Theory]
        [InlineData(StatusCode.PermissionDenied, false)]
        [InlineData(StatusCode.Aborted, false)]
        [InlineData(StatusCode.Internal, true)]
        [InlineData(StatusCode.Unavailable, true)]
        [InlineData(StatusCode.DeadlineExceeded, false)]
        public void CanRetry_SimpleStatusCodes(StatusCode code, bool expectedRetriable)
        {
            var exception = new RpcException(new Status(code, "Bang"));
            RetryState state = CreateSimpleRetryState();
            Assert.Equal(expectedRetriable, state.CanRetry(exception));
        }

        [Fact]
        public void CanRetry_ResourceExhausted_NoRetryInfo()
        {
            Metadata trailers = new Metadata
            {
                { "otherinfo", "value" }
            };
            var exception = new RpcException(new Status(StatusCode.ResourceExhausted, "Bang"), trailers);
            RetryState state = CreateSimpleRetryState();
            Assert.False(state.CanRetry(exception));
        }

        [Fact]
        public void CanRetry_ResourceExhausted_WithRetryInfo()
        {
            var retryInfo = new Rpc.RetryInfo { RetryDelay = Duration.FromTimeSpan(TimeSpan.FromSeconds(2)) };
            Metadata trailers = new Metadata
            {
                { RetryState.RetryInfoKey, retryInfo.ToByteArray() }
            };
            var exception = new RpcException(new Status(StatusCode.ResourceExhausted, "Bang"), trailers);
            RetryState state = CreateSimpleRetryState();
            Assert.True(state.CanRetry(exception));
        }

        [Fact]
        public async Task CanRetry_MaxConsecutiveRetries_NoReset()
        {
            var state = new RetryState(
                new NoOpScheduler(),
                s_retrySettings,
                maxConsecutiveErrors: 2);
            var exception = new RpcException(new Status(StatusCode.Unavailable, "Bang"));

            Assert.True(state.CanRetry(exception));
            await state.RecordErrorAndWaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
            await state.RecordErrorAndWaitAsync(exception, default);

            Assert.False(state.CanRetry(exception));
        }

        [Fact]
        public async Task CanRetry_MaxConsecutiveRetries_WithReset()
        {
            var state = new RetryState(
                new NoOpScheduler(),
                s_retrySettings,
                maxConsecutiveErrors: 2);
            var exception = new RpcException(new Status(StatusCode.Unavailable, "Bang"));

            Assert.True(state.CanRetry(exception));
            await state.RecordErrorAndWaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
            await state.RecordErrorAndWaitAsync(exception, default);

            state.Reset();

            Assert.True(state.CanRetry(exception));
            await state.RecordErrorAndWaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
        }

        [Fact]
        public async Task RecordErrorAndWait_RetrySettingsObeyed()
        {
            RetrySettings retrySettings = RetrySettings.FromExponentialBackoff(
                maxAttempts: int.MaxValue, // Ignored in SqlResultStream
                initialBackoff: TimeSpan.FromSeconds(1),
                maxBackoff: TimeSpan.FromSeconds(5),
                backoffMultiplier: 2.0,
                ignored => false, // Ignored in SqlResultStream
                RetrySettings.NoJitter);
            var mock = new Mock<IScheduler>(MockBehavior.Strict);
            mock.Setup(s => s.Delay(TimeSpan.FromSeconds(1), default)).Returns(Task.FromResult(0));
            mock.Setup(s => s.Delay(TimeSpan.FromSeconds(2), default)).Returns(Task.FromResult(0));
            mock.Setup(s => s.Delay(TimeSpan.FromSeconds(4), default)).Returns(Task.FromResult(0));
            // Retry maxes out at 5 seconds
            mock.Setup(s => s.Delay(TimeSpan.FromSeconds(5), default)).Returns(Task.FromResult(0));
            // After reset
            mock.Setup(s => s.Delay(TimeSpan.FromSeconds(1), default)).Returns(Task.FromResult(0));

            var exception = new RpcException(new Status(StatusCode.Unavailable, "Bang"));

            var state = new RetryState(mock.Object, retrySettings, maxConsecutiveErrors: 5);

            await state.RecordErrorAndWaitAsync(exception, default);
            await state.RecordErrorAndWaitAsync(exception, default);
            await state.RecordErrorAndWaitAsync(exception, default);
            await state.RecordErrorAndWaitAsync(exception, default);
            state.Reset();
            await state.RecordErrorAndWaitAsync(exception, default);
        }

        [Fact]
        public async Task RecordErrorAndWait_RetryInfo()
        {
            var mock = new Mock<IScheduler>(MockBehavior.Strict);
            // Delay taken from retry info
            mock.Setup(s => s.Delay(TimeSpan.FromSeconds(3), default)).Returns(Task.FromResult(0));
            // Delay taken from backoff settings (which weren't affected by the first exception, because it contained backoff information)
            mock.Setup(s => s.Delay(TimeSpan.FromSeconds(1), default)).Returns(Task.FromResult(0));

            // The first exception contains retry info, so we don't use the backoff settings
            var retryInfo = new Rpc.RetryInfo { RetryDelay = Duration.FromTimeSpan(TimeSpan.FromSeconds(3)) };
            Metadata trailers = new Metadata
            {
                { RetryState.RetryInfoKey, retryInfo.ToByteArray() }
            };
            var exception1 = new RpcException(new Status(StatusCode.Unavailable, "Bang"), trailers);
            var exception2 = new RpcException(new Status(StatusCode.Unavailable, "Bang"));

            RetryState state = new RetryState(mock.Object, s_retrySettings, maxConsecutiveErrors: 5);

            Assert.True(state.CanRetry(exception1));
            await state.RecordErrorAndWaitAsync(exception1, default);

            Assert.True(state.CanRetry(exception2));
            await state.RecordErrorAndWaitAsync(exception2, default);
        }

        private static RetryState CreateSimpleRetryState() => new RetryState(
            new Mock<IScheduler>(MockBehavior.Strict).Object,
            s_retrySettings);
    }
}

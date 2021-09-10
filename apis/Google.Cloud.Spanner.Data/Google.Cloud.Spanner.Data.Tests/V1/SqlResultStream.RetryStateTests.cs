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
using static Google.Cloud.Spanner.V1.ResultStream;
using static Google.Cloud.Spanner.V1.Tests.SqlResultStreamTests;

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

        private static readonly CallSettings s_callSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromSeconds(30)));

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
        public async Task CanRetry_NoReset()
        {
            var state = new RetryState(
                new FakeClock(),
                new NoOpScheduler(),
                s_retrySettings,
                s_callSettings);
            var exception = new RpcException(new Status(StatusCode.Unavailable, "Bang"));

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
        }

        [Fact]
        public async Task CanRetry_WithReset()
        {
            var state = new RetryState(
                new FakeClock(),
                new NoOpScheduler(),
                s_retrySettings,
                s_callSettings);
            var exception = new RpcException(new Status(StatusCode.Unavailable, "Bang"));

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            state.Reset();

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

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

            var state = new RetryState(new FakeClock(), mock.Object, retrySettings, s_callSettings);

            await state.WaitAsync(exception, default);
            await state.WaitAsync(exception, default);
            await state.WaitAsync(exception, default);
            await state.WaitAsync(exception, default);
            state.Reset();
            await state.WaitAsync(exception, default);
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

            RetryState state = new RetryState(new FakeClock(), mock.Object, s_retrySettings, s_callSettings);

            Assert.True(state.CanRetry(exception1));
            await state.WaitAsync(exception1, default);

            Assert.True(state.CanRetry(exception2));
            await state.WaitAsync(exception2, default);
        }

        [Fact]
        public async Task ErrorWithBackoffLongerThanTimeout_FailsRetry()
        {
            // Create a clock that starts at zero ticks.
            var clock = new FakeClock(0);
            var scheduler = new AdvanceFakeClockScheduler(clock);
            var callSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromSeconds(10)));
            var state = new RetryState(clock, scheduler, s_retrySettings, callSettings);

            // The retry info contains a wait time that is longer than the timeout of the call.
            // The retry state will throw a DeadlineExceeded error without waiting.
            var retryInfo = new Rpc.RetryInfo { RetryDelay = Duration.FromTimeSpan(TimeSpan.FromSeconds(20)) };
            Metadata trailers = new Metadata
            {
                { RetryState.RetryInfoKey, retryInfo.ToByteArray() }
            };
            var exception = new RpcException(new Status(StatusCode.Unavailable, "Bang"), trailers);
            Assert.True(state.CanRetry(exception));
            await Assert.ThrowsAsync<RpcException>(() => state.WaitAsync(exception, default));
            // Check that the clock has not been advanced to verify that the retry state did not wait 20 seconds
            // before throwing an exception.
            Assert.Equal(0, clock.GetCurrentDateTimeUtc().Ticks);
        }

        [Fact]
        public async Task ErrorWithBackoffAfterDeadline_FailsRetry()
        {
            // Create a clock that starts at zero ticks.
            var clock = new FakeClock(0);
            var scheduler = new AdvanceFakeClockScheduler(clock);
            var callSettings = CallSettings.FromExpiration(Expiration.FromDeadline(new DateTime(TimeSpan.FromSeconds(10).Ticks, DateTimeKind.Utc)));
            var state = new RetryState(clock, scheduler, s_retrySettings, callSettings);

            // The retry info contains a wait time that is past the deadline of the call.
            // The retry state will throw a DeadlineExceeded error without waiting.
            var retryInfo = new Rpc.RetryInfo { RetryDelay = Duration.FromTimeSpan(TimeSpan.FromSeconds(20)) };
            Metadata trailers = new Metadata
            {
                { RetryState.RetryInfoKey, retryInfo.ToByteArray() }
            };
            var exception = new RpcException(new Status(StatusCode.Unavailable, "Bang"), trailers);
            Assert.True(state.CanRetry(exception));
            await Assert.ThrowsAsync<RpcException>(() => state.WaitAsync(exception, default));
            // Check that the clock has not been advanced to verify that the retry state did not wait 20 seconds
            // before throwing an exception.
            Assert.Equal(0, clock.GetCurrentDateTimeUtc().Ticks);
        }

        [Fact]
        public async Task ConsecutiveErrors_FailsRetryWhenTimeoutExceeded()
        {
            var clock = new FakeClock(0);
            var scheduler = new AdvanceFakeClockScheduler(clock);
            var callSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromSeconds(7)));
            var state = new RetryState(clock, scheduler, s_retrySettings, callSettings);

            var retryInfo = new Rpc.RetryInfo { RetryDelay = Duration.FromTimeSpan(TimeSpan.FromSeconds(3)) };
            Metadata trailers = new Metadata
            {
                { RetryState.RetryInfoKey, retryInfo.ToByteArray() }
            };
            var exception = new RpcException(new Status(StatusCode.Unavailable, "Bang"), trailers);

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
            await Assert.ThrowsAsync<RpcException>(() => state.WaitAsync(exception, default));

            // Verify that the clock has been advanced 6 seconds.
            Assert.Equal(TimeSpan.FromSeconds(6).Ticks, clock.GetCurrentDateTimeUtc().Ticks);
        }

        [Fact]
        public async Task ConsecutiveErrors_FailsRetryWhenDeadlineExceeded()
        {
            var clock = new FakeClock(0);
            var scheduler = new AdvanceFakeClockScheduler(clock);
            var callSettings = CallSettings.FromExpiration(Expiration.FromDeadline(new DateTime(TimeSpan.FromSeconds(7).Ticks, DateTimeKind.Utc)));
            var state = new RetryState(clock, scheduler, s_retrySettings, callSettings);

            var retryInfo = new Rpc.RetryInfo { RetryDelay = Duration.FromTimeSpan(TimeSpan.FromSeconds(3)) };
            Metadata trailers = new Metadata
            {
                { RetryState.RetryInfoKey, retryInfo.ToByteArray() }
            };
            var exception = new RpcException(new Status(StatusCode.Unavailable, "Bang"), trailers);

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
            await Assert.ThrowsAsync<RpcException>(() => state.WaitAsync(exception, default));

            // Verify that the clock has been advanced 6 seconds.
            Assert.Equal(TimeSpan.FromSeconds(6).Ticks, clock.GetCurrentDateTimeUtc().Ticks);
        }

        [Fact]
        public async Task ResetTimeout()
        {
            var clock = new FakeClock(0);
            var scheduler = new AdvanceFakeClockScheduler(clock);
            var callSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromSeconds(7)));
            var state = new RetryState(clock, scheduler, s_retrySettings, callSettings);

            var retryInfo = new Rpc.RetryInfo { RetryDelay = Duration.FromTimeSpan(TimeSpan.FromSeconds(3)) };
            Metadata trailers = new Metadata
            {
                { RetryState.RetryInfoKey, retryInfo.ToByteArray() }
            };
            var exception = new RpcException(new Status(StatusCode.Unavailable, "Bang"), trailers);

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            // Reset should set the deadline of the call to CurrentTime + Timeout.
            // That means that we can do two new retries without a timeout exception.
            state.Reset();

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
            await Assert.ThrowsAsync<RpcException>(() => state.WaitAsync(exception, default));

            // Verify that the clock has been advanced 12 seconds.
            Assert.Equal(TimeSpan.FromSeconds(12).Ticks, clock.GetCurrentDateTimeUtc().Ticks);
        }

        [Fact]
        public async Task ResetDeadline()
        {
            var clock = new FakeClock(0);
            var scheduler = new AdvanceFakeClockScheduler(clock);
            var callSettings = CallSettings.FromExpiration(Expiration.FromDeadline(new DateTime(TimeSpan.FromSeconds(7).Ticks, DateTimeKind.Utc)));
            var state = new RetryState(clock, scheduler, s_retrySettings, callSettings);

            var retryInfo = new Rpc.RetryInfo { RetryDelay = Duration.FromTimeSpan(TimeSpan.FromSeconds(3)) };
            Metadata trailers = new Metadata
            {
                { RetryState.RetryInfoKey, retryInfo.ToByteArray() }
            };
            var exception = new RpcException(new Status(StatusCode.Unavailable, "Bang"), trailers);

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            Assert.True(state.CanRetry(exception));
            await state.WaitAsync(exception, default);

            // Reset does not change the absolute deadline of the call.
            // The next retry attempt will therefore fail.
            state.Reset();

            Assert.True(state.CanRetry(exception));
            await Assert.ThrowsAsync<RpcException>(() => state.WaitAsync(exception, default));

            Assert.Equal(TimeSpan.FromSeconds(6).Ticks, clock.GetCurrentDateTimeUtc().Ticks);
        }

        private static RetryState CreateSimpleRetryState() => new RetryState(
            new FakeClock(),
            new Mock<IScheduler>(MockBehavior.Strict).Object,
            s_retrySettings,
            s_callSettings);
    }
}

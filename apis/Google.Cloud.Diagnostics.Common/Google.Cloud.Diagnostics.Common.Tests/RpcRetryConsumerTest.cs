// Copyright 2017 Google Inc. All Rights Reserved.
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

using Grpc.Core;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class RpcRetryConsumerTest
    {
        [Fact]
        public void Receive()
        {
            var options = RetryOptions.NoRetry(ExceptionHandling.Propagate);
            var consumer = new SimpleConsumer<int>();
            Func<Action, RetryOptions, ISequentialThreadingTimer> timerFactory =
                (callback, retryOptions) => new SequentialThreadingTimer();
            using var retryConsumer = new RpcRetryConsumer<int>(consumer, options, Utils.ConstantSizer<int>.GetSize, timerFactory);

            int[] intArray = { 1, 2, 3, 4 };
            retryConsumer.Receive(intArray);

            Assert.Equal(new[] { 1, 2, 3, 4 }, consumer.Items);
            Assert.Equal(1, consumer.ReceiveCount);
        }

        [Fact]
        public async Task ReceiveAsync()
        {
            var options = RetryOptions.NoRetry(ExceptionHandling.Propagate);
            var consumer = new SimpleConsumer<int>();
            Func<Action, RetryOptions, ISequentialThreadingTimer> timerFactory =
                (callback, retryOptions) => new SequentialThreadingTimer();
            using var retryConsumer = new RpcRetryConsumer<int>(consumer, options, Utils.ConstantSizer<int>.GetSize, timerFactory);

            int[] intArray = { 1, 2, 3, 4 };
            await retryConsumer.ReceiveAsync(intArray);

            Assert.Equal(new[] { 1, 2, 3, 4 }, consumer.Items);
            Assert.Equal(1, consumer.ReceiveCount);
        }

        [Fact]
        public void Receive_NoRetry_Propagate()
        {
            SetupTestReceiveThrows((timer, consumer, retryConsumer) => {
                int[] intArray = { 1, 2, 3, 4 };
                Assert.Throws<RpcException>(() => { retryConsumer.Receive(intArray); });

                Assert.Equal(1, consumer.FailedCalls);
                Assert.Null(timer.Callback);
            }, RetryOptions.NoRetry(ExceptionHandling.Propagate));
        }

        [Fact]
        public void Receive_NoRetry_Ignore()
        {
            SetupTestReceiveThrows((timer, consumer, retryConsumer) =>
            {
                int[] intArray = { 1, 2, 3, 4 };
                retryConsumer.Receive(intArray);

                Assert.Equal(1, consumer.FailedCalls);
                Assert.Null(timer.Callback);
            }, RetryOptions.NoRetry());
        }

        [Fact]
        public void Receive_Retry()
        {
            var timer = new FakeSequentialThreadingTimer();
            var options = RetryOptions.Retry();
            var timerFactory = CreateTimerFactory(timer);
            var consumer = new ThrowingConsumer<int>(1);

            using var retryConsumer = new RpcRetryConsumer<int>(consumer, options, Utils.ConstantSizer<int>.GetSize, timerFactory);
            int[] intArray = { 1, 2, 3, 4 };
            retryConsumer.Receive(intArray);

            timer.Call();
            // Extra call to ensure buffer is emptied.
            timer.Call();

            Assert.Equal(new[] { 1, 2, 3, 4 }, consumer.Items);
            Assert.Equal(1, consumer.ReceiveCount);
            Assert.Equal(1, consumer.FailedCalls);
        }

        [Fact]
        public void Receive_Retry_BufferFull_Ignore()
        {
            SetupTestReceiveThrows((timer, consumer, retryConsumer) =>
            {
                int[] intArray = { 1, 2, 3, 4 };
                retryConsumer.Receive(intArray);

                Assert.Equal(1, consumer.FailedCalls);
                timer.Call();
                // No new calls
                Assert.Equal(1, consumer.FailedCalls);
            }, RetryOptions.Retry(bufferSizeBytes: 1));
        }

        [Fact]
        public void Receive_Retry_BufferFull_Throw()
        {
            SetupTestReceiveThrows((timer, consumer, retryConsumer) =>
            {
                int[] intArray = { 1, 2, 3, 4 };
                Assert.Throws<InvalidOperationException>(() => { retryConsumer.Receive(intArray); });

                Assert.Equal(1, consumer.FailedCalls);
                timer.Call();
                // No new calls
                Assert.Equal(1, consumer.FailedCalls);
            }, RetryOptions.Retry(bufferSizeBytes: 1, bufferOverflow: BufferOverflow.ThrowException));
        }

        [Fact]
        public void Receive_Retry_MaxRetries_Ignore()
        {
            SetupTestReceiveThrows((timer, consumer, retryConsumer) =>
            {
                int[] intArray = { 1, 2, 3, 4 };
                retryConsumer.Receive(intArray);

                timer.Call();
                timer.Call();
                // Extra call to ensure buffer is emptied.
                timer.Call();
                Assert.Equal(3, consumer.FailedCalls);
            }, RetryOptions.Retry(retryAttempts: 2));
        }

        [Fact]
        public void Receive_Retry_MaxRetries_Throw()
        {
            SetupTestReceiveThrows((timer, consumer, retryConsumer) =>
            {
                int[] intArray = { 1, 2, 3, 4 };
                retryConsumer.Receive(intArray);

                timer.Call();
                Assert.Throws<InvalidOperationException>(() => { timer.Call(); });
                // Extra call to ensure buffer is emptied.
                timer.Call();
                Assert.Equal(3, consumer.FailedCalls);
            }, RetryOptions.Retry(exceptionHandling: ExceptionHandling.Propagate, retryAttempts: 2));
        }

        /// <summary>
        /// Creates a timer factory with a fake timer.
        /// </summary>
        private Func<Action, RetryOptions, ISequentialThreadingTimer> CreateTimerFactory(FakeSequentialThreadingTimer timer)
        {
            return (callback, retryOptions) =>
            {
                timer.Initialize(callback, retryOptions.RetryInterval);
                return timer;
            };
        }

        /// <summary>
        /// Sets up a test where all calls to the consumer passed to the <see cref="RpcRetryConsumer"/> will throw
        /// an <see cref="RpcException"/>.
        /// </summary>
        private void SetupTestReceiveThrows(Action<FakeSequentialThreadingTimer, ThrowingConsumer<int>, RpcRetryConsumer<int>> action, RetryOptions options)
        {
            var timer = new FakeSequentialThreadingTimer();
            var consumer = new ThrowingConsumer<int>(int.MaxValue);
            var timerFactory = CreateTimerFactory(timer);
            using var retryConsumer = new RpcRetryConsumer<int>(consumer, options, Utils.ConstantSizer<int>.GetSize, timerFactory);
            action(timer, consumer, retryConsumer);

            // Check that we haven't somehow managed to bypass the exception and actually receive something.
            Assert.Empty(consumer.Items);
            Assert.Equal(0, consumer.ReceiveCount);
        }

        /// <summary>
        /// A fake <see cref="ISequentialThreadingTimer"/> where the callback is only called when
        /// <see cref="Call"/> is called.
        /// </summary>
        private class FakeSequentialThreadingTimer : ISequentialThreadingTimer
        {
            internal Action Callback { get; private set; }

            public void Initialize(Action callback, TimeSpan waitTime) => Callback = callback;

            public void Call() => Callback();

            public void Dispose() { }
        }
    }
}

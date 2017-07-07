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
using Moq;
using System;
using System.Collections.Generic;
using System.Threading;
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
            var mockConsumer = new Mock<IConsumer<int>>();
            Func<Action, RetryOptions, ISequentialThreadingTimer> timerFactory =
                (callback, retryOptions) => new SequentialThreadingTimer();
            using (var retryConsumer = new RpcRetryConsumer<int>(
                mockConsumer.Object, options, Utils.ConstantSizer<int>.GetSize, timerFactory))
            {
                int[] intArray = { 1, 2, 3, 4 };
                retryConsumer.Receive(intArray);
                mockConsumer.Verify(c => c.Receive(intArray), Times.Once);
            }
        }

        [Fact]
        public async Task ReceiveAsync()
        {
            var options = RetryOptions.NoRetry(ExceptionHandling.Propagate);
            var mockConsumer = new Mock<IConsumer<int>>();
            Func<Action, RetryOptions, ISequentialThreadingTimer> timerFactory =
                (callback, retryOptions) => new SequentialThreadingTimer();
            using (var retryConsumer = new RpcRetryConsumer<int>(
                mockConsumer.Object, options, Utils.ConstantSizer<int>.GetSize, timerFactory))
            {
                int[] intArray = { 1, 2, 3, 4 };
                await retryConsumer.ReceiveAsync(intArray);
                mockConsumer.Verify(c => c.ReceiveAsync(intArray, CancellationToken.None), Times.Once);
            }
        }

        [Fact]
        public void Receive_NoRetry_Propagate()
        {
            SetupTestReceiveThrows((timer, mockConsumer, retryConsumer) => {
                int[] intArray = { 1, 2, 3, 4 };
                Assert.Throws<RpcException>(() => { retryConsumer.Receive(intArray); });

                mockConsumer.Verify(c => c.Receive(intArray), Times.Once);
                timer.Call();
                mockConsumer.Verify(c => c.Receive(intArray), Times.Once);
            }, RetryOptions.NoRetry(ExceptionHandling.Propagate));
        }

        [Fact]
        public void Receive_NoRetry_Ignore()
        {
            SetupTestReceiveThrows((timer, mockConsumer, retryConsumer) =>
            {
                int[] intArray = { 1, 2, 3, 4 };
                retryConsumer.Receive(intArray);

                mockConsumer.Verify(c => c.Receive(intArray), Times.Once);
                timer.Call();
                mockConsumer.Verify(c => c.Receive(intArray), Times.Once);
            }, RetryOptions.NoRetry());
        }

        [Fact]
        public void Receive_Retry()
        {
            var timer = new FakeSequentialThreadingTimer();
            var options = RetryOptions.Retry();
            var mockConsumer = new Mock<IConsumer<int>>();
            var timerFactory = CreateTimerFactory(timer);
            var calls = 0;
            mockConsumer.Setup(c => c.Receive(It.IsAny<IEnumerable<int>>()))
                .Callback(() =>
                {
                    calls++;
                    if (calls == 1)
                    {
                        throw new RpcException(Status.DefaultSuccess);
                    }
                });

            using (var retryConsumer = new RpcRetryConsumer<int>(
                mockConsumer.Object, options, Utils.ConstantSizer<int>.GetSize, timerFactory))
            {
                int[] intArray = { 1, 2, 3, 4 };
                retryConsumer.Receive(intArray);

                timer.Call();
                // Extra call to ensure buffer is emptied.
                timer.Call();
                mockConsumer.Verify(c => c.Receive(intArray), Times.Exactly(2));
            }
        }

        [Fact]
        public void Receive_Retry_BufferFull_Ignore()
        {
            SetupTestReceiveThrows((timer, mockConsumer, retryConsumer) =>
            {
                int[] intArray = { 1, 2, 3, 4 };
                retryConsumer.Receive(intArray);

                mockConsumer.Verify(c => c.Receive(intArray), Times.Once);
                timer.Call();
                mockConsumer.Verify(c => c.Receive(intArray), Times.Once);
            }, RetryOptions.Retry(bufferSizeBytes: 1));
        }

        [Fact]
        public void Receive_Retry_BufferFull_Throw()
        {
            SetupTestReceiveThrows((timer, mockConsumer, retryConsumer) =>
            {
                int[] intArray = { 1, 2, 3, 4 };
                Assert.Throws<InvalidOperationException>(() => { retryConsumer.Receive(intArray); });

                mockConsumer.Verify(c => c.Receive(intArray), Times.Once);
                timer.Call();
                mockConsumer.Verify(c => c.Receive(intArray), Times.Once);
            }, RetryOptions.Retry(bufferSizeBytes: 1, bufferOverflow: BufferOverflow.ThrowException));
        }

        [Fact]
        public void Receive_Retry_MaxRetries_Ignore()
        {
            SetupTestReceiveThrows((timer, mockConsumer, retryConsumer) =>
            {
                int[] intArray = { 1, 2, 3, 4 };
                retryConsumer.Receive(intArray);

                timer.Call();
                timer.Call();
                // Extra call to ensure buffer is emptied.
                timer.Call();
                mockConsumer.Verify(c => c.Receive(intArray), Times.Exactly(3));
            }, RetryOptions.Retry(retryAttempts: 2));
        }

        [Fact]
        public void Receive_Retry_MaxRetries_Throw()
        {
            SetupTestReceiveThrows((timer, mockConsumer, retryConsumer) =>
            {
                int[] intArray = { 1, 2, 3, 4 };
                retryConsumer.Receive(intArray);

                timer.Call();
                Assert.Throws<InvalidOperationException>(() => { timer.Call(); });
                // Extra call to ensure buffer is emptied.
                timer.Call();
                mockConsumer.Verify(c => c.Receive(intArray), Times.Exactly(3));
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
        private void SetupTestReceiveThrows(Action<FakeSequentialThreadingTimer, Mock<IConsumer<int>>, RpcRetryConsumer<int>> action, RetryOptions options)
        {
            var timer = new FakeSequentialThreadingTimer();
            var mockConsumer = new Mock<IConsumer<int>>();
            var timerFactory = CreateTimerFactory(timer);
            mockConsumer.Setup(c => c.Receive(It.IsAny<IEnumerable<int>>()))
                    .Throws(new RpcException(Status.DefaultSuccess));
            using (var retryConsumer = new RpcRetryConsumer<int>(
                mockConsumer.Object, options, Utils.ConstantSizer<int>.GetSize, timerFactory))
            {
                action(timer, mockConsumer, retryConsumer);
            }
        }

        /// <summary>
        /// A fake <see cref="ISequentialThreadingTimer"/> where the callback is only called when
        /// <see cref="Call"/> is called.
        /// </summary>
        private class FakeSequentialThreadingTimer : ISequentialThreadingTimer
        {
            private Action _callback;

            public void Initialize(Action callback, TimeSpan waitTime) => _callback = callback;

            public void Call() => _callback();

            public void Dispose() { }
        }
    }
}
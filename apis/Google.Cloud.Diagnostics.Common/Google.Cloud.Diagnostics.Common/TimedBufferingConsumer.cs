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
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Threading;
using Grpc.Core;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A <see cref="IFlushableConsumer{T}"/> that will automatically flush the buffer after a 
    /// given amount of time.
    /// </summary>
    internal class TimedBufferingConsumer<T> : FlushableConsumerBase<T>
    {
        /// <summary>The consumer to flush to.</summary>
        private readonly IConsumer<T> _consumer;

        /// <summary>
        /// The buffered items. This is not readonly as it is replaced when the buffer is flushed.
        /// </summary>
        private List<T> _items = new List<T>();

        /// <summary>The timer to automatically flush the buffer.</summary>
        private IThreadingTimer _timer;

        internal TimedBufferingConsumer(IConsumer<T> consumer, TimeSpan waitTime, IThreadingTimer timer)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _timer = GaxPreconditions.CheckNotNull(timer, nameof(timer));
            // Initialize the timer to flush ever wait time interval.
            _timer.Initialize((e) => {
                try
                {
                    Flush();
                }
                catch (RpcException)
                {
                    // TODO(talarico): This is a short term solution to ensure 
                    // we do not kill a process. See issue #842 to track the long term solution.
                    // This solution is dependent on implementation details specifically the fact
                    // that all consumers that make requests are gRPC based.
                }
            }, waitTime);
        }

        /// <summary>
        /// Creates a new <see cref="TimedBufferingConsumer{T}"/> that will automatically flush the 
        /// buffer to the <see cref="IConsumer{T}"/> after the given wait time.
        /// </summary>
        /// <param name="consumer">The consumer to flush to, cannot be null.</param>
        /// <param name="waitTime">The amount of time between automatic flushes.</param>
        public static TimedBufferingConsumer<T> Create(IConsumer<T> consumer, TimeSpan waitTime)
            => new TimedBufferingConsumer<T>(consumer, waitTime, new SimpleThreadingTimer());

        /// <inheritdoc />
        public override void Dispose()
        {
            Flush();
            _timer.Dispose();
        }

        /// <inheritdoc />
        protected override void ReceiveWithSemaphoreHeld(IEnumerable<T> items)
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            _items.AddRange(items);
        }

        /// <inheritdoc />
        protected override Task ReceiveAsyncWithSemaphoreHeldAsync(
            IEnumerable<T> items, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            _items.AddRange(items);
            return CommonUtils.CompletedTask;
        }

        /// <inheritdoc />
        protected override void FlushWithSemaphoreHeld()
        {
            if (_items.Count == 0)
            {
                return;
            }

            _consumer.Receive(_items);
            _items = new List<T>();
        }

        /// <inheritdoc />
        protected override Task FlushAsyncWithSemaphoreHeldAsync(CancellationToken cancellationToken)
        {
            if (_items.Count == 0)
            {
                return CommonUtils.CompletedTask;
            }

            IList<T> old = _items;
            _items = new List<T>();
            return _consumer.ReceiveAsync(old, cancellationToken);
        }
    }
}

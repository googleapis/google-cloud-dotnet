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

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A <see cref="IFlushableConsumer{T}"/> that will automatically flush after
    /// a given span of time.
    /// </summary>
    internal class TimedBufferingConsumer<T> : FlushableConsumerBase<T>
    {
        /// <summary>The consumer to flush to.</summary>		
        private readonly IConsumer<T> _consumer;

        /// <summary>The minimum amount of time to wait between automatically flushing the buffer.</summary>
        private readonly TimeSpan _waitTime;

        /// <summary>A clock for getting the current timestamp.</summary>
        private readonly IClock _clock;

        /// <summary>The buffered items.</summary>		
        private List<T> _items = new List<T>();

        /// <summary>The earliest time of the next automatica flush.</summary>
        private DateTime _nextFlush;

        private TimedBufferingConsumer(IConsumer<T> consumer, TimeSpan waitTime, IClock clock) : base()
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _waitTime = waitTime;
            _clock = GaxPreconditions.CheckNotNull(clock, nameof(clock));
            _nextFlush = _clock.GetCurrentDateTimeUtc().Add(_waitTime);
        }

        /// <summary>
        /// Creates a new <see cref="TimedBufferingConsumer{T}"/> that will flush to the
        /// given <see cref="IConsumer{T}"/> during a <see cref="Receive(IEnumerable{T})"/> call after
        /// the preset wait time since the last flush has passed.
        /// </summary>
        /// <param name="consumer">The consumer to flush to, cannot be null.</param>
        /// <param name="waitTime">The minimum amount of time between automatic flushes.</param>
        /// <param name="clock">A clock for getting the current timestamp.</param>
        public static TimedBufferingConsumer<T> Create(IConsumer<T> consumer, TimeSpan waitTime, IClock clock = null)
            => new TimedBufferingConsumer<T>(consumer, waitTime, clock ?? SystemClock.Instance);

        /// <inheritdoc />
        protected override void ReceiveWithSemaphoreHeld(IEnumerable<T> items)
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            _items.AddRange(items);
            if (_clock.GetCurrentDateTimeUtc() >= _nextFlush)
            {
                FlushWithSemaphoreHeld();
            }
        }

        /// <inheritdoc />
        protected override Task ReceiveAsyncWithSemaphoreHeldAsync(
            IEnumerable<T> items, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            _items.AddRange(items);
            if (_clock.GetCurrentDateTimeUtc() >= _nextFlush)
            {
                return FlushAsyncWithSemaphoreHeldAsync(cancellationToken);
            }
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
            _nextFlush = DateTime.UtcNow.Add(_waitTime);
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
            _nextFlush = DateTime.UtcNow.Add(_waitTime);
            return _consumer.ReceiveAsync(old, cancellationToken);
        }
    }
}

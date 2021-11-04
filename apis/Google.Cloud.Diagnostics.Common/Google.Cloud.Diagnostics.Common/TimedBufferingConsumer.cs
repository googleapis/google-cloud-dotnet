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
using System;
using System.Collections.Generic;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A <see cref="IFlushableConsumer{T}"/> that will automatically flush the buffer after a 
    /// given amount of time.
    /// </summary>
    internal class TimedBufferingConsumer<T> : FlushableConsumerBase<T>
    {
        /// <summary>
        /// The buffered items. This is not readonly as it is replaced when the buffer is flushed.
        /// </summary>
        private LinkedList<T> _items = new LinkedList<T>();

        /// <summary>The timer to automatically flush the buffer.</summary>
        private IThreadingTimer _timer;

        internal TimedBufferingConsumer(IConsumer<T> consumer, TimeSpan waitTime, IThreadingTimer timer)
            : base(consumer)
        {
            _timer = GaxPreconditions.CheckNotNull(timer, nameof(timer));
            // Initialize the timer to flush ever wait time interval.
            _timer.Initialize((e) => {
                try
                {
                    Flush();
                }
                catch (Exception)
                {
                    // TODO(atarafamas): This is a short term solution to ensure 
                    // we do not kill a process. See issue #2182 (currently in backlog) to track the long solution.
                }
            }, waitTime);
        }

        /// <summary>
        /// Creates a new <see cref="TimedBufferingConsumer{T}"/> that will automatically flush the 
        /// buffer to the <see cref="IConsumer{T}"/> after the given wait time.
        /// </summary>
        /// <param name="consumer">The consumer to flush to. Must not be null.</param>
        /// <param name="waitTime">The amount of time between automatic flushes.</param>
        public static TimedBufferingConsumer<T> Create(IConsumer<T> consumer, TimeSpan waitTime)
            => new TimedBufferingConsumer<T>(consumer, waitTime, new SimpleThreadingTimer());

        /// <inheritdoc />
        public override void Dispose()
        {
            _timer.Dispose();
            Flush();
        }

        /// <inheritdoc />
        protected override bool ReceiveWithSemaphoreHeld(IEnumerable<T> items)
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            foreach (T item in items)
            {
                _items.AddLast(item);
            }
            return false;
        }

        /// <inheritdoc />
        protected override IEnumerable<T> GetAndResetItemsWithSemaphoreHeld()
        {
            LinkedList<T> old = _items;
            _items = new LinkedList<T>();
            return old;
        }
    }
}

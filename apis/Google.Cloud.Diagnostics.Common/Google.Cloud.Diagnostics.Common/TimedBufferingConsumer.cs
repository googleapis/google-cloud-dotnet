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
        private List<T> _items = new List<T>();

        /// <summary>The timer to automatically flush the buffer.</summary>
        private IThreadingTimer _timer;

        internal TimedBufferingConsumer(IConsumer<T> consumer, TimeSpan waitTime, Action<Exception> timerExceptionHandler, IThreadingTimer timer)
            : base(consumer)
        {
            _timer = GaxPreconditions.CheckNotNull(timer, nameof(timer));
            // Initialize the timer to flush ever wait time interval.
            _timer.Initialize((e) => {
                try
                {
                    Flush();
                }
                catch (Exception ex)
                {
                    // Rethrowing exceptions here on the timer thread risks inmediately
                    // crashing the application, so we don't do that even if the library
                    // has been configured to propagate exceptions.
                    // Instead calling code can specify an exception handling action
                    // through options.
                    timerExceptionHandler?.Invoke(ex);
                }
            }, waitTime);
        }

        /// <summary>
        /// Creates a new <see cref="TimedBufferingConsumer{T}"/> that will automatically flush the 
        /// buffer to the <see cref="IConsumer{T}"/> after the given wait time.
        /// </summary>
        /// <param name="consumer">The consumer to flush to. Must not be null.</param>
        /// <param name="waitTime">The amount of time between automatic flushes.</param>
        /// <param name="timerExceptionHandler">The action to handle exceptions thrown within the timer thread. May be null.</param>
        internal static TimedBufferingConsumer<T> Create(IConsumer<T> consumer, TimeSpan waitTime, Action<Exception> timerExceptionHandler)
            => new TimedBufferingConsumer<T>(consumer, waitTime, timerExceptionHandler, new SimpleThreadingTimer());

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
            _items.AddRange(items);
            return false;
        }

        /// <inheritdoc />
        protected override IEnumerable<T> GetAndResetItemsWithSemaphoreHeld()
        {
            IList<T> old = _items;
            _items = new List<T>();
            return old;
        }
    }
}

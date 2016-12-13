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

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A <see cref="IFlushableConsumer{T}"/> that will automatically flush after
    /// a given span of time.
    /// </summary>
    internal class TimedBufferingConsumer<T> : IFlushableConsumer<T>
    {
        /// <summary>A mutex to protect the buffer.</summary>
        private readonly object _mutex = new object();

        /// <summary>The consumer to flush to.</summary>
        private readonly IConsumer<T> _consumer;

        /// <summary>The buffered items.</summary>
        private List<T> _items;

        /// <summary>The minimum amount of time to wait between automatically flushing the buffer.</summary>
        private readonly TimeSpan _waitTime;

        /// <summary>The earliest time of the next automatica flush.</summary>
        private DateTime _nextFlush;

        private TimedBufferingConsumer(IConsumer<T> consumer, TimeSpan waitTime)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _waitTime = waitTime;
            _items = new List<T>();
            _nextFlush = DateTime.UtcNow.Add(_waitTime);
        }

        /// <summary>
        /// Creates a new <see cref="TimedBufferingConsumer{T}"/> that will flush to the
        /// given <see cref="IConsumer{T}"/> during a <see cref="Receive(IEnumerable{T})"/> call after
        /// the preset wait time since the last flush has passed.
        /// </summary>
        /// <param name="consumer">The consumer to flush to, cannot be null.</param>
        /// <param name="waitTime">The minimum amount of time between automatic flushes.</param>
        public static TimedBufferingConsumer<T> Create(IConsumer<T> consumer, TimeSpan waitTime)
        {
            return new TimedBufferingConsumer<T>(consumer, waitTime);
        }

        /// <inheritdoc />
        public void Receive(IEnumerable<T> items)
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            lock (_mutex)
            {
                _items.AddRange(items);
                if (DateTime.UtcNow >= _nextFlush) { 
                  Flush();
                }
            }
        }

        /// <inheritdoc />
        public void Flush()
        {
            IList<T> old;
            lock (_mutex)
            {
                old = _items;
                _items = new List<T>();
                _nextFlush = DateTime.UtcNow.Add(_waitTime);
            }

            if (old.Count != 0)
            {
                _consumer.Receive(old);
            }
        }
    }
}

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
    /// A <see cref="IFlushableConsumer{T}"/> that will automatically flush when
    /// the buffer is full.
    /// </summary>
    internal class SizedBufferingConsumer<T> : FlushableConsumerBase<T>
    {
        /// <summary>A function to obtain the size of an item in bytes.</summary>
        private readonly Func<T, int> _sizer;

        /// <summary>The size of the buffer in bytes.</summary>
        private readonly int _bufferSize;

        /// <summary>
        /// The buffered items. This is not readonly as it is replaced when the buffer is flushed.
        /// </summary>
        private IList<T> _items = new List<T>();

        /// <summary>The current size of the items.</summary>
        private int _size;

        private SizedBufferingConsumer(IConsumer<T> consumer, Func<T, int> sizer, int bufferSize)
            : base(consumer)
        {
            GaxPreconditions.CheckArgument(
                bufferSize > 0, nameof(bufferSize), "bufferSize must be greater than 0");

            _sizer = GaxPreconditions.CheckNotNull(sizer, nameof(sizer));
            _bufferSize = bufferSize;

            _size = 0;
        }

        /// <summary>
        /// Creates a new <see cref="SizedBufferingConsumer{T}"/> that will flush to the
        /// given <see cref="IConsumer{T}"/>. 
        /// </summary>
        /// <param name="consumer">The consumer to flush to. Must not be null.</param>
        /// <param name="bufferSize">The buffer size in bytes.</param>
        /// <param name="sizer">A function to obtain the size of an item in bytes.</param>
        public static SizedBufferingConsumer<T> Create(IConsumer<T> consumer, Func<T, int> sizer, int bufferSize)
            => new SizedBufferingConsumer<T>(consumer, sizer, bufferSize);

        /// <inheritdoc />
        public override void Dispose() => Flush();

        /// <inheritdoc />
        protected override bool ReceiveWithSemaphoreHeld(IEnumerable<T> items)
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            foreach (T item in items)
            {
                _size += _sizer(item);
                _items.Add(item);
            }

            return _size >= _bufferSize;
        }

        protected override IEnumerable<T> GetAndResetItemsWithSemaphoreHeld()
        {
            IList<T> old = _items;
            _items = new List<T>();
            _size = 0;

            return old;
        }
    }
}
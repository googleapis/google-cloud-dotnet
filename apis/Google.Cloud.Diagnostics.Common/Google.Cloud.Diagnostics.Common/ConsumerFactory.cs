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

namespace Google.Cloud.Diagnostics.Common
{
    internal static class ConsumerFactory<T>
    {
        /// <summary>
        /// Gets a <see cref="IConsumer{T}"/> that wraps the passed in consumer based on the buffer options.
        /// </summary>
        /// <param name="consumer">The consumer to buffer into.</param>
        /// <param name="sizer">A function to obtain the size of an item in bytes.</param>
        /// <param name="bufferOptions">Buffer options for the buffered consumer.</param>
        /// <param name="retryOptions">Retry options for all consumer types.</param>
        internal static IConsumer<T> GetConsumer(IConsumer<T> consumer, Func<T, int> sizer,
            BufferOptions bufferOptions, RetryOptions retryOptions)
        {
            GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            GaxPreconditions.CheckNotNull(sizer, nameof(sizer));
            GaxPreconditions.CheckNotNull(bufferOptions, nameof(bufferOptions));
            GaxPreconditions.CheckNotNull(retryOptions, nameof(retryOptions));

            Func<Action, RetryOptions, ISequentialThreadingTimer> timerFactory = 
                (callback, options) => 
                {
                    ISequentialThreadingTimer timer = new SequentialThreadingTimer();
                    timer.Initialize(callback, options.RetryInterval);
                    return timer;
                };
            var retryConsumer = new RpcRetryConsumer<T>(consumer, retryOptions, sizer, timerFactory); 

            switch (bufferOptions.BufferType)
            {
                case BufferType.Sized:
                    return SizedBufferingConsumer<T>.Create(retryConsumer, sizer, bufferOptions.BufferSizeBytes);
                case BufferType.Timed:
                    return TimedBufferingConsumer<T>.Create(retryConsumer, bufferOptions.BufferWaitTime);
                case BufferType.None:
                    return retryConsumer;
                default:
                    throw new ArgumentException($"Invalid BufferType: {bufferOptions.BufferType}");
            }
        }
    }
}

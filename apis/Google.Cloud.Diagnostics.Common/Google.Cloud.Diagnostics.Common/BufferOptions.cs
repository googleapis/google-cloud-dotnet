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

using System;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Types of buffers.
    /// </summary>
    public enum BufferType
    {
        /// <summary>No buffer will be used and the base consumer will be returned.</summary>
        None,

        /// <summary>A sized buffer will be used to wrap the base consumer.</summary>
        Sized,

        /// <summary>A timed buffer will be used to wrap the base consumer.</summary>
        Timed
    }

    /// <summary>
    /// Options that define a buffer.
    /// </summary>
    public sealed class BufferOptions
    {
        /// <summary>
        /// Singleton for a <see cref= "BufferOptions" /> instance that describes a 
        /// <see cref="BufferType.None"/> type of buffer.
        /// </summary>
        private static readonly BufferOptions s_noBufferInstance = new BufferOptions(BufferType.None);

        /// <summary>The default buffer size in bytes. 2^16 = 65536.</summary>
        internal const int DefaultBufferSize = 65536;

        /// <summary>The default amount of time to wait before a flush is automatically made.</summary>
        private static readonly TimeSpan DefaultWaitTime = TimeSpan.FromSeconds(5);

        /// <summary>The type of buffer to be used.</summary>
        public BufferType BufferType { get; }

        /// <summary>The size of the buffer in bytes, only used for <see cref="BufferType.Sized"/></summary>
        public int BufferSizeBytes { get; }

        /// <summary>The time to wait before the buffer is flushed, only used for <see cref="BufferType.Timed"/></summary>
        public TimeSpan BufferWaitTime { get; }

        internal BufferOptions(BufferType bufferType, int? bufferSizeBytes = null, TimeSpan? bufferWaitTime = null)
        {
            BufferType = bufferType;
            BufferSizeBytes = bufferSizeBytes ?? default(int);
            BufferWaitTime = bufferWaitTime ?? default(TimeSpan);
        }

        /// <summary>
        /// Create <see cref="BufferOptions"/> for <see cref="BufferType.None"/>
        /// </summary>
        public static BufferOptions NoBuffer() => s_noBufferInstance;

        /// <summary>
        /// Create <see cref="BufferOptions"/> for <see cref="BufferType.Sized"/>
        /// </summary>
        /// <param name="bufferSizeBytes">Optional, The buffer size in bytes.</param>
        public static BufferOptions SizedBuffer(int bufferSizeBytes = DefaultBufferSize)
            => new BufferOptions(BufferType.Sized, bufferSizeBytes);

        /// <summary>
        /// Create <see cref="BufferOptions"/> for <see cref="BufferType.Timed"/>
        /// </summary>
        /// <param name="bufferWaitTime">Optional, The minimum amount of time between flushes.</param>
        public static BufferOptions TimedBuffer(TimeSpan? bufferWaitTime = null)
            => new BufferOptions(BufferType.Timed, null, bufferWaitTime ?? DefaultWaitTime);
    }
}
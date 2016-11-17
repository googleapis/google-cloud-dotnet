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
using Google.Devtools.Cloudtrace.V1;

namespace Google.Devtools.AspNet
{
    /// <summary>
    /// A <see cref="IFlushableTraceConsumer"/> that will automatically flush traces when
    /// the buffer is full.
    /// </summary>
    internal sealed class BufferingTraceConsumer : IFlushableTraceConsumer
    {
        /// <summary>The default buffer size in bytes. 2^16 = 65536.</summary>
        private const int DefaultBufferSize = 65536;

        /// <summary>A mutex to protect the buffer.</summary>
        private readonly object _mutex = new object();

        /// <summary>The trace consumer to flush traces to.</summary>
        private readonly ITraceConsumer _consumer;

        /// <summary>The size of the buffer in bytes.</summary>
        private readonly int _bufferSize;

        /// <summary>The buffered traces.</summary>
        private Traces _traces;

        /// <summary>The current size of traces.</summary>
        private int _size;

        private BufferingTraceConsumer(ITraceConsumer consumer, int bufferSize)
        {
            GaxPreconditions.CheckArgument(
                bufferSize > 0, nameof(bufferSize), "bufferSize must be greater than 0");

            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _bufferSize = bufferSize;

            _traces = new Traces();
            _size = 0;
        }

        /// <summary>
        /// Creates a new <see cref="BufferingTraceConsumer"/> that will flush traces to the
        /// given <see cref="ITraceConsumer"/>. 
        /// </summary>
        /// <param name="consumer">The consumer to flush traces to, cannot be null.</param>
        /// <param name="bufferSize">Optional, buffer size in bytes.</param>
        public static BufferingTraceConsumer Create(ITraceConsumer consumer, int bufferSize = DefaultBufferSize)
        {
            return new BufferingTraceConsumer(consumer, bufferSize);
        }

        /// <inheritdoc />
        public void Receive(Traces traces)
        {
            GaxPreconditions.CheckNotNull(traces, nameof(traces));
            lock (_mutex)
            {
                foreach (Trace trace in traces.Traces_)
                {
                    _size += trace.CalculateSize();
                    _traces.Traces_.Add(trace);
                    if (_size >= _bufferSize)
                    {
                        Flush();
                    }
                }
            }
        }

        /// <inheritdoc />
        public void Flush()
        {
            Traces old;
            lock (_mutex)
            {
                old = _traces;
                _traces = new Traces();
                _size = 0;
            }

            if (old.Traces_.Count != 0) { 
                _consumer.Receive(old);
            }
        }
    }
}

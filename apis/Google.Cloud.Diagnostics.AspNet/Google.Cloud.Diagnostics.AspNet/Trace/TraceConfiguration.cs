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
using Google.Cloud.Diagnostics.Common;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// Optional configuration to be used when initializing tracing.
    /// </summary>
    public sealed class TraceConfiguration
    {
        internal const double DefaultQpsSampleRate = 1.0;

        /// <summary>Gets the QPS sample rate.</summary>
        public double QpsSampleRate { get; }

        /// <summary>The buffer options for the tracer.</summary>
        public BufferOptions BufferOptions { get; }

        private TraceConfiguration(double qpsSampleRate, BufferOptions bufferOptions)
        {
            GaxPreconditions.CheckArgument(
                qpsSampleRate > 0, nameof(qpsSampleRate), "qpsSampleRate must be greater than 0.");
            QpsSampleRate = qpsSampleRate;
            BufferOptions = GaxPreconditions.CheckNotNull(bufferOptions, nameof(bufferOptions));
        }

        /// <summary>
        /// Creates a <see cref="TraceConfiguration"/>.
        /// </summary>
        /// <param name="qpsSampleRate">Optional, the qps sample rate.  The sample rate determines
        ///     how often requests are automatically traced. Defaults to <see cref="DefaultQpsSampleRate"/>
        /// </param>
        /// <param name="bufferOptions">Optional, the buffer options.  Defaults to a <see cref="BufferType.Sized"/></param>
        public static TraceConfiguration Create(
            double qpsSampleRate = DefaultQpsSampleRate, BufferOptions bufferOptions = null)
        {
            return new TraceConfiguration(qpsSampleRate, bufferOptions ?? BufferOptions.SizedBuffer());
        }
    }
}
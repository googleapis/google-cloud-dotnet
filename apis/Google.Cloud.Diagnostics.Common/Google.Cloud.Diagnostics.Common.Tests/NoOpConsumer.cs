// Copyright 2018 Google Inc. All Rights Reserved.
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

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    /// <summary>
    /// An <see cref="IConsumer{T}"> for testing that does nothing.
    /// </summary>
    public class NoOpConsumer : IConsumer<TraceProto>
    {
        /// <summary>
        /// Does nothing
        /// </summary>
        /// <param name="items"></param>
        public void Receive(IEnumerable<TraceProto> items) { }

        /// <summary>
        /// Returns a completed task.
        /// </summary>
        public Task ReceiveAsync(IEnumerable<TraceProto> items, CancellationToken cancellationToken = default) =>
            Task.Delay(0);

        /// <summary>
        /// Does nothing
        /// </summary>
        public void Dispose() { }
    }
}

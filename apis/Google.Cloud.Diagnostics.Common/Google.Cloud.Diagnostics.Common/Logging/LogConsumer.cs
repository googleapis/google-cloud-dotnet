// Copyright 2017 Google Inc. All Rights Reserved.
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
using Google.Cloud.Logging.V2;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Functions to create <see cref="IConsumer{LogEntry}"/>s.
    /// </summary>
    public static class LogConsumer
    {
        /// <summary>
        /// Creates an <see cref="IConsumer{LogEntry}"/> based on the client and options.
        /// </summary>
        /// <param name="client">A client to send log entries with. Cannot be null.</param>
        /// <param name="bufferOptions">The buffering options. Cannot be null.</param>
        /// <param name="retryOptions">The retry options. Cannot be null.</param>
        public static IConsumer<LogEntry> Create(LoggingServiceV2Client client,
            BufferOptions bufferOptions, RetryOptions retryOptions)
        {
            GaxPreconditions.CheckNotNull(client, nameof(client));
            GaxPreconditions.CheckNotNull(bufferOptions, nameof(bufferOptions));
            GaxPreconditions.CheckNotNull(retryOptions, nameof(retryOptions));

            return ConsumerFactory<LogEntry>.GetConsumer(
                new GrpcLogConsumer(client), MessageSizer<LogEntry>.GetSize, bufferOptions, retryOptions);
        }
    }
}

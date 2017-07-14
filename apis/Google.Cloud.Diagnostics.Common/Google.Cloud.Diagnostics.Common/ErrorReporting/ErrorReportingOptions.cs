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
using System.Diagnostics;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Optional configuration to be used when initializing error reporting.
    /// </summary>
    public sealed class ErrorReportingOptions
    {
        /// <summary>
        /// Where the error events should be sent.
        /// </summary>
        public EventTarget EventTarget { get; }

        /// <summary>The buffer options for the error reporter.</summary>
        public BufferOptions BufferOptions { get; }

        /// <summary>The retry options for the error reporter.</summary>
        public RetryOptions RetryOptions { get; }

        private ErrorReportingOptions(EventTarget eventTarget, BufferOptions bufferOptions, RetryOptions retryOptions)
        {
            EventTarget = GaxPreconditions.CheckNotNull(eventTarget, nameof(eventTarget));
            BufferOptions = GaxPreconditions.CheckNotNull(bufferOptions, nameof(bufferOptions));
            RetryOptions = GaxPreconditions.CheckNotNull(retryOptions, nameof(retryOptions));
        }

        /// <summary>
        /// Creates an <see cref="ErrorReportingOptions"/>.
        /// </summary>
        /// <param name="eventTarget">Where the error events should be sent. Cannot be null.</param>
        /// <param name="bufferOptions">The buffer options for the error reporter. Defaults to no buffer.</param>
        /// <param name="retryOptions">The retry options for the error reporter. Defaults to no retry.</param>
        public static ErrorReportingOptions Create(
            EventTarget eventTarget, BufferOptions bufferOptions = null, RetryOptions retryOptions = null) =>
            new ErrorReportingOptions(eventTarget, 
                bufferOptions ?? BufferOptions.NoBuffer(), retryOptions ?? RetryOptions.NoRetry());

        /// <summary>
        /// Creates an <see cref="ErrorReportingOptions"/> that will send error events to the
        /// Stackdriver Logging API.
        /// </summary>
        /// <param name="projectId">Optional if running on Google App Engine or Google Compute Engine.
        ///     The Google Cloud Platform project ID. If running on GAE or GCE the project ID will be
        ///     detected from the platform.</param>
        /// <param name="bufferOptions">The buffer options for the error reporter. Defaults to no buffer.</param>
        /// <param name="retryOptions">The retry options for the error reporter. Defaults to no retry.</param>
        public static ErrorReportingOptions Create(
            string projectId = null, BufferOptions bufferOptions = null, RetryOptions retryOptions = null) =>
                Create(EventTarget.ForLogging(projectId), bufferOptions, retryOptions);

        /// <summary>
        /// Gets a <see cref="IConsumer{LogEntry}"/>.
        /// </summary>
        internal IConsumer<LogEntry> CreateConsumer()
        {

            IConsumer<LogEntry> consumer;
            switch (EventTarget.Kind)
            {
                case EventTargetKind.Logging:
                    consumer = new GrpcLogConsumer(EventTarget.LoggingClient);
                    break;
                default:
                    Debug.Fail($"Unsupported location {EventTarget.Kind}");
                    return null;
            }

            return ConsumerFactory<LogEntry>.GetConsumer(
                consumer, MessageSizer<LogEntry>.GetSize, BufferOptions, RetryOptions);
        }
    }
}
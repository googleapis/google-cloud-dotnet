// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace GoogleCSharpSnippets
{
    // [START logging_v2_generated_LoggingServiceV2_WriteLogEntries_async_flattened]
    using Google.Api;
    using Google.Cloud.Logging.V2;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedLoggingServiceV2ClientSnippets
    {
        /// <summary>Snippet for WriteLogEntriesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task WriteLogEntriesAsync()
        {
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string logName = "projects/[PROJECT]/logs/[LOG]";
            MonitoredResource resource = new MonitoredResource();
            IDictionary<string, string> labels = new Dictionary<string, string> { { "", "" }, };
            IEnumerable<LogEntry> entries = new LogEntry[] { new LogEntry(), };
            // Make the request
            WriteLogEntriesResponse response = await loggingServiceV2Client.WriteLogEntriesAsync(logName, resource, labels, entries);
        }
    }
    // [END logging_v2_generated_LoggingServiceV2_WriteLogEntries_async_flattened]
}

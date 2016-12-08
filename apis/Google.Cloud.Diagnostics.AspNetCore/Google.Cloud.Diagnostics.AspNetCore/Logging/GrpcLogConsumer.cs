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

using System.Collections.Generic;
using Google.Cloud.Logging.V2;
using Google.Cloud.Diagnostics.Common;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    internal class GrpcLogConsumer : IConsumer<LogEntry>
    {
        private static readonly IDictionary<string, string> EmptyDictionary = new Dictionary<string, string>();
        private LoggingServiceV2Client _client;

        public GrpcLogConsumer(LoggingServiceV2Client client)
        {
            _client = client;
        }

        public void Receive(IEnumerable<LogEntry> logs)
        {
            _client.WriteLogEntriesAsync("", null, EmptyDictionary, logs);
        }
    }
}

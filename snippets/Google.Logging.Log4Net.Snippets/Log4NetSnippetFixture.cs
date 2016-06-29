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

using Google.Logging.V2;
using System;
using Xunit;

namespace Google.Logging.Log4Net.Snippets
{
    [CollectionDefinition(nameof(Log4NetSnippetFixture))]
    public sealed class Log4NetSnippetFixture : IDisposable, ICollectionFixture<Log4NetSnippetFixture>
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";

        public string ProjectId { get; }

        public string LogId { get; } = "TestLog";

        public Log4NetSnippetFixture()
        {
            ProjectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(ProjectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectEnvironmentVariable} environment variable before running tests");
            }
        }

        public void Dispose()
        {
            var logging = LoggingServiceV2Client.Create();
            var logName = LoggingServiceV2Client.FormatLogName(ProjectId, LogId);
            logging.DeleteLog(logName);
        }
    }
}

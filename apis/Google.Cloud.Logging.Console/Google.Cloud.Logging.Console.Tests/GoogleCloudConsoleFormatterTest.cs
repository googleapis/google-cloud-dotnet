// Copyright 2020 Google LLC
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

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.IO;
using Xunit;

namespace Google.Cloud.Logging.Console.Tests
{
    public class GoogleCloudConsoleFormatterTest
    {
        [Fact]
        public void SimplestLog()
        {
            var formatter = CreateFormatter();
            var logEntry = new LogEntry<string>(LogLevel.Information, "LogCategory", new EventId(1), "test", exception: null, (state, exception) => state);
            var writer = new StringWriter { NewLine = "\n" };
            formatter.Write(logEntry, scopeProvider: null, writer);
            var expectedJson = "{\"message\":\"test\",\"severity\":\"INFO\"}\n";
            var actualJson = writer.ToString();

            Assert.Equal(actualJson, expectedJson);
        }

        private static GoogleCloudConsoleFormatter CreateFormatter(GoogleCloudConsoleFormatterOptions options = null)
        {
            options ??= new GoogleCloudConsoleFormatterOptions();
            return new GoogleCloudConsoleFormatter(options);
        }
    }
}

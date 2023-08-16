// Copyright 2021 Google LLC
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

using Google.Cloud.Diagnostics.Common.Tests.Logging;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class ILoggerExtensionsTest
    {
        [Fact]
        public void WithLabels_NoChangesInOriginalLogger()
        {
            var originalLogger = new MemoryLogger("Category");

            var augmentedLogger = originalLogger.WithLabels(new KeyValuePair<string, string>("job_title", "hairdresser"));
            Assert.NotSame(originalLogger, augmentedLogger);

            originalLogger.LogInformation("Cutting hair");

            var logs = originalLogger.ListLogEntries();
            var entry = Assert.Single(logs);
            Assert.Equal("Cutting hair", entry.Message);
            Assert.Empty(entry.Scopes);
        }

        [Fact]
        public void WithLabels_BeginsScopeAndEndsScope()
        {
            var originalLogger = new MemoryLogger("Category");
            var augmentedLogger = originalLogger.WithLabels(new KeyValuePair<string, string>("job_title", "hairdresser"));

            augmentedLogger.LogInformation("Cutting hair");

            var logs = originalLogger.ListLogEntries();
            var entry = Assert.Single(logs);
            Assert.Equal("Cutting hair", entry.Message);
            AssertLabels(entry, "job_title:hairdresser");
        }

        [Fact]
        public void WithLabels_UseOriginalAfterAugmented()
        {
            var originalLogger = new MemoryLogger("Category");
            var augmentedLogger = originalLogger.WithLabels(new KeyValuePair<string, string>("job_title", "hairdresser"));

            augmentedLogger.LogInformation("Cutting hair");
            originalLogger.LogInformation("Busy");

            var logs = originalLogger.ListLogEntries();
            Assert.Equal(2, logs.Count);
            var augmentedEntry = logs[0];
            Assert.Equal("Cutting hair", augmentedEntry.Message);
            AssertLabels(augmentedEntry, "job_title:hairdresser");

            var plainEntry = logs[1];
            Assert.Equal("Busy", plainEntry.Message);
            Assert.Empty(plainEntry.Scopes);
        }

        [Fact]
        public void WithAddedLabels()
        {
            var originalLogger = new MemoryLogger("Category");
            var oneLabelLogger = originalLogger.WithLabels(new KeyValuePair<string, string>("job_title", "hairdresser"));
            var twoLabelLogger = oneLabelLogger.WithAddedLabels(new KeyValuePair<string, string>("tool", "scissors"));

            Assert.NotSame(oneLabelLogger, twoLabelLogger);
            twoLabelLogger.LogInformation("Cutting hair");

            var logs = originalLogger.ListLogEntries();
            var entry = Assert.Single(logs);
            Assert.Equal("Cutting hair", entry.Message);
            AssertLabels(entry, "job_title:hairdresser", "tool:scissors");
        }

        [Fact]
        public void WithAddedLabels_NoWithLabels()
        {
            var originalLogger = new MemoryLogger("Category");
            var augmentedLogger = originalLogger.WithAddedLabels(new KeyValuePair<string, string>("job_title", "hairdresser"));
            augmentedLogger.LogInformation("Cutting hair");

            var logs = originalLogger.ListLogEntries();
            var entry = Assert.Single(logs);
            Assert.Equal("Cutting hair", entry.Message);
            AssertLabels(entry, "job_title:hairdresser");
        }

        [Fact]
        public void WithAddedLabels_UseInitiallyAugmented()
        {
            var originalLogger = new MemoryLogger("Category");
            var oneLabelLogger = originalLogger.WithLabels(new KeyValuePair<string, string>("job_title", "hairdresser"));
            var twoLabelLogger = oneLabelLogger.WithAddedLabels(new KeyValuePair<string, string>("tool", "scissors"));

            twoLabelLogger.LogInformation("Cutting hair");
            oneLabelLogger.LogInformation("Busy");

            var logs = originalLogger.ListLogEntries();
            Assert.Equal(2, logs.Count);
            var twoLabelEntry = logs[0];
            Assert.Equal("Cutting hair", twoLabelEntry.Message);
            AssertLabels(twoLabelEntry, "job_title:hairdresser", "tool:scissors");

            var oneLabelEntry = logs[1];
            Assert.Equal("Busy", oneLabelEntry.Message);
            AssertLabels(oneLabelEntry, "job_title:hairdresser");
        }

        private static void AssertLabels(TestLogEntry entry, params string[] labels)
        {
            var scope = Assert.Single(entry.Scopes);
            var labellingScope = Assert.IsType<LabellingScopeState>(scope);
            var actualLabels = labellingScope.Labels;
            Assert.Equal(labels.Length, actualLabels.Count);

            foreach (var pair in labels)
            {
                var bits = pair.Split(':');
                var key = bits[0];
                var value = bits[1];
                Assert.Equal(value, actualLabels[key]);
            }
        }
    }
}

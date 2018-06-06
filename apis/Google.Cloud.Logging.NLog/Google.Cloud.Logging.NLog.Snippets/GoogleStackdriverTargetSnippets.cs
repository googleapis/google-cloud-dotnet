// Copyright 2018 Google Inc. All rights reserved.
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

using Google.Cloud.ClientTesting;
using Google.Cloud.Logging.V2;
using NLog;
using NLog.Config;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Xml;
using Xunit;

namespace Google.Cloud.Logging.NLog.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(NLogSnippetFixture))]
    public class GoogleStackdriverTargetSnippets
    {
        private readonly NLogSnippetFixture _fixture;

        public GoogleStackdriverTargetSnippets(NLogSnippetFixture fixture) => _fixture = fixture;

        [Fact]
        public void Overview()
        {
            string projectId = _fixture.ProjectId;
            string logId = $"{_fixture.LogId}-{Guid.NewGuid()}";
            string fileName = "nlog.xml";
            string resourceName = $"{typeof(GoogleStackdriverTargetSnippets).Namespace}.nlog-template.xml";

            // Load the NLog XML configuration, and replace the projectId and logId
            string xml;
            using (var stream = typeof(GoogleStackdriverTargetSnippets).GetTypeInfo().Assembly
                .GetManifestResourceStream(resourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    xml = reader.ReadToEnd();
                }
            }
            xml = xml.Replace("PROJECT_ID", projectId).Replace("LOG_ID", logId);
            Assert.False(File.Exists(fileName), "Test would overwrite existing file");
            //var xmlReader = XmlReader.Create(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));
            File.WriteAllText(fileName, xml);

            // Ensure NLog throws exceptions for any error conditions
            LogManager.ThrowExceptions = true;
            LogManager.ThrowConfigExceptions = true;

            // Configure nlog to use Google Stackdriver logging from the XML configuration file.
            //LogManager.Configuration = new XmlLoggingConfiguration(xmlReader, "unused");

            try
            {
                // Resource: nlog-template.xml nlog_template
                // Sample: Overview
                // Configure nlog to use Google Stackdriver logging from the XML configuration file.
                LogManager.LoadConfiguration("nlog.xml");

                // Acquire a logger for this class
                Logger logger = LogManager.GetCurrentClassLogger();
                // Log some information.This log entry will be sent to Google Stackdriver Logging.
                logger.Info("An exciting log entry!");

                // Flush buffered log entries before program exit; then shutdown the logger before program exit.
                LogManager.Flush(TimeSpan.FromSeconds(15));
                LogManager.Shutdown();
                // End sample

                // Verify the log entry is in StackDriver
                var logClient = LoggingServiceV2Client.Create();
                var logName = new LogName(projectId, logId);
                // Wait up to 60 seconds for the log entry to appear in StackDriver.
                for (int i = 0; i < 60; i++)
                {
                    var logEntry = logClient.ListLogEntries(new[] { $"projects/{projectId}" },
                        $"logName=\"{logName}\" AND \"An exciting log entry!\"", "timestamp desc").FirstOrDefault();
                    if (logEntry != null)
                    {
                        Assert.Contains("An exciting log entry!", logEntry.TextPayload);
                        return;
                    }
                    Thread.Sleep(1_000);
                }
                Assert.False(true, "Log entry failed to appear in StackDriver.");
            }
            finally
            {
                File.Delete(fileName);
            }
        }
    }
}

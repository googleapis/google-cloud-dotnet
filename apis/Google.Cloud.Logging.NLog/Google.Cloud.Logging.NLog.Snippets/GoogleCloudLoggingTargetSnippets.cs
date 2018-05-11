using Google.Cloud.ClientTesting;
using Google.Cloud.Logging.V2;
using NLog;
using NLog.Config;
using NLog.Targets.Wrappers;
using System;
using System.Collections.Generic;
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
    public class GoogleCloudLoggingTargetSnippets
    {
        private readonly NLogSnippetFixture _fixture;

        public GoogleCloudLoggingTargetSnippets(NLogSnippetFixture fixture) => _fixture = fixture;

        [Fact]
        public void Overview()
        {
            string projectId = _fixture.ProjectId;
            string logId = $"{_fixture.LogId}-{Guid.NewGuid()}";
            string resourceName = $"{typeof(GoogleCloudLoggingTargetSnippets).Namespace}.nlog-template.xml";

            // Load the NLog XML configuration, and replace the projectId and logId
            string xmlString;
            using (var stream = typeof(GoogleCloudLoggingTargetSnippets).GetTypeInfo().Assembly
                .GetManifestResourceStream(resourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    xmlString = reader.ReadToEnd();
                }
            }
            xmlString = xmlString.Replace("PROJECT_ID", projectId).Replace("LOG_ID", logId);
            var xmlReader = XmlReader.Create(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));

            // Ensure NLog throws exceptions for any error conditions
            LogManager.ThrowExceptions = true;
            LogManager.ThrowConfigExceptions = true;

            // Configure nlog to use Google Stackdriver logging from the XML configuration file.
            LogManager.Configuration = new XmlLoggingConfiguration(xmlReader, "unused");

            // Sample: Overview
            // Acquire a logger for this class
            Logger logger = LogManager.GetCurrentClassLogger();
            // Log some information.This log entry will be sent to Google Stackdriver Logging.
            string logMessage = $"An exciting log entry! With a Guid:{Guid.NewGuid()}";
            logger.Info(logMessage);

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
                    $"logName=\"{logName}\" AND \"{logMessage}\"", "timestamp desc").FirstOrDefault();
                if (logEntry != null)
                {
                    Assert.Contains(logMessage, logEntry.TextPayload);
                    return;
                }
                Thread.Sleep(1_000);
            }
            Assert.False(true, "Log entry failed to appear in StackDriver.");
        }
    }
}

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

using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Xml;
using Xunit;

namespace Google.Cloud.Logging.Log4Net.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(Log4NetSnippetFixture))]
    public class GoogleStackdriverAppenderSnippets
    {
        private class Program { }

        private readonly Log4NetSnippetFixture _fixture;

        public GoogleStackdriverAppenderSnippets(Log4NetSnippetFixture fixture)
        {
            _fixture = fixture;
        }

        // SampleResource: log4net-template.xml

        [SkippableFact]
        public void Overview()
        {
            TestEnvironment.SkipOnRestrictedEnvironment();
            DateTime startTime = DateTime.UtcNow;
            string projectId = _fixture.ProjectId;
            string logId = _fixture.LogId + $"-{Guid.NewGuid()}";
            string fileName = "log4net.xml";
            string resourceName = typeof(GoogleStackdriverAppenderSnippets).Namespace + ".log4net-template.xml";

            string xml;
            using (var stream = typeof(GoogleStackdriverAppenderSnippets).Assembly
                .GetManifestResourceStream(resourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    xml = reader.ReadToEnd();
                }
            }
            xml = xml.Replace("PROJECT_ID", projectId).Replace("LOG_ID", logId);
            Assert.False(File.Exists(fileName), "Test would overwrite existing file");
            File.WriteAllText(fileName, xml);

            try
            {
                // Resource: log4net-template.xml log4net_template
                // Sample: Overview
                // Configure log4net to use Google Cloud Logging from the XML configuration file.
                XmlConfigurator.Configure(LogManager.GetRepository(GetType().Assembly), new FileInfo("log4net.xml"));

                // Retrieve a logger for this context.
                ILog log = LogManager.GetLogger(typeof(Program));
                // Log some information. This log entry will be sent to Google Cloud Logging.
                log.Info("An exciting log entry!");

                // Flush buffered log entries before program exit.
                // This is required because log entries are buffered locally before being sent to Google Cloud Logging.
                // LogManager.Flush() only works in the full .NET framework (not in .NET Core):
                bool flushCompleted = LogManager.Flush(10_000);
                // On .NET Core, the specific repository needs to be flushed:
                bool repositoryFlushCompleted = ((IFlushable)LogManager.GetRepository(GetType().Assembly)).Flush(10_000);
                // End sample

                Assert.True(repositoryFlushCompleted);

                var logClient = LoggingServiceV2Client.Create();
                var logName = LogName.FromProjectLog(projectId, logId);

                string formattedTime = XmlConvert.ToString(startTime.AddMinutes(-3), XmlDateTimeSerializationMode.Utc);
                string filter = $"timestamp >= \"{formattedTime}\" AND logName=\"{logName}\" AND \"An exciting log entry!\"";

                // Wait up to 30 seconds for the log entry to appear in Google Cloud Logging.
                for (int i = 0; i < 30; i++)
                {
                    var logEntry = logClient.ListLogEntries(
                        resourceNames: new[] { ProjectName.FromProject(projectId) },
                        filter: filter,
                        orderBy: "timestamp desc")
                        .FirstOrDefault();
                    if (logEntry != null)
                    {
                        Assert.Contains("An exciting log entry!", logEntry.TextPayload);
                        return;
                    }
                    Thread.Sleep(1_000);
                }
                Assert.Fail("Log entry failed to appear in Google Cloud Logging.");
            }
            finally
            {
                File.Delete(fileName);
            }
        }

        // SampleResource: log4net-custom-labels-template.xml

        [SkippableFact]
        public void CustomLabels()
        {
            TestEnvironment.SkipOnRestrictedEnvironment();
            DateTime startTime = DateTime.UtcNow;
            string projectId = _fixture.ProjectId;
            string logId = _fixture.LogId + $"-{Guid.NewGuid()}";
            string fileName = "log4net.xml";
            string resourceName = typeof(GoogleStackdriverAppenderSnippets).Namespace + ".log4net-custom-labels-template.xml";

            string xml;
            using (var stream = typeof(GoogleStackdriverAppenderSnippets).Assembly
                .GetManifestResourceStream(resourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    xml = reader.ReadToEnd();
                }
            }
            xml = xml.Replace("PROJECT_ID", projectId).Replace("LOG_ID", logId);
            Assert.False(File.Exists(fileName), "Test would overwrite existing file");
            File.WriteAllText(fileName, xml);

            try
            {
                // Resource: log4net-custom-labels-template.xml log4net_custom_labels_template
                // Sample: Custom_Labels
                // Configure log4net to use Google Cloud Logging from the XML configuration file.
                XmlConfigurator.Configure(LogManager.GetRepository(GetType().Assembly), new FileInfo("log4net.xml"));

                // Retrieve a logger for this context.
                ILog log = LogManager.GetLogger(typeof(Program));
                // Set a property using one of the GlobaContext, ThreadContext or LogicalThreadContext classes.
                LogicalThreadContext.Properties["property_for_label"] = "my label value";
                // Log some information. This log entry will be sent to Google Cloud Logging with a label
                // {"label_from_property", "my label value"}. The label key "label_from_property" is the one
                // specified in configuration for a custom label that gets its value from the "property_for_label"
                // property.
                log.Info("An exciting log entry!");

                // Flush buffered log entries before program exit.
                // This is required because log entries are buffered locally before being sent to Google Cloud Logging.
                // LogManager.Flush() only works in the full .NET framework (not in .NET Core):
                bool flushCompleted = LogManager.Flush(10_000);
                // On .NET Core, the specific repository needs to be flushed:
                bool repositoryFlushCompleted = ((IFlushable)LogManager.GetRepository(GetType().Assembly)).Flush(10_000);
                // End sample

                Assert.True(repositoryFlushCompleted);

                var logClient = LoggingServiceV2Client.Create();
                var logName = LogName.FromProjectLog(projectId, logId);

                string formattedTime = XmlConvert.ToString(startTime.AddMinutes(-3), XmlDateTimeSerializationMode.Utc);
                string filter = $"timestamp >= \"{formattedTime}\" AND logName=\"{logName}\" AND \"An exciting log entry!\"";

                // Wait up to 30 seconds for the log entry to appear in Google Cloud Logging.
                for (int i = 0; i < 30; i++)
                {
                    var logEntry = logClient.ListLogEntries(
                        resourceNames: new[] { ProjectName.FromProject(projectId) },
                        filter: filter,
                        orderBy: "timestamp desc")
                        .FirstOrDefault();
                    if (logEntry != null)
                    {
                        Assert.Contains("An exciting log entry!", logEntry.TextPayload);
                        Assert.Contains(logEntry.Labels, label => label.Key == "label_from_property" && label.Value == "my label value");
                        return;
                    }
                    Thread.Sleep(1_000);
                }
                Assert.Fail("Log entry failed to appear in Google Cloud Logging.");
            }
            finally
            {
                File.Delete(fileName);
            }
        }

#pragma warning disable xUnit1013 // Public method should be marked as test
        // This cannot be a unit test as ASP.NET cannot run in this environment.
        public void Overview_AspNet()
#pragma warning restore xUnit1013 // Public method should be marked as test
        {
            // Resource: log4net-aspnet-template.xml log4net_aspnet_template
            // Sample: Overview_AspNet
            // Load log4net configuration from Web.config
            log4net.Config.XmlConfigurator.Configure(LogManager.GetRepository(GetType().Assembly));
            // End sample
        }

        // Sample: IJsonLayout
        public class SampleJsonLayout : IJsonLayout, IOptionHandler
        {
            public Struct _template;

            public int SampleConfigurationValue { get; set; }

            public void ActivateOptions()
            {
                _template = new Struct();
                _template.Fields["SampleConfiguration"] = Value.ForNumber(SampleConfigurationValue);
            }

            public Struct Format(LoggingEvent loggingEvent)
            {
                Struct ret = _template.Clone();
                ret.Fields["Message"] = Value.ForString(loggingEvent.RenderedMessage);
                if (loggingEvent.ExceptionObject != null)
                {
                    ret.Fields["Exception"] = Value.ForString(loggingEvent.ExceptionObject.Message);
                }
                return ret;
            }
        }
        // End sample
    }
}

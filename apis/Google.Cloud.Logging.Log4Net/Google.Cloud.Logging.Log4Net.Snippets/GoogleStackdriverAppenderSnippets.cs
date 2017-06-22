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

using log4net;
using log4net.Config;
using System.IO;
using Xunit;
using System.Reflection;

namespace Google.Cloud.Logging.Log4Net.Snippets
{
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

        [Fact]
        public void Overview()
        {
            string projectId = _fixture.ProjectId;
            string logId = _fixture.LogId;
            string fileName = "log4net.xml";
            string resourceName = typeof(GoogleStackdriverAppenderSnippets).Namespace + ".log4net-template.xml";

            string xml;
            using (var stream = typeof(GoogleStackdriverAppenderSnippets).GetTypeInfo().Assembly
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
                // Configure log4net to use Google Stackdriver logging from the XML configuration file.
                XmlConfigurator.Configure(LogManager.GetRepository(GetType().GetTypeInfo().Assembly), new FileInfo("log4net.xml"));

                // Retrieve a logger for this context.
                ILog log = LogManager.GetLogger(typeof(Program));
                // Log some information. This log entry will be sent to Google Stackdriver Logging.
                log.Info("An exciting log entry!");
                // End sample
            }
            finally
            {
                File.Delete(fileName);
            }

            // We can't assert anything here because:
            // * Log entries don't appear in the log instantly.
            // * Uploads happen in the background, so we can't check RPC repsonses.
        }

        public void Overview_AspNet()
        {
            // This cannot be a unit test as ASP.NET cannot run in this environment.
            // Resource: log4net-aspnet-template.xml log4net_aspnet_template
            // Sample: Overview_AspNet
            // Load log4net configuration from Web.config
            log4net.Config.XmlConfigurator.Configure(LogManager.GetRepository(GetType().GetTypeInfo().Assembly));
            // End sample
        }
    }
}

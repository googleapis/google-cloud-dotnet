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
using System.Text;
using Xunit;

namespace Google.Logging.Log4Net.Snippets
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

        [Fact]
        public void Overview()
        {
            string projectId = _fixture.ProjectId;
            string logId = _fixture.LogId;

            // Sample: Overview
            string xml = $@"
<?xml version=""1.0"" encoding=""utf-8"" ?>
<log4net>
  <appender name=""CloudLogger"" type=""Google.Logging.Log4Net.GoogleStackdriverAppender,Google.Logging.Log4Net"">
    <layout type=""log4net.Layout.PatternLayout"">
      <conversionPattern value=""%-4timestamp [%thread] %-5level %logger %ndc - %message""/>
    </layout>
    <projectId value = ""{projectId}""/>
    <logId value=""{logId}""/>
  </appender>
  <root>
    <level value=""ALL""/>
    <appender-ref ref=""CloudLogger""/>
  </root>
</log4net>
".Trim();
            MemoryStream xmlStream = new MemoryStream(Encoding.ASCII.GetBytes(xml));
            XmlConfigurator.Configure(xmlStream);
            // Usually the above configuration would use an XML configuration file,
            // rather than inline XML:
            // XmlConfigurator.Configure(new FileInfo("log4net.xml"));

            // Retrieve a logger for this context.
            ILog log = LogManager.GetLogger(typeof(Program));
            // Log some information. This log entry will be sent to Google Stackdriver Logging.
            log.Info("An exciting log entry!");
            // End sample

            // We can't assert anything here because:
            // * Log entries don't appear in the log instantly.
            // * Uploads happen in the background, so we can't check RPC repsonses.
        }
    }
}

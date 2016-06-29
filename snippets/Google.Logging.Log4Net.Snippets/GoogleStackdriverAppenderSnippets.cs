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

using Google.Api;
using Google.Api.Gax;
using Google.Logging.V2;
using log4net;
using log4net.Config;
using Moq;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Logging.Log4Net.Snippets
{
    public class GoogleStackdriverAppenderSnippets
    {
        private class Program { }

        [Fact]
        public void Overview()
        {
            var uploadedEntries = new List<LogEntry>();
            var fakeClient = new Mock<LoggingServiceV2Client>(MockBehavior.Strict);
            fakeClient.Setup(x => x.WriteLogEntriesAsync("", null, It.IsAny<IDictionary<string, string>>(), It.IsAny<IEnumerable<LogEntry>>(), null))
                .Returns<string, MonitoredResource, IDictionary<string, string>, IEnumerable<LogEntry>, CallSettings>((a, b, c, entries, d) =>
                {
                    uploadedEntries.AddRange(entries);
                    var tcs = new TaskCompletionSource<WriteLogEntriesResponse>();
                    tcs.SetResult(new WriteLogEntriesResponse());
                    return tcs.Task;
                });
            GoogleStackdriverAppender.ClientOverride = fakeClient.Object;

            // Sample: Overview
            var xml = @"
<?xml version=""1.0"" encoding=""utf-8"" ?>
<log4net>
  <appender name=""CloudLogger"" type=""Google.Logging.Log4Net.GoogleStackdriverAppender,Google.Logging.Log4Net"">
    <layout type=""log4net.Layout.PatternLayout"">
      <conversionPattern value=""%-4timestamp [%thread] %-5level %logger %ndc - %message""/>
    </layout>
    <projectId value = ""your-project-ID""/>
    <logId value=""your-log-ID""/>
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

            Thread.Sleep(100);
            Assert.Equal(1, uploadedEntries.Count);
            Assert.Contains("An exciting log entry!", uploadedEntries[0].TextPayload);
        }
    }
}

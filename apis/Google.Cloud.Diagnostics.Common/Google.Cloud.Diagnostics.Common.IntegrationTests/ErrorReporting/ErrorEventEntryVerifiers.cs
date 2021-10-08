// Copyright 2018 Google Inc. All Rights Reserved.
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
using Google.Cloud.ErrorReporting.V1Beta1;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests
{
    internal static class ErrorEventEntryVerifiers
    {
        /// <summary>
        /// Checks that there's only one event present.
        /// Includes a message with context info to help track the possible issue.
        /// </summary>
        public static ErrorEvent VerifySingle(ErrorEventEntryPolling polling, string contextInfo)
        {
            var events = polling.GetEvents(contextInfo, 1);
            var errorEvent = events.SingleOrDefault();
            Assert.True(errorEvent != null, $"No entries found for context {contextInfo}");
            return errorEvent;
        }

        /// <summary>
        /// Checks that there are <paramref name="expected"/> events present.
        /// Includes a message with context info to help track the possible issue.
        /// </summary>
        public static IEnumerable<ErrorEvent> VerifyMany(ErrorEventEntryPolling polling, string contextInfo, int expected)
        {
            var events = polling.GetEvents(contextInfo, expected);
            Assert.True(expected == events.Count(), $"Should have found {expected} entries for contest {contextInfo} but found {events.Count()}");
            return events;
        }

        /// <summary>
        /// Checks that an <see cref="ErrorEvent"/> contains valid data,
        /// including HTTP Context data.
        /// </summary>
        public static void VerifyFullErrorEventLogged(ErrorEvent errorEvent, string testId, string functionName, bool verifyHttpContext = true)
        {
            VerifyErrorEventLogged(errorEvent, testId, functionName);
            if (verifyHttpContext)
            {
                VerifyHttpContextLogged(errorEvent);
            }
        }

        /// <summary>
        /// Checks that an <see cref="ErrorEvent"/> contains valid data.
        /// Doesn't check for HTTP Context data, which won't be logged 
        /// when from within a self hosted Web API application the
        /// Google.Cloud.Diagnostics.GoogleExceptionLogger is used instead of the
        /// Google.Cloud.Diagnostics.GoogleWebApiExceptionLogger.
        /// </summary>
        public static void VerifyErrorEventLogged(ErrorEvent errorEvent, string testId, string functionName)
        {
            Assert.Equal(EntryData.Service, errorEvent.ServiceContext.Service);
            Assert.Equal(EntryData.Version, errorEvent.ServiceContext.Version);

            Assert.Contains(functionName, errorEvent.Message);
            Assert.Contains(testId, errorEvent.Message);

            if (TestEnvironment.IsWindows())
            {
                Assert.False(string.IsNullOrWhiteSpace(errorEvent.Context.ReportLocation.FilePath));
                Assert.True(errorEvent.Context.ReportLocation.LineNumber > 0);
            }
            Assert.Equal(functionName, errorEvent.Context.ReportLocation.FunctionName);
        }

        /// <summary>
        /// Checks that an <see cref="ErrorEvent"/> contains valid HTTP Context data.
        /// </summary>
        public static void VerifyHttpContextLogged(ErrorEvent errorEvent)
        {
            Assert.Equal(HttpMethod.Get.Method, errorEvent.Context.HttpRequest.Method);
            Assert.False(string.IsNullOrWhiteSpace(errorEvent.Context.HttpRequest.Url));
            // Verify that we are not storing any HTTP StatusCode
            Assert.Equal(0, errorEvent.Context.HttpRequest.ResponseStatusCode);
        }
    }
}

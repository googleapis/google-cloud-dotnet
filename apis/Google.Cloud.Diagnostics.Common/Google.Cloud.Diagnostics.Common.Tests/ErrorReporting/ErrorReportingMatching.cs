// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Protobuf.WellKnownTypes;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    internal class ErrorReportingMatching
    {
        internal const int ConflictStatusCode = 409;
        internal const string ServiceName = "SomeService";
        internal const string VersionName = "1.0.0";        
        internal const string UserAgentValue = "user-agent-1.0";
        internal const string DeleteMethod = "DELETE";
        internal const string ExceptionMessage = "some exception message";
        internal static readonly Uri GoogleUri = new Uri("https://www.google.com");

        private readonly string _defaultUri;
        private readonly string _defaultMethod;
        private readonly bool _isWindows;

        /// <summary>
        /// Creates a new instance of <see cref="ErrorReportingMatching"/> used to help matching
        /// Error Reporting Unit tests.
        /// </summary>
        /// <param name="isWindows">True if this test is running on windows.</param>
        /// <param name="defaultUri">The default uri expected for an http request uri.
        ///     Defaults to the empty string.</param>
        /// <param name="defaultMethod">The default method expected for an http request method.
        ///     Defaults to the empty string.</param>
        internal ErrorReportingMatching(bool isWindows, string defaultUri = "", string defaultMethod = "")
        {
            _isWindows = isWindows;
            _defaultUri = defaultUri;
            _defaultMethod = defaultMethod;
        }

        /// <summary>
        /// Matcher to check if an <see cref="IEnumerable{ReportedErrorEvent}"/> contains
        /// one element and matches the following: 
        /// <list type="bullet">
        /// <term>The EventTime less than or equal to now</term>
        /// <term>The HttpMethod matches the default http method</term>
        /// <term>The Url matches the default url</term>
        /// <term>The UserAgent is empty or null</term>
        /// <term>The ResponseStatusCode is "0"</term>
        /// <term>The LineNumber is "0"</term>
        /// <term>The FilePath is empty or null</term>
        /// <term>The FunctionName is empty or null</term>
        /// <term>The Service is <see cref="ServiceName"/></term>
        /// <term>The Version is <see cref="VersionName"/></term>
        /// </list>
        /// </summary>
        internal IEnumerable<ReportedErrorEvent> IsSimpleContext()
        {
            return Match.Create<IEnumerable<ReportedErrorEvent>>(enumerable => {
                var e = enumerable.Single();
                return e.Message.Contains(ExceptionMessage) &&
                    e.EventTime.Seconds <= Timestamp.FromDateTime(DateTime.UtcNow).Seconds &&
                    e.Context.HttpRequest.Method.Contains(_defaultMethod) &&
                    e.Context.HttpRequest.Url.Contains(_defaultUri) &&
                    string.IsNullOrEmpty(e.Context.HttpRequest.UserAgent) &&
                    e.Context.HttpRequest.ResponseStatusCode == 0 &&
                    e.Context.ReportLocation.LineNumber == 0 &&
                    string.IsNullOrEmpty(e.Context.ReportLocation.FilePath) &&
                    string.IsNullOrEmpty(e.Context.ReportLocation.FunctionName) &&
                    e.ServiceContext.Service.Equals(ServiceName) &&
                    e.ServiceContext.Version.Equals(VersionName);
            });
        }

        /// <summary>
        /// Matcher to check if an <see cref="IEnumerable{ReportedErrorEvent}>"/> contains
        /// one element and matches the following:
        /// <list type="bullet">
        /// <term>The EventTime less than or equal to now</term>
        /// <term>The HttpMethod is <see cref="DeleteMethod"/></term>
        /// <term>The Url is <see cref="GoogleUri"/></term>
        /// <term>The UserAgent is <see cref="UserAgentValue"/></term>
        /// <term>The ResponseStatusCode is <see cref="ConflictStatusCode"/></term>
        /// <term>The LineNumber is greater than 0</term>
        /// <term>The FilePath is not empty or null</term>
        /// <term>The FunctionName is the name of <see cref="CreateException"/></term>
        /// <term>The Service is <see cref="ServiceName"/></term>
        /// <term>The Version is <see cref="VersionName"/></term>
        /// </list>
        /// </summary>
        internal IEnumerable<ReportedErrorEvent> IsComplexContext()
        {
            return Match.Create<IEnumerable<ReportedErrorEvent>>(enumerable => {
                var e = enumerable.Single();
                return e.Message.Contains(ExceptionMessage) &&
                    e.EventTime.Seconds <= Timestamp.FromDateTime(DateTime.UtcNow).Seconds &&
                    e.Context.HttpRequest.Method.Equals(DeleteMethod) &&
                    e.Context.HttpRequest.Url.Contains(GoogleUri.ToString()) &&
                    e.Context.HttpRequest.UserAgent.Equals(UserAgentValue) &&
                    e.Context.HttpRequest.ResponseStatusCode == ConflictStatusCode &&
                    (!_isWindows || e.Context.ReportLocation.LineNumber > 0) &&
                    (!_isWindows || !string.IsNullOrEmpty(e.Context.ReportLocation.FilePath)) &&
                    e.Context.ReportLocation.FunctionName.Equals(nameof(CreateException)) &&
                    e.ServiceContext.Service.Equals(ServiceName) &&
                    e.ServiceContext.Version.Equals(VersionName);
            });
        }

        /// <summary>
        /// Create a thrown exception with message <see cref="ExceptionMessage"/>
        /// </summary>
        internal Exception CreateException()
        {
            try
            {
                throw new Exception(ExceptionMessage);
            }
            catch (Exception e)
            {
                return e;
            }
        }
    }
}

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

using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class ErrorReportingOptionsTest
    {
        [Fact]
        public void ErrorReportingOptions_ProjectId()
        {
            var options = ErrorReportingOptions.Create("pid");
            Assert.NotNull(options.ReportEventsTo);
            Assert.Equal(ReportEventsToLocation.Logging, options.ReportEventsTo.ReportEventsToLocation);
            Assert.Equal(BufferOptions.NoBuffer(), options.BufferOptions);
        }

        [Fact]
        public void ErrorReportingOptions_ReportEventsTo()
        {
            var reportTo = ReportEventsTo.ErrorReporting();
            var bufferOptions = BufferOptions.SizedBuffer();

            var options = ErrorReportingOptions.Create(reportTo, bufferOptions);
            Assert.Equal(reportTo, options.ReportEventsTo);
            Assert.Equal(bufferOptions, options.BufferOptions);
        }
    }
}

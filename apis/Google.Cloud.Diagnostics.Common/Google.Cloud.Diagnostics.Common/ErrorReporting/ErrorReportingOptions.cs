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

using Google.Api.Gax;

namespace Google.Cloud.Diagnostics.Common
{
    public sealed class ErrorReportingOptions
    {
        public ReportEventsTo ReportEventsTo { get; }

        public BufferOptions BufferOptions { get; }

        private ErrorReportingOptions(ReportEventsTo reportEventsTo, BufferOptions bufferOptions)
        {
            ReportEventsTo = GaxPreconditions.CheckNotNull(reportEventsTo, nameof(reportEventsTo));
            BufferOptions = GaxPreconditions.CheckNotNull(bufferOptions, nameof(bufferOptions));
        }

        public static ErrorReportingOptions Create(
            ReportEventsTo reportEventsTo, BufferOptions bufferOptions = null)
        {
            return new ErrorReportingOptions(
                reportEventsTo, bufferOptions ?? BufferOptions.NoBuffer());
        }

        public static ErrorReportingOptions Create(
            string projectId, BufferOptions bufferOptions = null)
        {
            GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId));
            return new ErrorReportingOptions(
                ReportEventsTo.Logging(projectId), bufferOptions ?? BufferOptions.NoBuffer());
        }
    }
}

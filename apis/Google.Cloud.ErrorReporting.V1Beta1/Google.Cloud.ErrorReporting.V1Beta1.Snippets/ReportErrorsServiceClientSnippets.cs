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

using Google.Cloud.ClientTesting;
using Google.Protobuf.WellKnownTypes;
using System;
using Xunit;

namespace Google.Cloud.ErrorReporting.V1Beta1.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(ErrorReportingFixture))]
    public class ReportErrorsServiceClientSnippets
    {
        private readonly ErrorReportingFixture _fixture;

        public ReportErrorsServiceClientSnippets(ErrorReportingFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void ReportErrorEvent()
        {
            string projectId = _fixture.ProjectId;

            // Sample: ReportErrorEvent
            // Additional: ReportErrorEvent(*,*,*)
            ReportErrorsServiceClient client = ReportErrorsServiceClient.Create();
            ProjectName projectName = new ProjectName(projectId);
            ReportedErrorEvent error = new ReportedErrorEvent
            {
                Context = new ErrorContext
                {
                    ReportLocation = new SourceLocation
                    {
                        FilePath = "SampleApp.BusinessLogic/ComplexLogic.cs",
                        FunctionName = "ComputeTrickyAnswer",
                        LineNumber = 100
                    },
                    User = "userid"                    
                },

                // If this is a stack trace, the service will parse it.
                Message = "Computation failed",

                EventTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ServiceContext = new ServiceContext
                {
                    Service = "SampleApp",
                    Version = "1.0.0"
                }
            };
            client.ReportErrorEvent(projectName, error);
            // End sample
        }
    }
}

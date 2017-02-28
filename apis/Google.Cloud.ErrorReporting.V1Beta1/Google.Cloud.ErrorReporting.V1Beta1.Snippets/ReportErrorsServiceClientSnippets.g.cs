// Copyright 2017, Google Inc. All rights reserved.
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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.ErrorReporting.V1Beta1.Snippets
{
    public class GeneratedReportErrorsServiceClientSnippets
    {
        public async Task ReportErrorEventAsync()
        {
            // Snippet: ReportErrorEventAsync(ProjectName,ReportedErrorEvent,CallSettings)
            // Additional: ReportErrorEventAsync(ProjectName,ReportedErrorEvent,CancellationToken)
            // Create client
            ReportErrorsServiceClient reportErrorsServiceClient = await ReportErrorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName projectName = new ProjectName("[PROJECT]");
            ReportedErrorEvent @event = new ReportedErrorEvent();
            // Make the request
            ReportErrorEventResponse response = await reportErrorsServiceClient.ReportErrorEventAsync(projectName, @event);
            // End snippet
        }

        public void ReportErrorEvent()
        {
            // Snippet: ReportErrorEvent(ProjectName,ReportedErrorEvent,CallSettings)
            // Create client
            ReportErrorsServiceClient reportErrorsServiceClient = ReportErrorsServiceClient.Create();
            // Initialize request argument(s)
            ProjectName projectName = new ProjectName("[PROJECT]");
            ReportedErrorEvent @event = new ReportedErrorEvent();
            // Make the request
            ReportErrorEventResponse response = reportErrorsServiceClient.ReportErrorEvent(projectName, @event);
            // End snippet
        }

        public async Task ReportErrorEventAsync_RequestObject()
        {
            // Snippet: ReportErrorEventAsync(ReportErrorEventRequest,CallSettings)
            // Create client
            ReportErrorsServiceClient reportErrorsServiceClient = await ReportErrorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportErrorEventRequest request = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = new ProjectName("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            // Make the request
            ReportErrorEventResponse response = await reportErrorsServiceClient.ReportErrorEventAsync(request);
            // End snippet
        }

        public void ReportErrorEvent_RequestObject()
        {
            // Snippet: ReportErrorEvent(ReportErrorEventRequest,CallSettings)
            // Create client
            ReportErrorsServiceClient reportErrorsServiceClient = ReportErrorsServiceClient.Create();
            // Initialize request argument(s)
            ReportErrorEventRequest request = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = new ProjectName("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            // Make the request
            ReportErrorEventResponse response = reportErrorsServiceClient.ReportErrorEvent(request);
            // End snippet
        }

    }
}

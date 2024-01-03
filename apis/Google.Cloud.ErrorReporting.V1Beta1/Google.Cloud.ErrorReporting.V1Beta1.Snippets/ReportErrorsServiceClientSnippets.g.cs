// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ErrorReporting.V1Beta1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedReportErrorsServiceClientSnippets
    {
        /// <summary>Snippet for ReportErrorEvent</summary>
        public void ReportErrorEventRequestObject()
        {
            // Snippet: ReportErrorEvent(ReportErrorEventRequest, CallSettings)
            // Create client
            ReportErrorsServiceClient reportErrorsServiceClient = ReportErrorsServiceClient.Create();
            // Initialize request argument(s)
            ReportErrorEventRequest request = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            // Make the request
            ReportErrorEventResponse response = reportErrorsServiceClient.ReportErrorEvent(request);
            // End snippet
        }

        /// <summary>Snippet for ReportErrorEventAsync</summary>
        public async Task ReportErrorEventRequestObjectAsync()
        {
            // Snippet: ReportErrorEventAsync(ReportErrorEventRequest, CallSettings)
            // Additional: ReportErrorEventAsync(ReportErrorEventRequest, CancellationToken)
            // Create client
            ReportErrorsServiceClient reportErrorsServiceClient = await ReportErrorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportErrorEventRequest request = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            // Make the request
            ReportErrorEventResponse response = await reportErrorsServiceClient.ReportErrorEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReportErrorEvent</summary>
        public void ReportErrorEvent()
        {
            // Snippet: ReportErrorEvent(string, ReportedErrorEvent, CallSettings)
            // Create client
            ReportErrorsServiceClient reportErrorsServiceClient = ReportErrorsServiceClient.Create();
            // Initialize request argument(s)
            string projectName = "projects/[PROJECT]";
            ReportedErrorEvent @event = new ReportedErrorEvent();
            // Make the request
            ReportErrorEventResponse response = reportErrorsServiceClient.ReportErrorEvent(projectName, @event);
            // End snippet
        }

        /// <summary>Snippet for ReportErrorEventAsync</summary>
        public async Task ReportErrorEventAsync()
        {
            // Snippet: ReportErrorEventAsync(string, ReportedErrorEvent, CallSettings)
            // Additional: ReportErrorEventAsync(string, ReportedErrorEvent, CancellationToken)
            // Create client
            ReportErrorsServiceClient reportErrorsServiceClient = await ReportErrorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectName = "projects/[PROJECT]";
            ReportedErrorEvent @event = new ReportedErrorEvent();
            // Make the request
            ReportErrorEventResponse response = await reportErrorsServiceClient.ReportErrorEventAsync(projectName, @event);
            // End snippet
        }

        /// <summary>Snippet for ReportErrorEvent</summary>
        public void ReportErrorEventResourceNames()
        {
            // Snippet: ReportErrorEvent(ProjectName, ReportedErrorEvent, CallSettings)
            // Create client
            ReportErrorsServiceClient reportErrorsServiceClient = ReportErrorsServiceClient.Create();
            // Initialize request argument(s)
            ProjectName projectName = ProjectName.FromProject("[PROJECT]");
            ReportedErrorEvent @event = new ReportedErrorEvent();
            // Make the request
            ReportErrorEventResponse response = reportErrorsServiceClient.ReportErrorEvent(projectName, @event);
            // End snippet
        }

        /// <summary>Snippet for ReportErrorEventAsync</summary>
        public async Task ReportErrorEventResourceNamesAsync()
        {
            // Snippet: ReportErrorEventAsync(ProjectName, ReportedErrorEvent, CallSettings)
            // Additional: ReportErrorEventAsync(ProjectName, ReportedErrorEvent, CancellationToken)
            // Create client
            ReportErrorsServiceClient reportErrorsServiceClient = await ReportErrorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName projectName = ProjectName.FromProject("[PROJECT]");
            ReportedErrorEvent @event = new ReportedErrorEvent();
            // Make the request
            ReportErrorEventResponse response = await reportErrorsServiceClient.ReportErrorEventAsync(projectName, @event);
            // End snippet
        }
    }
}

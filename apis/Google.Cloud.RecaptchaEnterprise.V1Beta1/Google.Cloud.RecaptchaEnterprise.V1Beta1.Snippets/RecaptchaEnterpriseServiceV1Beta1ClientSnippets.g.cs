// Copyright 2019 Google LLC
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

namespace Google.Cloud.RecaptchaEnterprise.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.RecaptchaEnterprise.V1Beta1;
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

    /// <summary>Generated snippets</summary>
    public class GeneratedRecaptchaEnterpriseServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for CreateAssessmentAsync</summary>
        public async Task CreateAssessmentAsync()
        {
            // Snippet: CreateAssessmentAsync(string,Assessment,CallSettings)
            // Additional: CreateAssessmentAsync(string,Assessment,CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = await recaptchaEnterpriseServiceV1Beta1Client.CreateAssessmentAsync(formattedParent, assessment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessment</summary>
        public void CreateAssessment()
        {
            // Snippet: CreateAssessment(string,Assessment,CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = recaptchaEnterpriseServiceV1Beta1Client.CreateAssessment(formattedParent, assessment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessmentAsync</summary>
        public async Task CreateAssessmentAsync_RequestObject()
        {
            // Snippet: CreateAssessmentAsync(CreateAssessmentRequest,CallSettings)
            // Additional: CreateAssessmentAsync(CreateAssessmentRequest,CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
                Assessment = new Assessment(),
            };
            // Make the request
            Assessment response = await recaptchaEnterpriseServiceV1Beta1Client.CreateAssessmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessment</summary>
        public void CreateAssessment_RequestObject()
        {
            // Snippet: CreateAssessment(CreateAssessmentRequest,CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
                Assessment = new Assessment(),
            };
            // Make the request
            Assessment response = recaptchaEnterpriseServiceV1Beta1Client.CreateAssessment(request);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessmentAsync</summary>
        public async Task AnnotateAssessmentAsync()
        {
            // Snippet: AnnotateAssessmentAsync(string,AnnotateAssessmentRequest.Types.Annotation,CallSettings)
            // Additional: AnnotateAssessmentAsync(string,AnnotateAssessmentRequest.Types.Annotation,CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new AssessmentName("[PROJECT]", "[ASSESSMENT]").ToString();
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = await recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessmentAsync(formattedName, annotation);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessment</summary>
        public void AnnotateAssessment()
        {
            // Snippet: AnnotateAssessment(string,AnnotateAssessmentRequest.Types.Annotation,CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            string formattedName = new AssessmentName("[PROJECT]", "[ASSESSMENT]").ToString();
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessment(formattedName, annotation);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessmentAsync</summary>
        public async Task AnnotateAssessmentAsync_RequestObject()
        {
            // Snippet: AnnotateAssessmentAsync(AnnotateAssessmentRequest,CallSettings)
            // Additional: AnnotateAssessmentAsync(AnnotateAssessmentRequest,CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                Name = new AssessmentName("[PROJECT]", "[ASSESSMENT]").ToString(),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified,
            };
            // Make the request
            AnnotateAssessmentResponse response = await recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessment</summary>
        public void AnnotateAssessment_RequestObject()
        {
            // Snippet: AnnotateAssessment(AnnotateAssessmentRequest,CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                Name = new AssessmentName("[PROJECT]", "[ASSESSMENT]").ToString(),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified,
            };
            // Make the request
            AnnotateAssessmentResponse response = recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessment(request);
            // End snippet
        }

    }
}

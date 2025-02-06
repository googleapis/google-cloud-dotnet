// Copyright 2025 Google LLC
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
    using Google.Cloud.RecaptchaEnterprise.V1Beta1;
    using Google.Protobuf;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRecaptchaEnterpriseServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for CreateAssessment</summary>
        public void CreateAssessmentRequestObject()
        {
            // Snippet: CreateAssessment(CreateAssessmentRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            // Make the request
            Assessment response = recaptchaEnterpriseServiceV1Beta1Client.CreateAssessment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessmentAsync</summary>
        public async Task CreateAssessmentRequestObjectAsync()
        {
            // Snippet: CreateAssessmentAsync(CreateAssessmentRequest, CallSettings)
            // Additional: CreateAssessmentAsync(CreateAssessmentRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            // Make the request
            Assessment response = await recaptchaEnterpriseServiceV1Beta1Client.CreateAssessmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessment</summary>
        public void CreateAssessment()
        {
            // Snippet: CreateAssessment(string, Assessment, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = recaptchaEnterpriseServiceV1Beta1Client.CreateAssessment(parent, assessment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessmentAsync</summary>
        public async Task CreateAssessmentAsync()
        {
            // Snippet: CreateAssessmentAsync(string, Assessment, CallSettings)
            // Additional: CreateAssessmentAsync(string, Assessment, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = await recaptchaEnterpriseServiceV1Beta1Client.CreateAssessmentAsync(parent, assessment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessment</summary>
        public void CreateAssessmentResourceNames()
        {
            // Snippet: CreateAssessment(ProjectName, Assessment, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = recaptchaEnterpriseServiceV1Beta1Client.CreateAssessment(parent, assessment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessmentAsync</summary>
        public async Task CreateAssessmentResourceNamesAsync()
        {
            // Snippet: CreateAssessmentAsync(ProjectName, Assessment, CallSettings)
            // Additional: CreateAssessmentAsync(ProjectName, Assessment, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = await recaptchaEnterpriseServiceV1Beta1Client.CreateAssessmentAsync(parent, assessment);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessment</summary>
        public void AnnotateAssessmentRequestObject()
        {
            // Snippet: AnnotateAssessment(AnnotateAssessmentRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified,
                Reasons =
                {
                    AnnotateAssessmentRequest.Types.Reason.Unspecified,
                },
                HashedAccountId = ByteString.Empty,
                TransactionEvent = new TransactionEvent(),
            };
            // Make the request
            AnnotateAssessmentResponse response = recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessment(request);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessmentAsync</summary>
        public async Task AnnotateAssessmentRequestObjectAsync()
        {
            // Snippet: AnnotateAssessmentAsync(AnnotateAssessmentRequest, CallSettings)
            // Additional: AnnotateAssessmentAsync(AnnotateAssessmentRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified,
                Reasons =
                {
                    AnnotateAssessmentRequest.Types.Reason.Unspecified,
                },
                HashedAccountId = ByteString.Empty,
                TransactionEvent = new TransactionEvent(),
            };
            // Make the request
            AnnotateAssessmentResponse response = await recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessment</summary>
        public void AnnotateAssessment()
        {
            // Snippet: AnnotateAssessment(string, AnnotateAssessmentRequest.Types.Annotation, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/assessments/[ASSESSMENT]";
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessment(name, annotation);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessmentAsync</summary>
        public async Task AnnotateAssessmentAsync()
        {
            // Snippet: AnnotateAssessmentAsync(string, AnnotateAssessmentRequest.Types.Annotation, CallSettings)
            // Additional: AnnotateAssessmentAsync(string, AnnotateAssessmentRequest.Types.Annotation, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/assessments/[ASSESSMENT]";
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = await recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessmentAsync(name, annotation);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessment</summary>
        public void AnnotateAssessmentResourceNames()
        {
            // Snippet: AnnotateAssessment(AssessmentName, AnnotateAssessmentRequest.Types.Annotation, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            AssessmentName name = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]");
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessment(name, annotation);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessmentAsync</summary>
        public async Task AnnotateAssessmentResourceNamesAsync()
        {
            // Snippet: AnnotateAssessmentAsync(AssessmentName, AnnotateAssessmentRequest.Types.Annotation, CallSettings)
            // Additional: AnnotateAssessmentAsync(AssessmentName, AnnotateAssessmentRequest.Types.Annotation, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            AssessmentName name = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]");
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = await recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessmentAsync(name, annotation);
            // End snippet
        }
    }
}

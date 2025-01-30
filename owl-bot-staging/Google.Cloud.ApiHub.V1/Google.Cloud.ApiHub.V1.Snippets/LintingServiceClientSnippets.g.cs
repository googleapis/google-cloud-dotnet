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
    using Google.Cloud.ApiHub.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLintingServiceClientSnippets
    {
        /// <summary>Snippet for GetStyleGuide</summary>
        public void GetStyleGuideRequestObject()
        {
            // Snippet: GetStyleGuide(GetStyleGuideRequest, CallSettings)
            // Create client
            LintingServiceClient lintingServiceClient = LintingServiceClient.Create();
            // Initialize request argument(s)
            GetStyleGuideRequest request = new GetStyleGuideRequest
            {
                StyleGuideName = StyleGuideName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            StyleGuide response = lintingServiceClient.GetStyleGuide(request);
            // End snippet
        }

        /// <summary>Snippet for GetStyleGuideAsync</summary>
        public async Task GetStyleGuideRequestObjectAsync()
        {
            // Snippet: GetStyleGuideAsync(GetStyleGuideRequest, CallSettings)
            // Additional: GetStyleGuideAsync(GetStyleGuideRequest, CancellationToken)
            // Create client
            LintingServiceClient lintingServiceClient = await LintingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetStyleGuideRequest request = new GetStyleGuideRequest
            {
                StyleGuideName = StyleGuideName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            StyleGuide response = await lintingServiceClient.GetStyleGuideAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStyleGuide</summary>
        public void GetStyleGuide()
        {
            // Snippet: GetStyleGuide(string, CallSettings)
            // Create client
            LintingServiceClient lintingServiceClient = LintingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/styleGuide";
            // Make the request
            StyleGuide response = lintingServiceClient.GetStyleGuide(name);
            // End snippet
        }

        /// <summary>Snippet for GetStyleGuideAsync</summary>
        public async Task GetStyleGuideAsync()
        {
            // Snippet: GetStyleGuideAsync(string, CallSettings)
            // Additional: GetStyleGuideAsync(string, CancellationToken)
            // Create client
            LintingServiceClient lintingServiceClient = await LintingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/styleGuide";
            // Make the request
            StyleGuide response = await lintingServiceClient.GetStyleGuideAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetStyleGuide</summary>
        public void GetStyleGuideResourceNames()
        {
            // Snippet: GetStyleGuide(StyleGuideName, CallSettings)
            // Create client
            LintingServiceClient lintingServiceClient = LintingServiceClient.Create();
            // Initialize request argument(s)
            StyleGuideName name = StyleGuideName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            StyleGuide response = lintingServiceClient.GetStyleGuide(name);
            // End snippet
        }

        /// <summary>Snippet for GetStyleGuideAsync</summary>
        public async Task GetStyleGuideResourceNamesAsync()
        {
            // Snippet: GetStyleGuideAsync(StyleGuideName, CallSettings)
            // Additional: GetStyleGuideAsync(StyleGuideName, CancellationToken)
            // Create client
            LintingServiceClient lintingServiceClient = await LintingServiceClient.CreateAsync();
            // Initialize request argument(s)
            StyleGuideName name = StyleGuideName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            StyleGuide response = await lintingServiceClient.GetStyleGuideAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateStyleGuide</summary>
        public void UpdateStyleGuideRequestObject()
        {
            // Snippet: UpdateStyleGuide(UpdateStyleGuideRequest, CallSettings)
            // Create client
            LintingServiceClient lintingServiceClient = LintingServiceClient.Create();
            // Initialize request argument(s)
            UpdateStyleGuideRequest request = new UpdateStyleGuideRequest
            {
                StyleGuide = new StyleGuide(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            StyleGuide response = lintingServiceClient.UpdateStyleGuide(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateStyleGuideAsync</summary>
        public async Task UpdateStyleGuideRequestObjectAsync()
        {
            // Snippet: UpdateStyleGuideAsync(UpdateStyleGuideRequest, CallSettings)
            // Additional: UpdateStyleGuideAsync(UpdateStyleGuideRequest, CancellationToken)
            // Create client
            LintingServiceClient lintingServiceClient = await LintingServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateStyleGuideRequest request = new UpdateStyleGuideRequest
            {
                StyleGuide = new StyleGuide(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            StyleGuide response = await lintingServiceClient.UpdateStyleGuideAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateStyleGuide</summary>
        public void UpdateStyleGuide()
        {
            // Snippet: UpdateStyleGuide(StyleGuide, FieldMask, CallSettings)
            // Create client
            LintingServiceClient lintingServiceClient = LintingServiceClient.Create();
            // Initialize request argument(s)
            StyleGuide styleGuide = new StyleGuide();
            FieldMask updateMask = new FieldMask();
            // Make the request
            StyleGuide response = lintingServiceClient.UpdateStyleGuide(styleGuide, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateStyleGuideAsync</summary>
        public async Task UpdateStyleGuideAsync()
        {
            // Snippet: UpdateStyleGuideAsync(StyleGuide, FieldMask, CallSettings)
            // Additional: UpdateStyleGuideAsync(StyleGuide, FieldMask, CancellationToken)
            // Create client
            LintingServiceClient lintingServiceClient = await LintingServiceClient.CreateAsync();
            // Initialize request argument(s)
            StyleGuide styleGuide = new StyleGuide();
            FieldMask updateMask = new FieldMask();
            // Make the request
            StyleGuide response = await lintingServiceClient.UpdateStyleGuideAsync(styleGuide, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetStyleGuideContents</summary>
        public void GetStyleGuideContentsRequestObject()
        {
            // Snippet: GetStyleGuideContents(GetStyleGuideContentsRequest, CallSettings)
            // Create client
            LintingServiceClient lintingServiceClient = LintingServiceClient.Create();
            // Initialize request argument(s)
            GetStyleGuideContentsRequest request = new GetStyleGuideContentsRequest
            {
                StyleGuideName = StyleGuideName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            StyleGuideContents response = lintingServiceClient.GetStyleGuideContents(request);
            // End snippet
        }

        /// <summary>Snippet for GetStyleGuideContentsAsync</summary>
        public async Task GetStyleGuideContentsRequestObjectAsync()
        {
            // Snippet: GetStyleGuideContentsAsync(GetStyleGuideContentsRequest, CallSettings)
            // Additional: GetStyleGuideContentsAsync(GetStyleGuideContentsRequest, CancellationToken)
            // Create client
            LintingServiceClient lintingServiceClient = await LintingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetStyleGuideContentsRequest request = new GetStyleGuideContentsRequest
            {
                StyleGuideName = StyleGuideName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            StyleGuideContents response = await lintingServiceClient.GetStyleGuideContentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStyleGuideContents</summary>
        public void GetStyleGuideContents()
        {
            // Snippet: GetStyleGuideContents(string, CallSettings)
            // Create client
            LintingServiceClient lintingServiceClient = LintingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/styleGuide";
            // Make the request
            StyleGuideContents response = lintingServiceClient.GetStyleGuideContents(name);
            // End snippet
        }

        /// <summary>Snippet for GetStyleGuideContentsAsync</summary>
        public async Task GetStyleGuideContentsAsync()
        {
            // Snippet: GetStyleGuideContentsAsync(string, CallSettings)
            // Additional: GetStyleGuideContentsAsync(string, CancellationToken)
            // Create client
            LintingServiceClient lintingServiceClient = await LintingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/styleGuide";
            // Make the request
            StyleGuideContents response = await lintingServiceClient.GetStyleGuideContentsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetStyleGuideContents</summary>
        public void GetStyleGuideContentsResourceNames()
        {
            // Snippet: GetStyleGuideContents(StyleGuideName, CallSettings)
            // Create client
            LintingServiceClient lintingServiceClient = LintingServiceClient.Create();
            // Initialize request argument(s)
            StyleGuideName name = StyleGuideName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            StyleGuideContents response = lintingServiceClient.GetStyleGuideContents(name);
            // End snippet
        }

        /// <summary>Snippet for GetStyleGuideContentsAsync</summary>
        public async Task GetStyleGuideContentsResourceNamesAsync()
        {
            // Snippet: GetStyleGuideContentsAsync(StyleGuideName, CallSettings)
            // Additional: GetStyleGuideContentsAsync(StyleGuideName, CancellationToken)
            // Create client
            LintingServiceClient lintingServiceClient = await LintingServiceClient.CreateAsync();
            // Initialize request argument(s)
            StyleGuideName name = StyleGuideName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            StyleGuideContents response = await lintingServiceClient.GetStyleGuideContentsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LintSpec</summary>
        public void LintSpecRequestObject()
        {
            // Snippet: LintSpec(LintSpecRequest, CallSettings)
            // Create client
            LintingServiceClient lintingServiceClient = LintingServiceClient.Create();
            // Initialize request argument(s)
            LintSpecRequest request = new LintSpecRequest
            {
                SpecName = SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            lintingServiceClient.LintSpec(request);
            // End snippet
        }

        /// <summary>Snippet for LintSpecAsync</summary>
        public async Task LintSpecRequestObjectAsync()
        {
            // Snippet: LintSpecAsync(LintSpecRequest, CallSettings)
            // Additional: LintSpecAsync(LintSpecRequest, CancellationToken)
            // Create client
            LintingServiceClient lintingServiceClient = await LintingServiceClient.CreateAsync();
            // Initialize request argument(s)
            LintSpecRequest request = new LintSpecRequest
            {
                SpecName = SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            await lintingServiceClient.LintSpecAsync(request);
            // End snippet
        }
    }
}

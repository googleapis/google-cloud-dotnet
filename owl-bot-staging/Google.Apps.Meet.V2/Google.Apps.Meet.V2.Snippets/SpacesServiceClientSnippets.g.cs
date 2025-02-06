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
    using Google.Apps.Meet.V2;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSpacesServiceClientSnippets
    {
        /// <summary>Snippet for CreateSpace</summary>
        public void CreateSpaceRequestObject()
        {
            // Snippet: CreateSpace(CreateSpaceRequest, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            CreateSpaceRequest request = new CreateSpaceRequest { Space = new Space(), };
            // Make the request
            Space response = spacesServiceClient.CreateSpace(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSpaceAsync</summary>
        public async Task CreateSpaceRequestObjectAsync()
        {
            // Snippet: CreateSpaceAsync(CreateSpaceRequest, CallSettings)
            // Additional: CreateSpaceAsync(CreateSpaceRequest, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSpaceRequest request = new CreateSpaceRequest { Space = new Space(), };
            // Make the request
            Space response = await spacesServiceClient.CreateSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSpace</summary>
        public void CreateSpace()
        {
            // Snippet: CreateSpace(Space, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            Space space = new Space();
            // Make the request
            Space response = spacesServiceClient.CreateSpace(space);
            // End snippet
        }

        /// <summary>Snippet for CreateSpaceAsync</summary>
        public async Task CreateSpaceAsync()
        {
            // Snippet: CreateSpaceAsync(Space, CallSettings)
            // Additional: CreateSpaceAsync(Space, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            Space space = new Space();
            // Make the request
            Space response = await spacesServiceClient.CreateSpaceAsync(space);
            // End snippet
        }

        /// <summary>Snippet for GetSpace</summary>
        public void GetSpaceRequestObject()
        {
            // Snippet: GetSpace(GetSpaceRequest, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            GetSpaceRequest request = new GetSpaceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            Space response = spacesServiceClient.GetSpace(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceAsync</summary>
        public async Task GetSpaceRequestObjectAsync()
        {
            // Snippet: GetSpaceAsync(GetSpaceRequest, CallSettings)
            // Additional: GetSpaceAsync(GetSpaceRequest, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSpaceRequest request = new GetSpaceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            Space response = await spacesServiceClient.GetSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpace</summary>
        public void GetSpace()
        {
            // Snippet: GetSpace(string, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]";
            // Make the request
            Space response = spacesServiceClient.GetSpace(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceAsync</summary>
        public async Task GetSpaceAsync()
        {
            // Snippet: GetSpaceAsync(string, CallSettings)
            // Additional: GetSpaceAsync(string, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]";
            // Make the request
            Space response = await spacesServiceClient.GetSpaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpace</summary>
        public void GetSpaceResourceNames()
        {
            // Snippet: GetSpace(SpaceName, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromSpace("[SPACE]");
            // Make the request
            Space response = spacesServiceClient.GetSpace(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceAsync</summary>
        public async Task GetSpaceResourceNamesAsync()
        {
            // Snippet: GetSpaceAsync(SpaceName, CallSettings)
            // Additional: GetSpaceAsync(SpaceName, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromSpace("[SPACE]");
            // Make the request
            Space response = await spacesServiceClient.GetSpaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpace</summary>
        public void UpdateSpaceRequestObject()
        {
            // Snippet: UpdateSpace(UpdateSpaceRequest, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            UpdateSpaceRequest request = new UpdateSpaceRequest
            {
                Space = new Space(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Space response = spacesServiceClient.UpdateSpace(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpaceAsync</summary>
        public async Task UpdateSpaceRequestObjectAsync()
        {
            // Snippet: UpdateSpaceAsync(UpdateSpaceRequest, CallSettings)
            // Additional: UpdateSpaceAsync(UpdateSpaceRequest, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSpaceRequest request = new UpdateSpaceRequest
            {
                Space = new Space(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Space response = await spacesServiceClient.UpdateSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpace</summary>
        public void UpdateSpace()
        {
            // Snippet: UpdateSpace(Space, FieldMask, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            Space space = new Space();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Space response = spacesServiceClient.UpdateSpace(space, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpaceAsync</summary>
        public async Task UpdateSpaceAsync()
        {
            // Snippet: UpdateSpaceAsync(Space, FieldMask, CallSettings)
            // Additional: UpdateSpaceAsync(Space, FieldMask, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            Space space = new Space();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Space response = await spacesServiceClient.UpdateSpaceAsync(space, updateMask);
            // End snippet
        }

        /// <summary>Snippet for EndActiveConference</summary>
        public void EndActiveConferenceRequestObject()
        {
            // Snippet: EndActiveConference(EndActiveConferenceRequest, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            EndActiveConferenceRequest request = new EndActiveConferenceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            spacesServiceClient.EndActiveConference(request);
            // End snippet
        }

        /// <summary>Snippet for EndActiveConferenceAsync</summary>
        public async Task EndActiveConferenceRequestObjectAsync()
        {
            // Snippet: EndActiveConferenceAsync(EndActiveConferenceRequest, CallSettings)
            // Additional: EndActiveConferenceAsync(EndActiveConferenceRequest, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndActiveConferenceRequest request = new EndActiveConferenceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            await spacesServiceClient.EndActiveConferenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EndActiveConference</summary>
        public void EndActiveConference()
        {
            // Snippet: EndActiveConference(string, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]";
            // Make the request
            spacesServiceClient.EndActiveConference(name);
            // End snippet
        }

        /// <summary>Snippet for EndActiveConferenceAsync</summary>
        public async Task EndActiveConferenceAsync()
        {
            // Snippet: EndActiveConferenceAsync(string, CallSettings)
            // Additional: EndActiveConferenceAsync(string, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]";
            // Make the request
            await spacesServiceClient.EndActiveConferenceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EndActiveConference</summary>
        public void EndActiveConferenceResourceNames()
        {
            // Snippet: EndActiveConference(SpaceName, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromSpace("[SPACE]");
            // Make the request
            spacesServiceClient.EndActiveConference(name);
            // End snippet
        }

        /// <summary>Snippet for EndActiveConferenceAsync</summary>
        public async Task EndActiveConferenceResourceNamesAsync()
        {
            // Snippet: EndActiveConferenceAsync(SpaceName, CallSettings)
            // Additional: EndActiveConferenceAsync(SpaceName, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromSpace("[SPACE]");
            // Make the request
            await spacesServiceClient.EndActiveConferenceAsync(name);
            // End snippet
        }
    }
}

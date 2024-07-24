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
    using Google.Cloud.Profiler.V2;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedProfilerServiceClientSnippets
    {
        /// <summary>Snippet for CreateProfile</summary>
        public void CreateProfileRequestObject()
        {
            // Snippet: CreateProfile(CreateProfileRequest, CallSettings)
            // Create client
            ProfilerServiceClient profilerServiceClient = ProfilerServiceClient.Create();
            // Initialize request argument(s)
            CreateProfileRequest request = new CreateProfileRequest
            {
                Deployment = new Deployment(),
                ProfileType =
                {
                    ProfileType.Unspecified,
                },
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Profile response = profilerServiceClient.CreateProfile(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProfileAsync</summary>
        public async Task CreateProfileRequestObjectAsync()
        {
            // Snippet: CreateProfileAsync(CreateProfileRequest, CallSettings)
            // Additional: CreateProfileAsync(CreateProfileRequest, CancellationToken)
            // Create client
            ProfilerServiceClient profilerServiceClient = await ProfilerServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateProfileRequest request = new CreateProfileRequest
            {
                Deployment = new Deployment(),
                ProfileType =
                {
                    ProfileType.Unspecified,
                },
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Profile response = await profilerServiceClient.CreateProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOfflineProfile</summary>
        public void CreateOfflineProfileRequestObject()
        {
            // Snippet: CreateOfflineProfile(CreateOfflineProfileRequest, CallSettings)
            // Create client
            ProfilerServiceClient profilerServiceClient = ProfilerServiceClient.Create();
            // Initialize request argument(s)
            CreateOfflineProfileRequest request = new CreateOfflineProfileRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Profile = new Profile(),
            };
            // Make the request
            Profile response = profilerServiceClient.CreateOfflineProfile(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOfflineProfileAsync</summary>
        public async Task CreateOfflineProfileRequestObjectAsync()
        {
            // Snippet: CreateOfflineProfileAsync(CreateOfflineProfileRequest, CallSettings)
            // Additional: CreateOfflineProfileAsync(CreateOfflineProfileRequest, CancellationToken)
            // Create client
            ProfilerServiceClient profilerServiceClient = await ProfilerServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateOfflineProfileRequest request = new CreateOfflineProfileRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Profile = new Profile(),
            };
            // Make the request
            Profile response = await profilerServiceClient.CreateOfflineProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOfflineProfile</summary>
        public void CreateOfflineProfile()
        {
            // Snippet: CreateOfflineProfile(string, Profile, CallSettings)
            // Create client
            ProfilerServiceClient profilerServiceClient = ProfilerServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Profile profile = new Profile();
            // Make the request
            Profile response = profilerServiceClient.CreateOfflineProfile(parent, profile);
            // End snippet
        }

        /// <summary>Snippet for CreateOfflineProfileAsync</summary>
        public async Task CreateOfflineProfileAsync()
        {
            // Snippet: CreateOfflineProfileAsync(string, Profile, CallSettings)
            // Additional: CreateOfflineProfileAsync(string, Profile, CancellationToken)
            // Create client
            ProfilerServiceClient profilerServiceClient = await ProfilerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Profile profile = new Profile();
            // Make the request
            Profile response = await profilerServiceClient.CreateOfflineProfileAsync(parent, profile);
            // End snippet
        }

        /// <summary>Snippet for CreateOfflineProfile</summary>
        public void CreateOfflineProfileResourceNames()
        {
            // Snippet: CreateOfflineProfile(ProjectName, Profile, CallSettings)
            // Create client
            ProfilerServiceClient profilerServiceClient = ProfilerServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Profile profile = new Profile();
            // Make the request
            Profile response = profilerServiceClient.CreateOfflineProfile(parent, profile);
            // End snippet
        }

        /// <summary>Snippet for CreateOfflineProfileAsync</summary>
        public async Task CreateOfflineProfileResourceNamesAsync()
        {
            // Snippet: CreateOfflineProfileAsync(ProjectName, Profile, CallSettings)
            // Additional: CreateOfflineProfileAsync(ProjectName, Profile, CancellationToken)
            // Create client
            ProfilerServiceClient profilerServiceClient = await ProfilerServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Profile profile = new Profile();
            // Make the request
            Profile response = await profilerServiceClient.CreateOfflineProfileAsync(parent, profile);
            // End snippet
        }

        /// <summary>Snippet for UpdateProfile</summary>
        public void UpdateProfileRequestObject()
        {
            // Snippet: UpdateProfile(UpdateProfileRequest, CallSettings)
            // Create client
            ProfilerServiceClient profilerServiceClient = ProfilerServiceClient.Create();
            // Initialize request argument(s)
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Profile response = profilerServiceClient.UpdateProfile(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProfileAsync</summary>
        public async Task UpdateProfileRequestObjectAsync()
        {
            // Snippet: UpdateProfileAsync(UpdateProfileRequest, CallSettings)
            // Additional: UpdateProfileAsync(UpdateProfileRequest, CancellationToken)
            // Create client
            ProfilerServiceClient profilerServiceClient = await ProfilerServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Profile response = await profilerServiceClient.UpdateProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProfile</summary>
        public void UpdateProfile()
        {
            // Snippet: UpdateProfile(Profile, FieldMask, CallSettings)
            // Create client
            ProfilerServiceClient profilerServiceClient = ProfilerServiceClient.Create();
            // Initialize request argument(s)
            Profile profile = new Profile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Profile response = profilerServiceClient.UpdateProfile(profile, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProfileAsync</summary>
        public async Task UpdateProfileAsync()
        {
            // Snippet: UpdateProfileAsync(Profile, FieldMask, CallSettings)
            // Additional: UpdateProfileAsync(Profile, FieldMask, CancellationToken)
            // Create client
            ProfilerServiceClient profilerServiceClient = await ProfilerServiceClient.CreateAsync();
            // Initialize request argument(s)
            Profile profile = new Profile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Profile response = await profilerServiceClient.UpdateProfileAsync(profile, updateMask);
            // End snippet
        }
    }
}

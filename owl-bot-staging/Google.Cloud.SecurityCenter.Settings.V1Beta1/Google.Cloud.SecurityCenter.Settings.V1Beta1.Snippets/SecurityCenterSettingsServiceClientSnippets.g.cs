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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.SecurityCenter.Settings.V1Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSecurityCenterSettingsServiceClientSnippets
    {
        /// <summary>Snippet for GetServiceAccount</summary>
        public void GetServiceAccountRequestObject()
        {
            // Snippet: GetServiceAccount(GetServiceAccountRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            ServiceAccount response = securityCenterSettingsServiceClient.GetServiceAccount(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountAsync</summary>
        public async Task GetServiceAccountRequestObjectAsync()
        {
            // Snippet: GetServiceAccountAsync(GetServiceAccountRequest, CallSettings)
            // Additional: GetServiceAccountAsync(GetServiceAccountRequest, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            ServiceAccount response = await securityCenterSettingsServiceClient.GetServiceAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccount</summary>
        public void GetServiceAccount()
        {
            // Snippet: GetServiceAccount(string, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/serviceAccount";
            // Make the request
            ServiceAccount response = securityCenterSettingsServiceClient.GetServiceAccount(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountAsync</summary>
        public async Task GetServiceAccountAsync()
        {
            // Snippet: GetServiceAccountAsync(string, CallSettings)
            // Additional: GetServiceAccountAsync(string, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/serviceAccount";
            // Make the request
            ServiceAccount response = await securityCenterSettingsServiceClient.GetServiceAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccount</summary>
        public void GetServiceAccountResourceNames()
        {
            // Snippet: GetServiceAccount(ServiceAccountName, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromOrganization("[ORGANIZATION]");
            // Make the request
            ServiceAccount response = securityCenterSettingsServiceClient.GetServiceAccount(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountAsync</summary>
        public async Task GetServiceAccountResourceNamesAsync()
        {
            // Snippet: GetServiceAccountAsync(ServiceAccountName, CallSettings)
            // Additional: GetServiceAccountAsync(ServiceAccountName, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromOrganization("[ORGANIZATION]");
            // Make the request
            ServiceAccount response = await securityCenterSettingsServiceClient.GetServiceAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettingsRequestObject()
        {
            // Snippet: GetSettings(GetSettingsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            Settings response = securityCenterSettingsServiceClient.GetSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsRequestObjectAsync()
        {
            // Snippet: GetSettingsAsync(GetSettingsRequest, CallSettings)
            // Additional: GetSettingsAsync(GetSettingsRequest, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            Settings response = await securityCenterSettingsServiceClient.GetSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettings()
        {
            // Snippet: GetSettings(string, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/settings";
            // Make the request
            Settings response = securityCenterSettingsServiceClient.GetSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsAsync()
        {
            // Snippet: GetSettingsAsync(string, CallSettings)
            // Additional: GetSettingsAsync(string, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/settings";
            // Make the request
            Settings response = await securityCenterSettingsServiceClient.GetSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettingsResourceNames()
        {
            // Snippet: GetSettings(SettingsName, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromOrganization("[ORGANIZATION]");
            // Make the request
            Settings response = securityCenterSettingsServiceClient.GetSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsResourceNamesAsync()
        {
            // Snippet: GetSettingsAsync(SettingsName, CallSettings)
            // Additional: GetSettingsAsync(SettingsName, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromOrganization("[ORGANIZATION]");
            // Make the request
            Settings response = await securityCenterSettingsServiceClient.GetSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettings</summary>
        public void UpdateSettingsRequestObject()
        {
            // Snippet: UpdateSettings(UpdateSettingsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Settings response = securityCenterSettingsServiceClient.UpdateSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettingsAsync</summary>
        public async Task UpdateSettingsRequestObjectAsync()
        {
            // Snippet: UpdateSettingsAsync(UpdateSettingsRequest, CallSettings)
            // Additional: UpdateSettingsAsync(UpdateSettingsRequest, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Settings response = await securityCenterSettingsServiceClient.UpdateSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettings</summary>
        public void UpdateSettings()
        {
            // Snippet: UpdateSettings(Settings, FieldMask, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            Settings settings = new Settings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Settings response = securityCenterSettingsServiceClient.UpdateSettings(settings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettingsAsync</summary>
        public async Task UpdateSettingsAsync()
        {
            // Snippet: UpdateSettingsAsync(Settings, FieldMask, CallSettings)
            // Additional: UpdateSettingsAsync(Settings, FieldMask, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Settings settings = new Settings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Settings response = await securityCenterSettingsServiceClient.UpdateSettingsAsync(settings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ResetSettings</summary>
        public void ResetSettingsRequestObject()
        {
            // Snippet: ResetSettings(ResetSettingsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            ResetSettingsRequest request = new ResetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                Etag = "",
            };
            // Make the request
            securityCenterSettingsServiceClient.ResetSettings(request);
            // End snippet
        }

        /// <summary>Snippet for ResetSettingsAsync</summary>
        public async Task ResetSettingsRequestObjectAsync()
        {
            // Snippet: ResetSettingsAsync(ResetSettingsRequest, CallSettings)
            // Additional: ResetSettingsAsync(ResetSettingsRequest, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResetSettingsRequest request = new ResetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                Etag = "",
            };
            // Make the request
            await securityCenterSettingsServiceClient.ResetSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetSettings</summary>
        public void BatchGetSettingsRequestObject()
        {
            // Snippet: BatchGetSettings(BatchGetSettingsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            BatchGetSettingsRequest request = new BatchGetSettingsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Names = { "", },
            };
            // Make the request
            BatchGetSettingsResponse response = securityCenterSettingsServiceClient.BatchGetSettings(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetSettingsAsync</summary>
        public async Task BatchGetSettingsRequestObjectAsync()
        {
            // Snippet: BatchGetSettingsAsync(BatchGetSettingsRequest, CallSettings)
            // Additional: BatchGetSettingsAsync(BatchGetSettingsRequest, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchGetSettingsRequest request = new BatchGetSettingsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Names = { "", },
            };
            // Make the request
            BatchGetSettingsResponse response = await securityCenterSettingsServiceClient.BatchGetSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveSettings</summary>
        public void CalculateEffectiveSettingsRequestObject()
        {
            // Snippet: CalculateEffectiveSettings(CalculateEffectiveSettingsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            CalculateEffectiveSettingsRequest request = new CalculateEffectiveSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            Settings response = securityCenterSettingsServiceClient.CalculateEffectiveSettings(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveSettingsAsync</summary>
        public async Task CalculateEffectiveSettingsRequestObjectAsync()
        {
            // Snippet: CalculateEffectiveSettingsAsync(CalculateEffectiveSettingsRequest, CallSettings)
            // Additional: CalculateEffectiveSettingsAsync(CalculateEffectiveSettingsRequest, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CalculateEffectiveSettingsRequest request = new CalculateEffectiveSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            Settings response = await securityCenterSettingsServiceClient.CalculateEffectiveSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveSettings</summary>
        public void CalculateEffectiveSettings()
        {
            // Snippet: CalculateEffectiveSettings(string, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/settings";
            // Make the request
            Settings response = securityCenterSettingsServiceClient.CalculateEffectiveSettings(name);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveSettingsAsync</summary>
        public async Task CalculateEffectiveSettingsAsync()
        {
            // Snippet: CalculateEffectiveSettingsAsync(string, CallSettings)
            // Additional: CalculateEffectiveSettingsAsync(string, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/settings";
            // Make the request
            Settings response = await securityCenterSettingsServiceClient.CalculateEffectiveSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveSettings</summary>
        public void CalculateEffectiveSettingsResourceNames()
        {
            // Snippet: CalculateEffectiveSettings(SettingsName, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromOrganization("[ORGANIZATION]");
            // Make the request
            Settings response = securityCenterSettingsServiceClient.CalculateEffectiveSettings(name);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveSettingsAsync</summary>
        public async Task CalculateEffectiveSettingsResourceNamesAsync()
        {
            // Snippet: CalculateEffectiveSettingsAsync(SettingsName, CallSettings)
            // Additional: CalculateEffectiveSettingsAsync(SettingsName, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromOrganization("[ORGANIZATION]");
            // Make the request
            Settings response = await securityCenterSettingsServiceClient.CalculateEffectiveSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchCalculateEffectiveSettings</summary>
        public void BatchCalculateEffectiveSettingsRequestObject()
        {
            // Snippet: BatchCalculateEffectiveSettings(BatchCalculateEffectiveSettingsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            BatchCalculateEffectiveSettingsRequest request = new BatchCalculateEffectiveSettingsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Requests =
                {
                    new CalculateEffectiveSettingsRequest(),
                },
            };
            // Make the request
            BatchCalculateEffectiveSettingsResponse response = securityCenterSettingsServiceClient.BatchCalculateEffectiveSettings(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCalculateEffectiveSettingsAsync</summary>
        public async Task BatchCalculateEffectiveSettingsRequestObjectAsync()
        {
            // Snippet: BatchCalculateEffectiveSettingsAsync(BatchCalculateEffectiveSettingsRequest, CallSettings)
            // Additional: BatchCalculateEffectiveSettingsAsync(BatchCalculateEffectiveSettingsRequest, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCalculateEffectiveSettingsRequest request = new BatchCalculateEffectiveSettingsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Requests =
                {
                    new CalculateEffectiveSettingsRequest(),
                },
            };
            // Make the request
            BatchCalculateEffectiveSettingsResponse response = await securityCenterSettingsServiceClient.BatchCalculateEffectiveSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetComponentSettings</summary>
        public void GetComponentSettingsRequestObject()
        {
            // Snippet: GetComponentSettings(GetComponentSettingsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            GetComponentSettingsRequest request = new GetComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            // Make the request
            ComponentSettings response = securityCenterSettingsServiceClient.GetComponentSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetComponentSettingsAsync</summary>
        public async Task GetComponentSettingsRequestObjectAsync()
        {
            // Snippet: GetComponentSettingsAsync(GetComponentSettingsRequest, CallSettings)
            // Additional: GetComponentSettingsAsync(GetComponentSettingsRequest, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetComponentSettingsRequest request = new GetComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            // Make the request
            ComponentSettings response = await securityCenterSettingsServiceClient.GetComponentSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetComponentSettings</summary>
        public void GetComponentSettings()
        {
            // Snippet: GetComponentSettings(string, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/components/[COMPONENT]/settings";
            // Make the request
            ComponentSettings response = securityCenterSettingsServiceClient.GetComponentSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetComponentSettingsAsync</summary>
        public async Task GetComponentSettingsAsync()
        {
            // Snippet: GetComponentSettingsAsync(string, CallSettings)
            // Additional: GetComponentSettingsAsync(string, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/components/[COMPONENT]/settings";
            // Make the request
            ComponentSettings response = await securityCenterSettingsServiceClient.GetComponentSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetComponentSettings</summary>
        public void GetComponentSettingsResourceNames()
        {
            // Snippet: GetComponentSettings(ComponentSettingsName, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            ComponentSettingsName name = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]");
            // Make the request
            ComponentSettings response = securityCenterSettingsServiceClient.GetComponentSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetComponentSettingsAsync</summary>
        public async Task GetComponentSettingsResourceNamesAsync()
        {
            // Snippet: GetComponentSettingsAsync(ComponentSettingsName, CallSettings)
            // Additional: GetComponentSettingsAsync(ComponentSettingsName, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ComponentSettingsName name = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]");
            // Make the request
            ComponentSettings response = await securityCenterSettingsServiceClient.GetComponentSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateComponentSettings</summary>
        public void UpdateComponentSettingsRequestObject()
        {
            // Snippet: UpdateComponentSettings(UpdateComponentSettingsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            UpdateComponentSettingsRequest request = new UpdateComponentSettingsRequest
            {
                ComponentSettings = new ComponentSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ComponentSettings response = securityCenterSettingsServiceClient.UpdateComponentSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateComponentSettingsAsync</summary>
        public async Task UpdateComponentSettingsRequestObjectAsync()
        {
            // Snippet: UpdateComponentSettingsAsync(UpdateComponentSettingsRequest, CallSettings)
            // Additional: UpdateComponentSettingsAsync(UpdateComponentSettingsRequest, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateComponentSettingsRequest request = new UpdateComponentSettingsRequest
            {
                ComponentSettings = new ComponentSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ComponentSettings response = await securityCenterSettingsServiceClient.UpdateComponentSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateComponentSettings</summary>
        public void UpdateComponentSettings()
        {
            // Snippet: UpdateComponentSettings(ComponentSettings, FieldMask, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            ComponentSettings componentSettings = new ComponentSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ComponentSettings response = securityCenterSettingsServiceClient.UpdateComponentSettings(componentSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateComponentSettingsAsync</summary>
        public async Task UpdateComponentSettingsAsync()
        {
            // Snippet: UpdateComponentSettingsAsync(ComponentSettings, FieldMask, CallSettings)
            // Additional: UpdateComponentSettingsAsync(ComponentSettings, FieldMask, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ComponentSettings componentSettings = new ComponentSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ComponentSettings response = await securityCenterSettingsServiceClient.UpdateComponentSettingsAsync(componentSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ResetComponentSettings</summary>
        public void ResetComponentSettingsRequestObject()
        {
            // Snippet: ResetComponentSettings(ResetComponentSettingsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            ResetComponentSettingsRequest request = new ResetComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                Etag = "",
            };
            // Make the request
            securityCenterSettingsServiceClient.ResetComponentSettings(request);
            // End snippet
        }

        /// <summary>Snippet for ResetComponentSettingsAsync</summary>
        public async Task ResetComponentSettingsRequestObjectAsync()
        {
            // Snippet: ResetComponentSettingsAsync(ResetComponentSettingsRequest, CallSettings)
            // Additional: ResetComponentSettingsAsync(ResetComponentSettingsRequest, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResetComponentSettingsRequest request = new ResetComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                Etag = "",
            };
            // Make the request
            await securityCenterSettingsServiceClient.ResetComponentSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveComponentSettings</summary>
        public void CalculateEffectiveComponentSettingsRequestObject()
        {
            // Snippet: CalculateEffectiveComponentSettings(CalculateEffectiveComponentSettingsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            CalculateEffectiveComponentSettingsRequest request = new CalculateEffectiveComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            // Make the request
            ComponentSettings response = securityCenterSettingsServiceClient.CalculateEffectiveComponentSettings(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveComponentSettingsAsync</summary>
        public async Task CalculateEffectiveComponentSettingsRequestObjectAsync()
        {
            // Snippet: CalculateEffectiveComponentSettingsAsync(CalculateEffectiveComponentSettingsRequest, CallSettings)
            // Additional: CalculateEffectiveComponentSettingsAsync(CalculateEffectiveComponentSettingsRequest, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CalculateEffectiveComponentSettingsRequest request = new CalculateEffectiveComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            // Make the request
            ComponentSettings response = await securityCenterSettingsServiceClient.CalculateEffectiveComponentSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveComponentSettings</summary>
        public void CalculateEffectiveComponentSettings()
        {
            // Snippet: CalculateEffectiveComponentSettings(string, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/components/[COMPONENT]/settings";
            // Make the request
            ComponentSettings response = securityCenterSettingsServiceClient.CalculateEffectiveComponentSettings(name);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveComponentSettingsAsync</summary>
        public async Task CalculateEffectiveComponentSettingsAsync()
        {
            // Snippet: CalculateEffectiveComponentSettingsAsync(string, CallSettings)
            // Additional: CalculateEffectiveComponentSettingsAsync(string, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/components/[COMPONENT]/settings";
            // Make the request
            ComponentSettings response = await securityCenterSettingsServiceClient.CalculateEffectiveComponentSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveComponentSettings</summary>
        public void CalculateEffectiveComponentSettingsResourceNames()
        {
            // Snippet: CalculateEffectiveComponentSettings(ComponentSettingsName, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            ComponentSettingsName name = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]");
            // Make the request
            ComponentSettings response = securityCenterSettingsServiceClient.CalculateEffectiveComponentSettings(name);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveComponentSettingsAsync</summary>
        public async Task CalculateEffectiveComponentSettingsResourceNamesAsync()
        {
            // Snippet: CalculateEffectiveComponentSettingsAsync(ComponentSettingsName, CallSettings)
            // Additional: CalculateEffectiveComponentSettingsAsync(ComponentSettingsName, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ComponentSettingsName name = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]");
            // Make the request
            ComponentSettings response = await securityCenterSettingsServiceClient.CalculateEffectiveComponentSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDetectors</summary>
        public void ListDetectorsRequestObject()
        {
            // Snippet: ListDetectors(ListDetectorsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            ListDetectorsRequest request = new ListDetectorsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDetectorsResponse, Detector> response = securityCenterSettingsServiceClient.ListDetectors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Detector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDetectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Detector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Detector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Detector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDetectorsAsync</summary>
        public async Task ListDetectorsRequestObjectAsync()
        {
            // Snippet: ListDetectorsAsync(ListDetectorsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDetectorsRequest request = new ListDetectorsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDetectorsResponse, Detector> response = securityCenterSettingsServiceClient.ListDetectorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Detector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDetectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Detector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Detector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Detector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDetectors</summary>
        public void ListDetectors()
        {
            // Snippet: ListDetectors(string, string, int?, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListDetectorsResponse, Detector> response = securityCenterSettingsServiceClient.ListDetectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Detector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDetectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Detector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Detector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Detector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDetectorsAsync</summary>
        public async Task ListDetectorsAsync()
        {
            // Snippet: ListDetectorsAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListDetectorsResponse, Detector> response = securityCenterSettingsServiceClient.ListDetectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Detector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDetectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Detector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Detector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Detector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDetectors</summary>
        public void ListDetectorsResourceNames()
        {
            // Snippet: ListDetectors(OrganizationName, string, int?, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListDetectorsResponse, Detector> response = securityCenterSettingsServiceClient.ListDetectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Detector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDetectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Detector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Detector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Detector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDetectorsAsync</summary>
        public async Task ListDetectorsResourceNamesAsync()
        {
            // Snippet: ListDetectorsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListDetectorsResponse, Detector> response = securityCenterSettingsServiceClient.ListDetectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Detector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDetectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Detector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Detector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Detector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComponents</summary>
        public void ListComponentsRequestObject()
        {
            // Snippet: ListComponents(ListComponentsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            ListComponentsRequest request = new ListComponentsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<ListComponentsResponse, string> response = securityCenterSettingsServiceClient.ListComponents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListComponentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComponentsAsync</summary>
        public async Task ListComponentsRequestObjectAsync()
        {
            // Snippet: ListComponentsAsync(ListComponentsRequest, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListComponentsRequest request = new ListComponentsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListComponentsResponse, string> response = securityCenterSettingsServiceClient.ListComponentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListComponentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComponents</summary>
        public void ListComponents()
        {
            // Snippet: ListComponents(string, string, int?, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListComponentsResponse, string> response = securityCenterSettingsServiceClient.ListComponents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListComponentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComponentsAsync</summary>
        public async Task ListComponentsAsync()
        {
            // Snippet: ListComponentsAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListComponentsResponse, string> response = securityCenterSettingsServiceClient.ListComponentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListComponentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComponents</summary>
        public void ListComponentsResourceNames()
        {
            // Snippet: ListComponents(OrganizationName, string, int?, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = SecurityCenterSettingsServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListComponentsResponse, string> response = securityCenterSettingsServiceClient.ListComponents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListComponentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComponentsAsync</summary>
        public async Task ListComponentsResourceNamesAsync()
        {
            // Snippet: ListComponentsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListComponentsResponse, string> response = securityCenterSettingsServiceClient.ListComponentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListComponentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}

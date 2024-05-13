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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    // [START compute_v1_generated_RegionBackendServices_Patch_async_flattened]
    using Google.Cloud.Compute.V1;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    public sealed partial class GeneratedRegionBackendServicesClientSnippets
    {
        /// <summary>Snippet for PatchAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task PatchAsync()
        {
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendService = "";
            BackendService backendServiceResource = new BackendService
            {
                Id = 0UL,
                Iap = new BackendServiceIAP
                {
                    Enabled = false,
                    Oauth2ClientSecret = "",
                    Oauth2ClientSecretSha256 = "",
                    Oauth2ClientId = "",
                },
                ConsistentHash = new ConsistentHashLoadBalancerSettings
                {
                    HttpCookie = new ConsistentHashLoadBalancerSettingsHttpCookie
                    {
                        Ttl = new Duration
                        {
                            Nanos = 0,
                            Seconds = 0L,
                        },
                        Name = "",
                        Path = "",
                    },
                    MinimumRingSize = 0L,
                    HttpHeaderName = "",
                },
                Kind = "",
                Name = "",
                Port = 0,
                Metadatas = { { "", "" }, },
                CustomRequestHeaders = { "", },
                CreationTimestamp = "",
                EdgeSecurityPolicy = "",
                PortName = "",
                MaxStreamDuration = new Duration
                {
                    Nanos = 0,
                    Seconds = 0L,
                },
                TimeoutSec = 0,
                Protocol = "",
                ServiceLbPolicy = "",
                CompressionMode = "",
                FailoverPolicy = new BackendServiceFailoverPolicy
                {
                    DropTrafficIfUnhealthy = false,
                    DisableConnectionDrainOnFailover = false,
                    FailoverRatio = 0F,
                },
                LocalityLbPolicy = "",
                ServiceBindings = { "", },
                Region = "",
                LocalityLbPolicies =
                {
                    new BackendServiceLocalityLoadBalancingPolicyConfig
                    {
                        CustomPolicy = new BackendServiceLocalityLoadBalancingPolicyConfigCustomPolicy { Data = "", Name = "", },
                        Policy = new BackendServiceLocalityLoadBalancingPolicyConfigPolicy { Name = "", },
                    },
                },
                ConnectionTrackingPolicy = new BackendServiceConnectionTrackingPolicy
                {
                    EnableStrongAffinity = false,
                    IdleTimeoutSec = 0,
                    TrackingMode = "",
                    ConnectionPersistenceOnUnhealthyBackends = "",
                },
                SecurityPolicy = "",
                CdnPolicy = new BackendServiceCdnPolicy
                {
                    CacheMode = "",
                    ClientTtl = 0,
                    DefaultTtl = 0,
                    NegativeCachingPolicy =
                    {
                        new BackendServiceCdnPolicyNegativeCachingPolicy { Ttl = 0, Code = 0, },
                    },
                    CacheKeyPolicy = new CacheKeyPolicy
                    {
                        IncludeHttpHeaders = { "", },
                        QueryStringWhitelist = { "", },
                        IncludeNamedCookies = { "", },
                        IncludeProtocol = false,
                        QueryStringBlacklist = { "", },
                        IncludeQueryString = false,
                        IncludeHost = false,
                    },
                    ServeWhileStale = 0,
                    SignedUrlCacheMaxAgeSec = 0L,
                    MaxTtl = 0,
                    NegativeCaching = false,
                    SignedUrlKeyNames = { "", },
                    BypassCacheOnRequestHeaders =
                    {
                        new BackendServiceCdnPolicyBypassCacheOnRequestHeader { HeaderName = "", },
                    },
                    RequestCoalescing = false,
                },
                Network = "",
                Fingerprint = "",
                EnableCDN = false,
                LogConfig = new BackendServiceLogConfig
                {
                    OptionalMode = "",
                    SampleRate = 0F,
                    Enable = false,
                    OptionalFields = { "", },
                },
                OutlierDetection = new OutlierDetection
                {
                    MaxEjectionPercent = 0,
                    Interval = new Duration
                    {
                        Nanos = 0,
                        Seconds = 0L,
                    },
                    BaseEjectionTime = new Duration
                    {
                        Nanos = 0,
                        Seconds = 0L,
                    },
                    SuccessRateStdevFactor = 0,
                    EnforcingSuccessRate = 0,
                    EnforcingConsecutiveErrors = 0,
                    SuccessRateRequestVolume = 0,
                    ConsecutiveErrors = 0,
                    EnforcingConsecutiveGatewayFailure = 0,
                    ConsecutiveGatewayFailure = 0,
                    SuccessRateMinimumHosts = 0,
                },
                LoadBalancingScheme = "",
                AffinityCookieTtlSec = 0,
                CustomResponseHeaders = { "", },
                UsedBy =
                {
                    new BackendServiceUsedBy { Reference = "", },
                },
                CircuitBreakers = new CircuitBreakers
                {
                    MaxRequests = 0,
                    MaxRetries = 0,
                    MaxConnections = 0,
                    MaxRequestsPerConnection = 0,
                    MaxPendingRequests = 0,
                },
                Description = "",
                HealthChecks = { "", },
                Subsetting = new Subsetting { Policy = "", },
                SelfLink = "",
                ConnectionDraining = new ConnectionDraining
                {
                    DrainingTimeoutSec = 0,
                },
                SessionAffinity = "",
                SecuritySettings = new SecuritySettings
                {
                    SubjectAltNames = { "", },
                    AwsV4Authentication = new AWSV4Signature
                    {
                        AccessKeyVersion = "",
                        OriginRegion = "",
                        AccessKeyId = "",
                        AccessKey = "",
                    },
                    ClientTlsPolicy = "",
                },
                Backends =
                {
                    new Backend
                    {
                        MaxRatePerInstance = 0F,
                        Group = "",
                        MaxConnectionsPerInstance = 0,
                        MaxConnections = 0,
                        MaxRatePerEndpoint = 0F,
                        Failover = false,
                        MaxUtilization = 0F,
                        Preference = "",
                        MaxConnectionsPerEndpoint = 0,
                        CapacityScaler = 0F,
                        MaxRate = 0,
                        Description = "",
                        BalancingMode = "",
                    },
                },
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendServicesClient.PatchAsync(project, region, backendService, backendServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendServicesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END compute_v1_generated_RegionBackendServices_Patch_async_flattened]
}

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
    // [START compute_v1_generated_UrlMaps_Validate_async]
    using Google.Cloud.Compute.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedUrlMapsClientSnippets
    {
        /// <summary>Snippet for ValidateAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ValidateRequestObjectAsync()
        {
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            ValidateUrlMapRequest request = new ValidateUrlMapRequest
            {
                Project = "",
                UrlMap = "",
                UrlMapsValidateRequestResource = new UrlMapsValidateRequest
                {
                    LoadBalancingSchemes = { "", },
                    Resource = new UrlMap
                    {
                        Id = 0UL,
                        Kind = "",
                        Name = "",
                        CreationTimestamp = "",
                        Tests =
                        {
                            new UrlMapTest
                            {
                                Host = "",
                                Path = "",
                                ExpectedRedirectResponseCode = 0,
                                Headers =
                                {
                                    new UrlMapTestHeader { Name = "", Value = "", },
                                },
                                Service = "",
                                Description = "",
                                ExpectedOutputUrl = "",
                            },
                        },
                        Region = "",
                        Fingerprint = "",
                        PathMatchers =
                        {
                            new PathMatcher
                            {
                                Name = "",
                                PathRules =
                                {
                                    new PathRule
                                    {
                                        Paths = { "", },
                                        Service = "",
                                        UrlRedirect = new HttpRedirectAction
                                        {
                                            StripQuery = false,
                                            HostRedirect = "",
                                            HttpsRedirect = false,
                                            PathRedirect = "",
                                            RedirectResponseCode = "",
                                            PrefixRedirect = "",
                                        },
                                        RouteAction = new HttpRouteAction
                                        {
                                            RetryPolicy = new HttpRetryPolicy
                                            {
                                                RetryConditions = { "", },
                                                NumRetries = 0U,
                                                PerTryTimeout = new Duration
                                                {
                                                    Nanos = 0,
                                                    Seconds = 0L,
                                                },
                                            },
                                            MaxStreamDuration = new Duration
                                            {
                                                Nanos = 0,
                                                Seconds = 0L,
                                            },
                                            RequestMirrorPolicy = new RequestMirrorPolicy { BackendService = "", },
                                            UrlRewrite = new UrlRewrite
                                            {
                                                PathPrefixRewrite = "",
                                                HostRewrite = "",
                                                PathTemplateRewrite = "",
                                            },
                                            Timeout = new Duration
                                            {
                                                Nanos = 0,
                                                Seconds = 0L,
                                            },
                                            WeightedBackendServices =
                                            {
                                                new WeightedBackendService
                                                {
                                                    Weight = 0U,
                                                    BackendService = "",
                                                    HeaderAction = new HttpHeaderAction
                                                    {
                                                        ResponseHeadersToAdd =
                                                        {
                                                            new HttpHeaderOption
                                                            {
                                                                Replace = false,
                                                                HeaderName = "",
                                                                HeaderValue = "",
                                                            },
                                                        },
                                                        RequestHeadersToAdd =
                                                        {
                                                            new HttpHeaderOption
                                                            {
                                                                Replace = false,
                                                                HeaderName = "",
                                                                HeaderValue = "",
                                                            },
                                                        },
                                                        ResponseHeadersToRemove = { "", },
                                                        RequestHeadersToRemove = { "", },
                                                    },
                                                },
                                            },
                                            CorsPolicy = new CorsPolicy
                                            {
                                                AllowHeaders = { "", },
                                                AllowOrigins = { "", },
                                                AllowMethods = { "", },
                                                AllowOriginRegexes = { "", },
                                                ExposeHeaders = { "", },
                                                Disabled = false,
                                                MaxAge = 0,
                                                AllowCredentials = false,
                                            },
                                            FaultInjectionPolicy = new HttpFaultInjection
                                            {
                                                Abort = new HttpFaultAbort
                                                {
                                                    Percentage = 0,
                                                    HttpStatus = 0U,
                                                },
                                                Delay = new HttpFaultDelay
                                                {
                                                    Percentage = 0,
                                                    FixedDelay = new Duration
                                                    {
                                                        Nanos = 0,
                                                        Seconds = 0L,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                HeaderAction = new HttpHeaderAction
                                {
                                    ResponseHeadersToAdd =
                                    {
                                        new HttpHeaderOption
                                        {
                                            Replace = false,
                                            HeaderName = "",
                                            HeaderValue = "",
                                        },
                                    },
                                    RequestHeadersToAdd =
                                    {
                                        new HttpHeaderOption
                                        {
                                            Replace = false,
                                            HeaderName = "",
                                            HeaderValue = "",
                                        },
                                    },
                                    ResponseHeadersToRemove = { "", },
                                    RequestHeadersToRemove = { "", },
                                },
                                DefaultUrlRedirect = new HttpRedirectAction
                                {
                                    StripQuery = false,
                                    HostRedirect = "",
                                    HttpsRedirect = false,
                                    PathRedirect = "",
                                    RedirectResponseCode = "",
                                    PrefixRedirect = "",
                                },
                                DefaultService = "",
                                RouteRules =
                                {
                                    new HttpRouteRule
                                    {
                                        HeaderAction = new HttpHeaderAction
                                        {
                                            ResponseHeadersToAdd =
                                            {
                                                new HttpHeaderOption
                                                {
                                                    Replace = false,
                                                    HeaderName = "",
                                                    HeaderValue = "",
                                                },
                                            },
                                            RequestHeadersToAdd =
                                            {
                                                new HttpHeaderOption
                                                {
                                                    Replace = false,
                                                    HeaderName = "",
                                                    HeaderValue = "",
                                                },
                                            },
                                            ResponseHeadersToRemove = { "", },
                                            RequestHeadersToRemove = { "", },
                                        },
                                        Service = "",
                                        MatchRules =
                                        {
                                            new HttpRouteRuleMatch
                                            {
                                                RegexMatch = "",
                                                FullPathMatch = "",
                                                PrefixMatch = "",
                                                QueryParameterMatches =
                                                {
                                                    new HttpQueryParameterMatch
                                                    {
                                                        Name = "",
                                                        PresentMatch = false,
                                                        RegexMatch = "",
                                                        ExactMatch = "",
                                                    },
                                                },
                                                PathTemplateMatch = "",
                                                HeaderMatches =
                                                {
                                                    new HttpHeaderMatch
                                                    {
                                                        PresentMatch = false,
                                                        RangeMatch = new Int64RangeMatch
                                                        {
                                                            RangeStart = 0L,
                                                            RangeEnd = 0L,
                                                        },
                                                        RegexMatch = "",
                                                        HeaderName = "",
                                                        PrefixMatch = "",
                                                        SuffixMatch = "",
                                                        ExactMatch = "",
                                                        InvertMatch = false,
                                                    },
                                                },
                                                IgnoreCase = false,
                                                MetadataFilters =
                                                {
                                                    new MetadataFilter
                                                    {
                                                        FilterMatchCriteria = "",
                                                        FilterLabels =
                                                        {
                                                            new MetadataFilterLabelMatch { Name = "", Value = "", },
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                        UrlRedirect = new HttpRedirectAction
                                        {
                                            StripQuery = false,
                                            HostRedirect = "",
                                            HttpsRedirect = false,
                                            PathRedirect = "",
                                            RedirectResponseCode = "",
                                            PrefixRedirect = "",
                                        },
                                        Description = "",
                                        RouteAction = new HttpRouteAction
                                        {
                                            RetryPolicy = new HttpRetryPolicy
                                            {
                                                RetryConditions = { "", },
                                                NumRetries = 0U,
                                                PerTryTimeout = new Duration
                                                {
                                                    Nanos = 0,
                                                    Seconds = 0L,
                                                },
                                            },
                                            MaxStreamDuration = new Duration
                                            {
                                                Nanos = 0,
                                                Seconds = 0L,
                                            },
                                            RequestMirrorPolicy = new RequestMirrorPolicy { BackendService = "", },
                                            UrlRewrite = new UrlRewrite
                                            {
                                                PathPrefixRewrite = "",
                                                HostRewrite = "",
                                                PathTemplateRewrite = "",
                                            },
                                            Timeout = new Duration
                                            {
                                                Nanos = 0,
                                                Seconds = 0L,
                                            },
                                            WeightedBackendServices =
                                            {
                                                new WeightedBackendService
                                                {
                                                    Weight = 0U,
                                                    BackendService = "",
                                                    HeaderAction = new HttpHeaderAction
                                                    {
                                                        ResponseHeadersToAdd =
                                                        {
                                                            new HttpHeaderOption
                                                            {
                                                                Replace = false,
                                                                HeaderName = "",
                                                                HeaderValue = "",
                                                            },
                                                        },
                                                        RequestHeadersToAdd =
                                                        {
                                                            new HttpHeaderOption
                                                            {
                                                                Replace = false,
                                                                HeaderName = "",
                                                                HeaderValue = "",
                                                            },
                                                        },
                                                        ResponseHeadersToRemove = { "", },
                                                        RequestHeadersToRemove = { "", },
                                                    },
                                                },
                                            },
                                            CorsPolicy = new CorsPolicy
                                            {
                                                AllowHeaders = { "", },
                                                AllowOrigins = { "", },
                                                AllowMethods = { "", },
                                                AllowOriginRegexes = { "", },
                                                ExposeHeaders = { "", },
                                                Disabled = false,
                                                MaxAge = 0,
                                                AllowCredentials = false,
                                            },
                                            FaultInjectionPolicy = new HttpFaultInjection
                                            {
                                                Abort = new HttpFaultAbort
                                                {
                                                    Percentage = 0,
                                                    HttpStatus = 0U,
                                                },
                                                Delay = new HttpFaultDelay
                                                {
                                                    Percentage = 0,
                                                    FixedDelay = new Duration
                                                    {
                                                        Nanos = 0,
                                                        Seconds = 0L,
                                                    },
                                                },
                                            },
                                        },
                                        Priority = 0,
                                    },
                                },
                                DefaultRouteAction = new HttpRouteAction
                                {
                                    RetryPolicy = new HttpRetryPolicy
                                    {
                                        RetryConditions = { "", },
                                        NumRetries = 0U,
                                        PerTryTimeout = new Duration
                                        {
                                            Nanos = 0,
                                            Seconds = 0L,
                                        },
                                    },
                                    MaxStreamDuration = new Duration
                                    {
                                        Nanos = 0,
                                        Seconds = 0L,
                                    },
                                    RequestMirrorPolicy = new RequestMirrorPolicy { BackendService = "", },
                                    UrlRewrite = new UrlRewrite
                                    {
                                        PathPrefixRewrite = "",
                                        HostRewrite = "",
                                        PathTemplateRewrite = "",
                                    },
                                    Timeout = new Duration
                                    {
                                        Nanos = 0,
                                        Seconds = 0L,
                                    },
                                    WeightedBackendServices =
                                    {
                                        new WeightedBackendService
                                        {
                                            Weight = 0U,
                                            BackendService = "",
                                            HeaderAction = new HttpHeaderAction
                                            {
                                                ResponseHeadersToAdd =
                                                {
                                                    new HttpHeaderOption
                                                    {
                                                        Replace = false,
                                                        HeaderName = "",
                                                        HeaderValue = "",
                                                    },
                                                },
                                                RequestHeadersToAdd =
                                                {
                                                    new HttpHeaderOption
                                                    {
                                                        Replace = false,
                                                        HeaderName = "",
                                                        HeaderValue = "",
                                                    },
                                                },
                                                ResponseHeadersToRemove = { "", },
                                                RequestHeadersToRemove = { "", },
                                            },
                                        },
                                    },
                                    CorsPolicy = new CorsPolicy
                                    {
                                        AllowHeaders = { "", },
                                        AllowOrigins = { "", },
                                        AllowMethods = { "", },
                                        AllowOriginRegexes = { "", },
                                        ExposeHeaders = { "", },
                                        Disabled = false,
                                        MaxAge = 0,
                                        AllowCredentials = false,
                                    },
                                    FaultInjectionPolicy = new HttpFaultInjection
                                    {
                                        Abort = new HttpFaultAbort
                                        {
                                            Percentage = 0,
                                            HttpStatus = 0U,
                                        },
                                        Delay = new HttpFaultDelay
                                        {
                                            Percentage = 0,
                                            FixedDelay = new Duration
                                            {
                                                Nanos = 0,
                                                Seconds = 0L,
                                            },
                                        },
                                    },
                                },
                                Description = "",
                            },
                        },
                        HostRules =
                        {
                            new HostRule
                            {
                                Hosts = { "", },
                                PathMatcher = "",
                                Description = "",
                            },
                        },
                        HeaderAction = new HttpHeaderAction
                        {
                            ResponseHeadersToAdd =
                            {
                                new HttpHeaderOption
                                {
                                    Replace = false,
                                    HeaderName = "",
                                    HeaderValue = "",
                                },
                            },
                            RequestHeadersToAdd =
                            {
                                new HttpHeaderOption
                                {
                                    Replace = false,
                                    HeaderName = "",
                                    HeaderValue = "",
                                },
                            },
                            ResponseHeadersToRemove = { "", },
                            RequestHeadersToRemove = { "", },
                        },
                        DefaultUrlRedirect = new HttpRedirectAction
                        {
                            StripQuery = false,
                            HostRedirect = "",
                            HttpsRedirect = false,
                            PathRedirect = "",
                            RedirectResponseCode = "",
                            PrefixRedirect = "",
                        },
                        DefaultService = "",
                        DefaultRouteAction = new HttpRouteAction
                        {
                            RetryPolicy = new HttpRetryPolicy
                            {
                                RetryConditions = { "", },
                                NumRetries = 0U,
                                PerTryTimeout = new Duration
                                {
                                    Nanos = 0,
                                    Seconds = 0L,
                                },
                            },
                            MaxStreamDuration = new Duration
                            {
                                Nanos = 0,
                                Seconds = 0L,
                            },
                            RequestMirrorPolicy = new RequestMirrorPolicy { BackendService = "", },
                            UrlRewrite = new UrlRewrite
                            {
                                PathPrefixRewrite = "",
                                HostRewrite = "",
                                PathTemplateRewrite = "",
                            },
                            Timeout = new Duration
                            {
                                Nanos = 0,
                                Seconds = 0L,
                            },
                            WeightedBackendServices =
                            {
                                new WeightedBackendService
                                {
                                    Weight = 0U,
                                    BackendService = "",
                                    HeaderAction = new HttpHeaderAction
                                    {
                                        ResponseHeadersToAdd =
                                        {
                                            new HttpHeaderOption
                                            {
                                                Replace = false,
                                                HeaderName = "",
                                                HeaderValue = "",
                                            },
                                        },
                                        RequestHeadersToAdd =
                                        {
                                            new HttpHeaderOption
                                            {
                                                Replace = false,
                                                HeaderName = "",
                                                HeaderValue = "",
                                            },
                                        },
                                        ResponseHeadersToRemove = { "", },
                                        RequestHeadersToRemove = { "", },
                                    },
                                },
                            },
                            CorsPolicy = new CorsPolicy
                            {
                                AllowHeaders = { "", },
                                AllowOrigins = { "", },
                                AllowMethods = { "", },
                                AllowOriginRegexes = { "", },
                                ExposeHeaders = { "", },
                                Disabled = false,
                                MaxAge = 0,
                                AllowCredentials = false,
                            },
                            FaultInjectionPolicy = new HttpFaultInjection
                            {
                                Abort = new HttpFaultAbort
                                {
                                    Percentage = 0,
                                    HttpStatus = 0U,
                                },
                                Delay = new HttpFaultDelay
                                {
                                    Percentage = 0,
                                    FixedDelay = new Duration
                                    {
                                        Nanos = 0,
                                        Seconds = 0L,
                                    },
                                },
                            },
                        },
                        Description = "",
                        SelfLink = "",
                    },
                },
            };
            // Make the request
            UrlMapsValidateResponse response = await urlMapsClient.ValidateAsync(request);
        }
    }
    // [END compute_v1_generated_UrlMaps_Validate_async]
}

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
    // [START compute_v1_generated_RegionSecurityPolicies_Patch_sync_flattened]
    using Google.Cloud.Compute.V1;
    using lro = Google.LongRunning;

    public sealed partial class GeneratedRegionSecurityPoliciesClientSnippets
    {
        /// <summary>Snippet for Patch</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void Patch()
        {
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            SecurityPolicy securityPolicyResource = new SecurityPolicy
            {
                Id = 0UL,
                Kind = "",
                Name = "",
                Type = "",
                UserDefinedFields =
                {
                    new SecurityPolicyUserDefinedField
                    {
                        Base = "",
                        Mask = "",
                        Name = "",
                        Size = 0,
                        Offset = 0,
                    },
                },
                CreationTimestamp = "",
                DdosProtectionConfig = new SecurityPolicyDdosProtectionConfig { DdosProtection = "", },
                Rules =
                {
                    new SecurityPolicyRule
                    {
                        Kind = "",
                        RateLimitOptions = new SecurityPolicyRuleRateLimitOptions
                        {
                            EnforceOnKeyConfigs =
                            {
                                new SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig
                                {
                                    EnforceOnKeyName = "",
                                    EnforceOnKeyType = "",
                                },
                            },
                            BanDurationSec = 0,
                            EnforceOnKeyName = "",
                            ExceedAction = "",
                            RateLimitThreshold = new SecurityPolicyRuleRateLimitOptionsThreshold
                            {
                                IntervalSec = 0,
                                Count = 0,
                            },
                            EnforceOnKey = "",
                            ExceedRedirectOptions = new SecurityPolicyRuleRedirectOptions { Type = "", Target = "", },
                            BanThreshold = new SecurityPolicyRuleRateLimitOptionsThreshold
                            {
                                IntervalSec = 0,
                                Count = 0,
                            },
                            ConformAction = "",
                        },
                        Match = new SecurityPolicyRuleMatcher
                        {
                            Expr = new Expr
                            {
                                Title = "",
                                Location = "",
                                Expression = "",
                                Description = "",
                            },
                            Config = new SecurityPolicyRuleMatcherConfig { SrcIpRanges = { "", }, },
                            VersionedExpr = "",
                            ExprOptions = new SecurityPolicyRuleMatcherExprOptions
                            {
                                RecaptchaOptions = new SecurityPolicyRuleMatcherExprOptionsRecaptchaOptions
                                {
                                    ActionTokenSiteKeys = { "", },
                                    SessionTokenSiteKeys = { "", },
                                },
                            },
                        },
                        PreconfiguredWafConfig = new SecurityPolicyRulePreconfiguredWafConfig
                        {
                            Exclusions =
                            {
                                new SecurityPolicyRulePreconfiguredWafConfigExclusion
                                {
                                    RequestHeadersToExclude =
                                    {
                                        new SecurityPolicyRulePreconfiguredWafConfigExclusionFieldParams { Op = "", Val = "", },
                                    },
                                    RequestUrisToExclude =
                                    {
                                        new SecurityPolicyRulePreconfiguredWafConfigExclusionFieldParams { Op = "", Val = "", },
                                    },
                                    RequestCookiesToExclude =
                                    {
                                        new SecurityPolicyRulePreconfiguredWafConfigExclusionFieldParams { Op = "", Val = "", },
                                    },
                                    RequestQueryParamsToExclude =
                                    {
                                        new SecurityPolicyRulePreconfiguredWafConfigExclusionFieldParams { Op = "", Val = "", },
                                    },
                                    TargetRuleIds = { "", },
                                    TargetRuleSet = "",
                                },
                            },
                        },
                        RedirectOptions = new SecurityPolicyRuleRedirectOptions { Type = "", Target = "", },
                        Action = "",
                        Preview = false,
                        HeaderAction = new SecurityPolicyRuleHttpHeaderAction
                        {
                            RequestHeadersToAdds =
                            {
                                new SecurityPolicyRuleHttpHeaderActionHttpHeaderOption
                                {
                                    HeaderName = "",
                                    HeaderValue = "",
                                },
                            },
                        },
                        Description = "",
                        Priority = 0,
                        NetworkMatch = new SecurityPolicyRuleNetworkMatcher
                        {
                            UserDefinedFields =
                            {
                                new SecurityPolicyRuleNetworkMatcherUserDefinedFieldMatch
                                {
                                    Name = "",
                                    Values = { "", },
                                },
                            },
                            SrcRegionCodes = { "", },
                            SrcAsns = { 0U, },
                            IpProtocols = { "", },
                            DestIpRanges = { "", },
                            DestPorts = { "", },
                            SrcIpRanges = { "", },
                            SrcPorts = { "", },
                        },
                    },
                },
                Region = "",
                AdaptiveProtectionConfig = new SecurityPolicyAdaptiveProtectionConfig
                {
                    Layer7DdosDefenseConfig = new SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfig
                    {
                        ThresholdConfigs =
                        {
                            new SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfig
                            {
                                Name = "",
                                AutoDeployExpirationSec = 0,
                                AutoDeployConfidenceThreshold = 0F,
                                AutoDeployImpactedBaselineThreshold = 0F,
                                AutoDeployLoadThreshold = 0F,
                            },
                        },
                        Enable = false,
                        RuleVisibility = "",
                    },
                },
                LabelFingerprint = "",
                Fingerprint = "",
                Description = "",
                AdvancedOptionsConfig = new SecurityPolicyAdvancedOptionsConfig
                {
                    JsonCustomConfig = new SecurityPolicyAdvancedOptionsConfigJsonCustomConfig { ContentTypes = { "", }, },
                    LogLevel = "",
                    JsonParsing = "",
                    UserIpRequestHeaders = { "", },
                },
                SelfLink = "",
                Labels = { { "", "" }, },
                RecaptchaOptionsConfig = new SecurityPolicyRecaptchaOptionsConfig
                {
                    RedirectSiteKey = "",
                },
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.Patch(project, region, securityPolicy, securityPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END compute_v1_generated_RegionSecurityPolicies_Patch_sync_flattened]
}

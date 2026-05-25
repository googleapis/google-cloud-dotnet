// Copyright 2026 Google LLC
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
using gax = Google.Api.Gax;
using gcnv = Google.Cloud.NetworkSecurity.V1;
using sys = System;

namespace Google.Cloud.NetworkSecurity.V1
{
    /// <summary>Resource name for the <c>GatewaySecurityPolicyRule</c> resource.</summary>
    public sealed partial class GatewaySecurityPolicyRuleName : gax::IResourceName, sys::IEquatable<GatewaySecurityPolicyRuleName>
    {
        /// <summary>The possible contents of <see cref="GatewaySecurityPolicyRuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}</c>
            /// .
            /// </summary>
            ProjectLocationGatewaySecurityPolicyRule = 1,
        }

        private static gax::PathTemplate s_projectLocationGatewaySecurityPolicyRule = new gax::PathTemplate("projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}");

        /// <summary>
        /// Creates a <see cref="GatewaySecurityPolicyRuleName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GatewaySecurityPolicyRuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GatewaySecurityPolicyRuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GatewaySecurityPolicyRuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GatewaySecurityPolicyRuleName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewaySecurityPolicyId">
        /// The <c>GatewaySecurityPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="GatewaySecurityPolicyRuleName"/> constructed from the provided ids.
        /// </returns>
        public static GatewaySecurityPolicyRuleName FromProjectLocationGatewaySecurityPolicyRule(string projectId, string locationId, string gatewaySecurityPolicyId, string ruleId) =>
            new GatewaySecurityPolicyRuleName(ResourceNameType.ProjectLocationGatewaySecurityPolicyRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gatewaySecurityPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(gatewaySecurityPolicyId, nameof(gatewaySecurityPolicyId)), ruleId: gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GatewaySecurityPolicyRuleName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewaySecurityPolicyId">
        /// The <c>GatewaySecurityPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GatewaySecurityPolicyRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string gatewaySecurityPolicyId, string ruleId) =>
            FormatProjectLocationGatewaySecurityPolicyRule(projectId, locationId, gatewaySecurityPolicyId, ruleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GatewaySecurityPolicyRuleName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewaySecurityPolicyId">
        /// The <c>GatewaySecurityPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GatewaySecurityPolicyRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationGatewaySecurityPolicyRule(string projectId, string locationId, string gatewaySecurityPolicyId, string ruleId) =>
            s_projectLocationGatewaySecurityPolicyRule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(gatewaySecurityPolicyId, nameof(gatewaySecurityPolicyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GatewaySecurityPolicyRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gatewaySecurityPolicyRuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="GatewaySecurityPolicyRuleName"/> if successful.</returns>
        public static GatewaySecurityPolicyRuleName Parse(string gatewaySecurityPolicyRuleName) =>
            Parse(gatewaySecurityPolicyRuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GatewaySecurityPolicyRuleName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gatewaySecurityPolicyRuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GatewaySecurityPolicyRuleName"/> if successful.</returns>
        public static GatewaySecurityPolicyRuleName Parse(string gatewaySecurityPolicyRuleName, bool allowUnparsed) =>
            TryParse(gatewaySecurityPolicyRuleName, allowUnparsed, out GatewaySecurityPolicyRuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GatewaySecurityPolicyRuleName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gatewaySecurityPolicyRuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GatewaySecurityPolicyRuleName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gatewaySecurityPolicyRuleName, out GatewaySecurityPolicyRuleName result) =>
            TryParse(gatewaySecurityPolicyRuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GatewaySecurityPolicyRuleName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gatewaySecurityPolicyRuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GatewaySecurityPolicyRuleName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gatewaySecurityPolicyRuleName, bool allowUnparsed, out GatewaySecurityPolicyRuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicyRuleName, nameof(gatewaySecurityPolicyRuleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGatewaySecurityPolicyRule.TryParseName(gatewaySecurityPolicyRuleName, out resourceName))
            {
                result = FromProjectLocationGatewaySecurityPolicyRule(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(gatewaySecurityPolicyRuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GatewaySecurityPolicyRuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string gatewaySecurityPolicyId = null, string locationId = null, string projectId = null, string ruleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GatewaySecurityPolicyId = gatewaySecurityPolicyId;
            LocationId = locationId;
            ProjectId = projectId;
            RuleId = ruleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GatewaySecurityPolicyRuleName"/> class from the component parts of
        /// pattern
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewaySecurityPolicyId">
        /// The <c>GatewaySecurityPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        public GatewaySecurityPolicyRuleName(string projectId, string locationId, string gatewaySecurityPolicyId, string ruleId) : this(ResourceNameType.ProjectLocationGatewaySecurityPolicyRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gatewaySecurityPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(gatewaySecurityPolicyId, nameof(gatewaySecurityPolicyId)), ruleId: gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>GatewaySecurityPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string GatewaySecurityPolicyId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Rule</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RuleId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationGatewaySecurityPolicyRule: return s_projectLocationGatewaySecurityPolicyRule.Expand(ProjectId, LocationId, GatewaySecurityPolicyId, RuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GatewaySecurityPolicyRuleName);

        /// <inheritdoc/>
        public bool Equals(GatewaySecurityPolicyRuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GatewaySecurityPolicyRuleName a, GatewaySecurityPolicyRuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GatewaySecurityPolicyRuleName a, GatewaySecurityPolicyRuleName b) => !(a == b);
    }

    public partial class GatewaySecurityPolicyRule
    {
        /// <summary>
        /// <see cref="gcnv::GatewaySecurityPolicyRuleName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::GatewaySecurityPolicyRuleName GatewaySecurityPolicyRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GatewaySecurityPolicyRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGatewaySecurityPolicyRuleRequest
    {
        /// <summary>
        /// <see cref="GatewaySecurityPolicyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public GatewaySecurityPolicyName ParentAsGatewaySecurityPolicyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : GatewaySecurityPolicyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetGatewaySecurityPolicyRuleRequest
    {
        /// <summary>
        /// <see cref="gcnv::GatewaySecurityPolicyRuleName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::GatewaySecurityPolicyRuleName GatewaySecurityPolicyRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GatewaySecurityPolicyRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGatewaySecurityPolicyRulesRequest
    {
        /// <summary>
        /// <see cref="GatewaySecurityPolicyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public GatewaySecurityPolicyName ParentAsGatewaySecurityPolicyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : GatewaySecurityPolicyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGatewaySecurityPolicyRuleRequest
    {
        /// <summary>
        /// <see cref="gcnv::GatewaySecurityPolicyRuleName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::GatewaySecurityPolicyRuleName GatewaySecurityPolicyRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GatewaySecurityPolicyRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

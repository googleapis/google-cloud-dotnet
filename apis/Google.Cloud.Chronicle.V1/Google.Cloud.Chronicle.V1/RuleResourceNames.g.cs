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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gccv = Google.Cloud.Chronicle.V1;
using sys = System;

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Resource name for the <c>Rule</c> resource.</summary>
    public sealed partial class RuleName : gax::IResourceName, sys::IEquatable<RuleName>
    {
        /// <summary>The possible contents of <see cref="RuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}</c>.
            /// </summary>
            ProjectLocationInstanceRule = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceRule = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/rules/{rule}");

        /// <summary>Creates a <see cref="RuleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RuleName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RuleName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RuleName"/> constructed from the provided ids.</returns>
        public static RuleName FromProjectLocationInstanceRule(string projectId, string locationId, string instanceId, string ruleId) =>
            new RuleName(ResourceNameType.ProjectLocationInstanceRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), ruleId: gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string ruleId) =>
            FormatProjectLocationInstanceRule(projectId, locationId, instanceId, ruleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceRule(string projectId, string locationId, string instanceId, string ruleId) =>
            s_projectLocationInstanceRule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)));

        /// <summary>Parses the given resource name string into a new <see cref="RuleName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="ruleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RuleName"/> if successful.</returns>
        public static RuleName Parse(string ruleName) => Parse(ruleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RuleName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="ruleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RuleName"/> if successful.</returns>
        public static RuleName Parse(string ruleName, bool allowUnparsed) =>
            TryParse(ruleName, allowUnparsed, out RuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="RuleName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="ruleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string ruleName, out RuleName result) => TryParse(ruleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RuleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="ruleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string ruleName, bool allowUnparsed, out RuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(ruleName, nameof(ruleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceRule.TryParseName(ruleName, out resourceName))
            {
                result = FromProjectLocationInstanceRule(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(ruleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string projectId = null, string ruleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
            RuleId = ruleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RuleName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        public RuleName(string projectId, string locationId, string instanceId, string ruleId) : this(ResourceNameType.ProjectLocationInstanceRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), ruleId: gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstanceRule: return s_projectLocationInstanceRule.Expand(ProjectId, LocationId, InstanceId, RuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RuleName);

        /// <inheritdoc/>
        public bool Equals(RuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RuleName a, RuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RuleName a, RuleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>RuleDeployment</c> resource.</summary>
    public sealed partial class RuleDeploymentName : gax::IResourceName, sys::IEquatable<RuleDeploymentName>
    {
        /// <summary>The possible contents of <see cref="RuleDeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment</c>.
            /// </summary>
            ProjectLocationInstanceRule = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceRule = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment");

        /// <summary>Creates a <see cref="RuleDeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RuleDeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RuleDeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RuleDeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RuleDeploymentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RuleDeploymentName"/> constructed from the provided ids.</returns>
        public static RuleDeploymentName FromProjectLocationInstanceRule(string projectId, string locationId, string instanceId, string ruleId) =>
            new RuleDeploymentName(ResourceNameType.ProjectLocationInstanceRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), ruleId: gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RuleDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RuleDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string ruleId) =>
            FormatProjectLocationInstanceRule(projectId, locationId, instanceId, ruleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RuleDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RuleDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceRule(string projectId, string locationId, string instanceId, string ruleId) =>
            s_projectLocationInstanceRule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RuleDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="ruleDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RuleDeploymentName"/> if successful.</returns>
        public static RuleDeploymentName Parse(string ruleDeploymentName) => Parse(ruleDeploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RuleDeploymentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="ruleDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RuleDeploymentName"/> if successful.</returns>
        public static RuleDeploymentName Parse(string ruleDeploymentName, bool allowUnparsed) =>
            TryParse(ruleDeploymentName, allowUnparsed, out RuleDeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RuleDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="ruleDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RuleDeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string ruleDeploymentName, out RuleDeploymentName result) =>
            TryParse(ruleDeploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RuleDeploymentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="ruleDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RuleDeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string ruleDeploymentName, bool allowUnparsed, out RuleDeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(ruleDeploymentName, nameof(ruleDeploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceRule.TryParseName(ruleDeploymentName, out resourceName))
            {
                result = FromProjectLocationInstanceRule(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(ruleDeploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RuleDeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string projectId = null, string ruleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
            RuleId = ruleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RuleDeploymentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        public RuleDeploymentName(string projectId, string locationId, string instanceId, string ruleId) : this(ResourceNameType.ProjectLocationInstanceRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), ruleId: gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstanceRule: return s_projectLocationInstanceRule.Expand(ProjectId, LocationId, InstanceId, RuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RuleDeploymentName);

        /// <inheritdoc/>
        public bool Equals(RuleDeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RuleDeploymentName a, RuleDeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RuleDeploymentName a, RuleDeploymentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Retrohunt</c> resource.</summary>
    public sealed partial class RetrohuntName : gax::IResourceName, sys::IEquatable<RetrohuntName>
    {
        /// <summary>The possible contents of <see cref="RetrohuntName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}</c>.
            /// </summary>
            ProjectLocationInstanceRuleRetrohunt = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceRuleRetrohunt = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}");

        /// <summary>Creates a <see cref="RetrohuntName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RetrohuntName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RetrohuntName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RetrohuntName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RetrohuntName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="retrohuntId">The <c>Retrohunt</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RetrohuntName"/> constructed from the provided ids.</returns>
        public static RetrohuntName FromProjectLocationInstanceRuleRetrohunt(string projectId, string locationId, string instanceId, string ruleId, string retrohuntId) =>
            new RetrohuntName(ResourceNameType.ProjectLocationInstanceRuleRetrohunt, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), ruleId: gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)), retrohuntId: gax::GaxPreconditions.CheckNotNullOrEmpty(retrohuntId, nameof(retrohuntId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RetrohuntName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="retrohuntId">The <c>Retrohunt</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RetrohuntName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string ruleId, string retrohuntId) =>
            FormatProjectLocationInstanceRuleRetrohunt(projectId, locationId, instanceId, ruleId, retrohuntId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RetrohuntName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="retrohuntId">The <c>Retrohunt</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RetrohuntName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceRuleRetrohunt(string projectId, string locationId, string instanceId, string ruleId, string retrohuntId) =>
            s_projectLocationInstanceRuleRetrohunt.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)), gax::GaxPreconditions.CheckNotNullOrEmpty(retrohuntId, nameof(retrohuntId)));

        /// <summary>Parses the given resource name string into a new <see cref="RetrohuntName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="retrohuntName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RetrohuntName"/> if successful.</returns>
        public static RetrohuntName Parse(string retrohuntName) => Parse(retrohuntName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RetrohuntName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="retrohuntName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RetrohuntName"/> if successful.</returns>
        public static RetrohuntName Parse(string retrohuntName, bool allowUnparsed) =>
            TryParse(retrohuntName, allowUnparsed, out RetrohuntName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RetrohuntName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="retrohuntName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RetrohuntName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string retrohuntName, out RetrohuntName result) => TryParse(retrohuntName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RetrohuntName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="retrohuntName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RetrohuntName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string retrohuntName, bool allowUnparsed, out RetrohuntName result)
        {
            gax::GaxPreconditions.CheckNotNull(retrohuntName, nameof(retrohuntName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceRuleRetrohunt.TryParseName(retrohuntName, out resourceName))
            {
                result = FromProjectLocationInstanceRuleRetrohunt(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(retrohuntName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RetrohuntName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string projectId = null, string retrohuntId = null, string ruleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
            RetrohuntId = retrohuntId;
            RuleId = ruleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RetrohuntName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleId">The <c>Rule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="retrohuntId">The <c>Retrohunt</c> ID. Must not be <c>null</c> or empty.</param>
        public RetrohuntName(string projectId, string locationId, string instanceId, string ruleId, string retrohuntId) : this(ResourceNameType.ProjectLocationInstanceRuleRetrohunt, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), ruleId: gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)), retrohuntId: gax::GaxPreconditions.CheckNotNullOrEmpty(retrohuntId, nameof(retrohuntId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Retrohunt</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RetrohuntId { get; }

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
                case ResourceNameType.ProjectLocationInstanceRuleRetrohunt: return s_projectLocationInstanceRuleRetrohunt.Expand(ProjectId, LocationId, InstanceId, RuleId, RetrohuntId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RetrohuntName);

        /// <inheritdoc/>
        public bool Equals(RetrohuntName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RetrohuntName a, RetrohuntName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RetrohuntName a, RetrohuntName b) => !(a == b);
    }

    public partial class Rule
    {
        /// <summary>
        /// <see cref="gccv::RuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RuleName RuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ReferenceListName"/>-typed view over the <see cref="ReferenceLists"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ReferenceListName> ReferenceListsAsReferenceListNames
        {
            get => new gax::ResourceNameList<ReferenceListName>(ReferenceLists, s => string.IsNullOrEmpty(s) ? null : ReferenceListName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="DataAccessScopeName"/>-typed view over the <see cref="Scope"/> resource name property.
        /// </summary>
        public DataAccessScopeName ScopeAsDataAccessScopeName
        {
            get => string.IsNullOrEmpty(Scope) ? null : DataAccessScopeName.Parse(Scope, allowUnparsed: true);
            set => Scope = value?.ToString() ?? "";
        }
    }

    public partial class RuleDeployment
    {
        /// <summary>
        /// <see cref="gccv::RuleDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RuleDeploymentName RuleDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RuleDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="ProducerRules"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<InstanceName> ProducerRulesAsInstanceNames
        {
            get => new gax::ResourceNameList<InstanceName>(ProducerRules, s => string.IsNullOrEmpty(s) ? null : InstanceName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="ConsumerRules"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<InstanceName> ConsumerRulesAsInstanceNames
        {
            get => new gax::ResourceNameList<InstanceName>(ConsumerRules, s => string.IsNullOrEmpty(s) ? null : InstanceName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class Retrohunt
    {
        /// <summary>
        /// <see cref="gccv::RetrohuntName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RetrohuntName RetrohuntName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RetrohuntName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRuleRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRuleRequest
    {
        /// <summary>
        /// <see cref="gccv::RuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RuleName RuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRulesRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteRuleRequest
    {
        /// <summary>
        /// <see cref="gccv::RuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RuleName RuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRuleRevisionsRequest
    {
        /// <summary>
        /// <see cref="gccv::RuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RuleName RuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRetrohuntRequest
    {
        /// <summary><see cref="RuleName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RuleName ParentAsRuleName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RuleName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRetrohuntRequest
    {
        /// <summary>
        /// <see cref="gccv::RetrohuntName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RetrohuntName RetrohuntName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RetrohuntName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRetrohuntsRequest
    {
        /// <summary><see cref="RuleName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RuleName ParentAsRuleName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RuleName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRuleDeploymentRequest
    {
        /// <summary>
        /// <see cref="gccv::RuleDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RuleDeploymentName RuleDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RuleDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRuleDeploymentsRequest
    {
        /// <summary><see cref="RuleName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RuleName ParentAsRuleName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RuleName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RetrohuntMetadata
    {
        /// <summary>
        /// <see cref="RuleName"/>-typed view over the <see cref="Retrohunt"/> resource name property.
        /// </summary>
        public RuleName RetrohuntAsRuleName
        {
            get => string.IsNullOrEmpty(Retrohunt) ? null : RuleName.Parse(Retrohunt, allowUnparsed: true);
            set => Retrohunt = value?.ToString() ?? "";
        }
    }
}

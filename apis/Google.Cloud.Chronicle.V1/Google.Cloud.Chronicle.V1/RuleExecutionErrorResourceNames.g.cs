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
using gccv = Google.Cloud.Chronicle.V1;
using sys = System;

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Resource name for the <c>RuleExecutionError</c> resource.</summary>
    public sealed partial class RuleExecutionErrorName : gax::IResourceName, sys::IEquatable<RuleExecutionErrorName>
    {
        /// <summary>The possible contents of <see cref="RuleExecutionErrorName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/instances/{instance}/ruleExecutionErrors/{rule_execution_error}</c>
            /// .
            /// </summary>
            ProjectLocationInstanceRuleExecutionError = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceRuleExecutionError = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/ruleExecutionErrors/{rule_execution_error}");

        /// <summary>Creates a <see cref="RuleExecutionErrorName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RuleExecutionErrorName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RuleExecutionErrorName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RuleExecutionErrorName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RuleExecutionErrorName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/ruleExecutionErrors/{rule_execution_error}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleExecutionErrorId">
        /// The <c>RuleExecutionError</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="RuleExecutionErrorName"/> constructed from the provided ids.</returns>
        public static RuleExecutionErrorName FromProjectLocationInstanceRuleExecutionError(string projectId, string locationId, string instanceId, string ruleExecutionErrorId) =>
            new RuleExecutionErrorName(ResourceNameType.ProjectLocationInstanceRuleExecutionError, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), ruleExecutionErrorId: gax::GaxPreconditions.CheckNotNullOrEmpty(ruleExecutionErrorId, nameof(ruleExecutionErrorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RuleExecutionErrorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/ruleExecutionErrors/{rule_execution_error}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleExecutionErrorId">
        /// The <c>RuleExecutionError</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="RuleExecutionErrorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/ruleExecutionErrors/{rule_execution_error}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string ruleExecutionErrorId) =>
            FormatProjectLocationInstanceRuleExecutionError(projectId, locationId, instanceId, ruleExecutionErrorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RuleExecutionErrorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/ruleExecutionErrors/{rule_execution_error}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleExecutionErrorId">
        /// The <c>RuleExecutionError</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="RuleExecutionErrorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/ruleExecutionErrors/{rule_execution_error}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationInstanceRuleExecutionError(string projectId, string locationId, string instanceId, string ruleExecutionErrorId) =>
            s_projectLocationInstanceRuleExecutionError.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(ruleExecutionErrorId, nameof(ruleExecutionErrorId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RuleExecutionErrorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/ruleExecutionErrors/{rule_execution_error}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="ruleExecutionErrorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RuleExecutionErrorName"/> if successful.</returns>
        public static RuleExecutionErrorName Parse(string ruleExecutionErrorName) => Parse(ruleExecutionErrorName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RuleExecutionErrorName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/ruleExecutionErrors/{rule_execution_error}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="ruleExecutionErrorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RuleExecutionErrorName"/> if successful.</returns>
        public static RuleExecutionErrorName Parse(string ruleExecutionErrorName, bool allowUnparsed) =>
            TryParse(ruleExecutionErrorName, allowUnparsed, out RuleExecutionErrorName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RuleExecutionErrorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/ruleExecutionErrors/{rule_execution_error}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="ruleExecutionErrorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RuleExecutionErrorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string ruleExecutionErrorName, out RuleExecutionErrorName result) =>
            TryParse(ruleExecutionErrorName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RuleExecutionErrorName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/ruleExecutionErrors/{rule_execution_error}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="ruleExecutionErrorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RuleExecutionErrorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string ruleExecutionErrorName, bool allowUnparsed, out RuleExecutionErrorName result)
        {
            gax::GaxPreconditions.CheckNotNull(ruleExecutionErrorName, nameof(ruleExecutionErrorName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceRuleExecutionError.TryParseName(ruleExecutionErrorName, out resourceName))
            {
                result = FromProjectLocationInstanceRuleExecutionError(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(ruleExecutionErrorName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RuleExecutionErrorName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string projectId = null, string ruleExecutionErrorId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
            RuleExecutionErrorId = ruleExecutionErrorId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RuleExecutionErrorName"/> class from the component parts of
        /// pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/ruleExecutionErrors/{rule_execution_error}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleExecutionErrorId">
        /// The <c>RuleExecutionError</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public RuleExecutionErrorName(string projectId, string locationId, string instanceId, string ruleExecutionErrorId) : this(ResourceNameType.ProjectLocationInstanceRuleExecutionError, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), ruleExecutionErrorId: gax::GaxPreconditions.CheckNotNullOrEmpty(ruleExecutionErrorId, nameof(ruleExecutionErrorId)))
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
        /// The <c>RuleExecutionError</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string RuleExecutionErrorId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationInstanceRuleExecutionError: return s_projectLocationInstanceRuleExecutionError.Expand(ProjectId, LocationId, InstanceId, RuleExecutionErrorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RuleExecutionErrorName);

        /// <inheritdoc/>
        public bool Equals(RuleExecutionErrorName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RuleExecutionErrorName a, RuleExecutionErrorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RuleExecutionErrorName a, RuleExecutionErrorName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CuratedRule</c> resource.</summary>
    public sealed partial class CuratedRuleName : gax::IResourceName, sys::IEquatable<CuratedRuleName>
    {
        /// <summary>The possible contents of <see cref="CuratedRuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/curatedRules/{curatedRule}</c>.
            /// </summary>
            ProjectLocationInstanceCuratedRule = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceCuratedRule = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/curatedRules/{curatedRule}");

        /// <summary>Creates a <see cref="CuratedRuleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CuratedRuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CuratedRuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CuratedRuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CuratedRuleName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/curatedRules/{curatedRule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="curatedRuleId">The <c>CuratedRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CuratedRuleName"/> constructed from the provided ids.</returns>
        public static CuratedRuleName FromProjectLocationInstanceCuratedRule(string projectId, string locationId, string instanceId, string curatedRuleId) =>
            new CuratedRuleName(ResourceNameType.ProjectLocationInstanceCuratedRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), curatedRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(curatedRuleId, nameof(curatedRuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CuratedRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/curatedRules/{curatedRule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="curatedRuleId">The <c>CuratedRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CuratedRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/curatedRules/{curatedRule}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string curatedRuleId) =>
            FormatProjectLocationInstanceCuratedRule(projectId, locationId, instanceId, curatedRuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CuratedRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/curatedRules/{curatedRule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="curatedRuleId">The <c>CuratedRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CuratedRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/curatedRules/{curatedRule}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceCuratedRule(string projectId, string locationId, string instanceId, string curatedRuleId) =>
            s_projectLocationInstanceCuratedRule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(curatedRuleId, nameof(curatedRuleId)));

        /// <summary>Parses the given resource name string into a new <see cref="CuratedRuleName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/curatedRules/{curatedRule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="curatedRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CuratedRuleName"/> if successful.</returns>
        public static CuratedRuleName Parse(string curatedRuleName) => Parse(curatedRuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CuratedRuleName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/curatedRules/{curatedRule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="curatedRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CuratedRuleName"/> if successful.</returns>
        public static CuratedRuleName Parse(string curatedRuleName, bool allowUnparsed) =>
            TryParse(curatedRuleName, allowUnparsed, out CuratedRuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CuratedRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/curatedRules/{curatedRule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="curatedRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CuratedRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string curatedRuleName, out CuratedRuleName result) =>
            TryParse(curatedRuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CuratedRuleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/curatedRules/{curatedRule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="curatedRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CuratedRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string curatedRuleName, bool allowUnparsed, out CuratedRuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(curatedRuleName, nameof(curatedRuleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceCuratedRule.TryParseName(curatedRuleName, out resourceName))
            {
                result = FromProjectLocationInstanceCuratedRule(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(curatedRuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CuratedRuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string curatedRuleId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CuratedRuleId = curatedRuleId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CuratedRuleName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/curatedRules/{curatedRule}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="curatedRuleId">The <c>CuratedRule</c> ID. Must not be <c>null</c> or empty.</param>
        public CuratedRuleName(string projectId, string locationId, string instanceId, string curatedRuleId) : this(ResourceNameType.ProjectLocationInstanceCuratedRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), curatedRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(curatedRuleId, nameof(curatedRuleId)))
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
        /// The <c>CuratedRule</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CuratedRuleId { get; }

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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationInstanceCuratedRule: return s_projectLocationInstanceCuratedRule.Expand(ProjectId, LocationId, InstanceId, CuratedRuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CuratedRuleName);

        /// <inheritdoc/>
        public bool Equals(CuratedRuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CuratedRuleName a, CuratedRuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CuratedRuleName a, CuratedRuleName b) => !(a == b);
    }

    public partial class ListRuleExecutionErrorsRequest
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

    public partial class RuleExecutionError
    {
        /// <summary>
        /// <see cref="gccv::RuleExecutionErrorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RuleExecutionErrorName RuleExecutionErrorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RuleExecutionErrorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="RuleName"/>-typed view over the <see cref="Rule"/> resource name property.</summary>
        public RuleName RuleAsRuleName
        {
            get => string.IsNullOrEmpty(Rule) ? null : RuleName.Parse(Rule, allowUnparsed: true);
            set => Rule = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CuratedRuleName"/>-typed view over the <see cref="CuratedRule"/> resource name property.
        /// </summary>
        public CuratedRuleName CuratedRuleAsCuratedRuleName
        {
            get => string.IsNullOrEmpty(CuratedRule) ? null : CuratedRuleName.Parse(CuratedRule, allowUnparsed: true);
            set => CuratedRule = value?.ToString() ?? "";
        }
    }
}

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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcdcv = Google.Cloud.Dialogflow.Cx.V3;
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Resource name for the <c>Agent</c> resource.</summary>
    public sealed partial class AgentName : gax::IResourceName, sys::IEquatable<AgentName>
    {
        /// <summary>The possible contents of <see cref="AgentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/agents/{agent}</c>.
            /// </summary>
            ProjectLocationAgent = 1,
        }

        private static gax::PathTemplate s_projectLocationAgent = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}");

        /// <summary>Creates a <see cref="AgentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AgentName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AgentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AgentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AgentName"/> with the pattern <c>projects/{project}/locations/{location}/agents/{agent}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AgentName"/> constructed from the provided ids.</returns>
        public static AgentName FromProjectLocationAgent(string projectId, string locationId, string agentId) =>
            new AgentName(ResourceNameType.ProjectLocationAgent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId) =>
            FormatProjectLocationAgent(projectId, locationId, agentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}</c>.
        /// </returns>
        public static string FormatProjectLocationAgent(string projectId, string locationId, string agentId) =>
            s_projectLocationAgent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)));

        /// <summary>Parses the given resource name string into a new <see cref="AgentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/agents/{agent}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="agentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AgentName"/> if successful.</returns>
        public static AgentName Parse(string agentName) => Parse(agentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AgentName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/agents/{agent}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AgentName"/> if successful.</returns>
        public static AgentName Parse(string agentName, bool allowUnparsed) =>
            TryParse(agentName, allowUnparsed, out AgentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AgentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/agents/{agent}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="agentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AgentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentName, out AgentName result) => TryParse(agentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AgentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/agents/{agent}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AgentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentName, bool allowUnparsed, out AgentName result)
        {
            gax::GaxPreconditions.CheckNotNull(agentName, nameof(agentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgent.TryParseName(agentName, out resourceName))
            {
                result = FromProjectLocationAgent(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(agentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AgentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AgentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        public AgentName(string projectId, string locationId, string agentId) : this(ResourceNameType.ProjectLocationAgent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)))
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
        /// The <c>Agent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AgentId { get; }

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
                case ResourceNameType.ProjectLocationAgent: return s_projectLocationAgent.Expand(ProjectId, LocationId, AgentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AgentName);

        /// <inheritdoc/>
        public bool Equals(AgentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AgentName a, AgentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AgentName a, AgentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AgentValidationResult</c> resource.</summary>
    public sealed partial class AgentValidationResultName : gax::IResourceName, sys::IEquatable<AgentValidationResultName>
    {
        /// <summary>The possible contents of <see cref="AgentValidationResultName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/agents/{agent}/validationResult</c>
            /// .
            /// </summary>
            ProjectLocationAgent = 1,
        }

        private static gax::PathTemplate s_projectLocationAgent = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/validationResult");

        /// <summary>Creates a <see cref="AgentValidationResultName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AgentValidationResultName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AgentValidationResultName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AgentValidationResultName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AgentValidationResultName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/validationResult</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AgentValidationResultName"/> constructed from the provided ids.
        /// </returns>
        public static AgentValidationResultName FromProjectLocationAgent(string projectId, string locationId, string agentId) =>
            new AgentValidationResultName(ResourceNameType.ProjectLocationAgent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AgentValidationResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/validationResult</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AgentValidationResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/validationResult</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId) =>
            FormatProjectLocationAgent(projectId, locationId, agentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AgentValidationResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/validationResult</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AgentValidationResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/validationResult</c>.
        /// </returns>
        public static string FormatProjectLocationAgent(string projectId, string locationId, string agentId) =>
            s_projectLocationAgent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AgentValidationResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/validationResult</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="agentValidationResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AgentValidationResultName"/> if successful.</returns>
        public static AgentValidationResultName Parse(string agentValidationResultName) =>
            Parse(agentValidationResultName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AgentValidationResultName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/validationResult</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentValidationResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AgentValidationResultName"/> if successful.</returns>
        public static AgentValidationResultName Parse(string agentValidationResultName, bool allowUnparsed) =>
            TryParse(agentValidationResultName, allowUnparsed, out AgentValidationResultName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AgentValidationResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/validationResult</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="agentValidationResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AgentValidationResultName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentValidationResultName, out AgentValidationResultName result) =>
            TryParse(agentValidationResultName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AgentValidationResultName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/validationResult</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentValidationResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AgentValidationResultName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentValidationResultName, bool allowUnparsed, out AgentValidationResultName result)
        {
            gax::GaxPreconditions.CheckNotNull(agentValidationResultName, nameof(agentValidationResultName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgent.TryParseName(agentValidationResultName, out resourceName))
            {
                result = FromProjectLocationAgent(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(agentValidationResultName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AgentValidationResultName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AgentValidationResultName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/agents/{agent}/validationResult</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        public AgentValidationResultName(string projectId, string locationId, string agentId) : this(ResourceNameType.ProjectLocationAgent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)))
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
        /// The <c>Agent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AgentId { get; }

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
                case ResourceNameType.ProjectLocationAgent: return s_projectLocationAgent.Expand(ProjectId, LocationId, AgentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AgentValidationResultName);

        /// <inheritdoc/>
        public bool Equals(AgentValidationResultName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AgentValidationResultName a, AgentValidationResultName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AgentValidationResultName a, AgentValidationResultName b) => !(a == b);
    }

    public partial class Agent
    {
        /// <summary>
        /// <see cref="gcdcv::AgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::AgentName AgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::AgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FlowName"/>-typed view over the <see cref="StartFlow"/> resource name property.
        /// </summary>
        public FlowName StartFlowAsFlowName
        {
            get => string.IsNullOrEmpty(StartFlow) ? null : FlowName.Parse(StartFlow, allowUnparsed: true);
            set => StartFlow = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecuritySettingsName"/>-typed view over the <see cref="SecuritySettings"/> resource name
        /// property.
        /// </summary>
        public SecuritySettingsName SecuritySettingsAsSecuritySettingsName
        {
            get => string.IsNullOrEmpty(SecuritySettings) ? null : SecuritySettingsName.Parse(SecuritySettings, allowUnparsed: true);
            set => SecuritySettings = value?.ToString() ?? "";
        }
    }

    public partial class ListAgentsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAgentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::AgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::AgentName AgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::AgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAgentRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAgentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::AgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::AgentName AgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::AgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportAgentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::AgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::AgentName AgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::AgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Environment"/> resource name property.
        /// </summary>
        public EnvironmentName EnvironmentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Environment) ? null : EnvironmentName.Parse(Environment, allowUnparsed: true);
            set => Environment = value?.ToString() ?? "";
        }
    }

    public partial class RestoreAgentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::AgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::AgentName AgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::AgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ValidateAgentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::AgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::AgentName AgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::AgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAgentValidationResultRequest
    {
        /// <summary>
        /// <see cref="gcdcv::AgentValidationResultName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdcv::AgentValidationResultName AgentValidationResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::AgentValidationResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AgentValidationResult
    {
        /// <summary>
        /// <see cref="gcdcv::AgentValidationResultName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdcv::AgentValidationResultName AgentValidationResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::AgentValidationResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetGenerativeSettingsRequest
    {
        /// <summary>
        /// <see cref="gcdcv::AgentGenerativeSettingsName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdcv::AgentGenerativeSettingsName AgentGenerativeSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::AgentGenerativeSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

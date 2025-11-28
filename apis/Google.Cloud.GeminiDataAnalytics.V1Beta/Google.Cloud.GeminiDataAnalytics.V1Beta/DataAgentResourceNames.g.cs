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
using gcgv = Google.Cloud.GeminiDataAnalytics.V1Beta;
using sys = System;

namespace Google.Cloud.GeminiDataAnalytics.V1Beta
{
    /// <summary>Resource name for the <c>DataAgent</c> resource.</summary>
    public sealed partial class DataAgentName : gax::IResourceName, sys::IEquatable<DataAgentName>
    {
        /// <summary>The possible contents of <see cref="DataAgentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/dataAgents/{data_agent}</c>.
            /// </summary>
            ProjectLocationDataAgent = 1,
        }

        private static gax::PathTemplate s_projectLocationDataAgent = new gax::PathTemplate("projects/{project}/locations/{location}/dataAgents/{data_agent}");

        /// <summary>Creates a <see cref="DataAgentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataAgentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataAgentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataAgentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataAgentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataAgents/{data_agent}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAgentId">The <c>DataAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataAgentName"/> constructed from the provided ids.</returns>
        public static DataAgentName FromProjectLocationDataAgent(string projectId, string locationId, string dataAgentId) =>
            new DataAgentName(ResourceNameType.ProjectLocationDataAgent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataAgentId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataAgentId, nameof(dataAgentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataAgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataAgents/{data_agent}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAgentId">The <c>DataAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataAgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataAgents/{data_agent}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataAgentId) =>
            FormatProjectLocationDataAgent(projectId, locationId, dataAgentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataAgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataAgents/{data_agent}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAgentId">The <c>DataAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataAgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataAgents/{data_agent}</c>.
        /// </returns>
        public static string FormatProjectLocationDataAgent(string projectId, string locationId, string dataAgentId) =>
            s_projectLocationDataAgent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataAgentId, nameof(dataAgentId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataAgentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataAgents/{data_agent}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataAgentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataAgentName"/> if successful.</returns>
        public static DataAgentName Parse(string dataAgentName) => Parse(dataAgentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataAgentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataAgents/{data_agent}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataAgentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataAgentName"/> if successful.</returns>
        public static DataAgentName Parse(string dataAgentName, bool allowUnparsed) =>
            TryParse(dataAgentName, allowUnparsed, out DataAgentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataAgentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataAgents/{data_agent}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataAgentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataAgentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataAgentName, out DataAgentName result) => TryParse(dataAgentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataAgentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataAgents/{data_agent}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataAgentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataAgentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataAgentName, bool allowUnparsed, out DataAgentName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataAgentName, nameof(dataAgentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataAgent.TryParseName(dataAgentName, out resourceName))
            {
                result = FromProjectLocationDataAgent(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataAgentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataAgentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataAgentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataAgentId = dataAgentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataAgentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataAgents/{data_agent}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAgentId">The <c>DataAgent</c> ID. Must not be <c>null</c> or empty.</param>
        public DataAgentName(string projectId, string locationId, string dataAgentId) : this(ResourceNameType.ProjectLocationDataAgent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataAgentId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataAgentId, nameof(dataAgentId)))
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
        /// The <c>DataAgent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataAgentId { get; }

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
                case ResourceNameType.ProjectLocationDataAgent: return s_projectLocationDataAgent.Expand(ProjectId, LocationId, DataAgentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataAgentName);

        /// <inheritdoc/>
        public bool Equals(DataAgentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataAgentName a, DataAgentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataAgentName a, DataAgentName b) => !(a == b);
    }

    public partial class DataAgent
    {
        /// <summary>
        /// <see cref="gcgv::DataAgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::DataAgentName DataAgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::DataAgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

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
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Resource name for the <c>Session</c> resource.</summary>
    public sealed partial class SessionName : gax::IResourceName, sys::IEquatable<SessionName>
    {
        /// <summary>The possible contents of <see cref="SessionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agents/{agent}/sessions/{session}</c>.
            /// </summary>
            ProjectLocationAgentSession = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/sessions/{session}</c>
            /// .
            /// </summary>
            ProjectLocationAgentEnvironmentSession = 2,
        }

        private static gax::PathTemplate s_projectLocationAgentSession = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/sessions/{session}");

        private static gax::PathTemplate s_projectLocationAgentEnvironmentSession = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/sessions/{session}");

        /// <summary>Creates a <see cref="SessionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SessionName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SessionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SessionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SessionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SessionName"/> constructed from the provided ids.</returns>
        public static SessionName FromProjectLocationAgentSession(string projectId, string locationId, string agentId, string sessionId) =>
            new SessionName(ResourceNameType.ProjectLocationAgentSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>
        /// Creates a <see cref="SessionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SessionName"/> constructed from the provided ids.</returns>
        public static SessionName FromProjectLocationAgentEnvironmentSession(string projectId, string locationId, string agentId, string environmentId, string sessionId) =>
            new SessionName(ResourceNameType.ProjectLocationAgentEnvironmentSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/sessions/{session}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string sessionId) =>
            FormatProjectLocationAgentSession(projectId, locationId, agentId, sessionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/sessions/{session}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentSession(string projectId, string locationId, string agentId, string sessionId) =>
            s_projectLocationAgentSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/sessions/{session}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentEnvironmentSession(string projectId, string locationId, string agentId, string environmentId, string sessionId) =>
            s_projectLocationAgentEnvironmentSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>Parses the given resource name string into a new <see cref="SessionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/sessions/{session}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/sessions/{session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SessionName"/> if successful.</returns>
        public static SessionName Parse(string sessionName) => Parse(sessionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SessionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/sessions/{session}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/sessions/{session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SessionName"/> if successful.</returns>
        public static SessionName Parse(string sessionName, bool allowUnparsed) =>
            TryParse(sessionName, allowUnparsed, out SessionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/sessions/{session}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/sessions/{session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionName, out SessionName result) => TryParse(sessionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SessionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/sessions/{session}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/sessions/{session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionName, bool allowUnparsed, out SessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentSession.TryParseName(sessionName, out resourceName))
            {
                result = FromProjectLocationAgentSession(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationAgentEnvironmentSession.TryParseName(sessionName, out resourceName))
            {
                result = FromProjectLocationAgentEnvironmentSession(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sessionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SessionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string environmentId = null, string locationId = null, string projectId = null, string sessionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            EnvironmentId = environmentId;
            LocationId = locationId;
            ProjectId = projectId;
            SessionId = sessionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SessionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/sessions/{session}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        public SessionName(string projectId, string locationId, string agentId, string sessionId) : this(ResourceNameType.ProjectLocationAgentSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)))
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
        /// The <c>Agent</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string AgentId { get; }

        /// <summary>
        /// The <c>Environment</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string EnvironmentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Session</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string SessionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationAgentSession: return s_projectLocationAgentSession.Expand(ProjectId, LocationId, AgentId, SessionId);
                case ResourceNameType.ProjectLocationAgentEnvironmentSession: return s_projectLocationAgentEnvironmentSession.Expand(ProjectId, LocationId, AgentId, EnvironmentId, SessionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SessionName);

        /// <inheritdoc/>
        public bool Equals(SessionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SessionName a, SessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SessionName a, SessionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataStore</c> resource.</summary>
    public sealed partial class DataStoreName : gax::IResourceName, sys::IEquatable<DataStoreName>
    {
        /// <summary>The possible contents of <see cref="DataStoreName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/dataStores/{data_store}</c>.
            /// </summary>
            ProjectLocationDataStore = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}</c>.
            /// </summary>
            ProjectLocationCollectionDataStore = 2,
        }

        private static gax::PathTemplate s_projectLocationDataStore = new gax::PathTemplate("projects/{project}/locations/{location}/dataStores/{data_store}");

        private static gax::PathTemplate s_projectLocationCollectionDataStore = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}");

        /// <summary>Creates a <see cref="DataStoreName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataStoreName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataStoreName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataStoreName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataStoreName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataStoreName"/> constructed from the provided ids.</returns>
        public static DataStoreName FromProjectLocationDataStore(string projectId, string locationId, string dataStoreId) =>
            new DataStoreName(ResourceNameType.ProjectLocationDataStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Creates a <see cref="DataStoreName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataStoreName"/> constructed from the provided ids.</returns>
        public static DataStoreName FromProjectLocationCollectionDataStore(string projectId, string locationId, string collectionId, string dataStoreId) =>
            new DataStoreName(ResourceNameType.ProjectLocationCollectionDataStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataStoreId) =>
            FormatProjectLocationDataStore(projectId, locationId, dataStoreId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}</c>.
        /// </returns>
        public static string FormatProjectLocationDataStore(string projectId, string locationId, string dataStoreId) =>
            s_projectLocationDataStore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}</c>.
        /// </returns>
        public static string FormatProjectLocationCollectionDataStore(string projectId, string locationId, string collectionId, string dataStoreId) =>
            s_projectLocationCollectionDataStore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataStoreName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataStores/{data_store}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataStoreName"/> if successful.</returns>
        public static DataStoreName Parse(string dataStoreName) => Parse(dataStoreName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataStoreName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataStores/{data_store}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataStoreName"/> if successful.</returns>
        public static DataStoreName Parse(string dataStoreName, bool allowUnparsed) =>
            TryParse(dataStoreName, allowUnparsed, out DataStoreName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataStoreName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataStores/{data_store}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataStoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataStoreName, out DataStoreName result) => TryParse(dataStoreName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataStoreName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataStores/{data_store}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataStoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataStoreName, bool allowUnparsed, out DataStoreName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataStoreName, nameof(dataStoreName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataStore.TryParseName(dataStoreName, out resourceName))
            {
                result = FromProjectLocationDataStore(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationCollectionDataStore.TryParseName(dataStoreName, out resourceName))
            {
                result = FromProjectLocationCollectionDataStore(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataStoreName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataStoreName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string dataStoreId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            DataStoreId = dataStoreId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataStoreName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        public DataStoreName(string projectId, string locationId, string dataStoreId) : this(ResourceNameType.ProjectLocationDataStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)))
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
        /// The <c>Collection</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string CollectionId { get; }

        /// <summary>
        /// The <c>DataStore</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string DataStoreId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectLocationDataStore: return s_projectLocationDataStore.Expand(ProjectId, LocationId, DataStoreId);
                case ResourceNameType.ProjectLocationCollectionDataStore: return s_projectLocationCollectionDataStore.Expand(ProjectId, LocationId, CollectionId, DataStoreId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataStoreName);

        /// <inheritdoc/>
        public bool Equals(DataStoreName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataStoreName a, DataStoreName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataStoreName a, DataStoreName b) => !(a == b);
    }

    public partial class SubmitAnswerFeedbackRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }

    public partial class DetectIntentRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }

    public partial class StreamingDetectIntentRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }

    public partial class QueryParameters
    {
        /// <summary>
        /// <see cref="PageName"/>-typed view over the <see cref="CurrentPage"/> resource name property.
        /// </summary>
        public PageName CurrentPageAsPageName
        {
            get => string.IsNullOrEmpty(CurrentPage) ? null : PageName.Parse(CurrentPage, allowUnparsed: true);
            set => CurrentPage = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VersionName"/>-typed view over the <see cref="FlowVersions"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<VersionName> FlowVersionsAsVersionNames
        {
            get => new gax::ResourceNameList<VersionName>(FlowVersions, s => string.IsNullOrEmpty(s) ? null : VersionName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BoostSpecs
    {
        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="DataStores"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<DataStoreName> DataStoresAsDataStoreNames
        {
            get => new gax::ResourceNameList<DataStoreName>(DataStores, s => string.IsNullOrEmpty(s) ? null : DataStoreName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class FilterSpecs
    {
        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="DataStores"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<DataStoreName> DataStoresAsDataStoreNames
        {
            get => new gax::ResourceNameList<DataStoreName>(DataStores, s => string.IsNullOrEmpty(s) ? null : DataStoreName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class QueryResult
    {
        /// <summary>
        /// <see cref="IntentName"/>-typed view over the <see cref="TriggerIntent"/> resource name property.
        /// </summary>
        public IntentName TriggerIntentAsIntentName
        {
            get => string.IsNullOrEmpty(TriggerIntent) ? null : IntentName.Parse(TriggerIntent, allowUnparsed: true);
            set => TriggerIntent = value?.ToString() ?? "";
        }
    }

    public partial class IntentInput
    {
        /// <summary><see cref="IntentName"/>-typed view over the <see cref="Intent"/> resource name property.</summary>
        public IntentName IntentAsIntentName
        {
            get => string.IsNullOrEmpty(Intent) ? null : IntentName.Parse(Intent, allowUnparsed: true);
            set => Intent = value?.ToString() ?? "";
        }
    }

    public partial class MatchIntentRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }

    public partial class MatchIntentResponse
    {
        /// <summary>
        /// <see cref="IntentName"/>-typed view over the <see cref="TriggerIntent"/> resource name property.
        /// </summary>
        public IntentName TriggerIntentAsIntentName
        {
            get => string.IsNullOrEmpty(TriggerIntent) ? null : IntentName.Parse(TriggerIntent, allowUnparsed: true);
            set => TriggerIntent = value?.ToString() ?? "";
        }
    }
}

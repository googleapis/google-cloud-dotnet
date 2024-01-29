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
using gax = Google.Api.Gax;
using gcdv = Google.Cloud.Dialogflow.V2;
using sys = System;

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Resource name for the <c>SessionEntityType</c> resource.</summary>
    public sealed partial class SessionEntityTypeName : gax::IResourceName, sys::IEquatable<SessionEntityTypeName>
    {
        /// <summary>The possible contents of <see cref="SessionEntityTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/agent/sessions/{session}/entityTypes/{entity_type}</c>
            /// .
            /// </summary>
            ProjectSessionEntityType = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
            /// .
            /// </summary>
            ProjectEnvironmentUserSessionEntityType = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/entityTypes/{entity_type}</c>.
            /// </summary>
            ProjectLocationSessionEntityType = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
            /// .
            /// </summary>
            ProjectLocationEnvironmentUserSessionEntityType = 4,
        }

        private static gax::PathTemplate s_projectSessionEntityType = new gax::PathTemplate("projects/{project}/agent/sessions/{session}/entityTypes/{entity_type}");

        private static gax::PathTemplate s_projectEnvironmentUserSessionEntityType = new gax::PathTemplate("projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}");

        private static gax::PathTemplate s_projectLocationSessionEntityType = new gax::PathTemplate("projects/{project}/locations/{location}/agent/sessions/{session}/entityTypes/{entity_type}");

        private static gax::PathTemplate s_projectLocationEnvironmentUserSessionEntityType = new gax::PathTemplate("projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}");

        /// <summary>Creates a <see cref="SessionEntityTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SessionEntityTypeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SessionEntityTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SessionEntityTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SessionEntityTypeName"/> with the pattern
        /// <c>projects/{project}/agent/sessions/{session}/entityTypes/{entity_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SessionEntityTypeName"/> constructed from the provided ids.</returns>
        public static SessionEntityTypeName FromProjectSessionEntityType(string projectId, string sessionId, string entityTypeId) =>
            new SessionEntityTypeName(ResourceNameType.ProjectSessionEntityType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), entityTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Creates a <see cref="SessionEntityTypeName"/> with the pattern
        /// <c>
        /// projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SessionEntityTypeName"/> constructed from the provided ids.</returns>
        public static SessionEntityTypeName FromProjectEnvironmentUserSessionEntityType(string projectId, string environmentId, string userId, string sessionId, string entityTypeId) =>
            new SessionEntityTypeName(ResourceNameType.ProjectEnvironmentUserSessionEntityType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), entityTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Creates a <see cref="SessionEntityTypeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/entityTypes/{entity_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SessionEntityTypeName"/> constructed from the provided ids.</returns>
        public static SessionEntityTypeName FromProjectLocationSessionEntityType(string projectId, string locationId, string sessionId, string entityTypeId) =>
            new SessionEntityTypeName(ResourceNameType.ProjectLocationSessionEntityType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), entityTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Creates a <see cref="SessionEntityTypeName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SessionEntityTypeName"/> constructed from the provided ids.</returns>
        public static SessionEntityTypeName FromProjectLocationEnvironmentUserSessionEntityType(string projectId, string locationId, string environmentId, string userId, string sessionId, string entityTypeId) =>
            new SessionEntityTypeName(ResourceNameType.ProjectLocationEnvironmentUserSessionEntityType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), entityTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionEntityTypeName"/> with pattern
        /// <c>projects/{project}/agent/sessions/{session}/entityTypes/{entity_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionEntityTypeName"/> with pattern
        /// <c>projects/{project}/agent/sessions/{session}/entityTypes/{entity_type}</c>.
        /// </returns>
        public static string Format(string projectId, string sessionId, string entityTypeId) =>
            FormatProjectSessionEntityType(projectId, sessionId, entityTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionEntityTypeName"/> with pattern
        /// <c>projects/{project}/agent/sessions/{session}/entityTypes/{entity_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionEntityTypeName"/> with pattern
        /// <c>projects/{project}/agent/sessions/{session}/entityTypes/{entity_type}</c>.
        /// </returns>
        public static string FormatProjectSessionEntityType(string projectId, string sessionId, string entityTypeId) =>
            s_projectSessionEntityType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionEntityTypeName"/> with pattern
        /// <c>
        /// projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionEntityTypeName"/> with pattern
        /// <c>
        /// projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// .
        /// </returns>
        public static string FormatProjectEnvironmentUserSessionEntityType(string projectId, string environmentId, string userId, string sessionId, string entityTypeId) =>
            s_projectEnvironmentUserSessionEntityType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionEntityTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/entityTypes/{entity_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionEntityTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/entityTypes/{entity_type}</c>.
        /// </returns>
        public static string FormatProjectLocationSessionEntityType(string projectId, string locationId, string sessionId, string entityTypeId) =>
            s_projectLocationSessionEntityType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionEntityTypeName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionEntityTypeName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationEnvironmentUserSessionEntityType(string projectId, string locationId, string environmentId, string userId, string sessionId, string entityTypeId) =>
            s_projectLocationEnvironmentUserSessionEntityType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SessionEntityTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/agent/sessions/{session}/entityTypes/{entity_type}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sessionEntityTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SessionEntityTypeName"/> if successful.</returns>
        public static SessionEntityTypeName Parse(string sessionEntityTypeName) => Parse(sessionEntityTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SessionEntityTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/agent/sessions/{session}/entityTypes/{entity_type}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sessionEntityTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SessionEntityTypeName"/> if successful.</returns>
        public static SessionEntityTypeName Parse(string sessionEntityTypeName, bool allowUnparsed) =>
            TryParse(sessionEntityTypeName, allowUnparsed, out SessionEntityTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SessionEntityTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/agent/sessions/{session}/entityTypes/{entity_type}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sessionEntityTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SessionEntityTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionEntityTypeName, out SessionEntityTypeName result) =>
            TryParse(sessionEntityTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SessionEntityTypeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/agent/sessions/{session}/entityTypes/{entity_type}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sessionEntityTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SessionEntityTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionEntityTypeName, bool allowUnparsed, out SessionEntityTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(sessionEntityTypeName, nameof(sessionEntityTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSessionEntityType.TryParseName(sessionEntityTypeName, out resourceName))
            {
                result = FromProjectSessionEntityType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectEnvironmentUserSessionEntityType.TryParseName(sessionEntityTypeName, out resourceName))
            {
                result = FromProjectEnvironmentUserSessionEntityType(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (s_projectLocationSessionEntityType.TryParseName(sessionEntityTypeName, out resourceName))
            {
                result = FromProjectLocationSessionEntityType(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationEnvironmentUserSessionEntityType.TryParseName(sessionEntityTypeName, out resourceName))
            {
                result = FromProjectLocationEnvironmentUserSessionEntityType(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sessionEntityTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SessionEntityTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entityTypeId = null, string environmentId = null, string locationId = null, string projectId = null, string sessionId = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntityTypeId = entityTypeId;
            EnvironmentId = environmentId;
            LocationId = locationId;
            ProjectId = projectId;
            SessionId = sessionId;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SessionEntityTypeName"/> class from the component parts of pattern
        /// <c>projects/{project}/agent/sessions/{session}/entityTypes/{entity_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        public SessionEntityTypeName(string projectId, string sessionId, string entityTypeId) : this(ResourceNameType.ProjectSessionEntityType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), entityTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)))
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
        /// The <c>EntityType</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string EntityTypeId { get; }

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

        /// <summary>
        /// The <c>User</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string UserId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSessionEntityType: return s_projectSessionEntityType.Expand(ProjectId, SessionId, EntityTypeId);
                case ResourceNameType.ProjectEnvironmentUserSessionEntityType: return s_projectEnvironmentUserSessionEntityType.Expand(ProjectId, EnvironmentId, UserId, SessionId, EntityTypeId);
                case ResourceNameType.ProjectLocationSessionEntityType: return s_projectLocationSessionEntityType.Expand(ProjectId, LocationId, SessionId, EntityTypeId);
                case ResourceNameType.ProjectLocationEnvironmentUserSessionEntityType: return s_projectLocationEnvironmentUserSessionEntityType.Expand(ProjectId, LocationId, EnvironmentId, UserId, SessionId, EntityTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SessionEntityTypeName);

        /// <inheritdoc/>
        public bool Equals(SessionEntityTypeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SessionEntityTypeName a, SessionEntityTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SessionEntityTypeName a, SessionEntityTypeName b) => !(a == b);
    }

    public partial class SessionEntityType
    {
        /// <summary>
        /// <see cref="gcdv::SessionEntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SessionEntityTypeName SessionEntityTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SessionEntityTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSessionEntityTypesRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SessionName ParentAsSessionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SessionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSessionEntityTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::SessionEntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SessionEntityTypeName SessionEntityTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SessionEntityTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSessionEntityTypeRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SessionName ParentAsSessionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SessionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSessionEntityTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::SessionEntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SessionEntityTypeName SessionEntityTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SessionEntityTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

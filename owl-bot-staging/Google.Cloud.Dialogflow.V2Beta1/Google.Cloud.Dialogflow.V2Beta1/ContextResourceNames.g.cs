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
using gcdv = Google.Cloud.Dialogflow.V2Beta1;
using sys = System;

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Resource name for the <c>Context</c> resource.</summary>
    public sealed partial class ContextName : gax::IResourceName, sys::IEquatable<ContextName>
    {
        /// <summary>The possible contents of <see cref="ContextName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/agent/sessions/{session}/contexts/{context}</c>.
            /// </summary>
            ProjectSessionContext = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
            /// .
            /// </summary>
            ProjectEnvironmentUserSessionContext = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/contexts/{context}</c>.
            /// </summary>
            ProjectLocationSessionContext = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
            /// .
            /// </summary>
            ProjectLocationEnvironmentUserSessionContext = 4,
        }

        private static gax::PathTemplate s_projectSessionContext = new gax::PathTemplate("projects/{project}/agent/sessions/{session}/contexts/{context}");

        private static gax::PathTemplate s_projectEnvironmentUserSessionContext = new gax::PathTemplate("projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}");

        private static gax::PathTemplate s_projectLocationSessionContext = new gax::PathTemplate("projects/{project}/locations/{location}/agent/sessions/{session}/contexts/{context}");

        private static gax::PathTemplate s_projectLocationEnvironmentUserSessionContext = new gax::PathTemplate("projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}");

        /// <summary>Creates a <see cref="ContextName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ContextName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ContextName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ContextName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ContextName"/> with the pattern
        /// <c>projects/{project}/agent/sessions/{session}/contexts/{context}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ContextName"/> constructed from the provided ids.</returns>
        public static ContextName FromProjectSessionContext(string projectId, string sessionId, string contextId) =>
            new ContextName(ResourceNameType.ProjectSessionContext, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), contextId: gax::GaxPreconditions.CheckNotNullOrEmpty(contextId, nameof(contextId)));

        /// <summary>
        /// Creates a <see cref="ContextName"/> with the pattern
        /// <c>projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ContextName"/> constructed from the provided ids.</returns>
        public static ContextName FromProjectEnvironmentUserSessionContext(string projectId, string environmentId, string userId, string sessionId, string contextId) =>
            new ContextName(ResourceNameType.ProjectEnvironmentUserSessionContext, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), contextId: gax::GaxPreconditions.CheckNotNullOrEmpty(contextId, nameof(contextId)));

        /// <summary>
        /// Creates a <see cref="ContextName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/contexts/{context}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ContextName"/> constructed from the provided ids.</returns>
        public static ContextName FromProjectLocationSessionContext(string projectId, string locationId, string sessionId, string contextId) =>
            new ContextName(ResourceNameType.ProjectLocationSessionContext, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), contextId: gax::GaxPreconditions.CheckNotNullOrEmpty(contextId, nameof(contextId)));

        /// <summary>
        /// Creates a <see cref="ContextName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ContextName"/> constructed from the provided ids.</returns>
        public static ContextName FromProjectLocationEnvironmentUserSessionContext(string projectId, string locationId, string environmentId, string userId, string sessionId, string contextId) =>
            new ContextName(ResourceNameType.ProjectLocationEnvironmentUserSessionContext, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), contextId: gax::GaxPreconditions.CheckNotNullOrEmpty(contextId, nameof(contextId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContextName"/> with pattern
        /// <c>projects/{project}/agent/sessions/{session}/contexts/{context}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContextName"/> with pattern
        /// <c>projects/{project}/agent/sessions/{session}/contexts/{context}</c>.
        /// </returns>
        public static string Format(string projectId, string sessionId, string contextId) =>
            FormatProjectSessionContext(projectId, sessionId, contextId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContextName"/> with pattern
        /// <c>projects/{project}/agent/sessions/{session}/contexts/{context}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContextName"/> with pattern
        /// <c>projects/{project}/agent/sessions/{session}/contexts/{context}</c>.
        /// </returns>
        public static string FormatProjectSessionContext(string projectId, string sessionId, string contextId) =>
            s_projectSessionContext.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(contextId, nameof(contextId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContextName"/> with pattern
        /// <c>projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContextName"/> with pattern
        /// <c>projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// .
        /// </returns>
        public static string FormatProjectEnvironmentUserSessionContext(string projectId, string environmentId, string userId, string sessionId, string contextId) =>
            s_projectEnvironmentUserSessionContext.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(contextId, nameof(contextId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContextName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/contexts/{context}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContextName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/contexts/{context}</c>.
        /// </returns>
        public static string FormatProjectLocationSessionContext(string projectId, string locationId, string sessionId, string contextId) =>
            s_projectLocationSessionContext.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(contextId, nameof(contextId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContextName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContextName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationEnvironmentUserSessionContext(string projectId, string locationId, string environmentId, string userId, string sessionId, string contextId) =>
            s_projectLocationEnvironmentUserSessionContext.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(contextId, nameof(contextId)));

        /// <summary>Parses the given resource name string into a new <see cref="ContextName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/agent/sessions/{session}/contexts/{context}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="contextName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ContextName"/> if successful.</returns>
        public static ContextName Parse(string contextName) => Parse(contextName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ContextName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/agent/sessions/{session}/contexts/{context}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contextName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ContextName"/> if successful.</returns>
        public static ContextName Parse(string contextName, bool allowUnparsed) =>
            TryParse(contextName, allowUnparsed, out ContextName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContextName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/agent/sessions/{session}/contexts/{context}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="contextName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContextName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contextName, out ContextName result) => TryParse(contextName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContextName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/agent/sessions/{session}/contexts/{context}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agent/sessions/{session}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agent/environments/{environment}/users/{user}/sessions/{session}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contextName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContextName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contextName, bool allowUnparsed, out ContextName result)
        {
            gax::GaxPreconditions.CheckNotNull(contextName, nameof(contextName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSessionContext.TryParseName(contextName, out resourceName))
            {
                result = FromProjectSessionContext(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectEnvironmentUserSessionContext.TryParseName(contextName, out resourceName))
            {
                result = FromProjectEnvironmentUserSessionContext(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (s_projectLocationSessionContext.TryParseName(contextName, out resourceName))
            {
                result = FromProjectLocationSessionContext(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationEnvironmentUserSessionContext.TryParseName(contextName, out resourceName))
            {
                result = FromProjectLocationEnvironmentUserSessionContext(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(contextName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ContextName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string contextId = null, string environmentId = null, string locationId = null, string projectId = null, string sessionId = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ContextId = contextId;
            EnvironmentId = environmentId;
            LocationId = locationId;
            ProjectId = projectId;
            SessionId = sessionId;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ContextName"/> class from the component parts of pattern
        /// <c>projects/{project}/agent/sessions/{session}/contexts/{context}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        public ContextName(string projectId, string sessionId, string contextId) : this(ResourceNameType.ProjectSessionContext, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), contextId: gax::GaxPreconditions.CheckNotNullOrEmpty(contextId, nameof(contextId)))
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
        /// The <c>Context</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ContextId { get; }

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
                case ResourceNameType.ProjectSessionContext: return s_projectSessionContext.Expand(ProjectId, SessionId, ContextId);
                case ResourceNameType.ProjectEnvironmentUserSessionContext: return s_projectEnvironmentUserSessionContext.Expand(ProjectId, EnvironmentId, UserId, SessionId, ContextId);
                case ResourceNameType.ProjectLocationSessionContext: return s_projectLocationSessionContext.Expand(ProjectId, LocationId, SessionId, ContextId);
                case ResourceNameType.ProjectLocationEnvironmentUserSessionContext: return s_projectLocationEnvironmentUserSessionContext.Expand(ProjectId, LocationId, EnvironmentId, UserId, SessionId, ContextId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ContextName);

        /// <inheritdoc/>
        public bool Equals(ContextName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ContextName a, ContextName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ContextName a, ContextName b) => !(a == b);
    }

    public partial class Context
    {
        /// <summary>
        /// <see cref="gcdv::ContextName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ContextName ContextName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ContextName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListContextsRequest
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

    public partial class GetContextRequest
    {
        /// <summary>
        /// <see cref="gcdv::ContextName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ContextName ContextName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ContextName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateContextRequest
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

    public partial class DeleteContextRequest
    {
        /// <summary>
        /// <see cref="gcdv::ContextName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ContextName ContextName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ContextName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAllContextsRequest
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
}

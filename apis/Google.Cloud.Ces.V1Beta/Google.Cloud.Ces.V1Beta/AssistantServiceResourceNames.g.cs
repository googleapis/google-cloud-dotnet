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
using gccv = Google.Cloud.Ces.V1Beta;
using sys = System;

namespace Google.Cloud.Ces.V1Beta
{
    /// <summary>Resource name for the <c>AssistantSession</c> resource.</summary>
    public sealed partial class AssistantSessionName : gax::IResourceName, sys::IEquatable<AssistantSessionName>
    {
        /// <summary>The possible contents of <see cref="AssistantSessionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}</c>.
            /// </summary>
            ProjectLocationAppAssistantSession = 1,
        }

        private static gax::PathTemplate s_projectLocationAppAssistantSession = new gax::PathTemplate("projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}");

        /// <summary>Creates a <see cref="AssistantSessionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssistantSessionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssistantSessionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssistantSessionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssistantSessionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assistantSessionId">The <c>AssistantSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssistantSessionName"/> constructed from the provided ids.</returns>
        public static AssistantSessionName FromProjectLocationAppAssistantSession(string projectId, string locationId, string appId, string assistantSessionId) =>
            new AssistantSessionName(ResourceNameType.ProjectLocationAppAssistantSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), assistantSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(assistantSessionId, nameof(assistantSessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssistantSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assistantSessionId">The <c>AssistantSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssistantSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string appId, string assistantSessionId) =>
            FormatProjectLocationAppAssistantSession(projectId, locationId, appId, assistantSessionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssistantSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assistantSessionId">The <c>AssistantSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssistantSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}</c>.
        /// </returns>
        public static string FormatProjectLocationAppAssistantSession(string projectId, string locationId, string appId, string assistantSessionId) =>
            s_projectLocationAppAssistantSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assistantSessionId, nameof(assistantSessionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssistantSessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assistantSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssistantSessionName"/> if successful.</returns>
        public static AssistantSessionName Parse(string assistantSessionName) => Parse(assistantSessionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssistantSessionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assistantSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssistantSessionName"/> if successful.</returns>
        public static AssistantSessionName Parse(string assistantSessionName, bool allowUnparsed) =>
            TryParse(assistantSessionName, allowUnparsed, out AssistantSessionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssistantSessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assistantSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssistantSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assistantSessionName, out AssistantSessionName result) =>
            TryParse(assistantSessionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssistantSessionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assistantSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssistantSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assistantSessionName, bool allowUnparsed, out AssistantSessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(assistantSessionName, nameof(assistantSessionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAppAssistantSession.TryParseName(assistantSessionName, out resourceName))
            {
                result = FromProjectLocationAppAssistantSession(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assistantSessionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AssistantSessionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string appId = null, string assistantSessionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AppId = appId;
            AssistantSessionId = assistantSessionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssistantSessionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assistantSessionId">The <c>AssistantSession</c> ID. Must not be <c>null</c> or empty.</param>
        public AssistantSessionName(string projectId, string locationId, string appId, string assistantSessionId) : this(ResourceNameType.ProjectLocationAppAssistantSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), assistantSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(assistantSessionId, nameof(assistantSessionId)))
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
        /// The <c>App</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// The <c>AssistantSession</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AssistantSessionId { get; }

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
                case ResourceNameType.ProjectLocationAppAssistantSession: return s_projectLocationAppAssistantSession.Expand(ProjectId, LocationId, AppId, AssistantSessionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssistantSessionName);

        /// <inheritdoc/>
        public bool Equals(AssistantSessionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AssistantSessionName a, AssistantSessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AssistantSessionName a, AssistantSessionName b) => !(a == b);
    }

    public partial class ListAssistantSessionsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAssistantSessionRequest
    {
        /// <summary>
        /// <see cref="gccv::AssistantSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AssistantSessionName AssistantSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AssistantSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAssistantSessionRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAssistantSessionRequest
    {
        /// <summary>
        /// <see cref="gccv::AssistantSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AssistantSessionName AssistantSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AssistantSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RunAssistantRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="App"/> resource name property.</summary>
        public AppName AppAsAppName
        {
            get => string.IsNullOrEmpty(App) ? null : AppName.Parse(App, allowUnparsed: true);
            set => App = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AssistantSessionName"/>-typed view over the <see cref="AssistantSession"/> resource name
        /// property.
        /// </summary>
        public AssistantSessionName AssistantSessionAsAssistantSessionName
        {
            get => string.IsNullOrEmpty(AssistantSession) ? null : AssistantSessionName.Parse(AssistantSession, allowUnparsed: true);
            set => AssistantSession = value?.ToString() ?? "";
        }
    }

    public partial class AssistantSession
    {
        /// <summary>
        /// <see cref="gccv::AssistantSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AssistantSessionName AssistantSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AssistantSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ChatAiAssistantRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="App"/> resource name property.</summary>
        public AppName AppAsAppName
        {
            get => string.IsNullOrEmpty(App) ? null : AppName.Parse(App, allowUnparsed: true);
            set => App = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AssistantSessionName"/>-typed view over the <see cref="AssistantSession"/> resource name
        /// property.
        /// </summary>
        public AssistantSessionName AssistantSessionAsAssistantSessionName
        {
            get => string.IsNullOrEmpty(AssistantSession) ? null : AssistantSessionName.Parse(AssistantSession, allowUnparsed: true);
            set => AssistantSession = value?.ToString() ?? "";
        }
    }
}

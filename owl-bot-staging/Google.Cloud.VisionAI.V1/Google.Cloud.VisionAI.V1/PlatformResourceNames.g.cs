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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcvv = Google.Cloud.VisionAI.V1;
using sys = System;

namespace Google.Cloud.VisionAI.V1
{
    /// <summary>Resource name for the <c>Application</c> resource.</summary>
    public sealed partial class ApplicationName : gax::IResourceName, sys::IEquatable<ApplicationName>
    {
        /// <summary>The possible contents of <see cref="ApplicationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/applications/{application}</c>.
            /// </summary>
            ProjectLocationApplication = 1,
        }

        private static gax::PathTemplate s_projectLocationApplication = new gax::PathTemplate("projects/{project}/locations/{location}/applications/{application}");

        /// <summary>Creates a <see cref="ApplicationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApplicationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApplicationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApplicationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApplicationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ApplicationName"/> constructed from the provided ids.</returns>
        public static ApplicationName FromProjectLocationApplication(string projectId, string locationId, string applicationId) =>
            new ApplicationName(ResourceNameType.ProjectLocationApplication, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), applicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApplicationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApplicationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string applicationId) =>
            FormatProjectLocationApplication(projectId, locationId, applicationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApplicationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApplicationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}</c>.
        /// </returns>
        public static string FormatProjectLocationApplication(string projectId, string locationId, string applicationId) =>
            s_projectLocationApplication.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)));

        /// <summary>Parses the given resource name string into a new <see cref="ApplicationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/applications/{application}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="applicationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ApplicationName"/> if successful.</returns>
        public static ApplicationName Parse(string applicationName) => Parse(applicationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApplicationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/applications/{application}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="applicationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ApplicationName"/> if successful.</returns>
        public static ApplicationName Parse(string applicationName, bool allowUnparsed) =>
            TryParse(applicationName, allowUnparsed, out ApplicationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApplicationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/applications/{application}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="applicationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApplicationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string applicationName, out ApplicationName result) =>
            TryParse(applicationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApplicationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/applications/{application}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="applicationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApplicationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string applicationName, bool allowUnparsed, out ApplicationName result)
        {
            gax::GaxPreconditions.CheckNotNull(applicationName, nameof(applicationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApplication.TryParseName(applicationName, out resourceName))
            {
                result = FromProjectLocationApplication(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(applicationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ApplicationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string applicationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApplicationId = applicationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ApplicationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        public ApplicationName(string projectId, string locationId, string applicationId) : this(ResourceNameType.ProjectLocationApplication, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), applicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)))
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
        /// The <c>Application</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ApplicationId { get; }

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
                case ResourceNameType.ProjectLocationApplication: return s_projectLocationApplication.Expand(ProjectId, LocationId, ApplicationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ApplicationName);

        /// <inheritdoc/>
        public bool Equals(ApplicationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ApplicationName a, ApplicationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ApplicationName a, ApplicationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Draft</c> resource.</summary>
    public sealed partial class DraftName : gax::IResourceName, sys::IEquatable<DraftName>
    {
        /// <summary>The possible contents of <see cref="DraftName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/applications/{application}/drafts/{draft}</c>.
            /// </summary>
            ProjectLocationApplicationDraft = 1,
        }

        private static gax::PathTemplate s_projectLocationApplicationDraft = new gax::PathTemplate("projects/{project}/locations/{location}/applications/{application}/drafts/{draft}");

        /// <summary>Creates a <see cref="DraftName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DraftName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DraftName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DraftName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DraftName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/drafts/{draft}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="draftId">The <c>Draft</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DraftName"/> constructed from the provided ids.</returns>
        public static DraftName FromProjectLocationApplicationDraft(string projectId, string locationId, string applicationId, string draftId) =>
            new DraftName(ResourceNameType.ProjectLocationApplicationDraft, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), applicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)), draftId: gax::GaxPreconditions.CheckNotNullOrEmpty(draftId, nameof(draftId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DraftName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/drafts/{draft}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="draftId">The <c>Draft</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DraftName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/drafts/{draft}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string applicationId, string draftId) =>
            FormatProjectLocationApplicationDraft(projectId, locationId, applicationId, draftId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DraftName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/drafts/{draft}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="draftId">The <c>Draft</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DraftName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/drafts/{draft}</c>.
        /// </returns>
        public static string FormatProjectLocationApplicationDraft(string projectId, string locationId, string applicationId, string draftId) =>
            s_projectLocationApplicationDraft.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(draftId, nameof(draftId)));

        /// <summary>Parses the given resource name string into a new <see cref="DraftName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/drafts/{draft}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="draftName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DraftName"/> if successful.</returns>
        public static DraftName Parse(string draftName) => Parse(draftName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DraftName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/drafts/{draft}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="draftName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DraftName"/> if successful.</returns>
        public static DraftName Parse(string draftName, bool allowUnparsed) =>
            TryParse(draftName, allowUnparsed, out DraftName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DraftName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/drafts/{draft}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="draftName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DraftName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string draftName, out DraftName result) => TryParse(draftName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DraftName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/drafts/{draft}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="draftName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DraftName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string draftName, bool allowUnparsed, out DraftName result)
        {
            gax::GaxPreconditions.CheckNotNull(draftName, nameof(draftName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApplicationDraft.TryParseName(draftName, out resourceName))
            {
                result = FromProjectLocationApplicationDraft(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(draftName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DraftName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string applicationId = null, string draftId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApplicationId = applicationId;
            DraftId = draftId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DraftName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/drafts/{draft}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="draftId">The <c>Draft</c> ID. Must not be <c>null</c> or empty.</param>
        public DraftName(string projectId, string locationId, string applicationId, string draftId) : this(ResourceNameType.ProjectLocationApplicationDraft, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), applicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)), draftId: gax::GaxPreconditions.CheckNotNullOrEmpty(draftId, nameof(draftId)))
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
        /// The <c>Application</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ApplicationId { get; }

        /// <summary>
        /// The <c>Draft</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DraftId { get; }

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
                case ResourceNameType.ProjectLocationApplicationDraft: return s_projectLocationApplicationDraft.Expand(ProjectId, LocationId, ApplicationId, DraftId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DraftName);

        /// <inheritdoc/>
        public bool Equals(DraftName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DraftName a, DraftName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DraftName a, DraftName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Instance</c> resource.</summary>
    public sealed partial class InstanceName : gax::IResourceName, sys::IEquatable<InstanceName>
    {
        /// <summary>The possible contents of <see cref="InstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/applications/{application}/instances/{instance}</c>.
            /// </summary>
            ProjectLocationApplicationInstance = 1,
        }

        private static gax::PathTemplate s_projectLocationApplicationInstance = new gax::PathTemplate("projects/{project}/locations/{location}/applications/{application}/instances/{instance}");

        /// <summary>Creates a <see cref="InstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static InstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstanceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InstanceName"/> constructed from the provided ids.</returns>
        public static InstanceName FromProjectLocationApplicationInstance(string projectId, string locationId, string applicationId, string instanceId) =>
            new InstanceName(ResourceNameType.ProjectLocationApplicationInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), applicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/instances/{instance}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string applicationId, string instanceId) =>
            FormatProjectLocationApplicationInstance(projectId, locationId, applicationId, instanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/instances/{instance}</c>.
        /// </returns>
        public static string FormatProjectLocationApplicationInstance(string projectId, string locationId, string applicationId, string instanceId) =>
            s_projectLocationApplicationInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>Parses the given resource name string into a new <see cref="InstanceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/instances/{instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceName"/> if successful.</returns>
        public static InstanceName Parse(string instanceName) => Parse(instanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/instances/{instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstanceName"/> if successful.</returns>
        public static InstanceName Parse(string instanceName, bool allowUnparsed) =>
            TryParse(instanceName, allowUnparsed, out InstanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/instances/{instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, out InstanceName result) => TryParse(instanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/instances/{instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, bool allowUnparsed, out InstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApplicationInstance.TryParseName(instanceName, out resourceName))
            {
                result = FromProjectLocationApplicationInstance(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string applicationId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApplicationId = applicationId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstanceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/instances/{instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        public InstanceName(string projectId, string locationId, string applicationId, string instanceId) : this(ResourceNameType.ProjectLocationApplicationInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), applicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)))
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
        /// The <c>Application</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ApplicationId { get; }

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
                case ResourceNameType.ProjectLocationApplicationInstance: return s_projectLocationApplicationInstance.Expand(ProjectId, LocationId, ApplicationId, InstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstanceName);

        /// <inheritdoc/>
        public bool Equals(InstanceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InstanceName a, InstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InstanceName a, InstanceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Processor</c> resource.</summary>
    public sealed partial class ProcessorName : gax::IResourceName, sys::IEquatable<ProcessorName>
    {
        /// <summary>The possible contents of <see cref="ProcessorName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/processors/{processor}</c>.
            /// </summary>
            ProjectLocationProcessor = 1,
        }

        private static gax::PathTemplate s_projectLocationProcessor = new gax::PathTemplate("projects/{project}/locations/{location}/processors/{processor}");

        /// <summary>Creates a <see cref="ProcessorName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProcessorName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProcessorName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProcessorName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProcessorName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProcessorName"/> constructed from the provided ids.</returns>
        public static ProcessorName FromProjectLocationProcessor(string projectId, string locationId, string processorId) =>
            new ProcessorName(ResourceNameType.ProjectLocationProcessor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProcessorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProcessorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string processorId) =>
            FormatProjectLocationProcessor(projectId, locationId, processorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProcessorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProcessorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}</c>.
        /// </returns>
        public static string FormatProjectLocationProcessor(string projectId, string locationId, string processorId) =>
            s_projectLocationProcessor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProcessorName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processors/{processor}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="processorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProcessorName"/> if successful.</returns>
        public static ProcessorName Parse(string processorName) => Parse(processorName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProcessorName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processors/{processor}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="processorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProcessorName"/> if successful.</returns>
        public static ProcessorName Parse(string processorName, bool allowUnparsed) =>
            TryParse(processorName, allowUnparsed, out ProcessorName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProcessorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processors/{processor}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="processorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProcessorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string processorName, out ProcessorName result) => TryParse(processorName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProcessorName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processors/{processor}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="processorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProcessorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string processorName, bool allowUnparsed, out ProcessorName result)
        {
            gax::GaxPreconditions.CheckNotNull(processorName, nameof(processorName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationProcessor.TryParseName(processorName, out resourceName))
            {
                result = FromProjectLocationProcessor(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(processorName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProcessorName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string processorId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProcessorId = processorId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProcessorName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        public ProcessorName(string projectId, string locationId, string processorId) : this(ResourceNameType.ProjectLocationProcessor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Processor</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProcessorId { get; }

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
                case ResourceNameType.ProjectLocationProcessor: return s_projectLocationProcessor.Expand(ProjectId, LocationId, ProcessorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProcessorName);

        /// <inheritdoc/>
        public bool Equals(ProcessorName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProcessorName a, ProcessorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProcessorName a, ProcessorName b) => !(a == b);
    }

    public partial class CreateApplicationInstancesRequest
    {
        /// <summary>
        /// <see cref="gcvv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteApplicationInstancesRequest
    {
        /// <summary>
        /// <see cref="gcvv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="InstanceIds"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<InstanceName> InstanceIdsAsInstanceNames
        {
            get => new gax::ResourceNameList<InstanceName>(InstanceIds, s => string.IsNullOrEmpty(s) ? null : InstanceName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ListApplicationsRequest
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

    public partial class GetApplicationRequest
    {
        /// <summary>
        /// <see cref="gcvv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateApplicationRequest
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

    public partial class DeleteApplicationRequest
    {
        /// <summary>
        /// <see cref="gcvv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeployApplicationRequest
    {
        /// <summary>
        /// <see cref="gcvv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UndeployApplicationRequest
    {
        /// <summary>
        /// <see cref="gcvv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AddApplicationStreamInputRequest
    {
        /// <summary>
        /// <see cref="gcvv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UpdateApplicationStreamInputRequest
    {
        /// <summary>
        /// <see cref="gcvv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RemoveApplicationStreamInputRequest
    {
        /// <summary>
        /// <see cref="gcvv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class TargetStreamInput
            {
                /// <summary>
                /// <see cref="StreamName"/>-typed view over the <see cref="Stream"/> resource name property.
                /// </summary>
                public StreamName StreamAsStreamName
                {
                    get => string.IsNullOrEmpty(Stream) ? null : StreamName.Parse(Stream, allowUnparsed: true);
                    set => Stream = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListInstancesRequest
    {
        /// <summary>
        /// <see cref="ApplicationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApplicationName ParentAsApplicationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApplicationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetInstanceRequest
    {
        /// <summary>
        /// <see cref="gcvv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDraftsRequest
    {
        /// <summary>
        /// <see cref="ApplicationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApplicationName ParentAsApplicationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApplicationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDraftRequest
    {
        /// <summary>
        /// <see cref="gcvv::DraftName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::DraftName DraftName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::DraftName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDraftRequest
    {
        /// <summary>
        /// <see cref="ApplicationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApplicationName ParentAsApplicationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApplicationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateApplicationInstancesRequest
    {
        /// <summary>
        /// <see cref="gcvv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDraftRequest
    {
        /// <summary>
        /// <see cref="gcvv::DraftName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::DraftName DraftName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::DraftName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListProcessorsRequest
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

    public partial class ListPrebuiltProcessorsRequest
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

    public partial class GetProcessorRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProcessorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProcessorName ProcessorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProcessorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateProcessorRequest
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

    public partial class DeleteProcessorRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProcessorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProcessorName ProcessorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProcessorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Application
    {
        /// <summary>
        /// <see cref="gcvv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Draft
    {
        /// <summary>
        /// <see cref="gcvv::DraftName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::DraftName DraftName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::DraftName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Instance
    {
        /// <summary>
        /// <see cref="gcvv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Processor
    {
        /// <summary>
        /// <see cref="gcvv::ProcessorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProcessorName ProcessorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProcessorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StreamWithAnnotation
    {
        /// <summary><see cref="StreamName"/>-typed view over the <see cref="Stream"/> resource name property.</summary>
        public StreamName StreamAsStreamName
        {
            get => string.IsNullOrEmpty(Stream) ? null : StreamName.Parse(Stream, allowUnparsed: true);
            set => Stream = value?.ToString() ?? "";
        }
    }
}

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
using gcdv = Google.Cloud.DesignCenter.V1;
using sys = System;

namespace Google.Cloud.DesignCenter.V1
{
    /// <summary>Resource name for the <c>ApplicationTemplate</c> resource.</summary>
    public sealed partial class ApplicationTemplateName : gax::IResourceName, sys::IEquatable<ApplicationTemplateName>
    {
        /// <summary>The possible contents of <see cref="ApplicationTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}</c>
            /// .
            /// </summary>
            ProjectLocationSpaceApplicationTemplate = 1,
        }

        private static gax::PathTemplate s_projectLocationSpaceApplicationTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}");

        /// <summary>Creates a <see cref="ApplicationTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApplicationTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApplicationTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApplicationTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApplicationTemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ApplicationTemplateName"/> constructed from the provided ids.
        /// </returns>
        public static ApplicationTemplateName FromProjectLocationSpaceApplicationTemplate(string projectId, string locationId, string spaceId, string applicationTemplateId) =>
            new ApplicationTemplateName(ResourceNameType.ProjectLocationSpaceApplicationTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), applicationTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApplicationTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ApplicationTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string spaceId, string applicationTemplateId) =>
            FormatProjectLocationSpaceApplicationTemplate(projectId, locationId, spaceId, applicationTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApplicationTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ApplicationTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}</c>.
        /// </returns>
        public static string FormatProjectLocationSpaceApplicationTemplate(string projectId, string locationId, string spaceId, string applicationTemplateId) =>
            s_projectLocationSpaceApplicationTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApplicationTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="applicationTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ApplicationTemplateName"/> if successful.</returns>
        public static ApplicationTemplateName Parse(string applicationTemplateName) => Parse(applicationTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApplicationTemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="applicationTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ApplicationTemplateName"/> if successful.</returns>
        public static ApplicationTemplateName Parse(string applicationTemplateName, bool allowUnparsed) =>
            TryParse(applicationTemplateName, allowUnparsed, out ApplicationTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApplicationTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="applicationTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApplicationTemplateName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string applicationTemplateName, out ApplicationTemplateName result) =>
            TryParse(applicationTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApplicationTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="applicationTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApplicationTemplateName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string applicationTemplateName, bool allowUnparsed, out ApplicationTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(applicationTemplateName, nameof(applicationTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSpaceApplicationTemplate.TryParseName(applicationTemplateName, out resourceName))
            {
                result = FromProjectLocationSpaceApplicationTemplate(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(applicationTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ApplicationTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string applicationTemplateId = null, string locationId = null, string projectId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApplicationTemplateId = applicationTemplateId;
            LocationId = locationId;
            ProjectId = projectId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ApplicationTemplateName"/> class from the component parts of
        /// pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ApplicationTemplateName(string projectId, string locationId, string spaceId, string applicationTemplateId) : this(ResourceNameType.ProjectLocationSpaceApplicationTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), applicationTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)))
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
        /// The <c>ApplicationTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ApplicationTemplateId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSpaceApplicationTemplate: return s_projectLocationSpaceApplicationTemplate.Expand(ProjectId, LocationId, SpaceId, ApplicationTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ApplicationTemplateName);

        /// <inheritdoc/>
        public bool Equals(ApplicationTemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ApplicationTemplateName a, ApplicationTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ApplicationTemplateName a, ApplicationTemplateName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ApplicationTemplateRevision</c> resource.</summary>
    public sealed partial class ApplicationTemplateRevisionName : gax::IResourceName, sys::IEquatable<ApplicationTemplateRevisionName>
    {
        /// <summary>The possible contents of <see cref="ApplicationTemplateRevisionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/revisions/{revision}</c>
            /// .
            /// </summary>
            ProjectLocationSpaceApplicationTemplateRevision = 1,
        }

        private static gax::PathTemplate s_projectLocationSpaceApplicationTemplateRevision = new gax::PathTemplate("projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/revisions/{revision}");

        /// <summary>
        /// Creates a <see cref="ApplicationTemplateRevisionName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApplicationTemplateRevisionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApplicationTemplateRevisionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApplicationTemplateRevisionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApplicationTemplateRevisionName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/revisions/{revision}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="ApplicationTemplateRevisionName"/> constructed from the provided ids.
        /// </returns>
        public static ApplicationTemplateRevisionName FromProjectLocationSpaceApplicationTemplateRevision(string projectId, string locationId, string spaceId, string applicationTemplateId, string revisionId) =>
            new ApplicationTemplateRevisionName(ResourceNameType.ProjectLocationSpaceApplicationTemplateRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), applicationTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApplicationTemplateRevisionName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/revisions/{revision}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApplicationTemplateRevisionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/revisions/{revision}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string spaceId, string applicationTemplateId, string revisionId) =>
            FormatProjectLocationSpaceApplicationTemplateRevision(projectId, locationId, spaceId, applicationTemplateId, revisionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApplicationTemplateRevisionName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/revisions/{revision}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApplicationTemplateRevisionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/revisions/{revision}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationSpaceApplicationTemplateRevision(string projectId, string locationId, string spaceId, string applicationTemplateId, string revisionId) =>
            s_projectLocationSpaceApplicationTemplateRevision.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)), gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApplicationTemplateRevisionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="applicationTemplateRevisionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ApplicationTemplateRevisionName"/> if successful.</returns>
        public static ApplicationTemplateRevisionName Parse(string applicationTemplateRevisionName) =>
            Parse(applicationTemplateRevisionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApplicationTemplateRevisionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="applicationTemplateRevisionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ApplicationTemplateRevisionName"/> if successful.</returns>
        public static ApplicationTemplateRevisionName Parse(string applicationTemplateRevisionName, bool allowUnparsed) =>
            TryParse(applicationTemplateRevisionName, allowUnparsed, out ApplicationTemplateRevisionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApplicationTemplateRevisionName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="applicationTemplateRevisionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApplicationTemplateRevisionName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string applicationTemplateRevisionName, out ApplicationTemplateRevisionName result) =>
            TryParse(applicationTemplateRevisionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApplicationTemplateRevisionName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="applicationTemplateRevisionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApplicationTemplateRevisionName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string applicationTemplateRevisionName, bool allowUnparsed, out ApplicationTemplateRevisionName result)
        {
            gax::GaxPreconditions.CheckNotNull(applicationTemplateRevisionName, nameof(applicationTemplateRevisionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSpaceApplicationTemplateRevision.TryParseName(applicationTemplateRevisionName, out resourceName))
            {
                result = FromProjectLocationSpaceApplicationTemplateRevision(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(applicationTemplateRevisionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ApplicationTemplateRevisionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string applicationTemplateId = null, string locationId = null, string projectId = null, string revisionId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApplicationTemplateId = applicationTemplateId;
            LocationId = locationId;
            ProjectId = projectId;
            RevisionId = revisionId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ApplicationTemplateRevisionName"/> class from the component parts
        /// of pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/revisions/{revision}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        public ApplicationTemplateRevisionName(string projectId, string locationId, string spaceId, string applicationTemplateId, string revisionId) : this(ResourceNameType.ProjectLocationSpaceApplicationTemplateRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), applicationTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)))
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
        /// The <c>ApplicationTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ApplicationTemplateId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Revision</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RevisionId { get; }

        /// <summary>
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSpaceApplicationTemplateRevision: return s_projectLocationSpaceApplicationTemplateRevision.Expand(ProjectId, LocationId, SpaceId, ApplicationTemplateId, RevisionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ApplicationTemplateRevisionName);

        /// <inheritdoc/>
        public bool Equals(ApplicationTemplateRevisionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ApplicationTemplateRevisionName a, ApplicationTemplateRevisionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ApplicationTemplateRevisionName a, ApplicationTemplateRevisionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ApplicationTemplateSystemRevision</c> resource.</summary>
    public sealed partial class ApplicationTemplateSystemRevisionName : gax::IResourceName, sys::IEquatable<ApplicationTemplateSystemRevisionName>
    {
        /// <summary>The possible contents of <see cref="ApplicationTemplateSystemRevisionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}</c>
            /// .
            /// </summary>
            ProjectLocationSpaceApplicationTemplateSystemRevision = 1,
        }

        private static gax::PathTemplate s_projectLocationSpaceApplicationTemplateSystemRevision = new gax::PathTemplate("projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}");

        /// <summary>
        /// Creates a <see cref="ApplicationTemplateSystemRevisionName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApplicationTemplateSystemRevisionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApplicationTemplateSystemRevisionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApplicationTemplateSystemRevisionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApplicationTemplateSystemRevisionName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="systemRevisionId">The <c>SystemRevision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="ApplicationTemplateSystemRevisionName"/> constructed from the provided ids.
        /// </returns>
        public static ApplicationTemplateSystemRevisionName FromProjectLocationSpaceApplicationTemplateSystemRevision(string projectId, string locationId, string spaceId, string applicationTemplateId, string systemRevisionId) =>
            new ApplicationTemplateSystemRevisionName(ResourceNameType.ProjectLocationSpaceApplicationTemplateSystemRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), applicationTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)), systemRevisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(systemRevisionId, nameof(systemRevisionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApplicationTemplateSystemRevisionName"/>
        /// with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="systemRevisionId">The <c>SystemRevision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApplicationTemplateSystemRevisionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string spaceId, string applicationTemplateId, string systemRevisionId) =>
            FormatProjectLocationSpaceApplicationTemplateSystemRevision(projectId, locationId, spaceId, applicationTemplateId, systemRevisionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApplicationTemplateSystemRevisionName"/>
        /// with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="systemRevisionId">The <c>SystemRevision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApplicationTemplateSystemRevisionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationSpaceApplicationTemplateSystemRevision(string projectId, string locationId, string spaceId, string applicationTemplateId, string systemRevisionId) =>
            s_projectLocationSpaceApplicationTemplateSystemRevision.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)), gax::GaxPreconditions.CheckNotNullOrEmpty(systemRevisionId, nameof(systemRevisionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApplicationTemplateSystemRevisionName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="applicationTemplateSystemRevisionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ApplicationTemplateSystemRevisionName"/> if successful.</returns>
        public static ApplicationTemplateSystemRevisionName Parse(string applicationTemplateSystemRevisionName) =>
            Parse(applicationTemplateSystemRevisionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApplicationTemplateSystemRevisionName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="applicationTemplateSystemRevisionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ApplicationTemplateSystemRevisionName"/> if successful.</returns>
        public static ApplicationTemplateSystemRevisionName Parse(string applicationTemplateSystemRevisionName, bool allowUnparsed) =>
            TryParse(applicationTemplateSystemRevisionName, allowUnparsed, out ApplicationTemplateSystemRevisionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApplicationTemplateSystemRevisionName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="applicationTemplateSystemRevisionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApplicationTemplateSystemRevisionName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string applicationTemplateSystemRevisionName, out ApplicationTemplateSystemRevisionName result) =>
            TryParse(applicationTemplateSystemRevisionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApplicationTemplateSystemRevisionName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="applicationTemplateSystemRevisionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApplicationTemplateSystemRevisionName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string applicationTemplateSystemRevisionName, bool allowUnparsed, out ApplicationTemplateSystemRevisionName result)
        {
            gax::GaxPreconditions.CheckNotNull(applicationTemplateSystemRevisionName, nameof(applicationTemplateSystemRevisionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSpaceApplicationTemplateSystemRevision.TryParseName(applicationTemplateSystemRevisionName, out resourceName))
            {
                result = FromProjectLocationSpaceApplicationTemplateSystemRevision(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(applicationTemplateSystemRevisionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ApplicationTemplateSystemRevisionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string applicationTemplateId = null, string locationId = null, string projectId = null, string spaceId = null, string systemRevisionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApplicationTemplateId = applicationTemplateId;
            LocationId = locationId;
            ProjectId = projectId;
            SpaceId = spaceId;
            SystemRevisionId = systemRevisionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ApplicationTemplateSystemRevisionName"/> class from the component
        /// parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="systemRevisionId">The <c>SystemRevision</c> ID. Must not be <c>null</c> or empty.</param>
        public ApplicationTemplateSystemRevisionName(string projectId, string locationId, string spaceId, string applicationTemplateId, string systemRevisionId) : this(ResourceNameType.ProjectLocationSpaceApplicationTemplateSystemRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), applicationTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)), systemRevisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(systemRevisionId, nameof(systemRevisionId)))
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
        /// The <c>ApplicationTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ApplicationTemplateId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>
        /// The <c>SystemRevision</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SystemRevisionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSpaceApplicationTemplateSystemRevision: return s_projectLocationSpaceApplicationTemplateSystemRevision.Expand(ProjectId, LocationId, SpaceId, ApplicationTemplateId, SystemRevisionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ApplicationTemplateSystemRevisionName);

        /// <inheritdoc/>
        public bool Equals(ApplicationTemplateSystemRevisionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ApplicationTemplateSystemRevisionName a, ApplicationTemplateSystemRevisionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ApplicationTemplateSystemRevisionName a, ApplicationTemplateSystemRevisionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Component</c> resource.</summary>
    public sealed partial class ComponentName : gax::IResourceName, sys::IEquatable<ComponentName>
    {
        /// <summary>The possible contents of <see cref="ComponentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}</c>
            /// .
            /// </summary>
            ProjectLocationSpaceApplicationTemplateComponent = 1,
        }

        private static gax::PathTemplate s_projectLocationSpaceApplicationTemplateComponent = new gax::PathTemplate("projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}");

        /// <summary>Creates a <see cref="ComponentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ComponentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ComponentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ComponentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ComponentName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ComponentName"/> constructed from the provided ids.</returns>
        public static ComponentName FromProjectLocationSpaceApplicationTemplateComponent(string projectId, string locationId, string spaceId, string applicationTemplateId, string componentId) =>
            new ComponentName(ResourceNameType.ProjectLocationSpaceApplicationTemplateComponent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), applicationTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)), componentId: gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ComponentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ComponentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string spaceId, string applicationTemplateId, string componentId) =>
            FormatProjectLocationSpaceApplicationTemplateComponent(projectId, locationId, spaceId, applicationTemplateId, componentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ComponentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ComponentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationSpaceApplicationTemplateComponent(string projectId, string locationId, string spaceId, string applicationTemplateId, string componentId) =>
            s_projectLocationSpaceApplicationTemplateComponent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)), gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>Parses the given resource name string into a new <see cref="ComponentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="componentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ComponentName"/> if successful.</returns>
        public static ComponentName Parse(string componentName) => Parse(componentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ComponentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="componentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ComponentName"/> if successful.</returns>
        public static ComponentName Parse(string componentName, bool allowUnparsed) =>
            TryParse(componentName, allowUnparsed, out ComponentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ComponentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="componentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ComponentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string componentName, out ComponentName result) => TryParse(componentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ComponentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="componentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ComponentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string componentName, bool allowUnparsed, out ComponentName result)
        {
            gax::GaxPreconditions.CheckNotNull(componentName, nameof(componentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSpaceApplicationTemplateComponent.TryParseName(componentName, out resourceName))
            {
                result = FromProjectLocationSpaceApplicationTemplateComponent(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(componentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ComponentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string applicationTemplateId = null, string componentId = null, string locationId = null, string projectId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApplicationTemplateId = applicationTemplateId;
            ComponentId = componentId;
            LocationId = locationId;
            ProjectId = projectId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ComponentName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        public ComponentName(string projectId, string locationId, string spaceId, string applicationTemplateId, string componentId) : this(ResourceNameType.ProjectLocationSpaceApplicationTemplateComponent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), applicationTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)), componentId: gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)))
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
        /// The <c>ApplicationTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ApplicationTemplateId { get; }

        /// <summary>
        /// The <c>Component</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ComponentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSpaceApplicationTemplateComponent: return s_projectLocationSpaceApplicationTemplateComponent.Expand(ProjectId, LocationId, SpaceId, ApplicationTemplateId, ComponentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ComponentName);

        /// <inheritdoc/>
        public bool Equals(ComponentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ComponentName a, ComponentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ComponentName a, ComponentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Connection</c> resource.</summary>
    public sealed partial class ConnectionName : gax::IResourceName, sys::IEquatable<ConnectionName>
    {
        /// <summary>The possible contents of <see cref="ConnectionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}/connections/{connection}</c>
            /// .
            /// </summary>
            ProjectLocationSpaceApplicationTemplateComponentConnection = 1,
        }

        private static gax::PathTemplate s_projectLocationSpaceApplicationTemplateComponentConnection = new gax::PathTemplate("projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}/connections/{connection}");

        /// <summary>Creates a <see cref="ConnectionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConnectionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConnectionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConnectionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConnectionName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}/connections/{connection}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConnectionName"/> constructed from the provided ids.</returns>
        public static ConnectionName FromProjectLocationSpaceApplicationTemplateComponentConnection(string projectId, string locationId, string spaceId, string applicationTemplateId, string componentId, string connectionId) =>
            new ConnectionName(ResourceNameType.ProjectLocationSpaceApplicationTemplateComponentConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), applicationTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)), componentId: gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}/connections/{connection}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}/connections/{connection}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string spaceId, string applicationTemplateId, string componentId, string connectionId) =>
            FormatProjectLocationSpaceApplicationTemplateComponentConnection(projectId, locationId, spaceId, applicationTemplateId, componentId, connectionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}/connections/{connection}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}/connections/{connection}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationSpaceApplicationTemplateComponentConnection(string projectId, string locationId, string spaceId, string applicationTemplateId, string componentId, string connectionId) =>
            s_projectLocationSpaceApplicationTemplateComponentConnection.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)), gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)));

        /// <summary>Parses the given resource name string into a new <see cref="ConnectionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}/connections/{connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="connectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConnectionName"/> if successful.</returns>
        public static ConnectionName Parse(string connectionName) => Parse(connectionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConnectionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}/connections/{connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConnectionName"/> if successful.</returns>
        public static ConnectionName Parse(string connectionName, bool allowUnparsed) =>
            TryParse(connectionName, allowUnparsed, out ConnectionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}/connections/{connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="connectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectionName, out ConnectionName result) =>
            TryParse(connectionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}/connections/{connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectionName, bool allowUnparsed, out ConnectionName result)
        {
            gax::GaxPreconditions.CheckNotNull(connectionName, nameof(connectionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSpaceApplicationTemplateComponentConnection.TryParseName(connectionName, out resourceName))
            {
                result = FromProjectLocationSpaceApplicationTemplateComponentConnection(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(connectionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConnectionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string applicationTemplateId = null, string componentId = null, string connectionId = null, string locationId = null, string projectId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApplicationTemplateId = applicationTemplateId;
            ComponentId = componentId;
            ConnectionId = connectionId;
            LocationId = locationId;
            ProjectId = projectId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConnectionName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/components/{component}/connections/{connection}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationTemplateId">
        /// The <c>ApplicationTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        public ConnectionName(string projectId, string locationId, string spaceId, string applicationTemplateId, string componentId, string connectionId) : this(ResourceNameType.ProjectLocationSpaceApplicationTemplateComponentConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), applicationTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)), componentId: gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)))
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
        /// The <c>ApplicationTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ApplicationTemplateId { get; }

        /// <summary>
        /// The <c>Component</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ComponentId { get; }

        /// <summary>
        /// The <c>Connection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ConnectionId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSpaceApplicationTemplateComponentConnection: return s_projectLocationSpaceApplicationTemplateComponentConnection.Expand(ProjectId, LocationId, SpaceId, ApplicationTemplateId, ComponentId, ConnectionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConnectionName);

        /// <inheritdoc/>
        public bool Equals(ConnectionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConnectionName a, ConnectionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConnectionName a, ConnectionName b) => !(a == b);
    }

    public partial class ApplicationTemplate
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ApplicationTemplateName ApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ApplicationTemplateSystemRevisionName"/>-typed view over the
        /// <see cref="LatestSystemRevisionUri"/> resource name property.
        /// </summary>
        public ApplicationTemplateSystemRevisionName LatestSystemRevisionUriAsApplicationTemplateSystemRevisionName
        {
            get => string.IsNullOrEmpty(LatestSystemRevisionUri) ? null : ApplicationTemplateSystemRevisionName.Parse(LatestSystemRevisionUri, allowUnparsed: true);
            set => LatestSystemRevisionUri = value?.ToString() ?? "";
        }
    }

    public partial class ApplicationTemplateRevision
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::ApplicationTemplateRevisionName ApplicationTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ApplicationTemplateSystemRevision
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateSystemRevisionName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcdv::ApplicationTemplateSystemRevisionName ApplicationTemplateSystemRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateSystemRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Component
    {
        /// <summary>
        /// <see cref="gcdv::ComponentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ComponentName ComponentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ComponentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Connection
    {
        /// <summary>
        /// <see cref="gcdv::ConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConnectionName ConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ComponentName"/>-typed view over the <see cref="DestinationComponentUri"/> resource name
        /// property.
        /// </summary>
        public ComponentName DestinationComponentUriAsComponentName
        {
            get => string.IsNullOrEmpty(DestinationComponentUri) ? null : ComponentName.Parse(DestinationComponentUri, allowUnparsed: true);
            set => DestinationComponentUri = value?.ToString() ?? "";
        }
    }
}

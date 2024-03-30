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
using gcav = Google.Cloud.AIPlatform.V1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Resource name for the <c>NotebookRuntimeTemplate</c> resource.</summary>
    public sealed partial class NotebookRuntimeTemplateName : gax::IResourceName, sys::IEquatable<NotebookRuntimeTemplateName>
    {
        /// <summary>The possible contents of <see cref="NotebookRuntimeTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}</c>.
            /// </summary>
            ProjectLocationNotebookRuntimeTemplate = 1,
        }

        private static gax::PathTemplate s_projectLocationNotebookRuntimeTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}");

        /// <summary>Creates a <see cref="NotebookRuntimeTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NotebookRuntimeTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NotebookRuntimeTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NotebookRuntimeTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NotebookRuntimeTemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notebookRuntimeTemplateId">
        /// The <c>NotebookRuntimeTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="NotebookRuntimeTemplateName"/> constructed from the provided ids.
        /// </returns>
        public static NotebookRuntimeTemplateName FromProjectLocationNotebookRuntimeTemplate(string projectId, string locationId, string notebookRuntimeTemplateId) =>
            new NotebookRuntimeTemplateName(ResourceNameType.ProjectLocationNotebookRuntimeTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), notebookRuntimeTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(notebookRuntimeTemplateId, nameof(notebookRuntimeTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotebookRuntimeTemplateName"/> with
        /// pattern <c>projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notebookRuntimeTemplateId">
        /// The <c>NotebookRuntimeTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="NotebookRuntimeTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string notebookRuntimeTemplateId) =>
            FormatProjectLocationNotebookRuntimeTemplate(projectId, locationId, notebookRuntimeTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotebookRuntimeTemplateName"/> with
        /// pattern <c>projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notebookRuntimeTemplateId">
        /// The <c>NotebookRuntimeTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="NotebookRuntimeTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}</c>.
        /// </returns>
        public static string FormatProjectLocationNotebookRuntimeTemplate(string projectId, string locationId, string notebookRuntimeTemplateId) =>
            s_projectLocationNotebookRuntimeTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(notebookRuntimeTemplateId, nameof(notebookRuntimeTemplateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NotebookRuntimeTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="notebookRuntimeTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NotebookRuntimeTemplateName"/> if successful.</returns>
        public static NotebookRuntimeTemplateName Parse(string notebookRuntimeTemplateName) =>
            Parse(notebookRuntimeTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NotebookRuntimeTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notebookRuntimeTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NotebookRuntimeTemplateName"/> if successful.</returns>
        public static NotebookRuntimeTemplateName Parse(string notebookRuntimeTemplateName, bool allowUnparsed) =>
            TryParse(notebookRuntimeTemplateName, allowUnparsed, out NotebookRuntimeTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotebookRuntimeTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="notebookRuntimeTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotebookRuntimeTemplateName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notebookRuntimeTemplateName, out NotebookRuntimeTemplateName result) =>
            TryParse(notebookRuntimeTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotebookRuntimeTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notebookRuntimeTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotebookRuntimeTemplateName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notebookRuntimeTemplateName, bool allowUnparsed, out NotebookRuntimeTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(notebookRuntimeTemplateName, nameof(notebookRuntimeTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNotebookRuntimeTemplate.TryParseName(notebookRuntimeTemplateName, out resourceName))
            {
                result = FromProjectLocationNotebookRuntimeTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(notebookRuntimeTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NotebookRuntimeTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string notebookRuntimeTemplateId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NotebookRuntimeTemplateId = notebookRuntimeTemplateId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NotebookRuntimeTemplateName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notebookRuntimeTemplateId">
        /// The <c>NotebookRuntimeTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public NotebookRuntimeTemplateName(string projectId, string locationId, string notebookRuntimeTemplateId) : this(ResourceNameType.ProjectLocationNotebookRuntimeTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), notebookRuntimeTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(notebookRuntimeTemplateId, nameof(notebookRuntimeTemplateId)))
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
        /// The <c>NotebookRuntimeTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string NotebookRuntimeTemplateId { get; }

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
                case ResourceNameType.ProjectLocationNotebookRuntimeTemplate: return s_projectLocationNotebookRuntimeTemplate.Expand(ProjectId, LocationId, NotebookRuntimeTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NotebookRuntimeTemplateName);

        /// <inheritdoc/>
        public bool Equals(NotebookRuntimeTemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NotebookRuntimeTemplateName a, NotebookRuntimeTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NotebookRuntimeTemplateName a, NotebookRuntimeTemplateName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>NotebookRuntime</c> resource.</summary>
    public sealed partial class NotebookRuntimeName : gax::IResourceName, sys::IEquatable<NotebookRuntimeName>
    {
        /// <summary>The possible contents of <see cref="NotebookRuntimeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/notebookRuntimes/{notebook_runtime}</c>.
            /// </summary>
            ProjectLocationNotebookRuntime = 1,
        }

        private static gax::PathTemplate s_projectLocationNotebookRuntime = new gax::PathTemplate("projects/{project}/locations/{location}/notebookRuntimes/{notebook_runtime}");

        /// <summary>Creates a <see cref="NotebookRuntimeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NotebookRuntimeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NotebookRuntimeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NotebookRuntimeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NotebookRuntimeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/notebookRuntimes/{notebook_runtime}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notebookRuntimeId">The <c>NotebookRuntime</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NotebookRuntimeName"/> constructed from the provided ids.</returns>
        public static NotebookRuntimeName FromProjectLocationNotebookRuntime(string projectId, string locationId, string notebookRuntimeId) =>
            new NotebookRuntimeName(ResourceNameType.ProjectLocationNotebookRuntime, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), notebookRuntimeId: gax::GaxPreconditions.CheckNotNullOrEmpty(notebookRuntimeId, nameof(notebookRuntimeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotebookRuntimeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/notebookRuntimes/{notebook_runtime}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notebookRuntimeId">The <c>NotebookRuntime</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NotebookRuntimeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/notebookRuntimes/{notebook_runtime}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string notebookRuntimeId) =>
            FormatProjectLocationNotebookRuntime(projectId, locationId, notebookRuntimeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotebookRuntimeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/notebookRuntimes/{notebook_runtime}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notebookRuntimeId">The <c>NotebookRuntime</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NotebookRuntimeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/notebookRuntimes/{notebook_runtime}</c>.
        /// </returns>
        public static string FormatProjectLocationNotebookRuntime(string projectId, string locationId, string notebookRuntimeId) =>
            s_projectLocationNotebookRuntime.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(notebookRuntimeId, nameof(notebookRuntimeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NotebookRuntimeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/notebookRuntimes/{notebook_runtime}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="notebookRuntimeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NotebookRuntimeName"/> if successful.</returns>
        public static NotebookRuntimeName Parse(string notebookRuntimeName) => Parse(notebookRuntimeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NotebookRuntimeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/notebookRuntimes/{notebook_runtime}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notebookRuntimeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NotebookRuntimeName"/> if successful.</returns>
        public static NotebookRuntimeName Parse(string notebookRuntimeName, bool allowUnparsed) =>
            TryParse(notebookRuntimeName, allowUnparsed, out NotebookRuntimeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotebookRuntimeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/notebookRuntimes/{notebook_runtime}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="notebookRuntimeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotebookRuntimeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notebookRuntimeName, out NotebookRuntimeName result) =>
            TryParse(notebookRuntimeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotebookRuntimeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/notebookRuntimes/{notebook_runtime}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notebookRuntimeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotebookRuntimeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notebookRuntimeName, bool allowUnparsed, out NotebookRuntimeName result)
        {
            gax::GaxPreconditions.CheckNotNull(notebookRuntimeName, nameof(notebookRuntimeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNotebookRuntime.TryParseName(notebookRuntimeName, out resourceName))
            {
                result = FromProjectLocationNotebookRuntime(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(notebookRuntimeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NotebookRuntimeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string notebookRuntimeId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NotebookRuntimeId = notebookRuntimeId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NotebookRuntimeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/notebookRuntimes/{notebook_runtime}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notebookRuntimeId">The <c>NotebookRuntime</c> ID. Must not be <c>null</c> or empty.</param>
        public NotebookRuntimeName(string projectId, string locationId, string notebookRuntimeId) : this(ResourceNameType.ProjectLocationNotebookRuntime, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), notebookRuntimeId: gax::GaxPreconditions.CheckNotNullOrEmpty(notebookRuntimeId, nameof(notebookRuntimeId)))
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
        /// The <c>NotebookRuntime</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string NotebookRuntimeId { get; }

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
                case ResourceNameType.ProjectLocationNotebookRuntime: return s_projectLocationNotebookRuntime.Expand(ProjectId, LocationId, NotebookRuntimeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NotebookRuntimeName);

        /// <inheritdoc/>
        public bool Equals(NotebookRuntimeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NotebookRuntimeName a, NotebookRuntimeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NotebookRuntimeName a, NotebookRuntimeName b) => !(a == b);
    }

    public partial class NotebookRuntimeTemplate
    {
        /// <summary>
        /// <see cref="gcav::NotebookRuntimeTemplateName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::NotebookRuntimeTemplateName NotebookRuntimeTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NotebookRuntimeTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class NotebookRuntime
    {
        /// <summary>
        /// <see cref="gcav::NotebookRuntimeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NotebookRuntimeName NotebookRuntimeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NotebookRuntimeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

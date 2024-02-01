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
using gcav = Google.Cloud.ArtifactRegistry.V1;
using sys = System;

namespace Google.Cloud.ArtifactRegistry.V1
{
    /// <summary>Resource name for the <c>File</c> resource.</summary>
    public sealed partial class FileName : gax::IResourceName, sys::IEquatable<FileName>
    {
        /// <summary>The possible contents of <see cref="FileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/files/{file}</c>.
            /// </summary>
            ProjectLocationRepositoryFile = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryFile = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/files/{file}");

        /// <summary>Creates a <see cref="FileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FileName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FileName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/files/{file}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileId">The <c>File</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FileName"/> constructed from the provided ids.</returns>
        public static FileName FromProjectLocationRepositoryFile(string projectId, string locationId, string repositoryId, string fileId) =>
            new FileName(ResourceNameType.ProjectLocationRepositoryFile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), fileId: gax::GaxPreconditions.CheckNotNullOrEmpty(fileId, nameof(fileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/files/{file}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileId">The <c>File</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/files/{file}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string fileId) =>
            FormatProjectLocationRepositoryFile(projectId, locationId, repositoryId, fileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/files/{file}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileId">The <c>File</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/files/{file}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryFile(string projectId, string locationId, string repositoryId, string fileId) =>
            s_projectLocationRepositoryFile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fileId, nameof(fileId)));

        /// <summary>Parses the given resource name string into a new <see cref="FileName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/files/{file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FileName"/> if successful.</returns>
        public static FileName Parse(string fileName) => Parse(fileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FileName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/files/{file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FileName"/> if successful.</returns>
        public static FileName Parse(string fileName, bool allowUnparsed) =>
            TryParse(fileName, allowUnparsed, out FileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="FileName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/files/{file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fileName, out FileName result) => TryParse(fileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/files/{file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fileName, bool allowUnparsed, out FileName result)
        {
            gax::GaxPreconditions.CheckNotNull(fileName, nameof(fileName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryFile.TryParseName(fileName, out resourceName))
            {
                result = FromProjectLocationRepositoryFile(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(fileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string fileId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FileId = fileId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FileName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/files/{file}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileId">The <c>File</c> ID. Must not be <c>null</c> or empty.</param>
        public FileName(string projectId, string locationId, string repositoryId, string fileId) : this(ResourceNameType.ProjectLocationRepositoryFile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), fileId: gax::GaxPreconditions.CheckNotNullOrEmpty(fileId, nameof(fileId)))
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
        /// The <c>File</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FileId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Repository</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RepositoryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRepositoryFile: return s_projectLocationRepositoryFile.Expand(ProjectId, LocationId, RepositoryId, FileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FileName);

        /// <inheritdoc/>
        public bool Equals(FileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FileName a, FileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FileName a, FileName b) => !(a == b);
    }

    public partial class File
    {
        /// <summary>
        /// <see cref="gcav::FileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FileName FileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFilesRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFileRequest
    {
        /// <summary>
        /// <see cref="gcav::FileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FileName FileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

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
using gcav = Google.Cloud.AIPlatform.V1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Resource name for the <c>SavedQuery</c> resource.</summary>
    public sealed partial class SavedQueryName : gax::IResourceName, sys::IEquatable<SavedQueryName>
    {
        /// <summary>The possible contents of <see cref="SavedQueryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/datasets/{dataset}/savedQueries/{saved_query}</c>.
            /// </summary>
            ProjectLocationDatasetSavedQuery = 1,
        }

        private static gax::PathTemplate s_projectLocationDatasetSavedQuery = new gax::PathTemplate("projects/{project}/locations/{location}/datasets/{dataset}/savedQueries/{saved_query}");

        /// <summary>Creates a <see cref="SavedQueryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SavedQueryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SavedQueryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SavedQueryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SavedQueryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/savedQueries/{saved_query}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="savedQueryId">The <c>SavedQuery</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SavedQueryName"/> constructed from the provided ids.</returns>
        public static SavedQueryName FromProjectLocationDatasetSavedQuery(string projectId, string locationId, string datasetId, string savedQueryId) =>
            new SavedQueryName(ResourceNameType.ProjectLocationDatasetSavedQuery, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), savedQueryId: gax::GaxPreconditions.CheckNotNullOrEmpty(savedQueryId, nameof(savedQueryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SavedQueryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/savedQueries/{saved_query}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="savedQueryId">The <c>SavedQuery</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SavedQueryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/savedQueries/{saved_query}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string datasetId, string savedQueryId) =>
            FormatProjectLocationDatasetSavedQuery(projectId, locationId, datasetId, savedQueryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SavedQueryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/savedQueries/{saved_query}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="savedQueryId">The <c>SavedQuery</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SavedQueryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/savedQueries/{saved_query}</c>.
        /// </returns>
        public static string FormatProjectLocationDatasetSavedQuery(string projectId, string locationId, string datasetId, string savedQueryId) =>
            s_projectLocationDatasetSavedQuery.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(savedQueryId, nameof(savedQueryId)));

        /// <summary>Parses the given resource name string into a new <see cref="SavedQueryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/savedQueries/{saved_query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="savedQueryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SavedQueryName"/> if successful.</returns>
        public static SavedQueryName Parse(string savedQueryName) => Parse(savedQueryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SavedQueryName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/savedQueries/{saved_query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="savedQueryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SavedQueryName"/> if successful.</returns>
        public static SavedQueryName Parse(string savedQueryName, bool allowUnparsed) =>
            TryParse(savedQueryName, allowUnparsed, out SavedQueryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SavedQueryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/savedQueries/{saved_query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="savedQueryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SavedQueryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string savedQueryName, out SavedQueryName result) =>
            TryParse(savedQueryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SavedQueryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/savedQueries/{saved_query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="savedQueryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SavedQueryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string savedQueryName, bool allowUnparsed, out SavedQueryName result)
        {
            gax::GaxPreconditions.CheckNotNull(savedQueryName, nameof(savedQueryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDatasetSavedQuery.TryParseName(savedQueryName, out resourceName))
            {
                result = FromProjectLocationDatasetSavedQuery(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(savedQueryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SavedQueryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string locationId = null, string projectId = null, string savedQueryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            LocationId = locationId;
            ProjectId = projectId;
            SavedQueryId = savedQueryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SavedQueryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/savedQueries/{saved_query}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="savedQueryId">The <c>SavedQuery</c> ID. Must not be <c>null</c> or empty.</param>
        public SavedQueryName(string projectId, string locationId, string datasetId, string savedQueryId) : this(ResourceNameType.ProjectLocationDatasetSavedQuery, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), savedQueryId: gax::GaxPreconditions.CheckNotNullOrEmpty(savedQueryId, nameof(savedQueryId)))
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
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>SavedQuery</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SavedQueryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDatasetSavedQuery: return s_projectLocationDatasetSavedQuery.Expand(ProjectId, LocationId, DatasetId, SavedQueryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SavedQueryName);

        /// <inheritdoc/>
        public bool Equals(SavedQueryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SavedQueryName a, SavedQueryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SavedQueryName a, SavedQueryName b) => !(a == b);
    }

    public partial class SavedQuery
    {
        /// <summary>
        /// <see cref="gcav::SavedQueryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SavedQueryName SavedQueryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SavedQueryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

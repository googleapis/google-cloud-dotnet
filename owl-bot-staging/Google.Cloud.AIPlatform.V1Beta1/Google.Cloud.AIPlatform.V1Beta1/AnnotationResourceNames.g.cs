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
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>Annotation</c> resource.</summary>
    public sealed partial class AnnotationName : gax::IResourceName, sys::IEquatable<AnnotationName>
    {
        /// <summary>The possible contents of <see cref="AnnotationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}/annotations/{annotation}</c>
            /// .
            /// </summary>
            ProjectLocationDatasetDataItemAnnotation = 1,
        }

        private static gax::PathTemplate s_projectLocationDatasetDataItemAnnotation = new gax::PathTemplate("projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}/annotations/{annotation}");

        /// <summary>Creates a <see cref="AnnotationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AnnotationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AnnotationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AnnotationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AnnotationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}/annotations/{annotation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataItemId">The <c>DataItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationId">The <c>Annotation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnnotationName"/> constructed from the provided ids.</returns>
        public static AnnotationName FromProjectLocationDatasetDataItemAnnotation(string projectId, string locationId, string datasetId, string dataItemId, string annotationId) =>
            new AnnotationName(ResourceNameType.ProjectLocationDatasetDataItemAnnotation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), dataItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataItemId, nameof(dataItemId)), annotationId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotationId, nameof(annotationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnnotationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}/annotations/{annotation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataItemId">The <c>DataItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationId">The <c>Annotation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnnotationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}/annotations/{annotation}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string datasetId, string dataItemId, string annotationId) =>
            FormatProjectLocationDatasetDataItemAnnotation(projectId, locationId, datasetId, dataItemId, annotationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnnotationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}/annotations/{annotation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataItemId">The <c>DataItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationId">The <c>Annotation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnnotationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}/annotations/{annotation}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationDatasetDataItemAnnotation(string projectId, string locationId, string datasetId, string dataItemId, string annotationId) =>
            s_projectLocationDatasetDataItemAnnotation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataItemId, nameof(dataItemId)), gax::GaxPreconditions.CheckNotNullOrEmpty(annotationId, nameof(annotationId)));

        /// <summary>Parses the given resource name string into a new <see cref="AnnotationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}/annotations/{annotation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="annotationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnnotationName"/> if successful.</returns>
        public static AnnotationName Parse(string annotationName) => Parse(annotationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnnotationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}/annotations/{annotation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="annotationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AnnotationName"/> if successful.</returns>
        public static AnnotationName Parse(string annotationName, bool allowUnparsed) =>
            TryParse(annotationName, allowUnparsed, out AnnotationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnnotationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}/annotations/{annotation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="annotationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnnotationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string annotationName, out AnnotationName result) =>
            TryParse(annotationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnnotationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}/annotations/{annotation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="annotationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnnotationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string annotationName, bool allowUnparsed, out AnnotationName result)
        {
            gax::GaxPreconditions.CheckNotNull(annotationName, nameof(annotationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDatasetDataItemAnnotation.TryParseName(annotationName, out resourceName))
            {
                result = FromProjectLocationDatasetDataItemAnnotation(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(annotationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AnnotationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string annotationId = null, string dataItemId = null, string datasetId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnnotationId = annotationId;
            DataItemId = dataItemId;
            DatasetId = datasetId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnnotationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}/annotations/{annotation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataItemId">The <c>DataItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationId">The <c>Annotation</c> ID. Must not be <c>null</c> or empty.</param>
        public AnnotationName(string projectId, string locationId, string datasetId, string dataItemId, string annotationId) : this(ResourceNameType.ProjectLocationDatasetDataItemAnnotation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), dataItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataItemId, nameof(dataItemId)), annotationId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotationId, nameof(annotationId)))
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
        /// The <c>Annotation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AnnotationId { get; }

        /// <summary>
        /// The <c>DataItem</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataItemId { get; }

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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDatasetDataItemAnnotation: return s_projectLocationDatasetDataItemAnnotation.Expand(ProjectId, LocationId, DatasetId, DataItemId, AnnotationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AnnotationName);

        /// <inheritdoc/>
        public bool Equals(AnnotationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AnnotationName a, AnnotationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AnnotationName a, AnnotationName b) => !(a == b);
    }

    public partial class Annotation
    {
        /// <summary>
        /// <see cref="gcav::AnnotationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AnnotationName AnnotationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AnnotationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

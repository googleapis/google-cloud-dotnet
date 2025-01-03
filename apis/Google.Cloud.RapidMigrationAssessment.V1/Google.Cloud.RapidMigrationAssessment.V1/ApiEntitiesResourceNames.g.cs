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
using gcrv = Google.Cloud.RapidMigrationAssessment.V1;
using sys = System;

namespace Google.Cloud.RapidMigrationAssessment.V1
{
    /// <summary>Resource name for the <c>Collector</c> resource.</summary>
    public sealed partial class CollectorName : gax::IResourceName, sys::IEquatable<CollectorName>
    {
        /// <summary>The possible contents of <see cref="CollectorName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/collectors/{collector}</c>.
            /// </summary>
            ProjectLocationCollector = 1,
        }

        private static gax::PathTemplate s_projectLocationCollector = new gax::PathTemplate("projects/{project}/locations/{location}/collectors/{collector}");

        /// <summary>Creates a <see cref="CollectorName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CollectorName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CollectorName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CollectorName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CollectorName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/collectors/{collector}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectorId">The <c>Collector</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CollectorName"/> constructed from the provided ids.</returns>
        public static CollectorName FromProjectLocationCollector(string projectId, string locationId, string collectorId) =>
            new CollectorName(ResourceNameType.ProjectLocationCollector, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectorId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectorId, nameof(collectorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CollectorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collectors/{collector}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectorId">The <c>Collector</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CollectorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collectors/{collector}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string collectorId) =>
            FormatProjectLocationCollector(projectId, locationId, collectorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CollectorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collectors/{collector}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectorId">The <c>Collector</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CollectorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collectors/{collector}</c>.
        /// </returns>
        public static string FormatProjectLocationCollector(string projectId, string locationId, string collectorId) =>
            s_projectLocationCollector.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectorId, nameof(collectorId)));

        /// <summary>Parses the given resource name string into a new <see cref="CollectorName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/collectors/{collector}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="collectorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CollectorName"/> if successful.</returns>
        public static CollectorName Parse(string collectorName) => Parse(collectorName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CollectorName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/collectors/{collector}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="collectorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CollectorName"/> if successful.</returns>
        public static CollectorName Parse(string collectorName, bool allowUnparsed) =>
            TryParse(collectorName, allowUnparsed, out CollectorName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CollectorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/collectors/{collector}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="collectorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CollectorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string collectorName, out CollectorName result) => TryParse(collectorName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CollectorName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/collectors/{collector}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="collectorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CollectorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string collectorName, bool allowUnparsed, out CollectorName result)
        {
            gax::GaxPreconditions.CheckNotNull(collectorName, nameof(collectorName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCollector.TryParseName(collectorName, out resourceName))
            {
                result = FromProjectLocationCollector(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(collectorName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CollectorName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectorId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectorId = collectorId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CollectorName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/collectors/{collector}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectorId">The <c>Collector</c> ID. Must not be <c>null</c> or empty.</param>
        public CollectorName(string projectId, string locationId, string collectorId) : this(ResourceNameType.ProjectLocationCollector, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectorId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectorId, nameof(collectorId)))
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
        /// The <c>Collector</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CollectorId { get; }

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
                case ResourceNameType.ProjectLocationCollector: return s_projectLocationCollector.Expand(ProjectId, LocationId, CollectorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CollectorName);

        /// <inheritdoc/>
        public bool Equals(CollectorName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CollectorName a, CollectorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CollectorName a, CollectorName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Annotation</c> resource.</summary>
    public sealed partial class AnnotationName : gax::IResourceName, sys::IEquatable<AnnotationName>
    {
        /// <summary>The possible contents of <see cref="AnnotationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/annotations/{annotation}</c>.
            /// </summary>
            ProjectLocationAnnotation = 1,
        }

        private static gax::PathTemplate s_projectLocationAnnotation = new gax::PathTemplate("projects/{project}/locations/{location}/annotations/{annotation}");

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
        /// <c>projects/{project}/locations/{location}/annotations/{annotation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationId">The <c>Annotation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnnotationName"/> constructed from the provided ids.</returns>
        public static AnnotationName FromProjectLocationAnnotation(string projectId, string locationId, string annotationId) =>
            new AnnotationName(ResourceNameType.ProjectLocationAnnotation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), annotationId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotationId, nameof(annotationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnnotationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/annotations/{annotation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationId">The <c>Annotation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnnotationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/annotations/{annotation}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string annotationId) =>
            FormatProjectLocationAnnotation(projectId, locationId, annotationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnnotationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/annotations/{annotation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationId">The <c>Annotation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnnotationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/annotations/{annotation}</c>.
        /// </returns>
        public static string FormatProjectLocationAnnotation(string projectId, string locationId, string annotationId) =>
            s_projectLocationAnnotation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(annotationId, nameof(annotationId)));

        /// <summary>Parses the given resource name string into a new <see cref="AnnotationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/annotations/{annotation}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/annotations/{annotation}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/annotations/{annotation}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/annotations/{annotation}</c></description>
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
            if (s_projectLocationAnnotation.TryParseName(annotationName, out resourceName))
            {
                result = FromProjectLocationAnnotation(resourceName[0], resourceName[1], resourceName[2]);
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

        private AnnotationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string annotationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnnotationId = annotationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnnotationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/annotations/{annotation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationId">The <c>Annotation</c> ID. Must not be <c>null</c> or empty.</param>
        public AnnotationName(string projectId, string locationId, string annotationId) : this(ResourceNameType.ProjectLocationAnnotation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), annotationId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotationId, nameof(annotationId)))
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
                case ResourceNameType.ProjectLocationAnnotation: return s_projectLocationAnnotation.Expand(ProjectId, LocationId, AnnotationId);
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

    public partial class Collector
    {
        /// <summary>
        /// <see cref="gcrv::CollectorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::CollectorName CollectorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::CollectorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Annotation
    {
        /// <summary>
        /// <see cref="gcrv::AnnotationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::AnnotationName AnnotationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::AnnotationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

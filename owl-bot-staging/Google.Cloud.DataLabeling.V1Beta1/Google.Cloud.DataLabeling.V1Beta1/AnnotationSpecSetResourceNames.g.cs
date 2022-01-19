// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gcdv = Google.Cloud.DataLabeling.V1Beta1;
using sys = System;

namespace Google.Cloud.DataLabeling.V1Beta1
{
    /// <summary>Resource name for the <c>AnnotationSpecSet</c> resource.</summary>
    public sealed partial class AnnotationSpecSetName : gax::IResourceName, sys::IEquatable<AnnotationSpecSetName>
    {
        /// <summary>The possible contents of <see cref="AnnotationSpecSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/annotationSpecSets/{annotation_spec_set}</c>.
            /// </summary>
            ProjectAnnotationSpecSet = 1,
        }

        private static gax::PathTemplate s_projectAnnotationSpecSet = new gax::PathTemplate("projects/{project}/annotationSpecSets/{annotation_spec_set}");

        /// <summary>Creates a <see cref="AnnotationSpecSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AnnotationSpecSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AnnotationSpecSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AnnotationSpecSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AnnotationSpecSetName"/> with the pattern
        /// <c>projects/{project}/annotationSpecSets/{annotation_spec_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationSpecSetId">The <c>AnnotationSpecSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnnotationSpecSetName"/> constructed from the provided ids.</returns>
        public static AnnotationSpecSetName FromProjectAnnotationSpecSet(string projectId, string annotationSpecSetId) =>
            new AnnotationSpecSetName(ResourceNameType.ProjectAnnotationSpecSet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), annotationSpecSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotationSpecSetId, nameof(annotationSpecSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnnotationSpecSetName"/> with pattern
        /// <c>projects/{project}/annotationSpecSets/{annotation_spec_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationSpecSetId">The <c>AnnotationSpecSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnnotationSpecSetName"/> with pattern
        /// <c>projects/{project}/annotationSpecSets/{annotation_spec_set}</c>.
        /// </returns>
        public static string Format(string projectId, string annotationSpecSetId) =>
            FormatProjectAnnotationSpecSet(projectId, annotationSpecSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnnotationSpecSetName"/> with pattern
        /// <c>projects/{project}/annotationSpecSets/{annotation_spec_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationSpecSetId">The <c>AnnotationSpecSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnnotationSpecSetName"/> with pattern
        /// <c>projects/{project}/annotationSpecSets/{annotation_spec_set}</c>.
        /// </returns>
        public static string FormatProjectAnnotationSpecSet(string projectId, string annotationSpecSetId) =>
            s_projectAnnotationSpecSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(annotationSpecSetId, nameof(annotationSpecSetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnnotationSpecSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/annotationSpecSets/{annotation_spec_set}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="annotationSpecSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnnotationSpecSetName"/> if successful.</returns>
        public static AnnotationSpecSetName Parse(string annotationSpecSetName) => Parse(annotationSpecSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnnotationSpecSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/annotationSpecSets/{annotation_spec_set}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="annotationSpecSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AnnotationSpecSetName"/> if successful.</returns>
        public static AnnotationSpecSetName Parse(string annotationSpecSetName, bool allowUnparsed) =>
            TryParse(annotationSpecSetName, allowUnparsed, out AnnotationSpecSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnnotationSpecSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/annotationSpecSets/{annotation_spec_set}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="annotationSpecSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnnotationSpecSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string annotationSpecSetName, out AnnotationSpecSetName result) =>
            TryParse(annotationSpecSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnnotationSpecSetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/annotationSpecSets/{annotation_spec_set}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="annotationSpecSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnnotationSpecSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string annotationSpecSetName, bool allowUnparsed, out AnnotationSpecSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(annotationSpecSetName, nameof(annotationSpecSetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectAnnotationSpecSet.TryParseName(annotationSpecSetName, out resourceName))
            {
                result = FromProjectAnnotationSpecSet(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(annotationSpecSetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AnnotationSpecSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string annotationSpecSetId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnnotationSpecSetId = annotationSpecSetId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnnotationSpecSetName"/> class from the component parts of pattern
        /// <c>projects/{project}/annotationSpecSets/{annotation_spec_set}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationSpecSetId">The <c>AnnotationSpecSet</c> ID. Must not be <c>null</c> or empty.</param>
        public AnnotationSpecSetName(string projectId, string annotationSpecSetId) : this(ResourceNameType.ProjectAnnotationSpecSet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), annotationSpecSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotationSpecSetId, nameof(annotationSpecSetId)))
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
        /// The <c>AnnotationSpecSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AnnotationSpecSetId { get; }

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
                case ResourceNameType.ProjectAnnotationSpecSet: return s_projectAnnotationSpecSet.Expand(ProjectId, AnnotationSpecSetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AnnotationSpecSetName);

        /// <inheritdoc/>
        public bool Equals(AnnotationSpecSetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AnnotationSpecSetName a, AnnotationSpecSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AnnotationSpecSetName a, AnnotationSpecSetName b) => !(a == b);
    }

    public partial class AnnotationSpecSet
    {
        /// <summary>
        /// <see cref="gcdv::AnnotationSpecSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AnnotationSpecSetName AnnotationSpecSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AnnotationSpecSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

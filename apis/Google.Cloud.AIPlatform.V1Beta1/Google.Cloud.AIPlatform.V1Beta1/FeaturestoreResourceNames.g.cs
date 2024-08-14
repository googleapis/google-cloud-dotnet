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
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>Featurestore</c> resource.</summary>
    public sealed partial class FeaturestoreName : gax::IResourceName, sys::IEquatable<FeaturestoreName>
    {
        /// <summary>The possible contents of <see cref="FeaturestoreName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/featurestores/{featurestore}</c>
            /// .
            /// </summary>
            ProjectLocationFeaturestore = 1,
        }

        private static gax::PathTemplate s_projectLocationFeaturestore = new gax::PathTemplate("projects/{project}/locations/{location}/featurestores/{featurestore}");

        /// <summary>Creates a <see cref="FeaturestoreName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeaturestoreName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FeaturestoreName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeaturestoreName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeaturestoreName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featurestoreId">The <c>Featurestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FeaturestoreName"/> constructed from the provided ids.</returns>
        public static FeaturestoreName FromProjectLocationFeaturestore(string projectId, string locationId, string featurestoreId) =>
            new FeaturestoreName(ResourceNameType.ProjectLocationFeaturestore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), featurestoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(featurestoreId, nameof(featurestoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeaturestoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featurestoreId">The <c>Featurestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeaturestoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string featurestoreId) =>
            FormatProjectLocationFeaturestore(projectId, locationId, featurestoreId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeaturestoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featurestoreId">The <c>Featurestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeaturestoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}</c>.
        /// </returns>
        public static string FormatProjectLocationFeaturestore(string projectId, string locationId, string featurestoreId) =>
            s_projectLocationFeaturestore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(featurestoreId, nameof(featurestoreId)));

        /// <summary>Parses the given resource name string into a new <see cref="FeaturestoreName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/featurestores/{featurestore}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="featurestoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeaturestoreName"/> if successful.</returns>
        public static FeaturestoreName Parse(string featurestoreName) => Parse(featurestoreName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeaturestoreName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/featurestores/{featurestore}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="featurestoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeaturestoreName"/> if successful.</returns>
        public static FeaturestoreName Parse(string featurestoreName, bool allowUnparsed) =>
            TryParse(featurestoreName, allowUnparsed, out FeaturestoreName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeaturestoreName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/featurestores/{featurestore}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="featurestoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeaturestoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string featurestoreName, out FeaturestoreName result) =>
            TryParse(featurestoreName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeaturestoreName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/featurestores/{featurestore}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="featurestoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeaturestoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string featurestoreName, bool allowUnparsed, out FeaturestoreName result)
        {
            gax::GaxPreconditions.CheckNotNull(featurestoreName, nameof(featurestoreName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFeaturestore.TryParseName(featurestoreName, out resourceName))
            {
                result = FromProjectLocationFeaturestore(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(featurestoreName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FeaturestoreName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string featurestoreId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FeaturestoreId = featurestoreId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeaturestoreName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featurestoreId">The <c>Featurestore</c> ID. Must not be <c>null</c> or empty.</param>
        public FeaturestoreName(string projectId, string locationId, string featurestoreId) : this(ResourceNameType.ProjectLocationFeaturestore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), featurestoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(featurestoreId, nameof(featurestoreId)))
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
        /// The <c>Featurestore</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string FeaturestoreId { get; }

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
                case ResourceNameType.ProjectLocationFeaturestore: return s_projectLocationFeaturestore.Expand(ProjectId, LocationId, FeaturestoreId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeaturestoreName);

        /// <inheritdoc/>
        public bool Equals(FeaturestoreName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FeaturestoreName a, FeaturestoreName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FeaturestoreName a, FeaturestoreName b) => !(a == b);
    }

    public partial class Featurestore
    {
        /// <summary>
        /// <see cref="gcav::FeaturestoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeaturestoreName FeaturestoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeaturestoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

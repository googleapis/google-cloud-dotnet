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
    /// <summary>Resource name for the <c>Feature</c> resource.</summary>
    public sealed partial class FeatureName : gax::IResourceName, sys::IEquatable<FeatureName>
    {
        /// <summary>The possible contents of <see cref="FeatureName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}</c>
            /// .
            /// </summary>
            ProjectLocationFeaturestoreEntityTypeFeature = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}</c>.
            /// </summary>
            ProjectLocationFeatureGroupFeature = 2,
        }

        private static gax::PathTemplate s_projectLocationFeaturestoreEntityTypeFeature = new gax::PathTemplate("projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}");

        private static gax::PathTemplate s_projectLocationFeatureGroupFeature = new gax::PathTemplate("projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}");

        /// <summary>Creates a <see cref="FeatureName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeatureName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FeatureName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeatureName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeatureName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featurestoreId">The <c>Featurestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureId">The <c>Feature</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FeatureName"/> constructed from the provided ids.</returns>
        public static FeatureName FromProjectLocationFeaturestoreEntityTypeFeature(string projectId, string locationId, string featurestoreId, string entityTypeId, string featureId) =>
            new FeatureName(ResourceNameType.ProjectLocationFeaturestoreEntityTypeFeature, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), featurestoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(featurestoreId, nameof(featurestoreId)), entityTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)), featureId: gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)));

        /// <summary>
        /// Creates a <see cref="FeatureName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureGroupId">The <c>FeatureGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureId">The <c>Feature</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FeatureName"/> constructed from the provided ids.</returns>
        public static FeatureName FromProjectLocationFeatureGroupFeature(string projectId, string locationId, string featureGroupId, string featureId) =>
            new FeatureName(ResourceNameType.ProjectLocationFeatureGroupFeature, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), featureGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(featureGroupId, nameof(featureGroupId)), featureId: gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeatureName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featurestoreId">The <c>Featurestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureId">The <c>Feature</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeatureName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string featurestoreId, string entityTypeId, string featureId) =>
            FormatProjectLocationFeaturestoreEntityTypeFeature(projectId, locationId, featurestoreId, entityTypeId, featureId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeatureName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featurestoreId">The <c>Featurestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureId">The <c>Feature</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeatureName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationFeaturestoreEntityTypeFeature(string projectId, string locationId, string featurestoreId, string entityTypeId, string featureId) =>
            s_projectLocationFeaturestoreEntityTypeFeature.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(featurestoreId, nameof(featurestoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeatureName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureGroupId">The <c>FeatureGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureId">The <c>Feature</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeatureName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}</c>.
        /// </returns>
        public static string FormatProjectLocationFeatureGroupFeature(string projectId, string locationId, string featureGroupId, string featureId) =>
            s_projectLocationFeatureGroupFeature.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(featureGroupId, nameof(featureGroupId)), gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)));

        /// <summary>Parses the given resource name string into a new <see cref="FeatureName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="featureName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeatureName"/> if successful.</returns>
        public static FeatureName Parse(string featureName) => Parse(featureName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeatureName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="featureName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeatureName"/> if successful.</returns>
        public static FeatureName Parse(string featureName, bool allowUnparsed) =>
            TryParse(featureName, allowUnparsed, out FeatureName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeatureName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="featureName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeatureName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string featureName, out FeatureName result) => TryParse(featureName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeatureName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="featureName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeatureName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string featureName, bool allowUnparsed, out FeatureName result)
        {
            gax::GaxPreconditions.CheckNotNull(featureName, nameof(featureName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFeaturestoreEntityTypeFeature.TryParseName(featureName, out resourceName))
            {
                result = FromProjectLocationFeaturestoreEntityTypeFeature(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (s_projectLocationFeatureGroupFeature.TryParseName(featureName, out resourceName))
            {
                result = FromProjectLocationFeatureGroupFeature(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(featureName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FeatureName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entityTypeId = null, string featureId = null, string featureGroupId = null, string featurestoreId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntityTypeId = entityTypeId;
            FeatureId = featureId;
            FeatureGroupId = featureGroupId;
            FeaturestoreId = featurestoreId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeatureName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featurestoreId">The <c>Featurestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureId">The <c>Feature</c> ID. Must not be <c>null</c> or empty.</param>
        public FeatureName(string projectId, string locationId, string featurestoreId, string entityTypeId, string featureId) : this(ResourceNameType.ProjectLocationFeaturestoreEntityTypeFeature, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), featurestoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(featurestoreId, nameof(featurestoreId)), entityTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)), featureId: gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)))
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
        /// The <c>EntityType</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string EntityTypeId { get; }

        /// <summary>
        /// The <c>Feature</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FeatureId { get; }

        /// <summary>
        /// The <c>FeatureGroup</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string FeatureGroupId { get; }

        /// <summary>
        /// The <c>Featurestore</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string FeaturestoreId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectLocationFeaturestoreEntityTypeFeature: return s_projectLocationFeaturestoreEntityTypeFeature.Expand(ProjectId, LocationId, FeaturestoreId, EntityTypeId, FeatureId);
                case ResourceNameType.ProjectLocationFeatureGroupFeature: return s_projectLocationFeatureGroupFeature.Expand(ProjectId, LocationId, FeatureGroupId, FeatureId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeatureName);

        /// <inheritdoc/>
        public bool Equals(FeatureName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FeatureName a, FeatureName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FeatureName a, FeatureName b) => !(a == b);
    }

    public partial class Feature
    {
        /// <summary>
        /// <see cref="gcav::FeatureName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureName FeatureName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

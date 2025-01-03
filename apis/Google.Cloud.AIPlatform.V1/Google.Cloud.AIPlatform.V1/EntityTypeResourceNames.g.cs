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
    /// <summary>Resource name for the <c>EntityType</c> resource.</summary>
    public sealed partial class EntityTypeName : gax::IResourceName, sys::IEquatable<EntityTypeName>
    {
        /// <summary>The possible contents of <see cref="EntityTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}</c>.
            /// </summary>
            ProjectLocationFeaturestoreEntityType = 1,
        }

        private static gax::PathTemplate s_projectLocationFeaturestoreEntityType = new gax::PathTemplate("projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}");

        /// <summary>Creates a <see cref="EntityTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EntityTypeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EntityTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EntityTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EntityTypeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featurestoreId">The <c>Featurestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EntityTypeName"/> constructed from the provided ids.</returns>
        public static EntityTypeName FromProjectLocationFeaturestoreEntityType(string projectId, string locationId, string featurestoreId, string entityTypeId) =>
            new EntityTypeName(ResourceNameType.ProjectLocationFeaturestoreEntityType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), featurestoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(featurestoreId, nameof(featurestoreId)), entityTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntityTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featurestoreId">The <c>Featurestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntityTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string featurestoreId, string entityTypeId) =>
            FormatProjectLocationFeaturestoreEntityType(projectId, locationId, featurestoreId, entityTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntityTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featurestoreId">The <c>Featurestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntityTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}</c>.
        /// </returns>
        public static string FormatProjectLocationFeaturestoreEntityType(string projectId, string locationId, string featurestoreId, string entityTypeId) =>
            s_projectLocationFeaturestoreEntityType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(featurestoreId, nameof(featurestoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>Parses the given resource name string into a new <see cref="EntityTypeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entityTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EntityTypeName"/> if successful.</returns>
        public static EntityTypeName Parse(string entityTypeName) => Parse(entityTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EntityTypeName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entityTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EntityTypeName"/> if successful.</returns>
        public static EntityTypeName Parse(string entityTypeName, bool allowUnparsed) =>
            TryParse(entityTypeName, allowUnparsed, out EntityTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntityTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entityTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntityTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entityTypeName, out EntityTypeName result) =>
            TryParse(entityTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntityTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entityTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntityTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entityTypeName, bool allowUnparsed, out EntityTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(entityTypeName, nameof(entityTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFeaturestoreEntityType.TryParseName(entityTypeName, out resourceName))
            {
                result = FromProjectLocationFeaturestoreEntityType(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(entityTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EntityTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entityTypeId = null, string featurestoreId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntityTypeId = entityTypeId;
            FeaturestoreId = featurestoreId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EntityTypeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featurestoreId">The <c>Featurestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        public EntityTypeName(string projectId, string locationId, string featurestoreId, string entityTypeId) : this(ResourceNameType.ProjectLocationFeaturestoreEntityType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), featurestoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(featurestoreId, nameof(featurestoreId)), entityTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)))
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
        /// The <c>EntityType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EntityTypeId { get; }

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
                case ResourceNameType.ProjectLocationFeaturestoreEntityType: return s_projectLocationFeaturestoreEntityType.Expand(ProjectId, LocationId, FeaturestoreId, EntityTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EntityTypeName);

        /// <inheritdoc/>
        public bool Equals(EntityTypeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EntityTypeName a, EntityTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EntityTypeName a, EntityTypeName b) => !(a == b);
    }

    public partial class EntityType
    {
        /// <summary>
        /// <see cref="gcav::EntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::EntityTypeName EntityTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::EntityTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

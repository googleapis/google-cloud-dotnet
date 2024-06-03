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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcmv = Google.Cloud.MigrationCenter.V1;
using sys = System;

namespace Google.Cloud.MigrationCenter.V1
{
    /// <summary>Resource name for the <c>Asset</c> resource.</summary>
    public sealed partial class AssetName : gax::IResourceName, sys::IEquatable<AssetName>
    {
        /// <summary>The possible contents of <see cref="AssetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/assets/{asset}</c>.
            /// </summary>
            ProjectLocationAsset = 1,
        }

        private static gax::PathTemplate s_projectLocationAsset = new gax::PathTemplate("projects/{project}/locations/{location}/assets/{asset}");

        /// <summary>Creates a <see cref="AssetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssetName"/> with the pattern <c>projects/{project}/locations/{location}/assets/{asset}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssetName"/> constructed from the provided ids.</returns>
        public static AssetName FromProjectLocationAsset(string projectId, string locationId, string assetId) =>
            new AssetName(ResourceNameType.ProjectLocationAsset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/assets/{asset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/assets/{asset}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string assetId) =>
            FormatProjectLocationAsset(projectId, locationId, assetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/assets/{asset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/assets/{asset}</c>.
        /// </returns>
        public static string FormatProjectLocationAsset(string projectId, string locationId, string assetId) =>
            s_projectLocationAsset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>Parses the given resource name string into a new <see cref="AssetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/assets/{asset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssetName"/> if successful.</returns>
        public static AssetName Parse(string assetName) => Parse(assetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/assets/{asset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssetName"/> if successful.</returns>
        public static AssetName Parse(string assetName, bool allowUnparsed) =>
            TryParse(assetName, allowUnparsed, out AssetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/assets/{asset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetName, out AssetName result) => TryParse(assetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/assets/{asset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetName, bool allowUnparsed, out AssetName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetName, nameof(assetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAsset.TryParseName(assetName, out resourceName))
            {
                result = FromProjectLocationAsset(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AssetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetId = assetId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/assets/{asset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        public AssetName(string projectId, string locationId, string assetId) : this(ResourceNameType.ProjectLocationAsset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)))
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
        /// The <c>Asset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetId { get; }

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
                case ResourceNameType.ProjectLocationAsset: return s_projectLocationAsset.Expand(ProjectId, LocationId, AssetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssetName);

        /// <inheritdoc/>
        public bool Equals(AssetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AssetName a, AssetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AssetName a, AssetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PreferenceSet</c> resource.</summary>
    public sealed partial class PreferenceSetName : gax::IResourceName, sys::IEquatable<PreferenceSetName>
    {
        /// <summary>The possible contents of <see cref="PreferenceSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/preferenceSets/{preference_set}</c>
            /// .
            /// </summary>
            ProjectLocationPreferenceSet = 1,
        }

        private static gax::PathTemplate s_projectLocationPreferenceSet = new gax::PathTemplate("projects/{project}/locations/{location}/preferenceSets/{preference_set}");

        /// <summary>Creates a <see cref="PreferenceSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PreferenceSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PreferenceSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PreferenceSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PreferenceSetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/preferenceSets/{preference_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="preferenceSetId">The <c>PreferenceSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PreferenceSetName"/> constructed from the provided ids.</returns>
        public static PreferenceSetName FromProjectLocationPreferenceSet(string projectId, string locationId, string preferenceSetId) =>
            new PreferenceSetName(ResourceNameType.ProjectLocationPreferenceSet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), preferenceSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(preferenceSetId, nameof(preferenceSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PreferenceSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/preferenceSets/{preference_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="preferenceSetId">The <c>PreferenceSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PreferenceSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/preferenceSets/{preference_set}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string preferenceSetId) =>
            FormatProjectLocationPreferenceSet(projectId, locationId, preferenceSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PreferenceSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/preferenceSets/{preference_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="preferenceSetId">The <c>PreferenceSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PreferenceSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/preferenceSets/{preference_set}</c>.
        /// </returns>
        public static string FormatProjectLocationPreferenceSet(string projectId, string locationId, string preferenceSetId) =>
            s_projectLocationPreferenceSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(preferenceSetId, nameof(preferenceSetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PreferenceSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/preferenceSets/{preference_set}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="preferenceSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PreferenceSetName"/> if successful.</returns>
        public static PreferenceSetName Parse(string preferenceSetName) => Parse(preferenceSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PreferenceSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/preferenceSets/{preference_set}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="preferenceSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PreferenceSetName"/> if successful.</returns>
        public static PreferenceSetName Parse(string preferenceSetName, bool allowUnparsed) =>
            TryParse(preferenceSetName, allowUnparsed, out PreferenceSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PreferenceSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/preferenceSets/{preference_set}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="preferenceSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PreferenceSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string preferenceSetName, out PreferenceSetName result) =>
            TryParse(preferenceSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PreferenceSetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/preferenceSets/{preference_set}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="preferenceSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PreferenceSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string preferenceSetName, bool allowUnparsed, out PreferenceSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(preferenceSetName, nameof(preferenceSetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPreferenceSet.TryParseName(preferenceSetName, out resourceName))
            {
                result = FromProjectLocationPreferenceSet(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(preferenceSetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PreferenceSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string preferenceSetId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PreferenceSetId = preferenceSetId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PreferenceSetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/preferenceSets/{preference_set}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="preferenceSetId">The <c>PreferenceSet</c> ID. Must not be <c>null</c> or empty.</param>
        public PreferenceSetName(string projectId, string locationId, string preferenceSetId) : this(ResourceNameType.ProjectLocationPreferenceSet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), preferenceSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(preferenceSetId, nameof(preferenceSetId)))
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
        /// The <c>PreferenceSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PreferenceSetId { get; }

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
                case ResourceNameType.ProjectLocationPreferenceSet: return s_projectLocationPreferenceSet.Expand(ProjectId, LocationId, PreferenceSetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PreferenceSetName);

        /// <inheritdoc/>
        public bool Equals(PreferenceSetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PreferenceSetName a, PreferenceSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PreferenceSetName a, PreferenceSetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ImportJob</c> resource.</summary>
    public sealed partial class ImportJobName : gax::IResourceName, sys::IEquatable<ImportJobName>
    {
        /// <summary>The possible contents of <see cref="ImportJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/importJobs/{import_job}</c>.
            /// </summary>
            ProjectLocationImportJob = 1,
        }

        private static gax::PathTemplate s_projectLocationImportJob = new gax::PathTemplate("projects/{project}/locations/{location}/importJobs/{import_job}");

        /// <summary>Creates a <see cref="ImportJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ImportJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ImportJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ImportJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ImportJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="importJobId">The <c>ImportJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ImportJobName"/> constructed from the provided ids.</returns>
        public static ImportJobName FromProjectLocationImportJob(string projectId, string locationId, string importJobId) =>
            new ImportJobName(ResourceNameType.ProjectLocationImportJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), importJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(importJobId, nameof(importJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ImportJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="importJobId">The <c>ImportJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ImportJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string importJobId) =>
            FormatProjectLocationImportJob(projectId, locationId, importJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ImportJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="importJobId">The <c>ImportJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ImportJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}</c>.
        /// </returns>
        public static string FormatProjectLocationImportJob(string projectId, string locationId, string importJobId) =>
            s_projectLocationImportJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(importJobId, nameof(importJobId)));

        /// <summary>Parses the given resource name string into a new <see cref="ImportJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/importJobs/{import_job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="importJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ImportJobName"/> if successful.</returns>
        public static ImportJobName Parse(string importJobName) => Parse(importJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ImportJobName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/importJobs/{import_job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="importJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ImportJobName"/> if successful.</returns>
        public static ImportJobName Parse(string importJobName, bool allowUnparsed) =>
            TryParse(importJobName, allowUnparsed, out ImportJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ImportJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/importJobs/{import_job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="importJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ImportJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string importJobName, out ImportJobName result) => TryParse(importJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ImportJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/importJobs/{import_job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="importJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ImportJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string importJobName, bool allowUnparsed, out ImportJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(importJobName, nameof(importJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationImportJob.TryParseName(importJobName, out resourceName))
            {
                result = FromProjectLocationImportJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(importJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ImportJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string importJobId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ImportJobId = importJobId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ImportJobName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="importJobId">The <c>ImportJob</c> ID. Must not be <c>null</c> or empty.</param>
        public ImportJobName(string projectId, string locationId, string importJobId) : this(ResourceNameType.ProjectLocationImportJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), importJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(importJobId, nameof(importJobId)))
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
        /// The <c>ImportJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ImportJobId { get; }

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
                case ResourceNameType.ProjectLocationImportJob: return s_projectLocationImportJob.Expand(ProjectId, LocationId, ImportJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ImportJobName);

        /// <inheritdoc/>
        public bool Equals(ImportJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ImportJobName a, ImportJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ImportJobName a, ImportJobName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ImportDataFile</c> resource.</summary>
    public sealed partial class ImportDataFileName : gax::IResourceName, sys::IEquatable<ImportDataFileName>
    {
        /// <summary>The possible contents of <see cref="ImportDataFileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/importJobs/{import_job}/importDataFiles/{import_data_file}</c>
            /// .
            /// </summary>
            ProjectLocationImportJobImportDataFile = 1,
        }

        private static gax::PathTemplate s_projectLocationImportJobImportDataFile = new gax::PathTemplate("projects/{project}/locations/{location}/importJobs/{import_job}/importDataFiles/{import_data_file}");

        /// <summary>Creates a <see cref="ImportDataFileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ImportDataFileName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ImportDataFileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ImportDataFileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ImportDataFileName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}/importDataFiles/{import_data_file}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="importJobId">The <c>ImportJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="importDataFileId">The <c>ImportDataFile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ImportDataFileName"/> constructed from the provided ids.</returns>
        public static ImportDataFileName FromProjectLocationImportJobImportDataFile(string projectId, string locationId, string importJobId, string importDataFileId) =>
            new ImportDataFileName(ResourceNameType.ProjectLocationImportJobImportDataFile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), importJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(importJobId, nameof(importJobId)), importDataFileId: gax::GaxPreconditions.CheckNotNullOrEmpty(importDataFileId, nameof(importDataFileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ImportDataFileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}/importDataFiles/{import_data_file}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="importJobId">The <c>ImportJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="importDataFileId">The <c>ImportDataFile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ImportDataFileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}/importDataFiles/{import_data_file}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string importJobId, string importDataFileId) =>
            FormatProjectLocationImportJobImportDataFile(projectId, locationId, importJobId, importDataFileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ImportDataFileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}/importDataFiles/{import_data_file}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="importJobId">The <c>ImportJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="importDataFileId">The <c>ImportDataFile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ImportDataFileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}/importDataFiles/{import_data_file}</c>.
        /// </returns>
        public static string FormatProjectLocationImportJobImportDataFile(string projectId, string locationId, string importJobId, string importDataFileId) =>
            s_projectLocationImportJobImportDataFile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(importJobId, nameof(importJobId)), gax::GaxPreconditions.CheckNotNullOrEmpty(importDataFileId, nameof(importDataFileId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ImportDataFileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}/importDataFiles/{import_data_file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="importDataFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ImportDataFileName"/> if successful.</returns>
        public static ImportDataFileName Parse(string importDataFileName) => Parse(importDataFileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ImportDataFileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}/importDataFiles/{import_data_file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="importDataFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ImportDataFileName"/> if successful.</returns>
        public static ImportDataFileName Parse(string importDataFileName, bool allowUnparsed) =>
            TryParse(importDataFileName, allowUnparsed, out ImportDataFileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ImportDataFileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}/importDataFiles/{import_data_file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="importDataFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ImportDataFileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string importDataFileName, out ImportDataFileName result) =>
            TryParse(importDataFileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ImportDataFileName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}/importDataFiles/{import_data_file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="importDataFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ImportDataFileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string importDataFileName, bool allowUnparsed, out ImportDataFileName result)
        {
            gax::GaxPreconditions.CheckNotNull(importDataFileName, nameof(importDataFileName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationImportJobImportDataFile.TryParseName(importDataFileName, out resourceName))
            {
                result = FromProjectLocationImportJobImportDataFile(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(importDataFileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ImportDataFileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string importDataFileId = null, string importJobId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ImportDataFileId = importDataFileId;
            ImportJobId = importJobId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ImportDataFileName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/importJobs/{import_job}/importDataFiles/{import_data_file}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="importJobId">The <c>ImportJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="importDataFileId">The <c>ImportDataFile</c> ID. Must not be <c>null</c> or empty.</param>
        public ImportDataFileName(string projectId, string locationId, string importJobId, string importDataFileId) : this(ResourceNameType.ProjectLocationImportJobImportDataFile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), importJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(importJobId, nameof(importJobId)), importDataFileId: gax::GaxPreconditions.CheckNotNullOrEmpty(importDataFileId, nameof(importDataFileId)))
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
        /// The <c>ImportDataFile</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ImportDataFileId { get; }

        /// <summary>
        /// The <c>ImportJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ImportJobId { get; }

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
                case ResourceNameType.ProjectLocationImportJobImportDataFile: return s_projectLocationImportJobImportDataFile.Expand(ProjectId, LocationId, ImportJobId, ImportDataFileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ImportDataFileName);

        /// <inheritdoc/>
        public bool Equals(ImportDataFileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ImportDataFileName a, ImportDataFileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ImportDataFileName a, ImportDataFileName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Group</c> resource.</summary>
    public sealed partial class GroupName : gax::IResourceName, sys::IEquatable<GroupName>
    {
        /// <summary>The possible contents of <see cref="GroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/groups/{group}</c>.
            /// </summary>
            ProjectLocationGroup = 1,
        }

        private static gax::PathTemplate s_projectLocationGroup = new gax::PathTemplate("projects/{project}/locations/{location}/groups/{group}");

        /// <summary>Creates a <see cref="GroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GroupName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GroupName"/> with the pattern <c>projects/{project}/locations/{location}/groups/{group}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GroupName"/> constructed from the provided ids.</returns>
        public static GroupName FromProjectLocationGroup(string projectId, string locationId, string groupId) =>
            new GroupName(ResourceNameType.ProjectLocationGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), groupId: gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/groups/{group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/groups/{group}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string groupId) =>
            FormatProjectLocationGroup(projectId, locationId, groupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/groups/{group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/groups/{group}</c>.
        /// </returns>
        public static string FormatProjectLocationGroup(string projectId, string locationId, string groupId) =>
            s_projectLocationGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)));

        /// <summary>Parses the given resource name string into a new <see cref="GroupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/groups/{group}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="groupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GroupName"/> if successful.</returns>
        public static GroupName Parse(string groupName) => Parse(groupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GroupName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/groups/{group}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="groupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GroupName"/> if successful.</returns>
        public static GroupName Parse(string groupName, bool allowUnparsed) =>
            TryParse(groupName, allowUnparsed, out GroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/groups/{group}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="groupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string groupName, out GroupName result) => TryParse(groupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/groups/{group}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="groupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string groupName, bool allowUnparsed, out GroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(groupName, nameof(groupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGroup.TryParseName(groupName, out resourceName))
            {
                result = FromProjectLocationGroup(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(groupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string groupId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GroupId = groupId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GroupName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/groups/{group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        public GroupName(string projectId, string locationId, string groupId) : this(ResourceNameType.ProjectLocationGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), groupId: gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)))
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
        /// The <c>Group</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string GroupId { get; }

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
                case ResourceNameType.ProjectLocationGroup: return s_projectLocationGroup.Expand(ProjectId, LocationId, GroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GroupName);

        /// <inheritdoc/>
        public bool Equals(GroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GroupName a, GroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GroupName a, GroupName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ErrorFrame</c> resource.</summary>
    public sealed partial class ErrorFrameName : gax::IResourceName, sys::IEquatable<ErrorFrameName>
    {
        /// <summary>The possible contents of <see cref="ErrorFrameName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}</c>.
            /// </summary>
            ProjectLocationSourceErrorFrame = 1,
        }

        private static gax::PathTemplate s_projectLocationSourceErrorFrame = new gax::PathTemplate("projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}");

        /// <summary>Creates a <see cref="ErrorFrameName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ErrorFrameName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ErrorFrameName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ErrorFrameName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ErrorFrameName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="errorFrameId">The <c>ErrorFrame</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ErrorFrameName"/> constructed from the provided ids.</returns>
        public static ErrorFrameName FromProjectLocationSourceErrorFrame(string projectId, string locationId, string sourceId, string errorFrameId) =>
            new ErrorFrameName(ResourceNameType.ProjectLocationSourceErrorFrame, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), errorFrameId: gax::GaxPreconditions.CheckNotNullOrEmpty(errorFrameId, nameof(errorFrameId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ErrorFrameName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="errorFrameId">The <c>ErrorFrame</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ErrorFrameName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sourceId, string errorFrameId) =>
            FormatProjectLocationSourceErrorFrame(projectId, locationId, sourceId, errorFrameId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ErrorFrameName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="errorFrameId">The <c>ErrorFrame</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ErrorFrameName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}</c>.
        /// </returns>
        public static string FormatProjectLocationSourceErrorFrame(string projectId, string locationId, string sourceId, string errorFrameId) =>
            s_projectLocationSourceErrorFrame.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(errorFrameId, nameof(errorFrameId)));

        /// <summary>Parses the given resource name string into a new <see cref="ErrorFrameName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="errorFrameName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ErrorFrameName"/> if successful.</returns>
        public static ErrorFrameName Parse(string errorFrameName) => Parse(errorFrameName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ErrorFrameName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="errorFrameName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ErrorFrameName"/> if successful.</returns>
        public static ErrorFrameName Parse(string errorFrameName, bool allowUnparsed) =>
            TryParse(errorFrameName, allowUnparsed, out ErrorFrameName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ErrorFrameName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="errorFrameName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ErrorFrameName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string errorFrameName, out ErrorFrameName result) =>
            TryParse(errorFrameName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ErrorFrameName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="errorFrameName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ErrorFrameName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string errorFrameName, bool allowUnparsed, out ErrorFrameName result)
        {
            gax::GaxPreconditions.CheckNotNull(errorFrameName, nameof(errorFrameName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSourceErrorFrame.TryParseName(errorFrameName, out resourceName))
            {
                result = FromProjectLocationSourceErrorFrame(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(errorFrameName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ErrorFrameName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string errorFrameId = null, string locationId = null, string projectId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ErrorFrameId = errorFrameId;
            LocationId = locationId;
            ProjectId = projectId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ErrorFrameName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="errorFrameId">The <c>ErrorFrame</c> ID. Must not be <c>null</c> or empty.</param>
        public ErrorFrameName(string projectId, string locationId, string sourceId, string errorFrameId) : this(ResourceNameType.ProjectLocationSourceErrorFrame, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), errorFrameId: gax::GaxPreconditions.CheckNotNullOrEmpty(errorFrameId, nameof(errorFrameId)))
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
        /// The <c>ErrorFrame</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ErrorFrameId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Source</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSourceErrorFrame: return s_projectLocationSourceErrorFrame.Expand(ProjectId, LocationId, SourceId, ErrorFrameId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ErrorFrameName);

        /// <inheritdoc/>
        public bool Equals(ErrorFrameName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ErrorFrameName a, ErrorFrameName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ErrorFrameName a, ErrorFrameName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Source</c> resource.</summary>
    public sealed partial class SourceName : gax::IResourceName, sys::IEquatable<SourceName>
    {
        /// <summary>The possible contents of <see cref="SourceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/sources/{source}</c>.
            /// </summary>
            ProjectLocationSource = 1,
        }

        private static gax::PathTemplate s_projectLocationSource = new gax::PathTemplate("projects/{project}/locations/{location}/sources/{source}");

        /// <summary>Creates a <see cref="SourceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SourceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SourceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SourceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SourceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SourceName"/> constructed from the provided ids.</returns>
        public static SourceName FromProjectLocationSource(string projectId, string locationId, string sourceId) =>
            new SourceName(ResourceNameType.ProjectLocationSource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sourceId) =>
            FormatProjectLocationSource(projectId, locationId, sourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}</c>.
        /// </returns>
        public static string FormatProjectLocationSource(string projectId, string locationId, string sourceId) =>
            s_projectLocationSource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)));

        /// <summary>Parses the given resource name string into a new <see cref="SourceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sources/{source}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SourceName"/> if successful.</returns>
        public static SourceName Parse(string sourceName) => Parse(sourceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SourceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sources/{source}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SourceName"/> if successful.</returns>
        public static SourceName Parse(string sourceName, bool allowUnparsed) =>
            TryParse(sourceName, allowUnparsed, out SourceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sources/{source}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sourceName, out SourceName result) => TryParse(sourceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SourceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sources/{source}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sourceName, bool allowUnparsed, out SourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(sourceName, nameof(sourceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSource.TryParseName(sourceName, out resourceName))
            {
                result = FromProjectLocationSource(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sourceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SourceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SourceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        public SourceName(string projectId, string locationId, string sourceId) : this(ResourceNameType.ProjectLocationSource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Source</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSource: return s_projectLocationSource.Expand(ProjectId, LocationId, SourceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SourceName);

        /// <inheritdoc/>
        public bool Equals(SourceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SourceName a, SourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SourceName a, SourceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ReportConfig</c> resource.</summary>
    public sealed partial class ReportConfigName : gax::IResourceName, sys::IEquatable<ReportConfigName>
    {
        /// <summary>The possible contents of <see cref="ReportConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>
            /// .
            /// </summary>
            ProjectLocationReportConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationReportConfig = new gax::PathTemplate("projects/{project}/locations/{location}/reportConfigs/{report_config}");

        /// <summary>Creates a <see cref="ReportConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReportConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReportConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReportConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReportConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReportConfigName"/> constructed from the provided ids.</returns>
        public static ReportConfigName FromProjectLocationReportConfig(string projectId, string locationId, string reportConfigId) =>
            new ReportConfigName(ResourceNameType.ProjectLocationReportConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reportConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReportConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReportConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string reportConfigId) =>
            FormatProjectLocationReportConfig(projectId, locationId, reportConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReportConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReportConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>.
        /// </returns>
        public static string FormatProjectLocationReportConfig(string projectId, string locationId, string reportConfigId) =>
            s_projectLocationReportConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReportConfigName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reportConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReportConfigName"/> if successful.</returns>
        public static ReportConfigName Parse(string reportConfigName) => Parse(reportConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReportConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reportConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReportConfigName"/> if successful.</returns>
        public static ReportConfigName Parse(string reportConfigName, bool allowUnparsed) =>
            TryParse(reportConfigName, allowUnparsed, out ReportConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReportConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reportConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReportConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reportConfigName, out ReportConfigName result) =>
            TryParse(reportConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReportConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reportConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReportConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reportConfigName, bool allowUnparsed, out ReportConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(reportConfigName, nameof(reportConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationReportConfig.TryParseName(reportConfigName, out resourceName))
            {
                result = FromProjectLocationReportConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(reportConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReportConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string reportConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ReportConfigId = reportConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReportConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public ReportConfigName(string projectId, string locationId, string reportConfigId) : this(ResourceNameType.ProjectLocationReportConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reportConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ReportConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReportConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationReportConfig: return s_projectLocationReportConfig.Expand(ProjectId, LocationId, ReportConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReportConfigName);

        /// <inheritdoc/>
        public bool Equals(ReportConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReportConfigName a, ReportConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReportConfigName a, ReportConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Report</c> resource.</summary>
    public sealed partial class ReportName : gax::IResourceName, sys::IEquatable<ReportName>
    {
        /// <summary>The possible contents of <see cref="ReportName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reports/{report}</c>.
            /// </summary>
            ProjectLocationReportConfigReport = 1,
        }

        private static gax::PathTemplate s_projectLocationReportConfigReport = new gax::PathTemplate("projects/{project}/locations/{location}/reportConfigs/{report_config}/reports/{report}");

        /// <summary>Creates a <see cref="ReportName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReportName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReportName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReportName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReportName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reports/{report}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportId">The <c>Report</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReportName"/> constructed from the provided ids.</returns>
        public static ReportName FromProjectLocationReportConfigReport(string projectId, string locationId, string reportConfigId, string reportId) =>
            new ReportName(ResourceNameType.ProjectLocationReportConfigReport, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reportConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)), reportId: gax::GaxPreconditions.CheckNotNullOrEmpty(reportId, nameof(reportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reports/{report}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportId">The <c>Report</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reports/{report}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string reportConfigId, string reportId) =>
            FormatProjectLocationReportConfigReport(projectId, locationId, reportConfigId, reportId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reports/{report}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportId">The <c>Report</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reports/{report}</c>.
        /// </returns>
        public static string FormatProjectLocationReportConfigReport(string projectId, string locationId, string reportConfigId, string reportId) =>
            s_projectLocationReportConfigReport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reportId, nameof(reportId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReportName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reports/{report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReportName"/> if successful.</returns>
        public static ReportName Parse(string reportName) => Parse(reportName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReportName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reports/{report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReportName"/> if successful.</returns>
        public static ReportName Parse(string reportName, bool allowUnparsed) =>
            TryParse(reportName, allowUnparsed, out ReportName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReportName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reports/{report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reportName, out ReportName result) => TryParse(reportName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReportName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reports/{report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reportName, bool allowUnparsed, out ReportName result)
        {
            gax::GaxPreconditions.CheckNotNull(reportName, nameof(reportName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationReportConfigReport.TryParseName(reportName, out resourceName))
            {
                result = FromProjectLocationReportConfigReport(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(reportName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReportName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string reportId = null, string reportConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ReportId = reportId;
            ReportConfigId = reportConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReportName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reports/{report}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportId">The <c>Report</c> ID. Must not be <c>null</c> or empty.</param>
        public ReportName(string projectId, string locationId, string reportConfigId, string reportId) : this(ResourceNameType.ProjectLocationReportConfigReport, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reportConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)), reportId: gax::GaxPreconditions.CheckNotNullOrEmpty(reportId, nameof(reportId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Report</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ReportId { get; }

        /// <summary>
        /// The <c>ReportConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReportConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationReportConfigReport: return s_projectLocationReportConfigReport.Expand(ProjectId, LocationId, ReportConfigId, ReportId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReportName);

        /// <inheritdoc/>
        public bool Equals(ReportName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReportName a, ReportName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReportName a, ReportName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Settings</c> resource.</summary>
    public sealed partial class SettingsName : gax::IResourceName, sys::IEquatable<SettingsName>
    {
        /// <summary>The possible contents of <see cref="SettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/locations/{location}/settings</c>.</summary>
            ProjectLocation = 1,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/settings");

        /// <summary>Creates a <see cref="SettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SettingsName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static SettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SettingsName"/> with the pattern <c>projects/{project}/locations/{location}/settings</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromProjectLocation(string projectId, string locationId) =>
            new SettingsName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>Parses the given resource name string into a new <see cref="SettingsName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName) => Parse(settingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SettingsName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName, bool allowUnparsed) =>
            TryParse(settingsName, allowUnparsed, out SettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, out SettingsName result) => TryParse(settingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, bool allowUnparsed, out SettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(settingsName, nameof(settingsName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(settingsName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(settingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SettingsName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/settings</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public SettingsName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SettingsName);

        /// <inheritdoc/>
        public bool Equals(SettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SettingsName a, SettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SettingsName a, SettingsName b) => !(a == b);
    }

    public partial class Asset
    {
        /// <summary>
        /// <see cref="gcmv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SourceName"/>-typed view over the <see cref="Sources"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<SourceName> SourcesAsSourceNames
        {
            get => new gax::ResourceNameList<SourceName>(Sources, s => string.IsNullOrEmpty(s) ? null : SourceName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="GroupName"/>-typed view over the <see cref="AssignedGroups"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<GroupName> AssignedGroupsAsGroupNames
        {
            get => new gax::ResourceNameList<GroupName>(AssignedGroups, s => string.IsNullOrEmpty(s) ? null : GroupName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class PreferenceSet
    {
        /// <summary>
        /// <see cref="gcmv::PreferenceSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::PreferenceSetName PreferenceSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::PreferenceSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportJob
    {
        /// <summary>
        /// <see cref="gcmv::ImportJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ImportJobName ImportJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ImportJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SourceName"/>-typed view over the <see cref="AssetSource"/> resource name property.
        /// </summary>
        public SourceName AssetSourceAsSourceName
        {
            get => string.IsNullOrEmpty(AssetSource) ? null : SourceName.Parse(AssetSource, allowUnparsed: true);
            set => AssetSource = value?.ToString() ?? "";
        }
    }

    public partial class ImportDataFile
    {
        /// <summary>
        /// <see cref="gcmv::ImportDataFileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ImportDataFileName ImportDataFileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ImportDataFileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Group
    {
        /// <summary>
        /// <see cref="gcmv::GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::GroupName GroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::GroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ErrorFrame
    {
        /// <summary>
        /// <see cref="gcmv::ErrorFrameName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ErrorFrameName ErrorFrameName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ErrorFrameName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Source
    {
        /// <summary>
        /// <see cref="gcmv::SourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::SourceName SourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::SourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReportConfig
    {
        /// <summary>
        /// <see cref="gcmv::ReportConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ReportConfigName ReportConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ReportConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class GroupPreferenceSetAssignment
            {
                /// <summary>
                /// <see cref="GroupName"/>-typed view over the <see cref="Group"/> resource name property.
                /// </summary>
                public GroupName GroupAsGroupName
                {
                    get => string.IsNullOrEmpty(Group) ? null : GroupName.Parse(Group, allowUnparsed: true);
                    set => Group = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="PreferenceSetName"/>-typed view over the <see cref="PreferenceSet"/> resource name
                /// property.
                /// </summary>
                public PreferenceSetName PreferenceSetAsPreferenceSetName
                {
                    get => string.IsNullOrEmpty(PreferenceSet) ? null : PreferenceSetName.Parse(PreferenceSet, allowUnparsed: true);
                    set => PreferenceSet = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class Report
    {
        /// <summary>
        /// <see cref="gcmv::ReportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ReportName ReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAssetsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAssetRequest
    {
        /// <summary>
        /// <see cref="gcmv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchUpdateAssetsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAssetRequest
    {
        /// <summary>
        /// <see cref="gcmv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeleteAssetsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<AssetName> AssetNames
        {
            get => new gax::ResourceNameList<AssetName>(Names, s => string.IsNullOrEmpty(s) ? null : AssetName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ReportAssetFramesRequest
    {
        /// <summary><see cref="SourceName"/>-typed view over the <see cref="Source"/> resource name property.</summary>
        public SourceName SourceAsSourceName
        {
            get => string.IsNullOrEmpty(Source) ? null : SourceName.Parse(Source, allowUnparsed: true);
            set => Source = value?.ToString() ?? "";
        }
    }

    public partial class CreateImportJobRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListImportJobsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetImportJobRequest
    {
        /// <summary>
        /// <see cref="gcmv::ImportJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ImportJobName ImportJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ImportJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteImportJobRequest
    {
        /// <summary>
        /// <see cref="gcmv::ImportJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ImportJobName ImportJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ImportJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ValidateImportJobRequest
    {
        /// <summary>
        /// <see cref="gcmv::ImportJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ImportJobName ImportJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ImportJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RunImportJobRequest
    {
        /// <summary>
        /// <see cref="gcmv::ImportJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ImportJobName ImportJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ImportJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetImportDataFileRequest
    {
        /// <summary>
        /// <see cref="gcmv::ImportDataFileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ImportDataFileName ImportDataFileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ImportDataFileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListImportDataFilesRequest
    {
        /// <summary>
        /// <see cref="ImportJobName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ImportJobName ParentAsImportJobName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ImportJobName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateImportDataFileRequest
    {
        /// <summary>
        /// <see cref="ImportJobName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ImportJobName ParentAsImportJobName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ImportJobName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteImportDataFileRequest
    {
        /// <summary>
        /// <see cref="gcmv::ImportDataFileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ImportDataFileName ImportDataFileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ImportDataFileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGroupsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetGroupRequest
    {
        /// <summary>
        /// <see cref="gcmv::GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::GroupName GroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::GroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGroupRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGroupRequest
    {
        /// <summary>
        /// <see cref="gcmv::GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::GroupName GroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::GroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AddAssetsToGroupRequest
    {
        /// <summary><see cref="GroupName"/>-typed view over the <see cref="Group"/> resource name property.</summary>
        public GroupName GroupAsGroupName
        {
            get => string.IsNullOrEmpty(Group) ? null : GroupName.Parse(Group, allowUnparsed: true);
            set => Group = value?.ToString() ?? "";
        }
    }

    public partial class RemoveAssetsFromGroupRequest
    {
        /// <summary><see cref="GroupName"/>-typed view over the <see cref="Group"/> resource name property.</summary>
        public GroupName GroupAsGroupName
        {
            get => string.IsNullOrEmpty(Group) ? null : GroupName.Parse(Group, allowUnparsed: true);
            set => Group = value?.ToString() ?? "";
        }
    }

    public partial class ListErrorFramesRequest
    {
        /// <summary><see cref="SourceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SourceName ParentAsSourceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SourceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetErrorFrameRequest
    {
        /// <summary>
        /// <see cref="gcmv::ErrorFrameName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ErrorFrameName ErrorFrameName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ErrorFrameName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSourcesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSourceRequest
    {
        /// <summary>
        /// <see cref="gcmv::SourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::SourceName SourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::SourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSourceRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSourceRequest
    {
        /// <summary>
        /// <see cref="gcmv::SourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::SourceName SourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::SourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPreferenceSetsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPreferenceSetRequest
    {
        /// <summary>
        /// <see cref="gcmv::PreferenceSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::PreferenceSetName PreferenceSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::PreferenceSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePreferenceSetRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePreferenceSetRequest
    {
        /// <summary>
        /// <see cref="gcmv::PreferenceSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::PreferenceSetName PreferenceSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::PreferenceSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSettingsRequest
    {
        /// <summary>
        /// <see cref="gcmv::SettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::SettingsName SettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::SettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateReportConfigRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteReportConfigRequest
    {
        /// <summary>
        /// <see cref="gcmv::ReportConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ReportConfigName ReportConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ReportConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetReportRequest
    {
        /// <summary>
        /// <see cref="gcmv::ReportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ReportName ReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListReportsRequest
    {
        /// <summary>
        /// <see cref="ReportConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ReportConfigName ParentAsReportConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ReportConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteReportRequest
    {
        /// <summary>
        /// <see cref="gcmv::ReportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ReportName ReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetReportConfigRequest
    {
        /// <summary>
        /// <see cref="gcmv::ReportConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ReportConfigName ReportConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ReportConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListReportConfigsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateReportRequest
    {
        /// <summary>
        /// <see cref="ReportConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ReportConfigName ParentAsReportConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ReportConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AssetList
    {
        /// <summary>
        /// <see cref="AssetName"/>-typed view over the <see cref="AssetIds"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AssetName> AssetIdsAsAssetNames
        {
            get => new gax::ResourceNameList<AssetName>(AssetIds, s => string.IsNullOrEmpty(s) ? null : AssetName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class Settings
    {
        /// <summary>
        /// <see cref="gcmv::SettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::SettingsName SettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::SettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PreferenceSetName"/>-typed view over the <see cref="PreferenceSet"/> resource name property.
        /// </summary>
        public PreferenceSetName PreferenceSetAsPreferenceSetName
        {
            get => string.IsNullOrEmpty(PreferenceSet) ? null : PreferenceSetName.Parse(PreferenceSet, allowUnparsed: true);
            set => PreferenceSet = value?.ToString() ?? "";
        }
    }
}

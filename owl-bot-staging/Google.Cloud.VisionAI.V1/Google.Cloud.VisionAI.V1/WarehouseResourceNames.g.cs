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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcvv = Google.Cloud.VisionAI.V1;
using sys = System;

namespace Google.Cloud.VisionAI.V1
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
            /// A resource name with pattern
            /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}</c>.
            /// </summary>
            ProjectNumberLocationCorpusAsset = 1,
        }

        private static gax::PathTemplate s_projectNumberLocationCorpusAsset = new gax::PathTemplate("projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}");

        /// <summary>Creates a <see cref="AssetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssetName"/> with the pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssetName"/> constructed from the provided ids.</returns>
        public static AssetName FromProjectNumberLocationCorpusAsset(string projectNumberId, string locationId, string corpusId, string assetId) =>
            new AssetName(ResourceNameType.ProjectNumberLocationCorpusAsset, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}</c>.
        /// </returns>
        public static string Format(string projectNumberId, string locationId, string corpusId, string assetId) =>
            FormatProjectNumberLocationCorpusAsset(projectNumberId, locationId, corpusId, assetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}</c>.
        /// </returns>
        public static string FormatProjectNumberLocationCorpusAsset(string projectNumberId, string locationId, string corpusId, string assetId) =>
            s_projectNumberLocationCorpusAsset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>Parses the given resource name string into a new <see cref="AssetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}</c>
        /// </description>
        /// </item>
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
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}</c>
        /// </description>
        /// </item>
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
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}</c>
        /// </description>
        /// </item>
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
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}</c>
        /// </description>
        /// </item>
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
            if (s_projectNumberLocationCorpusAsset.TryParseName(assetName, out resourceName))
            {
                result = FromProjectNumberLocationCorpusAsset(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
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

        private AssetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetId = null, string corpusId = null, string locationId = null, string projectNumberId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetId = assetId;
            CorpusId = corpusId;
            LocationId = locationId;
            ProjectNumberId = projectNumberId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssetName"/> class from the component parts of pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}</c>
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        public AssetName(string projectNumberId, string locationId, string corpusId, string assetId) : this(ResourceNameType.ProjectNumberLocationCorpusAsset, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)))
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
        /// The <c>Corpus</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CorpusId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>ProjectNumber</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ProjectNumberId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNumberLocationCorpusAsset: return s_projectNumberLocationCorpusAsset.Expand(ProjectNumberId, LocationId, CorpusId, AssetId);
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

    /// <summary>Resource name for the <c>Collection</c> resource.</summary>
    public sealed partial class CollectionName : gax::IResourceName, sys::IEquatable<CollectionName>
    {
        /// <summary>The possible contents of <see cref="CollectionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}</c>.
            /// </summary>
            ProjectNumberLocationCorpusCollection = 1,
        }

        private static gax::PathTemplate s_projectNumberLocationCorpusCollection = new gax::PathTemplate("projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}");

        /// <summary>Creates a <see cref="CollectionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CollectionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CollectionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CollectionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CollectionName"/> with the pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CollectionName"/> constructed from the provided ids.</returns>
        public static CollectionName FromProjectNumberLocationCorpusCollection(string projectNumberId, string locationId, string corpusId, string collectionId) =>
            new CollectionName(ResourceNameType.ProjectNumberLocationCorpusCollection, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CollectionName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CollectionName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}</c>.
        /// </returns>
        public static string Format(string projectNumberId, string locationId, string corpusId, string collectionId) =>
            FormatProjectNumberLocationCorpusCollection(projectNumberId, locationId, corpusId, collectionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CollectionName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CollectionName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}</c>.
        /// </returns>
        public static string FormatProjectNumberLocationCorpusCollection(string projectNumberId, string locationId, string corpusId, string collectionId) =>
            s_projectNumberLocationCorpusCollection.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)));

        /// <summary>Parses the given resource name string into a new <see cref="CollectionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="collectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CollectionName"/> if successful.</returns>
        public static CollectionName Parse(string collectionName) => Parse(collectionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CollectionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="collectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CollectionName"/> if successful.</returns>
        public static CollectionName Parse(string collectionName, bool allowUnparsed) =>
            TryParse(collectionName, allowUnparsed, out CollectionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CollectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="collectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CollectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string collectionName, out CollectionName result) =>
            TryParse(collectionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CollectionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="collectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CollectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string collectionName, bool allowUnparsed, out CollectionName result)
        {
            gax::GaxPreconditions.CheckNotNull(collectionName, nameof(collectionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNumberLocationCorpusCollection.TryParseName(collectionName, out resourceName))
            {
                result = FromProjectNumberLocationCorpusCollection(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(collectionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CollectionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string corpusId = null, string locationId = null, string projectNumberId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            CorpusId = corpusId;
            LocationId = locationId;
            ProjectNumberId = projectNumberId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CollectionName"/> class from the component parts of pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}</c>
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        public CollectionName(string projectNumberId, string locationId, string corpusId, string collectionId) : this(ResourceNameType.ProjectNumberLocationCorpusCollection, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)))
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
        /// The <c>Collection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CollectionId { get; }

        /// <summary>
        /// The <c>Corpus</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CorpusId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>ProjectNumber</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ProjectNumberId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNumberLocationCorpusCollection: return s_projectNumberLocationCorpusCollection.Expand(ProjectNumberId, LocationId, CorpusId, CollectionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CollectionName);

        /// <inheritdoc/>
        public bool Equals(CollectionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CollectionName a, CollectionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CollectionName a, CollectionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Index</c> resource.</summary>
    public sealed partial class IndexName : gax::IResourceName, sys::IEquatable<IndexName>
    {
        /// <summary>The possible contents of <see cref="IndexName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}</c>.
            /// </summary>
            ProjectNumberLocationCorpusIndex = 1,
        }

        private static gax::PathTemplate s_projectNumberLocationCorpusIndex = new gax::PathTemplate("projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}");

        /// <summary>Creates a <see cref="IndexName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IndexName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IndexName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IndexName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IndexName"/> with the pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexId">The <c>Index</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IndexName"/> constructed from the provided ids.</returns>
        public static IndexName FromProjectNumberLocationCorpusIndex(string projectNumberId, string locationId, string corpusId, string indexId) =>
            new IndexName(ResourceNameType.ProjectNumberLocationCorpusIndex, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), indexId: gax::GaxPreconditions.CheckNotNullOrEmpty(indexId, nameof(indexId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IndexName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexId">The <c>Index</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IndexName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}</c>.
        /// </returns>
        public static string Format(string projectNumberId, string locationId, string corpusId, string indexId) =>
            FormatProjectNumberLocationCorpusIndex(projectNumberId, locationId, corpusId, indexId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IndexName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexId">The <c>Index</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IndexName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}</c>.
        /// </returns>
        public static string FormatProjectNumberLocationCorpusIndex(string projectNumberId, string locationId, string corpusId, string indexId) =>
            s_projectNumberLocationCorpusIndex.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), gax::GaxPreconditions.CheckNotNullOrEmpty(indexId, nameof(indexId)));

        /// <summary>Parses the given resource name string into a new <see cref="IndexName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="indexName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IndexName"/> if successful.</returns>
        public static IndexName Parse(string indexName) => Parse(indexName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IndexName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="indexName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IndexName"/> if successful.</returns>
        public static IndexName Parse(string indexName, bool allowUnparsed) =>
            TryParse(indexName, allowUnparsed, out IndexName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IndexName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="indexName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IndexName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string indexName, out IndexName result) => TryParse(indexName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IndexName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="indexName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IndexName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string indexName, bool allowUnparsed, out IndexName result)
        {
            gax::GaxPreconditions.CheckNotNull(indexName, nameof(indexName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNumberLocationCorpusIndex.TryParseName(indexName, out resourceName))
            {
                result = FromProjectNumberLocationCorpusIndex(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(indexName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IndexName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string corpusId = null, string indexId = null, string locationId = null, string projectNumberId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CorpusId = corpusId;
            IndexId = indexId;
            LocationId = locationId;
            ProjectNumberId = projectNumberId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IndexName"/> class from the component parts of pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}</c>
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexId">The <c>Index</c> ID. Must not be <c>null</c> or empty.</param>
        public IndexName(string projectNumberId, string locationId, string corpusId, string indexId) : this(ResourceNameType.ProjectNumberLocationCorpusIndex, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), indexId: gax::GaxPreconditions.CheckNotNullOrEmpty(indexId, nameof(indexId)))
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
        /// The <c>Corpus</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CorpusId { get; }

        /// <summary>
        /// The <c>Index</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IndexId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>ProjectNumber</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ProjectNumberId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNumberLocationCorpusIndex: return s_projectNumberLocationCorpusIndex.Expand(ProjectNumberId, LocationId, CorpusId, IndexId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IndexName);

        /// <inheritdoc/>
        public bool Equals(IndexName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(IndexName a, IndexName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(IndexName a, IndexName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Corpus</c> resource.</summary>
    public sealed partial class CorpusName : gax::IResourceName, sys::IEquatable<CorpusName>
    {
        /// <summary>The possible contents of <see cref="CorpusName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project_number}/locations/{location}/corpora/{corpus}</c>.
            /// </summary>
            ProjectNumberLocationCorpus = 1,
        }

        private static gax::PathTemplate s_projectNumberLocationCorpus = new gax::PathTemplate("projects/{project_number}/locations/{location}/corpora/{corpus}");

        /// <summary>Creates a <see cref="CorpusName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CorpusName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CorpusName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CorpusName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CorpusName"/> with the pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CorpusName"/> constructed from the provided ids.</returns>
        public static CorpusName FromProjectNumberLocationCorpus(string projectNumberId, string locationId, string corpusId) =>
            new CorpusName(ResourceNameType.ProjectNumberLocationCorpus, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CorpusName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CorpusName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}</c>.
        /// </returns>
        public static string Format(string projectNumberId, string locationId, string corpusId) =>
            FormatProjectNumberLocationCorpus(projectNumberId, locationId, corpusId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CorpusName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CorpusName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}</c>.
        /// </returns>
        public static string FormatProjectNumberLocationCorpus(string projectNumberId, string locationId, string corpusId) =>
            s_projectNumberLocationCorpus.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)));

        /// <summary>Parses the given resource name string into a new <see cref="CorpusName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project_number}/locations/{location}/corpora/{corpus}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="corpusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CorpusName"/> if successful.</returns>
        public static CorpusName Parse(string corpusName) => Parse(corpusName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CorpusName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project_number}/locations/{location}/corpora/{corpus}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="corpusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CorpusName"/> if successful.</returns>
        public static CorpusName Parse(string corpusName, bool allowUnparsed) =>
            TryParse(corpusName, allowUnparsed, out CorpusName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CorpusName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project_number}/locations/{location}/corpora/{corpus}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="corpusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CorpusName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string corpusName, out CorpusName result) => TryParse(corpusName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CorpusName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project_number}/locations/{location}/corpora/{corpus}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="corpusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CorpusName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string corpusName, bool allowUnparsed, out CorpusName result)
        {
            gax::GaxPreconditions.CheckNotNull(corpusName, nameof(corpusName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNumberLocationCorpus.TryParseName(corpusName, out resourceName))
            {
                result = FromProjectNumberLocationCorpus(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(corpusName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CorpusName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string corpusId = null, string locationId = null, string projectNumberId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CorpusId = corpusId;
            LocationId = locationId;
            ProjectNumberId = projectNumberId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CorpusName"/> class from the component parts of pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}</c>
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        public CorpusName(string projectNumberId, string locationId, string corpusId) : this(ResourceNameType.ProjectNumberLocationCorpus, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)))
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
        /// The <c>Corpus</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CorpusId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>ProjectNumber</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ProjectNumberId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNumberLocationCorpus: return s_projectNumberLocationCorpus.Expand(ProjectNumberId, LocationId, CorpusId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CorpusName);

        /// <inheritdoc/>
        public bool Equals(CorpusName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CorpusName a, CorpusName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CorpusName a, CorpusName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataSchema</c> resource.</summary>
    public sealed partial class DataSchemaName : gax::IResourceName, sys::IEquatable<DataSchemaName>
    {
        /// <summary>The possible contents of <see cref="DataSchemaName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}</c>.
            /// </summary>
            ProjectNumberLocationCorpusDataSchema = 1,
        }

        private static gax::PathTemplate s_projectNumberLocationCorpusDataSchema = new gax::PathTemplate("projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}");

        /// <summary>Creates a <see cref="DataSchemaName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataSchemaName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataSchemaName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataSchemaName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataSchemaName"/> with the pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSchemaId">The <c>DataSchema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataSchemaName"/> constructed from the provided ids.</returns>
        public static DataSchemaName FromProjectNumberLocationCorpusDataSchema(string projectNumberId, string locationId, string corpusId, string dataSchemaId) =>
            new DataSchemaName(ResourceNameType.ProjectNumberLocationCorpusDataSchema, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), dataSchemaId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataSchemaId, nameof(dataSchemaId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataSchemaName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSchemaId">The <c>DataSchema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataSchemaName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}</c>.
        /// </returns>
        public static string Format(string projectNumberId, string locationId, string corpusId, string dataSchemaId) =>
            FormatProjectNumberLocationCorpusDataSchema(projectNumberId, locationId, corpusId, dataSchemaId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataSchemaName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSchemaId">The <c>DataSchema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataSchemaName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}</c>.
        /// </returns>
        public static string FormatProjectNumberLocationCorpusDataSchema(string projectNumberId, string locationId, string corpusId, string dataSchemaId) =>
            s_projectNumberLocationCorpusDataSchema.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataSchemaId, nameof(dataSchemaId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataSchemaName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataSchemaName"/> if successful.</returns>
        public static DataSchemaName Parse(string dataSchemaName) => Parse(dataSchemaName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataSchemaName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataSchemaName"/> if successful.</returns>
        public static DataSchemaName Parse(string dataSchemaName, bool allowUnparsed) =>
            TryParse(dataSchemaName, allowUnparsed, out DataSchemaName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataSchemaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataSchemaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSchemaName, out DataSchemaName result) =>
            TryParse(dataSchemaName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataSchemaName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataSchemaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSchemaName, bool allowUnparsed, out DataSchemaName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataSchemaName, nameof(dataSchemaName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNumberLocationCorpusDataSchema.TryParseName(dataSchemaName, out resourceName))
            {
                result = FromProjectNumberLocationCorpusDataSchema(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataSchemaName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataSchemaName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string corpusId = null, string dataSchemaId = null, string locationId = null, string projectNumberId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CorpusId = corpusId;
            DataSchemaId = dataSchemaId;
            LocationId = locationId;
            ProjectNumberId = projectNumberId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataSchemaName"/> class from the component parts of pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}</c>
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSchemaId">The <c>DataSchema</c> ID. Must not be <c>null</c> or empty.</param>
        public DataSchemaName(string projectNumberId, string locationId, string corpusId, string dataSchemaId) : this(ResourceNameType.ProjectNumberLocationCorpusDataSchema, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), dataSchemaId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataSchemaId, nameof(dataSchemaId)))
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
        /// The <c>Corpus</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CorpusId { get; }

        /// <summary>
        /// The <c>DataSchema</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataSchemaId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>ProjectNumber</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ProjectNumberId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNumberLocationCorpusDataSchema: return s_projectNumberLocationCorpusDataSchema.Expand(ProjectNumberId, LocationId, CorpusId, DataSchemaId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataSchemaName);

        /// <inheritdoc/>
        public bool Equals(DataSchemaName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataSchemaName a, DataSchemaName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataSchemaName a, DataSchemaName b) => !(a == b);
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
            /// A resource name with pattern
            /// <c>
            /// projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}</c>
            /// .
            /// </summary>
            ProjectNumberLocationCorpusAssetAnnotation = 1,
        }

        private static gax::PathTemplate s_projectNumberLocationCorpusAssetAnnotation = new gax::PathTemplate("projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}");

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
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}</c>
        /// .
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationId">The <c>Annotation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnnotationName"/> constructed from the provided ids.</returns>
        public static AnnotationName FromProjectNumberLocationCorpusAssetAnnotation(string projectNumberId, string locationId, string corpusId, string assetId, string annotationId) =>
            new AnnotationName(ResourceNameType.ProjectNumberLocationCorpusAssetAnnotation, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)), annotationId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotationId, nameof(annotationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnnotationName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}</c>
        /// .
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationId">The <c>Annotation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnnotationName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}</c>
        /// .
        /// </returns>
        public static string Format(string projectNumberId, string locationId, string corpusId, string assetId, string annotationId) =>
            FormatProjectNumberLocationCorpusAssetAnnotation(projectNumberId, locationId, corpusId, assetId, annotationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnnotationName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}</c>
        /// .
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationId">The <c>Annotation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnnotationName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}</c>
        /// .
        /// </returns>
        public static string FormatProjectNumberLocationCorpusAssetAnnotation(string projectNumberId, string locationId, string corpusId, string assetId, string annotationId) =>
            s_projectNumberLocationCorpusAssetAnnotation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(annotationId, nameof(annotationId)));

        /// <summary>Parses the given resource name string into a new <see cref="AnnotationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}</c>
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
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}</c>
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
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}</c>
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
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}</c>
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
            if (s_projectNumberLocationCorpusAssetAnnotation.TryParseName(annotationName, out resourceName))
            {
                result = FromProjectNumberLocationCorpusAssetAnnotation(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
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

        private AnnotationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string annotationId = null, string assetId = null, string corpusId = null, string locationId = null, string projectNumberId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnnotationId = annotationId;
            AssetId = assetId;
            CorpusId = corpusId;
            LocationId = locationId;
            ProjectNumberId = projectNumberId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnnotationName"/> class from the component parts of pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}</c>
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationId">The <c>Annotation</c> ID. Must not be <c>null</c> or empty.</param>
        public AnnotationName(string projectNumberId, string locationId, string corpusId, string assetId, string annotationId) : this(ResourceNameType.ProjectNumberLocationCorpusAssetAnnotation, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)), annotationId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotationId, nameof(annotationId)))
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
        /// The <c>Asset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetId { get; }

        /// <summary>
        /// The <c>Corpus</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CorpusId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>ProjectNumber</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ProjectNumberId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNumberLocationCorpusAssetAnnotation: return s_projectNumberLocationCorpusAssetAnnotation.Expand(ProjectNumberId, LocationId, CorpusId, AssetId, AnnotationId);
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

    /// <summary>Resource name for the <c>SearchConfig</c> resource.</summary>
    public sealed partial class SearchConfigName : gax::IResourceName, sys::IEquatable<SearchConfigName>
    {
        /// <summary>The possible contents of <see cref="SearchConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}</c>.
            /// </summary>
            ProjectNumberLocationCorpusSearchConfig = 1,
        }

        private static gax::PathTemplate s_projectNumberLocationCorpusSearchConfig = new gax::PathTemplate("projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}");

        /// <summary>Creates a <see cref="SearchConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SearchConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SearchConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SearchConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SearchConfigName"/> with the pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchConfigId">The <c>SearchConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SearchConfigName"/> constructed from the provided ids.</returns>
        public static SearchConfigName FromProjectNumberLocationCorpusSearchConfig(string projectNumberId, string locationId, string corpusId, string searchConfigId) =>
            new SearchConfigName(ResourceNameType.ProjectNumberLocationCorpusSearchConfig, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), searchConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(searchConfigId, nameof(searchConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SearchConfigName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchConfigId">The <c>SearchConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SearchConfigName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}</c>.
        /// </returns>
        public static string Format(string projectNumberId, string locationId, string corpusId, string searchConfigId) =>
            FormatProjectNumberLocationCorpusSearchConfig(projectNumberId, locationId, corpusId, searchConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SearchConfigName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchConfigId">The <c>SearchConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SearchConfigName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}</c>.
        /// </returns>
        public static string FormatProjectNumberLocationCorpusSearchConfig(string projectNumberId, string locationId, string corpusId, string searchConfigId) =>
            s_projectNumberLocationCorpusSearchConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), gax::GaxPreconditions.CheckNotNullOrEmpty(searchConfigId, nameof(searchConfigId)));

        /// <summary>Parses the given resource name string into a new <see cref="SearchConfigName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="searchConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SearchConfigName"/> if successful.</returns>
        public static SearchConfigName Parse(string searchConfigName) => Parse(searchConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SearchConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="searchConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SearchConfigName"/> if successful.</returns>
        public static SearchConfigName Parse(string searchConfigName, bool allowUnparsed) =>
            TryParse(searchConfigName, allowUnparsed, out SearchConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SearchConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="searchConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SearchConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string searchConfigName, out SearchConfigName result) =>
            TryParse(searchConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SearchConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="searchConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SearchConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string searchConfigName, bool allowUnparsed, out SearchConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(searchConfigName, nameof(searchConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNumberLocationCorpusSearchConfig.TryParseName(searchConfigName, out resourceName))
            {
                result = FromProjectNumberLocationCorpusSearchConfig(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(searchConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SearchConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string corpusId = null, string locationId = null, string projectNumberId = null, string searchConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CorpusId = corpusId;
            LocationId = locationId;
            ProjectNumberId = projectNumberId;
            SearchConfigId = searchConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SearchConfigName"/> class from the component parts of pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}</c>
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchConfigId">The <c>SearchConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public SearchConfigName(string projectNumberId, string locationId, string corpusId, string searchConfigId) : this(ResourceNameType.ProjectNumberLocationCorpusSearchConfig, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), searchConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(searchConfigId, nameof(searchConfigId)))
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
        /// The <c>Corpus</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CorpusId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>ProjectNumber</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ProjectNumberId { get; }

        /// <summary>
        /// The <c>SearchConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SearchConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNumberLocationCorpusSearchConfig: return s_projectNumberLocationCorpusSearchConfig.Expand(ProjectNumberId, LocationId, CorpusId, SearchConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SearchConfigName);

        /// <inheritdoc/>
        public bool Equals(SearchConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SearchConfigName a, SearchConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SearchConfigName a, SearchConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>IndexEndpoint</c> resource.</summary>
    public sealed partial class IndexEndpointName : gax::IResourceName, sys::IEquatable<IndexEndpointName>
    {
        /// <summary>The possible contents of <see cref="IndexEndpointName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}</c>
            /// .
            /// </summary>
            ProjectLocationIndexEndpoint = 1,
        }

        private static gax::PathTemplate s_projectLocationIndexEndpoint = new gax::PathTemplate("projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}");

        /// <summary>Creates a <see cref="IndexEndpointName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IndexEndpointName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IndexEndpointName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IndexEndpointName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IndexEndpointName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexEndpointId">The <c>IndexEndpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IndexEndpointName"/> constructed from the provided ids.</returns>
        public static IndexEndpointName FromProjectLocationIndexEndpoint(string projectId, string locationId, string indexEndpointId) =>
            new IndexEndpointName(ResourceNameType.ProjectLocationIndexEndpoint, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), indexEndpointId: gax::GaxPreconditions.CheckNotNullOrEmpty(indexEndpointId, nameof(indexEndpointId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IndexEndpointName"/> with pattern
        /// <c>projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexEndpointId">The <c>IndexEndpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IndexEndpointName"/> with pattern
        /// <c>projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string indexEndpointId) =>
            FormatProjectLocationIndexEndpoint(projectId, locationId, indexEndpointId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IndexEndpointName"/> with pattern
        /// <c>projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexEndpointId">The <c>IndexEndpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IndexEndpointName"/> with pattern
        /// <c>projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}</c>.
        /// </returns>
        public static string FormatProjectLocationIndexEndpoint(string projectId, string locationId, string indexEndpointId) =>
            s_projectLocationIndexEndpoint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(indexEndpointId, nameof(indexEndpointId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IndexEndpointName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="indexEndpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IndexEndpointName"/> if successful.</returns>
        public static IndexEndpointName Parse(string indexEndpointName) => Parse(indexEndpointName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IndexEndpointName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="indexEndpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IndexEndpointName"/> if successful.</returns>
        public static IndexEndpointName Parse(string indexEndpointName, bool allowUnparsed) =>
            TryParse(indexEndpointName, allowUnparsed, out IndexEndpointName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IndexEndpointName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="indexEndpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IndexEndpointName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string indexEndpointName, out IndexEndpointName result) =>
            TryParse(indexEndpointName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IndexEndpointName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="indexEndpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IndexEndpointName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string indexEndpointName, bool allowUnparsed, out IndexEndpointName result)
        {
            gax::GaxPreconditions.CheckNotNull(indexEndpointName, nameof(indexEndpointName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationIndexEndpoint.TryParseName(indexEndpointName, out resourceName))
            {
                result = FromProjectLocationIndexEndpoint(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(indexEndpointName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IndexEndpointName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string indexEndpointId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            IndexEndpointId = indexEndpointId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IndexEndpointName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexEndpointId">The <c>IndexEndpoint</c> ID. Must not be <c>null</c> or empty.</param>
        public IndexEndpointName(string projectId, string locationId, string indexEndpointId) : this(ResourceNameType.ProjectLocationIndexEndpoint, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), indexEndpointId: gax::GaxPreconditions.CheckNotNullOrEmpty(indexEndpointId, nameof(indexEndpointId)))
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
        /// The <c>IndexEndpoint</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string IndexEndpointId { get; }

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
                case ResourceNameType.ProjectLocationIndexEndpoint: return s_projectLocationIndexEndpoint.Expand(ProjectId, LocationId, IndexEndpointId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IndexEndpointName);

        /// <inheritdoc/>
        public bool Equals(IndexEndpointName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(IndexEndpointName a, IndexEndpointName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(IndexEndpointName a, IndexEndpointName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SearchHypernym</c> resource.</summary>
    public sealed partial class SearchHypernymName : gax::IResourceName, sys::IEquatable<SearchHypernymName>
    {
        /// <summary>The possible contents of <see cref="SearchHypernymName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}</c>
            /// .
            /// </summary>
            ProjectNumberLocationCorpusSearchHypernym = 1,
        }

        private static gax::PathTemplate s_projectNumberLocationCorpusSearchHypernym = new gax::PathTemplate("projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}");

        /// <summary>Creates a <see cref="SearchHypernymName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SearchHypernymName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SearchHypernymName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SearchHypernymName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SearchHypernymName"/> with the pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchHypernymId">The <c>SearchHypernym</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SearchHypernymName"/> constructed from the provided ids.</returns>
        public static SearchHypernymName FromProjectNumberLocationCorpusSearchHypernym(string projectNumberId, string locationId, string corpusId, string searchHypernymId) =>
            new SearchHypernymName(ResourceNameType.ProjectNumberLocationCorpusSearchHypernym, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), searchHypernymId: gax::GaxPreconditions.CheckNotNullOrEmpty(searchHypernymId, nameof(searchHypernymId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SearchHypernymName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchHypernymId">The <c>SearchHypernym</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SearchHypernymName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}</c>.
        /// </returns>
        public static string Format(string projectNumberId, string locationId, string corpusId, string searchHypernymId) =>
            FormatProjectNumberLocationCorpusSearchHypernym(projectNumberId, locationId, corpusId, searchHypernymId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SearchHypernymName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchHypernymId">The <c>SearchHypernym</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SearchHypernymName"/> with pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}</c>.
        /// </returns>
        public static string FormatProjectNumberLocationCorpusSearchHypernym(string projectNumberId, string locationId, string corpusId, string searchHypernymId) =>
            s_projectNumberLocationCorpusSearchHypernym.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), gax::GaxPreconditions.CheckNotNullOrEmpty(searchHypernymId, nameof(searchHypernymId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SearchHypernymName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="searchHypernymName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SearchHypernymName"/> if successful.</returns>
        public static SearchHypernymName Parse(string searchHypernymName) => Parse(searchHypernymName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SearchHypernymName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="searchHypernymName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SearchHypernymName"/> if successful.</returns>
        public static SearchHypernymName Parse(string searchHypernymName, bool allowUnparsed) =>
            TryParse(searchHypernymName, allowUnparsed, out SearchHypernymName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SearchHypernymName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="searchHypernymName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SearchHypernymName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string searchHypernymName, out SearchHypernymName result) =>
            TryParse(searchHypernymName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SearchHypernymName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="searchHypernymName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SearchHypernymName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string searchHypernymName, bool allowUnparsed, out SearchHypernymName result)
        {
            gax::GaxPreconditions.CheckNotNull(searchHypernymName, nameof(searchHypernymName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNumberLocationCorpusSearchHypernym.TryParseName(searchHypernymName, out resourceName))
            {
                result = FromProjectNumberLocationCorpusSearchHypernym(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(searchHypernymName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SearchHypernymName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string corpusId = null, string locationId = null, string projectNumberId = null, string searchHypernymId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CorpusId = corpusId;
            LocationId = locationId;
            ProjectNumberId = projectNumberId;
            SearchHypernymId = searchHypernymId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SearchHypernymName"/> class from the component parts of pattern
        /// <c>projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}</c>
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="corpusId">The <c>Corpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchHypernymId">The <c>SearchHypernym</c> ID. Must not be <c>null</c> or empty.</param>
        public SearchHypernymName(string projectNumberId, string locationId, string corpusId, string searchHypernymId) : this(ResourceNameType.ProjectNumberLocationCorpusSearchHypernym, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), corpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(corpusId, nameof(corpusId)), searchHypernymId: gax::GaxPreconditions.CheckNotNullOrEmpty(searchHypernymId, nameof(searchHypernymId)))
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
        /// The <c>Corpus</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CorpusId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>ProjectNumber</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ProjectNumberId { get; }

        /// <summary>
        /// The <c>SearchHypernym</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SearchHypernymId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNumberLocationCorpusSearchHypernym: return s_projectNumberLocationCorpusSearchHypernym.Expand(ProjectNumberId, LocationId, CorpusId, SearchHypernymId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SearchHypernymName);

        /// <inheritdoc/>
        public bool Equals(SearchHypernymName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SearchHypernymName a, SearchHypernymName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SearchHypernymName a, SearchHypernymName b) => !(a == b);
    }

    public partial class CreateAssetRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CorpusName ParentAsCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAssetRequest
    {
        /// <summary>
        /// <see cref="gcvv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAssetsRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CorpusName ParentAsCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAssetRequest
    {
        /// <summary>
        /// <see cref="gcvv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UploadAssetRequest
    {
        /// <summary>
        /// <see cref="gcvv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateRetrievalUrlRequest
    {
        /// <summary>
        /// <see cref="gcvv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Asset
    {
        /// <summary>
        /// <see cref="gcvv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AnalyzeAssetRequest
    {
        /// <summary>
        /// <see cref="gcvv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class IndexAssetRequest
    {
        /// <summary>
        /// <see cref="gcvv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="IndexName"/>-typed view over the <see cref="Index"/> resource name property.</summary>
        public IndexName IndexAsIndexName
        {
            get => string.IsNullOrEmpty(Index) ? null : IndexName.Parse(Index, allowUnparsed: true);
            set => Index = value?.ToString() ?? "";
        }
    }

    public partial class RemoveIndexAssetRequest
    {
        /// <summary>
        /// <see cref="gcvv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="IndexName"/>-typed view over the <see cref="Index"/> resource name property.</summary>
        public IndexName IndexAsIndexName
        {
            get => string.IsNullOrEmpty(Index) ? null : IndexName.Parse(Index, allowUnparsed: true);
            set => Index = value?.ToString() ?? "";
        }
    }

    public partial class IndexedAsset
    {
        /// <summary><see cref="IndexName"/>-typed view over the <see cref="Index"/> resource name property.</summary>
        public IndexName IndexAsIndexName
        {
            get => string.IsNullOrEmpty(Index) ? null : IndexName.Parse(Index, allowUnparsed: true);
            set => Index = value?.ToString() ?? "";
        }

        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.</summary>
        public AssetName AssetAsAssetName
        {
            get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
            set => Asset = value?.ToString() ?? "";
        }
    }

    public partial class ViewIndexedAssetsRequest
    {
        /// <summary><see cref="IndexName"/>-typed view over the <see cref="Index"/> resource name property.</summary>
        public IndexName IndexAsIndexName
        {
            get => string.IsNullOrEmpty(Index) ? null : IndexName.Parse(Index, allowUnparsed: true);
            set => Index = value?.ToString() ?? "";
        }
    }

    public partial class CreateCollectionRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CorpusName ParentAsCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCollectionRequest
    {
        /// <summary>
        /// <see cref="gcvv::CollectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CollectionName CollectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CollectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetCollectionRequest
    {
        /// <summary>
        /// <see cref="gcvv::CollectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CollectionName CollectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CollectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCollectionsRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CorpusName ParentAsCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ViewCollectionItemsRequest
    {
        /// <summary>
        /// <see cref="CollectionName"/>-typed view over the <see cref="Collection"/> resource name property.
        /// </summary>
        public CollectionName CollectionAsCollectionName
        {
            get => string.IsNullOrEmpty(Collection) ? null : CollectionName.Parse(Collection, allowUnparsed: true);
            set => Collection = value?.ToString() ?? "";
        }
    }

    public partial class Collection
    {
        /// <summary>
        /// <see cref="gcvv::CollectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CollectionName CollectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CollectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CollectionItem
    {
        /// <summary>
        /// <see cref="CollectionName"/>-typed view over the <see cref="Collection"/> resource name property.
        /// </summary>
        public CollectionName CollectionAsCollectionName
        {
            get => string.IsNullOrEmpty(Collection) ? null : CollectionName.Parse(Collection, allowUnparsed: true);
            set => Collection = value?.ToString() ?? "";
        }
    }

    public partial class CreateIndexRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CorpusName ParentAsCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetIndexRequest
    {
        /// <summary>
        /// <see cref="gcvv::IndexName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::IndexName IndexName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::IndexName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListIndexesRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CorpusName ParentAsCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteIndexRequest
    {
        /// <summary>
        /// <see cref="gcvv::IndexName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::IndexName IndexName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::IndexName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Index
    {
        /// <summary>
        /// <see cref="gcvv::IndexName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::IndexName IndexName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::IndexName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeployedIndexReference
    {
        /// <summary>
        /// <see cref="IndexEndpointName"/>-typed view over the <see cref="IndexEndpoint"/> resource name property.
        /// </summary>
        public IndexEndpointName IndexEndpointAsIndexEndpointName
        {
            get => string.IsNullOrEmpty(IndexEndpoint) ? null : IndexEndpointName.Parse(IndexEndpoint, allowUnparsed: true);
            set => IndexEndpoint = value?.ToString() ?? "";
        }
    }

    public partial class Corpus
    {
        /// <summary>
        /// <see cref="gcvv::CorpusName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CorpusName CorpusName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CorpusName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetCorpusRequest
    {
        /// <summary>
        /// <see cref="gcvv::CorpusName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CorpusName CorpusName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CorpusName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCorpusRequest
    {
        /// <summary>
        /// <see cref="gcvv::CorpusName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CorpusName CorpusName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CorpusName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AnalyzeCorpusRequest
    {
        /// <summary>
        /// <see cref="gcvv::CorpusName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CorpusName CorpusName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CorpusName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDataSchemaRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CorpusName ParentAsCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DataSchema
    {
        /// <summary>
        /// <see cref="gcvv::DataSchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::DataSchemaName DataSchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::DataSchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDataSchemaRequest
    {
        /// <summary>
        /// <see cref="gcvv::DataSchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::DataSchemaName DataSchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::DataSchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDataSchemaRequest
    {
        /// <summary>
        /// <see cref="gcvv::DataSchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::DataSchemaName DataSchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::DataSchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataSchemasRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CorpusName ParentAsCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateAnnotationRequest
    {
        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AssetName ParentAsAssetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AssetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class Annotation
    {
        /// <summary>
        /// <see cref="gcvv::AnnotationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AnnotationName AnnotationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AnnotationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAnnotationsRequest
    {
        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AssetName ParentAsAssetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AssetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAnnotationRequest
    {
        /// <summary>
        /// <see cref="gcvv::AnnotationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AnnotationName AnnotationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AnnotationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAnnotationRequest
    {
        /// <summary>
        /// <see cref="gcvv::AnnotationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AnnotationName AnnotationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AnnotationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportAssetsRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CorpusName ParentAsCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateSearchConfigRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CorpusName ParentAsCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSearchConfigRequest
    {
        /// <summary>
        /// <see cref="gcvv::SearchConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::SearchConfigName SearchConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::SearchConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSearchConfigRequest
    {
        /// <summary>
        /// <see cref="gcvv::SearchConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::SearchConfigName SearchConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::SearchConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSearchConfigsRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CorpusName ParentAsCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class SearchConfig
    {
        /// <summary>
        /// <see cref="gcvv::SearchConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::SearchConfigName SearchConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::SearchConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class IndexEndpoint
    {
        /// <summary>
        /// <see cref="gcvv::IndexEndpointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::IndexEndpointName IndexEndpointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::IndexEndpointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateIndexEndpointRequest
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

    public partial class GetIndexEndpointRequest
    {
        /// <summary>
        /// <see cref="gcvv::IndexEndpointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::IndexEndpointName IndexEndpointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::IndexEndpointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListIndexEndpointsRequest
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

    public partial class DeleteIndexEndpointRequest
    {
        /// <summary>
        /// <see cref="gcvv::IndexEndpointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::IndexEndpointName IndexEndpointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::IndexEndpointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeployIndexRequest
    {
        /// <summary>
        /// <see cref="IndexEndpointName"/>-typed view over the <see cref="IndexEndpoint"/> resource name property.
        /// </summary>
        public IndexEndpointName IndexEndpointAsIndexEndpointName
        {
            get => string.IsNullOrEmpty(IndexEndpoint) ? null : IndexEndpointName.Parse(IndexEndpoint, allowUnparsed: true);
            set => IndexEndpoint = value?.ToString() ?? "";
        }
    }

    public partial class DeployIndexMetadata
    {
        /// <summary>
        /// <see cref="IndexName"/>-typed view over the <see cref="DeployedIndex"/> resource name property.
        /// </summary>
        public IndexName DeployedIndexAsIndexName
        {
            get => string.IsNullOrEmpty(DeployedIndex) ? null : IndexName.Parse(DeployedIndex, allowUnparsed: true);
            set => DeployedIndex = value?.ToString() ?? "";
        }
    }

    public partial class UndeployIndexMetadata
    {
        /// <summary>
        /// <see cref="IndexName"/>-typed view over the <see cref="DeployedIndex"/> resource name property.
        /// </summary>
        public IndexName DeployedIndexAsIndexName
        {
            get => string.IsNullOrEmpty(DeployedIndex) ? null : IndexName.Parse(DeployedIndex, allowUnparsed: true);
            set => DeployedIndex = value?.ToString() ?? "";
        }
    }

    public partial class UndeployIndexRequest
    {
        /// <summary>
        /// <see cref="IndexEndpointName"/>-typed view over the <see cref="IndexEndpoint"/> resource name property.
        /// </summary>
        public IndexEndpointName IndexEndpointAsIndexEndpointName
        {
            get => string.IsNullOrEmpty(IndexEndpoint) ? null : IndexEndpointName.Parse(IndexEndpoint, allowUnparsed: true);
            set => IndexEndpoint = value?.ToString() ?? "";
        }
    }

    public partial class DeployedIndex
    {
        /// <summary><see cref="IndexName"/>-typed view over the <see cref="Index"/> resource name property.</summary>
        public IndexName IndexAsIndexName
        {
            get => string.IsNullOrEmpty(Index) ? null : IndexName.Parse(Index, allowUnparsed: true);
            set => Index = value?.ToString() ?? "";
        }
    }

    public partial class SearchHypernym
    {
        /// <summary>
        /// <see cref="gcvv::SearchHypernymName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::SearchHypernymName SearchHypernymName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::SearchHypernymName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSearchHypernymRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CorpusName ParentAsCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSearchHypernymRequest
    {
        /// <summary>
        /// <see cref="gcvv::SearchHypernymName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::SearchHypernymName SearchHypernymName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::SearchHypernymName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSearchHypernymRequest
    {
        /// <summary>
        /// <see cref="gcvv::SearchHypernymName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::SearchHypernymName SearchHypernymName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::SearchHypernymName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSearchHypernymsRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CorpusName ParentAsCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class IngestAssetRequest
    {
        public partial class Types
        {
            public partial class Config
            {
                /// <summary>
                /// <see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.
                /// </summary>
                public AssetName AssetAsAssetName
                {
                    get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
                    set => Asset = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ClipAssetRequest
    {
        /// <summary>
        /// <see cref="gcvv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateHlsUriRequest
    {
        /// <summary>
        /// <see cref="gcvv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SearchAssetsRequest
    {
        /// <summary><see cref="CorpusName"/>-typed view over the <see cref="Corpus"/> resource name property.</summary>
        public CorpusName CorpusAsCorpusName
        {
            get => string.IsNullOrEmpty(Corpus) ? null : CorpusName.Parse(Corpus, allowUnparsed: true);
            set => Corpus = value?.ToString() ?? "";
        }
    }

    public partial class SearchIndexEndpointRequest
    {
        /// <summary>
        /// <see cref="IndexEndpointName"/>-typed view over the <see cref="IndexEndpoint"/> resource name property.
        /// </summary>
        public IndexEndpointName IndexEndpointAsIndexEndpointName
        {
            get => string.IsNullOrEmpty(IndexEndpoint) ? null : IndexEndpointName.Parse(IndexEndpoint, allowUnparsed: true);
            set => IndexEndpoint = value?.ToString() ?? "";
        }
    }

    public partial class ImageQuery
    {
        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.</summary>
        public AssetName AssetAsAssetName
        {
            get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
            set => Asset = value?.ToString() ?? "";
        }
    }
}

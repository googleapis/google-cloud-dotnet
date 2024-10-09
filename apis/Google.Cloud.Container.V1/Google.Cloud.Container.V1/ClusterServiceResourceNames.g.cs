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
using sys = System;

namespace Google.Cloud.Container.V1
{
    /// <summary>Resource name for the <c>Topic</c> resource.</summary>
    public sealed partial class TopicName : gax::IResourceName, sys::IEquatable<TopicName>
    {
        /// <summary>The possible contents of <see cref="TopicName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/topics/{topic}</c>.</summary>
            ProjectTopic = 1,
        }

        private static gax::PathTemplate s_projectTopic = new gax::PathTemplate("projects/{project}/topics/{topic}");

        /// <summary>Creates a <see cref="TopicName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TopicName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TopicName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TopicName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TopicName"/> with the pattern <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TopicName"/> constructed from the provided ids.</returns>
        public static TopicName FromProjectTopic(string projectId, string topicId) =>
            new TopicName(ResourceNameType.ProjectTopic, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), topicId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicName"/> with pattern
        /// <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicName"/> with pattern <c>projects/{project}/topics/{topic}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string topicId) => FormatProjectTopic(projectId, topicId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicName"/> with pattern
        /// <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicName"/> with pattern <c>projects/{project}/topics/{topic}</c>
        /// .
        /// </returns>
        public static string FormatProjectTopic(string projectId, string topicId) =>
            s_projectTopic.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)));

        /// <summary>Parses the given resource name string into a new <see cref="TopicName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName) => Parse(topicName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TopicName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName, bool allowUnparsed) =>
            TryParse(topicName, allowUnparsed, out TopicName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, out TopicName result) => TryParse(topicName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, bool allowUnparsed, out TopicName result)
        {
            gax::GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTopic.TryParseName(topicName, out resourceName))
            {
                result = FromProjectTopic(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(topicName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TopicName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string topicId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            TopicId = topicId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TopicName"/> class from the component parts of pattern
        /// <c>projects/{project}/topics/{topic}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        public TopicName(string projectId, string topicId) : this(ResourceNameType.ProjectTopic, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), topicId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Topic</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TopicId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTopic: return s_projectTopic.Expand(ProjectId, TopicId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TopicName);

        /// <inheritdoc/>
        public bool Equals(TopicName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TopicName a, TopicName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TopicName a, TopicName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CaPool</c> resource.</summary>
    public sealed partial class CaPoolName : gax::IResourceName, sys::IEquatable<CaPoolName>
    {
        /// <summary>The possible contents of <see cref="CaPoolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
            /// </summary>
            ProjectLocationCaPool = 1,
        }

        private static gax::PathTemplate s_projectLocationCaPool = new gax::PathTemplate("projects/{project}/locations/{location}/caPools/{ca_pool}");

        /// <summary>Creates a <see cref="CaPoolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CaPoolName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CaPoolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CaPoolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CaPoolName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CaPoolName"/> constructed from the provided ids.</returns>
        public static CaPoolName FromProjectLocationCaPool(string projectId, string locationId, string caPoolId) =>
            new CaPoolName(ResourceNameType.ProjectLocationCaPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), caPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CaPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CaPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string caPoolId) =>
            FormatProjectLocationCaPool(projectId, locationId, caPoolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CaPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CaPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </returns>
        public static string FormatProjectLocationCaPool(string projectId, string locationId, string caPoolId) =>
            s_projectLocationCaPool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)));

        /// <summary>Parses the given resource name string into a new <see cref="CaPoolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/caPools/{ca_pool}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="caPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CaPoolName"/> if successful.</returns>
        public static CaPoolName Parse(string caPoolName) => Parse(caPoolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CaPoolName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/caPools/{ca_pool}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="caPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CaPoolName"/> if successful.</returns>
        public static CaPoolName Parse(string caPoolName, bool allowUnparsed) =>
            TryParse(caPoolName, allowUnparsed, out CaPoolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CaPoolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/caPools/{ca_pool}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="caPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CaPoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string caPoolName, out CaPoolName result) => TryParse(caPoolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CaPoolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/caPools/{ca_pool}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="caPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CaPoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string caPoolName, bool allowUnparsed, out CaPoolName result)
        {
            gax::GaxPreconditions.CheckNotNull(caPoolName, nameof(caPoolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCaPool.TryParseName(caPoolName, out resourceName))
            {
                result = FromProjectLocationCaPool(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(caPoolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CaPoolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string caPoolId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CaPoolId = caPoolId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CaPoolName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        public CaPoolName(string projectId, string locationId, string caPoolId) : this(ResourceNameType.ProjectLocationCaPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), caPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)))
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
        /// The <c>CaPool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CaPoolId { get; }

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
                case ResourceNameType.ProjectLocationCaPool: return s_projectLocationCaPool.Expand(ProjectId, LocationId, CaPoolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CaPoolName);

        /// <inheritdoc/>
        public bool Equals(CaPoolName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CaPoolName a, CaPoolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CaPoolName a, CaPoolName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CryptoKeyVersion</c> resource.</summary>
    public sealed partial class CryptoKeyVersionName : gax::IResourceName, sys::IEquatable<CryptoKeyVersionName>
    {
        /// <summary>The possible contents of <see cref="CryptoKeyVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
            /// .
            /// </summary>
            ProjectLocationKeyRingCryptoKeyCryptoKeyVersion = 1,
        }

        private static gax::PathTemplate s_projectLocationKeyRingCryptoKeyCryptoKeyVersion = new gax::PathTemplate("projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}");

        /// <summary>Creates a <see cref="CryptoKeyVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CryptoKeyVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CryptoKeyVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CryptoKeyVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CryptoKeyVersionName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyVersionId">The <c>CryptoKeyVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CryptoKeyVersionName"/> constructed from the provided ids.</returns>
        public static CryptoKeyVersionName FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion(string projectId, string locationId, string keyRingId, string cryptoKeyId, string cryptoKeyVersionId) =>
            new CryptoKeyVersionName(ResourceNameType.ProjectLocationKeyRingCryptoKeyCryptoKeyVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyRingId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), cryptoKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)), cryptoKeyVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyVersionId, nameof(cryptoKeyVersionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CryptoKeyVersionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyVersionId">The <c>CryptoKeyVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CryptoKeyVersionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string keyRingId, string cryptoKeyId, string cryptoKeyVersionId) =>
            FormatProjectLocationKeyRingCryptoKeyCryptoKeyVersion(projectId, locationId, keyRingId, cryptoKeyId, cryptoKeyVersionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CryptoKeyVersionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyVersionId">The <c>CryptoKeyVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CryptoKeyVersionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationKeyRingCryptoKeyCryptoKeyVersion(string projectId, string locationId, string keyRingId, string cryptoKeyId, string cryptoKeyVersionId) =>
            s_projectLocationKeyRingCryptoKeyCryptoKeyVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyVersionId, nameof(cryptoKeyVersionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CryptoKeyVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cryptoKeyVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CryptoKeyVersionName"/> if successful.</returns>
        public static CryptoKeyVersionName Parse(string cryptoKeyVersionName) => Parse(cryptoKeyVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CryptoKeyVersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cryptoKeyVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CryptoKeyVersionName"/> if successful.</returns>
        public static CryptoKeyVersionName Parse(string cryptoKeyVersionName, bool allowUnparsed) =>
            TryParse(cryptoKeyVersionName, allowUnparsed, out CryptoKeyVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CryptoKeyVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cryptoKeyVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CryptoKeyVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cryptoKeyVersionName, out CryptoKeyVersionName result) =>
            TryParse(cryptoKeyVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CryptoKeyVersionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cryptoKeyVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CryptoKeyVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cryptoKeyVersionName, bool allowUnparsed, out CryptoKeyVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(cryptoKeyVersionName, nameof(cryptoKeyVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationKeyRingCryptoKeyCryptoKeyVersion.TryParseName(cryptoKeyVersionName, out resourceName))
            {
                result = FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cryptoKeyVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CryptoKeyVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cryptoKeyId = null, string cryptoKeyVersionId = null, string keyRingId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CryptoKeyId = cryptoKeyId;
            CryptoKeyVersionId = cryptoKeyVersionId;
            KeyRingId = keyRingId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CryptoKeyVersionName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyVersionId">The <c>CryptoKeyVersion</c> ID. Must not be <c>null</c> or empty.</param>
        public CryptoKeyVersionName(string projectId, string locationId, string keyRingId, string cryptoKeyId, string cryptoKeyVersionId) : this(ResourceNameType.ProjectLocationKeyRingCryptoKeyCryptoKeyVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyRingId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), cryptoKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)), cryptoKeyVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyVersionId, nameof(cryptoKeyVersionId)))
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
        /// The <c>CryptoKey</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CryptoKeyId { get; }

        /// <summary>
        /// The <c>CryptoKeyVersion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CryptoKeyVersionId { get; }

        /// <summary>
        /// The <c>KeyRing</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string KeyRingId { get; }

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
                case ResourceNameType.ProjectLocationKeyRingCryptoKeyCryptoKeyVersion: return s_projectLocationKeyRingCryptoKeyCryptoKeyVersion.Expand(ProjectId, LocationId, KeyRingId, CryptoKeyId, CryptoKeyVersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CryptoKeyVersionName);

        /// <inheritdoc/>
        public bool Equals(CryptoKeyVersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CryptoKeyVersionName a, CryptoKeyVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CryptoKeyVersionName a, CryptoKeyVersionName b) => !(a == b);
    }

    public partial class UserManagedKeysConfig
    {
        /// <summary>
        /// <see cref="CaPoolName"/>-typed view over the <see cref="ClusterCa"/> resource name property.
        /// </summary>
        public CaPoolName ClusterCaAsCaPoolName
        {
            get => string.IsNullOrEmpty(ClusterCa) ? null : CaPoolName.Parse(ClusterCa, allowUnparsed: true);
            set => ClusterCa = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CaPoolName"/>-typed view over the <see cref="EtcdApiCa"/> resource name property.
        /// </summary>
        public CaPoolName EtcdApiCaAsCaPoolName
        {
            get => string.IsNullOrEmpty(EtcdApiCa) ? null : CaPoolName.Parse(EtcdApiCa, allowUnparsed: true);
            set => EtcdApiCa = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CaPoolName"/>-typed view over the <see cref="EtcdPeerCa"/> resource name property.
        /// </summary>
        public CaPoolName EtcdPeerCaAsCaPoolName
        {
            get => string.IsNullOrEmpty(EtcdPeerCa) ? null : CaPoolName.Parse(EtcdPeerCa, allowUnparsed: true);
            set => EtcdPeerCa = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CryptoKeyVersionName"/>-typed view over the <see cref="ServiceAccountSigningKeys"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<CryptoKeyVersionName> ServiceAccountSigningKeysAsCryptoKeyVersionNames
        {
            get => new gax::ResourceNameList<CryptoKeyVersionName>(ServiceAccountSigningKeys, s => string.IsNullOrEmpty(s) ? null : CryptoKeyVersionName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="CryptoKeyVersionName"/>-typed view over the <see cref="ServiceAccountVerificationKeys"/> resource
        /// name property.
        /// </summary>
        public gax::ResourceNameList<CryptoKeyVersionName> ServiceAccountVerificationKeysAsCryptoKeyVersionNames
        {
            get => new gax::ResourceNameList<CryptoKeyVersionName>(ServiceAccountVerificationKeys, s => string.IsNullOrEmpty(s) ? null : CryptoKeyVersionName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="CaPoolName"/>-typed view over the <see cref="AggregationCa"/> resource name property.
        /// </summary>
        public CaPoolName AggregationCaAsCaPoolName
        {
            get => string.IsNullOrEmpty(AggregationCa) ? null : CaPoolName.Parse(AggregationCa, allowUnparsed: true);
            set => AggregationCa = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CryptoKeyVersionName"/>-typed view over the <see cref="ControlPlaneDiskEncryptionKey"/> resource
        /// name property.
        /// </summary>
        public CryptoKeyVersionName ControlPlaneDiskEncryptionKeyAsCryptoKeyVersionName
        {
            get => string.IsNullOrEmpty(ControlPlaneDiskEncryptionKey) ? null : CryptoKeyVersionName.Parse(ControlPlaneDiskEncryptionKey, allowUnparsed: true);
            set => ControlPlaneDiskEncryptionKey = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CryptoKeyVersionName"/>-typed view over the <see cref="GkeopsEtcdBackupEncryptionKey"/> resource
        /// name property.
        /// </summary>
        public CryptoKeyVersionName GkeopsEtcdBackupEncryptionKeyAsCryptoKeyVersionName
        {
            get => string.IsNullOrEmpty(GkeopsEtcdBackupEncryptionKey) ? null : CryptoKeyVersionName.Parse(GkeopsEtcdBackupEncryptionKey, allowUnparsed: true);
            set => GkeopsEtcdBackupEncryptionKey = value?.ToString() ?? "";
        }
    }

    public partial class NotificationConfig
    {
        public partial class Types
        {
            public partial class PubSub
            {
                /// <summary>
                /// <see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.
                /// </summary>
                public TopicName TopicAsTopicName
                {
                    get => string.IsNullOrEmpty(Topic) ? null : TopicName.Parse(Topic, allowUnparsed: true);
                    set => Topic = value?.ToString() ?? "";
                }
            }
        }
    }
}

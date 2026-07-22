// Copyright 2026 Google LLC
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
using gaav = Google.Ads.AdManager.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Resource name for the <c>CreativeSet</c> resource.</summary>
    public sealed partial class CreativeSetName : gax::IResourceName, sys::IEquatable<CreativeSetName>
    {
        /// <summary>The possible contents of <see cref="CreativeSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/creativeSets/{creative_set}</c>.
            /// </summary>
            NetworkCodeCreativeSet = 1,
        }

        private static gax::PathTemplate s_networkCodeCreativeSet = new gax::PathTemplate("networks/{network_code}/creativeSets/{creative_set}");

        /// <summary>Creates a <see cref="CreativeSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CreativeSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CreativeSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CreativeSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CreativeSetName"/> with the pattern
        /// <c>networks/{network_code}/creativeSets/{creative_set}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="creativeSetId">The <c>CreativeSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CreativeSetName"/> constructed from the provided ids.</returns>
        public static CreativeSetName FromNetworkCodeCreativeSet(string networkCodeId, string creativeSetId) =>
            new CreativeSetName(ResourceNameType.NetworkCodeCreativeSet, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), creativeSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(creativeSetId, nameof(creativeSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CreativeSetName"/> with pattern
        /// <c>networks/{network_code}/creativeSets/{creative_set}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="creativeSetId">The <c>CreativeSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CreativeSetName"/> with pattern
        /// <c>networks/{network_code}/creativeSets/{creative_set}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string creativeSetId) =>
            FormatNetworkCodeCreativeSet(networkCodeId, creativeSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CreativeSetName"/> with pattern
        /// <c>networks/{network_code}/creativeSets/{creative_set}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="creativeSetId">The <c>CreativeSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CreativeSetName"/> with pattern
        /// <c>networks/{network_code}/creativeSets/{creative_set}</c>.
        /// </returns>
        public static string FormatNetworkCodeCreativeSet(string networkCodeId, string creativeSetId) =>
            s_networkCodeCreativeSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(creativeSetId, nameof(creativeSetId)));

        /// <summary>Parses the given resource name string into a new <see cref="CreativeSetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/creativeSets/{creative_set}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="creativeSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CreativeSetName"/> if successful.</returns>
        public static CreativeSetName Parse(string creativeSetName) => Parse(creativeSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CreativeSetName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/creativeSets/{creative_set}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="creativeSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CreativeSetName"/> if successful.</returns>
        public static CreativeSetName Parse(string creativeSetName, bool allowUnparsed) =>
            TryParse(creativeSetName, allowUnparsed, out CreativeSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CreativeSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/creativeSets/{creative_set}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="creativeSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CreativeSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string creativeSetName, out CreativeSetName result) =>
            TryParse(creativeSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CreativeSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/creativeSets/{creative_set}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="creativeSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CreativeSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string creativeSetName, bool allowUnparsed, out CreativeSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(creativeSetName, nameof(creativeSetName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeCreativeSet.TryParseName(creativeSetName, out resourceName))
            {
                result = FromNetworkCodeCreativeSet(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(creativeSetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CreativeSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string creativeSetId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CreativeSetId = creativeSetId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CreativeSetName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/creativeSets/{creative_set}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="creativeSetId">The <c>CreativeSet</c> ID. Must not be <c>null</c> or empty.</param>
        public CreativeSetName(string networkCodeId, string creativeSetId) : this(ResourceNameType.NetworkCodeCreativeSet, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), creativeSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(creativeSetId, nameof(creativeSetId)))
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
        /// The <c>CreativeSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CreativeSetId { get; }

        /// <summary>
        /// The <c>NetworkCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkCodeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeCreativeSet: return s_networkCodeCreativeSet.Expand(NetworkCodeId, CreativeSetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CreativeSetName);

        /// <inheritdoc/>
        public bool Equals(CreativeSetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CreativeSetName a, CreativeSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CreativeSetName a, CreativeSetName b) => !(a == b);
    }

    public partial class CreativeSet
    {
        /// <summary>
        /// <see cref="gaav::CreativeSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::CreativeSetName CreativeSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::CreativeSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CreativeName"/>-typed view over the <see cref="MasterCreative"/> resource name property.
        /// </summary>
        public CreativeName MasterCreativeAsCreativeName
        {
            get => string.IsNullOrEmpty(MasterCreative) ? null : CreativeName.Parse(MasterCreative, allowUnparsed: true);
            set => MasterCreative = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CreativeName"/>-typed view over the <see cref="CompanionCreatives"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<CreativeName> CompanionCreativesAsCreativeNames
        {
            get => new gax::ResourceNameList<CreativeName>(CompanionCreatives, s => string.IsNullOrEmpty(s) ? null : CreativeName.Parse(s, allowUnparsed: true));
        }
    }
}

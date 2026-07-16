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
    /// <summary>Resource name for the <c>TargetingPreset</c> resource.</summary>
    public sealed partial class TargetingPresetName : gax::IResourceName, sys::IEquatable<TargetingPresetName>
    {
        /// <summary>The possible contents of <see cref="TargetingPresetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/targetingPresets/{targeting_preset}</c>.
            /// </summary>
            NetworkCodeTargetingPreset = 1,
        }

        private static gax::PathTemplate s_networkCodeTargetingPreset = new gax::PathTemplate("networks/{network_code}/targetingPresets/{targeting_preset}");

        /// <summary>Creates a <see cref="TargetingPresetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TargetingPresetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TargetingPresetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TargetingPresetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TargetingPresetName"/> with the pattern
        /// <c>networks/{network_code}/targetingPresets/{targeting_preset}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetingPresetId">The <c>TargetingPreset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TargetingPresetName"/> constructed from the provided ids.</returns>
        public static TargetingPresetName FromNetworkCodeTargetingPreset(string networkCodeId, string targetingPresetId) =>
            new TargetingPresetName(ResourceNameType.NetworkCodeTargetingPreset, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), targetingPresetId: gax::GaxPreconditions.CheckNotNullOrEmpty(targetingPresetId, nameof(targetingPresetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TargetingPresetName"/> with pattern
        /// <c>networks/{network_code}/targetingPresets/{targeting_preset}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetingPresetId">The <c>TargetingPreset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TargetingPresetName"/> with pattern
        /// <c>networks/{network_code}/targetingPresets/{targeting_preset}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string targetingPresetId) =>
            FormatNetworkCodeTargetingPreset(networkCodeId, targetingPresetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TargetingPresetName"/> with pattern
        /// <c>networks/{network_code}/targetingPresets/{targeting_preset}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetingPresetId">The <c>TargetingPreset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TargetingPresetName"/> with pattern
        /// <c>networks/{network_code}/targetingPresets/{targeting_preset}</c>.
        /// </returns>
        public static string FormatNetworkCodeTargetingPreset(string networkCodeId, string targetingPresetId) =>
            s_networkCodeTargetingPreset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(targetingPresetId, nameof(targetingPresetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TargetingPresetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/targetingPresets/{targeting_preset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="targetingPresetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TargetingPresetName"/> if successful.</returns>
        public static TargetingPresetName Parse(string targetingPresetName) => Parse(targetingPresetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TargetingPresetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/targetingPresets/{targeting_preset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="targetingPresetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TargetingPresetName"/> if successful.</returns>
        public static TargetingPresetName Parse(string targetingPresetName, bool allowUnparsed) =>
            TryParse(targetingPresetName, allowUnparsed, out TargetingPresetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TargetingPresetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/targetingPresets/{targeting_preset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="targetingPresetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TargetingPresetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string targetingPresetName, out TargetingPresetName result) =>
            TryParse(targetingPresetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TargetingPresetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/targetingPresets/{targeting_preset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="targetingPresetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TargetingPresetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string targetingPresetName, bool allowUnparsed, out TargetingPresetName result)
        {
            gax::GaxPreconditions.CheckNotNull(targetingPresetName, nameof(targetingPresetName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeTargetingPreset.TryParseName(targetingPresetName, out resourceName))
            {
                result = FromNetworkCodeTargetingPreset(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(targetingPresetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TargetingPresetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkCodeId = null, string targetingPresetId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkCodeId = networkCodeId;
            TargetingPresetId = targetingPresetId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TargetingPresetName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/targetingPresets/{targeting_preset}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetingPresetId">The <c>TargetingPreset</c> ID. Must not be <c>null</c> or empty.</param>
        public TargetingPresetName(string networkCodeId, string targetingPresetId) : this(ResourceNameType.NetworkCodeTargetingPreset, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), targetingPresetId: gax::GaxPreconditions.CheckNotNullOrEmpty(targetingPresetId, nameof(targetingPresetId)))
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
        /// The <c>NetworkCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkCodeId { get; }

        /// <summary>
        /// The <c>TargetingPreset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string TargetingPresetId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeTargetingPreset: return s_networkCodeTargetingPreset.Expand(NetworkCodeId, TargetingPresetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TargetingPresetName);

        /// <inheritdoc/>
        public bool Equals(TargetingPresetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TargetingPresetName a, TargetingPresetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TargetingPresetName a, TargetingPresetName b) => !(a == b);
    }

    public partial class TargetingPreset
    {
        /// <summary>
        /// <see cref="gaav::TargetingPresetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::TargetingPresetName TargetingPresetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::TargetingPresetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

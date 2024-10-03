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
using gaav = Google.Ads.AdManager.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Resource name for the <c>AdUnit</c> resource.</summary>
    public sealed partial class AdUnitName : gax::IResourceName, sys::IEquatable<AdUnitName>
    {
        /// <summary>The possible contents of <see cref="AdUnitName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>networks/{network_code}/adUnits/{ad_unit}</c>.</summary>
            NetworkCodeAdUnit = 1,
        }

        private static gax::PathTemplate s_networkCodeAdUnit = new gax::PathTemplate("networks/{network_code}/adUnits/{ad_unit}");

        /// <summary>Creates a <see cref="AdUnitName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdUnitName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdUnitName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdUnitName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdUnitName"/> with the pattern <c>networks/{network_code}/adUnits/{ad_unit}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adUnitId">The <c>AdUnit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdUnitName"/> constructed from the provided ids.</returns>
        public static AdUnitName FromNetworkCodeAdUnit(string networkCodeId, string adUnitId) =>
            new AdUnitName(ResourceNameType.NetworkCodeAdUnit, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), adUnitId: gax::GaxPreconditions.CheckNotNullOrEmpty(adUnitId, nameof(adUnitId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdUnitName"/> with pattern
        /// <c>networks/{network_code}/adUnits/{ad_unit}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adUnitId">The <c>AdUnit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdUnitName"/> with pattern
        /// <c>networks/{network_code}/adUnits/{ad_unit}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string adUnitId) => FormatNetworkCodeAdUnit(networkCodeId, adUnitId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdUnitName"/> with pattern
        /// <c>networks/{network_code}/adUnits/{ad_unit}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adUnitId">The <c>AdUnit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdUnitName"/> with pattern
        /// <c>networks/{network_code}/adUnits/{ad_unit}</c>.
        /// </returns>
        public static string FormatNetworkCodeAdUnit(string networkCodeId, string adUnitId) =>
            s_networkCodeAdUnit.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adUnitId, nameof(adUnitId)));

        /// <summary>Parses the given resource name string into a new <see cref="AdUnitName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/adUnits/{ad_unit}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adUnitName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdUnitName"/> if successful.</returns>
        public static AdUnitName Parse(string adUnitName) => Parse(adUnitName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdUnitName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/adUnits/{ad_unit}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adUnitName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdUnitName"/> if successful.</returns>
        public static AdUnitName Parse(string adUnitName, bool allowUnparsed) =>
            TryParse(adUnitName, allowUnparsed, out AdUnitName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdUnitName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/adUnits/{ad_unit}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adUnitName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdUnitName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adUnitName, out AdUnitName result) => TryParse(adUnitName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdUnitName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/adUnits/{ad_unit}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adUnitName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdUnitName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adUnitName, bool allowUnparsed, out AdUnitName result)
        {
            gax::GaxPreconditions.CheckNotNull(adUnitName, nameof(adUnitName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeAdUnit.TryParseName(adUnitName, out resourceName))
            {
                result = FromNetworkCodeAdUnit(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adUnitName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdUnitName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adUnitId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdUnitId = adUnitId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdUnitName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/adUnits/{ad_unit}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adUnitId">The <c>AdUnit</c> ID. Must not be <c>null</c> or empty.</param>
        public AdUnitName(string networkCodeId, string adUnitId) : this(ResourceNameType.NetworkCodeAdUnit, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), adUnitId: gax::GaxPreconditions.CheckNotNullOrEmpty(adUnitId, nameof(adUnitId)))
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
        /// The <c>AdUnit</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AdUnitId { get; }

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
                case ResourceNameType.NetworkCodeAdUnit: return s_networkCodeAdUnit.Expand(NetworkCodeId, AdUnitId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdUnitName);

        /// <inheritdoc/>
        public bool Equals(AdUnitName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AdUnitName a, AdUnitName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AdUnitName a, AdUnitName b) => !(a == b);
    }

    public partial class AdUnit
    {
        /// <summary>
        /// <see cref="gaav::AdUnitName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AdUnitName AdUnitName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AdUnitName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TeamName"/>-typed view over the <see cref="AppliedTeams"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<TeamName> AppliedTeamsAsTeamNames
        {
            get => new gax::ResourceNameList<TeamName>(AppliedTeams, s => string.IsNullOrEmpty(s) ? null : TeamName.Parse(s, allowUnparsed: true));
        }

        /// <summary><see cref="TeamName"/>-typed view over the <see cref="Teams"/> resource name property.</summary>
        public gax::ResourceNameList<TeamName> TeamsAsTeamNames
        {
            get => new gax::ResourceNameList<TeamName>(Teams, s => string.IsNullOrEmpty(s) ? null : TeamName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="gaav::AdUnitName"/>-typed view over the <see cref="ParentAdUnit"/> resource name property.
        /// </summary>
        public gaav::AdUnitName ParentAdUnitAsAdUnitName
        {
            get => string.IsNullOrEmpty(ParentAdUnit) ? null : gaav::AdUnitName.Parse(ParentAdUnit, allowUnparsed: true);
            set => ParentAdUnit = value?.ToString() ?? "";
        }
    }

    public partial class AdUnitParent
    {
        /// <summary>
        /// <see cref="AdUnitName"/>-typed view over the <see cref="ParentAdUnit"/> resource name property.
        /// </summary>
        public AdUnitName ParentAdUnitAsAdUnitName
        {
            get => string.IsNullOrEmpty(ParentAdUnit) ? null : AdUnitName.Parse(ParentAdUnit, allowUnparsed: true);
            set => ParentAdUnit = value?.ToString() ?? "";
        }
    }

    public partial class LabelFrequencyCap
    {
        /// <summary><see cref="LabelName"/>-typed view over the <see cref="Label"/> resource name property.</summary>
        public LabelName LabelAsLabelName
        {
            get => string.IsNullOrEmpty(Label) ? null : LabelName.Parse(Label, allowUnparsed: true);
            set => Label = value?.ToString() ?? "";
        }
    }
}

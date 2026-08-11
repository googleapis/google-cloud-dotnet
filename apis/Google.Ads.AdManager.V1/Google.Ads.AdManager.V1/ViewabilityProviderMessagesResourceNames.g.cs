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
    /// <summary>Resource name for the <c>ViewabilityProvider</c> resource.</summary>
    public sealed partial class ViewabilityProviderName : gax::IResourceName, sys::IEquatable<ViewabilityProviderName>
    {
        /// <summary>The possible contents of <see cref="ViewabilityProviderName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/viewabilityProviders/{viewability_provider}</c>.
            /// </summary>
            NetworkCodeViewabilityProvider = 1,
        }

        private static gax::PathTemplate s_networkCodeViewabilityProvider = new gax::PathTemplate("networks/{network_code}/viewabilityProviders/{viewability_provider}");

        /// <summary>Creates a <see cref="ViewabilityProviderName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ViewabilityProviderName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ViewabilityProviderName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ViewabilityProviderName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ViewabilityProviderName"/> with the pattern
        /// <c>networks/{network_code}/viewabilityProviders/{viewability_provider}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewabilityProviderId">
        /// The <c>ViewabilityProvider</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ViewabilityProviderName"/> constructed from the provided ids.
        /// </returns>
        public static ViewabilityProviderName FromNetworkCodeViewabilityProvider(string networkCodeId, string viewabilityProviderId) =>
            new ViewabilityProviderName(ResourceNameType.NetworkCodeViewabilityProvider, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), viewabilityProviderId: gax::GaxPreconditions.CheckNotNullOrEmpty(viewabilityProviderId, nameof(viewabilityProviderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ViewabilityProviderName"/> with pattern
        /// <c>networks/{network_code}/viewabilityProviders/{viewability_provider}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewabilityProviderId">
        /// The <c>ViewabilityProvider</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ViewabilityProviderName"/> with pattern
        /// <c>networks/{network_code}/viewabilityProviders/{viewability_provider}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string viewabilityProviderId) =>
            FormatNetworkCodeViewabilityProvider(networkCodeId, viewabilityProviderId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ViewabilityProviderName"/> with pattern
        /// <c>networks/{network_code}/viewabilityProviders/{viewability_provider}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewabilityProviderId">
        /// The <c>ViewabilityProvider</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ViewabilityProviderName"/> with pattern
        /// <c>networks/{network_code}/viewabilityProviders/{viewability_provider}</c>.
        /// </returns>
        public static string FormatNetworkCodeViewabilityProvider(string networkCodeId, string viewabilityProviderId) =>
            s_networkCodeViewabilityProvider.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(viewabilityProviderId, nameof(viewabilityProviderId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ViewabilityProviderName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/viewabilityProviders/{viewability_provider}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="viewabilityProviderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ViewabilityProviderName"/> if successful.</returns>
        public static ViewabilityProviderName Parse(string viewabilityProviderName) => Parse(viewabilityProviderName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ViewabilityProviderName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/viewabilityProviders/{viewability_provider}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="viewabilityProviderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ViewabilityProviderName"/> if successful.</returns>
        public static ViewabilityProviderName Parse(string viewabilityProviderName, bool allowUnparsed) =>
            TryParse(viewabilityProviderName, allowUnparsed, out ViewabilityProviderName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ViewabilityProviderName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/viewabilityProviders/{viewability_provider}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="viewabilityProviderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ViewabilityProviderName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string viewabilityProviderName, out ViewabilityProviderName result) =>
            TryParse(viewabilityProviderName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ViewabilityProviderName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/viewabilityProviders/{viewability_provider}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="viewabilityProviderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ViewabilityProviderName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string viewabilityProviderName, bool allowUnparsed, out ViewabilityProviderName result)
        {
            gax::GaxPreconditions.CheckNotNull(viewabilityProviderName, nameof(viewabilityProviderName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeViewabilityProvider.TryParseName(viewabilityProviderName, out resourceName))
            {
                result = FromNetworkCodeViewabilityProvider(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(viewabilityProviderName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ViewabilityProviderName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkCodeId = null, string viewabilityProviderId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkCodeId = networkCodeId;
            ViewabilityProviderId = viewabilityProviderId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ViewabilityProviderName"/> class from the component parts of
        /// pattern <c>networks/{network_code}/viewabilityProviders/{viewability_provider}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewabilityProviderId">
        /// The <c>ViewabilityProvider</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ViewabilityProviderName(string networkCodeId, string viewabilityProviderId) : this(ResourceNameType.NetworkCodeViewabilityProvider, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), viewabilityProviderId: gax::GaxPreconditions.CheckNotNullOrEmpty(viewabilityProviderId, nameof(viewabilityProviderId)))
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
        /// The <c>ViewabilityProvider</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ViewabilityProviderId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeViewabilityProvider: return s_networkCodeViewabilityProvider.Expand(NetworkCodeId, ViewabilityProviderId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ViewabilityProviderName);

        /// <inheritdoc/>
        public bool Equals(ViewabilityProviderName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ViewabilityProviderName a, ViewabilityProviderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ViewabilityProviderName a, ViewabilityProviderName b) => !(a == b);
    }

    public partial class ViewabilityProvider
    {
        /// <summary>
        /// <see cref="gaav::ViewabilityProviderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ViewabilityProviderName ViewabilityProviderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ViewabilityProviderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ContactName"/>-typed view over the <see cref="PrimaryContact"/> resource name property.
        /// </summary>
        public ContactName PrimaryContactAsContactName
        {
            get => string.IsNullOrEmpty(PrimaryContact) ? null : ContactName.Parse(PrimaryContact, allowUnparsed: true);
            set => PrimaryContact = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TeamName"/>-typed view over the <see cref="AppliedTeams"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<TeamName> AppliedTeamsAsTeamNames
        {
            get => new gax::ResourceNameList<TeamName>(AppliedTeams, s => string.IsNullOrEmpty(s) ? null : TeamName.Parse(s, allowUnparsed: true));
        }
    }
}

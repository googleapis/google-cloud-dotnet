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
    /// <summary>Resource name for the <c>Proposal</c> resource.</summary>
    public sealed partial class ProposalName : gax::IResourceName, sys::IEquatable<ProposalName>
    {
        /// <summary>The possible contents of <see cref="ProposalName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>networks/{network_code}/proposals/{proposal}</c>.</summary>
            NetworkCodeProposal = 1,
        }

        private static gax::PathTemplate s_networkCodeProposal = new gax::PathTemplate("networks/{network_code}/proposals/{proposal}");

        /// <summary>Creates a <see cref="ProposalName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProposalName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static ProposalName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProposalName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProposalName"/> with the pattern <c>networks/{network_code}/proposals/{proposal}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="proposalId">The <c>Proposal</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProposalName"/> constructed from the provided ids.</returns>
        public static ProposalName FromNetworkCodeProposal(string networkCodeId, string proposalId) =>
            new ProposalName(ResourceNameType.NetworkCodeProposal, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), proposalId: gax::GaxPreconditions.CheckNotNullOrEmpty(proposalId, nameof(proposalId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProposalName"/> with pattern
        /// <c>networks/{network_code}/proposals/{proposal}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="proposalId">The <c>Proposal</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProposalName"/> with pattern
        /// <c>networks/{network_code}/proposals/{proposal}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string proposalId) =>
            FormatNetworkCodeProposal(networkCodeId, proposalId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProposalName"/> with pattern
        /// <c>networks/{network_code}/proposals/{proposal}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="proposalId">The <c>Proposal</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProposalName"/> with pattern
        /// <c>networks/{network_code}/proposals/{proposal}</c>.
        /// </returns>
        public static string FormatNetworkCodeProposal(string networkCodeId, string proposalId) =>
            s_networkCodeProposal.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(proposalId, nameof(proposalId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProposalName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/proposals/{proposal}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="proposalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProposalName"/> if successful.</returns>
        public static ProposalName Parse(string proposalName) => Parse(proposalName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProposalName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/proposals/{proposal}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="proposalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProposalName"/> if successful.</returns>
        public static ProposalName Parse(string proposalName, bool allowUnparsed) =>
            TryParse(proposalName, allowUnparsed, out ProposalName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProposalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/proposals/{proposal}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="proposalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProposalName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string proposalName, out ProposalName result) => TryParse(proposalName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProposalName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/proposals/{proposal}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="proposalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProposalName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string proposalName, bool allowUnparsed, out ProposalName result)
        {
            gax::GaxPreconditions.CheckNotNull(proposalName, nameof(proposalName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeProposal.TryParseName(proposalName, out resourceName))
            {
                result = FromNetworkCodeProposal(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(proposalName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProposalName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkCodeId = null, string proposalId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkCodeId = networkCodeId;
            ProposalId = proposalId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProposalName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/proposals/{proposal}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="proposalId">The <c>Proposal</c> ID. Must not be <c>null</c> or empty.</param>
        public ProposalName(string networkCodeId, string proposalId) : this(ResourceNameType.NetworkCodeProposal, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), proposalId: gax::GaxPreconditions.CheckNotNullOrEmpty(proposalId, nameof(proposalId)))
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
        /// The <c>Proposal</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProposalId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeProposal: return s_networkCodeProposal.Expand(NetworkCodeId, ProposalId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProposalName);

        /// <inheritdoc/>
        public bool Equals(ProposalName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProposalName a, ProposalName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProposalName a, ProposalName b) => !(a == b);
    }

    public partial class Proposal
    {
        /// <summary>
        /// <see cref="gaav::ProposalName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ProposalName ProposalName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ProposalName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="UserName"/>-typed view over the <see cref="PrimarySalesperson"/> resource name property.
        /// </summary>
        public UserName PrimarySalespersonAsUserName
        {
            get => string.IsNullOrEmpty(PrimarySalesperson) ? null : UserName.Parse(PrimarySalesperson, allowUnparsed: true);
            set => PrimarySalesperson = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="UserName"/>-typed view over the <see cref="SalesPlannerUsers"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<UserName> SalesPlannerUsersAsUserNames
        {
            get => new gax::ResourceNameList<UserName>(SalesPlannerUsers, s => string.IsNullOrEmpty(s) ? null : UserName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="UserName"/>-typed view over the <see cref="Trafficker"/> resource name property.
        /// </summary>
        public UserName TraffickerAsUserName
        {
            get => string.IsNullOrEmpty(Trafficker) ? null : UserName.Parse(Trafficker, allowUnparsed: true);
            set => Trafficker = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="UserName"/>-typed view over the <see cref="SellerContactUsers"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<UserName> SellerContactUsersAsUserNames
        {
            get => new gax::ResourceNameList<UserName>(SellerContactUsers, s => string.IsNullOrEmpty(s) ? null : UserName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="TeamName"/>-typed view over the <see cref="AppliedTeams"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<TeamName> AppliedTeamsAsTeamNames
        {
            get => new gax::ResourceNameList<TeamName>(AppliedTeams, s => string.IsNullOrEmpty(s) ? null : TeamName.Parse(s, allowUnparsed: true));
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Order"/> resource name property.</summary>
        public OrderName OrderAsOrderName
        {
            get => string.IsNullOrEmpty(Order) ? null : OrderName.Parse(Order, allowUnparsed: true);
            set => Order = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CompanyName"/>-typed view over the <see cref="Advertiser"/> resource name property.
        /// </summary>
        public CompanyName AdvertiserAsCompanyName
        {
            get => string.IsNullOrEmpty(Advertiser) ? null : CompanyName.Parse(Advertiser, allowUnparsed: true);
            set => Advertiser = value?.ToString() ?? "";
        }
    }

    public partial class ProposalCompanyAssociation
    {
        /// <summary>
        /// <see cref="CompanyName"/>-typed view over the <see cref="Company"/> resource name property.
        /// </summary>
        public CompanyName CompanyAsCompanyName
        {
            get => string.IsNullOrEmpty(Company) ? null : CompanyName.Parse(Company, allowUnparsed: true);
            set => Company = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ContactName"/>-typed view over the <see cref="SellerContacts"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ContactName> SellerContactsAsContactNames
        {
            get => new gax::ResourceNameList<ContactName>(SellerContacts, s => string.IsNullOrEmpty(s) ? null : ContactName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class MarketplaceComment
    {
        /// <summary>
        /// <see cref="ProposalName"/>-typed view over the <see cref="Proposal"/> resource name property.
        /// </summary>
        public ProposalName ProposalAsProposalName
        {
            get => string.IsNullOrEmpty(Proposal) ? null : ProposalName.Parse(Proposal, allowUnparsed: true);
            set => Proposal = value?.ToString() ?? "";
        }
    }
}

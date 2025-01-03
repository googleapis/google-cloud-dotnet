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
using gccv = Google.Cloud.Channel.V1;
using sys = System;

namespace Google.Cloud.Channel.V1
{
    /// <summary>Resource name for the <c>Offer</c> resource.</summary>
    public sealed partial class OfferName : gax::IResourceName, sys::IEquatable<OfferName>
    {
        /// <summary>The possible contents of <see cref="OfferName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/offers/{offer}</c>.</summary>
            AccountOffer = 1,
        }

        private static gax::PathTemplate s_accountOffer = new gax::PathTemplate("accounts/{account}/offers/{offer}");

        /// <summary>Creates a <see cref="OfferName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OfferName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OfferName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OfferName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OfferName"/> with the pattern <c>accounts/{account}/offers/{offer}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OfferName"/> constructed from the provided ids.</returns>
        public static OfferName FromAccountOffer(string accountId, string offerId) =>
            new OfferName(ResourceNameType.AccountOffer, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), offerId: gax::GaxPreconditions.CheckNotNullOrEmpty(offerId, nameof(offerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OfferName"/> with pattern
        /// <c>accounts/{account}/offers/{offer}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OfferName"/> with pattern <c>accounts/{account}/offers/{offer}</c>
        /// .
        /// </returns>
        public static string Format(string accountId, string offerId) => FormatAccountOffer(accountId, offerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OfferName"/> with pattern
        /// <c>accounts/{account}/offers/{offer}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OfferName"/> with pattern <c>accounts/{account}/offers/{offer}</c>
        /// .
        /// </returns>
        public static string FormatAccountOffer(string accountId, string offerId) =>
            s_accountOffer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(offerId, nameof(offerId)));

        /// <summary>Parses the given resource name string into a new <see cref="OfferName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/offers/{offer}</c></description></item></list>
        /// </remarks>
        /// <param name="offerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OfferName"/> if successful.</returns>
        public static OfferName Parse(string offerName) => Parse(offerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OfferName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/offers/{offer}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="offerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OfferName"/> if successful.</returns>
        public static OfferName Parse(string offerName, bool allowUnparsed) =>
            TryParse(offerName, allowUnparsed, out OfferName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OfferName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/offers/{offer}</c></description></item></list>
        /// </remarks>
        /// <param name="offerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OfferName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string offerName, out OfferName result) => TryParse(offerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OfferName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/offers/{offer}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="offerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OfferName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string offerName, bool allowUnparsed, out OfferName result)
        {
            gax::GaxPreconditions.CheckNotNull(offerName, nameof(offerName));
            gax::TemplatedResourceName resourceName;
            if (s_accountOffer.TryParseName(offerName, out resourceName))
            {
                result = FromAccountOffer(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(offerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OfferName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string offerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            OfferId = offerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OfferName"/> class from the component parts of pattern
        /// <c>accounts/{account}/offers/{offer}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        public OfferName(string accountId, string offerId) : this(ResourceNameType.AccountOffer, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), offerId: gax::GaxPreconditions.CheckNotNullOrEmpty(offerId, nameof(offerId)))
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
        /// The <c>Account</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AccountId { get; }

        /// <summary>
        /// The <c>Offer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OfferId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountOffer: return s_accountOffer.Expand(AccountId, OfferId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OfferName);

        /// <inheritdoc/>
        public bool Equals(OfferName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OfferName a, OfferName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OfferName a, OfferName b) => !(a == b);
    }

    public partial class Offer
    {
        /// <summary>
        /// <see cref="gccv::OfferName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::OfferName OfferName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::OfferName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

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
using gsmlv = Google.Shopping.Merchant.Lfp.V1Beta;
using sys = System;

namespace Google.Shopping.Merchant.Lfp.V1Beta
{
    /// <summary>Resource name for the <c>LfpMerchantState</c> resource.</summary>
    public sealed partial class LfpMerchantStateName : gax::IResourceName, sys::IEquatable<LfpMerchantStateName>
    {
        /// <summary>The possible contents of <see cref="LfpMerchantStateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>accounts/{account}/lfpMerchantStates/{lfp_merchant_state}</c>.
            /// </summary>
            AccountLfpMerchantState = 1,
        }

        private static gax::PathTemplate s_accountLfpMerchantState = new gax::PathTemplate("accounts/{account}/lfpMerchantStates/{lfp_merchant_state}");

        /// <summary>Creates a <see cref="LfpMerchantStateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LfpMerchantStateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LfpMerchantStateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LfpMerchantStateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LfpMerchantStateName"/> with the pattern
        /// <c>accounts/{account}/lfpMerchantStates/{lfp_merchant_state}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lfpMerchantStateId">The <c>LfpMerchantState</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LfpMerchantStateName"/> constructed from the provided ids.</returns>
        public static LfpMerchantStateName FromAccountLfpMerchantState(string accountId, string lfpMerchantStateId) =>
            new LfpMerchantStateName(ResourceNameType.AccountLfpMerchantState, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), lfpMerchantStateId: gax::GaxPreconditions.CheckNotNullOrEmpty(lfpMerchantStateId, nameof(lfpMerchantStateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LfpMerchantStateName"/> with pattern
        /// <c>accounts/{account}/lfpMerchantStates/{lfp_merchant_state}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lfpMerchantStateId">The <c>LfpMerchantState</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LfpMerchantStateName"/> with pattern
        /// <c>accounts/{account}/lfpMerchantStates/{lfp_merchant_state}</c>.
        /// </returns>
        public static string Format(string accountId, string lfpMerchantStateId) =>
            FormatAccountLfpMerchantState(accountId, lfpMerchantStateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LfpMerchantStateName"/> with pattern
        /// <c>accounts/{account}/lfpMerchantStates/{lfp_merchant_state}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lfpMerchantStateId">The <c>LfpMerchantState</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LfpMerchantStateName"/> with pattern
        /// <c>accounts/{account}/lfpMerchantStates/{lfp_merchant_state}</c>.
        /// </returns>
        public static string FormatAccountLfpMerchantState(string accountId, string lfpMerchantStateId) =>
            s_accountLfpMerchantState.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lfpMerchantStateId, nameof(lfpMerchantStateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LfpMerchantStateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/lfpMerchantStates/{lfp_merchant_state}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="lfpMerchantStateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LfpMerchantStateName"/> if successful.</returns>
        public static LfpMerchantStateName Parse(string lfpMerchantStateName) => Parse(lfpMerchantStateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LfpMerchantStateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/lfpMerchantStates/{lfp_merchant_state}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lfpMerchantStateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LfpMerchantStateName"/> if successful.</returns>
        public static LfpMerchantStateName Parse(string lfpMerchantStateName, bool allowUnparsed) =>
            TryParse(lfpMerchantStateName, allowUnparsed, out LfpMerchantStateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LfpMerchantStateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/lfpMerchantStates/{lfp_merchant_state}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="lfpMerchantStateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LfpMerchantStateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lfpMerchantStateName, out LfpMerchantStateName result) =>
            TryParse(lfpMerchantStateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LfpMerchantStateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/lfpMerchantStates/{lfp_merchant_state}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lfpMerchantStateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LfpMerchantStateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lfpMerchantStateName, bool allowUnparsed, out LfpMerchantStateName result)
        {
            gax::GaxPreconditions.CheckNotNull(lfpMerchantStateName, nameof(lfpMerchantStateName));
            gax::TemplatedResourceName resourceName;
            if (s_accountLfpMerchantState.TryParseName(lfpMerchantStateName, out resourceName))
            {
                result = FromAccountLfpMerchantState(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(lfpMerchantStateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LfpMerchantStateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string lfpMerchantStateId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            LfpMerchantStateId = lfpMerchantStateId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LfpMerchantStateName"/> class from the component parts of pattern
        /// <c>accounts/{account}/lfpMerchantStates/{lfp_merchant_state}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lfpMerchantStateId">The <c>LfpMerchantState</c> ID. Must not be <c>null</c> or empty.</param>
        public LfpMerchantStateName(string accountId, string lfpMerchantStateId) : this(ResourceNameType.AccountLfpMerchantState, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), lfpMerchantStateId: gax::GaxPreconditions.CheckNotNullOrEmpty(lfpMerchantStateId, nameof(lfpMerchantStateId)))
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
        /// The <c>LfpMerchantState</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string LfpMerchantStateId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountLfpMerchantState: return s_accountLfpMerchantState.Expand(AccountId, LfpMerchantStateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LfpMerchantStateName);

        /// <inheritdoc/>
        public bool Equals(LfpMerchantStateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LfpMerchantStateName a, LfpMerchantStateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LfpMerchantStateName a, LfpMerchantStateName b) => !(a == b);
    }

    public partial class LfpMerchantState
    {
        /// <summary>
        /// <see cref="gsmlv::LfpMerchantStateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmlv::LfpMerchantStateName LfpMerchantStateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmlv::LfpMerchantStateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetLfpMerchantStateRequest
    {
        /// <summary>
        /// <see cref="gsmlv::LfpMerchantStateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmlv::LfpMerchantStateName LfpMerchantStateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmlv::LfpMerchantStateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

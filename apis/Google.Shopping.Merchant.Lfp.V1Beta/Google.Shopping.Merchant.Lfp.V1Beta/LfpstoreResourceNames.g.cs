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
using gsmlv = Google.Shopping.Merchant.Lfp.V1Beta;
using sys = System;

namespace Google.Shopping.Merchant.Lfp.V1Beta
{
    /// <summary>Resource name for the <c>LfpStore</c> resource.</summary>
    public sealed partial class LfpStoreName : gax::IResourceName, sys::IEquatable<LfpStoreName>
    {
        /// <summary>The possible contents of <see cref="LfpStoreName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>accounts/{account}/lfpStores/{target_merchant}~{store_code}</c>.
            /// </summary>
            AccountTargetMerchantStoreCode = 1,
        }

        private static gax::PathTemplate s_accountTargetMerchantStoreCode = new gax::PathTemplate("accounts/{account}/lfpStores/{target_merchant_store_code}");

        /// <summary>Creates a <see cref="LfpStoreName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LfpStoreName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static LfpStoreName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LfpStoreName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LfpStoreName"/> with the pattern
        /// <c>accounts/{account}/lfpStores/{target_merchant}~{store_code}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetMerchantId">The <c>TargetMerchant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storeCodeId">The <c>StoreCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LfpStoreName"/> constructed from the provided ids.</returns>
        public static LfpStoreName FromAccountTargetMerchantStoreCode(string accountId, string targetMerchantId, string storeCodeId) =>
            new LfpStoreName(ResourceNameType.AccountTargetMerchantStoreCode, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), targetMerchantId: gax::GaxPreconditions.CheckNotNullOrEmpty(targetMerchantId, nameof(targetMerchantId)), storeCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(storeCodeId, nameof(storeCodeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LfpStoreName"/> with pattern
        /// <c>accounts/{account}/lfpStores/{target_merchant}~{store_code}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetMerchantId">The <c>TargetMerchant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storeCodeId">The <c>StoreCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LfpStoreName"/> with pattern
        /// <c>accounts/{account}/lfpStores/{target_merchant}~{store_code}</c>.
        /// </returns>
        public static string Format(string accountId, string targetMerchantId, string storeCodeId) =>
            FormatAccountTargetMerchantStoreCode(accountId, targetMerchantId, storeCodeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LfpStoreName"/> with pattern
        /// <c>accounts/{account}/lfpStores/{target_merchant}~{store_code}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetMerchantId">The <c>TargetMerchant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storeCodeId">The <c>StoreCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LfpStoreName"/> with pattern
        /// <c>accounts/{account}/lfpStores/{target_merchant}~{store_code}</c>.
        /// </returns>
        public static string FormatAccountTargetMerchantStoreCode(string accountId, string targetMerchantId, string storeCodeId) =>
            s_accountTargetMerchantStoreCode.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(targetMerchantId, nameof(targetMerchantId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(storeCodeId, nameof(storeCodeId)))}");

        /// <summary>Parses the given resource name string into a new <see cref="LfpStoreName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/lfpStores/{target_merchant}~{store_code}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="lfpStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LfpStoreName"/> if successful.</returns>
        public static LfpStoreName Parse(string lfpStoreName) => Parse(lfpStoreName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LfpStoreName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/lfpStores/{target_merchant}~{store_code}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lfpStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LfpStoreName"/> if successful.</returns>
        public static LfpStoreName Parse(string lfpStoreName, bool allowUnparsed) =>
            TryParse(lfpStoreName, allowUnparsed, out LfpStoreName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LfpStoreName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/lfpStores/{target_merchant}~{store_code}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="lfpStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LfpStoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lfpStoreName, out LfpStoreName result) => TryParse(lfpStoreName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LfpStoreName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/lfpStores/{target_merchant}~{store_code}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lfpStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LfpStoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lfpStoreName, bool allowUnparsed, out LfpStoreName result)
        {
            gax::GaxPreconditions.CheckNotNull(lfpStoreName, nameof(lfpStoreName));
            gax::TemplatedResourceName resourceName;
            if (s_accountTargetMerchantStoreCode.TryParseName(lfpStoreName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromAccountTargetMerchantStoreCode(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(lfpStoreName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static string[] ParseSplitHelper(string s, char[] separators)
        {
            string[] result = new string[separators.Length + 1];
            int i0 = 0;
            for (int i = 0; i <= separators.Length; i++)
            {
                int i1 = i < separators.Length ? s.IndexOf(separators[i], i0) : s.Length;
                if (i1 < 0 || i1 == i0)
                {
                    return null;
                }
                result[i] = s.Substring(i0, i1 - i0);
                i0 = i1 + 1;
            }
            return result;
        }

        private LfpStoreName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string storeCodeId = null, string targetMerchantId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            StoreCodeId = storeCodeId;
            TargetMerchantId = targetMerchantId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LfpStoreName"/> class from the component parts of pattern
        /// <c>accounts/{account}/lfpStores/{target_merchant}~{store_code}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetMerchantId">The <c>TargetMerchant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storeCodeId">The <c>StoreCode</c> ID. Must not be <c>null</c> or empty.</param>
        public LfpStoreName(string accountId, string targetMerchantId, string storeCodeId) : this(ResourceNameType.AccountTargetMerchantStoreCode, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), targetMerchantId: gax::GaxPreconditions.CheckNotNullOrEmpty(targetMerchantId, nameof(targetMerchantId)), storeCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(storeCodeId, nameof(storeCodeId)))
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
        /// The <c>StoreCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StoreCodeId { get; }

        /// <summary>
        /// The <c>TargetMerchant</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string TargetMerchantId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountTargetMerchantStoreCode: return s_accountTargetMerchantStoreCode.Expand(AccountId, $"{TargetMerchantId}~{StoreCodeId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LfpStoreName);

        /// <inheritdoc/>
        public bool Equals(LfpStoreName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LfpStoreName a, LfpStoreName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LfpStoreName a, LfpStoreName b) => !(a == b);
    }

    public partial class LfpStore
    {
        /// <summary>
        /// <see cref="gsmlv::LfpStoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmlv::LfpStoreName LfpStoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmlv::LfpStoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetLfpStoreRequest
    {
        /// <summary>
        /// <see cref="gsmlv::LfpStoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmlv::LfpStoreName LfpStoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmlv::LfpStoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InsertLfpStoreRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteLfpStoreRequest
    {
        /// <summary>
        /// <see cref="gsmlv::LfpStoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmlv::LfpStoreName LfpStoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmlv::LfpStoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLfpStoresRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}

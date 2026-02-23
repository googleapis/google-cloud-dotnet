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
using gadv = Google.Ads.DataManager.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.DataManager.V1
{
    /// <summary>Resource name for the <c>UserListGlobalLicense</c> resource.</summary>
    public sealed partial class UserListGlobalLicenseName : gax::IResourceName, sys::IEquatable<UserListGlobalLicenseName>
    {
        /// <summary>The possible contents of <see cref="UserListGlobalLicenseName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}</c>.
            /// </summary>
            AccountTypeAccountUserListGlobalLicense = 1,
        }

        private static gax::PathTemplate s_accountTypeAccountUserListGlobalLicense = new gax::PathTemplate("accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}");

        /// <summary>Creates a <see cref="UserListGlobalLicenseName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserListGlobalLicenseName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UserListGlobalLicenseName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserListGlobalLicenseName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UserListGlobalLicenseName"/> with the pattern
        /// <c>accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}</c>.
        /// </summary>
        /// <param name="accountTypeId">The <c>AccountType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListGlobalLicenseId">
        /// The <c>UserListGlobalLicense</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="UserListGlobalLicenseName"/> constructed from the provided ids.
        /// </returns>
        public static UserListGlobalLicenseName FromAccountTypeAccountUserListGlobalLicense(string accountTypeId, string accountId, string userListGlobalLicenseId) =>
            new UserListGlobalLicenseName(ResourceNameType.AccountTypeAccountUserListGlobalLicense, accountTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountTypeId, nameof(accountTypeId)), accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), userListGlobalLicenseId: gax::GaxPreconditions.CheckNotNullOrEmpty(userListGlobalLicenseId, nameof(userListGlobalLicenseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserListGlobalLicenseName"/> with pattern
        /// <c>accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}</c>.
        /// </summary>
        /// <param name="accountTypeId">The <c>AccountType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListGlobalLicenseId">
        /// The <c>UserListGlobalLicense</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="UserListGlobalLicenseName"/> with pattern
        /// <c>accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}</c>.
        /// </returns>
        public static string Format(string accountTypeId, string accountId, string userListGlobalLicenseId) =>
            FormatAccountTypeAccountUserListGlobalLicense(accountTypeId, accountId, userListGlobalLicenseId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserListGlobalLicenseName"/> with pattern
        /// <c>accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}</c>.
        /// </summary>
        /// <param name="accountTypeId">The <c>AccountType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListGlobalLicenseId">
        /// The <c>UserListGlobalLicense</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="UserListGlobalLicenseName"/> with pattern
        /// <c>accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}</c>.
        /// </returns>
        public static string FormatAccountTypeAccountUserListGlobalLicense(string accountTypeId, string accountId, string userListGlobalLicenseId) =>
            s_accountTypeAccountUserListGlobalLicense.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountTypeId, nameof(accountTypeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userListGlobalLicenseId, nameof(userListGlobalLicenseId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserListGlobalLicenseName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userListGlobalLicenseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserListGlobalLicenseName"/> if successful.</returns>
        public static UserListGlobalLicenseName Parse(string userListGlobalLicenseName) =>
            Parse(userListGlobalLicenseName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserListGlobalLicenseName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userListGlobalLicenseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserListGlobalLicenseName"/> if successful.</returns>
        public static UserListGlobalLicenseName Parse(string userListGlobalLicenseName, bool allowUnparsed) =>
            TryParse(userListGlobalLicenseName, allowUnparsed, out UserListGlobalLicenseName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserListGlobalLicenseName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userListGlobalLicenseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserListGlobalLicenseName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userListGlobalLicenseName, out UserListGlobalLicenseName result) =>
            TryParse(userListGlobalLicenseName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserListGlobalLicenseName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userListGlobalLicenseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserListGlobalLicenseName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userListGlobalLicenseName, bool allowUnparsed, out UserListGlobalLicenseName result)
        {
            gax::GaxPreconditions.CheckNotNull(userListGlobalLicenseName, nameof(userListGlobalLicenseName));
            gax::TemplatedResourceName resourceName;
            if (s_accountTypeAccountUserListGlobalLicense.TryParseName(userListGlobalLicenseName, out resourceName))
            {
                result = FromAccountTypeAccountUserListGlobalLicense(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userListGlobalLicenseName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UserListGlobalLicenseName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string accountTypeId = null, string userListGlobalLicenseId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            AccountTypeId = accountTypeId;
            UserListGlobalLicenseId = userListGlobalLicenseId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserListGlobalLicenseName"/> class from the component parts of
        /// pattern <c>accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}</c>
        /// </summary>
        /// <param name="accountTypeId">The <c>AccountType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListGlobalLicenseId">
        /// The <c>UserListGlobalLicense</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public UserListGlobalLicenseName(string accountTypeId, string accountId, string userListGlobalLicenseId) : this(ResourceNameType.AccountTypeAccountUserListGlobalLicense, accountTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountTypeId, nameof(accountTypeId)), accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), userListGlobalLicenseId: gax::GaxPreconditions.CheckNotNullOrEmpty(userListGlobalLicenseId, nameof(userListGlobalLicenseId)))
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
        /// The <c>AccountType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AccountTypeId { get; }

        /// <summary>
        /// The <c>UserListGlobalLicense</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string UserListGlobalLicenseId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountTypeAccountUserListGlobalLicense: return s_accountTypeAccountUserListGlobalLicense.Expand(AccountTypeId, AccountId, UserListGlobalLicenseId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserListGlobalLicenseName);

        /// <inheritdoc/>
        public bool Equals(UserListGlobalLicenseName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UserListGlobalLicenseName a, UserListGlobalLicenseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UserListGlobalLicenseName a, UserListGlobalLicenseName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>UserListGlobalLicenseCustomerInfo</c> resource.</summary>
    public sealed partial class UserListGlobalLicenseCustomerInfoName : gax::IResourceName, sys::IEquatable<UserListGlobalLicenseCustomerInfoName>
    {
        /// <summary>The possible contents of <see cref="UserListGlobalLicenseCustomerInfoName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}/customerInfos/{license_customer_info}</c>
            /// .
            /// </summary>
            AccountTypeAccountUserListGlobalLicenseLicenseCustomerInfo = 1,
        }

        private static gax::PathTemplate s_accountTypeAccountUserListGlobalLicenseLicenseCustomerInfo = new gax::PathTemplate("accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}/customerInfos/{license_customer_info}");

        /// <summary>
        /// Creates a <see cref="UserListGlobalLicenseCustomerInfoName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserListGlobalLicenseCustomerInfoName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UserListGlobalLicenseCustomerInfoName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserListGlobalLicenseCustomerInfoName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UserListGlobalLicenseCustomerInfoName"/> with the pattern
        /// <c>
        /// accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}/customerInfos/{license_customer_info}</c>
        /// .
        /// </summary>
        /// <param name="accountTypeId">The <c>AccountType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListGlobalLicenseId">
        /// The <c>UserListGlobalLicense</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="licenseCustomerInfoId">
        /// The <c>LicenseCustomerInfo</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="UserListGlobalLicenseCustomerInfoName"/> constructed from the provided ids.
        /// </returns>
        public static UserListGlobalLicenseCustomerInfoName FromAccountTypeAccountUserListGlobalLicenseLicenseCustomerInfo(string accountTypeId, string accountId, string userListGlobalLicenseId, string licenseCustomerInfoId) =>
            new UserListGlobalLicenseCustomerInfoName(ResourceNameType.AccountTypeAccountUserListGlobalLicenseLicenseCustomerInfo, accountTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountTypeId, nameof(accountTypeId)), accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), userListGlobalLicenseId: gax::GaxPreconditions.CheckNotNullOrEmpty(userListGlobalLicenseId, nameof(userListGlobalLicenseId)), licenseCustomerInfoId: gax::GaxPreconditions.CheckNotNullOrEmpty(licenseCustomerInfoId, nameof(licenseCustomerInfoId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserListGlobalLicenseCustomerInfoName"/>
        /// with pattern
        /// <c>
        /// accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}/customerInfos/{license_customer_info}</c>
        /// .
        /// </summary>
        /// <param name="accountTypeId">The <c>AccountType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListGlobalLicenseId">
        /// The <c>UserListGlobalLicense</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="licenseCustomerInfoId">
        /// The <c>LicenseCustomerInfo</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="UserListGlobalLicenseCustomerInfoName"/> with pattern
        /// <c>
        /// accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}/customerInfos/{license_customer_info}</c>
        /// .
        /// </returns>
        public static string Format(string accountTypeId, string accountId, string userListGlobalLicenseId, string licenseCustomerInfoId) =>
            FormatAccountTypeAccountUserListGlobalLicenseLicenseCustomerInfo(accountTypeId, accountId, userListGlobalLicenseId, licenseCustomerInfoId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserListGlobalLicenseCustomerInfoName"/>
        /// with pattern
        /// <c>
        /// accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}/customerInfos/{license_customer_info}</c>
        /// .
        /// </summary>
        /// <param name="accountTypeId">The <c>AccountType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListGlobalLicenseId">
        /// The <c>UserListGlobalLicense</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="licenseCustomerInfoId">
        /// The <c>LicenseCustomerInfo</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="UserListGlobalLicenseCustomerInfoName"/> with pattern
        /// <c>
        /// accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}/customerInfos/{license_customer_info}</c>
        /// .
        /// </returns>
        public static string FormatAccountTypeAccountUserListGlobalLicenseLicenseCustomerInfo(string accountTypeId, string accountId, string userListGlobalLicenseId, string licenseCustomerInfoId) =>
            s_accountTypeAccountUserListGlobalLicenseLicenseCustomerInfo.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountTypeId, nameof(accountTypeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userListGlobalLicenseId, nameof(userListGlobalLicenseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(licenseCustomerInfoId, nameof(licenseCustomerInfoId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserListGlobalLicenseCustomerInfoName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}/customerInfos/{license_customer_info}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userListGlobalLicenseCustomerInfoName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="UserListGlobalLicenseCustomerInfoName"/> if successful.</returns>
        public static UserListGlobalLicenseCustomerInfoName Parse(string userListGlobalLicenseCustomerInfoName) =>
            Parse(userListGlobalLicenseCustomerInfoName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserListGlobalLicenseCustomerInfoName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}/customerInfos/{license_customer_info}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userListGlobalLicenseCustomerInfoName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserListGlobalLicenseCustomerInfoName"/> if successful.</returns>
        public static UserListGlobalLicenseCustomerInfoName Parse(string userListGlobalLicenseCustomerInfoName, bool allowUnparsed) =>
            TryParse(userListGlobalLicenseCustomerInfoName, allowUnparsed, out UserListGlobalLicenseCustomerInfoName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserListGlobalLicenseCustomerInfoName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}/customerInfos/{license_customer_info}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userListGlobalLicenseCustomerInfoName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserListGlobalLicenseCustomerInfoName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userListGlobalLicenseCustomerInfoName, out UserListGlobalLicenseCustomerInfoName result) =>
            TryParse(userListGlobalLicenseCustomerInfoName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserListGlobalLicenseCustomerInfoName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}/customerInfos/{license_customer_info}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userListGlobalLicenseCustomerInfoName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserListGlobalLicenseCustomerInfoName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userListGlobalLicenseCustomerInfoName, bool allowUnparsed, out UserListGlobalLicenseCustomerInfoName result)
        {
            gax::GaxPreconditions.CheckNotNull(userListGlobalLicenseCustomerInfoName, nameof(userListGlobalLicenseCustomerInfoName));
            gax::TemplatedResourceName resourceName;
            if (s_accountTypeAccountUserListGlobalLicenseLicenseCustomerInfo.TryParseName(userListGlobalLicenseCustomerInfoName, out resourceName))
            {
                result = FromAccountTypeAccountUserListGlobalLicenseLicenseCustomerInfo(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userListGlobalLicenseCustomerInfoName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UserListGlobalLicenseCustomerInfoName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string accountTypeId = null, string licenseCustomerInfoId = null, string userListGlobalLicenseId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            AccountTypeId = accountTypeId;
            LicenseCustomerInfoId = licenseCustomerInfoId;
            UserListGlobalLicenseId = userListGlobalLicenseId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserListGlobalLicenseCustomerInfoName"/> class from the component
        /// parts of pattern
        /// <c>
        /// accountTypes/{account_type}/accounts/{account}/userListGlobalLicenses/{user_list_global_license}/customerInfos/{license_customer_info}</c>
        /// </summary>
        /// <param name="accountTypeId">The <c>AccountType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListGlobalLicenseId">
        /// The <c>UserListGlobalLicense</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="licenseCustomerInfoId">
        /// The <c>LicenseCustomerInfo</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public UserListGlobalLicenseCustomerInfoName(string accountTypeId, string accountId, string userListGlobalLicenseId, string licenseCustomerInfoId) : this(ResourceNameType.AccountTypeAccountUserListGlobalLicenseLicenseCustomerInfo, accountTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountTypeId, nameof(accountTypeId)), accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), userListGlobalLicenseId: gax::GaxPreconditions.CheckNotNullOrEmpty(userListGlobalLicenseId, nameof(userListGlobalLicenseId)), licenseCustomerInfoId: gax::GaxPreconditions.CheckNotNullOrEmpty(licenseCustomerInfoId, nameof(licenseCustomerInfoId)))
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
        /// The <c>AccountType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AccountTypeId { get; }

        /// <summary>
        /// The <c>LicenseCustomerInfo</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string LicenseCustomerInfoId { get; }

        /// <summary>
        /// The <c>UserListGlobalLicense</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string UserListGlobalLicenseId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountTypeAccountUserListGlobalLicenseLicenseCustomerInfo: return s_accountTypeAccountUserListGlobalLicenseLicenseCustomerInfo.Expand(AccountTypeId, AccountId, UserListGlobalLicenseId, LicenseCustomerInfoId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserListGlobalLicenseCustomerInfoName);

        /// <inheritdoc/>
        public bool Equals(UserListGlobalLicenseCustomerInfoName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UserListGlobalLicenseCustomerInfoName a, UserListGlobalLicenseCustomerInfoName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UserListGlobalLicenseCustomerInfoName a, UserListGlobalLicenseCustomerInfoName b) => !(a == b);
    }

    public partial class UserListGlobalLicense
    {
        /// <summary>
        /// <see cref="gadv::UserListGlobalLicenseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gadv::UserListGlobalLicenseName UserListGlobalLicenseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gadv::UserListGlobalLicenseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UserListGlobalLicenseCustomerInfo
    {
        /// <summary>
        /// <see cref="gadv::UserListGlobalLicenseCustomerInfoName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gadv::UserListGlobalLicenseCustomerInfoName UserListGlobalLicenseCustomerInfoName
        {
            get => string.IsNullOrEmpty(Name) ? null : gadv::UserListGlobalLicenseCustomerInfoName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

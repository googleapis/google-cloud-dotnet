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
using gsmdv = Google.Shopping.Merchant.DataSources.V1Beta;
using sys = System;

namespace Google.Shopping.Merchant.DataSources.V1Beta
{
    /// <summary>Resource name for the <c>DataSource</c> resource.</summary>
    public sealed partial class DataSourceName : gax::IResourceName, sys::IEquatable<DataSourceName>
    {
        /// <summary>The possible contents of <see cref="DataSourceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/dataSources/{datasource}</c>.</summary>
            AccountDatasource = 1,
        }

        private static gax::PathTemplate s_accountDatasource = new gax::PathTemplate("accounts/{account}/dataSources/{datasource}");

        /// <summary>Creates a <see cref="DataSourceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataSourceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataSourceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataSourceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataSourceName"/> with the pattern <c>accounts/{account}/dataSources/{datasource}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataSourceName"/> constructed from the provided ids.</returns>
        public static DataSourceName FromAccountDatasource(string accountId, string datasourceId) =>
            new DataSourceName(ResourceNameType.AccountDatasource, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), datasourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>accounts/{account}/dataSources/{datasource}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>accounts/{account}/dataSources/{datasource}</c>.
        /// </returns>
        public static string Format(string accountId, string datasourceId) => FormatAccountDatasource(accountId, datasourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>accounts/{account}/dataSources/{datasource}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>accounts/{account}/dataSources/{datasource}</c>.
        /// </returns>
        public static string FormatAccountDatasource(string accountId, string datasourceId) =>
            s_accountDatasource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataSourceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/dataSources/{datasource}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataSourceName"/> if successful.</returns>
        public static DataSourceName Parse(string dataSourceName) => Parse(dataSourceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataSourceName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/dataSources/{datasource}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataSourceName"/> if successful.</returns>
        public static DataSourceName Parse(string dataSourceName, bool allowUnparsed) =>
            TryParse(dataSourceName, allowUnparsed, out DataSourceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataSourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/dataSources/{datasource}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataSourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSourceName, out DataSourceName result) =>
            TryParse(dataSourceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataSourceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/dataSources/{datasource}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataSourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSourceName, bool allowUnparsed, out DataSourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataSourceName, nameof(dataSourceName));
            gax::TemplatedResourceName resourceName;
            if (s_accountDatasource.TryParseName(dataSourceName, out resourceName))
            {
                result = FromAccountDatasource(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataSourceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataSourceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string datasourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            DatasourceId = datasourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataSourceName"/> class from the component parts of pattern
        /// <c>accounts/{account}/dataSources/{datasource}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        public DataSourceName(string accountId, string datasourceId) : this(ResourceNameType.AccountDatasource, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), datasourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)))
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
        /// The <c>Datasource</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountDatasource: return s_accountDatasource.Expand(AccountId, DatasourceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataSourceName);

        /// <inheritdoc/>
        public bool Equals(DataSourceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataSourceName a, DataSourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataSourceName a, DataSourceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Account</c> resource.</summary>
    public sealed partial class AccountName : gax::IResourceName, sys::IEquatable<AccountName>
    {
        /// <summary>The possible contents of <see cref="AccountName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}</c>.</summary>
            Account = 1,
        }

        private static gax::PathTemplate s_account = new gax::PathTemplate("accounts/{account}");

        /// <summary>Creates a <see cref="AccountName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccountName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccountName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccountName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="AccountName"/> with the pattern <c>accounts/{account}</c>.</summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccountName"/> constructed from the provided ids.</returns>
        public static AccountName FromAccount(string accountId) =>
            new AccountName(ResourceNameType.Account, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountName"/> with pattern
        /// <c>accounts/{account}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountName"/> with pattern <c>accounts/{account}</c>.
        /// </returns>
        public static string Format(string accountId) => FormatAccount(accountId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountName"/> with pattern
        /// <c>accounts/{account}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountName"/> with pattern <c>accounts/{account}</c>.
        /// </returns>
        public static string FormatAccount(string accountId) =>
            s_account.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)));

        /// <summary>Parses the given resource name string into a new <see cref="AccountName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}</c></description></item></list>
        /// </remarks>
        /// <param name="accountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccountName"/> if successful.</returns>
        public static AccountName Parse(string accountName) => Parse(accountName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccountName"/> if successful.</returns>
        public static AccountName Parse(string accountName, bool allowUnparsed) =>
            TryParse(accountName, allowUnparsed, out AccountName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}</c></description></item></list>
        /// </remarks>
        /// <param name="accountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountName, out AccountName result) => TryParse(accountName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountName, bool allowUnparsed, out AccountName result)
        {
            gax::GaxPreconditions.CheckNotNull(accountName, nameof(accountName));
            gax::TemplatedResourceName resourceName;
            if (s_account.TryParseName(accountName, out resourceName))
            {
                result = FromAccount(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accountName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccountName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccountName"/> class from the component parts of pattern
        /// <c>accounts/{account}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        public AccountName(string accountId) : this(ResourceNameType.Account, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Account: return s_account.Expand(AccountId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccountName);

        /// <inheritdoc/>
        public bool Equals(AccountName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccountName a, AccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccountName a, AccountName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Datasource</c> resource.</summary>
    public sealed partial class DatasourceName : gax::IResourceName, sys::IEquatable<DatasourceName>
    {
        /// <summary>The possible contents of <see cref="DatasourceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/dataSources/{datasource}</c>.</summary>
            AccountDatasource = 1,
        }

        private static gax::PathTemplate s_accountDatasource = new gax::PathTemplate("accounts/{account}/dataSources/{datasource}");

        /// <summary>Creates a <see cref="DatasourceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatasourceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DatasourceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatasourceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatasourceName"/> with the pattern <c>accounts/{account}/dataSources/{datasource}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DatasourceName"/> constructed from the provided ids.</returns>
        public static DatasourceName FromAccountDatasource(string accountId, string datasourceId) =>
            new DatasourceName(ResourceNameType.AccountDatasource, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), datasourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasourceName"/> with pattern
        /// <c>accounts/{account}/dataSources/{datasource}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasourceName"/> with pattern
        /// <c>accounts/{account}/dataSources/{datasource}</c>.
        /// </returns>
        public static string Format(string accountId, string datasourceId) => FormatAccountDatasource(accountId, datasourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasourceName"/> with pattern
        /// <c>accounts/{account}/dataSources/{datasource}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasourceName"/> with pattern
        /// <c>accounts/{account}/dataSources/{datasource}</c>.
        /// </returns>
        public static string FormatAccountDatasource(string accountId, string datasourceId) =>
            s_accountDatasource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)));

        /// <summary>Parses the given resource name string into a new <see cref="DatasourceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/dataSources/{datasource}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="datasourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatasourceName"/> if successful.</returns>
        public static DatasourceName Parse(string datasourceName) => Parse(datasourceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatasourceName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/dataSources/{datasource}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatasourceName"/> if successful.</returns>
        public static DatasourceName Parse(string datasourceName, bool allowUnparsed) =>
            TryParse(datasourceName, allowUnparsed, out DatasourceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/dataSources/{datasource}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="datasourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasourceName, out DatasourceName result) =>
            TryParse(datasourceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasourceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/dataSources/{datasource}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasourceName, bool allowUnparsed, out DatasourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(datasourceName, nameof(datasourceName));
            gax::TemplatedResourceName resourceName;
            if (s_accountDatasource.TryParseName(datasourceName, out resourceName))
            {
                result = FromAccountDatasource(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(datasourceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatasourceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string datasourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            DatasourceId = datasourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatasourceName"/> class from the component parts of pattern
        /// <c>accounts/{account}/dataSources/{datasource}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        public DatasourceName(string accountId, string datasourceId) : this(ResourceNameType.AccountDatasource, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), datasourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)))
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
        /// The <c>Datasource</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountDatasource: return s_accountDatasource.Expand(AccountId, DatasourceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatasourceName);

        /// <inheritdoc/>
        public bool Equals(DatasourceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatasourceName a, DatasourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatasourceName a, DatasourceName b) => !(a == b);
    }

    public partial class DataSource
    {
        /// <summary>
        /// <see cref="gsmdv::DataSourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmdv::DataSourceName DataSourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmdv::DataSourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDataSourceRequest
    {
        /// <summary>
        /// <see cref="gsmdv::DataSourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmdv::DataSourceName DataSourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmdv::DataSourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataSourcesRequest
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

    public partial class CreateDataSourceRequest
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

    public partial class FetchDataSourceRequest
    {
        /// <summary>
        /// <see cref="gsmdv::DataSourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmdv::DataSourceName DataSourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmdv::DataSourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDataSourceRequest
    {
        /// <summary>
        /// <see cref="gsmdv::DataSourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmdv::DataSourceName DataSourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmdv::DataSourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

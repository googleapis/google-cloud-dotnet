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
using gaav = Google.Analytics.Admin.V1Beta;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Analytics.Admin.V1Beta
{
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

    /// <summary>Resource name for the <c>Property</c> resource.</summary>
    public sealed partial class PropertyName : gax::IResourceName, sys::IEquatable<PropertyName>
    {
        /// <summary>The possible contents of <see cref="PropertyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>properties/{property}</c>.</summary>
            Property = 1,
        }

        private static gax::PathTemplate s_property = new gax::PathTemplate("properties/{property}");

        /// <summary>Creates a <see cref="PropertyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PropertyName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static PropertyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PropertyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="PropertyName"/> with the pattern <c>properties/{property}</c>.</summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PropertyName"/> constructed from the provided ids.</returns>
        public static PropertyName FromProperty(string propertyId) =>
            new PropertyName(ResourceNameType.Property, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PropertyName"/> with pattern
        /// <c>properties/{property}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PropertyName"/> with pattern <c>properties/{property}</c>.
        /// </returns>
        public static string Format(string propertyId) => FormatProperty(propertyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PropertyName"/> with pattern
        /// <c>properties/{property}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PropertyName"/> with pattern <c>properties/{property}</c>.
        /// </returns>
        public static string FormatProperty(string propertyId) =>
            s_property.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)));

        /// <summary>Parses the given resource name string into a new <see cref="PropertyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>properties/{property}</c></description></item></list>
        /// </remarks>
        /// <param name="propertyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PropertyName"/> if successful.</returns>
        public static PropertyName Parse(string propertyName) => Parse(propertyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PropertyName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>properties/{property}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="propertyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PropertyName"/> if successful.</returns>
        public static PropertyName Parse(string propertyName, bool allowUnparsed) =>
            TryParse(propertyName, allowUnparsed, out PropertyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PropertyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>properties/{property}</c></description></item></list>
        /// </remarks>
        /// <param name="propertyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PropertyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string propertyName, out PropertyName result) => TryParse(propertyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PropertyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>properties/{property}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="propertyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PropertyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string propertyName, bool allowUnparsed, out PropertyName result)
        {
            gax::GaxPreconditions.CheckNotNull(propertyName, nameof(propertyName));
            gax::TemplatedResourceName resourceName;
            if (s_property.TryParseName(propertyName, out resourceName))
            {
                result = FromProperty(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(propertyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PropertyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PropertyName"/> class from the component parts of pattern
        /// <c>properties/{property}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        public PropertyName(string propertyId) : this(ResourceNameType.Property, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)))
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
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Property: return s_property.Expand(PropertyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PropertyName);

        /// <inheritdoc/>
        public bool Equals(PropertyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PropertyName a, PropertyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PropertyName a, PropertyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataStream</c> resource.</summary>
    public sealed partial class DataStreamName : gax::IResourceName, sys::IEquatable<DataStreamName>
    {
        /// <summary>The possible contents of <see cref="DataStreamName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>properties/{property}/dataStreams/{data_stream}</c>.</summary>
            PropertyDataStream = 1,
        }

        private static gax::PathTemplate s_propertyDataStream = new gax::PathTemplate("properties/{property}/dataStreams/{data_stream}");

        /// <summary>Creates a <see cref="DataStreamName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataStreamName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataStreamName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataStreamName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataStreamName"/> with the pattern <c>properties/{property}/dataStreams/{data_stream}</c>
        /// .
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataStreamName"/> constructed from the provided ids.</returns>
        public static DataStreamName FromPropertyDataStream(string propertyId, string dataStreamId) =>
            new DataStreamName(ResourceNameType.PropertyDataStream, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), dataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStreamId, nameof(dataStreamId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataStreamName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataStreamName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}</c>.
        /// </returns>
        public static string Format(string propertyId, string dataStreamId) =>
            FormatPropertyDataStream(propertyId, dataStreamId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataStreamName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataStreamName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}</c>.
        /// </returns>
        public static string FormatPropertyDataStream(string propertyId, string dataStreamId) =>
            s_propertyDataStream.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStreamId, nameof(dataStreamId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataStreamName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/dataStreams/{data_stream}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataStreamName"/> if successful.</returns>
        public static DataStreamName Parse(string dataStreamName) => Parse(dataStreamName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataStreamName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/dataStreams/{data_stream}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataStreamName"/> if successful.</returns>
        public static DataStreamName Parse(string dataStreamName, bool allowUnparsed) =>
            TryParse(dataStreamName, allowUnparsed, out DataStreamName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataStreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/dataStreams/{data_stream}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataStreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataStreamName, out DataStreamName result) =>
            TryParse(dataStreamName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataStreamName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/dataStreams/{data_stream}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataStreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataStreamName, bool allowUnparsed, out DataStreamName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataStreamName, nameof(dataStreamName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyDataStream.TryParseName(dataStreamName, out resourceName))
            {
                result = FromPropertyDataStream(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataStreamName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataStreamName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataStreamId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataStreamId = dataStreamId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataStreamName"/> class from the component parts of pattern
        /// <c>properties/{property}/dataStreams/{data_stream}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        public DataStreamName(string propertyId, string dataStreamId) : this(ResourceNameType.PropertyDataStream, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), dataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStreamId, nameof(dataStreamId)))
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
        /// The <c>DataStream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataStreamId { get; }

        /// <summary>
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyDataStream: return s_propertyDataStream.Expand(PropertyId, DataStreamId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataStreamName);

        /// <inheritdoc/>
        public bool Equals(DataStreamName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataStreamName a, DataStreamName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataStreamName a, DataStreamName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FirebaseLink</c> resource.</summary>
    public sealed partial class FirebaseLinkName : gax::IResourceName, sys::IEquatable<FirebaseLinkName>
    {
        /// <summary>The possible contents of <see cref="FirebaseLinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>properties/{property}/firebaseLinks/{firebase_link}</c>.
            /// </summary>
            PropertyFirebaseLink = 1,
        }

        private static gax::PathTemplate s_propertyFirebaseLink = new gax::PathTemplate("properties/{property}/firebaseLinks/{firebase_link}");

        /// <summary>Creates a <see cref="FirebaseLinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FirebaseLinkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FirebaseLinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FirebaseLinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FirebaseLinkName"/> with the pattern
        /// <c>properties/{property}/firebaseLinks/{firebase_link}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firebaseLinkId">The <c>FirebaseLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FirebaseLinkName"/> constructed from the provided ids.</returns>
        public static FirebaseLinkName FromPropertyFirebaseLink(string propertyId, string firebaseLinkId) =>
            new FirebaseLinkName(ResourceNameType.PropertyFirebaseLink, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), firebaseLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(firebaseLinkId, nameof(firebaseLinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FirebaseLinkName"/> with pattern
        /// <c>properties/{property}/firebaseLinks/{firebase_link}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firebaseLinkId">The <c>FirebaseLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FirebaseLinkName"/> with pattern
        /// <c>properties/{property}/firebaseLinks/{firebase_link}</c>.
        /// </returns>
        public static string Format(string propertyId, string firebaseLinkId) =>
            FormatPropertyFirebaseLink(propertyId, firebaseLinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FirebaseLinkName"/> with pattern
        /// <c>properties/{property}/firebaseLinks/{firebase_link}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firebaseLinkId">The <c>FirebaseLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FirebaseLinkName"/> with pattern
        /// <c>properties/{property}/firebaseLinks/{firebase_link}</c>.
        /// </returns>
        public static string FormatPropertyFirebaseLink(string propertyId, string firebaseLinkId) =>
            s_propertyFirebaseLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(firebaseLinkId, nameof(firebaseLinkId)));

        /// <summary>Parses the given resource name string into a new <see cref="FirebaseLinkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/firebaseLinks/{firebase_link}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="firebaseLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FirebaseLinkName"/> if successful.</returns>
        public static FirebaseLinkName Parse(string firebaseLinkName) => Parse(firebaseLinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FirebaseLinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/firebaseLinks/{firebase_link}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="firebaseLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FirebaseLinkName"/> if successful.</returns>
        public static FirebaseLinkName Parse(string firebaseLinkName, bool allowUnparsed) =>
            TryParse(firebaseLinkName, allowUnparsed, out FirebaseLinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FirebaseLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/firebaseLinks/{firebase_link}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="firebaseLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FirebaseLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string firebaseLinkName, out FirebaseLinkName result) =>
            TryParse(firebaseLinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FirebaseLinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/firebaseLinks/{firebase_link}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="firebaseLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FirebaseLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string firebaseLinkName, bool allowUnparsed, out FirebaseLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(firebaseLinkName, nameof(firebaseLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyFirebaseLink.TryParseName(firebaseLinkName, out resourceName))
            {
                result = FromPropertyFirebaseLink(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(firebaseLinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FirebaseLinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string firebaseLinkId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FirebaseLinkId = firebaseLinkId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FirebaseLinkName"/> class from the component parts of pattern
        /// <c>properties/{property}/firebaseLinks/{firebase_link}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firebaseLinkId">The <c>FirebaseLink</c> ID. Must not be <c>null</c> or empty.</param>
        public FirebaseLinkName(string propertyId, string firebaseLinkId) : this(ResourceNameType.PropertyFirebaseLink, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), firebaseLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(firebaseLinkId, nameof(firebaseLinkId)))
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
        /// The <c>FirebaseLink</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string FirebaseLinkId { get; }

        /// <summary>
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyFirebaseLink: return s_propertyFirebaseLink.Expand(PropertyId, FirebaseLinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FirebaseLinkName);

        /// <inheritdoc/>
        public bool Equals(FirebaseLinkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FirebaseLinkName a, FirebaseLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FirebaseLinkName a, FirebaseLinkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>GoogleAdsLink</c> resource.</summary>
    public sealed partial class GoogleAdsLinkName : gax::IResourceName, sys::IEquatable<GoogleAdsLinkName>
    {
        /// <summary>The possible contents of <see cref="GoogleAdsLinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>properties/{property}/googleAdsLinks/{google_ads_link}</c>.
            /// </summary>
            PropertyGoogleAdsLink = 1,
        }

        private static gax::PathTemplate s_propertyGoogleAdsLink = new gax::PathTemplate("properties/{property}/googleAdsLinks/{google_ads_link}");

        /// <summary>Creates a <see cref="GoogleAdsLinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GoogleAdsLinkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GoogleAdsLinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GoogleAdsLinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GoogleAdsLinkName"/> with the pattern
        /// <c>properties/{property}/googleAdsLinks/{google_ads_link}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="googleAdsLinkId">The <c>GoogleAdsLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GoogleAdsLinkName"/> constructed from the provided ids.</returns>
        public static GoogleAdsLinkName FromPropertyGoogleAdsLink(string propertyId, string googleAdsLinkId) =>
            new GoogleAdsLinkName(ResourceNameType.PropertyGoogleAdsLink, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), googleAdsLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(googleAdsLinkId, nameof(googleAdsLinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GoogleAdsLinkName"/> with pattern
        /// <c>properties/{property}/googleAdsLinks/{google_ads_link}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="googleAdsLinkId">The <c>GoogleAdsLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GoogleAdsLinkName"/> with pattern
        /// <c>properties/{property}/googleAdsLinks/{google_ads_link}</c>.
        /// </returns>
        public static string Format(string propertyId, string googleAdsLinkId) =>
            FormatPropertyGoogleAdsLink(propertyId, googleAdsLinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GoogleAdsLinkName"/> with pattern
        /// <c>properties/{property}/googleAdsLinks/{google_ads_link}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="googleAdsLinkId">The <c>GoogleAdsLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GoogleAdsLinkName"/> with pattern
        /// <c>properties/{property}/googleAdsLinks/{google_ads_link}</c>.
        /// </returns>
        public static string FormatPropertyGoogleAdsLink(string propertyId, string googleAdsLinkId) =>
            s_propertyGoogleAdsLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(googleAdsLinkId, nameof(googleAdsLinkId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GoogleAdsLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/googleAdsLinks/{google_ads_link}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="googleAdsLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GoogleAdsLinkName"/> if successful.</returns>
        public static GoogleAdsLinkName Parse(string googleAdsLinkName) => Parse(googleAdsLinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GoogleAdsLinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/googleAdsLinks/{google_ads_link}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="googleAdsLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GoogleAdsLinkName"/> if successful.</returns>
        public static GoogleAdsLinkName Parse(string googleAdsLinkName, bool allowUnparsed) =>
            TryParse(googleAdsLinkName, allowUnparsed, out GoogleAdsLinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GoogleAdsLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/googleAdsLinks/{google_ads_link}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="googleAdsLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GoogleAdsLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string googleAdsLinkName, out GoogleAdsLinkName result) =>
            TryParse(googleAdsLinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GoogleAdsLinkName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/googleAdsLinks/{google_ads_link}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="googleAdsLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GoogleAdsLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string googleAdsLinkName, bool allowUnparsed, out GoogleAdsLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(googleAdsLinkName, nameof(googleAdsLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyGoogleAdsLink.TryParseName(googleAdsLinkName, out resourceName))
            {
                result = FromPropertyGoogleAdsLink(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(googleAdsLinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GoogleAdsLinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string googleAdsLinkId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GoogleAdsLinkId = googleAdsLinkId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GoogleAdsLinkName"/> class from the component parts of pattern
        /// <c>properties/{property}/googleAdsLinks/{google_ads_link}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="googleAdsLinkId">The <c>GoogleAdsLink</c> ID. Must not be <c>null</c> or empty.</param>
        public GoogleAdsLinkName(string propertyId, string googleAdsLinkId) : this(ResourceNameType.PropertyGoogleAdsLink, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), googleAdsLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(googleAdsLinkId, nameof(googleAdsLinkId)))
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
        /// The <c>GoogleAdsLink</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string GoogleAdsLinkId { get; }

        /// <summary>
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyGoogleAdsLink: return s_propertyGoogleAdsLink.Expand(PropertyId, GoogleAdsLinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GoogleAdsLinkName);

        /// <inheritdoc/>
        public bool Equals(GoogleAdsLinkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GoogleAdsLinkName a, GoogleAdsLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GoogleAdsLinkName a, GoogleAdsLinkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataSharingSettings</c> resource.</summary>
    public sealed partial class DataSharingSettingsName : gax::IResourceName, sys::IEquatable<DataSharingSettingsName>
    {
        /// <summary>The possible contents of <see cref="DataSharingSettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/dataSharingSettings</c>.</summary>
            Account = 1,
        }

        private static gax::PathTemplate s_account = new gax::PathTemplate("accounts/{account}/dataSharingSettings");

        /// <summary>Creates a <see cref="DataSharingSettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataSharingSettingsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataSharingSettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataSharingSettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataSharingSettingsName"/> with the pattern <c>accounts/{account}/dataSharingSettings</c>
        /// .
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="DataSharingSettingsName"/> constructed from the provided ids.
        /// </returns>
        public static DataSharingSettingsName FromAccount(string accountId) =>
            new DataSharingSettingsName(ResourceNameType.Account, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataSharingSettingsName"/> with pattern
        /// <c>accounts/{account}/dataSharingSettings</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataSharingSettingsName"/> with pattern
        /// <c>accounts/{account}/dataSharingSettings</c>.
        /// </returns>
        public static string Format(string accountId) => FormatAccount(accountId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataSharingSettingsName"/> with pattern
        /// <c>accounts/{account}/dataSharingSettings</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataSharingSettingsName"/> with pattern
        /// <c>accounts/{account}/dataSharingSettings</c>.
        /// </returns>
        public static string FormatAccount(string accountId) =>
            s_account.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataSharingSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/dataSharingSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataSharingSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataSharingSettingsName"/> if successful.</returns>
        public static DataSharingSettingsName Parse(string dataSharingSettingsName) => Parse(dataSharingSettingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataSharingSettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/dataSharingSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataSharingSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataSharingSettingsName"/> if successful.</returns>
        public static DataSharingSettingsName Parse(string dataSharingSettingsName, bool allowUnparsed) =>
            TryParse(dataSharingSettingsName, allowUnparsed, out DataSharingSettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataSharingSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/dataSharingSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataSharingSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataSharingSettingsName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSharingSettingsName, out DataSharingSettingsName result) =>
            TryParse(dataSharingSettingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataSharingSettingsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/dataSharingSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataSharingSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataSharingSettingsName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSharingSettingsName, bool allowUnparsed, out DataSharingSettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataSharingSettingsName, nameof(dataSharingSettingsName));
            gax::TemplatedResourceName resourceName;
            if (s_account.TryParseName(dataSharingSettingsName, out resourceName))
            {
                result = FromAccount(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataSharingSettingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataSharingSettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataSharingSettingsName"/> class from the component parts of
        /// pattern <c>accounts/{account}/dataSharingSettings</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        public DataSharingSettingsName(string accountId) : this(ResourceNameType.Account, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)))
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
        public override bool Equals(object obj) => Equals(obj as DataSharingSettingsName);

        /// <inheritdoc/>
        public bool Equals(DataSharingSettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataSharingSettingsName a, DataSharingSettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataSharingSettingsName a, DataSharingSettingsName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AccountSummary</c> resource.</summary>
    public sealed partial class AccountSummaryName : gax::IResourceName, sys::IEquatable<AccountSummaryName>
    {
        /// <summary>The possible contents of <see cref="AccountSummaryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accountSummaries/{account_summary}</c>.</summary>
            AccountSummary = 1,
        }

        private static gax::PathTemplate s_accountSummary = new gax::PathTemplate("accountSummaries/{account_summary}");

        /// <summary>Creates a <see cref="AccountSummaryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccountSummaryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccountSummaryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccountSummaryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccountSummaryName"/> with the pattern <c>accountSummaries/{account_summary}</c>.
        /// </summary>
        /// <param name="accountSummaryId">The <c>AccountSummary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccountSummaryName"/> constructed from the provided ids.</returns>
        public static AccountSummaryName FromAccountSummary(string accountSummaryId) =>
            new AccountSummaryName(ResourceNameType.AccountSummary, accountSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountSummaryId, nameof(accountSummaryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountSummaryName"/> with pattern
        /// <c>accountSummaries/{account_summary}</c>.
        /// </summary>
        /// <param name="accountSummaryId">The <c>AccountSummary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountSummaryName"/> with pattern
        /// <c>accountSummaries/{account_summary}</c>.
        /// </returns>
        public static string Format(string accountSummaryId) => FormatAccountSummary(accountSummaryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountSummaryName"/> with pattern
        /// <c>accountSummaries/{account_summary}</c>.
        /// </summary>
        /// <param name="accountSummaryId">The <c>AccountSummary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountSummaryName"/> with pattern
        /// <c>accountSummaries/{account_summary}</c>.
        /// </returns>
        public static string FormatAccountSummary(string accountSummaryId) =>
            s_accountSummary.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountSummaryId, nameof(accountSummaryId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountSummaryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accountSummaries/{account_summary}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accountSummaryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccountSummaryName"/> if successful.</returns>
        public static AccountSummaryName Parse(string accountSummaryName) => Parse(accountSummaryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountSummaryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accountSummaries/{account_summary}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountSummaryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccountSummaryName"/> if successful.</returns>
        public static AccountSummaryName Parse(string accountSummaryName, bool allowUnparsed) =>
            TryParse(accountSummaryName, allowUnparsed, out AccountSummaryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountSummaryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accountSummaries/{account_summary}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accountSummaryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountSummaryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountSummaryName, out AccountSummaryName result) =>
            TryParse(accountSummaryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountSummaryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accountSummaries/{account_summary}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountSummaryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountSummaryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountSummaryName, bool allowUnparsed, out AccountSummaryName result)
        {
            gax::GaxPreconditions.CheckNotNull(accountSummaryName, nameof(accountSummaryName));
            gax::TemplatedResourceName resourceName;
            if (s_accountSummary.TryParseName(accountSummaryName, out resourceName))
            {
                result = FromAccountSummary(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accountSummaryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccountSummaryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountSummaryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountSummaryId = accountSummaryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccountSummaryName"/> class from the component parts of pattern
        /// <c>accountSummaries/{account_summary}</c>
        /// </summary>
        /// <param name="accountSummaryId">The <c>AccountSummary</c> ID. Must not be <c>null</c> or empty.</param>
        public AccountSummaryName(string accountSummaryId) : this(ResourceNameType.AccountSummary, accountSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountSummaryId, nameof(accountSummaryId)))
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
        /// The <c>AccountSummary</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AccountSummaryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountSummary: return s_accountSummary.Expand(AccountSummaryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccountSummaryName);

        /// <inheritdoc/>
        public bool Equals(AccountSummaryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccountSummaryName a, AccountSummaryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccountSummaryName a, AccountSummaryName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MeasurementProtocolSecret</c> resource.</summary>
    public sealed partial class MeasurementProtocolSecretName : gax::IResourceName, sys::IEquatable<MeasurementProtocolSecretName>
    {
        /// <summary>The possible contents of <see cref="MeasurementProtocolSecretName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// properties/{property}/dataStreams/{data_stream}/measurementProtocolSecrets/{measurement_protocol_secret}</c>
            /// .
            /// </summary>
            PropertyDataStreamMeasurementProtocolSecret = 1,
        }

        private static gax::PathTemplate s_propertyDataStreamMeasurementProtocolSecret = new gax::PathTemplate("properties/{property}/dataStreams/{data_stream}/measurementProtocolSecrets/{measurement_protocol_secret}");

        /// <summary>
        /// Creates a <see cref="MeasurementProtocolSecretName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MeasurementProtocolSecretName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MeasurementProtocolSecretName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MeasurementProtocolSecretName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MeasurementProtocolSecretName"/> with the pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/measurementProtocolSecrets/{measurement_protocol_secret}</c>
        /// .
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="measurementProtocolSecretId">
        /// The <c>MeasurementProtocolSecret</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="MeasurementProtocolSecretName"/> constructed from the provided ids.
        /// </returns>
        public static MeasurementProtocolSecretName FromPropertyDataStreamMeasurementProtocolSecret(string propertyId, string dataStreamId, string measurementProtocolSecretId) =>
            new MeasurementProtocolSecretName(ResourceNameType.PropertyDataStreamMeasurementProtocolSecret, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), dataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStreamId, nameof(dataStreamId)), measurementProtocolSecretId: gax::GaxPreconditions.CheckNotNullOrEmpty(measurementProtocolSecretId, nameof(measurementProtocolSecretId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MeasurementProtocolSecretName"/> with
        /// pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/measurementProtocolSecrets/{measurement_protocol_secret}</c>
        /// .
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="measurementProtocolSecretId">
        /// The <c>MeasurementProtocolSecret</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MeasurementProtocolSecretName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/measurementProtocolSecrets/{measurement_protocol_secret}</c>
        /// .
        /// </returns>
        public static string Format(string propertyId, string dataStreamId, string measurementProtocolSecretId) =>
            FormatPropertyDataStreamMeasurementProtocolSecret(propertyId, dataStreamId, measurementProtocolSecretId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MeasurementProtocolSecretName"/> with
        /// pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/measurementProtocolSecrets/{measurement_protocol_secret}</c>
        /// .
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="measurementProtocolSecretId">
        /// The <c>MeasurementProtocolSecret</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MeasurementProtocolSecretName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/measurementProtocolSecrets/{measurement_protocol_secret}</c>
        /// .
        /// </returns>
        public static string FormatPropertyDataStreamMeasurementProtocolSecret(string propertyId, string dataStreamId, string measurementProtocolSecretId) =>
            s_propertyDataStreamMeasurementProtocolSecret.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStreamId, nameof(dataStreamId)), gax::GaxPreconditions.CheckNotNullOrEmpty(measurementProtocolSecretId, nameof(measurementProtocolSecretId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MeasurementProtocolSecretName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/dataStreams/{data_stream}/measurementProtocolSecrets/{measurement_protocol_secret}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="measurementProtocolSecretName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="MeasurementProtocolSecretName"/> if successful.</returns>
        public static MeasurementProtocolSecretName Parse(string measurementProtocolSecretName) =>
            Parse(measurementProtocolSecretName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MeasurementProtocolSecretName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/dataStreams/{data_stream}/measurementProtocolSecrets/{measurement_protocol_secret}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="measurementProtocolSecretName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MeasurementProtocolSecretName"/> if successful.</returns>
        public static MeasurementProtocolSecretName Parse(string measurementProtocolSecretName, bool allowUnparsed) =>
            TryParse(measurementProtocolSecretName, allowUnparsed, out MeasurementProtocolSecretName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MeasurementProtocolSecretName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/dataStreams/{data_stream}/measurementProtocolSecrets/{measurement_protocol_secret}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="measurementProtocolSecretName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MeasurementProtocolSecretName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string measurementProtocolSecretName, out MeasurementProtocolSecretName result) =>
            TryParse(measurementProtocolSecretName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MeasurementProtocolSecretName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/dataStreams/{data_stream}/measurementProtocolSecrets/{measurement_protocol_secret}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="measurementProtocolSecretName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MeasurementProtocolSecretName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string measurementProtocolSecretName, bool allowUnparsed, out MeasurementProtocolSecretName result)
        {
            gax::GaxPreconditions.CheckNotNull(measurementProtocolSecretName, nameof(measurementProtocolSecretName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyDataStreamMeasurementProtocolSecret.TryParseName(measurementProtocolSecretName, out resourceName))
            {
                result = FromPropertyDataStreamMeasurementProtocolSecret(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(measurementProtocolSecretName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MeasurementProtocolSecretName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataStreamId = null, string measurementProtocolSecretId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataStreamId = dataStreamId;
            MeasurementProtocolSecretId = measurementProtocolSecretId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MeasurementProtocolSecretName"/> class from the component parts of
        /// pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/measurementProtocolSecrets/{measurement_protocol_secret}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="measurementProtocolSecretId">
        /// The <c>MeasurementProtocolSecret</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public MeasurementProtocolSecretName(string propertyId, string dataStreamId, string measurementProtocolSecretId) : this(ResourceNameType.PropertyDataStreamMeasurementProtocolSecret, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), dataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStreamId, nameof(dataStreamId)), measurementProtocolSecretId: gax::GaxPreconditions.CheckNotNullOrEmpty(measurementProtocolSecretId, nameof(measurementProtocolSecretId)))
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
        /// The <c>DataStream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataStreamId { get; }

        /// <summary>
        /// The <c>MeasurementProtocolSecret</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string MeasurementProtocolSecretId { get; }

        /// <summary>
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyDataStreamMeasurementProtocolSecret: return s_propertyDataStreamMeasurementProtocolSecret.Expand(PropertyId, DataStreamId, MeasurementProtocolSecretId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MeasurementProtocolSecretName);

        /// <inheritdoc/>
        public bool Equals(MeasurementProtocolSecretName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MeasurementProtocolSecretName a, MeasurementProtocolSecretName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MeasurementProtocolSecretName a, MeasurementProtocolSecretName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ConversionEvent</c> resource.</summary>
    public sealed partial class ConversionEventName : gax::IResourceName, sys::IEquatable<ConversionEventName>
    {
        /// <summary>The possible contents of <see cref="ConversionEventName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>properties/{property}/conversionEvents/{conversion_event}</c>.
            /// </summary>
            PropertyConversionEvent = 1,
        }

        private static gax::PathTemplate s_propertyConversionEvent = new gax::PathTemplate("properties/{property}/conversionEvents/{conversion_event}");

        /// <summary>Creates a <see cref="ConversionEventName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConversionEventName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConversionEventName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConversionEventName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConversionEventName"/> with the pattern
        /// <c>properties/{property}/conversionEvents/{conversion_event}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionEventId">The <c>ConversionEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConversionEventName"/> constructed from the provided ids.</returns>
        public static ConversionEventName FromPropertyConversionEvent(string propertyId, string conversionEventId) =>
            new ConversionEventName(ResourceNameType.PropertyConversionEvent, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), conversionEventId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversionEventId, nameof(conversionEventId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversionEventName"/> with pattern
        /// <c>properties/{property}/conversionEvents/{conversion_event}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionEventId">The <c>ConversionEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversionEventName"/> with pattern
        /// <c>properties/{property}/conversionEvents/{conversion_event}</c>.
        /// </returns>
        public static string Format(string propertyId, string conversionEventId) =>
            FormatPropertyConversionEvent(propertyId, conversionEventId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversionEventName"/> with pattern
        /// <c>properties/{property}/conversionEvents/{conversion_event}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionEventId">The <c>ConversionEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversionEventName"/> with pattern
        /// <c>properties/{property}/conversionEvents/{conversion_event}</c>.
        /// </returns>
        public static string FormatPropertyConversionEvent(string propertyId, string conversionEventId) =>
            s_propertyConversionEvent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversionEventId, nameof(conversionEventId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversionEventName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/conversionEvents/{conversion_event}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="conversionEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConversionEventName"/> if successful.</returns>
        public static ConversionEventName Parse(string conversionEventName) => Parse(conversionEventName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversionEventName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/conversionEvents/{conversion_event}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversionEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConversionEventName"/> if successful.</returns>
        public static ConversionEventName Parse(string conversionEventName, bool allowUnparsed) =>
            TryParse(conversionEventName, allowUnparsed, out ConversionEventName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversionEventName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/conversionEvents/{conversion_event}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="conversionEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversionEventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversionEventName, out ConversionEventName result) =>
            TryParse(conversionEventName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversionEventName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/conversionEvents/{conversion_event}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversionEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversionEventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversionEventName, bool allowUnparsed, out ConversionEventName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversionEventName, nameof(conversionEventName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyConversionEvent.TryParseName(conversionEventName, out resourceName))
            {
                result = FromPropertyConversionEvent(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conversionEventName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConversionEventName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversionEventId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversionEventId = conversionEventId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConversionEventName"/> class from the component parts of pattern
        /// <c>properties/{property}/conversionEvents/{conversion_event}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionEventId">The <c>ConversionEvent</c> ID. Must not be <c>null</c> or empty.</param>
        public ConversionEventName(string propertyId, string conversionEventId) : this(ResourceNameType.PropertyConversionEvent, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), conversionEventId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversionEventId, nameof(conversionEventId)))
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
        /// The <c>ConversionEvent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConversionEventId { get; }

        /// <summary>
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyConversionEvent: return s_propertyConversionEvent.Expand(PropertyId, ConversionEventId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConversionEventName);

        /// <inheritdoc/>
        public bool Equals(ConversionEventName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConversionEventName a, ConversionEventName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConversionEventName a, ConversionEventName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>KeyEvent</c> resource.</summary>
    public sealed partial class KeyEventName : gax::IResourceName, sys::IEquatable<KeyEventName>
    {
        /// <summary>The possible contents of <see cref="KeyEventName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>properties/{property}/keyEvents/{key_event}</c>.</summary>
            PropertyKeyEvent = 1,
        }

        private static gax::PathTemplate s_propertyKeyEvent = new gax::PathTemplate("properties/{property}/keyEvents/{key_event}");

        /// <summary>Creates a <see cref="KeyEventName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="KeyEventName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static KeyEventName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new KeyEventName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="KeyEventName"/> with the pattern <c>properties/{property}/keyEvents/{key_event}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyEventId">The <c>KeyEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="KeyEventName"/> constructed from the provided ids.</returns>
        public static KeyEventName FromPropertyKeyEvent(string propertyId, string keyEventId) =>
            new KeyEventName(ResourceNameType.PropertyKeyEvent, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), keyEventId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyEventId, nameof(keyEventId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeyEventName"/> with pattern
        /// <c>properties/{property}/keyEvents/{key_event}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyEventId">The <c>KeyEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="KeyEventName"/> with pattern
        /// <c>properties/{property}/keyEvents/{key_event}</c>.
        /// </returns>
        public static string Format(string propertyId, string keyEventId) => FormatPropertyKeyEvent(propertyId, keyEventId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeyEventName"/> with pattern
        /// <c>properties/{property}/keyEvents/{key_event}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyEventId">The <c>KeyEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="KeyEventName"/> with pattern
        /// <c>properties/{property}/keyEvents/{key_event}</c>.
        /// </returns>
        public static string FormatPropertyKeyEvent(string propertyId, string keyEventId) =>
            s_propertyKeyEvent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keyEventId, nameof(keyEventId)));

        /// <summary>Parses the given resource name string into a new <see cref="KeyEventName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/keyEvents/{key_event}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="keyEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeyEventName"/> if successful.</returns>
        public static KeyEventName Parse(string keyEventName) => Parse(keyEventName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeyEventName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/keyEvents/{key_event}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keyEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="KeyEventName"/> if successful.</returns>
        public static KeyEventName Parse(string keyEventName, bool allowUnparsed) =>
            TryParse(keyEventName, allowUnparsed, out KeyEventName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeyEventName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/keyEvents/{key_event}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="keyEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeyEventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keyEventName, out KeyEventName result) => TryParse(keyEventName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeyEventName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/keyEvents/{key_event}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keyEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeyEventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keyEventName, bool allowUnparsed, out KeyEventName result)
        {
            gax::GaxPreconditions.CheckNotNull(keyEventName, nameof(keyEventName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyKeyEvent.TryParseName(keyEventName, out resourceName))
            {
                result = FromPropertyKeyEvent(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(keyEventName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private KeyEventName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string keyEventId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            KeyEventId = keyEventId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="KeyEventName"/> class from the component parts of pattern
        /// <c>properties/{property}/keyEvents/{key_event}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyEventId">The <c>KeyEvent</c> ID. Must not be <c>null</c> or empty.</param>
        public KeyEventName(string propertyId, string keyEventId) : this(ResourceNameType.PropertyKeyEvent, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), keyEventId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyEventId, nameof(keyEventId)))
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
        /// The <c>KeyEvent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string KeyEventId { get; }

        /// <summary>
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyKeyEvent: return s_propertyKeyEvent.Expand(PropertyId, KeyEventId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as KeyEventName);

        /// <inheritdoc/>
        public bool Equals(KeyEventName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(KeyEventName a, KeyEventName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(KeyEventName a, KeyEventName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CustomDimension</c> resource.</summary>
    public sealed partial class CustomDimensionName : gax::IResourceName, sys::IEquatable<CustomDimensionName>
    {
        /// <summary>The possible contents of <see cref="CustomDimensionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>properties/{property}/customDimensions/{custom_dimension}</c>.
            /// </summary>
            PropertyCustomDimension = 1,
        }

        private static gax::PathTemplate s_propertyCustomDimension = new gax::PathTemplate("properties/{property}/customDimensions/{custom_dimension}");

        /// <summary>Creates a <see cref="CustomDimensionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomDimensionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomDimensionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomDimensionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomDimensionName"/> with the pattern
        /// <c>properties/{property}/customDimensions/{custom_dimension}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customDimensionId">The <c>CustomDimension</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomDimensionName"/> constructed from the provided ids.</returns>
        public static CustomDimensionName FromPropertyCustomDimension(string propertyId, string customDimensionId) =>
            new CustomDimensionName(ResourceNameType.PropertyCustomDimension, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), customDimensionId: gax::GaxPreconditions.CheckNotNullOrEmpty(customDimensionId, nameof(customDimensionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomDimensionName"/> with pattern
        /// <c>properties/{property}/customDimensions/{custom_dimension}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customDimensionId">The <c>CustomDimension</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomDimensionName"/> with pattern
        /// <c>properties/{property}/customDimensions/{custom_dimension}</c>.
        /// </returns>
        public static string Format(string propertyId, string customDimensionId) =>
            FormatPropertyCustomDimension(propertyId, customDimensionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomDimensionName"/> with pattern
        /// <c>properties/{property}/customDimensions/{custom_dimension}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customDimensionId">The <c>CustomDimension</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomDimensionName"/> with pattern
        /// <c>properties/{property}/customDimensions/{custom_dimension}</c>.
        /// </returns>
        public static string FormatPropertyCustomDimension(string propertyId, string customDimensionId) =>
            s_propertyCustomDimension.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customDimensionId, nameof(customDimensionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomDimensionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/customDimensions/{custom_dimension}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customDimensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomDimensionName"/> if successful.</returns>
        public static CustomDimensionName Parse(string customDimensionName) => Parse(customDimensionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomDimensionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/customDimensions/{custom_dimension}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customDimensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomDimensionName"/> if successful.</returns>
        public static CustomDimensionName Parse(string customDimensionName, bool allowUnparsed) =>
            TryParse(customDimensionName, allowUnparsed, out CustomDimensionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomDimensionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/customDimensions/{custom_dimension}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customDimensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomDimensionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customDimensionName, out CustomDimensionName result) =>
            TryParse(customDimensionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomDimensionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/customDimensions/{custom_dimension}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customDimensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomDimensionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customDimensionName, bool allowUnparsed, out CustomDimensionName result)
        {
            gax::GaxPreconditions.CheckNotNull(customDimensionName, nameof(customDimensionName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyCustomDimension.TryParseName(customDimensionName, out resourceName))
            {
                result = FromPropertyCustomDimension(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customDimensionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomDimensionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customDimensionId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomDimensionId = customDimensionId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomDimensionName"/> class from the component parts of pattern
        /// <c>properties/{property}/customDimensions/{custom_dimension}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customDimensionId">The <c>CustomDimension</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomDimensionName(string propertyId, string customDimensionId) : this(ResourceNameType.PropertyCustomDimension, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), customDimensionId: gax::GaxPreconditions.CheckNotNullOrEmpty(customDimensionId, nameof(customDimensionId)))
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
        /// The <c>CustomDimension</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CustomDimensionId { get; }

        /// <summary>
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyCustomDimension: return s_propertyCustomDimension.Expand(PropertyId, CustomDimensionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomDimensionName);

        /// <inheritdoc/>
        public bool Equals(CustomDimensionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomDimensionName a, CustomDimensionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CustomDimensionName a, CustomDimensionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CustomMetric</c> resource.</summary>
    public sealed partial class CustomMetricName : gax::IResourceName, sys::IEquatable<CustomMetricName>
    {
        /// <summary>The possible contents of <see cref="CustomMetricName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>properties/{property}/customMetrics/{custom_metric}</c>.
            /// </summary>
            PropertyCustomMetric = 1,
        }

        private static gax::PathTemplate s_propertyCustomMetric = new gax::PathTemplate("properties/{property}/customMetrics/{custom_metric}");

        /// <summary>Creates a <see cref="CustomMetricName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomMetricName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomMetricName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomMetricName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomMetricName"/> with the pattern
        /// <c>properties/{property}/customMetrics/{custom_metric}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customMetricId">The <c>CustomMetric</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomMetricName"/> constructed from the provided ids.</returns>
        public static CustomMetricName FromPropertyCustomMetric(string propertyId, string customMetricId) =>
            new CustomMetricName(ResourceNameType.PropertyCustomMetric, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), customMetricId: gax::GaxPreconditions.CheckNotNullOrEmpty(customMetricId, nameof(customMetricId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomMetricName"/> with pattern
        /// <c>properties/{property}/customMetrics/{custom_metric}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customMetricId">The <c>CustomMetric</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomMetricName"/> with pattern
        /// <c>properties/{property}/customMetrics/{custom_metric}</c>.
        /// </returns>
        public static string Format(string propertyId, string customMetricId) =>
            FormatPropertyCustomMetric(propertyId, customMetricId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomMetricName"/> with pattern
        /// <c>properties/{property}/customMetrics/{custom_metric}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customMetricId">The <c>CustomMetric</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomMetricName"/> with pattern
        /// <c>properties/{property}/customMetrics/{custom_metric}</c>.
        /// </returns>
        public static string FormatPropertyCustomMetric(string propertyId, string customMetricId) =>
            s_propertyCustomMetric.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customMetricId, nameof(customMetricId)));

        /// <summary>Parses the given resource name string into a new <see cref="CustomMetricName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/customMetrics/{custom_metric}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customMetricName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomMetricName"/> if successful.</returns>
        public static CustomMetricName Parse(string customMetricName) => Parse(customMetricName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomMetricName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/customMetrics/{custom_metric}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customMetricName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomMetricName"/> if successful.</returns>
        public static CustomMetricName Parse(string customMetricName, bool allowUnparsed) =>
            TryParse(customMetricName, allowUnparsed, out CustomMetricName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomMetricName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/customMetrics/{custom_metric}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customMetricName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomMetricName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customMetricName, out CustomMetricName result) =>
            TryParse(customMetricName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomMetricName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/customMetrics/{custom_metric}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customMetricName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomMetricName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customMetricName, bool allowUnparsed, out CustomMetricName result)
        {
            gax::GaxPreconditions.CheckNotNull(customMetricName, nameof(customMetricName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyCustomMetric.TryParseName(customMetricName, out resourceName))
            {
                result = FromPropertyCustomMetric(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customMetricName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomMetricName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customMetricId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomMetricId = customMetricId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomMetricName"/> class from the component parts of pattern
        /// <c>properties/{property}/customMetrics/{custom_metric}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customMetricId">The <c>CustomMetric</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomMetricName(string propertyId, string customMetricId) : this(ResourceNameType.PropertyCustomMetric, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), customMetricId: gax::GaxPreconditions.CheckNotNullOrEmpty(customMetricId, nameof(customMetricId)))
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
        /// The <c>CustomMetric</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CustomMetricId { get; }

        /// <summary>
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyCustomMetric: return s_propertyCustomMetric.Expand(PropertyId, CustomMetricId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomMetricName);

        /// <inheritdoc/>
        public bool Equals(CustomMetricName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomMetricName a, CustomMetricName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CustomMetricName a, CustomMetricName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataRetentionSettings</c> resource.</summary>
    public sealed partial class DataRetentionSettingsName : gax::IResourceName, sys::IEquatable<DataRetentionSettingsName>
    {
        /// <summary>The possible contents of <see cref="DataRetentionSettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>properties/{property}/dataRetentionSettings</c>.</summary>
            Property = 1,
        }

        private static gax::PathTemplate s_property = new gax::PathTemplate("properties/{property}/dataRetentionSettings");

        /// <summary>Creates a <see cref="DataRetentionSettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataRetentionSettingsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataRetentionSettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataRetentionSettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataRetentionSettingsName"/> with the pattern
        /// <c>properties/{property}/dataRetentionSettings</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="DataRetentionSettingsName"/> constructed from the provided ids.
        /// </returns>
        public static DataRetentionSettingsName FromProperty(string propertyId) =>
            new DataRetentionSettingsName(ResourceNameType.Property, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataRetentionSettingsName"/> with pattern
        /// <c>properties/{property}/dataRetentionSettings</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataRetentionSettingsName"/> with pattern
        /// <c>properties/{property}/dataRetentionSettings</c>.
        /// </returns>
        public static string Format(string propertyId) => FormatProperty(propertyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataRetentionSettingsName"/> with pattern
        /// <c>properties/{property}/dataRetentionSettings</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataRetentionSettingsName"/> with pattern
        /// <c>properties/{property}/dataRetentionSettings</c>.
        /// </returns>
        public static string FormatProperty(string propertyId) =>
            s_property.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataRetentionSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/dataRetentionSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataRetentionSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataRetentionSettingsName"/> if successful.</returns>
        public static DataRetentionSettingsName Parse(string dataRetentionSettingsName) =>
            Parse(dataRetentionSettingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataRetentionSettingsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/dataRetentionSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataRetentionSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataRetentionSettingsName"/> if successful.</returns>
        public static DataRetentionSettingsName Parse(string dataRetentionSettingsName, bool allowUnparsed) =>
            TryParse(dataRetentionSettingsName, allowUnparsed, out DataRetentionSettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataRetentionSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/dataRetentionSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataRetentionSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataRetentionSettingsName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataRetentionSettingsName, out DataRetentionSettingsName result) =>
            TryParse(dataRetentionSettingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataRetentionSettingsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/dataRetentionSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataRetentionSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataRetentionSettingsName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataRetentionSettingsName, bool allowUnparsed, out DataRetentionSettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataRetentionSettingsName, nameof(dataRetentionSettingsName));
            gax::TemplatedResourceName resourceName;
            if (s_property.TryParseName(dataRetentionSettingsName, out resourceName))
            {
                result = FromProperty(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataRetentionSettingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataRetentionSettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataRetentionSettingsName"/> class from the component parts of
        /// pattern <c>properties/{property}/dataRetentionSettings</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        public DataRetentionSettingsName(string propertyId) : this(ResourceNameType.Property, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)))
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
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Property: return s_property.Expand(PropertyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataRetentionSettingsName);

        /// <inheritdoc/>
        public bool Equals(DataRetentionSettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataRetentionSettingsName a, DataRetentionSettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataRetentionSettingsName a, DataRetentionSettingsName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Organization</c> resource.</summary>
    public sealed partial class OrganizationName : gax::IResourceName, sys::IEquatable<OrganizationName>
    {
        /// <summary>The possible contents of <see cref="OrganizationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>organizations/{organization}</c>.</summary>
            Organization = 1,
        }

        private static gax::PathTemplate s_organization = new gax::PathTemplate("organizations/{organization}");

        /// <summary>Creates a <see cref="OrganizationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrganizationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrganizationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrganizationName"/> with the pattern <c>organizations/{organization}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OrganizationName"/> constructed from the provided ids.</returns>
        public static OrganizationName FromOrganization(string organizationId) =>
            new OrganizationName(ResourceNameType.Organization, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationName"/> with pattern
        /// <c>organizations/{organization}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationName"/> with pattern
        /// <c>organizations/{organization}</c>.
        /// </returns>
        public static string Format(string organizationId) => FormatOrganization(organizationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationName"/> with pattern
        /// <c>organizations/{organization}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationName"/> with pattern
        /// <c>organizations/{organization}</c>.
        /// </returns>
        public static string FormatOrganization(string organizationId) =>
            s_organization.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>Parses the given resource name string into a new <see cref="OrganizationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>organizations/{organization}</c></description></item></list>
        /// </remarks>
        /// <param name="organizationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationName"/> if successful.</returns>
        public static OrganizationName Parse(string organizationName) => Parse(organizationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>organizations/{organization}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrganizationName"/> if successful.</returns>
        public static OrganizationName Parse(string organizationName, bool allowUnparsed) =>
            TryParse(organizationName, allowUnparsed, out OrganizationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>organizations/{organization}</c></description></item></list>
        /// </remarks>
        /// <param name="organizationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationName, out OrganizationName result) =>
            TryParse(organizationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>organizations/{organization}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationName, bool allowUnparsed, out OrganizationName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationName, nameof(organizationName));
            gax::TemplatedResourceName resourceName;
            if (s_organization.TryParseName(organizationName, out resourceName))
            {
                result = FromOrganization(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(organizationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrganizationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrganizationName"/> class from the component parts of pattern
        /// <c>organizations/{organization}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        public OrganizationName(string organizationId) : this(ResourceNameType.Organization, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)))
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
        /// The <c>Organization</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Organization: return s_organization.Expand(OrganizationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrganizationName);

        /// <inheritdoc/>
        public bool Equals(OrganizationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrganizationName a, OrganizationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrganizationName a, OrganizationName b) => !(a == b);
    }

    public partial class Account
    {
        /// <summary>
        /// <see cref="gaav::AccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AccountName AccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationName"/>-typed view over the <see cref="GmpOrganization"/> resource name property.
        /// </summary>
        public OrganizationName GmpOrganizationAsOrganizationName
        {
            get => string.IsNullOrEmpty(GmpOrganization) ? null : OrganizationName.Parse(GmpOrganization, allowUnparsed: true);
            set => GmpOrganization = value?.ToString() ?? "";
        }
    }

    public partial class Property
    {
        /// <summary>
        /// <see cref="gaav::PropertyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::PropertyName PropertyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::PropertyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Account"/> resource name property.
        /// </summary>
        public AccountName AccountAsAccountName
        {
            get => string.IsNullOrEmpty(Account) ? null : AccountName.Parse(Account, allowUnparsed: true);
            set => Account = value?.ToString() ?? "";
        }
    }

    public partial class DataStream
    {
        /// <summary>
        /// <see cref="gaav::DataStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::DataStreamName DataStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DataStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FirebaseLink
    {
        /// <summary>
        /// <see cref="gaav::FirebaseLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::FirebaseLinkName FirebaseLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::FirebaseLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GoogleAdsLink
    {
        /// <summary>
        /// <see cref="gaav::GoogleAdsLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::GoogleAdsLinkName GoogleAdsLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::GoogleAdsLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DataSharingSettings
    {
        /// <summary>
        /// <see cref="gaav::DataSharingSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::DataSharingSettingsName DataSharingSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DataSharingSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AccountSummary
    {
        /// <summary>
        /// <see cref="gaav::AccountSummaryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AccountSummaryName AccountSummaryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AccountSummaryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Account"/> resource name property.
        /// </summary>
        public AccountName AccountAsAccountName
        {
            get => string.IsNullOrEmpty(Account) ? null : AccountName.Parse(Account, allowUnparsed: true);
            set => Account = value?.ToString() ?? "";
        }
    }

    public partial class PropertySummary
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Property"/> resource name property.
        /// </summary>
        public PropertyName PropertyAsPropertyName
        {
            get => string.IsNullOrEmpty(Property) ? null : PropertyName.Parse(Property, allowUnparsed: true);
            set => Property = value?.ToString() ?? "";
        }
    }

    public partial class MeasurementProtocolSecret
    {
        /// <summary>
        /// <see cref="gaav::MeasurementProtocolSecretName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::MeasurementProtocolSecretName MeasurementProtocolSecretName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::MeasurementProtocolSecretName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ConversionEvent
    {
        /// <summary>
        /// <see cref="gaav::ConversionEventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ConversionEventName ConversionEventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ConversionEventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class KeyEvent
    {
        /// <summary>
        /// <see cref="gaav::KeyEventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::KeyEventName KeyEventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::KeyEventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CustomDimension
    {
        /// <summary>
        /// <see cref="gaav::CustomDimensionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::CustomDimensionName CustomDimensionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::CustomDimensionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CustomMetric
    {
        /// <summary>
        /// <see cref="gaav::CustomMetricName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::CustomMetricName CustomMetricName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::CustomMetricName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DataRetentionSettings
    {
        /// <summary>
        /// <see cref="gaav::DataRetentionSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::DataRetentionSettingsName DataRetentionSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DataRetentionSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

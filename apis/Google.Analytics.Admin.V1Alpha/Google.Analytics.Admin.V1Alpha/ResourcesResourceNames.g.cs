// Copyright 2021 Google LLC
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

using gaav = Google.Analytics.Admin.V1Alpha;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Analytics.Admin.V1Alpha
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

        /// <inheritdoc/>
        public static bool operator ==(AccountName a, AccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public static bool operator ==(PropertyName a, PropertyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(PropertyName a, PropertyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AndroidAppDataStream</c> resource.</summary>
    public sealed partial class AndroidAppDataStreamName : gax::IResourceName, sys::IEquatable<AndroidAppDataStreamName>
    {
        /// <summary>The possible contents of <see cref="AndroidAppDataStreamName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>properties/{property}/androidAppDataStreams/{android_app_data_stream}</c>
            /// .
            /// </summary>
            PropertyAndroidAppDataStream = 1,
        }

        private static gax::PathTemplate s_propertyAndroidAppDataStream = new gax::PathTemplate("properties/{property}/androidAppDataStreams/{android_app_data_stream}");

        /// <summary>Creates a <see cref="AndroidAppDataStreamName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AndroidAppDataStreamName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AndroidAppDataStreamName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AndroidAppDataStreamName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AndroidAppDataStreamName"/> with the pattern
        /// <c>properties/{property}/androidAppDataStreams/{android_app_data_stream}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="androidAppDataStreamId">
        /// The <c>AndroidAppDataStream</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="AndroidAppDataStreamName"/> constructed from the provided ids.
        /// </returns>
        public static AndroidAppDataStreamName FromPropertyAndroidAppDataStream(string propertyId, string androidAppDataStreamId) =>
            new AndroidAppDataStreamName(ResourceNameType.PropertyAndroidAppDataStream, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), androidAppDataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(androidAppDataStreamId, nameof(androidAppDataStreamId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AndroidAppDataStreamName"/> with pattern
        /// <c>properties/{property}/androidAppDataStreams/{android_app_data_stream}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="androidAppDataStreamId">
        /// The <c>AndroidAppDataStream</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AndroidAppDataStreamName"/> with pattern
        /// <c>properties/{property}/androidAppDataStreams/{android_app_data_stream}</c>.
        /// </returns>
        public static string Format(string propertyId, string androidAppDataStreamId) =>
            FormatPropertyAndroidAppDataStream(propertyId, androidAppDataStreamId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AndroidAppDataStreamName"/> with pattern
        /// <c>properties/{property}/androidAppDataStreams/{android_app_data_stream}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="androidAppDataStreamId">
        /// The <c>AndroidAppDataStream</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AndroidAppDataStreamName"/> with pattern
        /// <c>properties/{property}/androidAppDataStreams/{android_app_data_stream}</c>.
        /// </returns>
        public static string FormatPropertyAndroidAppDataStream(string propertyId, string androidAppDataStreamId) =>
            s_propertyAndroidAppDataStream.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(androidAppDataStreamId, nameof(androidAppDataStreamId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AndroidAppDataStreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>properties/{property}/androidAppDataStreams/{android_app_data_stream}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="androidAppDataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AndroidAppDataStreamName"/> if successful.</returns>
        public static AndroidAppDataStreamName Parse(string androidAppDataStreamName) =>
            Parse(androidAppDataStreamName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AndroidAppDataStreamName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>properties/{property}/androidAppDataStreams/{android_app_data_stream}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="androidAppDataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AndroidAppDataStreamName"/> if successful.</returns>
        public static AndroidAppDataStreamName Parse(string androidAppDataStreamName, bool allowUnparsed) =>
            TryParse(androidAppDataStreamName, allowUnparsed, out AndroidAppDataStreamName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AndroidAppDataStreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>properties/{property}/androidAppDataStreams/{android_app_data_stream}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="androidAppDataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AndroidAppDataStreamName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string androidAppDataStreamName, out AndroidAppDataStreamName result) =>
            TryParse(androidAppDataStreamName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AndroidAppDataStreamName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>properties/{property}/androidAppDataStreams/{android_app_data_stream}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="androidAppDataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AndroidAppDataStreamName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string androidAppDataStreamName, bool allowUnparsed, out AndroidAppDataStreamName result)
        {
            gax::GaxPreconditions.CheckNotNull(androidAppDataStreamName, nameof(androidAppDataStreamName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyAndroidAppDataStream.TryParseName(androidAppDataStreamName, out resourceName))
            {
                result = FromPropertyAndroidAppDataStream(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(androidAppDataStreamName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AndroidAppDataStreamName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string androidAppDataStreamId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AndroidAppDataStreamId = androidAppDataStreamId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AndroidAppDataStreamName"/> class from the component parts of
        /// pattern <c>properties/{property}/androidAppDataStreams/{android_app_data_stream}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="androidAppDataStreamId">
        /// The <c>AndroidAppDataStream</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AndroidAppDataStreamName(string propertyId, string androidAppDataStreamId) : this(ResourceNameType.PropertyAndroidAppDataStream, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), androidAppDataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(androidAppDataStreamId, nameof(androidAppDataStreamId)))
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
        /// The <c>AndroidAppDataStream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AndroidAppDataStreamId { get; }

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
                case ResourceNameType.PropertyAndroidAppDataStream: return s_propertyAndroidAppDataStream.Expand(PropertyId, AndroidAppDataStreamId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AndroidAppDataStreamName);

        /// <inheritdoc/>
        public bool Equals(AndroidAppDataStreamName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AndroidAppDataStreamName a, AndroidAppDataStreamName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AndroidAppDataStreamName a, AndroidAppDataStreamName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>IosAppDataStream</c> resource.</summary>
    public sealed partial class IosAppDataStreamName : gax::IResourceName, sys::IEquatable<IosAppDataStreamName>
    {
        /// <summary>The possible contents of <see cref="IosAppDataStreamName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>properties/{property}/iosAppDataStreams/{ios_app_data_stream}</c>.
            /// </summary>
            PropertyIosAppDataStream = 1,
        }

        private static gax::PathTemplate s_propertyIosAppDataStream = new gax::PathTemplate("properties/{property}/iosAppDataStreams/{ios_app_data_stream}");

        /// <summary>Creates a <see cref="IosAppDataStreamName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IosAppDataStreamName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IosAppDataStreamName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IosAppDataStreamName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IosAppDataStreamName"/> with the pattern
        /// <c>properties/{property}/iosAppDataStreams/{ios_app_data_stream}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="iosAppDataStreamId">The <c>IosAppDataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IosAppDataStreamName"/> constructed from the provided ids.</returns>
        public static IosAppDataStreamName FromPropertyIosAppDataStream(string propertyId, string iosAppDataStreamId) =>
            new IosAppDataStreamName(ResourceNameType.PropertyIosAppDataStream, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), iosAppDataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(iosAppDataStreamId, nameof(iosAppDataStreamId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IosAppDataStreamName"/> with pattern
        /// <c>properties/{property}/iosAppDataStreams/{ios_app_data_stream}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="iosAppDataStreamId">The <c>IosAppDataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IosAppDataStreamName"/> with pattern
        /// <c>properties/{property}/iosAppDataStreams/{ios_app_data_stream}</c>.
        /// </returns>
        public static string Format(string propertyId, string iosAppDataStreamId) =>
            FormatPropertyIosAppDataStream(propertyId, iosAppDataStreamId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IosAppDataStreamName"/> with pattern
        /// <c>properties/{property}/iosAppDataStreams/{ios_app_data_stream}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="iosAppDataStreamId">The <c>IosAppDataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IosAppDataStreamName"/> with pattern
        /// <c>properties/{property}/iosAppDataStreams/{ios_app_data_stream}</c>.
        /// </returns>
        public static string FormatPropertyIosAppDataStream(string propertyId, string iosAppDataStreamId) =>
            s_propertyIosAppDataStream.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(iosAppDataStreamId, nameof(iosAppDataStreamId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IosAppDataStreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>properties/{property}/iosAppDataStreams/{ios_app_data_stream}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="iosAppDataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IosAppDataStreamName"/> if successful.</returns>
        public static IosAppDataStreamName Parse(string iosAppDataStreamName) => Parse(iosAppDataStreamName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IosAppDataStreamName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>properties/{property}/iosAppDataStreams/{ios_app_data_stream}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="iosAppDataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IosAppDataStreamName"/> if successful.</returns>
        public static IosAppDataStreamName Parse(string iosAppDataStreamName, bool allowUnparsed) =>
            TryParse(iosAppDataStreamName, allowUnparsed, out IosAppDataStreamName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IosAppDataStreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>properties/{property}/iosAppDataStreams/{ios_app_data_stream}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="iosAppDataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IosAppDataStreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string iosAppDataStreamName, out IosAppDataStreamName result) =>
            TryParse(iosAppDataStreamName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IosAppDataStreamName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>properties/{property}/iosAppDataStreams/{ios_app_data_stream}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="iosAppDataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IosAppDataStreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string iosAppDataStreamName, bool allowUnparsed, out IosAppDataStreamName result)
        {
            gax::GaxPreconditions.CheckNotNull(iosAppDataStreamName, nameof(iosAppDataStreamName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyIosAppDataStream.TryParseName(iosAppDataStreamName, out resourceName))
            {
                result = FromPropertyIosAppDataStream(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(iosAppDataStreamName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IosAppDataStreamName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string iosAppDataStreamId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            IosAppDataStreamId = iosAppDataStreamId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IosAppDataStreamName"/> class from the component parts of pattern
        /// <c>properties/{property}/iosAppDataStreams/{ios_app_data_stream}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="iosAppDataStreamId">The <c>IosAppDataStream</c> ID. Must not be <c>null</c> or empty.</param>
        public IosAppDataStreamName(string propertyId, string iosAppDataStreamId) : this(ResourceNameType.PropertyIosAppDataStream, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), iosAppDataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(iosAppDataStreamId, nameof(iosAppDataStreamId)))
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
        /// The <c>IosAppDataStream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string IosAppDataStreamId { get; }

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
                case ResourceNameType.PropertyIosAppDataStream: return s_propertyIosAppDataStream.Expand(PropertyId, IosAppDataStreamId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IosAppDataStreamName);

        /// <inheritdoc/>
        public bool Equals(IosAppDataStreamName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(IosAppDataStreamName a, IosAppDataStreamName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(IosAppDataStreamName a, IosAppDataStreamName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>WebDataStream</c> resource.</summary>
    public sealed partial class WebDataStreamName : gax::IResourceName, sys::IEquatable<WebDataStreamName>
    {
        /// <summary>The possible contents of <see cref="WebDataStreamName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>properties/{property}/webDataStreams/{web_data_stream}</c>.
            /// </summary>
            PropertyWebDataStream = 1,
        }

        private static gax::PathTemplate s_propertyWebDataStream = new gax::PathTemplate("properties/{property}/webDataStreams/{web_data_stream}");

        /// <summary>Creates a <see cref="WebDataStreamName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WebDataStreamName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WebDataStreamName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WebDataStreamName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WebDataStreamName"/> with the pattern
        /// <c>properties/{property}/webDataStreams/{web_data_stream}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webDataStreamId">The <c>WebDataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WebDataStreamName"/> constructed from the provided ids.</returns>
        public static WebDataStreamName FromPropertyWebDataStream(string propertyId, string webDataStreamId) =>
            new WebDataStreamName(ResourceNameType.PropertyWebDataStream, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), webDataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(webDataStreamId, nameof(webDataStreamId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WebDataStreamName"/> with pattern
        /// <c>properties/{property}/webDataStreams/{web_data_stream}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webDataStreamId">The <c>WebDataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WebDataStreamName"/> with pattern
        /// <c>properties/{property}/webDataStreams/{web_data_stream}</c>.
        /// </returns>
        public static string Format(string propertyId, string webDataStreamId) =>
            FormatPropertyWebDataStream(propertyId, webDataStreamId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WebDataStreamName"/> with pattern
        /// <c>properties/{property}/webDataStreams/{web_data_stream}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webDataStreamId">The <c>WebDataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WebDataStreamName"/> with pattern
        /// <c>properties/{property}/webDataStreams/{web_data_stream}</c>.
        /// </returns>
        public static string FormatPropertyWebDataStream(string propertyId, string webDataStreamId) =>
            s_propertyWebDataStream.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(webDataStreamId, nameof(webDataStreamId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WebDataStreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/webDataStreams/{web_data_stream}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="webDataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WebDataStreamName"/> if successful.</returns>
        public static WebDataStreamName Parse(string webDataStreamName) => Parse(webDataStreamName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WebDataStreamName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/webDataStreams/{web_data_stream}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="webDataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WebDataStreamName"/> if successful.</returns>
        public static WebDataStreamName Parse(string webDataStreamName, bool allowUnparsed) =>
            TryParse(webDataStreamName, allowUnparsed, out WebDataStreamName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WebDataStreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/webDataStreams/{web_data_stream}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="webDataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WebDataStreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string webDataStreamName, out WebDataStreamName result) =>
            TryParse(webDataStreamName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WebDataStreamName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/webDataStreams/{web_data_stream}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="webDataStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WebDataStreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string webDataStreamName, bool allowUnparsed, out WebDataStreamName result)
        {
            gax::GaxPreconditions.CheckNotNull(webDataStreamName, nameof(webDataStreamName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyWebDataStream.TryParseName(webDataStreamName, out resourceName))
            {
                result = FromPropertyWebDataStream(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(webDataStreamName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WebDataStreamName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string propertyId = null, string webDataStreamId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PropertyId = propertyId;
            WebDataStreamId = webDataStreamId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WebDataStreamName"/> class from the component parts of pattern
        /// <c>properties/{property}/webDataStreams/{web_data_stream}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webDataStreamId">The <c>WebDataStream</c> ID. Must not be <c>null</c> or empty.</param>
        public WebDataStreamName(string propertyId, string webDataStreamId) : this(ResourceNameType.PropertyWebDataStream, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), webDataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(webDataStreamId, nameof(webDataStreamId)))
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

        /// <summary>
        /// The <c>WebDataStream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string WebDataStreamId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyWebDataStream: return s_propertyWebDataStream.Expand(PropertyId, WebDataStreamId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WebDataStreamName);

        /// <inheritdoc/>
        public bool Equals(WebDataStreamName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(WebDataStreamName a, WebDataStreamName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(WebDataStreamName a, WebDataStreamName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>UserLink</c> resource.</summary>
    public sealed partial class UserLinkName : gax::IResourceName, sys::IEquatable<UserLinkName>
    {
        /// <summary>The possible contents of <see cref="UserLinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/userLinks/{user_link}</c>.</summary>
            AccountUserLink = 1,

            /// <summary>A resource name with pattern <c>properties/{property}/userLinks/{user_link}</c>.</summary>
            PropertyUserLink = 2,
        }

        private static gax::PathTemplate s_accountUserLink = new gax::PathTemplate("accounts/{account}/userLinks/{user_link}");

        private static gax::PathTemplate s_propertyUserLink = new gax::PathTemplate("properties/{property}/userLinks/{user_link}");

        /// <summary>Creates a <see cref="UserLinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserLinkName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static UserLinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserLinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UserLinkName"/> with the pattern <c>accounts/{account}/userLinks/{user_link}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userLinkId">The <c>UserLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UserLinkName"/> constructed from the provided ids.</returns>
        public static UserLinkName FromAccountUserLink(string accountId, string userLinkId) =>
            new UserLinkName(ResourceNameType.AccountUserLink, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), userLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(userLinkId, nameof(userLinkId)));

        /// <summary>
        /// Creates a <see cref="UserLinkName"/> with the pattern <c>properties/{property}/userLinks/{user_link}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userLinkId">The <c>UserLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UserLinkName"/> constructed from the provided ids.</returns>
        public static UserLinkName FromPropertyUserLink(string propertyId, string userLinkId) =>
            new UserLinkName(ResourceNameType.PropertyUserLink, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), userLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(userLinkId, nameof(userLinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserLinkName"/> with pattern
        /// <c>accounts/{account}/userLinks/{user_link}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userLinkId">The <c>UserLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserLinkName"/> with pattern
        /// <c>accounts/{account}/userLinks/{user_link}</c>.
        /// </returns>
        public static string Format(string accountId, string userLinkId) => FormatAccountUserLink(accountId, userLinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserLinkName"/> with pattern
        /// <c>accounts/{account}/userLinks/{user_link}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userLinkId">The <c>UserLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserLinkName"/> with pattern
        /// <c>accounts/{account}/userLinks/{user_link}</c>.
        /// </returns>
        public static string FormatAccountUserLink(string accountId, string userLinkId) =>
            s_accountUserLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userLinkId, nameof(userLinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserLinkName"/> with pattern
        /// <c>properties/{property}/userLinks/{user_link}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userLinkId">The <c>UserLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserLinkName"/> with pattern
        /// <c>properties/{property}/userLinks/{user_link}</c>.
        /// </returns>
        public static string FormatPropertyUserLink(string propertyId, string userLinkId) =>
            s_propertyUserLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userLinkId, nameof(userLinkId)));

        /// <summary>Parses the given resource name string into a new <see cref="UserLinkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/userLinks/{user_link}</c></description></item>
        /// <item><description><c>properties/{property}/userLinks/{user_link}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="userLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserLinkName"/> if successful.</returns>
        public static UserLinkName Parse(string userLinkName) => Parse(userLinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserLinkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/userLinks/{user_link}</c></description></item>
        /// <item><description><c>properties/{property}/userLinks/{user_link}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserLinkName"/> if successful.</returns>
        public static UserLinkName Parse(string userLinkName, bool allowUnparsed) =>
            TryParse(userLinkName, allowUnparsed, out UserLinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/userLinks/{user_link}</c></description></item>
        /// <item><description><c>properties/{property}/userLinks/{user_link}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="userLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userLinkName, out UserLinkName result) => TryParse(userLinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserLinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/userLinks/{user_link}</c></description></item>
        /// <item><description><c>properties/{property}/userLinks/{user_link}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userLinkName, bool allowUnparsed, out UserLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(userLinkName, nameof(userLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_accountUserLink.TryParseName(userLinkName, out resourceName))
            {
                result = FromAccountUserLink(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_propertyUserLink.TryParseName(userLinkName, out resourceName))
            {
                result = FromPropertyUserLink(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userLinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UserLinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string propertyId = null, string userLinkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            PropertyId = propertyId;
            UserLinkId = userLinkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserLinkName"/> class from the component parts of pattern
        /// <c>accounts/{account}/userLinks/{user_link}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userLinkId">The <c>UserLink</c> ID. Must not be <c>null</c> or empty.</param>
        public UserLinkName(string accountId, string userLinkId) : this(ResourceNameType.AccountUserLink, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), userLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(userLinkId, nameof(userLinkId)))
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
        /// The <c>Account</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string AccountId { get; }

        /// <summary>
        /// The <c>Property</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>
        /// The <c>UserLink</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string UserLinkId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountUserLink: return s_accountUserLink.Expand(AccountId, UserLinkId);
                case ResourceNameType.PropertyUserLink: return s_propertyUserLink.Expand(PropertyId, UserLinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserLinkName);

        /// <inheritdoc/>
        public bool Equals(UserLinkName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(UserLinkName a, UserLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(UserLinkName a, UserLinkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EnhancedMeasurementSettings</c> resource.</summary>
    public sealed partial class EnhancedMeasurementSettingsName : gax::IResourceName, sys::IEquatable<EnhancedMeasurementSettingsName>
    {
        /// <summary>The possible contents of <see cref="EnhancedMeasurementSettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>properties/{property}/webDataStreams/{web_data_stream}/enhancedMeasurementSettings</c>.
            /// </summary>
            PropertyWebDataStream = 1,
        }

        private static gax::PathTemplate s_propertyWebDataStream = new gax::PathTemplate("properties/{property}/webDataStreams/{web_data_stream}/enhancedMeasurementSettings");

        /// <summary>
        /// Creates a <see cref="EnhancedMeasurementSettingsName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EnhancedMeasurementSettingsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EnhancedMeasurementSettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EnhancedMeasurementSettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EnhancedMeasurementSettingsName"/> with the pattern
        /// <c>properties/{property}/webDataStreams/{web_data_stream}/enhancedMeasurementSettings</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webDataStreamId">The <c>WebDataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="EnhancedMeasurementSettingsName"/> constructed from the provided ids.
        /// </returns>
        public static EnhancedMeasurementSettingsName FromPropertyWebDataStream(string propertyId, string webDataStreamId) =>
            new EnhancedMeasurementSettingsName(ResourceNameType.PropertyWebDataStream, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), webDataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(webDataStreamId, nameof(webDataStreamId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnhancedMeasurementSettingsName"/> with
        /// pattern <c>properties/{property}/webDataStreams/{web_data_stream}/enhancedMeasurementSettings</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webDataStreamId">The <c>WebDataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnhancedMeasurementSettingsName"/> with pattern
        /// <c>properties/{property}/webDataStreams/{web_data_stream}/enhancedMeasurementSettings</c>.
        /// </returns>
        public static string Format(string propertyId, string webDataStreamId) =>
            FormatPropertyWebDataStream(propertyId, webDataStreamId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnhancedMeasurementSettingsName"/> with
        /// pattern <c>properties/{property}/webDataStreams/{web_data_stream}/enhancedMeasurementSettings</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webDataStreamId">The <c>WebDataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnhancedMeasurementSettingsName"/> with pattern
        /// <c>properties/{property}/webDataStreams/{web_data_stream}/enhancedMeasurementSettings</c>.
        /// </returns>
        public static string FormatPropertyWebDataStream(string propertyId, string webDataStreamId) =>
            s_propertyWebDataStream.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(webDataStreamId, nameof(webDataStreamId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EnhancedMeasurementSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/webDataStreams/{web_data_stream}/enhancedMeasurementSettings</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="enhancedMeasurementSettingsName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="EnhancedMeasurementSettingsName"/> if successful.</returns>
        public static EnhancedMeasurementSettingsName Parse(string enhancedMeasurementSettingsName) =>
            Parse(enhancedMeasurementSettingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EnhancedMeasurementSettingsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/webDataStreams/{web_data_stream}/enhancedMeasurementSettings</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="enhancedMeasurementSettingsName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EnhancedMeasurementSettingsName"/> if successful.</returns>
        public static EnhancedMeasurementSettingsName Parse(string enhancedMeasurementSettingsName, bool allowUnparsed) =>
            TryParse(enhancedMeasurementSettingsName, allowUnparsed, out EnhancedMeasurementSettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnhancedMeasurementSettingsName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/webDataStreams/{web_data_stream}/enhancedMeasurementSettings</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="enhancedMeasurementSettingsName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnhancedMeasurementSettingsName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string enhancedMeasurementSettingsName, out EnhancedMeasurementSettingsName result) =>
            TryParse(enhancedMeasurementSettingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnhancedMeasurementSettingsName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/webDataStreams/{web_data_stream}/enhancedMeasurementSettings</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="enhancedMeasurementSettingsName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnhancedMeasurementSettingsName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string enhancedMeasurementSettingsName, bool allowUnparsed, out EnhancedMeasurementSettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(enhancedMeasurementSettingsName, nameof(enhancedMeasurementSettingsName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyWebDataStream.TryParseName(enhancedMeasurementSettingsName, out resourceName))
            {
                result = FromPropertyWebDataStream(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(enhancedMeasurementSettingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EnhancedMeasurementSettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string propertyId = null, string webDataStreamId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PropertyId = propertyId;
            WebDataStreamId = webDataStreamId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EnhancedMeasurementSettingsName"/> class from the component parts
        /// of pattern <c>properties/{property}/webDataStreams/{web_data_stream}/enhancedMeasurementSettings</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webDataStreamId">The <c>WebDataStream</c> ID. Must not be <c>null</c> or empty.</param>
        public EnhancedMeasurementSettingsName(string propertyId, string webDataStreamId) : this(ResourceNameType.PropertyWebDataStream, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), webDataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(webDataStreamId, nameof(webDataStreamId)))
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

        /// <summary>
        /// The <c>WebDataStream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string WebDataStreamId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyWebDataStream: return s_propertyWebDataStream.Expand(PropertyId, WebDataStreamId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EnhancedMeasurementSettingsName);

        /// <inheritdoc/>
        public bool Equals(EnhancedMeasurementSettingsName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(EnhancedMeasurementSettingsName a, EnhancedMeasurementSettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(EnhancedMeasurementSettingsName a, EnhancedMeasurementSettingsName b) => !(a == b);
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

        /// <inheritdoc/>
        public static bool operator ==(FirebaseLinkName a, FirebaseLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(FirebaseLinkName a, FirebaseLinkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>GlobalSiteTag</c> resource.</summary>
    public sealed partial class GlobalSiteTagName : gax::IResourceName, sys::IEquatable<GlobalSiteTagName>
    {
        /// <summary>The possible contents of <see cref="GlobalSiteTagName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>properties/{property}/globalSiteTag</c>.</summary>
            Property = 1,
        }

        private static gax::PathTemplate s_property = new gax::PathTemplate("properties/{property}/globalSiteTag");

        /// <summary>Creates a <see cref="GlobalSiteTagName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GlobalSiteTagName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GlobalSiteTagName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GlobalSiteTagName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GlobalSiteTagName"/> with the pattern <c>properties/{property}/globalSiteTag</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GlobalSiteTagName"/> constructed from the provided ids.</returns>
        public static GlobalSiteTagName FromProperty(string propertyId) =>
            new GlobalSiteTagName(ResourceNameType.Property, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GlobalSiteTagName"/> with pattern
        /// <c>properties/{property}/globalSiteTag</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GlobalSiteTagName"/> with pattern
        /// <c>properties/{property}/globalSiteTag</c>.
        /// </returns>
        public static string Format(string propertyId) => FormatProperty(propertyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GlobalSiteTagName"/> with pattern
        /// <c>properties/{property}/globalSiteTag</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GlobalSiteTagName"/> with pattern
        /// <c>properties/{property}/globalSiteTag</c>.
        /// </returns>
        public static string FormatProperty(string propertyId) =>
            s_property.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GlobalSiteTagName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/globalSiteTag</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="globalSiteTagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GlobalSiteTagName"/> if successful.</returns>
        public static GlobalSiteTagName Parse(string globalSiteTagName) => Parse(globalSiteTagName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GlobalSiteTagName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/globalSiteTag</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="globalSiteTagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GlobalSiteTagName"/> if successful.</returns>
        public static GlobalSiteTagName Parse(string globalSiteTagName, bool allowUnparsed) =>
            TryParse(globalSiteTagName, allowUnparsed, out GlobalSiteTagName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GlobalSiteTagName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/globalSiteTag</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="globalSiteTagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GlobalSiteTagName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string globalSiteTagName, out GlobalSiteTagName result) =>
            TryParse(globalSiteTagName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GlobalSiteTagName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/globalSiteTag</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="globalSiteTagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GlobalSiteTagName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string globalSiteTagName, bool allowUnparsed, out GlobalSiteTagName result)
        {
            gax::GaxPreconditions.CheckNotNull(globalSiteTagName, nameof(globalSiteTagName));
            gax::TemplatedResourceName resourceName;
            if (s_property.TryParseName(globalSiteTagName, out resourceName))
            {
                result = FromProperty(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(globalSiteTagName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GlobalSiteTagName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GlobalSiteTagName"/> class from the component parts of pattern
        /// <c>properties/{property}/globalSiteTag</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        public GlobalSiteTagName(string propertyId) : this(ResourceNameType.Property, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)))
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
        public override bool Equals(object obj) => Equals(obj as GlobalSiteTagName);

        /// <inheritdoc/>
        public bool Equals(GlobalSiteTagName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(GlobalSiteTagName a, GlobalSiteTagName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(GlobalSiteTagName a, GlobalSiteTagName b) => !(a == b);
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

        /// <inheritdoc/>
        public static bool operator ==(GoogleAdsLinkName a, GoogleAdsLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public static bool operator ==(DataSharingSettingsName a, DataSharingSettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public static bool operator ==(AccountSummaryName a, AccountSummaryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AccountSummaryName a, AccountSummaryName b) => !(a == b);
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
    }

    public partial class AndroidAppDataStream
    {
        /// <summary>
        /// <see cref="gaav::AndroidAppDataStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AndroidAppDataStreamName AndroidAppDataStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AndroidAppDataStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class IosAppDataStream
    {
        /// <summary>
        /// <see cref="gaav::IosAppDataStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::IosAppDataStreamName IosAppDataStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::IosAppDataStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class WebDataStream
    {
        /// <summary>
        /// <see cref="gaav::WebDataStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::WebDataStreamName WebDataStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::WebDataStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UserLink
    {
        /// <summary>
        /// <see cref="gaav::UserLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::UserLinkName UserLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::UserLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EnhancedMeasurementSettings
    {
        /// <summary>
        /// <see cref="gaav::EnhancedMeasurementSettingsName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::EnhancedMeasurementSettingsName EnhancedMeasurementSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::EnhancedMeasurementSettingsName.Parse(Name, allowUnparsed: true);
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

    public partial class GlobalSiteTag
    {
        /// <summary>
        /// <see cref="gaav::GlobalSiteTagName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::GlobalSiteTagName GlobalSiteTagName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::GlobalSiteTagName.Parse(Name, allowUnparsed: true);
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
}

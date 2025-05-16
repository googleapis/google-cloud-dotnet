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
using gsmav = Google.Shopping.Merchant.Accounts.V1Beta;
using sys = System;

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Resource name for the <c>OmnichannelSetting</c> resource.</summary>
    public sealed partial class OmnichannelSettingName : gax::IResourceName, sys::IEquatable<OmnichannelSettingName>
    {
        /// <summary>The possible contents of <see cref="OmnichannelSettingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>accounts/{account}/omnichannelSettings/{omnichannel_setting}</c>.
            /// </summary>
            AccountOmnichannelSetting = 1,
        }

        private static gax::PathTemplate s_accountOmnichannelSetting = new gax::PathTemplate("accounts/{account}/omnichannelSettings/{omnichannel_setting}");

        /// <summary>Creates a <see cref="OmnichannelSettingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OmnichannelSettingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OmnichannelSettingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OmnichannelSettingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OmnichannelSettingName"/> with the pattern
        /// <c>accounts/{account}/omnichannelSettings/{omnichannel_setting}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="omnichannelSettingId">
        /// The <c>OmnichannelSetting</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="OmnichannelSettingName"/> constructed from the provided ids.</returns>
        public static OmnichannelSettingName FromAccountOmnichannelSetting(string accountId, string omnichannelSettingId) =>
            new OmnichannelSettingName(ResourceNameType.AccountOmnichannelSetting, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), omnichannelSettingId: gax::GaxPreconditions.CheckNotNullOrEmpty(omnichannelSettingId, nameof(omnichannelSettingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OmnichannelSettingName"/> with pattern
        /// <c>accounts/{account}/omnichannelSettings/{omnichannel_setting}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="omnichannelSettingId">
        /// The <c>OmnichannelSetting</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="OmnichannelSettingName"/> with pattern
        /// <c>accounts/{account}/omnichannelSettings/{omnichannel_setting}</c>.
        /// </returns>
        public static string Format(string accountId, string omnichannelSettingId) =>
            FormatAccountOmnichannelSetting(accountId, omnichannelSettingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OmnichannelSettingName"/> with pattern
        /// <c>accounts/{account}/omnichannelSettings/{omnichannel_setting}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="omnichannelSettingId">
        /// The <c>OmnichannelSetting</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="OmnichannelSettingName"/> with pattern
        /// <c>accounts/{account}/omnichannelSettings/{omnichannel_setting}</c>.
        /// </returns>
        public static string FormatAccountOmnichannelSetting(string accountId, string omnichannelSettingId) =>
            s_accountOmnichannelSetting.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(omnichannelSettingId, nameof(omnichannelSettingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OmnichannelSettingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/omnichannelSettings/{omnichannel_setting}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="omnichannelSettingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OmnichannelSettingName"/> if successful.</returns>
        public static OmnichannelSettingName Parse(string omnichannelSettingName) => Parse(omnichannelSettingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OmnichannelSettingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/omnichannelSettings/{omnichannel_setting}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="omnichannelSettingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OmnichannelSettingName"/> if successful.</returns>
        public static OmnichannelSettingName Parse(string omnichannelSettingName, bool allowUnparsed) =>
            TryParse(omnichannelSettingName, allowUnparsed, out OmnichannelSettingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OmnichannelSettingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/omnichannelSettings/{omnichannel_setting}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="omnichannelSettingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OmnichannelSettingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string omnichannelSettingName, out OmnichannelSettingName result) =>
            TryParse(omnichannelSettingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OmnichannelSettingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/omnichannelSettings/{omnichannel_setting}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="omnichannelSettingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OmnichannelSettingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string omnichannelSettingName, bool allowUnparsed, out OmnichannelSettingName result)
        {
            gax::GaxPreconditions.CheckNotNull(omnichannelSettingName, nameof(omnichannelSettingName));
            gax::TemplatedResourceName resourceName;
            if (s_accountOmnichannelSetting.TryParseName(omnichannelSettingName, out resourceName))
            {
                result = FromAccountOmnichannelSetting(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(omnichannelSettingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OmnichannelSettingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string omnichannelSettingId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            OmnichannelSettingId = omnichannelSettingId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OmnichannelSettingName"/> class from the component parts of
        /// pattern <c>accounts/{account}/omnichannelSettings/{omnichannel_setting}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="omnichannelSettingId">
        /// The <c>OmnichannelSetting</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public OmnichannelSettingName(string accountId, string omnichannelSettingId) : this(ResourceNameType.AccountOmnichannelSetting, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), omnichannelSettingId: gax::GaxPreconditions.CheckNotNullOrEmpty(omnichannelSettingId, nameof(omnichannelSettingId)))
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
        /// The <c>OmnichannelSetting</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string OmnichannelSettingId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountOmnichannelSetting: return s_accountOmnichannelSetting.Expand(AccountId, OmnichannelSettingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OmnichannelSettingName);

        /// <inheritdoc/>
        public bool Equals(OmnichannelSettingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OmnichannelSettingName a, OmnichannelSettingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OmnichannelSettingName a, OmnichannelSettingName b) => !(a == b);
    }

    public partial class OmnichannelSetting
    {
        /// <summary>
        /// <see cref="gsmav::OmnichannelSettingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::OmnichannelSettingName OmnichannelSettingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::OmnichannelSettingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetOmnichannelSettingRequest
    {
        /// <summary>
        /// <see cref="gsmav::OmnichannelSettingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::OmnichannelSettingName OmnichannelSettingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::OmnichannelSettingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListOmnichannelSettingsRequest
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

    public partial class CreateOmnichannelSettingRequest
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

    public partial class RequestInventoryVerificationRequest
    {
        /// <summary>
        /// <see cref="gsmav::OmnichannelSettingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::OmnichannelSettingName OmnichannelSettingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::OmnichannelSettingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

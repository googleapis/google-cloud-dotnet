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
using gsmav = Google.Shopping.Merchant.Accounts.V1;
using sys = System;

namespace Google.Shopping.Merchant.Accounts.V1
{
    /// <summary>Resource name for the <c>Region</c> resource.</summary>
    public sealed partial class RegionName : gax::IResourceName, sys::IEquatable<RegionName>
    {
        /// <summary>The possible contents of <see cref="RegionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/regions/{region}</c>.</summary>
            AccountRegion = 1,
        }

        private static gax::PathTemplate s_accountRegion = new gax::PathTemplate("accounts/{account}/regions/{region}");

        /// <summary>Creates a <see cref="RegionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RegionName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RegionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RegionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RegionName"/> with the pattern <c>accounts/{account}/regions/{region}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RegionName"/> constructed from the provided ids.</returns>
        public static RegionName FromAccountRegion(string accountId, string regionId) =>
            new RegionName(ResourceNameType.AccountRegion, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegionName"/> with pattern
        /// <c>accounts/{account}/regions/{region}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegionName"/> with pattern
        /// <c>accounts/{account}/regions/{region}</c>.
        /// </returns>
        public static string Format(string accountId, string regionId) => FormatAccountRegion(accountId, regionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegionName"/> with pattern
        /// <c>accounts/{account}/regions/{region}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegionName"/> with pattern
        /// <c>accounts/{account}/regions/{region}</c>.
        /// </returns>
        public static string FormatAccountRegion(string accountId, string regionId) =>
            s_accountRegion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)));

        /// <summary>Parses the given resource name string into a new <see cref="RegionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/regions/{region}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="regionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RegionName"/> if successful.</returns>
        public static RegionName Parse(string regionName) => Parse(regionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RegionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/regions/{region}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="regionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RegionName"/> if successful.</returns>
        public static RegionName Parse(string regionName, bool allowUnparsed) =>
            TryParse(regionName, allowUnparsed, out RegionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/regions/{region}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="regionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string regionName, out RegionName result) => TryParse(regionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/regions/{region}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="regionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string regionName, bool allowUnparsed, out RegionName result)
        {
            gax::GaxPreconditions.CheckNotNull(regionName, nameof(regionName));
            gax::TemplatedResourceName resourceName;
            if (s_accountRegion.TryParseName(regionName, out resourceName))
            {
                result = FromAccountRegion(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(regionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RegionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string regionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            RegionId = regionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RegionName"/> class from the component parts of pattern
        /// <c>accounts/{account}/regions/{region}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        public RegionName(string accountId, string regionId) : this(ResourceNameType.AccountRegion, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)))
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
        /// The <c>Region</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountRegion: return s_accountRegion.Expand(AccountId, RegionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RegionName);

        /// <inheritdoc/>
        public bool Equals(RegionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RegionName a, RegionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RegionName a, RegionName b) => !(a == b);
    }

    public partial class GetRegionRequest
    {
        /// <summary>
        /// <see cref="gsmav::RegionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::RegionName RegionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::RegionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRegionRequest
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

    public partial class BatchCreateRegionsRequest
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

    public partial class BatchUpdateRegionsRequest
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

    public partial class DeleteRegionRequest
    {
        /// <summary>
        /// <see cref="gsmav::RegionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::RegionName RegionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::RegionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeleteRegionsRequest
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

    public partial class ListRegionsRequest
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

    public partial class Region
    {
        /// <summary>
        /// <see cref="gsmav::RegionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::RegionName RegionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::RegionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

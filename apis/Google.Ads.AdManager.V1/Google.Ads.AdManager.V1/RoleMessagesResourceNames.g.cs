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
using gaav = Google.Ads.AdManager.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Resource name for the <c>Role</c> resource.</summary>
    public sealed partial class RoleName : gax::IResourceName, sys::IEquatable<RoleName>
    {
        /// <summary>The possible contents of <see cref="RoleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>networks/{network_code}/roles/{role}</c>.</summary>
            NetworkCodeRole = 1,
        }

        private static gax::PathTemplate s_networkCodeRole = new gax::PathTemplate("networks/{network_code}/roles/{role}");

        /// <summary>Creates a <see cref="RoleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RoleName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RoleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RoleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RoleName"/> with the pattern <c>networks/{network_code}/roles/{role}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RoleName"/> constructed from the provided ids.</returns>
        public static RoleName FromNetworkCodeRole(string networkCodeId, string roleId) =>
            new RoleName(ResourceNameType.NetworkCodeRole, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), roleId: gax::GaxPreconditions.CheckNotNullOrEmpty(roleId, nameof(roleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RoleName"/> with pattern
        /// <c>networks/{network_code}/roles/{role}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RoleName"/> with pattern
        /// <c>networks/{network_code}/roles/{role}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string roleId) => FormatNetworkCodeRole(networkCodeId, roleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RoleName"/> with pattern
        /// <c>networks/{network_code}/roles/{role}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RoleName"/> with pattern
        /// <c>networks/{network_code}/roles/{role}</c>.
        /// </returns>
        public static string FormatNetworkCodeRole(string networkCodeId, string roleId) =>
            s_networkCodeRole.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(roleId, nameof(roleId)));

        /// <summary>Parses the given resource name string into a new <see cref="RoleName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/roles/{role}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="roleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RoleName"/> if successful.</returns>
        public static RoleName Parse(string roleName) => Parse(roleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RoleName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/roles/{role}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="roleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RoleName"/> if successful.</returns>
        public static RoleName Parse(string roleName, bool allowUnparsed) =>
            TryParse(roleName, allowUnparsed, out RoleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="RoleName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/roles/{role}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="roleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RoleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string roleName, out RoleName result) => TryParse(roleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RoleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/roles/{role}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="roleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RoleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string roleName, bool allowUnparsed, out RoleName result)
        {
            gax::GaxPreconditions.CheckNotNull(roleName, nameof(roleName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeRole.TryParseName(roleName, out resourceName))
            {
                result = FromNetworkCodeRole(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(roleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RoleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkCodeId = null, string roleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkCodeId = networkCodeId;
            RoleId = roleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RoleName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/roles/{role}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        public RoleName(string networkCodeId, string roleId) : this(ResourceNameType.NetworkCodeRole, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), roleId: gax::GaxPreconditions.CheckNotNullOrEmpty(roleId, nameof(roleId)))
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
        /// The <c>Role</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RoleId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeRole: return s_networkCodeRole.Expand(NetworkCodeId, RoleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RoleName);

        /// <inheritdoc/>
        public bool Equals(RoleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RoleName a, RoleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RoleName a, RoleName b) => !(a == b);
    }

    public partial class Role
    {
        /// <summary>
        /// <see cref="gaav::RoleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::RoleName RoleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::RoleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

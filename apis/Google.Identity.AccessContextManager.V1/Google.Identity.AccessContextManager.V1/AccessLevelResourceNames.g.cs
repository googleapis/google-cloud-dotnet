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
using giav = Google.Identity.AccessContextManager.V1;
using sys = System;

namespace Google.Identity.AccessContextManager.V1
{
    /// <summary>Resource name for the <c>AccessLevel</c> resource.</summary>
    public sealed partial class AccessLevelName : gax::IResourceName, sys::IEquatable<AccessLevelName>
    {
        /// <summary>The possible contents of <see cref="AccessLevelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>accessPolicies/{access_policy}/accessLevels/{access_level}</c>.
            /// </summary>
            AccessPolicyAccessLevel = 1,
        }

        private static gax::PathTemplate s_accessPolicyAccessLevel = new gax::PathTemplate("accessPolicies/{access_policy}/accessLevels/{access_level}");

        /// <summary>Creates a <see cref="AccessLevelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccessLevelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccessLevelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccessLevelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccessLevelName"/> with the pattern
        /// <c>accessPolicies/{access_policy}/accessLevels/{access_level}</c>.
        /// </summary>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessLevelId">The <c>AccessLevel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccessLevelName"/> constructed from the provided ids.</returns>
        public static AccessLevelName FromAccessPolicyAccessLevel(string accessPolicyId, string accessLevelId) =>
            new AccessLevelName(ResourceNameType.AccessPolicyAccessLevel, accessPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)), accessLevelId: gax::GaxPreconditions.CheckNotNullOrEmpty(accessLevelId, nameof(accessLevelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessLevelName"/> with pattern
        /// <c>accessPolicies/{access_policy}/accessLevels/{access_level}</c>.
        /// </summary>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessLevelId">The <c>AccessLevel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessLevelName"/> with pattern
        /// <c>accessPolicies/{access_policy}/accessLevels/{access_level}</c>.
        /// </returns>
        public static string Format(string accessPolicyId, string accessLevelId) =>
            FormatAccessPolicyAccessLevel(accessPolicyId, accessLevelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessLevelName"/> with pattern
        /// <c>accessPolicies/{access_policy}/accessLevels/{access_level}</c>.
        /// </summary>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessLevelId">The <c>AccessLevel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessLevelName"/> with pattern
        /// <c>accessPolicies/{access_policy}/accessLevels/{access_level}</c>.
        /// </returns>
        public static string FormatAccessPolicyAccessLevel(string accessPolicyId, string accessLevelId) =>
            s_accessPolicyAccessLevel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(accessLevelId, nameof(accessLevelId)));

        /// <summary>Parses the given resource name string into a new <see cref="AccessLevelName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accessPolicies/{access_policy}/accessLevels/{access_level}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accessLevelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccessLevelName"/> if successful.</returns>
        public static AccessLevelName Parse(string accessLevelName) => Parse(accessLevelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccessLevelName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accessPolicies/{access_policy}/accessLevels/{access_level}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessLevelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccessLevelName"/> if successful.</returns>
        public static AccessLevelName Parse(string accessLevelName, bool allowUnparsed) =>
            TryParse(accessLevelName, allowUnparsed, out AccessLevelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessLevelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accessPolicies/{access_policy}/accessLevels/{access_level}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accessLevelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessLevelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessLevelName, out AccessLevelName result) =>
            TryParse(accessLevelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessLevelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accessPolicies/{access_policy}/accessLevels/{access_level}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessLevelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessLevelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessLevelName, bool allowUnparsed, out AccessLevelName result)
        {
            gax::GaxPreconditions.CheckNotNull(accessLevelName, nameof(accessLevelName));
            gax::TemplatedResourceName resourceName;
            if (s_accessPolicyAccessLevel.TryParseName(accessLevelName, out resourceName))
            {
                result = FromAccessPolicyAccessLevel(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accessLevelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccessLevelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accessLevelId = null, string accessPolicyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccessLevelId = accessLevelId;
            AccessPolicyId = accessPolicyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccessLevelName"/> class from the component parts of pattern
        /// <c>accessPolicies/{access_policy}/accessLevels/{access_level}</c>
        /// </summary>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessLevelId">The <c>AccessLevel</c> ID. Must not be <c>null</c> or empty.</param>
        public AccessLevelName(string accessPolicyId, string accessLevelId) : this(ResourceNameType.AccessPolicyAccessLevel, accessPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)), accessLevelId: gax::GaxPreconditions.CheckNotNullOrEmpty(accessLevelId, nameof(accessLevelId)))
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
        /// The <c>AccessLevel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AccessLevelId { get; }

        /// <summary>
        /// The <c>AccessPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AccessPolicyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccessPolicyAccessLevel: return s_accessPolicyAccessLevel.Expand(AccessPolicyId, AccessLevelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccessLevelName);

        /// <inheritdoc/>
        public bool Equals(AccessLevelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccessLevelName a, AccessLevelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccessLevelName a, AccessLevelName b) => !(a == b);
    }

    public partial class AccessLevel
    {
        /// <summary>
        /// <see cref="giav::AccessLevelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giav::AccessLevelName AccessLevelName
        {
            get => string.IsNullOrEmpty(Name) ? null : giav::AccessLevelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

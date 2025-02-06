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
using giav = Google.Identity.AccessContextManager.V1;
using sys = System;

namespace Google.Identity.AccessContextManager.V1
{
    /// <summary>Resource name for the <c>AccessPolicy</c> resource.</summary>
    public sealed partial class AccessPolicyName : gax::IResourceName, sys::IEquatable<AccessPolicyName>
    {
        /// <summary>The possible contents of <see cref="AccessPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accessPolicies/{access_policy}</c>.</summary>
            AccessPolicy = 1,
        }

        private static gax::PathTemplate s_accessPolicy = new gax::PathTemplate("accessPolicies/{access_policy}");

        /// <summary>Creates a <see cref="AccessPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccessPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccessPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccessPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccessPolicyName"/> with the pattern <c>accessPolicies/{access_policy}</c>.
        /// </summary>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccessPolicyName"/> constructed from the provided ids.</returns>
        public static AccessPolicyName FromAccessPolicy(string accessPolicyId) =>
            new AccessPolicyName(ResourceNameType.AccessPolicy, accessPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessPolicyName"/> with pattern
        /// <c>accessPolicies/{access_policy}</c>.
        /// </summary>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessPolicyName"/> with pattern
        /// <c>accessPolicies/{access_policy}</c>.
        /// </returns>
        public static string Format(string accessPolicyId) => FormatAccessPolicy(accessPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessPolicyName"/> with pattern
        /// <c>accessPolicies/{access_policy}</c>.
        /// </summary>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessPolicyName"/> with pattern
        /// <c>accessPolicies/{access_policy}</c>.
        /// </returns>
        public static string FormatAccessPolicy(string accessPolicyId) =>
            s_accessPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)));

        /// <summary>Parses the given resource name string into a new <see cref="AccessPolicyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accessPolicies/{access_policy}</c></description></item></list>
        /// </remarks>
        /// <param name="accessPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccessPolicyName"/> if successful.</returns>
        public static AccessPolicyName Parse(string accessPolicyName) => Parse(accessPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccessPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accessPolicies/{access_policy}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccessPolicyName"/> if successful.</returns>
        public static AccessPolicyName Parse(string accessPolicyName, bool allowUnparsed) =>
            TryParse(accessPolicyName, allowUnparsed, out AccessPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accessPolicies/{access_policy}</c></description></item></list>
        /// </remarks>
        /// <param name="accessPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessPolicyName, out AccessPolicyName result) =>
            TryParse(accessPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accessPolicies/{access_policy}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessPolicyName, bool allowUnparsed, out AccessPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(accessPolicyName, nameof(accessPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_accessPolicy.TryParseName(accessPolicyName, out resourceName))
            {
                result = FromAccessPolicy(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accessPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccessPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accessPolicyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccessPolicyId = accessPolicyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccessPolicyName"/> class from the component parts of pattern
        /// <c>accessPolicies/{access_policy}</c>
        /// </summary>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public AccessPolicyName(string accessPolicyId) : this(ResourceNameType.AccessPolicy, accessPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)))
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
                case ResourceNameType.AccessPolicy: return s_accessPolicy.Expand(AccessPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccessPolicyName);

        /// <inheritdoc/>
        public bool Equals(AccessPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccessPolicyName a, AccessPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccessPolicyName a, AccessPolicyName b) => !(a == b);
    }

    public partial class AccessPolicy
    {
        /// <summary>
        /// <see cref="giav::AccessPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giav::AccessPolicyName AccessPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : giav::AccessPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

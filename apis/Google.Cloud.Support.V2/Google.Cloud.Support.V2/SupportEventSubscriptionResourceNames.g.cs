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
using gax = Google.Api.Gax;
using gcsv = Google.Cloud.Support.V2;
using sys = System;

namespace Google.Cloud.Support.V2
{
    /// <summary>Resource name for the <c>SupportEventSubscription</c> resource.</summary>
    public sealed partial class SupportEventSubscriptionName : gax::IResourceName, sys::IEquatable<SupportEventSubscriptionName>
    {
        /// <summary>The possible contents of <see cref="SupportEventSubscriptionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/supportEventSubscriptions/{support_event_subscription}</c>.
            /// </summary>
            OrganizationSupportEventSubscription = 1,
        }

        private static gax::PathTemplate s_organizationSupportEventSubscription = new gax::PathTemplate("organizations/{organization}/supportEventSubscriptions/{support_event_subscription}");

        /// <summary>
        /// Creates a <see cref="SupportEventSubscriptionName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SupportEventSubscriptionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SupportEventSubscriptionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SupportEventSubscriptionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SupportEventSubscriptionName"/> with the pattern
        /// <c>organizations/{organization}/supportEventSubscriptions/{support_event_subscription}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="supportEventSubscriptionId">
        /// The <c>SupportEventSubscription</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="SupportEventSubscriptionName"/> constructed from the provided ids.
        /// </returns>
        public static SupportEventSubscriptionName FromOrganizationSupportEventSubscription(string organizationId, string supportEventSubscriptionId) =>
            new SupportEventSubscriptionName(ResourceNameType.OrganizationSupportEventSubscription, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), supportEventSubscriptionId: gax::GaxPreconditions.CheckNotNullOrEmpty(supportEventSubscriptionId, nameof(supportEventSubscriptionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SupportEventSubscriptionName"/> with
        /// pattern <c>organizations/{organization}/supportEventSubscriptions/{support_event_subscription}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="supportEventSubscriptionId">
        /// The <c>SupportEventSubscription</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SupportEventSubscriptionName"/> with pattern
        /// <c>organizations/{organization}/supportEventSubscriptions/{support_event_subscription}</c>.
        /// </returns>
        public static string Format(string organizationId, string supportEventSubscriptionId) =>
            FormatOrganizationSupportEventSubscription(organizationId, supportEventSubscriptionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SupportEventSubscriptionName"/> with
        /// pattern <c>organizations/{organization}/supportEventSubscriptions/{support_event_subscription}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="supportEventSubscriptionId">
        /// The <c>SupportEventSubscription</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SupportEventSubscriptionName"/> with pattern
        /// <c>organizations/{organization}/supportEventSubscriptions/{support_event_subscription}</c>.
        /// </returns>
        public static string FormatOrganizationSupportEventSubscription(string organizationId, string supportEventSubscriptionId) =>
            s_organizationSupportEventSubscription.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(supportEventSubscriptionId, nameof(supportEventSubscriptionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SupportEventSubscriptionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/supportEventSubscriptions/{support_event_subscription}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="supportEventSubscriptionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="SupportEventSubscriptionName"/> if successful.</returns>
        public static SupportEventSubscriptionName Parse(string supportEventSubscriptionName) =>
            Parse(supportEventSubscriptionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SupportEventSubscriptionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/supportEventSubscriptions/{support_event_subscription}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="supportEventSubscriptionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SupportEventSubscriptionName"/> if successful.</returns>
        public static SupportEventSubscriptionName Parse(string supportEventSubscriptionName, bool allowUnparsed) =>
            TryParse(supportEventSubscriptionName, allowUnparsed, out SupportEventSubscriptionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SupportEventSubscriptionName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/supportEventSubscriptions/{support_event_subscription}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="supportEventSubscriptionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SupportEventSubscriptionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string supportEventSubscriptionName, out SupportEventSubscriptionName result) =>
            TryParse(supportEventSubscriptionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SupportEventSubscriptionName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/supportEventSubscriptions/{support_event_subscription}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="supportEventSubscriptionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SupportEventSubscriptionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string supportEventSubscriptionName, bool allowUnparsed, out SupportEventSubscriptionName result)
        {
            gax::GaxPreconditions.CheckNotNull(supportEventSubscriptionName, nameof(supportEventSubscriptionName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationSupportEventSubscription.TryParseName(supportEventSubscriptionName, out resourceName))
            {
                result = FromOrganizationSupportEventSubscription(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(supportEventSubscriptionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SupportEventSubscriptionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string organizationId = null, string supportEventSubscriptionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            OrganizationId = organizationId;
            SupportEventSubscriptionId = supportEventSubscriptionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SupportEventSubscriptionName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/supportEventSubscriptions/{support_event_subscription}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="supportEventSubscriptionId">
        /// The <c>SupportEventSubscription</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public SupportEventSubscriptionName(string organizationId, string supportEventSubscriptionId) : this(ResourceNameType.OrganizationSupportEventSubscription, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), supportEventSubscriptionId: gax::GaxPreconditions.CheckNotNullOrEmpty(supportEventSubscriptionId, nameof(supportEventSubscriptionId)))
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

        /// <summary>
        /// The <c>SupportEventSubscription</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string SupportEventSubscriptionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationSupportEventSubscription: return s_organizationSupportEventSubscription.Expand(OrganizationId, SupportEventSubscriptionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SupportEventSubscriptionName);

        /// <inheritdoc/>
        public bool Equals(SupportEventSubscriptionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SupportEventSubscriptionName a, SupportEventSubscriptionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SupportEventSubscriptionName a, SupportEventSubscriptionName b) => !(a == b);
    }

    public partial class SupportEventSubscription
    {
        /// <summary>
        /// <see cref="gcsv::SupportEventSubscriptionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcsv::SupportEventSubscriptionName SupportEventSubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SupportEventSubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

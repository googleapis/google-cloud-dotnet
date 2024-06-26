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
using gcgv = Google.Cloud.GdcHardwareManagement.V1Alpha;
using sys = System;

namespace Google.Cloud.GdcHardwareManagement.V1Alpha
{
    /// <summary>Resource name for the <c>Order</c> resource.</summary>
    public sealed partial class OrderName : gax::IResourceName, sys::IEquatable<OrderName>
    {
        /// <summary>The possible contents of <see cref="OrderName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/orders/{order}</c>.
            /// </summary>
            ProjectLocationOrder = 1,
        }

        private static gax::PathTemplate s_projectLocationOrder = new gax::PathTemplate("projects/{project}/locations/{location}/orders/{order}");

        /// <summary>Creates a <see cref="OrderName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrderName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrderName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrderName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrderName"/> with the pattern <c>projects/{project}/locations/{location}/orders/{order}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OrderName"/> constructed from the provided ids.</returns>
        public static OrderName FromProjectLocationOrder(string projectId, string locationId, string orderId) =>
            new OrderName(ResourceNameType.ProjectLocationOrder, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrderName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrderName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string orderId) =>
            FormatProjectLocationOrder(projectId, locationId, orderId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrderName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrderName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}</c>.
        /// </returns>
        public static string FormatProjectLocationOrder(string projectId, string locationId, string orderId) =>
            s_projectLocationOrder.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)));

        /// <summary>Parses the given resource name string into a new <see cref="OrderName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/orders/{order}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrderName"/> if successful.</returns>
        public static OrderName Parse(string orderName) => Parse(orderName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrderName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/orders/{order}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrderName"/> if successful.</returns>
        public static OrderName Parse(string orderName, bool allowUnparsed) =>
            TryParse(orderName, allowUnparsed, out OrderName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrderName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/orders/{order}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orderName, out OrderName result) => TryParse(orderName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrderName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/orders/{order}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orderName, bool allowUnparsed, out OrderName result)
        {
            gax::GaxPreconditions.CheckNotNull(orderName, nameof(orderName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationOrder.TryParseName(orderName, out resourceName))
            {
                result = FromProjectLocationOrder(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(orderName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrderName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string orderId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrderId = orderId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrderName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        public OrderName(string projectId, string locationId, string orderId) : this(ResourceNameType.ProjectLocationOrder, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Order</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OrderId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationOrder: return s_projectLocationOrder.Expand(ProjectId, LocationId, OrderId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrderName);

        /// <inheritdoc/>
        public bool Equals(OrderName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrderName a, OrderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrderName a, OrderName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Site</c> resource.</summary>
    public sealed partial class SiteName : gax::IResourceName, sys::IEquatable<SiteName>
    {
        /// <summary>The possible contents of <see cref="SiteName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/sites/{site}</c>.
            /// </summary>
            ProjectLocationSite = 1,
        }

        private static gax::PathTemplate s_projectLocationSite = new gax::PathTemplate("projects/{project}/locations/{location}/sites/{site}");

        /// <summary>Creates a <see cref="SiteName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SiteName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SiteName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SiteName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SiteName"/> with the pattern <c>projects/{project}/locations/{location}/sites/{site}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="siteId">The <c>Site</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SiteName"/> constructed from the provided ids.</returns>
        public static SiteName FromProjectLocationSite(string projectId, string locationId, string siteId) =>
            new SiteName(ResourceNameType.ProjectLocationSite, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), siteId: gax::GaxPreconditions.CheckNotNullOrEmpty(siteId, nameof(siteId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SiteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sites/{site}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="siteId">The <c>Site</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SiteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sites/{site}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string siteId) =>
            FormatProjectLocationSite(projectId, locationId, siteId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SiteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sites/{site}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="siteId">The <c>Site</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SiteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sites/{site}</c>.
        /// </returns>
        public static string FormatProjectLocationSite(string projectId, string locationId, string siteId) =>
            s_projectLocationSite.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(siteId, nameof(siteId)));

        /// <summary>Parses the given resource name string into a new <see cref="SiteName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sites/{site}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="siteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SiteName"/> if successful.</returns>
        public static SiteName Parse(string siteName) => Parse(siteName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SiteName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sites/{site}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="siteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SiteName"/> if successful.</returns>
        public static SiteName Parse(string siteName, bool allowUnparsed) =>
            TryParse(siteName, allowUnparsed, out SiteName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="SiteName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sites/{site}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="siteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SiteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string siteName, out SiteName result) => TryParse(siteName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SiteName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sites/{site}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="siteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SiteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string siteName, bool allowUnparsed, out SiteName result)
        {
            gax::GaxPreconditions.CheckNotNull(siteName, nameof(siteName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSite.TryParseName(siteName, out resourceName))
            {
                result = FromProjectLocationSite(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(siteName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SiteName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string siteId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SiteId = siteId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SiteName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sites/{site}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="siteId">The <c>Site</c> ID. Must not be <c>null</c> or empty.</param>
        public SiteName(string projectId, string locationId, string siteId) : this(ResourceNameType.ProjectLocationSite, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), siteId: gax::GaxPreconditions.CheckNotNullOrEmpty(siteId, nameof(siteId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Site</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SiteId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSite: return s_projectLocationSite.Expand(ProjectId, LocationId, SiteId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SiteName);

        /// <inheritdoc/>
        public bool Equals(SiteName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SiteName a, SiteName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SiteName a, SiteName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>HardwareGroup</c> resource.</summary>
    public sealed partial class HardwareGroupName : gax::IResourceName, sys::IEquatable<HardwareGroupName>
    {
        /// <summary>The possible contents of <see cref="HardwareGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}</c>.
            /// </summary>
            ProjectLocationOrderHardwareGroup = 1,
        }

        private static gax::PathTemplate s_projectLocationOrderHardwareGroup = new gax::PathTemplate("projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}");

        /// <summary>Creates a <see cref="HardwareGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="HardwareGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static HardwareGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new HardwareGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="HardwareGroupName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hardwareGroupId">The <c>HardwareGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="HardwareGroupName"/> constructed from the provided ids.</returns>
        public static HardwareGroupName FromProjectLocationOrderHardwareGroup(string projectId, string locationId, string orderId, string hardwareGroupId) =>
            new HardwareGroupName(ResourceNameType.ProjectLocationOrderHardwareGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)), hardwareGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(hardwareGroupId, nameof(hardwareGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HardwareGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hardwareGroupId">The <c>HardwareGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HardwareGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string orderId, string hardwareGroupId) =>
            FormatProjectLocationOrderHardwareGroup(projectId, locationId, orderId, hardwareGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HardwareGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hardwareGroupId">The <c>HardwareGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HardwareGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}</c>.
        /// </returns>
        public static string FormatProjectLocationOrderHardwareGroup(string projectId, string locationId, string orderId, string hardwareGroupId) =>
            s_projectLocationOrderHardwareGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(hardwareGroupId, nameof(hardwareGroupId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HardwareGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="hardwareGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HardwareGroupName"/> if successful.</returns>
        public static HardwareGroupName Parse(string hardwareGroupName) => Parse(hardwareGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HardwareGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hardwareGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="HardwareGroupName"/> if successful.</returns>
        public static HardwareGroupName Parse(string hardwareGroupName, bool allowUnparsed) =>
            TryParse(hardwareGroupName, allowUnparsed, out HardwareGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HardwareGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="hardwareGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HardwareGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hardwareGroupName, out HardwareGroupName result) =>
            TryParse(hardwareGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HardwareGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hardwareGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HardwareGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hardwareGroupName, bool allowUnparsed, out HardwareGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(hardwareGroupName, nameof(hardwareGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationOrderHardwareGroup.TryParseName(hardwareGroupName, out resourceName))
            {
                result = FromProjectLocationOrderHardwareGroup(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(hardwareGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private HardwareGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string hardwareGroupId = null, string locationId = null, string orderId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            HardwareGroupId = hardwareGroupId;
            LocationId = locationId;
            OrderId = orderId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="HardwareGroupName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hardwareGroupId">The <c>HardwareGroup</c> ID. Must not be <c>null</c> or empty.</param>
        public HardwareGroupName(string projectId, string locationId, string orderId, string hardwareGroupId) : this(ResourceNameType.ProjectLocationOrderHardwareGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)), hardwareGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(hardwareGroupId, nameof(hardwareGroupId)))
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
        /// The <c>HardwareGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string HardwareGroupId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Order</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OrderId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationOrderHardwareGroup: return s_projectLocationOrderHardwareGroup.Expand(ProjectId, LocationId, OrderId, HardwareGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as HardwareGroupName);

        /// <inheritdoc/>
        public bool Equals(HardwareGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(HardwareGroupName a, HardwareGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(HardwareGroupName a, HardwareGroupName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Hardware</c> resource.</summary>
    public sealed partial class HardwareName : gax::IResourceName, sys::IEquatable<HardwareName>
    {
        /// <summary>The possible contents of <see cref="HardwareName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/hardware/{hardware}</c>.
            /// </summary>
            ProjectLocationHardware = 1,
        }

        private static gax::PathTemplate s_projectLocationHardware = new gax::PathTemplate("projects/{project}/locations/{location}/hardware/{hardware}");

        /// <summary>Creates a <see cref="HardwareName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="HardwareName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static HardwareName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new HardwareName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="HardwareName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/hardware/{hardware}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hardwareId">The <c>Hardware</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="HardwareName"/> constructed from the provided ids.</returns>
        public static HardwareName FromProjectLocationHardware(string projectId, string locationId, string hardwareId) =>
            new HardwareName(ResourceNameType.ProjectLocationHardware, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), hardwareId: gax::GaxPreconditions.CheckNotNullOrEmpty(hardwareId, nameof(hardwareId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HardwareName"/> with pattern
        /// <c>projects/{project}/locations/{location}/hardware/{hardware}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hardwareId">The <c>Hardware</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HardwareName"/> with pattern
        /// <c>projects/{project}/locations/{location}/hardware/{hardware}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string hardwareId) =>
            FormatProjectLocationHardware(projectId, locationId, hardwareId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HardwareName"/> with pattern
        /// <c>projects/{project}/locations/{location}/hardware/{hardware}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hardwareId">The <c>Hardware</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HardwareName"/> with pattern
        /// <c>projects/{project}/locations/{location}/hardware/{hardware}</c>.
        /// </returns>
        public static string FormatProjectLocationHardware(string projectId, string locationId, string hardwareId) =>
            s_projectLocationHardware.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(hardwareId, nameof(hardwareId)));

        /// <summary>Parses the given resource name string into a new <see cref="HardwareName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/hardware/{hardware}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="hardwareName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HardwareName"/> if successful.</returns>
        public static HardwareName Parse(string hardwareName) => Parse(hardwareName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HardwareName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/hardware/{hardware}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hardwareName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="HardwareName"/> if successful.</returns>
        public static HardwareName Parse(string hardwareName, bool allowUnparsed) =>
            TryParse(hardwareName, allowUnparsed, out HardwareName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HardwareName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/hardware/{hardware}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="hardwareName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HardwareName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hardwareName, out HardwareName result) => TryParse(hardwareName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HardwareName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/hardware/{hardware}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hardwareName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HardwareName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hardwareName, bool allowUnparsed, out HardwareName result)
        {
            gax::GaxPreconditions.CheckNotNull(hardwareName, nameof(hardwareName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationHardware.TryParseName(hardwareName, out resourceName))
            {
                result = FromProjectLocationHardware(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(hardwareName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private HardwareName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string hardwareId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            HardwareId = hardwareId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="HardwareName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/hardware/{hardware}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hardwareId">The <c>Hardware</c> ID. Must not be <c>null</c> or empty.</param>
        public HardwareName(string projectId, string locationId, string hardwareId) : this(ResourceNameType.ProjectLocationHardware, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), hardwareId: gax::GaxPreconditions.CheckNotNullOrEmpty(hardwareId, nameof(hardwareId)))
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
        /// The <c>Hardware</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string HardwareId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationHardware: return s_projectLocationHardware.Expand(ProjectId, LocationId, HardwareId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as HardwareName);

        /// <inheritdoc/>
        public bool Equals(HardwareName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(HardwareName a, HardwareName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(HardwareName a, HardwareName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Comment</c> resource.</summary>
    public sealed partial class CommentName : gax::IResourceName, sys::IEquatable<CommentName>
    {
        /// <summary>The possible contents of <see cref="CommentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/orders/{order}/comments/{comment}</c>.
            /// </summary>
            ProjectLocationOrderComment = 1,
        }

        private static gax::PathTemplate s_projectLocationOrderComment = new gax::PathTemplate("projects/{project}/locations/{location}/orders/{order}/comments/{comment}");

        /// <summary>Creates a <see cref="CommentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CommentName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CommentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CommentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CommentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/comments/{comment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CommentName"/> constructed from the provided ids.</returns>
        public static CommentName FromProjectLocationOrderComment(string projectId, string locationId, string orderId, string commentId) =>
            new CommentName(ResourceNameType.ProjectLocationOrderComment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)), commentId: gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CommentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/comments/{comment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CommentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/comments/{comment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string orderId, string commentId) =>
            FormatProjectLocationOrderComment(projectId, locationId, orderId, commentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CommentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/comments/{comment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CommentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/comments/{comment}</c>.
        /// </returns>
        public static string FormatProjectLocationOrderComment(string projectId, string locationId, string orderId, string commentId) =>
            s_projectLocationOrderComment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)));

        /// <summary>Parses the given resource name string into a new <see cref="CommentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/orders/{order}/comments/{comment}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="commentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CommentName"/> if successful.</returns>
        public static CommentName Parse(string commentName) => Parse(commentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CommentName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/orders/{order}/comments/{comment}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="commentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CommentName"/> if successful.</returns>
        public static CommentName Parse(string commentName, bool allowUnparsed) =>
            TryParse(commentName, allowUnparsed, out CommentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CommentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/orders/{order}/comments/{comment}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="commentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CommentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string commentName, out CommentName result) => TryParse(commentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CommentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/orders/{order}/comments/{comment}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="commentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CommentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string commentName, bool allowUnparsed, out CommentName result)
        {
            gax::GaxPreconditions.CheckNotNull(commentName, nameof(commentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationOrderComment.TryParseName(commentName, out resourceName))
            {
                result = FromProjectLocationOrderComment(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(commentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CommentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string commentId = null, string locationId = null, string orderId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CommentId = commentId;
            LocationId = locationId;
            OrderId = orderId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CommentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/comments/{comment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        public CommentName(string projectId, string locationId, string orderId, string commentId) : this(ResourceNameType.ProjectLocationOrderComment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)), commentId: gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)))
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
        /// The <c>Comment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CommentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Order</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OrderId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationOrderComment: return s_projectLocationOrderComment.Expand(ProjectId, LocationId, OrderId, CommentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CommentName);

        /// <inheritdoc/>
        public bool Equals(CommentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CommentName a, CommentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CommentName a, CommentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ChangeLogEntry</c> resource.</summary>
    public sealed partial class ChangeLogEntryName : gax::IResourceName, sys::IEquatable<ChangeLogEntryName>
    {
        /// <summary>The possible contents of <see cref="ChangeLogEntryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}</c>.
            /// </summary>
            ProjectLocationOrderChangeLogEntry = 1,
        }

        private static gax::PathTemplate s_projectLocationOrderChangeLogEntry = new gax::PathTemplate("projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}");

        /// <summary>Creates a <see cref="ChangeLogEntryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ChangeLogEntryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ChangeLogEntryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ChangeLogEntryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ChangeLogEntryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changeLogEntryId">The <c>ChangeLogEntry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ChangeLogEntryName"/> constructed from the provided ids.</returns>
        public static ChangeLogEntryName FromProjectLocationOrderChangeLogEntry(string projectId, string locationId, string orderId, string changeLogEntryId) =>
            new ChangeLogEntryName(ResourceNameType.ProjectLocationOrderChangeLogEntry, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)), changeLogEntryId: gax::GaxPreconditions.CheckNotNullOrEmpty(changeLogEntryId, nameof(changeLogEntryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChangeLogEntryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changeLogEntryId">The <c>ChangeLogEntry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChangeLogEntryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string orderId, string changeLogEntryId) =>
            FormatProjectLocationOrderChangeLogEntry(projectId, locationId, orderId, changeLogEntryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChangeLogEntryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changeLogEntryId">The <c>ChangeLogEntry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChangeLogEntryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}</c>.
        /// </returns>
        public static string FormatProjectLocationOrderChangeLogEntry(string projectId, string locationId, string orderId, string changeLogEntryId) =>
            s_projectLocationOrderChangeLogEntry.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(changeLogEntryId, nameof(changeLogEntryId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChangeLogEntryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="changeLogEntryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ChangeLogEntryName"/> if successful.</returns>
        public static ChangeLogEntryName Parse(string changeLogEntryName) => Parse(changeLogEntryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChangeLogEntryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="changeLogEntryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ChangeLogEntryName"/> if successful.</returns>
        public static ChangeLogEntryName Parse(string changeLogEntryName, bool allowUnparsed) =>
            TryParse(changeLogEntryName, allowUnparsed, out ChangeLogEntryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChangeLogEntryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="changeLogEntryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChangeLogEntryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string changeLogEntryName, out ChangeLogEntryName result) =>
            TryParse(changeLogEntryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChangeLogEntryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="changeLogEntryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChangeLogEntryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string changeLogEntryName, bool allowUnparsed, out ChangeLogEntryName result)
        {
            gax::GaxPreconditions.CheckNotNull(changeLogEntryName, nameof(changeLogEntryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationOrderChangeLogEntry.TryParseName(changeLogEntryName, out resourceName))
            {
                result = FromProjectLocationOrderChangeLogEntry(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(changeLogEntryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ChangeLogEntryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string changeLogEntryId = null, string locationId = null, string orderId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ChangeLogEntryId = changeLogEntryId;
            LocationId = locationId;
            OrderId = orderId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ChangeLogEntryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changeLogEntryId">The <c>ChangeLogEntry</c> ID. Must not be <c>null</c> or empty.</param>
        public ChangeLogEntryName(string projectId, string locationId, string orderId, string changeLogEntryId) : this(ResourceNameType.ProjectLocationOrderChangeLogEntry, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)), changeLogEntryId: gax::GaxPreconditions.CheckNotNullOrEmpty(changeLogEntryId, nameof(changeLogEntryId)))
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
        /// The <c>ChangeLogEntry</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ChangeLogEntryId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Order</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OrderId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationOrderChangeLogEntry: return s_projectLocationOrderChangeLogEntry.Expand(ProjectId, LocationId, OrderId, ChangeLogEntryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ChangeLogEntryName);

        /// <inheritdoc/>
        public bool Equals(ChangeLogEntryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ChangeLogEntryName a, ChangeLogEntryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ChangeLogEntryName a, ChangeLogEntryName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Sku</c> resource.</summary>
    public sealed partial class SkuName : gax::IResourceName, sys::IEquatable<SkuName>
    {
        /// <summary>The possible contents of <see cref="SkuName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/skus/{sku}</c>.
            /// </summary>
            ProjectLocationSku = 1,
        }

        private static gax::PathTemplate s_projectLocationSku = new gax::PathTemplate("projects/{project}/locations/{location}/skus/{sku}");

        /// <summary>Creates a <see cref="SkuName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SkuName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SkuName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SkuName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SkuName"/> with the pattern <c>projects/{project}/locations/{location}/skus/{sku}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SkuName"/> constructed from the provided ids.</returns>
        public static SkuName FromProjectLocationSku(string projectId, string locationId, string skuId) =>
            new SkuName(ResourceNameType.ProjectLocationSku, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), skuId: gax::GaxPreconditions.CheckNotNullOrEmpty(skuId, nameof(skuId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SkuName"/> with pattern
        /// <c>projects/{project}/locations/{location}/skus/{sku}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SkuName"/> with pattern
        /// <c>projects/{project}/locations/{location}/skus/{sku}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string skuId) =>
            FormatProjectLocationSku(projectId, locationId, skuId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SkuName"/> with pattern
        /// <c>projects/{project}/locations/{location}/skus/{sku}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SkuName"/> with pattern
        /// <c>projects/{project}/locations/{location}/skus/{sku}</c>.
        /// </returns>
        public static string FormatProjectLocationSku(string projectId, string locationId, string skuId) =>
            s_projectLocationSku.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(skuId, nameof(skuId)));

        /// <summary>Parses the given resource name string into a new <see cref="SkuName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/skus/{sku}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="skuName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SkuName"/> if successful.</returns>
        public static SkuName Parse(string skuName) => Parse(skuName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SkuName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/skus/{sku}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="skuName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SkuName"/> if successful.</returns>
        public static SkuName Parse(string skuName, bool allowUnparsed) =>
            TryParse(skuName, allowUnparsed, out SkuName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="SkuName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/skus/{sku}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="skuName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SkuName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string skuName, out SkuName result) => TryParse(skuName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SkuName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/skus/{sku}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="skuName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SkuName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string skuName, bool allowUnparsed, out SkuName result)
        {
            gax::GaxPreconditions.CheckNotNull(skuName, nameof(skuName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSku.TryParseName(skuName, out resourceName))
            {
                result = FromProjectLocationSku(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(skuName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SkuName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string skuId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SkuId = skuId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SkuName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/skus/{sku}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c> or empty.</param>
        public SkuName(string projectId, string locationId, string skuId) : this(ResourceNameType.ProjectLocationSku, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), skuId: gax::GaxPreconditions.CheckNotNullOrEmpty(skuId, nameof(skuId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Sku</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SkuId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSku: return s_projectLocationSku.Expand(ProjectId, LocationId, SkuId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SkuName);

        /// <inheritdoc/>
        public bool Equals(SkuName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SkuName a, SkuName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SkuName a, SkuName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Zone</c> resource.</summary>
    public sealed partial class ZoneName : gax::IResourceName, sys::IEquatable<ZoneName>
    {
        /// <summary>The possible contents of <see cref="ZoneName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/zones/{zone}</c>.
            /// </summary>
            ProjectLocationZone = 1,
        }

        private static gax::PathTemplate s_projectLocationZone = new gax::PathTemplate("projects/{project}/locations/{location}/zones/{zone}");

        /// <summary>Creates a <see cref="ZoneName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ZoneName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ZoneName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ZoneName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ZoneName"/> with the pattern <c>projects/{project}/locations/{location}/zones/{zone}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ZoneName"/> constructed from the provided ids.</returns>
        public static ZoneName FromProjectLocationZone(string projectId, string locationId, string zoneId) =>
            new ZoneName(ResourceNameType.ProjectLocationZone, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ZoneName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ZoneName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string zoneId) =>
            FormatProjectLocationZone(projectId, locationId, zoneId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ZoneName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ZoneName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}</c>.
        /// </returns>
        public static string FormatProjectLocationZone(string projectId, string locationId, string zoneId) =>
            s_projectLocationZone.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)));

        /// <summary>Parses the given resource name string into a new <see cref="ZoneName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/zones/{zone}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="zoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ZoneName"/> if successful.</returns>
        public static ZoneName Parse(string zoneName) => Parse(zoneName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ZoneName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/zones/{zone}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="zoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ZoneName"/> if successful.</returns>
        public static ZoneName Parse(string zoneName, bool allowUnparsed) =>
            TryParse(zoneName, allowUnparsed, out ZoneName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="ZoneName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/zones/{zone}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="zoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ZoneName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string zoneName, out ZoneName result) => TryParse(zoneName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ZoneName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/zones/{zone}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="zoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ZoneName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string zoneName, bool allowUnparsed, out ZoneName result)
        {
            gax::GaxPreconditions.CheckNotNull(zoneName, nameof(zoneName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationZone.TryParseName(zoneName, out resourceName))
            {
                result = FromProjectLocationZone(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(zoneName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ZoneName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ZoneName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        public ZoneName(string projectId, string locationId, string zoneId) : this(ResourceNameType.ProjectLocationZone, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationZone: return s_projectLocationZone.Expand(ProjectId, LocationId, ZoneId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ZoneName);

        /// <inheritdoc/>
        public bool Equals(ZoneName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ZoneName a, ZoneName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ZoneName a, ZoneName b) => !(a == b);
    }

    public partial class Order
    {
        /// <summary>
        /// <see cref="gcgv::OrderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::OrderName OrderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::OrderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Site
    {
        /// <summary>
        /// <see cref="gcgv::SiteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::SiteName SiteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::SiteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class HardwareGroup
    {
        /// <summary>
        /// <see cref="gcgv::HardwareGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::HardwareGroupName HardwareGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::HardwareGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="SiteName"/>-typed view over the <see cref="Site"/> resource name property.</summary>
        public SiteName SiteAsSiteName
        {
            get => string.IsNullOrEmpty(Site) ? null : SiteName.Parse(Site, allowUnparsed: true);
            set => Site = value?.ToString() ?? "";
        }

        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Zone"/> resource name property.</summary>
        public ZoneName ZoneAsZoneName
        {
            get => string.IsNullOrEmpty(Zone) ? null : ZoneName.Parse(Zone, allowUnparsed: true);
            set => Zone = value?.ToString() ?? "";
        }
    }

    public partial class Hardware
    {
        /// <summary>
        /// <see cref="gcgv::HardwareName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::HardwareName HardwareName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::HardwareName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Order"/> resource name property.</summary>
        public OrderName OrderAsOrderName
        {
            get => string.IsNullOrEmpty(Order) ? null : OrderName.Parse(Order, allowUnparsed: true);
            set => Order = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="HardwareGroupName"/>-typed view over the <see cref="HardwareGroup"/> resource name property.
        /// </summary>
        public HardwareGroupName HardwareGroupAsHardwareGroupName
        {
            get => string.IsNullOrEmpty(HardwareGroup) ? null : HardwareGroupName.Parse(HardwareGroup, allowUnparsed: true);
            set => HardwareGroup = value?.ToString() ?? "";
        }

        /// <summary><see cref="SiteName"/>-typed view over the <see cref="Site"/> resource name property.</summary>
        public SiteName SiteAsSiteName
        {
            get => string.IsNullOrEmpty(Site) ? null : SiteName.Parse(Site, allowUnparsed: true);
            set => Site = value?.ToString() ?? "";
        }

        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Zone"/> resource name property.</summary>
        public ZoneName ZoneAsZoneName
        {
            get => string.IsNullOrEmpty(Zone) ? null : ZoneName.Parse(Zone, allowUnparsed: true);
            set => Zone = value?.ToString() ?? "";
        }
    }

    public partial class Comment
    {
        /// <summary>
        /// <see cref="gcgv::CommentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::CommentName CommentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::CommentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ChangeLogEntry
    {
        /// <summary>
        /// <see cref="gcgv::ChangeLogEntryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::ChangeLogEntryName ChangeLogEntryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::ChangeLogEntryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Sku
    {
        /// <summary>
        /// <see cref="gcgv::SkuName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::SkuName SkuName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::SkuName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Zone
    {
        /// <summary>
        /// <see cref="gcgv::ZoneName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::ZoneName ZoneName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::ZoneName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class HardwareConfig
    {
        /// <summary><see cref="SkuName"/>-typed view over the <see cref="Sku"/> resource name property.</summary>
        public SkuName SkuAsSkuName
        {
            get => string.IsNullOrEmpty(Sku) ? null : SkuName.Parse(Sku, allowUnparsed: true);
            set => Sku = value?.ToString() ?? "";
        }
    }

    public partial class HardwareLocation
    {
        /// <summary><see cref="SiteName"/>-typed view over the <see cref="Site"/> resource name property.</summary>
        public SiteName SiteAsSiteName
        {
            get => string.IsNullOrEmpty(Site) ? null : SiteName.Parse(Site, allowUnparsed: true);
            set => Site = value?.ToString() ?? "";
        }
    }
}

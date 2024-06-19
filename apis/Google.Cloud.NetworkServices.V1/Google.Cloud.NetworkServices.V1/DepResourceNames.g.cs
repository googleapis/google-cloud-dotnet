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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcnv = Google.Cloud.NetworkServices.V1;
using sys = System;

namespace Google.Cloud.NetworkServices.V1
{
    /// <summary>Resource name for the <c>LbTrafficExtension</c> resource.</summary>
    public sealed partial class LbTrafficExtensionName : gax::IResourceName, sys::IEquatable<LbTrafficExtensionName>
    {
        /// <summary>The possible contents of <see cref="LbTrafficExtensionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}</c>.
            /// </summary>
            ProjectLocationLbTrafficExtension = 1,
        }

        private static gax::PathTemplate s_projectLocationLbTrafficExtension = new gax::PathTemplate("projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}");

        /// <summary>Creates a <see cref="LbTrafficExtensionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LbTrafficExtensionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LbTrafficExtensionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LbTrafficExtensionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LbTrafficExtensionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lbTrafficExtensionId">
        /// The <c>LbTrafficExtension</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="LbTrafficExtensionName"/> constructed from the provided ids.</returns>
        public static LbTrafficExtensionName FromProjectLocationLbTrafficExtension(string projectId, string locationId, string lbTrafficExtensionId) =>
            new LbTrafficExtensionName(ResourceNameType.ProjectLocationLbTrafficExtension, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lbTrafficExtensionId: gax::GaxPreconditions.CheckNotNullOrEmpty(lbTrafficExtensionId, nameof(lbTrafficExtensionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LbTrafficExtensionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lbTrafficExtensionId">
        /// The <c>LbTrafficExtension</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="LbTrafficExtensionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string lbTrafficExtensionId) =>
            FormatProjectLocationLbTrafficExtension(projectId, locationId, lbTrafficExtensionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LbTrafficExtensionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lbTrafficExtensionId">
        /// The <c>LbTrafficExtension</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="LbTrafficExtensionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}</c>.
        /// </returns>
        public static string FormatProjectLocationLbTrafficExtension(string projectId, string locationId, string lbTrafficExtensionId) =>
            s_projectLocationLbTrafficExtension.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lbTrafficExtensionId, nameof(lbTrafficExtensionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LbTrafficExtensionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="lbTrafficExtensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LbTrafficExtensionName"/> if successful.</returns>
        public static LbTrafficExtensionName Parse(string lbTrafficExtensionName) => Parse(lbTrafficExtensionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LbTrafficExtensionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lbTrafficExtensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LbTrafficExtensionName"/> if successful.</returns>
        public static LbTrafficExtensionName Parse(string lbTrafficExtensionName, bool allowUnparsed) =>
            TryParse(lbTrafficExtensionName, allowUnparsed, out LbTrafficExtensionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LbTrafficExtensionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="lbTrafficExtensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LbTrafficExtensionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lbTrafficExtensionName, out LbTrafficExtensionName result) =>
            TryParse(lbTrafficExtensionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LbTrafficExtensionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lbTrafficExtensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LbTrafficExtensionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lbTrafficExtensionName, bool allowUnparsed, out LbTrafficExtensionName result)
        {
            gax::GaxPreconditions.CheckNotNull(lbTrafficExtensionName, nameof(lbTrafficExtensionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLbTrafficExtension.TryParseName(lbTrafficExtensionName, out resourceName))
            {
                result = FromProjectLocationLbTrafficExtension(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(lbTrafficExtensionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LbTrafficExtensionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string lbTrafficExtensionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LbTrafficExtensionId = lbTrafficExtensionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LbTrafficExtensionName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lbTrafficExtensionId">
        /// The <c>LbTrafficExtension</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public LbTrafficExtensionName(string projectId, string locationId, string lbTrafficExtensionId) : this(ResourceNameType.ProjectLocationLbTrafficExtension, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lbTrafficExtensionId: gax::GaxPreconditions.CheckNotNullOrEmpty(lbTrafficExtensionId, nameof(lbTrafficExtensionId)))
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
        /// The <c>LbTrafficExtension</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string LbTrafficExtensionId { get; }

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
                case ResourceNameType.ProjectLocationLbTrafficExtension: return s_projectLocationLbTrafficExtension.Expand(ProjectId, LocationId, LbTrafficExtensionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LbTrafficExtensionName);

        /// <inheritdoc/>
        public bool Equals(LbTrafficExtensionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LbTrafficExtensionName a, LbTrafficExtensionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LbTrafficExtensionName a, LbTrafficExtensionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>LbRouteExtension</c> resource.</summary>
    public sealed partial class LbRouteExtensionName : gax::IResourceName, sys::IEquatable<LbRouteExtensionName>
    {
        /// <summary>The possible contents of <see cref="LbRouteExtensionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}</c>.
            /// </summary>
            ProjectLocationLbRouteExtension = 1,
        }

        private static gax::PathTemplate s_projectLocationLbRouteExtension = new gax::PathTemplate("projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}");

        /// <summary>Creates a <see cref="LbRouteExtensionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LbRouteExtensionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LbRouteExtensionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LbRouteExtensionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LbRouteExtensionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lbRouteExtensionId">The <c>LbRouteExtension</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LbRouteExtensionName"/> constructed from the provided ids.</returns>
        public static LbRouteExtensionName FromProjectLocationLbRouteExtension(string projectId, string locationId, string lbRouteExtensionId) =>
            new LbRouteExtensionName(ResourceNameType.ProjectLocationLbRouteExtension, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lbRouteExtensionId: gax::GaxPreconditions.CheckNotNullOrEmpty(lbRouteExtensionId, nameof(lbRouteExtensionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LbRouteExtensionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lbRouteExtensionId">The <c>LbRouteExtension</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LbRouteExtensionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string lbRouteExtensionId) =>
            FormatProjectLocationLbRouteExtension(projectId, locationId, lbRouteExtensionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LbRouteExtensionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lbRouteExtensionId">The <c>LbRouteExtension</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LbRouteExtensionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}</c>.
        /// </returns>
        public static string FormatProjectLocationLbRouteExtension(string projectId, string locationId, string lbRouteExtensionId) =>
            s_projectLocationLbRouteExtension.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lbRouteExtensionId, nameof(lbRouteExtensionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LbRouteExtensionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="lbRouteExtensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LbRouteExtensionName"/> if successful.</returns>
        public static LbRouteExtensionName Parse(string lbRouteExtensionName) => Parse(lbRouteExtensionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LbRouteExtensionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lbRouteExtensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LbRouteExtensionName"/> if successful.</returns>
        public static LbRouteExtensionName Parse(string lbRouteExtensionName, bool allowUnparsed) =>
            TryParse(lbRouteExtensionName, allowUnparsed, out LbRouteExtensionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LbRouteExtensionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="lbRouteExtensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LbRouteExtensionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lbRouteExtensionName, out LbRouteExtensionName result) =>
            TryParse(lbRouteExtensionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LbRouteExtensionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lbRouteExtensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LbRouteExtensionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lbRouteExtensionName, bool allowUnparsed, out LbRouteExtensionName result)
        {
            gax::GaxPreconditions.CheckNotNull(lbRouteExtensionName, nameof(lbRouteExtensionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLbRouteExtension.TryParseName(lbRouteExtensionName, out resourceName))
            {
                result = FromProjectLocationLbRouteExtension(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(lbRouteExtensionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LbRouteExtensionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string lbRouteExtensionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LbRouteExtensionId = lbRouteExtensionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LbRouteExtensionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lbRouteExtensionId">The <c>LbRouteExtension</c> ID. Must not be <c>null</c> or empty.</param>
        public LbRouteExtensionName(string projectId, string locationId, string lbRouteExtensionId) : this(ResourceNameType.ProjectLocationLbRouteExtension, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lbRouteExtensionId: gax::GaxPreconditions.CheckNotNullOrEmpty(lbRouteExtensionId, nameof(lbRouteExtensionId)))
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
        /// The <c>LbRouteExtension</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string LbRouteExtensionId { get; }

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
                case ResourceNameType.ProjectLocationLbRouteExtension: return s_projectLocationLbRouteExtension.Expand(ProjectId, LocationId, LbRouteExtensionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LbRouteExtensionName);

        /// <inheritdoc/>
        public bool Equals(LbRouteExtensionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LbRouteExtensionName a, LbRouteExtensionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LbRouteExtensionName a, LbRouteExtensionName b) => !(a == b);
    }

    public partial class LbTrafficExtension
    {
        /// <summary>
        /// <see cref="gcnv::LbTrafficExtensionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::LbTrafficExtensionName LbTrafficExtensionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::LbTrafficExtensionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLbTrafficExtensionsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetLbTrafficExtensionRequest
    {
        /// <summary>
        /// <see cref="gcnv::LbTrafficExtensionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::LbTrafficExtensionName LbTrafficExtensionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::LbTrafficExtensionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateLbTrafficExtensionRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteLbTrafficExtensionRequest
    {
        /// <summary>
        /// <see cref="gcnv::LbTrafficExtensionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::LbTrafficExtensionName LbTrafficExtensionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::LbTrafficExtensionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LbRouteExtension
    {
        /// <summary>
        /// <see cref="gcnv::LbRouteExtensionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::LbRouteExtensionName LbRouteExtensionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::LbRouteExtensionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLbRouteExtensionsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetLbRouteExtensionRequest
    {
        /// <summary>
        /// <see cref="gcnv::LbRouteExtensionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::LbRouteExtensionName LbRouteExtensionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::LbRouteExtensionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateLbRouteExtensionRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteLbRouteExtensionRequest
    {
        /// <summary>
        /// <see cref="gcnv::LbRouteExtensionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::LbRouteExtensionName LbRouteExtensionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::LbRouteExtensionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

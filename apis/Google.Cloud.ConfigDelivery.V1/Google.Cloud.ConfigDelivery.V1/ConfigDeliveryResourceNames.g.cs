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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gccv = Google.Cloud.ConfigDelivery.V1;
using sys = System;

namespace Google.Cloud.ConfigDelivery.V1
{
    /// <summary>Resource name for the <c>ResourceBundle</c> resource.</summary>
    public sealed partial class ResourceBundleName : gax::IResourceName, sys::IEquatable<ResourceBundleName>
    {
        /// <summary>The possible contents of <see cref="ResourceBundleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}</c>.
            /// </summary>
            ProjectLocationResourceBundle = 1,
        }

        private static gax::PathTemplate s_projectLocationResourceBundle = new gax::PathTemplate("projects/{project}/locations/{location}/resourceBundles/{resource_bundle}");

        /// <summary>Creates a <see cref="ResourceBundleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ResourceBundleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ResourceBundleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ResourceBundleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ResourceBundleName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceBundleId">The <c>ResourceBundle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ResourceBundleName"/> constructed from the provided ids.</returns>
        public static ResourceBundleName FromProjectLocationResourceBundle(string projectId, string locationId, string resourceBundleId) =>
            new ResourceBundleName(ResourceNameType.ProjectLocationResourceBundle, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceBundleId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceBundleId, nameof(resourceBundleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceBundleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceBundleId">The <c>ResourceBundle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ResourceBundleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string resourceBundleId) =>
            FormatProjectLocationResourceBundle(projectId, locationId, resourceBundleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceBundleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceBundleId">The <c>ResourceBundle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ResourceBundleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}</c>.
        /// </returns>
        public static string FormatProjectLocationResourceBundle(string projectId, string locationId, string resourceBundleId) =>
            s_projectLocationResourceBundle.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(resourceBundleId, nameof(resourceBundleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ResourceBundleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="resourceBundleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ResourceBundleName"/> if successful.</returns>
        public static ResourceBundleName Parse(string resourceBundleName) => Parse(resourceBundleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ResourceBundleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="resourceBundleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ResourceBundleName"/> if successful.</returns>
        public static ResourceBundleName Parse(string resourceBundleName, bool allowUnparsed) =>
            TryParse(resourceBundleName, allowUnparsed, out ResourceBundleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ResourceBundleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="resourceBundleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ResourceBundleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resourceBundleName, out ResourceBundleName result) =>
            TryParse(resourceBundleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ResourceBundleName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="resourceBundleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ResourceBundleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resourceBundleName, bool allowUnparsed, out ResourceBundleName result)
        {
            gax::GaxPreconditions.CheckNotNull(resourceBundleName, nameof(resourceBundleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationResourceBundle.TryParseName(resourceBundleName, out resourceName))
            {
                result = FromProjectLocationResourceBundle(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(resourceBundleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ResourceBundleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string resourceBundleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ResourceBundleId = resourceBundleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ResourceBundleName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceBundleId">The <c>ResourceBundle</c> ID. Must not be <c>null</c> or empty.</param>
        public ResourceBundleName(string projectId, string locationId, string resourceBundleId) : this(ResourceNameType.ProjectLocationResourceBundle, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceBundleId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceBundleId, nameof(resourceBundleId)))
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
        /// The <c>ResourceBundle</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ResourceBundleId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationResourceBundle: return s_projectLocationResourceBundle.Expand(ProjectId, LocationId, ResourceBundleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ResourceBundleName);

        /// <inheritdoc/>
        public bool Equals(ResourceBundleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ResourceBundleName a, ResourceBundleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ResourceBundleName a, ResourceBundleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FleetPackage</c> resource.</summary>
    public sealed partial class FleetPackageName : gax::IResourceName, sys::IEquatable<FleetPackageName>
    {
        /// <summary>The possible contents of <see cref="FleetPackageName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}</c>
            /// .
            /// </summary>
            ProjectLocationFleetPackage = 1,
        }

        private static gax::PathTemplate s_projectLocationFleetPackage = new gax::PathTemplate("projects/{project}/locations/{location}/fleetPackages/{fleet_package}");

        /// <summary>Creates a <see cref="FleetPackageName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FleetPackageName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FleetPackageName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FleetPackageName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FleetPackageName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetPackageId">The <c>FleetPackage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FleetPackageName"/> constructed from the provided ids.</returns>
        public static FleetPackageName FromProjectLocationFleetPackage(string projectId, string locationId, string fleetPackageId) =>
            new FleetPackageName(ResourceNameType.ProjectLocationFleetPackage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), fleetPackageId: gax::GaxPreconditions.CheckNotNullOrEmpty(fleetPackageId, nameof(fleetPackageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FleetPackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetPackageId">The <c>FleetPackage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FleetPackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string fleetPackageId) =>
            FormatProjectLocationFleetPackage(projectId, locationId, fleetPackageId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FleetPackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetPackageId">The <c>FleetPackage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FleetPackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}</c>.
        /// </returns>
        public static string FormatProjectLocationFleetPackage(string projectId, string locationId, string fleetPackageId) =>
            s_projectLocationFleetPackage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fleetPackageId, nameof(fleetPackageId)));

        /// <summary>Parses the given resource name string into a new <see cref="FleetPackageName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fleetPackageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FleetPackageName"/> if successful.</returns>
        public static FleetPackageName Parse(string fleetPackageName) => Parse(fleetPackageName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FleetPackageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fleetPackageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FleetPackageName"/> if successful.</returns>
        public static FleetPackageName Parse(string fleetPackageName, bool allowUnparsed) =>
            TryParse(fleetPackageName, allowUnparsed, out FleetPackageName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FleetPackageName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fleetPackageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FleetPackageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fleetPackageName, out FleetPackageName result) =>
            TryParse(fleetPackageName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FleetPackageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fleetPackageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FleetPackageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fleetPackageName, bool allowUnparsed, out FleetPackageName result)
        {
            gax::GaxPreconditions.CheckNotNull(fleetPackageName, nameof(fleetPackageName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFleetPackage.TryParseName(fleetPackageName, out resourceName))
            {
                result = FromProjectLocationFleetPackage(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(fleetPackageName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FleetPackageName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string fleetPackageId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FleetPackageId = fleetPackageId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FleetPackageName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetPackageId">The <c>FleetPackage</c> ID. Must not be <c>null</c> or empty.</param>
        public FleetPackageName(string projectId, string locationId, string fleetPackageId) : this(ResourceNameType.ProjectLocationFleetPackage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), fleetPackageId: gax::GaxPreconditions.CheckNotNullOrEmpty(fleetPackageId, nameof(fleetPackageId)))
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
        /// The <c>FleetPackage</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string FleetPackageId { get; }

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
                case ResourceNameType.ProjectLocationFleetPackage: return s_projectLocationFleetPackage.Expand(ProjectId, LocationId, FleetPackageId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FleetPackageName);

        /// <inheritdoc/>
        public bool Equals(FleetPackageName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FleetPackageName a, FleetPackageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FleetPackageName a, FleetPackageName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Release</c> resource.</summary>
    public sealed partial class ReleaseName : gax::IResourceName, sys::IEquatable<ReleaseName>
    {
        /// <summary>The possible contents of <see cref="ReleaseName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}</c>.
            /// </summary>
            ProjectLocationResourceBundleRelease = 1,
        }

        private static gax::PathTemplate s_projectLocationResourceBundleRelease = new gax::PathTemplate("projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}");

        /// <summary>Creates a <see cref="ReleaseName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReleaseName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReleaseName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReleaseName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReleaseName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceBundleId">The <c>ResourceBundle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReleaseName"/> constructed from the provided ids.</returns>
        public static ReleaseName FromProjectLocationResourceBundleRelease(string projectId, string locationId, string resourceBundleId, string releaseId) =>
            new ReleaseName(ResourceNameType.ProjectLocationResourceBundleRelease, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceBundleId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceBundleId, nameof(resourceBundleId)), releaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReleaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceBundleId">The <c>ResourceBundle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReleaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string resourceBundleId, string releaseId) =>
            FormatProjectLocationResourceBundleRelease(projectId, locationId, resourceBundleId, releaseId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReleaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceBundleId">The <c>ResourceBundle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReleaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}</c>.
        /// </returns>
        public static string FormatProjectLocationResourceBundleRelease(string projectId, string locationId, string resourceBundleId, string releaseId) =>
            s_projectLocationResourceBundleRelease.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(resourceBundleId, nameof(resourceBundleId)), gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReleaseName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="releaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReleaseName"/> if successful.</returns>
        public static ReleaseName Parse(string releaseName) => Parse(releaseName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReleaseName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="releaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReleaseName"/> if successful.</returns>
        public static ReleaseName Parse(string releaseName, bool allowUnparsed) =>
            TryParse(releaseName, allowUnparsed, out ReleaseName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReleaseName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="releaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReleaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string releaseName, out ReleaseName result) => TryParse(releaseName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReleaseName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="releaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReleaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string releaseName, bool allowUnparsed, out ReleaseName result)
        {
            gax::GaxPreconditions.CheckNotNull(releaseName, nameof(releaseName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationResourceBundleRelease.TryParseName(releaseName, out resourceName))
            {
                result = FromProjectLocationResourceBundleRelease(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(releaseName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReleaseName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string releaseId = null, string resourceBundleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ReleaseId = releaseId;
            ResourceBundleId = resourceBundleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReleaseName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceBundleId">The <c>ResourceBundle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        public ReleaseName(string projectId, string locationId, string resourceBundleId, string releaseId) : this(ResourceNameType.ProjectLocationResourceBundleRelease, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceBundleId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceBundleId, nameof(resourceBundleId)), releaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)))
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
        /// The <c>Release</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ReleaseId { get; }

        /// <summary>
        /// The <c>ResourceBundle</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ResourceBundleId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationResourceBundleRelease: return s_projectLocationResourceBundleRelease.Expand(ProjectId, LocationId, ResourceBundleId, ReleaseId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReleaseName);

        /// <inheritdoc/>
        public bool Equals(ReleaseName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReleaseName a, ReleaseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReleaseName a, ReleaseName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Variant</c> resource.</summary>
    public sealed partial class VariantName : gax::IResourceName, sys::IEquatable<VariantName>
    {
        /// <summary>The possible contents of <see cref="VariantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}/variants/{variant}</c>
            /// .
            /// </summary>
            ProjectLocationResourceBundleReleaseVariant = 1,
        }

        private static gax::PathTemplate s_projectLocationResourceBundleReleaseVariant = new gax::PathTemplate("projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}/variants/{variant}");

        /// <summary>Creates a <see cref="VariantName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VariantName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VariantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VariantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VariantName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}/variants/{variant}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceBundleId">The <c>ResourceBundle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="variantId">The <c>Variant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VariantName"/> constructed from the provided ids.</returns>
        public static VariantName FromProjectLocationResourceBundleReleaseVariant(string projectId, string locationId, string resourceBundleId, string releaseId, string variantId) =>
            new VariantName(ResourceNameType.ProjectLocationResourceBundleReleaseVariant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceBundleId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceBundleId, nameof(resourceBundleId)), releaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)), variantId: gax::GaxPreconditions.CheckNotNullOrEmpty(variantId, nameof(variantId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VariantName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}/variants/{variant}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceBundleId">The <c>ResourceBundle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="variantId">The <c>Variant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VariantName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}/variants/{variant}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string resourceBundleId, string releaseId, string variantId) =>
            FormatProjectLocationResourceBundleReleaseVariant(projectId, locationId, resourceBundleId, releaseId, variantId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VariantName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}/variants/{variant}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceBundleId">The <c>ResourceBundle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="variantId">The <c>Variant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VariantName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}/variants/{variant}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationResourceBundleReleaseVariant(string projectId, string locationId, string resourceBundleId, string releaseId, string variantId) =>
            s_projectLocationResourceBundleReleaseVariant.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(resourceBundleId, nameof(resourceBundleId)), gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(variantId, nameof(variantId)));

        /// <summary>Parses the given resource name string into a new <see cref="VariantName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}/variants/{variant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="variantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VariantName"/> if successful.</returns>
        public static VariantName Parse(string variantName) => Parse(variantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VariantName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}/variants/{variant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="variantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VariantName"/> if successful.</returns>
        public static VariantName Parse(string variantName, bool allowUnparsed) =>
            TryParse(variantName, allowUnparsed, out VariantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VariantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}/variants/{variant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="variantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VariantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string variantName, out VariantName result) => TryParse(variantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VariantName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}/variants/{variant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="variantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VariantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string variantName, bool allowUnparsed, out VariantName result)
        {
            gax::GaxPreconditions.CheckNotNull(variantName, nameof(variantName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationResourceBundleReleaseVariant.TryParseName(variantName, out resourceName))
            {
                result = FromProjectLocationResourceBundleReleaseVariant(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(variantName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VariantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string releaseId = null, string resourceBundleId = null, string variantId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ReleaseId = releaseId;
            ResourceBundleId = resourceBundleId;
            VariantId = variantId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VariantName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/resourceBundles/{resource_bundle}/releases/{release}/variants/{variant}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceBundleId">The <c>ResourceBundle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="variantId">The <c>Variant</c> ID. Must not be <c>null</c> or empty.</param>
        public VariantName(string projectId, string locationId, string resourceBundleId, string releaseId, string variantId) : this(ResourceNameType.ProjectLocationResourceBundleReleaseVariant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceBundleId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceBundleId, nameof(resourceBundleId)), releaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)), variantId: gax::GaxPreconditions.CheckNotNullOrEmpty(variantId, nameof(variantId)))
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
        /// The <c>Release</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ReleaseId { get; }

        /// <summary>
        /// The <c>ResourceBundle</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ResourceBundleId { get; }

        /// <summary>
        /// The <c>Variant</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VariantId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationResourceBundleReleaseVariant: return s_projectLocationResourceBundleReleaseVariant.Expand(ProjectId, LocationId, ResourceBundleId, ReleaseId, VariantId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VariantName);

        /// <inheritdoc/>
        public bool Equals(VariantName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VariantName a, VariantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VariantName a, VariantName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Rollout</c> resource.</summary>
    public sealed partial class RolloutName : gax::IResourceName, sys::IEquatable<RolloutName>
    {
        /// <summary>The possible contents of <see cref="RolloutName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}</c>.
            /// </summary>
            ProjectLocationFleetPackageRollout = 1,
        }

        private static gax::PathTemplate s_projectLocationFleetPackageRollout = new gax::PathTemplate("projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}");

        /// <summary>Creates a <see cref="RolloutName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RolloutName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RolloutName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RolloutName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RolloutName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetPackageId">The <c>FleetPackage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RolloutName"/> constructed from the provided ids.</returns>
        public static RolloutName FromProjectLocationFleetPackageRollout(string projectId, string locationId, string fleetPackageId, string rolloutId) =>
            new RolloutName(ResourceNameType.ProjectLocationFleetPackageRollout, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), fleetPackageId: gax::GaxPreconditions.CheckNotNullOrEmpty(fleetPackageId, nameof(fleetPackageId)), rolloutId: gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RolloutName"/> with pattern
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetPackageId">The <c>FleetPackage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RolloutName"/> with pattern
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string fleetPackageId, string rolloutId) =>
            FormatProjectLocationFleetPackageRollout(projectId, locationId, fleetPackageId, rolloutId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RolloutName"/> with pattern
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetPackageId">The <c>FleetPackage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RolloutName"/> with pattern
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}</c>.
        /// </returns>
        public static string FormatProjectLocationFleetPackageRollout(string projectId, string locationId, string fleetPackageId, string rolloutId) =>
            s_projectLocationFleetPackageRollout.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fleetPackageId, nameof(fleetPackageId)), gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)));

        /// <summary>Parses the given resource name string into a new <see cref="RolloutName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="rolloutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RolloutName"/> if successful.</returns>
        public static RolloutName Parse(string rolloutName) => Parse(rolloutName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RolloutName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rolloutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RolloutName"/> if successful.</returns>
        public static RolloutName Parse(string rolloutName, bool allowUnparsed) =>
            TryParse(rolloutName, allowUnparsed, out RolloutName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RolloutName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="rolloutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RolloutName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rolloutName, out RolloutName result) => TryParse(rolloutName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RolloutName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rolloutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RolloutName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rolloutName, bool allowUnparsed, out RolloutName result)
        {
            gax::GaxPreconditions.CheckNotNull(rolloutName, nameof(rolloutName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFleetPackageRollout.TryParseName(rolloutName, out resourceName))
            {
                result = FromProjectLocationFleetPackageRollout(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(rolloutName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RolloutName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string fleetPackageId = null, string locationId = null, string projectId = null, string rolloutId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FleetPackageId = fleetPackageId;
            LocationId = locationId;
            ProjectId = projectId;
            RolloutId = rolloutId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RolloutName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetPackageId">The <c>FleetPackage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        public RolloutName(string projectId, string locationId, string fleetPackageId, string rolloutId) : this(ResourceNameType.ProjectLocationFleetPackageRollout, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), fleetPackageId: gax::GaxPreconditions.CheckNotNullOrEmpty(fleetPackageId, nameof(fleetPackageId)), rolloutId: gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)))
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
        /// The <c>FleetPackage</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string FleetPackageId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Rollout</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RolloutId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationFleetPackageRollout: return s_projectLocationFleetPackageRollout.Expand(ProjectId, LocationId, FleetPackageId, RolloutId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RolloutName);

        /// <inheritdoc/>
        public bool Equals(RolloutName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RolloutName a, RolloutName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RolloutName a, RolloutName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Repository</c> resource.</summary>
    public sealed partial class RepositoryName : gax::IResourceName, sys::IEquatable<RepositoryName>
    {
        /// <summary>The possible contents of <see cref="RepositoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
            /// </summary>
            ProjectLocationConnectionRepository = 1,
        }

        private static gax::PathTemplate s_projectLocationConnectionRepository = new gax::PathTemplate("projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}");

        /// <summary>Creates a <see cref="RepositoryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RepositoryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RepositoryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RepositoryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RepositoryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RepositoryName"/> constructed from the provided ids.</returns>
        public static RepositoryName FromProjectLocationConnectionRepository(string projectId, string locationId, string connectionId, string repositoryId) =>
            new RepositoryName(ResourceNameType.ProjectLocationConnectionRepository, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string connectionId, string repositoryId) =>
            FormatProjectLocationConnectionRepository(projectId, locationId, connectionId, repositoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </returns>
        public static string FormatProjectLocationConnectionRepository(string projectId, string locationId, string connectionId, string repositoryId) =>
            s_projectLocationConnectionRepository.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)));

        /// <summary>Parses the given resource name string into a new <see cref="RepositoryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RepositoryName"/> if successful.</returns>
        public static RepositoryName Parse(string repositoryName) => Parse(repositoryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RepositoryName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RepositoryName"/> if successful.</returns>
        public static RepositoryName Parse(string repositoryName, bool allowUnparsed) =>
            TryParse(repositoryName, allowUnparsed, out RepositoryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RepositoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RepositoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string repositoryName, out RepositoryName result) =>
            TryParse(repositoryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RepositoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RepositoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string repositoryName, bool allowUnparsed, out RepositoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(repositoryName, nameof(repositoryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConnectionRepository.TryParseName(repositoryName, out resourceName))
            {
                result = FromProjectLocationConnectionRepository(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(repositoryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RepositoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string connectionId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConnectionId = connectionId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RepositoryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        public RepositoryName(string projectId, string locationId, string connectionId, string repositoryId) : this(ResourceNameType.ProjectLocationConnectionRepository, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)))
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
        /// The <c>Connection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ConnectionId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Repository</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RepositoryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationConnectionRepository: return s_projectLocationConnectionRepository.Expand(ProjectId, LocationId, ConnectionId, RepositoryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RepositoryName);

        /// <inheritdoc/>
        public bool Equals(RepositoryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RepositoryName a, RepositoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RepositoryName a, RepositoryName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Membership</c> resource.</summary>
    public sealed partial class MembershipName : gax::IResourceName, sys::IEquatable<MembershipName>
    {
        /// <summary>The possible contents of <see cref="MembershipName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
            /// </summary>
            ProjectLocationMembership = 1,
        }

        private static gax::PathTemplate s_projectLocationMembership = new gax::PathTemplate("projects/{project}/locations/{location}/memberships/{membership}");

        /// <summary>Creates a <see cref="MembershipName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MembershipName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MembershipName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MembershipName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MembershipName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MembershipName"/> constructed from the provided ids.</returns>
        public static MembershipName FromProjectLocationMembership(string projectId, string locationId, string membershipId) =>
            new MembershipName(ResourceNameType.ProjectLocationMembership, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), membershipId: gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string membershipId) =>
            FormatProjectLocationMembership(projectId, locationId, membershipId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </returns>
        public static string FormatProjectLocationMembership(string projectId, string locationId, string membershipId) =>
            s_projectLocationMembership.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)));

        /// <summary>Parses the given resource name string into a new <see cref="MembershipName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{membership}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MembershipName"/> if successful.</returns>
        public static MembershipName Parse(string membershipName) => Parse(membershipName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MembershipName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{membership}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MembershipName"/> if successful.</returns>
        public static MembershipName Parse(string membershipName, bool allowUnparsed) =>
            TryParse(membershipName, allowUnparsed, out MembershipName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MembershipName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{membership}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MembershipName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string membershipName, out MembershipName result) =>
            TryParse(membershipName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MembershipName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{membership}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MembershipName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string membershipName, bool allowUnparsed, out MembershipName result)
        {
            gax::GaxPreconditions.CheckNotNull(membershipName, nameof(membershipName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMembership.TryParseName(membershipName, out resourceName))
            {
                result = FromProjectLocationMembership(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(membershipName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MembershipName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string membershipId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MembershipId = membershipId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MembershipName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        public MembershipName(string projectId, string locationId, string membershipId) : this(ResourceNameType.ProjectLocationMembership, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), membershipId: gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)))
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
        /// The <c>Membership</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MembershipId { get; }

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
                case ResourceNameType.ProjectLocationMembership: return s_projectLocationMembership.Expand(ProjectId, LocationId, MembershipId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MembershipName);

        /// <inheritdoc/>
        public bool Equals(MembershipName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MembershipName a, MembershipName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MembershipName a, MembershipName b) => !(a == b);
    }

    public partial class ResourceBundle
    {
        /// <summary>
        /// <see cref="gccv::ResourceBundleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ResourceBundleName ResourceBundleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ResourceBundleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListResourceBundlesRequest
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

    public partial class GetResourceBundleRequest
    {
        /// <summary>
        /// <see cref="gccv::ResourceBundleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ResourceBundleName ResourceBundleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ResourceBundleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateResourceBundleRequest
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

    public partial class DeleteResourceBundleRequest
    {
        /// <summary>
        /// <see cref="gccv::ResourceBundleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ResourceBundleName ResourceBundleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ResourceBundleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FleetPackage
    {
        /// <summary>
        /// <see cref="gccv::FleetPackageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FleetPackageName FleetPackageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FleetPackageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class ResourceBundleTag
            {
                /// <summary>
                /// <see cref="gccv::ResourceBundleName"/>-typed view over the <see cref="Name"/> resource name
                /// property.
                /// </summary>
                public gccv::ResourceBundleName ResourceBundleName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gccv::ResourceBundleName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }
            }

            public partial class CloudBuildRepository
            {
                /// <summary>
                /// <see cref="gccv::RepositoryName"/>-typed view over the <see cref="Name"/> resource name property.
                /// </summary>
                public gccv::RepositoryName RepositoryName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gccv::RepositoryName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class FleetPackageInfo
    {
        /// <summary>
        /// <see cref="RolloutName"/>-typed view over the <see cref="ActiveRollout"/> resource name property.
        /// </summary>
        public RolloutName ActiveRolloutAsRolloutName
        {
            get => string.IsNullOrEmpty(ActiveRollout) ? null : RolloutName.Parse(ActiveRollout, allowUnparsed: true);
            set => ActiveRollout = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="RolloutName"/>-typed view over the <see cref="LastCompletedRollout"/> resource name property.
        /// </summary>
        public RolloutName LastCompletedRolloutAsRolloutName
        {
            get => string.IsNullOrEmpty(LastCompletedRollout) ? null : RolloutName.Parse(LastCompletedRollout, allowUnparsed: true);
            set => LastCompletedRollout = value?.ToString() ?? "";
        }
    }

    public partial class ClusterInfo
    {
        /// <summary>
        /// <see cref="MembershipName"/>-typed view over the <see cref="Membership"/> resource name property.
        /// </summary>
        public MembershipName MembershipAsMembershipName
        {
            get => string.IsNullOrEmpty(Membership) ? null : MembershipName.Parse(Membership, allowUnparsed: true);
            set => Membership = value?.ToString() ?? "";
        }
    }

    public partial class ResourceBundleDeploymentInfo
    {
        /// <summary>
        /// <see cref="ReleaseName"/>-typed view over the <see cref="Release"/> resource name property.
        /// </summary>
        public ReleaseName ReleaseAsReleaseName
        {
            get => string.IsNullOrEmpty(Release) ? null : ReleaseName.Parse(Release, allowUnparsed: true);
            set => Release = value?.ToString() ?? "";
        }
    }

    public partial class Fleet
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }

    public partial class ListFleetPackagesRequest
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

    public partial class GetFleetPackageRequest
    {
        /// <summary>
        /// <see cref="gccv::FleetPackageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FleetPackageName FleetPackageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FleetPackageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFleetPackageRequest
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

    public partial class DeleteFleetPackageRequest
    {
        /// <summary>
        /// <see cref="gccv::FleetPackageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FleetPackageName FleetPackageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FleetPackageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Release
    {
        /// <summary>
        /// <see cref="gccv::ReleaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ReleaseName ReleaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ReleaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Variant
    {
        /// <summary>
        /// <see cref="gccv::VariantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::VariantName VariantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::VariantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListVariantsRequest
    {
        /// <summary>
        /// <see cref="ReleaseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ReleaseName ParentAsReleaseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ReleaseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetVariantRequest
    {
        /// <summary>
        /// <see cref="gccv::VariantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::VariantName VariantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::VariantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateVariantRequest
    {
        /// <summary>
        /// <see cref="ReleaseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ReleaseName ParentAsReleaseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ReleaseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteVariantRequest
    {
        /// <summary>
        /// <see cref="gccv::VariantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::VariantName VariantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::VariantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListReleasesRequest
    {
        /// <summary>
        /// <see cref="ResourceBundleName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ResourceBundleName ParentAsResourceBundleName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ResourceBundleName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetReleaseRequest
    {
        /// <summary>
        /// <see cref="gccv::ReleaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ReleaseName ReleaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ReleaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateReleaseRequest
    {
        /// <summary>
        /// <see cref="ResourceBundleName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ResourceBundleName ParentAsResourceBundleName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ResourceBundleName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteReleaseRequest
    {
        /// <summary>
        /// <see cref="gccv::ReleaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ReleaseName ReleaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ReleaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRolloutsRequest
    {
        /// <summary>
        /// <see cref="FleetPackageName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FleetPackageName ParentAsFleetPackageName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FleetPackageName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRolloutRequest
    {
        /// <summary>
        /// <see cref="gccv::RolloutName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RolloutName RolloutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RolloutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Rollout
    {
        /// <summary>
        /// <see cref="gccv::RolloutName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RolloutName RolloutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RolloutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ReleaseName"/>-typed view over the <see cref="Release"/> resource name property.
        /// </summary>
        public ReleaseName ReleaseAsReleaseName
        {
            get => string.IsNullOrEmpty(Release) ? null : ReleaseName.Parse(Release, allowUnparsed: true);
            set => Release = value?.ToString() ?? "";
        }
    }

    public partial class SuspendRolloutRequest
    {
        /// <summary>
        /// <see cref="gccv::RolloutName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RolloutName RolloutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RolloutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResumeRolloutRequest
    {
        /// <summary>
        /// <see cref="gccv::RolloutName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RolloutName RolloutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RolloutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AbortRolloutRequest
    {
        /// <summary>
        /// <see cref="gccv::RolloutName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RolloutName RolloutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RolloutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

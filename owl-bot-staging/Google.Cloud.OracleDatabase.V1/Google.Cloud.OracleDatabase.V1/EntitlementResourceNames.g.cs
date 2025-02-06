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
using gcov = Google.Cloud.OracleDatabase.V1;
using sys = System;

namespace Google.Cloud.OracleDatabase.V1
{
    /// <summary>Resource name for the <c>Entitlement</c> resource.</summary>
    public sealed partial class EntitlementName : gax::IResourceName, sys::IEquatable<EntitlementName>
    {
        /// <summary>The possible contents of <see cref="EntitlementName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>.
            /// </summary>
            ProjectLocationEntitlement = 1,
        }

        private static gax::PathTemplate s_projectLocationEntitlement = new gax::PathTemplate("projects/{project}/locations/{location}/entitlements/{entitlement}");

        /// <summary>Creates a <see cref="EntitlementName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EntitlementName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EntitlementName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EntitlementName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EntitlementName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EntitlementName"/> constructed from the provided ids.</returns>
        public static EntitlementName FromProjectLocationEntitlement(string projectId, string locationId, string entitlementId) =>
            new EntitlementName(ResourceNameType.ProjectLocationEntitlement, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entitlementId: gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntitlementName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntitlementName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string entitlementId) =>
            FormatProjectLocationEntitlement(projectId, locationId, entitlementId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntitlementName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntitlementName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>.
        /// </returns>
        public static string FormatProjectLocationEntitlement(string projectId, string locationId, string entitlementId) =>
            s_projectLocationEntitlement.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)));

        /// <summary>Parses the given resource name string into a new <see cref="EntitlementName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entitlements/{entitlement}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entitlementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EntitlementName"/> if successful.</returns>
        public static EntitlementName Parse(string entitlementName) => Parse(entitlementName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EntitlementName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entitlements/{entitlement}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entitlementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EntitlementName"/> if successful.</returns>
        public static EntitlementName Parse(string entitlementName, bool allowUnparsed) =>
            TryParse(entitlementName, allowUnparsed, out EntitlementName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntitlementName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entitlements/{entitlement}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entitlementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntitlementName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entitlementName, out EntitlementName result) =>
            TryParse(entitlementName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntitlementName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entitlements/{entitlement}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entitlementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntitlementName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entitlementName, bool allowUnparsed, out EntitlementName result)
        {
            gax::GaxPreconditions.CheckNotNull(entitlementName, nameof(entitlementName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEntitlement.TryParseName(entitlementName, out resourceName))
            {
                result = FromProjectLocationEntitlement(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(entitlementName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EntitlementName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entitlementId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntitlementId = entitlementId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EntitlementName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        public EntitlementName(string projectId, string locationId, string entitlementId) : this(ResourceNameType.ProjectLocationEntitlement, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entitlementId: gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)))
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
        /// The <c>Entitlement</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EntitlementId { get; }

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
                case ResourceNameType.ProjectLocationEntitlement: return s_projectLocationEntitlement.Expand(ProjectId, LocationId, EntitlementId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EntitlementName);

        /// <inheritdoc/>
        public bool Equals(EntitlementName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EntitlementName a, EntitlementName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EntitlementName a, EntitlementName b) => !(a == b);
    }

    public partial class Entitlement
    {
        /// <summary>
        /// <see cref="gcov::EntitlementName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::EntitlementName EntitlementName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::EntitlementName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

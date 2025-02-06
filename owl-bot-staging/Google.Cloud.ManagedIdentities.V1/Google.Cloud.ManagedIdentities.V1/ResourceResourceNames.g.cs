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
using gcmv = Google.Cloud.ManagedIdentities.V1;
using sys = System;

namespace Google.Cloud.ManagedIdentities.V1
{
    /// <summary>Resource name for the <c>Domain</c> resource.</summary>
    public sealed partial class DomainName : gax::IResourceName, sys::IEquatable<DomainName>
    {
        /// <summary>The possible contents of <see cref="DomainName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/domains/{domain}</c>.
            /// </summary>
            ProjectLocationDomain = 1,
        }

        private static gax::PathTemplate s_projectLocationDomain = new gax::PathTemplate("projects/{project}/locations/{location}/domains/{domain}");

        /// <summary>Creates a <see cref="DomainName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DomainName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DomainName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DomainName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DomainName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/domains/{domain}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="domainId">The <c>Domain</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DomainName"/> constructed from the provided ids.</returns>
        public static DomainName FromProjectLocationDomain(string projectId, string locationId, string domainId) =>
            new DomainName(ResourceNameType.ProjectLocationDomain, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), domainId: gax::GaxPreconditions.CheckNotNullOrEmpty(domainId, nameof(domainId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DomainName"/> with pattern
        /// <c>projects/{project}/locations/{location}/domains/{domain}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="domainId">The <c>Domain</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DomainName"/> with pattern
        /// <c>projects/{project}/locations/{location}/domains/{domain}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string domainId) =>
            FormatProjectLocationDomain(projectId, locationId, domainId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DomainName"/> with pattern
        /// <c>projects/{project}/locations/{location}/domains/{domain}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="domainId">The <c>Domain</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DomainName"/> with pattern
        /// <c>projects/{project}/locations/{location}/domains/{domain}</c>.
        /// </returns>
        public static string FormatProjectLocationDomain(string projectId, string locationId, string domainId) =>
            s_projectLocationDomain.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(domainId, nameof(domainId)));

        /// <summary>Parses the given resource name string into a new <see cref="DomainName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/domains/{domain}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="domainName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DomainName"/> if successful.</returns>
        public static DomainName Parse(string domainName) => Parse(domainName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DomainName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/domains/{domain}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="domainName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DomainName"/> if successful.</returns>
        public static DomainName Parse(string domainName, bool allowUnparsed) =>
            TryParse(domainName, allowUnparsed, out DomainName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DomainName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/domains/{domain}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="domainName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DomainName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string domainName, out DomainName result) => TryParse(domainName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DomainName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/domains/{domain}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="domainName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DomainName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string domainName, bool allowUnparsed, out DomainName result)
        {
            gax::GaxPreconditions.CheckNotNull(domainName, nameof(domainName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDomain.TryParseName(domainName, out resourceName))
            {
                result = FromProjectLocationDomain(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(domainName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DomainName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string domainId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DomainId = domainId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DomainName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/domains/{domain}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="domainId">The <c>Domain</c> ID. Must not be <c>null</c> or empty.</param>
        public DomainName(string projectId, string locationId, string domainId) : this(ResourceNameType.ProjectLocationDomain, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), domainId: gax::GaxPreconditions.CheckNotNullOrEmpty(domainId, nameof(domainId)))
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
        /// The <c>Domain</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DomainId { get; }

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
                case ResourceNameType.ProjectLocationDomain: return s_projectLocationDomain.Expand(ProjectId, LocationId, DomainId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DomainName);

        /// <inheritdoc/>
        public bool Equals(DomainName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DomainName a, DomainName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DomainName a, DomainName b) => !(a == b);
    }

    public partial class Domain
    {
        /// <summary>
        /// <see cref="gcmv::DomainName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::DomainName DomainName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::DomainName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

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
using gcmv = Google.Cloud.Metastore.V1Beta;
using sys = System;

namespace Google.Cloud.Metastore.V1Beta
{
    /// <summary>Resource name for the <c>Federation</c> resource.</summary>
    public sealed partial class FederationName : gax::IResourceName, sys::IEquatable<FederationName>
    {
        /// <summary>The possible contents of <see cref="FederationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/federations/{federation}</c>.
            /// </summary>
            ProjectLocationFederation = 1,
        }

        private static gax::PathTemplate s_projectLocationFederation = new gax::PathTemplate("projects/{project}/locations/{location}/federations/{federation}");

        /// <summary>Creates a <see cref="FederationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FederationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FederationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FederationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FederationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/federations/{federation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="federationId">The <c>Federation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FederationName"/> constructed from the provided ids.</returns>
        public static FederationName FromProjectLocationFederation(string projectId, string locationId, string federationId) =>
            new FederationName(ResourceNameType.ProjectLocationFederation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), federationId: gax::GaxPreconditions.CheckNotNullOrEmpty(federationId, nameof(federationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FederationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/federations/{federation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="federationId">The <c>Federation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FederationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/federations/{federation}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string federationId) =>
            FormatProjectLocationFederation(projectId, locationId, federationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FederationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/federations/{federation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="federationId">The <c>Federation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FederationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/federations/{federation}</c>.
        /// </returns>
        public static string FormatProjectLocationFederation(string projectId, string locationId, string federationId) =>
            s_projectLocationFederation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(federationId, nameof(federationId)));

        /// <summary>Parses the given resource name string into a new <see cref="FederationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/federations/{federation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="federationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FederationName"/> if successful.</returns>
        public static FederationName Parse(string federationName) => Parse(federationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FederationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/federations/{federation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="federationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FederationName"/> if successful.</returns>
        public static FederationName Parse(string federationName, bool allowUnparsed) =>
            TryParse(federationName, allowUnparsed, out FederationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FederationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/federations/{federation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="federationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FederationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string federationName, out FederationName result) =>
            TryParse(federationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FederationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/federations/{federation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="federationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FederationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string federationName, bool allowUnparsed, out FederationName result)
        {
            gax::GaxPreconditions.CheckNotNull(federationName, nameof(federationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFederation.TryParseName(federationName, out resourceName))
            {
                result = FromProjectLocationFederation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(federationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FederationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string federationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FederationId = federationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FederationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/federations/{federation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="federationId">The <c>Federation</c> ID. Must not be <c>null</c> or empty.</param>
        public FederationName(string projectId, string locationId, string federationId) : this(ResourceNameType.ProjectLocationFederation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), federationId: gax::GaxPreconditions.CheckNotNullOrEmpty(federationId, nameof(federationId)))
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
        /// The <c>Federation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FederationId { get; }

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
                case ResourceNameType.ProjectLocationFederation: return s_projectLocationFederation.Expand(ProjectId, LocationId, FederationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FederationName);

        /// <inheritdoc/>
        public bool Equals(FederationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FederationName a, FederationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FederationName a, FederationName b) => !(a == b);
    }

    public partial class Federation
    {
        /// <summary>
        /// <see cref="gcmv::FederationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::FederationName FederationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::FederationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFederationsRequest
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

    public partial class GetFederationRequest
    {
        /// <summary>
        /// <see cref="gcmv::FederationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::FederationName FederationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::FederationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFederationRequest
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

    public partial class DeleteFederationRequest
    {
        /// <summary>
        /// <see cref="gcmv::FederationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::FederationName FederationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::FederationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcnv = Google.Cloud.NetworkSecurity.V1;
using sys = System;

namespace Google.Cloud.NetworkSecurity.V1
{
    /// <summary>Resource name for the <c>AddressGroup</c> resource.</summary>
    public sealed partial class AddressGroupName : gax::IResourceName, sys::IEquatable<AddressGroupName>
    {
        /// <summary>The possible contents of <see cref="AddressGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/addressGroups/{address_group}</c>
            /// .
            /// </summary>
            ProjectLocationAddressGroup = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/addressGroups/{address_group}</c>.
            /// </summary>
            OrganizationLocationAddressGroup = 2,
        }

        private static gax::PathTemplate s_projectLocationAddressGroup = new gax::PathTemplate("projects/{project}/locations/{location}/addressGroups/{address_group}");

        private static gax::PathTemplate s_organizationLocationAddressGroup = new gax::PathTemplate("organizations/{organization}/locations/{location}/addressGroups/{address_group}");

        /// <summary>Creates a <see cref="AddressGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AddressGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AddressGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AddressGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AddressGroupName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/addressGroups/{address_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="addressGroupId">The <c>AddressGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AddressGroupName"/> constructed from the provided ids.</returns>
        public static AddressGroupName FromProjectLocationAddressGroup(string projectId, string locationId, string addressGroupId) =>
            new AddressGroupName(ResourceNameType.ProjectLocationAddressGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), addressGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroupId, nameof(addressGroupId)));

        /// <summary>
        /// Creates a <see cref="AddressGroupName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/addressGroups/{address_group}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="addressGroupId">The <c>AddressGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AddressGroupName"/> constructed from the provided ids.</returns>
        public static AddressGroupName FromOrganizationLocationAddressGroup(string organizationId, string locationId, string addressGroupId) =>
            new AddressGroupName(ResourceNameType.OrganizationLocationAddressGroup, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), addressGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroupId, nameof(addressGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AddressGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/addressGroups/{address_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="addressGroupId">The <c>AddressGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AddressGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/addressGroups/{address_group}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string addressGroupId) =>
            FormatProjectLocationAddressGroup(projectId, locationId, addressGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AddressGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/addressGroups/{address_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="addressGroupId">The <c>AddressGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AddressGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/addressGroups/{address_group}</c>.
        /// </returns>
        public static string FormatProjectLocationAddressGroup(string projectId, string locationId, string addressGroupId) =>
            s_projectLocationAddressGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroupId, nameof(addressGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AddressGroupName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/addressGroups/{address_group}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="addressGroupId">The <c>AddressGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AddressGroupName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/addressGroups/{address_group}</c>.
        /// </returns>
        public static string FormatOrganizationLocationAddressGroup(string organizationId, string locationId, string addressGroupId) =>
            s_organizationLocationAddressGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroupId, nameof(addressGroupId)));

        /// <summary>Parses the given resource name string into a new <see cref="AddressGroupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/addressGroups/{address_group}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/addressGroups/{address_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="addressGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AddressGroupName"/> if successful.</returns>
        public static AddressGroupName Parse(string addressGroupName) => Parse(addressGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AddressGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/addressGroups/{address_group}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/addressGroups/{address_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="addressGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AddressGroupName"/> if successful.</returns>
        public static AddressGroupName Parse(string addressGroupName, bool allowUnparsed) =>
            TryParse(addressGroupName, allowUnparsed, out AddressGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AddressGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/addressGroups/{address_group}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/addressGroups/{address_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="addressGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AddressGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string addressGroupName, out AddressGroupName result) =>
            TryParse(addressGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AddressGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/addressGroups/{address_group}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/addressGroups/{address_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="addressGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AddressGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string addressGroupName, bool allowUnparsed, out AddressGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(addressGroupName, nameof(addressGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAddressGroup.TryParseName(addressGroupName, out resourceName))
            {
                result = FromProjectLocationAddressGroup(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationAddressGroup.TryParseName(addressGroupName, out resourceName))
            {
                result = FromOrganizationLocationAddressGroup(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(addressGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AddressGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string addressGroupId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AddressGroupId = addressGroupId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AddressGroupName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/addressGroups/{address_group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="addressGroupId">The <c>AddressGroup</c> ID. Must not be <c>null</c> or empty.</param>
        public AddressGroupName(string projectId, string locationId, string addressGroupId) : this(ResourceNameType.ProjectLocationAddressGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), addressGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroupId, nameof(addressGroupId)))
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
        /// The <c>AddressGroup</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string AddressGroupId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectLocationAddressGroup: return s_projectLocationAddressGroup.Expand(ProjectId, LocationId, AddressGroupId);
                case ResourceNameType.OrganizationLocationAddressGroup: return s_organizationLocationAddressGroup.Expand(OrganizationId, LocationId, AddressGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AddressGroupName);

        /// <inheritdoc/>
        public bool Equals(AddressGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AddressGroupName a, AddressGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AddressGroupName a, AddressGroupName b) => !(a == b);
    }

    public partial class AddressGroup
    {
        /// <summary>
        /// <see cref="gcnv::AddressGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::AddressGroupName AddressGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::AddressGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAddressGroupsRequest
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

    public partial class GetAddressGroupRequest
    {
        /// <summary>
        /// <see cref="gcnv::AddressGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::AddressGroupName AddressGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::AddressGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAddressGroupRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAddressGroupRequest
    {
        /// <summary>
        /// <see cref="gcnv::AddressGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::AddressGroupName AddressGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::AddressGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AddAddressGroupItemsRequest
    {
        /// <summary>
        /// <see cref="AddressGroupName"/>-typed view over the <see cref="AddressGroup"/> resource name property.
        /// </summary>
        public AddressGroupName AddressGroupAsAddressGroupName
        {
            get => string.IsNullOrEmpty(AddressGroup) ? null : AddressGroupName.Parse(AddressGroup, allowUnparsed: true);
            set => AddressGroup = value?.ToString() ?? "";
        }
    }

    public partial class RemoveAddressGroupItemsRequest
    {
        /// <summary>
        /// <see cref="AddressGroupName"/>-typed view over the <see cref="AddressGroup"/> resource name property.
        /// </summary>
        public AddressGroupName AddressGroupAsAddressGroupName
        {
            get => string.IsNullOrEmpty(AddressGroup) ? null : AddressGroupName.Parse(AddressGroup, allowUnparsed: true);
            set => AddressGroup = value?.ToString() ?? "";
        }
    }

    public partial class CloneAddressGroupItemsRequest
    {
        /// <summary>
        /// <see cref="AddressGroupName"/>-typed view over the <see cref="AddressGroup"/> resource name property.
        /// </summary>
        public AddressGroupName AddressGroupAsAddressGroupName
        {
            get => string.IsNullOrEmpty(AddressGroup) ? null : AddressGroupName.Parse(AddressGroup, allowUnparsed: true);
            set => AddressGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AddressGroupName"/>-typed view over the <see cref="SourceAddressGroup"/> resource name property.
        /// </summary>
        public AddressGroupName SourceAddressGroupAsAddressGroupName
        {
            get => string.IsNullOrEmpty(SourceAddressGroup) ? null : AddressGroupName.Parse(SourceAddressGroup, allowUnparsed: true);
            set => SourceAddressGroup = value?.ToString() ?? "";
        }
    }

    public partial class ListAddressGroupReferencesRequest
    {
        /// <summary>
        /// <see cref="AddressGroupName"/>-typed view over the <see cref="AddressGroup"/> resource name property.
        /// </summary>
        public AddressGroupName AddressGroupAsAddressGroupName
        {
            get => string.IsNullOrEmpty(AddressGroup) ? null : AddressGroupName.Parse(AddressGroup, allowUnparsed: true);
            set => AddressGroup = value?.ToString() ?? "";
        }
    }
}

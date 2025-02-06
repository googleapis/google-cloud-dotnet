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
using gcdv = Google.Cloud.Domains.V1;
using sys = System;

namespace Google.Cloud.Domains.V1
{
    /// <summary>Resource name for the <c>Registration</c> resource.</summary>
    public sealed partial class RegistrationName : gax::IResourceName, sys::IEquatable<RegistrationName>
    {
        /// <summary>The possible contents of <see cref="RegistrationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/registrations/{registration}</c>
            /// .
            /// </summary>
            ProjectLocationRegistration = 1,
        }

        private static gax::PathTemplate s_projectLocationRegistration = new gax::PathTemplate("projects/{project}/locations/{location}/registrations/{registration}");

        /// <summary>Creates a <see cref="RegistrationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RegistrationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RegistrationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RegistrationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RegistrationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/registrations/{registration}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="registrationId">The <c>Registration</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RegistrationName"/> constructed from the provided ids.</returns>
        public static RegistrationName FromProjectLocationRegistration(string projectId, string locationId, string registrationId) =>
            new RegistrationName(ResourceNameType.ProjectLocationRegistration, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), registrationId: gax::GaxPreconditions.CheckNotNullOrEmpty(registrationId, nameof(registrationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegistrationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/registrations/{registration}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="registrationId">The <c>Registration</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegistrationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/registrations/{registration}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string registrationId) =>
            FormatProjectLocationRegistration(projectId, locationId, registrationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegistrationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/registrations/{registration}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="registrationId">The <c>Registration</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegistrationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/registrations/{registration}</c>.
        /// </returns>
        public static string FormatProjectLocationRegistration(string projectId, string locationId, string registrationId) =>
            s_projectLocationRegistration.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(registrationId, nameof(registrationId)));

        /// <summary>Parses the given resource name string into a new <see cref="RegistrationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/registrations/{registration}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="registrationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RegistrationName"/> if successful.</returns>
        public static RegistrationName Parse(string registrationName) => Parse(registrationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RegistrationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/registrations/{registration}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="registrationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RegistrationName"/> if successful.</returns>
        public static RegistrationName Parse(string registrationName, bool allowUnparsed) =>
            TryParse(registrationName, allowUnparsed, out RegistrationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegistrationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/registrations/{registration}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="registrationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegistrationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string registrationName, out RegistrationName result) =>
            TryParse(registrationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegistrationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/registrations/{registration}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="registrationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegistrationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string registrationName, bool allowUnparsed, out RegistrationName result)
        {
            gax::GaxPreconditions.CheckNotNull(registrationName, nameof(registrationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRegistration.TryParseName(registrationName, out resourceName))
            {
                result = FromProjectLocationRegistration(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(registrationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RegistrationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string registrationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RegistrationId = registrationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RegistrationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/registrations/{registration}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="registrationId">The <c>Registration</c> ID. Must not be <c>null</c> or empty.</param>
        public RegistrationName(string projectId, string locationId, string registrationId) : this(ResourceNameType.ProjectLocationRegistration, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), registrationId: gax::GaxPreconditions.CheckNotNullOrEmpty(registrationId, nameof(registrationId)))
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
        /// The <c>Registration</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string RegistrationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRegistration: return s_projectLocationRegistration.Expand(ProjectId, LocationId, RegistrationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RegistrationName);

        /// <inheritdoc/>
        public bool Equals(RegistrationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RegistrationName a, RegistrationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RegistrationName a, RegistrationName b) => !(a == b);
    }

    public partial class Registration
    {
        /// <summary>
        /// <see cref="gcdv::RegistrationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RegistrationName RegistrationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RegistrationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SearchDomainsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Location"/> resource name property.
        /// </summary>
        public gagr::LocationName LocationAsLocationName
        {
            get => string.IsNullOrEmpty(Location) ? null : gagr::LocationName.Parse(Location, allowUnparsed: true);
            set => Location = value?.ToString() ?? "";
        }
    }

    public partial class RetrieveRegisterParametersRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Location"/> resource name property.
        /// </summary>
        public gagr::LocationName LocationAsLocationName
        {
            get => string.IsNullOrEmpty(Location) ? null : gagr::LocationName.Parse(Location, allowUnparsed: true);
            set => Location = value?.ToString() ?? "";
        }
    }

    public partial class RegisterDomainRequest
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

    public partial class RetrieveTransferParametersRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Location"/> resource name property.
        /// </summary>
        public gagr::LocationName LocationAsLocationName
        {
            get => string.IsNullOrEmpty(Location) ? null : gagr::LocationName.Parse(Location, allowUnparsed: true);
            set => Location = value?.ToString() ?? "";
        }
    }

    public partial class TransferDomainRequest
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

    public partial class ListRegistrationsRequest
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

    public partial class GetRegistrationRequest
    {
        /// <summary>
        /// <see cref="gcdv::RegistrationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RegistrationName RegistrationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RegistrationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ConfigureManagementSettingsRequest
    {
        /// <summary>
        /// <see cref="RegistrationName"/>-typed view over the <see cref="Registration"/> resource name property.
        /// </summary>
        public RegistrationName RegistrationAsRegistrationName
        {
            get => string.IsNullOrEmpty(Registration) ? null : RegistrationName.Parse(Registration, allowUnparsed: true);
            set => Registration = value?.ToString() ?? "";
        }
    }

    public partial class ConfigureDnsSettingsRequest
    {
        /// <summary>
        /// <see cref="RegistrationName"/>-typed view over the <see cref="Registration"/> resource name property.
        /// </summary>
        public RegistrationName RegistrationAsRegistrationName
        {
            get => string.IsNullOrEmpty(Registration) ? null : RegistrationName.Parse(Registration, allowUnparsed: true);
            set => Registration = value?.ToString() ?? "";
        }
    }

    public partial class ConfigureContactSettingsRequest
    {
        /// <summary>
        /// <see cref="RegistrationName"/>-typed view over the <see cref="Registration"/> resource name property.
        /// </summary>
        public RegistrationName RegistrationAsRegistrationName
        {
            get => string.IsNullOrEmpty(Registration) ? null : RegistrationName.Parse(Registration, allowUnparsed: true);
            set => Registration = value?.ToString() ?? "";
        }
    }

    public partial class ExportRegistrationRequest
    {
        /// <summary>
        /// <see cref="gcdv::RegistrationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RegistrationName RegistrationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RegistrationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteRegistrationRequest
    {
        /// <summary>
        /// <see cref="gcdv::RegistrationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RegistrationName RegistrationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RegistrationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RetrieveAuthorizationCodeRequest
    {
        /// <summary>
        /// <see cref="RegistrationName"/>-typed view over the <see cref="Registration"/> resource name property.
        /// </summary>
        public RegistrationName RegistrationAsRegistrationName
        {
            get => string.IsNullOrEmpty(Registration) ? null : RegistrationName.Parse(Registration, allowUnparsed: true);
            set => Registration = value?.ToString() ?? "";
        }
    }

    public partial class ResetAuthorizationCodeRequest
    {
        /// <summary>
        /// <see cref="RegistrationName"/>-typed view over the <see cref="Registration"/> resource name property.
        /// </summary>
        public RegistrationName RegistrationAsRegistrationName
        {
            get => string.IsNullOrEmpty(Registration) ? null : RegistrationName.Parse(Registration, allowUnparsed: true);
            set => Registration = value?.ToString() ?? "";
        }
    }
}

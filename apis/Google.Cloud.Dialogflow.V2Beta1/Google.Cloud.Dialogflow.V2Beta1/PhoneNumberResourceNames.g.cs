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
using gcdv = Google.Cloud.Dialogflow.V2Beta1;
using sys = System;

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Resource name for the <c>PhoneNumber</c> resource.</summary>
    public sealed partial class PhoneNumberName : gax::IResourceName, sys::IEquatable<PhoneNumberName>
    {
        /// <summary>The possible contents of <see cref="PhoneNumberName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/phoneNumbers/{phone_number}</c>.</summary>
            ProjectPhoneNumber = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/phoneNumbers/{phone_number}</c>.
            /// </summary>
            ProjectLocationPhoneNumber = 2,
        }

        private static gax::PathTemplate s_projectPhoneNumber = new gax::PathTemplate("projects/{project}/phoneNumbers/{phone_number}");

        private static gax::PathTemplate s_projectLocationPhoneNumber = new gax::PathTemplate("projects/{project}/locations/{location}/phoneNumbers/{phone_number}");

        /// <summary>Creates a <see cref="PhoneNumberName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PhoneNumberName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PhoneNumberName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PhoneNumberName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PhoneNumberName"/> with the pattern <c>projects/{project}/phoneNumbers/{phone_number}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phoneNumberId">The <c>PhoneNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PhoneNumberName"/> constructed from the provided ids.</returns>
        public static PhoneNumberName FromProjectPhoneNumber(string projectId, string phoneNumberId) =>
            new PhoneNumberName(ResourceNameType.ProjectPhoneNumber, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), phoneNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(phoneNumberId, nameof(phoneNumberId)));

        /// <summary>
        /// Creates a <see cref="PhoneNumberName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/phoneNumbers/{phone_number}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phoneNumberId">The <c>PhoneNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PhoneNumberName"/> constructed from the provided ids.</returns>
        public static PhoneNumberName FromProjectLocationPhoneNumber(string projectId, string locationId, string phoneNumberId) =>
            new PhoneNumberName(ResourceNameType.ProjectLocationPhoneNumber, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), phoneNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(phoneNumberId, nameof(phoneNumberId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PhoneNumberName"/> with pattern
        /// <c>projects/{project}/phoneNumbers/{phone_number}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phoneNumberId">The <c>PhoneNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PhoneNumberName"/> with pattern
        /// <c>projects/{project}/phoneNumbers/{phone_number}</c>.
        /// </returns>
        public static string Format(string projectId, string phoneNumberId) =>
            FormatProjectPhoneNumber(projectId, phoneNumberId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PhoneNumberName"/> with pattern
        /// <c>projects/{project}/phoneNumbers/{phone_number}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phoneNumberId">The <c>PhoneNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PhoneNumberName"/> with pattern
        /// <c>projects/{project}/phoneNumbers/{phone_number}</c>.
        /// </returns>
        public static string FormatProjectPhoneNumber(string projectId, string phoneNumberId) =>
            s_projectPhoneNumber.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(phoneNumberId, nameof(phoneNumberId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PhoneNumberName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phoneNumbers/{phone_number}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phoneNumberId">The <c>PhoneNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PhoneNumberName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phoneNumbers/{phone_number}</c>.
        /// </returns>
        public static string FormatProjectLocationPhoneNumber(string projectId, string locationId, string phoneNumberId) =>
            s_projectLocationPhoneNumber.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(phoneNumberId, nameof(phoneNumberId)));

        /// <summary>Parses the given resource name string into a new <see cref="PhoneNumberName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/phoneNumbers/{phone_number}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phoneNumbers/{phone_number}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="phoneNumberName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PhoneNumberName"/> if successful.</returns>
        public static PhoneNumberName Parse(string phoneNumberName) => Parse(phoneNumberName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PhoneNumberName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/phoneNumbers/{phone_number}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phoneNumbers/{phone_number}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="phoneNumberName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PhoneNumberName"/> if successful.</returns>
        public static PhoneNumberName Parse(string phoneNumberName, bool allowUnparsed) =>
            TryParse(phoneNumberName, allowUnparsed, out PhoneNumberName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PhoneNumberName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/phoneNumbers/{phone_number}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phoneNumbers/{phone_number}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="phoneNumberName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PhoneNumberName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string phoneNumberName, out PhoneNumberName result) =>
            TryParse(phoneNumberName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PhoneNumberName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/phoneNumbers/{phone_number}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phoneNumbers/{phone_number}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="phoneNumberName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PhoneNumberName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string phoneNumberName, bool allowUnparsed, out PhoneNumberName result)
        {
            gax::GaxPreconditions.CheckNotNull(phoneNumberName, nameof(phoneNumberName));
            gax::TemplatedResourceName resourceName;
            if (s_projectPhoneNumber.TryParseName(phoneNumberName, out resourceName))
            {
                result = FromProjectPhoneNumber(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationPhoneNumber.TryParseName(phoneNumberName, out resourceName))
            {
                result = FromProjectLocationPhoneNumber(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(phoneNumberName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PhoneNumberName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string phoneNumberId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PhoneNumberId = phoneNumberId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PhoneNumberName"/> class from the component parts of pattern
        /// <c>projects/{project}/phoneNumbers/{phone_number}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phoneNumberId">The <c>PhoneNumber</c> ID. Must not be <c>null</c> or empty.</param>
        public PhoneNumberName(string projectId, string phoneNumberId) : this(ResourceNameType.ProjectPhoneNumber, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), phoneNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(phoneNumberId, nameof(phoneNumberId)))
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
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>PhoneNumber</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string PhoneNumberId { get; }

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
                case ResourceNameType.ProjectPhoneNumber: return s_projectPhoneNumber.Expand(ProjectId, PhoneNumberId);
                case ResourceNameType.ProjectLocationPhoneNumber: return s_projectLocationPhoneNumber.Expand(ProjectId, LocationId, PhoneNumberId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PhoneNumberName);

        /// <inheritdoc/>
        public bool Equals(PhoneNumberName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PhoneNumberName a, PhoneNumberName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PhoneNumberName a, PhoneNumberName b) => !(a == b);
    }

    public partial class PhoneNumber
    {
        /// <summary>
        /// <see cref="gcdv::PhoneNumberName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PhoneNumberName PhoneNumberName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PhoneNumberName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeletePhoneNumberRequest
    {
        /// <summary>
        /// <see cref="gcdv::PhoneNumberName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PhoneNumberName PhoneNumberName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PhoneNumberName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UndeletePhoneNumberRequest
    {
        /// <summary>
        /// <see cref="gcdv::PhoneNumberName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PhoneNumberName PhoneNumberName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PhoneNumberName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPhoneNumbersRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }
}

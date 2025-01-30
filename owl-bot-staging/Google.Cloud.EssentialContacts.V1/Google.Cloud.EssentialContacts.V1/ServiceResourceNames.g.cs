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
using gcev = Google.Cloud.EssentialContacts.V1;
using sys = System;

namespace Google.Cloud.EssentialContacts.V1
{
    /// <summary>Resource name for the <c>Contact</c> resource.</summary>
    public sealed partial class ContactName : gax::IResourceName, sys::IEquatable<ContactName>
    {
        /// <summary>The possible contents of <see cref="ContactName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/contacts/{contact}</c>.</summary>
            ProjectContact = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/contacts/{contact}</c>.</summary>
            FolderContact = 2,

            /// <summary>A resource name with pattern <c>organizations/{organization}/contacts/{contact}</c>.</summary>
            OrganizationContact = 3,
        }

        private static gax::PathTemplate s_projectContact = new gax::PathTemplate("projects/{project}/contacts/{contact}");

        private static gax::PathTemplate s_folderContact = new gax::PathTemplate("folders/{folder}/contacts/{contact}");

        private static gax::PathTemplate s_organizationContact = new gax::PathTemplate("organizations/{organization}/contacts/{contact}");

        /// <summary>Creates a <see cref="ContactName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ContactName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ContactName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ContactName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ContactName"/> with the pattern <c>projects/{project}/contacts/{contact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contactId">The <c>Contact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ContactName"/> constructed from the provided ids.</returns>
        public static ContactName FromProjectContact(string projectId, string contactId) =>
            new ContactName(ResourceNameType.ProjectContact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), contactId: gax::GaxPreconditions.CheckNotNullOrEmpty(contactId, nameof(contactId)));

        /// <summary>
        /// Creates a <see cref="ContactName"/> with the pattern <c>folders/{folder}/contacts/{contact}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contactId">The <c>Contact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ContactName"/> constructed from the provided ids.</returns>
        public static ContactName FromFolderContact(string folderId, string contactId) =>
            new ContactName(ResourceNameType.FolderContact, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), contactId: gax::GaxPreconditions.CheckNotNullOrEmpty(contactId, nameof(contactId)));

        /// <summary>
        /// Creates a <see cref="ContactName"/> with the pattern <c>organizations/{organization}/contacts/{contact}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contactId">The <c>Contact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ContactName"/> constructed from the provided ids.</returns>
        public static ContactName FromOrganizationContact(string organizationId, string contactId) =>
            new ContactName(ResourceNameType.OrganizationContact, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), contactId: gax::GaxPreconditions.CheckNotNullOrEmpty(contactId, nameof(contactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContactName"/> with pattern
        /// <c>projects/{project}/contacts/{contact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contactId">The <c>Contact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContactName"/> with pattern
        /// <c>projects/{project}/contacts/{contact}</c>.
        /// </returns>
        public static string Format(string projectId, string contactId) => FormatProjectContact(projectId, contactId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContactName"/> with pattern
        /// <c>projects/{project}/contacts/{contact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contactId">The <c>Contact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContactName"/> with pattern
        /// <c>projects/{project}/contacts/{contact}</c>.
        /// </returns>
        public static string FormatProjectContact(string projectId, string contactId) =>
            s_projectContact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(contactId, nameof(contactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContactName"/> with pattern
        /// <c>folders/{folder}/contacts/{contact}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contactId">The <c>Contact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContactName"/> with pattern
        /// <c>folders/{folder}/contacts/{contact}</c>.
        /// </returns>
        public static string FormatFolderContact(string folderId, string contactId) =>
            s_folderContact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(contactId, nameof(contactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContactName"/> with pattern
        /// <c>organizations/{organization}/contacts/{contact}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contactId">The <c>Contact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContactName"/> with pattern
        /// <c>organizations/{organization}/contacts/{contact}</c>.
        /// </returns>
        public static string FormatOrganizationContact(string organizationId, string contactId) =>
            s_organizationContact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(contactId, nameof(contactId)));

        /// <summary>Parses the given resource name string into a new <see cref="ContactName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/contacts/{contact}</c></description></item>
        /// <item><description><c>folders/{folder}/contacts/{contact}</c></description></item>
        /// <item><description><c>organizations/{organization}/contacts/{contact}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="contactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ContactName"/> if successful.</returns>
        public static ContactName Parse(string contactName) => Parse(contactName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ContactName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/contacts/{contact}</c></description></item>
        /// <item><description><c>folders/{folder}/contacts/{contact}</c></description></item>
        /// <item><description><c>organizations/{organization}/contacts/{contact}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ContactName"/> if successful.</returns>
        public static ContactName Parse(string contactName, bool allowUnparsed) =>
            TryParse(contactName, allowUnparsed, out ContactName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContactName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/contacts/{contact}</c></description></item>
        /// <item><description><c>folders/{folder}/contacts/{contact}</c></description></item>
        /// <item><description><c>organizations/{organization}/contacts/{contact}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="contactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contactName, out ContactName result) => TryParse(contactName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContactName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/contacts/{contact}</c></description></item>
        /// <item><description><c>folders/{folder}/contacts/{contact}</c></description></item>
        /// <item><description><c>organizations/{organization}/contacts/{contact}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contactName, bool allowUnparsed, out ContactName result)
        {
            gax::GaxPreconditions.CheckNotNull(contactName, nameof(contactName));
            gax::TemplatedResourceName resourceName;
            if (s_projectContact.TryParseName(contactName, out resourceName))
            {
                result = FromProjectContact(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderContact.TryParseName(contactName, out resourceName))
            {
                result = FromFolderContact(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationContact.TryParseName(contactName, out resourceName))
            {
                result = FromOrganizationContact(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(contactName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ContactName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string contactId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ContactId = contactId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ContactName"/> class from the component parts of pattern
        /// <c>projects/{project}/contacts/{contact}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contactId">The <c>Contact</c> ID. Must not be <c>null</c> or empty.</param>
        public ContactName(string projectId, string contactId) : this(ResourceNameType.ProjectContact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), contactId: gax::GaxPreconditions.CheckNotNullOrEmpty(contactId, nameof(contactId)))
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
        /// The <c>Contact</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ContactId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

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
                case ResourceNameType.ProjectContact: return s_projectContact.Expand(ProjectId, ContactId);
                case ResourceNameType.FolderContact: return s_folderContact.Expand(FolderId, ContactId);
                case ResourceNameType.OrganizationContact: return s_organizationContact.Expand(OrganizationId, ContactId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ContactName);

        /// <inheritdoc/>
        public bool Equals(ContactName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ContactName a, ContactName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ContactName a, ContactName b) => !(a == b);
    }

    public partial class Contact
    {
        /// <summary>
        /// <see cref="gcev::ContactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::ContactName ContactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::ContactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListContactsRequest
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
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::FolderName ParentAsFolderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::FolderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetContactRequest
    {
        /// <summary>
        /// <see cref="gcev::ContactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::ContactName ContactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::ContactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteContactRequest
    {
        /// <summary>
        /// <see cref="gcev::ContactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::ContactName ContactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::ContactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateContactRequest
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
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::FolderName ParentAsFolderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::FolderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ComputeContactsRequest
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
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::FolderName ParentAsFolderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::FolderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class SendTestMessageRequest
    {
        /// <summary>
        /// <see cref="ContactName"/>-typed view over the <see cref="Contacts"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ContactName> ContactsAsContactNames
        {
            get => new gax::ResourceNameList<ContactName>(Contacts, s => string.IsNullOrEmpty(s) ? null : ContactName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Resource"/> resource name property.
        /// </summary>
        public gagr::ProjectName ResourceAsProjectName
        {
            get => string.IsNullOrEmpty(Resource) ? null : gagr::ProjectName.Parse(Resource, allowUnparsed: true);
            set => Resource = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Resource"/> resource name property.
        /// </summary>
        public gagr::FolderName ResourceAsFolderName
        {
            get => string.IsNullOrEmpty(Resource) ? null : gagr::FolderName.Parse(Resource, allowUnparsed: true);
            set => Resource = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Resource"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ResourceAsOrganizationName
        {
            get => string.IsNullOrEmpty(Resource) ? null : gagr::OrganizationName.Parse(Resource, allowUnparsed: true);
            set => Resource = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Resource"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Resource))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Resource, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::FolderName.TryParse(Resource, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::OrganizationName.TryParse(Resource, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                return gax::UnparsedResourceName.Parse(Resource);
            }
            set => Resource = value?.ToString() ?? "";
        }
    }
}

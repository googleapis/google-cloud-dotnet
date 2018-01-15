// Copyright 2017, Google LLC All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using System;
using System.Linq;

namespace Google.Cloud.ResourceManager.V2
{
    /// <summary>
    /// Resource name for the 'folder' resource.
    /// </summary>
    public sealed partial class FolderName : IResourceName, IEquatable<FolderName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("folders/{folder}");

        /// <summary>
        /// Parses the given folder resource name in string form into a new
        /// <see cref="FolderName"/> instance.
        /// </summary>
        /// <param name="folderName">The folder resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FolderName"/> if successful.</returns>
        public static FolderName Parse(string folderName)
        {
            GaxPreconditions.CheckNotNull(folderName, nameof(folderName));
            TemplatedResourceName resourceName = s_template.ParseName(folderName);
            return new FolderName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given folder resource name in string form into a new
        /// <see cref="FolderName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="folderName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="folderName">The folder resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FolderName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderName, out FolderName result)
        {
            GaxPreconditions.CheckNotNull(folderName, nameof(folderName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(folderName, out resourceName))
            {
                result = new FolderName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="FolderName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="folderId">The folder ID. Must not be <c>null</c>.</param>
        public FolderName(string folderId)
        {
            FolderId = GaxPreconditions.CheckNotNull(folderId, nameof(folderId));
        }

        /// <summary>
        /// The folder ID. Never <c>null</c>.
        /// </summary>
        public string FolderId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(FolderId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FolderName);

        /// <inheritdoc />
        public bool Equals(FolderName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FolderName a, FolderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FolderName a, FolderName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'organization' resource.
    /// </summary>
    public sealed partial class OrganizationName : IResourceName, IEquatable<OrganizationName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("organizations/{org_id}");

        /// <summary>
        /// Parses the given organization resource name in string form into a new
        /// <see cref="OrganizationName"/> instance.
        /// </summary>
        /// <param name="organizationName">The organization resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationName"/> if successful.</returns>
        public static OrganizationName Parse(string organizationName)
        {
            GaxPreconditions.CheckNotNull(organizationName, nameof(organizationName));
            TemplatedResourceName resourceName = s_template.ParseName(organizationName);
            return new OrganizationName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given organization resource name in string form into a new
        /// <see cref="OrganizationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="organizationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationName">The organization resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationName, out OrganizationName result)
        {
            GaxPreconditions.CheckNotNull(organizationName, nameof(organizationName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationName, out resourceName))
            {
                result = new OrganizationName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="orgId">The org ID. Must not be <c>null</c>.</param>
        public OrganizationName(string orgId)
        {
            OrgId = GaxPreconditions.CheckNotNull(orgId, nameof(orgId));
        }

        /// <summary>
        /// The org ID. Never <c>null</c>.
        /// </summary>
        public string OrgId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrgId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationName);

        /// <inheritdoc />
        public bool Equals(OrganizationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationName a, OrganizationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationName a, OrganizationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>OrganizationName: A resource of type 'organization'.</description></item>
    /// <item><description>FolderName: A resource of type 'folder'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class ParentNameOneof : IResourceName, IEquatable<ParentNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="ParentNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'organization'.
            /// </summary>
            OrganizationName = 1,

            /// <summary>
            /// A resource of type 'folder'.
            /// </summary>
            FolderName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="ParentNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationName: A resource of type 'organization'.</description></item>
        /// <item><description>FolderName: A resource of type 'folder'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>; otherwise will throw an
        /// <see cref="ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="ParentNameOneof"/> if successful.</returns>
        public static ParentNameOneof Parse(string name, bool allowUnknown)
        {
            ParentNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="ParentNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationName: A resource of type 'organization'.</description></item>
        /// <item><description>FolderName: A resource of type 'folder'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ParentNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out ParentNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            OrganizationName organizationName;
            if (OrganizationName.TryParse(name, out organizationName))
            {
                result = new ParentNameOneof(OneofType.OrganizationName, organizationName);
                return true;
            }
            FolderName folderName;
            if (FolderName.TryParse(name, out folderName))
            {
                result = new ParentNameOneof(OneofType.FolderName, folderName);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new ParentNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="ParentNameOneof"/> from the provided <see cref="OrganizationName"/>
        /// </summary>
        /// <param name="organizationName">The <see cref="OrganizationName"/> to be contained within
        /// the returned <see cref="ParentNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="ParentNameOneof"/>, containing <paramref name="organizationName"/>.</returns>
        public static ParentNameOneof From(OrganizationName organizationName) => new ParentNameOneof(OneofType.OrganizationName, organizationName);

        /// <summary>
        /// Construct a new instance of <see cref="ParentNameOneof"/> from the provided <see cref="FolderName"/>
        /// </summary>
        /// <param name="folderName">The <see cref="FolderName"/> to be contained within
        /// the returned <see cref="ParentNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="ParentNameOneof"/>, containing <paramref name="folderName"/>.</returns>
        public static ParentNameOneof From(FolderName folderName) => new ParentNameOneof(OneofType.FolderName, folderName);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.OrganizationName: return name is OrganizationName;
                case OneofType.FolderName: return name is FolderName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ParentNameOneof"/> resource name class
        /// from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public ParentNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="OrganizationName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="OrganizationName"/>.
        /// </remarks>
        public OrganizationName OrganizationName => CheckAndReturn<OrganizationName>(OneofType.OrganizationName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="FolderName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="FolderName"/>.
        /// </remarks>
        public FolderName FolderName => CheckAndReturn<FolderName>(OneofType.FolderName);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ParentNameOneof);

        /// <inheritdoc />
        public bool Equals(ParentNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ParentNameOneof a, ParentNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ParentNameOneof a, ParentNameOneof b) => !(a == b);
    }


    public partial class CreateFolderRequest
    {
        /// <summary>
        /// <see cref="ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.ResourceManager.V2.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteFolderRequest
    {
        /// <summary>
        /// <see cref="FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public FolderName FolderName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.ResourceManager.V2.FolderName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Folder
    {
        /// <summary>
        /// <see cref="FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public FolderName FolderName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.ResourceManager.V2.FolderName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.ResourceManager.V2.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetFolderRequest
    {
        /// <summary>
        /// <see cref="FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public FolderName FolderName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.ResourceManager.V2.FolderName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListFoldersRequest
    {
        /// <summary>
        /// <see cref="ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.ResourceManager.V2.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class MoveFolderRequest
    {
        /// <summary>
        /// <see cref="FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public FolderName FolderName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.ResourceManager.V2.FolderName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="ParentNameOneof"/>-typed view over the <see cref="DestinationParent"/> resource name property.
        /// </summary>
        public ParentNameOneof DestinationParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(DestinationParent) ? null : Google.Cloud.ResourceManager.V2.ParentNameOneof.Parse(DestinationParent, true); }
            set { DestinationParent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UndeleteFolderRequest
    {
        /// <summary>
        /// <see cref="FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public FolderName FolderName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.ResourceManager.V2.FolderName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}
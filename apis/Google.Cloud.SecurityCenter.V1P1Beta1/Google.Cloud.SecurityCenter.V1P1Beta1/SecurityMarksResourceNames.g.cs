// Copyright 2020 Google LLC
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

using gax = Google.Api.Gax;
using gcsv = Google.Cloud.SecurityCenter.V1P1Beta1;
using sys = System;

namespace Google.Cloud.SecurityCenter.V1P1Beta1
{
    /// <summary>Resource name for the <c>OrganizationAsset</c> resource.</summary>
    public sealed partial class OrganizationAssetName : gax::IResourceName, sys::IEquatable<OrganizationAssetName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/assets/{asset}/securityMarks");

        /// <summary>
        /// Parses the given <c>OrganizationAsset</c> resource name in string form into a new
        /// <see cref="OrganizationAssetName"/> instance.
        /// </summary>
        /// <param name="organizationAssetName">
        /// The <c>OrganizationAsset</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="OrganizationAssetName"/> if successful.</returns>
        public static OrganizationAssetName Parse(string organizationAssetName)
        {
            gax::GaxPreconditions.CheckNotNull(organizationAssetName, nameof(organizationAssetName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(organizationAssetName);
            return new OrganizationAssetName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="OrganizationAssetName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if
        /// <paramref name="organizationAssetName"/> is <c>null</c>, as this would usually indicate a programming error
        /// rather than a data error.
        /// </remarks>
        /// <param name="organizationAssetName">
        /// The <c>OrganizationAsset</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationAssetName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationAssetName, out OrganizationAssetName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationAssetName, nameof(organizationAssetName));
            if (s_template.TryParseName(organizationAssetName, out gax::TemplatedResourceName resourceName))
            {
                result = new OrganizationAssetName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Formats the IDs into the string representation of the <see cref="OrganizationAssetName"/>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="OrganizationAssetName"/>.</returns>
        public static string Format(string organizationId, string assetId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(assetId, nameof(assetId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationAssetName"/> resource name class from its component
        /// parts.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c>.</param>
        public OrganizationAssetName(string organizationId, string assetId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            AssetId = gax::GaxPreconditions.CheckNotNull(assetId, nameof(assetId));
        }

        /// <summary>The <c>Organization</c> ID. Never <c>null</c>.</summary>
        public string OrganizationId { get; }

        /// <summary>The <c>Asset</c> ID. Never <c>null</c>.</summary>
        public string AssetId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(OrganizationId, AssetId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrganizationAssetName);

        /// <inheritdoc/>
        public bool Equals(OrganizationAssetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(OrganizationAssetName a, OrganizationAssetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(OrganizationAssetName a, OrganizationAssetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>OrganizationSourceFinding</c> resource.</summary>
    public sealed partial class OrganizationSourceFindingName : gax::IResourceName, sys::IEquatable<OrganizationSourceFindingName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/sources/{source}/findings/{finding}/securityMarks");

        /// <summary>
        /// Parses the given <c>OrganizationSourceFinding</c> resource name in string form into a new
        /// <see cref="OrganizationSourceFindingName"/> instance.
        /// </summary>
        /// <param name="organizationSourceFindingName">
        /// The <c>OrganizationSourceFinding</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="OrganizationSourceFindingName"/> if successful.</returns>
        public static OrganizationSourceFindingName Parse(string organizationSourceFindingName)
        {
            gax::GaxPreconditions.CheckNotNull(organizationSourceFindingName, nameof(organizationSourceFindingName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(organizationSourceFindingName);
            return new OrganizationSourceFindingName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new
        /// <see cref="OrganizationSourceFindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if
        /// <paramref name="organizationSourceFindingName"/> is <c>null</c>, as this would usually indicate a
        /// programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationSourceFindingName">
        /// The <c>OrganizationSourceFinding</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationSourceFindingName"/>, or <c>null</c> if parsing
        /// fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationSourceFindingName, out OrganizationSourceFindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationSourceFindingName, nameof(organizationSourceFindingName));
            if (s_template.TryParseName(organizationSourceFindingName, out gax::TemplatedResourceName resourceName))
            {
                result = new OrganizationSourceFindingName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Formats the IDs into the string representation of the <see cref="OrganizationSourceFindingName"/>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c>.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="OrganizationSourceFindingName"/>.</returns>
        public static string Format(string organizationId, string sourceId, string findingId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNull(findingId, nameof(findingId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationSourceFindingName"/> resource name class from its
        /// component parts.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c>.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c>.</param>
        public OrganizationSourceFindingName(string organizationId, string sourceId, string findingId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            SourceId = gax::GaxPreconditions.CheckNotNull(sourceId, nameof(sourceId));
            FindingId = gax::GaxPreconditions.CheckNotNull(findingId, nameof(findingId));
        }

        /// <summary>The <c>Organization</c> ID. Never <c>null</c>.</summary>
        public string OrganizationId { get; }

        /// <summary>The <c>Source</c> ID. Never <c>null</c>.</summary>
        public string SourceId { get; }

        /// <summary>The <c>Finding</c> ID. Never <c>null</c>.</summary>
        public string FindingId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(OrganizationId, SourceId, FindingId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrganizationSourceFindingName);

        /// <inheritdoc/>
        public bool Equals(OrganizationSourceFindingName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(OrganizationSourceFindingName a, OrganizationSourceFindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(OrganizationSourceFindingName a, OrganizationSourceFindingName b) => !(a == b);
    }

    /// <summary>Resource name which will contain one of a choice of resource names.</summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>OrganizationAssetName: A resource of type 'organization'.</description></item>
    /// <item><description>OrganizationSourceFindingName: A resource of type 'source'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class SecurityMarksNameOneOf : gax::IResourceName, sys::IEquatable<SecurityMarksNameOneOf>
    {
        /// <summary>The possible contents of <see cref="SecurityMarksNameOneOf"/>.</summary>
        public enum OneofType
        {
            /// <summary>A resource of an unknown type.</summary>
            Unknown = 0,

            /// <summary>A resource of type 'organization'</summary>
            OrganizationAssetName = 1,

            /// <summary>A resource of type 'source'</summary>
            OrganizationSourceFindingName = 2
        }

        /// <summary>
        /// Parses the given <c>SecurityMarks</c> resource name in string form into a new
        /// <see cref="SecurityMarksNameOneOf"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationAssetName: A resource of type 'organization'.</description></item>
        /// <item><description>OrganizationSourceFindingName: A resource of type 'source'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">
        /// If <c>true</c>, will successfully parse an unknown resource name into an
        /// <see cref="gax::UnknownResourceName"/>; otherwise will throw an<see cref="sys::ArgumentException"/> if an
        /// unknown resource name is given.
        /// </param>
        /// <returns>The parsed <see cref="SecurityMarksNameOneOf"/> if successful.</returns>
        public static SecurityMarksNameOneOf Parse(string name, bool allowUnknown)
        {
            if (TryParse(name, allowUnknown, out SecurityMarksNameOneOf result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="SecurityMarksNameOneOf"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationAssetName: A resource of type 'organization'.</description></item>
        /// <item><description>OrganizationSourceFindingName: A resource of type 'source'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">
        /// If <c>true</c>, will successfully parse an unknown resource name into an
        /// <see cref="gax::UnknownResourceName"/>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityMarksNameOneOf"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed succssfully; othrewise <c>false</c></returns>
        public static bool TryParse(string name, bool allowUnknown, out SecurityMarksNameOneOf result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (OrganizationAssetName.TryParse(name, out OrganizationAssetName organizationAssetName))
            {
                result = new SecurityMarksNameOneOf(OneofType.OrganizationAssetName, organizationAssetName);
                return true;
            }
            if (OrganizationSourceFindingName.TryParse(name, out OrganizationSourceFindingName organizationSourceFindingName))
            {
                result = new SecurityMarksNameOneOf(OneofType.OrganizationSourceFindingName, organizationSourceFindingName);
                return true;
            }
            if (allowUnknown)
            {
                if (gax::UnknownResourceName.TryParse(name, out gax::UnknownResourceName unknownResourceName))
                {
                    result = new SecurityMarksNameOneOf(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Constructs a new instance of <see cref="SecurityMarksNameOneOf"/> from the provided
        /// <see cref="OrganizationAssetName"/>.
        /// </summary>
        /// <param name="organizationAssetName">
        /// The <see cref="OrganizationAssetName"/> to be contained within the returned
        /// <see cref="SecurityMarksNameOneOf"/>. Must not be <c>null</c>
        /// </param>
        /// <returns>
        /// A new <see cref="SecurityMarksNameOneOf"/>, containing <paramref name="organizationAssetName"/>.
        /// </returns>
        public static SecurityMarksNameOneOf From(OrganizationAssetName organizationAssetName) =>
            new SecurityMarksNameOneOf(OneofType.OrganizationAssetName, organizationAssetName);

        /// <summary>
        /// Constructs a new instance of <see cref="SecurityMarksNameOneOf"/> from the provided
        /// <see cref="OrganizationSourceFindingName"/>.
        /// </summary>
        /// <param name="organizationSourceFindingName">
        /// The <see cref="OrganizationSourceFindingName"/> to be contained within the returned
        /// <see cref="SecurityMarksNameOneOf"/>. Must not be <c>null</c>
        /// </param>
        /// <returns>
        /// A new <see cref="SecurityMarksNameOneOf"/>, containing <paramref name="organizationSourceFindingName"/>.
        /// </returns>
        public static SecurityMarksNameOneOf From(OrganizationSourceFindingName organizationSourceFindingName) =>
            new SecurityMarksNameOneOf(OneofType.OrganizationSourceFindingName, organizationSourceFindingName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true;
                case OneofType.OrganizationAssetName: return name is OrganizationAssetName;
                case OneofType.OrganizationSourceFindingName: return name is OrganizationSourceFindingName;
                default: return false;
            }
        }

        public SecurityMarksNameOneOf(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>The <see cref="OneofType"/> of the Name contained in this instance.</summary>
        public OneofType Type { get; }

        /// <summary>The <see cref="gax::IResourceName"/> contained in this instance.</summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="OrganizationAssetName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown is this does not contain an instance of
        /// <see cref="OrganizationAssetName"/>.
        /// </remarks>
        public OrganizationAssetName OrganizationAssetName => CheckAndReturn<OrganizationAssetName>(OneofType.OrganizationAssetName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="OrganizationSourceFindingName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown is this does not contain an instance of
        /// <see cref="OrganizationSourceFindingName"/>.
        /// </remarks>
        public OrganizationSourceFindingName OrganizationSourceFindingName => CheckAndReturn<OrganizationSourceFindingName>(OneofType.OrganizationSourceFindingName);

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

        /// <inheritdoc/>
        public override string ToString() => this.Name.ToString();

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecurityMarksNameOneOf);

        /// <inheritdoc/>
        public bool Equals(SecurityMarksNameOneOf other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SecurityMarksNameOneOf a, SecurityMarksNameOneOf b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SecurityMarksNameOneOf a, SecurityMarksNameOneOf b) => !(a == b);
    }

    public partial class SecurityMarks
    {
        /// <summary>
        /// <see cref="gcsv::SecurityMarksNameOneOf"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecurityMarksNameOneOf SecurityMarksNameOneOf
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecurityMarksNameOneOf.Parse(Name, true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

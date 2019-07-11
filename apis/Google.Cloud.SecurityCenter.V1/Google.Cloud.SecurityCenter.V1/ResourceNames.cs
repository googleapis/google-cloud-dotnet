// Copyright 2019 Google LLC
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
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.SecurityCenter.V1
{
    /// <summary>
    /// Resource name for the 'asset' resource.
    /// </summary>
    public sealed partial class AssetName : gax::IResourceName, sys::IEquatable<AssetName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/assets/{asset}");

        /// <summary>
        /// Parses the given asset resource name in string form into a new
        /// <see cref="AssetName"/> instance.
        /// </summary>
        /// <param name="assetName">The asset resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssetName"/> if successful.</returns>
        public static AssetName Parse(string assetName)
        {
            gax::GaxPreconditions.CheckNotNull(assetName, nameof(assetName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(assetName);
            return new AssetName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given asset resource name in string form into a new
        /// <see cref="AssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="assetName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="assetName">The asset resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AssetName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetName, out AssetName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetName, nameof(assetName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(assetName, out resourceName))
            {
                result = new AssetName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="AssetName"/>.</summary>
        /// <param name="organizationId">The <c>organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="assetId">The <c>asset</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="AssetName"/>.</returns>
        public static string Format(string organizationId, string assetId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(assetId, nameof(assetId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="AssetName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="assetId">The asset ID. Must not be <c>null</c>.</param>
        public AssetName(string organizationId, string assetId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            AssetId = gax::GaxPreconditions.CheckNotNull(assetId, nameof(assetId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The asset ID. Never <c>null</c>.
        /// </summary>
        public string AssetId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, AssetId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AssetName);

        /// <inheritdoc />
        public bool Equals(AssetName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AssetName a, AssetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AssetName a, AssetName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'asset_security_marks' resource.
    /// </summary>
    public sealed partial class AssetSecurityMarksName : gax::IResourceName, sys::IEquatable<AssetSecurityMarksName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/assets/{asset}/securityMarks");

        /// <summary>
        /// Parses the given asset_security_marks resource name in string form into a new
        /// <see cref="AssetSecurityMarksName"/> instance.
        /// </summary>
        /// <param name="assetSecurityMarksName">The asset_security_marks resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssetSecurityMarksName"/> if successful.</returns>
        public static AssetSecurityMarksName Parse(string assetSecurityMarksName)
        {
            gax::GaxPreconditions.CheckNotNull(assetSecurityMarksName, nameof(assetSecurityMarksName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(assetSecurityMarksName);
            return new AssetSecurityMarksName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given asset_security_marks resource name in string form into a new
        /// <see cref="AssetSecurityMarksName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="assetSecurityMarksName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="assetSecurityMarksName">The asset_security_marks resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AssetSecurityMarksName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetSecurityMarksName, out AssetSecurityMarksName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetSecurityMarksName, nameof(assetSecurityMarksName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(assetSecurityMarksName, out resourceName))
            {
                result = new AssetSecurityMarksName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="AssetSecurityMarksName"/>.</summary>
        /// <param name="organizationId">The <c>organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="assetId">The <c>asset</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="AssetSecurityMarksName"/>.</returns>
        public static string Format(string organizationId, string assetId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(assetId, nameof(assetId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="AssetSecurityMarksName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="assetId">The asset ID. Must not be <c>null</c>.</param>
        public AssetSecurityMarksName(string organizationId, string assetId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            AssetId = gax::GaxPreconditions.CheckNotNull(assetId, nameof(assetId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The asset ID. Never <c>null</c>.
        /// </summary>
        public string AssetId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, AssetId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AssetSecurityMarksName);

        /// <inheritdoc />
        public bool Equals(AssetSecurityMarksName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AssetSecurityMarksName a, AssetSecurityMarksName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AssetSecurityMarksName a, AssetSecurityMarksName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'finding' resource.
    /// </summary>
    public sealed partial class FindingName : gax::IResourceName, sys::IEquatable<FindingName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/sources/{source}/findings/{finding}");

        /// <summary>
        /// Parses the given finding resource name in string form into a new
        /// <see cref="FindingName"/> instance.
        /// </summary>
        /// <param name="findingName">The finding resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FindingName"/> if successful.</returns>
        public static FindingName Parse(string findingName)
        {
            gax::GaxPreconditions.CheckNotNull(findingName, nameof(findingName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(findingName);
            return new FindingName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given finding resource name in string form into a new
        /// <see cref="FindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="findingName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="findingName">The finding resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FindingName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingName, out FindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(findingName, nameof(findingName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(findingName, out resourceName))
            {
                result = new FindingName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="FindingName"/>.</summary>
        /// <param name="organizationId">The <c>organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sourceId">The <c>source</c> ID. Must not be <c>null</c>.</param>
        /// <param name="findingId">The <c>finding</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="FindingName"/>.</returns>
        public static string Format(string organizationId, string sourceId, string findingId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNull(findingId, nameof(findingId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="FindingName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="sourceId">The source ID. Must not be <c>null</c>.</param>
        /// <param name="findingId">The finding ID. Must not be <c>null</c>.</param>
        public FindingName(string organizationId, string sourceId, string findingId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            SourceId = gax::GaxPreconditions.CheckNotNull(sourceId, nameof(sourceId));
            FindingId = gax::GaxPreconditions.CheckNotNull(findingId, nameof(findingId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The source ID. Never <c>null</c>.
        /// </summary>
        public string SourceId { get; }

        /// <summary>
        /// The finding ID. Never <c>null</c>.
        /// </summary>
        public string FindingId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, SourceId, FindingId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FindingName);

        /// <inheritdoc />
        public bool Equals(FindingName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FindingName a, FindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FindingName a, FindingName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'finding_security_marks' resource.
    /// </summary>
    public sealed partial class FindingSecurityMarksName : gax::IResourceName, sys::IEquatable<FindingSecurityMarksName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/sources/{source}/findings/{finding}/securityMarks");

        /// <summary>
        /// Parses the given finding_security_marks resource name in string form into a new
        /// <see cref="FindingSecurityMarksName"/> instance.
        /// </summary>
        /// <param name="findingSecurityMarksName">The finding_security_marks resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FindingSecurityMarksName"/> if successful.</returns>
        public static FindingSecurityMarksName Parse(string findingSecurityMarksName)
        {
            gax::GaxPreconditions.CheckNotNull(findingSecurityMarksName, nameof(findingSecurityMarksName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(findingSecurityMarksName);
            return new FindingSecurityMarksName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given finding_security_marks resource name in string form into a new
        /// <see cref="FindingSecurityMarksName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="findingSecurityMarksName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="findingSecurityMarksName">The finding_security_marks resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FindingSecurityMarksName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingSecurityMarksName, out FindingSecurityMarksName result)
        {
            gax::GaxPreconditions.CheckNotNull(findingSecurityMarksName, nameof(findingSecurityMarksName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(findingSecurityMarksName, out resourceName))
            {
                result = new FindingSecurityMarksName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="FindingSecurityMarksName"/>.</summary>
        /// <param name="organizationId">The <c>organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sourceId">The <c>source</c> ID. Must not be <c>null</c>.</param>
        /// <param name="findingId">The <c>finding</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="FindingSecurityMarksName"/>.</returns>
        public static string Format(string organizationId, string sourceId, string findingId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNull(findingId, nameof(findingId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="FindingSecurityMarksName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="sourceId">The source ID. Must not be <c>null</c>.</param>
        /// <param name="findingId">The finding ID. Must not be <c>null</c>.</param>
        public FindingSecurityMarksName(string organizationId, string sourceId, string findingId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            SourceId = gax::GaxPreconditions.CheckNotNull(sourceId, nameof(sourceId));
            FindingId = gax::GaxPreconditions.CheckNotNull(findingId, nameof(findingId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The source ID. Never <c>null</c>.
        /// </summary>
        public string SourceId { get; }

        /// <summary>
        /// The finding ID. Never <c>null</c>.
        /// </summary>
        public string FindingId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, SourceId, FindingId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FindingSecurityMarksName);

        /// <inheritdoc />
        public bool Equals(FindingSecurityMarksName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FindingSecurityMarksName a, FindingSecurityMarksName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FindingSecurityMarksName a, FindingSecurityMarksName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'organization' resource.
    /// </summary>
    public sealed partial class OrganizationName : gax::IResourceName, sys::IEquatable<OrganizationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}");

        /// <summary>
        /// Parses the given organization resource name in string form into a new
        /// <see cref="OrganizationName"/> instance.
        /// </summary>
        /// <param name="organizationName">The organization resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationName"/> if successful.</returns>
        public static OrganizationName Parse(string organizationName)
        {
            gax::GaxPreconditions.CheckNotNull(organizationName, nameof(organizationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(organizationName);
            return new OrganizationName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given organization resource name in string form into a new
        /// <see cref="OrganizationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="organizationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationName">The organization resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationName, out OrganizationName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationName, nameof(organizationName));
            gax::TemplatedResourceName resourceName;
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

        /// <summary>Formats the IDs into the string representation of the <see cref="OrganizationName"/>.</summary>
        /// <param name="organizationId">The <c>organization</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="OrganizationName"/>.</returns>
        public static string Format(string organizationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        public OrganizationName(string organizationId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId);

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
    /// Resource name for the 'organization_settings' resource.
    /// </summary>
    public sealed partial class OrganizationSettingsName : gax::IResourceName, sys::IEquatable<OrganizationSettingsName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/organizationSettings");

        /// <summary>
        /// Parses the given organization_settings resource name in string form into a new
        /// <see cref="OrganizationSettingsName"/> instance.
        /// </summary>
        /// <param name="organizationSettingsName">The organization_settings resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationSettingsName"/> if successful.</returns>
        public static OrganizationSettingsName Parse(string organizationSettingsName)
        {
            gax::GaxPreconditions.CheckNotNull(organizationSettingsName, nameof(organizationSettingsName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(organizationSettingsName);
            return new OrganizationSettingsName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given organization_settings resource name in string form into a new
        /// <see cref="OrganizationSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="organizationSettingsName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationSettingsName">The organization_settings resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationSettingsName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationSettingsName, out OrganizationSettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationSettingsName, nameof(organizationSettingsName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationSettingsName, out resourceName))
            {
                result = new OrganizationSettingsName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="OrganizationSettingsName"/>.</summary>
        /// <param name="organizationId">The <c>organization</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="OrganizationSettingsName"/>.</returns>
        public static string Format(string organizationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationSettingsName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        public OrganizationSettingsName(string organizationId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationSettingsName);

        /// <inheritdoc />
        public bool Equals(OrganizationSettingsName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationSettingsName a, OrganizationSettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationSettingsName a, OrganizationSettingsName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'organization_sources' resource.
    /// </summary>
    public sealed partial class OrganizationSourcesName : gax::IResourceName, sys::IEquatable<OrganizationSourcesName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/sources/-");

        /// <summary>
        /// Parses the given organization_sources resource name in string form into a new
        /// <see cref="OrganizationSourcesName"/> instance.
        /// </summary>
        /// <param name="organizationSourcesName">The organization_sources resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationSourcesName"/> if successful.</returns>
        public static OrganizationSourcesName Parse(string organizationSourcesName)
        {
            gax::GaxPreconditions.CheckNotNull(organizationSourcesName, nameof(organizationSourcesName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(organizationSourcesName);
            return new OrganizationSourcesName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given organization_sources resource name in string form into a new
        /// <see cref="OrganizationSourcesName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="organizationSourcesName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationSourcesName">The organization_sources resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationSourcesName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationSourcesName, out OrganizationSourcesName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationSourcesName, nameof(organizationSourcesName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationSourcesName, out resourceName))
            {
                result = new OrganizationSourcesName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="OrganizationSourcesName"/>.</summary>
        /// <param name="organizationId">The <c>organization</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="OrganizationSourcesName"/>.</returns>
        public static string Format(string organizationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationSourcesName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        public OrganizationSourcesName(string organizationId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationSourcesName);

        /// <inheritdoc />
        public bool Equals(OrganizationSourcesName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationSourcesName a, OrganizationSourcesName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationSourcesName a, OrganizationSourcesName b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>AssetSecurityMarksName: A resource of type 'asset_security_marks'.</description></item>
    /// <item><description>FindingSecurityMarksName: A resource of type 'finding_security_marks'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class SecuritymarksNameOneof : gax::IResourceName, sys::IEquatable<SecuritymarksNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="SecuritymarksNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'asset_security_marks'.
            /// </summary>
            AssetSecurityMarksName = 1,

            /// <summary>
            /// A resource of type 'finding_security_marks'.
            /// </summary>
            FindingSecurityMarksName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="SecuritymarksNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>AssetSecurityMarksName: A resource of type 'asset_security_marks'.</description></item>
        /// <item><description>FindingSecurityMarksName: A resource of type 'finding_security_marks'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="SecuritymarksNameOneof"/> if successful.</returns>
        public static SecuritymarksNameOneof Parse(string name, bool allowUnknown)
        {
            SecuritymarksNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="SecuritymarksNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>AssetSecurityMarksName: A resource of type 'asset_security_marks'.</description></item>
        /// <item><description>FindingSecurityMarksName: A resource of type 'finding_security_marks'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SecuritymarksNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out SecuritymarksNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            AssetSecurityMarksName assetSecurityMarksName;
            if (AssetSecurityMarksName.TryParse(name, out assetSecurityMarksName))
            {
                result = new SecuritymarksNameOneof(OneofType.AssetSecurityMarksName, assetSecurityMarksName);
                return true;
            }
            FindingSecurityMarksName findingSecurityMarksName;
            if (FindingSecurityMarksName.TryParse(name, out findingSecurityMarksName))
            {
                result = new SecuritymarksNameOneof(OneofType.FindingSecurityMarksName, findingSecurityMarksName);
                return true;
            }
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new SecuritymarksNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="SecuritymarksNameOneof"/> from the provided <see cref="AssetSecurityMarksName"/>
        /// </summary>
        /// <param name="assetSecurityMarksName">The <see cref="AssetSecurityMarksName"/> to be contained within
        /// the returned <see cref="SecuritymarksNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="SecuritymarksNameOneof"/>, containing <paramref name="assetSecurityMarksName"/>.</returns>
        public static SecuritymarksNameOneof From(AssetSecurityMarksName assetSecurityMarksName) => new SecuritymarksNameOneof(OneofType.AssetSecurityMarksName, assetSecurityMarksName);

        /// <summary>
        /// Construct a new instance of <see cref="SecuritymarksNameOneof"/> from the provided <see cref="FindingSecurityMarksName"/>
        /// </summary>
        /// <param name="findingSecurityMarksName">The <see cref="FindingSecurityMarksName"/> to be contained within
        /// the returned <see cref="SecuritymarksNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="SecuritymarksNameOneof"/>, containing <paramref name="findingSecurityMarksName"/>.</returns>
        public static SecuritymarksNameOneof From(FindingSecurityMarksName findingSecurityMarksName) => new SecuritymarksNameOneof(OneofType.FindingSecurityMarksName, findingSecurityMarksName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.AssetSecurityMarksName: return name is AssetSecurityMarksName;
                case OneofType.FindingSecurityMarksName: return name is FindingSecurityMarksName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="SecuritymarksNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public SecuritymarksNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
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
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="AssetSecurityMarksName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="AssetSecurityMarksName"/>.
        /// </remarks>
        public AssetSecurityMarksName AssetSecurityMarksName => CheckAndReturn<AssetSecurityMarksName>(OneofType.AssetSecurityMarksName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="FindingSecurityMarksName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="FindingSecurityMarksName"/>.
        /// </remarks>
        public FindingSecurityMarksName FindingSecurityMarksName => CheckAndReturn<FindingSecurityMarksName>(OneofType.FindingSecurityMarksName);

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SecuritymarksNameOneof);

        /// <inheritdoc />
        public bool Equals(SecuritymarksNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SecuritymarksNameOneof a, SecuritymarksNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SecuritymarksNameOneof a, SecuritymarksNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'source' resource.
    /// </summary>
    public sealed partial class SourceName : gax::IResourceName, sys::IEquatable<SourceName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/sources/{source}");

        /// <summary>
        /// Parses the given source resource name in string form into a new
        /// <see cref="SourceName"/> instance.
        /// </summary>
        /// <param name="sourceName">The source resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SourceName"/> if successful.</returns>
        public static SourceName Parse(string sourceName)
        {
            gax::GaxPreconditions.CheckNotNull(sourceName, nameof(sourceName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(sourceName);
            return new SourceName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given source resource name in string form into a new
        /// <see cref="SourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="sourceName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="sourceName">The source resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SourceName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sourceName, out SourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(sourceName, nameof(sourceName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(sourceName, out resourceName))
            {
                result = new SourceName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="SourceName"/>.</summary>
        /// <param name="organizationId">The <c>organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sourceId">The <c>source</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="SourceName"/>.</returns>
        public static string Format(string organizationId, string sourceId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(sourceId, nameof(sourceId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="SourceName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="sourceId">The source ID. Must not be <c>null</c>.</param>
        public SourceName(string organizationId, string sourceId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            SourceId = gax::GaxPreconditions.CheckNotNull(sourceId, nameof(sourceId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The source ID. Never <c>null</c>.
        /// </summary>
        public string SourceId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, SourceId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SourceName);

        /// <inheritdoc />
        public bool Equals(SourceName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SourceName a, SourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SourceName a, SourceName b) => !(a == b);
    }


    public partial class Asset
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.AssetName AssetName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.SecurityCenter.V1.AssetName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateFindingRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.SourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.SourceName ParentAsSourceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.SecurityCenter.V1.SourceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateSourceRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.SecurityCenter.V1.OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Finding
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.FindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.FindingName FindingName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.SecurityCenter.V1.FindingName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetOrganizationSettingsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.OrganizationSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.OrganizationSettingsName OrganizationSettingsName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.SecurityCenter.V1.OrganizationSettingsName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetSourceRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.SourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.SourceName SourceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.SecurityCenter.V1.SourceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GroupAssetsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.SecurityCenter.V1.OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GroupFindingsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.SourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.SourceName ParentAsSourceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.SecurityCenter.V1.SourceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListAssetsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.SecurityCenter.V1.OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListFindingsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.SourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.SourceName ParentAsSourceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.SecurityCenter.V1.SourceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListSourcesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.SecurityCenter.V1.OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class RunAssetDiscoveryRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.SecurityCenter.V1.OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class SetFindingStateRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.FindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.FindingName FindingName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.SecurityCenter.V1.FindingName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Source
    {
        /// <summary>
        /// <see cref="Google.Cloud.SecurityCenter.V1.SourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.SecurityCenter.V1.SourceName SourceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.SecurityCenter.V1.SourceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}
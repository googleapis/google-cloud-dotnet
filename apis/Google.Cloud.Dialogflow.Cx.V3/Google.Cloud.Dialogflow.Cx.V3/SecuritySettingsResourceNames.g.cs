// Copyright 2021 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using gcdcv = Google.Cloud.Dialogflow.Cx.V3;
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Resource name for the <c>SecuritySettings</c> resource.</summary>
    public sealed partial class SecuritySettingsName : gax::IResourceName, sys::IEquatable<SecuritySettingsName>
    {
        /// <summary>The possible contents of <see cref="SecuritySettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>.
            /// </summary>
            ProjectLocationSecuritySettings = 1,
        }

        private static gax::PathTemplate s_projectLocationSecuritySettings = new gax::PathTemplate("projects/{project}/locations/{location}/securitySettings/{security_settings}");

        /// <summary>Creates a <see cref="SecuritySettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecuritySettingsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecuritySettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecuritySettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecuritySettingsName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securitySettingsId">The <c>SecuritySettings</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecuritySettingsName"/> constructed from the provided ids.</returns>
        public static SecuritySettingsName FromProjectLocationSecuritySettings(string projectId, string locationId, string securitySettingsId) =>
            new SecuritySettingsName(ResourceNameType.ProjectLocationSecuritySettings, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securitySettingsId: gax::GaxPreconditions.CheckNotNullOrEmpty(securitySettingsId, nameof(securitySettingsId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecuritySettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securitySettingsId">The <c>SecuritySettings</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecuritySettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string securitySettingsId) =>
            FormatProjectLocationSecuritySettings(projectId, locationId, securitySettingsId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecuritySettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securitySettingsId">The <c>SecuritySettings</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecuritySettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>.
        /// </returns>
        public static string FormatProjectLocationSecuritySettings(string projectId, string locationId, string securitySettingsId) =>
            s_projectLocationSecuritySettings.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(securitySettingsId, nameof(securitySettingsId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecuritySettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securitySettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SecuritySettingsName"/> if successful.</returns>
        public static SecuritySettingsName Parse(string securitySettingsName) => Parse(securitySettingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecuritySettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securitySettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecuritySettingsName"/> if successful.</returns>
        public static SecuritySettingsName Parse(string securitySettingsName, bool allowUnparsed) =>
            TryParse(securitySettingsName, allowUnparsed, out SecuritySettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecuritySettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securitySettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecuritySettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securitySettingsName, out SecuritySettingsName result) =>
            TryParse(securitySettingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecuritySettingsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securitySettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecuritySettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securitySettingsName, bool allowUnparsed, out SecuritySettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(securitySettingsName, nameof(securitySettingsName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSecuritySettings.TryParseName(securitySettingsName, out resourceName))
            {
                result = FromProjectLocationSecuritySettings(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(securitySettingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecuritySettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string securitySettingsId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SecuritySettingsId = securitySettingsId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecuritySettingsName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securitySettingsId">The <c>SecuritySettings</c> ID. Must not be <c>null</c> or empty.</param>
        public SecuritySettingsName(string projectId, string locationId, string securitySettingsId) : this(ResourceNameType.ProjectLocationSecuritySettings, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securitySettingsId: gax::GaxPreconditions.CheckNotNullOrEmpty(securitySettingsId, nameof(securitySettingsId)))
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
        /// The <c>SecuritySettings</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SecuritySettingsId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSecuritySettings: return s_projectLocationSecuritySettings.Expand(ProjectId, LocationId, SecuritySettingsId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecuritySettingsName);

        /// <inheritdoc/>
        public bool Equals(SecuritySettingsName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SecuritySettingsName a, SecuritySettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SecuritySettingsName a, SecuritySettingsName b) => !(a == b);
    }

    public partial class GetSecuritySettingsRequest
    {
        /// <summary>
        /// <see cref="gcdcv::SecuritySettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::SecuritySettingsName SecuritySettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::SecuritySettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSecuritySettingsRequest
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

    public partial class CreateSecuritySettingsRequest
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

    public partial class DeleteSecuritySettingsRequest
    {
        /// <summary>
        /// <see cref="gcdcv::SecuritySettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::SecuritySettingsName SecuritySettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::SecuritySettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SecuritySettings
    {
        /// <summary>
        /// <see cref="gcdcv::SecuritySettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::SecuritySettingsName SecuritySettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::SecuritySettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

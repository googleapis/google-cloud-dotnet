// Copyright 2024 Google LLC
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecuritySettingsName a, SecuritySettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SecuritySettingsName a, SecuritySettingsName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InspectTemplate</c> resource.</summary>
    public sealed partial class InspectTemplateName : gax::IResourceName, sys::IEquatable<InspectTemplateName>
    {
        /// <summary>The possible contents of <see cref="InspectTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>.
            /// </summary>
            OrganizationLocationInspectTemplate = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>.
            /// </summary>
            ProjectLocationInspectTemplate = 2,
        }

        private static gax::PathTemplate s_organizationLocationInspectTemplate = new gax::PathTemplate("organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}");

        private static gax::PathTemplate s_projectLocationInspectTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/inspectTemplates/{inspect_template}");

        /// <summary>Creates a <see cref="InspectTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InspectTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InspectTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InspectTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InspectTemplateName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InspectTemplateName"/> constructed from the provided ids.</returns>
        public static InspectTemplateName FromOrganizationLocationInspectTemplate(string organizationId, string locationId, string inspectTemplateId) =>
            new InspectTemplateName(ResourceNameType.OrganizationLocationInspectTemplate, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), inspectTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Creates a <see cref="InspectTemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InspectTemplateName"/> constructed from the provided ids.</returns>
        public static InspectTemplateName FromProjectLocationInspectTemplate(string projectId, string locationId, string inspectTemplateId) =>
            new InspectTemplateName(ResourceNameType.ProjectLocationInspectTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), inspectTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId, string inspectTemplateId) =>
            FormatOrganizationLocationInspectTemplate(organizationId, locationId, inspectTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </returns>
        public static string FormatOrganizationLocationInspectTemplate(string organizationId, string locationId, string inspectTemplateId) =>
            s_organizationLocationInspectTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </returns>
        public static string FormatProjectLocationInspectTemplate(string projectId, string locationId, string inspectTemplateId) =>
            s_projectLocationInspectTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InspectTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="inspectTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InspectTemplateName"/> if successful.</returns>
        public static InspectTemplateName Parse(string inspectTemplateName) => Parse(inspectTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InspectTemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="inspectTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InspectTemplateName"/> if successful.</returns>
        public static InspectTemplateName Parse(string inspectTemplateName, bool allowUnparsed) =>
            TryParse(inspectTemplateName, allowUnparsed, out InspectTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InspectTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="inspectTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InspectTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string inspectTemplateName, out InspectTemplateName result) =>
            TryParse(inspectTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InspectTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="inspectTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InspectTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string inspectTemplateName, bool allowUnparsed, out InspectTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(inspectTemplateName, nameof(inspectTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationInspectTemplate.TryParseName(inspectTemplateName, out resourceName))
            {
                result = FromOrganizationLocationInspectTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationInspectTemplate.TryParseName(inspectTemplateName, out resourceName))
            {
                result = FromProjectLocationInspectTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(inspectTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InspectTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string inspectTemplateId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InspectTemplateId = inspectTemplateId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InspectTemplateName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        public InspectTemplateName(string organizationId, string locationId, string inspectTemplateId) : this(ResourceNameType.OrganizationLocationInspectTemplate, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), inspectTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)))
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
        /// The <c>InspectTemplate</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string InspectTemplateId { get; }

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
                case ResourceNameType.OrganizationLocationInspectTemplate: return s_organizationLocationInspectTemplate.Expand(OrganizationId, LocationId, InspectTemplateId);
                case ResourceNameType.ProjectLocationInspectTemplate: return s_projectLocationInspectTemplate.Expand(ProjectId, LocationId, InspectTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InspectTemplateName);

        /// <inheritdoc/>
        public bool Equals(InspectTemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InspectTemplateName a, InspectTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InspectTemplateName a, InspectTemplateName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DeidentifyTemplate</c> resource.</summary>
    public sealed partial class DeidentifyTemplateName : gax::IResourceName, sys::IEquatable<DeidentifyTemplateName>
    {
        /// <summary>The possible contents of <see cref="DeidentifyTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
            /// </summary>
            OrganizationLocationDeidentifyTemplate = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
            /// </summary>
            ProjectLocationDeidentifyTemplate = 2,
        }

        private static gax::PathTemplate s_organizationLocationDeidentifyTemplate = new gax::PathTemplate("organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}");

        private static gax::PathTemplate s_projectLocationDeidentifyTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}");

        /// <summary>Creates a <see cref="DeidentifyTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DeidentifyTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DeidentifyTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DeidentifyTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DeidentifyTemplateName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="DeidentifyTemplateName"/> constructed from the provided ids.</returns>
        public static DeidentifyTemplateName FromOrganizationLocationDeidentifyTemplate(string organizationId, string locationId, string deidentifyTemplateId) =>
            new DeidentifyTemplateName(ResourceNameType.OrganizationLocationDeidentifyTemplate, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deidentifyTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Creates a <see cref="DeidentifyTemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="DeidentifyTemplateName"/> constructed from the provided ids.</returns>
        public static DeidentifyTemplateName FromProjectLocationDeidentifyTemplate(string projectId, string locationId, string deidentifyTemplateId) =>
            new DeidentifyTemplateName(ResourceNameType.ProjectLocationDeidentifyTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deidentifyTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId, string deidentifyTemplateId) =>
            FormatOrganizationLocationDeidentifyTemplate(organizationId, locationId, deidentifyTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </returns>
        public static string FormatOrganizationLocationDeidentifyTemplate(string organizationId, string locationId, string deidentifyTemplateId) =>
            s_organizationLocationDeidentifyTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </returns>
        public static string FormatProjectLocationDeidentifyTemplate(string projectId, string locationId, string deidentifyTemplateId) =>
            s_projectLocationDeidentifyTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeidentifyTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deidentifyTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DeidentifyTemplateName"/> if successful.</returns>
        public static DeidentifyTemplateName Parse(string deidentifyTemplateName) => Parse(deidentifyTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeidentifyTemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deidentifyTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DeidentifyTemplateName"/> if successful.</returns>
        public static DeidentifyTemplateName Parse(string deidentifyTemplateName, bool allowUnparsed) =>
            TryParse(deidentifyTemplateName, allowUnparsed, out DeidentifyTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeidentifyTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deidentifyTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeidentifyTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deidentifyTemplateName, out DeidentifyTemplateName result) =>
            TryParse(deidentifyTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeidentifyTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deidentifyTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeidentifyTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deidentifyTemplateName, bool allowUnparsed, out DeidentifyTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(deidentifyTemplateName, nameof(deidentifyTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationDeidentifyTemplate.TryParseName(deidentifyTemplateName, out resourceName))
            {
                result = FromOrganizationLocationDeidentifyTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationDeidentifyTemplate.TryParseName(deidentifyTemplateName, out resourceName))
            {
                result = FromProjectLocationDeidentifyTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(deidentifyTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DeidentifyTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deidentifyTemplateId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeidentifyTemplateId = deidentifyTemplateId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DeidentifyTemplateName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DeidentifyTemplateName(string organizationId, string locationId, string deidentifyTemplateId) : this(ResourceNameType.OrganizationLocationDeidentifyTemplate, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deidentifyTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)))
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
        /// The <c>DeidentifyTemplate</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string DeidentifyTemplateId { get; }

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
                case ResourceNameType.OrganizationLocationDeidentifyTemplate: return s_organizationLocationDeidentifyTemplate.Expand(OrganizationId, LocationId, DeidentifyTemplateId);
                case ResourceNameType.ProjectLocationDeidentifyTemplate: return s_projectLocationDeidentifyTemplate.Expand(ProjectId, LocationId, DeidentifyTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DeidentifyTemplateName);

        /// <inheritdoc/>
        public bool Equals(DeidentifyTemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DeidentifyTemplateName a, DeidentifyTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DeidentifyTemplateName a, DeidentifyTemplateName b) => !(a == b);
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

        /// <summary>
        /// <see cref="InspectTemplateName"/>-typed view over the <see cref="InspectTemplate"/> resource name property.
        /// </summary>
        public InspectTemplateName InspectTemplateAsInspectTemplateName
        {
            get => string.IsNullOrEmpty(InspectTemplate) ? null : InspectTemplateName.Parse(InspectTemplate, allowUnparsed: true);
            set => InspectTemplate = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DeidentifyTemplateName"/>-typed view over the <see cref="DeidentifyTemplate"/> resource name
        /// property.
        /// </summary>
        public DeidentifyTemplateName DeidentifyTemplateAsDeidentifyTemplateName
        {
            get => string.IsNullOrEmpty(DeidentifyTemplate) ? null : DeidentifyTemplateName.Parse(DeidentifyTemplate, allowUnparsed: true);
            set => DeidentifyTemplate = value?.ToString() ?? "";
        }
    }
}

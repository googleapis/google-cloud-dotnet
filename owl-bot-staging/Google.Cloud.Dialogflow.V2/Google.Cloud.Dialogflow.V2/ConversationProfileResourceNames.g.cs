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
using gcdv = Google.Cloud.Dialogflow.V2;
using sys = System;

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Resource name for the <c>ConversationProfile</c> resource.</summary>
    public sealed partial class ConversationProfileName : gax::IResourceName, sys::IEquatable<ConversationProfileName>
    {
        /// <summary>The possible contents of <see cref="ConversationProfileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/conversationProfiles/{conversation_profile}</c>.
            /// </summary>
            ProjectConversationProfile = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>.
            /// </summary>
            ProjectLocationConversationProfile = 2,
        }

        private static gax::PathTemplate s_projectConversationProfile = new gax::PathTemplate("projects/{project}/conversationProfiles/{conversation_profile}");

        private static gax::PathTemplate s_projectLocationConversationProfile = new gax::PathTemplate("projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}");

        /// <summary>Creates a <see cref="ConversationProfileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConversationProfileName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConversationProfileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConversationProfileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConversationProfileName"/> with the pattern
        /// <c>projects/{project}/conversationProfiles/{conversation_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationProfileId">
        /// The <c>ConversationProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ConversationProfileName"/> constructed from the provided ids.
        /// </returns>
        public static ConversationProfileName FromProjectConversationProfile(string projectId, string conversationProfileId) =>
            new ConversationProfileName(ResourceNameType.ProjectConversationProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), conversationProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfileId, nameof(conversationProfileId)));

        /// <summary>
        /// Creates a <see cref="ConversationProfileName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationProfileId">
        /// The <c>ConversationProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ConversationProfileName"/> constructed from the provided ids.
        /// </returns>
        public static ConversationProfileName FromProjectLocationConversationProfile(string projectId, string locationId, string conversationProfileId) =>
            new ConversationProfileName(ResourceNameType.ProjectLocationConversationProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfileId, nameof(conversationProfileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationProfileName"/> with pattern
        /// <c>projects/{project}/conversationProfiles/{conversation_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationProfileId">
        /// The <c>ConversationProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ConversationProfileName"/> with pattern
        /// <c>projects/{project}/conversationProfiles/{conversation_profile}</c>.
        /// </returns>
        public static string Format(string projectId, string conversationProfileId) =>
            FormatProjectConversationProfile(projectId, conversationProfileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationProfileName"/> with pattern
        /// <c>projects/{project}/conversationProfiles/{conversation_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationProfileId">
        /// The <c>ConversationProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ConversationProfileName"/> with pattern
        /// <c>projects/{project}/conversationProfiles/{conversation_profile}</c>.
        /// </returns>
        public static string FormatProjectConversationProfile(string projectId, string conversationProfileId) =>
            s_projectConversationProfile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfileId, nameof(conversationProfileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationProfileId">
        /// The <c>ConversationProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ConversationProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>.
        /// </returns>
        public static string FormatProjectLocationConversationProfile(string projectId, string locationId, string conversationProfileId) =>
            s_projectLocationConversationProfile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfileId, nameof(conversationProfileId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversationProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/conversationProfiles/{conversation_profile}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversationProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConversationProfileName"/> if successful.</returns>
        public static ConversationProfileName Parse(string conversationProfileName) => Parse(conversationProfileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversationProfileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/conversationProfiles/{conversation_profile}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConversationProfileName"/> if successful.</returns>
        public static ConversationProfileName Parse(string conversationProfileName, bool allowUnparsed) =>
            TryParse(conversationProfileName, allowUnparsed, out ConversationProfileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/conversationProfiles/{conversation_profile}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversationProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationProfileName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationProfileName, out ConversationProfileName result) =>
            TryParse(conversationProfileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationProfileName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/conversationProfiles/{conversation_profile}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationProfileName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationProfileName, bool allowUnparsed, out ConversationProfileName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversationProfileName, nameof(conversationProfileName));
            gax::TemplatedResourceName resourceName;
            if (s_projectConversationProfile.TryParseName(conversationProfileName, out resourceName))
            {
                result = FromProjectConversationProfile(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationConversationProfile.TryParseName(conversationProfileName, out resourceName))
            {
                result = FromProjectLocationConversationProfile(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conversationProfileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConversationProfileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversationProfileId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversationProfileId = conversationProfileId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConversationProfileName"/> class from the component parts of
        /// pattern <c>projects/{project}/conversationProfiles/{conversation_profile}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationProfileId">
        /// The <c>ConversationProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ConversationProfileName(string projectId, string conversationProfileId) : this(ResourceNameType.ProjectConversationProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), conversationProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfileId, nameof(conversationProfileId)))
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
        /// The <c>ConversationProfile</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ConversationProfileId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectConversationProfile: return s_projectConversationProfile.Expand(ProjectId, ConversationProfileId);
                case ResourceNameType.ProjectLocationConversationProfile: return s_projectLocationConversationProfile.Expand(ProjectId, LocationId, ConversationProfileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConversationProfileName);

        /// <inheritdoc/>
        public bool Equals(ConversationProfileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConversationProfileName a, ConversationProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConversationProfileName a, ConversationProfileName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CXSecuritySettings</c> resource.</summary>
    public sealed partial class CXSecuritySettingsName : gax::IResourceName, sys::IEquatable<CXSecuritySettingsName>
    {
        /// <summary>The possible contents of <see cref="CXSecuritySettingsName"/>.</summary>
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

        /// <summary>Creates a <see cref="CXSecuritySettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CXSecuritySettingsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CXSecuritySettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CXSecuritySettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CXSecuritySettingsName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securitySettingsId">The <c>SecuritySettings</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CXSecuritySettingsName"/> constructed from the provided ids.</returns>
        public static CXSecuritySettingsName FromProjectLocationSecuritySettings(string projectId, string locationId, string securitySettingsId) =>
            new CXSecuritySettingsName(ResourceNameType.ProjectLocationSecuritySettings, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securitySettingsId: gax::GaxPreconditions.CheckNotNullOrEmpty(securitySettingsId, nameof(securitySettingsId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CXSecuritySettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securitySettingsId">The <c>SecuritySettings</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CXSecuritySettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string securitySettingsId) =>
            FormatProjectLocationSecuritySettings(projectId, locationId, securitySettingsId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CXSecuritySettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securitySettingsId">The <c>SecuritySettings</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CXSecuritySettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>.
        /// </returns>
        public static string FormatProjectLocationSecuritySettings(string projectId, string locationId, string securitySettingsId) =>
            s_projectLocationSecuritySettings.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(securitySettingsId, nameof(securitySettingsId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CXSecuritySettingsName"/> instance.
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
        /// <param name="cXSecuritySettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CXSecuritySettingsName"/> if successful.</returns>
        public static CXSecuritySettingsName Parse(string cXSecuritySettingsName) => Parse(cXSecuritySettingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CXSecuritySettingsName"/> instance; optionally
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
        /// <param name="cXSecuritySettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CXSecuritySettingsName"/> if successful.</returns>
        public static CXSecuritySettingsName Parse(string cXSecuritySettingsName, bool allowUnparsed) =>
            TryParse(cXSecuritySettingsName, allowUnparsed, out CXSecuritySettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CXSecuritySettingsName"/> instance.
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
        /// <param name="cXSecuritySettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CXSecuritySettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cXSecuritySettingsName, out CXSecuritySettingsName result) =>
            TryParse(cXSecuritySettingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CXSecuritySettingsName"/> instance;
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
        /// <param name="cXSecuritySettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CXSecuritySettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cXSecuritySettingsName, bool allowUnparsed, out CXSecuritySettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(cXSecuritySettingsName, nameof(cXSecuritySettingsName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSecuritySettings.TryParseName(cXSecuritySettingsName, out resourceName))
            {
                result = FromProjectLocationSecuritySettings(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cXSecuritySettingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CXSecuritySettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string securitySettingsId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SecuritySettingsId = securitySettingsId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CXSecuritySettingsName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/securitySettings/{security_settings}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securitySettingsId">The <c>SecuritySettings</c> ID. Must not be <c>null</c> or empty.</param>
        public CXSecuritySettingsName(string projectId, string locationId, string securitySettingsId) : this(ResourceNameType.ProjectLocationSecuritySettings, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securitySettingsId: gax::GaxPreconditions.CheckNotNullOrEmpty(securitySettingsId, nameof(securitySettingsId)))
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
        public override bool Equals(object obj) => Equals(obj as CXSecuritySettingsName);

        /// <inheritdoc/>
        public bool Equals(CXSecuritySettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CXSecuritySettingsName a, CXSecuritySettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CXSecuritySettingsName a, CXSecuritySettingsName b) => !(a == b);
    }

    public partial class ConversationProfile
    {
        /// <summary>
        /// <see cref="gcdv::ConversationProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConversationProfileName ConversationProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConversationProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CXSecuritySettingsName"/>-typed view over the <see cref="SecuritySettings"/> resource name
        /// property.
        /// </summary>
        public CXSecuritySettingsName SecuritySettingsAsCXSecuritySettingsName
        {
            get => string.IsNullOrEmpty(SecuritySettings) ? null : CXSecuritySettingsName.Parse(SecuritySettings, allowUnparsed: true);
            set => SecuritySettings = value?.ToString() ?? "";
        }
    }

    public partial class ListConversationProfilesRequest
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

    public partial class GetConversationProfileRequest
    {
        /// <summary>
        /// <see cref="gcdv::ConversationProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConversationProfileName ConversationProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConversationProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateConversationProfileRequest
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

    public partial class DeleteConversationProfileRequest
    {
        /// <summary>
        /// <see cref="gcdv::ConversationProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConversationProfileName ConversationProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConversationProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AutomatedAgentConfig
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Agent"/> resource name property.</summary>
        public AgentName AgentAsAgentName
        {
            get => string.IsNullOrEmpty(Agent) ? null : AgentName.Parse(Agent, allowUnparsed: true);
            set => Agent = value?.ToString() ?? "";
        }
    }

    public partial class HumanAgentAssistantConfig
    {
        public partial class Types
        {
            public partial class SuggestionConfig
            {
                /// <summary>
                /// <see cref="GeneratorName"/>-typed view over the <see cref="Generators"/> resource name property.
                /// </summary>
                public gax::ResourceNameList<GeneratorName> GeneratorsAsGeneratorNames
                {
                    get => new gax::ResourceNameList<GeneratorName>(Generators, s => string.IsNullOrEmpty(s) ? null : GeneratorName.Parse(s, allowUnparsed: true));
                }
            }

            public partial class SuggestionQueryConfig
            {
                public partial class Types
                {
                    public partial class KnowledgeBaseQuerySource
                    {
                        /// <summary>
                        /// <see cref="KnowledgeBaseName"/>-typed view over the <see cref="KnowledgeBases"/> resource
                        /// name property.
                        /// </summary>
                        public gax::ResourceNameList<KnowledgeBaseName> KnowledgeBasesAsKnowledgeBaseNames
                        {
                            get => new gax::ResourceNameList<KnowledgeBaseName>(KnowledgeBases, s => string.IsNullOrEmpty(s) ? null : KnowledgeBaseName.Parse(s, allowUnparsed: true));
                        }
                    }

                    public partial class DocumentQuerySource
                    {
                        /// <summary>
                        /// <see cref="DocumentName"/>-typed view over the <see cref="Documents"/> resource name
                        /// property.
                        /// </summary>
                        public gax::ResourceNameList<DocumentName> DocumentsAsDocumentNames
                        {
                            get => new gax::ResourceNameList<DocumentName>(Documents, s => string.IsNullOrEmpty(s) ? null : DocumentName.Parse(s, allowUnparsed: true));
                        }
                    }

                    public partial class DialogflowQuerySource
                    {
                        /// <summary>
                        /// <see cref="AgentName"/>-typed view over the <see cref="Agent"/> resource name property.
                        /// </summary>
                        public AgentName AgentAsAgentName
                        {
                            get => string.IsNullOrEmpty(Agent) ? null : AgentName.Parse(Agent, allowUnparsed: true);
                            set => Agent = value?.ToString() ?? "";
                        }

                        public partial class Types
                        {
                            public partial class HumanAgentSideConfig
                            {
                                /// <summary>
                                /// <see cref="AgentName"/>-typed view over the <see cref="Agent"/> resource name
                                /// property.
                                /// </summary>
                                public AgentName AgentAsAgentName
                                {
                                    get => string.IsNullOrEmpty(Agent) ? null : AgentName.Parse(Agent, allowUnparsed: true);
                                    set => Agent = value?.ToString() ?? "";
                                }
                            }
                        }
                    }
                }
            }

            public partial class ConversationModelConfig
            {
                /// <summary>
                /// <see cref="ConversationModelName"/>-typed view over the <see cref="Model"/> resource name property.
                /// </summary>
                public ConversationModelName ModelAsConversationModelName
                {
                    get => string.IsNullOrEmpty(Model) ? null : ConversationModelName.Parse(Model, allowUnparsed: true);
                    set => Model = value?.ToString() ?? "";
                }
            }
        }
    }
}

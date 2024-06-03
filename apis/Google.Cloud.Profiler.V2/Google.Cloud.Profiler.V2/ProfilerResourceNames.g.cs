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
using gcpv = Google.Cloud.Profiler.V2;
using sys = System;

namespace Google.Cloud.Profiler.V2
{
    /// <summary>Resource name for the <c>Profile</c> resource.</summary>
    public sealed partial class ProfileName : gax::IResourceName, sys::IEquatable<ProfileName>
    {
        /// <summary>The possible contents of <see cref="ProfileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/profiles/{profile}</c>.</summary>
            ProjectProfile = 1,
        }

        private static gax::PathTemplate s_projectProfile = new gax::PathTemplate("projects/{project}/profiles/{profile}");

        /// <summary>Creates a <see cref="ProfileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProfileName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProfileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProfileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProfileName"/> with the pattern <c>projects/{project}/profiles/{profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="profileId">The <c>Profile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProfileName"/> constructed from the provided ids.</returns>
        public static ProfileName FromProjectProfile(string projectId, string profileId) =>
            new ProfileName(ResourceNameType.ProjectProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), profileId: gax::GaxPreconditions.CheckNotNullOrEmpty(profileId, nameof(profileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProfileName"/> with pattern
        /// <c>projects/{project}/profiles/{profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="profileId">The <c>Profile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProfileName"/> with pattern
        /// <c>projects/{project}/profiles/{profile}</c>.
        /// </returns>
        public static string Format(string projectId, string profileId) => FormatProjectProfile(projectId, profileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProfileName"/> with pattern
        /// <c>projects/{project}/profiles/{profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="profileId">The <c>Profile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProfileName"/> with pattern
        /// <c>projects/{project}/profiles/{profile}</c>.
        /// </returns>
        public static string FormatProjectProfile(string projectId, string profileId) =>
            s_projectProfile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(profileId, nameof(profileId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProfileName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/profiles/{profile}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="profileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProfileName"/> if successful.</returns>
        public static ProfileName Parse(string profileName) => Parse(profileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProfileName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/profiles/{profile}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="profileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProfileName"/> if successful.</returns>
        public static ProfileName Parse(string profileName, bool allowUnparsed) =>
            TryParse(profileName, allowUnparsed, out ProfileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/profiles/{profile}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="profileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string profileName, out ProfileName result) => TryParse(profileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProfileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/profiles/{profile}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="profileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string profileName, bool allowUnparsed, out ProfileName result)
        {
            gax::GaxPreconditions.CheckNotNull(profileName, nameof(profileName));
            gax::TemplatedResourceName resourceName;
            if (s_projectProfile.TryParseName(profileName, out resourceName))
            {
                result = FromProjectProfile(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(profileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProfileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string profileId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProfileId = profileId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProfileName"/> class from the component parts of pattern
        /// <c>projects/{project}/profiles/{profile}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="profileId">The <c>Profile</c> ID. Must not be <c>null</c> or empty.</param>
        public ProfileName(string projectId, string profileId) : this(ResourceNameType.ProjectProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), profileId: gax::GaxPreconditions.CheckNotNullOrEmpty(profileId, nameof(profileId)))
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
        /// The <c>Profile</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProfileId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
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
                case ResourceNameType.ProjectProfile: return s_projectProfile.Expand(ProjectId, ProfileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProfileName);

        /// <inheritdoc/>
        public bool Equals(ProfileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProfileName a, ProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProfileName a, ProfileName b) => !(a == b);
    }

    public partial class CreateProfileRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateOfflineProfileRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class Profile
    {
        /// <summary>
        /// <see cref="gcpv::ProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ProfileName ProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListProfilesRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}

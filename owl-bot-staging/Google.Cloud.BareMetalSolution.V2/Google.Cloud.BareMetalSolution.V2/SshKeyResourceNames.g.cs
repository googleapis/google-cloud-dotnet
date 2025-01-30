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
using gcbv = Google.Cloud.BareMetalSolution.V2;
using sys = System;

namespace Google.Cloud.BareMetalSolution.V2
{
    /// <summary>Resource name for the <c>SshKey</c> resource.</summary>
    public sealed partial class SshKeyName : gax::IResourceName, sys::IEquatable<SshKeyName>
    {
        /// <summary>The possible contents of <see cref="SshKeyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/sshKeys/{ssh_key}</c>.
            /// </summary>
            ProjectLocationSshKey = 1,
        }

        private static gax::PathTemplate s_projectLocationSshKey = new gax::PathTemplate("projects/{project}/locations/{location}/sshKeys/{ssh_key}");

        /// <summary>Creates a <see cref="SshKeyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SshKeyName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SshKeyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SshKeyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SshKeyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sshKeys/{ssh_key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sshKeyId">The <c>SshKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SshKeyName"/> constructed from the provided ids.</returns>
        public static SshKeyName FromProjectLocationSshKey(string projectId, string locationId, string sshKeyId) =>
            new SshKeyName(ResourceNameType.ProjectLocationSshKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sshKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(sshKeyId, nameof(sshKeyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SshKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sshKeys/{ssh_key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sshKeyId">The <c>SshKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SshKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sshKeys/{ssh_key}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sshKeyId) =>
            FormatProjectLocationSshKey(projectId, locationId, sshKeyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SshKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sshKeys/{ssh_key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sshKeyId">The <c>SshKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SshKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sshKeys/{ssh_key}</c>.
        /// </returns>
        public static string FormatProjectLocationSshKey(string projectId, string locationId, string sshKeyId) =>
            s_projectLocationSshKey.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sshKeyId, nameof(sshKeyId)));

        /// <summary>Parses the given resource name string into a new <see cref="SshKeyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sshKeys/{ssh_key}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sshKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SshKeyName"/> if successful.</returns>
        public static SshKeyName Parse(string sshKeyName) => Parse(sshKeyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SshKeyName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sshKeys/{ssh_key}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sshKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SshKeyName"/> if successful.</returns>
        public static SshKeyName Parse(string sshKeyName, bool allowUnparsed) =>
            TryParse(sshKeyName, allowUnparsed, out SshKeyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SshKeyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sshKeys/{ssh_key}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sshKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SshKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sshKeyName, out SshKeyName result) => TryParse(sshKeyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SshKeyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sshKeys/{ssh_key}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sshKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SshKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sshKeyName, bool allowUnparsed, out SshKeyName result)
        {
            gax::GaxPreconditions.CheckNotNull(sshKeyName, nameof(sshKeyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSshKey.TryParseName(sshKeyName, out resourceName))
            {
                result = FromProjectLocationSshKey(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sshKeyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SshKeyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string sshKeyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SshKeyId = sshKeyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SshKeyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sshKeys/{ssh_key}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sshKeyId">The <c>SshKey</c> ID. Must not be <c>null</c> or empty.</param>
        public SshKeyName(string projectId, string locationId, string sshKeyId) : this(ResourceNameType.ProjectLocationSshKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sshKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(sshKeyId, nameof(sshKeyId)))
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
        /// The <c>SshKey</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SshKeyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSshKey: return s_projectLocationSshKey.Expand(ProjectId, LocationId, SshKeyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SshKeyName);

        /// <inheritdoc/>
        public bool Equals(SshKeyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SshKeyName a, SshKeyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SshKeyName a, SshKeyName b) => !(a == b);
    }

    public partial class SSHKey
    {
        /// <summary>
        /// <see cref="gcbv::SshKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::SshKeyName SshKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::SshKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSSHKeysRequest
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

    public partial class CreateSSHKeyRequest
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

    public partial class DeleteSSHKeyRequest
    {
        /// <summary>
        /// <see cref="gcbv::SshKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::SshKeyName SshKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::SshKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

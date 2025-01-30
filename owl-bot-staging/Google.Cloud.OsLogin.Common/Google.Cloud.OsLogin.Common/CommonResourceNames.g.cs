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
using gax = Google.Api.Gax;
using gcoc = Google.Cloud.OsLogin.Common;
using sys = System;

namespace Google.Cloud.OsLogin.Common
{
    /// <summary>Resource name for the <c>PosixAccount</c> resource.</summary>
    public sealed partial class PosixAccountName : gax::IResourceName, sys::IEquatable<PosixAccountName>
    {
        /// <summary>The possible contents of <see cref="PosixAccountName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>users/{user}/projects/{project}</c>.</summary>
            UserProject = 1,
        }

        private static gax::PathTemplate s_userProject = new gax::PathTemplate("users/{user}/projects/{project}");

        /// <summary>Creates a <see cref="PosixAccountName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PosixAccountName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PosixAccountName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PosixAccountName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PosixAccountName"/> with the pattern <c>users/{user}/projects/{project}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PosixAccountName"/> constructed from the provided ids.</returns>
        public static PosixAccountName FromUserProject(string userId, string projectId) =>
            new PosixAccountName(ResourceNameType.UserProject, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PosixAccountName"/> with pattern
        /// <c>users/{user}/projects/{project}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PosixAccountName"/> with pattern
        /// <c>users/{user}/projects/{project}</c>.
        /// </returns>
        public static string Format(string userId, string projectId) => FormatUserProject(userId, projectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PosixAccountName"/> with pattern
        /// <c>users/{user}/projects/{project}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PosixAccountName"/> with pattern
        /// <c>users/{user}/projects/{project}</c>.
        /// </returns>
        public static string FormatUserProject(string userId, string projectId) =>
            s_userProject.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>Parses the given resource name string into a new <see cref="PosixAccountName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/projects/{project}</c></description></item></list>
        /// </remarks>
        /// <param name="posixAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PosixAccountName"/> if successful.</returns>
        public static PosixAccountName Parse(string posixAccountName) => Parse(posixAccountName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PosixAccountName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/projects/{project}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="posixAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PosixAccountName"/> if successful.</returns>
        public static PosixAccountName Parse(string posixAccountName, bool allowUnparsed) =>
            TryParse(posixAccountName, allowUnparsed, out PosixAccountName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PosixAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/projects/{project}</c></description></item></list>
        /// </remarks>
        /// <param name="posixAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PosixAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string posixAccountName, out PosixAccountName result) =>
            TryParse(posixAccountName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PosixAccountName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/projects/{project}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="posixAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PosixAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string posixAccountName, bool allowUnparsed, out PosixAccountName result)
        {
            gax::GaxPreconditions.CheckNotNull(posixAccountName, nameof(posixAccountName));
            gax::TemplatedResourceName resourceName;
            if (s_userProject.TryParseName(posixAccountName, out resourceName))
            {
                result = FromUserProject(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(posixAccountName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PosixAccountName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PosixAccountName"/> class from the component parts of pattern
        /// <c>users/{user}/projects/{project}</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        public PosixAccountName(string userId, string projectId) : this(ResourceNameType.UserProject, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>User</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UserId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.UserProject: return s_userProject.Expand(UserId, ProjectId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PosixAccountName);

        /// <inheritdoc/>
        public bool Equals(PosixAccountName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PosixAccountName a, PosixAccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PosixAccountName a, PosixAccountName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SshPublicKey</c> resource.</summary>
    public sealed partial class SshPublicKeyName : gax::IResourceName, sys::IEquatable<SshPublicKeyName>
    {
        /// <summary>The possible contents of <see cref="SshPublicKeyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>users/{user}/sshPublicKeys/{fingerprint}</c>.</summary>
            UserFingerprint = 1,
        }

        private static gax::PathTemplate s_userFingerprint = new gax::PathTemplate("users/{user}/sshPublicKeys/{fingerprint}");

        /// <summary>Creates a <see cref="SshPublicKeyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SshPublicKeyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SshPublicKeyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SshPublicKeyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SshPublicKeyName"/> with the pattern <c>users/{user}/sshPublicKeys/{fingerprint}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fingerprintId">The <c>Fingerprint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SshPublicKeyName"/> constructed from the provided ids.</returns>
        public static SshPublicKeyName FromUserFingerprint(string userId, string fingerprintId) =>
            new SshPublicKeyName(ResourceNameType.UserFingerprint, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), fingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(fingerprintId, nameof(fingerprintId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SshPublicKeyName"/> with pattern
        /// <c>users/{user}/sshPublicKeys/{fingerprint}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fingerprintId">The <c>Fingerprint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SshPublicKeyName"/> with pattern
        /// <c>users/{user}/sshPublicKeys/{fingerprint}</c>.
        /// </returns>
        public static string Format(string userId, string fingerprintId) => FormatUserFingerprint(userId, fingerprintId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SshPublicKeyName"/> with pattern
        /// <c>users/{user}/sshPublicKeys/{fingerprint}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fingerprintId">The <c>Fingerprint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SshPublicKeyName"/> with pattern
        /// <c>users/{user}/sshPublicKeys/{fingerprint}</c>.
        /// </returns>
        public static string FormatUserFingerprint(string userId, string fingerprintId) =>
            s_userFingerprint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fingerprintId, nameof(fingerprintId)));

        /// <summary>Parses the given resource name string into a new <see cref="SshPublicKeyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/sshPublicKeys/{fingerprint}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sshPublicKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SshPublicKeyName"/> if successful.</returns>
        public static SshPublicKeyName Parse(string sshPublicKeyName) => Parse(sshPublicKeyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SshPublicKeyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/sshPublicKeys/{fingerprint}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sshPublicKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SshPublicKeyName"/> if successful.</returns>
        public static SshPublicKeyName Parse(string sshPublicKeyName, bool allowUnparsed) =>
            TryParse(sshPublicKeyName, allowUnparsed, out SshPublicKeyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SshPublicKeyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/sshPublicKeys/{fingerprint}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sshPublicKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SshPublicKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sshPublicKeyName, out SshPublicKeyName result) =>
            TryParse(sshPublicKeyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SshPublicKeyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/sshPublicKeys/{fingerprint}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sshPublicKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SshPublicKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sshPublicKeyName, bool allowUnparsed, out SshPublicKeyName result)
        {
            gax::GaxPreconditions.CheckNotNull(sshPublicKeyName, nameof(sshPublicKeyName));
            gax::TemplatedResourceName resourceName;
            if (s_userFingerprint.TryParseName(sshPublicKeyName, out resourceName))
            {
                result = FromUserFingerprint(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sshPublicKeyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SshPublicKeyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string fingerprintId = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FingerprintId = fingerprintId;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SshPublicKeyName"/> class from the component parts of pattern
        /// <c>users/{user}/sshPublicKeys/{fingerprint}</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fingerprintId">The <c>Fingerprint</c> ID. Must not be <c>null</c> or empty.</param>
        public SshPublicKeyName(string userId, string fingerprintId) : this(ResourceNameType.UserFingerprint, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), fingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(fingerprintId, nameof(fingerprintId)))
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
        /// The <c>Fingerprint</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FingerprintId { get; }

        /// <summary>
        /// The <c>User</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UserId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.UserFingerprint: return s_userFingerprint.Expand(UserId, FingerprintId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SshPublicKeyName);

        /// <inheritdoc/>
        public bool Equals(SshPublicKeyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SshPublicKeyName a, SshPublicKeyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SshPublicKeyName a, SshPublicKeyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>User</c> resource.</summary>
    public sealed partial class UserName : gax::IResourceName, sys::IEquatable<UserName>
    {
        /// <summary>The possible contents of <see cref="UserName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>users/{user}</c>.</summary>
            User = 1,
        }

        private static gax::PathTemplate s_user = new gax::PathTemplate("users/{user}");

        /// <summary>Creates a <see cref="UserName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UserName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="UserName"/> with the pattern <c>users/{user}</c>.</summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UserName"/> constructed from the provided ids.</returns>
        public static UserName FromUser(string userId) =>
            new UserName(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserName"/> with pattern <c>users/{user}</c>
        /// .
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserName"/> with pattern <c>users/{user}</c>.
        /// </returns>
        public static string Format(string userId) => FormatUser(userId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserName"/> with pattern <c>users/{user}</c>
        /// .
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserName"/> with pattern <c>users/{user}</c>.
        /// </returns>
        public static string FormatUser(string userId) =>
            s_user.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>Parses the given resource name string into a new <see cref="UserName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}</c></description></item></list>
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserName"/> if successful.</returns>
        public static UserName Parse(string userName) => Parse(userName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserName"/> if successful.</returns>
        public static UserName Parse(string userName, bool allowUnparsed) =>
            TryParse(userName, allowUnparsed, out UserName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="UserName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}</c></description></item></list>
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userName, out UserName result) => TryParse(userName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userName, bool allowUnparsed, out UserName result)
        {
            gax::GaxPreconditions.CheckNotNull(userName, nameof(userName));
            gax::TemplatedResourceName resourceName;
            if (s_user.TryParseName(userName, out resourceName))
            {
                result = FromUser(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UserName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserName"/> class from the component parts of pattern
        /// <c>users/{user}</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        public UserName(string userId) : this(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)))
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
        /// The <c>User</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UserId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.User: return s_user.Expand(UserId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserName);

        /// <inheritdoc/>
        public bool Equals(UserName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UserName a, UserName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UserName a, UserName b) => !(a == b);
    }

    public partial class PosixAccount
    {
        /// <summary>
        /// <see cref="gcoc::PosixAccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcoc::PosixAccountName PosixAccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoc::PosixAccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SshPublicKey
    {
        /// <summary>
        /// <see cref="gcoc::SshPublicKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcoc::SshPublicKeyName SshPublicKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoc::SshPublicKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

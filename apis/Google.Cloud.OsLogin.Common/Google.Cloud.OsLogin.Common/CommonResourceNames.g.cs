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
using gcoc = Google.Cloud.OsLogin.Common;
using sys = System;

namespace Google.Cloud.OsLogin.Common
{
    /// <summary>Resource name for the <c>PosixAccount</c> resource.</summary>
    public sealed partial class PosixAccountName : gax::IResourceName, sys::IEquatable<PosixAccountName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("users/{user}/projects/{project}");

        /// <summary>
        /// Parses the given <c>PosixAccount</c> resource name in string form into a new <see cref="PosixAccountName"/>
        /// instance.
        /// </summary>
        /// <param name="posixAccountName">
        /// The <c>PosixAccount</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="PosixAccountName"/> if successful.</returns>
        public static PosixAccountName Parse(string posixAccountName)
        {
            gax::GaxPreconditions.CheckNotNull(posixAccountName, nameof(posixAccountName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(posixAccountName);
            return new PosixAccountName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="PosixAccountName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="posixAccountName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="posixAccountName">
        /// The <c>PosixAccount</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PosixAccountName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string posixAccountName, out PosixAccountName result)
        {
            gax::GaxPreconditions.CheckNotNull(posixAccountName, nameof(posixAccountName));
            if (s_template.TryParseName(posixAccountName, out gax::TemplatedResourceName resourceName))
            {
                result = new PosixAccountName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="PosixAccountName"/>.</summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c>.</param>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="PosixAccountName"/>.</returns>
        public static string Format(string userId, string projectId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="PosixAccountName"/> resource name class from its component
        /// parts.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c>.</param>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        public PosixAccountName(string userId, string projectId)
        {
            UserId = gax::GaxPreconditions.CheckNotNull(userId, nameof(userId));
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>The <c>User</c> ID. Never <c>null</c>.</summary>
        public string UserId { get; }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(UserId, ProjectId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PosixAccountName);

        /// <inheritdoc/>
        public bool Equals(PosixAccountName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(PosixAccountName a, PosixAccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(PosixAccountName a, PosixAccountName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SshPublicKey</c> resource.</summary>
    public sealed partial class SshPublicKeyName : gax::IResourceName, sys::IEquatable<SshPublicKeyName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("users/{user}/sshPublicKeys/{fingerprint}");

        /// <summary>
        /// Parses the given <c>SshPublicKey</c> resource name in string form into a new <see cref="SshPublicKeyName"/>
        /// instance.
        /// </summary>
        /// <param name="sshPublicKeyName">
        /// The <c>SshPublicKey</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="SshPublicKeyName"/> if successful.</returns>
        public static SshPublicKeyName Parse(string sshPublicKeyName)
        {
            gax::GaxPreconditions.CheckNotNull(sshPublicKeyName, nameof(sshPublicKeyName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(sshPublicKeyName);
            return new SshPublicKeyName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="SshPublicKeyName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="sshPublicKeyName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="sshPublicKeyName">
        /// The <c>SshPublicKey</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SshPublicKeyName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sshPublicKeyName, out SshPublicKeyName result)
        {
            gax::GaxPreconditions.CheckNotNull(sshPublicKeyName, nameof(sshPublicKeyName));
            if (s_template.TryParseName(sshPublicKeyName, out gax::TemplatedResourceName resourceName))
            {
                result = new SshPublicKeyName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="SshPublicKeyName"/>.</summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c>.</param>
        /// <param name="fingerprintId">The <c>Fingerprint</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="SshPublicKeyName"/>.</returns>
        public static string Format(string userId, string fingerprintId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNull(fingerprintId, nameof(fingerprintId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="SshPublicKeyName"/> resource name class from its component
        /// parts.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c>.</param>
        /// <param name="fingerprintId">The <c>Fingerprint</c> ID. Must not be <c>null</c>.</param>
        public SshPublicKeyName(string userId, string fingerprintId)
        {
            UserId = gax::GaxPreconditions.CheckNotNull(userId, nameof(userId));
            FingerprintId = gax::GaxPreconditions.CheckNotNull(fingerprintId, nameof(fingerprintId));
        }

        /// <summary>The <c>User</c> ID. Never <c>null</c>.</summary>
        public string UserId { get; }

        /// <summary>The <c>Fingerprint</c> ID. Never <c>null</c>.</summary>
        public string FingerprintId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(UserId, FingerprintId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SshPublicKeyName);

        /// <inheritdoc/>
        public bool Equals(SshPublicKeyName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SshPublicKeyName a, SshPublicKeyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SshPublicKeyName a, SshPublicKeyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>User</c> resource.</summary>
    public sealed partial class UserName : gax::IResourceName, sys::IEquatable<UserName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("users/{user}");

        /// <summary>
        /// Parses the given <c>User</c> resource name in string form into a new <see cref="UserName"/> instance.
        /// </summary>
        /// <param name="userName">The <c>User</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserName"/> if successful.</returns>
        public static UserName Parse(string userName)
        {
            gax::GaxPreconditions.CheckNotNull(userName, nameof(userName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(userName);
            return new UserName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="UserName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="userName"/> is <c>null</c>
        /// , as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="userName">The <c>User</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userName, out UserName result)
        {
            gax::GaxPreconditions.CheckNotNull(userName, nameof(userName));
            if (s_template.TryParseName(userName, out gax::TemplatedResourceName resourceName))
            {
                result = new UserName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="UserName"/>.</summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="UserName"/>.</returns>
        public static string Format(string userId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(userId, nameof(userId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="UserName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c>.</param>
        public UserName(string userId) => UserId = gax::GaxPreconditions.CheckNotNull(userId, nameof(userId));

        /// <summary>The <c>User</c> ID. Never <c>null</c>.</summary>
        public string UserId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(UserId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserName);

        /// <inheritdoc/>
        public bool Equals(UserName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(UserName a, UserName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(UserName a, UserName b) => !(a == b);
    }

    public partial class PosixAccount
    {
        /// <summary>
        /// <see cref="gcoc::PosixAccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcoc::PosixAccountName PosixAccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoc::PosixAccountName.Parse(Name);
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
            get => string.IsNullOrEmpty(Name) ? null : gcoc::SshPublicKeyName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}

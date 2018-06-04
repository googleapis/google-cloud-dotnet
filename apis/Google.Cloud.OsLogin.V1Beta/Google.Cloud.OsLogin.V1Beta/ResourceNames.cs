// Copyright 2018 Google LLC
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

namespace Google.Cloud.OsLogin.V1Beta
{
    /// <summary>
    /// Resource name for the 'user' resource.
    /// </summary>
    public sealed partial class UserName : gax::IResourceName, sys::IEquatable<UserName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("users/{user}");

        /// <summary>
        /// Parses the given user resource name in string form into a new
        /// <see cref="UserName"/> instance.
        /// </summary>
        /// <param name="userName">The user resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserName"/> if successful.</returns>
        public static UserName Parse(string userName)
        {
            gax::GaxPreconditions.CheckNotNull(userName, nameof(userName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(userName);
            return new UserName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given user resource name in string form into a new
        /// <see cref="UserName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="userName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="userName">The user resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="UserName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userName, out UserName result)
        {
            gax::GaxPreconditions.CheckNotNull(userName, nameof(userName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(userName, out resourceName))
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

        /// <summary>
        /// Constructs a new instance of the <see cref="UserName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="userId">The user ID. Must not be <c>null</c>.</param>
        public UserName(string userId)
        {
            UserId = gax::GaxPreconditions.CheckNotNull(userId, nameof(userId));
        }

        /// <summary>
        /// The user ID. Never <c>null</c>.
        /// </summary>
        public string UserId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(UserId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as UserName);

        /// <inheritdoc />
        public bool Equals(UserName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(UserName a, UserName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(UserName a, UserName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project' resource.
    /// </summary>
    public sealed partial class ProjectName : gax::IResourceName, sys::IEquatable<ProjectName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("users/{user}/projects/{project}");

        /// <summary>
        /// Parses the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectName"/> if successful.</returns>
        public static ProjectName Parse(string projectName)
        {
            gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(projectName);
            return new ProjectName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="projectName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectName, out ProjectName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectName, out resourceName))
            {
                result = new ProjectName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="userId">The user ID. Must not be <c>null</c>.</param>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        public ProjectName(string userId, string projectId)
        {
            UserId = gax::GaxPreconditions.CheckNotNull(userId, nameof(userId));
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>
        /// The user ID. Never <c>null</c>.
        /// </summary>
        public string UserId { get; }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(UserId, ProjectId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectName);

        /// <inheritdoc />
        public bool Equals(ProjectName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectName a, ProjectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectName a, ProjectName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'fingerprint' resource.
    /// </summary>
    public sealed partial class FingerprintName : gax::IResourceName, sys::IEquatable<FingerprintName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("users/{user}/sshPublicKeys/{fingerprint}");

        /// <summary>
        /// Parses the given fingerprint resource name in string form into a new
        /// <see cref="FingerprintName"/> instance.
        /// </summary>
        /// <param name="fingerprintName">The fingerprint resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FingerprintName"/> if successful.</returns>
        public static FingerprintName Parse(string fingerprintName)
        {
            gax::GaxPreconditions.CheckNotNull(fingerprintName, nameof(fingerprintName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(fingerprintName);
            return new FingerprintName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given fingerprint resource name in string form into a new
        /// <see cref="FingerprintName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="fingerprintName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="fingerprintName">The fingerprint resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FingerprintName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fingerprintName, out FingerprintName result)
        {
            gax::GaxPreconditions.CheckNotNull(fingerprintName, nameof(fingerprintName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(fingerprintName, out resourceName))
            {
                result = new FingerprintName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="FingerprintName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="userId">The user ID. Must not be <c>null</c>.</param>
        /// <param name="fingerprintId">The fingerprint ID. Must not be <c>null</c>.</param>
        public FingerprintName(string userId, string fingerprintId)
        {
            UserId = gax::GaxPreconditions.CheckNotNull(userId, nameof(userId));
            FingerprintId = gax::GaxPreconditions.CheckNotNull(fingerprintId, nameof(fingerprintId));
        }

        /// <summary>
        /// The user ID. Never <c>null</c>.
        /// </summary>
        public string UserId { get; }

        /// <summary>
        /// The fingerprint ID. Never <c>null</c>.
        /// </summary>
        public string FingerprintId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(UserId, FingerprintId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FingerprintName);

        /// <inheritdoc />
        public bool Equals(FingerprintName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FingerprintName a, FingerprintName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FingerprintName a, FingerprintName b) => !(a == b);
    }


    public partial class DeletePosixAccountRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.OsLogin.V1Beta.ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.OsLogin.V1Beta.ProjectName ProjectName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.OsLogin.V1Beta.ProjectName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteSshPublicKeyRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.OsLogin.V1Beta.FingerprintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.OsLogin.V1Beta.FingerprintName FingerprintName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.OsLogin.V1Beta.FingerprintName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetLoginProfileRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.OsLogin.V1Beta.UserName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.OsLogin.V1Beta.UserName UserName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.OsLogin.V1Beta.UserName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetSshPublicKeyRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.OsLogin.V1Beta.FingerprintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.OsLogin.V1Beta.FingerprintName FingerprintName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.OsLogin.V1Beta.FingerprintName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ImportSshPublicKeyRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.OsLogin.V1Beta.UserName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.OsLogin.V1Beta.UserName ParentAsUserName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.OsLogin.V1Beta.UserName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateSshPublicKeyRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.OsLogin.V1Beta.FingerprintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.OsLogin.V1Beta.FingerprintName FingerprintName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.OsLogin.V1Beta.FingerprintName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}
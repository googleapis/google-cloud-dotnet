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
using gcsv = Google.Cloud.SecretManager.V1Beta1;
using sys = System;

namespace Google.Cloud.SecretManager.V1Beta1
{
    /// <summary>Resource name for the <c>Secret</c> resource.</summary>
    public sealed partial class SecretName : gax::IResourceName, sys::IEquatable<SecretName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/secrets/{secret}");

        /// <summary>
        /// Parses the given <c>Secret</c> resource name in string form into a new <see cref="SecretName"/> instance.
        /// </summary>
        /// <param name="secretName">The <c>Secret</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SecretName"/> if successful.</returns>
        public static SecretName Parse(string secretName)
        {
            gax::GaxPreconditions.CheckNotNull(secretName, nameof(secretName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(secretName);
            return new SecretName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="SecretName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="secretName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="secretName">The <c>Secret</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretName, out SecretName result)
        {
            gax::GaxPreconditions.CheckNotNull(secretName, nameof(secretName));
            if (s_template.TryParseName(secretName, out gax::TemplatedResourceName resourceName))
            {
                result = new SecretName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="SecretName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="SecretName"/>.</returns>
        public static string Format(string projectId, string secretId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(secretId, nameof(secretId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="SecretName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c>.</param>
        public SecretName(string projectId, string secretId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            SecretId = gax::GaxPreconditions.CheckNotNull(secretId, nameof(secretId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Secret</c> ID. Never <c>null</c>.</summary>
        public string SecretId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, SecretId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecretName);

        /// <inheritdoc/>
        public bool Equals(SecretName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SecretName a, SecretName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SecretName a, SecretName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SecretVersion</c> resource.</summary>
    public sealed partial class SecretVersionName : gax::IResourceName, sys::IEquatable<SecretVersionName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/secrets/{secret}/versions/{secret_version}");

        /// <summary>
        /// Parses the given <c>SecretVersion</c> resource name in string form into a new
        /// <see cref="SecretVersionName"/> instance.
        /// </summary>
        /// <param name="secretVersionName">
        /// The <c>SecretVersion</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="SecretVersionName"/> if successful.</returns>
        public static SecretVersionName Parse(string secretVersionName)
        {
            gax::GaxPreconditions.CheckNotNull(secretVersionName, nameof(secretVersionName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(secretVersionName);
            return new SecretVersionName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="SecretVersionName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="secretVersionName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="secretVersionName">
        /// The <c>SecretVersion</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretVersionName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretVersionName, out SecretVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(secretVersionName, nameof(secretVersionName));
            if (s_template.TryParseName(secretVersionName, out gax::TemplatedResourceName resourceName))
            {
                result = new SecretVersionName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="SecretVersionName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c>.</param>
        /// <param name="secretVersionId">The <c>SecretVersion</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="SecretVersionName"/>.</returns>
        public static string Format(string projectId, string secretId, string secretVersionId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(secretId, nameof(secretId)), gax::GaxPreconditions.CheckNotNull(secretVersionId, nameof(secretVersionId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="SecretVersionName"/> resource name class from its component
        /// parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c>.</param>
        /// <param name="secretVersionId">The <c>SecretVersion</c> ID. Must not be <c>null</c>.</param>
        public SecretVersionName(string projectId, string secretId, string secretVersionId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            SecretId = gax::GaxPreconditions.CheckNotNull(secretId, nameof(secretId));
            SecretVersionId = gax::GaxPreconditions.CheckNotNull(secretVersionId, nameof(secretVersionId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Secret</c> ID. Never <c>null</c>.</summary>
        public string SecretId { get; }

        /// <summary>The <c>SecretVersion</c> ID. Never <c>null</c>.</summary>
        public string SecretVersionId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, SecretId, SecretVersionId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecretVersionName);

        /// <inheritdoc/>
        public bool Equals(SecretVersionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SecretVersionName a, SecretVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SecretVersionName a, SecretVersionName b) => !(a == b);
    }

    public partial class Secret
    {
        /// <summary>
        /// <see cref="gcsv::SecretName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecretName SecretName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecretName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SecretVersion
    {
        /// <summary>
        /// <see cref="gcsv::SecretVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecretVersionName SecretVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecretVersionName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}

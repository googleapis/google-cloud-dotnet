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
using gax = Google.Api.Gax;
using gcsv = Google.Cloud.SecretManager.V1Beta1;
using sys = System;

namespace Google.Cloud.SecretManager.V1Beta1
{
    /// <summary>Resource name for the <c>Secret</c> resource.</summary>
    public sealed partial class SecretName : gax::IResourceName, sys::IEquatable<SecretName>
    {
        /// <summary>The possible contents of <see cref="SecretName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/secrets/{secret}</c>.</summary>
            ProjectSecret = 1,
        }

        private static gax::PathTemplate s_projectSecret = new gax::PathTemplate("projects/{project}/secrets/{secret}");

        /// <summary>Creates a <see cref="SecretName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecretName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecretName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecretName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecretName"/> with the pattern <c>projects/{project}/secrets/{secret}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecretName"/> constructed from the provided ids.</returns>
        public static SecretName FromProjectSecret(string projectId, string secretId) =>
            new SecretName(ResourceNameType.ProjectSecret, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), secretId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecretName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecretName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}</c>.
        /// </returns>
        public static string Format(string projectId, string secretId) => FormatProjectSecret(projectId, secretId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecretName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecretName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}</c>.
        /// </returns>
        public static string FormatProjectSecret(string projectId, string secretId) =>
            s_projectSecret.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)));

        /// <summary>Parses the given resource name string into a new <see cref="SecretName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="secretName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SecretName"/> if successful.</returns>
        public static SecretName Parse(string secretName) => Parse(secretName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecretName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="secretName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecretName"/> if successful.</returns>
        public static SecretName Parse(string secretName, bool allowUnparsed) =>
            TryParse(secretName, allowUnparsed, out SecretName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecretName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="secretName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretName, out SecretName result) => TryParse(secretName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecretName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="secretName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretName, bool allowUnparsed, out SecretName result)
        {
            gax::GaxPreconditions.CheckNotNull(secretName, nameof(secretName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSecret.TryParseName(secretName, out resourceName))
            {
                result = FromProjectSecret(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(secretName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecretName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string secretId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SecretId = secretId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecretName"/> class from the component parts of pattern
        /// <c>projects/{project}/secrets/{secret}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        public SecretName(string projectId, string secretId) : this(ResourceNameType.ProjectSecret, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), secretId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)))
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
        /// The <c>Secret</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SecretId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSecret: return s_projectSecret.Expand(ProjectId, SecretId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecretName);

        /// <inheritdoc/>
        public bool Equals(SecretName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecretName a, SecretName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SecretName a, SecretName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SecretVersion</c> resource.</summary>
    public sealed partial class SecretVersionName : gax::IResourceName, sys::IEquatable<SecretVersionName>
    {
        /// <summary>The possible contents of <see cref="SecretVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/secrets/{secret}/versions/{secret_version}</c>.
            /// </summary>
            ProjectSecretSecretVersion = 1,
        }

        private static gax::PathTemplate s_projectSecretSecretVersion = new gax::PathTemplate("projects/{project}/secrets/{secret}/versions/{secret_version}");

        /// <summary>Creates a <see cref="SecretVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecretVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecretVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecretVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecretVersionName"/> with the pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{secret_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretVersionId">The <c>SecretVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecretVersionName"/> constructed from the provided ids.</returns>
        public static SecretVersionName FromProjectSecretSecretVersion(string projectId, string secretId, string secretVersionId) =>
            new SecretVersionName(ResourceNameType.ProjectSecretSecretVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), secretId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)), secretVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretVersionId, nameof(secretVersionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{secret_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretVersionId">The <c>SecretVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{secret_version}</c>.
        /// </returns>
        public static string Format(string projectId, string secretId, string secretVersionId) =>
            FormatProjectSecretSecretVersion(projectId, secretId, secretVersionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{secret_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretVersionId">The <c>SecretVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{secret_version}</c>.
        /// </returns>
        public static string FormatProjectSecretSecretVersion(string projectId, string secretId, string secretVersionId) =>
            s_projectSecretSecretVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)), gax::GaxPreconditions.CheckNotNullOrEmpty(secretVersionId, nameof(secretVersionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecretVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/secrets/{secret}/versions/{secret_version}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SecretVersionName"/> if successful.</returns>
        public static SecretVersionName Parse(string secretVersionName) => Parse(secretVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecretVersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/secrets/{secret}/versions/{secret_version}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecretVersionName"/> if successful.</returns>
        public static SecretVersionName Parse(string secretVersionName, bool allowUnparsed) =>
            TryParse(secretVersionName, allowUnparsed, out SecretVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecretVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/secrets/{secret}/versions/{secret_version}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretVersionName, out SecretVersionName result) =>
            TryParse(secretVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecretVersionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/secrets/{secret}/versions/{secret_version}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretVersionName, bool allowUnparsed, out SecretVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(secretVersionName, nameof(secretVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSecretSecretVersion.TryParseName(secretVersionName, out resourceName))
            {
                result = FromProjectSecretSecretVersion(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(secretVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecretVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string secretId = null, string secretVersionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SecretId = secretId;
            SecretVersionId = secretVersionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecretVersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{secret_version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretVersionId">The <c>SecretVersion</c> ID. Must not be <c>null</c> or empty.</param>
        public SecretVersionName(string projectId, string secretId, string secretVersionId) : this(ResourceNameType.ProjectSecretSecretVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), secretId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)), secretVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretVersionId, nameof(secretVersionId)))
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
        /// The <c>Secret</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SecretId { get; }

        /// <summary>
        /// The <c>SecretVersion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SecretVersionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSecretSecretVersion: return s_projectSecretSecretVersion.Expand(ProjectId, SecretId, SecretVersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecretVersionName);

        /// <inheritdoc/>
        public bool Equals(SecretVersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecretVersionName a, SecretVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SecretVersionName a, SecretVersionName b) => !(a == b);
    }

    public partial class Secret
    {
        /// <summary>
        /// <see cref="gcsv::SecretName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecretName SecretName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecretName.Parse(Name, allowUnparsed: true);
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
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecretVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

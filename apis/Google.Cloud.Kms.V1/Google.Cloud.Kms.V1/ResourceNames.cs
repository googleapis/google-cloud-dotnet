// Copyright 2020 Google LLC
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

namespace Google.Cloud.Kms.V1
{
    /// <summary>
    /// Resource name for the 'crypto_key' resource.
    /// </summary>
    public sealed partial class CryptoKeyName : gax::IResourceName, sys::IEquatable<CryptoKeyName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}");

        /// <summary>
        /// Parses the given crypto_key resource name in string form into a new
        /// <see cref="CryptoKeyName"/> instance.
        /// </summary>
        /// <param name="cryptoKeyName">The crypto_key resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CryptoKeyName"/> if successful.</returns>
        public static CryptoKeyName Parse(string cryptoKeyName)
        {
            gax::GaxPreconditions.CheckNotNull(cryptoKeyName, nameof(cryptoKeyName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(cryptoKeyName);
            return new CryptoKeyName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given crypto_key resource name in string form into a new
        /// <see cref="CryptoKeyName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="cryptoKeyName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="cryptoKeyName">The crypto_key resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CryptoKeyName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cryptoKeyName, out CryptoKeyName result)
        {
            gax::GaxPreconditions.CheckNotNull(cryptoKeyName, nameof(cryptoKeyName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(cryptoKeyName, out resourceName))
            {
                result = new CryptoKeyName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="CryptoKeyName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="keyRingId">The <c>keyRing</c> ID. Must not be <c>null</c>.</param>
        /// <param name="cryptoKeyId">The <c>cryptoKey</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="CryptoKeyName"/>.</returns>
        public static string Format(string projectId, string locationId, string keyRingId, string cryptoKeyId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(keyRingId, nameof(keyRingId)), gax::GaxPreconditions.CheckNotNull(cryptoKeyId, nameof(cryptoKeyId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="CryptoKeyName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="keyRingId">The keyRing ID. Must not be <c>null</c>.</param>
        /// <param name="cryptoKeyId">The cryptoKey ID. Must not be <c>null</c>.</param>
        public CryptoKeyName(string projectId, string locationId, string keyRingId, string cryptoKeyId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            KeyRingId = gax::GaxPreconditions.CheckNotNull(keyRingId, nameof(keyRingId));
            CryptoKeyId = gax::GaxPreconditions.CheckNotNull(cryptoKeyId, nameof(cryptoKeyId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The keyRing ID. Never <c>null</c>.
        /// </summary>
        public string KeyRingId { get; }

        /// <summary>
        /// The cryptoKey ID. Never <c>null</c>.
        /// </summary>
        public string CryptoKeyId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, KeyRingId, CryptoKeyId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CryptoKeyName);

        /// <inheritdoc />
        public bool Equals(CryptoKeyName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CryptoKeyName a, CryptoKeyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CryptoKeyName a, CryptoKeyName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'crypto_key_path' resource.
    /// </summary>
    public sealed partial class CryptoKeyPathName : gax::IResourceName, sys::IEquatable<CryptoKeyPathName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key_path=**}");

        /// <summary>
        /// Parses the given crypto_key_path resource name in string form into a new
        /// <see cref="CryptoKeyPathName"/> instance.
        /// </summary>
        /// <param name="cryptoKeyPathName">The crypto_key_path resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CryptoKeyPathName"/> if successful.</returns>
        public static CryptoKeyPathName Parse(string cryptoKeyPathName)
        {
            gax::GaxPreconditions.CheckNotNull(cryptoKeyPathName, nameof(cryptoKeyPathName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(cryptoKeyPathName);
            return new CryptoKeyPathName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given crypto_key_path resource name in string form into a new
        /// <see cref="CryptoKeyPathName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="cryptoKeyPathName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="cryptoKeyPathName">The crypto_key_path resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CryptoKeyPathName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cryptoKeyPathName, out CryptoKeyPathName result)
        {
            gax::GaxPreconditions.CheckNotNull(cryptoKeyPathName, nameof(cryptoKeyPathName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(cryptoKeyPathName, out resourceName))
            {
                result = new CryptoKeyPathName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="CryptoKeyPathName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="keyRingId">The <c>keyRing</c> ID. Must not be <c>null</c>.</param>
        /// <param name="cryptoKeyPathId">The <c>cryptoKeyPath</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="CryptoKeyPathName"/>.</returns>
        public static string Format(string projectId, string locationId, string keyRingId, string cryptoKeyPathId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(keyRingId, nameof(keyRingId)), gax::GaxPreconditions.CheckNotNull(cryptoKeyPathId, nameof(cryptoKeyPathId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="CryptoKeyPathName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="keyRingId">The keyRing ID. Must not be <c>null</c>.</param>
        /// <param name="cryptoKeyPathId">The cryptoKeyPath ID. Must not be <c>null</c>.</param>
        public CryptoKeyPathName(string projectId, string locationId, string keyRingId, string cryptoKeyPathId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            KeyRingId = gax::GaxPreconditions.CheckNotNull(keyRingId, nameof(keyRingId));
            CryptoKeyPathId = gax::GaxPreconditions.CheckNotNull(cryptoKeyPathId, nameof(cryptoKeyPathId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The keyRing ID. Never <c>null</c>.
        /// </summary>
        public string KeyRingId { get; }

        /// <summary>
        /// The cryptoKeyPath ID. Never <c>null</c>.
        /// </summary>
        public string CryptoKeyPathId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, KeyRingId, CryptoKeyPathId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CryptoKeyPathName);

        /// <inheritdoc />
        public bool Equals(CryptoKeyPathName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CryptoKeyPathName a, CryptoKeyPathName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CryptoKeyPathName a, CryptoKeyPathName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'crypto_key_version' resource.
    /// </summary>
    public sealed partial class CryptoKeyVersionName : gax::IResourceName, sys::IEquatable<CryptoKeyVersionName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}");

        /// <summary>
        /// Parses the given crypto_key_version resource name in string form into a new
        /// <see cref="CryptoKeyVersionName"/> instance.
        /// </summary>
        /// <param name="cryptoKeyVersionName">The crypto_key_version resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CryptoKeyVersionName"/> if successful.</returns>
        public static CryptoKeyVersionName Parse(string cryptoKeyVersionName)
        {
            gax::GaxPreconditions.CheckNotNull(cryptoKeyVersionName, nameof(cryptoKeyVersionName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(cryptoKeyVersionName);
            return new CryptoKeyVersionName(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
        }

        /// <summary>
        /// Tries to parse the given crypto_key_version resource name in string form into a new
        /// <see cref="CryptoKeyVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="cryptoKeyVersionName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="cryptoKeyVersionName">The crypto_key_version resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CryptoKeyVersionName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cryptoKeyVersionName, out CryptoKeyVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(cryptoKeyVersionName, nameof(cryptoKeyVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(cryptoKeyVersionName, out resourceName))
            {
                result = new CryptoKeyVersionName(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="CryptoKeyVersionName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="keyRingId">The <c>keyRing</c> ID. Must not be <c>null</c>.</param>
        /// <param name="cryptoKeyId">The <c>cryptoKey</c> ID. Must not be <c>null</c>.</param>
        /// <param name="cryptoKeyVersionId">The <c>cryptoKeyVersion</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="CryptoKeyVersionName"/>.</returns>
        public static string Format(string projectId, string locationId, string keyRingId, string cryptoKeyId, string cryptoKeyVersionId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(keyRingId, nameof(keyRingId)), gax::GaxPreconditions.CheckNotNull(cryptoKeyId, nameof(cryptoKeyId)), gax::GaxPreconditions.CheckNotNull(cryptoKeyVersionId, nameof(cryptoKeyVersionId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="CryptoKeyVersionName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="keyRingId">The keyRing ID. Must not be <c>null</c>.</param>
        /// <param name="cryptoKeyId">The cryptoKey ID. Must not be <c>null</c>.</param>
        /// <param name="cryptoKeyVersionId">The cryptoKeyVersion ID. Must not be <c>null</c>.</param>
        public CryptoKeyVersionName(string projectId, string locationId, string keyRingId, string cryptoKeyId, string cryptoKeyVersionId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            KeyRingId = gax::GaxPreconditions.CheckNotNull(keyRingId, nameof(keyRingId));
            CryptoKeyId = gax::GaxPreconditions.CheckNotNull(cryptoKeyId, nameof(cryptoKeyId));
            CryptoKeyVersionId = gax::GaxPreconditions.CheckNotNull(cryptoKeyVersionId, nameof(cryptoKeyVersionId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The keyRing ID. Never <c>null</c>.
        /// </summary>
        public string KeyRingId { get; }

        /// <summary>
        /// The cryptoKey ID. Never <c>null</c>.
        /// </summary>
        public string CryptoKeyId { get; }

        /// <summary>
        /// The cryptoKeyVersion ID. Never <c>null</c>.
        /// </summary>
        public string CryptoKeyVersionId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, KeyRingId, CryptoKeyId, CryptoKeyVersionId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CryptoKeyVersionName);

        /// <inheritdoc />
        public bool Equals(CryptoKeyVersionName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CryptoKeyVersionName a, CryptoKeyVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CryptoKeyVersionName a, CryptoKeyVersionName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'import_job' resource.
    /// </summary>
    public sealed partial class ImportJobName : gax::IResourceName, sys::IEquatable<ImportJobName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/keyRings/{key_ring}/importJobs/{import_job}");

        /// <summary>
        /// Parses the given import_job resource name in string form into a new
        /// <see cref="ImportJobName"/> instance.
        /// </summary>
        /// <param name="importJobName">The import_job resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ImportJobName"/> if successful.</returns>
        public static ImportJobName Parse(string importJobName)
        {
            gax::GaxPreconditions.CheckNotNull(importJobName, nameof(importJobName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(importJobName);
            return new ImportJobName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given import_job resource name in string form into a new
        /// <see cref="ImportJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="importJobName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="importJobName">The import_job resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ImportJobName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string importJobName, out ImportJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(importJobName, nameof(importJobName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(importJobName, out resourceName))
            {
                result = new ImportJobName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ImportJobName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="keyRingId">The <c>keyRing</c> ID. Must not be <c>null</c>.</param>
        /// <param name="importJobId">The <c>importJob</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ImportJobName"/>.</returns>
        public static string Format(string projectId, string locationId, string keyRingId, string importJobId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(keyRingId, nameof(keyRingId)), gax::GaxPreconditions.CheckNotNull(importJobId, nameof(importJobId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ImportJobName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="keyRingId">The keyRing ID. Must not be <c>null</c>.</param>
        /// <param name="importJobId">The importJob ID. Must not be <c>null</c>.</param>
        public ImportJobName(string projectId, string locationId, string keyRingId, string importJobId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            KeyRingId = gax::GaxPreconditions.CheckNotNull(keyRingId, nameof(keyRingId));
            ImportJobId = gax::GaxPreconditions.CheckNotNull(importJobId, nameof(importJobId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The keyRing ID. Never <c>null</c>.
        /// </summary>
        public string KeyRingId { get; }

        /// <summary>
        /// The importJob ID. Never <c>null</c>.
        /// </summary>
        public string ImportJobId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, KeyRingId, ImportJobId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ImportJobName);

        /// <inheritdoc />
        public bool Equals(ImportJobName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ImportJobName a, ImportJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ImportJobName a, ImportJobName b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>KeyRingName: A resource of type 'key_ring'.</description></item>
    /// <item><description>CryptoKeyName: A resource of type 'crypto_key'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class KeyNameOneof : gax::IResourceName, sys::IEquatable<KeyNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="KeyNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'key_ring'.
            /// </summary>
            KeyRingName = 1,

            /// <summary>
            /// A resource of type 'crypto_key'.
            /// </summary>
            CryptoKeyName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="KeyNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>KeyRingName: A resource of type 'key_ring'.</description></item>
        /// <item><description>CryptoKeyName: A resource of type 'crypto_key'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="KeyNameOneof"/> if successful.</returns>
        public static KeyNameOneof Parse(string name, bool allowUnknown)
        {
            KeyNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="KeyNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>KeyRingName: A resource of type 'key_ring'.</description></item>
        /// <item><description>CryptoKeyName: A resource of type 'crypto_key'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="KeyNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out KeyNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            KeyRingName keyRingName;
            if (KeyRingName.TryParse(name, out keyRingName))
            {
                result = new KeyNameOneof(OneofType.KeyRingName, keyRingName);
                return true;
            }
            CryptoKeyName cryptoKeyName;
            if (CryptoKeyName.TryParse(name, out cryptoKeyName))
            {
                result = new KeyNameOneof(OneofType.CryptoKeyName, cryptoKeyName);
                return true;
            }
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new KeyNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="KeyNameOneof"/> from the provided <see cref="KeyRingName"/>
        /// </summary>
        /// <param name="keyRingName">The <see cref="KeyRingName"/> to be contained within
        /// the returned <see cref="KeyNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="KeyNameOneof"/>, containing <paramref name="keyRingName"/>.</returns>
        public static KeyNameOneof From(KeyRingName keyRingName) => new KeyNameOneof(OneofType.KeyRingName, keyRingName);

        /// <summary>
        /// Construct a new instance of <see cref="KeyNameOneof"/> from the provided <see cref="CryptoKeyName"/>
        /// </summary>
        /// <param name="cryptoKeyName">The <see cref="CryptoKeyName"/> to be contained within
        /// the returned <see cref="KeyNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="KeyNameOneof"/>, containing <paramref name="cryptoKeyName"/>.</returns>
        public static KeyNameOneof From(CryptoKeyName cryptoKeyName) => new KeyNameOneof(OneofType.CryptoKeyName, cryptoKeyName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.KeyRingName: return name is KeyRingName;
                case OneofType.CryptoKeyName: return name is CryptoKeyName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="KeyNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public KeyNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="KeyRingName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="KeyRingName"/>.
        /// </remarks>
        public KeyRingName KeyRingName => CheckAndReturn<KeyRingName>(OneofType.KeyRingName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="CryptoKeyName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="CryptoKeyName"/>.
        /// </remarks>
        public CryptoKeyName CryptoKeyName => CheckAndReturn<CryptoKeyName>(OneofType.CryptoKeyName);

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as KeyNameOneof);

        /// <inheritdoc />
        public bool Equals(KeyNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(KeyNameOneof a, KeyNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(KeyNameOneof a, KeyNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'key_ring' resource.
    /// </summary>
    public sealed partial class KeyRingName : gax::IResourceName, sys::IEquatable<KeyRingName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/keyRings/{key_ring}");

        /// <summary>
        /// Parses the given key_ring resource name in string form into a new
        /// <see cref="KeyRingName"/> instance.
        /// </summary>
        /// <param name="keyRingName">The key_ring resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeyRingName"/> if successful.</returns>
        public static KeyRingName Parse(string keyRingName)
        {
            gax::GaxPreconditions.CheckNotNull(keyRingName, nameof(keyRingName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(keyRingName);
            return new KeyRingName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given key_ring resource name in string form into a new
        /// <see cref="KeyRingName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="keyRingName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="keyRingName">The key_ring resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="KeyRingName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keyRingName, out KeyRingName result)
        {
            gax::GaxPreconditions.CheckNotNull(keyRingName, nameof(keyRingName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(keyRingName, out resourceName))
            {
                result = new KeyRingName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="KeyRingName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="keyRingId">The <c>keyRing</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="KeyRingName"/>.</returns>
        public static string Format(string projectId, string locationId, string keyRingId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(keyRingId, nameof(keyRingId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="KeyRingName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="keyRingId">The keyRing ID. Must not be <c>null</c>.</param>
        public KeyRingName(string projectId, string locationId, string keyRingId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            KeyRingId = gax::GaxPreconditions.CheckNotNull(keyRingId, nameof(keyRingId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The keyRing ID. Never <c>null</c>.
        /// </summary>
        public string KeyRingId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, KeyRingId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as KeyRingName);

        /// <inheritdoc />
        public bool Equals(KeyRingName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(KeyRingName a, KeyRingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(KeyRingName a, KeyRingName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'location' resource.
    /// </summary>
    public sealed partial class LocationName : gax::IResourceName, sys::IEquatable<LocationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}");

        /// <summary>
        /// Parses the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(locationName);
            return new LocationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="locationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, out LocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(locationName, out resourceName))
            {
                result = new LocationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="LocationName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="LocationName"/>.</returns>
        public static string Format(string projectId, string locationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        public LocationName(string projectId, string locationId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LocationName);

        /// <inheritdoc />
        public bool Equals(LocationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LocationName a, LocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LocationName a, LocationName b) => !(a == b);
    }


    public partial class AsymmetricDecryptRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyVersionName CryptoKeyVersionName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.CryptoKeyVersionName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class AsymmetricSignRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyVersionName CryptoKeyVersionName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.CryptoKeyVersionName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateCryptoKeyRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.KeyRingName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.KeyRingName ParentAsKeyRingName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Kms.V1.KeyRingName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateCryptoKeyVersionRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyName ParentAsCryptoKeyName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Kms.V1.CryptoKeyName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateImportJobRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.KeyRingName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.KeyRingName ParentAsKeyRingName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Kms.V1.KeyRingName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateKeyRingRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Kms.V1.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CryptoKey
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyName CryptoKeyName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.CryptoKeyName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CryptoKeyVersion
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyVersionName CryptoKeyVersionName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.CryptoKeyVersionName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DecryptRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyName CryptoKeyName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.CryptoKeyName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DestroyCryptoKeyVersionRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyVersionName CryptoKeyVersionName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.CryptoKeyVersionName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class EncryptRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyPathName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyPathName CryptoKeyPathName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.CryptoKeyPathName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetCryptoKeyRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyName CryptoKeyName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.CryptoKeyName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetCryptoKeyVersionRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyVersionName CryptoKeyVersionName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.CryptoKeyVersionName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetImportJobRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.ImportJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.ImportJobName ImportJobName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.ImportJobName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetKeyRingRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.KeyRingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.KeyRingName KeyRingName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.KeyRingName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetPublicKeyRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyVersionName CryptoKeyVersionName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.CryptoKeyVersionName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ImportCryptoKeyVersionRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyName ParentAsCryptoKeyName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Kms.V1.CryptoKeyName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class KeyRing
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.KeyRingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.KeyRingName KeyRingName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.KeyRingName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListCryptoKeyVersionsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyName ParentAsCryptoKeyName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Kms.V1.CryptoKeyName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListCryptoKeysRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.KeyRingName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.KeyRingName ParentAsKeyRingName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Kms.V1.KeyRingName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListImportJobsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.KeyRingName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.KeyRingName ParentAsKeyRingName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Kms.V1.KeyRingName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListKeyRingsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Kms.V1.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class RestoreCryptoKeyVersionRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyVersionName CryptoKeyVersionName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.CryptoKeyVersionName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateCryptoKeyPrimaryVersionRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Kms.V1.CryptoKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Kms.V1.CryptoKeyName CryptoKeyName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Kms.V1.CryptoKeyName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}
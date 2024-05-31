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
using gclv = Google.Cloud.Logging.V2;
using sys = System;

namespace Google.Cloud.Logging.V2
{
    /// <summary>Resource name for the <c>LogBucket</c> resource.</summary>
    public sealed partial class LogBucketName : gax::IResourceName, sys::IEquatable<LogBucketName>
    {
        /// <summary>The possible contents of <see cref="LogBucketName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/buckets/{bucket}</c>.
            /// </summary>
            ProjectLocationBucket = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/locations/{location}/buckets/{bucket}</c>.
            /// </summary>
            OrganizationLocationBucket = 2,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/buckets/{bucket}</c>.
            /// </summary>
            FolderLocationBucket = 3,

            /// <summary>
            /// A resource name with pattern <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}</c>
            /// .
            /// </summary>
            BillingAccountLocationBucket = 4,
        }

        private static gax::PathTemplate s_projectLocationBucket = new gax::PathTemplate("projects/{project}/locations/{location}/buckets/{bucket}");

        private static gax::PathTemplate s_organizationLocationBucket = new gax::PathTemplate("organizations/{organization}/locations/{location}/buckets/{bucket}");

        private static gax::PathTemplate s_folderLocationBucket = new gax::PathTemplate("folders/{folder}/locations/{location}/buckets/{bucket}");

        private static gax::PathTemplate s_billingAccountLocationBucket = new gax::PathTemplate("billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}");

        /// <summary>Creates a <see cref="LogBucketName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LogBucketName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LogBucketName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LogBucketName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LogBucketName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogBucketName"/> constructed from the provided ids.</returns>
        public static LogBucketName FromProjectLocationBucket(string projectId, string locationId, string bucketId) =>
            new LogBucketName(ResourceNameType.ProjectLocationBucket, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>
        /// Creates a <see cref="LogBucketName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogBucketName"/> constructed from the provided ids.</returns>
        public static LogBucketName FromOrganizationLocationBucket(string organizationId, string locationId, string bucketId) =>
            new LogBucketName(ResourceNameType.OrganizationLocationBucket, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>
        /// Creates a <see cref="LogBucketName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogBucketName"/> constructed from the provided ids.</returns>
        public static LogBucketName FromFolderLocationBucket(string folderId, string locationId, string bucketId) =>
            new LogBucketName(ResourceNameType.FolderLocationBucket, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>
        /// Creates a <see cref="LogBucketName"/> with the pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogBucketName"/> constructed from the provided ids.</returns>
        public static LogBucketName FromBillingAccountLocationBucket(string billingAccountId, string locationId, string bucketId) =>
            new LogBucketName(ResourceNameType.BillingAccountLocationBucket, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogBucketName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogBucketName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string bucketId) =>
            FormatProjectLocationBucket(projectId, locationId, bucketId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogBucketName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogBucketName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}</c>.
        /// </returns>
        public static string FormatProjectLocationBucket(string projectId, string locationId, string bucketId) =>
            s_projectLocationBucket.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogBucketName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogBucketName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}</c>.
        /// </returns>
        public static string FormatOrganizationLocationBucket(string organizationId, string locationId, string bucketId) =>
            s_organizationLocationBucket.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogBucketName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogBucketName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/buckets/{bucket}</c>.
        /// </returns>
        public static string FormatFolderLocationBucket(string folderId, string locationId, string bucketId) =>
            s_folderLocationBucket.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogBucketName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogBucketName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}</c>.
        /// </returns>
        public static string FormatBillingAccountLocationBucket(string billingAccountId, string locationId, string bucketId) =>
            s_billingAccountLocationBucket.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>Parses the given resource name string into a new <see cref="LogBucketName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/buckets/{bucket}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/buckets/{bucket}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/locations/{location}/buckets/{bucket}</c></description></item>
        /// <item>
        /// <description><c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="logBucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LogBucketName"/> if successful.</returns>
        public static LogBucketName Parse(string logBucketName) => Parse(logBucketName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LogBucketName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/buckets/{bucket}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/buckets/{bucket}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/locations/{location}/buckets/{bucket}</c></description></item>
        /// <item>
        /// <description><c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logBucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LogBucketName"/> if successful.</returns>
        public static LogBucketName Parse(string logBucketName, bool allowUnparsed) =>
            TryParse(logBucketName, allowUnparsed, out LogBucketName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogBucketName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/buckets/{bucket}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/buckets/{bucket}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/locations/{location}/buckets/{bucket}</c></description></item>
        /// <item>
        /// <description><c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="logBucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogBucketName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logBucketName, out LogBucketName result) => TryParse(logBucketName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogBucketName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/buckets/{bucket}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/buckets/{bucket}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/locations/{location}/buckets/{bucket}</c></description></item>
        /// <item>
        /// <description><c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logBucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogBucketName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logBucketName, bool allowUnparsed, out LogBucketName result)
        {
            gax::GaxPreconditions.CheckNotNull(logBucketName, nameof(logBucketName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBucket.TryParseName(logBucketName, out resourceName))
            {
                result = FromProjectLocationBucket(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationBucket.TryParseName(logBucketName, out resourceName))
            {
                result = FromOrganizationLocationBucket(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationBucket.TryParseName(logBucketName, out resourceName))
            {
                result = FromFolderLocationBucket(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_billingAccountLocationBucket.TryParseName(logBucketName, out resourceName))
            {
                result = FromBillingAccountLocationBucket(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(logBucketName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LogBucketName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string bucketId = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            BucketId = bucketId;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LogBucketName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        public LogBucketName(string projectId, string locationId, string bucketId) : this(ResourceNameType.ProjectLocationBucket, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)))
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
        /// The <c>BillingAccount</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>Bucket</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string BucketId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

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
                case ResourceNameType.ProjectLocationBucket: return s_projectLocationBucket.Expand(ProjectId, LocationId, BucketId);
                case ResourceNameType.OrganizationLocationBucket: return s_organizationLocationBucket.Expand(OrganizationId, LocationId, BucketId);
                case ResourceNameType.FolderLocationBucket: return s_folderLocationBucket.Expand(FolderId, LocationId, BucketId);
                case ResourceNameType.BillingAccountLocationBucket: return s_billingAccountLocationBucket.Expand(BillingAccountId, LocationId, BucketId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LogBucketName);

        /// <inheritdoc/>
        public bool Equals(LogBucketName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LogBucketName a, LogBucketName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LogBucketName a, LogBucketName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>LogView</c> resource.</summary>
    public sealed partial class LogViewName : gax::IResourceName, sys::IEquatable<LogViewName>
    {
        /// <summary>The possible contents of <see cref="LogViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/buckets/{bucket}/views/{view}</c>
            /// .
            /// </summary>
            ProjectLocationBucketView = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/views/{view}</c>.
            /// </summary>
            OrganizationLocationBucketView = 2,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/buckets/{bucket}/views/{view}</c>.
            /// </summary>
            FolderLocationBucketView = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/views/{view}</c>.
            /// </summary>
            BillingAccountLocationBucketView = 4,
        }

        private static gax::PathTemplate s_projectLocationBucketView = new gax::PathTemplate("projects/{project}/locations/{location}/buckets/{bucket}/views/{view}");

        private static gax::PathTemplate s_organizationLocationBucketView = new gax::PathTemplate("organizations/{organization}/locations/{location}/buckets/{bucket}/views/{view}");

        private static gax::PathTemplate s_folderLocationBucketView = new gax::PathTemplate("folders/{folder}/locations/{location}/buckets/{bucket}/views/{view}");

        private static gax::PathTemplate s_billingAccountLocationBucketView = new gax::PathTemplate("billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/views/{view}");

        /// <summary>Creates a <see cref="LogViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LogViewName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LogViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LogViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LogViewName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogViewName"/> constructed from the provided ids.</returns>
        public static LogViewName FromProjectLocationBucketView(string projectId, string locationId, string bucketId, string viewId) =>
            new LogViewName(ResourceNameType.ProjectLocationBucketView, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), viewId: gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)));

        /// <summary>
        /// Creates a <see cref="LogViewName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogViewName"/> constructed from the provided ids.</returns>
        public static LogViewName FromOrganizationLocationBucketView(string organizationId, string locationId, string bucketId, string viewId) =>
            new LogViewName(ResourceNameType.OrganizationLocationBucketView, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), viewId: gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)));

        /// <summary>
        /// Creates a <see cref="LogViewName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogViewName"/> constructed from the provided ids.</returns>
        public static LogViewName FromFolderLocationBucketView(string folderId, string locationId, string bucketId, string viewId) =>
            new LogViewName(ResourceNameType.FolderLocationBucketView, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), viewId: gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)));

        /// <summary>
        /// Creates a <see cref="LogViewName"/> with the pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogViewName"/> constructed from the provided ids.</returns>
        public static LogViewName FromBillingAccountLocationBucketView(string billingAccountId, string locationId, string bucketId, string viewId) =>
            new LogViewName(ResourceNameType.BillingAccountLocationBucketView, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), viewId: gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string bucketId, string viewId) =>
            FormatProjectLocationBucketView(projectId, locationId, bucketId, viewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </returns>
        public static string FormatProjectLocationBucketView(string projectId, string locationId, string bucketId, string viewId) =>
            s_projectLocationBucketView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogViewName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogViewName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </returns>
        public static string FormatOrganizationLocationBucketView(string organizationId, string locationId, string bucketId, string viewId) =>
            s_organizationLocationBucketView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogViewName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogViewName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </returns>
        public static string FormatFolderLocationBucketView(string folderId, string locationId, string bucketId, string viewId) =>
            s_folderLocationBucketView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogViewName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogViewName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/views/{view}</c>.
        /// </returns>
        public static string FormatBillingAccountLocationBucketView(string billingAccountId, string locationId, string bucketId, string viewId) =>
            s_billingAccountLocationBucketView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)));

        /// <summary>Parses the given resource name string into a new <see cref="LogViewName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/buckets/{bucket}/views/{view}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/views/{view}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/buckets/{bucket}/views/{view}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/views/{view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="logViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LogViewName"/> if successful.</returns>
        public static LogViewName Parse(string logViewName) => Parse(logViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LogViewName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/buckets/{bucket}/views/{view}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/views/{view}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/buckets/{bucket}/views/{view}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/views/{view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LogViewName"/> if successful.</returns>
        public static LogViewName Parse(string logViewName, bool allowUnparsed) =>
            TryParse(logViewName, allowUnparsed, out LogViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/buckets/{bucket}/views/{view}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/views/{view}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/buckets/{bucket}/views/{view}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/views/{view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="logViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logViewName, out LogViewName result) => TryParse(logViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/buckets/{bucket}/views/{view}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/views/{view}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/buckets/{bucket}/views/{view}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/views/{view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logViewName, bool allowUnparsed, out LogViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(logViewName, nameof(logViewName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBucketView.TryParseName(logViewName, out resourceName))
            {
                result = FromProjectLocationBucketView(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_organizationLocationBucketView.TryParseName(logViewName, out resourceName))
            {
                result = FromOrganizationLocationBucketView(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_folderLocationBucketView.TryParseName(logViewName, out resourceName))
            {
                result = FromFolderLocationBucketView(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_billingAccountLocationBucketView.TryParseName(logViewName, out resourceName))
            {
                result = FromBillingAccountLocationBucketView(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(logViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LogViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string bucketId = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string viewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            BucketId = bucketId;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            ViewId = viewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LogViewName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/views/{view}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        public LogViewName(string projectId, string locationId, string bucketId, string viewId) : this(ResourceNameType.ProjectLocationBucketView, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), viewId: gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)))
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
        /// The <c>BillingAccount</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>Bucket</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string BucketId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

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

        /// <summary>
        /// The <c>View</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationBucketView: return s_projectLocationBucketView.Expand(ProjectId, LocationId, BucketId, ViewId);
                case ResourceNameType.OrganizationLocationBucketView: return s_organizationLocationBucketView.Expand(OrganizationId, LocationId, BucketId, ViewId);
                case ResourceNameType.FolderLocationBucketView: return s_folderLocationBucketView.Expand(FolderId, LocationId, BucketId, ViewId);
                case ResourceNameType.BillingAccountLocationBucketView: return s_billingAccountLocationBucketView.Expand(BillingAccountId, LocationId, BucketId, ViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LogViewName);

        /// <inheritdoc/>
        public bool Equals(LogViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LogViewName a, LogViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LogViewName a, LogViewName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>LogSink</c> resource.</summary>
    public sealed partial class LogSinkName : gax::IResourceName, sys::IEquatable<LogSinkName>
    {
        /// <summary>The possible contents of <see cref="LogSinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/sinks/{sink}</c>.</summary>
            ProjectSink = 1,

            /// <summary>A resource name with pattern <c>organizations/{organization}/sinks/{sink}</c>.</summary>
            OrganizationSink = 2,

            /// <summary>A resource name with pattern <c>folders/{folder}/sinks/{sink}</c>.</summary>
            FolderSink = 3,

            /// <summary>A resource name with pattern <c>billingAccounts/{billing_account}/sinks/{sink}</c>.</summary>
            BillingAccountSink = 4,
        }

        private static gax::PathTemplate s_projectSink = new gax::PathTemplate("projects/{project}/sinks/{sink}");

        private static gax::PathTemplate s_organizationSink = new gax::PathTemplate("organizations/{organization}/sinks/{sink}");

        private static gax::PathTemplate s_folderSink = new gax::PathTemplate("folders/{folder}/sinks/{sink}");

        private static gax::PathTemplate s_billingAccountSink = new gax::PathTemplate("billingAccounts/{billing_account}/sinks/{sink}");

        /// <summary>Creates a <see cref="LogSinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LogSinkName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LogSinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LogSinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LogSinkName"/> with the pattern <c>projects/{project}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogSinkName"/> constructed from the provided ids.</returns>
        public static LogSinkName FromProjectSink(string projectId, string sinkId) =>
            new LogSinkName(ResourceNameType.ProjectSink, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>
        /// Creates a <see cref="LogSinkName"/> with the pattern <c>organizations/{organization}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogSinkName"/> constructed from the provided ids.</returns>
        public static LogSinkName FromOrganizationSink(string organizationId, string sinkId) =>
            new LogSinkName(ResourceNameType.OrganizationSink, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), sinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>
        /// Creates a <see cref="LogSinkName"/> with the pattern <c>folders/{folder}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogSinkName"/> constructed from the provided ids.</returns>
        public static LogSinkName FromFolderSink(string folderId, string sinkId) =>
            new LogSinkName(ResourceNameType.FolderSink, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), sinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>
        /// Creates a <see cref="LogSinkName"/> with the pattern <c>billingAccounts/{billing_account}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogSinkName"/> constructed from the provided ids.</returns>
        public static LogSinkName FromBillingAccountSink(string billingAccountId, string sinkId) =>
            new LogSinkName(ResourceNameType.BillingAccountSink, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), sinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogSinkName"/> with pattern
        /// <c>projects/{project}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogSinkName"/> with pattern <c>projects/{project}/sinks/{sink}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string sinkId) => FormatProjectSink(projectId, sinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogSinkName"/> with pattern
        /// <c>projects/{project}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogSinkName"/> with pattern <c>projects/{project}/sinks/{sink}</c>
        /// .
        /// </returns>
        public static string FormatProjectSink(string projectId, string sinkId) =>
            s_projectSink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogSinkName"/> with pattern
        /// <c>organizations/{organization}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogSinkName"/> with pattern
        /// <c>organizations/{organization}/sinks/{sink}</c>.
        /// </returns>
        public static string FormatOrganizationSink(string organizationId, string sinkId) =>
            s_organizationSink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogSinkName"/> with pattern
        /// <c>folders/{folder}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogSinkName"/> with pattern <c>folders/{folder}/sinks/{sink}</c>
        /// .
        /// </returns>
        public static string FormatFolderSink(string folderId, string sinkId) =>
            s_folderSink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogSinkName"/> with pattern
        /// <c>billingAccounts/{billing_account}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogSinkName"/> with pattern
        /// <c>billingAccounts/{billing_account}/sinks/{sink}</c>.
        /// </returns>
        public static string FormatBillingAccountSink(string billingAccountId, string sinkId) =>
            s_billingAccountSink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>Parses the given resource name string into a new <see cref="LogSinkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sinks/{sink}</c></description></item>
        /// <item><description><c>organizations/{organization}/sinks/{sink}</c></description></item>
        /// <item><description><c>folders/{folder}/sinks/{sink}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/sinks/{sink}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="logSinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LogSinkName"/> if successful.</returns>
        public static LogSinkName Parse(string logSinkName) => Parse(logSinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LogSinkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sinks/{sink}</c></description></item>
        /// <item><description><c>organizations/{organization}/sinks/{sink}</c></description></item>
        /// <item><description><c>folders/{folder}/sinks/{sink}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/sinks/{sink}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logSinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LogSinkName"/> if successful.</returns>
        public static LogSinkName Parse(string logSinkName, bool allowUnparsed) =>
            TryParse(logSinkName, allowUnparsed, out LogSinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogSinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sinks/{sink}</c></description></item>
        /// <item><description><c>organizations/{organization}/sinks/{sink}</c></description></item>
        /// <item><description><c>folders/{folder}/sinks/{sink}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/sinks/{sink}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="logSinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogSinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logSinkName, out LogSinkName result) => TryParse(logSinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogSinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sinks/{sink}</c></description></item>
        /// <item><description><c>organizations/{organization}/sinks/{sink}</c></description></item>
        /// <item><description><c>folders/{folder}/sinks/{sink}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/sinks/{sink}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logSinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogSinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logSinkName, bool allowUnparsed, out LogSinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(logSinkName, nameof(logSinkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSink.TryParseName(logSinkName, out resourceName))
            {
                result = FromProjectSink(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationSink.TryParseName(logSinkName, out resourceName))
            {
                result = FromOrganizationSink(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderSink.TryParseName(logSinkName, out resourceName))
            {
                result = FromFolderSink(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_billingAccountSink.TryParseName(logSinkName, out resourceName))
            {
                result = FromBillingAccountSink(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(logSinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LogSinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string folderId = null, string organizationId = null, string projectId = null, string sinkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            SinkId = sinkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LogSinkName"/> class from the component parts of pattern
        /// <c>projects/{project}/sinks/{sink}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        public LogSinkName(string projectId, string sinkId) : this(ResourceNameType.ProjectSink, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)))
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
        /// The <c>BillingAccount</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Sink</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string SinkId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSink: return s_projectSink.Expand(ProjectId, SinkId);
                case ResourceNameType.OrganizationSink: return s_organizationSink.Expand(OrganizationId, SinkId);
                case ResourceNameType.FolderSink: return s_folderSink.Expand(FolderId, SinkId);
                case ResourceNameType.BillingAccountSink: return s_billingAccountSink.Expand(BillingAccountId, SinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LogSinkName);

        /// <inheritdoc/>
        public bool Equals(LogSinkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LogSinkName a, LogSinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LogSinkName a, LogSinkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Link</c> resource.</summary>
    public sealed partial class LinkName : gax::IResourceName, sys::IEquatable<LinkName>
    {
        /// <summary>The possible contents of <see cref="LinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/buckets/{bucket}/links/{link}</c>
            /// .
            /// </summary>
            ProjectLocationBucketLink = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/links/{link}</c>.
            /// </summary>
            OrganizationLocationBucketLink = 2,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/buckets/{bucket}/links/{link}</c>.
            /// </summary>
            FolderLocationBucketLink = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/links/{link}</c>.
            /// </summary>
            BillingAccountLocationBucketLink = 4,
        }

        private static gax::PathTemplate s_projectLocationBucketLink = new gax::PathTemplate("projects/{project}/locations/{location}/buckets/{bucket}/links/{link}");

        private static gax::PathTemplate s_organizationLocationBucketLink = new gax::PathTemplate("organizations/{organization}/locations/{location}/buckets/{bucket}/links/{link}");

        private static gax::PathTemplate s_folderLocationBucketLink = new gax::PathTemplate("folders/{folder}/locations/{location}/buckets/{bucket}/links/{link}");

        private static gax::PathTemplate s_billingAccountLocationBucketLink = new gax::PathTemplate("billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/links/{link}");

        /// <summary>Creates a <see cref="LinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LinkName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LinkName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LinkName"/> constructed from the provided ids.</returns>
        public static LinkName FromProjectLocationBucketLink(string projectId, string locationId, string bucketId, string linkId) =>
            new LinkName(ResourceNameType.ProjectLocationBucketLink, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), linkId: gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)));

        /// <summary>
        /// Creates a <see cref="LinkName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LinkName"/> constructed from the provided ids.</returns>
        public static LinkName FromOrganizationLocationBucketLink(string organizationId, string locationId, string bucketId, string linkId) =>
            new LinkName(ResourceNameType.OrganizationLocationBucketLink, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), linkId: gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)));

        /// <summary>
        /// Creates a <see cref="LinkName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LinkName"/> constructed from the provided ids.</returns>
        public static LinkName FromFolderLocationBucketLink(string folderId, string locationId, string bucketId, string linkId) =>
            new LinkName(ResourceNameType.FolderLocationBucketLink, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), linkId: gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)));

        /// <summary>
        /// Creates a <see cref="LinkName"/> with the pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LinkName"/> constructed from the provided ids.</returns>
        public static LinkName FromBillingAccountLocationBucketLink(string billingAccountId, string locationId, string bucketId, string linkId) =>
            new LinkName(ResourceNameType.BillingAccountLocationBucketLink, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), linkId: gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LinkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LinkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string bucketId, string linkId) =>
            FormatProjectLocationBucketLink(projectId, locationId, bucketId, linkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LinkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LinkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </returns>
        public static string FormatProjectLocationBucketLink(string projectId, string locationId, string bucketId, string linkId) =>
            s_projectLocationBucketLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LinkName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LinkName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </returns>
        public static string FormatOrganizationLocationBucketLink(string organizationId, string locationId, string bucketId, string linkId) =>
            s_organizationLocationBucketLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LinkName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LinkName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </returns>
        public static string FormatFolderLocationBucketLink(string folderId, string locationId, string bucketId, string linkId) =>
            s_folderLocationBucketLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LinkName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LinkName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/links/{link}</c>.
        /// </returns>
        public static string FormatBillingAccountLocationBucketLink(string billingAccountId, string locationId, string bucketId, string linkId) =>
            s_billingAccountLocationBucketLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)));

        /// <summary>Parses the given resource name string into a new <see cref="LinkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/buckets/{bucket}/links/{link}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/links/{link}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/buckets/{bucket}/links/{link}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/links/{link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="linkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LinkName"/> if successful.</returns>
        public static LinkName Parse(string linkName) => Parse(linkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LinkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/buckets/{bucket}/links/{link}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/links/{link}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/buckets/{bucket}/links/{link}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/links/{link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="linkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LinkName"/> if successful.</returns>
        public static LinkName Parse(string linkName, bool allowUnparsed) =>
            TryParse(linkName, allowUnparsed, out LinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="LinkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/buckets/{bucket}/links/{link}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/links/{link}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/buckets/{bucket}/links/{link}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/links/{link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="linkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string linkName, out LinkName result) => TryParse(linkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/buckets/{bucket}/links/{link}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/buckets/{bucket}/links/{link}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/buckets/{bucket}/links/{link}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/buckets/{bucket}/links/{link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="linkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string linkName, bool allowUnparsed, out LinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(linkName, nameof(linkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBucketLink.TryParseName(linkName, out resourceName))
            {
                result = FromProjectLocationBucketLink(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_organizationLocationBucketLink.TryParseName(linkName, out resourceName))
            {
                result = FromOrganizationLocationBucketLink(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_folderLocationBucketLink.TryParseName(linkName, out resourceName))
            {
                result = FromFolderLocationBucketLink(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_billingAccountLocationBucketLink.TryParseName(linkName, out resourceName))
            {
                result = FromBillingAccountLocationBucketLink(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(linkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string bucketId = null, string folderId = null, string linkId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            BucketId = bucketId;
            FolderId = folderId;
            LinkId = linkId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LinkName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/links/{link}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        public LinkName(string projectId, string locationId, string bucketId, string linkId) : this(ResourceNameType.ProjectLocationBucketLink, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), linkId: gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)))
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
        /// The <c>BillingAccount</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>Bucket</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string BucketId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Link</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LinkId { get; }

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
                case ResourceNameType.ProjectLocationBucketLink: return s_projectLocationBucketLink.Expand(ProjectId, LocationId, BucketId, LinkId);
                case ResourceNameType.OrganizationLocationBucketLink: return s_organizationLocationBucketLink.Expand(OrganizationId, LocationId, BucketId, LinkId);
                case ResourceNameType.FolderLocationBucketLink: return s_folderLocationBucketLink.Expand(FolderId, LocationId, BucketId, LinkId);
                case ResourceNameType.BillingAccountLocationBucketLink: return s_billingAccountLocationBucketLink.Expand(BillingAccountId, LocationId, BucketId, LinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LinkName);

        /// <inheritdoc/>
        public bool Equals(LinkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LinkName a, LinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LinkName a, LinkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>LogExclusion</c> resource.</summary>
    public sealed partial class LogExclusionName : gax::IResourceName, sys::IEquatable<LogExclusionName>
    {
        /// <summary>The possible contents of <see cref="LogExclusionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/exclusions/{exclusion}</c>.</summary>
            ProjectExclusion = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/exclusions/{exclusion}</c>.
            /// </summary>
            OrganizationExclusion = 2,

            /// <summary>A resource name with pattern <c>folders/{folder}/exclusions/{exclusion}</c>.</summary>
            FolderExclusion = 3,

            /// <summary>
            /// A resource name with pattern <c>billingAccounts/{billing_account}/exclusions/{exclusion}</c>.
            /// </summary>
            BillingAccountExclusion = 4,
        }

        private static gax::PathTemplate s_projectExclusion = new gax::PathTemplate("projects/{project}/exclusions/{exclusion}");

        private static gax::PathTemplate s_organizationExclusion = new gax::PathTemplate("organizations/{organization}/exclusions/{exclusion}");

        private static gax::PathTemplate s_folderExclusion = new gax::PathTemplate("folders/{folder}/exclusions/{exclusion}");

        private static gax::PathTemplate s_billingAccountExclusion = new gax::PathTemplate("billingAccounts/{billing_account}/exclusions/{exclusion}");

        /// <summary>Creates a <see cref="LogExclusionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LogExclusionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LogExclusionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LogExclusionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LogExclusionName"/> with the pattern <c>projects/{project}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogExclusionName"/> constructed from the provided ids.</returns>
        public static LogExclusionName FromProjectExclusion(string projectId, string exclusionId) =>
            new LogExclusionName(ResourceNameType.ProjectExclusion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), exclusionId: gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Creates a <see cref="LogExclusionName"/> with the pattern
        /// <c>organizations/{organization}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogExclusionName"/> constructed from the provided ids.</returns>
        public static LogExclusionName FromOrganizationExclusion(string organizationId, string exclusionId) =>
            new LogExclusionName(ResourceNameType.OrganizationExclusion, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), exclusionId: gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Creates a <see cref="LogExclusionName"/> with the pattern <c>folders/{folder}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogExclusionName"/> constructed from the provided ids.</returns>
        public static LogExclusionName FromFolderExclusion(string folderId, string exclusionId) =>
            new LogExclusionName(ResourceNameType.FolderExclusion, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), exclusionId: gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Creates a <see cref="LogExclusionName"/> with the pattern
        /// <c>billingAccounts/{billing_account}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogExclusionName"/> constructed from the provided ids.</returns>
        public static LogExclusionName FromBillingAccountExclusion(string billingAccountId, string exclusionId) =>
            new LogExclusionName(ResourceNameType.BillingAccountExclusion, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), exclusionId: gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogExclusionName"/> with pattern
        /// <c>projects/{project}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogExclusionName"/> with pattern
        /// <c>projects/{project}/exclusions/{exclusion}</c>.
        /// </returns>
        public static string Format(string projectId, string exclusionId) => FormatProjectExclusion(projectId, exclusionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogExclusionName"/> with pattern
        /// <c>projects/{project}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogExclusionName"/> with pattern
        /// <c>projects/{project}/exclusions/{exclusion}</c>.
        /// </returns>
        public static string FormatProjectExclusion(string projectId, string exclusionId) =>
            s_projectExclusion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogExclusionName"/> with pattern
        /// <c>organizations/{organization}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogExclusionName"/> with pattern
        /// <c>organizations/{organization}/exclusions/{exclusion}</c>.
        /// </returns>
        public static string FormatOrganizationExclusion(string organizationId, string exclusionId) =>
            s_organizationExclusion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogExclusionName"/> with pattern
        /// <c>folders/{folder}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogExclusionName"/> with pattern
        /// <c>folders/{folder}/exclusions/{exclusion}</c>.
        /// </returns>
        public static string FormatFolderExclusion(string folderId, string exclusionId) =>
            s_folderExclusion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogExclusionName"/> with pattern
        /// <c>billingAccounts/{billing_account}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogExclusionName"/> with pattern
        /// <c>billingAccounts/{billing_account}/exclusions/{exclusion}</c>.
        /// </returns>
        public static string FormatBillingAccountExclusion(string billingAccountId, string exclusionId) =>
            s_billingAccountExclusion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>Parses the given resource name string into a new <see cref="LogExclusionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>organizations/{organization}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>folders/{folder}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/exclusions/{exclusion}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="logExclusionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LogExclusionName"/> if successful.</returns>
        public static LogExclusionName Parse(string logExclusionName) => Parse(logExclusionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LogExclusionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>organizations/{organization}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>folders/{folder}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/exclusions/{exclusion}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logExclusionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LogExclusionName"/> if successful.</returns>
        public static LogExclusionName Parse(string logExclusionName, bool allowUnparsed) =>
            TryParse(logExclusionName, allowUnparsed, out LogExclusionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogExclusionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>organizations/{organization}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>folders/{folder}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/exclusions/{exclusion}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="logExclusionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogExclusionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logExclusionName, out LogExclusionName result) =>
            TryParse(logExclusionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogExclusionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>organizations/{organization}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>folders/{folder}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/exclusions/{exclusion}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logExclusionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogExclusionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logExclusionName, bool allowUnparsed, out LogExclusionName result)
        {
            gax::GaxPreconditions.CheckNotNull(logExclusionName, nameof(logExclusionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectExclusion.TryParseName(logExclusionName, out resourceName))
            {
                result = FromProjectExclusion(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationExclusion.TryParseName(logExclusionName, out resourceName))
            {
                result = FromOrganizationExclusion(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderExclusion.TryParseName(logExclusionName, out resourceName))
            {
                result = FromFolderExclusion(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_billingAccountExclusion.TryParseName(logExclusionName, out resourceName))
            {
                result = FromBillingAccountExclusion(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(logExclusionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LogExclusionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string exclusionId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            ExclusionId = exclusionId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LogExclusionName"/> class from the component parts of pattern
        /// <c>projects/{project}/exclusions/{exclusion}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        public LogExclusionName(string projectId, string exclusionId) : this(ResourceNameType.ProjectExclusion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), exclusionId: gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)))
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
        /// The <c>BillingAccount</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>Exclusion</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ExclusionId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

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
                case ResourceNameType.ProjectExclusion: return s_projectExclusion.Expand(ProjectId, ExclusionId);
                case ResourceNameType.OrganizationExclusion: return s_organizationExclusion.Expand(OrganizationId, ExclusionId);
                case ResourceNameType.FolderExclusion: return s_folderExclusion.Expand(FolderId, ExclusionId);
                case ResourceNameType.BillingAccountExclusion: return s_billingAccountExclusion.Expand(BillingAccountId, ExclusionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LogExclusionName);

        /// <inheritdoc/>
        public bool Equals(LogExclusionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LogExclusionName a, LogExclusionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LogExclusionName a, LogExclusionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CmekSettings</c> resource.</summary>
    public sealed partial class CmekSettingsName : gax::IResourceName, sys::IEquatable<CmekSettingsName>
    {
        /// <summary>The possible contents of <see cref="CmekSettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/cmekSettings</c>.</summary>
            Project = 1,

            /// <summary>A resource name with pattern <c>organizations/{organization}/cmekSettings</c>.</summary>
            Organization = 2,

            /// <summary>A resource name with pattern <c>folders/{folder}/cmekSettings</c>.</summary>
            Folder = 3,

            /// <summary>A resource name with pattern <c>billingAccounts/{billing_account}/cmekSettings</c>.</summary>
            BillingAccount = 4,
        }

        private static gax::PathTemplate s_project = new gax::PathTemplate("projects/{project}/cmekSettings");

        private static gax::PathTemplate s_organization = new gax::PathTemplate("organizations/{organization}/cmekSettings");

        private static gax::PathTemplate s_folder = new gax::PathTemplate("folders/{folder}/cmekSettings");

        private static gax::PathTemplate s_billingAccount = new gax::PathTemplate("billingAccounts/{billing_account}/cmekSettings");

        /// <summary>Creates a <see cref="CmekSettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CmekSettingsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CmekSettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CmekSettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CmekSettingsName"/> with the pattern <c>projects/{project}/cmekSettings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CmekSettingsName"/> constructed from the provided ids.</returns>
        public static CmekSettingsName FromProject(string projectId) =>
            new CmekSettingsName(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Creates a <see cref="CmekSettingsName"/> with the pattern <c>organizations/{organization}/cmekSettings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CmekSettingsName"/> constructed from the provided ids.</returns>
        public static CmekSettingsName FromOrganization(string organizationId) =>
            new CmekSettingsName(ResourceNameType.Organization, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>
        /// Creates a <see cref="CmekSettingsName"/> with the pattern <c>folders/{folder}/cmekSettings</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CmekSettingsName"/> constructed from the provided ids.</returns>
        public static CmekSettingsName FromFolder(string folderId) =>
            new CmekSettingsName(ResourceNameType.Folder, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>
        /// Creates a <see cref="CmekSettingsName"/> with the pattern <c>billingAccounts/{billing_account}/cmekSettings</c>
        /// .
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CmekSettingsName"/> constructed from the provided ids.</returns>
        public static CmekSettingsName FromBillingAccount(string billingAccountId) =>
            new CmekSettingsName(ResourceNameType.BillingAccount, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CmekSettingsName"/> with pattern
        /// <c>projects/{project}/cmekSettings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CmekSettingsName"/> with pattern
        /// <c>projects/{project}/cmekSettings</c>.
        /// </returns>
        public static string Format(string projectId) => FormatProject(projectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CmekSettingsName"/> with pattern
        /// <c>projects/{project}/cmekSettings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CmekSettingsName"/> with pattern
        /// <c>projects/{project}/cmekSettings</c>.
        /// </returns>
        public static string FormatProject(string projectId) =>
            s_project.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CmekSettingsName"/> with pattern
        /// <c>organizations/{organization}/cmekSettings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CmekSettingsName"/> with pattern
        /// <c>organizations/{organization}/cmekSettings</c>.
        /// </returns>
        public static string FormatOrganization(string organizationId) =>
            s_organization.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CmekSettingsName"/> with pattern
        /// <c>folders/{folder}/cmekSettings</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CmekSettingsName"/> with pattern
        /// <c>folders/{folder}/cmekSettings</c>.
        /// </returns>
        public static string FormatFolder(string folderId) =>
            s_folder.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CmekSettingsName"/> with pattern
        /// <c>billingAccounts/{billing_account}/cmekSettings</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CmekSettingsName"/> with pattern
        /// <c>billingAccounts/{billing_account}/cmekSettings</c>.
        /// </returns>
        public static string FormatBillingAccount(string billingAccountId) =>
            s_billingAccount.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)));

        /// <summary>Parses the given resource name string into a new <see cref="CmekSettingsName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/cmekSettings</c></description></item>
        /// <item><description><c>organizations/{organization}/cmekSettings</c></description></item>
        /// <item><description><c>folders/{folder}/cmekSettings</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/cmekSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="cmekSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CmekSettingsName"/> if successful.</returns>
        public static CmekSettingsName Parse(string cmekSettingsName) => Parse(cmekSettingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CmekSettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/cmekSettings</c></description></item>
        /// <item><description><c>organizations/{organization}/cmekSettings</c></description></item>
        /// <item><description><c>folders/{folder}/cmekSettings</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/cmekSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cmekSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CmekSettingsName"/> if successful.</returns>
        public static CmekSettingsName Parse(string cmekSettingsName, bool allowUnparsed) =>
            TryParse(cmekSettingsName, allowUnparsed, out CmekSettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CmekSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/cmekSettings</c></description></item>
        /// <item><description><c>organizations/{organization}/cmekSettings</c></description></item>
        /// <item><description><c>folders/{folder}/cmekSettings</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/cmekSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="cmekSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CmekSettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cmekSettingsName, out CmekSettingsName result) =>
            TryParse(cmekSettingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CmekSettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/cmekSettings</c></description></item>
        /// <item><description><c>organizations/{organization}/cmekSettings</c></description></item>
        /// <item><description><c>folders/{folder}/cmekSettings</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/cmekSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cmekSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CmekSettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cmekSettingsName, bool allowUnparsed, out CmekSettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(cmekSettingsName, nameof(cmekSettingsName));
            gax::TemplatedResourceName resourceName;
            if (s_project.TryParseName(cmekSettingsName, out resourceName))
            {
                result = FromProject(resourceName[0]);
                return true;
            }
            if (s_organization.TryParseName(cmekSettingsName, out resourceName))
            {
                result = FromOrganization(resourceName[0]);
                return true;
            }
            if (s_folder.TryParseName(cmekSettingsName, out resourceName))
            {
                result = FromFolder(resourceName[0]);
                return true;
            }
            if (s_billingAccount.TryParseName(cmekSettingsName, out resourceName))
            {
                result = FromBillingAccount(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cmekSettingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CmekSettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CmekSettingsName"/> class from the component parts of pattern
        /// <c>projects/{project}/cmekSettings</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        public CmekSettingsName(string projectId) : this(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)))
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
        /// The <c>BillingAccount</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

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
                case ResourceNameType.Project: return s_project.Expand(ProjectId);
                case ResourceNameType.Organization: return s_organization.Expand(OrganizationId);
                case ResourceNameType.Folder: return s_folder.Expand(FolderId);
                case ResourceNameType.BillingAccount: return s_billingAccount.Expand(BillingAccountId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CmekSettingsName);

        /// <inheritdoc/>
        public bool Equals(CmekSettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CmekSettingsName a, CmekSettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CmekSettingsName a, CmekSettingsName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Settings</c> resource.</summary>
    public sealed partial class SettingsName : gax::IResourceName, sys::IEquatable<SettingsName>
    {
        /// <summary>The possible contents of <see cref="SettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/settings</c>.</summary>
            Project = 1,

            /// <summary>A resource name with pattern <c>organizations/{organization}/settings</c>.</summary>
            Organization = 2,

            /// <summary>A resource name with pattern <c>folders/{folder}/settings</c>.</summary>
            Folder = 3,

            /// <summary>A resource name with pattern <c>billingAccounts/{billing_account}/settings</c>.</summary>
            BillingAccount = 4,
        }

        private static gax::PathTemplate s_project = new gax::PathTemplate("projects/{project}/settings");

        private static gax::PathTemplate s_organization = new gax::PathTemplate("organizations/{organization}/settings");

        private static gax::PathTemplate s_folder = new gax::PathTemplate("folders/{folder}/settings");

        private static gax::PathTemplate s_billingAccount = new gax::PathTemplate("billingAccounts/{billing_account}/settings");

        /// <summary>Creates a <see cref="SettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SettingsName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static SettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="SettingsName"/> with the pattern <c>projects/{project}/settings</c>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromProject(string projectId) =>
            new SettingsName(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Creates a <see cref="SettingsName"/> with the pattern <c>organizations/{organization}/settings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromOrganization(string organizationId) =>
            new SettingsName(ResourceNameType.Organization, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>Creates a <see cref="SettingsName"/> with the pattern <c>folders/{folder}/settings</c>.</summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromFolder(string folderId) =>
            new SettingsName(ResourceNameType.Folder, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>
        /// Creates a <see cref="SettingsName"/> with the pattern <c>billingAccounts/{billing_account}/settings</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromBillingAccount(string billingAccountId) =>
            new SettingsName(ResourceNameType.BillingAccount, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern <c>projects/{project}/settings</c>
        /// .
        /// </returns>
        public static string Format(string projectId) => FormatProject(projectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern <c>projects/{project}/settings</c>
        /// .
        /// </returns>
        public static string FormatProject(string projectId) =>
            s_project.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>organizations/{organization}/settings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>organizations/{organization}/settings</c>.
        /// </returns>
        public static string FormatOrganization(string organizationId) =>
            s_organization.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>folders/{folder}/settings</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern <c>folders/{folder}/settings</c>.
        /// </returns>
        public static string FormatFolder(string folderId) =>
            s_folder.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>billingAccounts/{billing_account}/settings</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>billingAccounts/{billing_account}/settings</c>.
        /// </returns>
        public static string FormatBillingAccount(string billingAccountId) =>
            s_billingAccount.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)));

        /// <summary>Parses the given resource name string into a new <see cref="SettingsName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/settings</c></description></item>
        /// <item><description><c>organizations/{organization}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/settings</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/settings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName) => Parse(settingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SettingsName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/settings</c></description></item>
        /// <item><description><c>organizations/{organization}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/settings</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/settings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName, bool allowUnparsed) =>
            TryParse(settingsName, allowUnparsed, out SettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/settings</c></description></item>
        /// <item><description><c>organizations/{organization}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/settings</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/settings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, out SettingsName result) => TryParse(settingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/settings</c></description></item>
        /// <item><description><c>organizations/{organization}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/settings</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/settings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, bool allowUnparsed, out SettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(settingsName, nameof(settingsName));
            gax::TemplatedResourceName resourceName;
            if (s_project.TryParseName(settingsName, out resourceName))
            {
                result = FromProject(resourceName[0]);
                return true;
            }
            if (s_organization.TryParseName(settingsName, out resourceName))
            {
                result = FromOrganization(resourceName[0]);
                return true;
            }
            if (s_folder.TryParseName(settingsName, out resourceName))
            {
                result = FromFolder(resourceName[0]);
                return true;
            }
            if (s_billingAccount.TryParseName(settingsName, out resourceName))
            {
                result = FromBillingAccount(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(settingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SettingsName"/> class from the component parts of pattern
        /// <c>projects/{project}/settings</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        public SettingsName(string projectId) : this(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)))
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
        /// The <c>BillingAccount</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

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
                case ResourceNameType.Project: return s_project.Expand(ProjectId);
                case ResourceNameType.Organization: return s_organization.Expand(OrganizationId);
                case ResourceNameType.Folder: return s_folder.Expand(FolderId);
                case ResourceNameType.BillingAccount: return s_billingAccount.Expand(BillingAccountId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SettingsName);

        /// <inheritdoc/>
        public bool Equals(SettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SettingsName a, SettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SettingsName a, SettingsName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>OrganizationLocation</c> resource.</summary>
    public sealed partial class OrganizationLocationName : gax::IResourceName, sys::IEquatable<OrganizationLocationName>
    {
        /// <summary>The possible contents of <see cref="OrganizationLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/locations/{location}</c>.
            /// </summary>
            OrganizationLocation = 1,
        }

        private static gax::PathTemplate s_organizationLocation = new gax::PathTemplate("organizations/{organization}/locations/{location}");

        /// <summary>Creates a <see cref="OrganizationLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrganizationLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrganizationLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrganizationLocationName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationLocationName"/> constructed from the provided ids.
        /// </returns>
        public static OrganizationLocationName FromOrganizationLocation(string organizationId, string locationId) =>
            new OrganizationLocationName(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId) =>
            FormatOrganizationLocation(organizationId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string FormatOrganizationLocation(string organizationId, string locationId) =>
            s_organizationLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationLocationName"/> if successful.</returns>
        public static OrganizationLocationName Parse(string organizationLocationName) =>
            Parse(organizationLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrganizationLocationName"/> if successful.</returns>
        public static OrganizationLocationName Parse(string organizationLocationName, bool allowUnparsed) =>
            TryParse(organizationLocationName, allowUnparsed, out OrganizationLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLocationName, out OrganizationLocationName result) =>
            TryParse(organizationLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLocationName, bool allowUnparsed, out OrganizationLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationLocationName, nameof(organizationLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocation.TryParseName(organizationLocationName, out resourceName))
            {
                result = FromOrganizationLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(organizationLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrganizationLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrganizationLocationName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/locations/{location}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public OrganizationLocationName(string organizationId, string locationId) : this(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        /// The <c>Organization</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationLocation: return s_organizationLocation.Expand(OrganizationId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrganizationLocationName);

        /// <inheritdoc/>
        public bool Equals(OrganizationLocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrganizationLocationName a, OrganizationLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrganizationLocationName a, OrganizationLocationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FolderLocation</c> resource.</summary>
    public sealed partial class FolderLocationName : gax::IResourceName, sys::IEquatable<FolderLocationName>
    {
        /// <summary>The possible contents of <see cref="FolderLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>folders/{folder}/locations/{location}</c>.</summary>
            FolderLocation = 1,
        }

        private static gax::PathTemplate s_folderLocation = new gax::PathTemplate("folders/{folder}/locations/{location}");

        /// <summary>Creates a <see cref="FolderLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FolderLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FolderLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FolderLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FolderLocationName"/> with the pattern <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FolderLocationName"/> constructed from the provided ids.</returns>
        public static FolderLocationName FromFolderLocation(string folderId, string locationId) =>
            new FolderLocationName(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </returns>
        public static string Format(string folderId, string locationId) => FormatFolderLocation(folderId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </returns>
        public static string FormatFolderLocation(string folderId, string locationId) =>
            s_folderLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FolderLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FolderLocationName"/> if successful.</returns>
        public static FolderLocationName Parse(string folderLocationName) => Parse(folderLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FolderLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FolderLocationName"/> if successful.</returns>
        public static FolderLocationName Parse(string folderLocationName, bool allowUnparsed) =>
            TryParse(folderLocationName, allowUnparsed, out FolderLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FolderLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FolderLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderLocationName, out FolderLocationName result) =>
            TryParse(folderLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FolderLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FolderLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderLocationName, bool allowUnparsed, out FolderLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(folderLocationName, nameof(folderLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_folderLocation.TryParseName(folderLocationName, out resourceName))
            {
                result = FromFolderLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(folderLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FolderLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FolderLocationName"/> class from the component parts of pattern
        /// <c>folders/{folder}/locations/{location}</c>
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public FolderLocationName(string folderId, string locationId) : this(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        /// The <c>Folder</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.FolderLocation: return s_folderLocation.Expand(FolderId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FolderLocationName);

        /// <inheritdoc/>
        public bool Equals(FolderLocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FolderLocationName a, FolderLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FolderLocationName a, FolderLocationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>BillingAccountLocation</c> resource.</summary>
    public sealed partial class BillingAccountLocationName : gax::IResourceName, sys::IEquatable<BillingAccountLocationName>
    {
        /// <summary>The possible contents of <see cref="BillingAccountLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>billingAccounts/{billing_account}/locations/{location}</c>.
            /// </summary>
            BillingAccountLocation = 1,
        }

        private static gax::PathTemplate s_billingAccountLocation = new gax::PathTemplate("billingAccounts/{billing_account}/locations/{location}");

        /// <summary>Creates a <see cref="BillingAccountLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BillingAccountLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BillingAccountLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BillingAccountLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BillingAccountLocationName"/> with the pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="BillingAccountLocationName"/> constructed from the provided ids.
        /// </returns>
        public static BillingAccountLocationName FromBillingAccountLocation(string billingAccountId, string locationId) =>
            new BillingAccountLocationName(ResourceNameType.BillingAccountLocation, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BillingAccountLocationName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BillingAccountLocationName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}</c>.
        /// </returns>
        public static string Format(string billingAccountId, string locationId) =>
            FormatBillingAccountLocation(billingAccountId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BillingAccountLocationName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BillingAccountLocationName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}</c>.
        /// </returns>
        public static string FormatBillingAccountLocation(string billingAccountId, string locationId) =>
            s_billingAccountLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BillingAccountLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>billingAccounts/{billing_account}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="billingAccountLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BillingAccountLocationName"/> if successful.</returns>
        public static BillingAccountLocationName Parse(string billingAccountLocationName) =>
            Parse(billingAccountLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BillingAccountLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>billingAccounts/{billing_account}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="billingAccountLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BillingAccountLocationName"/> if successful.</returns>
        public static BillingAccountLocationName Parse(string billingAccountLocationName, bool allowUnparsed) =>
            TryParse(billingAccountLocationName, allowUnparsed, out BillingAccountLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BillingAccountLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>billingAccounts/{billing_account}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="billingAccountLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BillingAccountLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string billingAccountLocationName, out BillingAccountLocationName result) =>
            TryParse(billingAccountLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BillingAccountLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>billingAccounts/{billing_account}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="billingAccountLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BillingAccountLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string billingAccountLocationName, bool allowUnparsed, out BillingAccountLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(billingAccountLocationName, nameof(billingAccountLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_billingAccountLocation.TryParseName(billingAccountLocationName, out resourceName))
            {
                result = FromBillingAccountLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(billingAccountLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BillingAccountLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string locationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            LocationId = locationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BillingAccountLocationName"/> class from the component parts of
        /// pattern <c>billingAccounts/{billing_account}/locations/{location}</c>
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public BillingAccountLocationName(string billingAccountId, string locationId) : this(ResourceNameType.BillingAccountLocation, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        /// The <c>BillingAccount</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.BillingAccountLocation: return s_billingAccountLocation.Expand(BillingAccountId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BillingAccountLocationName);

        /// <inheritdoc/>
        public bool Equals(BillingAccountLocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BillingAccountLocationName a, BillingAccountLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BillingAccountLocationName a, BillingAccountLocationName b) => !(a == b);
    }

    public partial class LogBucket
    {
        /// <summary>
        /// <see cref="gclv::LogBucketName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogBucketName LogBucketName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogBucketName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LogView
    {
        /// <summary>
        /// <see cref="gclv::LogViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogViewName LogViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LogSink
    {
        /// <summary>
        /// <see cref="gclv::LogSinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogSinkName LogSinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogSinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Destination"/> resource name property.
        /// </summary>
        public gax::IResourceName DestinationAsResourceName
        {
            get => string.IsNullOrEmpty(Destination) ? null : gax::UnparsedResourceName.Parse(Destination);
            set => Destination = value?.ToString() ?? "";
        }
    }

    public partial class Link
    {
        /// <summary>
        /// <see cref="gclv::LinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LinkName LinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBucketsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="BillingAccountLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public BillingAccountLocationName ParentAsBillingAccountLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BillingAccountLocationName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                if (BillingAccountLocationName.TryParse(Parent, out BillingAccountLocationName billingAccountLocation))
                {
                    return billingAccountLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateBucketRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="BillingAccountLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public BillingAccountLocationName ParentAsBillingAccountLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BillingAccountLocationName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                if (BillingAccountLocationName.TryParse(Parent, out BillingAccountLocationName billingAccountLocation))
                {
                    return billingAccountLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateBucketRequest
    {
        /// <summary>
        /// <see cref="gclv::LogBucketName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogBucketName LogBucketName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogBucketName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetBucketRequest
    {
        /// <summary>
        /// <see cref="gclv::LogBucketName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogBucketName LogBucketName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogBucketName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBucketRequest
    {
        /// <summary>
        /// <see cref="gclv::LogBucketName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogBucketName LogBucketName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogBucketName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UndeleteBucketRequest
    {
        /// <summary>
        /// <see cref="gclv::LogBucketName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogBucketName LogBucketName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogBucketName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetViewRequest
    {
        /// <summary>
        /// <see cref="gclv::LogViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogViewName LogViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteViewRequest
    {
        /// <summary>
        /// <see cref="gclv::LogViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogViewName LogViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSinksRequest
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
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::FolderName ParentAsFolderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::FolderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName ParentAsBillingAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::BillingAccountName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::BillingAccountName.TryParse(Parent, out gagr::BillingAccountName billingAccount))
                {
                    return billingAccount;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSinkRequest
    {
        /// <summary>
        /// <see cref="LogSinkName"/>-typed view over the <see cref="SinkName"/> resource name property.
        /// </summary>
        public LogSinkName SinkNameAsLogSinkName
        {
            get => string.IsNullOrEmpty(SinkName) ? null : LogSinkName.Parse(SinkName, allowUnparsed: true);
            set => SinkName = value?.ToString() ?? "";
        }
    }

    public partial class CreateSinkRequest
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
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::FolderName ParentAsFolderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::FolderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName ParentAsBillingAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::BillingAccountName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::BillingAccountName.TryParse(Parent, out gagr::BillingAccountName billingAccount))
                {
                    return billingAccount;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateSinkRequest
    {
        /// <summary>
        /// <see cref="LogSinkName"/>-typed view over the <see cref="SinkName"/> resource name property.
        /// </summary>
        public LogSinkName SinkNameAsLogSinkName
        {
            get => string.IsNullOrEmpty(SinkName) ? null : LogSinkName.Parse(SinkName, allowUnparsed: true);
            set => SinkName = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSinkRequest
    {
        /// <summary>
        /// <see cref="LogSinkName"/>-typed view over the <see cref="SinkName"/> resource name property.
        /// </summary>
        public LogSinkName SinkNameAsLogSinkName
        {
            get => string.IsNullOrEmpty(SinkName) ? null : LogSinkName.Parse(SinkName, allowUnparsed: true);
            set => SinkName = value?.ToString() ?? "";
        }
    }

    public partial class CreateLinkRequest
    {
        /// <summary>
        /// <see cref="LogBucketName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LogBucketName ParentAsLogBucketName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LogBucketName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteLinkRequest
    {
        /// <summary>
        /// <see cref="gclv::LinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LinkName LinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLinksRequest
    {
        /// <summary>
        /// <see cref="LogBucketName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LogBucketName ParentAsLogBucketName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LogBucketName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetLinkRequest
    {
        /// <summary>
        /// <see cref="gclv::LinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LinkName LinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LogExclusion
    {
        /// <summary>
        /// <see cref="gclv::LogExclusionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogExclusionName LogExclusionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogExclusionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListExclusionsRequest
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
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::FolderName ParentAsFolderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::FolderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName ParentAsBillingAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::BillingAccountName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::BillingAccountName.TryParse(Parent, out gagr::BillingAccountName billingAccount))
                {
                    return billingAccount;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetExclusionRequest
    {
        /// <summary>
        /// <see cref="gclv::LogExclusionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogExclusionName LogExclusionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogExclusionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateExclusionRequest
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
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::FolderName ParentAsFolderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::FolderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName ParentAsBillingAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::BillingAccountName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::BillingAccountName.TryParse(Parent, out gagr::BillingAccountName billingAccount))
                {
                    return billingAccount;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateExclusionRequest
    {
        /// <summary>
        /// <see cref="gclv::LogExclusionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogExclusionName LogExclusionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogExclusionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteExclusionRequest
    {
        /// <summary>
        /// <see cref="gclv::LogExclusionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogExclusionName LogExclusionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogExclusionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetCmekSettingsRequest
    {
        /// <summary>
        /// <see cref="gclv::CmekSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::CmekSettingsName CmekSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::CmekSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CmekSettings
    {
        /// <summary>
        /// <see cref="gclv::CmekSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::CmekSettingsName CmekSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::CmekSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSettingsRequest
    {
        /// <summary>
        /// <see cref="gclv::SettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::SettingsName SettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::SettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Settings
    {
        /// <summary>
        /// <see cref="gclv::SettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::SettingsName SettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::SettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

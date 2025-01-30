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
using gcav = Google.Cloud.ApiHub.V1;
using sys = System;

namespace Google.Cloud.ApiHub.V1
{
    /// <summary>Resource name for the <c>Api</c> resource.</summary>
    public sealed partial class ApiName : gax::IResourceName, sys::IEquatable<ApiName>
    {
        /// <summary>The possible contents of <see cref="ApiName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/apis/{api}</c>.
            /// </summary>
            ProjectLocationApi = 1,
        }

        private static gax::PathTemplate s_projectLocationApi = new gax::PathTemplate("projects/{project}/locations/{location}/apis/{api}");

        /// <summary>Creates a <see cref="ApiName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApiName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApiName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApiName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApiName"/> with the pattern <c>projects/{project}/locations/{location}/apis/{api}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ApiName"/> constructed from the provided ids.</returns>
        public static ApiName FromProjectLocationApi(string projectId, string locationId, string apiId) =>
            new ApiName(ResourceNameType.ProjectLocationApi, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string apiId) =>
            FormatProjectLocationApi(projectId, locationId, apiId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}</c>.
        /// </returns>
        public static string FormatProjectLocationApi(string projectId, string locationId, string apiId) =>
            s_projectLocationApi.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)));

        /// <summary>Parses the given resource name string into a new <see cref="ApiName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/apis/{api}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="apiName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ApiName"/> if successful.</returns>
        public static ApiName Parse(string apiName) => Parse(apiName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApiName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/apis/{api}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="apiName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ApiName"/> if successful.</returns>
        public static ApiName Parse(string apiName, bool allowUnparsed) =>
            TryParse(apiName, allowUnparsed, out ApiName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="ApiName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/apis/{api}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="apiName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiName, out ApiName result) => TryParse(apiName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApiName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/apis/{api}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="apiName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiName, bool allowUnparsed, out ApiName result)
        {
            gax::GaxPreconditions.CheckNotNull(apiName, nameof(apiName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApi.TryParseName(apiName, out resourceName))
            {
                result = FromProjectLocationApi(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(apiName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ApiName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApiId = apiId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ApiName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        public ApiName(string projectId, string locationId, string apiId) : this(ResourceNameType.ProjectLocationApi, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)))
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
        /// The <c>Api</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ApiId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationApi: return s_projectLocationApi.Expand(ProjectId, LocationId, ApiId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ApiName);

        /// <inheritdoc/>
        public bool Equals(ApiName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ApiName a, ApiName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ApiName a, ApiName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Version</c> resource.</summary>
    public sealed partial class VersionName : gax::IResourceName, sys::IEquatable<VersionName>
    {
        /// <summary>The possible contents of <see cref="VersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c>
            /// .
            /// </summary>
            ProjectLocationApiVersion = 1,
        }

        private static gax::PathTemplate s_projectLocationApiVersion = new gax::PathTemplate("projects/{project}/locations/{location}/apis/{api}/versions/{version}");

        /// <summary>Creates a <see cref="VersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VersionName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VersionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VersionName"/> constructed from the provided ids.</returns>
        public static VersionName FromProjectLocationApiVersion(string projectId, string locationId, string apiId, string versionId) =>
            new VersionName(ResourceNameType.ProjectLocationApiVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string apiId, string versionId) =>
            FormatProjectLocationApiVersion(projectId, locationId, apiId, versionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c>.
        /// </returns>
        public static string FormatProjectLocationApiVersion(string projectId, string locationId, string apiId, string versionId) =>
            s_projectLocationApiVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>Parses the given resource name string into a new <see cref="VersionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="versionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VersionName"/> if successful.</returns>
        public static VersionName Parse(string versionName) => Parse(versionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VersionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="versionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VersionName"/> if successful.</returns>
        public static VersionName Parse(string versionName, bool allowUnparsed) =>
            TryParse(versionName, allowUnparsed, out VersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="versionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string versionName, out VersionName result) => TryParse(versionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="versionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string versionName, bool allowUnparsed, out VersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(versionName, nameof(versionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApiVersion.TryParseName(versionName, out resourceName))
            {
                result = FromProjectLocationApiVersion(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(versionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiId = null, string locationId = null, string projectId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApiId = apiId;
            LocationId = locationId;
            ProjectId = projectId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        public VersionName(string projectId, string locationId, string apiId, string versionId) : this(ResourceNameType.ProjectLocationApiVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)))
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
        /// The <c>Api</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ApiId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Version</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VersionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationApiVersion: return s_projectLocationApiVersion.Expand(ProjectId, LocationId, ApiId, VersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VersionName);

        /// <inheritdoc/>
        public bool Equals(VersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VersionName a, VersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VersionName a, VersionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Spec</c> resource.</summary>
    public sealed partial class SpecName : gax::IResourceName, sys::IEquatable<SpecName>
    {
        /// <summary>The possible contents of <see cref="SpecName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>.
            /// </summary>
            ProjectLocationApiVersionSpec = 1,
        }

        private static gax::PathTemplate s_projectLocationApiVersionSpec = new gax::PathTemplate("projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}");

        /// <summary>Creates a <see cref="SpecName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SpecName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SpecName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SpecName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SpecName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specId">The <c>Spec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SpecName"/> constructed from the provided ids.</returns>
        public static SpecName FromProjectLocationApiVersionSpec(string projectId, string locationId, string apiId, string versionId, string specId) =>
            new SpecName(ResourceNameType.ProjectLocationApiVersionSpec, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), specId: gax::GaxPreconditions.CheckNotNullOrEmpty(specId, nameof(specId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specId">The <c>Spec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string apiId, string versionId, string specId) =>
            FormatProjectLocationApiVersionSpec(projectId, locationId, apiId, versionId, specId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specId">The <c>Spec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>.
        /// </returns>
        public static string FormatProjectLocationApiVersionSpec(string projectId, string locationId, string apiId, string versionId, string specId) =>
            s_projectLocationApiVersionSpec.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(specId, nameof(specId)));

        /// <summary>Parses the given resource name string into a new <see cref="SpecName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="specName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SpecName"/> if successful.</returns>
        public static SpecName Parse(string specName) => Parse(specName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SpecName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="specName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SpecName"/> if successful.</returns>
        public static SpecName Parse(string specName, bool allowUnparsed) =>
            TryParse(specName, allowUnparsed, out SpecName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="SpecName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="specName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SpecName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string specName, out SpecName result) => TryParse(specName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SpecName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="specName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SpecName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string specName, bool allowUnparsed, out SpecName result)
        {
            gax::GaxPreconditions.CheckNotNull(specName, nameof(specName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApiVersionSpec.TryParseName(specName, out resourceName))
            {
                result = FromProjectLocationApiVersionSpec(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(specName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SpecName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiId = null, string locationId = null, string projectId = null, string specId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApiId = apiId;
            LocationId = locationId;
            ProjectId = projectId;
            SpecId = specId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SpecName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specId">The <c>Spec</c> ID. Must not be <c>null</c> or empty.</param>
        public SpecName(string projectId, string locationId, string apiId, string versionId, string specId) : this(ResourceNameType.ProjectLocationApiVersionSpec, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), specId: gax::GaxPreconditions.CheckNotNullOrEmpty(specId, nameof(specId)))
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
        /// The <c>Api</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ApiId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Spec</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpecId { get; }

        /// <summary>
        /// The <c>Version</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VersionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationApiVersionSpec: return s_projectLocationApiVersionSpec.Expand(ProjectId, LocationId, ApiId, VersionId, SpecId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SpecName);

        /// <inheritdoc/>
        public bool Equals(SpecName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SpecName a, SpecName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SpecName a, SpecName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Deployment</c> resource.</summary>
    public sealed partial class DeploymentName : gax::IResourceName, sys::IEquatable<DeploymentName>
    {
        /// <summary>The possible contents of <see cref="DeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/deployments/{deployment}</c>.
            /// </summary>
            ProjectLocationDeployment = 1,
        }

        private static gax::PathTemplate s_projectLocationDeployment = new gax::PathTemplate("projects/{project}/locations/{location}/deployments/{deployment}");

        /// <summary>Creates a <see cref="DeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DeploymentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/deployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DeploymentName"/> constructed from the provided ids.</returns>
        public static DeploymentName FromProjectLocationDeployment(string projectId, string locationId, string deploymentId) =>
            new DeploymentName(ResourceNameType.ProjectLocationDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deployments/{deployment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string deploymentId) =>
            FormatProjectLocationDeployment(projectId, locationId, deploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deployments/{deployment}</c>.
        /// </returns>
        public static string FormatProjectLocationDeployment(string projectId, string locationId, string deploymentId) =>
            s_projectLocationDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>Parses the given resource name string into a new <see cref="DeploymentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/deployments/{deployment}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DeploymentName"/> if successful.</returns>
        public static DeploymentName Parse(string deploymentName) => Parse(deploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeploymentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/deployments/{deployment}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DeploymentName"/> if successful.</returns>
        public static DeploymentName Parse(string deploymentName, bool allowUnparsed) =>
            TryParse(deploymentName, allowUnparsed, out DeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/deployments/{deployment}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deploymentName, out DeploymentName result) =>
            TryParse(deploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeploymentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/deployments/{deployment}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deploymentName, bool allowUnparsed, out DeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(deploymentName, nameof(deploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDeployment.TryParseName(deploymentName, out resourceName))
            {
                result = FromProjectLocationDeployment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(deploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deploymentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeploymentId = deploymentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DeploymentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/deployments/{deployment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        public DeploymentName(string projectId, string locationId, string deploymentId) : this(ResourceNameType.ProjectLocationDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)))
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
        /// The <c>Deployment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DeploymentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationDeployment: return s_projectLocationDeployment.Expand(ProjectId, LocationId, DeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DeploymentName);

        /// <inheritdoc/>
        public bool Equals(DeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DeploymentName a, DeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DeploymentName a, DeploymentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ApiOperation</c> resource.</summary>
    public sealed partial class ApiOperationName : gax::IResourceName, sys::IEquatable<ApiOperationName>
    {
        /// <summary>The possible contents of <see cref="ApiOperationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}</c>.
            /// </summary>
            ProjectLocationApiVersionOperation = 1,
        }

        private static gax::PathTemplate s_projectLocationApiVersionOperation = new gax::PathTemplate("projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}");

        /// <summary>Creates a <see cref="ApiOperationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApiOperationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApiOperationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApiOperationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApiOperationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ApiOperationName"/> constructed from the provided ids.</returns>
        public static ApiOperationName FromProjectLocationApiVersionOperation(string projectId, string locationId, string apiId, string versionId, string operationId) =>
            new ApiOperationName(ResourceNameType.ProjectLocationApiVersionOperation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), operationId: gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiOperationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiOperationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string apiId, string versionId, string operationId) =>
            FormatProjectLocationApiVersionOperation(projectId, locationId, apiId, versionId, operationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiOperationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiOperationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}</c>.
        /// </returns>
        public static string FormatProjectLocationApiVersionOperation(string projectId, string locationId, string apiId, string versionId, string operationId) =>
            s_projectLocationApiVersionOperation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)));

        /// <summary>Parses the given resource name string into a new <see cref="ApiOperationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="apiOperationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ApiOperationName"/> if successful.</returns>
        public static ApiOperationName Parse(string apiOperationName) => Parse(apiOperationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApiOperationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="apiOperationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ApiOperationName"/> if successful.</returns>
        public static ApiOperationName Parse(string apiOperationName, bool allowUnparsed) =>
            TryParse(apiOperationName, allowUnparsed, out ApiOperationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApiOperationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="apiOperationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiOperationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiOperationName, out ApiOperationName result) =>
            TryParse(apiOperationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApiOperationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="apiOperationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiOperationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiOperationName, bool allowUnparsed, out ApiOperationName result)
        {
            gax::GaxPreconditions.CheckNotNull(apiOperationName, nameof(apiOperationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApiVersionOperation.TryParseName(apiOperationName, out resourceName))
            {
                result = FromProjectLocationApiVersionOperation(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(apiOperationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ApiOperationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiId = null, string locationId = null, string operationId = null, string projectId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApiId = apiId;
            LocationId = locationId;
            OperationId = operationId;
            ProjectId = projectId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ApiOperationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        public ApiOperationName(string projectId, string locationId, string apiId, string versionId, string operationId) : this(ResourceNameType.ProjectLocationApiVersionOperation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), operationId: gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)))
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
        /// The <c>Api</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ApiId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Operation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OperationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Version</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VersionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationApiVersionOperation: return s_projectLocationApiVersionOperation.Expand(ProjectId, LocationId, ApiId, VersionId, OperationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ApiOperationName);

        /// <inheritdoc/>
        public bool Equals(ApiOperationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ApiOperationName a, ApiOperationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ApiOperationName a, ApiOperationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Definition</c> resource.</summary>
    public sealed partial class DefinitionName : gax::IResourceName, sys::IEquatable<DefinitionName>
    {
        /// <summary>The possible contents of <see cref="DefinitionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}</c>.
            /// </summary>
            ProjectLocationApiVersionDefinition = 1,
        }

        private static gax::PathTemplate s_projectLocationApiVersionDefinition = new gax::PathTemplate("projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}");

        /// <summary>Creates a <see cref="DefinitionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DefinitionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DefinitionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DefinitionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DefinitionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="definitionId">The <c>Definition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DefinitionName"/> constructed from the provided ids.</returns>
        public static DefinitionName FromProjectLocationApiVersionDefinition(string projectId, string locationId, string apiId, string versionId, string definitionId) =>
            new DefinitionName(ResourceNameType.ProjectLocationApiVersionDefinition, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), definitionId: gax::GaxPreconditions.CheckNotNullOrEmpty(definitionId, nameof(definitionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DefinitionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="definitionId">The <c>Definition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DefinitionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string apiId, string versionId, string definitionId) =>
            FormatProjectLocationApiVersionDefinition(projectId, locationId, apiId, versionId, definitionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DefinitionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="definitionId">The <c>Definition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DefinitionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}</c>.
        /// </returns>
        public static string FormatProjectLocationApiVersionDefinition(string projectId, string locationId, string apiId, string versionId, string definitionId) =>
            s_projectLocationApiVersionDefinition.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(definitionId, nameof(definitionId)));

        /// <summary>Parses the given resource name string into a new <see cref="DefinitionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="definitionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DefinitionName"/> if successful.</returns>
        public static DefinitionName Parse(string definitionName) => Parse(definitionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DefinitionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="definitionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DefinitionName"/> if successful.</returns>
        public static DefinitionName Parse(string definitionName, bool allowUnparsed) =>
            TryParse(definitionName, allowUnparsed, out DefinitionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DefinitionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="definitionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DefinitionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string definitionName, out DefinitionName result) =>
            TryParse(definitionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DefinitionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="definitionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DefinitionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string definitionName, bool allowUnparsed, out DefinitionName result)
        {
            gax::GaxPreconditions.CheckNotNull(definitionName, nameof(definitionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApiVersionDefinition.TryParseName(definitionName, out resourceName))
            {
                result = FromProjectLocationApiVersionDefinition(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(definitionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DefinitionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiId = null, string definitionId = null, string locationId = null, string projectId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApiId = apiId;
            DefinitionId = definitionId;
            LocationId = locationId;
            ProjectId = projectId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DefinitionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="definitionId">The <c>Definition</c> ID. Must not be <c>null</c> or empty.</param>
        public DefinitionName(string projectId, string locationId, string apiId, string versionId, string definitionId) : this(ResourceNameType.ProjectLocationApiVersionDefinition, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), definitionId: gax::GaxPreconditions.CheckNotNullOrEmpty(definitionId, nameof(definitionId)))
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
        /// The <c>Api</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ApiId { get; }

        /// <summary>
        /// The <c>Definition</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DefinitionId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Version</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VersionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationApiVersionDefinition: return s_projectLocationApiVersionDefinition.Expand(ProjectId, LocationId, ApiId, VersionId, DefinitionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DefinitionName);

        /// <inheritdoc/>
        public bool Equals(DefinitionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DefinitionName a, DefinitionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DefinitionName a, DefinitionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Attribute</c> resource.</summary>
    public sealed partial class AttributeName : gax::IResourceName, sys::IEquatable<AttributeName>
    {
        /// <summary>The possible contents of <see cref="AttributeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/attributes/{attribute}</c>.
            /// </summary>
            ProjectLocationAttribute = 1,
        }

        private static gax::PathTemplate s_projectLocationAttribute = new gax::PathTemplate("projects/{project}/locations/{location}/attributes/{attribute}");

        /// <summary>Creates a <see cref="AttributeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AttributeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AttributeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AttributeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AttributeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/attributes/{attribute}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attributeId">The <c>Attribute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AttributeName"/> constructed from the provided ids.</returns>
        public static AttributeName FromProjectLocationAttribute(string projectId, string locationId, string attributeId) =>
            new AttributeName(ResourceNameType.ProjectLocationAttribute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), attributeId: gax::GaxPreconditions.CheckNotNullOrEmpty(attributeId, nameof(attributeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AttributeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/attributes/{attribute}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attributeId">The <c>Attribute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AttributeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/attributes/{attribute}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string attributeId) =>
            FormatProjectLocationAttribute(projectId, locationId, attributeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AttributeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/attributes/{attribute}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attributeId">The <c>Attribute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AttributeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/attributes/{attribute}</c>.
        /// </returns>
        public static string FormatProjectLocationAttribute(string projectId, string locationId, string attributeId) =>
            s_projectLocationAttribute.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(attributeId, nameof(attributeId)));

        /// <summary>Parses the given resource name string into a new <see cref="AttributeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/attributes/{attribute}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="attributeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AttributeName"/> if successful.</returns>
        public static AttributeName Parse(string attributeName) => Parse(attributeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AttributeName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/attributes/{attribute}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="attributeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AttributeName"/> if successful.</returns>
        public static AttributeName Parse(string attributeName, bool allowUnparsed) =>
            TryParse(attributeName, allowUnparsed, out AttributeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AttributeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/attributes/{attribute}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="attributeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AttributeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string attributeName, out AttributeName result) => TryParse(attributeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AttributeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/attributes/{attribute}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="attributeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AttributeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string attributeName, bool allowUnparsed, out AttributeName result)
        {
            gax::GaxPreconditions.CheckNotNull(attributeName, nameof(attributeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAttribute.TryParseName(attributeName, out resourceName))
            {
                result = FromProjectLocationAttribute(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(attributeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AttributeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string attributeId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AttributeId = attributeId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AttributeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/attributes/{attribute}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attributeId">The <c>Attribute</c> ID. Must not be <c>null</c> or empty.</param>
        public AttributeName(string projectId, string locationId, string attributeId) : this(ResourceNameType.ProjectLocationAttribute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), attributeId: gax::GaxPreconditions.CheckNotNullOrEmpty(attributeId, nameof(attributeId)))
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
        /// The <c>Attribute</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AttributeId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationAttribute: return s_projectLocationAttribute.Expand(ProjectId, LocationId, AttributeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AttributeName);

        /// <inheritdoc/>
        public bool Equals(AttributeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AttributeName a, AttributeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AttributeName a, AttributeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Dependency</c> resource.</summary>
    public sealed partial class DependencyName : gax::IResourceName, sys::IEquatable<DependencyName>
    {
        /// <summary>The possible contents of <see cref="DependencyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/dependencies/{dependency}</c>.
            /// </summary>
            ProjectLocationDependency = 1,
        }

        private static gax::PathTemplate s_projectLocationDependency = new gax::PathTemplate("projects/{project}/locations/{location}/dependencies/{dependency}");

        /// <summary>Creates a <see cref="DependencyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DependencyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DependencyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DependencyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DependencyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dependencies/{dependency}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dependencyId">The <c>Dependency</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DependencyName"/> constructed from the provided ids.</returns>
        public static DependencyName FromProjectLocationDependency(string projectId, string locationId, string dependencyId) =>
            new DependencyName(ResourceNameType.ProjectLocationDependency, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dependencyId: gax::GaxPreconditions.CheckNotNullOrEmpty(dependencyId, nameof(dependencyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DependencyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dependencies/{dependency}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dependencyId">The <c>Dependency</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DependencyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dependencies/{dependency}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dependencyId) =>
            FormatProjectLocationDependency(projectId, locationId, dependencyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DependencyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dependencies/{dependency}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dependencyId">The <c>Dependency</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DependencyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dependencies/{dependency}</c>.
        /// </returns>
        public static string FormatProjectLocationDependency(string projectId, string locationId, string dependencyId) =>
            s_projectLocationDependency.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dependencyId, nameof(dependencyId)));

        /// <summary>Parses the given resource name string into a new <see cref="DependencyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dependencies/{dependency}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dependencyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DependencyName"/> if successful.</returns>
        public static DependencyName Parse(string dependencyName) => Parse(dependencyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DependencyName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dependencies/{dependency}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dependencyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DependencyName"/> if successful.</returns>
        public static DependencyName Parse(string dependencyName, bool allowUnparsed) =>
            TryParse(dependencyName, allowUnparsed, out DependencyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DependencyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dependencies/{dependency}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dependencyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DependencyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dependencyName, out DependencyName result) =>
            TryParse(dependencyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DependencyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dependencies/{dependency}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dependencyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DependencyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dependencyName, bool allowUnparsed, out DependencyName result)
        {
            gax::GaxPreconditions.CheckNotNull(dependencyName, nameof(dependencyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDependency.TryParseName(dependencyName, out resourceName))
            {
                result = FromProjectLocationDependency(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dependencyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DependencyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dependencyId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DependencyId = dependencyId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DependencyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dependencies/{dependency}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dependencyId">The <c>Dependency</c> ID. Must not be <c>null</c> or empty.</param>
        public DependencyName(string projectId, string locationId, string dependencyId) : this(ResourceNameType.ProjectLocationDependency, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dependencyId: gax::GaxPreconditions.CheckNotNullOrEmpty(dependencyId, nameof(dependencyId)))
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
        /// The <c>Dependency</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DependencyId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationDependency: return s_projectLocationDependency.Expand(ProjectId, LocationId, DependencyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DependencyName);

        /// <inheritdoc/>
        public bool Equals(DependencyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DependencyName a, DependencyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DependencyName a, DependencyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ApiHubInstance</c> resource.</summary>
    public sealed partial class ApiHubInstanceName : gax::IResourceName, sys::IEquatable<ApiHubInstanceName>
    {
        /// <summary>The possible contents of <see cref="ApiHubInstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apiHubInstances/{api_hub_instance}</c>.
            /// </summary>
            ProjectLocationApiHubInstance = 1,
        }

        private static gax::PathTemplate s_projectLocationApiHubInstance = new gax::PathTemplate("projects/{project}/locations/{location}/apiHubInstances/{api_hub_instance}");

        /// <summary>Creates a <see cref="ApiHubInstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApiHubInstanceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApiHubInstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApiHubInstanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApiHubInstanceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apiHubInstances/{api_hub_instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiHubInstanceId">The <c>ApiHubInstance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ApiHubInstanceName"/> constructed from the provided ids.</returns>
        public static ApiHubInstanceName FromProjectLocationApiHubInstance(string projectId, string locationId, string apiHubInstanceId) =>
            new ApiHubInstanceName(ResourceNameType.ProjectLocationApiHubInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiHubInstanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiHubInstanceId, nameof(apiHubInstanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiHubInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apiHubInstances/{api_hub_instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiHubInstanceId">The <c>ApiHubInstance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiHubInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apiHubInstances/{api_hub_instance}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string apiHubInstanceId) =>
            FormatProjectLocationApiHubInstance(projectId, locationId, apiHubInstanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiHubInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apiHubInstances/{api_hub_instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiHubInstanceId">The <c>ApiHubInstance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiHubInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apiHubInstances/{api_hub_instance}</c>.
        /// </returns>
        public static string FormatProjectLocationApiHubInstance(string projectId, string locationId, string apiHubInstanceId) =>
            s_projectLocationApiHubInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiHubInstanceId, nameof(apiHubInstanceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApiHubInstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apiHubInstances/{api_hub_instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="apiHubInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ApiHubInstanceName"/> if successful.</returns>
        public static ApiHubInstanceName Parse(string apiHubInstanceName) => Parse(apiHubInstanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApiHubInstanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apiHubInstances/{api_hub_instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="apiHubInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ApiHubInstanceName"/> if successful.</returns>
        public static ApiHubInstanceName Parse(string apiHubInstanceName, bool allowUnparsed) =>
            TryParse(apiHubInstanceName, allowUnparsed, out ApiHubInstanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApiHubInstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apiHubInstances/{api_hub_instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="apiHubInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiHubInstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiHubInstanceName, out ApiHubInstanceName result) =>
            TryParse(apiHubInstanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApiHubInstanceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apiHubInstances/{api_hub_instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="apiHubInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiHubInstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiHubInstanceName, bool allowUnparsed, out ApiHubInstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(apiHubInstanceName, nameof(apiHubInstanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApiHubInstance.TryParseName(apiHubInstanceName, out resourceName))
            {
                result = FromProjectLocationApiHubInstance(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(apiHubInstanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ApiHubInstanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiHubInstanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApiHubInstanceId = apiHubInstanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ApiHubInstanceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apiHubInstances/{api_hub_instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiHubInstanceId">The <c>ApiHubInstance</c> ID. Must not be <c>null</c> or empty.</param>
        public ApiHubInstanceName(string projectId, string locationId, string apiHubInstanceId) : this(ResourceNameType.ProjectLocationApiHubInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiHubInstanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiHubInstanceId, nameof(apiHubInstanceId)))
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
        /// The <c>ApiHubInstance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ApiHubInstanceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationApiHubInstance: return s_projectLocationApiHubInstance.Expand(ProjectId, LocationId, ApiHubInstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ApiHubInstanceName);

        /// <inheritdoc/>
        public bool Equals(ApiHubInstanceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ApiHubInstanceName a, ApiHubInstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ApiHubInstanceName a, ApiHubInstanceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ExternalApi</c> resource.</summary>
    public sealed partial class ExternalApiName : gax::IResourceName, sys::IEquatable<ExternalApiName>
    {
        /// <summary>The possible contents of <see cref="ExternalApiName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/externalApis/{external_api}</c>.
            /// </summary>
            ProjectLocationExternalApi = 1,
        }

        private static gax::PathTemplate s_projectLocationExternalApi = new gax::PathTemplate("projects/{project}/locations/{location}/externalApis/{external_api}");

        /// <summary>Creates a <see cref="ExternalApiName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExternalApiName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExternalApiName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExternalApiName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExternalApiName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/externalApis/{external_api}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalApiId">The <c>ExternalApi</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExternalApiName"/> constructed from the provided ids.</returns>
        public static ExternalApiName FromProjectLocationExternalApi(string projectId, string locationId, string externalApiId) =>
            new ExternalApiName(ResourceNameType.ProjectLocationExternalApi, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), externalApiId: gax::GaxPreconditions.CheckNotNullOrEmpty(externalApiId, nameof(externalApiId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExternalApiName"/> with pattern
        /// <c>projects/{project}/locations/{location}/externalApis/{external_api}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalApiId">The <c>ExternalApi</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExternalApiName"/> with pattern
        /// <c>projects/{project}/locations/{location}/externalApis/{external_api}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string externalApiId) =>
            FormatProjectLocationExternalApi(projectId, locationId, externalApiId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExternalApiName"/> with pattern
        /// <c>projects/{project}/locations/{location}/externalApis/{external_api}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalApiId">The <c>ExternalApi</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExternalApiName"/> with pattern
        /// <c>projects/{project}/locations/{location}/externalApis/{external_api}</c>.
        /// </returns>
        public static string FormatProjectLocationExternalApi(string projectId, string locationId, string externalApiId) =>
            s_projectLocationExternalApi.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(externalApiId, nameof(externalApiId)));

        /// <summary>Parses the given resource name string into a new <see cref="ExternalApiName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/externalApis/{external_api}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="externalApiName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExternalApiName"/> if successful.</returns>
        public static ExternalApiName Parse(string externalApiName) => Parse(externalApiName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExternalApiName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/externalApis/{external_api}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="externalApiName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExternalApiName"/> if successful.</returns>
        public static ExternalApiName Parse(string externalApiName, bool allowUnparsed) =>
            TryParse(externalApiName, allowUnparsed, out ExternalApiName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExternalApiName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/externalApis/{external_api}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="externalApiName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExternalApiName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string externalApiName, out ExternalApiName result) =>
            TryParse(externalApiName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExternalApiName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/externalApis/{external_api}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="externalApiName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExternalApiName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string externalApiName, bool allowUnparsed, out ExternalApiName result)
        {
            gax::GaxPreconditions.CheckNotNull(externalApiName, nameof(externalApiName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationExternalApi.TryParseName(externalApiName, out resourceName))
            {
                result = FromProjectLocationExternalApi(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(externalApiName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExternalApiName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string externalApiId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExternalApiId = externalApiId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExternalApiName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/externalApis/{external_api}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalApiId">The <c>ExternalApi</c> ID. Must not be <c>null</c> or empty.</param>
        public ExternalApiName(string projectId, string locationId, string externalApiId) : this(ResourceNameType.ProjectLocationExternalApi, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), externalApiId: gax::GaxPreconditions.CheckNotNullOrEmpty(externalApiId, nameof(externalApiId)))
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
        /// The <c>ExternalApi</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ExternalApiId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationExternalApi: return s_projectLocationExternalApi.Expand(ProjectId, LocationId, ExternalApiId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExternalApiName);

        /// <inheritdoc/>
        public bool Equals(ExternalApiName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExternalApiName a, ExternalApiName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExternalApiName a, ExternalApiName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Extension</c> resource.</summary>
    public sealed partial class ExtensionName : gax::IResourceName, sys::IEquatable<ExtensionName>
    {
        /// <summary>The possible contents of <see cref="ExtensionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/extensions/{extension}</c>.
            /// </summary>
            ProjectLocationExtension = 1,
        }

        private static gax::PathTemplate s_projectLocationExtension = new gax::PathTemplate("projects/{project}/locations/{location}/extensions/{extension}");

        /// <summary>Creates a <see cref="ExtensionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExtensionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExtensionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExtensionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExtensionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/extensions/{extension}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionId">The <c>Extension</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExtensionName"/> constructed from the provided ids.</returns>
        public static ExtensionName FromProjectLocationExtension(string projectId, string locationId, string extensionId) =>
            new ExtensionName(ResourceNameType.ProjectLocationExtension, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), extensionId: gax::GaxPreconditions.CheckNotNullOrEmpty(extensionId, nameof(extensionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExtensionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/extensions/{extension}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionId">The <c>Extension</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExtensionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/extensions/{extension}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string extensionId) =>
            FormatProjectLocationExtension(projectId, locationId, extensionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExtensionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/extensions/{extension}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionId">The <c>Extension</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExtensionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/extensions/{extension}</c>.
        /// </returns>
        public static string FormatProjectLocationExtension(string projectId, string locationId, string extensionId) =>
            s_projectLocationExtension.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(extensionId, nameof(extensionId)));

        /// <summary>Parses the given resource name string into a new <see cref="ExtensionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/extensions/{extension}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="extensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExtensionName"/> if successful.</returns>
        public static ExtensionName Parse(string extensionName) => Parse(extensionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExtensionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/extensions/{extension}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="extensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExtensionName"/> if successful.</returns>
        public static ExtensionName Parse(string extensionName, bool allowUnparsed) =>
            TryParse(extensionName, allowUnparsed, out ExtensionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExtensionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/extensions/{extension}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="extensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExtensionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string extensionName, out ExtensionName result) => TryParse(extensionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExtensionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/extensions/{extension}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="extensionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExtensionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string extensionName, bool allowUnparsed, out ExtensionName result)
        {
            gax::GaxPreconditions.CheckNotNull(extensionName, nameof(extensionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationExtension.TryParseName(extensionName, out resourceName))
            {
                result = FromProjectLocationExtension(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(extensionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExtensionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string extensionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExtensionId = extensionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExtensionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/extensions/{extension}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionId">The <c>Extension</c> ID. Must not be <c>null</c> or empty.</param>
        public ExtensionName(string projectId, string locationId, string extensionId) : this(ResourceNameType.ProjectLocationExtension, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), extensionId: gax::GaxPreconditions.CheckNotNullOrEmpty(extensionId, nameof(extensionId)))
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
        /// The <c>Extension</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ExtensionId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationExtension: return s_projectLocationExtension.Expand(ProjectId, LocationId, ExtensionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExtensionName);

        /// <inheritdoc/>
        public bool Equals(ExtensionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExtensionName a, ExtensionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExtensionName a, ExtensionName b) => !(a == b);
    }

    public partial class Api
    {
        /// <summary>
        /// <see cref="gcav::ApiName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiName ApiName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VersionName"/>-typed view over the <see cref="Versions"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<VersionName> VersionsAsVersionNames
        {
            get => new gax::ResourceNameList<VersionName>(Versions, s => string.IsNullOrEmpty(s) ? null : VersionName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="VersionName"/>-typed view over the <see cref="SelectedVersion"/> resource name property.
        /// </summary>
        public VersionName SelectedVersionAsVersionName
        {
            get => string.IsNullOrEmpty(SelectedVersion) ? null : VersionName.Parse(SelectedVersion, allowUnparsed: true);
            set => SelectedVersion = value?.ToString() ?? "";
        }
    }

    public partial class Version
    {
        /// <summary>
        /// <see cref="gcav::VersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::VersionName VersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::VersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="SpecName"/>-typed view over the <see cref="Specs"/> resource name property.</summary>
        public gax::ResourceNameList<SpecName> SpecsAsSpecNames
        {
            get => new gax::ResourceNameList<SpecName>(Specs, s => string.IsNullOrEmpty(s) ? null : SpecName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="ApiOperationName"/>-typed view over the <see cref="ApiOperations"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ApiOperationName> ApiOperationsAsApiOperationNames
        {
            get => new gax::ResourceNameList<ApiOperationName>(ApiOperations, s => string.IsNullOrEmpty(s) ? null : ApiOperationName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="DefinitionName"/>-typed view over the <see cref="Definitions"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<DefinitionName> DefinitionsAsDefinitionNames
        {
            get => new gax::ResourceNameList<DefinitionName>(Definitions, s => string.IsNullOrEmpty(s) ? null : DefinitionName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="DeploymentName"/>-typed view over the <see cref="Deployments"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<DeploymentName> DeploymentsAsDeploymentNames
        {
            get => new gax::ResourceNameList<DeploymentName>(Deployments, s => string.IsNullOrEmpty(s) ? null : DeploymentName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="DeploymentName"/>-typed view over the <see cref="SelectedDeployment"/> resource name property.
        /// </summary>
        public DeploymentName SelectedDeploymentAsDeploymentName
        {
            get => string.IsNullOrEmpty(SelectedDeployment) ? null : DeploymentName.Parse(SelectedDeployment, allowUnparsed: true);
            set => SelectedDeployment = value?.ToString() ?? "";
        }
    }

    public partial class Spec
    {
        /// <summary>
        /// <see cref="gcav::SpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SpecName SpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Deployment
    {
        /// <summary>
        /// <see cref="gcav::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ApiOperation
    {
        /// <summary>
        /// <see cref="gcav::ApiOperationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiOperationName ApiOperationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiOperationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="SpecName"/>-typed view over the <see cref="Spec"/> resource name property.</summary>
        public SpecName SpecAsSpecName
        {
            get => string.IsNullOrEmpty(Spec) ? null : SpecName.Parse(Spec, allowUnparsed: true);
            set => Spec = value?.ToString() ?? "";
        }
    }

    public partial class Definition
    {
        /// <summary>
        /// <see cref="gcav::DefinitionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DefinitionName DefinitionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DefinitionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="SpecName"/>-typed view over the <see cref="Spec"/> resource name property.</summary>
        public SpecName SpecAsSpecName
        {
            get => string.IsNullOrEmpty(Spec) ? null : SpecName.Parse(Spec, allowUnparsed: true);
            set => Spec = value?.ToString() ?? "";
        }
    }

    public partial class Attribute
    {
        /// <summary>
        /// <see cref="gcav::AttributeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AttributeName AttributeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AttributeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AttributeValues
    {
        /// <summary>
        /// <see cref="AttributeName"/>-typed view over the <see cref="Attribute"/> resource name property.
        /// </summary>
        public AttributeName AttributeAsAttributeName
        {
            get => string.IsNullOrEmpty(Attribute) ? null : AttributeName.Parse(Attribute, allowUnparsed: true);
            set => Attribute = value?.ToString() ?? "";
        }
    }

    public partial class Dependency
    {
        /// <summary>
        /// <see cref="gcav::DependencyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DependencyName DependencyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DependencyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ApiHubInstance
    {
        /// <summary>
        /// <see cref="gcav::ApiHubInstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiHubInstanceName ApiHubInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiHubInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExternalApi
    {
        /// <summary>
        /// <see cref="gcav::ExternalApiName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ExternalApiName ExternalApiName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ExternalApiName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

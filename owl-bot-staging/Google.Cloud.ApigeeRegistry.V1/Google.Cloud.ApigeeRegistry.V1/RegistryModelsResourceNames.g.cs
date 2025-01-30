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
using gcav = Google.Cloud.ApigeeRegistry.V1;
using sys = System;

namespace Google.Cloud.ApigeeRegistry.V1
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

    /// <summary>Resource name for the <c>ApiVersion</c> resource.</summary>
    public sealed partial class ApiVersionName : gax::IResourceName, sys::IEquatable<ApiVersionName>
    {
        /// <summary>The possible contents of <see cref="ApiVersionName"/>.</summary>
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

        /// <summary>Creates a <see cref="ApiVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApiVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApiVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApiVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApiVersionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ApiVersionName"/> constructed from the provided ids.</returns>
        public static ApiVersionName FromProjectLocationApiVersion(string projectId, string locationId, string apiId, string versionId) =>
            new ApiVersionName(ResourceNameType.ProjectLocationApiVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string apiId, string versionId) =>
            FormatProjectLocationApiVersion(projectId, locationId, apiId, versionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c>.
        /// </returns>
        public static string FormatProjectLocationApiVersion(string projectId, string locationId, string apiId, string versionId) =>
            s_projectLocationApiVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>Parses the given resource name string into a new <see cref="ApiVersionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="apiVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ApiVersionName"/> if successful.</returns>
        public static ApiVersionName Parse(string apiVersionName) => Parse(apiVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApiVersionName"/> instance; optionally allowing
        /// an unparseable resource name.
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
        /// <param name="apiVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ApiVersionName"/> if successful.</returns>
        public static ApiVersionName Parse(string apiVersionName, bool allowUnparsed) =>
            TryParse(apiVersionName, allowUnparsed, out ApiVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApiVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="apiVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiVersionName, out ApiVersionName result) =>
            TryParse(apiVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApiVersionName"/> instance; optionally
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
        /// <param name="apiVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiVersionName, bool allowUnparsed, out ApiVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(apiVersionName, nameof(apiVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApiVersion.TryParseName(apiVersionName, out resourceName))
            {
                result = FromProjectLocationApiVersion(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(apiVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ApiVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiId = null, string locationId = null, string projectId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApiId = apiId;
            LocationId = locationId;
            ProjectId = projectId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ApiVersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        public ApiVersionName(string projectId, string locationId, string apiId, string versionId) : this(ResourceNameType.ProjectLocationApiVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)))
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
        public override bool Equals(object obj) => Equals(obj as ApiVersionName);

        /// <inheritdoc/>
        public bool Equals(ApiVersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ApiVersionName a, ApiVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ApiVersionName a, ApiVersionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ApiSpec</c> resource.</summary>
    public sealed partial class ApiSpecName : gax::IResourceName, sys::IEquatable<ApiSpecName>
    {
        /// <summary>The possible contents of <see cref="ApiSpecName"/>.</summary>
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

        /// <summary>Creates a <see cref="ApiSpecName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApiSpecName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApiSpecName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApiSpecName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApiSpecName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specId">The <c>Spec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ApiSpecName"/> constructed from the provided ids.</returns>
        public static ApiSpecName FromProjectLocationApiVersionSpec(string projectId, string locationId, string apiId, string versionId, string specId) =>
            new ApiSpecName(ResourceNameType.ProjectLocationApiVersionSpec, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), specId: gax::GaxPreconditions.CheckNotNullOrEmpty(specId, nameof(specId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiSpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specId">The <c>Spec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiSpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string apiId, string versionId, string specId) =>
            FormatProjectLocationApiVersionSpec(projectId, locationId, apiId, versionId, specId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiSpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specId">The <c>Spec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiSpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>.
        /// </returns>
        public static string FormatProjectLocationApiVersionSpec(string projectId, string locationId, string apiId, string versionId, string specId) =>
            s_projectLocationApiVersionSpec.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(specId, nameof(specId)));

        /// <summary>Parses the given resource name string into a new <see cref="ApiSpecName"/> instance.</summary>
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
        /// <param name="apiSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ApiSpecName"/> if successful.</returns>
        public static ApiSpecName Parse(string apiSpecName) => Parse(apiSpecName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApiSpecName"/> instance; optionally allowing an
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
        /// <param name="apiSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ApiSpecName"/> if successful.</returns>
        public static ApiSpecName Parse(string apiSpecName, bool allowUnparsed) =>
            TryParse(apiSpecName, allowUnparsed, out ApiSpecName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApiSpecName"/> instance.
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
        /// </remarks>
        /// <param name="apiSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiSpecName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiSpecName, out ApiSpecName result) => TryParse(apiSpecName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApiSpecName"/> instance; optionally
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
        /// <param name="apiSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiSpecName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiSpecName, bool allowUnparsed, out ApiSpecName result)
        {
            gax::GaxPreconditions.CheckNotNull(apiSpecName, nameof(apiSpecName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApiVersionSpec.TryParseName(apiSpecName, out resourceName))
            {
                result = FromProjectLocationApiVersionSpec(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(apiSpecName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ApiSpecName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiId = null, string locationId = null, string projectId = null, string specId = null, string versionId = null)
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
        /// Constructs a new instance of a <see cref="ApiSpecName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specId">The <c>Spec</c> ID. Must not be <c>null</c> or empty.</param>
        public ApiSpecName(string projectId, string locationId, string apiId, string versionId, string specId) : this(ResourceNameType.ProjectLocationApiVersionSpec, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), specId: gax::GaxPreconditions.CheckNotNullOrEmpty(specId, nameof(specId)))
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
        public override bool Equals(object obj) => Equals(obj as ApiSpecName);

        /// <inheritdoc/>
        public bool Equals(ApiSpecName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ApiSpecName a, ApiSpecName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ApiSpecName a, ApiSpecName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ApiDeployment</c> resource.</summary>
    public sealed partial class ApiDeploymentName : gax::IResourceName, sys::IEquatable<ApiDeploymentName>
    {
        /// <summary>The possible contents of <see cref="ApiDeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}</c>.
            /// </summary>
            ProjectLocationApiDeployment = 1,
        }

        private static gax::PathTemplate s_projectLocationApiDeployment = new gax::PathTemplate("projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}");

        /// <summary>Creates a <see cref="ApiDeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApiDeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApiDeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApiDeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApiDeploymentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ApiDeploymentName"/> constructed from the provided ids.</returns>
        public static ApiDeploymentName FromProjectLocationApiDeployment(string projectId, string locationId, string apiId, string deploymentId) =>
            new ApiDeploymentName(ResourceNameType.ProjectLocationApiDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string apiId, string deploymentId) =>
            FormatProjectLocationApiDeployment(projectId, locationId, apiId, deploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}</c>.
        /// </returns>
        public static string FormatProjectLocationApiDeployment(string projectId, string locationId, string apiId, string deploymentId) =>
            s_projectLocationApiDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApiDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="apiDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ApiDeploymentName"/> if successful.</returns>
        public static ApiDeploymentName Parse(string apiDeploymentName) => Parse(apiDeploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApiDeploymentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="apiDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ApiDeploymentName"/> if successful.</returns>
        public static ApiDeploymentName Parse(string apiDeploymentName, bool allowUnparsed) =>
            TryParse(apiDeploymentName, allowUnparsed, out ApiDeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApiDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="apiDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiDeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiDeploymentName, out ApiDeploymentName result) =>
            TryParse(apiDeploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApiDeploymentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="apiDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiDeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiDeploymentName, bool allowUnparsed, out ApiDeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(apiDeploymentName, nameof(apiDeploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApiDeployment.TryParseName(apiDeploymentName, out resourceName))
            {
                result = FromProjectLocationApiDeployment(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(apiDeploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ApiDeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiId = null, string deploymentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApiId = apiId;
            DeploymentId = deploymentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ApiDeploymentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        public ApiDeploymentName(string projectId, string locationId, string apiId, string deploymentId) : this(ResourceNameType.ProjectLocationApiDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)))
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
                case ResourceNameType.ProjectLocationApiDeployment: return s_projectLocationApiDeployment.Expand(ProjectId, LocationId, ApiId, DeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ApiDeploymentName);

        /// <inheritdoc/>
        public bool Equals(ApiDeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ApiDeploymentName a, ApiDeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ApiDeploymentName a, ApiDeploymentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Artifact</c> resource.</summary>
    public sealed partial class ArtifactName : gax::IResourceName, sys::IEquatable<ArtifactName>
    {
        /// <summary>The possible contents of <see cref="ArtifactName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/artifacts/{artifact}</c>.
            /// </summary>
            ProjectLocationArtifact = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/apis/{api}/artifacts/{artifact}</c>
            /// .
            /// </summary>
            ProjectLocationApiArtifact = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/artifacts/{artifact}</c>.
            /// </summary>
            ProjectLocationApiVersionArtifact = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}/artifacts/{artifact}</c>
            /// .
            /// </summary>
            ProjectLocationApiVersionSpecArtifact = 4,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}/artifacts/{artifact}</c>.
            /// </summary>
            ProjectLocationApiDeploymentArtifact = 5,
        }

        private static gax::PathTemplate s_projectLocationArtifact = new gax::PathTemplate("projects/{project}/locations/{location}/artifacts/{artifact}");

        private static gax::PathTemplate s_projectLocationApiArtifact = new gax::PathTemplate("projects/{project}/locations/{location}/apis/{api}/artifacts/{artifact}");

        private static gax::PathTemplate s_projectLocationApiVersionArtifact = new gax::PathTemplate("projects/{project}/locations/{location}/apis/{api}/versions/{version}/artifacts/{artifact}");

        private static gax::PathTemplate s_projectLocationApiVersionSpecArtifact = new gax::PathTemplate("projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}/artifacts/{artifact}");

        private static gax::PathTemplate s_projectLocationApiDeploymentArtifact = new gax::PathTemplate("projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}/artifacts/{artifact}");

        /// <summary>Creates a <see cref="ArtifactName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ArtifactName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static ArtifactName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ArtifactName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ArtifactName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ArtifactName"/> constructed from the provided ids.</returns>
        public static ArtifactName FromProjectLocationArtifact(string projectId, string locationId, string artifactId) =>
            new ArtifactName(ResourceNameType.ProjectLocationArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), artifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>
        /// Creates a <see cref="ArtifactName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ArtifactName"/> constructed from the provided ids.</returns>
        public static ArtifactName FromProjectLocationApiArtifact(string projectId, string locationId, string apiId, string artifactId) =>
            new ArtifactName(ResourceNameType.ProjectLocationApiArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), artifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>
        /// Creates a <see cref="ArtifactName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ArtifactName"/> constructed from the provided ids.</returns>
        public static ArtifactName FromProjectLocationApiVersionArtifact(string projectId, string locationId, string apiId, string versionId, string artifactId) =>
            new ArtifactName(ResourceNameType.ProjectLocationApiVersionArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), artifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>
        /// Creates a <see cref="ArtifactName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}/artifacts/{artifact}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specId">The <c>Spec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ArtifactName"/> constructed from the provided ids.</returns>
        public static ArtifactName FromProjectLocationApiVersionSpecArtifact(string projectId, string locationId, string apiId, string versionId, string specId, string artifactId) =>
            new ArtifactName(ResourceNameType.ProjectLocationApiVersionSpecArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), specId: gax::GaxPreconditions.CheckNotNullOrEmpty(specId, nameof(specId)), artifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>
        /// Creates a <see cref="ArtifactName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ArtifactName"/> constructed from the provided ids.</returns>
        public static ArtifactName FromProjectLocationApiDeploymentArtifact(string projectId, string locationId, string apiId, string deploymentId, string artifactId) =>
            new ArtifactName(ResourceNameType.ProjectLocationApiDeploymentArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)), artifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/artifacts/{artifact}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string artifactId) =>
            FormatProjectLocationArtifact(projectId, locationId, artifactId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/artifacts/{artifact}</c>.
        /// </returns>
        public static string FormatProjectLocationArtifact(string projectId, string locationId, string artifactId) =>
            s_projectLocationArtifact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/artifacts/{artifact}</c>.
        /// </returns>
        public static string FormatProjectLocationApiArtifact(string projectId, string locationId, string apiId, string artifactId) =>
            s_projectLocationApiArtifact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/artifacts/{artifact}</c>.
        /// </returns>
        public static string FormatProjectLocationApiVersionArtifact(string projectId, string locationId, string apiId, string versionId, string artifactId) =>
            s_projectLocationApiVersionArtifact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}/artifacts/{artifact}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specId">The <c>Spec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}/artifacts/{artifact}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationApiVersionSpecArtifact(string projectId, string locationId, string apiId, string versionId, string specId, string artifactId) =>
            s_projectLocationApiVersionSpecArtifact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(specId, nameof(specId)), gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}/artifacts/{artifact}</c>.
        /// </returns>
        public static string FormatProjectLocationApiDeploymentArtifact(string projectId, string locationId, string apiId, string deploymentId, string artifactId) =>
            s_projectLocationApiDeploymentArtifact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>Parses the given resource name string into a new <see cref="ArtifactName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/artifacts/{artifact}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apis/{api}/artifacts/{artifact}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="artifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ArtifactName"/> if successful.</returns>
        public static ArtifactName Parse(string artifactName) => Parse(artifactName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ArtifactName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/artifacts/{artifact}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apis/{api}/artifacts/{artifact}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="artifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ArtifactName"/> if successful.</returns>
        public static ArtifactName Parse(string artifactName, bool allowUnparsed) =>
            TryParse(artifactName, allowUnparsed, out ArtifactName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ArtifactName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/artifacts/{artifact}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apis/{api}/artifacts/{artifact}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="artifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string artifactName, out ArtifactName result) => TryParse(artifactName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ArtifactName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/artifacts/{artifact}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apis/{api}/artifacts/{artifact}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="artifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string artifactName, bool allowUnparsed, out ArtifactName result)
        {
            gax::GaxPreconditions.CheckNotNull(artifactName, nameof(artifactName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationArtifact.TryParseName(artifactName, out resourceName))
            {
                result = FromProjectLocationArtifact(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationApiArtifact.TryParseName(artifactName, out resourceName))
            {
                result = FromProjectLocationApiArtifact(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationApiVersionArtifact.TryParseName(artifactName, out resourceName))
            {
                result = FromProjectLocationApiVersionArtifact(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (s_projectLocationApiVersionSpecArtifact.TryParseName(artifactName, out resourceName))
            {
                result = FromProjectLocationApiVersionSpecArtifact(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5]);
                return true;
            }
            if (s_projectLocationApiDeploymentArtifact.TryParseName(artifactName, out resourceName))
            {
                result = FromProjectLocationApiDeploymentArtifact(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(artifactName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ArtifactName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiId = null, string artifactId = null, string deploymentId = null, string locationId = null, string projectId = null, string specId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApiId = apiId;
            ArtifactId = artifactId;
            DeploymentId = deploymentId;
            LocationId = locationId;
            ProjectId = projectId;
            SpecId = specId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ArtifactName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/artifacts/{artifact}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        public ArtifactName(string projectId, string locationId, string artifactId) : this(ResourceNameType.ProjectLocationArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), artifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)))
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
        /// The <c>Api</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ApiId { get; }

        /// <summary>
        /// The <c>Artifact</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ArtifactId { get; }

        /// <summary>
        /// The <c>Deployment</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string DeploymentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Spec</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string SpecId { get; }

        /// <summary>
        /// The <c>Version</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectLocationArtifact: return s_projectLocationArtifact.Expand(ProjectId, LocationId, ArtifactId);
                case ResourceNameType.ProjectLocationApiArtifact: return s_projectLocationApiArtifact.Expand(ProjectId, LocationId, ApiId, ArtifactId);
                case ResourceNameType.ProjectLocationApiVersionArtifact: return s_projectLocationApiVersionArtifact.Expand(ProjectId, LocationId, ApiId, VersionId, ArtifactId);
                case ResourceNameType.ProjectLocationApiVersionSpecArtifact: return s_projectLocationApiVersionSpecArtifact.Expand(ProjectId, LocationId, ApiId, VersionId, SpecId, ArtifactId);
                case ResourceNameType.ProjectLocationApiDeploymentArtifact: return s_projectLocationApiDeploymentArtifact.Expand(ProjectId, LocationId, ApiId, DeploymentId, ArtifactId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ArtifactName);

        /// <inheritdoc/>
        public bool Equals(ArtifactName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ArtifactName a, ArtifactName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ArtifactName a, ArtifactName b) => !(a == b);
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
        /// <see cref="ApiVersionName"/>-typed view over the <see cref="RecommendedVersion"/> resource name property.
        /// </summary>
        public ApiVersionName RecommendedVersionAsApiVersionName
        {
            get => string.IsNullOrEmpty(RecommendedVersion) ? null : ApiVersionName.Parse(RecommendedVersion, allowUnparsed: true);
            set => RecommendedVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ApiDeploymentName"/>-typed view over the <see cref="RecommendedDeployment"/> resource name
        /// property.
        /// </summary>
        public ApiDeploymentName RecommendedDeploymentAsApiDeploymentName
        {
            get => string.IsNullOrEmpty(RecommendedDeployment) ? null : ApiDeploymentName.Parse(RecommendedDeployment, allowUnparsed: true);
            set => RecommendedDeployment = value?.ToString() ?? "";
        }
    }

    public partial class ApiVersion
    {
        /// <summary>
        /// <see cref="gcav::ApiVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiVersionName ApiVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ApiSpec
    {
        /// <summary>
        /// <see cref="gcav::ApiSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiSpecName ApiSpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiSpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ApiDeployment
    {
        /// <summary>
        /// <see cref="gcav::ApiDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiDeploymentName ApiDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ApiSpecName"/>-typed view over the <see cref="ApiSpecRevision"/> resource name property.
        /// </summary>
        public ApiSpecName ApiSpecRevisionAsApiSpecName
        {
            get => string.IsNullOrEmpty(ApiSpecRevision) ? null : ApiSpecName.Parse(ApiSpecRevision, allowUnparsed: true);
            set => ApiSpecRevision = value?.ToString() ?? "";
        }
    }

    public partial class Artifact
    {
        /// <summary>
        /// <see cref="gcav::ArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ArtifactName ArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

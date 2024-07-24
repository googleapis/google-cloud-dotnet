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
using gcav = Google.Cloud.ApiGateway.V1;
using sys = System;

namespace Google.Cloud.ApiGateway.V1
{
    /// <summary>Resource name for the <c>Api</c> resource.</summary>
    public sealed partial class ApiName : gax::IResourceName, sys::IEquatable<ApiName>
    {
        /// <summary>The possible contents of <see cref="ApiName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/locations/global/apis/{api}</c>.</summary>
            ProjectApi = 1,
        }

        private static gax::PathTemplate s_projectApi = new gax::PathTemplate("projects/{project}/locations/global/apis/{api}");

        /// <summary>Creates a <see cref="ApiName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApiName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApiName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApiName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApiName"/> with the pattern <c>projects/{project}/locations/global/apis/{api}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ApiName"/> constructed from the provided ids.</returns>
        public static ApiName FromProjectApi(string projectId, string apiId) =>
            new ApiName(ResourceNameType.ProjectApi, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiName"/> with pattern
        /// <c>projects/{project}/locations/global/apis/{api}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiName"/> with pattern
        /// <c>projects/{project}/locations/global/apis/{api}</c>.
        /// </returns>
        public static string Format(string projectId, string apiId) => FormatProjectApi(projectId, apiId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiName"/> with pattern
        /// <c>projects/{project}/locations/global/apis/{api}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiName"/> with pattern
        /// <c>projects/{project}/locations/global/apis/{api}</c>.
        /// </returns>
        public static string FormatProjectApi(string projectId, string apiId) =>
            s_projectApi.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)));

        /// <summary>Parses the given resource name string into a new <see cref="ApiName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/global/apis/{api}</c></description></item>
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
        /// <item><description><c>projects/{project}/locations/global/apis/{api}</c></description></item>
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
        /// <item><description><c>projects/{project}/locations/global/apis/{api}</c></description></item>
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
        /// <item><description><c>projects/{project}/locations/global/apis/{api}</c></description></item>
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
            if (s_projectApi.TryParseName(apiName, out resourceName))
            {
                result = FromProjectApi(resourceName[0], resourceName[1]);
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

        private ApiName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApiId = apiId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ApiName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/global/apis/{api}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        public ApiName(string projectId, string apiId) : this(ResourceNameType.ProjectApi, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)))
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
                case ResourceNameType.ProjectApi: return s_projectApi.Expand(ProjectId, ApiId);
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

    /// <summary>Resource name for the <c>ApiConfig</c> resource.</summary>
    public sealed partial class ApiConfigName : gax::IResourceName, sys::IEquatable<ApiConfigName>
    {
        /// <summary>The possible contents of <see cref="ApiConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/global/apis/{api}/configs/{api_config}</c>.
            /// </summary>
            ProjectApiApiConfig = 1,
        }

        private static gax::PathTemplate s_projectApiApiConfig = new gax::PathTemplate("projects/{project}/locations/global/apis/{api}/configs/{api_config}");

        /// <summary>Creates a <see cref="ApiConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApiConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApiConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApiConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApiConfigName"/> with the pattern
        /// <c>projects/{project}/locations/global/apis/{api}/configs/{api_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiConfigId">The <c>ApiConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ApiConfigName"/> constructed from the provided ids.</returns>
        public static ApiConfigName FromProjectApiApiConfig(string projectId, string apiId, string apiConfigId) =>
            new ApiConfigName(ResourceNameType.ProjectApiApiConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), apiConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiConfigId, nameof(apiConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiConfigName"/> with pattern
        /// <c>projects/{project}/locations/global/apis/{api}/configs/{api_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiConfigId">The <c>ApiConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiConfigName"/> with pattern
        /// <c>projects/{project}/locations/global/apis/{api}/configs/{api_config}</c>.
        /// </returns>
        public static string Format(string projectId, string apiId, string apiConfigId) =>
            FormatProjectApiApiConfig(projectId, apiId, apiConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApiConfigName"/> with pattern
        /// <c>projects/{project}/locations/global/apis/{api}/configs/{api_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiConfigId">The <c>ApiConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApiConfigName"/> with pattern
        /// <c>projects/{project}/locations/global/apis/{api}/configs/{api_config}</c>.
        /// </returns>
        public static string FormatProjectApiApiConfig(string projectId, string apiId, string apiConfigId) =>
            s_projectApiApiConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiConfigId, nameof(apiConfigId)));

        /// <summary>Parses the given resource name string into a new <see cref="ApiConfigName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/global/apis/{api}/configs/{api_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="apiConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ApiConfigName"/> if successful.</returns>
        public static ApiConfigName Parse(string apiConfigName) => Parse(apiConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApiConfigName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/global/apis/{api}/configs/{api_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="apiConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ApiConfigName"/> if successful.</returns>
        public static ApiConfigName Parse(string apiConfigName, bool allowUnparsed) =>
            TryParse(apiConfigName, allowUnparsed, out ApiConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApiConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/global/apis/{api}/configs/{api_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="apiConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiConfigName, out ApiConfigName result) => TryParse(apiConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApiConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/global/apis/{api}/configs/{api_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="apiConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApiConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string apiConfigName, bool allowUnparsed, out ApiConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(apiConfigName, nameof(apiConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectApiApiConfig.TryParseName(apiConfigName, out resourceName))
            {
                result = FromProjectApiApiConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(apiConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ApiConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiId = null, string apiConfigId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApiId = apiId;
            ApiConfigId = apiConfigId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ApiConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/global/apis/{api}/configs/{api_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiId">The <c>Api</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiConfigId">The <c>ApiConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public ApiConfigName(string projectId, string apiId, string apiConfigId) : this(ResourceNameType.ProjectApiApiConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), apiId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)), apiConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiConfigId, nameof(apiConfigId)))
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
        /// The <c>ApiConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ApiConfigId { get; }

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
                case ResourceNameType.ProjectApiApiConfig: return s_projectApiApiConfig.Expand(ProjectId, ApiId, ApiConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ApiConfigName);

        /// <inheritdoc/>
        public bool Equals(ApiConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ApiConfigName a, ApiConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ApiConfigName a, ApiConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Gateway</c> resource.</summary>
    public sealed partial class GatewayName : gax::IResourceName, sys::IEquatable<GatewayName>
    {
        /// <summary>The possible contents of <see cref="GatewayName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
            /// </summary>
            ProjectLocationGateway = 1,
        }

        private static gax::PathTemplate s_projectLocationGateway = new gax::PathTemplate("projects/{project}/locations/{location}/gateways/{gateway}");

        /// <summary>Creates a <see cref="GatewayName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GatewayName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GatewayName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GatewayName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GatewayName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GatewayName"/> constructed from the provided ids.</returns>
        public static GatewayName FromProjectLocationGateway(string projectId, string locationId, string gatewayId) =>
            new GatewayName(ResourceNameType.ProjectLocationGateway, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string gatewayId) =>
            FormatProjectLocationGateway(projectId, locationId, gatewayId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </returns>
        public static string FormatProjectLocationGateway(string projectId, string locationId, string gatewayId) =>
            s_projectLocationGateway.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)));

        /// <summary>Parses the given resource name string into a new <see cref="GatewayName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/gateways/{gateway}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="gatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GatewayName"/> if successful.</returns>
        public static GatewayName Parse(string gatewayName) => Parse(gatewayName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GatewayName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/gateways/{gateway}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GatewayName"/> if successful.</returns>
        public static GatewayName Parse(string gatewayName, bool allowUnparsed) =>
            TryParse(gatewayName, allowUnparsed, out GatewayName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GatewayName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/gateways/{gateway}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="gatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GatewayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gatewayName, out GatewayName result) => TryParse(gatewayName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GatewayName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/gateways/{gateway}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GatewayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gatewayName, bool allowUnparsed, out GatewayName result)
        {
            gax::GaxPreconditions.CheckNotNull(gatewayName, nameof(gatewayName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGateway.TryParseName(gatewayName, out resourceName))
            {
                result = FromProjectLocationGateway(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(gatewayName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GatewayName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string gatewayId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GatewayId = gatewayId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GatewayName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        public GatewayName(string projectId, string locationId, string gatewayId) : this(ResourceNameType.ProjectLocationGateway, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)))
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
        /// The <c>Gateway</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string GatewayId { get; }

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
                case ResourceNameType.ProjectLocationGateway: return s_projectLocationGateway.Expand(ProjectId, LocationId, GatewayId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GatewayName);

        /// <inheritdoc/>
        public bool Equals(GatewayName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GatewayName a, GatewayName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GatewayName a, GatewayName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ServiceAccount</c> resource.</summary>
    public sealed partial class ServiceAccountName : gax::IResourceName, sys::IEquatable<ServiceAccountName>
    {
        /// <summary>The possible contents of <see cref="ServiceAccountName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/serviceAccounts/{service_account}</c>.
            /// </summary>
            ProjectServiceAccount = 1,
        }

        private static gax::PathTemplate s_projectServiceAccount = new gax::PathTemplate("projects/{project}/serviceAccounts/{service_account}");

        /// <summary>Creates a <see cref="ServiceAccountName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceAccountName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceAccountName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceAccountName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceAccountName"/> with the pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAccountId">The <c>ServiceAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceAccountName"/> constructed from the provided ids.</returns>
        public static ServiceAccountName FromProjectServiceAccount(string projectId, string serviceAccountId) =>
            new ServiceAccountName(ResourceNameType.ProjectServiceAccount, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), serviceAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAccountId, nameof(serviceAccountId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAccountId">The <c>ServiceAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </returns>
        public static string Format(string projectId, string serviceAccountId) =>
            FormatProjectServiceAccount(projectId, serviceAccountId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAccountId">The <c>ServiceAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </returns>
        public static string FormatProjectServiceAccount(string projectId, string serviceAccountId) =>
            s_projectServiceAccount.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAccountId, nameof(serviceAccountId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccounts/{service_account}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serviceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceAccountName"/> if successful.</returns>
        public static ServiceAccountName Parse(string serviceAccountName) => Parse(serviceAccountName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceAccountName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccounts/{service_account}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceAccountName"/> if successful.</returns>
        public static ServiceAccountName Parse(string serviceAccountName, bool allowUnparsed) =>
            TryParse(serviceAccountName, allowUnparsed, out ServiceAccountName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccounts/{service_account}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serviceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceAccountName, out ServiceAccountName result) =>
            TryParse(serviceAccountName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceAccountName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccounts/{service_account}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceAccountName, bool allowUnparsed, out ServiceAccountName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceAccountName, nameof(serviceAccountName));
            gax::TemplatedResourceName resourceName;
            if (s_projectServiceAccount.TryParseName(serviceAccountName, out resourceName))
            {
                result = FromProjectServiceAccount(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceAccountName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceAccountName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string serviceAccountId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            ServiceAccountId = serviceAccountId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceAccountName"/> class from the component parts of pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAccountId">The <c>ServiceAccount</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceAccountName(string projectId, string serviceAccountId) : this(ResourceNameType.ProjectServiceAccount, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), serviceAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAccountId, nameof(serviceAccountId)))
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
        /// The <c>ServiceAccount</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ServiceAccountId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectServiceAccount: return s_projectServiceAccount.Expand(ProjectId, ServiceAccountId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceAccountName);

        /// <inheritdoc/>
        public bool Equals(ServiceAccountName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceAccountName a, ServiceAccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceAccountName a, ServiceAccountName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ManagedService</c> resource.</summary>
    public sealed partial class ManagedServiceName : gax::IResourceName, sys::IEquatable<ManagedServiceName>
    {
        /// <summary>The possible contents of <see cref="ManagedServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>services/{service}</c>.</summary>
            Service = 1,
        }

        private static gax::PathTemplate s_service = new gax::PathTemplate("services/{service}");

        /// <summary>Creates a <see cref="ManagedServiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ManagedServiceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ManagedServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ManagedServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="ManagedServiceName"/> with the pattern <c>services/{service}</c>.</summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ManagedServiceName"/> constructed from the provided ids.</returns>
        public static ManagedServiceName FromService(string serviceId) =>
            new ManagedServiceName(ResourceNameType.Service, serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ManagedServiceName"/> with pattern
        /// <c>services/{service}</c>.
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ManagedServiceName"/> with pattern <c>services/{service}</c>.
        /// </returns>
        public static string Format(string serviceId) => FormatService(serviceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ManagedServiceName"/> with pattern
        /// <c>services/{service}</c>.
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ManagedServiceName"/> with pattern <c>services/{service}</c>.
        /// </returns>
        public static string FormatService(string serviceId) =>
            s_service.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ManagedServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>services/{service}</c></description></item></list>
        /// </remarks>
        /// <param name="managedServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ManagedServiceName"/> if successful.</returns>
        public static ManagedServiceName Parse(string managedServiceName) => Parse(managedServiceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ManagedServiceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>services/{service}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="managedServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ManagedServiceName"/> if successful.</returns>
        public static ManagedServiceName Parse(string managedServiceName, bool allowUnparsed) =>
            TryParse(managedServiceName, allowUnparsed, out ManagedServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ManagedServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>services/{service}</c></description></item></list>
        /// </remarks>
        /// <param name="managedServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ManagedServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string managedServiceName, out ManagedServiceName result) =>
            TryParse(managedServiceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ManagedServiceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>services/{service}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="managedServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ManagedServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string managedServiceName, bool allowUnparsed, out ManagedServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(managedServiceName, nameof(managedServiceName));
            gax::TemplatedResourceName resourceName;
            if (s_service.TryParseName(managedServiceName, out resourceName))
            {
                result = FromService(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(managedServiceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ManagedServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string serviceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ServiceId = serviceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ManagedServiceName"/> class from the component parts of pattern
        /// <c>services/{service}</c>
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        public ManagedServiceName(string serviceId) : this(ResourceNameType.Service, serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)))
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
        /// The <c>Service</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ServiceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Service: return s_service.Expand(ServiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ManagedServiceName);

        /// <inheritdoc/>
        public bool Equals(ManagedServiceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ManagedServiceName a, ManagedServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ManagedServiceName a, ManagedServiceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Service</c> resource.</summary>
    public sealed partial class ServiceName : gax::IResourceName, sys::IEquatable<ServiceName>
    {
        /// <summary>The possible contents of <see cref="ServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>services/{service}/configs/{config}</c>.</summary>
            ServiceConfig = 1,
        }

        private static gax::PathTemplate s_serviceConfig = new gax::PathTemplate("services/{service}/configs/{config}");

        /// <summary>Creates a <see cref="ServiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceName"/> with the pattern <c>services/{service}/configs/{config}</c>.
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceName"/> constructed from the provided ids.</returns>
        public static ServiceName FromServiceConfig(string serviceId, string configId) =>
            new ServiceName(ResourceNameType.ServiceConfig, serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), configId: gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>services/{service}/configs/{config}</c>.
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>services/{service}/configs/{config}</c>.
        /// </returns>
        public static string Format(string serviceId, string configId) => FormatServiceConfig(serviceId, configId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>services/{service}/configs/{config}</c>.
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>services/{service}/configs/{config}</c>.
        /// </returns>
        public static string FormatServiceConfig(string serviceId, string configId) =>
            s_serviceConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)));

        /// <summary>Parses the given resource name string into a new <see cref="ServiceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>services/{service}/configs/{config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceName"/> if successful.</returns>
        public static ServiceName Parse(string serviceName) => Parse(serviceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>services/{service}/configs/{config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceName"/> if successful.</returns>
        public static ServiceName Parse(string serviceName, bool allowUnparsed) =>
            TryParse(serviceName, allowUnparsed, out ServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>services/{service}/configs/{config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceName, out ServiceName result) => TryParse(serviceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>services/{service}/configs/{config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceName, bool allowUnparsed, out ServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName));
            gax::TemplatedResourceName resourceName;
            if (s_serviceConfig.TryParseName(serviceName, out resourceName))
            {
                result = FromServiceConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string configId = null, string serviceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConfigId = configId;
            ServiceId = serviceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceName"/> class from the component parts of pattern
        /// <c>services/{service}/configs/{config}</c>
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceName(string serviceId, string configId) : this(ResourceNameType.ServiceConfig, serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), configId: gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)))
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
        /// The <c>Config</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ConfigId { get; }

        /// <summary>
        /// The <c>Service</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ServiceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ServiceConfig: return s_serviceConfig.Expand(ServiceId, ConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceName);

        /// <inheritdoc/>
        public bool Equals(ServiceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceName a, ServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceName a, ServiceName b) => !(a == b);
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
        /// <see cref="ManagedServiceName"/>-typed view over the <see cref="ManagedService"/> resource name property.
        /// </summary>
        public ManagedServiceName ManagedServiceAsManagedServiceName
        {
            get => string.IsNullOrEmpty(ManagedService) ? null : ManagedServiceName.Parse(ManagedService, allowUnparsed: true);
            set => ManagedService = value?.ToString() ?? "";
        }
    }

    public partial class ApiConfig
    {
        /// <summary>
        /// <see cref="gcav::ApiConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiConfigName ApiConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ServiceName"/>-typed view over the <see cref="ServiceConfigId"/> resource name property.
        /// </summary>
        public ServiceName ServiceConfigIdAsServiceName
        {
            get => string.IsNullOrEmpty(ServiceConfigId) ? null : ServiceName.Parse(ServiceConfigId, allowUnparsed: true);
            set => ServiceConfigId = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ServiceAccountName"/>-typed view over the <see cref="GatewayServiceAccount"/> resource name
        /// property.
        /// </summary>
        public ServiceAccountName GatewayServiceAccountAsServiceAccountName
        {
            get => string.IsNullOrEmpty(GatewayServiceAccount) ? null : ServiceAccountName.Parse(GatewayServiceAccount, allowUnparsed: true);
            set => GatewayServiceAccount = value?.ToString() ?? "";
        }
    }

    public partial class Gateway
    {
        /// <summary>
        /// <see cref="gcav::GatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::GatewayName GatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::GatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ApiConfigName"/>-typed view over the <see cref="ApiConfig"/> resource name property.
        /// </summary>
        public ApiConfigName ApiConfigAsApiConfigName
        {
            get => string.IsNullOrEmpty(ApiConfig) ? null : ApiConfigName.Parse(ApiConfig, allowUnparsed: true);
            set => ApiConfig = value?.ToString() ?? "";
        }
    }

    public partial class ListGatewaysRequest
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

    public partial class GetGatewayRequest
    {
        /// <summary>
        /// <see cref="gcav::GatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::GatewayName GatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::GatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGatewayRequest
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

    public partial class DeleteGatewayRequest
    {
        /// <summary>
        /// <see cref="gcav::GatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::GatewayName GatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::GatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListApisRequest
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

    public partial class GetApiRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiName ApiName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateApiRequest
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

    public partial class DeleteApiRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiName ApiName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListApiConfigsRequest
    {
        /// <summary><see cref="ApiName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ApiName ParentAsApiName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetApiConfigRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiConfigName ApiConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateApiConfigRequest
    {
        /// <summary><see cref="ApiName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ApiName ParentAsApiName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteApiConfigRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiConfigName ApiConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

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
using gcoasv = Google.Cloud.Orchestration.Airflow.Service.V1;
using sys = System;

namespace Google.Cloud.Orchestration.Airflow.Service.V1
{
    /// <summary>Resource name for the <c>UserWorkloadsSecret</c> resource.</summary>
    public sealed partial class UserWorkloadsSecretName : gax::IResourceName, sys::IEquatable<UserWorkloadsSecretName>
    {
        /// <summary>The possible contents of <see cref="UserWorkloadsSecretName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsSecrets/{user_workloads_secret}</c>
            /// .
            /// </summary>
            ProjectLocationEnvironmentUserWorkloadsSecret = 1,
        }

        private static gax::PathTemplate s_projectLocationEnvironmentUserWorkloadsSecret = new gax::PathTemplate("projects/{project}/locations/{location}/environments/{environment}/userWorkloadsSecrets/{user_workloads_secret}");

        /// <summary>Creates a <see cref="UserWorkloadsSecretName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserWorkloadsSecretName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UserWorkloadsSecretName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserWorkloadsSecretName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UserWorkloadsSecretName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsSecrets/{user_workloads_secret}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userWorkloadsSecretId">
        /// The <c>UserWorkloadsSecret</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="UserWorkloadsSecretName"/> constructed from the provided ids.
        /// </returns>
        public static UserWorkloadsSecretName FromProjectLocationEnvironmentUserWorkloadsSecret(string projectId, string locationId, string environmentId, string userWorkloadsSecretId) =>
            new UserWorkloadsSecretName(ResourceNameType.ProjectLocationEnvironmentUserWorkloadsSecret, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), userWorkloadsSecretId: gax::GaxPreconditions.CheckNotNullOrEmpty(userWorkloadsSecretId, nameof(userWorkloadsSecretId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserWorkloadsSecretName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsSecrets/{user_workloads_secret}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userWorkloadsSecretId">
        /// The <c>UserWorkloadsSecret</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="UserWorkloadsSecretName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsSecrets/{user_workloads_secret}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string environmentId, string userWorkloadsSecretId) =>
            FormatProjectLocationEnvironmentUserWorkloadsSecret(projectId, locationId, environmentId, userWorkloadsSecretId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserWorkloadsSecretName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsSecrets/{user_workloads_secret}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userWorkloadsSecretId">
        /// The <c>UserWorkloadsSecret</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="UserWorkloadsSecretName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsSecrets/{user_workloads_secret}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationEnvironmentUserWorkloadsSecret(string projectId, string locationId, string environmentId, string userWorkloadsSecretId) =>
            s_projectLocationEnvironmentUserWorkloadsSecret.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userWorkloadsSecretId, nameof(userWorkloadsSecretId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserWorkloadsSecretName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsSecrets/{user_workloads_secret}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userWorkloadsSecretName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserWorkloadsSecretName"/> if successful.</returns>
        public static UserWorkloadsSecretName Parse(string userWorkloadsSecretName) => Parse(userWorkloadsSecretName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserWorkloadsSecretName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsSecrets/{user_workloads_secret}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userWorkloadsSecretName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserWorkloadsSecretName"/> if successful.</returns>
        public static UserWorkloadsSecretName Parse(string userWorkloadsSecretName, bool allowUnparsed) =>
            TryParse(userWorkloadsSecretName, allowUnparsed, out UserWorkloadsSecretName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserWorkloadsSecretName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsSecrets/{user_workloads_secret}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userWorkloadsSecretName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserWorkloadsSecretName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userWorkloadsSecretName, out UserWorkloadsSecretName result) =>
            TryParse(userWorkloadsSecretName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserWorkloadsSecretName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsSecrets/{user_workloads_secret}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userWorkloadsSecretName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserWorkloadsSecretName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userWorkloadsSecretName, bool allowUnparsed, out UserWorkloadsSecretName result)
        {
            gax::GaxPreconditions.CheckNotNull(userWorkloadsSecretName, nameof(userWorkloadsSecretName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEnvironmentUserWorkloadsSecret.TryParseName(userWorkloadsSecretName, out resourceName))
            {
                result = FromProjectLocationEnvironmentUserWorkloadsSecret(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userWorkloadsSecretName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UserWorkloadsSecretName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string environmentId = null, string locationId = null, string projectId = null, string userWorkloadsSecretId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EnvironmentId = environmentId;
            LocationId = locationId;
            ProjectId = projectId;
            UserWorkloadsSecretId = userWorkloadsSecretId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserWorkloadsSecretName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsSecrets/{user_workloads_secret}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userWorkloadsSecretId">
        /// The <c>UserWorkloadsSecret</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public UserWorkloadsSecretName(string projectId, string locationId, string environmentId, string userWorkloadsSecretId) : this(ResourceNameType.ProjectLocationEnvironmentUserWorkloadsSecret, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), userWorkloadsSecretId: gax::GaxPreconditions.CheckNotNullOrEmpty(userWorkloadsSecretId, nameof(userWorkloadsSecretId)))
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
        /// The <c>Environment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EnvironmentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>UserWorkloadsSecret</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string UserWorkloadsSecretId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationEnvironmentUserWorkloadsSecret: return s_projectLocationEnvironmentUserWorkloadsSecret.Expand(ProjectId, LocationId, EnvironmentId, UserWorkloadsSecretId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserWorkloadsSecretName);

        /// <inheritdoc/>
        public bool Equals(UserWorkloadsSecretName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UserWorkloadsSecretName a, UserWorkloadsSecretName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UserWorkloadsSecretName a, UserWorkloadsSecretName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>UserWorkloadsConfigMap</c> resource.</summary>
    public sealed partial class UserWorkloadsConfigMapName : gax::IResourceName, sys::IEquatable<UserWorkloadsConfigMapName>
    {
        /// <summary>The possible contents of <see cref="UserWorkloadsConfigMapName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsConfigMaps/{user_workloads_config_map}</c>
            /// .
            /// </summary>
            ProjectLocationEnvironmentUserWorkloadsConfigMap = 1,
        }

        private static gax::PathTemplate s_projectLocationEnvironmentUserWorkloadsConfigMap = new gax::PathTemplate("projects/{project}/locations/{location}/environments/{environment}/userWorkloadsConfigMaps/{user_workloads_config_map}");

        /// <summary>Creates a <see cref="UserWorkloadsConfigMapName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserWorkloadsConfigMapName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UserWorkloadsConfigMapName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserWorkloadsConfigMapName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UserWorkloadsConfigMapName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsConfigMaps/{user_workloads_config_map}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userWorkloadsConfigMapId">
        /// The <c>UserWorkloadsConfigMap</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="UserWorkloadsConfigMapName"/> constructed from the provided ids.
        /// </returns>
        public static UserWorkloadsConfigMapName FromProjectLocationEnvironmentUserWorkloadsConfigMap(string projectId, string locationId, string environmentId, string userWorkloadsConfigMapId) =>
            new UserWorkloadsConfigMapName(ResourceNameType.ProjectLocationEnvironmentUserWorkloadsConfigMap, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), userWorkloadsConfigMapId: gax::GaxPreconditions.CheckNotNullOrEmpty(userWorkloadsConfigMapId, nameof(userWorkloadsConfigMapId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserWorkloadsConfigMapName"/> with pattern
        /// 
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsConfigMaps/{user_workloads_config_map}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userWorkloadsConfigMapId">
        /// The <c>UserWorkloadsConfigMap</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="UserWorkloadsConfigMapName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsConfigMaps/{user_workloads_config_map}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string environmentId, string userWorkloadsConfigMapId) =>
            FormatProjectLocationEnvironmentUserWorkloadsConfigMap(projectId, locationId, environmentId, userWorkloadsConfigMapId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserWorkloadsConfigMapName"/> with pattern
        /// 
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsConfigMaps/{user_workloads_config_map}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userWorkloadsConfigMapId">
        /// The <c>UserWorkloadsConfigMap</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="UserWorkloadsConfigMapName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsConfigMaps/{user_workloads_config_map}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationEnvironmentUserWorkloadsConfigMap(string projectId, string locationId, string environmentId, string userWorkloadsConfigMapId) =>
            s_projectLocationEnvironmentUserWorkloadsConfigMap.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userWorkloadsConfigMapId, nameof(userWorkloadsConfigMapId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserWorkloadsConfigMapName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsConfigMaps/{user_workloads_config_map}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userWorkloadsConfigMapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserWorkloadsConfigMapName"/> if successful.</returns>
        public static UserWorkloadsConfigMapName Parse(string userWorkloadsConfigMapName) =>
            Parse(userWorkloadsConfigMapName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserWorkloadsConfigMapName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsConfigMaps/{user_workloads_config_map}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userWorkloadsConfigMapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserWorkloadsConfigMapName"/> if successful.</returns>
        public static UserWorkloadsConfigMapName Parse(string userWorkloadsConfigMapName, bool allowUnparsed) =>
            TryParse(userWorkloadsConfigMapName, allowUnparsed, out UserWorkloadsConfigMapName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserWorkloadsConfigMapName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsConfigMaps/{user_workloads_config_map}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userWorkloadsConfigMapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserWorkloadsConfigMapName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userWorkloadsConfigMapName, out UserWorkloadsConfigMapName result) =>
            TryParse(userWorkloadsConfigMapName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserWorkloadsConfigMapName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsConfigMaps/{user_workloads_config_map}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userWorkloadsConfigMapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserWorkloadsConfigMapName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userWorkloadsConfigMapName, bool allowUnparsed, out UserWorkloadsConfigMapName result)
        {
            gax::GaxPreconditions.CheckNotNull(userWorkloadsConfigMapName, nameof(userWorkloadsConfigMapName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEnvironmentUserWorkloadsConfigMap.TryParseName(userWorkloadsConfigMapName, out resourceName))
            {
                result = FromProjectLocationEnvironmentUserWorkloadsConfigMap(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userWorkloadsConfigMapName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UserWorkloadsConfigMapName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string environmentId = null, string locationId = null, string projectId = null, string userWorkloadsConfigMapId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EnvironmentId = environmentId;
            LocationId = locationId;
            ProjectId = projectId;
            UserWorkloadsConfigMapId = userWorkloadsConfigMapId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserWorkloadsConfigMapName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/environments/{environment}/userWorkloadsConfigMaps/{user_workloads_config_map}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userWorkloadsConfigMapId">
        /// The <c>UserWorkloadsConfigMap</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public UserWorkloadsConfigMapName(string projectId, string locationId, string environmentId, string userWorkloadsConfigMapId) : this(ResourceNameType.ProjectLocationEnvironmentUserWorkloadsConfigMap, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), userWorkloadsConfigMapId: gax::GaxPreconditions.CheckNotNullOrEmpty(userWorkloadsConfigMapId, nameof(userWorkloadsConfigMapId)))
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
        /// The <c>Environment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EnvironmentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>UserWorkloadsConfigMap</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string UserWorkloadsConfigMapId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationEnvironmentUserWorkloadsConfigMap: return s_projectLocationEnvironmentUserWorkloadsConfigMap.Expand(ProjectId, LocationId, EnvironmentId, UserWorkloadsConfigMapId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserWorkloadsConfigMapName);

        /// <inheritdoc/>
        public bool Equals(UserWorkloadsConfigMapName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UserWorkloadsConfigMapName a, UserWorkloadsConfigMapName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UserWorkloadsConfigMapName a, UserWorkloadsConfigMapName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Environment</c> resource.</summary>
    public sealed partial class EnvironmentName : gax::IResourceName, sys::IEquatable<EnvironmentName>
    {
        /// <summary>The possible contents of <see cref="EnvironmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/environments/{environment}</c>.
            /// </summary>
            ProjectLocationEnvironment = 1,
        }

        private static gax::PathTemplate s_projectLocationEnvironment = new gax::PathTemplate("projects/{project}/locations/{location}/environments/{environment}");

        /// <summary>Creates a <see cref="EnvironmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EnvironmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EnvironmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EnvironmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EnvironmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/environments/{environment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EnvironmentName"/> constructed from the provided ids.</returns>
        public static EnvironmentName FromProjectLocationEnvironment(string projectId, string locationId, string environmentId) =>
            new EnvironmentName(ResourceNameType.ProjectLocationEnvironment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/environments/{environment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/environments/{environment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string environmentId) =>
            FormatProjectLocationEnvironment(projectId, locationId, environmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/environments/{environment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/environments/{environment}</c>.
        /// </returns>
        public static string FormatProjectLocationEnvironment(string projectId, string locationId, string environmentId) =>
            s_projectLocationEnvironment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)));

        /// <summary>Parses the given resource name string into a new <see cref="EnvironmentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/environments/{environment}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EnvironmentName"/> if successful.</returns>
        public static EnvironmentName Parse(string environmentName) => Parse(environmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EnvironmentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/environments/{environment}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EnvironmentName"/> if successful.</returns>
        public static EnvironmentName Parse(string environmentName, bool allowUnparsed) =>
            TryParse(environmentName, allowUnparsed, out EnvironmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnvironmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/environments/{environment}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnvironmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string environmentName, out EnvironmentName result) =>
            TryParse(environmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnvironmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/environments/{environment}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnvironmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string environmentName, bool allowUnparsed, out EnvironmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(environmentName, nameof(environmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEnvironment.TryParseName(environmentName, out resourceName))
            {
                result = FromProjectLocationEnvironment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(environmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EnvironmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string environmentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EnvironmentId = environmentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EnvironmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/environments/{environment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        public EnvironmentName(string projectId, string locationId, string environmentId) : this(ResourceNameType.ProjectLocationEnvironment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)))
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
        /// The <c>Environment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EnvironmentId { get; }

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
                case ResourceNameType.ProjectLocationEnvironment: return s_projectLocationEnvironment.Expand(ProjectId, LocationId, EnvironmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EnvironmentName);

        /// <inheritdoc/>
        public bool Equals(EnvironmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EnvironmentName a, EnvironmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EnvironmentName a, EnvironmentName b) => !(a == b);
    }

    public partial class CreateUserWorkloadsSecretRequest
    {
        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EnvironmentName ParentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EnvironmentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetUserWorkloadsSecretRequest
    {
        /// <summary>
        /// <see cref="gcoasv::UserWorkloadsSecretName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcoasv::UserWorkloadsSecretName UserWorkloadsSecretName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoasv::UserWorkloadsSecretName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListUserWorkloadsSecretsRequest
    {
        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EnvironmentName ParentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EnvironmentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteUserWorkloadsSecretRequest
    {
        /// <summary>
        /// <see cref="gcoasv::UserWorkloadsSecretName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcoasv::UserWorkloadsSecretName UserWorkloadsSecretName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoasv::UserWorkloadsSecretName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateUserWorkloadsConfigMapRequest
    {
        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EnvironmentName ParentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EnvironmentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetUserWorkloadsConfigMapRequest
    {
        /// <summary>
        /// <see cref="gcoasv::UserWorkloadsConfigMapName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcoasv::UserWorkloadsConfigMapName UserWorkloadsConfigMapName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoasv::UserWorkloadsConfigMapName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListUserWorkloadsConfigMapsRequest
    {
        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EnvironmentName ParentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EnvironmentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteUserWorkloadsConfigMapRequest
    {
        /// <summary>
        /// <see cref="gcoasv::UserWorkloadsConfigMapName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcoasv::UserWorkloadsConfigMapName UserWorkloadsConfigMapName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoasv::UserWorkloadsConfigMapName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UserWorkloadsSecret
    {
        /// <summary>
        /// <see cref="gcoasv::UserWorkloadsSecretName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcoasv::UserWorkloadsSecretName UserWorkloadsSecretName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoasv::UserWorkloadsSecretName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UserWorkloadsConfigMap
    {
        /// <summary>
        /// <see cref="gcoasv::UserWorkloadsConfigMapName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcoasv::UserWorkloadsConfigMapName UserWorkloadsConfigMapName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoasv::UserWorkloadsConfigMapName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWorkloadsRequest
    {
        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EnvironmentName ParentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EnvironmentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class FetchDatabasePropertiesRequest
    {
        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Environment"/> resource name property.
        /// </summary>
        public EnvironmentName EnvironmentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Environment) ? null : EnvironmentName.Parse(Environment, allowUnparsed: true);
            set => Environment = value?.ToString() ?? "";
        }
    }

    public partial class Environment
    {
        /// <summary>
        /// <see cref="gcoasv::EnvironmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcoasv::EnvironmentName EnvironmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoasv::EnvironmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

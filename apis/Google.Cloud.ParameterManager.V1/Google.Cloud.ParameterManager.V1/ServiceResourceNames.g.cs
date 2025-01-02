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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcpv = Google.Cloud.ParameterManager.V1;
using sys = System;

namespace Google.Cloud.ParameterManager.V1
{
    /// <summary>Resource name for the <c>Parameter</c> resource.</summary>
    public sealed partial class ParameterName : gax::IResourceName, sys::IEquatable<ParameterName>
    {
        /// <summary>The possible contents of <see cref="ParameterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/parameters/{parameter}</c>.
            /// </summary>
            ProjectLocationParameter = 1,
        }

        private static gax::PathTemplate s_projectLocationParameter = new gax::PathTemplate("projects/{project}/locations/{location}/parameters/{parameter}");

        /// <summary>Creates a <see cref="ParameterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ParameterName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ParameterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ParameterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ParameterName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parameterId">The <c>Parameter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ParameterName"/> constructed from the provided ids.</returns>
        public static ParameterName FromProjectLocationParameter(string projectId, string locationId, string parameterId) =>
            new ParameterName(ResourceNameType.ProjectLocationParameter, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), parameterId: gax::GaxPreconditions.CheckNotNullOrEmpty(parameterId, nameof(parameterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParameterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parameterId">The <c>Parameter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ParameterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string parameterId) =>
            FormatProjectLocationParameter(projectId, locationId, parameterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParameterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parameterId">The <c>Parameter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ParameterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}</c>.
        /// </returns>
        public static string FormatProjectLocationParameter(string projectId, string locationId, string parameterId) =>
            s_projectLocationParameter.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(parameterId, nameof(parameterId)));

        /// <summary>Parses the given resource name string into a new <see cref="ParameterName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/parameters/{parameter}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="parameterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ParameterName"/> if successful.</returns>
        public static ParameterName Parse(string parameterName) => Parse(parameterName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ParameterName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/parameters/{parameter}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="parameterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ParameterName"/> if successful.</returns>
        public static ParameterName Parse(string parameterName, bool allowUnparsed) =>
            TryParse(parameterName, allowUnparsed, out ParameterName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParameterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/parameters/{parameter}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="parameterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParameterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string parameterName, out ParameterName result) => TryParse(parameterName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParameterName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/parameters/{parameter}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="parameterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParameterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string parameterName, bool allowUnparsed, out ParameterName result)
        {
            gax::GaxPreconditions.CheckNotNull(parameterName, nameof(parameterName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationParameter.TryParseName(parameterName, out resourceName))
            {
                result = FromProjectLocationParameter(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(parameterName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ParameterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string parameterId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ParameterId = parameterId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ParameterName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parameterId">The <c>Parameter</c> ID. Must not be <c>null</c> or empty.</param>
        public ParameterName(string projectId, string locationId, string parameterId) : this(ResourceNameType.ProjectLocationParameter, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), parameterId: gax::GaxPreconditions.CheckNotNullOrEmpty(parameterId, nameof(parameterId)))
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
        /// The <c>Parameter</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ParameterId { get; }

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
                case ResourceNameType.ProjectLocationParameter: return s_projectLocationParameter.Expand(ProjectId, LocationId, ParameterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ParameterName);

        /// <inheritdoc/>
        public bool Equals(ParameterName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ParameterName a, ParameterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ParameterName a, ParameterName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ParameterVersion</c> resource.</summary>
    public sealed partial class ParameterVersionName : gax::IResourceName, sys::IEquatable<ParameterVersionName>
    {
        /// <summary>The possible contents of <see cref="ParameterVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/parameters/{parameter}/versions/{parameter_version}</c>.
            /// </summary>
            ProjectLocationParameterParameterVersion = 1,
        }

        private static gax::PathTemplate s_projectLocationParameterParameterVersion = new gax::PathTemplate("projects/{project}/locations/{location}/parameters/{parameter}/versions/{parameter_version}");

        /// <summary>Creates a <see cref="ParameterVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ParameterVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ParameterVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ParameterVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ParameterVersionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}/versions/{parameter_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parameterId">The <c>Parameter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parameterVersionId">The <c>ParameterVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ParameterVersionName"/> constructed from the provided ids.</returns>
        public static ParameterVersionName FromProjectLocationParameterParameterVersion(string projectId, string locationId, string parameterId, string parameterVersionId) =>
            new ParameterVersionName(ResourceNameType.ProjectLocationParameterParameterVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), parameterId: gax::GaxPreconditions.CheckNotNullOrEmpty(parameterId, nameof(parameterId)), parameterVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(parameterVersionId, nameof(parameterVersionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParameterVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}/versions/{parameter_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parameterId">The <c>Parameter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parameterVersionId">The <c>ParameterVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ParameterVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}/versions/{parameter_version}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string parameterId, string parameterVersionId) =>
            FormatProjectLocationParameterParameterVersion(projectId, locationId, parameterId, parameterVersionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParameterVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}/versions/{parameter_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parameterId">The <c>Parameter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parameterVersionId">The <c>ParameterVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ParameterVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}/versions/{parameter_version}</c>.
        /// </returns>
        public static string FormatProjectLocationParameterParameterVersion(string projectId, string locationId, string parameterId, string parameterVersionId) =>
            s_projectLocationParameterParameterVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(parameterId, nameof(parameterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(parameterVersionId, nameof(parameterVersionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ParameterVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}/versions/{parameter_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="parameterVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ParameterVersionName"/> if successful.</returns>
        public static ParameterVersionName Parse(string parameterVersionName) => Parse(parameterVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ParameterVersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}/versions/{parameter_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="parameterVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ParameterVersionName"/> if successful.</returns>
        public static ParameterVersionName Parse(string parameterVersionName, bool allowUnparsed) =>
            TryParse(parameterVersionName, allowUnparsed, out ParameterVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParameterVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}/versions/{parameter_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="parameterVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParameterVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string parameterVersionName, out ParameterVersionName result) =>
            TryParse(parameterVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParameterVersionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}/versions/{parameter_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="parameterVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParameterVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string parameterVersionName, bool allowUnparsed, out ParameterVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(parameterVersionName, nameof(parameterVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationParameterParameterVersion.TryParseName(parameterVersionName, out resourceName))
            {
                result = FromProjectLocationParameterParameterVersion(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(parameterVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ParameterVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string parameterId = null, string parameterVersionId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ParameterId = parameterId;
            ParameterVersionId = parameterVersionId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ParameterVersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/parameters/{parameter}/versions/{parameter_version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parameterId">The <c>Parameter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parameterVersionId">The <c>ParameterVersion</c> ID. Must not be <c>null</c> or empty.</param>
        public ParameterVersionName(string projectId, string locationId, string parameterId, string parameterVersionId) : this(ResourceNameType.ProjectLocationParameterParameterVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), parameterId: gax::GaxPreconditions.CheckNotNullOrEmpty(parameterId, nameof(parameterId)), parameterVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(parameterVersionId, nameof(parameterVersionId)))
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
        /// The <c>Parameter</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ParameterId { get; }

        /// <summary>
        /// The <c>ParameterVersion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ParameterVersionId { get; }

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
                case ResourceNameType.ProjectLocationParameterParameterVersion: return s_projectLocationParameterParameterVersion.Expand(ProjectId, LocationId, ParameterId, ParameterVersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ParameterVersionName);

        /// <inheritdoc/>
        public bool Equals(ParameterVersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ParameterVersionName a, ParameterVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ParameterVersionName a, ParameterVersionName b) => !(a == b);
    }

    public partial class Parameter
    {
        /// <summary>
        /// <see cref="gcpv::ParameterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ParameterName ParameterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ParameterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListParametersRequest
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

    public partial class GetParameterRequest
    {
        /// <summary>
        /// <see cref="gcpv::ParameterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ParameterName ParameterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ParameterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateParameterRequest
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

    public partial class DeleteParameterRequest
    {
        /// <summary>
        /// <see cref="gcpv::ParameterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ParameterName ParameterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ParameterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ParameterVersion
    {
        /// <summary>
        /// <see cref="gcpv::ParameterVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ParameterVersionName ParameterVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ParameterVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListParameterVersionsRequest
    {
        /// <summary>
        /// <see cref="ParameterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParameterName ParentAsParameterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ParameterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetParameterVersionRequest
    {
        /// <summary>
        /// <see cref="gcpv::ParameterVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ParameterVersionName ParameterVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ParameterVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RenderParameterVersionRequest
    {
        /// <summary>
        /// <see cref="gcpv::ParameterVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ParameterVersionName ParameterVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ParameterVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RenderParameterVersionResponse
    {
        /// <summary>
        /// <see cref="ParameterVersionName"/>-typed view over the <see cref="ParameterVersion"/> resource name
        /// property.
        /// </summary>
        public ParameterVersionName ParameterVersionAsParameterVersionName
        {
            get => string.IsNullOrEmpty(ParameterVersion) ? null : ParameterVersionName.Parse(ParameterVersion, allowUnparsed: true);
            set => ParameterVersion = value?.ToString() ?? "";
        }
    }

    public partial class CreateParameterVersionRequest
    {
        /// <summary>
        /// <see cref="ParameterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParameterName ParentAsParameterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ParameterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteParameterVersionRequest
    {
        /// <summary>
        /// <see cref="gcpv::ParameterVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ParameterVersionName ParameterVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ParameterVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

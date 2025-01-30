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
using sys = System;

namespace Google.Cloud.ApigeeConnect.V1
{
    /// <summary>Resource name for the <c>Endpoint</c> resource.</summary>
    public sealed partial class EndpointName : gax::IResourceName, sys::IEquatable<EndpointName>
    {
        /// <summary>The possible contents of <see cref="EndpointName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/endpoints/{endpoint}</c>.</summary>
            ProjectEndpoint = 1,
        }

        private static gax::PathTemplate s_projectEndpoint = new gax::PathTemplate("projects/{project}/endpoints/{endpoint}");

        /// <summary>Creates a <see cref="EndpointName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EndpointName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static EndpointName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EndpointName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EndpointName"/> with the pattern <c>projects/{project}/endpoints/{endpoint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endpointId">The <c>Endpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EndpointName"/> constructed from the provided ids.</returns>
        public static EndpointName FromProjectEndpoint(string projectId, string endpointId) =>
            new EndpointName(ResourceNameType.ProjectEndpoint, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), endpointId: gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EndpointName"/> with pattern
        /// <c>projects/{project}/endpoints/{endpoint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endpointId">The <c>Endpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EndpointName"/> with pattern
        /// <c>projects/{project}/endpoints/{endpoint}</c>.
        /// </returns>
        public static string Format(string projectId, string endpointId) => FormatProjectEndpoint(projectId, endpointId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EndpointName"/> with pattern
        /// <c>projects/{project}/endpoints/{endpoint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endpointId">The <c>Endpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EndpointName"/> with pattern
        /// <c>projects/{project}/endpoints/{endpoint}</c>.
        /// </returns>
        public static string FormatProjectEndpoint(string projectId, string endpointId) =>
            s_projectEndpoint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)));

        /// <summary>Parses the given resource name string into a new <see cref="EndpointName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/endpoints/{endpoint}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="endpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EndpointName"/> if successful.</returns>
        public static EndpointName Parse(string endpointName) => Parse(endpointName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EndpointName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/endpoints/{endpoint}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="endpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EndpointName"/> if successful.</returns>
        public static EndpointName Parse(string endpointName, bool allowUnparsed) =>
            TryParse(endpointName, allowUnparsed, out EndpointName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EndpointName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/endpoints/{endpoint}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="endpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EndpointName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string endpointName, out EndpointName result) => TryParse(endpointName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EndpointName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/endpoints/{endpoint}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="endpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EndpointName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string endpointName, bool allowUnparsed, out EndpointName result)
        {
            gax::GaxPreconditions.CheckNotNull(endpointName, nameof(endpointName));
            gax::TemplatedResourceName resourceName;
            if (s_projectEndpoint.TryParseName(endpointName, out resourceName))
            {
                result = FromProjectEndpoint(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(endpointName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EndpointName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string endpointId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EndpointId = endpointId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EndpointName"/> class from the component parts of pattern
        /// <c>projects/{project}/endpoints/{endpoint}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endpointId">The <c>Endpoint</c> ID. Must not be <c>null</c> or empty.</param>
        public EndpointName(string projectId, string endpointId) : this(ResourceNameType.ProjectEndpoint, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), endpointId: gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)))
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
        /// The <c>Endpoint</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EndpointId { get; }

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
                case ResourceNameType.ProjectEndpoint: return s_projectEndpoint.Expand(ProjectId, EndpointId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EndpointName);

        /// <inheritdoc/>
        public bool Equals(EndpointName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EndpointName a, EndpointName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EndpointName a, EndpointName b) => !(a == b);
    }

    public partial class ListConnectionsRequest
    {
        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EndpointName ParentAsEndpointName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EndpointName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}

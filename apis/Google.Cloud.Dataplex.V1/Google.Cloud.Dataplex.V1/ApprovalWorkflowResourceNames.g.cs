// Copyright 2026 Google LLC
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
using gcdv = Google.Cloud.Dataplex.V1;
using sys = System;

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Resource name for the <c>ChangeRequest</c> resource.</summary>
    public sealed partial class ChangeRequestName : gax::IResourceName, sys::IEquatable<ChangeRequestName>
    {
        /// <summary>The possible contents of <see cref="ChangeRequestName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/changeRequests/{change_request}</c>
            /// .
            /// </summary>
            ProjectLocationChangeRequest = 1,
        }

        private static gax::PathTemplate s_projectLocationChangeRequest = new gax::PathTemplate("projects/{project}/locations/{location}/changeRequests/{change_request}");

        /// <summary>Creates a <see cref="ChangeRequestName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ChangeRequestName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ChangeRequestName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ChangeRequestName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ChangeRequestName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/changeRequests/{change_request}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changeRequestId">The <c>ChangeRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ChangeRequestName"/> constructed from the provided ids.</returns>
        public static ChangeRequestName FromProjectLocationChangeRequest(string projectId, string locationId, string changeRequestId) =>
            new ChangeRequestName(ResourceNameType.ProjectLocationChangeRequest, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), changeRequestId: gax::GaxPreconditions.CheckNotNullOrEmpty(changeRequestId, nameof(changeRequestId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChangeRequestName"/> with pattern
        /// <c>projects/{project}/locations/{location}/changeRequests/{change_request}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changeRequestId">The <c>ChangeRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChangeRequestName"/> with pattern
        /// <c>projects/{project}/locations/{location}/changeRequests/{change_request}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string changeRequestId) =>
            FormatProjectLocationChangeRequest(projectId, locationId, changeRequestId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChangeRequestName"/> with pattern
        /// <c>projects/{project}/locations/{location}/changeRequests/{change_request}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changeRequestId">The <c>ChangeRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChangeRequestName"/> with pattern
        /// <c>projects/{project}/locations/{location}/changeRequests/{change_request}</c>.
        /// </returns>
        public static string FormatProjectLocationChangeRequest(string projectId, string locationId, string changeRequestId) =>
            s_projectLocationChangeRequest.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(changeRequestId, nameof(changeRequestId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChangeRequestName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/changeRequests/{change_request}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="changeRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ChangeRequestName"/> if successful.</returns>
        public static ChangeRequestName Parse(string changeRequestName) => Parse(changeRequestName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChangeRequestName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/changeRequests/{change_request}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="changeRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ChangeRequestName"/> if successful.</returns>
        public static ChangeRequestName Parse(string changeRequestName, bool allowUnparsed) =>
            TryParse(changeRequestName, allowUnparsed, out ChangeRequestName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChangeRequestName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/changeRequests/{change_request}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="changeRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChangeRequestName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string changeRequestName, out ChangeRequestName result) =>
            TryParse(changeRequestName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChangeRequestName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/changeRequests/{change_request}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="changeRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChangeRequestName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string changeRequestName, bool allowUnparsed, out ChangeRequestName result)
        {
            gax::GaxPreconditions.CheckNotNull(changeRequestName, nameof(changeRequestName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationChangeRequest.TryParseName(changeRequestName, out resourceName))
            {
                result = FromProjectLocationChangeRequest(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(changeRequestName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ChangeRequestName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string changeRequestId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ChangeRequestId = changeRequestId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ChangeRequestName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/changeRequests/{change_request}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changeRequestId">The <c>ChangeRequest</c> ID. Must not be <c>null</c> or empty.</param>
        public ChangeRequestName(string projectId, string locationId, string changeRequestId) : this(ResourceNameType.ProjectLocationChangeRequest, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), changeRequestId: gax::GaxPreconditions.CheckNotNullOrEmpty(changeRequestId, nameof(changeRequestId)))
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
        /// The <c>ChangeRequest</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ChangeRequestId { get; }

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
                case ResourceNameType.ProjectLocationChangeRequest: return s_projectLocationChangeRequest.Expand(ProjectId, LocationId, ChangeRequestId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ChangeRequestName);

        /// <inheritdoc/>
        public bool Equals(ChangeRequestName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ChangeRequestName a, ChangeRequestName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ChangeRequestName a, ChangeRequestName b) => !(a == b);
    }

    public partial class ChangeRequest
    {
        /// <summary>
        /// <see cref="gcdv::ChangeRequestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ChangeRequestName ChangeRequestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ChangeRequestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Resource"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceAsResourceName
        {
            get => string.IsNullOrEmpty(Resource) ? null : gax::UnparsedResourceName.Parse(Resource);
            set => Resource = value?.ToString() ?? "";
        }
    }

    public partial class DataProductAccessRequest
    {
        /// <summary>
        /// <see cref="DataProductName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataProductName ParentAsDataProductName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataProductName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}

// Copyright 2023 Google LLC
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
using gccv = Google.Cloud.CloudDms.V1;
using sys = System;

namespace Google.Cloud.CloudDms.V1
{
    /// <summary>Resource name for the <c>ConversionWorkspace</c> resource.</summary>
    public sealed partial class ConversionWorkspaceName : gax::IResourceName, sys::IEquatable<ConversionWorkspaceName>
    {
        /// <summary>The possible contents of <see cref="ConversionWorkspaceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}</c>.
            /// </summary>
            ProjectLocationConversionWorkspace = 1,
        }

        private static gax::PathTemplate s_projectLocationConversionWorkspace = new gax::PathTemplate("projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}");

        /// <summary>Creates a <see cref="ConversionWorkspaceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConversionWorkspaceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConversionWorkspaceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConversionWorkspaceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConversionWorkspaceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionWorkspaceId">
        /// The <c>ConversionWorkspace</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ConversionWorkspaceName"/> constructed from the provided ids.
        /// </returns>
        public static ConversionWorkspaceName FromProjectLocationConversionWorkspace(string projectId, string locationId, string conversionWorkspaceId) =>
            new ConversionWorkspaceName(ResourceNameType.ProjectLocationConversionWorkspace, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversionWorkspaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversionWorkspaceId, nameof(conversionWorkspaceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversionWorkspaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionWorkspaceId">
        /// The <c>ConversionWorkspace</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ConversionWorkspaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string conversionWorkspaceId) =>
            FormatProjectLocationConversionWorkspace(projectId, locationId, conversionWorkspaceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversionWorkspaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionWorkspaceId">
        /// The <c>ConversionWorkspace</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ConversionWorkspaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}</c>.
        /// </returns>
        public static string FormatProjectLocationConversionWorkspace(string projectId, string locationId, string conversionWorkspaceId) =>
            s_projectLocationConversionWorkspace.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversionWorkspaceId, nameof(conversionWorkspaceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversionWorkspaceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversionWorkspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConversionWorkspaceName"/> if successful.</returns>
        public static ConversionWorkspaceName Parse(string conversionWorkspaceName) => Parse(conversionWorkspaceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversionWorkspaceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversionWorkspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConversionWorkspaceName"/> if successful.</returns>
        public static ConversionWorkspaceName Parse(string conversionWorkspaceName, bool allowUnparsed) =>
            TryParse(conversionWorkspaceName, allowUnparsed, out ConversionWorkspaceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversionWorkspaceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversionWorkspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversionWorkspaceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversionWorkspaceName, out ConversionWorkspaceName result) =>
            TryParse(conversionWorkspaceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversionWorkspaceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversionWorkspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversionWorkspaceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversionWorkspaceName, bool allowUnparsed, out ConversionWorkspaceName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversionWorkspaceName, nameof(conversionWorkspaceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConversionWorkspace.TryParseName(conversionWorkspaceName, out resourceName))
            {
                result = FromProjectLocationConversionWorkspace(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conversionWorkspaceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConversionWorkspaceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversionWorkspaceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversionWorkspaceId = conversionWorkspaceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConversionWorkspaceName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionWorkspaceId">
        /// The <c>ConversionWorkspace</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ConversionWorkspaceName(string projectId, string locationId, string conversionWorkspaceId) : this(ResourceNameType.ProjectLocationConversionWorkspace, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversionWorkspaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversionWorkspaceId, nameof(conversionWorkspaceId)))
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
        /// The <c>ConversionWorkspace</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ConversionWorkspaceId { get; }

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
                case ResourceNameType.ProjectLocationConversionWorkspace: return s_projectLocationConversionWorkspace.Expand(ProjectId, LocationId, ConversionWorkspaceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConversionWorkspaceName);

        /// <inheritdoc/>
        public bool Equals(ConversionWorkspaceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ConversionWorkspaceName a, ConversionWorkspaceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ConversionWorkspaceName a, ConversionWorkspaceName b) => !(a == b);
    }

    public partial class ConversionWorkspace
    {
        /// <summary>
        /// <see cref="gccv::ConversionWorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversionWorkspaceName ConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversionWorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

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
using gcsv = Google.Cloud.ServiceDirectory.V1;
using sys = System;

namespace Google.Cloud.ServiceDirectory.V1
{
    /// <summary>Resource name for the <c>Namespace</c> resource.</summary>
    public sealed partial class NamespaceName : gax::IResourceName, sys::IEquatable<NamespaceName>
    {
        /// <summary>The possible contents of <see cref="NamespaceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/namespaces/{namespace}</c>.
            /// </summary>
            ProjectLocationNamespace = 1,
        }

        private static gax::PathTemplate s_projectLocationNamespace = new gax::PathTemplate("projects/{project}/locations/{location}/namespaces/{namespace}");

        /// <summary>Creates a <see cref="NamespaceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NamespaceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NamespaceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NamespaceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NamespaceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NamespaceName"/> constructed from the provided ids.</returns>
        public static NamespaceName FromProjectLocationNamespace(string projectId, string locationId, string namespaceId) =>
            new NamespaceName(ResourceNameType.ProjectLocationNamespace, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), namespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NamespaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NamespaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string namespaceId) =>
            FormatProjectLocationNamespace(projectId, locationId, namespaceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NamespaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NamespaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}</c>.
        /// </returns>
        public static string FormatProjectLocationNamespace(string projectId, string locationId, string namespaceId) =>
            s_projectLocationNamespace.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)));

        /// <summary>Parses the given resource name string into a new <see cref="NamespaceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/namespaces/{namespace}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="namespaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NamespaceName"/> if successful.</returns>
        public static NamespaceName Parse(string namespaceName) => Parse(namespaceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NamespaceName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/namespaces/{namespace}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="namespaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NamespaceName"/> if successful.</returns>
        public static NamespaceName Parse(string namespaceName, bool allowUnparsed) =>
            TryParse(namespaceName, allowUnparsed, out NamespaceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NamespaceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/namespaces/{namespace}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="namespaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NamespaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string namespaceName, out NamespaceName result) => TryParse(namespaceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NamespaceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/namespaces/{namespace}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="namespaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NamespaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string namespaceName, bool allowUnparsed, out NamespaceName result)
        {
            gax::GaxPreconditions.CheckNotNull(namespaceName, nameof(namespaceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNamespace.TryParseName(namespaceName, out resourceName))
            {
                result = FromProjectLocationNamespace(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(namespaceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NamespaceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string namespaceId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NamespaceId = namespaceId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NamespaceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        public NamespaceName(string projectId, string locationId, string namespaceId) : this(ResourceNameType.ProjectLocationNamespace, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), namespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)))
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
        /// The <c>Namespace</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NamespaceId { get; }

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
                case ResourceNameType.ProjectLocationNamespace: return s_projectLocationNamespace.Expand(ProjectId, LocationId, NamespaceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NamespaceName);

        /// <inheritdoc/>
        public bool Equals(NamespaceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NamespaceName a, NamespaceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NamespaceName a, NamespaceName b) => !(a == b);
    }

    public partial class Namespace
    {
        /// <summary>
        /// <see cref="gcsv::NamespaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::NamespaceName NamespaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::NamespaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

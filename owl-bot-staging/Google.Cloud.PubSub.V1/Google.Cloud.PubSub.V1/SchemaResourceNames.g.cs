// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gcpv = Google.Cloud.PubSub.V1;
using sys = System;

namespace Google.Cloud.PubSub.V1
{
    /// <summary>Resource name for the <c>Schema</c> resource.</summary>
    public sealed partial class SchemaName : gax::IResourceName, sys::IEquatable<SchemaName>
    {
        /// <summary>The possible contents of <see cref="SchemaName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/schemas/{schema}</c>.</summary>
            ProjectSchema = 1,
        }

        private static gax::PathTemplate s_projectSchema = new gax::PathTemplate("projects/{project}/schemas/{schema}");

        /// <summary>Creates a <see cref="SchemaName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SchemaName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SchemaName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SchemaName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SchemaName"/> with the pattern <c>projects/{project}/schemas/{schema}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SchemaName"/> constructed from the provided ids.</returns>
        public static SchemaName FromProjectSchema(string projectId, string schemaId) =>
            new SchemaName(ResourceNameType.ProjectSchema, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), schemaId: gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/schemas/{schema}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/schemas/{schema}</c>.
        /// </returns>
        public static string Format(string projectId, string schemaId) => FormatProjectSchema(projectId, schemaId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/schemas/{schema}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/schemas/{schema}</c>.
        /// </returns>
        public static string FormatProjectSchema(string projectId, string schemaId) =>
            s_projectSchema.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)));

        /// <summary>Parses the given resource name string into a new <see cref="SchemaName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/schemas/{schema}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="schemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SchemaName"/> if successful.</returns>
        public static SchemaName Parse(string schemaName) => Parse(schemaName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SchemaName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/schemas/{schema}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="schemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SchemaName"/> if successful.</returns>
        public static SchemaName Parse(string schemaName, bool allowUnparsed) =>
            TryParse(schemaName, allowUnparsed, out SchemaName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SchemaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/schemas/{schema}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="schemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SchemaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string schemaName, out SchemaName result) => TryParse(schemaName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SchemaName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/schemas/{schema}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="schemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SchemaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string schemaName, bool allowUnparsed, out SchemaName result)
        {
            gax::GaxPreconditions.CheckNotNull(schemaName, nameof(schemaName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSchema.TryParseName(schemaName, out resourceName))
            {
                result = FromProjectSchema(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(schemaName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SchemaName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string schemaId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SchemaId = schemaId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SchemaName"/> class from the component parts of pattern
        /// <c>projects/{project}/schemas/{schema}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        public SchemaName(string projectId, string schemaId) : this(ResourceNameType.ProjectSchema, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), schemaId: gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)))
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
        /// The <c>Schema</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SchemaId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSchema: return s_projectSchema.Expand(ProjectId, SchemaId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SchemaName);

        /// <inheritdoc/>
        public bool Equals(SchemaName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SchemaName a, SchemaName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SchemaName a, SchemaName b) => !(a == b);
    }

    public partial class Schema
    {
        /// <summary>
        /// <see cref="gcpv::SchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::SchemaName SchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::SchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSchemaRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSchemaRequest
    {
        /// <summary>
        /// <see cref="gcpv::SchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::SchemaName SchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::SchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSchemasRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSchemaRequest
    {
        /// <summary>
        /// <see cref="gcpv::SchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::SchemaName SchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::SchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ValidateSchemaRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ValidateMessageRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcpv::SchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::SchemaName SchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::SchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

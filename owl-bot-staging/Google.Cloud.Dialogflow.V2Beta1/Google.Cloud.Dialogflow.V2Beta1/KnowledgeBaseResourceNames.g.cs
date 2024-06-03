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
using gcdv = Google.Cloud.Dialogflow.V2Beta1;
using sys = System;

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Resource name for the <c>KnowledgeBase</c> resource.</summary>
    public sealed partial class KnowledgeBaseName : gax::IResourceName, sys::IEquatable<KnowledgeBaseName>
    {
        /// <summary>The possible contents of <see cref="KnowledgeBaseName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/knowledgeBases/{knowledge_base}</c>.
            /// </summary>
            ProjectKnowledgeBase = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}</c>
            /// .
            /// </summary>
            ProjectLocationKnowledgeBase = 2,
        }

        private static gax::PathTemplate s_projectKnowledgeBase = new gax::PathTemplate("projects/{project}/knowledgeBases/{knowledge_base}");

        private static gax::PathTemplate s_projectLocationKnowledgeBase = new gax::PathTemplate("projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}");

        /// <summary>Creates a <see cref="KnowledgeBaseName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="KnowledgeBaseName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static KnowledgeBaseName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new KnowledgeBaseName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="KnowledgeBaseName"/> with the pattern
        /// <c>projects/{project}/knowledgeBases/{knowledge_base}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="knowledgeBaseId">The <c>KnowledgeBase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="KnowledgeBaseName"/> constructed from the provided ids.</returns>
        public static KnowledgeBaseName FromProjectKnowledgeBase(string projectId, string knowledgeBaseId) =>
            new KnowledgeBaseName(ResourceNameType.ProjectKnowledgeBase, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), knowledgeBaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(knowledgeBaseId, nameof(knowledgeBaseId)));

        /// <summary>
        /// Creates a <see cref="KnowledgeBaseName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="knowledgeBaseId">The <c>KnowledgeBase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="KnowledgeBaseName"/> constructed from the provided ids.</returns>
        public static KnowledgeBaseName FromProjectLocationKnowledgeBase(string projectId, string locationId, string knowledgeBaseId) =>
            new KnowledgeBaseName(ResourceNameType.ProjectLocationKnowledgeBase, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), knowledgeBaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(knowledgeBaseId, nameof(knowledgeBaseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KnowledgeBaseName"/> with pattern
        /// <c>projects/{project}/knowledgeBases/{knowledge_base}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="knowledgeBaseId">The <c>KnowledgeBase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="KnowledgeBaseName"/> with pattern
        /// <c>projects/{project}/knowledgeBases/{knowledge_base}</c>.
        /// </returns>
        public static string Format(string projectId, string knowledgeBaseId) =>
            FormatProjectKnowledgeBase(projectId, knowledgeBaseId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KnowledgeBaseName"/> with pattern
        /// <c>projects/{project}/knowledgeBases/{knowledge_base}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="knowledgeBaseId">The <c>KnowledgeBase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="KnowledgeBaseName"/> with pattern
        /// <c>projects/{project}/knowledgeBases/{knowledge_base}</c>.
        /// </returns>
        public static string FormatProjectKnowledgeBase(string projectId, string knowledgeBaseId) =>
            s_projectKnowledgeBase.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(knowledgeBaseId, nameof(knowledgeBaseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KnowledgeBaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="knowledgeBaseId">The <c>KnowledgeBase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="KnowledgeBaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}</c>.
        /// </returns>
        public static string FormatProjectLocationKnowledgeBase(string projectId, string locationId, string knowledgeBaseId) =>
            s_projectLocationKnowledgeBase.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(knowledgeBaseId, nameof(knowledgeBaseId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KnowledgeBaseName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/knowledgeBases/{knowledge_base}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="knowledgeBaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KnowledgeBaseName"/> if successful.</returns>
        public static KnowledgeBaseName Parse(string knowledgeBaseName) => Parse(knowledgeBaseName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KnowledgeBaseName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/knowledgeBases/{knowledge_base}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="knowledgeBaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="KnowledgeBaseName"/> if successful.</returns>
        public static KnowledgeBaseName Parse(string knowledgeBaseName, bool allowUnparsed) =>
            TryParse(knowledgeBaseName, allowUnparsed, out KnowledgeBaseName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KnowledgeBaseName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/knowledgeBases/{knowledge_base}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="knowledgeBaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KnowledgeBaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string knowledgeBaseName, out KnowledgeBaseName result) =>
            TryParse(knowledgeBaseName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KnowledgeBaseName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/knowledgeBases/{knowledge_base}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="knowledgeBaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KnowledgeBaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string knowledgeBaseName, bool allowUnparsed, out KnowledgeBaseName result)
        {
            gax::GaxPreconditions.CheckNotNull(knowledgeBaseName, nameof(knowledgeBaseName));
            gax::TemplatedResourceName resourceName;
            if (s_projectKnowledgeBase.TryParseName(knowledgeBaseName, out resourceName))
            {
                result = FromProjectKnowledgeBase(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationKnowledgeBase.TryParseName(knowledgeBaseName, out resourceName))
            {
                result = FromProjectLocationKnowledgeBase(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(knowledgeBaseName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private KnowledgeBaseName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string knowledgeBaseId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            KnowledgeBaseId = knowledgeBaseId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="KnowledgeBaseName"/> class from the component parts of pattern
        /// <c>projects/{project}/knowledgeBases/{knowledge_base}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="knowledgeBaseId">The <c>KnowledgeBase</c> ID. Must not be <c>null</c> or empty.</param>
        public KnowledgeBaseName(string projectId, string knowledgeBaseId) : this(ResourceNameType.ProjectKnowledgeBase, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), knowledgeBaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(knowledgeBaseId, nameof(knowledgeBaseId)))
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
        /// The <c>KnowledgeBase</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string KnowledgeBaseId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectKnowledgeBase: return s_projectKnowledgeBase.Expand(ProjectId, KnowledgeBaseId);
                case ResourceNameType.ProjectLocationKnowledgeBase: return s_projectLocationKnowledgeBase.Expand(ProjectId, LocationId, KnowledgeBaseId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as KnowledgeBaseName);

        /// <inheritdoc/>
        public bool Equals(KnowledgeBaseName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(KnowledgeBaseName a, KnowledgeBaseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(KnowledgeBaseName a, KnowledgeBaseName b) => !(a == b);
    }

    public partial class KnowledgeBase
    {
        /// <summary>
        /// <see cref="gcdv::KnowledgeBaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::KnowledgeBaseName KnowledgeBaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::KnowledgeBaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListKnowledgeBasesRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetKnowledgeBaseRequest
    {
        /// <summary>
        /// <see cref="gcdv::KnowledgeBaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::KnowledgeBaseName KnowledgeBaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::KnowledgeBaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateKnowledgeBaseRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteKnowledgeBaseRequest
    {
        /// <summary>
        /// <see cref="gcdv::KnowledgeBaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::KnowledgeBaseName KnowledgeBaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::KnowledgeBaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

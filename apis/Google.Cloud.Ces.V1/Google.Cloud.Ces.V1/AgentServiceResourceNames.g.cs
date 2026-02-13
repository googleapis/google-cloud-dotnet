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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gccv = Google.Cloud.Ces.V1;
using sys = System;

namespace Google.Cloud.Ces.V1
{
    /// <summary>Resource name for the <c>Dataset</c> resource.</summary>
    public sealed partial class DatasetName : gax::IResourceName, sys::IEquatable<DatasetName>
    {
        /// <summary>The possible contents of <see cref="DatasetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/datasets/{dataset}</c>.
            /// </summary>
            ProjectLocationDataset = 1,
        }

        private static gax::PathTemplate s_projectLocationDataset = new gax::PathTemplate("projects/{project}/locations/{location}/datasets/{dataset}");

        /// <summary>Creates a <see cref="DatasetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatasetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DatasetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatasetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatasetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DatasetName"/> constructed from the provided ids.</returns>
        public static DatasetName FromProjectLocationDataset(string projectId, string locationId, string datasetId) =>
            new DatasetName(ResourceNameType.ProjectLocationDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string datasetId) =>
            FormatProjectLocationDataset(projectId, locationId, datasetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}</c>.
        /// </returns>
        public static string FormatProjectLocationDataset(string projectId, string locationId, string datasetId) =>
            s_projectLocationDataset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>Parses the given resource name string into a new <see cref="DatasetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/datasets/{dataset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatasetName"/> if successful.</returns>
        public static DatasetName Parse(string datasetName) => Parse(datasetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatasetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/datasets/{dataset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatasetName"/> if successful.</returns>
        public static DatasetName Parse(string datasetName, bool allowUnparsed) =>
            TryParse(datasetName, allowUnparsed, out DatasetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/datasets/{dataset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetName, out DatasetName result) => TryParse(datasetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/datasets/{dataset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetName, bool allowUnparsed, out DatasetName result)
        {
            gax::GaxPreconditions.CheckNotNull(datasetName, nameof(datasetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataset.TryParseName(datasetName, out resourceName))
            {
                result = FromProjectLocationDataset(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(datasetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatasetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatasetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        public DatasetName(string projectId, string locationId, string datasetId) : this(ResourceNameType.ProjectLocationDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)))
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
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

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
                case ResourceNameType.ProjectLocationDataset: return s_projectLocationDataset.Expand(ProjectId, LocationId, DatasetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatasetName);

        /// <inheritdoc/>
        public bool Equals(DatasetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatasetName a, DatasetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatasetName a, DatasetName b) => !(a == b);
    }

    public partial class ListAppsRequest
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

    public partial class GetAppRequest
    {
        /// <summary>
        /// <see cref="gccv::AppName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AppName AppName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AppName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAppRequest
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

    public partial class DeleteAppRequest
    {
        /// <summary>
        /// <see cref="gccv::AppName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AppName AppName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AppName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportAppRequest
    {
        /// <summary>
        /// <see cref="gccv::AppName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AppName AppName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AppName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportAppRequest
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

    public partial class ImportAppResponse
    {
        /// <summary>
        /// <see cref="gccv::AppName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AppName AppName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AppName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAgentsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAgentRequest
    {
        /// <summary>
        /// <see cref="gccv::AgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AgentName AgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAgentRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAgentRequest
    {
        /// <summary>
        /// <see cref="gccv::AgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AgentName AgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListExamplesRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetExampleRequest
    {
        /// <summary>
        /// <see cref="gccv::ExampleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ExampleName ExampleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ExampleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateExampleRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteExampleRequest
    {
        /// <summary>
        /// <see cref="gccv::ExampleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ExampleName ExampleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ExampleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListToolsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetToolRequest
    {
        /// <summary>
        /// <see cref="gccv::ToolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ToolName ToolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ToolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateToolRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteToolRequest
    {
        /// <summary>
        /// <see cref="gccv::ToolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ToolName ToolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ToolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListConversationsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetConversationRequest
    {
        /// <summary>
        /// <see cref="gccv::ConversationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversationName ConversationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteConversationRequest
    {
        /// <summary>
        /// <see cref="gccv::ConversationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversationName ConversationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeleteConversationsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ConversationName"/>-typed view over the <see cref="Conversations"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ConversationName> ConversationsAsConversationNames
        {
            get => new gax::ResourceNameList<ConversationName>(Conversations, s => string.IsNullOrEmpty(s) ? null : ConversationName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ListGuardrailsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetGuardrailRequest
    {
        /// <summary>
        /// <see cref="gccv::GuardrailName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::GuardrailName GuardrailName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::GuardrailName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGuardrailRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGuardrailRequest
    {
        /// <summary>
        /// <see cref="gccv::GuardrailName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::GuardrailName GuardrailName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::GuardrailName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDeploymentsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDeploymentRequest
    {
        /// <summary>
        /// <see cref="gccv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDeploymentRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDeploymentRequest
    {
        /// <summary>
        /// <see cref="gccv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListToolsetsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetToolsetRequest
    {
        /// <summary>
        /// <see cref="gccv::ToolsetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ToolsetName ToolsetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ToolsetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateToolsetRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteToolsetRequest
    {
        /// <summary>
        /// <see cref="gccv::ToolsetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ToolsetName ToolsetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ToolsetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAppVersionsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAppVersionRequest
    {
        /// <summary>
        /// <see cref="gccv::AppVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AppVersionName AppVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AppVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAppVersionRequest
    {
        /// <summary>
        /// <see cref="gccv::AppVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AppVersionName AppVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AppVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAppVersionRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RestoreAppVersionRequest
    {
        /// <summary>
        /// <see cref="gccv::AppVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AppVersionName AppVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AppVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListChangelogsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetChangelogRequest
    {
        /// <summary>
        /// <see cref="gccv::ChangelogName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ChangelogName ChangelogName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ChangelogName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

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
using gcav = Google.Cloud.AIPlatform.V1Beta1;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    public partial class CreateMetadataStoreRequest
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

    public partial class GetMetadataStoreRequest
    {
        /// <summary>
        /// <see cref="gcav::MetadataStoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::MetadataStoreName MetadataStoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::MetadataStoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMetadataStoresRequest
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

    public partial class DeleteMetadataStoreRequest
    {
        /// <summary>
        /// <see cref="gcav::MetadataStoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::MetadataStoreName MetadataStoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::MetadataStoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateArtifactRequest
    {
        /// <summary>
        /// <see cref="MetadataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MetadataStoreName ParentAsMetadataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MetadataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetArtifactRequest
    {
        /// <summary>
        /// <see cref="gcav::ArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ArtifactName ArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListArtifactsRequest
    {
        /// <summary>
        /// <see cref="MetadataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MetadataStoreName ParentAsMetadataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MetadataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteArtifactRequest
    {
        /// <summary>
        /// <see cref="gcav::ArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ArtifactName ArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PurgeArtifactsRequest
    {
        /// <summary>
        /// <see cref="MetadataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MetadataStoreName ParentAsMetadataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MetadataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PurgeArtifactsResponse
    {
        /// <summary>
        /// <see cref="ArtifactName"/>-typed view over the <see cref="PurgeSample"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ArtifactName> PurgeSampleAsArtifactNames
        {
            get => new gax::ResourceNameList<ArtifactName>(PurgeSample, s => string.IsNullOrEmpty(s) ? null : ArtifactName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class CreateContextRequest
    {
        /// <summary>
        /// <see cref="MetadataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MetadataStoreName ParentAsMetadataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MetadataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetContextRequest
    {
        /// <summary>
        /// <see cref="gcav::ContextName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ContextName ContextName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ContextName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListContextsRequest
    {
        /// <summary>
        /// <see cref="MetadataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MetadataStoreName ParentAsMetadataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MetadataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteContextRequest
    {
        /// <summary>
        /// <see cref="gcav::ContextName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ContextName ContextName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ContextName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PurgeContextsRequest
    {
        /// <summary>
        /// <see cref="MetadataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MetadataStoreName ParentAsMetadataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MetadataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PurgeContextsResponse
    {
        /// <summary>
        /// <see cref="ContextName"/>-typed view over the <see cref="PurgeSample"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ContextName> PurgeSampleAsContextNames
        {
            get => new gax::ResourceNameList<ContextName>(PurgeSample, s => string.IsNullOrEmpty(s) ? null : ContextName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class AddContextArtifactsAndExecutionsRequest
    {
        /// <summary>
        /// <see cref="ContextName"/>-typed view over the <see cref="Context"/> resource name property.
        /// </summary>
        public ContextName ContextAsContextName
        {
            get => string.IsNullOrEmpty(Context) ? null : ContextName.Parse(Context, allowUnparsed: true);
            set => Context = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ArtifactName"/>-typed view over the <see cref="Artifacts"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ArtifactName> ArtifactsAsArtifactNames
        {
            get => new gax::ResourceNameList<ArtifactName>(Artifacts, s => string.IsNullOrEmpty(s) ? null : ArtifactName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="ExecutionName"/>-typed view over the <see cref="Executions"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ExecutionName> ExecutionsAsExecutionNames
        {
            get => new gax::ResourceNameList<ExecutionName>(Executions, s => string.IsNullOrEmpty(s) ? null : ExecutionName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class AddContextChildrenRequest
    {
        /// <summary>
        /// <see cref="ContextName"/>-typed view over the <see cref="Context"/> resource name property.
        /// </summary>
        public ContextName ContextAsContextName
        {
            get => string.IsNullOrEmpty(Context) ? null : ContextName.Parse(Context, allowUnparsed: true);
            set => Context = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ContextName"/>-typed view over the <see cref="ChildContexts"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ContextName> ChildContextsAsContextNames
        {
            get => new gax::ResourceNameList<ContextName>(ChildContexts, s => string.IsNullOrEmpty(s) ? null : ContextName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class RemoveContextChildrenRequest
    {
        /// <summary>
        /// <see cref="ContextName"/>-typed view over the <see cref="Context"/> resource name property.
        /// </summary>
        public ContextName ContextAsContextName
        {
            get => string.IsNullOrEmpty(Context) ? null : ContextName.Parse(Context, allowUnparsed: true);
            set => Context = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ContextName"/>-typed view over the <see cref="ChildContexts"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ContextName> ChildContextsAsContextNames
        {
            get => new gax::ResourceNameList<ContextName>(ChildContexts, s => string.IsNullOrEmpty(s) ? null : ContextName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class QueryContextLineageSubgraphRequest
    {
        /// <summary>
        /// <see cref="ContextName"/>-typed view over the <see cref="Context"/> resource name property.
        /// </summary>
        public ContextName ContextAsContextName
        {
            get => string.IsNullOrEmpty(Context) ? null : ContextName.Parse(Context, allowUnparsed: true);
            set => Context = value?.ToString() ?? "";
        }
    }

    public partial class CreateExecutionRequest
    {
        /// <summary>
        /// <see cref="MetadataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MetadataStoreName ParentAsMetadataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MetadataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetExecutionRequest
    {
        /// <summary>
        /// <see cref="gcav::ExecutionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ExecutionName ExecutionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ExecutionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListExecutionsRequest
    {
        /// <summary>
        /// <see cref="MetadataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MetadataStoreName ParentAsMetadataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MetadataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteExecutionRequest
    {
        /// <summary>
        /// <see cref="gcav::ExecutionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ExecutionName ExecutionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ExecutionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PurgeExecutionsRequest
    {
        /// <summary>
        /// <see cref="MetadataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MetadataStoreName ParentAsMetadataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MetadataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PurgeExecutionsResponse
    {
        /// <summary>
        /// <see cref="ExecutionName"/>-typed view over the <see cref="PurgeSample"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ExecutionName> PurgeSampleAsExecutionNames
        {
            get => new gax::ResourceNameList<ExecutionName>(PurgeSample, s => string.IsNullOrEmpty(s) ? null : ExecutionName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class AddExecutionEventsRequest
    {
        /// <summary>
        /// <see cref="ExecutionName"/>-typed view over the <see cref="Execution"/> resource name property.
        /// </summary>
        public ExecutionName ExecutionAsExecutionName
        {
            get => string.IsNullOrEmpty(Execution) ? null : ExecutionName.Parse(Execution, allowUnparsed: true);
            set => Execution = value?.ToString() ?? "";
        }
    }

    public partial class QueryExecutionInputsAndOutputsRequest
    {
        /// <summary>
        /// <see cref="ExecutionName"/>-typed view over the <see cref="Execution"/> resource name property.
        /// </summary>
        public ExecutionName ExecutionAsExecutionName
        {
            get => string.IsNullOrEmpty(Execution) ? null : ExecutionName.Parse(Execution, allowUnparsed: true);
            set => Execution = value?.ToString() ?? "";
        }
    }

    public partial class CreateMetadataSchemaRequest
    {
        /// <summary>
        /// <see cref="MetadataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MetadataStoreName ParentAsMetadataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MetadataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetMetadataSchemaRequest
    {
        /// <summary>
        /// <see cref="gcav::MetadataSchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::MetadataSchemaName MetadataSchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::MetadataSchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMetadataSchemasRequest
    {
        /// <summary>
        /// <see cref="MetadataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MetadataStoreName ParentAsMetadataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MetadataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class QueryArtifactLineageSubgraphRequest
    {
        /// <summary>
        /// <see cref="ArtifactName"/>-typed view over the <see cref="Artifact"/> resource name property.
        /// </summary>
        public ArtifactName ArtifactAsArtifactName
        {
            get => string.IsNullOrEmpty(Artifact) ? null : ArtifactName.Parse(Artifact, allowUnparsed: true);
            set => Artifact = value?.ToString() ?? "";
        }
    }
}

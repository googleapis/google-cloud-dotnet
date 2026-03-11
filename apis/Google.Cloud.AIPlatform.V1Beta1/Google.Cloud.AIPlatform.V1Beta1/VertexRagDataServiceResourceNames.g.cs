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
using gcav = Google.Cloud.AIPlatform.V1Beta1;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    public partial class CreateRagCorpusRequest
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

    public partial class GetRagCorpusRequest
    {
        /// <summary>
        /// <see cref="gcav::RagCorpusName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::RagCorpusName RagCorpusName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RagCorpusName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRagCorporaRequest
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

    public partial class DeleteRagCorpusRequest
    {
        /// <summary>
        /// <see cref="gcav::RagCorpusName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::RagCorpusName RagCorpusName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RagCorpusName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UploadRagFileRequest
    {
        /// <summary>
        /// <see cref="RagCorpusName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RagCorpusName ParentAsRagCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RagCorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ImportRagFilesRequest
    {
        /// <summary>
        /// <see cref="RagCorpusName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RagCorpusName ParentAsRagCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RagCorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRagFileRequest
    {
        /// <summary>
        /// <see cref="gcav::RagFileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::RagFileName RagFileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RagFileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRagFilesRequest
    {
        /// <summary>
        /// <see cref="RagCorpusName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RagCorpusName ParentAsRagCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RagCorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteRagFileRequest
    {
        /// <summary>
        /// <see cref="gcav::RagFileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::RagFileName RagFileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RagFileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetRagEngineConfigRequest
    {
        /// <summary>
        /// <see cref="gcav::RagEngineConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::RagEngineConfigName RagEngineConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RagEngineConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRagDataSchemaRequest
    {
        /// <summary>
        /// <see cref="RagCorpusName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RagCorpusName ParentAsRagCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RagCorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateRagDataSchemasRequest
    {
        /// <summary>
        /// <see cref="RagCorpusName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RagCorpusName ParentAsRagCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RagCorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRagDataSchemaRequest
    {
        /// <summary>
        /// <see cref="gcav::RagDataSchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::RagDataSchemaName RagDataSchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RagDataSchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRagDataSchemasRequest
    {
        /// <summary>
        /// <see cref="RagCorpusName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RagCorpusName ParentAsRagCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RagCorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeleteRagDataSchemasRequest
    {
        /// <summary>
        /// <see cref="RagCorpusName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RagCorpusName ParentAsRagCorpusName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RagCorpusName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="RagDataSchemaName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<RagDataSchemaName> RagDataSchemaNames
        {
            get => new gax::ResourceNameList<RagDataSchemaName>(Names, s => string.IsNullOrEmpty(s) ? null : RagDataSchemaName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class DeleteRagDataSchemaRequest
    {
        /// <summary>
        /// <see cref="gcav::RagDataSchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::RagDataSchemaName RagDataSchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RagDataSchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRagMetadataRequest
    {
        /// <summary>
        /// <see cref="RagFileName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RagFileName ParentAsRagFileName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RagFileName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateRagMetadataRequest
    {
        /// <summary>
        /// <see cref="RagFileName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RagFileName ParentAsRagFileName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RagFileName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRagMetadataRequest
    {
        /// <summary>
        /// <see cref="gcav::RagMetadataName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::RagMetadataName RagMetadataName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RagMetadataName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRagMetadataRequest
    {
        /// <summary>
        /// <see cref="RagFileName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RagFileName ParentAsRagFileName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RagFileName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteRagMetadataRequest
    {
        /// <summary>
        /// <see cref="gcav::RagMetadataName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::RagMetadataName RagMetadataName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RagMetadataName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeleteRagMetadataRequest
    {
        /// <summary>
        /// <see cref="RagFileName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RagFileName ParentAsRagFileName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RagFileName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="RagMetadataName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<RagMetadataName> RagMetadataNames
        {
            get => new gax::ResourceNameList<RagMetadataName>(Names, s => string.IsNullOrEmpty(s) ? null : RagMetadataName.Parse(s, allowUnparsed: true));
        }
    }
}

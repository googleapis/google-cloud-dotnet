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
}

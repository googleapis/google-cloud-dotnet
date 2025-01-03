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
using gcdv = Google.Cloud.DocumentAI.V1Beta3;

namespace Google.Cloud.DocumentAI.V1Beta3
{
    public partial class ImportDocumentsRequest
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Dataset"/> resource name property.
        /// </summary>
        public DatasetName DatasetAsDatasetName
        {
            get => string.IsNullOrEmpty(Dataset) ? null : DatasetName.Parse(Dataset, allowUnparsed: true);
            set => Dataset = value?.ToString() ?? "";
        }
    }

    public partial class GetDocumentRequest
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Dataset"/> resource name property.
        /// </summary>
        public DatasetName DatasetAsDatasetName
        {
            get => string.IsNullOrEmpty(Dataset) ? null : DatasetName.Parse(Dataset, allowUnparsed: true);
            set => Dataset = value?.ToString() ?? "";
        }
    }

    public partial class ListDocumentsRequest
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Dataset"/> resource name property.
        /// </summary>
        public DatasetName DatasetAsDatasetName
        {
            get => string.IsNullOrEmpty(Dataset) ? null : DatasetName.Parse(Dataset, allowUnparsed: true);
            set => Dataset = value?.ToString() ?? "";
        }
    }

    public partial class GetDatasetSchemaRequest
    {
        /// <summary>
        /// <see cref="gcdv::DatasetSchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DatasetSchemaName DatasetSchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DatasetSchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

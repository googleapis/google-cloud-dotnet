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

namespace Google.Cloud.AIPlatform.V1Beta1
{
    public partial class SearchMigratableResourcesRequest
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

    public partial class BatchMigrateResourcesRequest
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

    public partial class MigrateResourceRequest
    {
        public partial class Types
        {
            public partial class MigrateMlEngineModelVersionConfig
            {
                /// <summary>
                /// <see cref="VersionName"/>-typed view over the <see cref="ModelVersion"/> resource name property.
                /// </summary>
                public VersionName ModelVersionAsVersionName
                {
                    get => string.IsNullOrEmpty(ModelVersion) ? null : VersionName.Parse(ModelVersion, allowUnparsed: true);
                    set => ModelVersion = value?.ToString() ?? "";
                }
            }

            public partial class MigrateAutomlModelConfig
            {
                /// <summary>
                /// <see cref="AutoMLModelName"/>-typed view over the <see cref="Model"/> resource name property.
                /// </summary>
                public AutoMLModelName ModelAsAutoMLModelName
                {
                    get => string.IsNullOrEmpty(Model) ? null : AutoMLModelName.Parse(Model, allowUnparsed: true);
                    set => Model = value?.ToString() ?? "";
                }
            }

            public partial class MigrateAutomlDatasetConfig
            {
                /// <summary>
                /// <see cref="AutoMLDatasetName"/>-typed view over the <see cref="Dataset"/> resource name property.
                /// </summary>
                public AutoMLDatasetName DatasetAsAutoMLDatasetName
                {
                    get => string.IsNullOrEmpty(Dataset) ? null : AutoMLDatasetName.Parse(Dataset, allowUnparsed: true);
                    set => Dataset = value?.ToString() ?? "";
                }
            }

            public partial class MigrateDataLabelingDatasetConfig
            {
                /// <summary>
                /// <see cref="DataLabelingDatasetName"/>-typed view over the <see cref="Dataset"/> resource name
                /// property.
                /// </summary>
                public DataLabelingDatasetName DatasetAsDataLabelingDatasetName
                {
                    get => string.IsNullOrEmpty(Dataset) ? null : DataLabelingDatasetName.Parse(Dataset, allowUnparsed: true);
                    set => Dataset = value?.ToString() ?? "";
                }

                public partial class Types
                {
                    public partial class MigrateDataLabelingAnnotatedDatasetConfig
                    {
                        /// <summary>
                        /// <see cref="AnnotatedDatasetName"/>-typed view over the <see cref="AnnotatedDataset"/>
                        /// resource name property.
                        /// </summary>
                        public AnnotatedDatasetName AnnotatedDatasetAsAnnotatedDatasetName
                        {
                            get => string.IsNullOrEmpty(AnnotatedDataset) ? null : AnnotatedDatasetName.Parse(AnnotatedDataset, allowUnparsed: true);
                            set => AnnotatedDataset = value?.ToString() ?? "";
                        }
                    }
                }
            }
        }
    }

    public partial class MigrateResourceResponse
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Dataset"/> resource name property.
        /// </summary>
        public DatasetName DatasetAsDatasetName
        {
            get => string.IsNullOrEmpty(Dataset) ? null : DatasetName.Parse(Dataset, allowUnparsed: true);
            set => Dataset = value?.ToString() ?? "";
        }

        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Model"/> resource name property.</summary>
        public ModelName ModelAsModelName
        {
            get => string.IsNullOrEmpty(Model) ? null : ModelName.Parse(Model, allowUnparsed: true);
            set => Model = value?.ToString() ?? "";
        }
    }

    public partial class BatchMigrateResourcesOperationMetadata
    {
        public partial class Types
        {
            public partial class PartialResult
            {
                /// <summary>
                /// <see cref="ModelName"/>-typed view over the <see cref="Model"/> resource name property.
                /// </summary>
                public ModelName ModelAsModelName
                {
                    get => string.IsNullOrEmpty(Model) ? null : ModelName.Parse(Model, allowUnparsed: true);
                    set => Model = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="DatasetName"/>-typed view over the <see cref="Dataset"/> resource name property.
                /// </summary>
                public DatasetName DatasetAsDatasetName
                {
                    get => string.IsNullOrEmpty(Dataset) ? null : DatasetName.Parse(Dataset, allowUnparsed: true);
                    set => Dataset = value?.ToString() ?? "";
                }
            }
        }
    }
}

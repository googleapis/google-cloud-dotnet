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
using gmmv = Google.Maps.MapsPlatformDatasets.V1;

namespace Google.Maps.MapsPlatformDatasets.V1
{
    public partial class CreateDatasetRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDatasetRequest
    {
        /// <summary>
        /// <see cref="gmmv::DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmmv::DatasetName DatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmmv::DatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDatasetsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class FetchDatasetErrorsRequest
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

    public partial class DeleteDatasetRequest
    {
        /// <summary>
        /// <see cref="gmmv::DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmmv::DatasetName DatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmmv::DatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

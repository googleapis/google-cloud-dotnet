// Copyright 2021 Google LLC
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

using gagr = Google.Api.Gax.ResourceNames;
using gcav = Google.Cloud.AIPlatform.V1;

namespace Google.Cloud.AIPlatform.V1
{
    public partial class CreateDatasetRequest
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

    public partial class GetDatasetRequest
    {
        /// <summary>
        /// <see cref="gcav::DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DatasetName DatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDatasetsRequest
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

    public partial class DeleteDatasetRequest
    {
        /// <summary>
        /// <see cref="gcav::DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DatasetName DatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportDataRequest
    {
        /// <summary>
        /// <see cref="gcav::DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DatasetName DatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportDataRequest
    {
        /// <summary>
        /// <see cref="gcav::DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DatasetName DatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataItemsRequest
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DatasetName ParentAsDatasetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DatasetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAnnotationSpecRequest
    {
        /// <summary>
        /// <see cref="gcav::AnnotationSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AnnotationSpecName AnnotationSpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AnnotationSpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAnnotationsRequest
    {
        /// <summary>
        /// <see cref="DataItemName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataItemName ParentAsDataItemName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataItemName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}

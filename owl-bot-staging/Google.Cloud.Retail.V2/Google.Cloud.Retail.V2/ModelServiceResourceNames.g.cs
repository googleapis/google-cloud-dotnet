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
using gcrv = Google.Cloud.Retail.V2;

namespace Google.Cloud.Retail.V2
{
    public partial class CreateModelRequest
    {
        /// <summary>
        /// <see cref="CatalogName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CatalogName ParentAsCatalogName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CatalogName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetModelRequest
    {
        /// <summary>
        /// <see cref="gcrv::ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::ModelName ModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::ModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PauseModelRequest
    {
        /// <summary>
        /// <see cref="gcrv::ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::ModelName ModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::ModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListModelsRequest
    {
        /// <summary>
        /// <see cref="CatalogName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CatalogName ParentAsCatalogName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CatalogName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteModelRequest
    {
        /// <summary>
        /// <see cref="gcrv::ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::ModelName ModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::ModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TuneModelRequest
    {
        /// <summary>
        /// <see cref="gcrv::ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::ModelName ModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::ModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

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
using gcdv = Google.Cloud.DiscoveryEngine.V1Beta;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    public partial class CreateEngineRequest
    {
        /// <summary>
        /// <see cref="CollectionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CollectionName ParentAsCollectionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CollectionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEngineRequest
    {
        /// <summary>
        /// <see cref="gcdv::EngineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EngineName EngineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EngineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetEngineRequest
    {
        /// <summary>
        /// <see cref="gcdv::EngineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EngineName EngineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EngineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEnginesRequest
    {
        /// <summary>
        /// <see cref="CollectionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CollectionName ParentAsCollectionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CollectionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PauseEngineRequest
    {
        /// <summary>
        /// <see cref="gcdv::EngineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EngineName EngineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EngineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResumeEngineRequest
    {
        /// <summary>
        /// <see cref="gcdv::EngineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EngineName EngineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EngineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TuneEngineRequest
    {
        /// <summary>
        /// <see cref="gcdv::EngineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EngineName EngineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EngineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TuneEngineMetadata
    {
        /// <summary><see cref="EngineName"/>-typed view over the <see cref="Engine"/> resource name property.</summary>
        public EngineName EngineAsEngineName
        {
            get => string.IsNullOrEmpty(Engine) ? null : EngineName.Parse(Engine, allowUnparsed: true);
            set => Engine = value?.ToString() ?? "";
        }
    }
}

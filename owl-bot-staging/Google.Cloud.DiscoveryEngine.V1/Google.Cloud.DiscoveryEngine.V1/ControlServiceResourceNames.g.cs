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
using gax = Google.Api.Gax;
using gcdv = Google.Cloud.DiscoveryEngine.V1;

namespace Google.Cloud.DiscoveryEngine.V1
{
    public partial class CreateControlRequest
    {
        /// <summary><see cref="EngineName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public EngineName ParentAsEngineName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EngineName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStoreName ParentAsDataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (EngineName.TryParse(Parent, out EngineName engine))
                {
                    return engine;
                }
                if (DataStoreName.TryParse(Parent, out DataStoreName dataStore))
                {
                    return dataStore;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteControlRequest
    {
        /// <summary>
        /// <see cref="gcdv::ControlName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ControlName ControlName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ControlName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetControlRequest
    {
        /// <summary>
        /// <see cref="gcdv::ControlName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ControlName ControlName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ControlName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListControlsRequest
    {
        /// <summary><see cref="EngineName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public EngineName ParentAsEngineName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EngineName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStoreName ParentAsDataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (EngineName.TryParse(Parent, out EngineName engine))
                {
                    return engine;
                }
                if (DataStoreName.TryParse(Parent, out DataStoreName dataStore))
                {
                    return dataStore;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }
}

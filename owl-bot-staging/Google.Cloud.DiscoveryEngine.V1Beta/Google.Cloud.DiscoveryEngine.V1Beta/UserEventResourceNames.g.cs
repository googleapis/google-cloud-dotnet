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
using gcdv = Google.Cloud.DiscoveryEngine.V1Beta;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    public partial class UserEvent
    {
        /// <summary><see cref="EngineName"/>-typed view over the <see cref="Engine"/> resource name property.</summary>
        public EngineName EngineAsEngineName
        {
            get => string.IsNullOrEmpty(Engine) ? null : EngineName.Parse(Engine, allowUnparsed: true);
            set => Engine = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="DataStore"/> resource name property.
        /// </summary>
        public DataStoreName DataStoreAsDataStoreName
        {
            get => string.IsNullOrEmpty(DataStore) ? null : DataStoreName.Parse(DataStore, allowUnparsed: true);
            set => DataStore = value?.ToString() ?? "";
        }
    }

    public partial class DocumentInfo
    {
        /// <summary>
        /// <see cref="gcdv::DocumentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DocumentName DocumentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DocumentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

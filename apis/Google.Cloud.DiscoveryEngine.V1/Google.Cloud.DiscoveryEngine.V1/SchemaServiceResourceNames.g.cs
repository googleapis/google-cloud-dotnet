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
using gcdv = Google.Cloud.DiscoveryEngine.V1;

namespace Google.Cloud.DiscoveryEngine.V1
{
    public partial class GetSchemaRequest
    {
        /// <summary>
        /// <see cref="gcdv::SchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SchemaName SchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSchemasRequest
    {
        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStoreName ParentAsDataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateSchemaRequest
    {
        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStoreName ParentAsDataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSchemaRequest
    {
        /// <summary>
        /// <see cref="gcdv::SchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SchemaName SchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

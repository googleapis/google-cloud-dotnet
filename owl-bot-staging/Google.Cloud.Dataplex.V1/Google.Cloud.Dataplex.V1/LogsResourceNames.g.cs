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

namespace Google.Cloud.Dataplex.V1
{
    public partial class GovernanceEvent
    {
        public partial class Types
        {
            public partial class Entity
            {
                /// <summary>
                /// <see cref="EntityName"/>-typed view over the <see cref="Entity_"/> resource name property.
                /// </summary>
                public EntityName Entity_AsEntityName
                {
                    get => string.IsNullOrEmpty(Entity_) ? null : EntityName.Parse(Entity_, allowUnparsed: true);
                    set => Entity_ = value?.ToString() ?? "";
                }
            }
        }
    }
}

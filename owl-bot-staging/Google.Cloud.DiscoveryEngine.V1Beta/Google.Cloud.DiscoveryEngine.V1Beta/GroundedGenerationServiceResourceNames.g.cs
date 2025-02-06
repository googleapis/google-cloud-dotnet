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

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    public partial class GenerateGroundedContentRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Location"/> resource name property.
        /// </summary>
        public LocationName LocationAsLocationName
        {
            get => string.IsNullOrEmpty(Location) ? null : LocationName.Parse(Location, allowUnparsed: true);
            set => Location = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class GroundingSource
            {
                public partial class Types
                {
                    public partial class SearchSource
                    {
                        /// <summary>
                        /// <see cref="ServingConfigName"/>-typed view over the <see cref="ServingConfig"/> resource
                        /// name property.
                        /// </summary>
                        public ServingConfigName ServingConfigAsServingConfigName
                        {
                            get => string.IsNullOrEmpty(ServingConfig) ? null : ServingConfigName.Parse(ServingConfig, allowUnparsed: true);
                            set => ServingConfig = value?.ToString() ?? "";
                        }
                    }
                }
            }
        }
    }

    public partial class CheckGroundingRequest
    {
        /// <summary>
        /// <see cref="GroundingConfigName"/>-typed view over the <see cref="GroundingConfig"/> resource name property.
        /// </summary>
        public GroundingConfigName GroundingConfigAsGroundingConfigName
        {
            get => string.IsNullOrEmpty(GroundingConfig) ? null : GroundingConfigName.Parse(GroundingConfig, allowUnparsed: true);
            set => GroundingConfig = value?.ToString() ?? "";
        }
    }
}

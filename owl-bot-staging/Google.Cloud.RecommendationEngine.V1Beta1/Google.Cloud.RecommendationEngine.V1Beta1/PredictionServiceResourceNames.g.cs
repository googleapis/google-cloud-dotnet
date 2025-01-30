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
using gcrv = Google.Cloud.RecommendationEngine.V1Beta1;

namespace Google.Cloud.RecommendationEngine.V1Beta1
{
    public partial class PredictRequest
    {
        /// <summary>
        /// <see cref="gcrv::PlacementName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::PlacementName PlacementName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::PlacementName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

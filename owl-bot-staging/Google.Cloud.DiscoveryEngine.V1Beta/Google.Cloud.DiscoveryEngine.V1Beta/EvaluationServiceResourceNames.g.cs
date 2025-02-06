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
    public partial class GetEvaluationRequest
    {
        /// <summary>
        /// <see cref="gcdv::EvaluationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EvaluationName EvaluationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EvaluationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEvaluationsRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateEvaluationRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListEvaluationResultsRequest
    {
        /// <summary>
        /// <see cref="EvaluationName"/>-typed view over the <see cref="Evaluation"/> resource name property.
        /// </summary>
        public EvaluationName EvaluationAsEvaluationName
        {
            get => string.IsNullOrEmpty(Evaluation) ? null : EvaluationName.Parse(Evaluation, allowUnparsed: true);
            set => Evaluation = value?.ToString() ?? "";
        }
    }
}

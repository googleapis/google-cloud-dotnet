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
    public partial class GetSampleQueryRequest
    {
        /// <summary>
        /// <see cref="gcdv::SampleQueryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SampleQueryName SampleQueryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SampleQueryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSampleQueriesRequest
    {
        /// <summary>
        /// <see cref="SampleQuerySetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SampleQuerySetName ParentAsSampleQuerySetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SampleQuerySetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateSampleQueryRequest
    {
        /// <summary>
        /// <see cref="SampleQuerySetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SampleQuerySetName ParentAsSampleQuerySetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SampleQuerySetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSampleQueryRequest
    {
        /// <summary>
        /// <see cref="gcdv::SampleQueryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SampleQueryName SampleQueryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SampleQueryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

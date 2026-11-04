// Copyright 2026 Google LLC
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

namespace Google.Cloud.Sql.V1Beta4
{
    public partial class WorkloadCapture
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="SourceInstance"/> resource name property.
        /// </summary>
        public InstanceName SourceInstanceAsInstanceName
        {
            get => string.IsNullOrEmpty(SourceInstance) ? null : InstanceName.Parse(SourceInstance, allowUnparsed: true);
            set => SourceInstance = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="ReplayInstance"/> resource name property.
        /// </summary>
        public InstanceName ReplayInstanceAsInstanceName
        {
            get => string.IsNullOrEmpty(ReplayInstance) ? null : InstanceName.Parse(ReplayInstance, allowUnparsed: true);
            set => ReplayInstance = value?.ToString() ?? "";
        }
    }
}

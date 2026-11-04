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
    public partial class StreamSqlDataRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="InstanceId"/> resource name property.
        /// </summary>
        public InstanceName InstanceIdAsInstanceName
        {
            get => string.IsNullOrEmpty(InstanceId) ? null : InstanceName.Parse(InstanceId, allowUnparsed: true);
            set => InstanceId = value?.ToString() ?? "";
        }
    }

    public partial class StartSession
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="InstanceId"/> resource name property.
        /// </summary>
        public InstanceName InstanceIdAsInstanceName
        {
            get => string.IsNullOrEmpty(InstanceId) ? null : InstanceName.Parse(InstanceId, allowUnparsed: true);
            set => InstanceId = value?.ToString() ?? "";
        }
    }

    public partial class ContinueSession
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="InstanceId"/> resource name property.
        /// </summary>
        public InstanceName InstanceIdAsInstanceName
        {
            get => string.IsNullOrEmpty(InstanceId) ? null : InstanceName.Parse(InstanceId, allowUnparsed: true);
            set => InstanceId = value?.ToString() ?? "";
        }
    }
}

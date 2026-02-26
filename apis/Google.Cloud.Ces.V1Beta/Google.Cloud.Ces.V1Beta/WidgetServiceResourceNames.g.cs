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
using gccv = Google.Cloud.Ces.V1Beta;

namespace Google.Cloud.Ces.V1Beta
{
    public partial class GenerateChatTokenRequest
    {
        /// <summary>
        /// <see cref="gccv::SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::SessionName SessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::SessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DeploymentName"/>-typed view over the <see cref="Deployment"/> resource name property.
        /// </summary>
        public DeploymentName DeploymentAsDeploymentName
        {
            get => string.IsNullOrEmpty(Deployment) ? null : DeploymentName.Parse(Deployment, allowUnparsed: true);
            set => Deployment = value?.ToString() ?? "";
        }
    }
}

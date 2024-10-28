// Copyright 2024 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using gcvv = Google.Cloud.VisionAI.V1;

namespace Google.Cloud.VisionAI.V1
{
    public partial class ListOperatorsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetOperatorRequest
    {
        /// <summary>
        /// <see cref="gcvv::OperatorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::OperatorName OperatorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::OperatorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateOperatorRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteOperatorRequest
    {
        /// <summary>
        /// <see cref="gcvv::OperatorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::OperatorName OperatorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::OperatorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAnalysesRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ClusterName ParentAsClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAnalysisRequest
    {
        /// <summary>
        /// <see cref="gcvv::AnalysisName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AnalysisName AnalysisName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AnalysisName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAnalysisRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ClusterName ParentAsClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAnalysisRequest
    {
        /// <summary>
        /// <see cref="gcvv::AnalysisName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AnalysisName AnalysisName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AnalysisName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListProcessesRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ClusterName ParentAsClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetProcessRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProcessName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProcessName ProcessName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProcessName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateProcessRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ClusterName ParentAsClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteProcessRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProcessName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProcessName ProcessName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProcessName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchRunProcessRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ClusterName ParentAsClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ResolveOperatorInfoRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListPublicOperatorsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}

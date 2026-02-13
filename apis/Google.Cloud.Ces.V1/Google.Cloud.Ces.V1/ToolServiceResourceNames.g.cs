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

namespace Google.Cloud.Ces.V1
{
    public partial class ExecuteToolRequest
    {
        /// <summary><see cref="ToolName"/>-typed view over the <see cref="Tool"/> resource name property.</summary>
        public ToolName ToolAsToolName
        {
            get => string.IsNullOrEmpty(Tool) ? null : ToolName.Parse(Tool, allowUnparsed: true);
            set => Tool = value?.ToString() ?? "";
        }

        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ExecuteToolResponse
    {
        /// <summary><see cref="ToolName"/>-typed view over the <see cref="Tool"/> resource name property.</summary>
        public ToolName ToolAsToolName
        {
            get => string.IsNullOrEmpty(Tool) ? null : ToolName.Parse(Tool, allowUnparsed: true);
            set => Tool = value?.ToString() ?? "";
        }
    }

    public partial class RetrieveToolSchemaRequest
    {
        /// <summary><see cref="ToolName"/>-typed view over the <see cref="Tool"/> resource name property.</summary>
        public ToolName ToolAsToolName
        {
            get => string.IsNullOrEmpty(Tool) ? null : ToolName.Parse(Tool, allowUnparsed: true);
            set => Tool = value?.ToString() ?? "";
        }

        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RetrieveToolSchemaResponse
    {
        /// <summary><see cref="ToolName"/>-typed view over the <see cref="Tool"/> resource name property.</summary>
        public ToolName ToolAsToolName
        {
            get => string.IsNullOrEmpty(Tool) ? null : ToolName.Parse(Tool, allowUnparsed: true);
            set => Tool = value?.ToString() ?? "";
        }
    }

    public partial class RetrieveToolsRequest
    {
        /// <summary>
        /// <see cref="ToolsetName"/>-typed view over the <see cref="Toolset"/> resource name property.
        /// </summary>
        public ToolsetName ToolsetAsToolsetName
        {
            get => string.IsNullOrEmpty(Toolset) ? null : ToolsetName.Parse(Toolset, allowUnparsed: true);
            set => Toolset = value?.ToString() ?? "";
        }
    }
}

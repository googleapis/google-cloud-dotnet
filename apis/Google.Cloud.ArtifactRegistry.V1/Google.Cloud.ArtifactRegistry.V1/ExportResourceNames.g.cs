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
using gcav = Google.Cloud.ArtifactRegistry.V1;

namespace Google.Cloud.ArtifactRegistry.V1
{
    public partial class ExportArtifactRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Repository"/> resource name property.
        /// </summary>
        public RepositoryName RepositoryAsRepositoryName
        {
            get => string.IsNullOrEmpty(Repository) ? null : RepositoryName.Parse(Repository, allowUnparsed: true);
            set => Repository = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VersionName"/>-typed view over the <see cref="SourceVersion"/> resource name property.
        /// </summary>
        public VersionName SourceVersionAsVersionName
        {
            get => string.IsNullOrEmpty(SourceVersion) ? null : VersionName.Parse(SourceVersion, allowUnparsed: true);
            set => SourceVersion = value?.ToString() ?? "";
        }

        /// <summary><see cref="TagName"/>-typed view over the <see cref="SourceTag"/> resource name property.</summary>
        public TagName SourceTagAsTagName
        {
            get => string.IsNullOrEmpty(SourceTag) ? null : TagName.Parse(SourceTag, allowUnparsed: true);
            set => SourceTag = value?.ToString() ?? "";
        }
    }

    public partial class ExportArtifactMetadata
    {
        public partial class Types
        {
            public partial class ExportedFile
            {
                /// <summary>
                /// <see cref="gcav::FileName"/>-typed view over the <see cref="Name"/> resource name property.
                /// </summary>
                public gcav::FileName FileName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gcav::FileName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }
            }
        }
    }
}

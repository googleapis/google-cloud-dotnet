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
    public partial class SearchRequest
    {
        /// <summary>
        /// <see cref="ServingConfigName"/>-typed view over the <see cref="ServingConfig"/> resource name property.
        /// </summary>
        public ServingConfigName ServingConfigAsServingConfigName
        {
            get => string.IsNullOrEmpty(ServingConfig) ? null : ServingConfigName.Parse(ServingConfig, allowUnparsed: true);
            set => ServingConfig = value?.ToString() ?? "";
        }

        /// <summary><see cref="BranchName"/>-typed view over the <see cref="Branch"/> resource name property.</summary>
        public BranchName BranchAsBranchName
        {
            get => string.IsNullOrEmpty(Branch) ? null : BranchName.Parse(Branch, allowUnparsed: true);
            set => Branch = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class DataStoreSpec
            {
                /// <summary>
                /// <see cref="DataStoreName"/>-typed view over the <see cref="DataStore"/> resource name property.
                /// </summary>
                public DataStoreName DataStoreAsDataStoreName
                {
                    get => string.IsNullOrEmpty(DataStore) ? null : DataStoreName.Parse(DataStore, allowUnparsed: true);
                    set => DataStore = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class SearchResponse
    {
        public partial class Types
        {
            public partial class Summary
            {
                public partial class Types
                {
                    public partial class Reference
                    {
                        /// <summary>
                        /// <see cref="DocumentName"/>-typed view over the <see cref="Document"/> resource name
                        /// property.
                        /// </summary>
                        public DocumentName DocumentAsDocumentName
                        {
                            get => string.IsNullOrEmpty(Document) ? null : DocumentName.Parse(Document, allowUnparsed: true);
                            set => Document = value?.ToString() ?? "";
                        }
                    }
                }
            }
        }
    }
}
